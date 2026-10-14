using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects.DataClasses;

namespace System.Data.Entity.Core.Objects.Internal
{
	// Token: 0x02000443 RID: 1091
	internal sealed class EntityWrapperWithoutRelationships<TEntity> : global::System.Data.Entity.Core.Objects.Internal.EntityWrapper<TEntity> where TEntity : class
	{
		// Token: 0x0600355A RID: 13658 RVA: 0x000AAC98 File Offset: 0x000A8E98
		internal EntityWrapperWithoutRelationships(TEntity entity, global::System.Data.Entity.Core.EntityKey key, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Data.Entity.Core.Objects.ObjectContext context, global::System.Data.Entity.Core.Objects.MergeOption mergeOption, global::System.Type identityType, global::System.Func<object, global::System.Data.Entity.Core.Objects.Internal.IPropertyAccessorStrategy> propertyStrategy, global::System.Func<object, global::System.Data.Entity.Core.Objects.Internal.IChangeTrackingStrategy> changeTrackingStrategy, global::System.Func<object, global::System.Data.Entity.Core.Objects.Internal.IEntityKeyStrategy> keyStrategy, bool overridesEquals) : base(entity, global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager.Create(), key, entitySet, context, mergeOption, identityType, propertyStrategy, changeTrackingStrategy, keyStrategy, overridesEquals)
		{
		}

		// Token: 0x0600355B RID: 13659 RVA: 0x000AACC1 File Offset: 0x000A8EC1
		internal EntityWrapperWithoutRelationships(TEntity entity, global::System.Func<object, global::System.Data.Entity.Core.Objects.Internal.IPropertyAccessorStrategy> propertyStrategy, global::System.Func<object, global::System.Data.Entity.Core.Objects.Internal.IChangeTrackingStrategy> changeTrackingStrategy, global::System.Func<object, global::System.Data.Entity.Core.Objects.Internal.IEntityKeyStrategy> keyStrategy, bool overridesEquals) : base(entity, global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager.Create(), propertyStrategy, changeTrackingStrategy, keyStrategy, overridesEquals)
		{
		}

		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x0600355C RID: 13660 RVA: 0x000AACD5 File Offset: 0x000A8ED5
		public override bool OwnsRelationshipManager
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600355D RID: 13661 RVA: 0x000AACD8 File Offset: 0x000A8ED8
		public override void TakeSnapshotOfRelationships(global::System.Data.Entity.Core.Objects.EntityEntry entry)
		{
			entry.TakeSnapshotOfRelationships();
		}

		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x0600355E RID: 13662 RVA: 0x000AACE0 File Offset: 0x000A8EE0
		public override bool RequiresRelationshipChangeTracking
		{
			get
			{
				return true;
			}
		}
	}
}
