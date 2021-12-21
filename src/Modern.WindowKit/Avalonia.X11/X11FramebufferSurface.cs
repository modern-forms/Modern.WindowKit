using System;
using Modern.WindowKit.Controls.Platform.Surfaces;
using Modern.WindowKit.Platform;
using static Modern.WindowKit.X11.XLib;
namespace Modern.WindowKit.X11
{
    public class X11FramebufferSurface : IFramebufferPlatformSurface
    {
        private readonly IntPtr _display;
        private readonly IntPtr _xid;
        private readonly int _depth;
        private readonly Func<double> _scaling;

        public X11FramebufferSurface(IntPtr display, IntPtr xid, int depth, Func<double> scaling)
        {
            _display = display;
            _xid = xid;
            _depth = depth;
            _scaling = scaling;
        }
        
        public ILockedFramebuffer Lock()
        {
            XLockDisplay(_display);
            XGetGeometry(_display, _xid, out var root, out var x, out var y, out var width, out var height,
                out var bw, out var d);
            XUnlockDisplay(_display);
            return new X11Framebuffer(_display, _xid, _depth, width, height, _scaling());
        }
    }
}
