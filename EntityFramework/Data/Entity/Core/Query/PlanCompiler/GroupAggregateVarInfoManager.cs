using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Query.InternalTrees;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x02000345 RID: 837
	internal class GroupAggregateVarInfoManager
	{
		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x060027D8 RID: 10200 RVA: 0x00074DDF File Offset: 0x00072FDF
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.PlanCompiler.GroupAggregateVarInfo> GroupAggregateVarInfos
		{
			get
			{
				return this._groupAggregateVarInfos;
			}
		}

		// Token: 0x060027D9 RID: 10201 RVA: 0x00074DE7 File Offset: 0x00072FE7
		internal void Add(global::System.Data.Entity.Core.Query.InternalTrees.Var var, global::System.Data.Entity.Core.Query.PlanCompiler.GroupAggregateVarInfo groupAggregateVarInfo, global::System.Data.Entity.Core.Query.InternalTrees.Node computationTemplate, bool isUnnested)
		{
			this._groupAggregateVarRelatedVarToInfo.Add(var, new global::System.Data.Entity.Core.Query.PlanCompiler.GroupAggregateVarRefInfo(groupAggregateVarInfo, computationTemplate, isUnnested));
			this._groupAggregateVarInfos.Add(groupAggregateVarInfo);
		}

		// Token: 0x060027DA RID: 10202 RVA: 0x00074E0C File Offset: 0x0007300C
		internal void Add(global::System.Data.Entity.Core.Query.InternalTrees.Var var, global::System.Data.Entity.Core.Query.PlanCompiler.GroupAggregateVarInfo groupAggregateVarInfo, global::System.Data.Entity.Core.Query.InternalTrees.Node computationTemplate, bool isUnnested, global::System.Data.Entity.Core.Metadata.Edm.EdmMember property)
		{
			if (property == null)
			{
				this.Add(var, groupAggregateVarInfo, computationTemplate, isUnnested);
				return;
			}
			if (this._groupAggregateVarRelatedVarPropertyToInfo == null)
			{
				this._groupAggregateVarRelatedVarPropertyToInfo = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmMember, global::System.Data.Entity.Core.Query.PlanCompiler.GroupAggregateVarRefInfo>>();
			}
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmMember, global::System.Data.Entity.Core.Query.PlanCompiler.GroupAggregateVarRefInfo> dictionary;
			if (!this._groupAggregateVarRelatedVarPropertyToInfo.TryGetValue(var, out dictionary))
			{
				dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmMember, global::System.Data.Entity.Core.Query.PlanCompiler.GroupAggregateVarRefInfo>();
				this._groupAggregateVarRelatedVarPropertyToInfo.Add(var, dictionary);
			}
			dictionary.Add(property, new global::System.Data.Entity.Core.Query.PlanCompiler.GroupAggregateVarRefInfo(groupAggregateVarInfo, computationTemplate, isUnnested));
			this._groupAggregateVarInfos.Add(groupAggregateVarInfo);
		}

		// Token: 0x060027DB RID: 10203 RVA: 0x00074E7D File Offset: 0x0007307D
		internal bool TryGetReferencedGroupAggregateVarInfo(global::System.Data.Entity.Core.Query.InternalTrees.Var var, out global::System.Data.Entity.Core.Query.PlanCompiler.GroupAggregateVarRefInfo groupAggregateVarRefInfo)
		{
			return this._groupAggregateVarRelatedVarToInfo.TryGetValue(var, out groupAggregateVarRefInfo);
		}

		// Token: 0x060027DC RID: 10204 RVA: 0x00074E8C File Offset: 0x0007308C
		internal bool TryGetReferencedGroupAggregateVarInfo(global::System.Data.Entity.Core.Query.InternalTrees.Var var, global::System.Data.Entity.Core.Metadata.Edm.EdmMember property, out global::System.Data.Entity.Core.Query.PlanCompiler.GroupAggregateVarRefInfo groupAggregateVarRefInfo)
		{
			if (property == null)
			{
				return this.TryGetReferencedGroupAggregateVarInfo(var, out groupAggregateVarRefInfo);
			}
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmMember, global::System.Data.Entity.Core.Query.PlanCompiler.GroupAggregateVarRefInfo> dictionary;
			if (this._groupAggregateVarRelatedVarPropertyToInfo == null || !this._groupAggregateVarRelatedVarPropertyToInfo.TryGetValue(var, out dictionary))
			{
				groupAggregateVarRefInfo = null;
				return false;
			}
			return dictionary.TryGetValue(property, out groupAggregateVarRefInfo);
		}

		// Token: 0x04000DEB RID: 3563
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.PlanCompiler.GroupAggregateVarRefInfo> _groupAggregateVarRelatedVarToInfo = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.PlanCompiler.GroupAggregateVarRefInfo>();

		// Token: 0x04000DEC RID: 3564
		private global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmMember, global::System.Data.Entity.Core.Query.PlanCompiler.GroupAggregateVarRefInfo>> _groupAggregateVarRelatedVarPropertyToInfo;

		// Token: 0x04000DED RID: 3565
		private readonly global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Query.PlanCompiler.GroupAggregateVarInfo> _groupAggregateVarInfos = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Query.PlanCompiler.GroupAggregateVarInfo>();
	}
}
