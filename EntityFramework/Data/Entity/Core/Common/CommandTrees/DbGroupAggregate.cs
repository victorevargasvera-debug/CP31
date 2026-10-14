using System;
using System.Data.Entity.Core.Common.CommandTrees.Internal;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006C0 RID: 1728
	public sealed class DbGroupAggregate : global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate
	{
		// Token: 0x060050F3 RID: 20723 RVA: 0x0012190A File Offset: 0x0011FB0A
		internal DbGroupAggregate(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage resultType, global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList arguments) : base(resultType, arguments)
		{
		}
	}
}
