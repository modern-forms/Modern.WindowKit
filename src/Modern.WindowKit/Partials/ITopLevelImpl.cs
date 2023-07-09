using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modern.WindowKit.Platform
{
    public partial interface ITopLevelImpl
    {
        /// <summary>
        /// Invalidates a rect on the toplevel.
        /// </summary>
        void Invalidate(Rect rect);
    }
}
