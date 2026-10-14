using System;
using System.Collections.Generic;
using System.Globalization;

namespace System.Data.Entity.SqlServer.SqlGen
{
	// Token: 0x02000039 RID: 57
	internal sealed class SqlSelectStatement : global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment
	{
		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x00019908 File Offset: 0x00017B08
		// (set) Token: 0x06000592 RID: 1426 RVA: 0x00019910 File Offset: 0x00017B10
		internal bool OutputColumnsRenamed { get; set; }

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000593 RID: 1427 RVA: 0x00019919 File Offset: 0x00017B19
		// (set) Token: 0x06000594 RID: 1428 RVA: 0x00019921 File Offset: 0x00017B21
		internal global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.SqlServer.SqlGen.Symbol> OutputColumns { get; set; }

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000595 RID: 1429 RVA: 0x0001992A File Offset: 0x00017B2A
		// (set) Token: 0x06000596 RID: 1430 RVA: 0x00019932 File Offset: 0x00017B32
		internal global::System.Collections.Generic.List<global::System.Data.Entity.SqlServer.SqlGen.Symbol> AllJoinExtents { get; set; }

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x0001993B File Offset: 0x00017B3B
		internal global::System.Collections.Generic.List<global::System.Data.Entity.SqlServer.SqlGen.Symbol> FromExtents
		{
			get
			{
				if (this.fromExtents == null)
				{
					this.fromExtents = new global::System.Collections.Generic.List<global::System.Data.Entity.SqlServer.SqlGen.Symbol>();
				}
				return this.fromExtents;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000598 RID: 1432 RVA: 0x00019956 File Offset: 0x00017B56
		internal global::System.Collections.Generic.Dictionary<global::System.Data.Entity.SqlServer.SqlGen.Symbol, bool> OuterExtents
		{
			get
			{
				if (this.outerExtents == null)
				{
					this.outerExtents = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.SqlServer.SqlGen.Symbol, bool>();
				}
				return this.outerExtents;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x00019971 File Offset: 0x00017B71
		internal global::System.Data.Entity.SqlServer.SqlGen.SqlSelectClauseBuilder Select
		{
			get
			{
				return this.select;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600059A RID: 1434 RVA: 0x00019979 File Offset: 0x00017B79
		internal global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder From
		{
			get
			{
				return this.from;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x0600059B RID: 1435 RVA: 0x00019981 File Offset: 0x00017B81
		internal global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder Where
		{
			get
			{
				if (this.where == null)
				{
					this.where = new global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder();
				}
				return this.where;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x0600059C RID: 1436 RVA: 0x0001999C File Offset: 0x00017B9C
		internal global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder GroupBy
		{
			get
			{
				if (this.groupBy == null)
				{
					this.groupBy = new global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder();
				}
				return this.groupBy;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x0600059D RID: 1437 RVA: 0x000199B7 File Offset: 0x00017BB7
		public global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder OrderBy
		{
			get
			{
				if (this.orderBy == null)
				{
					this.orderBy = new global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder();
				}
				return this.orderBy;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600059E RID: 1438 RVA: 0x000199D2 File Offset: 0x00017BD2
		// (set) Token: 0x0600059F RID: 1439 RVA: 0x000199DA File Offset: 0x00017BDA
		internal bool IsTopMost { get; set; }

		// Token: 0x060005A0 RID: 1440 RVA: 0x000199E3 File Offset: 0x00017BE3
		internal SqlSelectStatement()
		{
			this.select = new global::System.Data.Entity.SqlServer.SqlGen.SqlSelectClauseBuilder(() => this.IsTopMost);
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00019A10 File Offset: 0x00017C10
		public void WriteSql(global::System.Data.Entity.SqlServer.SqlGen.SqlWriter writer, global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlGenerator)
		{
			global::System.Collections.Generic.List<string> list = null;
			if (this.outerExtents != null && 0 < this.outerExtents.Count)
			{
				foreach (global::System.Data.Entity.SqlServer.SqlGen.Symbol symbol in this.outerExtents.Keys)
				{
					global::System.Data.Entity.SqlServer.SqlGen.JoinSymbol joinSymbol = symbol as global::System.Data.Entity.SqlServer.SqlGen.JoinSymbol;
					if (joinSymbol != null)
					{
						using (global::System.Collections.Generic.List<global::System.Data.Entity.SqlServer.SqlGen.Symbol>.Enumerator enumerator2 = joinSymbol.FlattenedExtentList.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								global::System.Data.Entity.SqlServer.SqlGen.Symbol symbol2 = enumerator2.Current;
								if (list == null)
								{
									list = new global::System.Collections.Generic.List<string>();
								}
								list.Add(symbol2.NewName);
							}
							continue;
						}
					}
					if (list == null)
					{
						list = new global::System.Collections.Generic.List<string>();
					}
					list.Add(symbol.NewName);
				}
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.SqlServer.SqlGen.Symbol> list2 = this.AllJoinExtents ?? this.fromExtents;
			if (list2 != null)
			{
				foreach (global::System.Data.Entity.SqlServer.SqlGen.Symbol symbol3 in list2)
				{
					if (list != null && list.Contains(symbol3.Name))
					{
						int num = sqlGenerator.AllExtentNames[symbol3.Name];
						string text;
						do
						{
							num++;
							text = symbol3.Name + num.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
						}
						while (sqlGenerator.AllExtentNames.ContainsKey(text));
						sqlGenerator.AllExtentNames[symbol3.Name] = num;
						symbol3.NewName = text;
						sqlGenerator.AllExtentNames[text] = 0;
					}
					if (list == null)
					{
						list = new global::System.Collections.Generic.List<string>();
					}
					list.Add(symbol3.NewName);
				}
			}
			writer.Indent++;
			this.select.WriteSql(writer, sqlGenerator);
			writer.WriteLine();
			writer.Write("FROM ");
			this.From.WriteSql(writer, sqlGenerator);
			if (this.where != null && !this.Where.IsEmpty)
			{
				writer.WriteLine();
				writer.Write("WHERE ");
				this.Where.WriteSql(writer, sqlGenerator);
			}
			if (this.groupBy != null && !this.GroupBy.IsEmpty)
			{
				writer.WriteLine();
				writer.Write("GROUP BY ");
				this.GroupBy.WriteSql(writer, sqlGenerator);
			}
			if (this.orderBy != null && !this.OrderBy.IsEmpty && (this.IsTopMost || this.Select.Top != null || this.Select.Skip != null))
			{
				writer.WriteLine();
				writer.Write("ORDER BY ");
				this.OrderBy.WriteSql(writer, sqlGenerator);
			}
			if (this.Select.Skip != null)
			{
				writer.WriteLine();
				global::System.Data.Entity.SqlServer.SqlGen.SqlSelectStatement.WriteOffsetFetch(writer, this.Select.Top, this.Select.Skip, sqlGenerator);
			}
			int indent = writer.Indent - 1;
			writer.Indent = indent;
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00019D18 File Offset: 0x00017F18
		private static void WriteOffsetFetch(global::System.Data.Entity.SqlServer.SqlGen.SqlWriter writer, global::System.Data.Entity.SqlServer.SqlGen.TopClause top, global::System.Data.Entity.SqlServer.SqlGen.SkipClause skip, global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlGenerator)
		{
			skip.WriteSql(writer, sqlGenerator);
			if (top != null)
			{
				writer.Write("FETCH NEXT ");
				top.TopCount.WriteSql(writer, sqlGenerator);
				writer.Write(" ROWS ONLY ");
			}
		}

		// Token: 0x04000113 RID: 275
		private global::System.Collections.Generic.List<global::System.Data.Entity.SqlServer.SqlGen.Symbol> fromExtents;

		// Token: 0x04000114 RID: 276
		private global::System.Collections.Generic.Dictionary<global::System.Data.Entity.SqlServer.SqlGen.Symbol, bool> outerExtents;

		// Token: 0x04000115 RID: 277
		private readonly global::System.Data.Entity.SqlServer.SqlGen.SqlSelectClauseBuilder select;

		// Token: 0x04000116 RID: 278
		private readonly global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder from = new global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder();

		// Token: 0x04000117 RID: 279
		private global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder where;

		// Token: 0x04000118 RID: 280
		private global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder groupBy;

		// Token: 0x04000119 RID: 281
		private global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder orderBy;
	}
}
