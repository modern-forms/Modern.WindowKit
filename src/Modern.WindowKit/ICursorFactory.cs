using Modern.WindowKit.Input;
using Modern.WindowKit.Metadata;

#nullable enable

namespace Modern.WindowKit.Platform
{
    [PrivateApi]
    public interface ICursorFactory
    {
        ICursorImpl GetCursor(StandardCursorType cursorType);
        ICursorImpl CreateCursor(IBitmapImpl cursor, PixelPoint hotSpot);
    }
}
