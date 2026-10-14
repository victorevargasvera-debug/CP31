using System;
using System.ServiceModel;
using Motorola.CommonCPS.RadioManagement.Infrastructure.Services.RMCExportToCPS;
using Motorola.CommonCPS.RadioManagement.SharedServices;

namespace Motorola.CommonCPS.RadioManagement.Interface.RmcCpsWcfContractInterfaceForTestsOnly
{
	// Token: 0x0200000D RID: 13
	[global::System.ServiceModel.ServiceContract]
	public interface IRmcCpsWcfContract
	{
		// Token: 0x06000037 RID: 55
		[global::System.ServiceModel.OperationContract]
		bool InitDeviceManager();

		// Token: 0x06000038 RID: 56
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs ImportDevice(global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs args);

		// Token: 0x06000039 RID: 57
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs ParseAchive(global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs args);

		// Token: 0x0600003A RID: 58
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.RadioManagement.SharedServices.DeviceEventArgs EditTemplate(global::Motorola.CommonCPS.RadioManagement.SharedServices.DeviceEventArgs args);

		// Token: 0x0600003B RID: 59
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs ImportTemplate(global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs args);

		// Token: 0x0600003C RID: 60
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.RadioManagement.SharedServices.ExportDeviceEventArgs ExportDevice(global::Motorola.CommonCPS.RadioManagement.SharedServices.ExportDeviceEventArgs args);

		// Token: 0x0600003D RID: 61
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.RadioManagement.SharedServices.ExportDVRSEventArgs ExportDVRS(global::Motorola.CommonCPS.RadioManagement.SharedServices.ExportDVRSEventArgs args);

		// Token: 0x0600003E RID: 62
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeCodeplugEventArgs AstroUpgradeCodeplug(global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeCodeplugEventArgs args);

		// Token: 0x0600003F RID: 63
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROHoptionEnableEventArgs AstroCheckHoptionEnable(global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROHoptionEnableEventArgs args);

		// Token: 0x06000040 RID: 64
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROHoptionEnableEventArgs AstroCheckIsConvOnly(global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROHoptionEnableEventArgs args);

		// Token: 0x06000041 RID: 65
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.RadioManagement.SharedServices.AnalysisPackageEventArgs AnalysisPackage(global::Motorola.CommonCPS.RadioManagement.SharedServices.AnalysisPackageEventArgs args);

		// Token: 0x06000042 RID: 66
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.RadioManagement.SharedServices.ListLpPackageEventArgs LanguagePackInfos(global::Motorola.CommonCPS.RadioManagement.SharedServices.ListLpPackageEventArgs args);

		// Token: 0x06000043 RID: 67
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroDecodeLanguageIndexToLPIDEventArgs AstroDecodeLangageIndexToLpID(global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroDecodeLanguageIndexToLPIDEventArgs args);

		// Token: 0x06000044 RID: 68
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroLanguageCompatibleCheckEventArgs AstroLanguagePackCompatibleCheck(global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroLanguageCompatibleCheckEventArgs args);

		// Token: 0x06000045 RID: 69
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeWithLanugagePackIsSupportedCheckEventArgs AstroUpgradeWithLanugagePackIsSupportedCheck(global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeWithLanugagePackIsSupportedCheckEventArgs args);

		// Token: 0x06000046 RID: 70
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeFWCompatibleCheckEventArgs AstroUpgradeFWVerCompatibleCheck(global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeFWCompatibleCheckEventArgs args);

		// Token: 0x06000047 RID: 71
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroDecodeFlashCodeEventArgs AstroDecodeFlashCode(global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroDecodeFlashCodeEventArgs args);

		// Token: 0x06000048 RID: 72
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroFlashKeyEventArgs AstroReadFlashKey(global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroFlashKeyEventArgs args);

		// Token: 0x06000049 RID: 73
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroDecreaseKeyCountEventArgs AstroDecraseFlashKey(global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroDecreaseKeyCountEventArgs args);

		// Token: 0x0600004A RID: 74
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroPINPasswordConvertEventArgs AstroPINPasswordConvert(global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroPINPasswordConvertEventArgs args);

		// Token: 0x0600004B RID: 75
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroFlashKeyEventArgs AstroValidateFlashKey(global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroFlashKeyEventArgs args);

		// Token: 0x0600004C RID: 76
		[global::System.ServiceModel.OperationContract]
		void AstroReleaseFlashKey();

		// Token: 0x0600004D RID: 77
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroASKRequirementEventArgs AstroASKRequirementEditingCheck(global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroASKRequirementEventArgs args);

		// Token: 0x0600004E RID: 78
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROIndividualIdEditingEventArgs ASTROIndividualIdEditingCheck(global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROIndividualIdEditingEventArgs args);

		// Token: 0x0600004F RID: 79
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroWritingEventArgs AstroWritingCheck(global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroWritingEventArgs args);

		// Token: 0x06000050 RID: 80
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroCompatibilityEventArgs AstroCompatibilityCheck(global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroCompatibilityEventArgs args);

		// Token: 0x06000051 RID: 81
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroPop25EnabledEventArgs AstroPop25Enabled(global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroPop25EnabledEventArgs args);

		// Token: 0x06000052 RID: 82
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroEncodeFlashCodeEventArgs AstroEncodeFlashCode(global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroEncodeFlashCodeEventArgs args);

		// Token: 0x06000053 RID: 83
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.RadioManagement.SharedServices.ParseFeatureCodeEventArgs ParseFeatureCode(global::Motorola.CommonCPS.RadioManagement.SharedServices.ParseFeatureCodeEventArgs args);

		// Token: 0x06000054 RID: 84
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroParseFlashCodeEventArgs AstroParseFlashCode(global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroParseFlashCodeEventArgs args);

		// Token: 0x06000055 RID: 85
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.RadioManagement.SharedServices.ParseFeatureStatusEventArgs ParseFeatureStatus(global::Motorola.CommonCPS.RadioManagement.SharedServices.ParseFeatureStatusEventArgs args);

		// Token: 0x06000056 RID: 86
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.RadioManagement.SharedServices.PopulateRadioFeaturesFromCodeplugEventArgs PopulateRadioFeaturesFromCodeplug(global::Motorola.CommonCPS.RadioManagement.SharedServices.PopulateRadioFeaturesFromCodeplugEventArgs args);

		// Token: 0x06000057 RID: 87
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.RadioManagement.SharedServices.PopulateRadioFeaturesFromFlashCodeEventArgs PopulateRadioFeaturesFromFlashCode(global::Motorola.CommonCPS.RadioManagement.SharedServices.PopulateRadioFeaturesFromFlashCodeEventArgs args);

		// Token: 0x06000058 RID: 88
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.RadioManagement.Infrastructure.Services.RMCExportToCPS.QueryUpdateRadioEventArgs QueryUpdateRadio(global::Motorola.CommonCPS.RadioManagement.Infrastructure.Services.RMCExportToCPS.QueryUpdateRadioEventArgs args);

		// Token: 0x06000059 RID: 89
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROHoptionEnableEventArgs AstroCheckIsConvOnly2(global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROHoptionEnableEventArgs args);

		// Token: 0x0600005A RID: 90
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.RadioManagement.SharedServices.BindingServerLanguagePackEventArgs BindingServerLanguagePack(global::Motorola.CommonCPS.RadioManagement.SharedServices.BindingServerLanguagePackEventArgs args);

		// Token: 0x0600005B RID: 91
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.RadioManagement.SharedServices.IsFreonEventArgs RMCWnd_IsFreon(global::Motorola.CommonCPS.RadioManagement.SharedServices.IsFreonEventArgs args);

		// Token: 0x0600005C RID: 92
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroSystemKeyDataEventArgs AstroGetLoadedSysKeys(global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroSystemKeyDataEventArgs args);

		// Token: 0x0600005D RID: 93
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.RadioManagement.SharedServices.ListTTSLpPackageEventArgs TTSLanguagePackInfos(global::Motorola.CommonCPS.RadioManagement.SharedServices.ListTTSLpPackageEventArgs args);

		// Token: 0x0600005E RID: 94
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.RadioManagement.SharedServices.PcrLanguagePackCompatibleCheckEventArgs PcrLanguagePackCompatibleCheck(global::Motorola.CommonCPS.RadioManagement.SharedServices.PcrLanguagePackCompatibleCheckEventArgs args);

		// Token: 0x0600005F RID: 95
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.RadioManagement.SharedServices.ModelTierEventArgs ModelTier(global::Motorola.CommonCPS.RadioManagement.SharedServices.ModelTierEventArgs args);

		// Token: 0x06000060 RID: 96
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.RadioManagement.SharedServices.GetVAInstallationPathEventArgs GetVAInsallationPath(global::Motorola.CommonCPS.RadioManagement.SharedServices.GetVAInstallationPathEventArgs args);

		// Token: 0x06000061 RID: 97
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.RadioManagement.SharedServices.GetTTSInstallationPathEventArgs GetTTSInsallationPath(global::Motorola.CommonCPS.RadioManagement.SharedServices.GetTTSInstallationPathEventArgs args);

		// Token: 0x06000062 RID: 98
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.RadioManagement.SharedServices.GetPcrUserRegionArgs GetPcrCpsUserRegion(global::Motorola.CommonCPS.RadioManagement.SharedServices.GetPcrUserRegionArgs args);

		// Token: 0x06000063 RID: 99
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.RadioManagement.SharedServices.UpdatePcrFwDescriptionArgs UpdatePcrFwDescription(global::Motorola.CommonCPS.RadioManagement.SharedServices.UpdatePcrFwDescriptionArgs args);

		// Token: 0x06000064 RID: 100
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.RadioManagement.SharedServices.FirmwareUpgradeIncludeEqualEventArgs FirmwareUpgradeIncludeEqual(global::Motorola.CommonCPS.RadioManagement.SharedServices.FirmwareUpgradeIncludeEqualEventArgs args);

		// Token: 0x06000065 RID: 101
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.RadioManagement.SharedServices.IsSameFWVersionUpgradeSupportedEventArgs IsSameFWVersionUpgradeSupported(global::Motorola.CommonCPS.RadioManagement.SharedServices.IsSameFWVersionUpgradeSupportedEventArgs args);

		// Token: 0x06000066 RID: 102
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.RadioManagement.SharedServices.PCRFilterLicenseEventArgs PCRFilterLicense(global::Motorola.CommonCPS.RadioManagement.SharedServices.PCRFilterLicenseEventArgs args);

		// Token: 0x06000067 RID: 103
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.RadioManagement.SharedServices.GenerateLicenseFilterEventArgs GenerateLicenseFilter(global::Motorola.CommonCPS.RadioManagement.SharedServices.GenerateLicenseFilterEventArgs args);

		// Token: 0x06000068 RID: 104
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.RadioManagement.SharedServices.ParseRadioFeatureEventArgs ParseRadioFeature(global::Motorola.CommonCPS.RadioManagement.SharedServices.ParseRadioFeatureEventArgs args);

		// Token: 0x06000069 RID: 105
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.RadioManagement.SharedServices.UpgradeTemplateByFeaturesEventArgs UpgradeTemplateByFeatures(global::Motorola.CommonCPS.RadioManagement.SharedServices.UpgradeTemplateByFeaturesEventArgs args);

		// Token: 0x0600006A RID: 106
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.RadioManagement.SharedServices.ApplyRadioWithFeaturesEventArgs ApplyRadioWithFeatures(global::Motorola.CommonCPS.RadioManagement.SharedServices.ApplyRadioWithFeaturesEventArgs args);

		// Token: 0x0600006B RID: 107
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioCfsChangesInUpgradeEventArgs RadioCfsChangesInUpgrade(global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioCfsChangesInUpgradeEventArgs args);
	}
}
