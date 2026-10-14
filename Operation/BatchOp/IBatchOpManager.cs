using System;
using System.Collections.ObjectModel;

namespace Motorola.CommonCPS.RadioManagement.BatchOp
{
	// Token: 0x0200000A RID: 10
	public interface IBatchOpManager
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000024 RID: 36
		global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp> BatchOpList { get; }

		// Token: 0x06000025 RID: 37
		void Run(global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp batchOp);

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000026 RID: 38
		bool IsBusy { get; }

		// Token: 0x06000027 RID: 39
		global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp Find(global::System.Guid id);

		// Token: 0x06000028 RID: 40
		global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp FindByJbcId(global::System.Guid jbcId);

		// Token: 0x06000029 RID: 41
		void ClearOldBatchOp();
	}
}
