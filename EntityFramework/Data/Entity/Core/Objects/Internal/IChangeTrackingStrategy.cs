using System;
using System.Data.Entity.Core.Objects.DataClasses;

namespace System.Data.Entity.Core.Objects.Internal
{
	// Token: 0x02000446 RID: 1094
	internal interface IChangeTrackingStrategy
	{
		// Token: 0x0600356A RID: 13674
		void SetChangeTracker(global::System.Data.Entity.Core.Objects.DataClasses.IEntityChangeTracker changeTracker);

		// Token: 0x0600356B RID: 13675
		void TakeSnapshot(global::System.Data.Entity.Core.Objects.EntityEntry entry);

		// Token: 0x0600356C RID: 13676
		void SetCurrentValue(global::System.Data.Entity.Core.Objects.EntityEntry entry, global::System.Data.Entity.Core.Objects.StateManagerMemberMetadata member, int ordinal, object target, object value);

		// Token: 0x0600356D RID: 13677
		void UpdateCurrentValueRecord(object value, global::System.Data.Entity.Core.Objects.EntityEntry entry);
	}
}
