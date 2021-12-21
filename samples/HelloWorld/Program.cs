using Modern.WindowKit;
using Modern.WindowKit.Threading;

public class Program
{
    static void Main(string[] args)
    {
        var window = AvaloniaGlobals.WindowingInterface.CreateWindow();
        window.Show();
        var _mainLoopCancellationTokenSource = new CancellationTokenSource();

        Dispatcher.UIThread.MainLoop(_mainLoopCancellationTokenSource.Token);

        //window.ShowDialog(null);
    }
}
