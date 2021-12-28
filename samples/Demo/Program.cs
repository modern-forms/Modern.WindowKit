using Modern.WindowKit;
using Modern.WindowKit.Controls.Platform.Surfaces;
using Modern.WindowKit.Input.Raw;
using Modern.WindowKit.Platform;
using Modern.WindowKit.Skia;
using Modern.WindowKit.Threading;
using SkiaSharp;

namespace Demo;

public class Program
{
    private static IWindowImpl window = null!;
    private static SKSurface? canvas;
    private static SKColor? draw_color;
    private static Point? cursor_position;
    private static bool show_diagnostics = true;

    private static void Main()
    {
        // Create a native window
        window = AvaloniaGlobals.GetRequiredService<IWindowingPlatform>().CreateWindow();
        window.Resize(new Size(1024, 768));
        window.SetTitle("Modern.WindowKit Demo");

        // When the window is closed, stop our message loop
        var _mainLoopCancellationTokenSource = new CancellationTokenSource();
        window.Closed = () => _mainLoopCancellationTokenSource?.Cancel();

        // On resize, destroy our canvas so a new one will get created with the proper size
        window.Resized = (s, r) => { canvas?.Dispose(); canvas = null; };

        // Redraw if moved to update diagnostics
        window.PositionChanged = (p) => Invalidate();

        // Handle painting the window
        window.Paint = DoPaint;

        // Handle input
        window.Input = HandleInput;

        // Show the window
        window.Show(true, false);

        // Begin the message loop
        Dispatcher.UIThread.MainLoop(_mainLoopCancellationTokenSource.Token);
    }

    private static SKSurface GetCanvas()
    {
        if (canvas is not null)
            return canvas;

        var screen = window.ClientSize * window.RenderScaling;
        var info = new SKImageInfo((int)screen.Width, (int)screen.Height);

        canvas = SKSurface.Create(info);
        canvas.Canvas.Clear(SKColors.CornflowerBlue);

        return canvas;
    }

    private static void DoPaint(Rect bounds)
    {
        // Get the framebuffer for the window
        var skia_framebuffer = window.Surfaces.OfType<IFramebufferPlatformSurface>().First();

        using var framebuffer = skia_framebuffer.Lock();

        var framebufferImageInfo = new SKImageInfo(framebuffer.Size.Width, framebuffer.Size.Height,
            framebuffer.Format.ToSkColorType(), framebuffer.Format == PixelFormat.Rgb565 ? SKAlphaType.Opaque : SKAlphaType.Premul);

        // Wrap the framebuffer in a Skia canvas
        using var surface = SKSurface.Create(framebufferImageInfo, framebuffer.Address, framebuffer.RowBytes);

        // Draw our stored canvas onto the window
        surface.Canvas.DrawSurface(GetCanvas(), SKPoint.Empty);

        if (show_diagnostics)
            OutputDiagnostics(surface.Canvas);
    }

    private static void HandleInput(RawInputEventArgs obj)
    {
        if (obj is RawPointerEventArgs pointer)
            HandleMouseInput(pointer);
        else if (obj is RawKeyEventArgs key)
            HandleKeyboardInput(key);
    }

    private static void HandleMouseInput(RawPointerEventArgs e)
    {
        if (e.Type == RawPointerEventType.LeftButtonDown)
            draw_color = SKColors.Red;
        else if (e.Type == RawPointerEventType.RightButtonDown)
            draw_color = SKColors.Green;
        else if (e.Type == RawPointerEventType.LeftButtonUp || e.Type == RawPointerEventType.RightButtonUp)
            draw_color = null;
        else if (e.Type == RawPointerEventType.Move && draw_color.HasValue)
        {
            var radius = 5;
            var paint = new SKPaint { Color = draw_color.Value, IsStroke = false };
            GetCanvas().Canvas.DrawCircle(e.Position.ToSKPoint(), radius, paint);
        }

        if (e.Type == RawPointerEventType.LeaveWindow)
            cursor_position = null;
        else if (e.Type == RawPointerEventType.Move)
            cursor_position = e.Position;

        Invalidate();
    }

    private static void HandleKeyboardInput(RawKeyEventArgs e)
    {
        // Use F1 key to toggle diagnostics
        if (e.Type == RawKeyEventType.KeyUp && e.Key == Modern.WindowKit.Input.Key.F1)
            show_diagnostics = !show_diagnostics;

        Invalidate();
    }

    private static void Invalidate() => window.Invalidate(new Rect(Point.Empty, window.ClientSize));


    private static void OutputDiagnostics(SKCanvas canvas)
    {
        var paint = new SKPaint { Color = SKColors.Black, IsAntialias = true, TextSize = 16, SubpixelText = true, Typeface = SKTypeface.FromFamilyName(SKTypeface.Default.FamilyName, SKFontStyleWeight.SemiBold, SKFontStyleWidth.Normal, SKFontStyleSlant.Upright) };

        var y = 0;
        canvas.DrawText($"ClientSize - {window.ClientSize}", 10, y += 25, paint);
        canvas.DrawText($"DesktopScaling - {window.DesktopScaling}", 10, y += 25, paint);
        canvas.DrawText($"ExtendedMargins - {window.ExtendedMargins}", 10, y += 25, paint);
        canvas.DrawText($"FrameSize - {window.FrameSize}", 10, y += 25, paint);
        canvas.DrawText($"IsClientAreaExtendedToDecorations - {window.IsClientAreaExtendedToDecorations}", 10, y += 25, paint);
        canvas.DrawText($"MaxAutoSizeHint - {window.MaxAutoSizeHint}", 10, y += 25, paint);
        canvas.DrawText($"NeedsManagedDecorations - {window.NeedsManagedDecorations}", 10, y += 25, paint);
        canvas.DrawText($"OffScreenMargin - {window.OffScreenMargin}", 10, y += 25, paint);
        canvas.DrawText($"Position - {window.Position}", 10, y += 25, paint);
        canvas.DrawText($"RenderScaling - {window.RenderScaling}", 10, y += 25, paint);
        canvas.DrawText($"TransparencyLevel - {window.TransparencyLevel}", 10, y += 25, paint);
        canvas.DrawText($"WindowState - {window.WindowState}", 10, y += 25, paint);

        y = (int)window.ClientSize.Height - 45;

        if (cursor_position.HasValue)
            canvas.DrawText($"Cursor Position - {cursor_position}", 10, y += 25, paint);
    }
}
