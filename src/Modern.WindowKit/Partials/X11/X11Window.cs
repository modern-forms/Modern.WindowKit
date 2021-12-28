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
            //if (icon != null)
            //{
            //    var data = ((X11IconData)icon).Data;
            //    fixed (void* pdata = data)
            //        XChangeProperty(_x11.Display, _handle, _x11.Atoms._NET_WM_ICON,
            //            new IntPtr((int)Atom.XA_CARDINAL), 32, PropertyMode.Replace,
            //            pdata, data.Length);
            //}
            //else
            //{
            //    XDeleteProperty(_x11.Display, _handle, _x11.Atoms._NET_WM_ICON);
            //}
        }
    }
}
