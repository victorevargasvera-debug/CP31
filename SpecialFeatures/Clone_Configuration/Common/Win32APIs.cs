using System;
using System.Runtime.InteropServices;
using System.Security;

namespace SpecialFeatures.Clone_Configuration.Common
{
	// Token: 0x02000186 RID: 390
	public static class Win32APIs
	{
		// Token: 0x060012FA RID: 4858 RVA: 0x001B74A4 File Offset: 0x001B56A4
		public static void EnableCloseMenuItem(global::System.IntPtr hwnd, bool bEnable)
		{
			short num = (short)1940783109;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.IntPtr systemMenu;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1711013891;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					return;
				case 2:
					if (systemMenu != global::System.IntPtr.Zero)
					{
						num = (short)832831488;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
				{
					num = (short)508493824;
					short num3 = num;
					if (!bEnable)
					{
						num = (short)1672937478;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::SpecialFeatures.Clone_Configuration.Common.Win32APIs.SafeNativeMethods.EnableMenuItem(systemMenu, 61536U, 0U);
					num = (short)1366753281;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					goto IL_124;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_41;
					}
					continue;
				case 6:
					goto IL_122;
				}
				IL_41:
				num = (short)2024102965;
				short num4 = num;
				num = (short)791960629;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_124:
					systemMenu = global::SpecialFeatures.Clone_Configuration.Common.Win32APIs.SafeNativeMethods.GetSystemMenu(hwnd, false);
					num = (short)1686700033;
					if (num != 0)
					{
					}
					num = (short)359202818;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)512950272;
					if (num != 0)
					{
					}
					if (!(hwnd != global::System.IntPtr.Zero))
					{
						return;
					}
					num = (short)860487684;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_122:
			global::SpecialFeatures.Clone_Configuration.Common.Win32APIs.SafeNativeMethods.EnableMenuItem(systemMenu, 61536U, 1U);
		}

		// Token: 0x04000A28 RID: 2600
		private const uint a = 0U;

		// Token: 0x04000A29 RID: 2601
		private const uint b = 1U;

		// Token: 0x04000A2A RID: 2602
		private const uint c = 0U;

		// Token: 0x04000A2B RID: 2603
		private const uint d = 61536U;

		// Token: 0x02000187 RID: 391
		[global::System.Security.SuppressUnmanagedCodeSecurity]
		internal static class SafeNativeMethods
		{
			// Token: 0x060012FB RID: 4859
			[global::System.Runtime.InteropServices.DllImport("user32.dll")]
			internal static extern global::System.IntPtr GetSystemMenu(global::System.IntPtr hwnd, bool bRevert);

			// Token: 0x060012FC RID: 4860
			[global::System.Runtime.InteropServices.DllImport("user32.dll")]
			internal static extern bool EnableMenuItem(global::System.IntPtr hMenuItem, uint uItemID, uint uEnable);
		}
	}
}
