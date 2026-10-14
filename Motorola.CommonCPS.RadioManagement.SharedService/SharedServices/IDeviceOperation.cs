using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ASK.Interface;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;
using SharedUtility.Arguments;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000014 RID: 20
	public interface IDeviceOperation
	{
		// Token: 0x060000A9 RID: 169
		bool IsSerialNumberValid(string serialNumber);

		// Token: 0x060000AA RID: 170
		void ValidateCodeplugVersion(global::Motorola.CommonCPS.Server.EntityModel.Radio radio);

		// Token: 0x060000AB RID: 171
		void ValidateIsAllowWriteLanguage(global::Motorola.CommonCPS.Server.EntityModel.APXRadio radio, global::Motorola.CommonCPS.Server.CommonDBConstants.JobType type);

		// Token: 0x060000AC RID: 172
		void PreImportRadioToServer(string filePath, global::Motorola.CommonCPS.Server.EntityModel.Radio deviceToImport, global::Motorola.CommonCPS.Server.CommonDBConstants.ImportOption option);

		// Token: 0x060000AD RID: 173
		void BuildValidateSetForASTROScheduleJob(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.EntityModel.Codeplug currentCodeplug, global::Motorola.CommonCPS.Server.EntityModel.Codeplug workingCodeplug, ref global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet set);

		// Token: 0x060000AE RID: 174
		global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet BuildValidateEntitySetForASTRORadioUpgrade(global::Motorola.CommonCPS.Server.EntityModel.APXRadio updatedRadio, global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROSyncData syncRadioForUpgrade);

		// Token: 0x060000AF RID: 175
		global::Motorola.CommonCPS.Server.CommonDBConstants.ImportOption GetServerReadyJobtOption(bool generateTemplateOrConfig, bool applyToRadio);

		// Token: 0x060000B0 RID: 176
		void GetSyncDataForUpgrade(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware firmware, byte[] flashCode, string iButtonSerialNumber, global::System.Collections.Generic.IList<global::System.Guid> cross712Radios, int allRadioCount, bool isRefresh, global::ASK.Interface.ISystemKeyData systemID, out global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROSyncData syncData, string codeplugVersion = null);

		// Token: 0x060000B1 RID: 177
		void CleanForUpgrade(global::System.Collections.Generic.IList<global::System.Guid> upgradeSuccessfulRadios, global::System.Collections.Generic.IList<global::System.Guid> Cross712Radios, global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROSyncData syncData);

		// Token: 0x060000B2 RID: 178
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary UpgradeASTRORadioBatch(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.Radio radioToUpgrdae, global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROSyncData syncData, global::Motorola.CommonCPS.RadioManagement.SharedServices.FlashKeyInfo flashKeyInfo, global::System.Collections.Generic.IList<global::System.Guid> cross712Radios);

		// Token: 0x060000B3 RID: 179
		global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest HandleTemplateAndConfigForImportCSV(global::Motorola.CommonCPS.Server.EntityModel.Radio existedRadio, string templateName, string configName, string copiedRadioSN, global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest radioRq, global::Motorola.CommonCPS.RadioManagement.SharedServices.ImportCSVCache cache, ref global::System.Collections.Generic.List<string> warningList);

		// Token: 0x060000B4 RID: 180
		global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest HandleIPProgramSystemForImportCSV(global::Motorola.CommonCPS.Server.EntityModel.Radio existedRadio, string ipProgramSystemAlias, string copiedRadioSN, global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest radioRq, global::Motorola.CommonCPS.RadioManagement.SharedServices.ImportCSVCache cache, ref global::System.Collections.Generic.List<string> warningList);

		// Token: 0x060000B5 RID: 181
		bool IsQualifiedRadio(global::Motorola.CommonCPS.Server.EntityModel.Radio rd, global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest rq);

		// Token: 0x060000B6 RID: 182
		global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? GetDefaultRegion();

		// Token: 0x060000B7 RID: 183
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SharedServices.AppLicenseInfo> GetRegisteredAppLicenses();

		// Token: 0x060000B8 RID: 184
		bool IsAppLicenseSupport_RRP(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName?> regionList);

		// Token: 0x060000B9 RID: 185
		bool ValidateAstroASKRequirement(global::Motorola.CommonCPS.Server.EntityModel.APXRadio radioFromServer, out string stsMsg);

		// Token: 0x060000BA RID: 186
		bool ValidateRadioIdWithASK(global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem radioSys, global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxCpg, string modelnumber, out string error, bool checkASKOnly = false);

		// Token: 0x060000BB RID: 187
		string GetFileNameForExportCodeplug(string serialNumber, string templateName, string configName, bool? hasPBA);

		// Token: 0x060000BC RID: 188
		global::Motorola.CommonCPS.Server.CommonDBConstants.ImportOption GetImportOption(bool isCreateRadio, bool isCreateTemplate, bool isCreateConfig, bool isApply);

		// Token: 0x060000BD RID: 189
		bool CanImportRadio(bool isCreateRadio, bool isCreateConfig);

		// Token: 0x060000BE RID: 190
		bool IsInitializeImportRadio(out bool canOverride);

		// Token: 0x060000BF RID: 191
		bool IsValidAppLicense(string licenseName);

		// Token: 0x060000C0 RID: 192
		bool CanExportCodeplug(global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus radioStatus, bool? hasPBA);

		// Token: 0x060000C1 RID: 193
		void FetchPCRKeysFromServer(global::Motorola.CommonCPS.Server.EntityModel.PCRKeyData keyData);

		// Token: 0x060000C2 RID: 194
		bool ValidateIPConflictWithLocalServerIPAddress(global::SharedUtility.Arguments.Apx_ArgumentOfSharedConstraint arge, bool? locationEnable, bool? p25LocationReporting, int? arsMode, bool? directLocationRegistration, string locationServerIPAddress, out global::Motorola.Common.CustomException.CommonErrorCode error);

		// Token: 0x060000C3 RID: 195
		bool ValidataIPConflictWithBluetoothPANNetworkBaseAddress(global::SharedUtility.Arguments.Apx_ArgumentOfSharedConstraint arge, string bluetoothPANNetworkBaseAddress, out global::Motorola.Common.CustomException.CommonErrorCode error);

		// Token: 0x060000C4 RID: 196
		bool ValidataIPConflictLink2IPs(global::SharedUtility.Arguments.Apx_ArgumentOfSharedConstraint arge, bool IsDVRSMSUOperation, string PeerIP_Link2, string SubscriberIP_Link2, out global::Motorola.Common.CustomException.CommonErrorCode error);

		// Token: 0x060000C5 RID: 197
		global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData> GetLoadedASKWithoutDefault(bool isAttached = false);

		// Token: 0x060000C6 RID: 198
		global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData> GetLoadedASKWithDefault(bool isAttached = false);

		// Token: 0x060000C7 RID: 199
		void ResetRegionWithAppRegion(global::Motorola.CommonCPS.Server.EntityModel.Radio d);
	}
}
