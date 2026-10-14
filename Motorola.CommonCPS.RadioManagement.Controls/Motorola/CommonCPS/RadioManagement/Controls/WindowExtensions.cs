using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000116 RID: 278
	internal static class WindowExtensions
	{
		// Token: 0x060008C9 RID: 2249
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern int GetWindowLong(global::System.IntPtr A_0, int A_1);

		// Token: 0x060008CA RID: 2250
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern int SetWindowLong(global::System.IntPtr A_0, int A_1, int A_2);

		// Token: 0x060008CB RID: 2251 RVA: 0x00092374 File Offset: 0x00090574
		internal static void a(this global::System.Windows.Window A_0)
		{
			short num = (short)1304858062;
			short num2 = num;
			num = (short)969575886;
			switch (num2 == num)
			{
			}
			num = (short)1088028672;
			if (num != 0)
			{
			}
			num = (short)1372651521;
			if (num != 0)
			{
			}
			num = (short)953810944;
			short num3 = num;
			global::System.IntPtr handle = new global::System.Windows.Interop.WindowInteropHelper(A_0).Handle;
			int windowLong = global::Motorola.CommonCPS.RadioManagement.Controls.WindowExtensions.GetWindowLong(handle, -16);
			global::Motorola.CommonCPS.RadioManagement.Controls.WindowExtensions.SetWindowLong(handle, -16, windowLong & -131073);
		}

		// Token: 0x04000415 RID: 1045
		private const int a = -16;

		// Token: 0x04000416 RID: 1046
		private const int b = 131072;
	}
}
