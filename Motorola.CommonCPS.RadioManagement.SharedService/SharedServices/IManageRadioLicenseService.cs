using System;
using System.Collections.Generic;
using ASK.Interface;
using EntityModel.GenericModel;
using Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000045 RID: 69
	public interface IManageRadioLicenseService : global::Motorola.CommonCPS.RadioManagement.SharedServices.IService
	{
		// Token: 0x0600061B RID: 1563
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary> GetAvailableDevices(global::System.Guid? groupUUID, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail> selectedEIDDetails, int startIndex, int length, int featureType = 0);

		// Token: 0x0600061C RID: 1564
		int GetAvailableDevicesCount(global::System.Guid? groupUUID, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail> selectedEIDDetails, global::System.Collections.Generic.List<string> selectedSerialNumbers, int featureType = 0);

		// Token: 0x0600061D RID: 1565
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail> GetEIDDetailList(string EID);

		// Token: 0x0600061E RID: 1566
		global::EntityModel.GenericModel.CFSUpdateResult SubmitLicenseAssignment(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail> EIDDetailList, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase device, global::System.Collections.Generic.Dictionary<global::System.Guid, global::System.Collections.Generic.Dictionary<string, global::System.Guid>> newTemplateDic, global::System.Guid JobContainerGuid, global::ASK.Interface.ISystemKeyData SelectedSystemID);

		// Token: 0x0600061F RID: 1567
		global::EntityModel.GenericModel.CFSUpdateResult RestoreDevice(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase> selectedList, global::System.Collections.Generic.Dictionary<global::System.Guid, global::System.Collections.Generic.Dictionary<string, global::System.Guid>> newTemplateDic, global::System.Guid JobContainerGuid, global::ASK.Interface.ISystemKeyData SelectedSystemID);

		// Token: 0x06000620 RID: 1568
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> GenerateTemplateForSubmission(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, string targetFlashcode, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense> swLicenseList, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> requestList, out byte[] newTemplateContent, global::System.Collections.Generic.Dictionary<string, object> syncData, global::ASK.Interface.ISystemKeyData SelectedSystemID);

		// Token: 0x06000621 RID: 1569
		global::EntityModel.GenericModel.CFSUpdateResult RecoverRadioLicense(string radioSerialNumber, out string warning);

		// Token: 0x06000622 RID: 1570
		global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureFilter PrepareLicenseFilter(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail> selectedEIDDetails);
	}
}
