using System;
using System.Globalization;

namespace System.Data.Entity.SqlServer.SqlGen
{
	// Token: 0x02000040 RID: 64
	internal class TopClause : global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment
	{
		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060005CB RID: 1483 RVA: 0x0001A103 File Offset: 0x00018303
		internal bool WithTies
		{
			get
			{
				return this.withTies;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060005CC RID: 1484 RVA: 0x0001A10B File Offset: 0x0001830B
		internal global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment TopCount
		{
			get
			{
				return this.topCount;
			}
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x0001A113 File Offset: 0x00018313
		internal TopClause(global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment topCount, bool withTies)
		{
			this.topCount = topCount;
			this.withTies = withTies;
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x0001A12C File Offset: 0x0001832C
		internal TopClause(int topCount, bool withTies)
		{
			global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder sqlBuilder = new global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder();
			sqlBuilder.Append(topCount.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
			this.topCount = sqlBuilder;
			this.withTies = withTies;
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x0001A168 File Offset: 0x00018368
		public void WriteSql(global::System.Data.Entity.SqlServer.SqlGen.SqlWriter writer, global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlGenerator)
		{
			writer.Write("TOP ");
			if (sqlGenerator.SqlVersion != global::System.Data.Entity.SqlServer.SqlVersion.Sql8)
			{
				writer.Write("(");
			}
			this.TopCount.WriteSql(writer, sqlGenerator);
			if (sqlGenerator.SqlVersion != global::System.Data.Entity.SqlServer.SqlVersion.Sql8)
			{
				writer.Write(")");
			}
			writer.Write(" ");
			if (this.WithTies)
			{
				writer.Write("WITH TIES ");
			}
		}

		// Token: 0x04000128 RID: 296
		private readonly global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment topCount;

		// Token: 0x04000129 RID: 297
		private readonly bool withTies;
	}
}
