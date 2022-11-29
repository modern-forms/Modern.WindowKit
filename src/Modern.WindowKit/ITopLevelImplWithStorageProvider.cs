using Modern.WindowKit.Metadata;
using Modern.WindowKit.Platform;
using Modern.WindowKit.Platform.Storage;

namespace Modern.WindowKit.Controls.Platform;

[Unstable]
public interface ITopLevelImplWithStorageProvider : ITopLevelImpl
{
    public IStorageProvider StorageProvider { get; }
}
