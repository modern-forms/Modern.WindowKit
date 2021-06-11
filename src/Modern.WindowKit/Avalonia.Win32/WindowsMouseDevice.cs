#nullable disable

// Copyright (c) The Avalonia Project. All rights reserved.
// Licensed under the MIT license. See licence.md file in the project root for full license information.

using System;
using Modern.WindowKit.Controls;
using Modern.WindowKit.Input;
//using Modern.WindowKit.VisualTree;
using Modern.WindowKit.Win32.Interop;

namespace Modern.WindowKit.Win32.Input
{
    class WindowsMouseDevice : MouseDevice
    {
        public WindowsMouseDevice() : base(new WindowsMousePointer())
        {
            
        }
        
        class WindowsMousePointer : Pointer
        {
            public WindowsMousePointer() : base(Pointer.GetNextFreeId(),PointerType.Mouse, true)
            {
            }

            //protected override void PlatformCapture(IInputElement element)
            //{
            //    var hwnd = ((element?.GetVisualRoot() as TopLevel)?.PlatformImpl as WindowImpl)
            //        ?.Handle.Handle;

            //    if (hwnd.HasValue && hwnd != IntPtr.Zero)
            //        UnmanagedMethods.SetCapture(hwnd.Value);
            //    else
            //        UnmanagedMethods.ReleaseCapture();
            //}
        }

        public static WindowsMouseDevice Instance { get; } = new WindowsMouseDevice();
        
        public WindowImpl CurrentWindow
        {
            get;
            set;
        }
    }
}
