using System;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x02000391 RID: 913
	internal sealed class ComputedVar : global::System.Data.Entity.Core.Query.InternalTrees.Var
	{
		// Token: 0x06002CB9 RID: 11449 RVA: 0x0008F11F File Offset: 0x0008D31F
		internal ComputedVar(int id, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type) : base(id, global::System.Data.Entity.Core.Query.InternalTrees.VarType.Computed, type)
		{
		}
	}
}
