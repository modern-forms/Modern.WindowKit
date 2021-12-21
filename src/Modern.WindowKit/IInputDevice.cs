using Modern.WindowKit.Input.Raw;

namespace Modern.WindowKit.Input
{
    public interface IInputDevice
    {
        /// <summary>
        /// Processes raw event. Is called after preprocessing by InputManager
        /// </summary>
        /// <param name="ev"></param>
        void ProcessRawEvent(RawInputEventArgs ev);
    }
}
