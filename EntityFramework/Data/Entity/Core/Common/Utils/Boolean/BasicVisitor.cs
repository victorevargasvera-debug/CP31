using System;
using System.Collections.Generic;

namespace System.Data.Entity.Core.Common.Utils.Boolean
{
	// Token: 0x02000604 RID: 1540
	internal abstract class BasicVisitor<T_Identifier> : global::System.Data.Entity.Core.Common.Utils.Boolean.Visitor<T_Identifier, global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier>>
	{
		// Token: 0x06004B5F RID: 19295 RVA: 0x00109A21 File Offset: 0x00107C21
		internal override global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> VisitFalse(global::System.Data.Entity.Core.Common.Utils.Boolean.FalseExpr<T_Identifier> expression)
		{
			return expression;
		}

		// Token: 0x06004B60 RID: 19296 RVA: 0x00109A24 File Offset: 0x00107C24
		internal override global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> VisitTrue(global::System.Data.Entity.Core.Common.Utils.Boolean.TrueExpr<T_Identifier> expression)
		{
			return expression;
		}

		// Token: 0x06004B61 RID: 19297 RVA: 0x00109A27 File Offset: 0x00107C27
		internal override global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> VisitTerm(global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<T_Identifier> expression)
		{
			return expression;
		}

		// Token: 0x06004B62 RID: 19298 RVA: 0x00109A2A File Offset: 0x00107C2A
		internal override global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> VisitNot(global::System.Data.Entity.Core.Common.Utils.Boolean.NotExpr<T_Identifier> expression)
		{
			return new global::System.Data.Entity.Core.Common.Utils.Boolean.NotExpr<T_Identifier>(expression.Child.Accept<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier>>(this));
		}

		// Token: 0x06004B63 RID: 19299 RVA: 0x00109A3D File Offset: 0x00107C3D
		internal override global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> VisitAnd(global::System.Data.Entity.Core.Common.Utils.Boolean.AndExpr<T_Identifier> expression)
		{
			return new global::System.Data.Entity.Core.Common.Utils.Boolean.AndExpr<T_Identifier>(this.AcceptChildren(expression.Children));
		}

		// Token: 0x06004B64 RID: 19300 RVA: 0x00109A50 File Offset: 0x00107C50
		internal override global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> VisitOr(global::System.Data.Entity.Core.Common.Utils.Boolean.OrExpr<T_Identifier> expression)
		{
			return new global::System.Data.Entity.Core.Common.Utils.Boolean.OrExpr<T_Identifier>(this.AcceptChildren(expression.Children));
		}

		// Token: 0x06004B65 RID: 19301 RVA: 0x00109A63 File Offset: 0x00107C63
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier>> AcceptChildren(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier>> children)
		{
			foreach (global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> boolExpr in children)
			{
				yield return boolExpr.Accept<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier>>(this);
			}
			global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier>> enumerator = null;
			yield break;
			yield break;
		}
	}
}
