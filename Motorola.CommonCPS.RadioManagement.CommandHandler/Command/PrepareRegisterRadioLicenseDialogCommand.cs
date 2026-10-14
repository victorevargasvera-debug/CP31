using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000083 RID: 131
	internal class PrepareRegisterRadioLicenseDialogCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x0600034C RID: 844 RVA: 0x0003419C File Offset: 0x0003239C
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)332196638;
			short num2 = num;
			num = (short)1498737438;
			switch (num2 == num)
			{
			}
			num = (short)1389101056;
			if (num != 0)
			{
			}
			num = (short)266469376;
			short num3 = num;
			num = (short)725155841;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext registerRadioLicenseContext = new global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext();
			registerRadioLicenseContext.AvailableDevices = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();
			registerRadioLicenseContext.EIDDetails = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail>();
			registerRadioLicenseContext.EIDHistory = new global::System.Collections.Generic.List<string>();
			registerRadioLicenseContext.EIDString = string.Empty;
			registerRadioLicenseContext.SelectChangeSource = null;
			registerRadioLicenseContext.SelectedDevices = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();
			registerRadioLicenseContext.Groups = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.GroupService.GetGroupsTree();
			registerRadioLicenseContext.SelectedGroup = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.GroupService.FindGroup(global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.LastGroup);
			base.Interaction.ShowRegisterRadioLicenseDialog(registerRadioLicenseContext);
			return null;
		}
	}
}
