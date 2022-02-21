using System;
using System.Runtime.ExceptionServices;
using Avalonia.MicroCom;
using Modern.WindowKit.Platform;

namespace Modern.WindowKit.Native
{
    public abstract class NativeCallbackBase : CallbackBase, IMicroComExceptionCallback
    {
        public void RaiseException(Exception e)
        {
            if (AvaloniaGlobals.GetService<IPlatformThreadingInterface>() is PlatformThreadingInterface threadingInterface)
            {
                threadingInterface.TerminateNativeApp();

                threadingInterface.DispatchException(ExceptionDispatchInfo.Capture(e));
            }
        }
        }
}
