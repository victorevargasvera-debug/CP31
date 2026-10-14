using System;
using System.Collections;
using System.Collections.Specialized;

namespace Infragistics
{
	// Token: 0x020000C3 RID: 195
	public interface ICollectionBase : global::System.Collections.IList, global::System.Collections.ICollection, global::System.Collections.IEnumerable, global::System.Collections.Specialized.INotifyCollectionChanged, global::System.IDisposable
	{
		// Token: 0x06000731 RID: 1841
		void AddItemSilently(int index, object item);

		// Token: 0x06000732 RID: 1842
		bool RemoveItemSilently(int index);

		// Token: 0x06000733 RID: 1843
		void ResetItemsSilently();
	}
}
