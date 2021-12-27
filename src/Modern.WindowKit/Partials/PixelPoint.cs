using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modern.WindowKit
{
    public readonly partial struct PixelPoint
    {
        public System.Drawing.Point ToDrawingPoint () => new System.Drawing.Point (X, Y);
    }
}
