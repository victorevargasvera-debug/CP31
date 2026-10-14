using System;

namespace System.Data.Entity.Core.Common.Utils.Boolean
{
	// Token: 0x0200060D RID: 1549
	internal sealed class DnfSentence<T_Identifier> : global::System.Data.Entity.Core.Common.Utils.Boolean.Sentence<T_Identifier, global::System.Data.Entity.Core.Common.Utils.Boolean.DnfClause<T_Identifier>>
	{
		// Token: 0x06004B91 RID: 19345 RVA: 0x00109F76 File Offset: 0x00108176
		internal DnfSentence(global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Common.Utils.Boolean.DnfClause<T_Identifier>> clauses) : base(clauses, global::System.Data.Entity.Core.Common.Utils.Boolean.ExprType.Or)
		{
		}
	}
}
