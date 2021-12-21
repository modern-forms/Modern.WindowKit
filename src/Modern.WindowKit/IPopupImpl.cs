#nullable disable

//using Modern.WindowKit.Controls.Primitives.PopupPositioning;

namespace Modern.WindowKit.Platform
{
    /// <summary>
    /// Defines a platform-specific popup window implementation.
    /// </summary>
    public interface IPopupImpl : IWindowBaseImpl
    {
        //IPopupPositioner PopupPositioner { get; }

        void SetWindowManagerAddShadowHint(bool enabled);
    }
}
