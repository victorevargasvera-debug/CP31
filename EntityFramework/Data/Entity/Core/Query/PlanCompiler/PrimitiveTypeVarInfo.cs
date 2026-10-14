using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Query.InternalTrees;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x0200035B RID: 859
	internal class PrimitiveTypeVarInfo : global::System.Data.Entity.Core.Query.PlanCompiler.VarInfo
	{
		// Token: 0x060029BD RID: 10685 RVA: 0x00086938 File Offset: 0x00084B38
		internal PrimitiveTypeVarInfo(global::System.Data.Entity.Core.Query.InternalTrees.Var newVar)
		{
			this.m_newVars = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var>
			{
				newVar
			};
		}

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x060029BE RID: 10686 RVA: 0x00086952 File Offset: 0x00084B52
		internal global::System.Data.Entity.Core.Query.InternalTrees.Var NewVar
		{
			get
			{
				return this.m_newVars[0];
			}
		}

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x060029BF RID: 10687 RVA: 0x00086960 File Offset: 0x00084B60
		internal override global::System.Data.Entity.Core.Query.PlanCompiler.VarInfoKind Kind
		{
			get
			{
				return global::System.Data.Entity.Core.Query.PlanCompiler.VarInfoKind.PrimitiveTypeVarInfo;
			}
		}

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x060029C0 RID: 10688 RVA: 0x00086963 File Offset: 0x00084B63
		internal override global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var> NewVars
		{
			get
			{
				return this.m_newVars;
			}
		}

		// Token: 0x04000E65 RID: 3685
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var> m_newVars;
	}
}
