using System;
using System.Text;

namespace System.Data.Entity.SqlServer.SqlGen
{
	// Token: 0x0200003A RID: 58
	internal class SqlStringBuilder
	{
		// Token: 0x060005A4 RID: 1444 RVA: 0x00019D50 File Offset: 0x00017F50
		public SqlStringBuilder()
		{
			this._sql = new global::System.Text.StringBuilder();
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00019D63 File Offset: 0x00017F63
		public SqlStringBuilder(int capacity)
		{
			this._sql = new global::System.Text.StringBuilder(capacity);
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060005A6 RID: 1446 RVA: 0x00019D77 File Offset: 0x00017F77
		// (set) Token: 0x060005A7 RID: 1447 RVA: 0x00019D7F File Offset: 0x00017F7F
		public bool UpperCaseKeywords { get; set; }

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060005A8 RID: 1448 RVA: 0x00019D88 File Offset: 0x00017F88
		internal global::System.Text.StringBuilder InnerBuilder
		{
			get
			{
				return this._sql;
			}
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00019D90 File Offset: 0x00017F90
		public global::System.Data.Entity.SqlServer.SqlGen.SqlStringBuilder AppendKeyword(string keyword)
		{
			this._sql.Append(this.UpperCaseKeywords ? keyword.ToUpperInvariant() : keyword.ToLowerInvariant());
			return this;
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00019DB5 File Offset: 0x00017FB5
		public global::System.Data.Entity.SqlServer.SqlGen.SqlStringBuilder AppendLine()
		{
			this._sql.AppendLine();
			return this;
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00019DC4 File Offset: 0x00017FC4
		public global::System.Data.Entity.SqlServer.SqlGen.SqlStringBuilder AppendLine(string s)
		{
			this._sql.AppendLine(s);
			return this;
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x00019DD4 File Offset: 0x00017FD4
		public global::System.Data.Entity.SqlServer.SqlGen.SqlStringBuilder Append(string s)
		{
			this._sql.Append(s);
			return this;
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060005AD RID: 1453 RVA: 0x00019DE4 File Offset: 0x00017FE4
		public int Length
		{
			get
			{
				return this._sql.Length;
			}
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00019DF1 File Offset: 0x00017FF1
		public override string ToString()
		{
			return this._sql.ToString();
		}

		// Token: 0x0400011B RID: 283
		private readonly global::System.Text.StringBuilder _sql;
	}
}
