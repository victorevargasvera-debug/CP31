using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Query.InternalTrees;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x02000378 RID: 888
	internal class VarInfoMap
	{
		// Token: 0x06002AE3 RID: 10979 RVA: 0x0008BE9D File Offset: 0x0008A09D
		internal VarInfoMap()
		{
			this.m_map = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.PlanCompiler.VarInfo>();
		}

		// Token: 0x06002AE4 RID: 10980 RVA: 0x0008BEB0 File Offset: 0x0008A0B0
		internal global::System.Data.Entity.Core.Query.PlanCompiler.VarInfo CreateStructuredVarInfo(global::System.Data.Entity.Core.Query.InternalTrees.Var v, global::System.Data.Entity.Core.Metadata.Edm.RowType newType, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var> newVars, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> newProperties, bool newVarsIncludeNullSentinelVar)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.VarInfo varInfo = new global::System.Data.Entity.Core.Query.PlanCompiler.StructuredVarInfo(newType, newVars, newProperties, newVarsIncludeNullSentinelVar);
			this.m_map.Add(v, varInfo);
			return varInfo;
		}

		// Token: 0x06002AE5 RID: 10981 RVA: 0x0008BED7 File Offset: 0x0008A0D7
		internal global::System.Data.Entity.Core.Query.PlanCompiler.VarInfo CreateStructuredVarInfo(global::System.Data.Entity.Core.Query.InternalTrees.Var v, global::System.Data.Entity.Core.Metadata.Edm.RowType newType, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var> newVars, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> newProperties)
		{
			return this.CreateStructuredVarInfo(v, newType, newVars, newProperties, false);
		}

		// Token: 0x06002AE6 RID: 10982 RVA: 0x0008BEE8 File Offset: 0x0008A0E8
		internal global::System.Data.Entity.Core.Query.PlanCompiler.VarInfo CreateCollectionVarInfo(global::System.Data.Entity.Core.Query.InternalTrees.Var v, global::System.Data.Entity.Core.Query.InternalTrees.Var newVar)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.VarInfo varInfo = new global::System.Data.Entity.Core.Query.PlanCompiler.CollectionVarInfo(newVar);
			this.m_map.Add(v, varInfo);
			return varInfo;
		}

		// Token: 0x06002AE7 RID: 10983 RVA: 0x0008BF0C File Offset: 0x0008A10C
		internal global::System.Data.Entity.Core.Query.PlanCompiler.VarInfo CreatePrimitiveTypeVarInfo(global::System.Data.Entity.Core.Query.InternalTrees.Var v, global::System.Data.Entity.Core.Query.InternalTrees.Var newVar)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsScalarType(v.Type), "The current variable should be of primitive or enum type.");
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsScalarType(newVar.Type), "The new variable should be of primitive or enum type.");
			global::System.Data.Entity.Core.Query.PlanCompiler.VarInfo varInfo = new global::System.Data.Entity.Core.Query.PlanCompiler.PrimitiveTypeVarInfo(newVar);
			this.m_map.Add(v, varInfo);
			return varInfo;
		}

		// Token: 0x06002AE8 RID: 10984 RVA: 0x0008BF58 File Offset: 0x0008A158
		internal bool TryGetVarInfo(global::System.Data.Entity.Core.Query.InternalTrees.Var v, out global::System.Data.Entity.Core.Query.PlanCompiler.VarInfo varInfo)
		{
			return this.m_map.TryGetValue(v, out varInfo);
		}

		// Token: 0x04000ED4 RID: 3796
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.PlanCompiler.VarInfo> m_map;
	}
}
