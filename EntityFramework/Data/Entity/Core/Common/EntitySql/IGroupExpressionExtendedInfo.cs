using System;
using System.Data.Entity.Core.Common.CommandTrees;

namespace System.Data.Entity.Core.Common.EntitySql
{
	// Token: 0x02000659 RID: 1625
	internal interface IGroupExpressionExtendedInfo
	{
		// Token: 0x17000F0B RID: 3851
		// (get) Token: 0x06004E1D RID: 19997
		global::System.Data.Entity.Core.Common.CommandTrees.DbExpression GroupVarBasedExpression { get; }

		// Token: 0x17000F0C RID: 3852
		// (get) Token: 0x06004E1E RID: 19998
		global::System.Data.Entity.Core.Common.CommandTrees.DbExpression GroupAggBasedExpression { get; }
	}
}
