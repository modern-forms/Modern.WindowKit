using Modern.WindowKit.Input.Raw;
using Modern.WindowKit.Metadata;

namespace Modern.WindowKit.Input
{
    [NotClientImplementable]
    public interface IInputDevice
    {
        /// </summary>
        /// Processes raw event. Is called after preprocessing by InputManager
        /// </summary>
        /// <param name="ev"></param>
        void ProcessRawEvent(RawInputEventArgs ev);
    }
}
