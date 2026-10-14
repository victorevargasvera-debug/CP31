using System;
using System.Runtime.InteropServices;

namespace AcpUI.Common
{
	// Token: 0x02000094 RID: 148
	internal static class NativeMethods
	{
		// Token: 0x0600062B RID: 1579
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Bool)]
		internal static extern bool GetCursorPos(ref global::AcpUI.Common.NativeMethods.Win32Point A_0);

		// Token: 0x02000095 RID: 149
		internal struct Win32Point
		{
			// Token: 0x04000311 RID: 785
			public int a;

			// Token: 0x04000312 RID: 786
			public int b;
		}
	}
}
