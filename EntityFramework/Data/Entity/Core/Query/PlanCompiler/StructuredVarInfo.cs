using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Query.InternalTrees;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x0200036C RID: 876
	internal class StructuredVarInfo : global::System.Data.Entity.Core.Query.PlanCompiler.VarInfo
	{
		// Token: 0x06002A83 RID: 10883 RVA: 0x0008A944 File Offset: 0x00088B44
		internal StructuredVarInfo(global::System.Data.Entity.Core.Metadata.Edm.RowType newType, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var> newVars, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> newTypeProperties, bool newVarsIncludeNullSentinelVar)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(newVars.Count == newTypeProperties.Count, "count mismatch");
			this.m_newVars = newVars;
			this.m_newProperties = newTypeProperties;
			this.m_newType = newType;
			this.m_newVarsIncludeNullSentinelVar = newVarsIncludeNullSentinelVar;
			this.m_newTypeUsage = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(newType);
		}

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x06002A84 RID: 10884 RVA: 0x0008A998 File Offset: 0x00088B98
		internal override global::System.Data.Entity.Core.Query.PlanCompiler.VarInfoKind Kind
		{
			get
			{
				return global::System.Data.Entity.Core.Query.PlanCompiler.VarInfoKind.StructuredTypeVarInfo;
			}
		}

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x06002A85 RID: 10885 RVA: 0x0008A99B File Offset: 0x00088B9B
		internal override global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var> NewVars
		{
			get
			{
				return this.m_newVars;
			}
		}

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x06002A86 RID: 10886 RVA: 0x0008A9A3 File Offset: 0x00088BA3
		internal global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> Fields
		{
			get
			{
				return this.m_newProperties;
			}
		}

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x06002A87 RID: 10887 RVA: 0x0008A9AB File Offset: 0x00088BAB
		internal bool NewVarsIncludeNullSentinelVar
		{
			get
			{
				return this.m_newVarsIncludeNullSentinelVar;
			}
		}

		// Token: 0x06002A88 RID: 10888 RVA: 0x0008A9B3 File Offset: 0x00088BB3
		internal bool TryGetVar(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty p, out global::System.Data.Entity.Core.Query.InternalTrees.Var v)
		{
			if (this.m_propertyToVarMap == null)
			{
				this.InitPropertyToVarMap();
			}
			return this.m_propertyToVarMap.TryGetValue(p, out v);
		}

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x06002A89 RID: 10889 RVA: 0x0008A9D0 File Offset: 0x00088BD0
		internal global::System.Data.Entity.Core.Metadata.Edm.RowType NewType
		{
			get
			{
				return this.m_newType;
			}
		}

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x06002A8A RID: 10890 RVA: 0x0008A9D8 File Offset: 0x00088BD8
		internal global::System.Data.Entity.Core.Metadata.Edm.TypeUsage NewTypeUsage
		{
			get
			{
				return this.m_newTypeUsage;
			}
		}

		// Token: 0x06002A8B RID: 10891 RVA: 0x0008A9E0 File Offset: 0x00088BE0
		private void InitPropertyToVarMap()
		{
			if (this.m_propertyToVarMap == null)
			{
				this.m_propertyToVarMap = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Data.Entity.Core.Query.InternalTrees.Var>();
				global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Query.InternalTrees.Var> enumerator = this.m_newVars.GetEnumerator();
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty key in this.m_newProperties)
				{
					enumerator.MoveNext();
					this.m_propertyToVarMap.Add(key, enumerator.Current);
				}
				enumerator.Dispose();
			}
		}

		// Token: 0x04000EA6 RID: 3750
		private global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Data.Entity.Core.Query.InternalTrees.Var> m_propertyToVarMap;

		// Token: 0x04000EA7 RID: 3751
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var> m_newVars;

		// Token: 0x04000EA8 RID: 3752
		private readonly bool m_newVarsIncludeNullSentinelVar;

		// Token: 0x04000EA9 RID: 3753
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> m_newProperties;

		// Token: 0x04000EAA RID: 3754
		private readonly global::System.Data.Entity.Core.Metadata.Edm.RowType m_newType;

		// Token: 0x04000EAB RID: 3755
		private readonly global::System.Data.Entity.Core.Metadata.Edm.TypeUsage m_newTypeUsage;
	}
}
