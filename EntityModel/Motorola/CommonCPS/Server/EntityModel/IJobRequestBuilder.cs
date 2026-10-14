using System;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000EE RID: 238
	public interface IJobRequestBuilder
	{
		// Token: 0x06000E6F RID: 3695
		global::Motorola.CommonCPS.Server.EntityModel.JobRequest Build();

		// Token: 0x06000E70 RID: 3696
		global::Motorola.CommonCPS.Server.EntityModel.IJobRequestBuilder SetScheduleDate(global::System.DateTime? startDate, global::System.DateTime? endDate);

		// Token: 0x06000E71 RID: 3697
		global::Motorola.CommonCPS.Server.EntityModel.IJobRequestBuilder SetMigrationJob(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.EntityModel.Configuration configuration = null);

		// Token: 0x06000E72 RID: 3698
		global::Motorola.CommonCPS.Server.EntityModel.IJobRequestBuilder SetMatrixRRPJob(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, int switchoverDelay, bool isARSSuppression);

		// Token: 0x06000E73 RID: 3699
		global::Motorola.CommonCPS.Server.EntityModel.IJobRequestBuilder SetSingleRadio(bool isSingleRadioOp);

		// Token: 0x06000E74 RID: 3700
		global::Motorola.CommonCPS.Server.EntityModel.IJobRequestBuilder SetFirmwareRecoverJob(bool isFirmwareRecoverJob);

		// Token: 0x06000E75 RID: 3701
		global::Motorola.CommonCPS.Server.EntityModel.IJobRequestBuilder SetSysCert(bool isUserCertUninstallAll, bool isSysCertDistableAll, bool isSysCertEnableAll);

		// Token: 0x06000E76 RID: 3702
		global::Motorola.CommonCPS.Server.EntityModel.IJobRequestBuilder SetRestoreJob(global::Motorola.CommonCPS.Server.EntityModel.Codeplug restoreCodeplug);

		// Token: 0x06000E77 RID: 3703
		global::Motorola.CommonCPS.Server.EntityModel.IJobRequestBuilder SetSecurityField(global::Motorola.CommonCPS.Server.EntityModel.SecurityFieldRequest securityField);

		// Token: 0x06000E78 RID: 3704
		global::Motorola.CommonCPS.Server.EntityModel.IJobRequestBuilder SetUEFileContent(byte[] ueFile);

		// Token: 0x06000E79 RID: 3705
		global::Motorola.CommonCPS.Server.EntityModel.IJobRequestBuilder SetPBBFactoryResetJob(global::Motorola.CommonCPS.Server.EntityModel.Radio radio);

		// Token: 0x06000E7A RID: 3706
		global::Motorola.CommonCPS.Server.EntityModel.IJobRequestBuilder SetPasswordResetFileContent(byte[] passwordResetFileContent);
	}
}
