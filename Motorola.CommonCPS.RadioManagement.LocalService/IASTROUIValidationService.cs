using System;
using System.Collections.Generic;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x0200004A RID: 74
	public interface IASTROUIValidationService : global::Motorola.CommonCPS.RadioManagement.LocalService.IValidationUIServiceBase
	{
		// Token: 0x060002D1 RID: 721
		bool ValidateWhenEditRadioSystemColumn(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem oldSystem, string editedFieldName, object newValue, bool needCache, out global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.RadioSystemFieldType, object>> fieldValues, out global::Motorola.CommonCPS.Server.EntityModel.Radio validateRadio, out string error);

		// Token: 0x060002D2 RID: 722
		bool ValidateWhenEditRadioDataProfileColumn(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile oldDataProfile, string editedFieldName, object newValue, bool needCache, out global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.ProfileFieldType, object>> fieldValues, out global::Motorola.CommonCPS.Server.EntityModel.Radio validateRadio, out string error);

		// Token: 0x060002D3 RID: 723
		bool ValidateWhenEditOTARProfile(global::Motorola.CommonCPS.Server.EntityModel.APXRadio validateRadio, string editedFieldName, object newValue, global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile otarProfileUI, bool fillUpDownActive, out string error);

		// Token: 0x060002D4 RID: 724
		bool ValidateWhenEditOTARProfilesCross(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile otarProfile, global::Motorola.CommonCPS.Server.EntityModel.Radio validateRadio, string editedFieldName, bool isEditable, out string error);

		// Token: 0x060002D5 RID: 725
		bool ValidateDeviceIPGroup(string peerIP, string subscriberIP, string bluetoothDUNPeerIP, string bluetoothDUNSubscriberIP, out string error);

		// Token: 0x060002D6 RID: 726
		bool ValidateDeviceIP(string deviceIP, out string error);

		// Token: 0x060002D7 RID: 727
		bool CanFlashPort(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> selectedItems);

		// Token: 0x060002D8 RID: 728
		bool CanUpgradeFirmware(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> selectedItems);

		// Token: 0x060002D9 RID: 729
		bool CanQueryUpdateRadio(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> selectedItems);

		// Token: 0x060002DA RID: 730
		bool CanUpgradeCodeplugVersion(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> selectedItems);
	}
}
