using System;
using System.Collections.Generic;
using System.Linq;

namespace Infragistics
{
	// Token: 0x02000004 RID: 4
	internal class PositionSorter
	{
		// Token: 0x0600000D RID: 13 RVA: 0x0000211C File Offset: 0x0000031C
		private PositionSorter()
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000215C File Offset: 0x0000035C
		public static void Sort(global::System.Collections.Generic.List<global::Infragistics.ISupportPositioning> list, out bool isValid, global::System.Collections.Generic.IComparer<global::Infragistics.ISupportPositioning> defaultComparer = null)
		{
			global::Infragistics.PositionSorter positionSorter = new global::Infragistics.PositionSorter
			{
				_list = list,
				_defaultComparer = defaultComparer
			};
			isValid = positionSorter.Sort();
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002188 File Offset: 0x00000388
		private void AggregateBefores(global::Infragistics.ISupportPositioning item, global::System.Collections.Generic.HashSet<global::Infragistics.ISupportPositioning> result)
		{
			foreach (global::Infragistics.ISupportPositioning item2 in this._befores[item])
			{
				if (!result.Contains(item2))
				{
					result.Add(item2);
					this.AggregateBefores(item2, result);
				}
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000021F4 File Offset: 0x000003F4
		private void AggregateAfters(global::Infragistics.ISupportPositioning item, global::System.Collections.Generic.HashSet<global::Infragistics.ISupportPositioning> result)
		{
			foreach (global::Infragistics.ISupportPositioning item2 in this._afters[item])
			{
				if (!result.Contains(item2))
				{
					result.Add(item2);
					this.AggregateAfters(item2, result);
				}
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002260 File Offset: 0x00000460
		private int CompareHelper(global::Infragistics.ISupportPositioning x, global::Infragistics.ISupportPositioning y, int level = 0)
		{
			if (x == y)
			{
				return 0;
			}
			if (this._aggregatedBefores[x].Contains(y))
			{
				return -1;
			}
			if (this._aggregatedAfters[x].Contains(y))
			{
				return 1;
			}
			if (1 != level)
			{
				return -this.CompareHelper(y, x, 1);
			}
			if (x.Key != y.Key)
			{
				this._indeterminateOrderDetected = true;
			}
			if (this._defaultComparer != null)
			{
				return this._defaultComparer.Compare(x, y);
			}
			return 0;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000022FC File Offset: 0x000004FC
		private global::System.Collections.Generic.HashSet<global::Infragistics.ISupportPositioning> GetBeforeAfterItems(global::Infragistics.ISupportPositioning item, bool getBefore)
		{
			global::System.Collections.Generic.IEnumerable<string> enumerable = getBefore ? item.Before : item.After;
			global::System.Collections.Generic.HashSet<global::Infragistics.ISupportPositioning> hashSet = new global::System.Collections.Generic.HashSet<global::Infragistics.ISupportPositioning>();
			if (enumerable != null)
			{
				hashSet.UnionWith((from ii in enumerable
				where this._map.ContainsKey(ii)
				select ii).SelectMany((string ii) => this._map[ii]));
			}
			return hashSet;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0000235C File Offset: 0x0000055C
		private bool Sort()
		{
			bool result = true;
			foreach (global::Infragistics.ISupportPositioning supportPositioning in this._list)
			{
				global::System.Collections.Generic.IList<global::Infragistics.ISupportPositioning> list;
				if (!this._map.TryGetValue(supportPositioning.Key, out list))
				{
					list = (this._map[supportPositioning.Key] = new global::System.Collections.Generic.List<global::Infragistics.ISupportPositioning>());
				}
				list.Add(supportPositioning);
			}
			foreach (global::Infragistics.ISupportPositioning supportPositioning2 in this._list)
			{
				this._befores[supportPositioning2] = this.GetBeforeAfterItems(supportPositioning2, true);
				this._afters[supportPositioning2] = this.GetBeforeAfterItems(supportPositioning2, false);
			}
			foreach (global::Infragistics.ISupportPositioning supportPositioning3 in this._list)
			{
				foreach (global::Infragistics.ISupportPositioning key in this._befores[supportPositioning3])
				{
					this._afters[key].Add(supportPositioning3);
				}
				foreach (global::Infragistics.ISupportPositioning key2 in this._afters[supportPositioning3])
				{
					this._befores[key2].Add(supportPositioning3);
				}
			}
			foreach (global::Infragistics.ISupportPositioning supportPositioning4 in this._list)
			{
				global::System.Collections.Generic.HashSet<global::Infragistics.ISupportPositioning> hashSet = new global::System.Collections.Generic.HashSet<global::Infragistics.ISupportPositioning>();
				global::System.Collections.Generic.HashSet<global::Infragistics.ISupportPositioning> hashSet2 = new global::System.Collections.Generic.HashSet<global::Infragistics.ISupportPositioning>();
				this.AggregateBefores(supportPositioning4, hashSet);
				this.AggregateAfters(supportPositioning4, hashSet2);
				this._aggregatedBefores[supportPositioning4] = hashSet;
				this._aggregatedAfters[supportPositioning4] = hashSet2;
				if (hashSet.Overlaps(hashSet2))
				{
					result = false;
				}
			}
			this._list.Sort((global::Infragistics.ISupportPositioning x, global::Infragistics.ISupportPositioning y) => this.CompareHelper(x, y, 0));
			bool indeterminateOrderDetected = this._indeterminateOrderDetected;
			return result;
		}

		// Token: 0x04000005 RID: 5
		private global::System.Collections.Generic.IComparer<global::Infragistics.ISupportPositioning> _defaultComparer;

		// Token: 0x04000006 RID: 6
		private global::System.Collections.Generic.List<global::Infragistics.ISupportPositioning> _list;

		// Token: 0x04000007 RID: 7
		private global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Infragistics.ISupportPositioning>> _map = new global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Infragistics.ISupportPositioning>>();

		// Token: 0x04000008 RID: 8
		private global::System.Collections.Generic.Dictionary<global::Infragistics.ISupportPositioning, global::System.Collections.Generic.HashSet<global::Infragistics.ISupportPositioning>> _befores = new global::System.Collections.Generic.Dictionary<global::Infragistics.ISupportPositioning, global::System.Collections.Generic.HashSet<global::Infragistics.ISupportPositioning>>();

		// Token: 0x04000009 RID: 9
		private global::System.Collections.Generic.Dictionary<global::Infragistics.ISupportPositioning, global::System.Collections.Generic.HashSet<global::Infragistics.ISupportPositioning>> _afters = new global::System.Collections.Generic.Dictionary<global::Infragistics.ISupportPositioning, global::System.Collections.Generic.HashSet<global::Infragistics.ISupportPositioning>>();

		// Token: 0x0400000A RID: 10
		private global::System.Collections.Generic.Dictionary<global::Infragistics.ISupportPositioning, global::System.Collections.Generic.HashSet<global::Infragistics.ISupportPositioning>> _aggregatedBefores = new global::System.Collections.Generic.Dictionary<global::Infragistics.ISupportPositioning, global::System.Collections.Generic.HashSet<global::Infragistics.ISupportPositioning>>();

		// Token: 0x0400000B RID: 11
		private global::System.Collections.Generic.Dictionary<global::Infragistics.ISupportPositioning, global::System.Collections.Generic.HashSet<global::Infragistics.ISupportPositioning>> _aggregatedAfters = new global::System.Collections.Generic.Dictionary<global::Infragistics.ISupportPositioning, global::System.Collections.Generic.HashSet<global::Infragistics.ISupportPositioning>>();

		// Token: 0x0400000C RID: 12
		private bool _indeterminateOrderDetected;
	}
}
