using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace System.Data.Entity.Core.Objects
{
	// Token: 0x02000410 RID: 1040
	internal interface IObjectViewData<T>
	{
		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x06003149 RID: 12617
		global::System.Collections.Generic.IList<T> List { get; }

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x0600314A RID: 12618
		bool AllowNew { get; }

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x0600314B RID: 12619
		bool AllowEdit { get; }

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x0600314C RID: 12620
		bool AllowRemove { get; }

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x0600314D RID: 12621
		bool FiresEventOnAdd { get; }

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x0600314E RID: 12622
		bool FiresEventOnRemove { get; }

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x0600314F RID: 12623
		bool FiresEventOnClear { get; }

		// Token: 0x06003150 RID: 12624
		void EnsureCanAddNew();

		// Token: 0x06003151 RID: 12625
		int Add(T item, bool isAddNew);

		// Token: 0x06003152 RID: 12626
		void CommitItemAt(int index);

		// Token: 0x06003153 RID: 12627
		void Clear();

		// Token: 0x06003154 RID: 12628
		bool Remove(T item, bool isCancelNew);

		// Token: 0x06003155 RID: 12629
		global::System.ComponentModel.ListChangedEventArgs OnCollectionChanged(object sender, global::System.ComponentModel.CollectionChangeEventArgs e, global::System.Data.Entity.Core.Objects.ObjectViewListener listener);
	}
}
