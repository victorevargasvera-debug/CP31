using System;

namespace System.Data.Entity.SqlServer.SqlGen
{
	// Token: 0x02000031 RID: 49
	internal sealed class OptionalColumn
	{
		// Token: 0x0600045F RID: 1119 RVA: 0x00011704 File Offset: 0x0000F904
		internal void Append(object s)
		{
			this.m_builder.Append(s);
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x00011712 File Offset: 0x0000F912
		internal void MarkAsUsed()
		{
			this.m_usageManager.MarkAsUsed(this.m_symbol);
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00011725 File Offset: 0x0000F925
		internal OptionalColumn(global::System.Data.Entity.SqlServer.SqlGen.SymbolUsageManager usageManager, global::System.Data.Entity.SqlServer.SqlGen.Symbol symbol)
		{
			this.m_usageManager = usageManager;
			this.m_symbol = symbol;
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00011746 File Offset: 0x0000F946
		public bool WriteSqlIfUsed(global::System.Data.Entity.SqlServer.SqlGen.SqlWriter writer, global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlGenerator, string separator)
		{
			if (this.m_usageManager.IsUsed(this.m_symbol))
			{
				writer.Write(separator);
				this.m_builder.WriteSql(writer, sqlGenerator);
				return true;
			}
			return false;
		}

		// Token: 0x040000E1 RID: 225
		private readonly global::System.Data.Entity.SqlServer.SqlGen.SymbolUsageManager m_usageManager;

		// Token: 0x040000E2 RID: 226
		private readonly global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder m_builder = new global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder();

		// Token: 0x040000E3 RID: 227
		private readonly global::System.Data.Entity.SqlServer.SqlGen.Symbol m_symbol;
	}
}
