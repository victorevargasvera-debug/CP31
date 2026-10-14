using System;

namespace System.Data.Entity.Core.Common.Utils.Boolean
{
	// Token: 0x0200060C RID: 1548
	internal sealed class DnfClause<T_Identifier> : global::System.Data.Entity.Core.Common.Utils.Boolean.Clause<T_Identifier>, global::System.IEquatable<global::System.Data.Entity.Core.Common.Utils.Boolean.DnfClause<T_Identifier>>
	{
		// Token: 0x06004B8F RID: 19343 RVA: 0x00109F54 File Offset: 0x00108154
		internal DnfClause(global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Common.Utils.Boolean.Literal<T_Identifier>> literals) : base(literals, global::System.Data.Entity.Core.Common.Utils.Boolean.ExprType.And)
		{
		}

		// Token: 0x06004B90 RID: 19344 RVA: 0x00109F5E File Offset: 0x0010815E
		public bool Equals(global::System.Data.Entity.Core.Common.Utils.Boolean.DnfClause<T_Identifier> other)
		{
			return other != null && other.Literals.SetEquals(base.Literals);
		}
	}
}
