using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Query.InternalTrees;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x02000376 RID: 886
	internal abstract class VarInfo
	{
		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x06002AE0 RID: 10976
		internal abstract global::System.Data.Entity.Core.Query.PlanCompiler.VarInfoKind Kind { get; }

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x06002AE1 RID: 10977 RVA: 0x0008BE92 File Offset: 0x0008A092
		internal virtual global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var> NewVars
		{
			get
			{
				return null;
			}
		}
	}
}
