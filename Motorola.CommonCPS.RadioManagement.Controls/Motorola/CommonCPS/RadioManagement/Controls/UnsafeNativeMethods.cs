using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x0200011A RID: 282
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	internal static class UnsafeNativeMethods
	{
		// Token: 0x060008E2 RID: 2274
		[global::System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
		internal static extern int GetWindowLong(global::System.IntPtr A_0, int A_1);

		// Token: 0x060008E3 RID: 2275
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		internal static extern int SetWindowLong(global::System.IntPtr A_0, int A_1, int A_2);

		// Token: 0x060008E4 RID: 2276
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		internal static extern global::System.IntPtr GetSystemMenu(global::System.IntPtr A_0, bool A_1);

		// Token: 0x060008E5 RID: 2277
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		internal static extern bool EnableMenuItem(global::System.IntPtr A_0, uint A_1, uint A_2);
	}
}
