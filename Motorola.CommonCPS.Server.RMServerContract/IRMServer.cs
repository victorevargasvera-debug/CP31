using System;
using System.Collections.Generic;
using System.ServiceModel;
using EntityModel.GenericModel;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;
using Motorola.CommonCPS.Server.EntityModel.DataTransferObjects;
using Motorola.CommonCPS.Server.EntityModel.GenericModel;
using Motorola.CommonCPS.Server.EntityModel.GenericModel.BatchOperationJobParameter;
using Motorola.CommonCPS.Server.EntityModel.GenericModel.ConfigurationArgs;
using Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels;
using Motorola.CommonCPS.Server.EntityModel.GenericModel.HomeSetArgs;
using Motorola.CommonCPS.Server.EntityModel.GenericModel.ParameterClasses;
using Motorola.CommonCPS.Server.RMServerContract.DataQueryObjects;
using Motorola.CommonCPS.ServerCallbackContract;

namespace Motorola.CommonCPS.Server.RMServerContract
{
	// Token: 0x0200000D RID: 13
	[global::System.ServiceModel.ServiceContract(SessionMode = global::System.ServiceModel.SessionMode.Required, CallbackContract = typeof(global::Motorola.CommonCPS.ServerCallbackContract.IServerCallback))]
	public interface IRMServer
	{
		// Token: 0x0600017C RID: 380
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		string Ping();

		// Token: 0x0600017D RID: 381
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		string PingViaJobServer();

		// Token: 0x0600017E RID: 382
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.Obsolete]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		void SetRegionName(int regionName);

		// Token: 0x0600017F RID: 383
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.ServerInfo OpenSession(string clientGuid, global::Motorola.CommonCPS.Server.EntityModel.ClientInfo clientInfo, bool needCallback);

		// Token: 0x06000180 RID: 384
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		void CloseSession();

		// Token: 0x06000181 RID: 385
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DatabaseSizeSummary GetDatabaseSizeSummary();

		// Token: 0x06000182 RID: 386
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Group> ListGroups();

		// Token: 0x06000183 RID: 387
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.Server.EntityModel.Group AddGroup(global::System.Guid? parentGroupUuid = null);

		// Token: 0x06000184 RID: 388
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		byte[] UpdateGroup(global::Motorola.CommonCPS.Server.EntityModel.Group group);

		// Token: 0x06000185 RID: 389
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		void DeleteGroup(global::System.Guid groupUuid);

		// Token: 0x06000186 RID: 390
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary MoveDevice(global::System.Guid? groupUuidTo, global::System.Guid radioUuid, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet entitySet);

		// Token: 0x06000187 RID: 391
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary MoveDevicesBatchOp(global::System.Guid batchJobContainerUuid, global::System.Guid? groupUuidTo, global::System.Guid radioUuid, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet entitySet);

		// Token: 0x06000188 RID: 392
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.Radio> GetRadioList(global::System.Collections.Generic.IList<global::System.Guid> radioUuidList, bool isDeep = false);

		// Token: 0x06000189 RID: 393
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.Radio> GetRadiosForOtarProfileValidation(global::System.Collections.Generic.IList<global::System.Guid> radioUuidList);

		// Token: 0x0600018A RID: 394
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary> GetRadioListUsingConfigByWrkCp(global::System.Guid configUuid, int startIndex, int count);

		// Token: 0x0600018B RID: 395
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary> GetRadioListUsingConfig(global::System.Guid configUuid, int startIndex, int count);

		// Token: 0x0600018C RID: 396
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		int GetRadiosCountUsingConfigByWrkCp(global::System.Guid configUuid);

		// Token: 0x0600018D RID: 397
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		int GetRadiosCountUsingConfig(global::System.Guid configUuid);

		// Token: 0x0600018E RID: 398
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		bool DeleteRadio(global::Motorola.CommonCPS.Server.EntityModel.DeleteRadioBatchJobParameter parameter);

		// Token: 0x0600018F RID: 399
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary ImportBatchRadio(global::Motorola.CommonCPS.Server.EntityModel.ImportRadioBatchJobParameter parameter);

		// Token: 0x06000190 RID: 400
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary ImportRadioFromCSV(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest csvRequest, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet);

		// Token: 0x06000191 RID: 401
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary AddRadio(global::Motorola.CommonCPS.Server.EntityModel.Radio radio);

		// Token: 0x06000192 RID: 402
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary UpdateCodeplugPassword(global::Motorola.CommonCPS.Server.EntityModel.PasswordInfo pwdInfo, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet Set);

		// Token: 0x06000193 RID: 403
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary, global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary> ApplyTemplateToRadio(global::Motorola.CommonCPS.Server.EntityModel.ApplyTemplateBatchJobParameter parameter);

		// Token: 0x06000194 RID: 404
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary ApplyGeneralPackagesToRadio(global::System.Guid batchJobContainerUuid, global::System.Guid radioUuid, global::System.Collections.Generic.List<global::System.Guid> packageUuids, global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType type, string packageVersion, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySets);

		// Token: 0x06000195 RID: 405
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary ApplyPBBPackagesToRadio(global::System.Guid batchJobContainerUuid, global::System.Guid radioUuid, global::System.Collections.Generic.List<global::System.Guid> packageUuids, global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType type, string packageVersion, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySets);

		// Token: 0x06000196 RID: 406
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary UpdatePBBPackagesToRadio(global::System.Guid batchJobContainerUuid, global::System.Guid radioUuid, global::System.Collections.Generic.List<global::System.Guid> packageUuids, global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType type, string packageVersion, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySets);

		// Token: 0x06000197 RID: 407
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary, global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary> ApplyConfigurationToRadio(global::System.Guid batchJobContainerUuid, global::System.Guid configurationUuid, global::Motorola.CommonCPS.Server.EntityModel.RadioInfoForApplyConfiguration radioInfo, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySets);

		// Token: 0x06000198 RID: 408
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		void AddandApplyCompareConfigurationToRadio(global::System.Guid radioUuid, global::Motorola.CommonCPS.Server.EntityModel.Configuration configuration, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateSet);

		// Token: 0x06000199 RID: 409
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		global::System.Collections.Generic.List<bool> DoesDevicesAlreadyExist(global::System.Collections.Generic.List<string> deviceIDs);

		// Token: 0x0600019A RID: 410
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		byte[] ListRadioSummary(int startIndex, int length, global::System.Guid? groupUuid, global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode workMode, bool includeSubGroups = false);

		// Token: 0x0600019B RID: 411
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary GetRadioSumary(global::System.Guid summaryUuid);

		// Token: 0x0600019C RID: 412
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		byte[] ListRadioSummaryByIds(global::System.Collections.Generic.List<global::System.Guid> radioIds);

		// Token: 0x0600019D RID: 413
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		int GetRadioSystemSummariesCount(global::System.Guid? groupUuid, bool includeSubGroups = false, global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily = global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any);

		// Token: 0x0600019E RID: 414
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystemSummary> ListRadioSystemSummaries(global::System.Guid? groupUuid, int startIndex, int count, bool includeSubGroups = false, global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily = global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any);

		// Token: 0x0600019F RID: 415
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		int GetAPXRadioSystemsCount(global::System.Guid? groupUuid);

		// Token: 0x060001A0 RID: 416
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXSystemInfoSummary> ListAPXRadioSystems(global::System.Guid? groupUuid, int startIndex, int count);

		// Token: 0x060001A1 RID: 417
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		int GetRadioCountBySystem(global::System.Guid? groupUuid, global::Motorola.CommonCPS.Server.EntityModel.APXSystemInfoSummary apxRadioSystem, bool includeSubGroups = false);

		// Token: 0x060001A2 RID: 418
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystemSummary> ListRadiosByRadioSystem(global::System.Guid? groupUuid, global::Motorola.CommonCPS.Server.EntityModel.APXSystemInfoSummary apxRadioSystem, int startIndex, int count, bool includeSubGroups = false, global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily = global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any);

		// Token: 0x060001A3 RID: 419
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		int GetSystemRadioInfosCount(global::System.Guid? groupUuid);

		// Token: 0x060001A4 RID: 420
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXSystemRadioInfoSummary> ListSystemRadioInfos(global::System.Guid? groupUuid, int startIndex, int count);

		// Token: 0x060001A5 RID: 421
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		int GetSystemCountByRadio(global::System.Guid radioUuid);

		// Token: 0x060001A6 RID: 422
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystemSummary> ListSystemsByRadio(global::System.Guid radioUuid);

		// Token: 0x060001A7 RID: 423
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		int GetAPXDataProfilesCount(global::System.Guid? groupUuid, bool includeSubGroups = false);

		// Token: 0x060001A8 RID: 424
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary> ListAPXDataProfiles(global::System.Guid? groupUuid, int startIndex, int count, bool includeSubGroups = false);

		// Token: 0x060001A9 RID: 425
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO EditAPXOtarProfiles(global::System.Guid radioUuid, global::System.Guid otarUuid, global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.CommonDBConstants.OtarFieldType, object> fieldValues, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet set);

		// Token: 0x060001AA RID: 426
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO> GetAPXOtarProfiles(global::System.Guid? groupUuid, int startIndex, int count, bool includeSubGroups = false);

		// Token: 0x060001AB RID: 427
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		int GetAPXOtarProfilesCount(global::System.Guid? groupUuid, bool includeSubGroups = false);

		// Token: 0x060001AC RID: 428
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		int GetAPXOtarProfilesInfoCount(global::System.Guid? groupUuid);

		// Token: 0x060001AD RID: 429
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileInfoDTO> GetAPXOtarProfilesInfo(global::System.Guid? groupUUID, int startIndex, int count);

		// Token: 0x060001AE RID: 430
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		int GetRadiosByAPXOtarProfileCount(global::System.Guid? groupUuid, global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileInfoDTO otarProfile);

		// Token: 0x060001AF RID: 431
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		int GetAPXOtarProfileRadioInfoCount(global::System.Guid? groupUuid);

		// Token: 0x060001B0 RID: 432
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileRadioInfoDTO> GetAPXOtarProfileRadiosInfo(global::System.Guid? groupUUID, int startIndex, int count);

		// Token: 0x060001B1 RID: 433
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		int GetAPXOtarProfilesByRadioCount(global::System.Guid radioId);

		// Token: 0x060001B2 RID: 434
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO> GetAPXOtarProfilesByRadio(global::System.Guid radioId);

		// Token: 0x060001B3 RID: 435
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO> GetRadiosByAPXOtarProfile(global::System.Guid? groupUUID, global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileInfoDTO otarProfile, int startIndex, int count);

		// Token: 0x060001B4 RID: 436
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		int GetDataProfileInfoCount(global::System.Guid? groupId);

		// Token: 0x060001B5 RID: 437
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.DataProfileInfo> ListDataProfileInfo(global::System.Guid? groupId, int startIndex, int count);

		// Token: 0x060001B6 RID: 438
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		long GetAPXRadioSystemCount(global::System.Guid? groupUuid, string searchString);

		// Token: 0x060001B7 RID: 439
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		long GetAPXDataProfileCount(global::System.Guid? groupUuid, string searchString);

		// Token: 0x060001B8 RID: 440
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		int GetRadioCountByProfile(global::System.Guid? groupId, string profileName, int systemType);

		// Token: 0x060001B9 RID: 441
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary> ListRadiosByProfile(global::System.Guid? groupId, string profileName, int systemType, int startIndex, int count);

		// Token: 0x060001BA RID: 442
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		int GetProfileRadioInfoCount(global::System.Guid? groupId);

		// Token: 0x060001BB RID: 443
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.ProfileRadioInfoSummary> ListProfileRadioInfo(global::System.Guid? groupId, int startIndex, int count);

		// Token: 0x060001BC RID: 444
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		int GetProfileCountByRadio(global::System.Guid radioUuid);

		// Token: 0x060001BD RID: 445
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary> ListProfilesByRadio(global::System.Guid radioUuid);

		// Token: 0x060001BE RID: 446
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary DiscardCodeplugChanges(global::Motorola.CommonCPS.Server.EntityModel.DiscardCPChangesBatchJobParameter parameter);

		// Token: 0x060001BF RID: 447
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary DiscardCodeplugAndRadioFeatureChanges(global::Motorola.CommonCPS.Server.EntityModel.DiscardCPRFChangesBatchJobParameter parameter);

		// Token: 0x060001C0 RID: 448
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.Radio GetRadio(global::System.Guid radioUuid, bool isDeep = false);

		// Token: 0x060001C1 RID: 449
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.Radio GetRadioByDeviceId(string deviceID, bool isDeep = false);

		// Token: 0x060001C2 RID: 450
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.Radio CreateTempRadioForCompare(global::Motorola.CommonCPS.Server.EntityModel.Radio radio);

		// Token: 0x060001C3 RID: 451
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary Reset(global::System.Guid radioID, int? RadioID, int? CAI, string password, global::Motorola.CommonCPS.Server.EntityModel.LinkType? linkType, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet);

		// Token: 0x060001C4 RID: 452
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary EditRadio(global::System.Guid radioUuid, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object>> changedFieldValePair, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet);

		// Token: 0x060001C5 RID: 453
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary RadioIdentityTransfer(global::System.Guid radioUuid, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Guid, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>> changedFieldValePairForRadio, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet);

		// Token: 0x060001C6 RID: 454
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystemSummary EditAPXRadioSystem(global::System.Guid radioUuid, global::System.Guid systemUuid, global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.CommonDBConstants.RadioSystemFieldType, object> fieldValues, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet set);

		// Token: 0x060001C7 RID: 455
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary EditAPXRadioProfile(global::System.Guid radioUuid, global::System.Guid profileUuid, global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.CommonDBConstants.ProfileFieldType, object> fieldValues, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet set);

		// Token: 0x060001C8 RID: 456
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary, global::Motorola.Common.CustomException.CommonErrorCode> UpdateLanguagePackOnRadios(global::System.Collections.Generic.List<global::System.Guid> radioUuids);

		// Token: 0x060001C9 RID: 457
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		int GetRadioCount(global::System.Guid? groupUuid, global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode workMode, bool includeSubGroups = false);

		// Token: 0x060001CA RID: 458
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.Codeplug GetCodeplug(global::System.Guid codeplugUuid);

		// Token: 0x060001CB RID: 459
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary SelectLanguagePacksForPCR(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.EntitySummary templateInfo, global::System.Collections.Generic.List<global::System.Guid> LPList, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.EntitySummary> entitySummaryList, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet> validateSetList);

		// Token: 0x060001CC RID: 460
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary UpgradeAPXTemplateLanguagePack(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.EntitySummary templateInfo, global::System.Guid LPGuid, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.EntitySummary> entitySummaryList, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet> validateSetList);

		// Token: 0x060001CD RID: 461
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Template> ListTemplateByName(global::System.Collections.Generic.List<string> templateNameList, bool fullLoad);

		// Token: 0x060001CE RID: 462
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::System.Collections.Generic.KeyValuePair<global::System.Collections.Generic.List<global::System.Guid>, global::Motorola.CommonCPS.Server.EntityModel.Template> AddUpgradedTemplate(global::Motorola.CommonCPS.Server.EntityModel.Template template, global::System.Guid oldTemplateUuid, global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareCodeplugPairGroup FWCPGroup, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateSet);

		// Token: 0x060001CF RID: 463
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary EditTemplateFields(global::System.Guid templateUuid, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.TemplateFieldType, object>> fieldValues, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet entitySet);

		// Token: 0x060001D0 RID: 464
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary SaveTemplate(global::Motorola.CommonCPS.Server.EntityModel.Template template, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateSet);

		// Token: 0x060001D1 RID: 465
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Guid SaveNewTemplateForUpgrade(global::Motorola.CommonCPS.Server.EntityModel.Template template);

		// Token: 0x060001D2 RID: 466
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::Motorola.CommonCPS.Server.EntityModel.Template TemplateExist(string name);

		// Token: 0x060001D3 RID: 467
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		long GetTemplateSummaryRowIndex(global::System.Guid templateUuid, string searchString, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.OrderByOption> orderByOptions, global::Motorola.CommonCPS.Server.CommonDBConstants.TemplateFiterFlag filterFlag);

		// Token: 0x060001D4 RID: 468
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary> ListMatchedTemplate(global::System.Collections.Generic.List<global::System.Guid> radioUUIDList, int startIndex, int count);

		// Token: 0x060001D5 RID: 469
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Radio> GetReferencedRadios(global::System.Guid templateUuid, int startIndex, int count, bool returnWorkingRadiosOnly = false);

		// Token: 0x060001D6 RID: 470
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.EntityModel.EntitySummary, global::Motorola.CommonCPS.Server.EntityModel.RadioSummary> GetReferencedRadiosbyWorkingTemplateList(global::System.Collections.Generic.List<global::System.Guid> templateUuidList, int startIndex, int count);

		// Token: 0x060001D7 RID: 471
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		int GetReferencedRadiosCount(global::System.Collections.Generic.List<global::System.Guid> templateUuidList, bool isWorkingOnly = false, bool isFilterJob = true);

		// Token: 0x060001D8 RID: 472
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		long GetMatchedTemplateCount(global::System.Collections.Generic.List<global::System.Guid> radioUuids);

		// Token: 0x060001D9 RID: 473
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		long GetMatchedTemplateIndex(global::System.Collections.Generic.List<global::System.Guid> radioUuids, global::System.Guid templateUUID, string searchString, global::Motorola.CommonCPS.Server.EntityModel.OrderByOption[] orderByOptions);

		// Token: 0x060001DA RID: 474
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.Server.EntityModel.MatrixKey GetMatrixKey(global::System.Guid matrixKeyId);

		// Token: 0x060001DB RID: 475
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary> ListTemplateSummaries(int startIndex, int pageSize);

		// Token: 0x060001DC RID: 476
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary> ListTemplateSummariesByQueryCondition(global::System.Collections.Generic.Dictionary<string, global::System.Guid> queriesConditions);

		// Token: 0x060001DD RID: 477
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		bool DeleteTemplate(global::System.Guid? batchJobContainerUuid, global::System.Guid templateUuid, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet set, string templateName = null);

		// Token: 0x060001DE RID: 478
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary ImportTemplate(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.Template temp);

		// Token: 0x060001DF RID: 479
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.Template GetTemplate(global::System.Guid templateUuid, bool isDeep = false);

		// Token: 0x060001E0 RID: 480
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary GetTemplateSummary(global::System.Guid templateUuid);

		// Token: 0x060001E1 RID: 481
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		int GetTemplateCount();

		// Token: 0x060001E2 RID: 482
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		bool CheckTemplateNameDuplicate(string templateName);

		// Token: 0x060001E3 RID: 483
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.Package GetPackage(global::System.Guid packageUuid);

		// Token: 0x060001E4 RID: 484
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.Package ImportPackage(global::Motorola.CommonCPS.Server.EntityModel.Package package);

		// Token: 0x060001E5 RID: 485
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::Motorola.CommonCPS.Server.EntityModel.PackageSummary ImportBatchPackage(global::Motorola.CommonCPS.Server.EntityModel.ImportPackageBatchJobParameter parameter);

		// Token: 0x060001E6 RID: 486
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::Motorola.CommonCPS.Server.EntityModel.PackageSummary ImportBatchAstroFirmware(global::Motorola.CommonCPS.Server.EntityModel.ImportPackageBatchJobParameter parameter);

		// Token: 0x060001E7 RID: 487
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		bool DeleteBatchPackage(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.EntitySummary packageUuid, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateSet);

		// Token: 0x060001E8 RID: 488
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::Motorola.CommonCPS.Server.EntityModel.PackageSummary UpdatePackage(global::Motorola.CommonCPS.Server.EntityModel.PackageSummary summary, global::Motorola.CommonCPS.Server.CommonDBConstants.PackageColumns column);

		// Token: 0x060001E9 RID: 489
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.Server.EntityModel.PackageSummary UpdatePBBPackage(global::Motorola.CommonCPS.Server.EntityModel.PackageSummary summary, global::Motorola.CommonCPS.Server.CommonDBConstants.PackageColumns column);

		// Token: 0x060001EA RID: 490
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROPackageSummary> ListASTROPackageSummaries(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType packageType);

		// Token: 0x060001EB RID: 491
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRPackageSummary> ListPCRPackageSummaries(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType packageType, int? PairGroupRegion = null);

		// Token: 0x060001EC RID: 492
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PackageSummary> ListPackageSummary(int startIndex, int length, global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType packageType, int? pairGroupRegion = null, string modelFilter = null);

		// Token: 0x060001ED RID: 493
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		int GetPackagesCount(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType packageType, int? pairGroupRegion);

		// Token: 0x060001EE RID: 494
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.List<string> ListLanguagePackNames(global::Motorola.CommonCPS.Server.CommonDBConstants.LanguagePackFamily? languagePackFamily);

		// Token: 0x060001EF RID: 495
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareCodeplugPair> FindPCRUpgradePackagesForVersion(string codeplugVersion, string firmwareVersion, string modelNumber, string tanapaNo, int region);

		// Token: 0x060001F0 RID: 496
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePackSummary> ListPCRLanguagePackLatestByFamily(global::Motorola.CommonCPS.Server.CommonDBConstants.LanguagePackFamily lFamily);

		// Token: 0x060001F1 RID: 497
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRPackageSummary> ListPCRUpgradeFirmwarePackages(global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ListPCRUpgradePackageFilter> filters);

		// Token: 0x060001F2 RID: 498
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROPackage> ListASTROPackagesByTargetModelVersion(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType packageType, string targetModel, string packageVersion, bool isFreon, bool isEqual = true);

		// Token: 0x060001F3 RID: 499
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware> GetAstroAmpFirmwares(global::Motorola.CommonCPS.Server.RMServerContract.DataQueryObjects.AstroAmpFirmwareQuery query);

		// Token: 0x060001F4 RID: 500
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::Motorola.CommonCPS.Server.EntityModel.PCRPackage GetPCRPackageByNameVersion(global::Motorola.CommonCPS.Server.EntityModel.PCRPackageRequest packageReq);

		// Token: 0x060001F5 RID: 501
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROPackage> ListASTROPackages(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType packageType);

		// Token: 0x060001F6 RID: 502
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PBBPackage> ListPBBPackages(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType packageType);

		// Token: 0x060001F7 RID: 503
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRPackage> ListPCRPackages(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType packageType, int? PairGroupRegion = null);

		// Token: 0x060001F8 RID: 504
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.Server.EntityModel.Package PackageExist(global::Motorola.CommonCPS.Server.EntityModel.Package software);

		// Token: 0x060001F9 RID: 505
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROPackage> ListASTROPackagesByCompatibleVersion(string compatibleVersion);

		// Token: 0x060001FA RID: 506
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack GetLatestASTROLPPackagesByFirmwareVersion(string firmwareVersion, string LPID);

		// Token: 0x060001FB RID: 507
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.ReadWriteJob AddReadWriteJob(global::System.Guid batchJobContainerUuid, global::System.Guid? rwJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.JobRequest jobRequest, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateSet);

		// Token: 0x060001FC RID: 508
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary CancelJob(global::Motorola.CommonCPS.Server.EntityModel.CancelJobBatchJobParameter parameter);

		// Token: 0x060001FD RID: 509
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		void DeleteJobContainer(global::Motorola.CommonCPS.Server.EntityModel.DeleteJobContainerBatchJobParameter parameter);

		// Token: 0x060001FE RID: 510
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		int GetDeviceRWJobsCount(global::System.Guid deviceUuid);

		// Token: 0x060001FF RID: 511
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ReadWriteJob> ListJobsByDeviceUuid(global::System.Guid deviceUuid, int startIndex, int count);

		// Token: 0x06000200 RID: 512
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.JobContainerSummary> ListJbcSummarys(bool? isRwJob, int startIndex, int count);

		// Token: 0x06000201 RID: 513
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.JobContainerSummary GetLastJbcSummary(bool? isRwJob);

		// Token: 0x06000202 RID: 514
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.JobContainerSummary GetJbcSummary(global::System.Guid guid);

		// Token: 0x06000203 RID: 515
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		int GetJbcCount(bool? isRwJob);

		// Token: 0x06000204 RID: 516
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		int GetJobCount(global::System.Guid jbcUuid);

		// Token: 0x06000205 RID: 517
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.JobSummaryViewEntity> ListJobSummarys(global::System.Guid jbcUuid, int startIndex, int count);

		// Token: 0x06000206 RID: 518
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.JobSummaryViewEntity GetJobSummary(global::System.Guid jobUuid);

		// Token: 0x06000207 RID: 519
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.Server.EntityModel.JobSummaryViewEntity GetLastJobSummaryInJbc(global::System.Guid jbcUuid);

		// Token: 0x06000208 RID: 520
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.JobSummaryViewEntity GetLastJobSummary(bool? isRwJob);

		// Token: 0x06000209 RID: 521
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.Job GetJob(global::System.Guid jobUuid);

		// Token: 0x0600020A RID: 522
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		bool CheckReadJobPerformed(global::System.Collections.Generic.List<global::System.Guid> radioUuids);

		// Token: 0x0600020B RID: 523
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		bool HasJobFailed(global::System.Guid jobContainerUuid);

		// Token: 0x0600020C RID: 524
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary CompleteJob(global::Motorola.CommonCPS.Server.EntityModel.CompleteJobBatchJobParameter parameter);

		// Token: 0x0600020D RID: 525
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		int GetAvailableRadioForPurchaseCount(global::System.Guid? groupUuid, global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureFilter filter, global::System.Collections.Generic.List<string> selectedSerialNumbers, int featureType = 0);

		// Token: 0x0600020E RID: 526
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		int GetRadioFeatureCount(global::System.Guid? groupUuid, int featureType = 0);

		// Token: 0x0600020F RID: 527
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary> ListAvailableRadioForPurchase(global::System.Guid? groupUuid, global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureFilter filter, int startIndex, int count, global::System.Collections.Generic.List<string> selectedSerialNumbers, int featureType = 0);

		// Token: 0x06000210 RID: 528
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		long GetAvailableRadioForPurchaseIndex(global::System.Guid? groupUuid, global::System.Guid radioUuid, global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureFilter filter, string searchString, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.OrderByOption> orderByOptions, global::System.Collections.Generic.List<string> selectedSerialNumbers);

		// Token: 0x06000211 RID: 529
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary> ListRadioFeatureSummary(global::System.Guid? groupUuid, int startIndex, int count, int featureType = 0);

		// Token: 0x06000212 RID: 530
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		long GetRadioFeatureSummaryRowIndex(global::System.Guid? groupUuid, global::System.Guid radioLicenseUuid, string searchString, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.OrderByOption> orderByOptions);

		// Token: 0x06000213 RID: 531
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		void SubmitFeatureAssignment(global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SubmitLicenseRequest> requests, global::Motorola.CommonCPS.Server.CommonDBConstants.LicenseFrom licenseFrom);

		// Token: 0x06000214 RID: 532
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.ServiceKnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware))]
		[global::System.ServiceModel.ServiceKnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PCRFirmware))]
		global::EntityModel.GenericModel.CFSUpdateResult ApplyUpdatedTemplateToRadio(global::System.Guid radioUuid, global::System.Guid templateGuid, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature> featureList, byte[] response, global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet entitySet, global::System.Collections.Generic.Dictionary<string, object> syncDataToCP = null);

		// Token: 0x06000215 RID: 533
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		global::EntityModel.GenericModel.CFSUpdateResult RegisterLicenseToRadio(global::System.Guid radioUuid, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature> featureList, bool isSubmit, byte[] response, global::System.Guid batchJobContainerUuid);

		// Token: 0x06000216 RID: 534
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::EntityModel.GenericModel.CFSUpdateResult CfsUpgradeRadio(global::Motorola.CommonCPS.Server.EntityModel.CfsUpgradeRadioBatchJobParameter cfsUpgradeRadioBatchJobParameter);

		// Token: 0x06000217 RID: 535
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.Obsolete]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		int QueryFeatureCount(string productID);

		// Token: 0x06000218 RID: 536
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RadioManagementLicenseInfo> GetRadioManagementFeaure();

		// Token: 0x06000219 RID: 537
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		string GenerateHostID();

		// Token: 0x0600021A RID: 538
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		byte[] GetLicense();

		// Token: 0x0600021B RID: 539
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.SendDeviceRequest CreateRecoverRequest_CLL(string hostID);

		// Token: 0x0600021C RID: 540
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		void EnableFeature_CLL(global::Motorola.CommonCPS.Server.EntityModel.FeatureResponseObject referenceReq, string hostID, byte[] capabilityResponse);

		// Token: 0x0600021D RID: 541
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.Server.EntityModel.SendDeviceRequest CreateActivationRequest_CLL(string computerName, string AID, int count);

		// Token: 0x0600021E RID: 542
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::Motorola.CommonCPS.Server.EntityModel.SendDeviceRequest CreateRadioActivationRequest_CLL(string hostID, string computerName, string AID, int count);

		// Token: 0x0600021F RID: 543
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.Server.EntityModel.FeatureResponseObject SendRequestToServer_CLL(global::Motorola.CommonCPS.Server.EntityModel.SendDeviceRequest deviceRequest);

		// Token: 0x06000220 RID: 544
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ApplicationFeatureSummary> ListApplicationFeatureSummaries();

		// Token: 0x06000221 RID: 545
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::Motorola.CommonCPS.Server.EntityModel.ApplicationFeatureSummary UpdateApplicationFeatureComments(string featureName, string comments, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet set);

		// Token: 0x06000222 RID: 546
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::Motorola.CommonCPS.Server.EntityModel.RMFile AddFileEnhancement(global::Motorola.CommonCPS.Server.CommonDBConstants.FileType fileType, global::System.Guid fileUuid, long offset, byte[] data, int dataLen, long fileLen, string sha256Hash);

		// Token: 0x06000223 RID: 547
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::Motorola.CommonCPS.Server.EntityModel.RMFile GetFile(global::System.Guid fileUuid);

		// Token: 0x06000224 RID: 548
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		byte[] GetFileContentEnhancement(global::Motorola.CommonCPS.Server.EntityModel.RMFile file, long offset, int bufferLen);

		// Token: 0x06000225 RID: 549
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		void DeleteFile(global::System.Guid fileUuid);

		// Token: 0x06000226 RID: 550
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::Motorola.CommonCPS.Server.EntityModel.MatrixKey AddMatrixKey(global::Motorola.CommonCPS.Server.EntityModel.MatrixKey matrixKey);

		// Token: 0x06000227 RID: 551
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		bool DeleteMatrixKey(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.MatrixKey key);

		// Token: 0x06000228 RID: 552
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::Motorola.CommonCPS.Server.EntityModel.MatrixKey EditKey(global::System.Guid keyUuid, global::Motorola.CommonCPS.Server.CommonDBConstants.MatrixKeyType keyType, object changedField, global::Motorola.CommonCPS.Server.CommonDBConstants.KeyFieldType fieldType, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet set);

		// Token: 0x06000229 RID: 553
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixKey> ListMatrixKeys(global::Motorola.CommonCPS.Server.CommonDBConstants.MatrixKeyType keyType, int startIndex, int count);

		// Token: 0x0600022A RID: 554
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		int GetMatrixKeysCount(global::Motorola.CommonCPS.Server.CommonDBConstants.MatrixKeyType keyType);

		// Token: 0x0600022B RID: 555
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.MatrixKey GetMatrixKeyByIdentifier(string identifier, global::Motorola.CommonCPS.Server.CommonDBConstants.MatrixKeyType keyType);

		// Token: 0x0600022C RID: 556
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.Server.EntityModel.MatrixKey> GetMatrixKeysByIdentifiers(global::System.Collections.Generic.List<string> identifiers, global::Motorola.CommonCPS.Server.CommonDBConstants.MatrixKeyType keyType);

		// Token: 0x0600022D RID: 557
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::Motorola.CommonCPS.Server.EntityModel.PCRKeyData FillPcrKeyData(global::Motorola.CommonCPS.Server.EntityModel.PCRKeyData keyDataOnlyHasKeyId);

		// Token: 0x0600022E RID: 558
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.PCRKeyData GetPCRKeyIDsByConfigurationId(global::System.Guid configurationUuid);

		// Token: 0x0600022F RID: 559
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::Motorola.CommonCPS.Server.EntityModel.PBBPassword AddPBBPassword(global::Motorola.CommonCPS.Server.EntityModel.PBBPassword password);

		// Token: 0x06000230 RID: 560
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PBBPassword> ListPBBPasswords();

		// Token: 0x06000231 RID: 561
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.Server.EntityModel.PBBPassword GetPBBPassword(global::System.Guid passwordUuid);

		// Token: 0x06000232 RID: 562
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::Motorola.CommonCPS.Server.EntityModel.PBBApplicationShortcut GetPBBAppShortcutByPackageNameClassName(global::Motorola.CommonCPS.Server.EntityModel.PackageRequest packageReq);

		// Token: 0x06000233 RID: 563
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.Server.EntityModel.PBBPassword GetPBBPasswordById(string id);

		// Token: 0x06000234 RID: 564
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		void UpdatePBBPassword(global::Motorola.CommonCPS.Server.EntityModel.PBBPassword password);

		// Token: 0x06000235 RID: 565
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		bool DeletePBBPassword(global::Motorola.CommonCPS.Server.EntityModel.DeletePBBPasswordBatchJobParameter parameter);

		// Token: 0x06000236 RID: 566
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		void EnableFeature(global::Motorola.CommonCPS.Server.EntityModel.FeatureRequestObject referenceReq, byte[] capabilityResponse);

		// Token: 0x06000237 RID: 567
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.FeatureRequestObject GenerateFeatureRequest(string AID, int count);

		// Token: 0x06000238 RID: 568
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		void CancelFeatureRequest(global::Motorola.CommonCPS.Server.EntityModel.FeatureRequestObject referenceRequest);

		// Token: 0x06000239 RID: 569
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.Server.EntityModel.FeatureRequestObject GenerateRecoverRequest();

		// Token: 0x0600023A RID: 570
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		void UpdateRadioFeatureComments(global::System.Guid radioFeatureUuid, string comments);

		// Token: 0x0600023B RID: 571
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		string GetAppLicenseComments();

		// Token: 0x0600023C RID: 572
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		void UpdateAppLicenseComments(string comments);

		// Token: 0x0600023D RID: 573
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		int GetRadioFeatureSummaryByRadioCount(global::System.Guid? groupUuid, int featureType = 0);

		// Token: 0x0600023E RID: 574
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary> ListRadioFeatureSummaryByRadio(global::System.Guid? groupUuid, int startIndex, int count, int featureType = 0);

		// Token: 0x0600023F RID: 575
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		int GetRadioFeatureSummaryByFeatureCount(global::System.Guid? groupUuid, int featureType = 0);

		// Token: 0x06000240 RID: 576
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary> ListRadioFeatureSummaryByFeature(global::System.Guid? groupUuid, int startIndex, int count, int featureType = 0);

		// Token: 0x06000241 RID: 577
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary> GetRadioFeatureDetailsByRadio(global::System.Guid radioUuid, int featureType = 0);

		// Token: 0x06000242 RID: 578
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		int GetRadioFeatureDetailsByFeatureCount(global::System.Guid? groupUuid, int featureName, int featureType = 0);

		// Token: 0x06000243 RID: 579
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary> GetRadioFeatureDetailsByFeature(global::System.Guid? groupUuid, int startIndex, int count, int featureName, int featureType = 0);

		// Token: 0x06000244 RID: 580
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::EntityModel.GenericModel.CFSUpdateResult RecoverRadioFeatures(global::System.Guid radioId, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> features, byte[] targetFlashCode, byte[] capacityResponse);

		// Token: 0x06000245 RID: 581
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		void RestoreRadioFeatures(global::System.Guid radioId, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> features);

		// Token: 0x06000246 RID: 582
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		int GetRadioFeatureSummaryByCMSCCount(global::System.Guid? groupUuid, int featureType = 0);

		// Token: 0x06000247 RID: 583
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary> ListRadioFeatureSummaryByCMSC(global::System.Guid? groupUuid, int startIndex, int count, int featureType = 0);

		// Token: 0x06000248 RID: 584
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		int GetRadioFeatureSummaryByCMSCFeatureCount(global::System.Guid? groupUuid, int featureType = 0);

		// Token: 0x06000249 RID: 585
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary> ListRadioFeatureSummaryByCMSCFeature(global::System.Guid? groupUuid, int startIndex, int count, int featureType = 0);

		// Token: 0x0600024A RID: 586
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::EntityModel.GenericModel.CFSUpdateResult RegisterLicenseToCMSC(global::System.Guid radioUuid, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature> featureList, bool isSubmit, byte[] response, global::System.Guid batchJobContainerUuid);

		// Token: 0x0600024B RID: 587
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		global::EntityModel.GenericModel.CFSUpdateResult RestoreLicenseToCMSC(global::System.Guid radioUuid, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature> featureList, bool isSubmit, byte[] response, global::System.Guid batchJobContainerUuid);

		// Token: 0x0600024C RID: 588
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary> ListCMSCRadioFeatureSummary(global::System.Guid? groupUuid, int startIndex, int count, int featureType = 0);

		// Token: 0x0600024D RID: 589
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		int GetCMSCRadioFeatureCount(global::System.Guid? groupUuid, int featureType = 0);

		// Token: 0x0600024E RID: 590
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		int GetAvailableCMSCForPurchaseCount(global::System.Guid? groupUuid, global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureFilter filter, global::System.Collections.Generic.List<string> selectedSerialNumbers, int featureType = 0);

		// Token: 0x0600024F RID: 591
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary> ListAvailableCMSCForPurchase(global::System.Guid? groupUuid, global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureFilter filter, int startIndex, int count, global::System.Collections.Generic.List<string> selectedSerialNumbers, int featureType = 0);

		// Token: 0x06000250 RID: 592
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::EntityModel.GenericModel.CFSUpdateResult RecoverCMSCFeatures(global::System.Guid radioId, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> features, string hostID, byte[] targetFlashCode, byte[] capacityResponse);

		// Token: 0x06000251 RID: 593
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJobContainer AddBatchJobContainer(global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJobContainer batchJobContainer);

		// Token: 0x06000252 RID: 594
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob AddBatchJob(global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob job);

		// Token: 0x06000253 RID: 595
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::System.Collections.Generic.List<string> ListFeatureMatchedRadios(global::System.Guid? groupUuid, global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureFilter filter, string searchString, global::System.Collections.Generic.List<string> selectedSerialNumbers);

		// Token: 0x06000254 RID: 596
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary QueryAndUpdateRadio(global::System.Guid batchJobContainerUuid, global::System.Guid radioUuid, int? ownerAdvKeyType, int? homeSystemId, bool? writeProtected, bool? AskRequired, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet);

		// Token: 0x06000255 RID: 597
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		bool DeleteConfiguation(global::Motorola.CommonCPS.Server.EntityModel.DeleteConfigurationBatchJobParameter JobParameter);

		// Token: 0x06000256 RID: 598
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		bool DeleteConfiguationInJob(global::Motorola.CommonCPS.Server.EntityModel.DeleteConfigurationBatchJobParameter JobParameter);

		// Token: 0x06000257 RID: 599
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		bool DeleteDBRecord(global::System.Guid batchJobContainerUuid, global::System.Guid setUuid, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet);

		// Token: 0x06000258 RID: 600
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		bool DeleteDBRecordEx(global::Motorola.CommonCPS.Server.EntityModel.DeleteRecordBatchJobParameter parameter);

		// Token: 0x06000259 RID: 601
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		bool DeleteDBRecordDirectly(global::System.Guid setUuid, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet);

		// Token: 0x0600025A RID: 602
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.Configuration AddConfiguration(global::Motorola.CommonCPS.Server.EntityModel.Configuration configuration);

		// Token: 0x0600025B RID: 603
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.Configuration, global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary>> AddDefConfiguration(global::Motorola.CommonCPS.Server.EntityModel.Configuration configuration, global::Motorola.CommonCPS.Server.EntityModel.BLEditSaveDataArg saveData);

		// Token: 0x0600025C RID: 604
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary> ListConfigurations(int startIndex, int pageSize, global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily = global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any);

		// Token: 0x0600025D RID: 605
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary> ListMatchedConfigurations(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? productFamily, global::Motorola.CommonCPS.Server.EntityModel.GenericModel.ParameterClasses.FilterParameter_OfListCompatibleConfiguration filterParameter, int startIndex, int count);

		// Token: 0x0600025E RID: 606
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.Dictionary<int, int> GetUsedOptionsOfConfiguration(global::System.Guid ConfigurationUuid);

		// Token: 0x0600025F RID: 607
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		int GetMatchedConfigurationCount(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? productFamily, global::Motorola.CommonCPS.Server.EntityModel.GenericModel.ParameterClasses.FilterParameter_OfListCompatibleConfiguration filterParameter);

		// Token: 0x06000260 RID: 608
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary GetConfigurationSummaryById(global::System.Guid configUuid);

		// Token: 0x06000261 RID: 609
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary> ListDBRecordSummarys(string setType, int startIndex, int pageSize);

		// Token: 0x06000262 RID: 610
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary> ListDBRecordSummaryByParentId(global::System.Guid parentUuid, string setType, int startIndex, int pageSize);

		// Token: 0x06000263 RID: 611
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary> ListDBRecordSummaryByParentAndChildType(global::System.Collections.Generic.List<global::System.Guid> parent, string navigationFieldName, int startIndex, int pageSize);

		// Token: 0x06000264 RID: 612
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary> ListDBRecordSummaries(global::System.Guid? parentUuid, global::System.Collections.Generic.List<string> setTypes, int startIndex, int pageSize);

		// Token: 0x06000265 RID: 613
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.RecordSummary GetDBRecordSummaryByTypeAndName(string SetType, string SetName);

		// Token: 0x06000266 RID: 614
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary GetConfigurationSummaryByName(string configName);

		// Token: 0x06000267 RID: 615
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.RecordSummary GetDBRecordSummaryByUuid(global::System.Guid uuid);

		// Token: 0x06000268 RID: 616
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.RecordSummary AddDBRecord(global::Motorola.CommonCPS.Server.EntityModel.DBNode node);

		// Token: 0x06000269 RID: 617
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.DBNode GetDBRecords(global::System.Collections.Generic.List<global::System.Guid> recordUuids, bool recusive = true);

		// Token: 0x0600026A RID: 618
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.DBNode GetDBNodeContainedByConfiguration(global::System.Guid ConfigurationUuid, string TopSetType);

		// Token: 0x0600026B RID: 619
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.Configuration GetConfiguration(global::System.Guid recordUuid);

		// Token: 0x0600026C RID: 620
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		bool IsConfiguationReadOnly(global::System.Guid ConfigurationUuid);

		// Token: 0x0600026D RID: 621
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Guid? GetWorkingConfigurationId(global::System.Guid radioUuid);

		// Token: 0x0600026E RID: 622
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary> ModifyDBRecords(global::Motorola.CommonCPS.Server.EntityModel.BLEditSaveDataArg saveData);

		// Token: 0x0600026F RID: 623
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		byte[] ModifyDBRecordsCmp(byte[] compressedSaveData);

		// Token: 0x06000270 RID: 624
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Radio> ListImpactedBySaveData(global::Motorola.CommonCPS.Server.EntityModel.BLEditSaveDataArg saveData);

		// Token: 0x06000271 RID: 625
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::Motorola.CommonCPS.Server.EntityModel.RecordSummary EditDBRecordSummary(global::Motorola.CommonCPS.Server.EntityModel.RecordSummary summary);

		// Token: 0x06000272 RID: 626
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary EditConfigurationSmmary(global::System.Guid configUuid, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.ConfigurationFieldType, object>> fieldValues, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet set);

		// Token: 0x06000273 RID: 627
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.GenericModel.ConfigurationArgs.SaveConfirmResult GetSaveConfirmResult(global::Motorola.CommonCPS.Server.EntityModel.BLEditSaveDataArg saveData);

		// Token: 0x06000274 RID: 628
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.Server.EntityModel.GenericModel.ConfigurationArgs.SaveConfirmResult GetSaveConfirmResultCmp(byte[] compressedSaveData);

		// Token: 0x06000275 RID: 629
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.Server.EntityModel.GenericModel.HomeSetArgs.SaveHomeSetConfirmResult GetSaveHomeSetConfirmResult(global::System.Guid ChangeImpactedHomeSetUuid);

		// Token: 0x06000276 RID: 630
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		bool UpdatePBBCodeplugForceWriteHomeset(global::System.Guid codeplugUuid, bool IsForceWriteHomeSet);

		// Token: 0x06000277 RID: 631
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.IList<string>>> GenerateDefaultSetName(global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<string, int>> setTypeList);

		// Token: 0x06000278 RID: 632
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.IList<string>>> GenerateDefaultEntityName(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.KeyValuePair<string, int>> NameDesc);

		// Token: 0x06000279 RID: 633
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Field>>> ListDBRecordFields(global::System.Guid? parentUuid, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, bool>>>> setTypesAndFieldName, int startIndex, int pageSize);

		// Token: 0x0600027A RID: 634
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Field>>> ListDBRecordFieldsByParentAndType(global::System.Guid? parentUuid, string setType, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, bool>> fieldNameList, int startIndex, int pageSize);

		// Token: 0x0600027B RID: 635
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Field>>> GetDBRecordFieldsByUuid(global::System.Guid uuid, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, bool>> fieldNameList);

		// Token: 0x0600027C RID: 636
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Field>>> GetDBRecordFieldsByUuids(global::System.Collections.Generic.List<global::System.Guid> uuids, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, bool>> fieldNameList);

		// Token: 0x0600027D RID: 637
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary> ListDBRecordParentById(global::System.Guid setId, global::Motorola.CommonCPS.Server.CommonDBConstants.RelationType relationType = global::Motorola.CommonCPS.Server.CommonDBConstants.RelationType.Contain);

		// Token: 0x0600027E RID: 638
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary> ListRelatedRecordById(global::System.Guid setId, bool isRecursive = true);

		// Token: 0x0600027F RID: 639
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary CopyConfiguration(global::Motorola.CommonCPS.Server.EntityModel.CopyConfigurationBatchJobParameter copyJobParameter);

		// Token: 0x06000280 RID: 640
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary> ListConfigurationsSetAssignedTo(global::System.Guid topSetUuid, int pageNumber, int pageSize);

		// Token: 0x06000281 RID: 641
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		int GetConfigurationsSetAssignedTo(global::System.Guid topSetUuid);

		// Token: 0x06000282 RID: 642
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary> ListConfigurationsSetsNumberReachMax(string setName, int maxNumber);

		// Token: 0x06000283 RID: 643
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.Server.EntityModel.GenericModel.ConfigurationArgs.SaveAsResult SaveSetAs(global::Motorola.CommonCPS.Server.EntityModel.GenericModel.ConfigurationArgs.SaveAsArgs saveAsArgs);

		// Token: 0x06000284 RID: 644
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary ImportBatchConfiguration(global::Motorola.CommonCPS.Server.EntityModel.ImportConfigurationBatchJobParameter parameter);

		// Token: 0x06000285 RID: 645
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary ImportCFGFromTemplate(global::Motorola.CommonCPS.Server.EntityModel.ImportCFGFromTemplateOpJobParameter parameter);

		// Token: 0x06000286 RID: 646
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		global::System.Collections.Generic.IDictionary<string, int> GetSetCountOfSetType(global::System.Collections.Generic.List<string> SetTypes);

		// Token: 0x06000287 RID: 647
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.IDictionary<string, int> GetSetCountOfSetTypeAndParentId(global::System.Guid ParentId, global::System.Collections.Generic.List<string> SetTypes);

		// Token: 0x06000288 RID: 648
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		void ForceToSyncRadioData(global::System.Guid RadioUuid);

		// Token: 0x06000289 RID: 649
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.Server.EntityModel.OptionsCollection> ListOptionDataById(global::System.Collections.Generic.List<global::System.Guid> uuids);

		// Token: 0x0600028A RID: 650
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Guid, global::System.Collections.Generic.List<int>>> GetUsedOptionsOfTopRecords(global::System.Collections.Generic.List<global::System.Guid> uuids, global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily);

		// Token: 0x0600028B RID: 651
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.GenericModel.ConfigurationArgs.SaveResultForPerConfiguration SaveForPerConfiguration(global::Motorola.CommonCPS.Server.EntityModel.GenericModel.ConfigurationArgs.SaveDataForPerConfiguration saveData);

		// Token: 0x0600028C RID: 652
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Guid, byte[]>> GetDBRecordsTimeStamp(global::System.Collections.Generic.List<global::System.Guid> TopRecords_Uuids);

		// Token: 0x0600028D RID: 653
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary ApplyMVO(global::Motorola.CommonCPS.Server.EntityModel.ApplyMVOBatchJobParameter parameter);

		// Token: 0x0600028E RID: 654
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		int GetCandidateMVORadioSummaryCount(global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? regionName = null);

		// Token: 0x0600028F RID: 655
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary> ListCandidateMVORadioSummary(int startIndex, int length, global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? regionName = null);

		// Token: 0x06000290 RID: 656
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile GetAPXDataProfile(global::System.Guid dataProfileUuid);

		// Token: 0x06000291 RID: 657
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem GetAPXRadioSystem(global::System.Guid radioSystemUuid);

		// Token: 0x06000292 RID: 658
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareCodeplugPair GetMatchedPCRFirmwareCodeplugPair(global::System.Guid pairGroupUuid, string modelNo, string tanapaNo);

		// Token: 0x06000293 RID: 659
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.EntityModel.EntitySummary, global::Motorola.CommonCPS.Server.EntityModel.MatrixRadioSummary> GetUpgradeMatchedMatrixRadios(global::System.Collections.Generic.List<global::System.Guid> matrixTemplateUuidList, global::System.Guid pcrFWGroupUuid, bool isAllowDowngrade, int startIndex, int count);

		// Token: 0x06000294 RID: 660
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		int GetUpgradeMatchedMatrixRadiosCount(global::System.Collections.Generic.List<global::System.Guid> matrixTemplateUuidList, global::System.Guid pcrFWGroupUuid, bool isAllowDowngrade);

		// Token: 0x06000295 RID: 661
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.Server.EntityModel.Template ImportTemplateAndUpdateLP(global::Motorola.CommonCPS.Server.EntityModel.Template template, string astroLPIDUpgradeTo, string currentFWVersion, bool? isPortable);

		// Token: 0x06000296 RID: 662
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary UpgradeRadio(global::Motorola.CommonCPS.Server.EntityModel.UpgradeRadioBatchJobParameter parameter);

		// Token: 0x06000297 RID: 663
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		void ClearDBLock(bool isForce);

		// Token: 0x06000298 RID: 664
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.LanguageDetailInfo> GetLPDetailInfo(global::System.Guid radioUuid);

		// Token: 0x06000299 RID: 665
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRDeviceCertificateDetailInfo> GetPCRDeviceCertificatesDetailInfo(global::System.Guid radioUuid);

		// Token: 0x0600029A RID: 666
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.VADetailInfo> GetVADetailInfo(global::System.Guid radioUuid);

		// Token: 0x0600029B RID: 667
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.TTSVADetailInfo> GetTTSVADetailInfo(global::System.Guid radioUuid);

		// Token: 0x0600029C RID: 668
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.LanguageDetailInfo> GetTemplateLPDetailInfo(global::System.Guid TemplateUuid);

		// Token: 0x0600029D RID: 669
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.VADetailInfo> GetTemplateVADetailInfo(global::System.Guid TemplateUuid);

		// Token: 0x0600029E RID: 670
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ApkApplicationDesc> GetApkAppDetailInfo(global::System.Guid radioUuid);

		// Token: 0x0600029F RID: 671
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.CertificatesDesc> GetCertificateDetailInfo(global::System.Guid radioUuid);

		// Token: 0x060002A0 RID: 672
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		int GetPCRRadioSystemSummariesCount(global::System.Guid? groupUuid, bool includeSubGroups = false);

		// Token: 0x060002A1 RID: 673
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRRadioSystemSummary> ListPCRRadioSystemSummaries(global::System.Guid? groupUuid, int startIndex, int count, bool includeSubGroups = false);

		// Token: 0x060002A2 RID: 674
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.ServiceKnownType(typeof(global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRDMR3Site>))]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.PCRRadioSystemSummary EditPCRRadioSystem(global::System.Guid radioUuid, global::System.Guid systemUuid, global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.CommonDBConstants.PCRRadioSystemFieldType, object> fieldValues, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet set);

		// Token: 0x060002A3 RID: 675
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		int GetPCRSystemRadioInfosCount(global::System.Guid? groupUuid);

		// Token: 0x060002A4 RID: 676
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRSystemRadioInfoSummary> ListPCRSystemRadioInfos(global::System.Guid? groupUuid, int startIndex, int count);

		// Token: 0x060002A5 RID: 677
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		int GetPCRSystemCountByRadio(global::System.Guid radioUuid);

		// Token: 0x060002A6 RID: 678
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRRadioSystemSummary> ListPCRSystemsByRadio(global::System.Guid radioUuid);

		// Token: 0x060002A7 RID: 679
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		int GetPCRRadioSystemsCount(global::System.Guid? groupUuid);

		// Token: 0x060002A8 RID: 680
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRSystemInfoSummary> ListPCRRadioSystems(global::System.Guid? groupUuid, int startIndex, int count);

		// Token: 0x060002A9 RID: 681
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		int GetPCRRadioCountBySystem(global::System.Guid? groupUuid, global::Motorola.CommonCPS.Server.EntityModel.PCRSystemInfoSummary pcrRadioSystem, bool includeSubGroups = false);

		// Token: 0x060002AA RID: 682
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRRadioSystemSummary> ListRadiosByPCRRadioSystem(global::System.Guid? groupUuid, global::Motorola.CommonCPS.Server.EntityModel.PCRSystemInfoSummary pcrRadioSystem, int startIndex, int count, bool includeSubGroups = false);

		// Token: 0x060002AB RID: 683
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::Motorola.CommonCPS.Server.EntityModel.PCRRadioSystem GetPCRRadioSystem(global::System.Guid radioSystemUuid);

		// Token: 0x060002AC RID: 684
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRRadioSystemSummary> GetPCRRadioSystemByDMR3System(global::System.Guid DMR3SystemUUID);

		// Token: 0x060002AD RID: 685
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.Server.EntityModel.LESystemLinkInfo GetPCRLESystemLinkInfo(string serialNum);

		// Token: 0x060002AE RID: 686
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.SystemInfo GetPCRDMR3SystemInfo(string serialNum);

		// Token: 0x060002AF RID: 687
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.QueryGroup> ListQueryGroups();

		// Token: 0x060002B0 RID: 688
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.QueryGroup AddQueryGroup();

		// Token: 0x060002B1 RID: 689
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.QueryGroup GetQueryGroup(global::System.Guid queryGroupUuid);

		// Token: 0x060002B2 RID: 690
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		void DeleteQueryGroup(global::Motorola.CommonCPS.Server.EntityModel.QueryGroup queryGroup, bool isForceDelete);

		// Token: 0x060002B3 RID: 691
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.QueryGroup UpdateQueryGroup(global::Motorola.CommonCPS.Server.EntityModel.QueryGroup queryGroup);

		// Token: 0x060002B4 RID: 692
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		int GetQueryCount(global::System.Guid? queryGroupUuid);

		// Token: 0x060002B5 RID: 693
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.QuerySummary> GetQuerySummaries(int startIndex, int length, global::System.Guid? queryGroupId);

		// Token: 0x060002B6 RID: 694
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::Motorola.CommonCPS.Server.EntityModel.QuerySummary MoveQuerysBatchOp(global::Motorola.CommonCPS.Server.EntityModel.GenericModel.BatchOperationJobParameter.MoveQuerysBatchJobParameter batchJobParamter);

		// Token: 0x060002B7 RID: 695
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::Motorola.CommonCPS.Server.EntityModel.QuerySummary MoveDataminingQuery(global::System.Guid QueryNodeUuid, global::System.Guid? QueryGroupUuidTo, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateSet);

		// Token: 0x060002B8 RID: 696
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::Motorola.CommonCPS.Server.EntityModel.QuerySummary GetDataMiningQuery(global::System.Guid queryId);

		// Token: 0x060002B9 RID: 697
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.Server.EntityModel.QuerySummary AddDataMiningQuery(global::Motorola.CommonCPS.Server.EntityModel.QuerySummary querySummary);

		// Token: 0x060002BA RID: 698
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.QuerySummary EditDataMiningQuery(global::System.Guid queryID, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DatamingQuerySummaryFieldType, object>> fieldValues, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet entitySet);

		// Token: 0x060002BB RID: 699
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		bool IsDataMiningNameDuplicate(string querySummaryName, global::System.Guid? groupUuid);

		// Token: 0x060002BC RID: 700
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		bool DeleteDataMiningQueryBatchOp(global::Motorola.CommonCPS.Server.EntityModel.GenericModel.BatchOperationJobParameter.DeleteQueryBatchJobParameter batchJobParamter);

		// Token: 0x060002BD RID: 701
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::System.Collections.Generic.List<global::System.Guid> DataMiningQuery(global::Motorola.CommonCPS.Server.EntityModel.QuerySummary querySummary);

		// Token: 0x060002BE RID: 702
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		void EnableJobStatistic();

		// Token: 0x060002BF RID: 703
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.JobStatistic> GetJobStatistics(global::System.Collections.Generic.List<global::System.Guid> jobUuid);

		// Token: 0x060002C0 RID: 704
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		global::System.Collections.Generic.List<string> GetUserPermissions();

		// Token: 0x060002C1 RID: 705
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		global::System.Collections.Generic.List<string> GetSystemKeyPermissions();

		// Token: 0x060002C2 RID: 706
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary UpgradeRadioCodeplugVersion(global::Motorola.CommonCPS.Server.EntityModel.BatchJobParameterBase parameter);

		// Token: 0x060002C3 RID: 707
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary TurnOffMNISCPIndicatior(string deviceID);

		// Token: 0x060002C4 RID: 708
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixRadio> ListMatrixRadioByDMR3System(global::System.Guid? DMR3SystemUuid);

		// Token: 0x060002C5 RID: 709
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.RMFile PrepareProvisioningTable(global::System.Guid radioUuid);

		// Token: 0x060002C6 RID: 710
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::Motorola.CommonCPS.Server.EntityModel.MigrationInfo GetMigrationInfo();

		// Token: 0x060002C7 RID: 711
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		void MigrateRadioAndCommonResource(global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? regionName, bool needMigrateHistoryPBAs = false);

		// Token: 0x060002C8 RID: 712
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MigrationTemplateInfo> ListMigrationTemplateList();

		// Token: 0x060002C9 RID: 713
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::Motorola.CommonCPS.Server.EntityModel.MigrationPBBConfigurationAndWiFi GetMigrationPBBFusionCfgWifi();

		// Token: 0x060002CA RID: 714
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.CommonDBConstants.MigrationStatus SaveMigrationTemplateSelctions(global::System.Collections.Generic.List<global::System.Guid> abandonedTemplateUuidList);

		// Token: 0x060002CB RID: 715
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.Server.EntityModel.Template MigrateTemplate(global::Motorola.CommonCPS.Server.EntityModel.MigrateTemplateParameter parameter);

		// Token: 0x060002CC RID: 716
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::Motorola.CommonCPS.Server.EntityModel.Radio MigrateTemplateDataToRadio(global::Motorola.CommonCPS.Server.EntityModel.MigrateTemplateDataToRadioParameter parameter);

		// Token: 0x060002CD RID: 717
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.Server.CommonDBConstants.MigrationStatus MigrateTemplateAndApplyTemplateDone();

		// Token: 0x060002CE RID: 718
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		int ScheduleMigrationJob();

		// Token: 0x060002CF RID: 719
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		void TurnOffMigration(string rmVersion);

		// Token: 0x060002D0 RID: 720
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.Server.EntityModel.RadioConvertionResult ConvertRadioFromTModeToCMode(global::Motorola.CommonCPS.Server.EntityModel.RadioConvertionOpJobParameter parameter);

		// Token: 0x060002D1 RID: 721
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.Server.EntityModel.ConvertRadioFromCModeToTModeResult ConvertRadioFromCModeToTMode(global::Motorola.CommonCPS.Server.EntityModel.ConvertRadioFromCModeToTModeOpJobParameter parameter);

		// Token: 0x060002D2 RID: 722
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.ConvertTRadioInfo GetConvertTRadioFileInfo(global::Motorola.CommonCPS.Server.EntityModel.RadioConversionRelationshipParameter parameter);

		// Token: 0x060002D3 RID: 723
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		void TransferArchiveFileById(global::System.Guid archiveUuid);

		// Token: 0x060002D4 RID: 724
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.ClearDataProgressReport GetClearDataProgressReport();

		// Token: 0x060002D5 RID: 725
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		void ClearLegacyData();

		// Token: 0x060002D6 RID: 726
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::Motorola.CommonCPS.Server.CommonDBConstants.MigrationStatus AbortMigration();

		// Token: 0x060002D7 RID: 727
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.MigrationEstimatedData CalculateMigrationTimeAndSize();

		// Token: 0x060002D8 RID: 728
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		void SwapRadioWorkingCodeplug(string serialNumber);

		// Token: 0x060002D9 RID: 729
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		void UpdateMigrationStatus(global::Motorola.CommonCPS.Server.CommonDBConstants.MigrationStatus status);

		// Token: 0x060002DA RID: 730
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		bool IsSessionOutOfTime(string templateID);

		// Token: 0x060002DB RID: 731
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		void RefreshSessionTimer(string templateID);

		// Token: 0x060002DC RID: 732
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		int GetWaitCount(string templateID);

		// Token: 0x060002DD RID: 733
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		void SetWaitCount(string templateID, int newValue);

		// Token: 0x060002DE RID: 734
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem> ListAllIPProgramSystems();

		// Token: 0x060002DF RID: 735
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem> ListIPProgramSystems(int startIndex, int length);

		// Token: 0x060002E0 RID: 736
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem GetIPProgramSystem(global::System.Guid sysUuid);

		// Token: 0x060002E1 RID: 737
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem GetIPProgramSystemByAlias(string sysAlias);

		// Token: 0x060002E2 RID: 738
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		int GetIPProgramSystemsCount();

		// Token: 0x060002E3 RID: 739
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem AddIPProgramSystem(global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem sys);

		// Token: 0x060002E4 RID: 740
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		void UpdateIPProgramSystem(global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem sys);

		// Token: 0x060002E5 RID: 741
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		bool DeleteIPProgramSystem(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem sys);

		// Token: 0x060002E6 RID: 742
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary, global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem> ApplyIPProgramSystemToRadio(global::System.Guid batchJobContainerUuid, global::System.Guid ipProgramSystemUuid, global::Motorola.CommonCPS.Server.EntityModel.RadioInfoForApplyIPProgramSystem radioInfo, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySets);

		// Token: 0x060002E7 RID: 743
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem> ListMatchedIPProgramSystems(global::System.Collections.Generic.List<global::System.Guid> radioUUIDList, int startIndex, int count);

		// Token: 0x060002E8 RID: 744
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		int GetMatchedIPProgramSystemCount(global::System.Collections.Generic.List<global::System.Guid> radioUUIDList);

		// Token: 0x060002E9 RID: 745
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem EditIPProgramSystem(global::System.Guid sysUuid, object changedField, global::Motorola.CommonCPS.Server.CommonDBConstants.IPProgramSystemFieldType fieldType, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet set);

		// Token: 0x060002EA RID: 746
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DMR3System> GetAllDMR3Systems();

		// Token: 0x060002EB RID: 747
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		int GetALLSACRecordsCount(global::System.Guid systemUUID);

		// Token: 0x060002EC RID: 748
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SACRecordSummary> GetALLSACRecords(global::System.Guid systemUUID, int startIndex, int count);

		// Token: 0x060002ED RID: 749
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SACRecordSummary> GetALLSACRecordsBySerial(global::System.Guid systemUUID, string serialNumber);

		// Token: 0x060002EE RID: 750
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SACRecordSummary> GetSACRecordsByDeviceID(global::System.Guid systemUUID, int deviceID);

		// Token: 0x060002EF RID: 751
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SACRecordSummary> GetSACRecordsBySerial(string serial);

		// Token: 0x060002F0 RID: 752
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SACSiteSelection> GetAllSACSiteSelection(global::System.Guid systemUUID);

		// Token: 0x060002F1 RID: 753
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::Motorola.CommonCPS.Server.EntityModel.SACSiteSelection GetSACSiteSelection(global::System.Guid systemUUID, global::System.Guid siteSelUuid);

		// Token: 0x060002F2 RID: 754
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DMR3Site> GetDMR3SitesBySystem(global::System.Guid systemUUID);

		// Token: 0x060002F3 RID: 755
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DMR3Site> GetSelDMR3Sites(global::System.Guid sACSiteSelUUID);

		// Token: 0x060002F4 RID: 756
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::Motorola.CommonCPS.Server.EntityModel.SACRecordSummary AddSACRecord(global::Motorola.CommonCPS.Server.EntityModel.SACRecord sacRecord);

		// Token: 0x060002F5 RID: 757
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		bool DeleteSACRecord(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.SACRecordSummary sACRecord);

		// Token: 0x060002F6 RID: 758
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.Server.EntityModel.SACRecordSummary EditSACRecord(global::Motorola.CommonCPS.Server.EntityModel.SACRecord sacRecord, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.SACRecordFieldType, object>> changedFieldValePair, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet);

		// Token: 0x060002F7 RID: 759
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.SACRecordSummary EditSACRecordBat(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.SACRecord sacRecord, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.SACRecordFieldType, object>> changedFieldValePair, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet);

		// Token: 0x060002F8 RID: 760
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		bool EditSACSiteSelectionBatch(global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SACSiteSelection> sACSiteSelections);

		// Token: 0x060002F9 RID: 761
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.Server.EntityModel.SACRecordSummary ImportSACFromCSV(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.ImportSACFromCSVRequest csvRequest, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet);

		// Token: 0x060002FA RID: 762
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		int GetALLTGSARecordsCount(global::System.Guid systemUUID);

		// Token: 0x060002FB RID: 763
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.TGSARecord> GetALLTGSARecords(global::System.Guid systemUUID, int startIndex, int count);

		// Token: 0x060002FC RID: 764
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.TGSARecord> GetTGSARecordsByTalkGroupID(global::System.Guid systemUuid, int talkGroupID);

		// Token: 0x060002FD RID: 765
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.TGSASiteSelection> GetAllTGSASiteSelection(global::System.Guid systemUUID);

		// Token: 0x060002FE RID: 766
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.TGSASelSite> GetSelTGSASites(global::System.Guid tGSASiteSelUUID);

		// Token: 0x060002FF RID: 767
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.TGSARecord> AddTGSARecords(global::System.Guid batchJobContainerUuid, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.TGSARecord> modifyTGSAs, global::System.Guid sysUUID);

		// Token: 0x06000300 RID: 768
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.TGSARecord> DeleteTGSARecords(global::System.Guid batchJobContainerUuid, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.TGSARecord> tGSARecords);

		// Token: 0x06000301 RID: 769
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.TGSARecord EditTGSARecord(global::System.Guid tGSARecordUUID, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.TGSARecordFieldType, object>> changedFieldValePair, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet);

		// Token: 0x06000302 RID: 770
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.Server.EntityModel.TGSARecord EditTGSARecordBat(global::System.Guid batchJobContainerUuid, global::System.Guid tGSARecordUUID, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.TGSARecordFieldType, object>> changedFieldValePair, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet);

		// Token: 0x06000303 RID: 771
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.Server.EntityModel.TGSARecord ImportTGSAFromCSV(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.ImportTGSAFromCSVRequest csvRequest, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet);

		// Token: 0x06000304 RID: 772
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		bool EditTGSASiteSelectionBatch(global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.TGSASiteSelection> tGSASiteSelection);

		// Token: 0x06000305 RID: 773
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary EditPCRDeviceCertificate(global::System.Guid radioUuid, global::System.Guid deviceCertUuid, global::System.Collections.Generic.Dictionary<string, object> fieldValues, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet set);

		// Token: 0x06000306 RID: 774
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.BLVersion GetCurrentDataModelVersion();

		// Token: 0x06000307 RID: 775
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		void SetCurrentDataModelVersion(global::Motorola.CommonCPS.Server.EntityModel.BLVersion currentDataModelVersion);

		// Token: 0x06000308 RID: 776
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		int InitialDBUpradeProcess(global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.DBUpgradeInfo upgradeInfo);

		// Token: 0x06000309 RID: 777
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.DBNode> GetNextInitDNodes(int exceptCount = 5);

		// Token: 0x0600030A RID: 778
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		void SaveDBNodeInitStructure(global::Motorola.CommonCPS.Server.EntityModel.DBNode node);

		// Token: 0x0600030B RID: 779
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.DBUpgradeSet GetNextResolvingDBNodes(global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.DBUpgradeResolverSetRequest request);

		// Token: 0x0600030C RID: 780
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		void SaveDBResolverResult(global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.DBResolverSaveData result);

		// Token: 0x0600030D RID: 781
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode> GetNextDBUpgradeFinalizingSets(string setType, int count = 1);

		// Token: 0x0600030E RID: 782
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary> SaveUpgradeFinalizeSet(global::Motorola.CommonCPS.Server.EntityModel.BLEditSaveDataArg bllSaveData);

		// Token: 0x0600030F RID: 783
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.IList<string> GetUpgradeHandlerParameterRequest(global::Motorola.CommonCPS.Server.CommonDBConstants.PACType pac, global::Motorola.CommonCPS.Server.EntityModel.BLVersion currentDataModelVersion);

		// Token: 0x06000310 RID: 784
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		void RunDBUpgradeHandler(global::Motorola.CommonCPS.Server.CommonDBConstants.PACType pac, global::Motorola.CommonCPS.Server.EntityModel.BLVersion currentDataModelVersion, global::System.Collections.Generic.Dictionary<string, object> parameters);

		// Token: 0x06000311 RID: 785
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::System.Collections.Generic.List<string> ListEndpointsWeb(string queryString);

		// Token: 0x06000312 RID: 786
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.JobContainerResponse ListJobContainersWeb(string queryString);

		// Token: 0x06000313 RID: 787
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.JobContainerDetail GetJobContainerByIdWeb(string jobContainerID, string queryString);

		// Token: 0x06000314 RID: 788
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.Server.EntityModel.JobContainerResponse ListJobContainersBySerialNumberWeb(string serialNumber, string queryString);

		// Token: 0x06000315 RID: 789
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.Server.EntityModel.JobDetailResponse ListJobDetailsByJobContainerIdWeb(string jobContainerId, string queryString);

		// Token: 0x06000316 RID: 790
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.Server.EntityModel.JobDetailResponse ListJobDetailsWeb(string queryString);

		// Token: 0x06000317 RID: 791
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::Motorola.CommonCPS.Server.EntityModel.JobDetail GetJobDetailByIdWeb(string jobDetailId, string queryString);

		// Token: 0x06000318 RID: 792
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.RadioDetailResponse ListRadiosByJobDetailIdWeb(string jobDetailId, string queryString);

		// Token: 0x06000319 RID: 793
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::Motorola.CommonCPS.Server.EntityModel.RadioDetailResponse ListRadiosWeb(string queryString);

		// Token: 0x0600031A RID: 794
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::Motorola.CommonCPS.Server.EntityModel.RadioDetail GetRadioBySerialNumberWeb(string serialNumber, string queryString);

		// Token: 0x0600031B RID: 795
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::Motorola.CommonCPS.Server.EntityModel.RadioDetailResponse ListRadiosByJobContainerIdWeb(string serialNumber, string queryString);

		// Token: 0x0600031C RID: 796
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.GroupDetailResponse ListGroupsWeb(string queryString);

		// Token: 0x0600031D RID: 797
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.Server.EntityModel.Group GetGroupByNameWeb(string groupName);

		// Token: 0x0600031E RID: 798
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.GroupDetail GetGroupByGroupNameWeb(string groupName, string queryString);

		// Token: 0x0600031F RID: 799
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::Motorola.CommonCPS.Server.EntityModel.RadioDetailResponse ListRadiosByGroupNameWeb(string groupName, string queryString);

		// Token: 0x06000320 RID: 800
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.List<string> GetTemplateNamesWeb();

		// Token: 0x06000321 RID: 801
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.List<string> GetRadioAliasesWeb();

		// Token: 0x06000322 RID: 802
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		global::System.Collections.Generic.List<string> GetModelNumbersWeb();

		// Token: 0x06000323 RID: 803
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.Server.EntityModel.EnumeratedDetailResponse GetJobTypesWeb();

		// Token: 0x06000324 RID: 804
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::Motorola.CommonCPS.Server.EntityModel.EnumeratedDetailResponse GetJobStatusesWeb();

		// Token: 0x06000325 RID: 805
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::Motorola.CommonCPS.Server.EntityModel.EnumeratedDetailResponse GetJobDetailStatusesWeb();

		// Token: 0x06000326 RID: 806
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.RMServerContract.GroupDTO> ListGroupsRMAPI(global::Motorola.CommonCPS.Server.RMServerContract.QueryTO wherefilter, global::Motorola.CommonCPS.Server.RMServerContract.QueryTO searchfilter, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>> orderbylist, global::Motorola.CommonCPS.Server.RMServerContract.PaginationQTO paginationQto);

		// Token: 0x06000327 RID: 807
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		int GetCountOfGroupsRMAPI(global::Motorola.CommonCPS.Server.RMServerContract.QueryTO wherefilter, global::Motorola.CommonCPS.Server.RMServerContract.QueryTO searchfilter);

		// Token: 0x06000328 RID: 808
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>> GetDistinctFromGroupRMAPI(global::Motorola.CommonCPS.Server.RMServerContract.QueryTO wherefilter, global::Motorola.CommonCPS.Server.RMServerContract.QueryTO searchfilter, global::Motorola.CommonCPS.Server.RMServerContract.QueryTO columnNames);

		// Token: 0x06000329 RID: 809
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.RMServerContract.ReadWriteJobContainerDTO> ListJobContainerRMAPI(global::Motorola.CommonCPS.Server.RMServerContract.QueryTO wherefilter, global::Motorola.CommonCPS.Server.RMServerContract.QueryTO searchfilter, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>> orderbylist, global::Motorola.CommonCPS.Server.RMServerContract.PaginationQTO paginationQto);

		// Token: 0x0600032A RID: 810
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		int GetCountOfJobContainerRMAPI(global::Motorola.CommonCPS.Server.RMServerContract.QueryTO wherefilter, global::Motorola.CommonCPS.Server.RMServerContract.QueryTO searchfilter);

		// Token: 0x0600032B RID: 811
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>> GetDistinctFromJobContainerRMAPI(global::Motorola.CommonCPS.Server.RMServerContract.QueryTO wherefilter, global::Motorola.CommonCPS.Server.RMServerContract.QueryTO searchfilter, global::Motorola.CommonCPS.Server.RMServerContract.QueryTO columnNames);

		// Token: 0x0600032C RID: 812
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.RMServerContract.JobDTO> ListJobRMAPI(global::Motorola.CommonCPS.Server.RMServerContract.QueryTO wherefilter, global::Motorola.CommonCPS.Server.RMServerContract.QueryTO searchfilter, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>> orderbylist, global::Motorola.CommonCPS.Server.RMServerContract.PaginationQTO paginationQto);

		// Token: 0x0600032D RID: 813
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		int GetCountOfJobRMAPI(global::Motorola.CommonCPS.Server.RMServerContract.QueryTO wherefilter, global::Motorola.CommonCPS.Server.RMServerContract.QueryTO searchfilter);

		// Token: 0x0600032E RID: 814
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>> GetDistinctFromJobRMAPI(global::Motorola.CommonCPS.Server.RMServerContract.QueryTO wherefilter, global::Motorola.CommonCPS.Server.RMServerContract.QueryTO searchfilter, global::Motorola.CommonCPS.Server.RMServerContract.QueryTO columnNames);

		// Token: 0x0600032F RID: 815
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.RMServerContract.ReadWriteJobViewSummaryDTO> ListJobSummaryRMAPI(global::Motorola.CommonCPS.Server.RMServerContract.QueryTO wherefilter, global::Motorola.CommonCPS.Server.RMServerContract.QueryTO searchfilter, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>> orderbylist, global::Motorola.CommonCPS.Server.RMServerContract.PaginationQTO paginationQto);

		// Token: 0x06000330 RID: 816
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		int GetCountOfJobSummaryRMAPI(global::Motorola.CommonCPS.Server.RMServerContract.QueryTO wherefilter, global::Motorola.CommonCPS.Server.RMServerContract.QueryTO searchfilter);

		// Token: 0x06000331 RID: 817
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>> GetDistinctFromJobSummaryRMAPI(global::Motorola.CommonCPS.Server.RMServerContract.QueryTO wherefilter, global::Motorola.CommonCPS.Server.RMServerContract.QueryTO searchfilter, global::Motorola.CommonCPS.Server.RMServerContract.QueryTO columnNames);

		// Token: 0x06000332 RID: 818
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.RMServerContract.APXRadioSummaryDTO> ListAPXRadioSummaryRMAPI(global::Motorola.CommonCPS.Server.RMServerContract.QueryTO wherefilter, global::Motorola.CommonCPS.Server.RMServerContract.QueryTO searchfilter, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>> orderbylist, global::Motorola.CommonCPS.Server.RMServerContract.PaginationQTO paginationQto);

		// Token: 0x06000333 RID: 819
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		int GetCountOfAPXRadioSummaryRMAPI(global::Motorola.CommonCPS.Server.RMServerContract.QueryTO wherefilter, global::Motorola.CommonCPS.Server.RMServerContract.QueryTO searchfilter);

		// Token: 0x06000334 RID: 820
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>> GetDistinctValuesFromAPXRadioSummaryByFilters(global::Motorola.CommonCPS.Server.RMServerContract.QueryTO wherefilter, global::Motorola.CommonCPS.Server.RMServerContract.QueryTO searchfilter, global::Motorola.CommonCPS.Server.RMServerContract.QueryTO columnNames);

		// Token: 0x06000335 RID: 821
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.RMServerContract.MatrixRadioSummaryDTO> ListMatrixRadioSummaryRMAPI(global::Motorola.CommonCPS.Server.RMServerContract.QueryTO wherefilter, global::Motorola.CommonCPS.Server.RMServerContract.QueryTO searchfilter, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>> orderbylist, global::Motorola.CommonCPS.Server.RMServerContract.PaginationQTO paginationQto);

		// Token: 0x06000336 RID: 822
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		int GetCountOfMatrixRadioSummaryRMAPI(global::Motorola.CommonCPS.Server.RMServerContract.QueryTO wherefilter, global::Motorola.CommonCPS.Server.RMServerContract.QueryTO searchfilter);

		// Token: 0x06000337 RID: 823
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>> GetDistinctValuesFromMatrixRadioSummaryByFilters(global::Motorola.CommonCPS.Server.RMServerContract.QueryTO wherefilter, global::Motorola.CommonCPS.Server.RMServerContract.QueryTO searchfilter, global::Motorola.CommonCPS.Server.RMServerContract.QueryTO columnNames);

		// Token: 0x06000338 RID: 824
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.RMServerContract.PBBRadioSummaryDTO> ListPBBRadioSummaryRMAPI(global::Motorola.CommonCPS.Server.RMServerContract.QueryTO wherefilter, global::Motorola.CommonCPS.Server.RMServerContract.QueryTO searchfilter, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>> orderbylist, global::Motorola.CommonCPS.Server.RMServerContract.PaginationQTO paginationQto);

		// Token: 0x06000339 RID: 825
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		int GetCountOfPBBRadioSummaryRMAPI(global::Motorola.CommonCPS.Server.RMServerContract.QueryTO wherefilter, global::Motorola.CommonCPS.Server.RMServerContract.QueryTO searchfilter);

		// Token: 0x0600033A RID: 826
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>> GetDistinctValuesFromPBBRadioSummaryByFilters(global::Motorola.CommonCPS.Server.RMServerContract.QueryTO wherefilter, global::Motorola.CommonCPS.Server.RMServerContract.QueryTO searchfilter, global::Motorola.CommonCPS.Server.RMServerContract.QueryTO columnNames);

		// Token: 0x0600033B RID: 827
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		string GetRMVersion();

		// Token: 0x0600033C RID: 828
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::Motorola.CommonCPS.Server.CommonDBConstants.DatabaseSpaceLevel GetDatabaseSpaceLevel();

		// Token: 0x0600033D RID: 829
		[global::System.ServiceModel.OperationContract]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		bool IsFirmwareVersionModified(global::System.Collections.Generic.List<string> radioSerialNumbers);

		// Token: 0x0600033E RID: 830
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		[global::System.ServiceModel.OperationContract]
		void CancelBatchJobContainerByUser(global::System.Guid batchJobContainerUuid);
	}
}
