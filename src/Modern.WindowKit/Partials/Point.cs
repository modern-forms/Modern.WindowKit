using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modern.WindowKit
{
    readonly partial struct Point
    {
        public static Point Empty { get; } = new Point();
    }
}
