using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modern.WindowKit.Input.Raw
{
    public partial class RawTextInputEventArgs
    {
        public RawTextInputEventArgs(
            IKeyboardDevice device,
            ulong timestamp,
            IInputRoot root,
            string text,
            RawInputModifiers modifiers)
            : base(device, timestamp, root)
        {
            Text = text;
            Modifiers = modifiers;
        }

        public RawInputModifiers Modifiers { get; set; }
    }
}
