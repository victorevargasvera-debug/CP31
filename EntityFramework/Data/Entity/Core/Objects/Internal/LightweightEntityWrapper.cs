using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects.DataClasses;

namespace System.Data.Entity.Core.Objects.Internal
{
	// Token: 0x0200044D RID: 1101
	internal sealed class LightweightEntityWrapper<TEntity> : global::System.Data.Entity.Core.Objects.Internal.BaseEntityWrapper<TEntity> where TEntity : class, global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithRelationships, global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithKey, global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithChangeTracker
	{
		// Token: 0x060035AD RID: 13741 RVA: 0x000AC310 File Offset: 0x000AA510
		internal LightweightEntityWrapper(TEntity entity, bool overridesEquals) : base(entity, entity.RelationshipManager, overridesEquals)
		{
			this._entity = entity;
		}

		// Token: 0x060035AE RID: 13742 RVA: 0x000AC32C File Offset: 0x000AA52C
		internal LightweightEntityWrapper(TEntity entity, global::System.Data.Entity.Core.EntityKey key, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Data.Entity.Core.Objects.ObjectContext context, global::System.Data.Entity.Core.Objects.MergeOption mergeOption, global::System.Type identityType, bool overridesEquals) : base(entity, entity.RelationshipManager, entitySet, context, mergeOption, identityType, overridesEquals)
		{
			this._entity = entity;
			this._entity.EntityKey = key;
		}

		// Token: 0x060035AF RID: 13743 RVA: 0x000AC361 File Offset: 0x000AA561
		public override void SetChangeTracker(global::System.Data.Entity.Core.Objects.DataClasses.IEntityChangeTracker changeTracker)
		{
			this._entity.SetChangeTracker(changeTracker);
		}

		// Token: 0x060035B0 RID: 13744 RVA: 0x000AC374 File Offset: 0x000AA574
		public override void TakeSnapshot(global::System.Data.Entity.Core.Objects.EntityEntry entry)
		{
		}

		// Token: 0x060035B1 RID: 13745 RVA: 0x000AC376 File Offset: 0x000AA576
		public override void TakeSnapshotOfRelationships(global::System.Data.Entity.Core.Objects.EntityEntry entry)
		{
		}

		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x060035B2 RID: 13746 RVA: 0x000AC378 File Offset: 0x000AA578
		// (set) Token: 0x060035B3 RID: 13747 RVA: 0x000AC38A File Offset: 0x000AA58A
		public override global::System.Data.Entity.Core.EntityKey EntityKey
		{
			get
			{
				return this._entity.EntityKey;
			}
			set
			{
				this._entity.EntityKey = value;
			}
		}

		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x060035B4 RID: 13748 RVA: 0x000AC39D File Offset: 0x000AA59D
		public override bool OwnsRelationshipManager
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060035B5 RID: 13749 RVA: 0x000AC3A0 File Offset: 0x000AA5A0
		public override global::System.Data.Entity.Core.EntityKey GetEntityKeyFromEntity()
		{
			return this._entity.EntityKey;
		}

		// Token: 0x060035B6 RID: 13750 RVA: 0x000AC3B2 File Offset: 0x000AA5B2
		public override void CollectionAdd(global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd, object value)
		{
		}

		// Token: 0x060035B7 RID: 13751 RVA: 0x000AC3B4 File Offset: 0x000AA5B4
		public override bool CollectionRemove(global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd, object value)
		{
			return false;
		}

		// Token: 0x060035B8 RID: 13752 RVA: 0x000AC3B7 File Offset: 0x000AA5B7
		public override void SetNavigationPropertyValue(global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd, object value)
		{
		}

		// Token: 0x060035B9 RID: 13753 RVA: 0x000AC3B9 File Offset: 0x000AA5B9
		public override void RemoveNavigationPropertyValue(global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd, object value)
		{
		}

		// Token: 0x060035BA RID: 13754 RVA: 0x000AC3BB File Offset: 0x000AA5BB
		public override void EnsureCollectionNotNull(global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd)
		{
		}

		// Token: 0x060035BB RID: 13755 RVA: 0x000AC3BD File Offset: 0x000AA5BD
		public override object GetNavigationPropertyValue(global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd)
		{
			return null;
		}

		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x060035BC RID: 13756 RVA: 0x000AC3C0 File Offset: 0x000AA5C0
		public override object Entity
		{
			get
			{
				return this._entity;
			}
		}

		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x060035BD RID: 13757 RVA: 0x000AC3CD File Offset: 0x000AA5CD
		public override TEntity TypedEntity
		{
			get
			{
				return this._entity;
			}
		}

		// Token: 0x060035BE RID: 13758 RVA: 0x000AC3D5 File Offset: 0x000AA5D5
		public override void SetCurrentValue(global::System.Data.Entity.Core.Objects.EntityEntry entry, global::System.Data.Entity.Core.Objects.StateManagerMemberMetadata member, int ordinal, object target, object value)
		{
			member.SetValue(target, value);
		}

		// Token: 0x060035BF RID: 13759 RVA: 0x000AC3E1 File Offset: 0x000AA5E1
		public override void UpdateCurrentValueRecord(object value, global::System.Data.Entity.Core.Objects.EntityEntry entry)
		{
			entry.UpdateRecordWithoutSetModified(value, entry.CurrentValues);
		}

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x060035C0 RID: 13760 RVA: 0x000AC3F0 File Offset: 0x000AA5F0
		public override bool RequiresRelationshipChangeTracking
		{
			get
			{
				return false;
			}
		}

		// Token: 0x04001161 RID: 4449
		private readonly TEntity _entity;
	}
}
