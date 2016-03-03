using System;
using PlotProjects.Plugin.Abstractions;

namespace PlotProjects.Plugin
{
	internal class PlotImplementation : IPlot
	{
		public PlotImplementation ()
		{
		}

		public void InitWithLaunchOptions (Foundation.NSDictionary launchOptions)
		{
			if (launchOptions == null) {
				launchOptions = new Foundation.NSDictionary ();
			}
			if (Release) {
				PlotRelease.InitializeWithLaunchOptionsAndDelegate (launchOptions, null);
			} else {
				PlotDebug.InitializeWithLaunchOptionsAndDelegate (launchOptions, null);
			}
		}

		public void HandleNotification(UIKit.UILocalNotification localNotification)
		{
			if (Release) {
				PlotRelease.HandleNotification (localNotification);
			} else {
				PlotDebug.HandleNotification (localNotification);
			}
		}

		public void Enable()
		{
			if (Release) {
				PlotRelease.Enable ();
			} else {
				PlotDebug.Enable ();
			}
		}

		public void Disable()
		{
			if (Release) {
				PlotRelease.Disable ();
			} else {
				PlotDebug.Disable ();
			}
		}

		public void MailDebugLog(UIKit.UIViewController viewController)
		{
			if (Release) {
				PlotRelease.MailDebugLog (viewController);
			} else {
				PlotDebug.MailDebugLog (viewController);
			}
		}

		public bool Release {get; set;}

		public String Version {
			get {
				if (Release) {
					return PlotRelease.Version ();
				} else {
					return PlotDebug.Version ();
				}
			}
		}
	}
}

