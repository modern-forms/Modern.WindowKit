// Copyright (c) The Avalonia Project. All rights reserved.
// Licensed under the MIT license. See licence.md file in the project root for full license information.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using Modern.WindowKit.Controls;
using Modern.WindowKit.Controls.Platform;
using Modern.WindowKit.Input;
using Modern.WindowKit.Input.Raw;
using Modern.WindowKit.Win32.Input;
using static Modern.WindowKit.Win32.Interop.UnmanagedMethods;

namespace Modern.WindowKit.Win32
{
    public partial class WindowImpl
    {
        protected virtual unsafe IntPtr WndProc(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam)
        {
            IntPtr lRet = IntPtr.Zero;
            bool callDwp = true;

            if (_isClientAreaExtended)
            {
                //lRet = CustomCaptionProc(hWnd, msg, wParam, lParam, ref callDwp);
            }

            if (callDwp)
            {
                lRet = AppWndProc(hWnd, msg, wParam, lParam);
            }

            return lRet;
        }
        
        //public INativeControlHostImpl NativeControlHost => _nativeControlHost;

        protected virtual bool ShouldTakeFocusOnClick => true;
    }
}
