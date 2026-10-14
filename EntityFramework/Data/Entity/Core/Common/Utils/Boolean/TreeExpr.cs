using System;
using System.Collections.Generic;

namespace System.Data.Entity.Core.Common.Utils.Boolean
{
	// Token: 0x02000624 RID: 1572
	internal abstract class TreeExpr<T_Identifier> : global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier>
	{
		// Token: 0x06004C1A RID: 19482 RVA: 0x0010B249 File Offset: 0x00109449
		protected TreeExpr(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier>> children)
		{
			this._children = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier>>(children);
			this._children.MakeReadOnly();
			this._hashCode = this._children.GetElementsHashCode();
		}

		// Token: 0x17000ECE RID: 3790
		// (get) Token: 0x06004C1B RID: 19483 RVA: 0x0010B27A File Offset: 0x0010947A
		internal global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier>> Children
		{
			get
			{
				return this._children;
			}
		}

		// Token: 0x06004C1C RID: 19484 RVA: 0x0010B282 File Offset: 0x00109482
		public override bool Equals(object obj)
		{
			return base.Equals(obj as global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier>);
		}

		// Token: 0x06004C1D RID: 19485 RVA: 0x0010B290 File Offset: 0x00109490
		public override int GetHashCode()
		{
			return this._hashCode;
		}

		// Token: 0x06004C1E RID: 19486 RVA: 0x0010B298 File Offset: 0x00109498
		public override string ToString()
		{
			return global::System.Data.Entity.Core.Common.Utils.StringUtil.FormatInvariant("{0}({1})", new object[]
			{
				this.ExprType,
				this._children
			});
		}

		// Token: 0x06004C1F RID: 19487 RVA: 0x0010B2C1 File Offset: 0x001094C1
		protected override bool EquivalentTypeEquals(global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> other)
		{
			return ((global::System.Data.Entity.Core.Common.Utils.Boolean.TreeExpr<T_Identifier>)other).Children.SetEquals(this.Children);
		}

		// Token: 0x04001A8E RID: 6798
		private readonly global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier>> _children;

		// Token: 0x04001A8F RID: 6799
		private readonly int _hashCode;
	}
}
