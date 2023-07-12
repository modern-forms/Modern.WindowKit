using System;
using System.Threading;
using Modern.WindowKit.Compatibility;
using Modern.WindowKit.Metadata;
using Modern.WindowKit.Platform.Internal;

namespace Modern.WindowKit.Platform
{
    [PrivateApi]
    internal class StandardRuntimePlatform : IRuntimePlatform
        {
        private static readonly RuntimePlatformInfo s_info = new()
        {
            IsDesktop = OperatingSystemEx.IsWindows() || OperatingSystemEx.IsMacOS() || OperatingSystemEx.IsLinux(),
            IsMobile = OperatingSystemEx.IsAndroid() || OperatingSystemEx.IsIOS()
        };
        
        public virtual RuntimePlatformInfo GetRuntimeInfo() => s_info;
    }
}
