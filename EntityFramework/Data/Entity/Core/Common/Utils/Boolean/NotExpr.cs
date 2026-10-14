using System;
using System.Globalization;
using System.Linq;

namespace System.Data.Entity.Core.Common.Utils.Boolean
{
	// Token: 0x0200061B RID: 1563
	internal sealed class NotExpr<T_Identifier> : global::System.Data.Entity.Core.Common.Utils.Boolean.TreeExpr<T_Identifier>
	{
		// Token: 0x06004BD4 RID: 19412 RVA: 0x0010A846 File Offset: 0x00108A46
		internal NotExpr(global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> child) : base(new global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier>[]
		{
			child
		})
		{
		}

		// Token: 0x17000EC9 RID: 3785
		// (get) Token: 0x06004BD5 RID: 19413 RVA: 0x0010A858 File Offset: 0x00108A58
		internal override global::System.Data.Entity.Core.Common.Utils.Boolean.ExprType ExprType
		{
			get
			{
				return global::System.Data.Entity.Core.Common.Utils.Boolean.ExprType.Not;
			}
		}

		// Token: 0x17000ECA RID: 3786
		// (get) Token: 0x06004BD6 RID: 19414 RVA: 0x0010A85B File Offset: 0x00108A5B
		internal global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> Child
		{
			get
			{
				return base.Children.First<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier>>();
			}
		}

		// Token: 0x06004BD7 RID: 19415 RVA: 0x0010A868 File Offset: 0x00108A68
		internal override T_Return Accept<T_Return>(global::System.Data.Entity.Core.Common.Utils.Boolean.Visitor<T_Identifier, T_Return> visitor)
		{
			return visitor.VisitNot(this);
		}

		// Token: 0x06004BD8 RID: 19416 RVA: 0x0010A871 File Offset: 0x00108A71
		public override string ToString()
		{
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "!{0}", new object[]
			{
				this.Child
			});
		}

		// Token: 0x06004BD9 RID: 19417 RVA: 0x0010A891 File Offset: 0x00108A91
		internal override global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> MakeNegated()
		{
			return this.Child;
		}
	}
}
