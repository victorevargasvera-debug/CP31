using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace Motorola.CommonCPS.RadioManagement.ActivityBuilderLib
{
	// Token: 0x02000009 RID: 9
	public static class HomeSetUiService
	{
		// Token: 0x0600001C RID: 28 RVA: 0x00004DC4 File Offset: 0x00002FC4
		public static void SetBusyState()
		{
			short num = (short)1987263619;
			short num2 = num;
			num = (short)1095777411;
			switch (num2 == num)
			{
			}
			num = (short)475987969;
			if (num != 0)
			{
			}
			num = (short)1259143168;
			short num3 = num;
			num = (short)2069626880;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.HomeSetUiService.SetBusyState(true);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00004E74 File Offset: 0x00003074
		private static void SetBusyState(bool busy)
		{
			short num = (short)1158610944;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Windows.Input.Cursor overrideCursor;
				switch (num2)
				{
				case 0:
					goto IL_14;
				case 1:
					num = (short)851640328;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					overrideCursor = global::System.Windows.Input.Cursors.Wait;
					goto IL_173;
				case 3:
				{
					num = (short)30991581;
					short num3 = num;
					num = (short)120251613;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14;
					default:
						num = (short)1052835840;
						if (num != 0)
						{
						}
						if (global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.HomeSetUiService.IsBusy)
						{
							num = (short)1464991749;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					break;
				}
				case 4:
					return;
				case 5:
					new global::System.Windows.Threading.DispatcherTimer(global::System.TimeSpan.FromSeconds(0.0), global::System.Windows.Threading.DispatcherPriority.ApplicationIdle, new global::System.EventHandler(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.HomeSetUiService.dispatcherTimer_Tick), global::System.Windows.Application.Current.Dispatcher);
					num = (short)235470852;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (!busy)
					{
						num = (short)2061107201;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1372192770;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
				{
					num = (short)916586496;
					short num4 = num;
					global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.HomeSetUiService.IsBusy = busy;
					num = (short)765198342;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 8:
					overrideCursor = null;
					goto IL_173;
				}
				goto IL_48;
				IL_14:
				switch (0)
				{
				case 0:
					IL_48:
					num = (short)1785724929;
					if (num != 0)
					{
					}
					if (busy == global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.HomeSetUiService.IsBusy)
					{
						return;
					}
					num = (short)1723531271;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				continue;
				IL_173:
				global::System.Windows.Input.Mouse.OverrideCursor = overrideCursor;
				num = (short)251396099;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00005084 File Offset: 0x00003284
		private static void dispatcherTimer_Tick(object sender, global::System.EventArgs e)
		{
			short num = (short)1803986748;
			short num2 = num;
			num = (short)2045880124;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_6E:
				num = (short)262733825;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)71761920;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_67;
				}
				break;
			}
			global::System.Windows.Threading.DispatcherTimer dispatcherTimer;
			for (;;)
			{
				switch (num3)
				{
				case 0:
					goto IL_E8;
				case 1:
					if (dispatcherTimer != null)
					{
						num = (short)28835842;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					num = (short)1292763137;
					if (num != 0)
					{
					}
					global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.HomeSetUiService.SetBusyState(false);
					dispatcherTimer.Stop();
					num = (short)1497825280;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_67;
			}
			IL_E8:
			num = (short)653131776;
			short num4 = num;
			return;
			IL_67:
			dispatcherTimer = (sender as global::System.Windows.Threading.DispatcherTimer);
			goto IL_6E;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000051A8 File Offset: 0x000033A8
		// Note: this type is marked as 'beforefieldinit'.
		static HomeSetUiService()
		{
			short num = (short)917320411;
			short num2 = num;
			num = (short)856830683;
			switch (num2 == num)
			{
			}
			num = (short)1176829953;
			if (num != 0)
			{
			}
			num = (short)1313931264;
			short num3 = num;
			num = (short)1887764480;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.HomeSetUiService.PreviewType = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.PreviewPanelType.Unknown;
			global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.HomeSetUiService.UIObject = null;
			global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.HomeSetUiService.HomeSetName = "";
		}

		// Token: 0x04000015 RID: 21
		public static global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.PreviewPanelType PreviewType;

		// Token: 0x04000016 RID: 22
		public static object UIObject;

		// Token: 0x04000017 RID: 23
		public static string HomeSetName;

		// Token: 0x04000018 RID: 24
		private static bool IsBusy;
	}
}
