using System;
using System.Collections.Generic;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x0200004B RID: 75
	public interface IValidationUIServiceBase
	{
		// Token: 0x060002DB RID: 731
		bool ValidateWhenEditRadioColumn(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase oldDevice, object newValue, string editedFieldName, out global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object>> fieldValues, out global::Motorola.CommonCPS.Server.EntityModel.Radio ValidateRadio, out string error);

		// Token: 0x060002DC RID: 732
		bool ValidateWhenEditTemplateColumn(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase oldTemplate, object newValue, string editedFieldName, out global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.TemplateFieldType, object>> fieldValues, out string error);

		// Token: 0x060002DD RID: 733
		bool ValidateAllRadioFields(global::Motorola.CommonCPS.Server.EntityModel.Radio radioBase, global::System.Collections.Generic.Dictionary<string, string> errorList);

		// Token: 0x060002DE RID: 734
		bool ValidateRadioWithMVOForImportCSV(global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest CSVRequest, global::Motorola.CommonCPS.Server.EntityModel.Radio radioBase, global::System.Collections.Generic.Dictionary<string, string> tempErrorList);

		// Token: 0x060002DF RID: 735
		void ValidateDeviceModel(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase d);

		// Token: 0x060002E0 RID: 736
		void ValidateTemplateModel(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase template);

		// Token: 0x060002E1 RID: 737
		void ValidateDVRSHashDVRSFile(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase template);

		// Token: 0x060002E2 RID: 738
		bool CanCreateJob(global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus);

		// Token: 0x060002E3 RID: 739
		bool IsRadioSwitchoverRequired(global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus, global::Motorola.CommonCPS.Server.CommonDBConstants.CruncherStatus? cruncherStatus);

		// Token: 0x060002E4 RID: 740
		bool IsJobProcessingState(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radio);

		// Token: 0x060002E5 RID: 741
		bool ValidateNewRadio(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radio, out string error);

		// Token: 0x060002E6 RID: 742
		bool FoundInvalidDVRS(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRODVRSFileDto DVRSFile, long DVRSHashCode);

		// Token: 0x060002E7 RID: 743
		bool CanDeleteRadio(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> radios);

		// Token: 0x060002E8 RID: 744
		bool CanSelectMVO(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> radios);

		// Token: 0x060002E9 RID: 745
		void CheckDeviceModelEditable(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase device);
	}
}
