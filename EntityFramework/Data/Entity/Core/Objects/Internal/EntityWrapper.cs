using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Core.Objects.Internal
{
	// Token: 0x02000441 RID: 1089
	internal abstract class EntityWrapper<TEntity> : global::System.Data.Entity.Core.Objects.Internal.BaseEntityWrapper<TEntity> where TEntity : class
	{
		// Token: 0x06003536 RID: 13622 RVA: 0x000AA590 File Offset: 0x000A8790
		protected EntityWrapper(TEntity entity, global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager relationshipManager, global::System.Func<object, global::System.Data.Entity.Core.Objects.Internal.IPropertyAccessorStrategy> propertyStrategy, global::System.Func<object, global::System.Data.Entity.Core.Objects.Internal.IChangeTrackingStrategy> changeTrackingStrategy, global::System.Func<object, global::System.Data.Entity.Core.Objects.Internal.IEntityKeyStrategy> keyStrategy, bool overridesEquals) : base(entity, relationshipManager, overridesEquals)
		{
			if (relationshipManager == null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.RelationshipManager_UnexpectedNull);
			}
			this._entity = entity;
			this._propertyStrategy = propertyStrategy(entity);
			this._changeTrackingStrategy = changeTrackingStrategy(entity);
			this._keyStrategy = keyStrategy(entity);
		}

		// Token: 0x06003537 RID: 13623 RVA: 0x000AA5F4 File Offset: 0x000A87F4
		protected EntityWrapper(TEntity entity, global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager relationshipManager, global::System.Data.Entity.Core.EntityKey key, global::System.Data.Entity.Core.Metadata.Edm.EntitySet set, global::System.Data.Entity.Core.Objects.ObjectContext context, global::System.Data.Entity.Core.Objects.MergeOption mergeOption, global::System.Type identityType, global::System.Func<object, global::System.Data.Entity.Core.Objects.Internal.IPropertyAccessorStrategy> propertyStrategy, global::System.Func<object, global::System.Data.Entity.Core.Objects.Internal.IChangeTrackingStrategy> changeTrackingStrategy, global::System.Func<object, global::System.Data.Entity.Core.Objects.Internal.IEntityKeyStrategy> keyStrategy, bool overridesEquals) : base(entity, relationshipManager, set, context, mergeOption, identityType, overridesEquals)
		{
			if (relationshipManager == null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.RelationshipManager_UnexpectedNull);
			}
			this._entity = entity;
			this._propertyStrategy = propertyStrategy(entity);
			this._changeTrackingStrategy = changeTrackingStrategy(entity);
			this._keyStrategy = keyStrategy(entity);
			this._keyStrategy.SetEntityKey(key);
		}

		// Token: 0x06003538 RID: 13624 RVA: 0x000AA66D File Offset: 0x000A886D
		public override void SetChangeTracker(global::System.Data.Entity.Core.Objects.DataClasses.IEntityChangeTracker changeTracker)
		{
			this._changeTrackingStrategy.SetChangeTracker(changeTracker);
		}

		// Token: 0x06003539 RID: 13625 RVA: 0x000AA67B File Offset: 0x000A887B
		public override void TakeSnapshot(global::System.Data.Entity.Core.Objects.EntityEntry entry)
		{
			this._changeTrackingStrategy.TakeSnapshot(entry);
		}

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x0600353A RID: 13626 RVA: 0x000AA689 File Offset: 0x000A8889
		// (set) Token: 0x0600353B RID: 13627 RVA: 0x000AA696 File Offset: 0x000A8896
		public override global::System.Data.Entity.Core.EntityKey EntityKey
		{
			get
			{
				return this._keyStrategy.GetEntityKey();
			}
			set
			{
				this._keyStrategy.SetEntityKey(value);
			}
		}

		// Token: 0x0600353C RID: 13628 RVA: 0x000AA6A4 File Offset: 0x000A88A4
		public override global::System.Data.Entity.Core.EntityKey GetEntityKeyFromEntity()
		{
			return this._keyStrategy.GetEntityKeyFromEntity();
		}

		// Token: 0x0600353D RID: 13629 RVA: 0x000AA6B1 File Offset: 0x000A88B1
		public override void CollectionAdd(global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd, object value)
		{
			if (this._propertyStrategy != null)
			{
				this._propertyStrategy.CollectionAdd(relatedEnd, value);
			}
		}

		// Token: 0x0600353E RID: 13630 RVA: 0x000AA6C8 File Offset: 0x000A88C8
		public override bool CollectionRemove(global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd, object value)
		{
			return this._propertyStrategy != null && this._propertyStrategy.CollectionRemove(relatedEnd, value);
		}

		// Token: 0x0600353F RID: 13631 RVA: 0x000AA6E4 File Offset: 0x000A88E4
		public override void EnsureCollectionNotNull(global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd)
		{
			if (this._propertyStrategy != null && this._propertyStrategy.GetNavigationPropertyValue(relatedEnd) == null)
			{
				object value = this._propertyStrategy.CollectionCreate(relatedEnd);
				this._propertyStrategy.SetNavigationPropertyValue(relatedEnd, value);
			}
		}

		// Token: 0x06003540 RID: 13632 RVA: 0x000AA723 File Offset: 0x000A8923
		public override object GetNavigationPropertyValue(global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd)
		{
			if (this._propertyStrategy == null)
			{
				return null;
			}
			return this._propertyStrategy.GetNavigationPropertyValue(relatedEnd);
		}

		// Token: 0x06003541 RID: 13633 RVA: 0x000AA73B File Offset: 0x000A893B
		public override void SetNavigationPropertyValue(global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd, object value)
		{
			if (this._propertyStrategy != null)
			{
				this._propertyStrategy.SetNavigationPropertyValue(relatedEnd, value);
			}
		}

		// Token: 0x06003542 RID: 13634 RVA: 0x000AA752 File Offset: 0x000A8952
		public override void RemoveNavigationPropertyValue(global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd, object value)
		{
			if (this._propertyStrategy != null && this._propertyStrategy.GetNavigationPropertyValue(relatedEnd) == value)
			{
				this._propertyStrategy.SetNavigationPropertyValue(relatedEnd, null);
			}
		}

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x06003543 RID: 13635 RVA: 0x000AA778 File Offset: 0x000A8978
		public override object Entity
		{
			get
			{
				return this._entity;
			}
		}

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x06003544 RID: 13636 RVA: 0x000AA785 File Offset: 0x000A8985
		public override TEntity TypedEntity
		{
			get
			{
				return this._entity;
			}
		}

		// Token: 0x06003545 RID: 13637 RVA: 0x000AA78D File Offset: 0x000A898D
		public override void SetCurrentValue(global::System.Data.Entity.Core.Objects.EntityEntry entry, global::System.Data.Entity.Core.Objects.StateManagerMemberMetadata member, int ordinal, object target, object value)
		{
			this._changeTrackingStrategy.SetCurrentValue(entry, member, ordinal, target, value);
		}

		// Token: 0x06003546 RID: 13638 RVA: 0x000AA7A1 File Offset: 0x000A89A1
		public override void UpdateCurrentValueRecord(object value, global::System.Data.Entity.Core.Objects.EntityEntry entry)
		{
			this._changeTrackingStrategy.UpdateCurrentValueRecord(value, entry);
		}

		// Token: 0x0400113B RID: 4411
		private readonly TEntity _entity;

		// Token: 0x0400113C RID: 4412
		private readonly global::System.Data.Entity.Core.Objects.Internal.IPropertyAccessorStrategy _propertyStrategy;

		// Token: 0x0400113D RID: 4413
		private readonly global::System.Data.Entity.Core.Objects.Internal.IChangeTrackingStrategy _changeTrackingStrategy;

		// Token: 0x0400113E RID: 4414
		private readonly global::System.Data.Entity.Core.Objects.Internal.IEntityKeyStrategy _keyStrategy;
	}
}
