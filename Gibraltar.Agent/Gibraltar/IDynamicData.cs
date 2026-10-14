using System;
using System.ComponentModel;

namespace Gibraltar
{
	// Token: 0x02000164 RID: 356
	internal interface IDynamicData
	{
		// Token: 0x06000ED4 RID: 3796
		void CommitChanges(global::System.ComponentModel.ISynchronizeInvoke synchObject);

		// Token: 0x06000ED5 RID: 3797
		void Clear();

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06000ED6 RID: 3798
		bool HasDeferredChanges { get; }
	}
}
