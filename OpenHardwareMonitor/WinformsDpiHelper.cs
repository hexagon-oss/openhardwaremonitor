using System;

namespace OpenHardwareMonitor;

internal static class WinformsDpiHelper
{
	[System.Runtime.InteropServices.DllImport("user32.dll")]
	private static extern bool SetProcessDPIAware();


	/// <summary>
	///  // *** fix blurry text on High-Dpi Screen  <para></para>
	///  // *** call it Program.cs  Main()   as First Line.   Before EnableVisualStyles.. <para></para>
	///   
	/// <para></para>
	///  WinformsDpiHelper.SetProcess_DPIAware(); <para></para>
	///  
	///  Application.EnableVisualStyles(); <para></para>
	/// </summary>
	public static void SetProcess_DPIAware() 
	{
		if (Environment.OSVersion.Version.Major >= 6)
			SetProcessDPIAware();
	}
}
