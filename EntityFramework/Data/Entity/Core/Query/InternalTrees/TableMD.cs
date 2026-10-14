using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Query.PlanCompiler;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003F3 RID: 1011
	internal class TableMD
	{
		// Token: 0x06002F49 RID: 12105 RVA: 0x00094B66 File Offset: 0x00092D66
		private TableMD(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase extent)
		{
			this.m_columns = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.ColumnMD>();
			this.m_keys = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.ColumnMD>();
			this.m_extent = extent;
		}

		// Token: 0x06002F4A RID: 12106 RVA: 0x00094B8B File Offset: 0x00092D8B
		internal TableMD(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase extent) : this(extent)
		{
			this.m_columns.Add(new global::System.Data.Entity.Core.Query.InternalTrees.ColumnMD("element", type));
			this.m_flattened = !global::System.Data.Entity.Core.Query.PlanCompiler.TypeUtils.IsStructuredType(type);
		}

		// Token: 0x06002F4B RID: 12107 RVA: 0x00094BBC File Offset: 0x00092DBC
		internal TableMD(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> properties, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> keyProperties, global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase extent) : this(extent)
		{
			global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Query.InternalTrees.ColumnMD> dictionary = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Query.InternalTrees.ColumnMD>();
			this.m_flattened = true;
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty in properties)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.ColumnMD columnMD = new global::System.Data.Entity.Core.Query.InternalTrees.ColumnMD(edmProperty);
				this.m_columns.Add(columnMD);
				dictionary[edmProperty.Name] = columnMD;
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember in keyProperties)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.ColumnMD item;
				if (dictionary.TryGetValue(edmMember.Name, out item))
				{
					this.m_keys.Add(item);
				}
			}
		}

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x06002F4C RID: 12108 RVA: 0x00094C88 File Offset: 0x00092E88
		internal global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase Extent
		{
			get
			{
				return this.m_extent;
			}
		}

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x06002F4D RID: 12109 RVA: 0x00094C90 File Offset: 0x00092E90
		internal global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.ColumnMD> Columns
		{
			get
			{
				return this.m_columns;
			}
		}

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x06002F4E RID: 12110 RVA: 0x00094C98 File Offset: 0x00092E98
		internal global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.ColumnMD> Keys
		{
			get
			{
				return this.m_keys;
			}
		}

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x06002F4F RID: 12111 RVA: 0x00094CA0 File Offset: 0x00092EA0
		internal bool Flattened
		{
			get
			{
				return this.m_flattened;
			}
		}

		// Token: 0x06002F50 RID: 12112 RVA: 0x00094CA8 File Offset: 0x00092EA8
		public override string ToString()
		{
			if (this.m_extent == null)
			{
				return "Transient";
			}
			return this.m_extent.Name;
		}

		// Token: 0x04000FF5 RID: 4085
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.ColumnMD> m_columns;

		// Token: 0x04000FF6 RID: 4086
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.ColumnMD> m_keys;

		// Token: 0x04000FF7 RID: 4087
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase m_extent;

		// Token: 0x04000FF8 RID: 4088
		private readonly bool m_flattened;
	}
}
