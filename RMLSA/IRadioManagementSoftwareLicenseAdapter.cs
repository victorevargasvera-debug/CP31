using System;
using System.Collections.Generic;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter
{
	// Token: 0x02000008 RID: 8
	public interface IRadioManagementSoftwareLicenseAdapter
	{
		// Token: 0x06000022 RID: 34
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioEntitledLicense> QueryLicensesFromEntitlementID(string eid);

		// Token: 0x06000023 RID: 35
		global::Motorola.CommonCPS.Server.EntityModel.EntitlementList QueryAppLicensesFromEntitlementID(string eid);

		// Token: 0x06000024 RID: 36
		byte[] SubmitLicense(string radioSerialNumber, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense> licenses);

		// Token: 0x06000025 RID: 37
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense> RecoverLicenses(string radioSerialNumber, out byte[] capabilityResponse);

		// Token: 0x06000026 RID: 38
		global::Motorola.CommonCPS.Server.EntityModel.FeatureList RetrieveLicenses(string deviceID, out byte[] capabilityResponse);

		// Token: 0x06000027 RID: 39
		byte[] SubmitAppLicense(global::Motorola.CommonCPS.Server.EntityModel.SendDeviceRequest request, string hostID, global::System.Collections.Generic.List<string> aidsToValidate, out string warningMessage);

		// Token: 0x06000028 RID: 40
		byte[] SubmitAppLicense(global::Motorola.CommonCPS.Server.EntityModel.SendDeviceRequest request, string hostID, string AID, out string warningMessage);

		// Token: 0x06000029 RID: 41
		global::Motorola.CommonCPS.Server.EntityModel.FeatureList QueryFeaturesFromResponse(byte[] response, string deviceID, string featureName, string featureVersion, bool useTrustedStorage = false);

		// Token: 0x0600002A RID: 42
		byte[] RecoverAppLicense(string hostID, out string warningMsg);

		// Token: 0x0600002B RID: 43
		global::Motorola.CommonCPS.Server.EntityModel.SendDeviceRequest CreateActivationRequest(string hostID, string AID, int count);

		// Token: 0x0600002C RID: 44
		string GetAIDFromFeature(global::Motorola.CommonCPS.Server.EntityModel.FeatureItem feature);
	}
}
