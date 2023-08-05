namespace Modern.WindowKit.Win32.WinRT
{
    internal enum BlurEffect
    {
        None,
        Acrylic,
        MicaLight,
        MicaDark
    }
    
    internal interface IBlurHost
    {
        void SetBlur(BlurEffect enable);
    }
}
