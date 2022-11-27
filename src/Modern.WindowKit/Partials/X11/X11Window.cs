using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modern.WindowKit.Platform;
using Modern.WindowKit.Threading;
using static Modern.WindowKit.X11.XLib;

namespace Modern.WindowKit.X11
{
    unsafe partial class X11Window
    {
        private bool _invalidated;
        private object? glfeature = null;

        void DoPaint()
        {
            _invalidated = false;
            Paint?.Invoke(new Rect());
        }

        public void Invalidate(Rect rect)
        {
            if (_invalidated)

                return;
            _invalidated = true;
            Dispatcher.UIThread.InvokeAsync(() =>
            {
                if (_mapped)
                    DoPaint();
            });
        }

        public void ShowDialog(IWindowImpl parent)
        {
            Show(true, true);
        }

        public void SetIcon(SkiaSharp.SKBitmap? icon)
        {
            if (icon is not null)
            {
                var data = new UIntPtr[icon.Width * icon.Height + 2];
                data[0] = new UIntPtr((uint)icon.Width);
                data[1] = new UIntPtr((uint)icon.Height);
                icon.Pixels.Select(p => new UIntPtr((uint)p)).ToArray().CopyTo(data, 2);

                fixed (void* pdata = data)
                    XChangeProperty(_x11.Display, _handle, _x11.Atoms._NET_WM_ICON,
                        new IntPtr((int)Atom.XA_CARDINAL), 32, PropertyMode.Replace,
                        pdata, data.Length);
            }
            else
            {
                XDeleteProperty(_x11.Display, _handle, _x11.Atoms._NET_WM_ICON);
            }
        }
    }
}
