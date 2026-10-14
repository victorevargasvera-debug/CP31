using System;
using System.Collections.Generic;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;
using Motorola.CommonCPS.Server.GenericModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x0200003B RID: 59
	public interface IRadioFeatureOperation
	{
		// Token: 0x060005A2 RID: 1442
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.HOption> GetRadioOptionWithPCI(global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.Radio, global::Motorola.CommonCPS.Server.EntityModel.Codeplug> EMRadio);

		// Token: 0x060005A3 RID: 1443
		global::Motorola.CommonCPS.Server.EntityModel.Radio ParseAchiveFile(string filePath, bool IgnorePassword, string password, out global::System.Collections.Generic.Dictionary<int, int> optionCount);

		// Token: 0x060005A4 RID: 1444
		byte[] ConvertArchiveToXpbaByteArray(string filePath);

		// Token: 0x060005A5 RID: 1445
		global::Motorola.CommonCPS.Server.EntityModel.Radio ParsePBA(byte[] pbaData, out global::System.Collections.Generic.Dictionary<int, int> optionCount, out string ArchiveFilePath, out bool canBePack, bool IgnorePassword, string password);

		// Token: 0x060005A6 RID: 1446
		global::Motorola.CommonCPS.Server.EntityModel.Radio GetRadioFromPBA(byte[] pbaData);

		// Token: 0x060005A7 RID: 1447
		void ExportDevice(global::Motorola.CommonCPS.Server.EntityModel.Radio rd, string filePathName, string fieldError);

		// Token: 0x060005A8 RID: 1448
		void ExportDVRS(global::Motorola.CommonCPS.Server.EntityModel.Radio rd, string filePathName);

		// Token: 0x060005A9 RID: 1449
		void ExportDeviceToMNISXML(global::Motorola.CommonCPS.Server.EntityModel.Radio rd, string filePathName, string fieldError);

		// Token: 0x060005AA RID: 1450
		void ValidateAstroWriting(global::Motorola.CommonCPS.Server.EntityModel.APXRadio radio, bool enableWritingProtect, int transportPreference, bool isWriteProtected, bool isRestoreJob, bool restoreJob_PbaCanNotBeDirectlyModified, out global::Motorola.CommonCPS.Server.EntityModel.SecurityFieldRequest updatedCP);

		// Token: 0x060005AB RID: 1451
		bool CheckPcrLanguagePackCompatible(global::Motorola.CommonCPS.Server.CommonDBConstants.LanguagePackFamily languagePackFamily, string languagePackId, string codeplugVersion);

		// Token: 0x060005AC RID: 1452
		string AstroPINPasswordConvert(string source, bool encrypt);

		// Token: 0x060005AD RID: 1453
		global::Motorola.CommonCPS.RadioManagement.SharedServices.FlashKeyInfo ReadFlashKey(string OldModelNumber, byte[] OldFlashCode);

		// Token: 0x060005AE RID: 1454
		bool ValidateFlashKey(string OldModelNumber, byte[] OldFlashCode);

		// Token: 0x060005AF RID: 1455
		void AstroReleaseFlashKey();

		// Token: 0x060005B0 RID: 1456
		void DecreaseFlashKeyCount(string oldModelNumber, byte[] oldFlashCode, int decreaseCount);

		// Token: 0x060005B1 RID: 1457
		string AstroDecodeFlashCode(byte[] flashCode);

		// Token: 0x060005B2 RID: 1458
		byte[] AstroEncodeFlashCode(string flashCode);

		// Token: 0x060005B3 RID: 1459
		bool CheckAstroUpgradeFWIsSupported(string cvnFWVersion, string codeplugVersion = null);

		// Token: 0x060005B4 RID: 1460
		bool CheckAstroFWIsSupportedCurrentLanguagePack(string fwVersion, string lpCompatibleVerion, int? languageIndex);

		// Token: 0x060005B5 RID: 1461
		bool AnslysisPCRModelNumber(string modelNumber);

		// Token: 0x060005B6 RID: 1462
		global::Motorola.CommonCPS.Server.EntityModel.Package AnalysisPackageInfo(string filePath);

		// Token: 0x060005B7 RID: 1463
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.Package> AnalysisListPackageInfo(string filePath);

		// Token: 0x060005B8 RID: 1464
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package> LanguagePackInfos();

		// Token: 0x060005B9 RID: 1465
		string GetVaInstallationPath();

		// Token: 0x060005BA RID: 1466
		string GetTTSInstallationPath();

		// Token: 0x060005BB RID: 1467
		string UpdatePcrFwDescription(global::System.Collections.Generic.Dictionary<string, string> MapForDescription, string PcrFwDescription);

		// Token: 0x060005BC RID: 1468
		string GetLocalizedFeatureName(int featureNameTag);

		// Token: 0x060005BD RID: 1469
		string ParseFeatureCode(int featureCode, string modelNumber);

		// Token: 0x060005BE RID: 1470
		string ParseFeatureStatus(global::Motorola.CommonCPS.Server.CommonDBConstants.FeatureStatus fs);

		// Token: 0x060005BF RID: 1471
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioEntitledLicense> FilterLicenseList(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioEntitledLicense> originalLicenseList);

		// Token: 0x060005C0 RID: 1472
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SharedServices.PcrRadioEntitledLicenseSummary> PCRFilterLicenseList(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioEntitledLicense> licenseList);

		// Token: 0x060005C1 RID: 1473
		global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.ObservableCollectionFast<global::Motorola.CommonCPS.Server.EntityModel.CpsFeatureItem> CpsPcrFilterLicenseList(global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PcrFeatureDetail> licenseList);

		// Token: 0x060005C2 RID: 1474
		global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureFilter GenerateLicenseFilter(global::System.Collections.Generic.IList<string> selectedlicenseGroup, global::System.Collections.Generic.IList<string> newSelectedLicenseGroup, out global::System.Collections.Generic.IList<string> toUnselectedLicenseGroup);

		// Token: 0x060005C3 RID: 1475
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PcrFeatureDetail> CpsGetPcrFeatureDetail(global::Motorola.CommonCPS.Server.EntityModel.FeatureList featureNames);

		// Token: 0x060005C4 RID: 1476
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> ApplyRadioWithFeatures(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense> radioLicenses, out bool canUpgraded, out bool anyInvalid, out string warning);

		// Token: 0x060005C5 RID: 1477
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> PopulateRadioFeaturesFromCodeplug(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.EntityModel.Template targetTemplate, out int cfsModelType);

		// Token: 0x060005C6 RID: 1478
		global::Motorola.CommonCPS.RadioManagement.SharedServices.PopulateRadioFeaturesFromFlashCodeEventArgs PopulateRadioFeaturesFromFlashCode(byte[] flashCode, string modelNumber);

		// Token: 0x060005C7 RID: 1479
		void ParseRadioFeature(global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary featureSummary, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase radioLicense);

		// Token: 0x060005C8 RID: 1480
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadioLicense> AstroParseFlashCode(global::Motorola.CommonCPS.Server.EntityModel.RadioSummary rawRd, global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio localRd);

		// Token: 0x060005C9 RID: 1481
		global::System.Collections.Generic.Dictionary<int, string> AstroParseFlashCode(string flashCode, string modelNumber);

		// Token: 0x060005CA RID: 1482
		bool CheckAstroPop25Enabled();

		// Token: 0x060005CB RID: 1483
		void ValidateAstroCompatibility(global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug targetCP, global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug sourceCP, string targetModelnumber);

		// Token: 0x060005CC RID: 1484
		bool AstroCheckHoptionEnable(string flashcode, string hoption, string modelNumber);

		// Token: 0x060005CD RID: 1485
		bool AstroCheckIsConvOnly(string flashcode, string modelNumber);

		// Token: 0x060005CE RID: 1486
		bool CheckForUnlimited();

		// Token: 0x060005CF RID: 1487
		global::Motorola.CommonCPS.RadioManagement.SharedServices.OverrideResult GetResultForImportWithNeverOverride(global::Motorola.CommonCPS.Server.CommonDBConstants.ImportOption option);

		// Token: 0x060005D0 RID: 1488
		global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile FindSelectedProfileInRadioSystem(global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem sys, global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile> profiles);

		// Token: 0x060005D1 RID: 1489
		string AddFileSuffixForExportASTRORadio(string fileName);

		// Token: 0x060005D2 RID: 1490
		string AddFileSuffixForExportPCRRadio(string fileName);

		// Token: 0x060005D3 RID: 1491
		global::System.Collections.Generic.List<string> GetSupportedCodelugVersion(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily, string maxCodeplugVersionOfRadio);

		// Token: 0x060005D4 RID: 1492
		global::System.Collections.Generic.List<string> GetSupportedCodelugVersion_forUpgradeCPVersion(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily, string maxCodeplugVersionOfRadio);

		// Token: 0x060005D5 RID: 1493
		bool IsFreon(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily, string modelNumber);

		// Token: 0x060005D6 RID: 1494
		void ValidateForeignIP(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference transport);

		// Token: 0x060005D7 RID: 1495
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package> GetVAPackages(global::Motorola.CommonCPS.Server.EntityModel.Codeplug codeplug);

		// Token: 0x060005D8 RID: 1496
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package> GetCACertificatePackages(global::Motorola.CommonCPS.Server.EntityModel.Codeplug codeplug);

		// Token: 0x060005D9 RID: 1497
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package> GetDVRSFilePackages(global::Motorola.CommonCPS.Server.EntityModel.Codeplug codeplug);

		// Token: 0x060005DA RID: 1498
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package> GetTTSPackages(global::Motorola.CommonCPS.Server.EntityModel.Codeplug codeplug);

		// Token: 0x060005DB RID: 1499
		bool IsRadioSupportWriteLPWhenUpgrade(global::System.Guid radioUuid, string packageVersion);

		// Token: 0x060005DC RID: 1500
		void UpdateRestoreJobzCodeplug(global::Motorola.CommonCPS.Server.EntityModel.Codeplug historical_Codeplug, global::Motorola.CommonCPS.Server.EntityModel.Radio radio_fromPBA);

		// Token: 0x060005DD RID: 1501
		void UploadPackageFileContentToServer(global::Motorola.CommonCPS.Server.EntityModel.Codeplug Historical_Codeplug, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField> validateEntitySet);

		// Token: 0x060005DE RID: 1502
		global::Motorola.CommonCPS.Server.GenericModel.ResultOfUpgradeCPVersion UpgradeCPVersion(global::Motorola.CommonCPS.Server.GenericModel.InputOfUpgradeCPVersion _InputOfUpgradeCPVersion);
	}
}
