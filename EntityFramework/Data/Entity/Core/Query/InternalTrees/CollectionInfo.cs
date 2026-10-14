using System;
using System.Collections.Generic;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x02000385 RID: 901
	internal class CollectionInfo
	{
		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x06002BC8 RID: 11208 RVA: 0x0008D034 File Offset: 0x0008B234
		internal global::System.Data.Entity.Core.Query.InternalTrees.Var CollectionVar
		{
			get
			{
				return this.m_collectionVar;
			}
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x06002BC9 RID: 11209 RVA: 0x0008D03C File Offset: 0x0008B23C
		internal global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap ColumnMap
		{
			get
			{
				return this.m_columnMap;
			}
		}

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x06002BCA RID: 11210 RVA: 0x0008D044 File Offset: 0x0008B244
		internal global::System.Data.Entity.Core.Query.InternalTrees.VarList FlattenedElementVars
		{
			get
			{
				return this.m_flattenedElementVars;
			}
		}

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x06002BCB RID: 11211 RVA: 0x0008D04C File Offset: 0x0008B24C
		internal global::System.Data.Entity.Core.Query.InternalTrees.VarVec Keys
		{
			get
			{
				return this.m_keys;
			}
		}

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x06002BCC RID: 11212 RVA: 0x0008D054 File Offset: 0x0008B254
		internal global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> SortKeys
		{
			get
			{
				return this.m_sortKeys;
			}
		}

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x06002BCD RID: 11213 RVA: 0x0008D05C File Offset: 0x0008B25C
		internal object DiscriminatorValue
		{
			get
			{
				return this.m_discriminatorValue;
			}
		}

		// Token: 0x06002BCE RID: 11214 RVA: 0x0008D064 File Offset: 0x0008B264
		internal CollectionInfo(global::System.Data.Entity.Core.Query.InternalTrees.Var collectionVar, global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap columnMap, global::System.Data.Entity.Core.Query.InternalTrees.VarList flattenedElementVars, global::System.Data.Entity.Core.Query.InternalTrees.VarVec keys, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> sortKeys, object discriminatorValue)
		{
			this.m_collectionVar = collectionVar;
			this.m_columnMap = columnMap;
			this.m_flattenedElementVars = flattenedElementVars;
			this.m_keys = keys;
			this.m_sortKeys = sortKeys;
			this.m_discriminatorValue = discriminatorValue;
		}

		// Token: 0x04000EE2 RID: 3810
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.Var m_collectionVar;

		// Token: 0x04000EE3 RID: 3811
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap m_columnMap;

		// Token: 0x04000EE4 RID: 3812
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.VarList m_flattenedElementVars;

		// Token: 0x04000EE5 RID: 3813
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.VarVec m_keys;

		// Token: 0x04000EE6 RID: 3814
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> m_sortKeys;

		// Token: 0x04000EE7 RID: 3815
		private readonly object m_discriminatorValue;
	}
}
