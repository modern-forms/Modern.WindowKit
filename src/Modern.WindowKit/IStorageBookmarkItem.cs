using System.Threading.Tasks;
using Modern.WindowKit.Metadata;

namespace Modern.WindowKit.Platform.Storage;

[NotClientImplementable]
public interface IStorageBookmarkItem : IStorageItem
{
    Task ReleaseBookmarkAsync();
}

[NotClientImplementable]
public interface IStorageBookmarkFile : IStorageFile, IStorageBookmarkItem
{
}

[NotClientImplementable]
public interface IStorageBookmarkFolder : IStorageFolder, IStorageBookmarkItem
{
}
