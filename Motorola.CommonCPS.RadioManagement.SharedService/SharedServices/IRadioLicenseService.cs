using System;
using System.Collections.Generic;
using Motorola.Common.LogUtility.PerformanceMeasurement;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000046 RID: 70
	public interface IRadioLicenseService : global::Motorola.CommonCPS.RadioManagement.SharedServices.IService
	{
		// Token: 0x06000623 RID: 1571
		global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase ConvertLicenseSummaryToLicense(global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary summary);

		// Token: 0x06000624 RID: 1572
		global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseFeatureViewBase ConvertLicenseSummaryToLicenseFeatureViewBase(global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary summary);

		// Token: 0x06000625 RID: 1573
		global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseRadioViewBase ConvertLicenseSummaryToLicenseRadioViewBase(global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary summary);

		// Token: 0x06000626 RID: 1574
		void UpdateRadioFeatureComments(global::System.Guid radioFeatureUuid, string comments);

		// Token: 0x06000627 RID: 1575
		string ParseFeatureStatus(global::Motorola.CommonCPS.Server.CommonDBConstants.FeatureStatus featureStatus);

		// Token: 0x06000628 RID: 1576
		global::Motorola.CommonCPS.Server.EntityModel.FeatureList GetFeatureIDs(string serialNumber, byte[] featureList);

		// Token: 0x06000629 RID: 1577
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.CpsFeatureItem> RecoverDeviceLicenses(string radioSerialNumber, global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer parentMeasure);
	}
}
