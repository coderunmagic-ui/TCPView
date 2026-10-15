using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;


public static class TcpTableV6 {

	private const int AF_INET6 = 23; // Address Family for IPv6

	[DllImport("iphlpapi.dll",SetLastError = true)]
	private static extern uint GetExtendedTcpTable(
		IntPtr pTcpTable,
		ref int pdwSize,
		bool bOrder,
		int ulAf,
		TcpTableClass tableClass,
		uint reserved = 0);

	public static List<MIB_TCP6ROW_OWNER_PID> GetAllTcpConnections() {
		var bufferSize = 0;
		var result = new List<MIB_TCP6ROW_OWNER_PID>();

		// 1. Determine required buffer size
		uint ret = GetExtendedTcpTable(IntPtr.Zero,ref bufferSize,true,AF_INET6,TcpTableClass.TcpTableOwnerPidAll);

		// ERROR_INSUFFICIENT_BUFFER = 122
		if(ret != 0 && ret != 122)
			throw new Exception($"Failed to get table size. Error code: {ret}");

		IntPtr tcpTablePtr = Marshal.AllocHGlobal(bufferSize);

		try {
			// 2. Fetch the actual database table
			ret = GetExtendedTcpTable(tcpTablePtr,ref bufferSize,true,AF_INET6,TcpTableClass.TcpTableOwnerPidAll);
			if(ret != 0)
				throw new Exception($"Failed to retrieve TCP table. Error code: {ret}");

			// 3. Read the entry count (first 4 bytes of the table)
			int numEntries = Marshal.ReadInt32(tcpTablePtr);
			IntPtr rowPtr = IntPtr.Add(tcpTablePtr,4); // Offset past dwNumEntries

			// 4. Iterate over unmanaged array rows
			int rowSize = Marshal.SizeOf<MIB_TCP6ROW_OWNER_PID>();
			for(int i = 0;i < numEntries;i++) {
				var row = Marshal.PtrToStructure<MIB_TCP6ROW_OWNER_PID>(rowPtr);
				result.Add(row);
				rowPtr = IntPtr.Add(rowPtr,rowSize);
			}
		} finally {
			Marshal.FreeHGlobal(tcpTablePtr);
		}
		System.GC.Collect();
		return result;
	}
}

public enum TcpTableClass {
	TcpTableBasicListener,
	TcpTableBasicConnections,
	TcpTableBasicAll,
	TcpTableOwnerPidListener,
	TcpTableOwnerPidConnections,
	TcpTableOwnerPidAll, // Used to fetch all connections with PIDs
	TcpTableOwnerModuleListener,
	TcpTableOwnerModuleConnections,
	TcpTableOwnerModuleAll
}

[StructLayout(LayoutKind.Sequential)]
public struct MIB_TCP6ROW_OWNER_PID {
	[MarshalAs(UnmanagedType.ByValArray,SizeConst = 16)]
	public byte[] localAddr;
	public uint localScopeId;
	public byte localPort1;
	public byte localPort2;
	public byte localPort3;
	public byte localPort4;

	[MarshalAs(UnmanagedType.ByValArray,SizeConst = 16)]
	public byte[] remoteAddr;
	public uint remoteScopeId;
	public byte remotePort1;
	public byte remotePort2;
	public byte remotePort3;
	public byte remotePort4;

	public uint state;
	public uint owningPid;
	public string ProcessName => TcpUdpStateInfo.GetProcessName((int)owningPid);
	// Helper property to parse the network byte order local port
	public int LocalPort => (localPort1 << 8) + localPort2;

	// Helper property to parse the network byte order remote port
	public int RemotePort => (remotePort1 << 8) + remotePort2;

}