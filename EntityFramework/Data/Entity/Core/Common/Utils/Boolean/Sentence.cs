using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Data.Entity.Core.Common.Utils.Boolean
{
	// Token: 0x0200061D RID: 1565
	internal abstract class Sentence<T_Identifier, T_Clause> : global::System.Data.Entity.Core.Common.Utils.Boolean.NormalFormNode<T_Identifier> where T_Clause : global::System.Data.Entity.Core.Common.Utils.Boolean.Clause<T_Identifier>, global::System.IEquatable<T_Clause>
	{
		// Token: 0x06004BDE RID: 19422 RVA: 0x0010A8B7 File Offset: 0x00108AB7
		protected Sentence(global::System.Data.Entity.Core.Common.Utils.Set<T_Clause> clauses, global::System.Data.Entity.Core.Common.Utils.Boolean.ExprType treeType) : base(global::System.Data.Entity.Core.Common.Utils.Boolean.Sentence<T_Identifier, T_Clause>.ConvertClausesToExpr(clauses, treeType))
		{
			this._clauses = clauses.AsReadOnly();
		}

		// Token: 0x06004BDF RID: 19423 RVA: 0x0010A8D4 File Offset: 0x00108AD4
		private static global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> ConvertClausesToExpr(global::System.Data.Entity.Core.Common.Utils.Set<T_Clause> clauses, global::System.Data.Entity.Core.Common.Utils.Boolean.ExprType treeType)
		{
			bool flag = treeType == global::System.Data.Entity.Core.Common.Utils.Boolean.ExprType.And;
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier>> children = clauses.Select(new global::System.Func<T_Clause, global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier>>(global::System.Data.Entity.Core.Common.Utils.Boolean.NormalFormNode<T_Identifier>.ExprSelector<T_Clause>));
			if (flag)
			{
				return new global::System.Data.Entity.Core.Common.Utils.Boolean.AndExpr<T_Identifier>(children);
			}
			return new global::System.Data.Entity.Core.Common.Utils.Boolean.OrExpr<T_Identifier>(children);
		}

		// Token: 0x06004BE0 RID: 19424 RVA: 0x0010A907 File Offset: 0x00108B07
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("Sentence{");
			stringBuilder.Append(this._clauses);
			return stringBuilder.Append("}").ToString();
		}

		// Token: 0x04001A81 RID: 6785
		private readonly global::System.Data.Entity.Core.Common.Utils.Set<T_Clause> _clauses;
	}
}
