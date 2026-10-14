using System;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x020000B1 RID: 177
	public class PackingParameter_CheckRadioOrJobStatus
	{
		// Token: 0x06000A6F RID: 2671 RVA: 0x0007E8EC File Offset: 0x0007CAEC
		public PackingParameter_CheckRadioOrJobStatus(global::Motorola.CommonCPS.Server.EntityModel.RadioSummary device)
		{
			this.radioStatus = (global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus)device.RadioStatus.Value;
			global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus = device.JobStatus;
			this.jobStatus = ((jobStatus != null) ? new global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus?(jobStatus.GetValueOrDefault()) : null);
			this.changeIndicator = device.ChangeIndicator;
			this.cruncherStatus = device.CruncherStatus;
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x0007E968 File Offset: 0x0007CB68
		public PackingParameter_CheckRadioOrJobStatus(global::Motorola.CommonCPS.Server.EntityModel.Radio device)
		{
			this.SerialNumber = device.SerialNumber;
			this.radioStatus = (global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus)device.RadioStatus;
			if (device.LastJob != null)
			{
				this.jobStatus = new global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus?(device.LastJob.JobStatus);
				this.cruncherStatus = new global::Motorola.CommonCPS.Server.CommonDBConstants.CruncherStatus?(device.LastJob.CruncherStatus);
			}
			else
			{
				this.cruncherStatus = null;
			}
			if (device.WorkingCodeplug != null)
			{
				this.changeIndicator = device.WorkingCodeplug.ChangeIndicator;
				return;
			}
			this.changeIndicator = null;
		}

		// Token: 0x0400017D RID: 381
		public string SerialNumber = string.Empty;

		// Token: 0x0400017E RID: 382
		public global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus radioStatus;

		// Token: 0x0400017F RID: 383
		public global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus;

		// Token: 0x04000180 RID: 384
		public int? changeIndicator;

		// Token: 0x04000181 RID: 385
		public global::Motorola.CommonCPS.Server.CommonDBConstants.CruncherStatus? cruncherStatus;
	}
}
