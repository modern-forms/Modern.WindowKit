﻿using Modern.WindowKit.Metadata;

namespace Modern.WindowKit.Platform
    {
    [Unstable, PrivateApi]
    public interface IWindowingPlatform
    {
        IWindowImpl CreateWindow();

        //IWindowImpl CreateEmbeddableWindow();

        //ITrayIconImpl? CreateTrayIcon();
    }
}
