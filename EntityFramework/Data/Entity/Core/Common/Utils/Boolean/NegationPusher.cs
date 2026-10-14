using System;
using System.Linq;

namespace System.Data.Entity.Core.Common.Utils.Boolean
{
	// Token: 0x02000619 RID: 1561
	internal static class NegationPusher
	{
		// Token: 0x06004BD0 RID: 19408 RVA: 0x0010A810 File Offset: 0x00108A10
		internal static global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<T_Variable, T_Element>> EliminateNot<T_Variable, T_Element>(global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<T_Variable, T_Element>> expression)
		{
			return expression.Accept<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<T_Variable, T_Element>>>(global::System.Data.Entity.Core.Common.Utils.Boolean.NegationPusher.NonNegatedDomainConstraintTreeVisitor<T_Variable, T_Element>.Instance);
		}

		// Token: 0x02000C55 RID: 3157
		private class NonNegatedTreeVisitor<T_Identifier> : global::System.Data.Entity.Core.Common.Utils.Boolean.BasicVisitor<T_Identifier>
		{
			// Token: 0x06006AB6 RID: 27318 RVA: 0x0016BC0C File Offset: 0x00169E0C
			protected NonNegatedTreeVisitor()
			{
			}

			// Token: 0x06006AB7 RID: 27319 RVA: 0x0016BC14 File Offset: 0x00169E14
			internal override global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> VisitNot(global::System.Data.Entity.Core.Common.Utils.Boolean.NotExpr<T_Identifier> expression)
			{
				return expression.Child.Accept<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier>>(global::System.Data.Entity.Core.Common.Utils.Boolean.NegationPusher.NegatedTreeVisitor<T_Identifier>.Instance);
			}

			// Token: 0x040030E0 RID: 12512
			internal static readonly global::System.Data.Entity.Core.Common.Utils.Boolean.NegationPusher.NonNegatedTreeVisitor<T_Identifier> Instance = new global::System.Data.Entity.Core.Common.Utils.Boolean.NegationPusher.NonNegatedTreeVisitor<T_Identifier>();
		}

		// Token: 0x02000C56 RID: 3158
		private class NegatedTreeVisitor<T_Identifier> : global::System.Data.Entity.Core.Common.Utils.Boolean.Visitor<T_Identifier, global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier>>
		{
			// Token: 0x06006AB9 RID: 27321 RVA: 0x0016BC32 File Offset: 0x00169E32
			protected NegatedTreeVisitor()
			{
			}

			// Token: 0x06006ABA RID: 27322 RVA: 0x0016BC3A File Offset: 0x00169E3A
			internal override global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> VisitTrue(global::System.Data.Entity.Core.Common.Utils.Boolean.TrueExpr<T_Identifier> expression)
			{
				return global::System.Data.Entity.Core.Common.Utils.Boolean.FalseExpr<T_Identifier>.Value;
			}

			// Token: 0x06006ABB RID: 27323 RVA: 0x0016BC41 File Offset: 0x00169E41
			internal override global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> VisitFalse(global::System.Data.Entity.Core.Common.Utils.Boolean.FalseExpr<T_Identifier> expression)
			{
				return global::System.Data.Entity.Core.Common.Utils.Boolean.TrueExpr<T_Identifier>.Value;
			}

			// Token: 0x06006ABC RID: 27324 RVA: 0x0016BC48 File Offset: 0x00169E48
			internal override global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> VisitTerm(global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<T_Identifier> expression)
			{
				return new global::System.Data.Entity.Core.Common.Utils.Boolean.NotExpr<T_Identifier>(expression);
			}

			// Token: 0x06006ABD RID: 27325 RVA: 0x0016BC50 File Offset: 0x00169E50
			internal override global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> VisitNot(global::System.Data.Entity.Core.Common.Utils.Boolean.NotExpr<T_Identifier> expression)
			{
				return expression.Child.Accept<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier>>(global::System.Data.Entity.Core.Common.Utils.Boolean.NegationPusher.NonNegatedTreeVisitor<T_Identifier>.Instance);
			}

			// Token: 0x06006ABE RID: 27326 RVA: 0x0016BC62 File Offset: 0x00169E62
			internal override global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> VisitAnd(global::System.Data.Entity.Core.Common.Utils.Boolean.AndExpr<T_Identifier> expression)
			{
				return new global::System.Data.Entity.Core.Common.Utils.Boolean.OrExpr<T_Identifier>(from child in expression.Children
				select child.Accept<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier>>(this));
			}

			// Token: 0x06006ABF RID: 27327 RVA: 0x0016BC80 File Offset: 0x00169E80
			internal override global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> VisitOr(global::System.Data.Entity.Core.Common.Utils.Boolean.OrExpr<T_Identifier> expression)
			{
				return new global::System.Data.Entity.Core.Common.Utils.Boolean.AndExpr<T_Identifier>(from child in expression.Children
				select child.Accept<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier>>(this));
			}

			// Token: 0x040030E1 RID: 12513
			internal static readonly global::System.Data.Entity.Core.Common.Utils.Boolean.NegationPusher.NegatedTreeVisitor<T_Identifier> Instance = new global::System.Data.Entity.Core.Common.Utils.Boolean.NegationPusher.NegatedTreeVisitor<T_Identifier>();
		}

		// Token: 0x02000C57 RID: 3159
		private class NonNegatedDomainConstraintTreeVisitor<T_Variable, T_Element> : global::System.Data.Entity.Core.Common.Utils.Boolean.NegationPusher.NonNegatedTreeVisitor<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<T_Variable, T_Element>>
		{
			// Token: 0x06006AC3 RID: 27331 RVA: 0x0016BCBC File Offset: 0x00169EBC
			private NonNegatedDomainConstraintTreeVisitor()
			{
			}

			// Token: 0x06006AC4 RID: 27332 RVA: 0x0016BCC4 File Offset: 0x00169EC4
			internal override global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<T_Variable, T_Element>> VisitNot(global::System.Data.Entity.Core.Common.Utils.Boolean.NotExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<T_Variable, T_Element>> expression)
			{
				return expression.Child.Accept<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<T_Variable, T_Element>>>(global::System.Data.Entity.Core.Common.Utils.Boolean.NegationPusher.NegatedDomainConstraintTreeVisitor<T_Variable, T_Element>.Instance);
			}

			// Token: 0x040030E2 RID: 12514
			internal new static readonly global::System.Data.Entity.Core.Common.Utils.Boolean.NegationPusher.NonNegatedDomainConstraintTreeVisitor<T_Variable, T_Element> Instance = new global::System.Data.Entity.Core.Common.Utils.Boolean.NegationPusher.NonNegatedDomainConstraintTreeVisitor<T_Variable, T_Element>();
		}

		// Token: 0x02000C58 RID: 3160
		private class NegatedDomainConstraintTreeVisitor<T_Variable, T_Element> : global::System.Data.Entity.Core.Common.Utils.Boolean.NegationPusher.NegatedTreeVisitor<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<T_Variable, T_Element>>
		{
			// Token: 0x06006AC6 RID: 27334 RVA: 0x0016BCE2 File Offset: 0x00169EE2
			private NegatedDomainConstraintTreeVisitor()
			{
			}

			// Token: 0x06006AC7 RID: 27335 RVA: 0x0016BCEA File Offset: 0x00169EEA
			internal override global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<T_Variable, T_Element>> VisitNot(global::System.Data.Entity.Core.Common.Utils.Boolean.NotExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<T_Variable, T_Element>> expression)
			{
				return expression.Child.Accept<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<T_Variable, T_Element>>>(global::System.Data.Entity.Core.Common.Utils.Boolean.NegationPusher.NonNegatedDomainConstraintTreeVisitor<T_Variable, T_Element>.Instance);
			}

			// Token: 0x06006AC8 RID: 27336 RVA: 0x0016BCFC File Offset: 0x00169EFC
			internal override global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<T_Variable, T_Element>> VisitTerm(global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<T_Variable, T_Element>> expression)
			{
				return new global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<T_Variable, T_Element>>(expression.Identifier.InvertDomainConstraint());
			}

			// Token: 0x040030E3 RID: 12515
			internal new static readonly global::System.Data.Entity.Core.Common.Utils.Boolean.NegationPusher.NegatedDomainConstraintTreeVisitor<T_Variable, T_Element> Instance = new global::System.Data.Entity.Core.Common.Utils.Boolean.NegationPusher.NegatedDomainConstraintTreeVisitor<T_Variable, T_Element>();
		}
	}
}
