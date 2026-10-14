using System;
using System.Collections.Generic;
using System.Globalization;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003F2 RID: 1010
	internal class Table
	{
		// Token: 0x06002F41 RID: 12097 RVA: 0x000949E8 File Offset: 0x00092BE8
		internal Table(global::System.Data.Entity.Core.Query.InternalTrees.Command command, global::System.Data.Entity.Core.Query.InternalTrees.TableMD tableMetadata, int tableId)
		{
			this.m_tableMetadata = tableMetadata;
			this.m_columns = global::System.Data.Entity.Core.Query.InternalTrees.Command.CreateVarList();
			this.m_keys = command.CreateVarVec();
			this.m_nonnullableColumns = command.CreateVarVec();
			this.m_tableId = tableId;
			global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar> dictionary = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar>();
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.ColumnMD columnMD in tableMetadata.Columns)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar columnVar = command.CreateColumnVar(this, columnMD);
				dictionary[columnMD.Name] = columnVar;
				if (!columnMD.IsNullable)
				{
					this.m_nonnullableColumns.Set(columnVar);
				}
			}
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.ColumnMD columnMD2 in tableMetadata.Keys)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar v = dictionary[columnMD2.Name];
				this.m_keys.Set(v);
			}
			this.m_referencedColumns = command.CreateVarVec(this.m_columns);
		}

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x06002F42 RID: 12098 RVA: 0x00094B08 File Offset: 0x00092D08
		internal global::System.Data.Entity.Core.Query.InternalTrees.TableMD TableMetadata
		{
			get
			{
				return this.m_tableMetadata;
			}
		}

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x06002F43 RID: 12099 RVA: 0x00094B10 File Offset: 0x00092D10
		internal global::System.Data.Entity.Core.Query.InternalTrees.VarList Columns
		{
			get
			{
				return this.m_columns;
			}
		}

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x06002F44 RID: 12100 RVA: 0x00094B18 File Offset: 0x00092D18
		internal global::System.Data.Entity.Core.Query.InternalTrees.VarVec ReferencedColumns
		{
			get
			{
				return this.m_referencedColumns;
			}
		}

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x06002F45 RID: 12101 RVA: 0x00094B20 File Offset: 0x00092D20
		internal global::System.Data.Entity.Core.Query.InternalTrees.VarVec NonNullableColumns
		{
			get
			{
				return this.m_nonnullableColumns;
			}
		}

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x06002F46 RID: 12102 RVA: 0x00094B28 File Offset: 0x00092D28
		internal global::System.Data.Entity.Core.Query.InternalTrees.VarVec Keys
		{
			get
			{
				return this.m_keys;
			}
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x06002F47 RID: 12103 RVA: 0x00094B30 File Offset: 0x00092D30
		internal int TableId
		{
			get
			{
				return this.m_tableId;
			}
		}

		// Token: 0x06002F48 RID: 12104 RVA: 0x00094B38 File Offset: 0x00092D38
		public override string ToString()
		{
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}::{1}", new object[]
			{
				this.m_tableMetadata,
				this.TableId
			});
		}

		// Token: 0x04000FEF RID: 4079
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.TableMD m_tableMetadata;

		// Token: 0x04000FF0 RID: 4080
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.VarList m_columns;

		// Token: 0x04000FF1 RID: 4081
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.VarVec m_referencedColumns;

		// Token: 0x04000FF2 RID: 4082
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.VarVec m_keys;

		// Token: 0x04000FF3 RID: 4083
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.VarVec m_nonnullableColumns;

		// Token: 0x04000FF4 RID: 4084
		private readonly int m_tableId;
	}
}
