using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x0200052E RID: 1326
	public class EntityTypeMapping : global::System.Data.Entity.Core.Mapping.TypeMapping
	{
		// Token: 0x0600418B RID: 16779 RVA: 0x000DCAC4 File Offset: 0x000DACC4
		public EntityTypeMapping(global::System.Data.Entity.Core.Mapping.EntitySetMapping entitySetMapping)
		{
			this._entitySetMapping = entitySetMapping;
			this._fragments = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.MappingFragment>();
		}

		// Token: 0x17000CE9 RID: 3305
		// (get) Token: 0x0600418C RID: 16780 RVA: 0x000DCAFE File Offset: 0x000DACFE
		public global::System.Data.Entity.Core.Mapping.EntitySetMapping EntitySetMapping
		{
			get
			{
				return this._entitySetMapping;
			}
		}

		// Token: 0x17000CEA RID: 3306
		// (get) Token: 0x0600418D RID: 16781 RVA: 0x000DCB06 File Offset: 0x000DAD06
		internal override global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping SetMapping
		{
			get
			{
				return this.EntitySetMapping;
			}
		}

		// Token: 0x17000CEB RID: 3307
		// (get) Token: 0x0600418E RID: 16782 RVA: 0x000DCB10 File Offset: 0x000DAD10
		public global::System.Data.Entity.Core.Metadata.Edm.EntityType EntityType
		{
			get
			{
				global::System.Data.Entity.Core.Metadata.Edm.EntityType result;
				if ((result = this._entityType) == null)
				{
					result = (this._entityType = this.m_entityTypes.Values.SingleOrDefault<global::System.Data.Entity.Core.Metadata.Edm.EntityType>());
				}
				return result;
			}
		}

		// Token: 0x17000CEC RID: 3308
		// (get) Token: 0x0600418F RID: 16783 RVA: 0x000DCB40 File Offset: 0x000DAD40
		public bool IsHierarchyMapping
		{
			get
			{
				return this.m_isOfEntityTypes.Count > 0 || this.m_entityTypes.Count > 1;
			}
		}

		// Token: 0x17000CED RID: 3309
		// (get) Token: 0x06004190 RID: 16784 RVA: 0x000DCB60 File Offset: 0x000DAD60
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.MappingFragment> Fragments
		{
			get
			{
				return new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.MappingFragment>(this._fragments);
			}
		}

		// Token: 0x17000CEE RID: 3310
		// (get) Token: 0x06004191 RID: 16785 RVA: 0x000DCB6D File Offset: 0x000DAD6D
		internal override global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.MappingFragment> MappingFragments
		{
			get
			{
				return this.Fragments;
			}
		}

		// Token: 0x17000CEF RID: 3311
		// (get) Token: 0x06004192 RID: 16786 RVA: 0x000DCB75 File Offset: 0x000DAD75
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase> EntityTypes
		{
			get
			{
				return new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase>(new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase>(this.m_entityTypes.Values));
			}
		}

		// Token: 0x17000CF0 RID: 3312
		// (get) Token: 0x06004193 RID: 16787 RVA: 0x000DCB8C File Offset: 0x000DAD8C
		internal override global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase> Types
		{
			get
			{
				return this.EntityTypes;
			}
		}

		// Token: 0x17000CF1 RID: 3313
		// (get) Token: 0x06004194 RID: 16788 RVA: 0x000DCB94 File Offset: 0x000DAD94
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase> IsOfEntityTypes
		{
			get
			{
				return new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase>(new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase>(this.m_isOfEntityTypes.Values));
			}
		}

		// Token: 0x17000CF2 RID: 3314
		// (get) Token: 0x06004195 RID: 16789 RVA: 0x000DCBAB File Offset: 0x000DADAB
		internal override global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase> IsOfTypes
		{
			get
			{
				return this.IsOfEntityTypes;
			}
		}

		// Token: 0x06004196 RID: 16790 RVA: 0x000DCBB3 File Offset: 0x000DADB3
		public void AddType(global::System.Data.Entity.Core.Metadata.Edm.EntityType type)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(type, "type");
			base.ThrowIfReadOnly();
			this.m_entityTypes.Add(type.FullName, type);
		}

		// Token: 0x06004197 RID: 16791 RVA: 0x000DCBD9 File Offset: 0x000DADD9
		public void RemoveType(global::System.Data.Entity.Core.Metadata.Edm.EntityType type)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(type, "type");
			base.ThrowIfReadOnly();
			this.m_entityTypes.Remove(type.FullName);
		}

		// Token: 0x06004198 RID: 16792 RVA: 0x000DCBFF File Offset: 0x000DADFF
		public void AddIsOfType(global::System.Data.Entity.Core.Metadata.Edm.EntityType type)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(type, "type");
			base.ThrowIfReadOnly();
			this.m_isOfEntityTypes.Add(type.FullName, type);
		}

		// Token: 0x06004199 RID: 16793 RVA: 0x000DCC25 File Offset: 0x000DAE25
		public void RemoveIsOfType(global::System.Data.Entity.Core.Metadata.Edm.EntityType type)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(type, "type");
			base.ThrowIfReadOnly();
			this.m_isOfEntityTypes.Remove(type.FullName);
		}

		// Token: 0x0600419A RID: 16794 RVA: 0x000DCC4B File Offset: 0x000DAE4B
		public void AddFragment(global::System.Data.Entity.Core.Mapping.MappingFragment fragment)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Mapping.MappingFragment>(fragment, "fragment");
			base.ThrowIfReadOnly();
			this._fragments.Add(fragment);
		}

		// Token: 0x0600419B RID: 16795 RVA: 0x000DCC6B File Offset: 0x000DAE6B
		public void RemoveFragment(global::System.Data.Entity.Core.Mapping.MappingFragment fragment)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Mapping.MappingFragment>(fragment, "fragment");
			base.ThrowIfReadOnly();
			this._fragments.Remove(fragment);
		}

		// Token: 0x0600419C RID: 16796 RVA: 0x000DCC8C File Offset: 0x000DAE8C
		internal override void SetReadOnly()
		{
			this._fragments.TrimExcess();
			global::System.Data.Entity.Core.Mapping.MappingItem.SetReadOnly(this._fragments);
			base.SetReadOnly();
		}

		// Token: 0x0600419D RID: 16797 RVA: 0x000DCCAC File Offset: 0x000DAEAC
		internal global::System.Data.Entity.Core.Metadata.Edm.EntityType GetContainerType(string memberName)
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType in this.m_entityTypes.Values)
			{
				if (entityType.Properties.Contains(memberName))
				{
					return entityType;
				}
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType2 in this.m_isOfEntityTypes.Values)
			{
				if (entityType2.Properties.Contains(memberName))
				{
					return entityType2;
				}
			}
			return null;
		}

		// Token: 0x040016B7 RID: 5815
		private readonly global::System.Data.Entity.Core.Mapping.EntitySetMapping _entitySetMapping;

		// Token: 0x040016B8 RID: 5816
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.MappingFragment> _fragments;

		// Token: 0x040016B9 RID: 5817
		private readonly global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.EntityType> m_entityTypes = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.EntityType>(global::System.StringComparer.Ordinal);

		// Token: 0x040016BA RID: 5818
		private readonly global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.EntityType> m_isOfEntityTypes = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.EntityType>(global::System.StringComparer.Ordinal);

		// Token: 0x040016BB RID: 5819
		private global::System.Data.Entity.Core.Metadata.Edm.EntityType _entityType;
	}
}
