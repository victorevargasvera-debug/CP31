using System;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x02000384 RID: 900
	internal abstract class CollectionColumnMap : global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap
	{
		// Token: 0x06002BC4 RID: 11204 RVA: 0x0008CFE7 File Offset: 0x0008B1E7
		internal CollectionColumnMap(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, string name, global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap elementMap, global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap[] keys, global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap[] foreignKeys) : base(type, name)
		{
			this.m_element = elementMap;
			this.m_keys = (keys ?? new global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap[0]);
			this.m_foreignKeys = (foreignKeys ?? new global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap[0]);
		}

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x06002BC5 RID: 11205 RVA: 0x0008D01C File Offset: 0x0008B21C
		internal global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap[] ForeignKeys
		{
			get
			{
				return this.m_foreignKeys;
			}
		}

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x06002BC6 RID: 11206 RVA: 0x0008D024 File Offset: 0x0008B224
		internal global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap[] Keys
		{
			get
			{
				return this.m_keys;
			}
		}

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x06002BC7 RID: 11207 RVA: 0x0008D02C File Offset: 0x0008B22C
		internal global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap Element
		{
			get
			{
				return this.m_element;
			}
		}

		// Token: 0x04000EDF RID: 3807
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap m_element;

		// Token: 0x04000EE0 RID: 3808
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap[] m_foreignKeys;

		// Token: 0x04000EE1 RID: 3809
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap[] m_keys;
	}
}
