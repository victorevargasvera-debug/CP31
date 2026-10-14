using System;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x0200038D RID: 909
	internal sealed class ColumnVar : global::System.Data.Entity.Core.Query.InternalTrees.Var
	{
		// Token: 0x06002C1C RID: 11292 RVA: 0x0008E137 File Offset: 0x0008C337
		internal ColumnVar(int id, global::System.Data.Entity.Core.Query.InternalTrees.Table table, global::System.Data.Entity.Core.Query.InternalTrees.ColumnMD columnMetadata) : base(id, global::System.Data.Entity.Core.Query.InternalTrees.VarType.Column, columnMetadata.Type)
		{
			this.m_table = table;
			this.m_columnMetadata = columnMetadata;
		}

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x06002C1D RID: 11293 RVA: 0x0008E155 File Offset: 0x0008C355
		internal global::System.Data.Entity.Core.Query.InternalTrees.Table Table
		{
			get
			{
				return this.m_table;
			}
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x06002C1E RID: 11294 RVA: 0x0008E15D File Offset: 0x0008C35D
		internal global::System.Data.Entity.Core.Query.InternalTrees.ColumnMD ColumnMetadata
		{
			get
			{
				return this.m_columnMetadata;
			}
		}

		// Token: 0x06002C1F RID: 11295 RVA: 0x0008E165 File Offset: 0x0008C365
		internal override bool TryGetName(out string name)
		{
			name = this.m_columnMetadata.Name;
			return true;
		}

		// Token: 0x04000EF0 RID: 3824
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.ColumnMD m_columnMetadata;

		// Token: 0x04000EF1 RID: 3825
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.Table m_table;
	}
}
