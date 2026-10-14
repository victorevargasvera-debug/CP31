using System;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq.Expressions;

namespace System.Data.Entity.Core.Objects.ELinq
{
	// Token: 0x0200045C RID: 1116
	internal sealed class Binding
	{
		// Token: 0x060036E8 RID: 14056 RVA: 0x000B0562 File Offset: 0x000AE762
		internal Binding(global::System.Linq.Expressions.Expression linqExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression cqtExpression)
		{
			this.LinqExpression = linqExpression;
			this.CqtExpression = cqtExpression;
		}

		// Token: 0x040011CD RID: 4557
		internal readonly global::System.Linq.Expressions.Expression LinqExpression;

		// Token: 0x040011CE RID: 4558
		internal readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpression CqtExpression;
	}
}
