using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000045 RID: 69
	public static class UiBusyService
	{
		// Token: 0x0600023D RID: 573 RVA: 0x000293DC File Offset: 0x000275DC
		public static void SetBusyState()
		{
			short num = (short)824253396;
			short num2 = num;
			num = (short)966925268;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2143485952;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1871708161;
			if (num != 0)
			{
			}
			num = (short)723976192;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.LocalService.UiBusyService.a(true);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0002948C File Offset: 0x0002768C
		private static void a(bool A_0)
		{
			short num = (short)458948615;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Windows.Input.Cursor overrideCursor;
				switch (num2)
				{
				case 0:
				{
					num = (short)1217817143;
					short num3 = num;
					num = (short)2095475255;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1EC;
					default:
						num = (short)97845248;
						if (num != 0)
						{
						}
						overrideCursor = global::System.Windows.Input.Cursors.Wait;
						goto IL_1C8;
					}
					break;
				}
				case 1:
					if (global::Motorola.CommonCPS.RadioManagement.LocalService.UiBusyService.a)
					{
						goto IL_1EC;
					}
					return;
				case 2:
					num = (short)1013055492;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					new global::System.Windows.Threading.DispatcherTimer(global::System.TimeSpan.FromSeconds(0.0), global::System.Windows.Threading.DispatcherPriority.ApplicationIdle, new global::System.EventHandler(global::Motorola.CommonCPS.RadioManagement.LocalService.UiBusyService.a), global::System.Windows.Application.Current.Dispatcher);
					num = (short)688128006;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					overrideCursor = null;
					goto IL_1C8;
				case 5:
				{
					global::Motorola.CommonCPS.RadioManagement.LocalService.UiBusyService.a = A_0;
					num = (short)1162346496;
					short num4 = num;
					num = (short)1633878024;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					goto IL_AF;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_48;
					}
					continue;
				case 8:
					if (!A_0)
					{
						num = (short)25427970;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)500301824;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_48:
				if (A_0 != global::Motorola.CommonCPS.RadioManagement.LocalService.UiBusyService.a)
				{
					num = (short)1420099589;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_1C8:
				global::System.Windows.Input.Mouse.OverrideCursor = overrideCursor;
				num = (short)2110324737;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1EC:
				num = (short)873201667;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_AF:
			num = (short)66519041;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600023F RID: 575 RVA: 0x000296A4 File Offset: 0x000278A4
		private static void a(object A_0, global::System.EventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::System.Windows.Threading.DispatcherTimer dispatcherTimer;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return;
				case 1:
				{
					num2 = (short)1435697152;
					short num3 = num2;
					if (dispatcherTimer != null)
					{
						num2 = (short)1285423106;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 2:
				{
					num2 = (short)187953711;
					short num4 = num2;
					num2 = (short)2087186991;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)128122880;
						if (num2 != 0)
						{
						}
						global::Motorola.CommonCPS.RadioManagement.LocalService.UiBusyService.a(false);
						dispatcherTimer.Stop();
						break;
					}
					num2 = (short)126484481;
					if (num2 != 0)
					{
					}
					num2 = (short)451346432;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			dispatcherTimer = (A_0 as global::System.Windows.Threading.DispatcherTimer);
			num2 = (short)624230401;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0400006B RID: 107
		private static bool a;
	}
}
