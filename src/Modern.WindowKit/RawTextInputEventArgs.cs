using Modern.WindowKit.Metadata;

namespace Modern.WindowKit.Input.Raw
{
    [PrivateApi]
    public partial class RawTextInputEventArgs : RawInputEventArgs
    {
        //public RawTextInputEventArgs(
        //    IKeyboardDevice device,
        //    ulong timestamp,
        //    IInputRoot root,
        //    string text)
        //    : base(device, timestamp, root)
        //{
        //    Text = text;
        //}

        public string Text { get; }
    }
}
