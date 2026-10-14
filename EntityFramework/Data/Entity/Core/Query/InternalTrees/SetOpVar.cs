using System;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003E3 RID: 995
	internal sealed class SetOpVar : global::System.Data.Entity.Core.Query.InternalTrees.Var
	{
		// Token: 0x06002F05 RID: 12037 RVA: 0x00094529 File Offset: 0x00092729
		internal SetOpVar(int id, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type) : base(id, global::System.Data.Entity.Core.Query.InternalTrees.VarType.SetOp, type)
		{
		}
	}
}
