using System;
using PlotProjects.Plugin.Abstractions;
using PlotAndroid = Com.Plotprojects.Retail.Android.Plot;

namespace PlotProjects.Plugin
{
	internal class PlotImplementation : IPlot
	{
		internal PlotImplementation()
		{
		}

		public void Init(Android.App.Activity context)
		{
			PlotAndroid.Init (context);
		}

		public void Init(Android.Content.Context context)
		{
			PlotAndroid.Init (context);
		}

		public void Enable()
		{
			PlotAndroid.Enable ();
		}

		public void Disable()
		{
			PlotAndroid.Disable ();
		}

		public void MailDebugLog()
		{
			PlotAndroid.MailDebugLog ();
		}

		public string Version {
			get {
				return PlotAndroid.Version;
			}
		}
	}
}

