using System;
using System.Collections;
using System.Collections.Specialized;

namespace Infragistics
{
	// Token: 0x020000A9 RID: 169
	public interface ICollectionBase : global::System.Collections.IList, global::System.Collections.ICollection, global::System.Collections.IEnumerable, global::System.Collections.Specialized.INotifyCollectionChanged, global::System.IDisposable
	{
		// Token: 0x0600064D RID: 1613
		void AddItemSilently(int index, object item);

		// Token: 0x0600064E RID: 1614
		bool RemoveItemSilently(int index);

		// Token: 0x0600064F RID: 1615
		void ResetItemsSilently();
	}
}
