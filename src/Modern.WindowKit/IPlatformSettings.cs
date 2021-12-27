using System;

namespace Modern.WindowKit.Platform
{
    public interface IPlatformSettings
    {
        Size DoubleClickSize { get; }

        TimeSpan DoubleClickTime { get; }
    }
}
