using System;
using System.Collections.Generic;

namespace System.Data.Entity.Core.Common.Utils.Boolean
{
	// Token: 0x02000603 RID: 1539
	internal class AndExpr<T_Identifier> : global::System.Data.Entity.Core.Common.Utils.Boolean.TreeExpr<T_Identifier>
	{
		// Token: 0x06004B5B RID: 19291 RVA: 0x00109A03 File Offset: 0x00107C03
		internal AndExpr(params global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier>[] children) : this(children)
		{
		}

		// Token: 0x06004B5C RID: 19292 RVA: 0x00109A0C File Offset: 0x00107C0C
		internal AndExpr(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier>> children) : base(children)
		{
		}

		// Token: 0x17000EB9 RID: 3769
		// (get) Token: 0x06004B5D RID: 19293 RVA: 0x00109A15 File Offset: 0x00107C15
		internal override global::System.Data.Entity.Core.Common.Utils.Boolean.ExprType ExprType
		{
			get
			{
				return global::System.Data.Entity.Core.Common.Utils.Boolean.ExprType.And;
			}
		}

		// Token: 0x06004B5E RID: 19294 RVA: 0x00109A18 File Offset: 0x00107C18
		internal override T_Return Accept<T_Return>(global::System.Data.Entity.Core.Common.Utils.Boolean.Visitor<T_Identifier, T_Return> visitor)
		{
			return visitor.VisitAnd(this);
		}
	}
}
