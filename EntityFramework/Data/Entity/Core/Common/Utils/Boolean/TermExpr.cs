using System;
using System.Collections.Generic;

namespace System.Data.Entity.Core.Common.Utils.Boolean
{
	// Token: 0x02000622 RID: 1570
	internal sealed class TermExpr<T_Identifier> : global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier>, global::System.IEquatable<global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<T_Identifier>>
	{
		// Token: 0x06004C05 RID: 19461 RVA: 0x0010B090 File Offset: 0x00109290
		internal TermExpr(global::System.Collections.Generic.IEqualityComparer<T_Identifier> comparer, T_Identifier identifier)
		{
			this._identifier = identifier;
			if (comparer == null)
			{
				this._comparer = global::System.Collections.Generic.EqualityComparer<T_Identifier>.Default;
				return;
			}
			this._comparer = comparer;
		}

		// Token: 0x06004C06 RID: 19462 RVA: 0x0010B0B5 File Offset: 0x001092B5
		internal TermExpr(T_Identifier identifier) : this(null, identifier)
		{
		}

		// Token: 0x17000ECC RID: 3788
		// (get) Token: 0x06004C07 RID: 19463 RVA: 0x0010B0BF File Offset: 0x001092BF
		internal T_Identifier Identifier
		{
			get
			{
				return this._identifier;
			}
		}

		// Token: 0x17000ECD RID: 3789
		// (get) Token: 0x06004C08 RID: 19464 RVA: 0x0010B0C7 File Offset: 0x001092C7
		internal override global::System.Data.Entity.Core.Common.Utils.Boolean.ExprType ExprType
		{
			get
			{
				return global::System.Data.Entity.Core.Common.Utils.Boolean.ExprType.Term;
			}
		}

		// Token: 0x06004C09 RID: 19465 RVA: 0x0010B0CA File Offset: 0x001092CA
		public override bool Equals(object obj)
		{
			return this.Equals(obj as global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<T_Identifier>);
		}

		// Token: 0x06004C0A RID: 19466 RVA: 0x0010B0D8 File Offset: 0x001092D8
		public bool Equals(global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<T_Identifier> other)
		{
			return this._comparer.Equals(this._identifier, other._identifier);
		}

		// Token: 0x06004C0B RID: 19467 RVA: 0x0010B0F1 File Offset: 0x001092F1
		protected override bool EquivalentTypeEquals(global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> other)
		{
			return this._comparer.Equals(this._identifier, ((global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<T_Identifier>)other)._identifier);
		}

		// Token: 0x06004C0C RID: 19468 RVA: 0x0010B10F File Offset: 0x0010930F
		public override int GetHashCode()
		{
			return this._comparer.GetHashCode(this._identifier);
		}

		// Token: 0x06004C0D RID: 19469 RVA: 0x0010B122 File Offset: 0x00109322
		public override string ToString()
		{
			return global::System.Data.Entity.Core.Common.Utils.StringUtil.FormatInvariant("{0}", new object[]
			{
				this._identifier
			});
		}

		// Token: 0x06004C0E RID: 19470 RVA: 0x0010B142 File Offset: 0x00109342
		internal override T_Return Accept<T_Return>(global::System.Data.Entity.Core.Common.Utils.Boolean.Visitor<T_Identifier, T_Return> visitor)
		{
			return visitor.VisitTerm(this);
		}

		// Token: 0x06004C0F RID: 19471 RVA: 0x0010B14C File Offset: 0x0010934C
		internal override global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> MakeNegated()
		{
			global::System.Data.Entity.Core.Common.Utils.Boolean.Literal<T_Identifier> literal = new global::System.Data.Entity.Core.Common.Utils.Boolean.Literal<T_Identifier>(this, true).MakeNegated();
			if (literal.IsTermPositive)
			{
				return literal.Term;
			}
			return new global::System.Data.Entity.Core.Common.Utils.Boolean.NotExpr<T_Identifier>(literal.Term);
		}

		// Token: 0x04001A8B RID: 6795
		private readonly T_Identifier _identifier;

		// Token: 0x04001A8C RID: 6796
		private readonly global::System.Collections.Generic.IEqualityComparer<T_Identifier> _comparer;
	}
}
