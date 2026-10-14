using System;
using System.Linq.Expressions;

namespace System.Data.Entity.Core.Common.Internal.Materialization
{
	// Token: 0x02000634 RID: 1588
	internal class CollectionTranslatorResult : global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorResult
	{
		// Token: 0x06004C8F RID: 19599 RVA: 0x0010D988 File Offset: 0x0010BB88
		internal CollectionTranslatorResult(global::System.Linq.Expressions.Expression returnedExpression, global::System.Type requestedType, global::System.Linq.Expressions.Expression expressionToGetCoordinator) : base(returnedExpression, requestedType)
		{
			this.ExpressionToGetCoordinator = expressionToGetCoordinator;
		}

		// Token: 0x04001B15 RID: 6933
		internal readonly global::System.Linq.Expressions.Expression ExpressionToGetCoordinator;
	}
}
