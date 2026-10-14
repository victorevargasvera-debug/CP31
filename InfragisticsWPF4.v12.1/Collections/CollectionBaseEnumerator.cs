using System;
using System.Collections;
using System.Collections.Generic;

namespace Infragistics.Collections
{
	// Token: 0x020000AC RID: 172
	public class CollectionBaseEnumerator<T> : global::System.Collections.Generic.IEnumerator<T>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		// Token: 0x06000688 RID: 1672 RVA: 0x00017A53 File Offset: 0x00015C53
		public CollectionBaseEnumerator(global::Infragistics.Collections.CollectionBase<T> collection)
		{
			this._index = 0;
			this._collection = collection;
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000689 RID: 1673 RVA: 0x00017A6C File Offset: 0x00015C6C
		object global::System.Collections.IEnumerator.Current
		{
			get
			{
				return this._collection[this._index++];
			}
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x00017A9A File Offset: 0x00015C9A
		bool global::System.Collections.IEnumerator.MoveNext()
		{
			return this._index < this._collection.Count;
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x00017AAF File Offset: 0x00015CAF
		void global::System.Collections.IEnumerator.Reset()
		{
			this._index = 0;
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x0600068C RID: 1676 RVA: 0x00017AB8 File Offset: 0x00015CB8
		T global::System.Collections.Generic.IEnumerator<!0>.Current
		{
			get
			{
				return this._collection[this._index++];
			}
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x00017AE1 File Offset: 0x00015CE1
		public void Dispose()
		{
		}

		// Token: 0x0400030C RID: 780
		private int _index;

		// Token: 0x0400030D RID: 781
		private global::Infragistics.Collections.CollectionBase<T> _collection;
	}
}
