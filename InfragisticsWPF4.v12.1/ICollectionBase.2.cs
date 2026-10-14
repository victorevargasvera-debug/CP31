using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Infragistics
{
	// Token: 0x020000AA RID: 170
	public interface ICollectionBase<T> : global::Infragistics.ICollectionBase, global::System.Collections.IList, global::System.Collections.ICollection, global::System.Collections.Specialized.INotifyCollectionChanged, global::System.IDisposable, global::System.Collections.Generic.IList<!0>, global::System.Collections.Generic.ICollection<!0>, global::System.Collections.Generic.IEnumerable<!0>, global::System.Collections.IEnumerable
	{
		// Token: 0x06000650 RID: 1616
		void AddItemSilently(int index, T item);
	}
}
