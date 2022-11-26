using Modern.WindowKit.Input.Raw;
using Modern.WindowKit.Metadata;

namespace Modern.WindowKit.Input
{
    [NotClientImplementable]
    public interface IPointerDevice : IInputDevice
    {
        //[Obsolete("Use IPointer")]
        //IInputElement? Captured { get; }
        
        //[Obsolete("Use IPointer")]
        //void Capture(IInputElement? control);

        //[Obsolete("Use PointerEventArgs.GetPosition")]
        //Point GetPosition(IVisual relativeTo);
    }
}
