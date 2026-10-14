using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x0200005E RID: 94
	internal class ASTROSubmitRaioLicenseParam
	{
		// Token: 0x04000060 RID: 96
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase> licenseList;

		// Token: 0x04000061 RID: 97
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail> selectedEIDDetails;

		// Token: 0x04000062 RID: 98
		public global::Motorola.CommonCPS.Server.EntityModel.Package firmware;

		// Token: 0x04000063 RID: 99
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.LicenseSubmissionResult> submissionResult;
	}
}
