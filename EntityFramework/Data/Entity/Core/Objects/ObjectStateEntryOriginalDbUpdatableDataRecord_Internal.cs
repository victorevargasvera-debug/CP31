using System;

namespace System.Data.Entity.Core.Objects
{
	// Token: 0x02000422 RID: 1058
	internal class ObjectStateEntryOriginalDbUpdatableDataRecord_Internal : global::System.Data.Entity.Core.Objects.OriginalValueRecord
	{
		// Token: 0x06003315 RID: 13077 RVA: 0x000A201C File Offset: 0x000A021C
		internal ObjectStateEntryOriginalDbUpdatableDataRecord_Internal(global::System.Data.Entity.Core.Objects.EntityEntry cacheEntry, global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata metadata, object userObject) : base(cacheEntry, metadata, userObject)
		{
			global::System.Data.Entity.EntityState state = cacheEntry.State;
			if (state == global::System.Data.Entity.EntityState.Unchanged || state != global::System.Data.Entity.EntityState.Deleted)
			{
			}
		}

		// Token: 0x06003316 RID: 13078 RVA: 0x000A2046 File Offset: 0x000A0246
		protected override object GetRecordValue(int ordinal)
		{
			return (this._cacheEntry as global::System.Data.Entity.Core.Objects.EntityEntry).GetOriginalEntityValue(this._metadata, ordinal, this._userObject, global::System.Data.Entity.Core.Objects.ObjectStateValueRecord.OriginalUpdatableInternal);
		}

		// Token: 0x06003317 RID: 13079 RVA: 0x000A2066 File Offset: 0x000A0266
		protected override void SetRecordValue(int ordinal, object value)
		{
			(this._cacheEntry as global::System.Data.Entity.Core.Objects.EntityEntry).SetOriginalEntityValue(this._metadata, ordinal, this._userObject, value);
		}
	}
}
