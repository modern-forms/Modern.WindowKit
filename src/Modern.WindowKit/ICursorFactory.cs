using Modern.WindowKit.Input;

#nullable enable

namespace Modern.WindowKit.Platform
{
    public interface ICursorFactory
    {
        ICursorImpl GetCursor(StandardCursorType cursorType);
        ICursorImpl CreateCursor(IBitmapImpl cursor, PixelPoint hotSpot);
    }
}
