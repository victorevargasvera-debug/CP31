using System;

namespace System.Data.Entity.Core.Common.Utils.Boolean
{
	// Token: 0x02000608 RID: 1544
	internal sealed class CnfClause<T_Identifier> : global::System.Data.Entity.Core.Common.Utils.Boolean.Clause<T_Identifier>, global::System.IEquatable<global::System.Data.Entity.Core.Common.Utils.Boolean.CnfClause<T_Identifier>>
	{
		// Token: 0x06004B83 RID: 19331 RVA: 0x00109CFB File Offset: 0x00107EFB
		internal CnfClause(global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Common.Utils.Boolean.Literal<T_Identifier>> literals) : base(literals, global::System.Data.Entity.Core.Common.Utils.Boolean.ExprType.Or)
		{
		}

		// Token: 0x06004B84 RID: 19332 RVA: 0x00109D05 File Offset: 0x00107F05
		public bool Equals(global::System.Data.Entity.Core.Common.Utils.Boolean.CnfClause<T_Identifier> other)
		{
			return other != null && other.Literals.SetEquals(base.Literals);
		}
	}
}
