using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;

namespace Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect
{
	// Token: 0x0200000A RID: 10
	public static class NativeMethods
	{
		// Token: 0x0600001C RID: 28
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern global::System.IntPtr GetSystemMenu(global::System.IntPtr A_0, bool A_1);

		// Token: 0x0600001D RID: 29
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern bool EnableMenuItem(global::System.IntPtr A_0, uint A_1, uint A_2);

		// Token: 0x0600001E RID: 30 RVA: 0x00004750 File Offset: 0x00002950
		public static void EnableCloseWndButton(global::System.Windows.Window wnd, bool enable)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			global::System.IntPtr systemMenu;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_11B;
				case 1:
					if (enable)
					{
						num2 = (short)2011627521;
						if (num2 != 0)
						{
						}
						num2 = (short)129302531;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.NativeMethods.EnableMenuItem(systemMenu, 61536U, 1U);
					num2 = (short)1749680130;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_10B;
				case 3:
					goto IL_173;
				case 4:
				{
					num2 = (short)1856263333;
					short num3 = num2;
					num2 = (short)554652837;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_11B;
					default:
					{
						num2 = (short)1615790080;
						short num4 = num2;
						num2 = (short)159776768;
						if (num2 != 0)
						{
						}
						if (systemMenu != global::System.IntPtr.Zero)
						{
							num2 = (short)3538944;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					}
					break;
				}
				}
				goto IL_24;
				IL_11B:
				num2 = (short)2130313217;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_10B:
			return;
			IL_173:
			global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.NativeMethods.EnableMenuItem(systemMenu, 61536U, 0U);
			return;
			IL_24:
			systemMenu = global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.NativeMethods.GetSystemMenu(new global::System.Windows.Interop.WindowInteropHelper(wnd).Handle, false);
			num2 = (short)1133969412;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04000021 RID: 33
		private const uint a = 0U;

		// Token: 0x04000022 RID: 34
		private const uint b = 0U;

		// Token: 0x04000023 RID: 35
		private const uint c = 1U;

		// Token: 0x04000024 RID: 36
		private const uint d = 61536U;
	}
}
