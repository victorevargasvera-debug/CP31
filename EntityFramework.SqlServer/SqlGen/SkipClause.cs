using System;
using System.Globalization;

namespace System.Data.Entity.SqlServer.SqlGen
{
	// Token: 0x02000032 RID: 50
	internal class SkipClause : global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment
	{
		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000463 RID: 1123 RVA: 0x00011772 File Offset: 0x0000F972
		internal global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment SkipCount
		{
			get
			{
				return this.skipCount;
			}
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x0001177A File Offset: 0x0000F97A
		internal SkipClause(global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment skipCount)
		{
			this.skipCount = skipCount;
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x0001178C File Offset: 0x0000F98C
		internal SkipClause(int skipCount)
		{
			global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder sqlBuilder = new global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder();
			sqlBuilder.Append(skipCount.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
			this.skipCount = sqlBuilder;
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x000117BE File Offset: 0x0000F9BE
		public void WriteSql(global::System.Data.Entity.SqlServer.SqlGen.SqlWriter writer, global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlGenerator)
		{
			writer.Write("OFFSET ");
			this.SkipCount.WriteSql(writer, sqlGenerator);
			writer.Write(" ROWS ");
		}

		// Token: 0x040000E4 RID: 228
		private readonly global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment skipCount;
	}
}
