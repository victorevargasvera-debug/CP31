using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using Motorola.Common.LogUtility;
using Motorola.CommonCPS.RadioManagement.CommonBase;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.InteractionHelper;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x0200002C RID: 44
	internal class UpdateLogSettingCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000215 RID: 533 RVA: 0x0001B47C File Offset: 0x0001967C
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)1538976264;
			short num2 = num;
			num = (short)2043537928;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_13B:
				num = (short)1542848515;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)271450112;
				if (num != 0)
				{
				}
				num = (short)351993858;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			bool flag;
			for (;;)
			{
				switch (num3)
				{
				case 0:
					goto IL_AE;
				case 1:
					goto IL_12B;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_81;
					}
					continue;
				case 3:
					return false;
				}
				IL_81:
				if (paras[0].GetType() != typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.LogSetting))
				{
					num = (short)832110592;
					num3 = (int)((global::System.IntPtr)num);
				}
				else
				{
					bool.TryParse(global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.UploadLogToServer, out flag);
					num = (short)1914175488;
					short num4 = num;
					num = (short)1942945793;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
			IL_AE:
			num = (short)183566337;
			if (num != 0)
			{
			}
			return false;
			IL_12B:
			if (((global::Motorola.CommonCPS.RadioManagement.UIModels.LogSetting)paras[0]).UploadToServer == flag)
			{
				goto IL_13B;
			}
			return true;
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0001B5E4 File Offset: 0x000197E4
		protected override object ExecuteCmd(params object[] paras)
		{
			int a_ = 11;
			short num = (short)1807480870;
			short num2 = num;
			num = (short)145160230;
			global::Motorola.CommonCPS.RadioManagement.UIModels.LogSetting logSetting;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_20C:
				if (logSetting.RestartOption == global::Motorola.CommonCPS.RadioManagement.UIModels.RestartOptions.Now)
				{
					num = (short)1478557700;
					num3 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1706950656;
					short num4 = num;
					global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowNotificationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.CPS2_Logging_Change_Notification, global::Motorola.CommonCPS.ResourceRepository.Resources.CPS2_Log);
					num = (short)1927348224;
					num3 = (int)((global::System.IntPtr)num);
				}
				break;
			default:
				num = (short)1333002241;
				if (num != 0)
				{
				}
				num = (short)1703477248;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_9F;
				}
				break;
			}
			for (;;)
			{
				IL_85:
				switch (num3)
				{
				case 0:
					goto IL_1C8;
				case 1:
					global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).WriteEventEntry(global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("ꧻ軽泿洁攃戅⠇昉挋植挏㈑怓礕㠗椙礛氝嘟䜡嘣إ嬧伩堫娭夯就匳ᘵ䴷䨹堻弽㐿❁⁃籅桇", a_) + (logSetting.UploadToServer ? global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("맻都懿态栃挅氇", a_) : global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("룻韽珿持昃樅洇渉", a_)), global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
					num = (short)1131347970;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_20C;
				case 3:
					goto IL_16F;
				case 4:
				{
					string fileName = global::System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
					global::System.Diagnostics.Process.Start(new global::System.Diagnostics.ProcessStartInfo(global::System.IO.Path.Combine(global::System.Reflection.Assembly.GetEntryAssembly().Location, fileName)));
					global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).WriteEventEntry(global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("껻鯽珿瘁攃琅簇⨉伋帍䌏‑㐓眕栗標瀛眝䌟䌡倣伥䜧䐩ఫ伭嘯䘱儳䐵ᠷ漹䰻刽⼿⍁⁃晅⑇╉⭋湍㙏㝑㕓≕ⵗ⡙㥛繝य़ᅡ䑣ͥ٧୩๫ɭᕯᙱ婳", a_), global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
					global::System.Environment.Exit(0);
					num = (short)1610350595;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				goto IL_9F;
			}
			IL_16F:
			IL_1C8:
			return true;
			IL_9F:
			logSetting = (global::Motorola.CommonCPS.RadioManagement.UIModels.LogSetting)paras[0];
			global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.UploadLogToServer = logSetting.UploadToServer.ToString();
			global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Save();
			num = (short)1029111809;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_85;
		}
	}
}
