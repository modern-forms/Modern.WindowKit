#nullable disable

using System;
//using Modern.WindowKit.VisualTree;

namespace Modern.WindowKit.Input
{
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
