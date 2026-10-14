using System;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Objects
{
	// Token: 0x02000423 RID: 1059
	internal sealed class ObjectStateEntryOriginalDbUpdatableDataRecord_Public : global::System.Data.Entity.Core.Objects.ObjectStateEntryOriginalDbUpdatableDataRecord_Internal
	{
		// Token: 0x06003318 RID: 13080 RVA: 0x000A2086 File Offset: 0x000A0286
		internal ObjectStateEntryOriginalDbUpdatableDataRecord_Public(global::System.Data.Entity.Core.Objects.EntityEntry cacheEntry, global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata metadata, object userObject, int parentEntityPropertyIndex) : base(cacheEntry, metadata, userObject)
		{
			this._parentEntityPropertyIndex = parentEntityPropertyIndex;
		}

		// Token: 0x06003319 RID: 13081 RVA: 0x000A2099 File Offset: 0x000A0299
		protected override object GetRecordValue(int ordinal)
		{
			return (this._cacheEntry as global::System.Data.Entity.Core.Objects.EntityEntry).GetOriginalEntityValue(this._metadata, ordinal, this._userObject, global::System.Data.Entity.Core.Objects.ObjectStateValueRecord.OriginalUpdatablePublic, this.GetPropertyIndex(ordinal));
		}

		// Token: 0x0600331A RID: 13082 RVA: 0x000A20C0 File Offset: 0x000A02C0
		protected override void SetRecordValue(int ordinal, object value)
		{
			global::System.Data.Entity.Core.Objects.StateManagerMemberMetadata stateManagerMemberMetadata = this._metadata.Member(ordinal);
			if (stateManagerMemberMetadata.IsComplex)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_SetOriginalComplexProperties(stateManagerMemberMetadata.CLayerName));
			}
			object obj = value ?? global::System.DBNull.Value;
			global::System.Data.Entity.Core.Objects.EntityEntry entityEntry = this._cacheEntry as global::System.Data.Entity.Core.Objects.EntityEntry;
			global::System.Data.Entity.EntityState state = entityEntry.State;
			if (entityEntry.HasRecordValueChanged(this, ordinal, obj))
			{
				if (stateManagerMemberMetadata.IsPartOfKey)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_SetOriginalPrimaryKey(stateManagerMemberMetadata.CLayerName));
				}
				global::System.Type clrType = stateManagerMemberMetadata.ClrType;
				if (global::System.DBNull.Value == obj && clrType.IsValueType() && !stateManagerMemberMetadata.CdmMetadata.Nullable)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_NullOriginalValueForNonNullableProperty(stateManagerMemberMetadata.CLayerName, stateManagerMemberMetadata.ClrMetadata.Name, stateManagerMemberMetadata.ClrMetadata.DeclaringType.FullName));
				}
				base.SetRecordValue(ordinal, value);
				if (state == global::System.Data.Entity.EntityState.Unchanged && entityEntry.State == global::System.Data.Entity.EntityState.Modified)
				{
					entityEntry.ObjectStateManager.ChangeState(entityEntry, state, global::System.Data.Entity.EntityState.Modified);
				}
				entityEntry.SetModifiedPropertyInternal(this.GetPropertyIndex(ordinal));
			}
		}

		// Token: 0x0600331B RID: 13083 RVA: 0x000A21BC File Offset: 0x000A03BC
		private int GetPropertyIndex(int ordinal)
		{
			if (this._parentEntityPropertyIndex != -1)
			{
				return this._parentEntityPropertyIndex;
			}
			return ordinal;
		}

		// Token: 0x04001098 RID: 4248
		private readonly int _parentEntityPropertyIndex;
	}
}
