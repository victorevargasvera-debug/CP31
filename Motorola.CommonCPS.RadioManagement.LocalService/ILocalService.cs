using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;
using Motorola.CommonCPS.Server.EntityModel.GenericModel;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000009 RID: 9
	public interface ILocalService : global::Motorola.CommonCPS.RadioManagement.LocalService.IGeneralPackageLocalService
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060000D6 RID: 214
		bool IsConnected { get; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060000D7 RID: 215
		// (set) Token: 0x060000D8 RID: 216
		bool IsServerEventLocal { get; set; }

		// Token: 0x060000D9 RID: 217
		bool Connect(bool backgroundconnection = false);

		// Token: 0x060000DA RID: 218
		void Disconnect();

		// Token: 0x060000DB RID: 219
		global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem> GetASTROSystems(string groupID);

		// Token: 0x060000DC RID: 220
		global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemInfo> GetASTROSystemInfos(string groupID);

		// Token: 0x060000DD RID: 221
		global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem> GetRadioInfosBySystem(string groupID, string customId);

		// Token: 0x060000DE RID: 222
		global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemRadioInfo> GetSystemRadioInfos(string groupID);

		// Token: 0x060000DF RID: 223
		global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem> GetSystemInfosbyRadio(string radioID);

		// Token: 0x060000E0 RID: 224
		void ValidateRRPJob(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.EntityModel.JobRequest rq);

		// Token: 0x060000E1 RID: 225
		global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile> GetASTRODataProfiles(string groupID);

		// Token: 0x060000E2 RID: 226
		global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile> GetRadiosByProfile(string groupID, string customId, string profileName);

		// Token: 0x060000E3 RID: 227
		global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile> GetProfileInfosbyRadio(string radioID);

		// Token: 0x060000E4 RID: 228
		global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileInfo> GetASTROProfileInfos(string groupID);

		// Token: 0x060000E5 RID: 229
		global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileRadioInfo> GetProfileRadioInfos(string groupID);

		// Token: 0x060000E6 RID: 230
		global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile> GetASTROOtarProfiles(string groupID);

		// Token: 0x060000E7 RID: 231
		global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile> GetASTRORadiosByOtarProfile(string groupID, global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileInfo otarProfileInfo);

		// Token: 0x060000E8 RID: 232
		global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile> GetASTROOtarProfileInfosbyRadio(string radioID);

		// Token: 0x060000E9 RID: 233
		global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileInfo> GetASTROOtarProfileInfos(string groupID);

		// Token: 0x060000EA RID: 234
		global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileRadioInfo> GetASTROOtarProfileRadioInfos(string groupID);

		// Token: 0x060000EB RID: 235
		void RefreshASTROOtarProfilesForFillUpDown(global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile> selectedItems);

		// Token: 0x060000EC RID: 236
		global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer> GetJobContainers();

		// Token: 0x060000ED RID: 237
		global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer> GetJobContainers(bool isRwJbc);

		// Token: 0x060000EE RID: 238
		global::Motorola.CommonCPS.Server.EntityModel.JobContainerSummary GetJobContainerSummary(global::System.Guid guid);

		// Token: 0x060000EF RID: 239
		global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer GetJobContainers(global::System.Guid guid);

		// Token: 0x060000F0 RID: 240
		global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer, global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.JobBase>> GetJobs(global::System.Guid jbcUuid);

		// Token: 0x060000F1 RID: 241
		global::Motorola.CommonCPS.Server.EntityModel.Job GetJob(global::System.Guid guid);

		// Token: 0x060000F2 RID: 242
		global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> GetRadiosUsingConfiguration(global::System.Guid configurationUuid);

		// Token: 0x060000F3 RID: 243
		global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> GetRadiosUsingConfigurationWithWorkingCodeplug(global::System.Guid configurationUuid, global::System.Guid excludedRadioUuid);

		// Token: 0x060000F4 RID: 244
		int GetRadiosCountUsingConfig(global::System.Guid configurationUuid);

		// Token: 0x060000F5 RID: 245
		global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.LanguagePack> GetLanguagePackages();

		// Token: 0x060000F6 RID: 246
		global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceAnnouncement> GetVoiceAnnouncementPackages();

		// Token: 0x060000F7 RID: 247
		global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.CACertificates> GetCACertificatesPackages();

		// Token: 0x060000F8 RID: 248
		global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.TextToSpeech> GetTextToSpeechPackages();

		// Token: 0x060000F9 RID: 249
		global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware> GetFirmwarePackages();

		// Token: 0x060000FA RID: 250
		global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.DVRSFiles> GetDVRSFilesPackages();

		// Token: 0x060000FB RID: 251
		global::Motorola.CommonCPS.RadioManagement.UIModels.RadioDetails GetRadioDetails(global::System.Guid id, bool loadJobsSynchronously = true);

		// Token: 0x060000FC RID: 252
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.HistoricalJob> GetRadioHistoricalJobs(global::System.Guid deviceID, int startIndex, int count);

		// Token: 0x060000FD RID: 253
		int GetDeviceRWJobsCount(global::System.Guid deviceID);

		// Token: 0x060000FE RID: 254
		global::Motorola.CommonCPS.RadioManagement.UIModels.RadioDetails GetRadioDetailsBySerialNumber(string serialNumber);

		// Token: 0x060000FF RID: 255
		global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> GetRadios(global::Motorola.CommonCPS.RadioManagement.UIModels.Group group, global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode workMode);

		// Token: 0x06000100 RID: 256
		global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> GetRadiosForConversion(global::Motorola.CommonCPS.RadioManagement.UIModels.Group group);

		// Token: 0x06000101 RID: 257
		global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.LanguageDetailInfo> GetRadioLanguagesDetailInfo(global::System.Guid radioUUID);

		// Token: 0x06000102 RID: 258
		global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceDetailInfo> GetRadioVADetailInfo(global::System.Guid radioUUID);

		// Token: 0x06000103 RID: 259
		global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.LanguageDetailInfo> GetTemplateLanguagesDetailInfo(global::System.Guid templateUUID);

		// Token: 0x06000104 RID: 260
		global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceDetailInfo> GetTemplateVADetailInfo(global::System.Guid templateUUID);

		// Token: 0x06000105 RID: 261
		global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.Server.EntityModel.PCRDeviceCertificateDetailInfo> GetRadioPCRDeviceCertificateDetailInfo(global::System.Guid radioUUID);

		// Token: 0x06000106 RID: 262
		global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase EditPCRDeviceCertificate(global::System.Guid radioUuid, global::System.Guid deviceCertUuid, global::System.Collections.Generic.Dictionary<string, object> fieldValues, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet set);

		// Token: 0x06000107 RID: 263
		void UpdateSession();

		// Token: 0x06000108 RID: 264
		global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase> GetTemplate();

		// Token: 0x06000109 RID: 265
		global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase> GetCompatibleTemplateSummaryList(global::System.Collections.Generic.List<global::System.Guid> radioUUIDList);

		// Token: 0x0600010A RID: 266
		global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioOption> GetReferencedRadioList(global::System.Guid templateUuid, bool returnWorkingRadiosOnly = false);

		// Token: 0x0600010B RID: 267
		global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.LanguagePack> GetPCRLanguagePackLatestByFamily(global::Motorola.CommonCPS.Server.CommonDBConstants.LanguagePackFamily languagePackFamily);

		// Token: 0x0600010C RID: 268
		void GetAvailableDevices(global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> availableDevices, global::System.Guid? groupUUID, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail> selectedEIDDetails, int featureType = 0);

		// Token: 0x0600010D RID: 269
		global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase> GetRadioFeatures(string groupID, int featureType = 0);

		// Token: 0x0600010E RID: 270
		global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase> GetRadioFeatureDetailsByFeature(string groupID, int featureID, int featureType = 0);

		// Token: 0x0600010F RID: 271
		global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseFeatureViewBase> ListRadioFeatureSummaryByFeature(string groupID, int featureType = 0);

		// Token: 0x06000110 RID: 272
		global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase> GetRadioFeatureDetailsByRadio(global::System.Guid radioUuid, int featureType = 0);

		// Token: 0x06000111 RID: 273
		global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseRadioViewBase> ListRadioFeatureSummaryByRadio(string groupID, int featureType = 0);

		// Token: 0x06000112 RID: 274
		global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo> ListAppFeatures();

		// Token: 0x06000113 RID: 275
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo> ListAppLicenses();

		// Token: 0x06000114 RID: 276
		int GetAppLicenseCount();

		// Token: 0x06000115 RID: 277
		bool IsRadioSupportSelectedEID(string serialNumber, global::System.Guid? groupUUID, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail> selectedEIDDetails, int featureType = 0);

		// Token: 0x06000116 RID: 278
		global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RMResource> LoadRMResources();

		// Token: 0x06000117 RID: 279
		global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase EditRadioColumn(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase oldDevice, object newValue, string editedFieldName, bool commit, out string error);

		// Token: 0x06000118 RID: 280
		global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase EditTemplateColumn(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase oldTemplate, object newValue, string editedFieldName, out string error);

		// Token: 0x06000119 RID: 281
		global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase GetPackagesFromCPS(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType packageType);

		// Token: 0x0600011A RID: 282
		global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase GetPackagesFromCPS(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType packageType, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.PackageFileInfo> packageFileInfoList);

		// Token: 0x0600011B RID: 283
		void TrimCodeplug(global::Motorola.CommonCPS.Server.EntityModel.Codeplug cp);

		// Token: 0x0600011C RID: 284
		void CopyRadioIdentity(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioToCopy, out global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Guid, byte[]>> copyRadioIdentityInfo, out global::Motorola.CommonCPS.Server.EntityModel.Radio validateRadio);

		// Token: 0x0600011D RID: 285
		bool PasteRadioIdentity(global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Guid, byte[]>> copiedRadioIdentityRecords, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioToPaste, out global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>> pasteRadioIdentityRecordsForServer, out global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase transferredRadio, out global::Motorola.CommonCPS.Server.EntityModel.Radio validatePasteRadio, out global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.FieldPasteWarningInfo> cannotPasteList);

		// Token: 0x0600011E RID: 286
		global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase SubmitRadioPasteValue(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase toPasteRadio, global::Motorola.CommonCPS.Server.EntityModel.Radio validateRadio, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>> pasteRadioIdentityRecordsForServer);

		// Token: 0x0600011F RID: 287
		string GetHelpFilePath(string fieldPath = null);

		// Token: 0x06000120 RID: 288
		string GetHelpFilePathForTemplate();

		// Token: 0x06000121 RID: 289
		string ParseFieldPath(string[] pathArray);

		// Token: 0x06000122 RID: 290
		global::System.Collections.Generic.List<global::System.Guid> GetLastSelected(object item);

		// Token: 0x06000123 RID: 291
		void SaveLastSelectedItemSetting<T>(T selectedGroup) where T : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase;

		// Token: 0x06000124 RID: 292
		void SaveLastSelectedItemSetting<T>(global::System.Collections.Generic.IEnumerable<T> selectedItems) where T : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase;

		// Token: 0x06000125 RID: 293
		void RegisterMigrationProgressEvent(global::Motorola.CommonCPS.RadioManagement.LocalService.LocalService.DBMigrationEventDelegate method);

		// Token: 0x06000126 RID: 294
		void UnRegisterMigrationProgressEvent(global::Motorola.CommonCPS.RadioManagement.LocalService.LocalService.DBMigrationEventDelegate method);

		// Token: 0x06000127 RID: 295
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MigrationTemplateInfo> ListMigrationTemplateList();

		// Token: 0x06000128 RID: 296
		global::Motorola.CommonCPS.Server.EntityModel.MigrationPBBConfigurationAndWiFi GetMigrationPBBFusionCfgWifi();

		// Token: 0x06000129 RID: 297
		int ScheduleMigrationJob();

		// Token: 0x0600012A RID: 298
		void TurnOffMigration(string rmVersion);

		// Token: 0x0600012B RID: 299
		global::Motorola.CommonCPS.Server.EntityModel.ClearDataProgressReport GetClearDataProgressReport();

		// Token: 0x0600012C RID: 300
		void ClearLegacyData();

		// Token: 0x0600012D RID: 301
		global::Motorola.CommonCPS.Server.EntityModel.MigrationEstimatedData CalculateMigrationTimeAndSize();

		// Token: 0x0600012E RID: 302
		global::Motorola.CommonCPS.Server.CommonDBConstants.MigrationStatus AbortMigration();

		// Token: 0x0600012F RID: 303
		void SwapRadioWorkingCodeplug(string serialNumber);

		// Token: 0x06000130 RID: 304
		global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext GenerateSelectFirmwareContext(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> radios);

		// Token: 0x06000131 RID: 305
		global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext GenerateSelectRecoverFirmwareContext(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> radioList);

		// Token: 0x06000132 RID: 306
		bool CheckFirmwareAfterReadRadio(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext selectFirmwareContext);

		// Token: 0x06000133 RID: 307
		void CheckDatabaseSpaceStatus();
	}
}
