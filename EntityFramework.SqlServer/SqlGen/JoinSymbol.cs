using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.SqlServer.SqlGen
{
	// Token: 0x02000030 RID: 48
	internal sealed class JoinSymbol : global::System.Data.Entity.SqlServer.SqlGen.Symbol
	{
		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x00011607 File Offset: 0x0000F807
		// (set) Token: 0x06000457 RID: 1111 RVA: 0x00011622 File Offset: 0x0000F822
		internal global::System.Collections.Generic.List<global::System.Data.Entity.SqlServer.SqlGen.Symbol> ColumnList
		{
			get
			{
				if (this.columnList == null)
				{
					this.columnList = new global::System.Collections.Generic.List<global::System.Data.Entity.SqlServer.SqlGen.Symbol>();
				}
				return this.columnList;
			}
			set
			{
				this.columnList = value;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000458 RID: 1112 RVA: 0x0001162B File Offset: 0x0000F82B
		internal global::System.Collections.Generic.List<global::System.Data.Entity.SqlServer.SqlGen.Symbol> ExtentList
		{
			get
			{
				return this.extentList;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000459 RID: 1113 RVA: 0x00011633 File Offset: 0x0000F833
		// (set) Token: 0x0600045A RID: 1114 RVA: 0x0001164E File Offset: 0x0000F84E
		internal global::System.Collections.Generic.List<global::System.Data.Entity.SqlServer.SqlGen.Symbol> FlattenedExtentList
		{
			get
			{
				if (this.flattenedExtentList == null)
				{
					this.flattenedExtentList = new global::System.Collections.Generic.List<global::System.Data.Entity.SqlServer.SqlGen.Symbol>();
				}
				return this.flattenedExtentList;
			}
			set
			{
				this.flattenedExtentList = value;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600045B RID: 1115 RVA: 0x00011657 File Offset: 0x0000F857
		internal global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.SqlServer.SqlGen.Symbol> NameToExtent
		{
			get
			{
				return this.nameToExtent;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600045C RID: 1116 RVA: 0x0001165F File Offset: 0x0000F85F
		// (set) Token: 0x0600045D RID: 1117 RVA: 0x00011667 File Offset: 0x0000F867
		internal bool IsNestedJoin { get; set; }

		// Token: 0x0600045E RID: 1118 RVA: 0x00011670 File Offset: 0x0000F870
		public JoinSymbol(string name, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, global::System.Collections.Generic.List<global::System.Data.Entity.SqlServer.SqlGen.Symbol> extents) : base(name, type)
		{
			this.extentList = new global::System.Collections.Generic.List<global::System.Data.Entity.SqlServer.SqlGen.Symbol>(extents.Count);
			this.nameToExtent = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.SqlServer.SqlGen.Symbol>(extents.Count, global::System.StringComparer.OrdinalIgnoreCase);
			foreach (global::System.Data.Entity.SqlServer.SqlGen.Symbol symbol in extents)
			{
				this.nameToExtent[symbol.Name] = symbol;
				this.ExtentList.Add(symbol);
			}
		}

		// Token: 0x040000DC RID: 220
		private global::System.Collections.Generic.List<global::System.Data.Entity.SqlServer.SqlGen.Symbol> columnList;

		// Token: 0x040000DD RID: 221
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.SqlServer.SqlGen.Symbol> extentList;

		// Token: 0x040000DE RID: 222
		private global::System.Collections.Generic.List<global::System.Data.Entity.SqlServer.SqlGen.Symbol> flattenedExtentList;

		// Token: 0x040000DF RID: 223
		private readonly global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.SqlServer.SqlGen.Symbol> nameToExtent;
	}
}
