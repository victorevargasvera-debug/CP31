using System;
using System.Runtime.InteropServices;
using System.Text;

namespace AcpFileHandlerLib
{
	// Token: 0x02000013 RID: 19
	internal static class j
	{
		// Token: 0x06000079 RID: 121
		[global::System.Runtime.InteropServices.DllImport("Comdlg32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, SetLastError = true)]
		internal static extern bool GetSaveFileName(ref global::AcpFileHandlerLib.l A_0);

		// Token: 0x0600007A RID: 122
		[global::System.Runtime.InteropServices.DllImport("Comdlg32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, SetLastError = true)]
		internal static extern bool GetOpenFileName(ref global::AcpFileHandlerLib.l A_0);

		// Token: 0x0600007B RID: 123
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		internal static extern bool SetWindowPos(global::System.IntPtr A_0, global::System.IntPtr A_1, int A_2, int A_3, int A_4, int A_5, global::AcpFileHandlerLib.c A_6);

		// Token: 0x0600007C RID: 124
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		internal static extern bool GetWindowRect(global::System.IntPtr A_0, ref global::AcpFileHandlerLib.o A_1);

		// Token: 0x0600007D RID: 125
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		internal static extern global::System.IntPtr GetParent(global::System.IntPtr A_0);

		// Token: 0x0600007E RID: 126
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		internal static extern int SetParent(global::System.IntPtr A_0, global::System.IntPtr A_1);

		// Token: 0x0600007F RID: 127
		[global::System.Runtime.InteropServices.DllImport("user32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto)]
		public static extern int SendMessage(global::System.IntPtr A_0, uint A_1, global::System.IntPtr A_2, global::System.Text.StringBuilder A_3);

		// Token: 0x06000080 RID: 128
		[global::System.Runtime.InteropServices.DllImport("Comdlg32.dll")]
		internal static extern int CommDlgExtendedError();

		// Token: 0x06000081 RID: 129
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, SetLastError = true)]
		internal static extern bool GetDiskFreeSpace(string A_0, out uint A_1, out uint A_2, out uint A_3, out uint A_4);
	}
}
