using System;
using System.Collections;
using System.Collections.Generic;

namespace Infragistics.Collections
{
	// Token: 0x02000099 RID: 153
	internal class WeakSet<T> : global::System.Collections.Generic.ISet<T>, global::System.Collections.Generic.ICollection<!0>, global::System.Collections.Generic.IEnumerable<!0>, global::System.Collections.IEnumerable where T : class
	{
		// Token: 0x060005E8 RID: 1512 RVA: 0x00015C96 File Offset: 0x00013E96
		public WeakSet()
		{
			this._items = new global::Infragistics.Collections.WeakDictionary<T, object>(true, false);
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060005E9 RID: 1513 RVA: 0x00015CAB File Offset: 0x00013EAB
		public int Count
		{
			get
			{
				return this._items.Count;
			}
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x00015CB8 File Offset: 0x00013EB8
		public bool Add(T item)
		{
			if (!this._items.ContainsKey(item))
			{
				this._items.Add(item, global::Infragistics.Collections.WeakSet<T>.Value);
				return true;
			}
			return false;
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x00015CDC File Offset: 0x00013EDC
		public void Clear()
		{
			this._items.Clear();
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00015CE9 File Offset: 0x00013EE9
		public bool Contains(T item)
		{
			return this._items.ContainsKey(item);
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x00015CF8 File Offset: 0x00013EF8
		public void CopyTo(T[] array, int arrayIndex)
		{
			foreach (T t in this)
			{
				array[arrayIndex++] = t;
			}
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x00015D48 File Offset: 0x00013F48
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

		// Token: 0x060005EF RID: 1519 RVA: 0x00015D9C File Offset: 0x00013F9C
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

		// Token: 0x060005F0 RID: 1520 RVA: 0x00015E04 File Offset: 0x00014004
		public bool IsProperSubsetOf(global::System.Collections.Generic.IEnumerable<T> other)
		{
			return global::Infragistics.Collections.WeakSet<T>.IsSubsetSupersetOfHelper(this, global::Infragistics.Collections.WeakSet<T>.ToSet(other), true, false);
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x00015E14 File Offset: 0x00014014
		public bool IsProperSupersetOf(global::System.Collections.Generic.IEnumerable<T> other)
		{
			return global::Infragistics.Collections.WeakSet<T>.IsSubsetSupersetOfHelper(this, global::Infragistics.Collections.WeakSet<T>.ToSet(other), true, true);
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x00015E24 File Offset: 0x00014024
		public bool IsSubsetOf(global::System.Collections.Generic.IEnumerable<T> other)
		{
			return global::Infragistics.Collections.WeakSet<T>.IsSubsetSupersetOfHelper(this, global::Infragistics.Collections.WeakSet<T>.ToSet(other), false, false);
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x00015E34 File Offset: 0x00014034
		public bool IsSupersetOf(global::System.Collections.Generic.IEnumerable<T> other)
		{
			return global::Infragistics.Collections.WeakSet<T>.IsSubsetSupersetOfHelper(this, global::Infragistics.Collections.WeakSet<T>.ToSet(other), false, true);
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00015E44 File Offset: 0x00014044
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

		// Token: 0x060005F5 RID: 1525 RVA: 0x00015E98 File Offset: 0x00014098
		public bool Remove(T item)
		{
			return this._items.Remove(item);
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x00015EA8 File Offset: 0x000140A8
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

		// Token: 0x060005F7 RID: 1527 RVA: 0x00015F4C File Offset: 0x0001414C
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

		// Token: 0x060005F8 RID: 1528 RVA: 0x00016040 File Offset: 0x00014240
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

		// Token: 0x060005F9 RID: 1529 RVA: 0x0001608C File Offset: 0x0001428C
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

		// Token: 0x060005FA RID: 1530 RVA: 0x00016168 File Offset: 0x00014368
		private static global::System.Collections.Generic.ISet<T> ToSet(global::System.Collections.Generic.IEnumerable<T> other)
		{
			global::System.Collections.Generic.ISet<T> set = other as global::System.Collections.Generic.ISet<T>;
			if (set == null && other != null)
			{
				set = new global::System.Collections.Generic.HashSet<T>(other);
			}
			return set;
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x0001618A File Offset: 0x0001438A
		void global::System.Collections.Generic.ICollection<!0>.Add(T item)
		{
			this.Add(item);
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060005FC RID: 1532 RVA: 0x00016194 File Offset: 0x00014394
		bool global::System.Collections.Generic.ICollection<!0>.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x00016198 File Offset: 0x00014398
		public global::System.Collections.Generic.IEnumerator<T> GetEnumerator()
		{
			global::System.Collections.Generic.IEnumerable<T> keys = this._items.Keys;
			return keys.GetEnumerator();
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x000161B7 File Offset: 0x000143B7
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x040002B8 RID: 696
		private static object Value = new object();

		// Token: 0x040002B9 RID: 697
		private global::Infragistics.Collections.WeakDictionary<T, object> _items;
	}
}
