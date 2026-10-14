using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Internal
{
	// Token: 0x02000113 RID: 275
	internal class ReadOnlySet<T> : global::System.Collections.Generic.ISet<T>, global::System.Collections.Generic.ICollection<!0>, global::System.Collections.Generic.IEnumerable<!0>, global::System.Collections.IEnumerable
	{
		// Token: 0x0600133D RID: 4925 RVA: 0x000317FC File Offset: 0x0002F9FC
		public ReadOnlySet(global::System.Collections.Generic.ISet<T> set)
		{
			this._set = set;
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x0003180B File Offset: 0x0002FA0B
		public bool Add(T item)
		{
			throw global::System.Data.Entity.Resources.Error.DbPropertyValues_PropertyValueNamesAreReadonly();
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x00031812 File Offset: 0x0002FA12
		public void ExceptWith(global::System.Collections.Generic.IEnumerable<T> other)
		{
			this._set.ExceptWith(other);
		}

		// Token: 0x06001340 RID: 4928 RVA: 0x00031820 File Offset: 0x0002FA20
		public void IntersectWith(global::System.Collections.Generic.IEnumerable<T> other)
		{
			this._set.IntersectWith(other);
		}

		// Token: 0x06001341 RID: 4929 RVA: 0x0003182E File Offset: 0x0002FA2E
		public bool IsProperSubsetOf(global::System.Collections.Generic.IEnumerable<T> other)
		{
			return this._set.IsProperSubsetOf(other);
		}

		// Token: 0x06001342 RID: 4930 RVA: 0x0003183C File Offset: 0x0002FA3C
		public bool IsProperSupersetOf(global::System.Collections.Generic.IEnumerable<T> other)
		{
			return this._set.IsProperSupersetOf(other);
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x0003184A File Offset: 0x0002FA4A
		public bool IsSubsetOf(global::System.Collections.Generic.IEnumerable<T> other)
		{
			return this._set.IsSubsetOf(other);
		}

		// Token: 0x06001344 RID: 4932 RVA: 0x00031858 File Offset: 0x0002FA58
		public bool IsSupersetOf(global::System.Collections.Generic.IEnumerable<T> other)
		{
			return this._set.IsSupersetOf(other);
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x00031866 File Offset: 0x0002FA66
		public bool Overlaps(global::System.Collections.Generic.IEnumerable<T> other)
		{
			return this._set.Overlaps(other);
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x00031874 File Offset: 0x0002FA74
		public bool SetEquals(global::System.Collections.Generic.IEnumerable<T> other)
		{
			return this._set.SetEquals(other);
		}

		// Token: 0x06001347 RID: 4935 RVA: 0x00031882 File Offset: 0x0002FA82
		public void SymmetricExceptWith(global::System.Collections.Generic.IEnumerable<T> other)
		{
			this._set.SymmetricExceptWith(other);
		}

		// Token: 0x06001348 RID: 4936 RVA: 0x00031890 File Offset: 0x0002FA90
		public void UnionWith(global::System.Collections.Generic.IEnumerable<T> other)
		{
			this._set.UnionWith(other);
		}

		// Token: 0x06001349 RID: 4937 RVA: 0x0003189E File Offset: 0x0002FA9E
		void global::System.Collections.Generic.ICollection<!0>.Add(T item)
		{
			throw global::System.Data.Entity.Resources.Error.DbPropertyValues_PropertyValueNamesAreReadonly();
		}

		// Token: 0x0600134A RID: 4938 RVA: 0x000318A5 File Offset: 0x0002FAA5
		public void Clear()
		{
			throw global::System.Data.Entity.Resources.Error.DbPropertyValues_PropertyValueNamesAreReadonly();
		}

		// Token: 0x0600134B RID: 4939 RVA: 0x000318AC File Offset: 0x0002FAAC
		public bool Contains(T item)
		{
			return this._set.Contains(item);
		}

		// Token: 0x0600134C RID: 4940 RVA: 0x000318BA File Offset: 0x0002FABA
		public void CopyTo(T[] array, int arrayIndex)
		{
			this._set.CopyTo(array, arrayIndex);
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x0600134D RID: 4941 RVA: 0x000318C9 File Offset: 0x0002FAC9
		public int Count
		{
			get
			{
				return this._set.Count;
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x0600134E RID: 4942 RVA: 0x000318D6 File Offset: 0x0002FAD6
		public bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600134F RID: 4943 RVA: 0x000318D9 File Offset: 0x0002FAD9
		public bool Remove(T item)
		{
			throw global::System.Data.Entity.Resources.Error.DbPropertyValues_PropertyValueNamesAreReadonly();
		}

		// Token: 0x06001350 RID: 4944 RVA: 0x000318E0 File Offset: 0x0002FAE0
		public global::System.Collections.Generic.IEnumerator<T> GetEnumerator()
		{
			return this._set.GetEnumerator();
		}

		// Token: 0x06001351 RID: 4945 RVA: 0x000318ED File Offset: 0x0002FAED
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this._set.GetEnumerator();
		}

		// Token: 0x0400094F RID: 2383
		private readonly global::System.Collections.Generic.ISet<T> _set;
	}
}
