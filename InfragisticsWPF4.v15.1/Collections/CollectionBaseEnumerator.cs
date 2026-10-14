using System;
using System.Collections;
using System.Collections.Generic;

namespace Infragistics.Collections
{
	// Token: 0x020000C6 RID: 198
	public class CollectionBaseEnumerator<T> : global::System.Collections.Generic.IEnumerator<T>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		// Token: 0x0600076C RID: 1900 RVA: 0x0001B197 File Offset: 0x00019397
		public CollectionBaseEnumerator(global::Infragistics.Collections.CollectionBase<T> collection)
		{
			this._index = 0;
			this._collection = collection;
			this._current = default(T);
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x0600076D RID: 1901 RVA: 0x0001B1B9 File Offset: 0x000193B9
		object global::System.Collections.IEnumerator.Current
		{
			get
			{
				return this._current;
			}
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x0001B1C6 File Offset: 0x000193C6
		bool global::System.Collections.IEnumerator.MoveNext()
		{
			if (this._index < this._collection.Count)
			{
				this._current = this._collection[this._index];
				this._index++;
				return true;
			}
			return false;
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x0001B203 File Offset: 0x00019403
		void global::System.Collections.IEnumerator.Reset()
		{
			this._index = 0;
			this._current = default(T);
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000770 RID: 1904 RVA: 0x0001B218 File Offset: 0x00019418
		T global::System.Collections.Generic.IEnumerator<!0>.Current
		{
			get
			{
				return this._current;
			}
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x0001B220 File Offset: 0x00019420
		public void Dispose()
		{
		}

		// Token: 0x040003AE RID: 942
		private int _index;

		// Token: 0x040003AF RID: 943
		private T _current;

		// Token: 0x040003B0 RID: 944
		private global::Infragistics.Collections.CollectionBase<T> _collection;
	}
}
