using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

public class TcpUdpStateInfo {

	[DllImport("user32.dll",CharSet = CharSet.Auto)]
	private static extern bool DestroyIcon(IntPtr handle);

	public static Icon ConvertBitmapToIcon(Bitmap bitmap) {
		// 1. Get an Hicon handle from the bitmap
		IntPtr hIcon = bitmap.GetHicon();

		// 2. Create the managed Icon object from the handle
		Icon icon = Icon.FromHandle(hIcon);

		// 3. Clone the icon so it doesn't depend on the unmanaged handle
		Icon result = (Icon)icon.Clone();

		// 4. Clean up the native unmanaged resource immediately
		DestroyIcon(hIcon);
		icon.Dispose();

		return result;
	}

	public static Icon AddProcessIcon(int pid) {

		try {
			var p = Process.GetProcessById(pid);
			string path = p.MainModule?.FileName ?? "";
			Icon? icon = Icon.ExtractAssociatedIcon(path);

			return icon;
		} catch {
			return ConvertBitmapToIcon(TCPView.Properties.Resources.Unknown);
		}
	}

	public static string GetProcessName(int pid) {
		try {
			using var p = Process.GetProcessById(pid);
			//return System.IO.Path.GetFileName(p.MainModule.FileName);
			return p.ProcessName;
		} catch {
			return "Unknown";
		}
	}

	public static string GetProcessPath(int pid) {
		try {
			using var p = Process.GetProcessById(pid);
			return p.MainModule.FileName;
		} catch {
			return "Unknown";
		}
	}



	public static string TcpState(string State) {
		return State switch {
			"1" => "CLOSED",
			"2" => "LISTENING",
			"3" => "SYN_SENT",
			"4" => "SYN_RCVD",
			"5" => "ESTABLISHED",
			"6" => "FIN_WAIT1",
			"7" => "FIN_WAIT2",
			"8" => "CLOSE_WAIT",
			"9" => "CLOSING",
			"10" => "LAST_ACK",
			"11" => "TIME_WAIT",
			"12" => "DELETE_TCB",
		};
	}

	public static Color GetTcpStateColor(string state) {
		switch(state?.ToUpper()) {
			case "LISTEN":
			return Color.Blue;
			case "ESTABLISHED":
			return Color.Green;
			case "TIME_WAIT":
			return Color.Yellow;
			case "CLOSE_WAIT":
			return Color.Orange;
			case "CLOSED":
			return Color.LightGray;
			case "FIN_WAIT1":
			return Color.Gold;
			case "FIN_WAIT2":
			return Color.DarkOrange;
			default:
			return Color.White;
		}
	}
}