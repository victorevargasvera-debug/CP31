using System;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Core.Objects
{
	// Token: 0x02000421 RID: 1057
	internal sealed class ObjectStateEntryDbUpdatableDataRecord : global::System.Data.Entity.Core.Objects.CurrentValueRecord
	{
		// Token: 0x06003311 RID: 13073 RVA: 0x000A1F50 File Offset: 0x000A0150
		internal ObjectStateEntryDbUpdatableDataRecord(global::System.Data.Entity.Core.Objects.EntityEntry cacheEntry, global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata metadata, object userObject) : base(cacheEntry, metadata, userObject)
		{
			global::System.Data.Entity.EntityState state = cacheEntry.State;
			if (state == global::System.Data.Entity.EntityState.Unchanged || state != global::System.Data.Entity.EntityState.Added)
			{
			}
		}

		// Token: 0x06003312 RID: 13074 RVA: 0x000A1F7C File Offset: 0x000A017C
		internal ObjectStateEntryDbUpdatableDataRecord(global::System.Data.Entity.Core.Objects.RelationshipEntry cacheEntry) : base(cacheEntry)
		{
			global::System.Data.Entity.EntityState state = cacheEntry.State;
			if (state == global::System.Data.Entity.EntityState.Unchanged || state != global::System.Data.Entity.EntityState.Added)
			{
			}
		}

		// Token: 0x06003313 RID: 13075 RVA: 0x000A1FA4 File Offset: 0x000A01A4
		protected override object GetRecordValue(int ordinal)
		{
			if (this._cacheEntry.IsRelationship)
			{
				return (this._cacheEntry as global::System.Data.Entity.Core.Objects.RelationshipEntry).GetCurrentRelationValue(ordinal);
			}
			return (this._cacheEntry as global::System.Data.Entity.Core.Objects.EntityEntry).GetCurrentEntityValue(this._metadata, ordinal, this._userObject, global::System.Data.Entity.Core.Objects.ObjectStateValueRecord.CurrentUpdatable);
		}

		// Token: 0x06003314 RID: 13076 RVA: 0x000A1FE3 File Offset: 0x000A01E3
		protected override void SetRecordValue(int ordinal, object value)
		{
			if (this._cacheEntry.IsRelationship)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_CantModifyRelationValues);
			}
			(this._cacheEntry as global::System.Data.Entity.Core.Objects.EntityEntry).SetCurrentEntityValue(this._metadata, ordinal, this._userObject, value);
		}
	}
}
