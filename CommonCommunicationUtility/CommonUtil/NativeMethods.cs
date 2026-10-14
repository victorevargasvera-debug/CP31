using System;
using System.Collections.Specialized;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000015 RID: 21
	public static class NativeMethods
	{
		// Token: 0x06000059 RID: 89
		[global::System.Runtime.InteropServices.DllImport("user32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode)]
		internal static extern global::System.IntPtr RegisterDeviceNotification(global::System.IntPtr A_0, global::System.IntPtr A_1, uint A_2);

		// Token: 0x0600005A RID: 90
		[global::System.Runtime.InteropServices.DllImport("user32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode)]
		internal static extern uint UnregisterDeviceNotification(global::System.IntPtr A_0);

		// Token: 0x0600005B RID: 91
		[global::System.Runtime.InteropServices.DllImport("kernel32", SetLastError = true)]
		internal static extern uint CloseHandle(global::System.IntPtr A_0);

		// Token: 0x0600005C RID: 92
		[global::System.Runtime.InteropServices.DllImport("setupapi.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode)]
		internal static extern global::System.IntPtr SetupDiGetClassDevs(ref global::System.Guid A_0, global::System.IntPtr A_1, global::System.IntPtr A_2, int A_3);

		// Token: 0x0600005D RID: 93
		[global::System.Runtime.InteropServices.DllImport("setupapi.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, SetLastError = true)]
		internal static extern uint SetupDiEnumDeviceInterfaces(global::System.IntPtr A_0, global::System.IntPtr A_1, ref global::System.Guid A_2, uint A_3, ref global::Motorola.Common.Communication.CommonUtil.NativeMethods.SP_DEVICE_INTERFACE_DATA A_4);

		// Token: 0x0600005E RID: 94
		[global::System.Runtime.InteropServices.DllImport("setupapi.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, SetLastError = true)]
		internal static extern bool SetupDiDestroyDeviceInfoList(global::System.IntPtr A_0);

		// Token: 0x0600005F RID: 95
		[global::System.Runtime.InteropServices.DllImport("setupapi.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, SetLastError = true)]
		internal static extern bool SetupDiGetDeviceInterfaceDetail(global::System.IntPtr A_0, ref global::Motorola.Common.Communication.CommonUtil.NativeMethods.SP_DEVICE_INTERFACE_DATA A_1, global::System.IntPtr A_2, uint A_3, out uint A_4, ref global::Motorola.Common.Communication.CommonUtil.NativeMethods.SP_DEVINFO_DATA A_5);

		// Token: 0x06000060 RID: 96
		[global::System.Runtime.InteropServices.DllImport("setupapi.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, SetLastError = true)]
		internal static extern bool SetupDiGetDeviceInstanceId(global::System.IntPtr A_0, ref global::Motorola.Common.Communication.CommonUtil.NativeMethods.SP_DEVINFO_DATA A_1, global::System.Text.StringBuilder A_2, int A_3, out int A_4);

		// Token: 0x06000061 RID: 97
		[global::System.Runtime.InteropServices.DllImport("setupapi.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, SetLastError = true)]
		internal static extern int CM_Get_Device_ID(uint A_0, global::System.IntPtr A_1, int A_2, int A_3);

		// Token: 0x06000062 RID: 98
		[global::System.Runtime.InteropServices.DllImport("setupapi.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, SetLastError = true)]
		internal static extern int CM_Get_Parent(out uint A_0, uint A_1, int A_2);

		// Token: 0x06000063 RID: 99
		[global::System.Runtime.InteropServices.DllImport("setupapi.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, SetLastError = true)]
		internal static extern bool SetupDiGetDeviceRegistryProperty(global::System.IntPtr A_0, ref global::Motorola.Common.Communication.CommonUtil.NativeMethods.SP_DEVINFO_DATA A_1, uint A_2, out uint A_3, byte[] A_4, uint A_5, out uint A_6);

		// Token: 0x06000064 RID: 100
		[global::System.Runtime.InteropServices.DllImport("Setupapi", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, SetLastError = true)]
		internal static extern global::System.IntPtr SetupDiOpenDevRegKey(global::System.IntPtr A_0, ref global::Motorola.Common.Communication.CommonUtil.NativeMethods.SP_DEVINFO_DATA A_1, int A_2, int A_3, int A_4, int A_5);

		// Token: 0x06000065 RID: 101
		[global::System.Runtime.InteropServices.DllImport("advapi32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode)]
		internal static extern int RegOpenKeyEx(global::System.UIntPtr A_0, string A_1, int A_2, int A_3, out global::System.UIntPtr A_4);

		// Token: 0x06000066 RID: 102
		[global::System.Runtime.InteropServices.DllImport("advapi32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, SetLastError = true)]
		internal static extern int RegQueryValueEx(global::System.IntPtr A_0, string A_1, global::System.IntPtr A_2, global::System.IntPtr A_3, global::System.IntPtr A_4, ref uint A_5);

		// Token: 0x06000067 RID: 103
		[global::System.Runtime.InteropServices.DllImport("advapi32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, SetLastError = true)]
		internal static extern int RegCloseKey(global::System.IntPtr A_0);

		// Token: 0x06000068 RID: 104
		[global::System.Runtime.InteropServices.DllImport("advapi32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, SetLastError = true)]
		internal static extern bool SetServiceStatus(global::System.IntPtr A_0, ref global::Motorola.Common.Communication.CommonUtil.NativeMethods.SERVICE_STATUS A_1);

		// Token: 0x06000069 RID: 105
		[global::System.Runtime.InteropServices.DllImport("advapi32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, SetLastError = true)]
		internal static extern global::System.IntPtr RegisterServiceCtrlHandlerEx(string A_0, global::Motorola.Common.Communication.CommonUtil.NativeMethods.CtrHandleCallback A_1, global::System.IntPtr A_2);

		// Token: 0x0600006A RID: 106
		[global::System.Runtime.InteropServices.DllImport("advapi32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, SetLastError = true)]
		internal static extern global::System.IntPtr OpenSCManager(string A_0, string A_1, uint A_2);

		// Token: 0x0600006B RID: 107
		[global::System.Runtime.InteropServices.DllImport("advapi32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, SetLastError = true)]
		internal static extern bool EnumServicesStatusEx(global::System.IntPtr A_0, uint A_1, uint A_2, uint A_3, global::System.IntPtr A_4, uint A_5, out uint A_6, out uint A_7, ref uint A_8, string A_9);

		// Token: 0x0600006C RID: 108
		[global::System.Runtime.InteropServices.DllImport("advapi32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, SetLastError = true)]
		internal static extern bool CloseServiceHandle(global::System.IntPtr A_0);

		// Token: 0x0600006D RID: 109
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, SetLastError = true)]
		internal static extern uint GetCurrentProcessId();

		// Token: 0x0600006E RID: 110
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
		internal static extern uint WaitForSingleObject(global::System.IntPtr A_0, uint A_1);

		// Token: 0x0600006F RID: 111
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
		internal static extern int SetEvent(global::System.IntPtr A_0);

		// Token: 0x06000070 RID: 112
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
		internal static extern int ResetEvent(global::System.IntPtr A_0);

		// Token: 0x06000071 RID: 113
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, SetLastError = true)]
		internal static extern global::System.IntPtr CreateEvent(global::System.IntPtr A_0, int A_1, int A_2, global::System.IntPtr A_3);

		// Token: 0x06000072 RID: 114
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
		internal static extern int EscapeCommFunction(global::System.IntPtr A_0, uint A_1);

		// Token: 0x06000073 RID: 115
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
		internal static extern int SetCommTimeouts(global::System.IntPtr A_0, ref global::Motorola.Common.Communication.CommonUtil.NativeMethods.CommTimeouts A_1);

		// Token: 0x06000074 RID: 116
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
		internal static extern int GetCommState(global::System.IntPtr A_0, ref global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB A_1);

		// Token: 0x06000075 RID: 117
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
		internal static extern int SetCommState(global::System.IntPtr A_0, ref global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB A_1);

		// Token: 0x06000076 RID: 118
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
		internal static extern int SetupComm(global::System.IntPtr A_0, uint A_1, uint A_2);

		// Token: 0x06000077 RID: 119 RVA: 0x00007CAC File Offset: 0x00005EAC
		internal unsafe static int b(global::System.IntPtr A_0, byte* A_1, uint A_2, global::System.IntPtr A_3, global::System.IntPtr A_4, ref int A_5)
		{
			short num = (short)1358185349;
			short num2 = num;
			num = (short)403522437;
			switch (num2 == num)
			{
			}
			num = (short)1295777792;
			short num3 = num;
			num = (short)1823014912;
			if (num != 0)
			{
			}
			num = (short)1574961153;
			if (num != 0)
			{
			}
			int result = global::Motorola.Common.Communication.CommonUtil.NativeMethods.WriteFile(A_0, A_1, A_2, A_3, (global::System.Threading.NativeOverlapped*)((void*)A_4));
			A_5 = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
			return result;
		}

		// Token: 0x06000078 RID: 120
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
		private unsafe static extern int WriteFile(global::System.IntPtr A_0, byte* A_1, uint A_2, global::System.IntPtr A_3, global::System.Threading.NativeOverlapped* A_4);

		// Token: 0x06000079 RID: 121 RVA: 0x00007D6C File Offset: 0x00005F6C
		internal unsafe static int a(global::System.IntPtr A_0, byte* A_1, uint A_2, global::System.IntPtr A_3, global::System.IntPtr A_4, ref int A_5)
		{
			short num = (short)1932399216;
			short num2 = num;
			num = (short)116593264;
			switch (num2 == num)
			{
			}
			num = (short)2014904320;
			short num3 = num;
			num = (short)519962625;
			if (num != 0)
			{
			}
			num = (short)486735872;
			if (num != 0)
			{
			}
			int result = global::Motorola.Common.Communication.CommonUtil.NativeMethods.ReadFile(A_0, A_1, A_2, A_3, (global::System.Threading.NativeOverlapped*)((void*)A_4));
			A_5 = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
			return result;
		}

		// Token: 0x0600007A RID: 122
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
		private unsafe static extern int ReadFile(global::System.IntPtr A_0, byte* A_1, uint A_2, global::System.IntPtr A_3, global::System.Threading.NativeOverlapped* A_4);

		// Token: 0x0600007B RID: 123
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
		internal static extern int SetCommMask(global::System.IntPtr A_0, uint A_1);

		// Token: 0x0600007C RID: 124
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
		internal static extern int GetCommModemStatus(global::System.IntPtr A_0, ref uint A_1);

		// Token: 0x0600007D RID: 125
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
		internal static extern int ClearCommError(global::System.IntPtr A_0, ref uint A_1, ref global::Motorola.Common.Communication.CommonUtil.NativeMethods.CommStat A_2);

		// Token: 0x0600007E RID: 126
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, SetLastError = true)]
		internal static extern global::System.IntPtr CreateFile(string A_0, uint A_1, uint A_2, global::System.IntPtr A_3, uint A_4, uint A_5, global::System.IntPtr A_6);

		// Token: 0x0600007F RID: 127
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
		internal static extern int WaitCommEvent(global::System.IntPtr A_0, ref uint A_1, ref global::Motorola.Common.Communication.CommonUtil.NativeMethods.OVERLAPPED A_2);

		// Token: 0x06000080 RID: 128
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
		internal static extern int GetCommProperties(global::System.IntPtr A_0, ref global::Motorola.Common.Communication.CommonUtil.NativeMethods.COMMPROP A_1);

		// Token: 0x06000081 RID: 129
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
		internal static extern int GetOverlappedResult(global::System.IntPtr A_0, global::System.IntPtr A_1, ref uint A_2, int A_3);

		// Token: 0x06000082 RID: 130
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
		internal static extern int PurgeComm(global::System.IntPtr A_0, uint A_1);

		// Token: 0x06000083 RID: 131
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
		internal static extern uint GetFileType(global::System.IntPtr A_0);

		// Token: 0x06000084 RID: 132
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, SetLastError = true)]
		internal static extern uint GetDriveType(string lpRootPathName);

		// Token: 0x06000085 RID: 133
		[global::System.Runtime.InteropServices.DllImport("setupapi.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, SetLastError = true)]
		internal static extern int CM_Request_Device_Eject(uint A_0, global::System.UIntPtr A_1, global::System.UIntPtr A_2, uint A_3, uint A_4);

		// Token: 0x06000086 RID: 134
		[global::System.Runtime.InteropServices.DllImport("setupapi.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode)]
		internal static extern int CM_Query_And_Remove_SubTree(uint A_0, out global::Motorola.Common.Communication.CommonUtil.NativeMethods.PNP_VETO_TYPE A_1, global::System.Text.StringBuilder A_2, uint A_3, uint A_4);

		// Token: 0x06000087 RID: 135
		[global::System.Runtime.InteropServices.DllImport("setupapi.dll", SetLastError = true)]
		internal static extern int CM_Get_DevNode_Status(ref uint A_0, ref uint A_1, uint A_2, int A_3);

		// Token: 0x06000088 RID: 136
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
		internal static extern bool DeviceIoControl(global::System.IntPtr A_0, uint A_1, global::System.IntPtr A_2, uint A_3, global::System.IntPtr A_4, uint A_5, out uint A_6, global::System.IntPtr A_7);

		// Token: 0x06000089 RID: 137
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, SetLastError = true)]
		internal static extern bool IsWow64Process(global::System.IntPtr A_0, out bool A_1);

		// Token: 0x0600008A RID: 138
		[global::System.Runtime.InteropServices.DllImport("setupapi.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, SetLastError = true)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Bool)]
		internal static extern bool SetupDiClassGuidsFromName(string A_0, global::System.IntPtr A_1, int A_2, out int A_3);

		// Token: 0x0600008B RID: 139
		[global::System.Runtime.InteropServices.DllImport("setupapi.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, SetLastError = true)]
		internal static extern bool SetupDiEnumDeviceInfo(global::System.IntPtr A_0, uint A_1, ref global::Motorola.Common.Communication.CommonUtil.NativeMethods.SP_DEVINFO_DATA A_2);

		// Token: 0x0600008C RID: 140
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		internal static extern global::System.IntPtr GetDC(global::System.IntPtr A_0);

		// Token: 0x0600008D RID: 141
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		internal static extern int ReleaseDC(global::System.IntPtr A_0, global::System.IntPtr A_1);

		// Token: 0x0600008E RID: 142
		[global::System.Runtime.InteropServices.DllImport("gdi32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode)]
		internal static extern global::System.IntPtr CreateDC(string A_0, string A_1, string A_2, global::System.IntPtr A_3);

		// Token: 0x0600008F RID: 143
		[global::System.Runtime.InteropServices.DllImport("gdi32.dll")]
		internal static extern int GetDeviceCaps(global::System.IntPtr A_0, int A_1);

		// Token: 0x06000090 RID: 144
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		internal static extern bool SetProcessDPIAware();

		// Token: 0x06000091 RID: 145
		[global::System.Runtime.InteropServices.DllImport("Ws2_32.dll")]
		internal static extern int setsockopt(global::System.IntPtr A_0, int A_1, int A_2, ref int A_3, int A_4);

		// Token: 0x0400004B RID: 75
		public const uint OS_64_BIT = 64U;

		// Token: 0x0400004C RID: 76
		public const uint OS_32_BIT = 32U;

		// Token: 0x0400004D RID: 77
		public const string MOTO_GEMS_DEVICE = "VID_0CAD";

		// Token: 0x0400004E RID: 78
		public const string PORTABLE_DEVICE_IN_NORMAL_MODE = "PID_0100";

		// Token: 0x0400004F RID: 79
		public const string PORTABLE_DEVICE_IN_PROGRAM_MODE = "PID_9003";

		// Token: 0x04000050 RID: 80
		public const string MTM800E_DEVICE = "PID_9006";

		// Token: 0x04000051 RID: 81
		public const string PAIRED_DEVICE_INTERFACE_0 = "MI_00";

		// Token: 0x04000052 RID: 82
		public const string PAIRED_DEVICE_INTERFACE_1 = "MI_01";

		// Token: 0x04000053 RID: 83
		public const string GEMSTONE_BMP_DEVICE = "PID_9010";

		// Token: 0x04000054 RID: 84
		public const string MTM5400_DATABOX_DEVICE = "PID_9011";

		// Token: 0x04000055 RID: 85
		public const string ARAGORN_DEVICE_NORMAL = "PID_9012";

		// Token: 0x04000056 RID: 86
		public const string BOROMIR_DEVICE_NORMAL = "PID_9013";

		// Token: 0x04000057 RID: 87
		public const string MOTO_GEMS_DEVICE_ID = "0CAD";

		// Token: 0x04000058 RID: 88
		public const string PORTABLE_DEVICE_IN_NORMAL_MODE_ID = "0100";

		// Token: 0x04000059 RID: 89
		public const string PORTABLE_DEVICE_IN_PROGRAM_MODE_ID = "9003";

		// Token: 0x0400005A RID: 90
		public const string MTM800E_DEVICE_ID = "9006";

		// Token: 0x0400005B RID: 91
		public const string GEMSTONE_BMP_DEVICE_ID = "9010";

		// Token: 0x0400005C RID: 92
		public const string MTM5400_DEVICE_DATABOX_MODE_ID = "9011";

		// Token: 0x0400005D RID: 93
		public const string ARAGON_DEVICE_NORMAL_ID = "9012";

		// Token: 0x0400005E RID: 94
		public const string BOROMIR_DEVICE_NORMAL_ID = "9013";

		// Token: 0x0400005F RID: 95
		public const string MASS_STORAGE_DEVICE_ID = "MASS_STORAGE_RADIO";

		// Token: 0x04000060 RID: 96
		public const string RADIO_FLASHSTRAP_DESCRIPTOR = "Motorola TETRA FLASH programming loader";

		// Token: 0x04000061 RID: 97
		public const string RADIO_FLASHSTRAP_DESCRIPTOR_PART_ONE = "TETRA FLASH programming loader";

		// Token: 0x04000062 RID: 98
		public const int NOT_FOUND = -1;

		// Token: 0x04000063 RID: 99
		public const int IS_EQUAL = 0;

		// Token: 0x04000064 RID: 100
		public const int ERROR_SUCCESS = 0;

		// Token: 0x04000065 RID: 101
		public const int DEVICE_NOTIFY_ALL_INTERFACE_CLASSES = 4;

		// Token: 0x04000066 RID: 102
		public const int DBT_DEVTYP_VOLUME = 2;

		// Token: 0x04000067 RID: 103
		public const int DBT_DEVTYP_DEVICEINTERFACE = 5;

		// Token: 0x04000068 RID: 104
		public const int DBT_DEVTYP_HANDLE = 6;

		// Token: 0x04000069 RID: 105
		public const int WM_DEVICECHANGE = 537;

		// Token: 0x0400006A RID: 106
		public const int DBT_DEVICEARRIVAL = 32768;

		// Token: 0x0400006B RID: 107
		public const int DBT_DEVICEREMOVECOMPLETE = 32772;

		// Token: 0x0400006C RID: 108
		public const uint DEVICE_NOTIFY_WINDOW_HANDLE = 0U;

		// Token: 0x0400006D RID: 109
		public const uint DEVICE_NOTIFY_SERVICE_HANDLE = 1U;

		// Token: 0x0400006E RID: 110
		public const string VCOM_CLASS_INTERFACE = "9664C324-B905-4A34-B057-D97436E7B565";

		// Token: 0x0400006F RID: 111
		public const int DIGCF_PRESENT = 2;

		// Token: 0x04000070 RID: 112
		public const int DIGCF_DEVICEINTERFACE = 16;

		// Token: 0x04000071 RID: 113
		public const int INVALID_HANDLE_VALUE = -1;

		// Token: 0x04000072 RID: 114
		public const int ERROR_INSUFFICIENT_BUFFER = 122;

		// Token: 0x04000073 RID: 115
		public const int CR_SUCCESS = 0;

		// Token: 0x04000074 RID: 116
		public const int DICS_FLAG_GLOBAL = 1;

		// Token: 0x04000075 RID: 117
		public const int DIREG_DEV = 1;

		// Token: 0x04000076 RID: 118
		public const int STANDARD_RIGHTS_READ = 131072;

		// Token: 0x04000077 RID: 119
		public const int KEY_QUERY_VALUE = 1;

		// Token: 0x04000078 RID: 120
		public const int KEY_ENUMERATE_SUB_KEYS = 8;

		// Token: 0x04000079 RID: 121
		public const int KEY_NOTIFY = 16;

		// Token: 0x0400007A RID: 122
		public const int SYNCHRONIZE = 1048576;

		// Token: 0x0400007B RID: 123
		public const uint SERVICE_CONTROL_STOP = 1U;

		// Token: 0x0400007C RID: 124
		public const uint SERVICE_CONTROL_PAUSE = 2U;

		// Token: 0x0400007D RID: 125
		public const uint SERVICE_CONTROL_CONTINUE = 3U;

		// Token: 0x0400007E RID: 126
		public const uint SERVICE_CONTROL_INTERROGATE = 4U;

		// Token: 0x0400007F RID: 127
		public const uint SERVICE_CONTROL_SHUTDOWN = 5U;

		// Token: 0x04000080 RID: 128
		public const uint SERVICE_CONTROL_DEVICEEVENT = 11U;

		// Token: 0x04000081 RID: 129
		public const uint NO_ERROR = 0U;

		// Token: 0x04000082 RID: 130
		public const uint WAIT_ABANDONED = 128U;

		// Token: 0x04000083 RID: 131
		public const uint WAIT_OBJECT_0 = 0U;

		// Token: 0x04000084 RID: 132
		public const uint WAIT_TIMEOUT = 258U;

		// Token: 0x04000085 RID: 133
		public const uint WAIT_FAILED = 4294967295U;

		// Token: 0x04000086 RID: 134
		public const uint STANDARD_RIGHTS_REQUIRED = 983040U;

		// Token: 0x04000087 RID: 135
		public const uint SC_ENUM_PROCESS_INFO = 0U;

		// Token: 0x04000088 RID: 136
		public const int ERROR_MORE_DATA = 234;

		// Token: 0x04000089 RID: 137
		public const int DEVICE_NAME_LENGTH = 1024;

		// Token: 0x0400008A RID: 138
		public const int BUFFER_SIZE = 1024;

		// Token: 0x0400008B RID: 139
		public const uint GENERIC_READ = 2147483648U;

		// Token: 0x0400008C RID: 140
		public const uint GENERIC_WRITE = 1073741824U;

		// Token: 0x0400008D RID: 141
		public const uint OPEN_EXISTING = 3U;

		// Token: 0x0400008E RID: 142
		public const uint FILE_FLAG_OVERLAPPED = 1073741824U;

		// Token: 0x0400008F RID: 143
		public const uint FILE_ANY_ACCESS = 0U;

		// Token: 0x04000090 RID: 144
		public const uint FILE_SHARE_READ = 1U;

		// Token: 0x04000091 RID: 145
		public const uint FILE_SHARE_WRITE = 2U;

		// Token: 0x04000092 RID: 146
		public const uint FILE_TYPE_UNKNOWN = 0U;

		// Token: 0x04000093 RID: 147
		public const uint FILE_TYPE_DISK = 1U;

		// Token: 0x04000094 RID: 148
		public const uint FILE_TYPE_CHAR = 2U;

		// Token: 0x04000095 RID: 149
		public const uint FILE_TYPE_PIPE = 3U;

		// Token: 0x04000096 RID: 150
		public const uint FILE_TYPE_REMOTE = 32768U;

		// Token: 0x04000097 RID: 151
		public const uint PURGE_TXABORT = 1U;

		// Token: 0x04000098 RID: 152
		public const uint PURGE_RXABORT = 2U;

		// Token: 0x04000099 RID: 153
		public const uint PURGE_TXCLEAR = 4U;

		// Token: 0x0400009A RID: 154
		public const uint PURGE_RXCLEAR = 8U;

		// Token: 0x0400009B RID: 155
		public const uint ERROR_OPERATION_ABORTED = 995U;

		// Token: 0x0400009C RID: 156
		public const uint ERROR_IO_INCOMPLETE = 996U;

		// Token: 0x0400009D RID: 157
		public const uint ERROR_IO_PENDING = 997U;

		// Token: 0x0400009E RID: 158
		public const uint ERROR_INVALID_USER_BUFFER = 1784U;

		// Token: 0x0400009F RID: 159
		public const int ERROR_NO_MORE_ITEMS = 259;

		// Token: 0x040000A0 RID: 160
		public const uint DN_DISABLEABLE = 8192U;

		// Token: 0x040000A1 RID: 161
		public const uint DN_REMOVABLE = 16384U;

		// Token: 0x040000A2 RID: 162
		public const int USB_CTRL_COMMAND_SIZE = 8;

		// Token: 0x040000A3 RID: 163
		public const uint IO_USB_CTRL_REQUEST_CODE = 2147492995U;

		// Token: 0x040000A4 RID: 164
		public const uint IO_USB_CTRL_RESET_PORT = 2147492899U;

		// Token: 0x040000A5 RID: 165
		public const string USB_HUB_CLASS_INTERFACE = "F18A0E88-C30C-11D0-8815-00A0C906BED8";

		// Token: 0x040000A6 RID: 166
		public const int DIREG_DRV = 2;

		// Token: 0x040000A7 RID: 167
		public const int USB_PIPE_LIST_SIZE = 330;

		// Token: 0x040000A8 RID: 168
		public const int MAX_DESCRIPTOR_SIZE = 512;

		// Token: 0x040000A9 RID: 169
		public const byte STRING_DESCRIPTOR_TYPE = 3;

		// Token: 0x040000AA RID: 170
		public const uint IOCTL_USB_GET_NODE_CONNECTION_INFORMATION_EX = 2229320U;

		// Token: 0x040000AB RID: 171
		public const uint IOCTL_USB_GET_DESCRIPTOR_FROM_NODE_CONNECTION = 2229264U;

		// Token: 0x040000AC RID: 172
		public const uint IOCTL_USB_HUB_CYCLE_PORT = 2229316U;

		// Token: 0x040000AD RID: 173
		public const uint IOCTL_USB_USER_REQUEST = 2229304U;

		// Token: 0x040000AE RID: 174
		public const uint USBUSER_GET_BANDWIDTH_INFORMATION = 5U;

		// Token: 0x040000AF RID: 175
		public const uint METHOD_BUFFERED = 0U;

		// Token: 0x040000B0 RID: 176
		public const uint METHOD_IN_DIRECT = 1U;

		// Token: 0x040000B1 RID: 177
		public const uint METHOD_OUT_DIRECT = 2U;

		// Token: 0x040000B2 RID: 178
		public const uint METHOD_NEITHER = 3U;

		// Token: 0x040000B3 RID: 179
		public const uint FILE_DEVICE_FILE_SYSTEM = 9U;

		// Token: 0x040000B4 RID: 180
		public const uint FILE_DEVICE_MASS_STORAGE = 45U;

		// Token: 0x040000B5 RID: 181
		public const int SCSI_COMMAND_SIZE = 16;

		// Token: 0x040000B6 RID: 182
		public const int SPT_SENSE_LENGTH = 32;

		// Token: 0x040000B7 RID: 183
		public const byte SCSI_IOCTL_DATA_OUT = 0;

		// Token: 0x040000B8 RID: 184
		public const byte SCSI_IOCTL_DATA_IN = 1;

		// Token: 0x040000B9 RID: 185
		public const byte SCSI_IOCTL_DATA_UNSPECIFIED = 2;

		// Token: 0x040000BA RID: 186
		public const int DRIVERVERSION = 0;

		// Token: 0x040000BB RID: 187
		public const int TECHNOLOGY = 2;

		// Token: 0x040000BC RID: 188
		public const int HORZSIZE = 4;

		// Token: 0x040000BD RID: 189
		public const int VERTSIZE = 6;

		// Token: 0x040000BE RID: 190
		public const int HORZRES = 8;

		// Token: 0x040000BF RID: 191
		public const int VERTRES = 10;

		// Token: 0x040000C0 RID: 192
		public const int BITSPIXEL = 12;

		// Token: 0x040000C1 RID: 193
		public const int PLANES = 14;

		// Token: 0x040000C2 RID: 194
		public const int NUMBRUSHES = 16;

		// Token: 0x040000C3 RID: 195
		public const int NUMPENS = 18;

		// Token: 0x040000C4 RID: 196
		public const int NUMMARKERS = 20;

		// Token: 0x040000C5 RID: 197
		public const int NUMFONTS = 22;

		// Token: 0x040000C6 RID: 198
		public const int NUMCOLORS = 24;

		// Token: 0x040000C7 RID: 199
		public const int PDEVICESIZE = 26;

		// Token: 0x040000C8 RID: 200
		public const int CURVECAPS = 28;

		// Token: 0x040000C9 RID: 201
		public const int LINECAPS = 30;

		// Token: 0x040000CA RID: 202
		public const int POLYGONALCAPS = 32;

		// Token: 0x040000CB RID: 203
		public const int TEXTCAPS = 34;

		// Token: 0x040000CC RID: 204
		public const int CLIPCAPS = 36;

		// Token: 0x040000CD RID: 205
		public const int RASTERCAPS = 38;

		// Token: 0x040000CE RID: 206
		public const int ASPECTX = 40;

		// Token: 0x040000CF RID: 207
		public const int ASPECTY = 42;

		// Token: 0x040000D0 RID: 208
		public const int ASPECTXY = 44;

		// Token: 0x040000D1 RID: 209
		public const int SHADEBLENDCAPS = 45;

		// Token: 0x040000D2 RID: 210
		public const int LOGPIXELSX = 88;

		// Token: 0x040000D3 RID: 211
		public const int LOGPIXELSY = 90;

		// Token: 0x040000D4 RID: 212
		public const int SIZEPALETTE = 104;

		// Token: 0x040000D5 RID: 213
		public const int NUMRESERVED = 106;

		// Token: 0x040000D6 RID: 214
		public const int COLORRES = 108;

		// Token: 0x040000D7 RID: 215
		public const int PHYSICALWIDTH = 110;

		// Token: 0x040000D8 RID: 216
		public const int PHYSICALHEIGHT = 111;

		// Token: 0x040000D9 RID: 217
		public const int PHYSICALOFFSETX = 112;

		// Token: 0x040000DA RID: 218
		public const int PHYSICALOFFSETY = 113;

		// Token: 0x040000DB RID: 219
		public const int SCALINGFACTORX = 114;

		// Token: 0x040000DC RID: 220
		public const int SCALINGFACTORY = 115;

		// Token: 0x040000DD RID: 221
		public const int VREFRESH = 116;

		// Token: 0x040000DE RID: 222
		public const int DESKTOPVERTRES = 117;

		// Token: 0x040000DF RID: 223
		public const int DESKTOPHORZRES = 118;

		// Token: 0x040000E0 RID: 224
		public const int BLTALIGNMENT = 119;

		// Token: 0x040000E1 RID: 225
		public const int SERVICE_NO_CHANGE = -1;

		// Token: 0x02000016 RID: 22
		// (Invoke) Token: 0x06000093 RID: 147
		public delegate uint CtrHandleCallback(uint control, uint eventType, global::System.IntPtr eventData, global::System.IntPtr context);

		// Token: 0x02000017 RID: 23
		public enum State : uint
		{
			// Token: 0x040000E3 RID: 227
			SERVICE_NONE,
			// Token: 0x040000E4 RID: 228
			SERVICE_STOPPED,
			// Token: 0x040000E5 RID: 229
			SERVICE_START_PENDING,
			// Token: 0x040000E6 RID: 230
			SERVICE_STOP_PENDING,
			// Token: 0x040000E7 RID: 231
			SERVICE_RUNNING,
			// Token: 0x040000E8 RID: 232
			SERVICE_CONTINUE_PENDING,
			// Token: 0x040000E9 RID: 233
			SERVICE_PAUSE_PENDING,
			// Token: 0x040000EA RID: 234
			SERVICE_PAUSED
		}

		// Token: 0x02000018 RID: 24
		public enum ServiceControlManagerType : uint
		{
			// Token: 0x040000EC RID: 236
			SC_MANAGER_NONE,
			// Token: 0x040000ED RID: 237
			SC_MANAGER_CONNECT,
			// Token: 0x040000EE RID: 238
			SC_MANAGER_CREATE_SERVICE,
			// Token: 0x040000EF RID: 239
			SC_MANAGER_ENUMERATE_SERVICE = 4U,
			// Token: 0x040000F0 RID: 240
			SC_MANAGER_LOCK = 8U,
			// Token: 0x040000F1 RID: 241
			SC_MANAGER_QUERY_LOCK_STATUS = 16U,
			// Token: 0x040000F2 RID: 242
			SC_MANAGER_MODIFY_BOOT_CONFIG = 32U,
			// Token: 0x040000F3 RID: 243
			SC_MANAGER_ALL_ACCESS = 983103U
		}

		// Token: 0x02000019 RID: 25
		public enum ServiceType
		{
			// Token: 0x040000F5 RID: 245
			SERVICE_NONE,
			// Token: 0x040000F6 RID: 246
			SERVICE_KERNEL_DRIVER,
			// Token: 0x040000F7 RID: 247
			SERVICE_FILE_SYSTEM_DRIVER,
			// Token: 0x040000F8 RID: 248
			SERVICE_WIN32_OWN_PROCESS = 16,
			// Token: 0x040000F9 RID: 249
			SERVICE_WIN32_SHARE_PROCESS = 32,
			// Token: 0x040000FA RID: 250
			SERVICE_INTERACTIVE_PROCESS = 256,
			// Token: 0x040000FB RID: 251
			SERVICETYPE_NO_CHANGE = -1,
			// Token: 0x040000FC RID: 252
			SERVICE_WIN32 = 48
		}

		// Token: 0x0200001A RID: 26
		public enum ServiceStateRequest : uint
		{
			// Token: 0x040000FE RID: 254
			SERVICE_NONE,
			// Token: 0x040000FF RID: 255
			SERVICE_ACTIVE,
			// Token: 0x04000100 RID: 256
			SERVICE_INACTIVE,
			// Token: 0x04000101 RID: 257
			SERVICE_STATE_ALL
		}

		// Token: 0x0200001B RID: 27
		public enum WinDriveType : uint
		{
			// Token: 0x04000103 RID: 259
			DRIVE_UNKNOWN,
			// Token: 0x04000104 RID: 260
			DRIVE_NO_ROOT_DIR,
			// Token: 0x04000105 RID: 261
			DRIVE_REMOVABLE,
			// Token: 0x04000106 RID: 262
			DRIVE_FIXED,
			// Token: 0x04000107 RID: 263
			DRIVE_REMOTE,
			// Token: 0x04000108 RID: 264
			DRIVE_CDROM,
			// Token: 0x04000109 RID: 265
			DRIVE_RAMDISK
		}

		// Token: 0x0200001C RID: 28
		[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 1)]
		public struct SERVICE_STATUS
		{
			// Token: 0x06000096 RID: 150 RVA: 0x00007E2C File Offset: 0x0000602C
			// Note: this type is marked as 'beforefieldinit'.
			static SERVICE_STATUS()
			{
				short num = (short)689504257;
				if (num != 0)
				{
				}
				num = (short)555686532;
				short num2 = num;
				num = (short)1191647876;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1296039936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1578565632;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.CommonUtil.NativeMethods.SERVICE_STATUS.SizeOf = global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::Motorola.Common.Communication.CommonUtil.NativeMethods.SERVICE_STATUS));
			}

			// Token: 0x0400010A RID: 266
			public static readonly int SizeOf;

			// Token: 0x0400010B RID: 267
			public uint serviceType;

			// Token: 0x0400010C RID: 268
			public uint currentState;

			// Token: 0x0400010D RID: 269
			public uint controlsAccepted;

			// Token: 0x0400010E RID: 270
			public uint win32ExitCode;

			// Token: 0x0400010F RID: 271
			public uint serviceSpecificExitCode;

			// Token: 0x04000110 RID: 272
			public uint checkPoint;

			// Token: 0x04000111 RID: 273
			public uint waitHint;
		}

		// Token: 0x0200001D RID: 29
		[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = global::System.Runtime.InteropServices.CharSet.Unicode)]
		public struct DEV_BROADCAST_HDR
		{
			// Token: 0x04000112 RID: 274
			public uint dbcc_size;

			// Token: 0x04000113 RID: 275
			public uint dbcc_devicetype;

			// Token: 0x04000114 RID: 276
			public uint dbcc_reserved;
		}

		// Token: 0x0200001E RID: 30
		[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = global::System.Runtime.InteropServices.CharSet.Unicode)]
		public struct DEV_BROADCAST_VOLUME
		{
			// Token: 0x04000115 RID: 277
			public uint dbcc_size;

			// Token: 0x04000116 RID: 278
			public uint dbcc_devicetype;

			// Token: 0x04000117 RID: 279
			public uint dbcc_reserved;

			// Token: 0x04000118 RID: 280
			public uint dbcv_unitmask;

			// Token: 0x04000119 RID: 281
			public ushort dbcv_flags;
		}

		// Token: 0x0200001F RID: 31
		[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = global::System.Runtime.InteropServices.CharSet.Unicode)]
		public struct DEV_BROADCAST_DEVICEINTERFACE
		{
			// Token: 0x0400011A RID: 282
			public uint dbcc_size;

			// Token: 0x0400011B RID: 283
			public uint dbcc_devicetype;

			// Token: 0x0400011C RID: 284
			public uint dbcc_reserved;

			// Token: 0x0400011D RID: 285
			public global::System.Guid dbcc_classguid;

			// Token: 0x0400011E RID: 286
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 1024)]
			public string dbcc_name;
		}

		// Token: 0x02000020 RID: 32
		public struct SP_DEVICE_INTERFACE_DATA
		{
			// Token: 0x0400011F RID: 287
			public uint cbSize;

			// Token: 0x04000120 RID: 288
			public global::System.Guid InterfaceClassGuid;

			// Token: 0x04000121 RID: 289
			public uint Flags;

			// Token: 0x04000122 RID: 290
			internal global::System.IntPtr a;
		}

		// Token: 0x02000021 RID: 33
		[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = global::System.Runtime.InteropServices.CharSet.Unicode)]
		public struct SP_DEVICE_INTERFACE_DETAIL_DATA
		{
			// Token: 0x04000123 RID: 291
			public uint cbSize;

			// Token: 0x04000124 RID: 292
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 1024)]
			public string DevicePath;
		}

		// Token: 0x02000022 RID: 34
		[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, Pack = 1)]
		public struct SP_DEVICE_INTERFACE_DETAIL_DATA_V2_X86
		{
			// Token: 0x04000125 RID: 293
			public uint cbSize;

			// Token: 0x04000126 RID: 294
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 1)]
			public string DevicePath;
		}

		// Token: 0x02000023 RID: 35
		[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = global::System.Runtime.InteropServices.CharSet.Unicode)]
		public struct SP_DEVICE_INTERFACE_DETAIL_DATA_V2_X64
		{
			// Token: 0x04000127 RID: 295
			public uint cbSize;

			// Token: 0x04000128 RID: 296
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 1)]
			public string DevicePath;
		}

		// Token: 0x02000024 RID: 36
		public struct SP_DEVINFO_DATA
		{
			// Token: 0x04000129 RID: 297
			public uint cbSize;

			// Token: 0x0400012A RID: 298
			public global::System.Guid ClassGuid;

			// Token: 0x0400012B RID: 299
			public uint DevInst;

			// Token: 0x0400012C RID: 300
			internal global::System.IntPtr a;
		}

		// Token: 0x02000025 RID: 37
		[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 1)]
		public struct SERVICE_STATUS_PROCESS
		{
			// Token: 0x06000097 RID: 151 RVA: 0x00007EE8 File Offset: 0x000060E8
			// Note: this type is marked as 'beforefieldinit'.
			static SERVICE_STATUS_PROCESS()
			{
				short num = (short)935989745;
				short num2 = num;
				num = (short)1914376689;
				switch (num2 == num)
				{
				}
				num = (short)1318780928;
				short num3 = num;
				num = (short)352714752;
				if (num != 0)
				{
				}
				num = (short)946339841;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.CommonUtil.NativeMethods.SERVICE_STATUS_PROCESS.SizeOf = global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::Motorola.Common.Communication.CommonUtil.NativeMethods.SERVICE_STATUS_PROCESS));
			}

			// Token: 0x0400012D RID: 301
			public static readonly int SizeOf;

			// Token: 0x0400012E RID: 302
			public uint dwServiceType;

			// Token: 0x0400012F RID: 303
			public uint dwCurrentState;

			// Token: 0x04000130 RID: 304
			public uint dwControlsAccepted;

			// Token: 0x04000131 RID: 305
			public uint dwWin32ExitCode;

			// Token: 0x04000132 RID: 306
			public uint dwServiceSpecificExitCode;

			// Token: 0x04000133 RID: 307
			public uint dwCheckPoint;

			// Token: 0x04000134 RID: 308
			public uint dwWaitHint;

			// Token: 0x04000135 RID: 309
			public uint dwProcessId;

			// Token: 0x04000136 RID: 310
			public uint dwServiceFlags;
		}

		// Token: 0x02000026 RID: 38
		[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 1)]
		public struct ENUM_SERVICE_STATUS_PROCESS
		{
			// Token: 0x06000098 RID: 152 RVA: 0x00007FA4 File Offset: 0x000061A4
			// Note: this type is marked as 'beforefieldinit'.
			static ENUM_SERVICE_STATUS_PROCESS()
			{
				short num = (short)352231327;
				short num2 = num;
				num = (short)928489375;
				switch (num2 == num)
				{
				}
				num = (short)690225152;
				short num3 = num;
				num = (short)1705705473;
				if (num != 0)
				{
				}
				num = (short)7536640;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.CommonUtil.NativeMethods.ENUM_SERVICE_STATUS_PROCESS.SizeOf = global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::Motorola.Common.Communication.CommonUtil.NativeMethods.ENUM_SERVICE_STATUS_PROCESS));
			}

			// Token: 0x04000137 RID: 311
			public static readonly int SizeOf;

			// Token: 0x04000138 RID: 312
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)]
			public string pServiceName;

			// Token: 0x04000139 RID: 313
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)]
			public string pDisplayName;

			// Token: 0x0400013A RID: 314
			public global::Motorola.Common.Communication.CommonUtil.NativeMethods.SERVICE_STATUS_PROCESS ServiceStatus;
		}

		// Token: 0x02000027 RID: 39
		public enum DtrControl
		{
			// Token: 0x0400013C RID: 316
			Disable,
			// Token: 0x0400013D RID: 317
			Enable,
			// Token: 0x0400013E RID: 318
			Handshake
		}

		// Token: 0x02000028 RID: 40
		public enum RtsControl
		{
			// Token: 0x04000140 RID: 320
			Disable,
			// Token: 0x04000141 RID: 321
			Enable,
			// Token: 0x04000142 RID: 322
			Handshake,
			// Token: 0x04000143 RID: 323
			Toggle
		}

		// Token: 0x02000029 RID: 41
		public struct DCB
		{
			// Token: 0x06000099 RID: 153 RVA: 0x00008060 File Offset: 0x00006260
			private static int m()
			{
				short num = (short)103043912;
				short num2 = num;
				num = (short)1198674760;
				switch (num2 == num)
				{
				}
				num = (short)1850212352;
				short num3 = num;
				num = (short)1697906688;
				if (num != 0)
				{
				}
				num = (short)1809448961;
				if (num != 0)
				{
				}
				return global::System.Collections.Specialized.BitVector32.CreateMask();
			}

			// Token: 0x0600009A RID: 154 RVA: 0x0000810C File Offset: 0x0000630C
			private static int l()
			{
				short num = (short)861031576;
				short num2 = num;
				num = (short)1985432728;
				switch (num2 == num)
				{
				}
				num = (short)1443168256;
				short num3 = num;
				num = (short)1980825601;
				if (num != 0)
				{
				}
				num = (short)62783488;
				if (num != 0)
				{
				}
				return global::System.Collections.Specialized.BitVector32.CreateMask(global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.m());
			}

			// Token: 0x0600009B RID: 155 RVA: 0x000081C0 File Offset: 0x000063C0
			private static int k()
			{
				short num = (short)448951346;
				short num2 = num;
				num = (short)1162179634;
				switch (num2 == num)
				{
				}
				num = (short)107479040;
				short num3 = num;
				num = (short)831389697;
				if (num != 0)
				{
				}
				num = (short)1010958336;
				if (num != 0)
				{
				}
				return global::System.Collections.Specialized.BitVector32.CreateMask(global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.l());
			}

			// Token: 0x0600009C RID: 156 RVA: 0x00008274 File Offset: 0x00006474
			private static int j()
			{
				short num = (short)683732500;
				short num2 = num;
				num = (short)887614996;
				switch (num2 == num)
				{
				}
				num = (short)817299456;
				short num3 = num;
				num = (short)253689857;
				if (num != 0)
				{
				}
				num = (short)966328320;
				if (num != 0)
				{
				}
				return global::System.Collections.Specialized.BitVector32.CreateMask(global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.k());
			}

			// Token: 0x0600009D RID: 157 RVA: 0x00008328 File Offset: 0x00006528
			private static int i()
			{
				short num = (short)253252283;
				short num2 = num;
				num = (short)1635930811;
				switch (num2 == num)
				{
				}
				num = (short)659881984;
				short num3 = num;
				num = (short)470024193;
				if (num != 0)
				{
				}
				num = (short)133890048;
				if (num != 0)
				{
				}
				return global::System.Collections.Specialized.BitVector32.CreateMask(global::System.Collections.Specialized.BitVector32.CreateMask(global::System.Collections.Specialized.BitVector32.CreateMask(global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.j())));
			}

			// Token: 0x0600009E RID: 158 RVA: 0x000083E8 File Offset: 0x000065E8
			private static int h()
			{
				short num = (short)765200846;
				short num2 = num;
				num = (short)1366559182;
				switch (num2 == num)
				{
				}
				num = (short)702021632;
				short num3 = num;
				num = (short)102498305;
				if (num != 0)
				{
				}
				num = (short)742588416;
				if (num != 0)
				{
				}
				return global::System.Collections.Specialized.BitVector32.CreateMask(global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.i());
			}

			// Token: 0x0600009F RID: 159 RVA: 0x0000849C File Offset: 0x0000669C
			private static int g()
			{
				short num = (short)1711823774;
				short num2 = num;
				num = (short)777608094;
				switch (num2 == num)
				{
				}
				num = (short)6619136;
				short num3 = num;
				num = (short)1719271425;
				if (num != 0)
				{
				}
				num = (short)1247936512;
				if (num != 0)
				{
				}
				return global::System.Collections.Specialized.BitVector32.CreateMask(global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.h());
			}

			// Token: 0x060000A0 RID: 160 RVA: 0x00008550 File Offset: 0x00006750
			private static int f()
			{
				short num = (short)2021618801;
				short num2 = num;
				num = (short)569734257;
				switch (num2 == num)
				{
				}
				num = (short)123207680;
				short num3 = num;
				num = (short)1235353601;
				if (num != 0)
				{
				}
				num = (short)1840185344;
				if (num != 0)
				{
				}
				return global::System.Collections.Specialized.BitVector32.CreateMask(global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.g());
			}

			// Token: 0x060000A1 RID: 161 RVA: 0x00008604 File Offset: 0x00006804
			private static int e()
			{
				short num = (short)1719348035;
				short num2 = num;
				num = (short)1301293891;
				switch (num2 == num)
				{
				}
				num = (short)477233152;
				short num3 = num;
				num = (short)1556676608;
				if (num != 0)
				{
				}
				num = (short)1876754433;
				if (num != 0)
				{
				}
				return global::System.Collections.Specialized.BitVector32.CreateMask(global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.f());
			}

			// Token: 0x060000A2 RID: 162 RVA: 0x000086BC File Offset: 0x000068BC
			private static int d()
			{
				short num = (short)458061146;
				short num2 = num;
				num = (short)1757377882;
				switch (num2 == num)
				{
				}
				num = (short)1858928640;
				short num3 = num;
				num = (short)1590034433;
				if (num != 0)
				{
				}
				num = (short)1422589952;
				if (num != 0)
				{
				}
				return global::System.Collections.Specialized.BitVector32.CreateMask(global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.e());
			}

			// Token: 0x060000A3 RID: 163 RVA: 0x00008770 File Offset: 0x00006970
			private static int c()
			{
				short num = (short)1242774137;
				short num2 = num;
				num = (short)94845561;
				switch (num2 == num)
				{
				}
				num = (short)410517504;
				short num3 = num;
				num = (short)241893377;
				if (num != 0)
				{
				}
				num = (short)1951399936;
				if (num != 0)
				{
				}
				return global::System.Collections.Specialized.BitVector32.CreateMask(global::System.Collections.Specialized.BitVector32.CreateMask(global::System.Collections.Specialized.BitVector32.CreateMask(global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.d())));
			}

			// Token: 0x060000A4 RID: 164 RVA: 0x0000882C File Offset: 0x00006A2C
			private static global::System.Collections.Specialized.BitVector32.Section b()
			{
				short num = (short)1906402487;
				short num2 = num;
				num = (short)1846240439;
				switch (num2 == num)
				{
				}
				num = (short)23592960;
				short num3 = num;
				num = (short)974651393;
				if (num != 0)
				{
				}
				num = (short)673251328;
				if (num != 0)
				{
				}
				global::System.Collections.Specialized.BitVector32.Section previous = global::System.Collections.Specialized.BitVector32.CreateSection(1);
				previous = global::System.Collections.Specialized.BitVector32.CreateSection(1, previous);
				previous = global::System.Collections.Specialized.BitVector32.CreateSection(1, previous);
				previous = global::System.Collections.Specialized.BitVector32.CreateSection(1, previous);
				return global::System.Collections.Specialized.BitVector32.CreateSection(2, previous);
			}

			// Token: 0x060000A5 RID: 165 RVA: 0x00008900 File Offset: 0x00006B00
			private static global::System.Collections.Specialized.BitVector32.Section a()
			{
				short num = (short)902432389;
				short num2 = num;
				num = (short)1380517509;
				switch (num2 == num)
				{
				}
				num = (short)197328896;
				short num3 = num;
				num = (short)673513472;
				if (num != 0)
				{
				}
				num = (short)316407809;
				if (num != 0)
				{
				}
				global::System.Collections.Specialized.BitVector32.Section previous = global::System.Collections.Specialized.BitVector32.CreateSection(1, global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.b());
				previous = global::System.Collections.Specialized.BitVector32.CreateSection(1, previous);
				previous = global::System.Collections.Specialized.BitVector32.CreateSection(1, previous);
				previous = global::System.Collections.Specialized.BitVector32.CreateSection(1, previous);
				previous = global::System.Collections.Specialized.BitVector32.CreateSection(1, previous);
				previous = global::System.Collections.Specialized.BitVector32.CreateSection(1, previous);
				global::System.Collections.Specialized.BitVector32.Section section = global::System.Collections.Specialized.BitVector32.CreateSection(3, previous);
				previous = global::System.Collections.Specialized.BitVector32.CreateSection(1, section);
				return section;
			}

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x060000A6 RID: 166 RVA: 0x000089F0 File Offset: 0x00006BF0
			// (set) Token: 0x060000A7 RID: 167 RVA: 0x00008AAC File Offset: 0x00006CAC
			public bool Binary
			{
				get
				{
					short num = (short)402552514;
					short num2 = num;
					num = (short)729642690;
					switch (num2 == num)
					{
					}
					num = (short)284426240;
					short num3 = num;
					num = (short)283836416;
					if (num != 0)
					{
					}
					num = (short)1571422209;
					if (num != 0)
					{
					}
					return this.a[global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.d];
				}
				set
				{
					short num = (short)66728932;
					short num2 = num;
					num = (short)383005668;
					switch (num2 == num)
					{
					}
					num = (short)539099136;
					short num3 = num;
					num = (short)19464193;
					if (num != 0)
					{
					}
					num = (short)1736507392;
					if (num != 0)
					{
					}
					this.a[global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.d] = value;
				}
			}

			// Token: 0x1700001B RID: 27
			// (get) Token: 0x060000A8 RID: 168 RVA: 0x00008B68 File Offset: 0x00006D68
			// (set) Token: 0x060000A9 RID: 169 RVA: 0x00008C20 File Offset: 0x00006E20
			public bool CheckParity
			{
				get
				{
					short num = (short)1196324390;
					short num2 = num;
					num = (short)333870630;
					switch (num2 == num)
					{
					}
					num = (short)1145438208;
					short num3 = num;
					num = (short)1069940737;
					if (num != 0)
					{
					}
					num = (short)1008795648;
					if (num != 0)
					{
					}
					return this.a[global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.e];
				}
				set
				{
					short num = (short)1692325695;
					short num2 = num;
					num = (short)1603786559;
					switch (num2 == num)
					{
					}
					num = (short)1256849408;
					short num3 = num;
					num = (short)528220160;
					if (num != 0)
					{
					}
					num = (short)412221441;
					if (num != 0)
					{
					}
					this.a[global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.e] = value;
				}
			}

			// Token: 0x1700001C RID: 28
			// (get) Token: 0x060000AA RID: 170 RVA: 0x00008CDC File Offset: 0x00006EDC
			// (set) Token: 0x060000AB RID: 171 RVA: 0x00008D98 File Offset: 0x00006F98
			public bool OutxCtsFlow
			{
				get
				{
					short num = (short)1931629879;
					short num2 = num;
					num = (short)972248375;
					switch (num2 == num)
					{
					}
					num = (short)737476608;
					short num3 = num;
					num = (short)919928833;
					if (num != 0)
					{
					}
					num = (short)1124532224;
					if (num != 0)
					{
					}
					return this.a[global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.f];
				}
				set
				{
					short num = (short)467414701;
					short num2 = num;
					num = (short)1591422637;
					switch (num2 == num)
					{
					}
					num = (short)1004077056;
					short num3 = num;
					num = (short)1798373377;
					if (num != 0)
					{
					}
					num = (short)190316544;
					if (num != 0)
					{
					}
					this.a[global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.f] = value;
				}
			}

			// Token: 0x1700001D RID: 29
			// (get) Token: 0x060000AC RID: 172 RVA: 0x00008E54 File Offset: 0x00007054
			// (set) Token: 0x060000AD RID: 173 RVA: 0x00008F0C File Offset: 0x0000710C
			public bool OutxDsrFlow
			{
				get
				{
					short num = (short)645141260;
					short num2 = num;
					num = (short)1143673612;
					switch (num2 == num)
					{
					}
					num = (short)322174976;
					short num3 = num;
					num = (short)791347201;
					if (num != 0)
					{
					}
					num = (short)1936785408;
					if (num != 0)
					{
					}
					return this.a[global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.g];
				}
				set
				{
					short num = (short)1303997724;
					short num2 = num;
					num = (short)1820552476;
					switch (num2 == num)
					{
					}
					num = (short)1385889792;
					short num3 = num;
					num = (short)1105920001;
					if (num != 0)
					{
					}
					num = (short)1533280256;
					if (num != 0)
					{
					}
					this.a[global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.g] = value;
				}
			}

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x060000AE RID: 174 RVA: 0x00008FC8 File Offset: 0x000071C8
			// (set) Token: 0x060000AF RID: 175 RVA: 0x00009084 File Offset: 0x00007284
			public global::Motorola.Common.Communication.CommonUtil.NativeMethods.DtrControl DtrControl
			{
				get
				{
					short num = (short)1347352894;
					short num2 = num;
					num = (short)1307441470;
					switch (num2 == num)
					{
					}
					num = (short)1212416000;
					short num3 = num;
					num = (short)1047003136;
					if (num != 0)
					{
					}
					num = (short)956956673;
					if (num != 0)
					{
					}
					return (global::Motorola.Common.Communication.CommonUtil.NativeMethods.DtrControl)this.a[global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.h];
				}
				set
				{
					short num = (short)967687829;
					short num2 = num;
					num = (short)493141653;
					switch (num2 == num)
					{
					}
					num = (short)1942814720;
					short num3 = num;
					num = (short)2022113281;
					if (num != 0)
					{
					}
					num = (short)149749760;
					if (num != 0)
					{
					}
					this.a[global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.h] = (int)value;
				}
			}

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x060000B0 RID: 176 RVA: 0x00009140 File Offset: 0x00007340
			// (set) Token: 0x060000B1 RID: 177 RVA: 0x000091F8 File Offset: 0x000073F8
			public bool DsrSensitivity
			{
				get
				{
					short num = (short)1775040763;
					short num2 = num;
					num = (short)984414459;
					switch (num2 == num)
					{
					}
					num = (short)1350238208;
					short num3 = num;
					num = (short)1624899585;
					if (num != 0)
					{
					}
					num = (short)2119761920;
					if (num != 0)
					{
					}
					return this.a[global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.i];
				}
				set
				{
					short num = (short)1445139156;
					short num2 = num;
					num = (short)533730004;
					switch (num2 == num)
					{
					}
					num = (short)193462272;
					short num3 = num;
					num = (short)1792999425;
					if (num != 0)
					{
					}
					num = (short)1765670912;
					if (num != 0)
					{
					}
					this.a[global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.i] = value;
				}
			}

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x060000B2 RID: 178 RVA: 0x000092B4 File Offset: 0x000074B4
			// (set) Token: 0x060000B3 RID: 179 RVA: 0x00009370 File Offset: 0x00007570
			public bool TxContinueOnXoff
			{
				get
				{
					short num = (short)1119285423;
					short num2 = num;
					num = (short)1193406639;
					switch (num2 == num)
					{
					}
					num = (short)446103552;
					short num3 = num;
					num = (short)1000865793;
					if (num != 0)
					{
					}
					num = (short)712376320;
					if (num != 0)
					{
					}
					return this.a[global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.j];
				}
				set
				{
					short num = (short)269687760;
					short num2 = num;
					num = (short)1074600912;
					switch (num2 == num)
					{
					}
					num = (short)660013056;
					short num3 = num;
					num = (short)676921345;
					if (num != 0)
					{
					}
					num = (short)459538432;
					if (num != 0)
					{
					}
					this.a[global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.j] = value;
				}
			}

			// Token: 0x17000021 RID: 33
			// (get) Token: 0x060000B4 RID: 180 RVA: 0x0000942C File Offset: 0x0000762C
			// (set) Token: 0x060000B5 RID: 181 RVA: 0x000094E4 File Offset: 0x000076E4
			public bool OutX
			{
				get
				{
					short num = (short)1340181543;
					short num2 = num;
					num = (short)1963035687;
					switch (num2 == num)
					{
					}
					num = (short)778829824;
					short num3 = num;
					num = (short)1478361088;
					if (num != 0)
					{
					}
					num = (short)1156251649;
					if (num != 0)
					{
					}
					return this.a[global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.k];
				}
				set
				{
					short num = (short)1650212651;
					short num2 = num;
					num = (short)1333673771;
					switch (num2 == num)
					{
					}
					num = (short)1646395392;
					short num3 = num;
					num = (short)876412929;
					if (num != 0)
					{
					}
					num = (short)730398720;
					if (num != 0)
					{
					}
					this.a[global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.k] = value;
				}
			}

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x060000B6 RID: 182 RVA: 0x000095A0 File Offset: 0x000077A0
			// (set) Token: 0x060000B7 RID: 183 RVA: 0x00009658 File Offset: 0x00007858
			public bool InX
			{
				get
				{
					short num = (short)92781561;
					short num2 = num;
					num = (short)1614199801;
					switch (num2 == num)
					{
					}
					num = (short)509280256;
					short num3 = num;
					num = (short)1790967809;
					if (num != 0)
					{
					}
					num = (short)496304128;
					if (num != 0)
					{
					}
					return this.a[global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.l];
				}
				set
				{
					short num = (short)249102336;
					short num2 = num;
					num = (short)796328627;
					short num3 = num;
					num = (short)869728947;
					switch (num3 == num)
					{
					}
					num = (short)2099904512;
					if (num != 0)
					{
					}
					num = (short)2080964609;
					if (num != 0)
					{
					}
					this.a[global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.l] = value;
				}
			}

			// Token: 0x17000023 RID: 35
			// (get) Token: 0x060000B8 RID: 184 RVA: 0x00009714 File Offset: 0x00007914
			// (set) Token: 0x060000B9 RID: 185 RVA: 0x000097CC File Offset: 0x000079CC
			public bool ReplaceErrorChar
			{
				get
				{
					short num = (short)344064000;
					short num2 = num;
					num = (short)1318293715;
					short num3 = num;
					num = (short)1847169235;
					switch (num3 == num)
					{
					}
					num = (short)1973026817;
					if (num != 0)
					{
					}
					num = (short)2089877504;
					if (num != 0)
					{
					}
					return this.a[global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.m];
				}
				set
				{
					short num = (short)401276928;
					short num2 = num;
					num = (short)651549129;
					short num3 = num;
					num = (short)46651849;
					switch (num3 == num)
					{
					}
					num = (short)534577153;
					if (num != 0)
					{
					}
					num = (short)245301248;
					if (num != 0)
					{
					}
					this.a[global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.m] = value;
				}
			}

			// Token: 0x17000024 RID: 36
			// (get) Token: 0x060000BA RID: 186 RVA: 0x00009888 File Offset: 0x00007A88
			// (set) Token: 0x060000BB RID: 187 RVA: 0x00009944 File Offset: 0x00007B44
			public bool Null
			{
				get
				{
					short num = (short)1591148544;
					short num2 = num;
					num = (short)458925886;
					short num3 = num;
					num = (short)1460578110;
					switch (num3 == num)
					{
					}
					num = (short)1337458689;
					if (num != 0)
					{
					}
					num = (short)1730281472;
					if (num != 0)
					{
					}
					return this.a[global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.n];
				}
				set
				{
					short num = (short)2109538304;
					short num2 = num;
					num = (short)1712727831;
					short num3 = num;
					num = (short)1255745303;
					switch (num3 == num)
					{
					}
					num = (short)1706819584;
					if (num != 0)
					{
					}
					num = (short)391184385;
					if (num != 0)
					{
					}
					this.a[global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.n] = value;
				}
			}

			// Token: 0x17000025 RID: 37
			// (get) Token: 0x060000BC RID: 188 RVA: 0x00009A00 File Offset: 0x00007C00
			// (set) Token: 0x060000BD RID: 189 RVA: 0x00009AC0 File Offset: 0x00007CC0
			public global::Motorola.Common.Communication.CommonUtil.NativeMethods.RtsControl RtsControl
			{
				get
				{
					short num = (short)1879769088;
					short num2 = num;
					num = (short)11858360;
					short num3 = num;
					num = (short)781906360;
					switch (num3 == num)
					{
					}
					num = (short)1459486721;
					if (num != 0)
					{
					}
					num = (short)693501952;
					if (num != 0)
					{
					}
					return (global::Motorola.Common.Communication.CommonUtil.NativeMethods.RtsControl)this.a[global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.o];
				}
				set
				{
					short num = (short)1190658048;
					short num2 = num;
					num = (short)179424558;
					short num3 = num;
					num = (short)1585499438;
					switch (num3 == num)
					{
					}
					num = (short)1906638849;
					if (num != 0)
					{
					}
					num = (short)1138950144;
					if (num != 0)
					{
					}
					this.a[global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.o] = (int)value;
				}
			}

			// Token: 0x17000026 RID: 38
			// (get) Token: 0x060000BE RID: 190 RVA: 0x00009B78 File Offset: 0x00007D78
			// (set) Token: 0x060000BF RID: 191 RVA: 0x00009C34 File Offset: 0x00007E34
			public bool AbortOnError
			{
				get
				{
					short num = (short)520945664;
					short num2 = num;
					num = (short)1927793961;
					short num3 = num;
					num = (short)1516817705;
					switch (num3 == num)
					{
					}
					num = (short)925171713;
					if (num != 0)
					{
					}
					num = (short)993787904;
					if (num != 0)
					{
					}
					return this.a[global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.p];
				}
				set
				{
					short num = (short)2013724672;
					short num2 = num;
					num = (short)2007988345;
					short num3 = num;
					num = (short)245397625;
					switch (num3 == num)
					{
					}
					num = (short)892338177;
					if (num != 0)
					{
					}
					num = (short)808058880;
					if (num != 0)
					{
					}
					this.a[global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.p] = value;
				}
			}

			// Token: 0x060000C0 RID: 192 RVA: 0x00009CF0 File Offset: 0x00007EF0
			// Note: this type is marked as 'beforefieldinit'.
			static DCB()
			{
				short num = (short)1187774464;
				short num2 = num;
				num = (short)246720633;
				short num3 = num;
				num = (short)1969793145;
				switch (num3 == num)
				{
				}
				num = (short)1652752385;
				if (num != 0)
				{
				}
				num = (short)1087504384;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.d = global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.m();
				global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.e = global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.l();
				global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.f = global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.k();
				global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.g = global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.j();
				global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.h = global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.b();
				global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.i = global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.i();
				global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.j = global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.h();
				global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.k = global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.g();
				global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.l = global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.f();
				global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.m = global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.e();
				global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.n = global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.d();
				global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.o = global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.a();
				global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.p = global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB.c();
			}

			// Token: 0x04000144 RID: 324
			public uint DCBLength;

			// Token: 0x04000145 RID: 325
			public uint BaudRate;

			// Token: 0x04000146 RID: 326
			private global::System.Collections.Specialized.BitVector32 a;

			// Token: 0x04000147 RID: 327
			private ushort b;

			// Token: 0x04000148 RID: 328
			public ushort XonLim;

			// Token: 0x04000149 RID: 329
			public ushort XoffLim;

			// Token: 0x0400014A RID: 330
			public byte ByteSize;

			// Token: 0x0400014B RID: 331
			public byte Parity;

			// Token: 0x0400014C RID: 332
			public byte StopBits;

			// Token: 0x0400014D RID: 333
			public char XonChar;

			// Token: 0x0400014E RID: 334
			public char XoffChar;

			// Token: 0x0400014F RID: 335
			public char ErrorChar;

			// Token: 0x04000150 RID: 336
			public char EofChar;

			// Token: 0x04000151 RID: 337
			public char EvtChar;

			// Token: 0x04000152 RID: 338
			private ushort c;

			// Token: 0x04000153 RID: 339
			private static readonly int d;

			// Token: 0x04000154 RID: 340
			private static readonly int e;

			// Token: 0x04000155 RID: 341
			private static readonly int f;

			// Token: 0x04000156 RID: 342
			private static readonly int g;

			// Token: 0x04000157 RID: 343
			private static readonly global::System.Collections.Specialized.BitVector32.Section h;

			// Token: 0x04000158 RID: 344
			private static readonly int i;

			// Token: 0x04000159 RID: 345
			private static readonly int j;

			// Token: 0x0400015A RID: 346
			private static readonly int k;

			// Token: 0x0400015B RID: 347
			private static readonly int l;

			// Token: 0x0400015C RID: 348
			private static readonly int m;

			// Token: 0x0400015D RID: 349
			private static readonly int n;

			// Token: 0x0400015E RID: 350
			private static readonly global::System.Collections.Specialized.BitVector32.Section o;

			// Token: 0x0400015F RID: 351
			private static readonly int p;
		}

		// Token: 0x0200002A RID: 42
		public struct CommTimeouts
		{
			// Token: 0x04000160 RID: 352
			public uint ReadIntervalTimeout;

			// Token: 0x04000161 RID: 353
			public uint ReadTotalTimeoutMultiplier;

			// Token: 0x04000162 RID: 354
			public uint ReadTotalTimeoutConstant;

			// Token: 0x04000163 RID: 355
			public uint WriteTotalTimeoutMultiplier;

			// Token: 0x04000164 RID: 356
			public uint WriteTotalTimeoutConstant;
		}

		// Token: 0x0200002B RID: 43
		public struct OVERLAPPED
		{
			// Token: 0x060000C1 RID: 193 RVA: 0x00009E1C File Offset: 0x0000801C
			public OVERLAPPED(global::System.UIntPtr uInternal, global::System.UIntPtr uInernalHigh, uint offset, uint offsetHigh, global::System.IntPtr cEvent)
			{
				this.a = uInternal;
				this.b = uInernalHigh;
				this.Offset = offset;
				this.OffsetHigh = offsetHigh;
				this.c = cEvent;
			}

			// Token: 0x04000165 RID: 357
			internal global::System.UIntPtr a;

			// Token: 0x04000166 RID: 358
			internal global::System.UIntPtr b;

			// Token: 0x04000167 RID: 359
			public uint Offset;

			// Token: 0x04000168 RID: 360
			public uint OffsetHigh;

			// Token: 0x04000169 RID: 361
			internal global::System.IntPtr c;
		}

		// Token: 0x0200002C RID: 44
		public enum CommEventFlags : uint
		{
			// Token: 0x0400016B RID: 363
			NONE,
			// Token: 0x0400016C RID: 364
			RXCHAR,
			// Token: 0x0400016D RID: 365
			RXFLAG,
			// Token: 0x0400016E RID: 366
			TXEMPTY = 4U,
			// Token: 0x0400016F RID: 367
			CTS = 8U,
			// Token: 0x04000170 RID: 368
			DSR = 16U,
			// Token: 0x04000171 RID: 369
			RLSD = 32U,
			// Token: 0x04000172 RID: 370
			BREAK = 64U,
			// Token: 0x04000173 RID: 371
			ERR = 128U,
			// Token: 0x04000174 RID: 372
			RING = 256U,
			// Token: 0x04000175 RID: 373
			PERR = 512U,
			// Token: 0x04000176 RID: 374
			RX80FULL = 1024U,
			// Token: 0x04000177 RID: 375
			EVENT1 = 2048U,
			// Token: 0x04000178 RID: 376
			EVENT2 = 4096U,
			// Token: 0x04000179 RID: 377
			POWER = 8192U,
			// Token: 0x0400017A RID: 378
			ALLCE = 16383U,
			// Token: 0x0400017B RID: 379
			ALLCE_2 = 507U,
			// Token: 0x0400017C RID: 380
			ALLPC = 511U
		}

		// Token: 0x0200002D RID: 45
		public enum EventFlags
		{
			// Token: 0x0400017E RID: 382
			EVENT_NONE,
			// Token: 0x0400017F RID: 383
			EVENT_PULSE,
			// Token: 0x04000180 RID: 384
			EVENT_RESET,
			// Token: 0x04000181 RID: 385
			EVENT_SET
		}

		// Token: 0x0200002E RID: 46
		public enum CommErrorFlags : uint
		{
			// Token: 0x04000183 RID: 387
			RXOVER = 1U,
			// Token: 0x04000184 RID: 388
			OVERRUN,
			// Token: 0x04000185 RID: 389
			RXPARITY = 4U,
			// Token: 0x04000186 RID: 390
			FRAME = 8U,
			// Token: 0x04000187 RID: 391
			BREAK = 16U,
			// Token: 0x04000188 RID: 392
			TXFULL = 256U,
			// Token: 0x04000189 RID: 393
			IOE = 1024U,
			// Token: 0x0400018A RID: 394
			MODE = 32768U
		}

		// Token: 0x0200002F RID: 47
		public enum CommModemStatusFlags
		{
			// Token: 0x0400018C RID: 396
			MS_CTS_ON = 16,
			// Token: 0x0400018D RID: 397
			MS_DSR_ON = 32,
			// Token: 0x0400018E RID: 398
			MS_RING_ON = 64,
			// Token: 0x0400018F RID: 399
			MS_RLSD_ON = 128
		}

		// Token: 0x02000030 RID: 48
		public enum CommEscapes : uint
		{
			// Token: 0x04000191 RID: 401
			NONE,
			// Token: 0x04000192 RID: 402
			SETXOFF,
			// Token: 0x04000193 RID: 403
			SETXON,
			// Token: 0x04000194 RID: 404
			SETRTS,
			// Token: 0x04000195 RID: 405
			CLRRTS,
			// Token: 0x04000196 RID: 406
			SETDTR,
			// Token: 0x04000197 RID: 407
			CLRDTR,
			// Token: 0x04000198 RID: 408
			SETBREAK = 8U,
			// Token: 0x04000199 RID: 409
			CLRBREAK,
			// Token: 0x0400019A RID: 410
			SETIR,
			// Token: 0x0400019B RID: 411
			CLRIR
		}

		// Token: 0x02000031 RID: 49
		public enum APIErrors
		{
			// Token: 0x0400019D RID: 413
			ERROR_NONE,
			// Token: 0x0400019E RID: 414
			ERROR_FILE_NOT_FOUND = 2,
			// Token: 0x0400019F RID: 415
			ERROR_INVALID_NAME = 123,
			// Token: 0x040001A0 RID: 416
			ERROR_ACCESS_DENIED = 5,
			// Token: 0x040001A1 RID: 417
			ERROR_INVALID_HANDLE,
			// Token: 0x040001A2 RID: 418
			ERROR_IO_PENDING = 997
		}

		// Token: 0x02000032 RID: 50
		[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential)]
		public class CommStat
		{
			// Token: 0x060000C2 RID: 194 RVA: 0x00009E50 File Offset: 0x00008050
			static CommStat()
			{
				short num = (short)787939328;
				short num2 = num;
				num = (short)945874751;
				short num3 = num;
				num = (short)818014015;
				switch (num3 == num)
				{
				}
				num = (short)1765212161;
				if (num != 0)
				{
				}
				num = (short)1284243456;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.CommonUtil.NativeMethods.CommStat.b = global::System.Collections.Specialized.BitVector32.CreateMask();
				global::Motorola.Common.Communication.CommonUtil.NativeMethods.CommStat.c = global::System.Collections.Specialized.BitVector32.CreateMask(global::Motorola.Common.Communication.CommonUtil.NativeMethods.CommStat.b);
				global::Motorola.Common.Communication.CommonUtil.NativeMethods.CommStat.d = global::System.Collections.Specialized.BitVector32.CreateMask(global::Motorola.Common.Communication.CommonUtil.NativeMethods.CommStat.c);
				global::Motorola.Common.Communication.CommonUtil.NativeMethods.CommStat.e = global::System.Collections.Specialized.BitVector32.CreateMask(global::Motorola.Common.Communication.CommonUtil.NativeMethods.CommStat.d);
				global::Motorola.Common.Communication.CommonUtil.NativeMethods.CommStat.f = global::System.Collections.Specialized.BitVector32.CreateMask(global::Motorola.Common.Communication.CommonUtil.NativeMethods.CommStat.e);
				global::Motorola.Common.Communication.CommonUtil.NativeMethods.CommStat.g = global::System.Collections.Specialized.BitVector32.CreateMask(global::Motorola.Common.Communication.CommonUtil.NativeMethods.CommStat.f);
				global::Motorola.Common.Communication.CommonUtil.NativeMethods.CommStat.h = global::System.Collections.Specialized.BitVector32.CreateMask(global::Motorola.Common.Communication.CommonUtil.NativeMethods.CommStat.g);
			}

			// Token: 0x17000027 RID: 39
			// (get) Token: 0x060000C3 RID: 195 RVA: 0x00009F58 File Offset: 0x00008158
			// (set) Token: 0x060000C4 RID: 196 RVA: 0x0000A010 File Offset: 0x00008210
			public bool CtsHold
			{
				get
				{
					short num = (short)1246756864;
					short num2 = num;
					num = (short)743638707;
					short num3 = num;
					num = (short)1428817587;
					switch (num3 == num)
					{
					}
					num = (short)1411121152;
					if (num != 0)
					{
					}
					num = (short)1288503297;
					if (num != 0)
					{
					}
					return this.a[global::Motorola.Common.Communication.CommonUtil.NativeMethods.CommStat.b];
				}
				set
				{
					short num = (short)1054081024;
					short num2 = num;
					num = (short)291284;
					short num3 = num;
					num = (short)1531146708;
					switch (num3 == num)
					{
					}
					num = (short)167641089;
					if (num != 0)
					{
					}
					num = (short)69009408;
					if (num != 0)
					{
					}
					this.a[global::Motorola.Common.Communication.CommonUtil.NativeMethods.CommStat.b] = value;
				}
			}

			// Token: 0x17000028 RID: 40
			// (get) Token: 0x060000C5 RID: 197 RVA: 0x0000A0C8 File Offset: 0x000082C8
			// (set) Token: 0x060000C6 RID: 198 RVA: 0x0000A180 File Offset: 0x00008380
			public bool DsrHold
			{
				get
				{
					short num = (short)1546452992;
					short num2 = num;
					num = (short)1371767529;
					short num3 = num;
					num = (short)1082163945;
					switch (num3 == num)
					{
					}
					num = (short)457900033;
					if (num != 0)
					{
					}
					num = (short)1161560064;
					if (num != 0)
					{
					}
					return this.a[global::Motorola.Common.Communication.CommonUtil.NativeMethods.CommStat.c];
				}
				set
				{
					short num = (short)1437597696;
					short num2 = num;
					num = (short)1146743422;
					short num3 = num;
					num = (short)1609755262;
					switch (num3 == num)
					{
					}
					num = (short)443154433;
					if (num != 0)
					{
					}
					num = (short)1310261248;
					if (num != 0)
					{
					}
					this.a[global::Motorola.Common.Communication.CommonUtil.NativeMethods.CommStat.c] = value;
				}
			}

			// Token: 0x17000029 RID: 41
			// (get) Token: 0x060000C7 RID: 199 RVA: 0x0000A23C File Offset: 0x0000843C
			// (set) Token: 0x060000C8 RID: 200 RVA: 0x0000A2F4 File Offset: 0x000084F4
			public bool RlsHold
			{
				get
				{
					short num = (short)902037504;
					short num2 = num;
					num = (short)818472891;
					short num3 = num;
					num = (short)268691387;
					switch (num3 == num)
					{
					}
					num = (short)132907009;
					if (num != 0)
					{
					}
					num = (short)143523840;
					if (num != 0)
					{
					}
					return this.a[global::Motorola.Common.Communication.CommonUtil.NativeMethods.CommStat.d];
				}
				set
				{
					short num = (short)336658432;
					short num2 = num;
					num = (short)839857742;
					short num3 = num;
					num = (short)459093582;
					switch (num3 == num)
					{
					}
					num = (short)1418199041;
					if (num != 0)
					{
					}
					num = (short)1276182528;
					if (num != 0)
					{
					}
					this.a[global::Motorola.Common.Communication.CommonUtil.NativeMethods.CommStat.d] = value;
				}
			}

			// Token: 0x1700002A RID: 42
			// (get) Token: 0x060000C9 RID: 201 RVA: 0x0000A3B0 File Offset: 0x000085B0
			// (set) Token: 0x060000CA RID: 202 RVA: 0x0000A468 File Offset: 0x00008668
			public bool XoffHold
			{
				get
				{
					short num = (short)1891041280;
					short num2 = num;
					num = (short)1437466625;
					if (num != 0)
					{
					}
					num = (short)1146707317;
					short num3 = num;
					num = (short)529292661;
					switch (num3 == num)
					{
					}
					num = (short)383254528;
					if (num != 0)
					{
					}
					return this.a[global::Motorola.Common.Communication.CommonUtil.NativeMethods.CommStat.e];
				}
				set
				{
					short num = (short)801701888;
					short num2 = num;
					num = (short)1432775872;
					short num3 = num;
					num = (short)2102226112;
					switch (num3 == num)
					{
					}
					num = (short)200146945;
					if (num != 0)
					{
					}
					num = (short)929955840;
					if (num != 0)
					{
					}
					this.a[global::Motorola.Common.Communication.CommonUtil.NativeMethods.CommStat.e] = value;
				}
			}

			// Token: 0x1700002B RID: 43
			// (get) Token: 0x060000CB RID: 203 RVA: 0x0000A520 File Offset: 0x00008720
			// (set) Token: 0x060000CC RID: 204 RVA: 0x0000A5DC File Offset: 0x000087DC
			public bool XoffSent
			{
				get
				{
					short num = (short)885391360;
					short num2 = num;
					num = (short)1145307137;
					if (num != 0)
					{
					}
					num = (short)1658150507;
					short num3 = num;
					num = (short)450059883;
					switch (num3 == num)
					{
					}
					num = (short)1521811456;
					if (num != 0)
					{
					}
					return this.a[global::Motorola.Common.Communication.CommonUtil.NativeMethods.CommStat.f];
				}
				set
				{
					short num = (short)1030291456;
					short num2 = num;
					num = (short)1770127361;
					if (num != 0)
					{
					}
					num = (short)1579379782;
					short num3 = num;
					num = (short)1630891078;
					switch (num3 == num)
					{
					}
					num = (short)594542592;
					if (num != 0)
					{
					}
					this.a[global::Motorola.Common.Communication.CommonUtil.NativeMethods.CommStat.f] = value;
				}
			}

			// Token: 0x1700002C RID: 44
			// (get) Token: 0x060000CD RID: 205 RVA: 0x0000A698 File Offset: 0x00008898
			// (set) Token: 0x060000CE RID: 206 RVA: 0x0000A750 File Offset: 0x00008950
			public bool Eof
			{
				get
				{
					short num = (short)1007747072;
					short num2 = num;
					num = (short)379829561;
					short num3 = num;
					num = (short)886488377;
					switch (num3 == num)
					{
					}
					num = (short)7602177;
					if (num != 0)
					{
					}
					num = (short)953942016;
					if (num != 0)
					{
					}
					return this.a[global::Motorola.Common.Communication.CommonUtil.NativeMethods.CommStat.g];
				}
				set
				{
					short num = (short)1557004288;
					short num2 = num;
					num = (short)1339026391;
					short num3 = num;
					num = (short)480373719;
					switch (num3 == num)
					{
					}
					num = (short)1439236097;
					if (num != 0)
					{
					}
					num = (short)806617088;
					if (num != 0)
					{
					}
					this.a[global::Motorola.Common.Communication.CommonUtil.NativeMethods.CommStat.g] = value;
				}
			}

			// Token: 0x1700002D RID: 45
			// (get) Token: 0x060000CF RID: 207 RVA: 0x0000A808 File Offset: 0x00008A08
			// (set) Token: 0x060000D0 RID: 208 RVA: 0x0000A8C4 File Offset: 0x00008AC4
			public bool Txim
			{
				get
				{
					short num = (short)1212547072;
					short num2 = num;
					num = (short)1265893093;
					short num3 = num;
					num = (short)1768750821;
					switch (num3 == num)
					{
					}
					num = (short)1535311873;
					if (num != 0)
					{
					}
					num = (short)26542080;
					if (num != 0)
					{
					}
					return this.a[global::Motorola.Common.Communication.CommonUtil.NativeMethods.CommStat.h];
				}
				set
				{
					short num = (short)607584256;
					short num2 = num;
					num = (short)1947992065;
					if (num != 0)
					{
					}
					num = (short)1388917378;
					short num3 = num;
					num = (short)1739600514;
					switch (num3 == num)
					{
					}
					num = (short)488177664;
					if (num != 0)
					{
					}
					this.a[global::Motorola.Common.Communication.CommonUtil.NativeMethods.CommStat.h] = value;
				}
			}

			// Token: 0x040001A3 RID: 419
			private global::System.Collections.Specialized.BitVector32 a;

			// Token: 0x040001A4 RID: 420
			public uint cbInQue;

			// Token: 0x040001A5 RID: 421
			public uint cbOutQue;

			// Token: 0x040001A6 RID: 422
			private static readonly int b;

			// Token: 0x040001A7 RID: 423
			private static readonly int c;

			// Token: 0x040001A8 RID: 424
			private static readonly int d;

			// Token: 0x040001A9 RID: 425
			private static readonly int e;

			// Token: 0x040001AA RID: 426
			private static readonly int f;

			// Token: 0x040001AB RID: 427
			private static readonly int g;

			// Token: 0x040001AC RID: 428
			private static readonly int h;
		}

		// Token: 0x02000033 RID: 51
		[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = global::System.Runtime.InteropServices.CharSet.Unicode)]
		public struct COMMPROP
		{
			// Token: 0x040001AD RID: 429
			private ushort a;

			// Token: 0x040001AE RID: 430
			private ushort b;

			// Token: 0x040001AF RID: 431
			private uint c;

			// Token: 0x040001B0 RID: 432
			private uint d;

			// Token: 0x040001B1 RID: 433
			private uint e;

			// Token: 0x040001B2 RID: 434
			private uint f;

			// Token: 0x040001B3 RID: 435
			private uint g;

			// Token: 0x040001B4 RID: 436
			private uint h;

			// Token: 0x040001B5 RID: 437
			private uint i;

			// Token: 0x040001B6 RID: 438
			private uint j;

			// Token: 0x040001B7 RID: 439
			private uint k;

			// Token: 0x040001B8 RID: 440
			private ushort l;

			// Token: 0x040001B9 RID: 441
			private ushort m;

			// Token: 0x040001BA RID: 442
			private uint n;

			// Token: 0x040001BB RID: 443
			private uint o;

			// Token: 0x040001BC RID: 444
			private uint p;

			// Token: 0x040001BD RID: 445
			private uint q;

			// Token: 0x040001BE RID: 446
			private string r;
		}

		// Token: 0x02000034 RID: 52
		public enum PNP_VETO_TYPE
		{
			// Token: 0x040001C0 RID: 448
			PNP_VetoTypeUnknown,
			// Token: 0x040001C1 RID: 449
			PNP_VetoLegacyDevice,
			// Token: 0x040001C2 RID: 450
			PNP_VetoPendingClose,
			// Token: 0x040001C3 RID: 451
			PNP_VetoWindowsApp,
			// Token: 0x040001C4 RID: 452
			PNP_VetoWindowsService,
			// Token: 0x040001C5 RID: 453
			PNP_VetoOutstandingOpen,
			// Token: 0x040001C6 RID: 454
			PNP_VetoDevice,
			// Token: 0x040001C7 RID: 455
			PNP_VetoDriver,
			// Token: 0x040001C8 RID: 456
			PNP_VetoIllegalDeviceRequest,
			// Token: 0x040001C9 RID: 457
			PNP_VetoInsufficientPower,
			// Token: 0x040001CA RID: 458
			PNP_VetoNonDisableable,
			// Token: 0x040001CB RID: 459
			PNP_VetoLegacyDriver,
			// Token: 0x040001CC RID: 460
			PNP_VetoInsufficientRights
		}

		// Token: 0x02000035 RID: 53
		public struct DC_USB_CTRL_DATA
		{
			// Token: 0x040001CD RID: 461
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 8)]
			public byte[] setup_packet;

			// Token: 0x040001CE RID: 462
			public ulong data_to_dev_ptr;

			// Token: 0x040001CF RID: 463
			public uint data_to_dev_len;
		}

		// Token: 0x02000036 RID: 54
		public struct DC_IOCTRL_DATA
		{
			// Token: 0x040001D0 RID: 464
			public ulong data_in_ptr;

			// Token: 0x040001D1 RID: 465
			public ulong data_out_ptr;

			// Token: 0x040001D2 RID: 466
			public uint data_in_len;

			// Token: 0x040001D3 RID: 467
			public uint data_out_len;

			// Token: 0x040001D4 RID: 468
			public int status;
		}

		// Token: 0x02000037 RID: 55
		[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 1)]
		public struct USB_DEVICE_DESCRIPTOR
		{
			// Token: 0x040001D5 RID: 469
			public byte bLength;

			// Token: 0x040001D6 RID: 470
			public byte bDescriptorType;

			// Token: 0x040001D7 RID: 471
			public ushort bcdUSB;

			// Token: 0x040001D8 RID: 472
			public byte bDeviceClass;

			// Token: 0x040001D9 RID: 473
			public byte bDeviceSubClass;

			// Token: 0x040001DA RID: 474
			public byte bDeviceProtocol;

			// Token: 0x040001DB RID: 475
			public byte bMaxPacketSize0;

			// Token: 0x040001DC RID: 476
			public ushort idVendor;

			// Token: 0x040001DD RID: 477
			public ushort idProduct;

			// Token: 0x040001DE RID: 478
			public ushort bcdDevice;

			// Token: 0x040001DF RID: 479
			public byte iManufacturer;

			// Token: 0x040001E0 RID: 480
			public byte iProduct;

			// Token: 0x040001E1 RID: 481
			public byte iSerialNumber;

			// Token: 0x040001E2 RID: 482
			public byte bNumConfigurations;
		}

		// Token: 0x02000038 RID: 56
		[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 1)]
		public struct USB_ENDPOINT_DESCRIPTOR
		{
			// Token: 0x040001E3 RID: 483
			public byte bLength;

			// Token: 0x040001E4 RID: 484
			public byte bDescriptorType;

			// Token: 0x040001E5 RID: 485
			public byte bEndpointAddress;

			// Token: 0x040001E6 RID: 486
			public byte bmAttributes;

			// Token: 0x040001E7 RID: 487
			public ushort wMaxPacketSize;

			// Token: 0x040001E8 RID: 488
			public byte bInterval;
		}

		// Token: 0x02000039 RID: 57
		[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 1)]
		public struct USB_PIPE_INFO
		{
			// Token: 0x040001E9 RID: 489
			public global::Motorola.Common.Communication.CommonUtil.NativeMethods.USB_ENDPOINT_DESCRIPTOR EndpointDescriptor;

			// Token: 0x040001EA RID: 490
			public uint ScheduleOffset;
		}

		// Token: 0x0200003A RID: 58
		[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 1)]
		public struct USB_NODE_CONNECTION_INFORMATION_EX
		{
			// Token: 0x040001EB RID: 491
			public uint ConnectionIndex;

			// Token: 0x040001EC RID: 492
			public global::Motorola.Common.Communication.CommonUtil.NativeMethods.USB_DEVICE_DESCRIPTOR DeviceDescriptor;

			// Token: 0x040001ED RID: 493
			public byte CurrentConfigurationValue;

			// Token: 0x040001EE RID: 494
			public byte Speed;

			// Token: 0x040001EF RID: 495
			public byte DeviceIsHub;

			// Token: 0x040001F0 RID: 496
			public ushort DeviceAddress;

			// Token: 0x040001F1 RID: 497
			public uint NumberOfOpenPipes;

			// Token: 0x040001F2 RID: 498
			public global::Motorola.Common.Communication.CommonUtil.USB_CONNECTION_STATUS ConnectionStatus;

			// Token: 0x040001F3 RID: 499
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 330)]
			public global::Motorola.Common.Communication.CommonUtil.NativeMethods.USB_PIPE_INFO[] PipeList;
		}

		// Token: 0x0200003B RID: 59
		[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 1)]
		public struct USB_SETUP_PACKET
		{
			// Token: 0x040001F4 RID: 500
			public byte bmRequest;

			// Token: 0x040001F5 RID: 501
			public byte bRequest;

			// Token: 0x040001F6 RID: 502
			public ushort wValue;

			// Token: 0x040001F7 RID: 503
			public ushort wIndex;

			// Token: 0x040001F8 RID: 504
			public ushort wLength;
		}

		// Token: 0x0200003C RID: 60
		[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 1)]
		public struct USB_DESCRIPTOR_REQUEST
		{
			// Token: 0x040001F9 RID: 505
			public uint ConnectionIndex;

			// Token: 0x040001FA RID: 506
			public global::Motorola.Common.Communication.CommonUtil.NativeMethods.USB_SETUP_PACKET SetupPacket;

			// Token: 0x040001FB RID: 507
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 512)]
			public byte[] Data;
		}

		// Token: 0x0200003D RID: 61
		[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 1)]
		public struct USB_CYCLE_PORT_PARAMS
		{
			// Token: 0x040001FC RID: 508
			public uint ConnectionIndex;

			// Token: 0x040001FD RID: 509
			public uint StatusReturned;
		}

		// Token: 0x0200003E RID: 62
		public struct USBUSER_REQUEST_GET_USB_BANDWIDTH_INFO
		{
			// Token: 0x040001FE RID: 510
			public uint UsbUserRequest;

			// Token: 0x040001FF RID: 511
			public global::Motorola.Common.Communication.CommonUtil.USB_USER_ERROR_CODE UsbUserStatusCode;

			// Token: 0x04000200 RID: 512
			public uint RequestBufferLength;

			// Token: 0x04000201 RID: 513
			public uint ActualBufferLength;

			// Token: 0x04000202 RID: 514
			public uint DeviceCount;

			// Token: 0x04000203 RID: 515
			public uint TotalBusBandwidth;

			// Token: 0x04000204 RID: 516
			public uint Total32secBandwidth;

			// Token: 0x04000205 RID: 517
			public uint AllocedBulkAndControl;

			// Token: 0x04000206 RID: 518
			public uint AllocedIso;

			// Token: 0x04000207 RID: 519
			public uint AllocedInterrupt_1ms;

			// Token: 0x04000208 RID: 520
			public uint AllocedInterrupt_2ms;

			// Token: 0x04000209 RID: 521
			public uint AllocedInterrupt_4ms;

			// Token: 0x0400020A RID: 522
			public uint AllocedInterrupt_8ms;

			// Token: 0x0400020B RID: 523
			public uint AllocedInterrupt_16ms;

			// Token: 0x0400020C RID: 524
			public uint AllocedInterrupt_32ms;
		}

		// Token: 0x0200003F RID: 63
		public struct SCSI_PASS_THROUGH_DIRECT
		{
			// Token: 0x0400020D RID: 525
			public ushort Length;

			// Token: 0x0400020E RID: 526
			public byte ScsiStatus;

			// Token: 0x0400020F RID: 527
			public byte PathId;

			// Token: 0x04000210 RID: 528
			public byte TargetId;

			// Token: 0x04000211 RID: 529
			public byte Lun;

			// Token: 0x04000212 RID: 530
			public byte CdbLength;

			// Token: 0x04000213 RID: 531
			public byte SenseInfoLength;

			// Token: 0x04000214 RID: 532
			public byte DataIn;

			// Token: 0x04000215 RID: 533
			public uint DataTransferLength;

			// Token: 0x04000216 RID: 534
			public uint TimeOutValue;

			// Token: 0x04000217 RID: 535
			internal global::System.IntPtr a;

			// Token: 0x04000218 RID: 536
			public uint SenseInfoOffset;

			// Token: 0x04000219 RID: 537
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16)]
			public byte[] Cdb;
		}

		// Token: 0x02000040 RID: 64
		public struct SCSI_PASS_THROUGH_DIRECT_WITH_BUFFER
		{
			// Token: 0x0400021A RID: 538
			public global::Motorola.Common.Communication.CommonUtil.NativeMethods.SCSI_PASS_THROUGH_DIRECT sptd;

			// Token: 0x0400021B RID: 539
			public uint Filler;

			// Token: 0x0400021C RID: 540
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 32)]
			public byte[] ucSenseBuf;
		}

		// Token: 0x02000041 RID: 65
		public struct My_GUID
		{
			// Token: 0x0400021D RID: 541
			public int a;

			// Token: 0x0400021E RID: 542
			public short b;

			// Token: 0x0400021F RID: 543
			public short c;

			// Token: 0x04000220 RID: 544
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 8)]
			public byte[] d;
		}

		// Token: 0x02000042 RID: 66
		public struct PREVENT_MEDIA_REMOVAL
		{
			// Token: 0x04000221 RID: 545
			public byte PreventMediaRemoval;
		}
	}
}
