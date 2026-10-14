using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.Core.Objects
{
	// Token: 0x0200042F RID: 1071
	internal sealed class RelationshipWrapper : global::System.IEquatable<global::System.Data.Entity.Core.Objects.RelationshipWrapper>
	{
		// Token: 0x0600343A RID: 13370 RVA: 0x000A7AEE File Offset: 0x000A5CEE
		internal RelationshipWrapper(global::System.Data.Entity.Core.Metadata.Edm.AssociationSet extent, global::System.Data.Entity.Core.EntityKey key)
		{
			this.AssociationSet = extent;
			this.Key0 = key;
			this.Key1 = key;
		}

		// Token: 0x0600343B RID: 13371 RVA: 0x000A7B0B File Offset: 0x000A5D0B
		internal RelationshipWrapper(global::System.Data.Entity.Core.Objects.RelationshipWrapper wrapper, int ordinal, global::System.Data.Entity.Core.EntityKey key)
		{
			this.AssociationSet = wrapper.AssociationSet;
			this.Key0 = ((ordinal == 0) ? key : wrapper.Key0);
			this.Key1 = ((ordinal == 0) ? wrapper.Key1 : key);
		}

		// Token: 0x0600343C RID: 13372 RVA: 0x000A7B43 File Offset: 0x000A5D43
		internal RelationshipWrapper(global::System.Data.Entity.Core.Metadata.Edm.AssociationSet extent, global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.EntityKey> roleAndKey1, global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.EntityKey> roleAndKey2) : this(extent, roleAndKey1.Key, roleAndKey1.Value, roleAndKey2.Key, roleAndKey2.Value)
		{
		}

		// Token: 0x0600343D RID: 13373 RVA: 0x000A7B68 File Offset: 0x000A5D68
		internal RelationshipWrapper(global::System.Data.Entity.Core.Metadata.Edm.AssociationSet extent, string role0, global::System.Data.Entity.Core.EntityKey key0, string role1, global::System.Data.Entity.Core.EntityKey key1)
		{
			this.AssociationSet = extent;
			if (extent.ElementType.AssociationEndMembers[0].Name == role0)
			{
				this.Key0 = key0;
				this.Key1 = key1;
				return;
			}
			this.Key0 = key1;
			this.Key1 = key0;
		}

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x0600343E RID: 13374 RVA: 0x000A7BBF File Offset: 0x000A5DBF
		internal global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember> AssociationEndMembers
		{
			get
			{
				return this.AssociationSet.ElementType.AssociationEndMembers;
			}
		}

		// Token: 0x0600343F RID: 13375 RVA: 0x000A7BD1 File Offset: 0x000A5DD1
		internal global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember GetAssociationEndMember(global::System.Data.Entity.Core.EntityKey key)
		{
			return this.AssociationEndMembers[(this.Key0 != key) ? 1 : 0];
		}

		// Token: 0x06003440 RID: 13376 RVA: 0x000A7BF0 File Offset: 0x000A5DF0
		internal global::System.Data.Entity.Core.EntityKey GetOtherEntityKey(global::System.Data.Entity.Core.EntityKey key)
		{
			if (this.Key0 == key)
			{
				return this.Key1;
			}
			if (!(this.Key1 == key))
			{
				return null;
			}
			return this.Key0;
		}

		// Token: 0x06003441 RID: 13377 RVA: 0x000A7C1D File Offset: 0x000A5E1D
		internal global::System.Data.Entity.Core.EntityKey GetEntityKey(int ordinal)
		{
			if (ordinal == 0)
			{
				return this.Key0;
			}
			if (ordinal != 1)
			{
				throw new global::System.ArgumentOutOfRangeException("ordinal");
			}
			return this.Key1;
		}

		// Token: 0x06003442 RID: 13378 RVA: 0x000A7C40 File Offset: 0x000A5E40
		public override int GetHashCode()
		{
			return this.AssociationSet.Name.GetHashCode() ^ this.Key0.GetHashCode() + this.Key1.GetHashCode();
		}

		// Token: 0x06003443 RID: 13379 RVA: 0x000A7C6A File Offset: 0x000A5E6A
		public override bool Equals(object obj)
		{
			return this.Equals(obj as global::System.Data.Entity.Core.Objects.RelationshipWrapper);
		}

		// Token: 0x06003444 RID: 13380 RVA: 0x000A7C78 File Offset: 0x000A5E78
		public bool Equals(global::System.Data.Entity.Core.Objects.RelationshipWrapper wrapper)
		{
			return this == wrapper || (wrapper != null && this.AssociationSet == wrapper.AssociationSet && this.Key0.Equals(wrapper.Key0) && this.Key1.Equals(wrapper.Key1));
		}

		// Token: 0x040010D7 RID: 4311
		internal readonly global::System.Data.Entity.Core.Metadata.Edm.AssociationSet AssociationSet;

		// Token: 0x040010D8 RID: 4312
		internal readonly global::System.Data.Entity.Core.EntityKey Key0;

		// Token: 0x040010D9 RID: 4313
		internal readonly global::System.Data.Entity.Core.EntityKey Key1;
	}
}
