using System;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x020000BE RID: 190
	internal class ShowSettingCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000404 RID: 1028 RVA: 0x000435D4 File Offset: 0x000417D4
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)473563136;
			short num2 = num;
			num = (short)473729326;
			short num3 = num;
			num = (short)123570478;
			switch (num3 == num)
			{
			}
			num = (short)918093824;
			if (num != 0)
			{
			}
			num = (short)184549377;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext settingsContext = new global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext();
			settingsContext.Connection.Address = global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ServerAddress;
			settingsContext.Connection.Port = global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ServerPort;
			settingsContext.DealerInfo.Left = global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.DealerInfoLeft;
			settingsContext.DealerInfo.Center = global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.DealerInfoMiddle;
			settingsContext.DealerInfo.Right = global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.DealerInfoRight;
			bool uploadToServer;
			bool.TryParse(global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.UploadLogToServer, out uploadToServer);
			settingsContext.LogSetting.UploadToServer = uploadToServer;
			settingsContext.LogSetting.RestartOption = global::Motorola.CommonCPS.RadioManagement.UIModels.RestartOptions.Later;
			settingsContext.HiddenMessage.HiddenCapMaxRegisterWarningMessage = global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.HiddenWarningMessageCapacityMaxFeatureRegister;
			settingsContext.HiddenMessage.HiddenWarningMessageTemplateRadios = global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.HiddenWarningMessageTemplateRadios;
			settingsContext.IsSaved = false;
			global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsCancelled = false;
			base.Interaction.ShowSettingsDialog(settingsContext);
			return settingsContext.IsSaved;
		}
	}
}
