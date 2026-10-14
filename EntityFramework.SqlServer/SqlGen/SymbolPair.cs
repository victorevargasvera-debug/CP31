using System;

namespace System.Data.Entity.SqlServer.SqlGen
{
	// Token: 0x0200003D RID: 61
	internal class SymbolPair : global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment
	{
		// Token: 0x060005BE RID: 1470 RVA: 0x00019F7F File Offset: 0x0001817F
		public SymbolPair(global::System.Data.Entity.SqlServer.SqlGen.Symbol source, global::System.Data.Entity.SqlServer.SqlGen.Symbol column)
		{
			this.Source = source;
			this.Column = column;
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00019F95 File Offset: 0x00018195
		public void WriteSql(global::System.Data.Entity.SqlServer.SqlGen.SqlWriter writer, global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlGenerator)
		{
		}

		// Token: 0x04000124 RID: 292
		public global::System.Data.Entity.SqlServer.SqlGen.Symbol Source;

		// Token: 0x04000125 RID: 293
		public global::System.Data.Entity.SqlServer.SqlGen.Symbol Column;
	}
}
