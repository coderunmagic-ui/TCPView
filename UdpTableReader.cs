using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;

public class UdpTableReader {

	private const int AF_INET = 2;
	private const int AF_INET6 = 23;

	private enum UDP_TABLE_CLASS {
		UDP_TABLE_BASIC,
		UDP_TABLE_OWNER_PID,
		UDP_TABLE_OWNER_MODULE
	}

	[DllImport("iphlpapi.dll",SetLastError = true)]
	private static extern uint GetExtendedUdpTable(
		IntPtr pUdpTable,
		ref int pdwSize,
		bool bOrder,
		int ulAf,
		UDP_TABLE_CLASS TableClass,
		uint reserved
	);

	[StructLayout(LayoutKind.Sequential)]
	public struct MIB_UDPROW_OWNER_PID {
		public uint localAddr;
		[MarshalAs(UnmanagedType.ByValArray,SizeConst = 4)]
		public byte[] localPort;
		public uint owningPid;
		public string ProcessName => TcpUdpStateInfo.GetProcessName((int)owningPid);
		public IPAddress LocalAddress => new IPAddress(localAddr);
		public ushort LocalPort => (ushort)((localPort[0] << 8) + localPort[1] | (localPort[2] >> 8) + (localPort[3] << 24)); // Simplified port conversion

	}

	[StructLayout(LayoutKind.Sequential)]
	public struct MIB_UDP6ROW_OWNER_PID {
		[MarshalAs(UnmanagedType.ByValArray,SizeConst = 16)]
		public byte[] localAddr;
		public uint localScopeId;
		[MarshalAs(UnmanagedType.ByValArray,SizeConst = 4)]
		public byte[] localPort;
		public uint owningPid;
		public string ProcessName => TcpUdpStateInfo.GetProcessName((int)owningPid);
		public IPAddress LocalAddress => new IPAddress(localAddr);
		public ushort LocalPort => (ushort)((localPort[0] << 8) + localPort[1] | (localPort[2] >> 8) + (localPort[3] << 24));


	}

	public static List<MIB_UDPROW_OWNER_PID> GetExtendedUdpTable4() {
		var list = new List<MIB_UDPROW_OWNER_PID>();
		int bufferSize = 0;
		GetExtendedUdpTable(IntPtr.Zero,ref bufferSize,true,AF_INET,UDP_TABLE_CLASS.UDP_TABLE_OWNER_PID,0);

		IntPtr bufferTable = Marshal.AllocHGlobal(bufferSize);
		try {
			uint result = GetExtendedUdpTable(bufferTable,ref bufferSize,true,AF_INET,UDP_TABLE_CLASS.UDP_TABLE_OWNER_PID,0);
			if(result == 0) {
				int rowCount = Marshal.ReadInt32(bufferTable);
				IntPtr rowPtr = new IntPtr(bufferTable.ToInt64() + 4);
				int rowSize = Marshal.SizeOf(typeof(MIB_UDPROW_OWNER_PID));

				for(int i = 0;i < rowCount;i++) {
					var row = (MIB_UDPROW_OWNER_PID)Marshal.PtrToStructure(rowPtr,typeof(MIB_UDPROW_OWNER_PID));
					list.Add(row);
					rowPtr = new IntPtr(rowPtr.ToInt64() + rowSize);
				}
			}
		} finally {
			Marshal.FreeHGlobal(bufferTable);
		}
		System.GC.Collect();
		return list;
	}

	public static List<MIB_UDP6ROW_OWNER_PID> GetExtendedUdpTable6() {
		var list = new List<MIB_UDP6ROW_OWNER_PID>();
		int bufferSize = 0;
		GetExtendedUdpTable(IntPtr.Zero,ref bufferSize,true,AF_INET6,UDP_TABLE_CLASS.UDP_TABLE_OWNER_PID,0);

		IntPtr bufferTable = Marshal.AllocHGlobal(bufferSize);
		try {
			uint result = GetExtendedUdpTable(bufferTable,ref bufferSize,true,AF_INET6,UDP_TABLE_CLASS.UDP_TABLE_OWNER_PID,0);
			if(result == 0) {
				int rowCount = Marshal.ReadInt32(bufferTable);
				IntPtr rowPtr = new IntPtr(bufferTable.ToInt64() + 4); // Skip numEntries (4 bytes)
				int rowSize = Marshal.SizeOf(typeof(MIB_UDP6ROW_OWNER_PID));

				for(int i = 0;i < rowCount;i++) {
					var row = (MIB_UDP6ROW_OWNER_PID)Marshal.PtrToStructure(rowPtr,typeof(MIB_UDP6ROW_OWNER_PID));
					list.Add(row);
					rowPtr = new IntPtr(rowPtr.ToInt64() + rowSize);
				}
			}
		} finally {
			Marshal.FreeHGlobal(bufferTable);
		}
		System.GC.Collect();
		return list;
	}
}
