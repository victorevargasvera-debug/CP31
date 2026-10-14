using System;

namespace System.Data.Entity.Core.Common.Utils.Boolean
{
	// Token: 0x02000612 RID: 1554
	internal sealed class FalseExpr<T_Identifier> : global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier>
	{
		// Token: 0x06004BA5 RID: 19365 RVA: 0x0010A30D File Offset: 0x0010850D
		private FalseExpr()
		{
		}

		// Token: 0x17000EC3 RID: 3779
		// (get) Token: 0x06004BA6 RID: 19366 RVA: 0x0010A315 File Offset: 0x00108515
		internal static global::System.Data.Entity.Core.Common.Utils.Boolean.FalseExpr<T_Identifier> Value
		{
			get
			{
				return global::System.Data.Entity.Core.Common.Utils.Boolean.FalseExpr<T_Identifier>._value;
			}
		}

		// Token: 0x17000EC4 RID: 3780
		// (get) Token: 0x06004BA7 RID: 19367 RVA: 0x0010A31C File Offset: 0x0010851C
		internal override global::System.Data.Entity.Core.Common.Utils.Boolean.ExprType ExprType
		{
			get
			{
				return global::System.Data.Entity.Core.Common.Utils.Boolean.ExprType.False;
			}
		}

		// Token: 0x06004BA8 RID: 19368 RVA: 0x0010A31F File Offset: 0x0010851F
		internal override T_Return Accept<T_Return>(global::System.Data.Entity.Core.Common.Utils.Boolean.Visitor<T_Identifier, T_Return> visitor)
		{
			return visitor.VisitFalse(this);
		}

		// Token: 0x06004BA9 RID: 19369 RVA: 0x0010A328 File Offset: 0x00108528
		internal override global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> MakeNegated()
		{
			return global::System.Data.Entity.Core.Common.Utils.Boolean.TrueExpr<T_Identifier>.Value;
		}

		// Token: 0x06004BAA RID: 19370 RVA: 0x0010A32F File Offset: 0x0010852F
		protected override bool EquivalentTypeEquals(global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> other)
		{
			return this == other;
		}

		// Token: 0x04001A74 RID: 6772
		private static readonly global::System.Data.Entity.Core.Common.Utils.Boolean.FalseExpr<T_Identifier> _value = new global::System.Data.Entity.Core.Common.Utils.Boolean.FalseExpr<T_Identifier>();
	}
}
