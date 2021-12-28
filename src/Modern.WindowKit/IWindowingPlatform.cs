#nullable enable

namespace Modern.WindowKit.Platform
{
    public interface IWindowingPlatform
    {
        IWindowImpl CreateWindow();

        //IWindowImpl CreateEmbeddableWindow();

        //ITrayIconImpl? CreateTrayIcon();
    }
}
