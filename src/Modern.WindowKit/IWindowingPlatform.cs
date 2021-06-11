#nullable disable

namespace Modern.WindowKit.Platform
{
    public interface IWindowingPlatform
    {
        IWindowImpl CreateWindow();
        //IEmbeddableWindowImpl CreateEmbeddableWindow();
        IPopupImpl CreatePopup();
    }
}
