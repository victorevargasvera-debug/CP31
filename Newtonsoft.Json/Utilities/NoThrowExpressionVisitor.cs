using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000055 RID: 85
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	internal class NoThrowExpressionVisitor : global::System.Linq.Expressions.ExpressionVisitor
	{
		// Token: 0x06000506 RID: 1286 RVA: 0x00015233 File Offset: 0x00013433
		protected override global::System.Linq.Expressions.Expression VisitConditional(global::System.Linq.Expressions.ConditionalExpression node)
		{
			if (node.IfFalse.NodeType == global::System.Linq.Expressions.ExpressionType.Throw)
			{
				return global::System.Linq.Expressions.Expression.Condition(node.Test, node.IfTrue, global::System.Linq.Expressions.Expression.Constant(global::Newtonsoft.Json.Utilities.NoThrowExpressionVisitor.ErrorResult));
			}
			return base.VisitConditional(node);
		}

		// Token: 0x040001C1 RID: 449
		internal static readonly object ErrorResult = new object();
	}
}
