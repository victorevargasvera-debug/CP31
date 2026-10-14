using System;
using System.Collections.Generic;

namespace System.Data.Entity.SqlServer.SqlGen
{
	// Token: 0x02000038 RID: 56
	internal class SqlSelectClauseBuilder : global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder
	{
		// Token: 0x06000586 RID: 1414 RVA: 0x00019707 File Offset: 0x00017907
		internal void AddOptionalColumn(global::System.Data.Entity.SqlServer.SqlGen.OptionalColumn column)
		{
			if (this.m_optionalColumns == null)
			{
				this.m_optionalColumns = new global::System.Collections.Generic.List<global::System.Data.Entity.SqlServer.SqlGen.OptionalColumn>();
			}
			this.m_optionalColumns.Add(column);
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x00019728 File Offset: 0x00017928
		// (set) Token: 0x06000588 RID: 1416 RVA: 0x00019730 File Offset: 0x00017930
		internal global::System.Data.Entity.SqlServer.SqlGen.TopClause Top
		{
			get
			{
				return this.m_top;
			}
			set
			{
				this.m_top = value;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x00019739 File Offset: 0x00017939
		// (set) Token: 0x0600058A RID: 1418 RVA: 0x00019741 File Offset: 0x00017941
		internal global::System.Data.Entity.SqlServer.SqlGen.SkipClause Skip
		{
			get
			{
				return this.m_skip;
			}
			set
			{
				this.m_skip = value;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x0001974A File Offset: 0x0001794A
		// (set) Token: 0x0600058C RID: 1420 RVA: 0x00019752 File Offset: 0x00017952
		internal bool IsDistinct { get; set; }

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600058D RID: 1421 RVA: 0x0001975B File Offset: 0x0001795B
		public override bool IsEmpty
		{
			get
			{
				return base.IsEmpty && (this.m_optionalColumns == null || this.m_optionalColumns.Count == 0);
			}
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x0001977F File Offset: 0x0001797F
		internal SqlSelectClauseBuilder(global::System.Func<bool> isPartOfTopMostStatement)
		{
			this.m_isPartOfTopMostStatement = isPartOfTopMostStatement;
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x00019790 File Offset: 0x00017990
		public override void WriteSql(global::System.Data.Entity.SqlServer.SqlGen.SqlWriter writer, global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlGenerator)
		{
			writer.Write("SELECT ");
			if (this.IsDistinct)
			{
				writer.Write("DISTINCT ");
			}
			if (this.Top != null && this.Skip == null)
			{
				this.Top.WriteSql(writer, sqlGenerator);
			}
			if (this.IsEmpty)
			{
				writer.Write("*");
				return;
			}
			bool flag = this.WriteOptionalColumns(writer, sqlGenerator);
			if (!base.IsEmpty)
			{
				if (flag)
				{
					writer.Write(", ");
				}
				base.WriteSql(writer, sqlGenerator);
				return;
			}
			if (!flag)
			{
				this.m_optionalColumns[0].MarkAsUsed();
				this.m_optionalColumns[0].WriteSqlIfUsed(writer, sqlGenerator, "");
			}
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x00019844 File Offset: 0x00017A44
		private bool WriteOptionalColumns(global::System.Data.Entity.SqlServer.SqlGen.SqlWriter writer, global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlGenerator)
		{
			if (this.m_optionalColumns == null)
			{
				return false;
			}
			if (this.m_isPartOfTopMostStatement() || this.IsDistinct)
			{
				foreach (global::System.Data.Entity.SqlServer.SqlGen.OptionalColumn optionalColumn in this.m_optionalColumns)
				{
					optionalColumn.MarkAsUsed();
				}
			}
			string separator = "";
			bool result = false;
			using (global::System.Collections.Generic.List<global::System.Data.Entity.SqlServer.SqlGen.OptionalColumn>.Enumerator enumerator = this.m_optionalColumns.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.WriteSqlIfUsed(writer, sqlGenerator, separator))
					{
						result = true;
						separator = ", ";
					}
				}
			}
			return result;
		}

		// Token: 0x0400010B RID: 267
		private global::System.Collections.Generic.List<global::System.Data.Entity.SqlServer.SqlGen.OptionalColumn> m_optionalColumns;

		// Token: 0x0400010C RID: 268
		private global::System.Data.Entity.SqlServer.SqlGen.TopClause m_top;

		// Token: 0x0400010D RID: 269
		private global::System.Data.Entity.SqlServer.SqlGen.SkipClause m_skip;

		// Token: 0x0400010F RID: 271
		private readonly global::System.Func<bool> m_isPartOfTopMostStatement;
	}
}
