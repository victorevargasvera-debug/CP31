using System;
using System.Collections.Generic;
using ASK.Interface;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x0200003A RID: 58
	public interface ITemplateOperation : global::Motorola.CommonCPS.RadioManagement.SharedServices.IRadioFeatureOperation
	{
		// Token: 0x06000590 RID: 1424
		global::Motorola.CommonCPS.Server.EntityModel.Template ParseTemplateFile(string filePath, string password, bool ignorPwdValidation = false);

		// Token: 0x06000591 RID: 1425
		void EditTemplateByCPS(byte[] fileContent, global::Motorola.CommonCPS.Server.EntityModel.Radio rd, global::Motorola.CommonCPS.Server.EntityModel.Template temp);

		// Token: 0x06000592 RID: 1426
		global::Motorola.CommonCPS.Server.EntityModel.Template UpgradeTemplateByFeatures(global::Motorola.CommonCPS.Server.EntityModel.Template template, string sourceCFS, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> radioLicenses, out bool needUpgradeFirmware);

		// Token: 0x06000593 RID: 1427
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> RadioCfsChangesInUpgrade(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.EntityModel.Codeplug codeplug, global::Motorola.CommonCPS.Server.EntityModel.Template template);

		// Token: 0x06000594 RID: 1428
		void ValidateAstroCompatibility(global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug targetCP, global::Motorola.CommonCPS.Server.EntityModel.APXTemplate sourceTempalte, string targetModelnumber);

		// Token: 0x06000595 RID: 1429
		global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeCodeplugEventArgs AstroUpgradeCodeplug(byte[] flashCode, string iButtonSerialNumber, string modelNumber, global::Motorola.CommonCPS.Server.EntityModel.APXTemplate sourceTemplate, byte[] codeplugFileContent, string radioHostVersion, global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware firmware = null, bool brefresh = false, global::ASK.Interface.ISystemKeyData systemID = null);

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000596 RID: 1430
		// (set) Token: 0x06000597 RID: 1431
		global::Motorola.CommonCPS.RadioManagement.SharedServices.SaveCodeplugToRMCDelegate SaveCodeplugDelegate { get; set; }

		// Token: 0x06000598 RID: 1432
		string DownloadPackage(global::System.Guid packageUuids);

		// Token: 0x06000599 RID: 1433
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PackageSummary> GetPackage(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType packageType);

		// Token: 0x0600059A RID: 1434
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROPackage> GetASTROPackagesByCompatibleVersion(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType packageType, string compatibleVersion);

		// Token: 0x0600059B RID: 1435
		global::Motorola.CommonCPS.Server.EntityModel.Package UploadVAPackage(global::Motorola.CommonCPS.Server.EntityModel.Package package);

		// Token: 0x0600059C RID: 1436
		global::Motorola.CommonCPS.Server.EntityModel.Package UploadCACertificatePackage(global::Motorola.CommonCPS.Server.EntityModel.Package package);

		// Token: 0x0600059D RID: 1437
		global::Motorola.CommonCPS.Server.EntityModel.Package UploadDVRSFilePackage(global::Motorola.CommonCPS.Server.EntityModel.Package package);

		// Token: 0x0600059E RID: 1438
		bool IsFirmwareUpgradeIncludeEqual(int productFamily, string ModelNumber, string CFS);

		// Token: 0x0600059F RID: 1439
		bool CheckAstroUpgradeWithLanugagePackIsSupported(string radioFWVersion, string cvnFWVersion);

		// Token: 0x060005A0 RID: 1440
		string AstroDecodeLanguageIndexToLPID(int? languageIndex);

		// Token: 0x060005A1 RID: 1441
		bool CheckIsSupportedLanguagePack(string fwVersion, int? languageIndex);
	}
}
