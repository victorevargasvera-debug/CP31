using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects.DataClasses;

namespace System.Data.Entity.Core.Objects.Internal
{
	// Token: 0x0200044E RID: 1102
	internal class NullEntityWrapper : global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper
	{
		// Token: 0x060035C1 RID: 13761 RVA: 0x000AC3F3 File Offset: 0x000AA5F3
		private NullEntityWrapper()
		{
		}

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x060035C2 RID: 13762 RVA: 0x000AC3FB File Offset: 0x000AA5FB
		internal static global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper NullWrapper
		{
			get
			{
				return global::System.Data.Entity.Core.Objects.Internal.NullEntityWrapper._nullWrapper;
			}
		}

		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x060035C3 RID: 13763 RVA: 0x000AC402 File Offset: 0x000AA602
		public global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager RelationshipManager
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x060035C4 RID: 13764 RVA: 0x000AC405 File Offset: 0x000AA605
		public bool OwnsRelationshipManager
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x060035C5 RID: 13765 RVA: 0x000AC408 File Offset: 0x000AA608
		public object Entity
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x060035C6 RID: 13766 RVA: 0x000AC40B File Offset: 0x000AA60B
		// (set) Token: 0x060035C7 RID: 13767 RVA: 0x000AC40E File Offset: 0x000AA60E
		public global::System.Data.Entity.Core.Objects.EntityEntry ObjectStateEntry
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x060035C8 RID: 13768 RVA: 0x000AC410 File Offset: 0x000AA610
		public void CollectionAdd(global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd, object value)
		{
		}

		// Token: 0x060035C9 RID: 13769 RVA: 0x000AC412 File Offset: 0x000AA612
		public bool CollectionRemove(global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd, object value)
		{
			return false;
		}

		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x060035CA RID: 13770 RVA: 0x000AC415 File Offset: 0x000AA615
		// (set) Token: 0x060035CB RID: 13771 RVA: 0x000AC418 File Offset: 0x000AA618
		public global::System.Data.Entity.Core.EntityKey EntityKey
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x060035CC RID: 13772 RVA: 0x000AC41A File Offset: 0x000AA61A
		public global::System.Data.Entity.Core.EntityKey GetEntityKeyFromEntity()
		{
			return null;
		}

		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x060035CD RID: 13773 RVA: 0x000AC41D File Offset: 0x000AA61D
		// (set) Token: 0x060035CE RID: 13774 RVA: 0x000AC420 File Offset: 0x000AA620
		public global::System.Data.Entity.Core.Objects.ObjectContext Context
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x060035CF RID: 13775 RVA: 0x000AC422 File Offset: 0x000AA622
		public global::System.Data.Entity.Core.Objects.MergeOption MergeOption
		{
			get
			{
				return global::System.Data.Entity.Core.Objects.MergeOption.NoTracking;
			}
		}

		// Token: 0x060035D0 RID: 13776 RVA: 0x000AC425 File Offset: 0x000AA625
		public void AttachContext(global::System.Data.Entity.Core.Objects.ObjectContext context, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Data.Entity.Core.Objects.MergeOption mergeOption)
		{
		}

		// Token: 0x060035D1 RID: 13777 RVA: 0x000AC427 File Offset: 0x000AA627
		public void ResetContext(global::System.Data.Entity.Core.Objects.ObjectContext context, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Data.Entity.Core.Objects.MergeOption mergeOption)
		{
		}

		// Token: 0x060035D2 RID: 13778 RVA: 0x000AC429 File Offset: 0x000AA629
		public void DetachContext()
		{
		}

		// Token: 0x060035D3 RID: 13779 RVA: 0x000AC42B File Offset: 0x000AA62B
		public void SetChangeTracker(global::System.Data.Entity.Core.Objects.DataClasses.IEntityChangeTracker changeTracker)
		{
		}

		// Token: 0x060035D4 RID: 13780 RVA: 0x000AC42D File Offset: 0x000AA62D
		public void TakeSnapshot(global::System.Data.Entity.Core.Objects.EntityEntry entry)
		{
		}

		// Token: 0x060035D5 RID: 13781 RVA: 0x000AC42F File Offset: 0x000AA62F
		public void TakeSnapshotOfRelationships(global::System.Data.Entity.Core.Objects.EntityEntry entry)
		{
		}

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x060035D6 RID: 13782 RVA: 0x000AC431 File Offset: 0x000AA631
		public global::System.Type IdentityType
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060035D7 RID: 13783 RVA: 0x000AC434 File Offset: 0x000AA634
		public void EnsureCollectionNotNull(global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd)
		{
		}

		// Token: 0x060035D8 RID: 13784 RVA: 0x000AC436 File Offset: 0x000AA636
		public object GetNavigationPropertyValue(global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd)
		{
			return null;
		}

		// Token: 0x060035D9 RID: 13785 RVA: 0x000AC439 File Offset: 0x000AA639
		public void SetNavigationPropertyValue(global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd, object value)
		{
		}

		// Token: 0x060035DA RID: 13786 RVA: 0x000AC43B File Offset: 0x000AA63B
		public void RemoveNavigationPropertyValue(global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd, object value)
		{
		}

		// Token: 0x060035DB RID: 13787 RVA: 0x000AC43D File Offset: 0x000AA63D
		public void SetCurrentValue(global::System.Data.Entity.Core.Objects.EntityEntry entry, global::System.Data.Entity.Core.Objects.StateManagerMemberMetadata member, int ordinal, object target, object value)
		{
		}

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x060035DC RID: 13788 RVA: 0x000AC43F File Offset: 0x000AA63F
		// (set) Token: 0x060035DD RID: 13789 RVA: 0x000AC442 File Offset: 0x000AA642
		public bool InitializingProxyRelatedEnds
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x060035DE RID: 13790 RVA: 0x000AC444 File Offset: 0x000AA644
		public void UpdateCurrentValueRecord(object value, global::System.Data.Entity.Core.Objects.EntityEntry entry)
		{
		}

		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x060035DF RID: 13791 RVA: 0x000AC446 File Offset: 0x000AA646
		public bool RequiresRelationshipChangeTracking
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x060035E0 RID: 13792 RVA: 0x000AC449 File Offset: 0x000AA649
		public bool OverridesEqualsOrGetHashCode
		{
			get
			{
				return false;
			}
		}

		// Token: 0x04001162 RID: 4450
		private static readonly global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper _nullWrapper = new global::System.Data.Entity.Core.Objects.Internal.NullEntityWrapper();
	}
}
