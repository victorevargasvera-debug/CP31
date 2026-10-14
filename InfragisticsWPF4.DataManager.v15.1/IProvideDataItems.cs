using System;
using System.Collections.Generic;

namespace Infragistics
{
	// Token: 0x02000039 RID: 57
	public interface IProvideDataItems<T>
	{
		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000295 RID: 661
		int DataCount { get; }

		// Token: 0x06000296 RID: 662
		T GetDataItem(int index);

		// Token: 0x06000297 RID: 663
		T CreateItem();

		// Token: 0x06000298 RID: 664
		T CreateItem(object dataItem);

		// Token: 0x06000299 RID: 665
		void AddItem(T addedObject);

		// Token: 0x0600029A RID: 666
		bool RemoveItem(T removedObject);

		// Token: 0x0600029B RID: 667
		void RemoveRange(global::System.Collections.Generic.IList<T> itemsToRemove);

		// Token: 0x0600029C RID: 668
		void InsertItem(int index, T insertedObject);
	}
}
