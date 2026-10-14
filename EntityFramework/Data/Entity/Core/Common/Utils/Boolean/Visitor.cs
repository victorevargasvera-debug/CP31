using System;

namespace System.Data.Entity.Core.Common.Utils.Boolean
{
	// Token: 0x02000627 RID: 1575
	internal abstract class Visitor<T_Identifier, T_Return>
	{
		// Token: 0x06004C32 RID: 19506
		internal abstract T_Return VisitTrue(global::System.Data.Entity.Core.Common.Utils.Boolean.TrueExpr<T_Identifier> expression);

		// Token: 0x06004C33 RID: 19507
		internal abstract T_Return VisitFalse(global::System.Data.Entity.Core.Common.Utils.Boolean.FalseExpr<T_Identifier> expression);

		// Token: 0x06004C34 RID: 19508
		internal abstract T_Return VisitTerm(global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<T_Identifier> expression);

		// Token: 0x06004C35 RID: 19509
		internal abstract T_Return VisitNot(global::System.Data.Entity.Core.Common.Utils.Boolean.NotExpr<T_Identifier> expression);

		// Token: 0x06004C36 RID: 19510
		internal abstract T_Return VisitAnd(global::System.Data.Entity.Core.Common.Utils.Boolean.AndExpr<T_Identifier> expression);

		// Token: 0x06004C37 RID: 19511
		internal abstract T_Return VisitOr(global::System.Data.Entity.Core.Common.Utils.Boolean.OrExpr<T_Identifier> expression);
	}
}
