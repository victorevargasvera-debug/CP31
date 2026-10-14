using System;

namespace System.Data.Entity.Core.Common.Utils.Boolean
{
	// Token: 0x02000621 RID: 1569
	internal class TermCounter<T_Identifier> : global::System.Data.Entity.Core.Common.Utils.Boolean.Visitor<T_Identifier, int>
	{
		// Token: 0x06004BFB RID: 19451 RVA: 0x0010AFE7 File Offset: 0x001091E7
		internal static int CountTerms(global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> expression)
		{
			return expression.Accept<int>(global::System.Data.Entity.Core.Common.Utils.Boolean.TermCounter<T_Identifier>._instance);
		}

		// Token: 0x06004BFC RID: 19452 RVA: 0x0010AFF4 File Offset: 0x001091F4
		internal override int VisitTrue(global::System.Data.Entity.Core.Common.Utils.Boolean.TrueExpr<T_Identifier> expression)
		{
			return 0;
		}

		// Token: 0x06004BFD RID: 19453 RVA: 0x0010AFF7 File Offset: 0x001091F7
		internal override int VisitFalse(global::System.Data.Entity.Core.Common.Utils.Boolean.FalseExpr<T_Identifier> expression)
		{
			return 0;
		}

		// Token: 0x06004BFE RID: 19454 RVA: 0x0010AFFA File Offset: 0x001091FA
		internal override int VisitTerm(global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<T_Identifier> expression)
		{
			return 1;
		}

		// Token: 0x06004BFF RID: 19455 RVA: 0x0010AFFD File Offset: 0x001091FD
		internal override int VisitNot(global::System.Data.Entity.Core.Common.Utils.Boolean.NotExpr<T_Identifier> expression)
		{
			return expression.Child.Accept<int>(this);
		}

		// Token: 0x06004C00 RID: 19456 RVA: 0x0010B00B File Offset: 0x0010920B
		internal override int VisitAnd(global::System.Data.Entity.Core.Common.Utils.Boolean.AndExpr<T_Identifier> expression)
		{
			return this.VisitTree(expression);
		}

		// Token: 0x06004C01 RID: 19457 RVA: 0x0010B014 File Offset: 0x00109214
		internal override int VisitOr(global::System.Data.Entity.Core.Common.Utils.Boolean.OrExpr<T_Identifier> expression)
		{
			return this.VisitTree(expression);
		}

		// Token: 0x06004C02 RID: 19458 RVA: 0x0010B020 File Offset: 0x00109220
		private int VisitTree(global::System.Data.Entity.Core.Common.Utils.Boolean.TreeExpr<T_Identifier> expression)
		{
			int num = 0;
			foreach (global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> boolExpr in expression.Children)
			{
				num += boolExpr.Accept<int>(this);
			}
			return num;
		}

		// Token: 0x04001A8A RID: 6794
		private static readonly global::System.Data.Entity.Core.Common.Utils.Boolean.TermCounter<T_Identifier> _instance = new global::System.Data.Entity.Core.Common.Utils.Boolean.TermCounter<T_Identifier>();
	}
}
