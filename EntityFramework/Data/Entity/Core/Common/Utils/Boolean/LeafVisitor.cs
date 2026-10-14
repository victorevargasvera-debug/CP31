using System;
using System.Collections.Generic;
using System.Linq;

namespace System.Data.Entity.Core.Common.Utils.Boolean
{
	// Token: 0x02000616 RID: 1558
	internal class LeafVisitor<T_Identifier> : global::System.Data.Entity.Core.Common.Utils.Boolean.Visitor<T_Identifier, bool>
	{
		// Token: 0x06004BBD RID: 19389 RVA: 0x0010A65C File Offset: 0x0010885C
		private LeafVisitor()
		{
			this._terms = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<T_Identifier>>();
		}

		// Token: 0x06004BBE RID: 19390 RVA: 0x0010A670 File Offset: 0x00108870
		internal static global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<T_Identifier>> GetTerms(global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> expression)
		{
			global::System.Data.Entity.Core.Common.Utils.Boolean.LeafVisitor<T_Identifier> leafVisitor = new global::System.Data.Entity.Core.Common.Utils.Boolean.LeafVisitor<T_Identifier>();
			expression.Accept<bool>(leafVisitor);
			return leafVisitor._terms;
		}

		// Token: 0x06004BBF RID: 19391 RVA: 0x0010A691 File Offset: 0x00108891
		internal static global::System.Collections.Generic.IEnumerable<T_Identifier> GetLeaves(global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> expression)
		{
			return from term in global::System.Data.Entity.Core.Common.Utils.Boolean.LeafVisitor<T_Identifier>.GetTerms(expression)
			select term.Identifier;
		}

		// Token: 0x06004BC0 RID: 19392 RVA: 0x0010A6BD File Offset: 0x001088BD
		internal override bool VisitTrue(global::System.Data.Entity.Core.Common.Utils.Boolean.TrueExpr<T_Identifier> expression)
		{
			return true;
		}

		// Token: 0x06004BC1 RID: 19393 RVA: 0x0010A6C0 File Offset: 0x001088C0
		internal override bool VisitFalse(global::System.Data.Entity.Core.Common.Utils.Boolean.FalseExpr<T_Identifier> expression)
		{
			return true;
		}

		// Token: 0x06004BC2 RID: 19394 RVA: 0x0010A6C3 File Offset: 0x001088C3
		internal override bool VisitTerm(global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<T_Identifier> expression)
		{
			this._terms.Add(expression);
			return true;
		}

		// Token: 0x06004BC3 RID: 19395 RVA: 0x0010A6D2 File Offset: 0x001088D2
		internal override bool VisitNot(global::System.Data.Entity.Core.Common.Utils.Boolean.NotExpr<T_Identifier> expression)
		{
			return expression.Child.Accept<bool>(this);
		}

		// Token: 0x06004BC4 RID: 19396 RVA: 0x0010A6E0 File Offset: 0x001088E0
		internal override bool VisitAnd(global::System.Data.Entity.Core.Common.Utils.Boolean.AndExpr<T_Identifier> expression)
		{
			return this.VisitTree(expression);
		}

		// Token: 0x06004BC5 RID: 19397 RVA: 0x0010A6E9 File Offset: 0x001088E9
		internal override bool VisitOr(global::System.Data.Entity.Core.Common.Utils.Boolean.OrExpr<T_Identifier> expression)
		{
			return this.VisitTree(expression);
		}

		// Token: 0x06004BC6 RID: 19398 RVA: 0x0010A6F4 File Offset: 0x001088F4
		private bool VisitTree(global::System.Data.Entity.Core.Common.Utils.Boolean.TreeExpr<T_Identifier> expression)
		{
			foreach (global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> boolExpr in expression.Children)
			{
				boolExpr.Accept<bool>(this);
			}
			return true;
		}

		// Token: 0x04001A7B RID: 6779
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<T_Identifier>> _terms;
	}
}
