using System;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003CB RID: 971
	internal sealed class ParameterVar : global::System.Data.Entity.Core.Query.InternalTrees.Var
	{
		// Token: 0x06002E90 RID: 11920 RVA: 0x00093C2E File Offset: 0x00091E2E
		internal ParameterVar(int id, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, string paramName) : base(id, global::System.Data.Entity.Core.Query.InternalTrees.VarType.Parameter, type)
		{
			this.m_paramName = paramName;
		}

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x06002E91 RID: 11921 RVA: 0x00093C40 File Offset: 0x00091E40
		internal string ParameterName
		{
			get
			{
				return this.m_paramName;
			}
		}

		// Token: 0x06002E92 RID: 11922 RVA: 0x00093C48 File Offset: 0x00091E48
		internal override bool TryGetName(out string name)
		{
			name = this.ParameterName;
			return true;
		}

		// Token: 0x04000FB6 RID: 4022
		private readonly string m_paramName;
	}
}
