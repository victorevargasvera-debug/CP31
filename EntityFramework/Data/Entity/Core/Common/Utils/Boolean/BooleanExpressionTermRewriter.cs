using System;
using System.Collections.Generic;

namespace System.Data.Entity.Core.Common.Utils.Boolean
{
	// Token: 0x02000605 RID: 1541
	internal class BooleanExpressionTermRewriter<T_From, T_To> : global::System.Data.Entity.Core.Common.Utils.Boolean.Visitor<T_From, global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_To>>
	{
		// Token: 0x06004B67 RID: 19303 RVA: 0x00109A82 File Offset: 0x00107C82
		internal BooleanExpressionTermRewriter(global::System.Func<global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<T_From>, global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_To>> translator)
		{
			this._translator = translator;
		}

		// Token: 0x06004B68 RID: 19304 RVA: 0x00109A91 File Offset: 0x00107C91
		internal override global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_To> VisitFalse(global::System.Data.Entity.Core.Common.Utils.Boolean.FalseExpr<T_From> expression)
		{
			return global::System.Data.Entity.Core.Common.Utils.Boolean.FalseExpr<T_To>.Value;
		}

		// Token: 0x06004B69 RID: 19305 RVA: 0x00109A98 File Offset: 0x00107C98
		internal override global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_To> VisitTrue(global::System.Data.Entity.Core.Common.Utils.Boolean.TrueExpr<T_From> expression)
		{
			return global::System.Data.Entity.Core.Common.Utils.Boolean.TrueExpr<T_To>.Value;
		}

		// Token: 0x06004B6A RID: 19306 RVA: 0x00109A9F File Offset: 0x00107C9F
		internal override global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_To> VisitNot(global::System.Data.Entity.Core.Common.Utils.Boolean.NotExpr<T_From> expression)
		{
			return new global::System.Data.Entity.Core.Common.Utils.Boolean.NotExpr<T_To>(expression.Child.Accept<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_To>>(this));
		}

		// Token: 0x06004B6B RID: 19307 RVA: 0x00109AB2 File Offset: 0x00107CB2
		internal override global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_To> VisitTerm(global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<T_From> expression)
		{
			return this._translator(expression);
		}

		// Token: 0x06004B6C RID: 19308 RVA: 0x00109AC0 File Offset: 0x00107CC0
		internal override global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_To> VisitAnd(global::System.Data.Entity.Core.Common.Utils.Boolean.AndExpr<T_From> expression)
		{
			return new global::System.Data.Entity.Core.Common.Utils.Boolean.AndExpr<T_To>(this.VisitChildren(expression));
		}

		// Token: 0x06004B6D RID: 19309 RVA: 0x00109ACE File Offset: 0x00107CCE
		internal override global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_To> VisitOr(global::System.Data.Entity.Core.Common.Utils.Boolean.OrExpr<T_From> expression)
		{
			return new global::System.Data.Entity.Core.Common.Utils.Boolean.OrExpr<T_To>(this.VisitChildren(expression));
		}

		// Token: 0x06004B6E RID: 19310 RVA: 0x00109ADC File Offset: 0x00107CDC
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_To>> VisitChildren(global::System.Data.Entity.Core.Common.Utils.Boolean.TreeExpr<T_From> expression)
		{
			foreach (global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_From> boolExpr in expression.Children)
			{
				yield return boolExpr.Accept<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_To>>(this);
			}
			global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_From>>.Enumerator enumerator = default(global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_From>>.Enumerator);
			yield break;
			yield break;
		}

		// Token: 0x04001A5C RID: 6748
		private readonly global::System.Func<global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<T_From>, global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_To>> _translator;
	}
}
