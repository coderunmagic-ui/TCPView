using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using static TCPView.Form1;

public static class TcpTableV4 {

	private const int AF_INET = 2; // IPv4
	private const uint ERROR_SUCCESS = 0;
	private const uint ERROR_INSUFFICIENT_BUFFER = 122;

	[DllImport("iphlpapi.dll",SetLastError = true)]
	private static extern uint GetExtendedTcpTable(
		IntPtr pTcpTable,
		ref int pdwSize,
		bool bOrder,
		int ulAf,
		TCP_TABLE_CLASS tableClass,
		uint reserved = 0);


	public static List<MIB_TCPROW_OWNER_PID> GetAllTcpConnections() {
		var tcpRows = new List<MIB_TCPROW_OWNER_PID>();
		int bufferSize = 0;

		// 1. Initial call to get the required buffer size
		uint result = GetExtendedTcpTable(IntPtr.Zero,ref bufferSize,true,AF_INET,TCP_TABLE_CLASS.TCP_TABLE_OWNER_PID_ALL);

		if(result != ERROR_INSUFFICIENT_BUFFER) {
			throw new Exception($"Failed to estimate buffer size. Error Code: {result}");
		}

		// 2. Allocate unmanaged memory dynamically based on returned buffer size
		IntPtr tcpTablePtr = Marshal.AllocHGlobal(bufferSize);

		try {
			// 3. Second call to fetch actual connection data into allocated memory
			result = GetExtendedTcpTable(tcpTablePtr,ref bufferSize,true,AF_INET,TCP_TABLE_CLASS.TCP_TABLE_OWNER_PID_ALL);

			if(result != ERROR_SUCCESS) {
				throw new Exception($"Failed to retrieve TCP Table data. Error Code: {result}");
			}

			// 4. Read the number of rows from the beginning of the table structure (DWORD / uint32)
			int numberOfEntries = Marshal.ReadInt32(tcpTablePtr);

			// Offset pointer past the header (the `dwNumEntries` int field takes 4 bytes)
			IntPtr rowPtr = IntPtr.Add(tcpTablePtr,4);

			// 5. Parse memory sequence and marshal into managed structs
			for(int i = 0;i < numberOfEntries;i++) {
				var row = Marshal.PtrToStructure<MIB_TCPROW_OWNER_PID>(rowPtr);
				tcpRows.Add(row);

				// Step pointer forward by the structural footprint size of a single row
				rowPtr = IntPtr.Add(rowPtr,Marshal.SizeOf<MIB_TCPROW_OWNER_PID>());
			}
		} finally {
			// Always free unmanaged blocks to prevent application memory leaks
			Marshal.FreeHGlobal(tcpTablePtr);
		}
		System.GC.Collect();
		return tcpRows;
	}

}

public enum TCP_TABLE_CLASS {
	TCP_TABLE_BASIC_LISTENER,
	TCP_TABLE_BASIC_CONNECTIONS,
	TCP_TABLE_BASIC_ALL,
	TCP_TABLE_OWNER_PID_LISTENER,
	TCP_TABLE_OWNER_PID_CONNECTIONS,
	TCP_TABLE_OWNER_PID_ALL,
	TCP_TABLE_OWNER_MODULE_LISTENER,
	TCP_TABLE_OWNER_MODULE_CONNECTIONS,
	TCP_TABLE_OWNER_MODULE_ALL
}

[StructLayout(LayoutKind.Sequential)]
public struct MIB_TCPROW_OWNER_PID {
	public uint dwState;
	public uint dwLocalAddr;
	[MarshalAs(UnmanagedType.ByValArray,SizeConst = 4)]
	public byte[] rgLocalPort;
	public uint dwRemoteAddr;
	[MarshalAs(UnmanagedType.ByValArray,SizeConst = 4)]
	public byte[] rgRemotePort;
	public uint ProcessId;
	public string ProcessName => TcpUdpStateInfo.GetProcessName((int)ProcessId);
	public IPAddress LocalAddress => new IPAddress(dwLocalAddr);
	public ushort LocalPort => (ushort)((rgLocalPort[0] << 8) + rgLocalPort[1]);
	public IPAddress RemoteAddress => new IPAddress(dwRemoteAddr);
	public ushort RemotePort => dwRemoteAddr == 0 ? (ushort)0 : (ushort)((rgRemotePort[0] << 8) + rgRemotePort[1]);
	public uint State => dwState;
}