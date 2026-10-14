using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Core.Objects.Internal
{
	// Token: 0x02000435 RID: 1077
	internal abstract class BaseEntityWrapper<TEntity> : global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper where TEntity : class
	{
		// Token: 0x06003467 RID: 13415 RVA: 0x000A82C7 File Offset: 0x000A64C7
		protected BaseEntityWrapper(TEntity entity, global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager relationshipManager, bool overridesEquals)
		{
			if (relationshipManager == null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.RelationshipManager_UnexpectedNull);
			}
			this._relationshipManager = relationshipManager;
			if (overridesEquals)
			{
				this._flags = global::System.Data.Entity.Core.Objects.Internal.BaseEntityWrapper<TEntity>.WrapperFlags.OverridesEquals;
			}
		}

		// Token: 0x06003468 RID: 13416 RVA: 0x000A82F0 File Offset: 0x000A64F0
		protected BaseEntityWrapper(TEntity entity, global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager relationshipManager, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Data.Entity.Core.Objects.ObjectContext context, global::System.Data.Entity.Core.Objects.MergeOption mergeOption, global::System.Type identityType, bool overridesEquals)
		{
			if (relationshipManager == null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.RelationshipManager_UnexpectedNull);
			}
			this._identityType = identityType;
			this._relationshipManager = relationshipManager;
			if (overridesEquals)
			{
				this._flags = global::System.Data.Entity.Core.Objects.Internal.BaseEntityWrapper<TEntity>.WrapperFlags.OverridesEquals;
			}
			this.RelationshipManager.SetWrappedOwner(this, entity);
			if (entitySet != null)
			{
				this.Context = context;
				this.MergeOption = mergeOption;
				this.RelationshipManager.AttachContextToRelatedEnds(context, entitySet, mergeOption);
			}
		}

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x06003469 RID: 13417 RVA: 0x000A8360 File Offset: 0x000A6560
		public global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager RelationshipManager
		{
			get
			{
				return this._relationshipManager;
			}
		}

		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x0600346A RID: 13418 RVA: 0x000A8368 File Offset: 0x000A6568
		// (set) Token: 0x0600346B RID: 13419 RVA: 0x000A8370 File Offset: 0x000A6570
		public global::System.Data.Entity.Core.Objects.ObjectContext Context { get; set; }

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x0600346C RID: 13420 RVA: 0x000A8379 File Offset: 0x000A6579
		// (set) Token: 0x0600346D RID: 13421 RVA: 0x000A8388 File Offset: 0x000A6588
		public global::System.Data.Entity.Core.Objects.MergeOption MergeOption
		{
			get
			{
				if ((this._flags & global::System.Data.Entity.Core.Objects.Internal.BaseEntityWrapper<TEntity>.WrapperFlags.NoTracking) == global::System.Data.Entity.Core.Objects.Internal.BaseEntityWrapper<TEntity>.WrapperFlags.None)
				{
					return global::System.Data.Entity.Core.Objects.MergeOption.AppendOnly;
				}
				return global::System.Data.Entity.Core.Objects.MergeOption.NoTracking;
			}
			private set
			{
				if (value == global::System.Data.Entity.Core.Objects.MergeOption.NoTracking)
				{
					this._flags |= global::System.Data.Entity.Core.Objects.Internal.BaseEntityWrapper<TEntity>.WrapperFlags.NoTracking;
					return;
				}
				this._flags &= ~global::System.Data.Entity.Core.Objects.Internal.BaseEntityWrapper<TEntity>.WrapperFlags.NoTracking;
			}
		}

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x0600346E RID: 13422 RVA: 0x000A83AC File Offset: 0x000A65AC
		// (set) Token: 0x0600346F RID: 13423 RVA: 0x000A83B9 File Offset: 0x000A65B9
		public bool InitializingProxyRelatedEnds
		{
			get
			{
				return (this._flags & global::System.Data.Entity.Core.Objects.Internal.BaseEntityWrapper<TEntity>.WrapperFlags.InitializingRelatedEnds) > global::System.Data.Entity.Core.Objects.Internal.BaseEntityWrapper<TEntity>.WrapperFlags.None;
			}
			set
			{
				if (value)
				{
					this._flags |= global::System.Data.Entity.Core.Objects.Internal.BaseEntityWrapper<TEntity>.WrapperFlags.InitializingRelatedEnds;
					return;
				}
				this._flags &= ~global::System.Data.Entity.Core.Objects.Internal.BaseEntityWrapper<TEntity>.WrapperFlags.InitializingRelatedEnds;
			}
		}

		// Token: 0x06003470 RID: 13424 RVA: 0x000A83DC File Offset: 0x000A65DC
		public void AttachContext(global::System.Data.Entity.Core.Objects.ObjectContext context, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Data.Entity.Core.Objects.MergeOption mergeOption)
		{
			this.Context = context;
			this.MergeOption = mergeOption;
			if (entitySet != null)
			{
				this.RelationshipManager.AttachContextToRelatedEnds(context, entitySet, mergeOption);
			}
		}

		// Token: 0x06003471 RID: 13425 RVA: 0x000A83FD File Offset: 0x000A65FD
		public void ResetContext(global::System.Data.Entity.Core.Objects.ObjectContext context, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Data.Entity.Core.Objects.MergeOption mergeOption)
		{
			if (this.Context != context)
			{
				this.Context = context;
				this.MergeOption = mergeOption;
				this.RelationshipManager.ResetContextOnRelatedEnds(context, entitySet, mergeOption);
			}
		}

		// Token: 0x06003472 RID: 13426 RVA: 0x000A8424 File Offset: 0x000A6624
		public void DetachContext()
		{
			if (this.Context != null && this.Context.ObjectStateManager.TransactionManager.IsAttachTracking)
			{
				global::System.Data.Entity.Core.Objects.MergeOption? originalMergeOption = this.Context.ObjectStateManager.TransactionManager.OriginalMergeOption;
				global::System.Data.Entity.Core.Objects.MergeOption mergeOption = global::System.Data.Entity.Core.Objects.MergeOption.NoTracking;
				if (originalMergeOption.GetValueOrDefault() == mergeOption & originalMergeOption != null)
				{
					this.MergeOption = global::System.Data.Entity.Core.Objects.MergeOption.NoTracking;
					goto IL_5B;
				}
			}
			this.Context = null;
			IL_5B:
			this.RelationshipManager.DetachContextFromRelatedEnds();
		}

		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x06003473 RID: 13427 RVA: 0x000A8497 File Offset: 0x000A6697
		// (set) Token: 0x06003474 RID: 13428 RVA: 0x000A849F File Offset: 0x000A669F
		public global::System.Data.Entity.Core.Objects.EntityEntry ObjectStateEntry { get; set; }

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x06003475 RID: 13429 RVA: 0x000A84A8 File Offset: 0x000A66A8
		public global::System.Type IdentityType
		{
			get
			{
				if (this._identityType == null)
				{
					this._identityType = global::System.Data.Entity.Core.EntityUtil.GetEntityIdentityType(typeof(TEntity));
				}
				return this._identityType;
			}
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x06003476 RID: 13430 RVA: 0x000A84D3 File Offset: 0x000A66D3
		public bool OverridesEqualsOrGetHashCode
		{
			get
			{
				return (this._flags & global::System.Data.Entity.Core.Objects.Internal.BaseEntityWrapper<TEntity>.WrapperFlags.OverridesEquals) > global::System.Data.Entity.Core.Objects.Internal.BaseEntityWrapper<TEntity>.WrapperFlags.None;
			}
		}

		// Token: 0x06003477 RID: 13431
		public abstract void EnsureCollectionNotNull(global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd);

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x06003478 RID: 13432
		// (set) Token: 0x06003479 RID: 13433
		public abstract global::System.Data.Entity.Core.EntityKey EntityKey { get; set; }

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x0600347A RID: 13434
		public abstract bool OwnsRelationshipManager { get; }

		// Token: 0x0600347B RID: 13435
		public abstract global::System.Data.Entity.Core.EntityKey GetEntityKeyFromEntity();

		// Token: 0x0600347C RID: 13436
		public abstract void SetChangeTracker(global::System.Data.Entity.Core.Objects.DataClasses.IEntityChangeTracker changeTracker);

		// Token: 0x0600347D RID: 13437
		public abstract void TakeSnapshot(global::System.Data.Entity.Core.Objects.EntityEntry entry);

		// Token: 0x0600347E RID: 13438
		public abstract void TakeSnapshotOfRelationships(global::System.Data.Entity.Core.Objects.EntityEntry entry);

		// Token: 0x0600347F RID: 13439
		public abstract object GetNavigationPropertyValue(global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd);

		// Token: 0x06003480 RID: 13440
		public abstract void SetNavigationPropertyValue(global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd, object value);

		// Token: 0x06003481 RID: 13441
		public abstract void RemoveNavigationPropertyValue(global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd, object value);

		// Token: 0x06003482 RID: 13442
		public abstract void CollectionAdd(global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd, object value);

		// Token: 0x06003483 RID: 13443
		public abstract bool CollectionRemove(global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd, object value);

		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x06003484 RID: 13444
		public abstract object Entity { get; }

		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x06003485 RID: 13445
		public abstract TEntity TypedEntity { get; }

		// Token: 0x06003486 RID: 13446
		public abstract void SetCurrentValue(global::System.Data.Entity.Core.Objects.EntityEntry entry, global::System.Data.Entity.Core.Objects.StateManagerMemberMetadata member, int ordinal, object target, object value);

		// Token: 0x06003487 RID: 13447
		public abstract void UpdateCurrentValueRecord(object value, global::System.Data.Entity.Core.Objects.EntityEntry entry);

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x06003488 RID: 13448
		public abstract bool RequiresRelationshipChangeTracking { get; }

		// Token: 0x040010EC RID: 4332
		private readonly global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager _relationshipManager;

		// Token: 0x040010ED RID: 4333
		private global::System.Type _identityType;

		// Token: 0x040010EE RID: 4334
		private global::System.Data.Entity.Core.Objects.Internal.BaseEntityWrapper<TEntity>.WrapperFlags _flags;

		// Token: 0x02000A40 RID: 2624
		[global::System.Flags]
		private enum WrapperFlags
		{
			// Token: 0x04002A2C RID: 10796
			None = 0,
			// Token: 0x04002A2D RID: 10797
			NoTracking = 1,
			// Token: 0x04002A2E RID: 10798
			InitializingRelatedEnds = 2,
			// Token: 0x04002A2F RID: 10799
			OverridesEquals = 4
		}
	}
}
