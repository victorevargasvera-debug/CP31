using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects.DataClasses;

namespace System.Data.Entity.Core.Objects.Internal
{
	// Token: 0x02000444 RID: 1092
	internal sealed class EntityWrapperWithRelationships<TEntity> : global::System.Data.Entity.Core.Objects.Internal.EntityWrapper<TEntity> where TEntity : class, global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithRelationships
	{
		// Token: 0x0600355F RID: 13663 RVA: 0x000AACE4 File Offset: 0x000A8EE4
		internal EntityWrapperWithRelationships(TEntity entity, global::System.Data.Entity.Core.EntityKey key, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Data.Entity.Core.Objects.ObjectContext context, global::System.Data.Entity.Core.Objects.MergeOption mergeOption, global::System.Type identityType, global::System.Func<object, global::System.Data.Entity.Core.Objects.Internal.IPropertyAccessorStrategy> propertyStrategy, global::System.Func<object, global::System.Data.Entity.Core.Objects.Internal.IChangeTrackingStrategy> changeTrackingStrategy, global::System.Func<object, global::System.Data.Entity.Core.Objects.Internal.IEntityKeyStrategy> keyStrategy, bool overridesEquals) : base(entity, entity.RelationshipManager, key, entitySet, context, mergeOption, identityType, propertyStrategy, changeTrackingStrategy, keyStrategy, overridesEquals)
		{
		}

		// Token: 0x06003560 RID: 13664 RVA: 0x000AAD13 File Offset: 0x000A8F13
		internal EntityWrapperWithRelationships(TEntity entity, global::System.Func<object, global::System.Data.Entity.Core.Objects.Internal.IPropertyAccessorStrategy> propertyStrategy, global::System.Func<object, global::System.Data.Entity.Core.Objects.Internal.IChangeTrackingStrategy> changeTrackingStrategy, global::System.Func<object, global::System.Data.Entity.Core.Objects.Internal.IEntityKeyStrategy> keyStrategy, bool overridesEquals) : base(entity, entity.RelationshipManager, propertyStrategy, changeTrackingStrategy, keyStrategy, overridesEquals)
		{
		}

		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x06003561 RID: 13665 RVA: 0x000AAD2D File Offset: 0x000A8F2D
		public override bool OwnsRelationshipManager
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06003562 RID: 13666 RVA: 0x000AAD30 File Offset: 0x000A8F30
		public override void TakeSnapshotOfRelationships(global::System.Data.Entity.Core.Objects.EntityEntry entry)
		{
		}

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x06003563 RID: 13667 RVA: 0x000AAD32 File Offset: 0x000A8F32
		public override bool RequiresRelationshipChangeTracking
		{
			get
			{
				return false;
			}
		}
	}
}
