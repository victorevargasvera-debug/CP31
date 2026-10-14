using System;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000029 RID: 41
	internal class SaveHiddenMessageCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000206 RID: 518 RVA: 0x0001A834 File Offset: 0x00018A34
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)370235173;
			short num2 = num;
			num = (short)1345148709;
			switch (num2 == num)
			{
			}
			num = (short)151912448;
			short num3 = num;
			num = (short)2036793345;
			if (num != 0)
			{
			}
			num = (short)1837498368;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0001A8DC File Offset: 0x00018ADC
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)698147328;
			short num2 = num;
			num = (short)970711552;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_144:
				num = (short)680722433;
				if (num != 0)
				{
				}
				if (!(paras[0] is global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext))
				{
					goto IL_191;
				}
				num = (short)885981188;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1652490240;
				if (num != 0)
				{
				}
				num = (short)75563009;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					goto IL_FE;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_84;
					}
					continue;
				case 2:
					goto IL_144;
				case 3:
				{
					num = (short)59244544;
					short num4 = num;
					num = (short)1947860994;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.HiddenWarningMessageCapacityMaxFeatureRegister = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext).HiddenMessage.HiddenCapMaxRegisterWarningMessage;
					global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.HiddenWarningMessageTemplateRadios = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext).HiddenMessage.HiddenWarningMessageTemplateRadios;
					global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Save();
					num = (short)716374016;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_84:
				if (paras.Length != 1)
				{
					break;
				}
				num = (short)228720643;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_FE:
			IL_191:
			return true;
		}
	}
}
