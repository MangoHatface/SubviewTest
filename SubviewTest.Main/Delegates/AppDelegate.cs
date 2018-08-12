using AppKit;
using Foundation;

namespace SubviewTest
{
    [Register("AppDelegate")]
    public class AppDelegate : NSApplicationDelegate
    {
        public AppDelegate()
        {
        }

        public override void DidFinishLaunching(NSNotification notification)
        {
            NSWindow mainWindow = NSApplication.SharedApplication.MainWindow;
            mainWindow.MovableByWindowBackground = true;
        }

        public override void WillTerminate(NSNotification notification)
        {
            // Insert code here to tear down your application
        }
    }
}
