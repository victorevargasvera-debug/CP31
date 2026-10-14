using System;
using System.Collections.Generic;

namespace System.Data.Entity.Core.Common.Utils.Boolean
{
	// Token: 0x0200061C RID: 1564
	internal class OrExpr<T_Identifier> : global::System.Data.Entity.Core.Common.Utils.Boolean.TreeExpr<T_Identifier>
	{
		// Token: 0x06004BDA RID: 19418 RVA: 0x0010A899 File Offset: 0x00108A99
		internal OrExpr(params global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier>[] children) : this(children)
		{
		}

		// Token: 0x06004BDB RID: 19419 RVA: 0x0010A8A2 File Offset: 0x00108AA2
		internal OrExpr(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier>> children) : base(children)
		{
		}

		// Token: 0x17000ECB RID: 3787
		// (get) Token: 0x06004BDC RID: 19420 RVA: 0x0010A8AB File Offset: 0x00108AAB
		internal override global::System.Data.Entity.Core.Common.Utils.Boolean.ExprType ExprType
		{
			get
			{
				return global::System.Data.Entity.Core.Common.Utils.Boolean.ExprType.Or;
			}
		}

		// Token: 0x06004BDD RID: 19421 RVA: 0x0010A8AE File Offset: 0x00108AAE
		internal override T_Return Accept<T_Return>(global::System.Data.Entity.Core.Common.Utils.Boolean.Visitor<T_Identifier, T_Return> visitor)
		{
			return visitor.VisitOr(this);
		}
	}
}
