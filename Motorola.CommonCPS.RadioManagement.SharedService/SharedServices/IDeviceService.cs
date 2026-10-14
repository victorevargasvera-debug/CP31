using System;
using System.Collections.Generic;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000025 RID: 37
	public interface IDeviceService : global::Motorola.CommonCPS.RadioManagement.SharedServices.IService
	{
		// Token: 0x060004EB RID: 1259
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary EditRadioFields(global::Motorola.CommonCPS.Server.EntityModel.Radio radioFromServer, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object>> fieldValues);

		// Token: 0x060004EC RID: 1260
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary SubmitTransferRadioIdentity(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Guid, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>> transferRadioIdentityRecords);

		// Token: 0x060004ED RID: 1261
		void ExportCodeplug(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase selectedRadioModel, string fileName, global::Motorola.CommonCPS.Server.EntityModel.Radio radio, string fieldError);

		// Token: 0x060004EE RID: 1262
		void ExportMNISXML(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase selectedRadioModel, string fileName, global::Motorola.CommonCPS.Server.EntityModel.Radio radio, string fieldError);

		// Token: 0x060004EF RID: 1263
		bool DoesDeviceExit(string deviceID, out global::Motorola.CommonCPS.Server.EntityModel.Radio exisingDevice);

		// Token: 0x060004F0 RID: 1264
		void EditCodeplug(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase device, out string error);

		// Token: 0x060004F1 RID: 1265
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary MoveDeviceToGroup(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.RadioManagement.UIModels.Group targetGp);

		// Token: 0x060004F2 RID: 1266
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary UpdateCodeplugPassword(global::Motorola.CommonCPS.Server.EntityModel.PasswordInfo pwdInfo, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet Set);

		// Token: 0x060004F3 RID: 1267
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary MoveDeviceToGroupBatch(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.RadioManagement.UIModels.Group targetGp);

		// Token: 0x060004F4 RID: 1268
		bool DeleteDevice(global::System.Guid batchJobContainerId, global::Motorola.CommonCPS.Server.EntityModel.Radio device);

		// Token: 0x060004F5 RID: 1269
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary DiscardCodeplugChanges(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radio);

		// Token: 0x060004F6 RID: 1270
		void CheckValidityForOverrideExistDevice(global::Motorola.CommonCPS.Server.EntityModel.Radio curDevice, global::Motorola.CommonCPS.Server.EntityModel.Radio newDevice);

		// Token: 0x060004F7 RID: 1271
		global::Motorola.CommonCPS.Server.EntityModel.Radio GetRadioBySerialNumber(string serialNumber, bool isDeep = false);

		// Token: 0x060004F8 RID: 1272
		global::Motorola.CommonCPS.Server.EntityModel.Radio GetRadioByDeviceID(string deviceID, bool isDeep = false);

		// Token: 0x060004F9 RID: 1273
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary AddRadio(global::Motorola.CommonCPS.Server.EntityModel.Radio d);

		// Token: 0x060004FA RID: 1274
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.Radio> GetRadioList(global::System.Collections.Generic.IList<global::System.Guid> rdIDList, bool isDeep = false);

		// Token: 0x060004FB RID: 1275
		global::Motorola.CommonCPS.Server.EntityModel.Radio GetRadio(global::System.Guid radioUuid, bool isDeep = false);

		// Token: 0x060004FC RID: 1276
		global::Motorola.CommonCPS.RadioManagement.SharedServices.OverrideResult ValidateCanImportArchive(global::Motorola.CommonCPS.Server.EntityModel.Radio importingDevice, global::System.Guid? groupUUID, global::Motorola.CommonCPS.Server.CommonDBConstants.OverwriteOption? overwriteOption, global::Motorola.CommonCPS.Server.CommonDBConstants.ImportOption importOption, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet overWriteRadioEntitySet, out global::Motorola.CommonCPS.Server.EntityModel.Radio existingDevice, out string warning);

		// Token: 0x060004FD RID: 1277
		global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet BuildValidateSetForScheduleJob(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.EntityModel.Codeplug currentCodpelug, global::Motorola.CommonCPS.Server.EntityModel.Codeplug workingCodeplug);

		// Token: 0x060004FE RID: 1278
		global::Motorola.CommonCPS.Server.EntityModel.Job ScheduleJob(global::System.Guid batchJobContainerUuid, global::System.Guid? readWriteJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.JobRequest jobRq, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet entitySet);

		// Token: 0x060004FF RID: 1279
		bool ValidatePop25Enabled();

		// Token: 0x06000500 RID: 1280
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary ImportRadioToServer(global::System.Guid batchJobContainerUuid, global::System.Guid? groupUUID, string filePath, global::Motorola.CommonCPS.Server.EntityModel.Radio deviceToImport, global::Motorola.CommonCPS.Server.CommonDBConstants.ImportOption op, bool isOverwirted, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet entitySet, string warningMsg, global::System.Collections.Generic.Dictionary<int, int> optionCount);

		// Token: 0x06000501 RID: 1281
		global::Motorola.CommonCPS.Server.EntityModel.Radio ParseArchive(string filePath, bool IgnorePassword, string password, out global::System.Collections.Generic.Dictionary<int, int> optionCount);

		// Token: 0x06000502 RID: 1282
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary ApplyMVO(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radio, global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.Radio, global::Motorola.CommonCPS.Server.EntityModel.Codeplug> defaultValues);

		// Token: 0x06000503 RID: 1283
		int GetCandidateMVORadioSummaryCount();

		// Token: 0x06000504 RID: 1284
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary> ListMVOCandidateRadioSummary(int startIndex, int length);

		// Token: 0x06000505 RID: 1285
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary ImportRadioFromCSV(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest csvRequest, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet);

		// Token: 0x06000506 RID: 1286
		string AddFileSuffix(string filePath);

		// Token: 0x06000507 RID: 1287
		string GetJobDescriptionForImportRadio(string filePath, string serialNumber);

		// Token: 0x06000508 RID: 1288
		global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest HandleTemplateAndConfigForImportCSV(global::Motorola.CommonCPS.Server.EntityModel.Radio existedRadio, string templateName, string configName, string copiedRadioSN, global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest radioRq, global::Motorola.CommonCPS.RadioManagement.SharedServices.ImportCSVCache cache, ref global::System.Collections.Generic.List<string> warningList);

		// Token: 0x06000509 RID: 1289
		global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest HandleIPProgramSystemForImportCSV(global::Motorola.CommonCPS.Server.EntityModel.Radio existedRadio, string ipProgramSystemName, string copiedRadioSN, global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest radioRq, global::Motorola.CommonCPS.RadioManagement.SharedServices.ImportCSVCache cache, ref global::System.Collections.Generic.List<string> warningList);

		// Token: 0x0600050A RID: 1290
		global::System.Collections.Generic.List<string> GetSupportedCodelugVersion(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily, string maxCodeplugVersionOfRadio);

		// Token: 0x0600050B RID: 1291
		global::System.Collections.Generic.List<string> GetSupportedCodelugVersion_forUpgradeCPVersion(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily, string maxCodeplugVersionOfRadio);

		// Token: 0x0600050C RID: 1292
		string GetFileNameForExportCodeplug(string serialNumber, string templateName, string configName, bool? hasPBA);

		// Token: 0x0600050D RID: 1293
		global::Motorola.CommonCPS.Server.CommonDBConstants.ImportOption GetImportOption(bool isCreateRadio, bool isCreateTemplate, bool isCreateConfig, bool isApply);

		// Token: 0x0600050E RID: 1294
		bool CanImportRadio(bool isCreateRadio, bool isCreateConfig);

		// Token: 0x0600050F RID: 1295
		bool IsInitializeImportRadio(out bool canOverride);

		// Token: 0x06000510 RID: 1296
		bool CanExportCodeplug(global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus radioStatus, bool? hasPBA);

		// Token: 0x06000511 RID: 1297
		global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? GetDefaultRegion();
	}
}
