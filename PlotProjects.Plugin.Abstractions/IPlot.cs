using System;

namespace PlotProjects.Plugin.Abstractions
{
	/// <summary>
	/// A facade to the Plot plugin. Call the method Plot.GetInstance() to get an instance of this interface.
	/// </summary>
	public interface IPlot
	{
		/// <summary>
		/// Enable the Plot library. It will remember this between sessions.
		/// </summary>
		void Enable();
		/// <summary>
		/// Disable the Plot library. It will remember this between sessions.
		/// </summary>
		void Disable();

		/// <summary>
		/// Gets the current version number of the Plot library backing this module.
		/// </summary>
		/// <value>a string with the version</value>
		string Version { get; }
	}
}

