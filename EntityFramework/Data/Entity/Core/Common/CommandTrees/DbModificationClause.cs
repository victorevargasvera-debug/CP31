using System;
using System.Data.Entity.Core.Common.CommandTrees.Internal;
using System.Data.Entity.Core.Common.Utils;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006CE RID: 1742
	public abstract class DbModificationClause
	{
		// Token: 0x0600514B RID: 20811 RVA: 0x00122CB2 File Offset: 0x00120EB2
		internal DbModificationClause()
		{
		}

		// Token: 0x0600514C RID: 20812
		internal abstract void DumpStructure(global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionDumper dumper);

		// Token: 0x0600514D RID: 20813
		internal abstract global::System.Data.Entity.Core.Common.Utils.TreeNode Print(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<global::System.Data.Entity.Core.Common.Utils.TreeNode> visitor);
	}
}
