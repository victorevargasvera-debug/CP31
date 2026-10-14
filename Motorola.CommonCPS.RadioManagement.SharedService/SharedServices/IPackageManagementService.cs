using System;
using System.Collections.Generic;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000016 RID: 22
	public interface IPackageManagementService : global::Motorola.CommonCPS.RadioManagement.SharedServices.IService
	{
		// Token: 0x060000C9 RID: 201
		bool DeletePackages(global::System.Guid? jobContainerGuid, global::Motorola.CommonCPS.Server.EntityModel.Package package, string packageName);

		// Token: 0x060000CA RID: 202
		global::Motorola.CommonCPS.Server.EntityModel.PackageSummary CheckAndImportBacthPackage(global::System.Guid batchJobContainer, string filePath, global::Motorola.CommonCPS.Server.EntityModel.Package package, string jobDescription, out bool isOverwrite);

		// Token: 0x060000CB RID: 203
		global::Motorola.CommonCPS.Server.EntityModel.PackageSummary CheckAndImportBatchAstroFirmware(global::System.Guid batchJobContainerUuid, global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware> astroFirmwares, string jobDescription, out bool isOverwrite);

		// Token: 0x060000CC RID: 204
		global::Motorola.CommonCPS.Server.EntityModel.PackageSummary EditPackageColumn(global::Motorola.CommonCPS.Server.EntityModel.PackageSummary summary);

		// Token: 0x060000CD RID: 205
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package> GetLanguagePackInfos();

		// Token: 0x060000CE RID: 206
		global::Motorola.CommonCPS.Server.EntityModel.Package CheckPackageExist(global::Motorola.CommonCPS.Server.EntityModel.Package package);

		// Token: 0x060000CF RID: 207
		global::Motorola.CommonCPS.Server.EntityModel.Package GetPackage(global::System.Guid packageUuid);

		// Token: 0x060000D0 RID: 208
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PackageSummary> ListGeneralPackages(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType packageType, string modelNumber = null);

		// Token: 0x060000D1 RID: 209
		string GetVaInstallationPath();

		// Token: 0x060000D2 RID: 210
		string GetTTSInstallationPath();

		// Token: 0x060000D3 RID: 211
		string GetCpsVaImportPath();

		// Token: 0x060000D4 RID: 212
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.PackageSummary> GetPackageSummaries(int startIndex, int length, global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType type, int? region);
	}
}
