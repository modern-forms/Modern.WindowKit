using System;

namespace Modern.WindowKit.Platform
{
    public interface IMacOSTopLevelPlatformHandle
    {
        IntPtr NSView { get; }
        IntPtr GetNSViewRetained();
        IntPtr NSWindow { get; }
        IntPtr GetNSWindowRetained();
    }
}
