using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkiaSharp;

namespace Modern.WindowKit
{
    public static class SkiaExtensions
    {
        /// <summary>
        /// Convers an SKImage to a Bitmap.
        /// </summary>
        public static Bitmap ToBitmap (this SKImage skiaImage)
        {
            // TODO: maybe keep the same color types where we can, instead of just going to the platform default
            var bitmap = new Bitmap (skiaImage.Width, skiaImage.Height, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
            var data = bitmap.LockBits (new Rectangle (0, 0, bitmap.Width, bitmap.Height), System.Drawing.Imaging.ImageLockMode.WriteOnly, bitmap.PixelFormat);

            // copy
            using (var pixmap = new SKPixmap (new SKImageInfo (data.Width, data.Height), data.Scan0, data.Stride))
                skiaImage.ReadPixels (pixmap, 0, 0);

            bitmap.UnlockBits (data);
            return bitmap;
        }

        /// <summary>
        /// Convers an SKBitmap to a Bitmap.
        /// </summary>
        public static Bitmap ToBitmap (this SKBitmap skiaBitmap)
        {
            using (var image = SKImage.FromPixels (skiaBitmap.PeekPixels ()))
                return ToBitmap (image);
        }
    }
}
