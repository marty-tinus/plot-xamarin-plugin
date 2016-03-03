using Foundation;
using UIKit;
using PlotProjects.Plugin;
using PlotProjects.Plugin.Abstractions;

namespace PlotProjectsExample
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
	[Register ("AppDelegate")]
	public class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations

		private IPlot plot;

		public override UIWindow Window {
			get;
			set;
		}

		public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
		{
			plot = Plot.GetInstance(launchOptions, true);
			return true;
		}

		public override void ReceivedLocalNotification (UIApplication application, UILocalNotification notification)
		{
			//Important to add this:
			Plot.HandleNotification (notification);
		}
	}
}


