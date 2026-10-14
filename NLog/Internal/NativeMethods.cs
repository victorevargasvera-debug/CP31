using System;
using System.Runtime.InteropServices;
using System.Text;

namespace NLog.Internal
{
	// Token: 0x02000112 RID: 274
	internal static class NativeMethods
	{
		// Token: 0x06000D2D RID: 3373
		[global::System.Runtime.InteropServices.DllImport("advapi32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, SetLastError = true)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Bool)]
		internal static extern bool LogonUser(string pszUsername, string pszDomain, string pszPassword, int dwLogonType, int dwLogonProvider, out global::System.IntPtr phToken);

		// Token: 0x06000D2E RID: 3374
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Bool)]
		internal static extern bool CloseHandle(global::System.IntPtr handle);

		// Token: 0x06000D2F RID: 3375
		[global::System.Runtime.InteropServices.DllImport("advapi32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, SetLastError = true)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Bool)]
		internal static extern bool DuplicateToken(global::System.IntPtr existingTokenHandle, int impersonationLevel, out global::System.IntPtr duplicateTokenHandle);

		// Token: 0x06000D30 RID: 3376
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode)]
		internal static extern void OutputDebugString(string message);

		// Token: 0x06000D31 RID: 3377
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll")]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Bool)]
		internal static extern bool QueryPerformanceCounter(out ulong lpPerformanceCount);

		// Token: 0x06000D32 RID: 3378
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll")]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Bool)]
		internal static extern bool QueryPerformanceFrequency(out ulong lpPerformanceFrequency);

		// Token: 0x06000D33 RID: 3379
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll")]
		internal static extern int GetCurrentProcessId();

		// Token: 0x06000D34 RID: 3380
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, SetLastError = true)]
		internal static extern uint GetModuleFileName([global::System.Runtime.InteropServices.In] global::System.IntPtr hModule, [global::System.Runtime.InteropServices.Out] global::System.Text.StringBuilder lpFilename, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U4)] [global::System.Runtime.InteropServices.In] int nSize);
	}
}
