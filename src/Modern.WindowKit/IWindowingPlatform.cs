#nullable disable

namespace Modern.WindowKit.Platform
{
    public interface IWindowingPlatform
    {
        IWindowImpl CreateWindow();
        //IWindowImpl CreateEmbeddableWindow();
        IPopupImpl CreatePopup(IWindowBaseImpl parent);
    }
}
