using Modern.WindowKit.Mac.Interop;
using Modern.WindowKit.Threading;
using Modern.WindowKit.MicroCom;

namespace Modern.WindowKit.Native;

class AvnDispatcher : NativeCallbackBase, IAvnDispatcher
{
    public void Post(IAvnActionCallback cb)
    {
        var callback = cb.CloneReference();
        Dispatcher.UIThread.Post(() =>
        {
            using (callback)
                callback.Run();
        }, DispatcherPriority.Send);
    }
}
