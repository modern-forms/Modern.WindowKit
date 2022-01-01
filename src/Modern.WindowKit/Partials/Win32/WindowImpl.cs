using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modern.WindowKit.Win32.Interop;

namespace Modern.WindowKit.Win32
{
    public partial class WindowImpl
    {
        public IEnumerable<object> Surfaces => new object[] { Handle, /* _gl, */ _framebuffer };

        public void SetIcon(SkiaSharp.SKBitmap? icon)
        {
            if (icon == null)
            {
                UnmanagedMethods.PostMessage(_hwnd, (int)UnmanagedMethods.WindowsMessage.WM_SETICON,
                    new IntPtr((int)UnmanagedMethods.Icons.ICON_BIG), IntPtr.Zero);

                return;
            }

            using var icon2 = icon.ToBitmap();

            UnmanagedMethods.PostMessage(_hwnd, (int)UnmanagedMethods.WindowsMessage.WM_SETICON,
                new IntPtr((int)UnmanagedMethods.Icons.ICON_BIG), icon2.GetHicon());
        }
    }
}
