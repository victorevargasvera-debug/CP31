using System;
using System.Collections.Generic;
using System.Linq;

namespace System.Data.Entity.Core.Common.Utils.Boolean
{
	// Token: 0x02000606 RID: 1542
	internal abstract class BoolExpr<T_Identifier> : global::System.IEquatable<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier>>
	{
		// Token: 0x17000EBA RID: 3770
		// (get) Token: 0x06004B6F RID: 19311
		internal abstract global::System.Data.Entity.Core.Common.Utils.Boolean.ExprType ExprType { get; }

		// Token: 0x06004B70 RID: 19312
		internal abstract T_Return Accept<T_Return>(global::System.Data.Entity.Core.Common.Utils.Boolean.Visitor<T_Identifier, T_Return> visitor);

		// Token: 0x06004B71 RID: 19313 RVA: 0x00109AF3 File Offset: 0x00107CF3
		internal global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> Simplify()
		{
			return global::System.Data.Entity.Core.Common.Utils.Boolean.IdentifierService<T_Identifier>.Instance.LocalSimplify(this);
		}

		// Token: 0x06004B72 RID: 19314 RVA: 0x00109B00 File Offset: 0x00107D00
		internal global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> ExpensiveSimplify(out global::System.Data.Entity.Core.Common.Utils.Boolean.Converter<T_Identifier> converter)
		{
			global::System.Data.Entity.Core.Common.Utils.Boolean.ConversionContext<T_Identifier> context = global::System.Data.Entity.Core.Common.Utils.Boolean.IdentifierService<T_Identifier>.Instance.CreateConversionContext();
			converter = new global::System.Data.Entity.Core.Common.Utils.Boolean.Converter<T_Identifier>(this, context);
			if (converter.Vertex.IsOne())
			{
				return global::System.Data.Entity.Core.Common.Utils.Boolean.TrueExpr<T_Identifier>.Value;
			}
			if (converter.Vertex.IsZero())
			{
				return global::System.Data.Entity.Core.Common.Utils.Boolean.FalseExpr<T_Identifier>.Value;
			}
			return global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier>.ChooseCandidate(new global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier>[]
			{
				this,
				converter.Cnf.Expr,
				converter.Dnf.Expr
			});
		}

		// Token: 0x06004B73 RID: 19315 RVA: 0x00109B78 File Offset: 0x00107D78
		private static global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> ChooseCandidate(params global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier>[] candidates)
		{
			int num = 0;
			int num2 = 0;
			global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> boolExpr = null;
			for (int i = 0; i < candidates.Length; i++)
			{
				global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> boolExpr2 = candidates[i].Simplify();
				int num3 = boolExpr2.GetTerms().Distinct<global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<T_Identifier>>().Count<global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<T_Identifier>>();
				int num4 = boolExpr2.CountTerms();
				if (boolExpr == null || num3 < num || (num3 == num && num4 < num2))
				{
					boolExpr = boolExpr2;
					num = num3;
					num2 = num4;
				}
			}
			return boolExpr;
		}

		// Token: 0x06004B74 RID: 19316 RVA: 0x00109BE2 File Offset: 0x00107DE2
		internal global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<T_Identifier>> GetTerms()
		{
			return global::System.Data.Entity.Core.Common.Utils.Boolean.LeafVisitor<T_Identifier>.GetTerms(this);
		}

		// Token: 0x06004B75 RID: 19317 RVA: 0x00109BEA File Offset: 0x00107DEA
		internal int CountTerms()
		{
			return global::System.Data.Entity.Core.Common.Utils.Boolean.TermCounter<T_Identifier>.CountTerms(this);
		}

		// Token: 0x06004B76 RID: 19318 RVA: 0x00109BF2 File Offset: 0x00107DF2
		public static implicit operator global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier>(T_Identifier value)
		{
			return new global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<T_Identifier>(value);
		}

		// Token: 0x06004B77 RID: 19319 RVA: 0x00109BFA File Offset: 0x00107DFA
		internal virtual global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> MakeNegated()
		{
			return new global::System.Data.Entity.Core.Common.Utils.Boolean.NotExpr<T_Identifier>(this);
		}

		// Token: 0x06004B78 RID: 19320 RVA: 0x00109C04 File Offset: 0x00107E04
		public override string ToString()
		{
			return this.ExprType.ToString();
		}

		// Token: 0x06004B79 RID: 19321 RVA: 0x00109C25 File Offset: 0x00107E25
		public bool Equals(global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> other)
		{
			return other != null && this.ExprType == other.ExprType && this.EquivalentTypeEquals(other);
		}

		// Token: 0x06004B7A RID: 19322
		protected abstract bool EquivalentTypeEquals(global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> other);
	}
}
