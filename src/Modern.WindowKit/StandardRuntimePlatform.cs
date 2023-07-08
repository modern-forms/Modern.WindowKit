using System;
using System.Threading;
using Modern.WindowKit.Compatibility;
using Modern.WindowKit.Platform.Internal;

namespace Modern.WindowKit.Platform
{
    internal class StandardRuntimePlatform : IRuntimePlatform
    {
        public IDisposable StartSystemTimer(TimeSpan interval, Action tick)
        {
            return new Timer(_ => tick(), null, interval, interval);
        }

        public IUnmanagedBlob AllocBlob(int size) => new UnmanagedBlob(size);

        private static readonly RuntimePlatformInfo s_info = new()
        {
            IsDesktop = OperatingSystemEx.IsWindows() || OperatingSystemEx.IsMacOS() || OperatingSystemEx.IsLinux(),
            IsMobile = OperatingSystemEx.IsAndroid() || OperatingSystemEx.IsIOS()
        };


        public virtual RuntimePlatformInfo GetRuntimeInfo() => s_info;
    }
}
