using System;
using System.Collections;
using System.Collections.Generic;

namespace Infragistics
{
	// Token: 0x020000B0 RID: 176
	public class RearrangedList<T> : global::System.Collections.Generic.IList<T>, global::System.Collections.Generic.ICollection<T>, global::System.Collections.Generic.IEnumerable<!0>, global::System.Collections.IEnumerable
	{
		// Token: 0x06000792 RID: 1938 RVA: 0x00023C57 File Offset: 0x00021E57
		public RearrangedList(global::System.Collections.Generic.IList<T> inner, global::System.Collections.Generic.IList<int> indexes)
		{
			this._inner = inner;
			this._indexes = indexes;
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x00023C70 File Offset: 0x00021E70
		public int IndexOf(T item)
		{
			int num = this._inner.IndexOf(item);
			if (num == -1)
			{
				return -1;
			}
			return this._indexes.IndexOf(num);
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x00023C9C File Offset: 0x00021E9C
		public void Insert(int index, T item)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x00023CA3 File Offset: 0x00021EA3
		public void RemoveAt(int index)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x170001C3 RID: 451
		public T this[int index]
		{
			get
			{
				return this._inner[this._indexes[index]];
			}
			set
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x00023CCA File Offset: 0x00021ECA
		public void Add(T item)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x00023CD1 File Offset: 0x00021ED1
		public void Clear()
		{
			this._indexes.Clear();
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x00023CDE File Offset: 0x00021EDE
		public bool Contains(T item)
		{
			return this._inner.Contains(item);
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x00023CEC File Offset: 0x00021EEC
		public void CopyTo(T[] array, int arrayIndex)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x0600079C RID: 1948 RVA: 0x00023CF3 File Offset: 0x00021EF3
		public int Count
		{
			get
			{
				return this._indexes.Count;
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x0600079D RID: 1949 RVA: 0x00023D00 File Offset: 0x00021F00
		public bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x00023D03 File Offset: 0x00021F03
		public bool Remove(T item)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x00023E50 File Offset: 0x00022050
		public global::System.Collections.Generic.IEnumerator<T> GetEnumerator()
		{
			foreach (int ind in this._indexes)
			{
				yield return this._inner[ind];
			}
			yield break;
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x00023FB4 File Offset: 0x000221B4
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			foreach (int ind in this._indexes)
			{
				yield return this._inner[ind];
			}
			yield break;
		}

		// Token: 0x040002CD RID: 717
		private global::System.Collections.Generic.IList<T> _inner;

		// Token: 0x040002CE RID: 718
		private global::System.Collections.Generic.IList<int> _indexes;
	}
}
