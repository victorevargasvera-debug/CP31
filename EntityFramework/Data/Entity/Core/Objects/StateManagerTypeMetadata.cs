using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.Core.Objects
{
	// Token: 0x02000433 RID: 1075
	internal class StateManagerTypeMetadata
	{
		// Token: 0x0600345B RID: 13403 RVA: 0x000A80FE File Offset: 0x000A62FE
		internal StateManagerTypeMetadata()
		{
		}

		// Token: 0x0600345C RID: 13404 RVA: 0x000A8108 File Offset: 0x000A6308
		internal StateManagerTypeMetadata(global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType, global::System.Data.Entity.Core.Mapping.ObjectTypeMapping mapping)
		{
			this._typeUsage = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(edmType);
			this._recordInfo = new global::System.Data.Entity.Core.Common.DataRecordInfo(this._typeUsage);
			global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> properties = global::System.Data.Entity.Core.Common.TypeHelpers.GetProperties(edmType);
			this._members = new global::System.Data.Entity.Core.Objects.StateManagerMemberMetadata[properties.Count];
			this._objectNameToOrdinal = new global::System.Collections.Generic.Dictionary<string, int>(properties.Count);
			this._cLayerNameToOrdinal = new global::System.Collections.Generic.Dictionary<string, int>(properties.Count);
			global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> readOnlyMetadataCollection = null;
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEntityType(edmType))
			{
				readOnlyMetadataCollection = ((global::System.Data.Entity.Core.Metadata.Edm.EntityType)edmType).KeyMembers;
			}
			for (int i = 0; i < this._members.Length; i++)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = properties[i];
				global::System.Data.Entity.Core.Mapping.ObjectPropertyMapping objectPropertyMapping = null;
				if (mapping != null)
				{
					objectPropertyMapping = mapping.GetPropertyMap(edmProperty.Name);
					if (objectPropertyMapping != null)
					{
						this._objectNameToOrdinal.Add(objectPropertyMapping.ClrProperty.Name, i);
					}
				}
				this._cLayerNameToOrdinal.Add(edmProperty.Name, i);
				this._members[i] = new global::System.Data.Entity.Core.Objects.StateManagerMemberMetadata(objectPropertyMapping, edmProperty, readOnlyMetadataCollection != null && readOnlyMetadataCollection.Contains(edmProperty));
			}
		}

		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x0600345D RID: 13405 RVA: 0x000A8202 File Offset: 0x000A6402
		internal global::System.Data.Entity.Core.Metadata.Edm.TypeUsage CdmMetadata
		{
			get
			{
				return this._typeUsage;
			}
		}

		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x0600345E RID: 13406 RVA: 0x000A820A File Offset: 0x000A640A
		internal global::System.Data.Entity.Core.Common.DataRecordInfo DataRecordInfo
		{
			get
			{
				return this._recordInfo;
			}
		}

		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x0600345F RID: 13407 RVA: 0x000A8212 File Offset: 0x000A6412
		internal virtual int FieldCount
		{
			get
			{
				return this._members.Length;
			}
		}

		// Token: 0x06003460 RID: 13408 RVA: 0x000A821C File Offset: 0x000A641C
		internal global::System.Type GetFieldType(int ordinal)
		{
			return this.Member(ordinal).ClrType;
		}

		// Token: 0x06003461 RID: 13409 RVA: 0x000A822A File Offset: 0x000A642A
		internal virtual global::System.Data.Entity.Core.Objects.StateManagerMemberMetadata Member(int ordinal)
		{
			if (ordinal < this._members.Length)
			{
				return this._members[ordinal];
			}
			throw new global::System.ArgumentOutOfRangeException("ordinal");
		}

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x06003462 RID: 13410 RVA: 0x000A824A File Offset: 0x000A644A
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Objects.StateManagerMemberMetadata> Members
		{
			get
			{
				return this._members;
			}
		}

		// Token: 0x06003463 RID: 13411 RVA: 0x000A8252 File Offset: 0x000A6452
		internal string CLayerMemberName(int ordinal)
		{
			return this.Member(ordinal).CLayerName;
		}

		// Token: 0x06003464 RID: 13412 RVA: 0x000A8260 File Offset: 0x000A6460
		internal int GetOrdinalforOLayerMemberName(string name)
		{
			int result;
			if (string.IsNullOrEmpty(name) || !this._objectNameToOrdinal.TryGetValue(name, out result))
			{
				result = -1;
			}
			return result;
		}

		// Token: 0x06003465 RID: 13413 RVA: 0x000A8288 File Offset: 0x000A6488
		internal int GetOrdinalforCLayerMemberName(string name)
		{
			int result;
			if (string.IsNullOrEmpty(name) || !this._cLayerNameToOrdinal.TryGetValue(name, out result))
			{
				result = -1;
			}
			return result;
		}

		// Token: 0x040010E4 RID: 4324
		private readonly global::System.Data.Entity.Core.Metadata.Edm.TypeUsage _typeUsage;

		// Token: 0x040010E5 RID: 4325
		private readonly global::System.Data.Entity.Core.Objects.StateManagerMemberMetadata[] _members;

		// Token: 0x040010E6 RID: 4326
		private readonly global::System.Collections.Generic.Dictionary<string, int> _objectNameToOrdinal;

		// Token: 0x040010E7 RID: 4327
		private readonly global::System.Collections.Generic.Dictionary<string, int> _cLayerNameToOrdinal;

		// Token: 0x040010E8 RID: 4328
		private readonly global::System.Data.Entity.Core.Common.DataRecordInfo _recordInfo;
	}
}
