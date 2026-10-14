using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Infragistics.Collections
{
	// Token: 0x020000B3 RID: 179
	internal class WeakSet<T> : global::System.Collections.Generic.ISet<T>, global::System.Collections.Generic.ICollection<!0>, global::System.Collections.Generic.IEnumerable<!0>, global::System.Collections.IEnumerable where T : class
	{
		// Token: 0x060006C9 RID: 1737 RVA: 0x00019376 File Offset: 0x00017576
		public WeakSet()
		{
			this._items = new global::Infragistics.Collections.WeakDictionary<T, object>(true, false);
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060006CA RID: 1738 RVA: 0x0001938B File Offset: 0x0001758B
		public int Count
		{
			get
			{
				return this._items.Count;
			}
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x00019398 File Offset: 0x00017598
		public bool Add(T item)
		{
			if (!this._items.ContainsKey(item))
			{
				this._items.Add(item, global::Infragistics.Collections.WeakSet<T>.Value);
				return true;
			}
			return false;
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x000193BC File Offset: 0x000175BC
		public void Clear()
		{
			this._items.Clear();
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x000193C9 File Offset: 0x000175C9
		public void Compact()
		{
			this._items.Compact(true);
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x000193D7 File Offset: 0x000175D7
		public bool Contains(T item)
		{
			return this._items.ContainsKey(item);
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x000193E8 File Offset: 0x000175E8
		public void CopyTo(T[] array, int arrayIndex)
		{
			foreach (T t in this)
			{
				array[arrayIndex++] = t;
			}
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x00019438 File Offset: 0x00017638
		public void ExceptWith(global::System.Collections.Generic.IEnumerable<T> other)
		{
			if (other != null)
			{
				foreach (T key in other)
				{
					this._items.Remove(key);
				}
			}
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x0001948C File Offset: 0x0001768C
		public void IntersectWith(global::System.Collections.Generic.IEnumerable<T> other)
		{
			if (other != null)
			{
				global::System.Collections.Generic.List<T> list = new global::System.Collections.Generic.List<T>();
				foreach (T item in other)
				{
					if (this.Contains(item))
					{
						list.Add(item);
					}
				}
				this.Clear();
				this.UnionWith(list);
			}
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x000194F4 File Offset: 0x000176F4
		public bool IsProperSubsetOf(global::System.Collections.Generic.IEnumerable<T> other)
		{
			return global::Infragistics.Collections.WeakSet<T>.IsSubsetSupersetOfHelper(this, global::Infragistics.Collections.WeakSet<T>.ToSet(other), true, false);
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x00019504 File Offset: 0x00017704
		public bool IsProperSupersetOf(global::System.Collections.Generic.IEnumerable<T> other)
		{
			return global::Infragistics.Collections.WeakSet<T>.IsSubsetSupersetOfHelper(this, global::Infragistics.Collections.WeakSet<T>.ToSet(other), true, true);
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x00019514 File Offset: 0x00017714
		public bool IsSubsetOf(global::System.Collections.Generic.IEnumerable<T> other)
		{
			return global::Infragistics.Collections.WeakSet<T>.IsSubsetSupersetOfHelper(this, global::Infragistics.Collections.WeakSet<T>.ToSet(other), false, false);
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x00019524 File Offset: 0x00017724
		public bool IsSupersetOf(global::System.Collections.Generic.IEnumerable<T> other)
		{
			return global::Infragistics.Collections.WeakSet<T>.IsSubsetSupersetOfHelper(this, global::Infragistics.Collections.WeakSet<T>.ToSet(other), false, true);
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x00019534 File Offset: 0x00017734
		public bool Overlaps(global::System.Collections.Generic.IEnumerable<T> other)
		{
			if (other != null)
			{
				foreach (T item in other)
				{
					if (this.Contains(item))
					{
						return true;
					}
				}
				return false;
			}
			return false;
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x00019588 File Offset: 0x00017788
		public bool Remove(T item)
		{
			return this._items.Remove(item);
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x00019598 File Offset: 0x00017798
		public bool SetEquals(global::System.Collections.Generic.IEnumerable<T> other)
		{
			if (other != null)
			{
				global::System.Collections.Generic.ISet<T> set = global::Infragistics.Collections.WeakSet<T>.ToSet(other);
				foreach (T item in this)
				{
					if (!set.Contains(item))
					{
						return false;
					}
				}
				foreach (T item2 in set)
				{
					if (!this.Contains(item2))
					{
						return false;
					}
				}
				return true;
			}
			return false;
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x0001963C File Offset: 0x0001783C
		public void SymmetricExceptWith(global::System.Collections.Generic.IEnumerable<T> other)
		{
			if (other != null)
			{
				global::System.Collections.Generic.List<T> list = new global::System.Collections.Generic.List<T>();
				global::System.Collections.Generic.List<T> list2 = new global::System.Collections.Generic.List<T>();
				foreach (T item in other)
				{
					if (this.Contains(item))
					{
						list.Add(item);
					}
					else
					{
						list2.Add(item);
					}
				}
				foreach (T item2 in list)
				{
					this.Remove(item2);
				}
				foreach (T item3 in list2)
				{
					this.Add(item3);
				}
			}
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00019733 File Offset: 0x00017933
		public global::System.Collections.Generic.List<T> ToList()
		{
			return (from x in this
			select x).ToList<T>();
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x00019760 File Offset: 0x00017960
		public void UnionWith(global::System.Collections.Generic.IEnumerable<T> other)
		{
			if (other != null)
			{
				foreach (T item in other)
				{
					this.Add(item);
				}
			}
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x000197AC File Offset: 0x000179AC
		private static bool IsSubsetSupersetOfHelper(global::System.Collections.Generic.ISet<T> s1, global::System.Collections.Generic.ISet<T> s2, bool proper, bool checkSuperset)
		{
			if (s1 == null || s2 == null)
			{
				return false;
			}
			if (proper)
			{
				bool flag = null != global::Infragistics.CoreUtilities.GetFirstItem<T>(s1);
				bool result = null != global::Infragistics.CoreUtilities.GetFirstItem<T>(s2);
				if (checkSuperset)
				{
					if (!flag)
					{
						return false;
					}
				}
				else if (!flag)
				{
					return result;
				}
			}
			if (checkSuperset)
			{
				using (global::System.Collections.Generic.IEnumerator<T> enumerator = s2.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						T item = enumerator.Current;
						if (!s1.Contains(item))
						{
							return false;
						}
					}
					return true;
				}
			}
			foreach (T item2 in s1)
			{
				if (!s2.Contains(item2))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x00019888 File Offset: 0x00017A88
		private static global::System.Collections.Generic.ISet<T> ToSet(global::System.Collections.Generic.IEnumerable<T> other)
		{
			global::System.Collections.Generic.ISet<T> set = other as global::System.Collections.Generic.ISet<T>;
			if (set == null && other != null)
			{
				set = new global::System.Collections.Generic.HashSet<T>(other);
			}
			return set;
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x000198AA File Offset: 0x00017AAA
		void global::System.Collections.Generic.ICollection<!0>.Add(T item)
		{
			this.Add(item);
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060006DF RID: 1759 RVA: 0x000198B4 File Offset: 0x00017AB4
		bool global::System.Collections.Generic.ICollection<!0>.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x000198B8 File Offset: 0x00017AB8
		public global::System.Collections.Generic.IEnumerator<T> GetEnumerator()
		{
			global::System.Collections.Generic.IEnumerable<T> keys = this._items.Keys;
			return keys.GetEnumerator();
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x000198D7 File Offset: 0x00017AD7
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x0400033C RID: 828
		private static object Value = new object();

		// Token: 0x0400033D RID: 829
		private global::Infragistics.Collections.WeakDictionary<T, object> _items;
	}
}
