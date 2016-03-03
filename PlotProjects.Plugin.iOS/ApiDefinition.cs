using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace PlotProjects.Plugin
{
	[BaseType (typeof (NSObject))]
	internal interface PlotDebug {
		[Static, Export ("version")]
		String Version ();

		[Static, Export ("enable")]
		void Enable ();

		[Static, Export ("disable")]
		void Disable ();

		[Static, Export("initializeWithLaunchOptions:delegate:")]
		void InitializeWithLaunchOptionsAndDelegate(NSDictionary launchOptions, [NullAllowed] NSObject del);

		[Static, Export("handleNotification:")]
		void HandleNotification(UIKit.UILocalNotification localNotification);

		[Static, Export("mailDebugLog:")]
		void MailDebugLog(UIKit.UIViewController viewController);
	}

	[BaseType (typeof (NSObject))]
	internal interface PlotRelease {
		[Static, Export ("version")]
		String Version ();

		[Static, Export ("enable")]
		void Enable ();

		[Static, Export ("disable")]
		void Disable ();

		[Static, Export("initializeWithLaunchOptions:delegate:")]
		void InitializeWithLaunchOptionsAndDelegate(NSDictionary launchOptions, [NullAllowed] NSObject del);

		[Static, Export("handleNotification:")]
		void HandleNotification(UIKit.UILocalNotification localNotification);

		[Static, Export("mailDebugLog:")]
		void MailDebugLog(UIKit.UIViewController viewController);
	}
}

