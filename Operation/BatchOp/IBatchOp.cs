using System;
using System.ComponentModel;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.BatchOp
{
	// Token: 0x02000046 RID: 70
	public interface IBatchOp
	{
		// Token: 0x14000005 RID: 5
		// (add) Token: 0x060001A4 RID: 420
		// (remove) Token: 0x060001A5 RID: 421
		event global::System.ComponentModel.ProgressChangedEventHandler ProgressChanged;

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x060001A6 RID: 422
		// (remove) Token: 0x060001A7 RID: 423
		event global::System.ComponentModel.RunWorkerCompletedEventHandler RunWorkerCompleted;

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001A8 RID: 424
		global::System.Guid ID { get; }

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001A9 RID: 425
		global::System.Guid JobContainerGuid { get; }

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001AA RID: 426
		global::Motorola.CommonCPS.Server.CommonDBConstants.JobContainerStatus Status { get; }

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001AB RID: 427
		bool IsBusy { get; }

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001AC RID: 428
		bool Completed { get; }

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060001AD RID: 429
		global::Motorola.CommonCPS.Server.CommonDBConstants.JobType Type { get; }

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001AE RID: 430
		string JobName { get; }

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001AF RID: 431
		string Error { get; }

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001B0 RID: 432
		int TotalItemCount { get; }

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001B1 RID: 433
		int CurrentItemIndex { get; }

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001B2 RID: 434
		bool IsSafe { get; }

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001B3 RID: 435
		global::System.DateTime CreatedTime { get; }

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001B4 RID: 436
		// (set) Token: 0x060001B5 RID: 437
		bool IsVisible { get; set; }

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001B6 RID: 438
		string InitializationError { get; }

		// Token: 0x060001B7 RID: 439
		void CancelAsync();

		// Token: 0x060001B8 RID: 440
		void RunWorkerAsync();
	}
}
