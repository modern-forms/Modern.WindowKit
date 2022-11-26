using Modern.WindowKit.Controls.Primitives.PopupPositioning;
using Modern.WindowKit.Metadata;

namespace Modern.WindowKit.Platform
{
    /// <summary>
    /// Defines a platform-specific popup window implementation.
    /// </summary>
    [Unstable]
    public interface IPopupImpl : IWindowBaseImpl
    {
        IPopupPositioner PopupPositioner { get; }

        void SetWindowManagerAddShadowHint(bool enabled);
    }
}
