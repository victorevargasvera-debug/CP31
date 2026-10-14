using System;
using System.Collections.Generic;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000008 RID: 8
	public interface IASTROLocalService : global::Motorola.CommonCPS.RadioManagement.LocalService.ILocalService, global::Motorola.CommonCPS.RadioManagement.LocalService.IGeneralPackageLocalService
	{
		// Token: 0x060000C6 RID: 198
		bool CheckAstroPop25Enabled();

		// Token: 0x060000C7 RID: 199
		global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware> LoadAvailableFWPackagesForASTROUpgrade(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> radioList, bool isRefresh, string codeplugVersion = null);

		// Token: 0x060000C8 RID: 200
		global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware> LoadAvailableFWPackagesForAMPUpgrade(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> radioList, bool isRefresh, string maxSupportedCodeplugVersion);

		// Token: 0x060000C9 RID: 201
		void CheckDevicesIsMatchFlashKey(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> selectedRadios, out string newFlashCode, out string warning);

		// Token: 0x060000CA RID: 202
		bool IsRadioSupportWriteLPWhenUpgrade(global::System.Guid radioUuid, string packageVersion);

		// Token: 0x060000CB RID: 203
		bool AstroCheckAskEnable(string flashcode, string modelNumber);

		// Token: 0x060000CC RID: 204
		global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem> RefreshRadioSystemViewForRadio(global::Motorola.CommonCPS.Server.EntityModel.APXRadio validateRadio);

		// Token: 0x060000CD RID: 205
		void RefreshDataProfileForRadio(global::Motorola.CommonCPS.Server.EntityModel.APXRadio aPXRadio);

		// Token: 0x060000CE RID: 206
		void RefreshASTROOtarProfilesForOneRadioFromCache(global::Motorola.CommonCPS.Server.EntityModel.APXRadio aPXRadio, global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile currentASTROOtarProfile);

		// Token: 0x060000CF RID: 207
		void RefreshASTROOtarProfilesForOneRadioFromDB(global::Motorola.CommonCPS.Server.EntityModel.APXRadio aPXRadio);

		// Token: 0x060000D0 RID: 208
		void RefreshASTROOtarProfilesForRadio(global::Motorola.CommonCPS.Server.EntityModel.APXRadio aPXRadio);

		// Token: 0x060000D1 RID: 209
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile> ListASTROOtarProfilesByRadioWorkingCP(global::Motorola.CommonCPS.Server.EntityModel.Radio rawRadio);

		// Token: 0x060000D2 RID: 210
		void GetRadioDataForQueryRadioOperation(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroDevice, global::Motorola.CommonCPS.RadioManagement.UIModels.UpdateRadioContext context);

		// Token: 0x060000D3 RID: 211
		void InitialQueryUpdateRadio(global::Motorola.CommonCPS.RadioManagement.UIModels.UpdateRadioContext context);

		// Token: 0x060000D4 RID: 212
		global::System.Collections.Generic.List<string> GetSupportedCodelugVersion(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily, string maxCodeplugVersionOfRadio);

		// Token: 0x060000D5 RID: 213
		global::System.Collections.Generic.List<string> GetSupportedCodelugVersion_forUpgradeCPVersion(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily, string maxCodeplugVersionOfRadio);
	}
}
