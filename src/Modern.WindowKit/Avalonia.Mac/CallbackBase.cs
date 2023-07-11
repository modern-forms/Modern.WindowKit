using System;
using System.Runtime.ExceptionServices;
using Modern.WindowKit.MicroCom;
using Modern.WindowKit.Platform;
using Modern.WindowKit.Threading;
using Modern.WindowKit.MicroCom;

namespace Modern.WindowKit.Native
{
    internal abstract class NativeCallbackBase : CallbackBase, IMicroComExceptionCallback
    {
        public void RaiseException(Exception e)
        {
            if (AvaloniaLocator.Current.GetService<IDispatcherImpl>() is DispatcherImpl dispatcherImpl)
            {
                dispatcherImpl.PropagateCallbackException(ExceptionDispatchInfo.Capture(e));
            }
        }
    }
}
