using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration.Edm;

namespace System.Data.Entity.ModelConfiguration.Configuration.Mapping
{
	// Token: 0x02000218 RID: 536
	internal class SortedEntityTypeIndex
	{
		// Token: 0x06001C40 RID: 7232 RVA: 0x00050047 File Offset: 0x0004E247
		public SortedEntityTypeIndex()
		{
			this._entityTypes = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EntityType>>();
		}

		// Token: 0x06001C41 RID: 7233 RVA: 0x0005005C File Offset: 0x0004E25C
		public void Add(global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			int i = 0;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EntityType> list;
			if (!this._entityTypes.TryGetValue(entitySet, out list))
			{
				list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EntityType>();
				this._entityTypes.Add(entitySet, list);
			}
			while (i < list.Count)
			{
				if (list[i] == entityType)
				{
					return;
				}
				if (entityType.IsAncestorOf(list[i]))
				{
					break;
				}
				i++;
			}
			list.Insert(i, entityType);
		}

		// Token: 0x06001C42 RID: 7234 RVA: 0x000500C0 File Offset: 0x0004E2C0
		public bool Contains(global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EntityType> list;
			return this._entityTypes.TryGetValue(entitySet, out list) && list.Contains(entityType);
		}

		// Token: 0x06001C43 RID: 7235 RVA: 0x000500E8 File Offset: 0x0004E2E8
		public bool IsRoot(global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			bool result = true;
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType2 in this._entityTypes[entitySet])
			{
				if (entityType2 != entityType && entityType2.IsAncestorOf(entityType))
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06001C44 RID: 7236 RVA: 0x0005014C File Offset: 0x0004E34C
		public global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> GetEntitySets()
		{
			return this._entityTypes.Keys;
		}

		// Token: 0x06001C45 RID: 7237 RVA: 0x0005015C File Offset: 0x0004E35C
		public global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EntityType> GetEntityTypes(global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EntityType> result;
			if (this._entityTypes.TryGetValue(entitySet, out result))
			{
				return result;
			}
			return global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.SortedEntityTypeIndex._emptyTypes;
		}

		// Token: 0x04000AEA RID: 2794
		private static readonly global::System.Data.Entity.Core.Metadata.Edm.EntityType[] _emptyTypes = new global::System.Data.Entity.Core.Metadata.Edm.EntityType[0];

		// Token: 0x04000AEB RID: 2795
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EntityType>> _entityTypes;
	}
}
