using System;
using Modern.WindowKit.Metadata;

namespace Modern.WindowKit.Platform
{
    [Unstable]
    public interface IPlatformNativeSurfaceHandle : IPlatformHandle
    {
        PixelSize Size { get; }
        double Scaling { get; }
    }
}
