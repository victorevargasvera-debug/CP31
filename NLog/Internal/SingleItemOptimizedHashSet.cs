using System;
using System.Collections;
using System.Collections.Generic;

namespace NLog.Internal
{
	// Token: 0x02000123 RID: 291
	internal struct SingleItemOptimizedHashSet<T> : global::System.Collections.Generic.ICollection<T>, global::System.Collections.Generic.IEnumerable<T>, global::System.Collections.IEnumerable
	{
		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000D93 RID: 3475 RVA: 0x0002211C File Offset: 0x0002031C
		public int Count
		{
			get
			{
				global::System.Collections.Generic.HashSet<T> hashset = this._hashset;
				if (hashset != null)
				{
					return hashset.Count;
				}
				if (!global::System.Collections.Generic.EqualityComparer<T>.Default.Equals(this._singleItem, default(T)))
				{
					return 1;
				}
				return 0;
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000D94 RID: 3476 RVA: 0x00022157 File Offset: 0x00020357
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x0002215C File Offset: 0x0002035C
		public SingleItemOptimizedHashSet(T singleItem, global::NLog.Internal.SingleItemOptimizedHashSet<T> existing)
		{
			if (existing._hashset != null)
			{
				this._hashset = new global::System.Collections.Generic.HashSet<T>(existing._hashset);
				this._hashset.Add(singleItem);
				this._singleItem = default(T);
				return;
			}
			if (existing.Count == 1)
			{
				this._hashset = new global::System.Collections.Generic.HashSet<T>();
				this._hashset.Add(existing._singleItem);
				this._hashset.Add(singleItem);
				this._singleItem = default(T);
				return;
			}
			this._hashset = null;
			this._singleItem = singleItem;
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x000221EC File Offset: 0x000203EC
		public void Add(T item)
		{
			if (this._hashset != null)
			{
				this._hashset.Add(item);
				return;
			}
			global::System.Collections.Generic.HashSet<T> hashSet = new global::System.Collections.Generic.HashSet<T>();
			if (this.Count != 0)
			{
				hashSet.Add(this._singleItem);
			}
			hashSet.Add(item);
			this._hashset = hashSet;
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x00022239 File Offset: 0x00020439
		public void Clear()
		{
			if (this._hashset != null)
			{
				this._hashset.Clear();
				return;
			}
			this._hashset = new global::System.Collections.Generic.HashSet<T>();
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x0002225A File Offset: 0x0002045A
		public bool Contains(T item)
		{
			if (this._hashset != null)
			{
				return this._hashset.Contains(item);
			}
			return global::System.Collections.Generic.EqualityComparer<T>.Default.Equals(this._singleItem, item) && this.Count == 1;
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x0002228F File Offset: 0x0002048F
		public bool Remove(T item)
		{
			if (this._hashset != null)
			{
				return this._hashset.Remove(item);
			}
			this._hashset = new global::System.Collections.Generic.HashSet<T>();
			return global::System.Collections.Generic.EqualityComparer<T>.Default.Equals(this._singleItem, item);
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x000222C2 File Offset: 0x000204C2
		public void CopyTo(T[] array, int arrayIndex)
		{
			if (this._hashset != null)
			{
				this._hashset.CopyTo(array, arrayIndex);
				return;
			}
			if (this.Count == 1)
			{
				array[arrayIndex] = this._singleItem;
			}
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x000222F0 File Offset: 0x000204F0
		public global::System.Collections.Generic.IEnumerator<T> GetEnumerator()
		{
			if (this._hashset != null)
			{
				return this._hashset.GetEnumerator();
			}
			return this.SingleItemEnumerator();
		}

		// Token: 0x06000D9C RID: 3484 RVA: 0x00022311 File Offset: 0x00020511
		private global::System.Collections.Generic.IEnumerator<T> SingleItemEnumerator()
		{
			if (this.Count != 0)
			{
				yield return this._singleItem;
			}
			yield break;
		}

		// Token: 0x06000D9D RID: 3485 RVA: 0x00022325 File Offset: 0x00020525
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x040003BF RID: 959
		private readonly T _singleItem;

		// Token: 0x040003C0 RID: 960
		private global::System.Collections.Generic.HashSet<T> _hashset;

		// Token: 0x02000216 RID: 534
		public struct SingleItemScopedInsert : global::System.IDisposable
		{
			// Token: 0x06001300 RID: 4864 RVA: 0x00031334 File Offset: 0x0002F534
			public SingleItemScopedInsert(T singleItem, ref global::NLog.Internal.SingleItemOptimizedHashSet<T> existing, bool forceHashSet)
			{
				this._singleItem = singleItem;
				if (existing._hashset != null)
				{
					existing._hashset.Add(singleItem);
					this._hashset = existing._hashset;
					return;
				}
				if (forceHashSet)
				{
					existing = new global::NLog.Internal.SingleItemOptimizedHashSet<T>(singleItem, existing);
					existing.Add(singleItem);
					this._hashset = existing._hashset;
					return;
				}
				existing = new global::NLog.Internal.SingleItemOptimizedHashSet<T>(singleItem, existing);
				this._hashset = null;
			}

			// Token: 0x06001301 RID: 4865 RVA: 0x000313AC File Offset: 0x0002F5AC
			public void Dispose()
			{
				if (this._hashset != null)
				{
					this._hashset.Remove(this._singleItem);
				}
			}

			// Token: 0x040005E7 RID: 1511
			private readonly T _singleItem;

			// Token: 0x040005E8 RID: 1512
			private readonly global::System.Collections.Generic.HashSet<T> _hashset;
		}
	}
}
