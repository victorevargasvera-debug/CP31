using System;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000010 RID: 16
	public interface IService
	{
		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000080 RID: 128
		global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor ServerAccessor { get; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000081 RID: 129
		global::Motorola.CommonCPS.RadioManagement.SharedServices.IValidationServiceBase ValidationService { get; }

		// Token: 0x06000082 RID: 130
		bool IsRadioCanSelectATemplate(global::Motorola.CommonCPS.Server.EntityModel.RadioSummary device);

		// Token: 0x06000083 RID: 131
		bool IsRadioCanSelectAConfiguration(global::Motorola.CommonCPS.Server.EntityModel.RadioSummary device);

		// Token: 0x06000084 RID: 132
		bool CanRadioSelectAnIPProgramSystem(global::Motorola.CommonCPS.Server.EntityModel.RadioSummary device);

		// Token: 0x06000085 RID: 133
		bool IsRadioCanSelectATemplate(global::Motorola.CommonCPS.Server.EntityModel.Radio device, out string error);

		// Token: 0x06000086 RID: 134
		bool IsRadioSwitchoverRequired(global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus, global::Motorola.CommonCPS.Server.CommonDBConstants.CruncherStatus? cruncherStatus);

		// Token: 0x06000087 RID: 135
		bool IsJobNotRunning(global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus);

		// Token: 0x06000088 RID: 136
		bool CanCreateJob(global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus);

		// Token: 0x06000089 RID: 137
		global::Motorola.CommonCPS.Server.EntityModel.Radio GetRadioRawData(global::System.Guid deviceId, bool deepLoad = true);

		// Token: 0x0600008A RID: 138
		global::Motorola.CommonCPS.Server.EntityModel.Codeplug GetWorkingCodeplugRawData(global::System.Guid deviceID);

		// Token: 0x0600008B RID: 139
		global::Motorola.CommonCPS.Server.EntityModel.Template GetWorkingTemplateRawData(global::System.Guid deviceID);

		// Token: 0x0600008C RID: 140
		global::Motorola.CommonCPS.Server.EntityModel.Template GetTemplateRawData(global::System.Guid templateUuid, bool isDeep = false);

		// Token: 0x0600008D RID: 141
		bool IsJobProcessingState(global::Motorola.CommonCPS.Server.EntityModel.Radio rd);

		// Token: 0x0600008E RID: 142
		bool IsJobProcessingState(global::Motorola.CommonCPS.Server.EntityModel.RadioSummary radio);

		// Token: 0x0600008F RID: 143
		global::Motorola.CommonCPS.Server.EntityModel.RMFile AddFileToServer(string filePath);

		// Token: 0x06000090 RID: 144
		global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob AddBatchOperationJob(global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob job);

		// Token: 0x06000091 RID: 145
		global::Motorola.CommonCPS.Server.EntityModel.Package CheckAndUploadOnePackage(string filePath, global::Motorola.CommonCPS.Server.EntityModel.Package software);

		// Token: 0x06000092 RID: 146
		global::Motorola.CommonCPS.Server.EntityModel.Package UploadVAPackage(global::Motorola.CommonCPS.Server.EntityModel.Package package);

		// Token: 0x06000093 RID: 147
		void CheckRadioWorkingCodeplugCanBeOverwrite(global::Motorola.CommonCPS.Server.EntityModel.Radio device);
	}
}
