
namespace DedicatedMauiWindows3;

public static class Program
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2409")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [STAThreadAttribute]
    static void Main(string[] args)
    {
        WinRT.ComWrappersSupport.InitializeComWrappers();
        Microsoft.UI.Xaml.Application.Start((p) => {
            var context = new Microsoft.UI.Dispatching.DispatcherQueueSynchronizationContext(Microsoft.UI.Dispatching.DispatcherQueue.GetForCurrentThread());
            SynchronizationContext.SetSynchronizationContext(context);
            _ = new MySingleMauiProject.WinUI.App();
        });
    }
}
