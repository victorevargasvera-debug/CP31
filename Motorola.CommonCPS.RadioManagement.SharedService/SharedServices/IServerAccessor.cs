using System;
using System.Collections.Generic;
using System.Security;
using System.Threading;
using ASK.Interface;
using EntityModel.GenericModel;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;
using Motorola.CommonCPS.Server.EntityModel.DataTransferObjects;
using Motorola.CommonCPS.Server.EntityModel.GenericModel;
using Motorola.CommonCPS.Server.EntityModel.GenericModel.ConfigurationArgs;
using Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels;
using Motorola.CommonCPS.Server.EntityModel.GenericModel.HomeSetArgs;
using Motorola.CommonCPS.Server.EntityModel.GenericModel.ParameterClasses;
using Motorola.CommonCPS.Server.GenericModel;
using Motorola.CommonCPS.Server.RMDiscoveryServiceInterface;
using Motorola.CommonCPS.Server.RMServerContract.DataQueryObjects;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x0200001E RID: 30
	public interface IServerAccessor
	{
		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060002EE RID: 750
		bool IsConnected { get; }

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060002EF RID: 751
		global::Motorola.Common.CustomException.CommonErrorCode CompatibilityErrorCode { get; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060002F0 RID: 752
		global::Motorola.CommonCPS.Server.EntityModel.RMCInfo RMCInfo { get; }

		// Token: 0x060002F1 RID: 753
		bool Connect(bool backgroundconnection = false);

		// Token: 0x060002F2 RID: 754
		bool Connect(string address, int port, string authAddress, string authMethod, global::System.Threading.SynchronizationContext synchronizationContext, string username = "", global::System.Security.SecureString password = null, bool backgroundconnection = false, string jwtToken = null);

		// Token: 0x060002F3 RID: 755
		void UpdateSession();

		// Token: 0x060002F4 RID: 756
		int ChangePassword(string oldPassword, string newPassword, string currentUserType, string authType, string discoveryHost, int discoveryPort, string svcType, string userName = null, global::System.Security.SecureString pswd = null, bool activating = false);

		// Token: 0x060002F5 RID: 757
		void Disconnect();

		// Token: 0x060002F6 RID: 758
		void CheckCompatibility();

		// Token: 0x060002F7 RID: 759
		global::Motorola.CommonCPS.Server.EntityModel.BLVersion GetServerVersion();

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060002F8 RID: 760
		// (set) Token: 0x060002F9 RID: 761
		global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerEventHandler ServerEventArrived { get; set; }

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060002FA RID: 762
		// (set) Token: 0x060002FB RID: 763
		global::Motorola.CommonCPS.RadioManagement.SharedServices.IncompatibilityHandler IncompatiblityDetected { get; set; }

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060002FC RID: 764
		// (set) Token: 0x060002FD RID: 765
		global::System.EventHandler InvalidJwtTokenDetected { get; set; }

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060002FE RID: 766
		// (set) Token: 0x060002FF RID: 767
		global::Motorola.CommonCPS.RadioManagement.SharedServices.ConnectionClosedFaulted ConnectionClosedFaulted { get; set; }

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000300 RID: 768
		// (set) Token: 0x06000301 RID: 769
		global::System.EventHandler ServerConnectedEventHandler { get; set; }

		// Token: 0x06000302 RID: 770
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.RMDiscoveryServiceInterface.SystemKeyOperationResult> UploadSystemKeys(global::System.Collections.Generic.List<global::ASK.Interface.SystemKeyPermissionData> syskeyPermissions, string currentUserType, string authType, string discoveryHost, int discoveryPort, string svcType, string pac, string userName = null, global::System.Security.SecureString pswd = null, string jwtToken = null);

		// Token: 0x06000303 RID: 771
		global::Motorola.CommonCPS.Server.CommonDBConstants.DatabaseSpaceLevel GetDatabaseSpaceStatus();

		// Token: 0x06000304 RID: 772
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary GetRadioSummary(global::System.Guid radioId);

		// Token: 0x06000305 RID: 773
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary> GetRadioSummaries(int startIndex, int length, global::System.Guid? groupId, global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode workMode);

		// Token: 0x06000306 RID: 774
		global::Motorola.CommonCPS.Server.EntityModel.Radio GetRadioByDeviceUuid(global::System.Guid radioID, bool deepLoad = true);

		// Token: 0x06000307 RID: 775
		global::Motorola.CommonCPS.Server.EntityModel.Radio GetRadioByDeviceID(string deviceID, bool isDeep = false);

		// Token: 0x06000308 RID: 776
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary UpdateCodeplugPassword(global::Motorola.CommonCPS.Server.EntityModel.PasswordInfo pwdInfo, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet Set);

		// Token: 0x06000309 RID: 777
		global::Motorola.CommonCPS.Server.EntityModel.Codeplug GetCodeplug(global::System.Guid codePlugID);

		// Token: 0x0600030A RID: 778
		bool IsFirmwareVersionModified(global::System.Collections.Generic.List<string> radioSerialNumbers);

		// Token: 0x0600030B RID: 779
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.Group> GetGroups();

		// Token: 0x0600030C RID: 780
		global::Motorola.CommonCPS.Server.EntityModel.Group AddGroup(global::System.Guid? parentGroupUuid = null);

		// Token: 0x0600030D RID: 781
		void DeleteGroup(global::System.Guid groupUuid);

		// Token: 0x0600030E RID: 782
		byte[] UpdateGroup(global::Motorola.CommonCPS.Server.EntityModel.Group group);

		// Token: 0x0600030F RID: 783
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary MoveDeviceFromGroup(global::System.Guid? groupUuidTo, global::System.Guid deviceUuid, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet entitySet);

		// Token: 0x06000310 RID: 784
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary MoveDevicesBatchOp(global::System.Guid batchJobContainerUuid, global::System.Guid? groupUuidTo, global::System.Guid radioUuid, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet entitySet);

		// Token: 0x06000311 RID: 785
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.QuerySummary> GetQuerySummaries(int startIndex, int length, global::System.Guid? queryGroupId);

		// Token: 0x06000312 RID: 786
		bool DeleteQueryBatchOp(global::System.Guid batchJobContainerId, global::System.Guid queryId, string jobName, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet set);

		// Token: 0x06000313 RID: 787
		global::Motorola.CommonCPS.Server.EntityModel.QuerySummary MoveQuerysBatchOp(global::System.Guid batchJobContainerUuid, global::System.Guid? queryGroupUuidTo, global::System.Guid queryUuid, string jobName, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet entitySet);

		// Token: 0x06000314 RID: 788
		global::Motorola.CommonCPS.Server.EntityModel.QuerySummary AddQuery(global::Motorola.CommonCPS.Server.EntityModel.QuerySummary queryRawData, global::Motorola.CommonCPS.Server.EntityModel.QueryNode queryConditionRawData, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet set);

		// Token: 0x06000315 RID: 789
		bool IsQueryNameDuplicate(string querySummaryName);

		// Token: 0x06000316 RID: 790
		string GenerateDefaultQueryName();

		// Token: 0x06000317 RID: 791
		global::Motorola.CommonCPS.Server.EntityModel.QuerySummary MoveQueryFromGroup(global::System.Guid? groupUuidTo, global::System.Guid queryUuid, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet entitySet);

		// Token: 0x06000318 RID: 792
		global::Motorola.CommonCPS.Server.EntityModel.QuerySummary EditQuery(global::System.Guid queryID, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DatamingQuerySummaryFieldType, object>> fieldValues, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet entitySet);

		// Token: 0x06000319 RID: 793
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.QueryGroup> GetQueryGroups();

		// Token: 0x0600031A RID: 794
		global::Motorola.CommonCPS.Server.EntityModel.QueryGroup AddQueryGroup();

		// Token: 0x0600031B RID: 795
		global::Motorola.CommonCPS.Server.EntityModel.QueryGroup GetQueryGroup(global::System.Guid queryGroupUuid);

		// Token: 0x0600031C RID: 796
		void DeleteQueryGroup(global::Motorola.CommonCPS.Server.EntityModel.QueryGroup queryGroup);

		// Token: 0x0600031D RID: 797
		global::Motorola.CommonCPS.Server.EntityModel.QueryGroup UpdateQueryGroup(global::Motorola.CommonCPS.Server.EntityModel.QueryGroup queryGroup);

		// Token: 0x0600031E RID: 798
		int GetQueryCount(global::System.Guid? querygGroupUuid);

		// Token: 0x0600031F RID: 799
		global::Motorola.CommonCPS.Server.EntityModel.QueryNode GetQueryNode(global::System.Guid? queryId, out global::Motorola.CommonCPS.Server.EntityModel.QuerySummary summary);

		// Token: 0x06000320 RID: 800
		global::System.Collections.Generic.List<global::System.Guid> QueryConfigurations(global::Motorola.CommonCPS.Server.EntityModel.QuerySummary query, global::Motorola.CommonCPS.Server.EntityModel.QueryNode node);

		// Token: 0x06000321 RID: 801
		int GetAllDataProfilesCount(global::System.Guid? groupUuid);

		// Token: 0x06000322 RID: 802
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary> GetASTRODataProfiles(global::System.Guid? groupUUID, int startIndex, int count);

		// Token: 0x06000323 RID: 803
		int GetDataProfileInfoCount(global::System.Guid? groupUuid);

		// Token: 0x06000324 RID: 804
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.DataProfileInfo> ListDataProfileInfo(global::System.Guid? groupUUID, int startIndex, int count);

		// Token: 0x06000325 RID: 805
		int GetRadioCountByProfile(global::System.Guid? groupUuid, string profileName, int systemType);

		// Token: 0x06000326 RID: 806
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary> ListRadiosByProfile(global::System.Guid? groupUUID, string profileName, int systemType, int startIndex, int count);

		// Token: 0x06000327 RID: 807
		int GetProfileRadioInfoCount(global::System.Guid? groupUuid);

		// Token: 0x06000328 RID: 808
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.ProfileRadioInfoSummary> ListProfileRadioInfo(global::System.Guid? groupUUID, int startIndex, int count);

		// Token: 0x06000329 RID: 809
		int GetProfileCountByRadio(global::System.Guid radioId);

		// Token: 0x0600032A RID: 810
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary> ListProfilesByRadio(global::System.Guid radioId);

		// Token: 0x0600032B RID: 811
		int GetAPXOtarProfilesCount(global::System.Guid? groupUuid);

		// Token: 0x0600032C RID: 812
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO> GetAPXOtarProfiles(global::System.Guid? groupUUID, int startIndex, int count);

		// Token: 0x0600032D RID: 813
		int GetAPXOtarProfilesInfoCount(global::System.Guid? groupUuid);

		// Token: 0x0600032E RID: 814
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileInfoDTO> GetAPXOtarProfilesInfo(global::System.Guid? groupUUID, int startIndex, int count);

		// Token: 0x0600032F RID: 815
		int GetRadiosByAPXOtarProfileCount(global::System.Guid? groupUuid, global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileInfoDTO otarProfileDTO);

		// Token: 0x06000330 RID: 816
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO> GetRadiosByAPXOtarProfile(global::System.Guid? groupUUID, global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileInfoDTO otarProfileDto, int startIndex, int count);

		// Token: 0x06000331 RID: 817
		int GetAPXOtarProfileRadiosInfoCount(global::System.Guid? groupUuid);

		// Token: 0x06000332 RID: 818
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileRadioInfoDTO> GetAPXOtarProfileRadiosInfo(global::System.Guid? groupUUID, int startIndex, int count);

		// Token: 0x06000333 RID: 819
		int GetAPXOtarProfilesByRadioCount(global::System.Guid radioId);

		// Token: 0x06000334 RID: 820
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO> GetAPXOtarProfilesByRadio(global::System.Guid radioId);

		// Token: 0x06000335 RID: 821
		int GetAllRadioSystemSummariesCount(global::System.Guid? groupUuid);

		// Token: 0x06000336 RID: 822
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystemSummary> ListAllRadioSystems(global::System.Guid? groupUUID, int startIndex, int count);

		// Token: 0x06000337 RID: 823
		int GetAPXRadioSystemsCount(global::System.Guid? groupUuid);

		// Token: 0x06000338 RID: 824
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.APXSystemInfoSummary> ListAPXRadioSystems(global::System.Guid? groupUUID, int startIndex, int count);

		// Token: 0x06000339 RID: 825
		int GetRadioCountBySystem(global::System.Guid? groupUuid, global::Motorola.CommonCPS.Server.EntityModel.APXSystemInfoSummary apxRadioSystem);

		// Token: 0x0600033A RID: 826
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystemSummary> ListRadiosByRadioSystem(global::System.Guid? groupUuid, global::Motorola.CommonCPS.Server.EntityModel.APXSystemInfoSummary apxRadioSystem, int startIndex, int count, global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily = global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any);

		// Token: 0x0600033B RID: 827
		int GetSystemRadioInfosCount(global::System.Guid? groupUuid);

		// Token: 0x0600033C RID: 828
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXSystemRadioInfoSummary> ListSystemRadioInfos(global::System.Guid? groupUuid, int startIndex, int count);

		// Token: 0x0600033D RID: 829
		int GetSystemCountByRadio(global::System.Guid radioUuid);

		// Token: 0x0600033E RID: 830
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystemSummary> ListSystemsByRadio(global::System.Guid radioUuid);

		// Token: 0x0600033F RID: 831
		global::Motorola.CommonCPS.Server.EntityModel.PCRRadioSystemSummary EditPCRRadioSystem(global::System.Guid radioUuid, global::System.Guid systemUuid, global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.CommonDBConstants.PCRRadioSystemFieldType, object> fieldValues, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet set);

		// Token: 0x06000340 RID: 832
		int GetPCRRadioSystemSummariesCount(global::System.Guid? groupUuid);

		// Token: 0x06000341 RID: 833
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRRadioSystemSummary> ListPCRRadioSystemSummaries(global::System.Guid? groupUuid, int startIndex, int count);

		// Token: 0x06000342 RID: 834
		int GetPCRSystemRadioInfosCount(global::System.Guid? groupUuid);

		// Token: 0x06000343 RID: 835
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRSystemRadioInfoSummary> ListPCRSystemRadioInfos(global::System.Guid? groupUuid, int startIndex, int count);

		// Token: 0x06000344 RID: 836
		int GetPCRSystemCountByRadio(global::System.Guid radioUuid);

		// Token: 0x06000345 RID: 837
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRRadioSystemSummary> ListPCRSystemsByRadio(global::System.Guid radioUuid);

		// Token: 0x06000346 RID: 838
		int GetPCRRadioSystemsCount(global::System.Guid? groupUuid);

		// Token: 0x06000347 RID: 839
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRSystemInfoSummary> ListPCRRadioSystems(global::System.Guid? groupUuid, int startIndex, int count);

		// Token: 0x06000348 RID: 840
		int GetPCRRadioCountBySystem(global::System.Guid? groupUuid, global::Motorola.CommonCPS.Server.EntityModel.PCRSystemInfoSummary pcrRadioSystem);

		// Token: 0x06000349 RID: 841
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRRadioSystemSummary> ListRadiosByPCRRadioSystem(global::System.Guid? groupUuid, global::Motorola.CommonCPS.Server.EntityModel.PCRSystemInfoSummary pcrRadioSystem, int startIndex, int count);

		// Token: 0x0600034A RID: 842
		global::Motorola.CommonCPS.Server.EntityModel.PCRRadioSystem GetPCRRadioSystem(global::System.Guid id);

		// Token: 0x0600034B RID: 843
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRRadioSystemSummary> GetPCRRadioSystemByDMR3System(global::System.Guid radioSystemUuid);

		// Token: 0x0600034C RID: 844
		int GetDeviceRWJobsCount(global::System.Guid deviceUuid);

		// Token: 0x0600034D RID: 845
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ReadWriteJob> ListJobsByDeviceUuid(global::System.Guid deviceID, int startIndex, int count);

		// Token: 0x0600034E RID: 846
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.JobContainerSummary> ListJbcSummarys(bool? isRwJob, int pageNumber, int pageSize);

		// Token: 0x0600034F RID: 847
		global::Motorola.CommonCPS.Server.EntityModel.JobContainerSummary GetLastJbcSummary(bool? isRwJob);

		// Token: 0x06000350 RID: 848
		global::Motorola.CommonCPS.Server.EntityModel.JobContainerSummary GetJbcSummary(global::System.Guid guid);

		// Token: 0x06000351 RID: 849
		int GetJbcCount(bool? isRwJob);

		// Token: 0x06000352 RID: 850
		int GetJobCount(global::System.Guid jbcUuid);

		// Token: 0x06000353 RID: 851
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.JobSummaryViewEntity> ListJobSummary(global::System.Guid jbcUuid, int pageNumber, int pageSize);

		// Token: 0x06000354 RID: 852
		global::Motorola.CommonCPS.Server.EntityModel.Job GetJob(global::System.Guid jobUuid);

		// Token: 0x06000355 RID: 853
		global::Motorola.CommonCPS.Server.EntityModel.JobSummaryViewEntity GetJobSummary(global::System.Guid jobUuid);

		// Token: 0x06000356 RID: 854
		global::Motorola.CommonCPS.Server.EntityModel.JobSummaryViewEntity GetLastJobSummaryInJbc(global::System.Guid jbcUuid);

		// Token: 0x06000357 RID: 855
		global::Motorola.CommonCPS.Server.EntityModel.JobSummaryViewEntity GetLastJobSummary(bool? isRwJob);

		// Token: 0x06000358 RID: 856
		bool HasJobFailed(global::System.Guid jobContainerUuid);

		// Token: 0x06000359 RID: 857
		global::Motorola.CommonCPS.Server.EntityModel.Template GetTemplate(global::System.Guid templateUuid, bool isDeep = false);

		// Token: 0x0600035A RID: 858
		global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary ImportTemplate(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.Template temp);

		// Token: 0x0600035B RID: 859
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary> ListTemplateSummaries(int startIndex, int pageSize);

		// Token: 0x0600035C RID: 860
		global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary GetTemplateSummary(global::System.Guid templateUuid);

		// Token: 0x0600035D RID: 861
		bool CheckTemplateNameDuplicate(string templateName);

		// Token: 0x0600035E RID: 862
		global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary EditTemplate(global::System.Guid templateUuid, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.TemplateFieldType, object>> fieldValues, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet entitySet);

		// Token: 0x0600035F RID: 863
		global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary, global::Motorola.Common.CustomException.CommonErrorCode> UpdateLanguagePackOnRadios(global::System.Collections.Generic.List<global::System.Guid> radioUuids);

		// Token: 0x06000360 RID: 864
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Radio> GetReferencedRadioList(global::System.Guid templateUuid, int startIndex, int count, bool returnWorkingRadiosOnly = false);

		// Token: 0x06000361 RID: 865
		int GetReferencedRadiosCount(global::System.Collections.Generic.List<global::System.Guid> templateUuidList, bool isWorkingOnly = false, bool isFilterJob = true);

		// Token: 0x06000362 RID: 866
		global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.EntityModel.EntitySummary, global::Motorola.CommonCPS.Server.EntityModel.RadioSummary> GetReferencedRadiosbyTemplateList(global::System.Collections.Generic.List<global::System.Guid> templateUuidList, int startIndex, int count);

		// Token: 0x06000363 RID: 867
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.LanguageDetailInfo> GetTemplateLPDetailInfo(global::System.Guid TemplateUuid);

		// Token: 0x06000364 RID: 868
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.VADetailInfo> GetTemplateVADetailInfo(global::System.Guid TemplateUuid);

		// Token: 0x06000365 RID: 869
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.MatrixKey> ListMatrixKeys(global::Motorola.CommonCPS.Server.CommonDBConstants.MatrixKeyType keyType);

		// Token: 0x06000366 RID: 870
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.MatrixKey> ListMatrixKeys(global::Motorola.CommonCPS.Server.CommonDBConstants.MatrixKeyType keyType, int startIndex, int count);

		// Token: 0x06000367 RID: 871
		int GetMatrixKeysCount(global::Motorola.CommonCPS.Server.CommonDBConstants.MatrixKeyType keyType);

		// Token: 0x06000368 RID: 872
		global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.Server.EntityModel.MatrixKey> GetMatrixKeysByIdentifiers(global::System.Collections.Generic.List<string> identifiers, global::Motorola.CommonCPS.Server.CommonDBConstants.MatrixKeyType keyType);

		// Token: 0x06000369 RID: 873
		global::Motorola.CommonCPS.Server.EntityModel.PCRKeyData FillPcrKeyData(global::Motorola.CommonCPS.Server.EntityModel.PCRKeyData keyDataOnlyHasKeyId);

		// Token: 0x0600036A RID: 874
		global::Motorola.CommonCPS.Server.EntityModel.PCRKeyData GetPCRKeyIDsByConfigurationId(global::System.Guid configurationUuid);

		// Token: 0x0600036B RID: 875
		string GenerateHostID();

		// Token: 0x0600036C RID: 876
		void EnableFeature(global::Motorola.CommonCPS.Server.EntityModel.FeatureRequestObject referenceReq, byte[] capabilityResponse);

		// Token: 0x0600036D RID: 877
		global::Motorola.CommonCPS.Server.EntityModel.FeatureRequestObject GenerateFeatureRequest(string AID, int count);

		// Token: 0x0600036E RID: 878
		void CancelFeatureRequest(global::Motorola.CommonCPS.Server.EntityModel.FeatureRequestObject referenceRequest);

		// Token: 0x0600036F RID: 879
		global::Motorola.CommonCPS.Server.EntityModel.FeatureRequestObject GenerateRecoverRequest();

		// Token: 0x06000370 RID: 880
		void UpdateRadioFeatureComments(global::System.Guid radioFeatureUuid, string comments);

		// Token: 0x06000371 RID: 881
		void UpdateAppFeatureComments(string comments);

		// Token: 0x06000372 RID: 882
		int GetRadioFeatureCount(global::System.Guid? groupUuid, int featureType = 0);

		// Token: 0x06000373 RID: 883
		int GetCMSCRadioFeatureCount(global::System.Guid? groupUuid, int featureType = 0);

		// Token: 0x06000374 RID: 884
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary> GetRadioFeatures(global::System.Guid? groupUuid, int startIndex, int count, int featureType = 0);

		// Token: 0x06000375 RID: 885
		byte[] GetRadioFeatures(string radioSerialNumber);

		// Token: 0x06000376 RID: 886
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary> GetCMSCFeatures(global::System.Guid? groupUuid, int startIndex, int count, int featureType = 0);

		// Token: 0x06000377 RID: 887
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary> ListRadioFeatureSummaryByFeature(global::System.Guid? groupUuid, int startIndex, int count, int featureType = 0);

		// Token: 0x06000378 RID: 888
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary> ListRadioFeatureSummaryByCMSCFeature(global::System.Guid? groupUuid, int startIndex, int count, int featureType = 0);

		// Token: 0x06000379 RID: 889
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary> GetRadioFeatureDetailsByRadio(global::System.Guid radioUuid, int featureType = 0);

		// Token: 0x0600037A RID: 890
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary> GetRadioFeatureDetailsByFeature(global::System.Guid? groupUuid, int startIndex, int count, int featureName, int featureType = 0);

		// Token: 0x0600037B RID: 891
		int GetRadioFeatureDetailsByFeatureCount(global::System.Guid? groupUuid, int featureName, int featureType = 0);

		// Token: 0x0600037C RID: 892
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary> ListRadioFeatureSummaryByRadio(global::System.Guid? groupUuid, int startIndex, int count, int featureType = 0);

		// Token: 0x0600037D RID: 893
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary> ListRadioFeatureSummaryByCMSC(global::System.Guid? groupUuid, int startIndex, int count, int featureType = 0);

		// Token: 0x0600037E RID: 894
		int GetRadioFeatureSummaryByRadioCount(global::System.Guid? groupUuid, int featureType = 0);

		// Token: 0x0600037F RID: 895
		int GetRadioFeatureSummaryByCMSCCount(global::System.Guid? groupUuid, int featureType = 0);

		// Token: 0x06000380 RID: 896
		int ListRadioFeatureSummaryByRadio(global::System.Guid? groupUuid, int featureType = 0);

		// Token: 0x06000381 RID: 897
		int GetRadioFeatureSummaryByCMSCFeatureCount(global::System.Guid? groupUuid, int featureType = 0);

		// Token: 0x06000382 RID: 898
		int GetRadioFeaturesCount(global::System.Guid? groupUUID, int featureType = 0);

		// Token: 0x06000383 RID: 899
		int GetRadioFeatureIndex(global::System.Guid? groupUUID, global::System.Guid RadioLicenseUuid, string searchString, global::Motorola.CommonCPS.Server.EntityModel.OrderByOption[] orderByOptions);

		// Token: 0x06000384 RID: 900
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareCodeplugPair> FindPCRUpgradePackagesForVersion(string codeplugVersion, string firmwareVersion, string modelNumber, string tanapaNo, int region);

		// Token: 0x06000385 RID: 901
		global::System.Guid SaveNewTemplateForUpgrade(global::Motorola.CommonCPS.Server.EntityModel.Template temp);

		// Token: 0x06000386 RID: 902
		global::EntityModel.GenericModel.CFSUpdateResult ApplyUpdatedTemplateToRadio(global::System.Guid radioUuid, global::System.Guid templateGuid, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature> featureList, byte[] response, global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet entitySet, global::System.Collections.Generic.Dictionary<string, object> syncData = null);

		// Token: 0x06000387 RID: 903
		global::EntityModel.GenericModel.CFSUpdateResult RegisterLicenseToRadio(global::System.Guid radioUuid, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature> featureList, bool isSubmit, byte[] response, global::System.Guid batchJobContainerUuid);

		// Token: 0x06000388 RID: 904
		global::EntityModel.GenericModel.CFSUpdateResult RegisterLicenseToCMSC(global::System.Guid radioUuid, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature> featureList, bool isSubmit, byte[] response, global::System.Guid batchJobContainerUuid);

		// Token: 0x06000389 RID: 905
		int GetASTRODataProfileCount(global::System.Guid? groupUUID, string searchString);

		// Token: 0x0600038A RID: 906
		int GetTemplateCount();

		// Token: 0x0600038B RID: 907
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary> GetCompatibleTemplateSummaryList(global::System.Collections.Generic.List<global::System.Guid> radioUUIDList, int startIndex, int count);

		// Token: 0x0600038C RID: 908
		long GetCompatibleTemplateCount(global::System.Collections.Generic.List<global::System.Guid> radioUUIDList);

		// Token: 0x0600038D RID: 909
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary> ListRadioSummaryByIds(global::System.Collections.Generic.List<global::System.Guid> radioSummaryIds);

		// Token: 0x0600038E RID: 910
		byte[] GetFileContent(global::System.Guid fileUuid);

		// Token: 0x0600038F RID: 911
		global::Motorola.CommonCPS.Server.EntityModel.RMFile AddFileContent(byte[] data);

		// Token: 0x06000390 RID: 912
		global::Motorola.CommonCPS.Server.EntityModel.PCRPackage GetPCRPackageByNameVersion(global::Motorola.CommonCPS.Server.EntityModel.PCRPackageRequest packageReq);

		// Token: 0x06000391 RID: 913
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROPackage> GetASTROPackagesByTargetModelVersion(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType packageType, string targetModel, string packageVersion, bool isFreon, bool isEqual = true);

		// Token: 0x06000392 RID: 914
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware> GetAstroAmpFirmwares(global::Motorola.CommonCPS.Server.RMServerContract.DataQueryObjects.AstroAmpFirmwareQuery query);

		// Token: 0x06000393 RID: 915
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePackSummary> GetPCRLanguagePackLatestByFamily(global::Motorola.CommonCPS.Server.CommonDBConstants.LanguagePackFamily languagePackFamily);

		// Token: 0x06000394 RID: 916
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROPackage> ListASTROPackagesByCompatibleVersion(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType packageType, string compatibleVersion);

		// Token: 0x06000395 RID: 917
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PackageSummary> ListPackage(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType packageType, string modelFilter = null);

		// Token: 0x06000396 RID: 918
		global::System.Collections.Generic.List<string> ListLanguagePackNames(global::Motorola.CommonCPS.Server.CommonDBConstants.LanguagePackFamily? languagePackFamily);

		// Token: 0x06000397 RID: 919
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.PackageSummary> GetPackageSummaries(int startIndex, int length, global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType type, int? region);

		// Token: 0x06000398 RID: 920
		int GetPackagesCount(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType packageType, int? pairGroupRegion);

		// Token: 0x06000399 RID: 921
		global::Motorola.CommonCPS.Server.EntityModel.Package GetPackage(global::System.Guid packageUuid);

		// Token: 0x0600039A RID: 922
		global::Motorola.CommonCPS.Server.EntityModel.PBBApplicationShortcut GetPBBAppShortcutByPackageNameClassName(global::Motorola.CommonCPS.Server.EntityModel.PackageRequest packageReq);

		// Token: 0x0600039B RID: 923
		string DownLoadAstroPackage(global::System.Guid packageUuids);

		// Token: 0x0600039C RID: 924
		global::System.Collections.Generic.List<string> DownLoadPcrPackage(global::System.Collections.Generic.List<global::System.Guid> packageUuids);

		// Token: 0x0600039D RID: 925
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRPackageSummary> GetPCRUpgradePackages(global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ListPCRUpgradePackageFilter> filters);

		// Token: 0x0600039E RID: 926
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.LanguageDetailInfo> GetRadioLanguagesDetailInfo(global::System.Guid radioUUID);

		// Token: 0x0600039F RID: 927
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRDeviceCertificateDetailInfo> GetRadioPCRDeviceCertificateDetailInfo(global::System.Guid radioUUID);

		// Token: 0x060003A0 RID: 928
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary EditPCRDeviceCertificate(global::System.Guid radioUuid, global::System.Guid deviceCertUuid, global::System.Collections.Generic.Dictionary<string, object> fieldValues, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet set);

		// Token: 0x060003A1 RID: 929
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.VADetailInfo> GetRadioVADetailInfo(global::System.Guid radioUUID);

		// Token: 0x060003A2 RID: 930
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ApkApplicationDesc> GetRadioApkAppDetailInfo(global::System.Guid radioUUID);

		// Token: 0x060003A3 RID: 931
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.CertificatesDesc> GetRadioCertificateDetailInfo(global::System.Guid radioUUID);

		// Token: 0x060003A4 RID: 932
		global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.EntityModel.EntitySummary, global::Motorola.CommonCPS.Server.EntityModel.MatrixRadioSummary> GetMatchedReferenceRadiosForUpgrade(global::System.Collections.Generic.List<global::System.Guid> matrixTemplateUuidList, global::System.Guid PCRFirmwareCodeplugGroupUuid, bool isAllowDowngrade, int startIndex, int count);

		// Token: 0x060003A5 RID: 933
		int GetUpgradeMatchedMatrixRadiosCount(global::System.Collections.Generic.List<global::System.Guid> matrixTemplateUuidList, global::System.Guid pcrFWGroupUuid, bool isAllowDowngrade);

		// Token: 0x060003A6 RID: 934
		global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareCodeplugPair GetMatchedPCRFirmwareCodeplugPair(global::System.Guid pairGroupUuid, string modelNo, string tanapaNo);

		// Token: 0x060003A7 RID: 935
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PBBPackage> ListPBBPackages(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType packageType);

		// Token: 0x060003A8 RID: 936
		global::Motorola.CommonCPS.Server.EntityModel.Package AddPBBPackage(global::Motorola.CommonCPS.Server.EntityModel.PBBPackage pbbPackage);

		// Token: 0x060003A9 RID: 937
		global::System.Collections.Generic.List<global::System.Guid> GetReferencedRadioUuidListByPackageUuid(global::System.Guid packageUuid);

		// Token: 0x060003AA RID: 938
		void ResetRadioFeatures(global::System.Guid radioId, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> features, bool toOverride);

		// Token: 0x060003AB RID: 939
		void UpgradeRadioFeatures(global::System.Guid radioId, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> features);

		// Token: 0x060003AC RID: 940
		global::EntityModel.GenericModel.CFSUpdateResult RecoverRadioFeatures(global::System.Guid radioId, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> features, byte[] targetFlashCode, byte[] capacityResponse);

		// Token: 0x060003AD RID: 941
		void RestoreRadioFeatures(global::System.Guid radioId, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> features);

		// Token: 0x060003AE RID: 942
		global::EntityModel.GenericModel.CFSUpdateResult RestoreCMSCFeatures(global::System.Guid radioUuid, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature> featureList, bool isSubmit, byte[] response, global::System.Guid batchJobContainerUuid);

		// Token: 0x060003AF RID: 943
		void SubmitRadioFeatures(global::System.Guid radioId, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> features, byte[] targetFlashCode, global::Motorola.CommonCPS.Server.CommonDBConstants.LicenseFrom licenseFrom);

		// Token: 0x060003B0 RID: 944
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary> ListAvailableRadioForPurchase(global::System.Guid? groupUUID, global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureFilter filter, int startIndex, int count, int featureType = 0);

		// Token: 0x060003B1 RID: 945
		int GetAvailableRadioForPurchaseCount(global::System.Guid? groupUUID, global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureFilter filter, global::System.Collections.Generic.List<string> selectedSerialNumbers, int featureType = 0);

		// Token: 0x060003B2 RID: 946
		global::System.Collections.Generic.List<string> ListFeatureMatchedRadios(global::System.Guid? groupUUID, global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureFilter filter, global::System.Collections.Generic.List<string> selectedSerialNumbers, string searchString);

		// Token: 0x060003B3 RID: 947
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary> ListAvailableCMSCForPurchase(global::System.Guid? groupUUID, global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureFilter filter, int startIndex, int count, int featureType = 0);

		// Token: 0x060003B4 RID: 948
		int GetAvailableCMSCForPurchaseCount(global::System.Guid? groupUUID, global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureFilter filter, global::System.Collections.Generic.List<string> selectedSerialNumbers, int featureType = 0);

		// Token: 0x060003B5 RID: 949
		global::EntityModel.GenericModel.CFSUpdateResult RecoverCMSCFeatures(global::System.Guid radioId, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> features, string hostID, byte[] targetFlashCode, byte[] capacityResponse);

		// Token: 0x060003B6 RID: 950
		global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary, global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary> ApplyTemplateToRadio(global::System.Guid batchJobContainerUuid, global::System.Guid templateUuid, global::Motorola.CommonCPS.Server.EntityModel.RadioInfoForApplyTemplate radioInfo, string batchOpName, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet entitySet, bool returnTemplate = true, bool returnRadioBase = true);

		// Token: 0x060003B7 RID: 951
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary AddRadio(global::Motorola.CommonCPS.Server.EntityModel.Radio newRadio);

		// Token: 0x060003B8 RID: 952
		global::Motorola.CommonCPS.Server.EntityModel.Radio CreateTempRadioForCompare(global::Motorola.CommonCPS.Server.EntityModel.Radio radio);

		// Token: 0x060003B9 RID: 953
		global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary UpgradeAPXTemplateLanguagePack(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.EntitySummary templateInfo, global::System.Guid LPGuid, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.EntitySummary> entitySummaryList, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet> validateSetList);

		// Token: 0x060003BA RID: 954
		global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack GetLatestASTROLPPackagesByFirmwareVersion(string firmwareVersion, string LPID);

		// Token: 0x060003BB RID: 955
		bool DeletePackage(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.EntitySummary packageUuid, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet entitySetList);

		// Token: 0x060003BC RID: 956
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary CancelJob(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.EntitySummary entitySummary, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateSet);

		// Token: 0x060003BD RID: 957
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary CompleteJob(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.EntitySummary entitySummary, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateSet);

		// Token: 0x060003BE RID: 958
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.Radio> GetRadioList(global::System.Collections.Generic.IList<global::System.Guid> radioIdList, bool isDeep = false);

		// Token: 0x060003BF RID: 959
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.Radio> GetRadiosForOtarProfileValidation(global::System.Collections.Generic.IList<global::System.Guid> radioIdList, int pageSize = 50);

		// Token: 0x060003C0 RID: 960
		global::Motorola.CommonCPS.Server.EntityModel.Radio GetRadio(global::System.Guid radioId, bool isDeep = false);

		// Token: 0x060003C1 RID: 961
		int GetRadioCount(global::System.Guid? groupUuid, global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode workMode, bool includeSubGroups);

		// Token: 0x060003C2 RID: 962
		global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary SelectLanguagePacksForPCR(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.EntitySummary templateInfo, global::System.Collections.Generic.List<global::System.Guid> selectedLanguagePacks, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.EntitySummary> entitySummaryList, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet> validateSetList);

		// Token: 0x060003C3 RID: 963
		global::Motorola.CommonCPS.Server.EntityModel.Package ImportPackage(global::Motorola.CommonCPS.Server.EntityModel.Package packageReq);

		// Token: 0x060003C4 RID: 964
		global::Motorola.CommonCPS.Server.EntityModel.PackageSummary ImportBatchPackage(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.Package package, string jobDescription);

		// Token: 0x060003C5 RID: 965
		global::Motorola.CommonCPS.Server.EntityModel.PackageSummary ImportBatchAstroFirmware(global::System.Guid batchJobContainerUuid, global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware> package, string jobDescription);

		// Token: 0x060003C6 RID: 966
		global::Motorola.CommonCPS.Server.EntityModel.Package PackageExist(global::Motorola.CommonCPS.Server.EntityModel.Package software);

		// Token: 0x060003C7 RID: 967
		global::Motorola.CommonCPS.Server.EntityModel.PackageSummary UpdatePackage(global::Motorola.CommonCPS.Server.EntityModel.PackageSummary summary, global::Motorola.CommonCPS.Server.CommonDBConstants.PackageColumns column);

		// Token: 0x060003C8 RID: 968
		global::Motorola.CommonCPS.Server.EntityModel.PackageSummary UpdatePBBPackage(global::Motorola.CommonCPS.Server.EntityModel.PackageSummary summary, global::Motorola.CommonCPS.Server.CommonDBConstants.PackageColumns column);

		// Token: 0x060003C9 RID: 969
		global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary SaveTemplate(global::Motorola.CommonCPS.Server.EntityModel.Template temp, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet entitySet);

		// Token: 0x060003CA RID: 970
		bool DeleteDevice(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.Radio device, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet);

		// Token: 0x060003CB RID: 971
		global::Motorola.CommonCPS.Server.EntityModel.MatrixKey AddMatrixKey(global::Motorola.CommonCPS.Server.EntityModel.MatrixKey key);

		// Token: 0x060003CC RID: 972
		global::Motorola.CommonCPS.Server.EntityModel.MatrixKey EditMatrixKey(global::System.Guid keyUuid, global::Motorola.CommonCPS.Server.CommonDBConstants.MatrixKeyType keyType, object changedField, global::Motorola.CommonCPS.Server.CommonDBConstants.KeyFieldType fieldType, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet set);

		// Token: 0x060003CD RID: 973
		bool DeleteMatrixKey(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.MatrixKey key);

		// Token: 0x060003CE RID: 974
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary DiscardCodeplugChanges(global::System.Guid? batchJobContainerUuid, global::System.Guid radioUuid, string serialNumber, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet set);

		// Token: 0x060003CF RID: 975
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary DiscardCodeplugAndRadioFeatureChanges(global::System.Guid? batchJobContainerUuid, global::System.Guid radioUuid, string serialNumber, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet set, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature> originalRadioFeature);

		// Token: 0x060003D0 RID: 976
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary Reset(global::System.Guid radioUuid, int? RadioID, int? CAI, string password, global::Motorola.CommonCPS.Server.EntityModel.LinkType? linkType, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet);

		// Token: 0x060003D1 RID: 977
		global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary EditConfiguration(global::System.Guid configUuid, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.ConfigurationFieldType, object>> fieldValues, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet set);

		// Token: 0x060003D2 RID: 978
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary EditRadio(global::System.Guid radioUuid, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object>> fieldValues, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet set);

		// Token: 0x060003D3 RID: 979
		global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary EditAPXRadioProfile(global::System.Guid radioUuid, global::System.Guid profileUuid, global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.CommonDBConstants.ProfileFieldType, object> fieldValues, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet set);

		// Token: 0x060003D4 RID: 980
		global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystemSummary EditAPXRadioSystem(global::System.Guid radioUuid, global::System.Guid systemUuid, global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.CommonDBConstants.RadioSystemFieldType, object> fieldValues, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet set);

		// Token: 0x060003D5 RID: 981
		global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO EditASTROOTARProfile(global::System.Guid radioUuid, global::System.Guid otarUuid, global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.CommonDBConstants.OtarFieldType, object> fieldValues, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet set);

		// Token: 0x060003D6 RID: 982
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary RadioIdentityTransfer(global::System.Guid radioUuid, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Guid, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>> transferRadioIdentityRecords, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet entitySet);

		// Token: 0x060003D7 RID: 983
		bool DeleteTemplate(global::System.Guid? batchJobContainer, global::System.Guid templateUuid, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet set, string templateName = null);

		// Token: 0x060003D8 RID: 984
		global::Motorola.CommonCPS.Server.EntityModel.RMFile GetFile(global::System.Guid fileUuid);

		// Token: 0x060003D9 RID: 985
		void DeleteFile(global::System.Guid fileUuid);

		// Token: 0x060003DA RID: 986
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary QueryAndUpdateRadio(global::System.Guid batchJobContainerUuid, global::System.Guid radioUuid, int? keyType, int? systemOwnerKeyId, bool? writeProtected, bool? askRequired, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet);

		// Token: 0x060003DB RID: 987
		void SubmitRadioFeaturesForRadios(global::System.Guid operationGuid, global::System.Collections.Generic.IList<global::System.Guid> templateUuids, global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet> sets);

		// Token: 0x060003DC RID: 988
		void UpdateCodeplugAndLicense(string operationGuid, global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.Radio> radioList, global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest>> radioFeatureRequestList, global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet> validateSetList);

		// Token: 0x060003DD RID: 989
		void RecoverCodeplugAndLicense(string operationGuid, global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.Radio> radioList, global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest>> radioFeatureRequestList, global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet> validateSetList);

		// Token: 0x060003DE RID: 990
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Template> GetTemplateListByNameList(global::System.Collections.Generic.List<string> templateNameList);

		// Token: 0x060003DF RID: 991
		global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob AddBatchJob(global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob job);

		// Token: 0x060003E0 RID: 992
		global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJobContainer AddBatchJobContainer(global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJobContainer job);

		// Token: 0x060003E1 RID: 993
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary ImportRadio(global::Motorola.CommonCPS.Server.EntityModel.ImportRadioBatchJobParameter para);

		// Token: 0x060003E2 RID: 994
		global::Motorola.CommonCPS.Server.EntityModel.ReadWriteJob AddReadWriteJob(global::System.Guid batchJobContainerUuid, global::System.Guid? readWriteJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.JobRequest jr, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validSet);

		// Token: 0x060003E3 RID: 995
		global::Motorola.CommonCPS.Server.EntityModel.Template ImportTemplate(global::Motorola.CommonCPS.Server.EntityModel.Template temp, string currentFWVersion = null, bool? isPortable = null, string lpIDUpgradeTo = null);

		// Token: 0x060003E4 RID: 996
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary UpgradeRadio(global::System.Guid? batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.RadioUpgradeRequest request, string jobName);

		// Token: 0x060003E5 RID: 997
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary> GetRadioListUsingConfig(global::System.Guid configUuid, int startIndex, int count);

		// Token: 0x060003E6 RID: 998
		int GetRadiosCountUsingConfig(global::System.Guid configUuid);

		// Token: 0x060003E7 RID: 999
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary> GetRadioListUsingConfigWithWorkingCodeplug(global::System.Guid configUuid, int startIndex, int count);

		// Token: 0x060003E8 RID: 1000
		int GetRadiosCountUsingConfigWithWorkingCodeplug(global::System.Guid configUuid);

		// Token: 0x060003E9 RID: 1001
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary UpgradeRadioCodeplugVersion(global::System.Guid batchJobContainerUuid, global::System.Guid radioUuid, global::Motorola.CommonCPS.Server.GenericModel.ResultOfUpgradeCPVersion _ResultOfUpgradeCPVersion, string jobName, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet set);

		// Token: 0x060003EA RID: 1002
		bool DeleteConfiguration(global::System.Guid batchJobContainerUuid, global::System.Guid configUuid, string configName, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet, global::System.Collections.Generic.List<string> SharedSets);

		// Token: 0x060003EB RID: 1003
		bool DeleteConfiguration(global::System.Guid configUuid, string configName, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet, global::System.Collections.Generic.List<string> SharedSets);

		// Token: 0x060003EC RID: 1004
		global::Motorola.CommonCPS.Server.EntityModel.Configuration AddConfiguration(global::Motorola.CommonCPS.Server.EntityModel.Configuration configration);

		// Token: 0x060003ED RID: 1005
		global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.Configuration, global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary>> AddConfiguration(global::Motorola.CommonCPS.Server.EntityModel.Configuration configration, global::Motorola.CommonCPS.Server.EntityModel.BLEditSaveDataArg saveData);

		// Token: 0x060003EE RID: 1006
		global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary CopyConfiguration(global::System.Guid jobContainerUuid, global::System.Guid configUuid, string proposedConfigName, bool isDeep, string setSuffix, global::System.Collections.Generic.HashSet<string> forceCopyTypes);

		// Token: 0x060003EF RID: 1007
		global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary ImportConfiguration(global::System.Guid jobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.Configuration config, global::Motorola.CommonCPS.Server.EntityModel.SyncData syncData, string setSuffix);

		// Token: 0x060003F0 RID: 1008
		global::System.Collections.Generic.IDictionary<string, int> GetSetCount(global::System.Collections.Generic.List<string> setTypeList);

		// Token: 0x060003F1 RID: 1009
		global::System.Collections.Generic.IDictionary<string, int> GetSetCount(global::System.Collections.Generic.List<string> setTypeList, global::System.Guid parentId);

		// Token: 0x060003F2 RID: 1010
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary> GetConfigurations(int pageNumber, int pageSize);

		// Token: 0x060003F3 RID: 1011
		bool IsConfiguationReadOnly(global::System.Guid guid);

		// Token: 0x060003F4 RID: 1012
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary> ListMatchedConfigurations(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? fm, global::Motorola.CommonCPS.Server.EntityModel.GenericModel.ParameterClasses.FilterParameter_OfListCompatibleConfiguration filterParameter, int startIndex, int pageSize);

		// Token: 0x060003F5 RID: 1013
		int GetMatchedConfigurationCount(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? fm, global::Motorola.CommonCPS.Server.EntityModel.GenericModel.ParameterClasses.FilterParameter_OfListCompatibleConfiguration filterParameter);

		// Token: 0x060003F6 RID: 1014
		global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary GetConfigurationSummaryById(global::System.Guid configUuid);

		// Token: 0x060003F7 RID: 1015
		global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary GetConfigurationSummaryByName(string configName);

		// Token: 0x060003F8 RID: 1016
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary> ListConfigurationsSetAssignedTo(global::System.Guid topSetUuid, int startIndex, int pageSize);

		// Token: 0x060003F9 RID: 1017
		int GetConfigurationsSetAssignedToCount(global::System.Guid topSetUuid);

		// Token: 0x060003FA RID: 1018
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary> GetSetSummaries(global::System.Guid? parentId, global::System.Collections.Generic.List<string> setTypeList, int startIndex, int pageSize);

		// Token: 0x060003FB RID: 1019
		global::Motorola.CommonCPS.Server.EntityModel.RecordSummary GetSetSummary(global::System.Guid setUuid);

		// Token: 0x060003FC RID: 1020
		global::Motorola.CommonCPS.Server.EntityModel.RecordSummary GetSetSummary(string setType, string setName);

		// Token: 0x060003FD RID: 1021
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary> GetSetSummaries(global::System.Collections.Generic.List<global::System.Guid> setUuids);

		// Token: 0x060003FE RID: 1022
		global::Motorola.CommonCPS.Server.EntityModel.RecordSummary GetParantSetSummary(global::System.Guid setUuid);

		// Token: 0x060003FF RID: 1023
		global::Motorola.CommonCPS.Server.EntityModel.RecordSummary GetTopSetSummary(string topSetType, global::System.Guid setUuid);

		// Token: 0x06000400 RID: 1024
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary> ListRelatedSetById(global::System.Guid setId, bool isRecursive = true);

		// Token: 0x06000401 RID: 1025
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary> GetReferingSetSummaries(global::System.Guid setId, global::Motorola.CommonCPS.Server.CommonDBConstants.RelationType relationType);

		// Token: 0x06000402 RID: 1026
		global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Field>>> ListDBRecordFields(global::System.Guid? parentUuid, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, bool>>>> setTypesAndFieldName, int startIndex, int pageSize);

		// Token: 0x06000403 RID: 1027
		global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Field>> GetDBRecordFieldsByUuid(global::System.Guid setUuid, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, bool>> fieldNameList);

		// Token: 0x06000404 RID: 1028
		global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Field>>> GetDBRecordsFieldsByUuids(global::System.Collections.Generic.List<global::System.Guid> setUuids, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, bool>> fieldNameList);

		// Token: 0x06000405 RID: 1029
		global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.IList<string>>> GenerateDefaultSetName(global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<string, int>> setTypeList, bool generateForPreSharedKeys = false);

		// Token: 0x06000406 RID: 1030
		bool DeleteTelePortSet(global::System.Guid guid, global::System.Guid setUuid, string setName, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet);

		// Token: 0x06000407 RID: 1031
		global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DatabaseSizeSummary GetDatabaseSizeSummary();

		// Token: 0x06000408 RID: 1032
		global::Motorola.CommonCPS.Server.EntityModel.RecordSummary AddTelePortSet(global::Motorola.CommonCPS.Server.EntityModel.DBNode dbNode);

		// Token: 0x06000409 RID: 1033
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary> ModifyDBRecords(global::Motorola.CommonCPS.Server.EntityModel.BLEditSaveDataArg saveData);

		// Token: 0x0600040A RID: 1034
		global::Motorola.CommonCPS.Server.EntityModel.Configuration LoadConfiguration(string id);

		// Token: 0x0600040B RID: 1035
		global::Motorola.CommonCPS.Server.EntityModel.DBNode GetDBNodeContainedByConfiguration(global::System.Guid ConfigurationUuid, string TopSetType);

		// Token: 0x0600040C RID: 1036
		global::System.Guid? GetWorkingConfigurationId(global::System.Guid radioId);

		// Token: 0x0600040D RID: 1037
		global::Motorola.CommonCPS.Server.EntityModel.DBNode GetDBRecord(global::System.Guid? nullable, bool recursive);

		// Token: 0x0600040E RID: 1038
		global::Motorola.CommonCPS.Server.EntityModel.DBNode GetDBRecords(global::System.Collections.Generic.List<global::System.Guid> uuidList, bool recursive);

		// Token: 0x0600040F RID: 1039
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary> GetDBRecordsSummaryListByParentAndChildFieldName(global::System.Collections.Generic.List<global::System.Guid> parent, string navigationFieldName, int startIndex, int pageSize);

		// Token: 0x06000410 RID: 1040
		global::Motorola.CommonCPS.Server.EntityModel.RecordSummary GetDBRecordSummaryListByParentAndChildFieldName(global::System.Guid parent, string navigationFieldName);

		// Token: 0x06000411 RID: 1041
		global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary, global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary> ApplyConfiguration(global::System.Guid opGuid, global::System.Guid ConfigurationUuid, global::Motorola.CommonCPS.Server.EntityModel.RadioInfoForApplyConfiguration radioInfo, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateSet);

		// Token: 0x06000412 RID: 1042
		global::Motorola.CommonCPS.Server.EntityModel.GenericModel.ConfigurationArgs.SaveConfirmResult GetSaveConfirmResult(global::Motorola.CommonCPS.Server.EntityModel.BLEditSaveDataArg saveData);

		// Token: 0x06000413 RID: 1043
		global::Motorola.CommonCPS.Server.EntityModel.GenericModel.HomeSetArgs.SaveHomeSetConfirmResult GetSaveHomeSetConfirmResult(global::System.Guid ChangeImpactedHomeSetUuid);

		// Token: 0x06000414 RID: 1044
		bool UpdatePBBCodeplugForceWriteHomeset(global::System.Guid codeplugUuid, bool IsForceWriteHomeSet);

		// Token: 0x06000415 RID: 1045
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary> GetSetAssginToAllConfigsConfirmResult(global::System.Guid setUuid, int pageNumber, int pageSize);

		// Token: 0x06000416 RID: 1046
		global::Motorola.CommonCPS.Server.EntityModel.GenericModel.ConfigurationArgs.SaveAsResult CopySet(global::System.Guid setUuid, global::Motorola.CommonCPS.Server.CommonDBConstants.CopySetOptions option, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily, int>> maxNumberList, global::Motorola.CommonCPS.Server.EntityModel.BLEditSaveDataArg saveData, bool isNeedSync, global::Motorola.CommonCPS.Server.EntityModel.RecordSummary currentConfig, string newSetName, global::System.Collections.Generic.HashSet<string> forceCopyTypes = null);

		// Token: 0x06000417 RID: 1047
		global::Motorola.CommonCPS.Server.EntityModel.GenericModel.ConfigurationArgs.SaveAsResult CopyTopSet(global::Motorola.CommonCPS.Server.EntityModel.CopyTopSetParameter para);

		// Token: 0x06000418 RID: 1048
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary> GetConfigurationsSetsNumberReachMax(string setName, int maxNumber);

		// Token: 0x06000419 RID: 1049
		void ForceToSyncRadioData(global::System.Guid RadioUuid);

		// Token: 0x0600041A RID: 1050
		global::Motorola.CommonCPS.Server.EntityModel.GenericModel.ConfigurationArgs.SaveResultForPerConfiguration SaveForPerConfiguration(global::Motorola.CommonCPS.Server.EntityModel.GenericModel.ConfigurationArgs.SaveDataForPerConfiguration saveData);

		// Token: 0x0600041B RID: 1051
		int GetCandidateMVORadioSummaryCount();

		// Token: 0x0600041C RID: 1052
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary> ListCandidateMVORadioSummary(int startIndex, int length);

		// Token: 0x0600041D RID: 1053
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary ApplyMVO(global::Motorola.CommonCPS.Server.EntityModel.ApplyMVOBatchJobParameter parameter);

		// Token: 0x0600041E RID: 1054
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary ImportRadioFromCSV(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest csvRequest, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet);

		// Token: 0x0600041F RID: 1055
		void AddandApplyCompareConfigurationToRadio(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.EntityModel.Configuration configuration);

		// Token: 0x06000420 RID: 1056
		global::Motorola.CommonCPS.Server.EntityModel.RMFile AddFile(string filePath, global::Motorola.CommonCPS.Server.CommonDBConstants.FileType fileType = global::Motorola.CommonCPS.Server.CommonDBConstants.FileType.Default);

		// Token: 0x06000421 RID: 1057
		global::Motorola.CommonCPS.Server.EntityModel.RMFile AddFile(byte[] fileData, global::Motorola.CommonCPS.Server.CommonDBConstants.FileType fileType = global::Motorola.CommonCPS.Server.CommonDBConstants.FileType.Default);

		// Token: 0x06000422 RID: 1058
		void EnableFeature_CLL(global::Motorola.CommonCPS.Server.EntityModel.FeatureResponseObject referenceReq, string hostID, byte[] capabilityResponse);

		// Token: 0x06000423 RID: 1059
		void EnableFeature_Radio(string radioID, byte[] capabilityResponse);

		// Token: 0x06000424 RID: 1060
		global::Motorola.CommonCPS.Server.EntityModel.SendDeviceRequest CreateRadioActivationRequest_CLL(string hostID, string computerName, string AID, int count);

		// Token: 0x06000425 RID: 1061
		global::EntityModel.GenericModel.CFSUpdateResult CfsUpgradeRadio(global::Motorola.CommonCPS.Server.EntityModel.CfsUpgradeRadioBatchJobParameter cfsUpgradeRadioBatchJobParameter);

		// Token: 0x06000426 RID: 1062
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary ResetIdentifiers(global::System.Guid radioID, int? RadioID, int? CAI, string password, global::Motorola.CommonCPS.Server.EntityModel.LinkType? linkType, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet);

		// Token: 0x06000427 RID: 1063
		global::Motorola.CommonCPS.Server.EntityModel.RecordSummary GetConfigRecordByName(string configName);

		// Token: 0x06000428 RID: 1064
		void DeleteJobContainer(global::System.Guid batchJobContainerUuid, global::System.Guid deletingJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet, string jobContainerName);

		// Token: 0x06000429 RID: 1065
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary ApplyGeneralPackagesToRadio(global::System.Guid batchJobContainerUuid, global::System.Guid radioUuid, global::System.Collections.Generic.List<global::System.Guid> packageUuids, global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType type, string packageVersion, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySets);

		// Token: 0x0600042A RID: 1066
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary ApplyPBBPackagesToRadio(global::System.Guid batchJobContainerUuid, global::System.Guid radioUuid, global::System.Collections.Generic.List<global::System.Guid> packageUuids, global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType type, string packageVersion, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySets);

		// Token: 0x0600042B RID: 1067
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary UpdatePBBPackagesToRadio(global::System.Guid batchJobContainerUuid, global::System.Guid radioUuid, global::System.Collections.Generic.List<global::System.Guid> packageUuids, global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType type, string packageVersion, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySets);

		// Token: 0x0600042C RID: 1068
		byte[] GetAppLicenses();

		// Token: 0x0600042D RID: 1069
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ApplicationFeatureSummary> ListApplicationFeatureSummaries();

		// Token: 0x0600042E RID: 1070
		global::Motorola.CommonCPS.Server.EntityModel.ApplicationFeatureSummary UpdateApplicationFeatureComments(string featureName, string comments, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet set);

		// Token: 0x0600042F RID: 1071
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RadioManagementLicenseInfo> GetRadioManagementFeature();

		// Token: 0x06000430 RID: 1072
		global::Motorola.CommonCPS.Server.EntityModel.PBBPassword AddPBBPassword(global::Motorola.CommonCPS.Server.EntityModel.PBBPassword password);

		// Token: 0x06000431 RID: 1073
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PBBPassword> ListPBBPasswords();

		// Token: 0x06000432 RID: 1074
		global::Motorola.CommonCPS.Server.EntityModel.PBBPassword GetPBBPassword(global::System.Guid passwordUuid);

		// Token: 0x06000433 RID: 1075
		global::Motorola.CommonCPS.Server.EntityModel.PBBPassword GetPBBPasswordById(string id);

		// Token: 0x06000434 RID: 1076
		void UpdatePBBPassword(global::Motorola.CommonCPS.Server.EntityModel.PBBPassword password);

		// Token: 0x06000435 RID: 1077
		bool DeletePBBPassword(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.PBBPassword password);

		// Token: 0x06000436 RID: 1078
		void EnableJobStatistic();

		// Token: 0x06000437 RID: 1079
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.JobStatistic> GetJobStatistics(global::System.Collections.Generic.List<global::System.Guid> jobUuid);

		// Token: 0x06000438 RID: 1080
		global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.Server.EntityModel.OptionsCollection> ListOptionDataById(global::System.Collections.Generic.List<global::System.Guid> uuids);

		// Token: 0x06000439 RID: 1081
		global::System.Collections.Generic.List<string> GetUserPermissions();

		// Token: 0x0600043A RID: 1082
		global::Motorola.CommonCPS.Server.EntityModel.RMFile PrepareProvisioningTable(global::System.Guid radioUuid);

		// Token: 0x0600043B RID: 1083
		global::Motorola.CommonCPS.Server.EntityModel.LESystemLinkInfo GetPCRLESystemLinkInfo(string serialNum);

		// Token: 0x0600043C RID: 1084
		global::Motorola.CommonCPS.Server.EntityModel.SystemInfo GetPCRDMR3SystemInfo(string serialNum);

		// Token: 0x0600043D RID: 1085
		global::System.Collections.Generic.IList<string> GetSystemKeyPermissions();

		// Token: 0x0600043E RID: 1086
		bool IsSessionOutOfTime(string templateID);

		// Token: 0x0600043F RID: 1087
		void RefreshSessionTimer(string templateID);

		// Token: 0x06000440 RID: 1088
		int GetWaitCount(string templateID);

		// Token: 0x06000441 RID: 1089
		void SetWaitCount(string templateID, int newValue);

		// Token: 0x06000442 RID: 1090
		global::Motorola.CommonCPS.Server.EntityModel.MigrationInfo GetMigrationInfo();

		// Token: 0x06000443 RID: 1091
		void MigrateRadioAndCommonResource(global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? regionName, bool migrateHistoryPBAs = false);

		// Token: 0x06000444 RID: 1092
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MigrationTemplateInfo> ListMigrationTemplateList();

		// Token: 0x06000445 RID: 1093
		global::Motorola.CommonCPS.Server.EntityModel.MigrationPBBConfigurationAndWiFi GetMigrationPBBFusionCfgWifi();

		// Token: 0x06000446 RID: 1094
		void SaveMigrationTemplateSelctions(global::System.Collections.Generic.List<global::System.Guid> abandonedTemplateUuidList);

		// Token: 0x06000447 RID: 1095
		global::Motorola.CommonCPS.Server.EntityModel.Template MigrateTemplate(global::Motorola.CommonCPS.Server.EntityModel.MigrateTemplateParameter parameter);

		// Token: 0x06000448 RID: 1096
		global::Motorola.CommonCPS.Server.EntityModel.Radio MigrateTemplateDataToRadio(global::System.Guid batchJobContainerUuid, global::System.Guid radioUuid, global::System.Guid templateUuid, string batchOpJobName, bool applyToCurrentCP = false);

		// Token: 0x06000449 RID: 1097
		global::Motorola.CommonCPS.Server.CommonDBConstants.MigrationStatus MigrateTemplateAndApplyTemplateDone();

		// Token: 0x0600044A RID: 1098
		int ScheduleMigrationJob();

		// Token: 0x0600044B RID: 1099
		void TurnOffMigration(string rmVersion);

		// Token: 0x0600044C RID: 1100
		void TransferArchiveFileById(global::System.Guid achiveUuid);

		// Token: 0x0600044D RID: 1101
		global::Motorola.CommonCPS.Server.EntityModel.ClearDataProgressReport GetClearDataProgressReport();

		// Token: 0x0600044E RID: 1102
		void ClearLegacyData();

		// Token: 0x0600044F RID: 1103
		global::Motorola.CommonCPS.Server.EntityModel.MigrationEstimatedData CalculateMigrationTimeAndSize();

		// Token: 0x06000450 RID: 1104
		void SwapRadioWorkingCodeplug(string serialNumber);

		// Token: 0x06000451 RID: 1105
		global::Motorola.CommonCPS.Server.CommonDBConstants.MigrationStatus AbortMigration();

		// Token: 0x06000452 RID: 1106
		void UpdateMigrationStatus(global::Motorola.CommonCPS.Server.CommonDBConstants.MigrationStatus status);

		// Token: 0x06000453 RID: 1107
		global::Motorola.CommonCPS.Server.EntityModel.RadioConvertionResult ConvertRadioFromTModeToCMode(global::Motorola.CommonCPS.Server.EntityModel.RadioConvertionOpJobParameter parameter);

		// Token: 0x06000454 RID: 1108
		global::Motorola.CommonCPS.Server.EntityModel.ConvertTRadioInfo GetConvertTRadioFileInfo(global::Motorola.CommonCPS.Server.EntityModel.RadioConversionRelationshipParameter parameter);

		// Token: 0x06000455 RID: 1109
		global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary ImportCFGFromTemplate(global::Motorola.CommonCPS.Server.EntityModel.ImportCFGFromTemplateOpJobParameter parameter);

		// Token: 0x06000456 RID: 1110
		global::Motorola.CommonCPS.Server.EntityModel.ConvertRadioFromCModeToTModeResult ConvertRadioFromCModeToTMode(global::Motorola.CommonCPS.Server.EntityModel.ConvertRadioFromCModeToTModeOpJobParameter parameter);

		// Token: 0x06000457 RID: 1111
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem> ListAllIPProgramSystems();

		// Token: 0x06000458 RID: 1112
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem> ListIPProgramSystems(int startIndex, int length);

		// Token: 0x06000459 RID: 1113
		global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem GetIPProgramSystem(global::System.Guid sysUuid);

		// Token: 0x0600045A RID: 1114
		global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem GetIPProgramSystemByAlias(string sysAlias);

		// Token: 0x0600045B RID: 1115
		int GetIPProgramSystemsCount();

		// Token: 0x0600045C RID: 1116
		global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem AddIPProgramSystem(global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem sys);

		// Token: 0x0600045D RID: 1117
		void UpdateIPProgramSystem(global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem sys);

		// Token: 0x0600045E RID: 1118
		bool DeleteIPProgramSystem(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem sys);

		// Token: 0x0600045F RID: 1119
		global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary, global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem> ApplyIPProgramSystem(global::System.Guid batchOpGuid, global::System.Guid sysUuid, global::Motorola.CommonCPS.Server.EntityModel.RadioInfoForApplyIPProgramSystem radioInfo, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateSet);

		// Token: 0x06000460 RID: 1120
		global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem EditIPProgramSystem(global::System.Guid keyUuid, object changedField, global::Motorola.CommonCPS.Server.CommonDBConstants.IPProgramSystemFieldType fieldType, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet set);

		// Token: 0x06000461 RID: 1121
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem> ListMatchedIPProgramSystems(global::System.Collections.Generic.List<global::System.Guid> radioUUIDList, int startIndex, int pageSize);

		// Token: 0x06000462 RID: 1122
		int GetMatchedIPProgramSystemCount(global::System.Collections.Generic.List<global::System.Guid> radioUUIDList);

		// Token: 0x06000463 RID: 1123
		string GetSetInfo(string setType);

		// Token: 0x06000464 RID: 1124
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DMR3System> GetAllDMR3Systems();

		// Token: 0x06000465 RID: 1125
		int GetALLSACRecordsCount(global::System.Guid systemUUID);

		// Token: 0x06000466 RID: 1126
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SACRecordSummary> GetALLSACRecords(global::System.Guid systemUUID, int startIndex, int length);

		// Token: 0x06000467 RID: 1127
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SACRecordSummary> GetALLSACRecordsBySerial(global::System.Guid systemUUID, string serialNumber);

		// Token: 0x06000468 RID: 1128
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SACRecordSummary> GetSACRecordsBySerial(string radioSerial);

		// Token: 0x06000469 RID: 1129
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SACRecordSummary> GetSACRecordsByDeviceID(global::System.Guid systemUUID, int deviceID);

		// Token: 0x0600046A RID: 1130
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SACSiteSelection> GetAllSACSiteSelection(global::System.Guid systemUUID);

		// Token: 0x0600046B RID: 1131
		global::Motorola.CommonCPS.Server.EntityModel.SACSiteSelection GetSACSiteSelection(global::System.Guid systemUUID, global::System.Guid siteSelUuid);

		// Token: 0x0600046C RID: 1132
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DMR3Site> GetDMR3SitesBySystem(global::System.Guid systemUUID);

		// Token: 0x0600046D RID: 1133
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DMR3Site> GetSelDMR3Sites(global::System.Guid sACSiteSelUUID);

		// Token: 0x0600046E RID: 1134
		bool DeleteSACRecord(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.SACRecordSummary sacRecord);

		// Token: 0x0600046F RID: 1135
		global::Motorola.CommonCPS.Server.EntityModel.SACRecordSummary AddSACRecord(global::Motorola.CommonCPS.Server.EntityModel.SACRecord modifySAC);

		// Token: 0x06000470 RID: 1136
		global::Motorola.CommonCPS.Server.EntityModel.SACRecordSummary EditSACRecord(global::Motorola.CommonCPS.Server.EntityModel.SACRecord sacRecord, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.SACRecordFieldType, object>> changedFieldValePair, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet);

		// Token: 0x06000471 RID: 1137
		global::Motorola.CommonCPS.Server.EntityModel.SACRecordSummary EditSACRecordBat(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.SACRecord sacRecord, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.SACRecordFieldType, object>> changedFieldValePair, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet);

		// Token: 0x06000472 RID: 1138
		int GetALLTGSARecordsCount(global::System.Guid systemUUID);

		// Token: 0x06000473 RID: 1139
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.TGSARecord> GetALLTGSARecords(global::System.Guid systemUUID, int startIndex, int count);

		// Token: 0x06000474 RID: 1140
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.TGSASiteSelection> GetAllTGSASiteSelection(global::System.Guid systemUUID);

		// Token: 0x06000475 RID: 1141
		bool UpdateSACSiteSelectionBatch(global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SACSiteSelection> sacSiteSelections);

		// Token: 0x06000476 RID: 1142
		global::Motorola.CommonCPS.Server.EntityModel.SACRecordSummary ImportSACFromCSV(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.ImportSACFromCSVRequest csvRequest, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet);

		// Token: 0x06000477 RID: 1143
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.TGSARecord> GetTGSARecordsByTalkGroupID(global::System.Guid systemUuid, int talkGroupID);

		// Token: 0x06000478 RID: 1144
		bool UpdateTGSASiteSelectionBatch(global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.TGSASiteSelection> tgsaSiteSelections);

		// Token: 0x06000479 RID: 1145
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.TGSARecord> DeleteTGSARecords(global::System.Guid batchJobContainerUuid, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.TGSARecord> tgsaRecords);

		// Token: 0x0600047A RID: 1146
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.TGSARecord> AddTGSARecords(global::System.Guid batchJobContainerUuid, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.TGSARecord> addTGSAs, global::System.Guid sysUUID);

		// Token: 0x0600047B RID: 1147
		global::Motorola.CommonCPS.Server.EntityModel.TGSARecord EditTGSARecord(global::System.Guid tgsaRecordUuid, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.TGSARecordFieldType, object>> changedFieldValePair, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet);

		// Token: 0x0600047C RID: 1148
		global::Motorola.CommonCPS.Server.EntityModel.TGSARecord EditTGSARecordBat(global::System.Guid batchJobContainerUuid, global::System.Guid tgsaRecordUuid, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.TGSARecordFieldType, object>> changedFieldValePair, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet);

		// Token: 0x0600047D RID: 1149
		global::Motorola.CommonCPS.Server.EntityModel.TGSARecord ImportTGSAFromCSV(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.ImportTGSAFromCSVRequest csvRequest, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet);

		// Token: 0x0600047E RID: 1150
		global::System.Collections.Generic.Dictionary<int, int> GetUsedOptionsOfConfiguration(global::System.Guid guid);

		// Token: 0x0600047F RID: 1151
		global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Guid, global::System.Collections.Generic.List<int>>> GetUsedOptionsOfTopRecords(global::System.Collections.Generic.List<global::System.Guid> uuids, global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily);

		// Token: 0x06000480 RID: 1152
		global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Guid, byte[]>> GetDBRecordsTimeStamp(global::System.Collections.Generic.List<global::System.Guid> TopRecords_Uuids);

		// Token: 0x06000481 RID: 1153
		global::Motorola.CommonCPS.Server.EntityModel.RadioSummary TurnOffMNISCPIndicatior(string deviceID);

		// Token: 0x06000482 RID: 1154
		int InitialDBUpradeProcess(global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.DBUpgradeInfo upgradeInfo);

		// Token: 0x06000483 RID: 1155
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.DBNode> GetNextInitDNodes(int exceptCount);

		// Token: 0x06000484 RID: 1156
		void SaveDBNodeInitStructure(global::Motorola.CommonCPS.Server.EntityModel.DBNode node);

		// Token: 0x06000485 RID: 1157
		global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.DBUpgradeSet GetNextResolvingDBNodes(global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.DBUpgradeResolverSetRequest request);

		// Token: 0x06000486 RID: 1158
		void SaveDBResolverResult(global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.DBResolverSaveData result);

		// Token: 0x06000487 RID: 1159
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode> GetNextDBUpgradeFinalizingSets(string setType, int count);

		// Token: 0x06000488 RID: 1160
		void SetCurrentDataModelVersion(global::Motorola.CommonCPS.Server.EntityModel.BLVersion currentDataModelVersion);

		// Token: 0x06000489 RID: 1161
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary> SaveUpgradeFinalizeSet(global::Motorola.CommonCPS.Server.EntityModel.BLEditSaveDataArg bllSaveData);

		// Token: 0x0600048A RID: 1162
		global::System.Collections.Generic.IList<string> GetUpgradeHandlerParameterRequest(global::Motorola.CommonCPS.Server.CommonDBConstants.PACType pac, global::Motorola.CommonCPS.Server.EntityModel.BLVersion currentDataModelVersion);

		// Token: 0x0600048B RID: 1163
		void RunDBUpgradeHandler(global::Motorola.CommonCPS.Server.CommonDBConstants.PACType pac, global::Motorola.CommonCPS.Server.EntityModel.BLVersion currentDataModelVersion, global::System.Collections.Generic.Dictionary<string, object> parameters);

		// Token: 0x0600048C RID: 1164
		void CancelBatchJobContainerByUser(global::System.Guid batchJobContainerUuid);
	}
}
