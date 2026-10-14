using System;
using System.Globalization;
using Motorola.CommonCPS.RadioManagement.CommonBase;
using Motorola.CommonCPS.RadioManagement.InteractionHelper;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000096 RID: 150
	internal class ChangeRMAppLanguageCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000383 RID: 899 RVA: 0x00037D2C File Offset: 0x00035F2C
		public override bool CanExecute(params object[] paras)
		{
			global::Motorola.CommonCPS.RadioManagement.UIModels.Langauge language;
			for (;;)
			{
				IL_00:
				short num = (short)108986371;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						language = ((global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext)paras[0]).Language;
						num = (short)979894273;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						num = (short)1268418030;
						short num3 = num;
						num = (short)1386317294;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
						{
							num = (short)1675689985;
							if (num != 0)
							{
							}
							num = (short)575733760;
							short num4 = num;
							num = (short)1031143424;
							if (num != 0)
							{
							}
							if (string.Equals(language.SelectedLanguage, language.InitialLanguageSelection, global::System.StringComparison.Ordinal))
							{
								num = (short)1141506050;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return true;
						}
						}
						break;
					}
					case 2:
						goto IL_162;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_35;
						}
						continue;
					}
					IL_35:
					if (!(paras[0] is global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext))
					{
						return false;
					}
					num = (short)941621248;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			return true;
			IL_162:
			return !string.Equals(language.InitialLanguageSelection, global::Motorola.CommonCPS.ResourceRepository.Resources.Culture.NativeName, global::System.StringComparison.Ordinal);
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00037EA4 File Offset: 0x000360A4
		protected override object ExecuteCmd(params object[] paras)
		{
			int a_ = 15;
			short num = (short)18612224;
			switch (num)
			{
			default:
			{
				num = (short)1063583745;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					string text;
					string selectedLanguage;
					global::Motorola.CommonCPS.RadioManagement.UIModels.Langauge language;
					global::System.Globalization.CultureInfo cultureInfo;
					switch (num2)
					{
					case 0:
						selectedLanguage = text;
						num = (short)1740242955;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_85;
						}
						continue;
					case 2:
						goto IL_22E;
					case 3:
						num = (short)782434305;
						if (num != 0)
						{
						}
						num = (short)1440612358;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (string.Equals(language.SelectedLanguage, language.InitialLanguageSelection, global::System.StringComparison.Ordinal))
						{
							num = (short)984743936;
							short num3 = num;
							num = (short)1794899973;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_233;
					case 5:
						goto IL_199;
					case 6:
						if (paras[0] is global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext)
						{
							num = (short)1073610762;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_355;
					case 7:
						if (language.SelectedLanguage.Contains(cultureInfo.NativeName))
						{
							num = (short)974716928;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E5;
					case 8:
						goto IL_1E1;
					case 9:
					{
						if (string.Equals(language.InitialLanguageSelection, global::Motorola.CommonCPS.ResourceRepository.Resources.Culture.NativeName, global::System.StringComparison.Ordinal))
						{
							goto IL_1E1;
						}
						num = (short)386618766;
						short num4 = num;
						num = (short)373642638;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_199;
						default:
							num = (short)1538916352;
							if (num != 0)
							{
							}
							num = (short)83492876;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 10:
						language = ((global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext)paras[0]).Language;
						selectedLanguage = string.Empty;
						num = (short)1638334468;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_1E1;
					case 12:
						goto IL_233;
					case 13:
						try
						{
							global::Motorola.CommonCPS.RadioManagement.CommonBase.AppLanguage.GetInstance().SaveAppUserForUpgradeConfig(selectedLanguage);
							goto IL_200;
						}
						catch (global::System.Exception)
						{
							goto IL_200;
						}
						goto IL_E5;
						IL_200:
						global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowNotificationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Language_changes_will_go_into, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Connection_Language);
						num = (short)2002649090;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_85:
					if (paras.Length == 1)
					{
						num = (short)1944977411;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_E5:
					selectedLanguage = global::Motorola.CommonCPS.RadioManagement.CommonBase.AppLanguage.GetInstance()[language.SelectedLanguage];
					num = (short)976486408;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_199:
					num = (short)204406793;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E1:
					num = (short)95879181;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_233:
					cultureInfo = new global::System.Globalization.CultureInfo(global::Motorola.CommonCPS.RadioManagement.CommonBase.AppLanguage.MainAssemblyCulture);
					text = global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("旿氁", a_);
					num = (short)133169159;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_22E:
				IL_355:
				return true;
			}
			}
		}
	}
}
