using System;

namespace System.Data.Entity.Core.Common.Utils.Boolean
{
	// Token: 0x02000617 RID: 1559
	internal sealed class Literal<T_Identifier> : global::System.Data.Entity.Core.Common.Utils.Boolean.NormalFormNode<T_Identifier>, global::System.IEquatable<global::System.Data.Entity.Core.Common.Utils.Boolean.Literal<T_Identifier>>
	{
		// Token: 0x06004BC7 RID: 19399 RVA: 0x0010A748 File Offset: 0x00108948
		internal Literal(global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<T_Identifier> term, bool isTermPositive) : base(isTermPositive ? term : new global::System.Data.Entity.Core.Common.Utils.Boolean.NotExpr<T_Identifier>(term))
		{
			this._term = term;
			this._isTermPositive = isTermPositive;
		}

		// Token: 0x17000EC6 RID: 3782
		// (get) Token: 0x06004BC8 RID: 19400 RVA: 0x0010A76A File Offset: 0x0010896A
		internal global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<T_Identifier> Term
		{
			get
			{
				return this._term;
			}
		}

		// Token: 0x17000EC7 RID: 3783
		// (get) Token: 0x06004BC9 RID: 19401 RVA: 0x0010A772 File Offset: 0x00108972
		internal bool IsTermPositive
		{
			get
			{
				return this._isTermPositive;
			}
		}

		// Token: 0x06004BCA RID: 19402 RVA: 0x0010A77A File Offset: 0x0010897A
		internal global::System.Data.Entity.Core.Common.Utils.Boolean.Literal<T_Identifier> MakeNegated()
		{
			return global::System.Data.Entity.Core.Common.Utils.Boolean.IdentifierService<T_Identifier>.Instance.NegateLiteral(this);
		}

		// Token: 0x06004BCB RID: 19403 RVA: 0x0010A787 File Offset: 0x00108987
		public override string ToString()
		{
			return global::System.Data.Entity.Core.Common.Utils.StringUtil.FormatInvariant("{0}{1}", new object[]
			{
				this._isTermPositive ? string.Empty : "!",
				this._term
			});
		}

		// Token: 0x06004BCC RID: 19404 RVA: 0x0010A7B9 File Offset: 0x001089B9
		public override bool Equals(object obj)
		{
			return this.Equals(obj as global::System.Data.Entity.Core.Common.Utils.Boolean.Literal<T_Identifier>);
		}

		// Token: 0x06004BCD RID: 19405 RVA: 0x0010A7C7 File Offset: 0x001089C7
		public bool Equals(global::System.Data.Entity.Core.Common.Utils.Boolean.Literal<T_Identifier> other)
		{
			return other != null && other._isTermPositive == this._isTermPositive && other._term.Equals(this._term);
		}

		// Token: 0x06004BCE RID: 19406 RVA: 0x0010A7ED File Offset: 0x001089ED
		public override int GetHashCode()
		{
			return this._term.GetHashCode();
		}

		// Token: 0x04001A7C RID: 6780
		private readonly global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<T_Identifier> _term;

		// Token: 0x04001A7D RID: 6781
		private readonly bool _isTermPositive;
	}
}
