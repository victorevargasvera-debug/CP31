using System;

namespace System.Data.Entity.Core.Common.Utils.Boolean
{
	// Token: 0x02000618 RID: 1560
	internal sealed class LiteralVertexPair<T_Identifier>
	{
		// Token: 0x06004BCF RID: 19407 RVA: 0x0010A7FA File Offset: 0x001089FA
		internal LiteralVertexPair(global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex vertex, global::System.Data.Entity.Core.Common.Utils.Boolean.Literal<T_Identifier> literal)
		{
			this.Vertex = vertex;
			this.Literal = literal;
		}

		// Token: 0x04001A7E RID: 6782
		internal readonly global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex Vertex;

		// Token: 0x04001A7F RID: 6783
		internal readonly global::System.Data.Entity.Core.Common.Utils.Boolean.Literal<T_Identifier> Literal;
	}
}
