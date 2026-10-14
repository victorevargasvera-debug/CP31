using System;
using System.ComponentModel;
using System.Threading;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.ViewCache;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x020000D7 RID: 215
	internal class StopLoadingCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000450 RID: 1104 RVA: 0x00049E4C File Offset: 0x0004804C
		protected override object ExecuteCmd(params object[] paras)
		{
			int a_ = 1;
			switch (0)
			{
			case 0:
				goto IL_5D;
			}
			int num;
			short num2;
			bool flag;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveDataContext is global::System.ComponentModel.ICollectionView)
					{
						num2 = (short)2027683855;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_31F;
				case 1:
					goto IL_236;
				case 2:
				{
					global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache viewCache;
					if (viewCache.LoadingState == 0)
					{
						goto IL_169;
					}
					num2 = (short)1592131585;
					if (num2 != 0)
					{
					}
					global::System.Threading.Thread.Sleep(100);
					num2 = (short)419102729;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					num2 = (short)714473473;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					num2 = (short)1489960962;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
				{
					num2 = (short)459538432;
					short num3 = num2;
					num2 = (short)319991897;
					short num4 = num2;
					num2 = (short)1128378457;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_169;
					default:
						goto IL_1DE;
					}
					break;
				}
				case 6:
					goto IL_2C3;
				case 7:
					if (paras[0] is bool)
					{
						num2 = (short)2088304650;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2C3;
				case 8:
				{
					global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache viewCache;
					if (viewCache.LoadingState != 2)
					{
						num2 = (short)1016004612;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_273;
				}
				case 9:
					goto IL_236;
				case 10:
					flag = (bool)paras[0];
					num2 = (short)572915718;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					if (paras.Length == 1)
					{
						num2 = (short)258998286;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2C3;
				case 12:
					if (flag)
					{
						num2 = (short)509411331;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_273;
				case 13:
				{
					global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache viewCache;
					if (viewCache.LoadingState != 6)
					{
						num2 = (short)682295312;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_273;
				}
				case 14:
					num2 = (short)984481799;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
				{
					global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache viewCache = (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveDataContext as global::System.ComponentModel.ICollectionView).SourceCollection as global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache;
					viewCache.StopDownloading();
					num2 = (short)953286668;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 16:
					num2 = (short)1938227208;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_5D;
				IL_169:
				num2 = (short)1986920453;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_236:
				num2 = (short)974192653;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2C3:
				num2 = (short)2026766336;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_1DE:
			num2 = (short)512294912;
			if (num2 != 0)
			{
			}
			IL_273:
			return null;
			IL_31F:
			throw new global::System.NotSupportedException(global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("볱鯳苵\ud8f7觹觻軽烿洁瘃爅⠇礉砋愍怏㈑砓礕礗縙甛瀝䜟ȡ䈣䤥娧਩伫䄭尯帱儳唵䰷匹医倽怿㙁㵃㙅ⵇ灉", a_) + global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveDataContext.GetType().FullName);
			IL_5D:
			flag = false;
			num2 = (short)973275147;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x0004A1A0 File Offset: 0x000483A0
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)129826817;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache viewCache;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					viewCache = ((global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveDataContext as global::System.ComponentModel.ICollectionView).SourceCollection as global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache);
					num = (short)1213071363;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)36700161;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_5D;
					}
					continue;
				case 2:
					goto IL_14F;
				case 3:
				{
					num = (short)699976344;
					short num3 = num;
					num = (short)1692191384;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return false;
					default:
						num = (short)458489856;
						if (num != 0)
						{
						}
						if (viewCache == null)
						{
							num = (short)1693515778;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_84;
					}
					break;
				}
				}
				IL_5D:
				if (!(global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveDataContext is global::System.ComponentModel.ICollectionView))
				{
					return false;
				}
				num = (short)13434880;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_84:
			num = (short)60751872;
			short num4 = num;
			return viewCache.CanStopDownloading();
			IL_14F:
			return false;
		}
	}
}
