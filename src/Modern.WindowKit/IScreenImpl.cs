using System.Collections.Generic;

namespace Modern.WindowKit.Platform
{
    public interface IScreenImpl
    {
        int ScreenCount { get; }

        IReadOnlyList<Screen> AllScreens { get; }
    }
}
