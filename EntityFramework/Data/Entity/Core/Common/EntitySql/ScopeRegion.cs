using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common.EntitySql
{
	// Token: 0x02000669 RID: 1641
	internal sealed class ScopeRegion
	{
		// Token: 0x06004E4B RID: 20043 RVA: 0x001182E7 File Offset: 0x001164E7
		internal ScopeRegion(global::System.Data.Entity.Core.Common.EntitySql.ScopeManager scopeManager, int firstScopeIndex, int scopeRegionIndex)
		{
			this._scopeManager = scopeManager;
			this._firstScopeIndex = firstScopeIndex;
			this._scopeRegionIndex = scopeRegionIndex;
		}

		// Token: 0x17000F1F RID: 3871
		// (get) Token: 0x06004E4C RID: 20044 RVA: 0x0011831A File Offset: 0x0011651A
		internal int FirstScopeIndex
		{
			get
			{
				return this._firstScopeIndex;
			}
		}

		// Token: 0x17000F20 RID: 3872
		// (get) Token: 0x06004E4D RID: 20045 RVA: 0x00118322 File Offset: 0x00116522
		internal int ScopeRegionIndex
		{
			get
			{
				return this._scopeRegionIndex;
			}
		}

		// Token: 0x06004E4E RID: 20046 RVA: 0x0011832A File Offset: 0x0011652A
		internal bool ContainsScope(int scopeIndex)
		{
			return scopeIndex >= this._firstScopeIndex;
		}

		// Token: 0x06004E4F RID: 20047 RVA: 0x00118338 File Offset: 0x00116538
		internal void EnterGroupOperation(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding groupAggregateBinding)
		{
			this._groupAggregateBinding = groupAggregateBinding;
		}

		// Token: 0x06004E50 RID: 20048 RVA: 0x00118341 File Offset: 0x00116541
		internal void RollbackGroupOperation()
		{
			this._groupAggregateBinding = null;
		}

		// Token: 0x17000F21 RID: 3873
		// (get) Token: 0x06004E51 RID: 20049 RVA: 0x0011834A File Offset: 0x0011654A
		internal bool IsAggregating
		{
			get
			{
				return this._groupAggregateBinding != null;
			}
		}

		// Token: 0x17000F22 RID: 3874
		// (get) Token: 0x06004E52 RID: 20050 RVA: 0x00118355 File Offset: 0x00116555
		internal global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding GroupAggregateBinding
		{
			get
			{
				return this._groupAggregateBinding;
			}
		}

		// Token: 0x17000F23 RID: 3875
		// (get) Token: 0x06004E53 RID: 20051 RVA: 0x0011835D File Offset: 0x0011655D
		internal global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.EntitySql.GroupAggregateInfo> GroupAggregateInfos
		{
			get
			{
				return this._groupAggregateInfos;
			}
		}

		// Token: 0x06004E54 RID: 20052 RVA: 0x00118365 File Offset: 0x00116565
		internal void RegisterGroupAggregateName(string groupAggregateName)
		{
			this._groupAggregateNames.Add(groupAggregateName);
		}

		// Token: 0x06004E55 RID: 20053 RVA: 0x00118374 File Offset: 0x00116574
		internal bool ContainsGroupAggregate(string groupAggregateName)
		{
			return this._groupAggregateNames.Contains(groupAggregateName);
		}

		// Token: 0x17000F24 RID: 3876
		// (get) Token: 0x06004E56 RID: 20054 RVA: 0x00118382 File Offset: 0x00116582
		// (set) Token: 0x06004E57 RID: 20055 RVA: 0x0011838A File Offset: 0x0011658A
		internal bool WasResolutionCorrelated { get; set; }

		// Token: 0x06004E58 RID: 20056 RVA: 0x00118394 File Offset: 0x00116594
		internal void ApplyToScopeEntries(global::System.Action<global::System.Data.Entity.Core.Common.EntitySql.ScopeEntry> action)
		{
			for (int i = this.FirstScopeIndex; i <= this._scopeManager.CurrentScopeIndex; i++)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.EntitySql.ScopeEntry> keyValuePair in this._scopeManager.GetScopeByIndex(i))
				{
					action(keyValuePair.Value);
				}
			}
		}

		// Token: 0x06004E59 RID: 20057 RVA: 0x00118410 File Offset: 0x00116610
		internal void ApplyToScopeEntries(global::System.Func<global::System.Data.Entity.Core.Common.EntitySql.ScopeEntry, global::System.Data.Entity.Core.Common.EntitySql.ScopeEntry> action)
		{
			for (int i = this.FirstScopeIndex; i <= this._scopeManager.CurrentScopeIndex; i++)
			{
				global::System.Data.Entity.Core.Common.EntitySql.Scope scope = this._scopeManager.GetScopeByIndex(i);
				global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.EntitySql.ScopeEntry>> list = null;
				foreach (global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.EntitySql.ScopeEntry> keyValuePair in scope)
				{
					global::System.Data.Entity.Core.Common.EntitySql.ScopeEntry scopeEntry = action(keyValuePair.Value);
					if (keyValuePair.Value != scopeEntry)
					{
						if (list == null)
						{
							list = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.EntitySql.ScopeEntry>>();
						}
						list.Add(new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.EntitySql.ScopeEntry>(keyValuePair.Key, scopeEntry));
					}
				}
				if (list != null)
				{
					list.Each(delegate(global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.EntitySql.ScopeEntry> updatedScopeEntry)
					{
						scope.Replace(updatedScopeEntry.Key, updatedScopeEntry.Value);
					});
				}
			}
		}

		// Token: 0x06004E5A RID: 20058 RVA: 0x001184E4 File Offset: 0x001166E4
		internal void RollbackAllScopes()
		{
			this._scopeManager.RollbackToScope(this.FirstScopeIndex - 1);
		}

		// Token: 0x04001C6B RID: 7275
		private readonly global::System.Data.Entity.Core.Common.EntitySql.ScopeManager _scopeManager;

		// Token: 0x04001C6C RID: 7276
		private readonly int _firstScopeIndex;

		// Token: 0x04001C6D RID: 7277
		private readonly int _scopeRegionIndex;

		// Token: 0x04001C6E RID: 7278
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding _groupAggregateBinding;

		// Token: 0x04001C6F RID: 7279
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.EntitySql.GroupAggregateInfo> _groupAggregateInfos = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.EntitySql.GroupAggregateInfo>();

		// Token: 0x04001C70 RID: 7280
		private readonly global::System.Collections.Generic.HashSet<string> _groupAggregateNames = new global::System.Collections.Generic.HashSet<string>();
	}
}
