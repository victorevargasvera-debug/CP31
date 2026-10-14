using System;

namespace System.Data.Entity.Core.Common.Utils.Boolean
{
	// Token: 0x0200061A RID: 1562
	internal abstract class NormalFormNode<T_Identifier>
	{
		// Token: 0x06004BD1 RID: 19409 RVA: 0x0010A81D File Offset: 0x00108A1D
		protected NormalFormNode(global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> expr)
		{
			this._expr = expr.Simplify();
		}

		// Token: 0x17000EC8 RID: 3784
		// (get) Token: 0x06004BD2 RID: 19410 RVA: 0x0010A831 File Offset: 0x00108A31
		internal global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> Expr
		{
			get
			{
				return this._expr;
			}
		}

		// Token: 0x06004BD3 RID: 19411 RVA: 0x0010A839 File Offset: 0x00108A39
		protected static global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> ExprSelector<T_NormalFormNode>(T_NormalFormNode node) where T_NormalFormNode : global::System.Data.Entity.Core.Common.Utils.Boolean.NormalFormNode<T_Identifier>
		{
			return node._expr;
		}

		// Token: 0x04001A80 RID: 6784
		private readonly global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> _expr;
	}
}
