using System;
using System.Collections.Generic;

namespace System.Data.Entity.Core.Common.Utils.Boolean
{
	// Token: 0x0200060A RID: 1546
	internal abstract class ConversionContext<T_Identifier>
	{
		// Token: 0x06004B86 RID: 19334
		internal abstract global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex TranslateTermToVertex(global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<T_Identifier> term);

		// Token: 0x06004B87 RID: 19335
		internal abstract global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.Utils.Boolean.LiteralVertexPair<T_Identifier>> GetSuccessors(global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex vertex);

		// Token: 0x04001A5F RID: 6751
		internal readonly global::System.Data.Entity.Core.Common.Utils.Boolean.Solver Solver = new global::System.Data.Entity.Core.Common.Utils.Boolean.Solver();
	}
}
