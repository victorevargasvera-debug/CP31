using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Infragistics
{
	// Token: 0x020000C4 RID: 196
	public interface ICollectionBase<T> : global::Infragistics.ICollectionBase, global::System.Collections.IList, global::System.Collections.ICollection, global::System.Collections.Specialized.INotifyCollectionChanged, global::System.IDisposable, global::System.Collections.Generic.IList<!0>, global::System.Collections.Generic.ICollection<!0>, global::System.Collections.Generic.IEnumerable<!0>, global::System.Collections.IEnumerable
	{
		// Token: 0x06000734 RID: 1844
		void AddItemSilently(int index, T item);
	}
}
