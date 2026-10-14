using System;
using System.Globalization;
using System.Windows.Threading;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.InteractionHelper;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Core
{
	// Token: 0x02000006 RID: 6
	public class ConnectionMonitor
	{
		// Token: 0x06000010 RID: 16 RVA: 0x000031A0 File Offset: 0x000013A0
		private ConnectionMonitor()
		{
			this.b = new global::System.Windows.Threading.DispatcherTimer
			{
				Interval = new global::System.TimeSpan(0, 0, 30)
			};
			this.b.Tick += this.a;
			global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor instance = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(false, false);
			instance.ConnectionClosedFaulted = (global::Motorola.CommonCPS.RadioManagement.SharedServices.ConnectionClosedFaulted)global::System.Delegate.Combine(instance.ConnectionClosedFaulted, new global::Motorola.CommonCPS.RadioManagement.SharedServices.ConnectionClosedFaulted(this.a));
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000320C File Offset: 0x0000140C
		public static global::Motorola.CommonCPS.RadioManagement.Core.ConnectionMonitor CreateInstance()
		{
			short num = (short)1593716308;
			short num2 = num;
			num = (short)1519595092;
			switch (num2 == num)
			{
			}
			num = (short)554827777;
			if (num != 0)
			{
			}
			num = (short)745930752;
			if (num != 0)
			{
			}
			num = (short)1565851648;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.Core.ConnectionMonitor.a;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000032BC File Offset: 0x000014BC
		private void a(object A_0, global::System.EventArgs A_1)
		{
			int a_ = 19;
			short num = (short)1356726283;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsConnecting)
					{
						num = (short)1574830092;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)24903687;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					this.b.Stop();
					num = (short)913244176;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_26C;
				case 3:
					goto IL_166;
				case 4:
					num = (short)564002824;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					num = (short)1521090569;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (!global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsHostedDeployment)
					{
						num = (short)1347223556;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1933770754;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceProxy.GetInstance().LocalService.Connect(true))
					{
						num = (short)12910606;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)205127686;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_305;
				case 9:
					goto IL_32D;
				case 10:
					num = (short)199753743;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					switch (0)
					{
					case 0:
						goto IL_75;
					}
					continue;
				case 12:
					return;
				case 13:
					goto IL_FF;
				case 14:
					this.b.Stop();
					num = (short)309985297;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					goto IL_1C5;
				case 16:
					if (!global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsHostedDeployment)
					{
						num = (short)896073738;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)402587651;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					if (!global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsHostedDeployment)
					{
						num = (short)431685637;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)603652109;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_75:
				if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsConnected)
				{
					num = (short)1115559271;
					short num3 = num;
					num = (short)1741428071;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_166;
					default:
						num = (short)1955332096;
						if (num != 0)
						{
						}
						num = (short)44630017;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				else
				{
					num = (short)1646657536;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_FF:
			string text = global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AgencyName;
			goto IL_226;
			IL_166:
			string text2 = global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AgencyName;
			goto IL_2BE;
			IL_1C5:
			num = (short)1503133696;
			short num4 = num;
			num = (short)1456734209;
			if (num != 0)
			{
			}
			text2 = global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ServerAddress;
			goto IL_2BE;
			IL_226:
			string text3 = text;
			global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ReportStatus(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Status_Connection + global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("蚥", a_) + text3.ToUpper(global::System.Globalization.CultureInfo.InvariantCulture));
			return;
			IL_26C:
			string text4 = global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AgencyName;
			goto IL_3C2;
			IL_2BE:
			string text5 = text2;
			global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ReportStatus(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Status_Connection + global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("蚥", a_) + text5.ToUpper(global::System.Globalization.CultureInfo.InvariantCulture));
			return;
			IL_305:
			text4 = global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ServerAddress;
			goto IL_3C2;
			IL_32D:
			text = global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ServerAddress;
			goto IL_226;
			IL_3C2:
			string text6 = text4;
			global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ReportStatus(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Status_Disconnection + global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("蚥", a_) + text6.ToUpper(global::System.Globalization.CultureInfo.InvariantCulture));
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000036BC File Offset: 0x000018BC
		private void a()
		{
			int a_ = 1;
			short num = (short)1084620804;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				string text;
				switch (num2)
				{
				case 0:
					goto IL_185;
				case 1:
					text = global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ServerAddress;
					goto IL_140;
				case 2:
				{
					num = (short)1801783113;
					short num3 = num;
					num = (short)1446184777;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1289158656;
						short num4 = num;
						num = (short)646905856;
						if (num != 0)
						{
						}
						num = (short)1178730497;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 3:
					text = global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AgencyName;
					goto IL_140;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_41;
					}
					continue;
				}
				IL_41:
				num = (short)1502674945;
				if (num != 0)
				{
				}
				if (!global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsHostedDeployment)
				{
					num = (short)957743106;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1595867139;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_140:
				string text2 = text;
				global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ReportStatus(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Status_Disconnection + global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("뒓", a_) + text2.ToUpper(global::System.Globalization.CultureInfo.InvariantCulture));
				num = (short)2052521984;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_185:
			global::System.Windows.Threading.DispatcherTimer dispatcherTimer = this.b;
			if (dispatcherTimer == null)
			{
				return;
			}
			dispatcherTimer.Start();
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00003860 File Offset: 0x00001A60
		// Note: this type is marked as 'beforefieldinit'.
		static ConnectionMonitor()
		{
			short num = (short)879577321;
			short num2 = num;
			num = (short)249776361;
			switch (num2 == num)
			{
			}
			num = (short)1469775872;
			if (num != 0)
			{
			}
			num = (short)1913978881;
			if (num != 0)
			{
			}
			num = (short)1564672000;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.Core.ConnectionMonitor.a = new global::Motorola.CommonCPS.RadioManagement.Core.ConnectionMonitor();
		}

		// Token: 0x04000003 RID: 3
		private static readonly global::Motorola.CommonCPS.RadioManagement.Core.ConnectionMonitor a;

		// Token: 0x04000004 RID: 4
		private readonly global::System.Windows.Threading.DispatcherTimer b;
	}
}
