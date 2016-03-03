using System;
using PlotProjects.Plugin.Abstractions;

namespace PlotProjects.Plugin
{
	/// <summary>
	/// Plot Projects Module.
	/// </summary>
	public sealed class Plot
	{
		private static Lazy<IPlot> Implementation = new Lazy<IPlot>(() => CreatePlot(), System.Threading.LazyThreadSafetyMode.PublicationOnly);

		private static IPlot CreatePlot()
		{
			#if PORTABLE
			return null;
			#else
			return new PlotImplementation();
			#endif
		}

		internal static Exception NotImplementedInReferenceAssembly()
		{
			return new NotImplementedException("This functionality is not implemented in the portable version of this assembly. You should reference the PlotProjects.Plugin NuGet package from your main application project in order to reference the platform-specific implementation.");
		}
			
		private static IPlot GetInstance()
		{
			IPlot result = Implementation.Value;
			if (result == null) {
				throw new NotImplementedException ();
			}
			return result;
		}

		#if __ANDROID__
		/// <summary>
		/// Gets the Plot interface. The overload with the Activity parameter is preferred, else you're responsible yourself for asking for Location Services permission.
		/// Calling this method multiple times in your application is no problem.
		/// </summary>
		/// <returns>a link to the Plot interface</returns>
		/// <param name="context">Context</param>
		public static IPlot GetInstance(Android.Content.Context context)
		{
			PlotImplementation instance = (PlotImplementation) GetInstance ();
			instance.Init (context);
			return instance;
		}

		/// <summary>
		/// Gets the Plot interface.
		/// Calling this method multiple times in your application is no problem.
		/// </summary>
		/// <returns>a link to the Plot interface</returns>
		/// <param name="activity">an Activity to initialize Plot from</param>
		public static IPlot GetInstance(Android.App.Activity activity)
		{
			PlotImplementation instance = (PlotImplementation) GetInstance ();
			instance.Init (activity);
			return instance;
		}

		/// <summary>
		/// Mails the debug log. Only works when the debug meta-data property of the PlotService is set to true.
		/// </summary>
		public static void MailDebugLog()
		{
			PlotImplementation instance = (PlotImplementation) GetInstance ();
			instance.MailDebugLog();
		}
		#endif

		#if __IOS__
		/// <summary>
		/// Gets the Plot interface.
		/// </summary>
		/// <returns>a link to the Plot interface</returns>
		/// <param name="launchOptions">the launchOptions passed to the delegate</param>
		/// <param name="debug">whether debug logging should be enabled</param>
		public static IPlot GetInstance(Foundation.NSDictionary launchOptions, bool debug)
		{
			PlotImplementation instance = (PlotImplementation) GetInstance ();
			instance.Release = !debug;
			instance.InitWithLaunchOptions (launchOptions);
			return instance;
		}

		/// <summary>
		/// Forwards the notification to the Plot library.
		/// </summary>
		/// <param name="localNotification">localNotification object</param>
		public static void HandleNotification(UIKit.UILocalNotification localNotification)
		{
			PlotImplementation instance = (PlotImplementation) GetInstance ();
			instance.HandleNotification (localNotification);
		}

		public static void MailDebugLog(UIKit.UIViewController viewController)
		{
			PlotImplementation instance = (PlotImplementation) GetInstance ();
			instance.MailDebugLog(viewController);
		}
		#endif
	}
}

