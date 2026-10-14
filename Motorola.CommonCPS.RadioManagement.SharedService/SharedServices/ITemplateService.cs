using System;
using System.Collections.Generic;
using Motorola.CommonCPS.RadioManagement.CommonBase.Enums;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x0200004D RID: 77
	public interface ITemplateService : global::Motorola.CommonCPS.RadioManagement.SharedServices.IService
	{
		// Token: 0x06000666 RID: 1638
		void EditTemplate(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase temp, out string error);

		// Token: 0x06000667 RID: 1639
		bool DeleteTemplate(global::System.Guid batchJobContainer, global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase template);

		// Token: 0x06000668 RID: 1640
		void TryDeleteTemplate(global::System.Guid templateUuid);

		// Token: 0x06000669 RID: 1641
		bool PrecheckForSelectTemplate(global::Motorola.CommonCPS.Server.EntityModel.Radio rawDevice, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase device, out string error);

		// Token: 0x0600066A RID: 1642
		global::Motorola.CommonCPS.Server.EntityModel.Template ParseTemplateFile(string filePath, string password, bool ignorPwdValidation = false);

		// Token: 0x0600066B RID: 1643
		global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary ImportToServer(global::System.Guid jobContainerGuid, string filePath, global::Motorola.CommonCPS.Server.EntityModel.Template template);

		// Token: 0x0600066C RID: 1644
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> PrepareUploadTemplateAndRadio(global::Motorola.CommonCPS.Server.EntityModel.Template source, global::Motorola.CommonCPS.Server.EntityModel.Radio targetDevice, bool IsApply = true);

		// Token: 0x0600066D RID: 1645
		global::Motorola.CommonCPS.Server.EntityModel.Template GetTemplateByName(string templateName);

		// Token: 0x0600066E RID: 1646
		bool PrecheckForApplyTemplate(global::Motorola.CommonCPS.Server.EntityModel.Template rawTemplate, global::Motorola.CommonCPS.Server.EntityModel.Radio rawRadio, global::Motorola.CommonCPS.RadioManagement.CommonBase.Enums.CommandType cmdType, global::System.Guid orignalTemplateUuid, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase localDevices, out string error);

		// Token: 0x0600066F RID: 1647
		global::Motorola.CommonCPS.Server.EntityModel.RadioInfoForApplyTemplate GetRadioInfoForApplyTemplate(global::Motorola.CommonCPS.Server.EntityModel.Radio rd, global::Motorola.CommonCPS.Server.EntityModel.Template rawTemplate);

		// Token: 0x06000670 RID: 1648
		global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet GetValidateEntitySetForApplyTemplate(global::Motorola.CommonCPS.Server.EntityModel.Radio rd, global::Motorola.CommonCPS.Server.EntityModel.Template rawTemplate);

		// Token: 0x06000671 RID: 1649
		global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary, global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary> ApplyTemplateToRadio(global::System.Guid batchJobContainerUuid, global::System.Guid templateUuid, global::Motorola.CommonCPS.Server.EntityModel.RadioInfoForApplyTemplate radioInfo, string batchOpName, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet entitySet, bool returnTemplate = true, bool returnRadioBase = true);

		// Token: 0x06000672 RID: 1650
		global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary EditTemplateFields(global::System.Guid uuid, byte[] timeStamp, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.TemplateFieldType, object>> fieldValues);

		// Token: 0x06000673 RID: 1651
		global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary SaveTemplate(global::Motorola.CommonCPS.Server.EntityModel.Template temp, byte[] fileContent);

		// Token: 0x06000674 RID: 1652
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> GetRadioLicenseFeatures(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.EntityModel.Template source, out int cfsModelType);

		// Token: 0x06000675 RID: 1653
		bool CloneCheck(global::Motorola.CommonCPS.Server.EntityModel.Template template, global::Motorola.CommonCPS.Server.EntityModel.Radio rd, global::Motorola.CommonCPS.RadioManagement.CommonBase.Enums.CommandType? cmdType = null);

		// Token: 0x06000676 RID: 1654
		string GetArchieveFileTypeOfPAC();

		// Token: 0x06000677 RID: 1655
		void UpLoadVAFile(global::Motorola.CommonCPS.Server.EntityModel.Template template);
	}
}
