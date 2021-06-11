﻿#nullable disable

using Modern.WindowKit.Platform;

namespace Modern.WindowKit.Skia
{
    /// <summary>
    /// Skia platform initializer.
    /// </summary>
    public static class SkiaPlatform
    {
        /// <summary>
        /// Initialize Skia platform.
        /// </summary>
        public static void Initialize()
        {
            Initialize(new SkiaOptions());
        }

        public static void Initialize(SkiaOptions options)
        {
            //var customGpu = options.CustomGpuFactory?.Invoke();
            //var renderInterface = new PlatformRenderInterface(customGpu);

            //AvaloniaLocator.CurrentMutable
            //    .Bind<IPlatformRenderInterface>().ToConstant(renderInterface);
        }

        /// <summary>
        /// Default DPI.
        /// </summary>
        public static Vector DefaultDpi => new Vector(96.0f, 96.0f);
    }
}
