using Foundation;

namespace ScrollCrashRepro {
    [Register("AppDelegate")]
    public class AppDelegate : MauiUIApplicationDelegate {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}
