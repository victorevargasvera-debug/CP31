using System;
using System.Collections.Generic;
using System.Linq;
using Motorola.CommonCPS.RadioManagement.Global.Properties;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x0200002A RID: 42
	internal class ChangeShowDialogCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000209 RID: 521 RVA: 0x0001AA94 File Offset: 0x00018C94
		public override bool CanExecute(params object[] paras)
		{
			short num;
			for (;;)
			{
				IL_00:
				num = (short)23396353;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						if (!(paras[0] is global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.DialogVisibility>))
						{
							goto IL_23D;
						}
						num = (short)1852338053;
						short num3 = num;
						num = (short)1428385669;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)774569984;
							if (num != 0)
							{
							}
							num = (short)994508802;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
					{
						num = (short)222363648;
						short num4 = num;
						switch (0)
						{
						case 0:
							goto IL_64;
						}
						continue;
					}
					case 2:
						num = (short)2121465860;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)1593245696;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_11F;
					}
					IL_64:
					if (paras.Length != 1)
					{
						goto IL_23D;
					}
					num = (short)1606680579;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_11F:
			global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.DialogVisibility> outer = paras[0] as global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.DialogVisibility>;
			global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.DialogVisibility> dialogVisibilitiesSetting = global::Motorola.CommonCPS.RadioManagement.UIModels.DialogVisibility.GetDialogVisibilitiesSetting();
			return outer.GroupJoin(dialogVisibilitiesSetting, delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.DialogVisibility newSetting)
			{
				short num5 = (short)2041294217;
				short num6 = num5;
				num5 = (short)256290185;
				switch (num6 == num5)
				{
				}
				num5 = (short)857407488;
				short num7 = num5;
				num5 = (short)1851392001;
				if (num5 != 0)
				{
				}
				num5 = (short)1438842880;
				if (num5 != 0)
				{
				}
				return newSetting.Operation;
			}, delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.DialogVisibility oldSetting)
			{
				short num5 = (short)572239102;
				short num6 = num5;
				num5 = (short)527412478;
				switch (num6 == num5)
				{
				}
				num5 = (short)910491648;
				short num7 = num5;
				num5 = (short)438435841;
				if (num5 != 0)
				{
				}
				num5 = (short)524681216;
				if (num5 != 0)
				{
				}
				return oldSetting.Operation;
			}, delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.DialogVisibility newSetting, global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.DialogVisibility> matchedSettings)
			{
				short num5 = (short)201807603;
				short num6 = num5;
				num5 = (short)755390195;
				switch (num6 == num5)
				{
				}
				num5 = (short)1483472896;
				short num7 = num5;
				num5 = (short)1596260352;
				if (num5 != 0)
				{
				}
				num5 = (short)1269825537;
				if (num5 != 0)
				{
				}
				return new
				{
					newSetting,
					matchedSettings
				};
			}).SelectMany(delegate(<>h__TransparentIdentifier0)
			{
				short num5 = (short)1584759046;
				short num6 = num5;
				num5 = (short)732397830;
				switch (num6 == num5)
				{
				}
				num5 = (short)3801088;
				short num7 = num5;
				num5 = (short)249495553;
				if (num5 != 0)
				{
				}
				num5 = (short)538968064;
				if (num5 != 0)
				{
				}
				return <>h__TransparentIdentifier0.matchedSettings.DefaultIfEmpty<global::Motorola.CommonCPS.RadioManagement.UIModels.DialogVisibility>();
			}, delegate(<>h__TransparentIdentifier0, global::Motorola.CommonCPS.RadioManagement.UIModels.DialogVisibility matchedSetting)
			{
				short num5 = (short)1363783558;
				short num6 = num5;
				num5 = (short)1991487366;
				switch (num6 == num5)
				{
				}
				num5 = (short)1384185856;
				short num7 = num5;
				num5 = (short)148439040;
				if (num5 != 0)
				{
				}
				num5 = (short)850657281;
				if (num5 != 0)
				{
				}
				return new
				{
					<>h__TransparentIdentifier0,
					matchedSetting
				};
			}).Where(delegate(<>h__TransparentIdentifier1)
			{
				short num5 = (short)1305118648;
				short num6 = num5;
				num5 = (short)810715064;
				switch (num6 == num5)
				{
				}
				num5 = (short)115802112;
				short num7 = num5;
				num5 = (short)436666369;
				if (num5 != 0)
				{
				}
				num5 = (short)903151616;
				if (num5 != 0)
				{
				}
				bool show = <>h__TransparentIdentifier1.<>h__TransparentIdentifier0.newSetting.Show;
				global::Motorola.CommonCPS.RadioManagement.UIModels.DialogVisibility matchedSetting = <>h__TransparentIdentifier1.matchedSetting;
				bool? flag = (matchedSetting != null) ? new bool?(matchedSetting.Show) : null;
				return !(show == flag.GetValueOrDefault() & flag != null);
			}).Select(delegate(<>h__TransparentIdentifier1)
			{
				short num5 = (short)855748099;
				short num6 = num5;
				num5 = (short)2130161155;
				switch (num6 == num5)
				{
				}
				num5 = (short)798162944;
				short num7 = num5;
				num5 = (short)312999936;
				if (num5 != 0)
				{
				}
				num5 = (short)1219690497;
				if (num5 != 0)
				{
				}
				return <>h__TransparentIdentifier1.<>h__TransparentIdentifier0.newSetting;
			}).Any<global::Motorola.CommonCPS.RadioManagement.UIModels.DialogVisibility>();
			IL_23D:
			num = (short)1206321153;
			if (num != 0)
			{
			}
			throw new global::System.ArgumentException();
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0001AD0C File Offset: 0x00018F0C
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)162398208;
			short num2 = num;
			num = (short)515899394;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					goto IL_CA;
				case 1:
					num = (short)706215937;
					if (num != 0)
					{
					}
					if (paras[0] is global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.DialogVisibility>)
					{
						num = (short)399441923;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_168;
				case 2:
				{
					num = (short)1807984828;
					short num4 = num;
					num = (short)1366534332;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_CA;
					default:
						num = (short)391053312;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_AC;
						}
						continue;
					}
					break;
				}
				case 3:
					goto IL_163;
				}
				IL_AC:
				if (paras.Length == 1)
				{
					num = (short)812777472;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_168;
				IL_CA:
				num = (short)661848065;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_163:
			global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.DialogVisibility> newSettings = paras[0] as global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.DialogVisibility>;
			global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.DialogVisibility> dialogVisibilitiesSetting = global::Motorola.CommonCPS.RadioManagement.UIModels.DialogVisibility.GetDialogVisibilitiesSetting();
			global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.DialogVisibility> visibilities = global::Motorola.CommonCPS.RadioManagement.UIModels.DialogVisibility.MergeDialogVisibilities(newSettings, dialogVisibilitiesSetting);
			global::Motorola.CommonCPS.RadioManagement.Global.Properties.Settings.Default.DialogVisibilities = global::Motorola.CommonCPS.RadioManagement.UIModels.DialogVisibility.SerializeDialogVisibilities(visibilities);
			global::Motorola.CommonCPS.RadioManagement.Global.Properties.Settings.Default.Save();
			return true;
			IL_168:
			throw new global::System.ArgumentException();
		}
	}
}
