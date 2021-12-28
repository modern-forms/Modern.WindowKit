using Modern.WindowKit;
using Modern.WindowKit.Platform;
using Modern.WindowKit.Threading;

public class Program
{
    static void Main(string[] args)
    {
        var window = AvaloniaGlobals.GetRequiredService<IWindowingPlatform>().CreateWindow();
        window.Show(true, false);
        var _mainLoopCancellationTokenSource = new CancellationTokenSource();

        Dispatcher.UIThread.MainLoop(_mainLoopCancellationTokenSource.Token);

        //window.ShowDialog(null);
    }
}
