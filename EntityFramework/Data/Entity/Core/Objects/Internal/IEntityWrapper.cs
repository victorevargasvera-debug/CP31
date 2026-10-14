using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects.DataClasses;

namespace System.Data.Entity.Core.Objects.Internal
{
	// Token: 0x02000448 RID: 1096
	internal interface IEntityWrapper
	{
		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x06003571 RID: 13681
		global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager RelationshipManager { get; }

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x06003572 RID: 13682
		bool OwnsRelationshipManager { get; }

		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x06003573 RID: 13683
		object Entity { get; }

		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x06003574 RID: 13684
		// (set) Token: 0x06003575 RID: 13685
		global::System.Data.Entity.Core.Objects.EntityEntry ObjectStateEntry { get; set; }

		// Token: 0x06003576 RID: 13686
		void EnsureCollectionNotNull(global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd);

		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x06003577 RID: 13687
		// (set) Token: 0x06003578 RID: 13688
		global::System.Data.Entity.Core.EntityKey EntityKey { get; set; }

		// Token: 0x06003579 RID: 13689
		global::System.Data.Entity.Core.EntityKey GetEntityKeyFromEntity();

		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x0600357A RID: 13690
		// (set) Token: 0x0600357B RID: 13691
		global::System.Data.Entity.Core.Objects.ObjectContext Context { get; set; }

		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x0600357C RID: 13692
		global::System.Data.Entity.Core.Objects.MergeOption MergeOption { get; }

		// Token: 0x0600357D RID: 13693
		void AttachContext(global::System.Data.Entity.Core.Objects.ObjectContext context, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Data.Entity.Core.Objects.MergeOption mergeOption);

		// Token: 0x0600357E RID: 13694
		void ResetContext(global::System.Data.Entity.Core.Objects.ObjectContext context, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Data.Entity.Core.Objects.MergeOption mergeOption);

		// Token: 0x0600357F RID: 13695
		void DetachContext();

		// Token: 0x06003580 RID: 13696
		void SetChangeTracker(global::System.Data.Entity.Core.Objects.DataClasses.IEntityChangeTracker changeTracker);

		// Token: 0x06003581 RID: 13697
		void TakeSnapshot(global::System.Data.Entity.Core.Objects.EntityEntry entry);

		// Token: 0x06003582 RID: 13698
		void TakeSnapshotOfRelationships(global::System.Data.Entity.Core.Objects.EntityEntry entry);

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x06003583 RID: 13699
		global::System.Type IdentityType { get; }

		// Token: 0x06003584 RID: 13700
		void CollectionAdd(global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd, object value);

		// Token: 0x06003585 RID: 13701
		bool CollectionRemove(global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd, object value);

		// Token: 0x06003586 RID: 13702
		object GetNavigationPropertyValue(global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd);

		// Token: 0x06003587 RID: 13703
		void SetNavigationPropertyValue(global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd, object value);

		// Token: 0x06003588 RID: 13704
		void RemoveNavigationPropertyValue(global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd, object value);

		// Token: 0x06003589 RID: 13705
		void SetCurrentValue(global::System.Data.Entity.Core.Objects.EntityEntry entry, global::System.Data.Entity.Core.Objects.StateManagerMemberMetadata member, int ordinal, object target, object value);

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x0600358A RID: 13706
		// (set) Token: 0x0600358B RID: 13707
		bool InitializingProxyRelatedEnds { get; set; }

		// Token: 0x0600358C RID: 13708
		void UpdateCurrentValueRecord(object value, global::System.Data.Entity.Core.Objects.EntityEntry entry);

		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x0600358D RID: 13709
		bool RequiresRelationshipChangeTracking { get; }

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x0600358E RID: 13710
		bool OverridesEqualsOrGetHashCode { get; }
	}
}
