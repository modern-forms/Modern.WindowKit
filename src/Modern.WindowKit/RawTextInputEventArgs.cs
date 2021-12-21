namespace Modern.WindowKit.Input.Raw
{
    public class RawTextInputEventArgs : RawInputEventArgs
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

        public string Text { get; set; }

        public RawInputModifiers Modifiers { get; set; }
    }
}
