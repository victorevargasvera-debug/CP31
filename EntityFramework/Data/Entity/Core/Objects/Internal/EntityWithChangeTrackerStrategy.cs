using System;
using System.Data.Entity.Core.Objects.DataClasses;

namespace System.Data.Entity.Core.Objects.Internal
{
	// Token: 0x0200043F RID: 1087
	internal sealed class EntityWithChangeTrackerStrategy : global::System.Data.Entity.Core.Objects.Internal.IChangeTrackingStrategy
	{
		// Token: 0x0600352D RID: 13613 RVA: 0x000AA4E6 File Offset: 0x000A86E6
		public EntityWithChangeTrackerStrategy(global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithChangeTracker entity)
		{
			this._entity = entity;
		}

		// Token: 0x0600352E RID: 13614 RVA: 0x000AA4F5 File Offset: 0x000A86F5
		public void SetChangeTracker(global::System.Data.Entity.Core.Objects.DataClasses.IEntityChangeTracker changeTracker)
		{
			this._entity.SetChangeTracker(changeTracker);
		}

		// Token: 0x0600352F RID: 13615 RVA: 0x000AA503 File Offset: 0x000A8703
		public void TakeSnapshot(global::System.Data.Entity.Core.Objects.EntityEntry entry)
		{
			if (entry != null && entry.RequiresComplexChangeTracking)
			{
				entry.TakeSnapshot(true);
			}
		}

		// Token: 0x06003530 RID: 13616 RVA: 0x000AA517 File Offset: 0x000A8717
		public void SetCurrentValue(global::System.Data.Entity.Core.Objects.EntityEntry entry, global::System.Data.Entity.Core.Objects.StateManagerMemberMetadata member, int ordinal, object target, object value)
		{
			member.SetValue(target, value);
		}

		// Token: 0x06003531 RID: 13617 RVA: 0x000AA523 File Offset: 0x000A8723
		public void UpdateCurrentValueRecord(object value, global::System.Data.Entity.Core.Objects.EntityEntry entry)
		{
			bool flag = entry.WrappedEntity.IdentityType != this._entity.GetType();
			entry.UpdateRecordWithoutSetModified(value, entry.CurrentValues);
			if (flag)
			{
				entry.DetectChangesInProperties(true);
			}
		}

		// Token: 0x04001139 RID: 4409
		private readonly global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithChangeTracker _entity;
	}
}
