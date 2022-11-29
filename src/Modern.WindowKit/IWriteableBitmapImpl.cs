using Modern.WindowKit.Metadata;

namespace Modern.WindowKit.Platform
{
    /// <summary>
    /// Defines the platform-specific interface for a <see cref="Avalonia.Media.Imaging.WriteableBitmap"/>.
    /// </summary>
    [Unstable]
    public interface IWriteableBitmapImpl : IBitmapImpl
    {
        ILockedFramebuffer Lock();
    }
}
