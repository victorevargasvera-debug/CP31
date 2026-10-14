using System;

namespace System.Data.Entity.Core.Common.Utils.Boolean
{
	// Token: 0x02000625 RID: 1573
	internal sealed class TrueExpr<T_Identifier> : global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier>
	{
		// Token: 0x06004C20 RID: 19488 RVA: 0x0010B2D9 File Offset: 0x001094D9
		private TrueExpr()
		{
		}

		// Token: 0x17000ECF RID: 3791
		// (get) Token: 0x06004C21 RID: 19489 RVA: 0x0010B2E1 File Offset: 0x001094E1
		internal static global::System.Data.Entity.Core.Common.Utils.Boolean.TrueExpr<T_Identifier> Value
		{
			get
			{
				return global::System.Data.Entity.Core.Common.Utils.Boolean.TrueExpr<T_Identifier>._value;
			}
		}

		// Token: 0x17000ED0 RID: 3792
		// (get) Token: 0x06004C22 RID: 19490 RVA: 0x0010B2E8 File Offset: 0x001094E8
		internal override global::System.Data.Entity.Core.Common.Utils.Boolean.ExprType ExprType
		{
			get
			{
				return global::System.Data.Entity.Core.Common.Utils.Boolean.ExprType.True;
			}
		}

		// Token: 0x06004C23 RID: 19491 RVA: 0x0010B2EB File Offset: 0x001094EB
		internal override T_Return Accept<T_Return>(global::System.Data.Entity.Core.Common.Utils.Boolean.Visitor<T_Identifier, T_Return> visitor)
		{
			return visitor.VisitTrue(this);
		}

		// Token: 0x06004C24 RID: 19492 RVA: 0x0010B2F4 File Offset: 0x001094F4
		internal override global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> MakeNegated()
		{
			return global::System.Data.Entity.Core.Common.Utils.Boolean.FalseExpr<T_Identifier>.Value;
		}

		// Token: 0x06004C25 RID: 19493 RVA: 0x0010B2FB File Offset: 0x001094FB
		protected override bool EquivalentTypeEquals(global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> other)
		{
			return this == other;
		}

		// Token: 0x04001A90 RID: 6800
		private static readonly global::System.Data.Entity.Core.Common.Utils.Boolean.TrueExpr<T_Identifier> _value = new global::System.Data.Entity.Core.Common.Utils.Boolean.TrueExpr<T_Identifier>();
	}
}
