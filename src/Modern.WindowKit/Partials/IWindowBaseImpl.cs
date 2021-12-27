using Modern.WindowKit.Controls;
using Modern.WindowKit.Input;

namespace Modern.WindowKit.Platform
{
    public partial interface IWindowBaseImpl
    {
        /// <summary>
        /// Starts moving a window with left button being held. Should be called from left mouse button press event handler.
        /// </summary>
        void BeginMoveDrag(PointerPressedEventArgs e);

        /// <summary>
        /// Starts resizing a window. This function is used if an application has window resizing controls. 
        /// Should be called from left mouse button press event handler
        /// </summary>
        void BeginResizeDrag(WindowEdge edge, PointerPressedEventArgs e);

        /// <summary>
        /// Sets the client size of the top level.
        /// </summary>
        /// <param name="clientSize">The new client size.</param>
        /// <param name="reason">The reason for the resize.</param>
        void Resize(Size clientSize, PlatformResizeReason reason = PlatformResizeReason.Application);

        /// <summary>
        /// Minimum width of the window.
        /// </summary>
        /// 
        void SetMinMaxSize(Size minSize, Size maxSize);
    }
}
