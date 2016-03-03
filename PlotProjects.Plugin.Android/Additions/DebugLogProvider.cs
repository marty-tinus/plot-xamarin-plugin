using System;
using Android.Content;

namespace Com.Plotprojects.Retail.Android
{
	[ContentProvider(new [] {"@PACKAGE_NAME@.plot.debuglogprovider"}, Exported = true, Name = "com.plotprojects.retail.android.DebugLogProvider")]
	public partial class DebugLogProvider
	{
		
	}
}

