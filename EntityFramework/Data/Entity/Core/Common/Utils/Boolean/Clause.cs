using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Data.Entity.Core.Common.Utils.Boolean
{
	// Token: 0x02000607 RID: 1543
	internal abstract class Clause<T_Identifier> : global::System.Data.Entity.Core.Common.Utils.Boolean.NormalFormNode<T_Identifier>
	{
		// Token: 0x06004B7C RID: 19324 RVA: 0x00109C49 File Offset: 0x00107E49
		protected Clause(global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Common.Utils.Boolean.Literal<T_Identifier>> literals, global::System.Data.Entity.Core.Common.Utils.Boolean.ExprType treeType) : base(global::System.Data.Entity.Core.Common.Utils.Boolean.Clause<T_Identifier>.ConvertLiteralsToExpr(literals, treeType))
		{
			this._literals = literals.AsReadOnly();
			this._hashCode = this._literals.GetElementsHashCode();
		}

		// Token: 0x17000EBB RID: 3771
		// (get) Token: 0x06004B7D RID: 19325 RVA: 0x00109C75 File Offset: 0x00107E75
		internal global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Common.Utils.Boolean.Literal<T_Identifier>> Literals
		{
			get
			{
				return this._literals;
			}
		}

		// Token: 0x06004B7E RID: 19326 RVA: 0x00109C80 File Offset: 0x00107E80
		private static global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> ConvertLiteralsToExpr(global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Common.Utils.Boolean.Literal<T_Identifier>> literals, global::System.Data.Entity.Core.Common.Utils.Boolean.ExprType treeType)
		{
			bool flag = treeType == global::System.Data.Entity.Core.Common.Utils.Boolean.ExprType.And;
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier>> children = literals.Select(new global::System.Func<global::System.Data.Entity.Core.Common.Utils.Boolean.Literal<T_Identifier>, global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier>>(global::System.Data.Entity.Core.Common.Utils.Boolean.Clause<T_Identifier>.ConvertLiteralToExpression));
			if (flag)
			{
				return new global::System.Data.Entity.Core.Common.Utils.Boolean.AndExpr<T_Identifier>(children);
			}
			return new global::System.Data.Entity.Core.Common.Utils.Boolean.OrExpr<T_Identifier>(children);
		}

		// Token: 0x06004B7F RID: 19327 RVA: 0x00109CB3 File Offset: 0x00107EB3
		private static global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> ConvertLiteralToExpression(global::System.Data.Entity.Core.Common.Utils.Boolean.Literal<T_Identifier> literal)
		{
			return literal.Expr;
		}

		// Token: 0x06004B80 RID: 19328 RVA: 0x00109CBB File Offset: 0x00107EBB
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("Clause{");
			stringBuilder.Append(this._literals);
			return stringBuilder.Append("}").ToString();
		}

		// Token: 0x06004B81 RID: 19329 RVA: 0x00109CEA File Offset: 0x00107EEA
		public override int GetHashCode()
		{
			return this._hashCode;
		}

		// Token: 0x06004B82 RID: 19330 RVA: 0x00109CF2 File Offset: 0x00107EF2
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x04001A5D RID: 6749
		private readonly global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Common.Utils.Boolean.Literal<T_Identifier>> _literals;

		// Token: 0x04001A5E RID: 6750
		private readonly int _hashCode;
	}
}
