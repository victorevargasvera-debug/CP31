using System;
using System.Data.Entity.Core.Objects.DataClasses;

namespace System.Data.Entity.Core.Objects.Internal
{
	// Token: 0x02000459 RID: 1113
	internal sealed class SnapshotChangeTrackingStrategy : global::System.Data.Entity.Core.Objects.Internal.IChangeTrackingStrategy
	{
		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x0600368E RID: 13966 RVA: 0x000AFF33 File Offset: 0x000AE133
		public static global::System.Data.Entity.Core.Objects.Internal.SnapshotChangeTrackingStrategy Instance
		{
			get
			{
				return global::System.Data.Entity.Core.Objects.Internal.SnapshotChangeTrackingStrategy._instance;
			}
		}

		// Token: 0x0600368F RID: 13967 RVA: 0x000AFF3A File Offset: 0x000AE13A
		private SnapshotChangeTrackingStrategy()
		{
		}

		// Token: 0x06003690 RID: 13968 RVA: 0x000AFF42 File Offset: 0x000AE142
		public void SetChangeTracker(global::System.Data.Entity.Core.Objects.DataClasses.IEntityChangeTracker changeTracker)
		{
		}

		// Token: 0x06003691 RID: 13969 RVA: 0x000AFF44 File Offset: 0x000AE144
		public void TakeSnapshot(global::System.Data.Entity.Core.Objects.EntityEntry entry)
		{
			if (entry != null)
			{
				entry.TakeSnapshot(false);
			}
		}

		// Token: 0x06003692 RID: 13970 RVA: 0x000AFF50 File Offset: 0x000AE150
		public void SetCurrentValue(global::System.Data.Entity.Core.Objects.EntityEntry entry, global::System.Data.Entity.Core.Objects.StateManagerMemberMetadata member, int ordinal, object target, object value)
		{
			if (target == entry.Entity)
			{
				((global::System.Data.Entity.Core.Objects.DataClasses.IEntityChangeTracker)entry).EntityMemberChanging(member.CLayerName);
				member.SetValue(target, value);
				((global::System.Data.Entity.Core.Objects.DataClasses.IEntityChangeTracker)entry).EntityMemberChanged(member.CLayerName);
				if (member.IsComplex)
				{
					entry.UpdateComplexObjectSnapshot(member, target, ordinal, value);
					return;
				}
			}
			else
			{
				member.SetValue(target, value);
				if (entry.State != global::System.Data.Entity.EntityState.Added)
				{
					entry.DetectChangesInProperties(true);
				}
			}
		}

		// Token: 0x06003693 RID: 13971 RVA: 0x000AFFB8 File Offset: 0x000AE1B8
		public void UpdateCurrentValueRecord(object value, global::System.Data.Entity.Core.Objects.EntityEntry entry)
		{
			entry.UpdateRecordWithoutSetModified(value, entry.CurrentValues);
			entry.DetectChangesInProperties(false);
		}

		// Token: 0x040011AF RID: 4527
		private static readonly global::System.Data.Entity.Core.Objects.Internal.SnapshotChangeTrackingStrategy _instance = new global::System.Data.Entity.Core.Objects.Internal.SnapshotChangeTrackingStrategy();
	}
}
