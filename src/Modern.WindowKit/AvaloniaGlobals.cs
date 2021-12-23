using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using Modern.WindowKit.Controls.Platform;
using Modern.WindowKit.Input.Platform;
using Modern.WindowKit.Platform;
using Modern.WindowKit.Shared.PlatformSupport;
using Modern.WindowKit.Win32;
using Modern.WindowKit.X11;

namespace Modern.WindowKit
{
    public static class AvaloniaGlobals
    {
        public static IRuntimePlatform RuntimePlatform { get; }

        // These are always initialized to non-null but not in the constructor so the compiler doesn't see them.
        public static IPlatformThreadingInterface PlatformThreadingInterface { get; private set; }
        public static IWindowingPlatform WindowingInterface { get; private set; } = default!;
        public static ICursorFactory StandardCursorFactory { get; private set; } = default!;
        public static ISystemDialogImpl SystemDialogImplementation { get; private set; } = default!;
        public static IClipboard ClipboardInterface { get; private set; } = default!;

        static AvaloniaGlobals()
        {
            RuntimePlatform = new StandardRuntimePlatform();

            var runtime = RuntimePlatform.GetRuntimeInfo();

            if (runtime.OperatingSystem == OperatingSystemType.WinNT)
                InitializeWindows();
            else if (runtime.OperatingSystem == OperatingSystemType.Linux)
                InitializeLinux();
            else if (runtime.OperatingSystem == OperatingSystemType.OSX)
                InitializeOSX();
            else
                throw new InvalidOperationException("Unrecognized Operating System");
        }

        [MemberNotNull(nameof(PlatformThreadingInterface))]
        private static void InitializeLinux()
        {
            var x11 = new AvaloniaX11Platform();
            x11.Initialize(new X11PlatformOptions());

            WindowingInterface = x11;
            PlatformThreadingInterface = new X11PlatformThreading(x11);
            StandardCursorFactory = new X11CursorFactory(x11.Display);
            SystemDialogImplementation = new X11.NativeDialogs.GtkSystemDialog();
            ClipboardInterface = new X11Clipboard(x11);
        }

        [MemberNotNull(nameof(PlatformThreadingInterface))]
        private static void InitializeOSX()
        {
            var platform = Native.AvaloniaNativePlatform.Initialize();

            WindowingInterface = platform;
            PlatformThreadingInterface = new Native.PlatformThreadingInterface(platform.Factory.CreatePlatformThreadingInterface());
            StandardCursorFactory = new Native.CursorFactory(platform.Factory.CreateCursorFactory());
            SystemDialogImplementation = new Native.SystemDialogs(platform.Factory.CreateSystemDialogs());
            ClipboardInterface = new Native.ClipboardImpl(platform.Factory.CreateClipboard());
        }

        [MemberNotNull(nameof(PlatformThreadingInterface))]
        private static void InitializeWindows()
        {
            Win32Platform.Initialize();

            PlatformThreadingInterface = Win32Platform.Instance;
            WindowingInterface = Win32Platform.Instance;
            StandardCursorFactory = CursorFactory.Instance;
            SystemDialogImplementation = new SystemDialogImpl();
            ClipboardInterface = new ClipboardImpl();
        }
    }
}
