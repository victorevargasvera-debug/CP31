using System;
using System.Collections.Generic;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000042 RID: 66
	public interface ILicenseService : global::Motorola.CommonCPS.RadioManagement.SharedServices.IService
	{
		// Token: 0x06000608 RID: 1544
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo> QueryAppEIDInfo(string EID, out string warning);

		// Token: 0x06000609 RID: 1545
		string GenerateHostID();

		// Token: 0x0600060A RID: 1546
		void EnableFeature_CLL(global::Motorola.CommonCPS.Server.EntityModel.FeatureResponseObject referenceReq, string hostID, byte[] capabilityResponse);

		// Token: 0x0600060B RID: 1547
		global::System.Collections.Generic.KeyValuePair<string, string> GetRadioMgmtFeatureName(global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? region);

		// Token: 0x0600060C RID: 1548
		bool SubmitAppLicense(string AID, int count);

		// Token: 0x0600060D RID: 1549
		void SubmitAppLicenseFile(byte[] licenseFile);

		// Token: 0x0600060E RID: 1550
		byte[] RecoverAppLicense(out string warningMessage, bool isUpdateServer = true);

		// Token: 0x0600060F RID: 1551
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.SharedServices.AppLicenseInfo> GetRadioMgmtFeature();

		// Token: 0x06000610 RID: 1552
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SharedServices.AppLicenseInfo> GetRegisteredAppLicenses();

		// Token: 0x06000611 RID: 1553
		global::System.Collections.Generic.List<string> GetAppLicenseNames(global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? region = null);

		// Token: 0x06000612 RID: 1554
		bool IsAppLicenseSupport_RRP(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName?> regionList);

		// Token: 0x06000613 RID: 1555
		bool FilterLicenseByRegion(string licenseName, global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName region);

		// Token: 0x06000614 RID: 1556
		bool SplitRawLicenseName(string rawLicenseName, out string licenseName, out global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? region);

		// Token: 0x06000615 RID: 1557
		global::Motorola.CommonCPS.Server.EntityModel.ApplicationFeatureSummary UpdateAppLicense(global::Motorola.CommonCPS.Server.EntityModel.ApplicationFeatureSummary summary, string comment);

		// Token: 0x06000616 RID: 1558
		global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<string, string>> GetAppLicenseComments();

		// Token: 0x06000617 RID: 1559
		global::Motorola.CommonCPS.Server.EntityModel.FeatureList GetAppLicensesFromLicenseServer();
	}
}
