using System;

namespace System.Data.Entity.Core.Common.Utils.Boolean
{
	// Token: 0x02000609 RID: 1545
	internal sealed class CnfSentence<T_Identifier> : global::System.Data.Entity.Core.Common.Utils.Boolean.Sentence<T_Identifier, global::System.Data.Entity.Core.Common.Utils.Boolean.CnfClause<T_Identifier>>
	{
		// Token: 0x06004B85 RID: 19333 RVA: 0x00109D1D File Offset: 0x00107F1D
		internal CnfSentence(global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Common.Utils.Boolean.CnfClause<T_Identifier>> clauses) : base(clauses, global::System.Data.Entity.Core.Common.Utils.Boolean.ExprType.And)
		{
		}
	}
}
