using Modern.WindowKit.Platform;

namespace Modern.WindowKit.Native
{
    internal partial class WindowImpl
    {
        public override IPopupImpl CreatePopup() =>
            _opts.OverlayPopups ? null : new PopupImpl(_factory, _opts, this);

        public void ShowDialog(IWindowImpl window)
        {
            _native.Show(true.AsComBool(), true.AsComBool());
        }

        public void SetIcon(SkiaSharp.SKBitmap? icon)
        {
            // NO OP on OSX
        }

        public void SetSystemDecorations(SystemDecorations enabled)
        {
            _native.SetDecorations((Modern.WindowKit.Mac.Interop.SystemDecorations)enabled);
        }
    }
}
