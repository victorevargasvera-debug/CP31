using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity.Core.Objects.Internal;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Diagnostics;
using System.Linq;

namespace System.Data.Entity.Core.Objects
{
	// Token: 0x02000407 RID: 1031
	internal sealed class EntityEntry : global::System.Data.Entity.Core.Objects.ObjectStateEntry
	{
		// Token: 0x06003036 RID: 12342 RVA: 0x00097600 File Offset: 0x00095800
		internal EntityEntry() : base(new global::System.Data.Entity.Core.Objects.ObjectStateManager(), null, global::System.Data.Entity.EntityState.Unchanged)
		{
		}

		// Token: 0x06003037 RID: 12343 RVA: 0x0009760F File Offset: 0x0009580F
		internal EntityEntry(global::System.Data.Entity.Core.Objects.ObjectStateManager stateManager) : base(stateManager, null, global::System.Data.Entity.EntityState.Unchanged)
		{
		}

		// Token: 0x06003038 RID: 12344 RVA: 0x0009761A File Offset: 0x0009581A
		internal EntityEntry(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity, global::System.Data.Entity.Core.EntityKey entityKey, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Data.Entity.Core.Objects.ObjectStateManager cache, global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata typeMetadata, global::System.Data.Entity.EntityState state) : base(cache, entitySet, state)
		{
			this._wrappedEntity = wrappedEntity;
			this._cacheTypeMetadata = typeMetadata;
			this._entityKey = entityKey;
			wrappedEntity.ObjectStateEntry = this;
			this.SetChangeTrackingFlags();
		}

		// Token: 0x06003039 RID: 12345 RVA: 0x0009764C File Offset: 0x0009584C
		private void SetChangeTrackingFlags()
		{
			this._requiresScalarChangeTracking = (this.Entity != null && !(this.Entity is global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithChangeTracker));
			bool requiresComplexChangeTracking;
			if (this.Entity != null)
			{
				if (!this._requiresScalarChangeTracking)
				{
					if (this.WrappedEntity.IdentityType != this.Entity.GetType())
					{
						requiresComplexChangeTracking = this._cacheTypeMetadata.Members.Any((global::System.Data.Entity.Core.Objects.StateManagerMemberMetadata m) => m.IsComplex);
					}
					else
					{
						requiresComplexChangeTracking = false;
					}
				}
				else
				{
					requiresComplexChangeTracking = true;
				}
			}
			else
			{
				requiresComplexChangeTracking = false;
			}
			this._requiresComplexChangeTracking = requiresComplexChangeTracking;
			this._requiresAnyChangeTracking = (this.Entity != null && (!(this.Entity is global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithRelationships) || this._requiresComplexChangeTracking || this._requiresScalarChangeTracking));
		}

		// Token: 0x0600303A RID: 12346 RVA: 0x00097715 File Offset: 0x00095915
		internal EntityEntry(global::System.Data.Entity.Core.EntityKey entityKey, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Data.Entity.Core.Objects.ObjectStateManager cache, global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata typeMetadata) : base(cache, entitySet, global::System.Data.Entity.EntityState.Unchanged)
		{
			this._wrappedEntity = global::System.Data.Entity.Core.Objects.Internal.NullEntityWrapper.NullWrapper;
			this._entityKey = entityKey;
			this._cacheTypeMetadata = typeMetadata;
			this.SetChangeTrackingFlags();
		}

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x0600303B RID: 12347 RVA: 0x00097740 File Offset: 0x00095940
		public override bool IsRelationship
		{
			get
			{
				base.ValidateState();
				return false;
			}
		}

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x0600303C RID: 12348 RVA: 0x00097749 File Offset: 0x00095949
		public override object Entity
		{
			get
			{
				base.ValidateState();
				return this._wrappedEntity.Entity;
			}
		}

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x0600303D RID: 12349 RVA: 0x0009775C File Offset: 0x0009595C
		// (set) Token: 0x0600303E RID: 12350 RVA: 0x0009776A File Offset: 0x0009596A
		public override global::System.Data.Entity.Core.EntityKey EntityKey
		{
			get
			{
				base.ValidateState();
				return this._entityKey;
			}
			internal set
			{
				this._entityKey = value;
			}
		}

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x0600303F RID: 12351 RVA: 0x00097773 File Offset: 0x00095973
		internal global::System.Collections.Generic.IEnumerable<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>> ForeignKeyDependents
		{
			get
			{
				foreach (global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint> tuple in ((global::System.Data.Entity.Core.Metadata.Edm.EntitySet)base.EntitySet).ForeignKeyDependents)
				{
					if (global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetEntityTypeForEnd((global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember)tuple.Item2.ToRole).IsAssignableFrom(this._cacheTypeMetadata.DataRecordInfo.RecordType.EdmType))
					{
						yield return tuple;
					}
				}
				global::System.Collections.Generic.IEnumerator<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>> enumerator = null;
				yield break;
				yield break;
			}
		}

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x06003040 RID: 12352 RVA: 0x00097783 File Offset: 0x00095983
		internal global::System.Collections.Generic.IEnumerable<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>> ForeignKeyPrincipals
		{
			get
			{
				foreach (global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint> tuple in ((global::System.Data.Entity.Core.Metadata.Edm.EntitySet)base.EntitySet).ForeignKeyPrincipals)
				{
					if (global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetEntityTypeForEnd((global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember)tuple.Item2.FromRole).IsAssignableFrom(this._cacheTypeMetadata.DataRecordInfo.RecordType.EdmType))
					{
						yield return tuple;
					}
				}
				global::System.Collections.Generic.IEnumerator<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>> enumerator = null;
				yield break;
				yield break;
			}
		}

		// Token: 0x06003041 RID: 12353 RVA: 0x00097793 File Offset: 0x00095993
		public override global::System.Collections.Generic.IEnumerable<string> GetModifiedProperties()
		{
			base.ValidateState();
			if (global::System.Data.Entity.EntityState.Modified == base.State && this._modifiedFields != null)
			{
				int num;
				for (int i = 0; i < this._modifiedFields.Length; i = num + 1)
				{
					if (this._modifiedFields[i])
					{
						yield return this.GetCLayerName(i, this._cacheTypeMetadata);
					}
					num = i;
				}
			}
			yield break;
		}

		// Token: 0x06003042 RID: 12354 RVA: 0x000977A4 File Offset: 0x000959A4
		public override void SetModifiedProperty(string propertyName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(propertyName, "propertyName");
			int modifiedPropertyInternal = this.ValidateAndGetOrdinalForProperty(propertyName, "SetModifiedProperty");
			if (global::System.Data.Entity.EntityState.Unchanged == base.State)
			{
				base.State = global::System.Data.Entity.EntityState.Modified;
				this._cache.ChangeState(this, global::System.Data.Entity.EntityState.Unchanged, base.State);
			}
			this.SetModifiedPropertyInternal(modifiedPropertyInternal);
		}

		// Token: 0x06003043 RID: 12355 RVA: 0x000977F5 File Offset: 0x000959F5
		internal void SetModifiedPropertyInternal(int ordinal)
		{
			if (this._modifiedFields == null)
			{
				this._modifiedFields = new global::System.Collections.BitArray(this.GetFieldCount(this._cacheTypeMetadata));
			}
			this._modifiedFields[ordinal] = true;
		}

		// Token: 0x06003044 RID: 12356 RVA: 0x00097824 File Offset: 0x00095A24
		private int ValidateAndGetOrdinalForProperty(string propertyName, string methodName)
		{
			base.ValidateState();
			if (this.IsKeyEntry)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_CannotModifyKeyEntryState);
			}
			int ordinalforOLayerMemberName = this._cacheTypeMetadata.GetOrdinalforOLayerMemberName(propertyName);
			if (ordinalforOLayerMemberName == -1)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_SetModifiedOnInvalidProperty(propertyName));
			}
			if (base.State == global::System.Data.Entity.EntityState.Added || base.State == global::System.Data.Entity.EntityState.Deleted)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_SetModifiedStates(methodName));
			}
			return ordinalforOLayerMemberName;
		}

		// Token: 0x06003045 RID: 12357 RVA: 0x00097884 File Offset: 0x00095A84
		public override void RejectPropertyChanges(string propertyName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(propertyName, "propertyName");
			int num = this.ValidateAndGetOrdinalForProperty(propertyName, "RejectPropertyChanges");
			if (base.State == global::System.Data.Entity.EntityState.Unchanged)
			{
				return;
			}
			if (this._modifiedFields != null && this._modifiedFields[num])
			{
				this.DetectChangesInComplexProperties();
				object originalEntityValue = this.GetOriginalEntityValue(this._cacheTypeMetadata, num, this._wrappedEntity.Entity, global::System.Data.Entity.Core.Objects.ObjectStateValueRecord.OriginalReadonly);
				this.SetCurrentEntityValue(this._cacheTypeMetadata, num, this._wrappedEntity.Entity, originalEntityValue);
				this._modifiedFields[num] = false;
				for (int i = 0; i < this._modifiedFields.Length; i++)
				{
					if (this._modifiedFields[i])
					{
						return;
					}
				}
				this.ChangeObjectState(global::System.Data.Entity.EntityState.Unchanged);
			}
		}

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x06003046 RID: 12358 RVA: 0x0009793F File Offset: 0x00095B3F
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		public override global::System.Data.Common.DbDataRecord OriginalValues
		{
			get
			{
				return this.InternalGetOriginalValues(true);
			}
		}

		// Token: 0x06003047 RID: 12359 RVA: 0x00097948 File Offset: 0x00095B48
		public override global::System.Data.Entity.Core.Objects.OriginalValueRecord GetUpdatableOriginalValues()
		{
			return (global::System.Data.Entity.Core.Objects.OriginalValueRecord)this.InternalGetOriginalValues(false);
		}

		// Token: 0x06003048 RID: 12360 RVA: 0x00097958 File Offset: 0x00095B58
		private global::System.Data.Common.DbDataRecord InternalGetOriginalValues(bool readOnly)
		{
			base.ValidateState();
			if (base.State == global::System.Data.Entity.EntityState.Added)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_OriginalValuesDoesNotExist);
			}
			if (this.IsKeyEntry)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_CannotAccessKeyEntryValues);
			}
			this.DetectChangesInComplexProperties();
			if (readOnly)
			{
				return new global::System.Data.Entity.Core.Objects.ObjectStateEntryDbDataRecord(this, this._cacheTypeMetadata, this._wrappedEntity.Entity);
			}
			return new global::System.Data.Entity.Core.Objects.ObjectStateEntryOriginalDbUpdatableDataRecord_Public(this, this._cacheTypeMetadata, this._wrappedEntity.Entity, -1);
		}

		// Token: 0x06003049 RID: 12361 RVA: 0x000979CC File Offset: 0x00095BCC
		private void DetectChangesInComplexProperties()
		{
			if (this.RequiresScalarChangeTracking)
			{
				base.ObjectStateManager.TransactionManager.BeginOriginalValuesGetter();
				try
				{
					this.DetectChangesInProperties(true);
				}
				finally
				{
					base.ObjectStateManager.TransactionManager.EndOriginalValuesGetter();
				}
			}
		}

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x0600304A RID: 12362 RVA: 0x00097A1C File Offset: 0x00095C1C
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		public override global::System.Data.Entity.Core.Objects.CurrentValueRecord CurrentValues
		{
			get
			{
				base.ValidateState();
				if (base.State == global::System.Data.Entity.EntityState.Deleted)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_CurrentValuesDoesNotExist);
				}
				if (this.IsKeyEntry)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_CannotAccessKeyEntryValues);
				}
				return new global::System.Data.Entity.Core.Objects.ObjectStateEntryDbUpdatableDataRecord(this, this._cacheTypeMetadata, this._wrappedEntity.Entity);
			}
		}

		// Token: 0x0600304B RID: 12363 RVA: 0x00097A6D File Offset: 0x00095C6D
		public override void Delete()
		{
			this.Delete(true);
		}

		// Token: 0x0600304C RID: 12364 RVA: 0x00097A78 File Offset: 0x00095C78
		public override void AcceptChanges()
		{
			base.ValidateState();
			if (base.ObjectStateManager.EntryHasConceptualNull(this))
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectContext_CommitWithConceptualNull);
			}
			global::System.Data.Entity.EntityState state = base.State;
			if (state <= global::System.Data.Entity.EntityState.Added)
			{
				if (state != global::System.Data.Entity.EntityState.Unchanged)
				{
					if (state != global::System.Data.Entity.EntityState.Added)
					{
						return;
					}
					bool flag = this.RetrieveAndCheckReferentialConstraintValuesInAcceptChanges();
					this._cache.FixupKey(this);
					this._modifiedFields = null;
					this._originalValues = null;
					this._originalComplexObjects = null;
					base.State = global::System.Data.Entity.EntityState.Unchanged;
					if (flag)
					{
						this.RelationshipManager.CheckReferentialConstraintProperties(this);
					}
					this._wrappedEntity.TakeSnapshot(this);
					return;
				}
			}
			else if (state != global::System.Data.Entity.EntityState.Deleted)
			{
				if (state != global::System.Data.Entity.EntityState.Modified)
				{
					return;
				}
				this._cache.ChangeState(this, global::System.Data.Entity.EntityState.Modified, global::System.Data.Entity.EntityState.Unchanged);
				this._modifiedFields = null;
				this._originalValues = null;
				this._originalComplexObjects = null;
				base.State = global::System.Data.Entity.EntityState.Unchanged;
				this._cache.FixupReferencesByForeignKeys(this, false);
				this.RelationshipManager.CheckReferentialConstraintProperties(this);
				this._wrappedEntity.TakeSnapshot(this);
			}
			else
			{
				this.CascadeAcceptChanges();
				if (this._cache != null)
				{
					this._cache.ChangeState(this, global::System.Data.Entity.EntityState.Deleted, global::System.Data.Entity.EntityState.Detached);
					return;
				}
			}
		}

		// Token: 0x0600304D RID: 12365 RVA: 0x00097B80 File Offset: 0x00095D80
		public override void SetModified()
		{
			base.ValidateState();
			if (this.IsKeyEntry)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_CannotModifyKeyEntryState);
			}
			if (global::System.Data.Entity.EntityState.Unchanged == base.State)
			{
				base.State = global::System.Data.Entity.EntityState.Modified;
				this._cache.ChangeState(this, global::System.Data.Entity.EntityState.Unchanged, base.State);
				return;
			}
			if (global::System.Data.Entity.EntityState.Modified != base.State)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_SetModifiedStates("SetModified"));
			}
		}

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x0600304E RID: 12366 RVA: 0x00097BE5 File Offset: 0x00095DE5
		public override global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager RelationshipManager
		{
			get
			{
				base.ValidateState();
				if (this.IsKeyEntry)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_RelationshipAndKeyEntriesDoNotHaveRelationshipManagers);
				}
				if (this.WrappedEntity.Entity == null)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateManager_CannotGetRelationshipManagerForDetachedPocoEntity);
				}
				return this.WrappedEntity.RelationshipManager;
			}
		}

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x0600304F RID: 12367 RVA: 0x00097C23 File Offset: 0x00095E23
		internal override global::System.Collections.BitArray ModifiedProperties
		{
			get
			{
				return this._modifiedFields;
			}
		}

		// Token: 0x06003050 RID: 12368 RVA: 0x00097C2C File Offset: 0x00095E2C
		public override void ChangeState(global::System.Data.Entity.EntityState state)
		{
			global::System.Data.Entity.Core.EntityUtil.CheckValidStateForChangeEntityState(state);
			if (base.State == global::System.Data.Entity.EntityState.Detached && state == global::System.Data.Entity.EntityState.Detached)
			{
				return;
			}
			base.ValidateState();
			global::System.Data.Entity.Core.Objects.ObjectStateManager objectStateManager = base.ObjectStateManager;
			objectStateManager.TransactionManager.BeginLocalPublicAPI();
			try
			{
				this.ChangeObjectState(state);
			}
			finally
			{
				objectStateManager.TransactionManager.EndLocalPublicAPI();
			}
		}

		// Token: 0x06003051 RID: 12369 RVA: 0x00097C8C File Offset: 0x00095E8C
		public override void ApplyCurrentValues(object currentEntity)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<object>(currentEntity, "currentEntity");
			base.ValidateState();
			if (this.IsKeyEntry)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_CannotAccessKeyEntryValues);
			}
			global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedCurrentEntity = base.ObjectStateManager.EntityWrapperFactory.WrapEntityUsingStateManager(currentEntity, base.ObjectStateManager);
			this.ApplyCurrentValuesInternal(wrappedCurrentEntity);
		}

		// Token: 0x06003052 RID: 12370 RVA: 0x00097CE0 File Offset: 0x00095EE0
		public override void ApplyOriginalValues(object originalEntity)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<object>(originalEntity, "originalEntity");
			base.ValidateState();
			if (this.IsKeyEntry)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_CannotAccessKeyEntryValues);
			}
			global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedOriginalEntity = base.ObjectStateManager.EntityWrapperFactory.WrapEntityUsingStateManager(originalEntity, base.ObjectStateManager);
			this.ApplyOriginalValuesInternal(wrappedOriginalEntity);
		}

		// Token: 0x06003053 RID: 12371 RVA: 0x00097D31 File Offset: 0x00095F31
		internal void AddRelationshipEnd(global::System.Data.Entity.Core.Objects.RelationshipEntry item)
		{
			item.SetNextRelationshipEnd(this.EntityKey, this._headRelationshipEnds);
			this._headRelationshipEnds = item;
			this._countRelationshipEnds++;
		}

		// Token: 0x06003054 RID: 12372 RVA: 0x00097D5C File Offset: 0x00095F5C
		internal bool ContainsRelationshipEnd(global::System.Data.Entity.Core.Objects.RelationshipEntry item)
		{
			for (global::System.Data.Entity.Core.Objects.RelationshipEntry relationshipEntry = this._headRelationshipEnds; relationshipEntry != null; relationshipEntry = relationshipEntry.GetNextRelationshipEnd(this.EntityKey))
			{
				if (relationshipEntry == item)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06003055 RID: 12373 RVA: 0x00097D8C File Offset: 0x00095F8C
		internal void RemoveRelationshipEnd(global::System.Data.Entity.Core.Objects.RelationshipEntry item)
		{
			global::System.Data.Entity.Core.Objects.RelationshipEntry relationshipEntry = this._headRelationshipEnds;
			global::System.Data.Entity.Core.Objects.RelationshipEntry relationshipEntry2 = null;
			bool flag = false;
			while (relationshipEntry != null)
			{
				bool flag2 = this.EntityKey == relationshipEntry.Key0 || (this.EntityKey != relationshipEntry.Key1 && this.EntityKey.Equals(relationshipEntry.Key0));
				if (item == relationshipEntry)
				{
					global::System.Data.Entity.Core.Objects.RelationshipEntry relationshipEntry3;
					if (flag2)
					{
						relationshipEntry3 = relationshipEntry.NextKey0;
						relationshipEntry.NextKey0 = null;
					}
					else
					{
						relationshipEntry3 = relationshipEntry.NextKey1;
						relationshipEntry.NextKey1 = null;
					}
					if (relationshipEntry2 == null)
					{
						this._headRelationshipEnds = relationshipEntry3;
					}
					else if (flag)
					{
						relationshipEntry2.NextKey0 = relationshipEntry3;
					}
					else
					{
						relationshipEntry2.NextKey1 = relationshipEntry3;
					}
					this._countRelationshipEnds--;
					return;
				}
				relationshipEntry2 = relationshipEntry;
				relationshipEntry = (flag2 ? relationshipEntry.NextKey0 : relationshipEntry.NextKey1);
				flag = flag2;
			}
		}

		// Token: 0x06003056 RID: 12374 RVA: 0x00097E54 File Offset: 0x00096054
		internal void UpdateRelationshipEnds(global::System.Data.Entity.Core.EntityKey oldKey, global::System.Data.Entity.Core.Objects.EntityEntry promotedEntry)
		{
			int num = 0;
			global::System.Data.Entity.Core.Objects.RelationshipEntry relationshipEntry = this._headRelationshipEnds;
			while (relationshipEntry != null)
			{
				global::System.Data.Entity.Core.Objects.RelationshipEntry relationshipEntry2 = relationshipEntry;
				relationshipEntry = relationshipEntry.GetNextRelationshipEnd(oldKey);
				relationshipEntry2.ChangeRelatedEnd(oldKey, this.EntityKey);
				if (promotedEntry != null && !promotedEntry.ContainsRelationshipEnd(relationshipEntry2))
				{
					promotedEntry.AddRelationshipEnd(relationshipEntry2);
				}
				num++;
			}
			if (promotedEntry != null)
			{
				this._headRelationshipEnds = null;
				this._countRelationshipEnds = 0;
			}
		}

		// Token: 0x06003057 RID: 12375 RVA: 0x00097EAE File Offset: 0x000960AE
		internal global::System.Data.Entity.Core.Objects.EntityEntry.RelationshipEndEnumerable GetRelationshipEnds()
		{
			return new global::System.Data.Entity.Core.Objects.EntityEntry.RelationshipEndEnumerable(this);
		}

		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x06003058 RID: 12376 RVA: 0x00097EB6 File Offset: 0x000960B6
		internal override bool IsKeyEntry
		{
			get
			{
				return this._wrappedEntity.Entity == null;
			}
		}

		// Token: 0x06003059 RID: 12377 RVA: 0x00097EC6 File Offset: 0x000960C6
		internal override global::System.Data.Entity.Core.Common.DataRecordInfo GetDataRecordInfo(global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata metadata, object userObject)
		{
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEntityType(metadata.CdmMetadata.EdmType) && this._entityKey != null)
			{
				return new global::System.Data.Entity.Core.Common.EntityRecordInfo(metadata.DataRecordInfo, this._entityKey, (global::System.Data.Entity.Core.Metadata.Edm.EntitySet)base.EntitySet);
			}
			return metadata.DataRecordInfo;
		}

		// Token: 0x0600305A RID: 12378 RVA: 0x00097F08 File Offset: 0x00096108
		internal override void Reset()
		{
			this.RemoveFromForeignKeyIndex();
			this._cache.ForgetEntryWithConceptualNull(this, true);
			this.DetachObjectStateManagerFromEntity();
			this._wrappedEntity = global::System.Data.Entity.Core.Objects.Internal.NullEntityWrapper.NullWrapper;
			this._entityKey = null;
			this._modifiedFields = null;
			this._originalValues = null;
			this._originalComplexObjects = null;
			this.SetChangeTrackingFlags();
			base.Reset();
		}

		// Token: 0x0600305B RID: 12379 RVA: 0x00097F61 File Offset: 0x00096161
		internal override global::System.Type GetFieldType(int ordinal, global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata metadata)
		{
			return metadata.GetFieldType(ordinal);
		}

		// Token: 0x0600305C RID: 12380 RVA: 0x00097F6A File Offset: 0x0009616A
		internal override string GetCLayerName(int ordinal, global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata metadata)
		{
			return metadata.CLayerMemberName(ordinal);
		}

		// Token: 0x0600305D RID: 12381 RVA: 0x00097F73 File Offset: 0x00096173
		internal override int GetOrdinalforCLayerName(string name, global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata metadata)
		{
			return metadata.GetOrdinalforCLayerMemberName(name);
		}

		// Token: 0x0600305E RID: 12382 RVA: 0x00097F7C File Offset: 0x0009617C
		internal override void RevertDelete()
		{
			base.State = ((this._modifiedFields == null) ? global::System.Data.Entity.EntityState.Unchanged : global::System.Data.Entity.EntityState.Modified);
			this._cache.ChangeState(this, global::System.Data.Entity.EntityState.Deleted, base.State);
		}

		// Token: 0x0600305F RID: 12383 RVA: 0x00097FA4 File Offset: 0x000961A4
		internal override int GetFieldCount(global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata metadata)
		{
			return metadata.FieldCount;
		}

		// Token: 0x06003060 RID: 12384 RVA: 0x00097FAC File Offset: 0x000961AC
		private void CascadeAcceptChanges()
		{
			global::System.Data.Entity.Core.Objects.RelationshipEntry[] array = this._cache.CopyOfRelationshipsByKey(this.EntityKey);
			for (int i = 0; i < array.Length; i++)
			{
				array[i].AcceptChanges();
			}
		}

		// Token: 0x06003061 RID: 12385 RVA: 0x00097FE1 File Offset: 0x000961E1
		internal override void SetModifiedAll()
		{
			base.ValidateState();
			if (this._modifiedFields == null)
			{
				this._modifiedFields = new global::System.Collections.BitArray(this.GetFieldCount(this._cacheTypeMetadata));
			}
			this._modifiedFields.SetAll(true);
		}

		// Token: 0x06003062 RID: 12386 RVA: 0x00098014 File Offset: 0x00096214
		internal override void EntityMemberChanging(string entityMemberName)
		{
			if (this.IsKeyEntry)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_CannotAccessKeyEntryValues);
			}
			this.EntityMemberChanging(entityMemberName, null, null);
		}

		// Token: 0x06003063 RID: 12387 RVA: 0x00098032 File Offset: 0x00096232
		internal override void EntityMemberChanged(string entityMemberName)
		{
			if (this.IsKeyEntry)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_CannotAccessKeyEntryValues);
			}
			this.EntityMemberChanged(entityMemberName, null, null);
		}

		// Token: 0x06003064 RID: 12388 RVA: 0x00098050 File Offset: 0x00096250
		internal override void EntityComplexMemberChanging(string entityMemberName, object complexObject, string complexObjectMemberName)
		{
			if (this.IsKeyEntry)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_CannotAccessKeyEntryValues);
			}
			this.EntityMemberChanging(entityMemberName, complexObject, complexObjectMemberName);
		}

		// Token: 0x06003065 RID: 12389 RVA: 0x0009806E File Offset: 0x0009626E
		internal override void EntityComplexMemberChanged(string entityMemberName, object complexObject, string complexObjectMemberName)
		{
			if (this.IsKeyEntry)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_CannotAccessKeyEntryValues);
			}
			this.EntityMemberChanged(entityMemberName, complexObject, complexObjectMemberName);
		}

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x06003066 RID: 12390 RVA: 0x0009808C File Offset: 0x0009628C
		internal global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper WrappedEntity
		{
			get
			{
				return this._wrappedEntity;
			}
		}

		// Token: 0x06003067 RID: 12391 RVA: 0x00098094 File Offset: 0x00096294
		private void EntityMemberChanged(string entityMemberName, object complexObject, string complexObjectMemberName)
		{
			try
			{
				global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata stateManagerTypeMetadata;
				string a;
				object obj;
				int andValidateChangeMemberInfo = this.GetAndValidateChangeMemberInfo(entityMemberName, complexObject, complexObjectMemberName, out stateManagerTypeMetadata, out a, out obj);
				if (andValidateChangeMemberInfo != -2)
				{
					if (obj != this._cache.ChangingObject || a != this._cache.ChangingMember || entityMemberName != this._cache.ChangingEntityMember)
					{
						throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_EntityMemberChangedWithoutEntityMemberChanging);
					}
					if (base.State != this._cache.ChangingState)
					{
						throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_ChangedInDifferentStateFromChanging(this._cache.ChangingState, base.State));
					}
					object changingOldValue = this._cache.ChangingOldValue;
					object obj2 = null;
					global::System.Data.Entity.Core.Objects.StateManagerMemberMetadata stateManagerMemberMetadata = null;
					if (this._cache.SaveOriginalValues)
					{
						stateManagerMemberMetadata = stateManagerTypeMetadata.Member(andValidateChangeMemberInfo);
						if (stateManagerMemberMetadata.IsComplex && changingOldValue != null)
						{
							obj2 = stateManagerMemberMetadata.GetValue(obj);
							this.ExpandComplexTypeAndAddValues(stateManagerMemberMetadata, changingOldValue, obj2, false);
						}
						else
						{
							this.AddOriginalValueAt(-1, stateManagerMemberMetadata, obj, changingOldValue);
						}
					}
					global::System.Data.Entity.Core.Objects.Internal.TransactionManager transactionManager = base.ObjectStateManager.TransactionManager;
					global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Utils.Pair<string, string>> list;
					if (complexObject == null && (transactionManager.IsAlignChanges || !transactionManager.IsDetectChanges) && this.IsPropertyAForeignKey(entityMemberName, out list))
					{
						foreach (global::System.Data.Entity.Core.Common.Utils.Pair<string, string> pair in list)
						{
							string first = pair.First;
							string second = pair.Second;
							global::System.Data.Entity.Core.Objects.DataClasses.EntityReference entityReference = this.WrappedEntity.RelationshipManager.GetRelatedEndInternal(first, second) as global::System.Data.Entity.Core.Objects.DataClasses.EntityReference;
							if (!transactionManager.IsFixupByReference)
							{
								if (stateManagerMemberMetadata == null)
								{
									stateManagerMemberMetadata = stateManagerTypeMetadata.Member(andValidateChangeMemberInfo);
								}
								if (obj2 == null)
								{
									obj2 = stateManagerMemberMetadata.GetValue(obj);
								}
								bool flag = global::System.Data.Entity.Core.Objects.Internal.ForeignKeyFactory.IsConceptualNullKey(entityReference.CachedForeignKey);
								if (!global::System.Data.Entity.Core.Common.Utils.ByValueEqualityComparer.Default.Equals(changingOldValue, obj2) || flag)
								{
									this.FixupEntityReferenceByForeignKey(entityReference);
								}
							}
						}
					}
					if (this._cache != null && !this._cache.TransactionManager.IsOriginalValuesGetter)
					{
						global::System.Data.Entity.EntityState state = base.State;
						if (base.State != global::System.Data.Entity.EntityState.Added)
						{
							base.State = global::System.Data.Entity.EntityState.Modified;
						}
						if (base.State == global::System.Data.Entity.EntityState.Modified)
						{
							this.SetModifiedProperty(entityMemberName);
						}
						if (state != base.State)
						{
							this._cache.ChangeState(this, state, base.State);
						}
					}
				}
			}
			finally
			{
				this.SetCachedChangingValues(null, null, null, global::System.Data.Entity.EntityState.Detached, null);
			}
		}

		// Token: 0x06003068 RID: 12392 RVA: 0x00098314 File Offset: 0x00096514
		internal void SetCurrentEntityValue(string memberName, object newValue)
		{
			int ordinalforOLayerMemberName = this._cacheTypeMetadata.GetOrdinalforOLayerMemberName(memberName);
			this.SetCurrentEntityValue(this._cacheTypeMetadata, ordinalforOLayerMemberName, this._wrappedEntity.Entity, newValue);
		}

		// Token: 0x06003069 RID: 12393 RVA: 0x00098348 File Offset: 0x00096548
		internal void SetOriginalEntityValue(global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata metadata, int ordinal, object userObject, object newValue)
		{
			base.ValidateState();
			if (base.State == global::System.Data.Entity.EntityState.Added)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_OriginalValuesDoesNotExist);
			}
			int state = (int)base.State;
			global::System.Data.Entity.Core.Objects.StateManagerMemberMetadata stateManagerMemberMetadata = metadata.Member(ordinal);
			int num = this.FindOriginalValueIndex(stateManagerMemberMetadata, userObject);
			if (stateManagerMemberMetadata.IsComplex)
			{
				if (num >= 0)
				{
					this._originalValues.RemoveAt(num);
				}
				object value = stateManagerMemberMetadata.GetValue(userObject);
				if (value == null)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ComplexObject_NullableComplexTypesNotSupported(stateManagerMemberMetadata.CLayerName));
				}
				global::System.Data.Entity.Core.IExtendedDataRecord extendedDataRecord = newValue as global::System.Data.Entity.Core.IExtendedDataRecord;
				if (extendedDataRecord != null)
				{
					newValue = this._cache.ComplexTypeMaterializer.CreateComplex(extendedDataRecord, extendedDataRecord.DataRecordInfo, null);
				}
				this.ExpandComplexTypeAndAddValues(stateManagerMemberMetadata, value, newValue, true);
			}
			else
			{
				this.AddOriginalValueAt(num, stateManagerMemberMetadata, userObject, newValue);
			}
			if (state == 2)
			{
				base.State = global::System.Data.Entity.EntityState.Modified;
			}
		}

		// Token: 0x0600306A RID: 12394 RVA: 0x00098404 File Offset: 0x00096604
		private void EntityMemberChanging(string entityMemberName, object complexObject, string complexObjectMemberName)
		{
			global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata stateManagerTypeMetadata;
			string changingMember;
			object obj;
			int andValidateChangeMemberInfo = this.GetAndValidateChangeMemberInfo(entityMemberName, complexObject, complexObjectMemberName, out stateManagerTypeMetadata, out changingMember, out obj);
			if (andValidateChangeMemberInfo == -2)
			{
				return;
			}
			global::System.Data.Entity.Core.Objects.StateManagerMemberMetadata stateManagerMemberMetadata = stateManagerTypeMetadata.Member(andValidateChangeMemberInfo);
			this._cache.SaveOriginalValues = ((base.State == global::System.Data.Entity.EntityState.Unchanged || base.State == global::System.Data.Entity.EntityState.Modified) && this.FindOriginalValueIndex(stateManagerMemberMetadata, obj) == -1);
			object value = stateManagerMemberMetadata.GetValue(obj);
			this.SetCachedChangingValues(entityMemberName, obj, changingMember, base.State, value);
		}

		// Token: 0x0600306B RID: 12395 RVA: 0x00098478 File Offset: 0x00096678
		internal object GetOriginalEntityValue(string memberName)
		{
			int ordinalforOLayerMemberName = this._cacheTypeMetadata.GetOrdinalforOLayerMemberName(memberName);
			return this.GetOriginalEntityValue(this._cacheTypeMetadata, ordinalforOLayerMemberName, this._wrappedEntity.Entity, global::System.Data.Entity.Core.Objects.ObjectStateValueRecord.OriginalReadonly);
		}

		// Token: 0x0600306C RID: 12396 RVA: 0x000984AB File Offset: 0x000966AB
		internal object GetOriginalEntityValue(global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata metadata, int ordinal, object userObject, global::System.Data.Entity.Core.Objects.ObjectStateValueRecord updatableRecord)
		{
			return this.GetOriginalEntityValue(metadata, ordinal, userObject, updatableRecord, -1);
		}

		// Token: 0x0600306D RID: 12397 RVA: 0x000984B9 File Offset: 0x000966B9
		internal object GetOriginalEntityValue(global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata metadata, int ordinal, object userObject, global::System.Data.Entity.Core.Objects.ObjectStateValueRecord updatableRecord, int parentEntityPropertyIndex)
		{
			base.ValidateState();
			return this.GetOriginalEntityValue(metadata, metadata.Member(ordinal), ordinal, userObject, updatableRecord, parentEntityPropertyIndex);
		}

		// Token: 0x0600306E RID: 12398 RVA: 0x000984D8 File Offset: 0x000966D8
		internal object GetOriginalEntityValue(global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata metadata, global::System.Data.Entity.Core.Objects.StateManagerMemberMetadata memberMetadata, int ordinal, object userObject, global::System.Data.Entity.Core.Objects.ObjectStateValueRecord updatableRecord, int parentEntityPropertyIndex)
		{
			int num = this.FindOriginalValueIndex(memberMetadata, userObject);
			if (num >= 0)
			{
				return this._originalValues[num].OriginalValue ?? global::System.DBNull.Value;
			}
			return this.GetCurrentEntityValue(metadata, ordinal, userObject, updatableRecord, parentEntityPropertyIndex);
		}

		// Token: 0x0600306F RID: 12399 RVA: 0x0009851C File Offset: 0x0009671C
		internal object GetCurrentEntityValue(global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata metadata, int ordinal, object userObject, global::System.Data.Entity.Core.Objects.ObjectStateValueRecord updatableRecord)
		{
			return this.GetCurrentEntityValue(metadata, ordinal, userObject, updatableRecord, -1);
		}

		// Token: 0x06003070 RID: 12400 RVA: 0x0009852C File Offset: 0x0009672C
		internal object GetCurrentEntityValue(global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata metadata, int ordinal, object userObject, global::System.Data.Entity.Core.Objects.ObjectStateValueRecord updatableRecord, int parentEntityPropertyIndex)
		{
			base.ValidateState();
			global::System.Data.Entity.Core.Objects.StateManagerMemberMetadata stateManagerMemberMetadata = metadata.Member(ordinal);
			object obj = stateManagerMemberMetadata.GetValue(userObject);
			if (stateManagerMemberMetadata.IsComplex && obj != null)
			{
				switch (updatableRecord)
				{
				case global::System.Data.Entity.Core.Objects.ObjectStateValueRecord.OriginalReadonly:
					obj = new global::System.Data.Entity.Core.Objects.ObjectStateEntryDbDataRecord(this, this._cache.GetOrAddStateManagerTypeMetadata(stateManagerMemberMetadata.CdmMetadata.TypeUsage.EdmType), obj);
					break;
				case global::System.Data.Entity.Core.Objects.ObjectStateValueRecord.CurrentUpdatable:
					obj = new global::System.Data.Entity.Core.Objects.ObjectStateEntryDbUpdatableDataRecord(this, this._cache.GetOrAddStateManagerTypeMetadata(stateManagerMemberMetadata.CdmMetadata.TypeUsage.EdmType), obj);
					break;
				case global::System.Data.Entity.Core.Objects.ObjectStateValueRecord.OriginalUpdatableInternal:
					obj = new global::System.Data.Entity.Core.Objects.ObjectStateEntryOriginalDbUpdatableDataRecord_Internal(this, this._cache.GetOrAddStateManagerTypeMetadata(stateManagerMemberMetadata.CdmMetadata.TypeUsage.EdmType), obj);
					break;
				case global::System.Data.Entity.Core.Objects.ObjectStateValueRecord.OriginalUpdatablePublic:
					obj = new global::System.Data.Entity.Core.Objects.ObjectStateEntryOriginalDbUpdatableDataRecord_Public(this, this._cache.GetOrAddStateManagerTypeMetadata(stateManagerMemberMetadata.CdmMetadata.TypeUsage.EdmType), obj, parentEntityPropertyIndex);
					break;
				}
			}
			return obj ?? global::System.DBNull.Value;
		}

		// Token: 0x06003071 RID: 12401 RVA: 0x0009861C File Offset: 0x0009681C
		internal int FindOriginalValueIndex(global::System.Data.Entity.Core.Objects.StateManagerMemberMetadata metadata, object instance)
		{
			if (this._originalValues != null)
			{
				for (int i = 0; i < this._originalValues.Count; i++)
				{
					if (this._originalValues[i].UserObject == instance && this._originalValues[i].MemberMetadata == metadata)
					{
						return i;
					}
				}
			}
			return -1;
		}

		// Token: 0x06003072 RID: 12402 RVA: 0x00098672 File Offset: 0x00096872
		internal global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember GetAssociationEndMember(global::System.Data.Entity.Core.Objects.RelationshipEntry relationshipEntry)
		{
			base.ValidateState();
			return relationshipEntry.RelationshipWrapper.GetAssociationEndMember(this.EntityKey);
		}

		// Token: 0x06003073 RID: 12403 RVA: 0x0009868B File Offset: 0x0009688B
		internal global::System.Data.Entity.Core.Objects.EntityEntry GetOtherEndOfRelationship(global::System.Data.Entity.Core.Objects.RelationshipEntry relationshipEntry)
		{
			return this._cache.GetEntityEntry(relationshipEntry.RelationshipWrapper.GetOtherEntityKey(this.EntityKey));
		}

		// Token: 0x06003074 RID: 12404 RVA: 0x000986AC File Offset: 0x000968AC
		internal void ExpandComplexTypeAndAddValues(global::System.Data.Entity.Core.Objects.StateManagerMemberMetadata memberMetadata, object oldComplexObject, object newComplexObject, bool useOldComplexObject)
		{
			if (newComplexObject == null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ComplexObject_NullableComplexTypesNotSupported(memberMetadata.CLayerName));
			}
			global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata orAddStateManagerTypeMetadata = this._cache.GetOrAddStateManagerTypeMetadata(memberMetadata.CdmMetadata.TypeUsage.EdmType);
			for (int i = 0; i < orAddStateManagerTypeMetadata.FieldCount; i++)
			{
				global::System.Data.Entity.Core.Objects.StateManagerMemberMetadata stateManagerMemberMetadata = orAddStateManagerTypeMetadata.Member(i);
				if (stateManagerMemberMetadata.IsComplex)
				{
					object obj = null;
					if (oldComplexObject != null)
					{
						obj = stateManagerMemberMetadata.GetValue(oldComplexObject);
						if (obj == null)
						{
							int num = this.FindOriginalValueIndex(stateManagerMemberMetadata, oldComplexObject);
							if (num >= 0)
							{
								this._originalValues.RemoveAt(num);
							}
						}
					}
					this.ExpandComplexTypeAndAddValues(stateManagerMemberMetadata, obj, stateManagerMemberMetadata.GetValue(newComplexObject), useOldComplexObject);
				}
				else
				{
					object userObject = newComplexObject;
					int num2 = -1;
					object value;
					if (useOldComplexObject)
					{
						value = stateManagerMemberMetadata.GetValue(newComplexObject);
						userObject = oldComplexObject;
					}
					else if (oldComplexObject != null)
					{
						value = stateManagerMemberMetadata.GetValue(oldComplexObject);
						num2 = this.FindOriginalValueIndex(stateManagerMemberMetadata, oldComplexObject);
						if (num2 >= 0)
						{
							value = this._originalValues[num2].OriginalValue;
						}
					}
					else
					{
						value = stateManagerMemberMetadata.GetValue(newComplexObject);
					}
					this.AddOriginalValueAt(num2, stateManagerMemberMetadata, userObject, value);
				}
			}
		}

		// Token: 0x06003075 RID: 12405 RVA: 0x000987B0 File Offset: 0x000969B0
		internal int GetAndValidateChangeMemberInfo(string entityMemberName, object complexObject, string complexObjectMemberName, out global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata typeMetadata, out string changingMemberName, out object changingObject)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(entityMemberName, "entityMemberName");
			typeMetadata = null;
			changingMemberName = null;
			changingObject = null;
			base.ValidateState();
			int ordinalforOLayerMemberName = this._cacheTypeMetadata.GetOrdinalforOLayerMemberName(entityMemberName);
			if (ordinalforOLayerMemberName != -1)
			{
				global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata stateManagerTypeMetadata;
				string text;
				object obj;
				if (complexObject != null)
				{
					if (!this._cacheTypeMetadata.Member(ordinalforOLayerMemberName).IsComplex)
					{
						throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ComplexObject_ComplexChangeRequestedOnScalarProperty(entityMemberName));
					}
					stateManagerTypeMetadata = this._cache.GetOrAddStateManagerTypeMetadata(complexObject.GetType(), (global::System.Data.Entity.Core.Metadata.Edm.EntitySet)base.EntitySet);
					ordinalforOLayerMemberName = stateManagerTypeMetadata.GetOrdinalforOLayerMemberName(complexObjectMemberName);
					if (ordinalforOLayerMemberName == -1)
					{
						throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_ChangeOnUnmappedComplexProperty(complexObjectMemberName));
					}
					text = complexObjectMemberName;
					obj = complexObject;
				}
				else
				{
					stateManagerTypeMetadata = this._cacheTypeMetadata;
					text = entityMemberName;
					obj = this.Entity;
					if (this.WrappedEntity.IdentityType != this.Entity.GetType() && this.Entity is global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithChangeTracker && this.IsPropertyAForeignKey(entityMemberName))
					{
						this._cache.EntityInvokingFKSetter = this.WrappedEntity.Entity;
					}
				}
				this.VerifyEntityValueIsEditable(stateManagerTypeMetadata, ordinalforOLayerMemberName, text);
				typeMetadata = stateManagerTypeMetadata;
				changingMemberName = text;
				changingObject = obj;
				return ordinalforOLayerMemberName;
			}
			if (!(entityMemberName == "-EntityKey-"))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_ChangeOnUnmappedProperty(entityMemberName));
			}
			if (!this._cache.InRelationshipFixup)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_CantSetEntityKey);
			}
			this.SetCachedChangingValues(null, null, null, base.State, null);
			return -2;
		}

		// Token: 0x06003076 RID: 12406 RVA: 0x000988FC File Offset: 0x00096AFC
		private void SetCachedChangingValues(string entityMemberName, object changingObject, string changingMember, global::System.Data.Entity.EntityState changingState, object oldValue)
		{
			this._cache.ChangingEntityMember = entityMemberName;
			this._cache.ChangingObject = changingObject;
			this._cache.ChangingMember = changingMember;
			this._cache.ChangingState = changingState;
			this._cache.ChangingOldValue = oldValue;
			if (changingState == global::System.Data.Entity.EntityState.Detached)
			{
				this._cache.SaveOriginalValues = false;
			}
		}

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x06003077 RID: 12407 RVA: 0x00098958 File Offset: 0x00096B58
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		internal global::System.Data.Entity.Core.Objects.OriginalValueRecord EditableOriginalValues
		{
			get
			{
				return new global::System.Data.Entity.Core.Objects.ObjectStateEntryOriginalDbUpdatableDataRecord_Internal(this, this._cacheTypeMetadata, this._wrappedEntity.Entity);
			}
		}

		// Token: 0x06003078 RID: 12408 RVA: 0x00098974 File Offset: 0x00096B74
		internal void DetachObjectStateManagerFromEntity()
		{
			if (!this.IsKeyEntry)
			{
				this._wrappedEntity.SetChangeTracker(null);
				this._wrappedEntity.DetachContext();
				if (this._cache.TransactionManager.IsAttachTracking)
				{
					global::System.Data.Entity.Core.Objects.MergeOption? originalMergeOption = this._cache.TransactionManager.OriginalMergeOption;
					global::System.Data.Entity.Core.Objects.MergeOption mergeOption = global::System.Data.Entity.Core.Objects.MergeOption.NoTracking;
					if (originalMergeOption.GetValueOrDefault() == mergeOption & originalMergeOption != null)
					{
						return;
					}
				}
				this._wrappedEntity.EntityKey = null;
			}
		}

		// Token: 0x06003079 RID: 12409 RVA: 0x000989E8 File Offset: 0x00096BE8
		internal void TakeSnapshot(bool onlySnapshotComplexProperties)
		{
			if (base.State != global::System.Data.Entity.EntityState.Added)
			{
				global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata cacheTypeMetadata = this._cacheTypeMetadata;
				int fieldCount = this.GetFieldCount(cacheTypeMetadata);
				for (int i = 0; i < fieldCount; i++)
				{
					global::System.Data.Entity.Core.Objects.StateManagerMemberMetadata stateManagerMemberMetadata = cacheTypeMetadata.Member(i);
					if (stateManagerMemberMetadata.IsComplex)
					{
						object value = stateManagerMemberMetadata.GetValue(this._wrappedEntity.Entity);
						this.AddComplexObjectSnapshot(this.Entity, i, value);
						this.TakeSnapshotOfComplexType(stateManagerMemberMetadata, value);
					}
					else if (!onlySnapshotComplexProperties)
					{
						object value = stateManagerMemberMetadata.GetValue(this._wrappedEntity.Entity);
						this.AddOriginalValueAt(-1, stateManagerMemberMetadata, this._wrappedEntity.Entity, value);
					}
				}
			}
			this.TakeSnapshotOfForeignKeys();
		}

		// Token: 0x0600307A RID: 12410 RVA: 0x00098A8C File Offset: 0x00096C8C
		internal void TakeSnapshotOfForeignKeys()
		{
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.EntityKey>> dictionary;
			this.FindRelatedEntityKeysByForeignKeys(out dictionary, false);
			if (dictionary != null)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.EntityKey>> keyValuePair in dictionary)
				{
					global::System.Data.Entity.Core.Objects.DataClasses.EntityReference entityReference = keyValuePair.Key as global::System.Data.Entity.Core.Objects.DataClasses.EntityReference;
					if (!global::System.Data.Entity.Core.Objects.Internal.ForeignKeyFactory.IsConceptualNullKey(entityReference.CachedForeignKey))
					{
						entityReference.SetCachedForeignKey(keyValuePair.Value.First<global::System.Data.Entity.Core.EntityKey>(), this);
					}
				}
			}
		}

		// Token: 0x0600307B RID: 12411 RVA: 0x00098B0C File Offset: 0x00096D0C
		private void TakeSnapshotOfComplexType(global::System.Data.Entity.Core.Objects.StateManagerMemberMetadata member, object complexValue)
		{
			if (complexValue == null)
			{
				return;
			}
			global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata orAddStateManagerTypeMetadata = this._cache.GetOrAddStateManagerTypeMetadata(member.CdmMetadata.TypeUsage.EdmType);
			for (int i = 0; i < orAddStateManagerTypeMetadata.FieldCount; i++)
			{
				global::System.Data.Entity.Core.Objects.StateManagerMemberMetadata stateManagerMemberMetadata = orAddStateManagerTypeMetadata.Member(i);
				object value = stateManagerMemberMetadata.GetValue(complexValue);
				if (stateManagerMemberMetadata.IsComplex)
				{
					this.AddComplexObjectSnapshot(complexValue, i, value);
					this.TakeSnapshotOfComplexType(stateManagerMemberMetadata, value);
				}
				else if (this.FindOriginalValueIndex(stateManagerMemberMetadata, complexValue) == -1)
				{
					this.AddOriginalValueAt(-1, stateManagerMemberMetadata, complexValue, value);
				}
			}
		}

		// Token: 0x0600307C RID: 12412 RVA: 0x00098B8C File Offset: 0x00096D8C
		private void AddComplexObjectSnapshot(object userObject, int ordinal, object complexObject)
		{
			if (complexObject == null)
			{
				return;
			}
			this.CheckForDuplicateComplexObjects(complexObject);
			if (this._originalComplexObjects == null)
			{
				this._originalComplexObjects = new global::System.Collections.Generic.Dictionary<object, global::System.Collections.Generic.Dictionary<int, object>>(global::System.Data.Entity.Infrastructure.ObjectReferenceEqualityComparer.Default);
			}
			global::System.Collections.Generic.Dictionary<int, object> dictionary;
			if (!this._originalComplexObjects.TryGetValue(userObject, out dictionary))
			{
				dictionary = new global::System.Collections.Generic.Dictionary<int, object>();
				this._originalComplexObjects.Add(userObject, dictionary);
			}
			dictionary.Add(ordinal, complexObject);
		}

		// Token: 0x0600307D RID: 12413 RVA: 0x00098BE8 File Offset: 0x00096DE8
		private void CheckForDuplicateComplexObjects(object complexObject)
		{
			if (this._originalComplexObjects == null || complexObject == null)
			{
				return;
			}
			foreach (global::System.Collections.Generic.Dictionary<int, object> dictionary in this._originalComplexObjects.Values)
			{
				foreach (object obj in dictionary.Values)
				{
					if (complexObject == obj)
					{
						throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_ComplexObjectUsedMultipleTimes(this.Entity.GetType().FullName, complexObject.GetType().FullName));
					}
				}
			}
		}

		// Token: 0x0600307E RID: 12414 RVA: 0x00098CA8 File Offset: 0x00096EA8
		public override bool IsPropertyChanged(string propertyName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(propertyName, "propertyName");
			return this.DetectChangesInProperty(this.ValidateAndGetOrdinalForProperty(propertyName, "IsPropertyChanged"), false, true);
		}

		// Token: 0x0600307F RID: 12415 RVA: 0x00098CCC File Offset: 0x00096ECC
		private bool DetectChangesInProperty(int ordinal, bool detectOnlyComplexProperties, bool detectOnly)
		{
			bool flag = false;
			global::System.Data.Entity.Core.Objects.StateManagerMemberMetadata stateManagerMemberMetadata = this._cacheTypeMetadata.Member(ordinal);
			object value = stateManagerMemberMetadata.GetValue(this._wrappedEntity.Entity);
			if (stateManagerMemberMetadata.IsComplex)
			{
				if (base.State != global::System.Data.Entity.EntityState.Deleted)
				{
					object complexObjectSnapshot = this.GetComplexObjectSnapshot(this.Entity, ordinal);
					if (this.DetectChangesInComplexType(stateManagerMemberMetadata, stateManagerMemberMetadata, value, complexObjectSnapshot, ref flag, detectOnly))
					{
						this.CheckForDuplicateComplexObjects(value);
						if (!detectOnly)
						{
							((global::System.Data.Entity.Core.Objects.DataClasses.IEntityChangeTracker)this).EntityMemberChanging(stateManagerMemberMetadata.CLayerName);
							this._cache.ChangingOldValue = complexObjectSnapshot;
							((global::System.Data.Entity.Core.Objects.DataClasses.IEntityChangeTracker)this).EntityMemberChanged(stateManagerMemberMetadata.CLayerName);
						}
						this.UpdateComplexObjectSnapshot(stateManagerMemberMetadata, this.Entity, ordinal, value);
						if (!flag)
						{
							this.DetectChangesInComplexType(stateManagerMemberMetadata, stateManagerMemberMetadata, value, complexObjectSnapshot, ref flag, detectOnly);
						}
					}
				}
			}
			else if (!detectOnlyComplexProperties)
			{
				int num = this.FindOriginalValueIndex(stateManagerMemberMetadata, this._wrappedEntity.Entity);
				if (num < 0)
				{
					return this.GetModifiedProperties().Contains(stateManagerMemberMetadata.CLayerName);
				}
				object originalValue = this._originalValues[num].OriginalValue;
				if (!object.Equals(value, originalValue))
				{
					flag = true;
					if (stateManagerMemberMetadata.IsPartOfKey)
					{
						if (!global::System.Data.Entity.Core.Common.Utils.ByValueEqualityComparer.Default.Equals(value, originalValue))
						{
							throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_CannotModifyKeyProperty(stateManagerMemberMetadata.CLayerName));
						}
					}
					else if (base.State != global::System.Data.Entity.EntityState.Deleted && !detectOnly)
					{
						((global::System.Data.Entity.Core.Objects.DataClasses.IEntityChangeTracker)this).EntityMemberChanging(stateManagerMemberMetadata.CLayerName);
						((global::System.Data.Entity.Core.Objects.DataClasses.IEntityChangeTracker)this).EntityMemberChanged(stateManagerMemberMetadata.CLayerName);
					}
				}
			}
			return flag;
		}

		// Token: 0x06003080 RID: 12416 RVA: 0x00098E28 File Offset: 0x00097028
		internal void DetectChangesInProperties(bool detectOnlyComplexProperties)
		{
			int fieldCount = this.GetFieldCount(this._cacheTypeMetadata);
			for (int i = 0; i < fieldCount; i++)
			{
				this.DetectChangesInProperty(i, detectOnlyComplexProperties, false);
			}
		}

		// Token: 0x06003081 RID: 12417 RVA: 0x00098E58 File Offset: 0x00097058
		private bool DetectChangesInComplexType(global::System.Data.Entity.Core.Objects.StateManagerMemberMetadata topLevelMember, global::System.Data.Entity.Core.Objects.StateManagerMemberMetadata complexMember, object complexValue, object oldComplexValue, ref bool changeDetected, bool detectOnly)
		{
			if (complexValue == null)
			{
				if (oldComplexValue == null)
				{
					return false;
				}
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ComplexObject_NullableComplexTypesNotSupported(complexMember.CLayerName));
			}
			else
			{
				if (oldComplexValue != complexValue)
				{
					return true;
				}
				global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata orAddStateManagerTypeMetadata = this._cache.GetOrAddStateManagerTypeMetadata(complexMember.CdmMetadata.TypeUsage.EdmType);
				for (int i = 0; i < this.GetFieldCount(orAddStateManagerTypeMetadata); i++)
				{
					global::System.Data.Entity.Core.Objects.StateManagerMemberMetadata stateManagerMemberMetadata = orAddStateManagerTypeMetadata.Member(i);
					object value = stateManagerMemberMetadata.GetValue(complexValue);
					if (stateManagerMemberMetadata.IsComplex)
					{
						if (base.State != global::System.Data.Entity.EntityState.Deleted)
						{
							object complexObjectSnapshot = this.GetComplexObjectSnapshot(complexValue, i);
							if (this.DetectChangesInComplexType(topLevelMember, stateManagerMemberMetadata, value, complexObjectSnapshot, ref changeDetected, detectOnly))
							{
								this.CheckForDuplicateComplexObjects(value);
								if (!detectOnly)
								{
									((global::System.Data.Entity.Core.Objects.DataClasses.IEntityChangeTracker)this).EntityComplexMemberChanging(topLevelMember.CLayerName, complexValue, stateManagerMemberMetadata.CLayerName);
									this._cache.ChangingOldValue = complexObjectSnapshot;
									((global::System.Data.Entity.Core.Objects.DataClasses.IEntityChangeTracker)this).EntityComplexMemberChanged(topLevelMember.CLayerName, complexValue, stateManagerMemberMetadata.CLayerName);
								}
								this.UpdateComplexObjectSnapshot(stateManagerMemberMetadata, complexValue, i, value);
								if (!changeDetected)
								{
									this.DetectChangesInComplexType(topLevelMember, stateManagerMemberMetadata, value, complexObjectSnapshot, ref changeDetected, detectOnly);
								}
							}
						}
					}
					else
					{
						int num = this.FindOriginalValueIndex(stateManagerMemberMetadata, complexValue);
						object objB = (num == -1) ? null : this._originalValues[num].OriginalValue;
						if (!object.Equals(value, objB))
						{
							changeDetected = true;
							if (!detectOnly)
							{
								((global::System.Data.Entity.Core.Objects.DataClasses.IEntityChangeTracker)this).EntityComplexMemberChanging(topLevelMember.CLayerName, complexValue, stateManagerMemberMetadata.CLayerName);
								((global::System.Data.Entity.Core.Objects.DataClasses.IEntityChangeTracker)this).EntityComplexMemberChanged(topLevelMember.CLayerName, complexValue, stateManagerMemberMetadata.CLayerName);
							}
						}
					}
				}
				return false;
			}
		}

		// Token: 0x06003082 RID: 12418 RVA: 0x00098FC0 File Offset: 0x000971C0
		private object GetComplexObjectSnapshot(object parentObject, int parentOrdinal)
		{
			object result = null;
			global::System.Collections.Generic.Dictionary<int, object> dictionary;
			if (this._originalComplexObjects != null && this._originalComplexObjects.TryGetValue(parentObject, out dictionary))
			{
				dictionary.TryGetValue(parentOrdinal, out result);
			}
			return result;
		}

		// Token: 0x06003083 RID: 12419 RVA: 0x00098FF4 File Offset: 0x000971F4
		internal void UpdateComplexObjectSnapshot(global::System.Data.Entity.Core.Objects.StateManagerMemberMetadata member, object userObject, int ordinal, object currentValue)
		{
			bool flag = true;
			global::System.Collections.Generic.Dictionary<int, object> dictionary;
			if (this._originalComplexObjects != null && this._originalComplexObjects.TryGetValue(userObject, out dictionary))
			{
				object obj;
				dictionary.TryGetValue(ordinal, out obj);
				dictionary[ordinal] = currentValue;
				if (obj != null && this._originalComplexObjects.TryGetValue(obj, out dictionary))
				{
					this._originalComplexObjects.Remove(obj);
					this._originalComplexObjects.Add(currentValue, dictionary);
					global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata orAddStateManagerTypeMetadata = this._cache.GetOrAddStateManagerTypeMetadata(member.CdmMetadata.TypeUsage.EdmType);
					for (int i = 0; i < orAddStateManagerTypeMetadata.FieldCount; i++)
					{
						global::System.Data.Entity.Core.Objects.StateManagerMemberMetadata stateManagerMemberMetadata = orAddStateManagerTypeMetadata.Member(i);
						if (stateManagerMemberMetadata.IsComplex)
						{
							object value = stateManagerMemberMetadata.GetValue(currentValue);
							this.UpdateComplexObjectSnapshot(stateManagerMemberMetadata, currentValue, i, value);
						}
					}
				}
				flag = false;
			}
			if (flag)
			{
				this.AddComplexObjectSnapshot(userObject, ordinal, currentValue);
			}
		}

		// Token: 0x06003084 RID: 12420 RVA: 0x000990D4 File Offset: 0x000972D4
		internal void FixupFKValuesFromNonAddedReferences()
		{
			if (!((global::System.Data.Entity.Core.Metadata.Edm.EntitySet)base.EntitySet).HasForeignKeyRelationships)
			{
				return;
			}
			global::System.Collections.Generic.Dictionary<int, object> changedFKs = new global::System.Collections.Generic.Dictionary<int, object>();
			foreach (global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint> tuple in this.ForeignKeyDependents)
			{
				global::System.Data.Entity.Core.Objects.DataClasses.EntityReference entityReference = this.RelationshipManager.GetRelatedEndInternal(tuple.Item1.ElementType.FullName, tuple.Item2.FromRole.Name) as global::System.Data.Entity.Core.Objects.DataClasses.EntityReference;
				if (entityReference.TargetAccessor.HasProperty)
				{
					object navigationPropertyValue = this.WrappedEntity.GetNavigationPropertyValue(entityReference);
					global::System.Data.Entity.Core.Objects.ObjectStateEntry objectStateEntry;
					if (navigationPropertyValue != null && this._cache.TryGetObjectStateEntry(navigationPropertyValue, out objectStateEntry) && (objectStateEntry.State == global::System.Data.Entity.EntityState.Modified || objectStateEntry.State == global::System.Data.Entity.EntityState.Unchanged))
					{
						entityReference.UpdateForeignKeyValues(this.WrappedEntity, ((global::System.Data.Entity.Core.Objects.EntityEntry)objectStateEntry).WrappedEntity, changedFKs, false);
					}
				}
			}
		}

		// Token: 0x06003085 RID: 12421 RVA: 0x000991CC File Offset: 0x000973CC
		internal void TakeSnapshotOfRelationships()
		{
			global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager relationshipManager = this._wrappedEntity.RelationshipManager;
			foreach (global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navigationProperty in (this._cacheTypeMetadata.CdmMetadata.EdmType as global::System.Data.Entity.Core.Metadata.Edm.EntityType).NavigationProperties)
			{
				global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEndInternal = relationshipManager.GetRelatedEndInternal(navigationProperty.RelationshipType.FullName, navigationProperty.ToEndMember.Name);
				object navigationPropertyValue = this.WrappedEntity.GetNavigationPropertyValue(relatedEndInternal);
				if (navigationPropertyValue != null)
				{
					if (navigationProperty.ToEndMember.RelationshipMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many)
					{
						global::System.Collections.IEnumerable enumerable = navigationPropertyValue as global::System.Collections.IEnumerable;
						if (enumerable == null)
						{
							throw new global::System.Data.Entity.Core.EntityException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_UnableToEnumerateCollection(navigationProperty.Name, this.Entity.GetType().FullName));
						}
						using (global::System.Collections.IEnumerator enumerator2 = enumerable.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								object obj = enumerator2.Current;
								if (obj != null)
								{
									this.TakeSnapshotOfSingleRelationship(relatedEndInternal, navigationProperty, obj);
								}
							}
							continue;
						}
					}
					this.TakeSnapshotOfSingleRelationship(relatedEndInternal, navigationProperty, navigationPropertyValue);
				}
			}
		}

		// Token: 0x06003086 RID: 12422 RVA: 0x00099300 File Offset: 0x00097500
		private void TakeSnapshotOfSingleRelationship(global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd, global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty n, object o)
		{
			global::System.Data.Entity.Core.Objects.EntityEntry entityEntry = base.ObjectStateManager.FindEntityEntry(o);
			global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper entityWrapper;
			if (entityEntry != null)
			{
				entityWrapper = entityEntry._wrappedEntity;
				global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEndInternal = entityWrapper.RelationshipManager.GetRelatedEndInternal(n.RelationshipType.FullName, n.FromEndMember.Name);
				if (!relatedEndInternal.ContainsEntity(this._wrappedEntity))
				{
					if (entityWrapper.ObjectStateEntry.State == global::System.Data.Entity.EntityState.Deleted)
					{
						throw global::System.Data.Entity.Resources.Error.RelatedEnd_UnableToAddRelationshipWithDeletedEntity();
					}
					if (base.ObjectStateManager.TransactionManager.IsAttachTracking && (base.State & (global::System.Data.Entity.EntityState.Unchanged | global::System.Data.Entity.EntityState.Modified)) != (global::System.Data.Entity.EntityState)0 && (entityWrapper.ObjectStateEntry.State & (global::System.Data.Entity.EntityState.Unchanged | global::System.Data.Entity.EntityState.Modified)) != (global::System.Data.Entity.EntityState)0)
					{
						global::System.Data.Entity.Core.Objects.EntityEntry entityEntry2 = null;
						global::System.Data.Entity.Core.Objects.EntityEntry @object = null;
						if (relatedEnd.IsDependentEndOfReferentialConstraint(false))
						{
							entityEntry2 = entityWrapper.ObjectStateEntry;
							@object = this;
						}
						else if (relatedEndInternal.IsDependentEndOfReferentialConstraint(false))
						{
							entityEntry2 = this;
							@object = entityWrapper.ObjectStateEntry;
						}
						if (entityEntry2 != null)
						{
							global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint referentialConstraint = ((global::System.Data.Entity.Core.Metadata.Edm.AssociationType)relatedEnd.RelationMetadata).ReferentialConstraints[0];
							if (!global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd.VerifyRIConstraintsWithRelatedEntry(referentialConstraint, new global::System.Func<string, object>(@object.GetCurrentEntityValue), entityEntry2.EntityKey))
							{
								throw new global::System.InvalidOperationException(referentialConstraint.BuildConstraintExceptionMessage());
							}
						}
					}
					global::System.Data.Entity.Core.Objects.DataClasses.EntityReference entityReference = relatedEndInternal as global::System.Data.Entity.Core.Objects.DataClasses.EntityReference;
					if (entityReference != null && entityReference.NavigationPropertyIsNullOrMissing())
					{
						base.ObjectStateManager.TransactionManager.AlignedEntityReferences.Add(entityReference);
					}
					relatedEndInternal.AddToLocalCache(this._wrappedEntity, true);
					relatedEndInternal.OnAssociationChanged(global::System.ComponentModel.CollectionChangeAction.Add, this._wrappedEntity.Entity);
				}
			}
			else if (!base.ObjectStateManager.TransactionManager.WrappedEntities.TryGetValue(o, out entityWrapper))
			{
				entityWrapper = base.ObjectStateManager.EntityWrapperFactory.WrapEntityUsingStateManager(o, base.ObjectStateManager);
			}
			if (!relatedEnd.ContainsEntity(entityWrapper))
			{
				relatedEnd.AddToLocalCache(entityWrapper, true);
				relatedEnd.OnAssociationChanged(global::System.ComponentModel.CollectionChangeAction.Add, entityWrapper.Entity);
			}
		}

		// Token: 0x06003087 RID: 12423 RVA: 0x000994B4 File Offset: 0x000976B4
		internal void DetectChangesInRelationshipsOfSingleEntity()
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navigationProperty in (this._cacheTypeMetadata.CdmMetadata.EdmType as global::System.Data.Entity.Core.Metadata.Edm.EntityType).NavigationProperties)
			{
				global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEndInternal = this.WrappedEntity.RelationshipManager.GetRelatedEndInternal(navigationProperty.RelationshipType.FullName, navigationProperty.ToEndMember.Name);
				object navigationPropertyValue = this.WrappedEntity.GetNavigationPropertyValue(relatedEndInternal);
				global::System.Collections.Generic.HashSet<object> hashSet = new global::System.Collections.Generic.HashSet<object>(global::System.Data.Entity.Infrastructure.ObjectReferenceEqualityComparer.Default);
				if (navigationPropertyValue != null)
				{
					if (navigationProperty.ToEndMember.RelationshipMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many)
					{
						global::System.Collections.IEnumerable enumerable = navigationPropertyValue as global::System.Collections.IEnumerable;
						if (enumerable == null)
						{
							throw new global::System.Data.Entity.Core.EntityException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_UnableToEnumerateCollection(navigationProperty.Name, this.Entity.GetType().FullName));
						}
						using (global::System.Collections.IEnumerator enumerator2 = enumerable.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								object obj = enumerator2.Current;
								if (obj != null)
								{
									hashSet.Add(obj);
								}
							}
							goto IL_F4;
						}
					}
					hashSet.Add(navigationPropertyValue);
				}
				IL_F4:
				foreach (object obj2 in relatedEndInternal.GetInternalEnumerable())
				{
					if (!hashSet.Contains(obj2))
					{
						this.AddRelationshipDetectedByGraph(base.ObjectStateManager.TransactionManager.DeletedRelationshipsByGraph, obj2, relatedEndInternal, false);
					}
					else
					{
						hashSet.Remove(obj2);
					}
				}
				foreach (object relatedObject in hashSet)
				{
					this.AddRelationshipDetectedByGraph(base.ObjectStateManager.TransactionManager.AddedRelationshipsByGraph, relatedObject, relatedEndInternal, true);
				}
			}
		}

		// Token: 0x06003088 RID: 12424 RVA: 0x000996E8 File Offset: 0x000978E8
		private void AddRelationshipDetectedByGraph(global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>>> relationships, object relatedObject, global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEndFrom, bool verifyForAdd)
		{
			global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper entityWrapper = base.ObjectStateManager.EntityWrapperFactory.WrapEntityUsingStateManager(relatedObject, base.ObjectStateManager);
			global::System.Data.Entity.Core.Objects.EntityEntry.AddDetectedRelationship<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>(relationships, entityWrapper, relatedEndFrom);
			global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd otherEndOfRelationship = relatedEndFrom.GetOtherEndOfRelationship(entityWrapper);
			if (verifyForAdd && otherEndOfRelationship is global::System.Data.Entity.Core.Objects.DataClasses.EntityReference && base.ObjectStateManager.FindEntityEntry(relatedObject) == null)
			{
				otherEndOfRelationship.VerifyNavigationPropertyForAdd(this._wrappedEntity);
			}
			global::System.Data.Entity.Core.Objects.EntityEntry.AddDetectedRelationship<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>(relationships, this._wrappedEntity, otherEndOfRelationship);
		}

		// Token: 0x06003089 RID: 12425 RVA: 0x00099750 File Offset: 0x00097950
		private void AddRelationshipDetectedByForeignKey(global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.EntityKey>>> relationships, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.EntityKey>>> principalRelationships, global::System.Data.Entity.Core.EntityKey relatedKey, global::System.Data.Entity.Core.Objects.EntityEntry relatedEntry, global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEndFrom)
		{
			global::System.Data.Entity.Core.Objects.EntityEntry.AddDetectedRelationship<global::System.Data.Entity.Core.EntityKey>(relationships, relatedKey, relatedEndFrom);
			if (relatedEntry != null)
			{
				global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity = relatedEntry.WrappedEntity;
				global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd otherEndOfRelationship = relatedEndFrom.GetOtherEndOfRelationship(wrappedEntity);
				global::System.Data.Entity.Core.EntityKey permanentKey = base.ObjectStateManager.GetPermanentKey(relatedEntry.WrappedEntity, otherEndOfRelationship, this.WrappedEntity);
				global::System.Data.Entity.Core.Objects.EntityEntry.AddDetectedRelationship<global::System.Data.Entity.Core.EntityKey>(principalRelationships, permanentKey, otherEndOfRelationship);
			}
		}

		// Token: 0x0600308A RID: 12426 RVA: 0x000997A0 File Offset: 0x000979A0
		private static void AddDetectedRelationship<T>(global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd, global::System.Collections.Generic.HashSet<T>>> relationships, T relatedObject, global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd)
		{
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd, global::System.Collections.Generic.HashSet<T>> dictionary;
			if (!relationships.TryGetValue(relatedEnd.WrappedOwner, out dictionary))
			{
				dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd, global::System.Collections.Generic.HashSet<T>>();
				relationships.Add(relatedEnd.WrappedOwner, dictionary);
			}
			global::System.Collections.Generic.HashSet<T> hashSet;
			if (!dictionary.TryGetValue(relatedEnd, out hashSet))
			{
				hashSet = new global::System.Collections.Generic.HashSet<T>();
				dictionary.Add(relatedEnd, hashSet);
			}
			else if (relatedEnd is global::System.Data.Entity.Core.Objects.DataClasses.EntityReference && !object.Equals(hashSet.First<T>(), relatedObject))
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityReference_CannotAddMoreThanOneEntityToEntityReference(relatedEnd.RelationshipNavigation.To, relatedEnd.RelationshipNavigation.RelationshipName));
			}
			hashSet.Add(relatedObject);
		}

		// Token: 0x0600308B RID: 12427 RVA: 0x00099834 File Offset: 0x00097A34
		internal void Detach()
		{
			base.ValidateState();
			bool flag = false;
			global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager relationshipManager = this._wrappedEntity.RelationshipManager;
			flag = (base.State != global::System.Data.Entity.EntityState.Added && this.IsOneEndOfSomeRelationship());
			this._cache.TransactionManager.BeginDetaching();
			try
			{
				relationshipManager.DetachEntityFromRelationships(base.State);
			}
			finally
			{
				this._cache.TransactionManager.EndDetaching();
			}
			this.DetachRelationshipsEntries(relationshipManager);
			global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity = this._wrappedEntity;
			global::System.Data.Entity.Core.EntityKey entityKey = this._entityKey;
			int state = (int)base.State;
			if (flag)
			{
				this.DegradeEntry();
			}
			else
			{
				this._wrappedEntity.ObjectStateEntry = null;
				this._cache.ChangeState(this, base.State, global::System.Data.Entity.EntityState.Detached);
			}
			if (state != 4)
			{
				wrappedEntity.EntityKey = entityKey;
			}
		}

		// Token: 0x0600308C RID: 12428 RVA: 0x000998F8 File Offset: 0x00097AF8
		internal void Delete(bool doFixup)
		{
			base.ValidateState();
			if (this.IsKeyEntry)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_CannotDeleteOnKeyEntry);
			}
			if (doFixup && base.State != global::System.Data.Entity.EntityState.Deleted)
			{
				this.RelationshipManager.NullAllFKsInDependentsForWhichThisIsThePrincipal();
				this.NullAllForeignKeys();
				this.FixupRelationships();
			}
			global::System.Data.Entity.EntityState state = base.State;
			if (state <= global::System.Data.Entity.EntityState.Added)
			{
				if (state != global::System.Data.Entity.EntityState.Unchanged)
				{
					if (state != global::System.Data.Entity.EntityState.Added)
					{
						return;
					}
					this._cache.ChangeState(this, global::System.Data.Entity.EntityState.Added, global::System.Data.Entity.EntityState.Detached);
					return;
				}
				else
				{
					if (!doFixup)
					{
						this.DeleteRelationshipsThatReferenceKeys(null, null);
					}
					this._cache.ChangeState(this, global::System.Data.Entity.EntityState.Unchanged, global::System.Data.Entity.EntityState.Deleted);
					base.State = global::System.Data.Entity.EntityState.Deleted;
				}
			}
			else if (state != global::System.Data.Entity.EntityState.Deleted)
			{
				if (state != global::System.Data.Entity.EntityState.Modified)
				{
					return;
				}
				if (!doFixup)
				{
					this.DeleteRelationshipsThatReferenceKeys(null, null);
				}
				this._cache.ChangeState(this, global::System.Data.Entity.EntityState.Modified, global::System.Data.Entity.EntityState.Deleted);
				base.State = global::System.Data.Entity.EntityState.Deleted;
				return;
			}
		}

		// Token: 0x0600308D RID: 12429 RVA: 0x000999B0 File Offset: 0x00097BB0
		private void NullAllForeignKeys()
		{
			foreach (global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint> tuple in this.ForeignKeyDependents)
			{
				(this.WrappedEntity.RelationshipManager.GetRelatedEndInternal(tuple.Item1.ElementType.FullName, tuple.Item2.FromRole.Name) as global::System.Data.Entity.Core.Objects.DataClasses.EntityReference).NullAllForeignKeys();
			}
		}

		// Token: 0x0600308E RID: 12430 RVA: 0x00099A30 File Offset: 0x00097C30
		private bool IsOneEndOfSomeRelationship()
		{
			foreach (global::System.Data.Entity.Core.Objects.RelationshipEntry relationshipEntry in this._cache.FindRelationshipsByKey(this.EntityKey))
			{
				global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity relationshipMultiplicity = this.GetAssociationEndMember(relationshipEntry).RelationshipMultiplicity;
				if (relationshipMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One || relationshipMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne)
				{
					global::System.Data.Entity.Core.EntityKey otherEntityKey = relationshipEntry.RelationshipWrapper.GetOtherEntityKey(this.EntityKey);
					if (!this._cache.GetEntityEntry(otherEntityKey).IsKeyEntry)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0600308F RID: 12431 RVA: 0x00099AD0 File Offset: 0x00097CD0
		private void DetachRelationshipsEntries(global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager relationshipManager)
		{
			foreach (global::System.Data.Entity.Core.Objects.RelationshipEntry relationshipEntry in this._cache.CopyOfRelationshipsByKey(this.EntityKey))
			{
				global::System.Data.Entity.Core.EntityKey otherEntityKey = relationshipEntry.RelationshipWrapper.GetOtherEntityKey(this.EntityKey);
				if (this._cache.GetEntityEntry(otherEntityKey).IsKeyEntry)
				{
					if (relationshipEntry.State != global::System.Data.Entity.EntityState.Deleted)
					{
						global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember = relationshipEntry.RelationshipWrapper.GetAssociationEndMember(otherEntityKey);
						((global::System.Data.Entity.Core.Objects.DataClasses.EntityReference)relationshipManager.GetRelatedEndInternal(associationEndMember.DeclaringType.FullName, associationEndMember.Name)).DetachedEntityKey = otherEntityKey;
					}
					relationshipEntry.DeleteUnnecessaryKeyEntries();
					relationshipEntry.DetachRelationshipEntry();
				}
				else if (relationshipEntry.State == global::System.Data.Entity.EntityState.Deleted && this.GetAssociationEndMember(relationshipEntry).RelationshipMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many)
				{
					relationshipEntry.DetachRelationshipEntry();
				}
			}
		}

		// Token: 0x06003090 RID: 12432 RVA: 0x00099B93 File Offset: 0x00097D93
		private void FixupRelationships()
		{
			this._wrappedEntity.RelationshipManager.RemoveEntityFromRelationships();
			this.DeleteRelationshipsThatReferenceKeys(null, null);
		}

		// Token: 0x06003091 RID: 12433 RVA: 0x00099BB0 File Offset: 0x00097DB0
		internal void DeleteRelationshipsThatReferenceKeys(global::System.Data.Entity.Core.Metadata.Edm.RelationshipSet relationshipSet, global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember endMember)
		{
			if (base.State != global::System.Data.Entity.EntityState.Detached)
			{
				foreach (global::System.Data.Entity.Core.Objects.RelationshipEntry relationshipEntry in this._cache.CopyOfRelationshipsByKey(this.EntityKey))
				{
					if (relationshipEntry.State != global::System.Data.Entity.EntityState.Deleted && (relationshipSet == null || relationshipSet == relationshipEntry.EntitySet))
					{
						global::System.Data.Entity.Core.Objects.EntityEntry otherEndOfRelationship = this.GetOtherEndOfRelationship(relationshipEntry);
						if (endMember == null || endMember == otherEndOfRelationship.GetAssociationEndMember(relationshipEntry))
						{
							for (int j = 0; j < 2; j++)
							{
								global::System.Data.Entity.Core.EntityKey entityKey = relationshipEntry.GetCurrentRelationValue(j) as global::System.Data.Entity.Core.EntityKey;
								if (entityKey != null && this._cache.GetEntityEntry(entityKey).IsKeyEntry)
								{
									relationshipEntry.Delete(false);
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06003092 RID: 12434 RVA: 0x00099C58 File Offset: 0x00097E58
		private bool RetrieveAndCheckReferentialConstraintValuesInAcceptChanges()
		{
			global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager relationshipManager = this._wrappedEntity.RelationshipManager;
			global::System.Collections.Generic.List<string> list;
			bool flag;
			bool result = relationshipManager.FindNamesOfReferentialConstraintProperties(out list, out flag, true);
			if (list != null)
			{
				global::System.Collections.Generic.HashSet<object> visited = new global::System.Collections.Generic.HashSet<object>();
				global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.KeyValuePair<object, global::System.Data.Entity.Core.Objects.IntBox>> dictionary;
				relationshipManager.RetrieveReferentialConstraintProperties(out dictionary, visited, false);
				foreach (global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.KeyValuePair<object, global::System.Data.Entity.Core.Objects.IntBox>> keyValuePair in dictionary)
				{
					this.SetCurrentEntityValue(keyValuePair.Key, keyValuePair.Value.Key);
				}
			}
			if (flag)
			{
				this.CheckReferentialConstraintPropertiesInDependents();
			}
			return result;
		}

		// Token: 0x06003093 RID: 12435 RVA: 0x00099CF8 File Offset: 0x00097EF8
		internal void RetrieveReferentialConstraintPropertiesFromKeyEntries(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.KeyValuePair<object, global::System.Data.Entity.Core.Objects.IntBox>> properties)
		{
			foreach (global::System.Data.Entity.Core.Objects.RelationshipEntry relationshipEntry in this._cache.FindRelationshipsByKey(this.EntityKey))
			{
				global::System.Data.Entity.Core.Objects.EntityEntry otherEndOfRelationship = this.GetOtherEndOfRelationship(relationshipEntry);
				if (otherEndOfRelationship.IsKeyEntry)
				{
					foreach (global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint referentialConstraint in ((global::System.Data.Entity.Core.Metadata.Edm.AssociationSet)relationshipEntry.EntitySet).ElementType.ReferentialConstraints)
					{
						string name = this.GetAssociationEndMember(relationshipEntry).Name;
						if (referentialConstraint.ToRole.Name == name)
						{
							foreach (global::System.Data.Entity.Core.EntityKeyMember entityKeyMember in ((global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.EntityKeyMember>)otherEndOfRelationship.EntityKey.EntityKeyValues))
							{
								for (int i = 0; i < referentialConstraint.FromProperties.Count; i++)
								{
									if (referentialConstraint.FromProperties[i].Name == entityKeyMember.Key)
									{
										global::System.Data.Entity.Core.Objects.EntityEntry.AddOrIncreaseCounter(referentialConstraint, properties, referentialConstraint.ToProperties[i].Name, entityKeyMember.Value);
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06003094 RID: 12436 RVA: 0x00099EA8 File Offset: 0x000980A8
		internal static void AddOrIncreaseCounter(global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint constraint, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.KeyValuePair<object, global::System.Data.Entity.Core.Objects.IntBox>> properties, string propertyName, object propertyValue)
		{
			if (!properties.ContainsKey(propertyName))
			{
				properties[propertyName] = new global::System.Collections.Generic.KeyValuePair<object, global::System.Data.Entity.Core.Objects.IntBox>(propertyValue, new global::System.Data.Entity.Core.Objects.IntBox(1));
				return;
			}
			global::System.Collections.Generic.KeyValuePair<object, global::System.Data.Entity.Core.Objects.IntBox> keyValuePair = properties[propertyName];
			if (!global::System.Data.Entity.Core.Common.Utils.ByValueEqualityComparer.Default.Equals(keyValuePair.Key, propertyValue))
			{
				throw new global::System.InvalidOperationException(constraint.BuildConstraintExceptionMessage());
			}
			keyValuePair.Value.Value = keyValuePair.Value.Value + 1;
		}

		// Token: 0x06003095 RID: 12437 RVA: 0x00099F14 File Offset: 0x00098114
		private void CheckReferentialConstraintPropertiesInDependents()
		{
			foreach (global::System.Data.Entity.Core.Objects.RelationshipEntry relationshipEntry in this._cache.FindRelationshipsByKey(this.EntityKey))
			{
				global::System.Data.Entity.Core.Objects.EntityEntry otherEndOfRelationship = this.GetOtherEndOfRelationship(relationshipEntry);
				if (otherEndOfRelationship.State == global::System.Data.Entity.EntityState.Unchanged || otherEndOfRelationship.State == global::System.Data.Entity.EntityState.Modified)
				{
					foreach (global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint referentialConstraint in ((global::System.Data.Entity.Core.Metadata.Edm.AssociationSet)relationshipEntry.EntitySet).ElementType.ReferentialConstraints)
					{
						string name = this.GetAssociationEndMember(relationshipEntry).Name;
						if (referentialConstraint.FromRole.Name == name)
						{
							foreach (global::System.Data.Entity.Core.EntityKeyMember entityKeyMember in ((global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.EntityKeyMember>)otherEndOfRelationship.EntityKey.EntityKeyValues))
							{
								for (int i = 0; i < referentialConstraint.FromProperties.Count; i++)
								{
									if (referentialConstraint.ToProperties[i].Name == entityKeyMember.Key && !global::System.Data.Entity.Core.Common.Utils.ByValueEqualityComparer.Default.Equals(this.GetCurrentEntityValue(referentialConstraint.FromProperties[i].Name), entityKeyMember.Value))
									{
										throw new global::System.InvalidOperationException(referentialConstraint.BuildConstraintExceptionMessage());
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06003096 RID: 12438 RVA: 0x0009A0E8 File Offset: 0x000982E8
		internal void PromoteKeyEntry(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity, global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata typeMetadata)
		{
			this._wrappedEntity = wrappedEntity;
			this._wrappedEntity.ObjectStateEntry = this;
			this._cacheTypeMetadata = typeMetadata;
			this.SetChangeTrackingFlags();
		}

		// Token: 0x06003097 RID: 12439 RVA: 0x0009A10C File Offset: 0x0009830C
		internal void DegradeEntry()
		{
			this._entityKey = this.EntityKey;
			this.RemoveFromForeignKeyIndex();
			this._wrappedEntity.SetChangeTracker(null);
			this._modifiedFields = null;
			this._originalValues = null;
			this._originalComplexObjects = null;
			if (base.State == global::System.Data.Entity.EntityState.Added)
			{
				this._wrappedEntity.EntityKey = null;
				this._entityKey = null;
			}
			if (base.State != global::System.Data.Entity.EntityState.Unchanged)
			{
				this._cache.ChangeState(this, base.State, global::System.Data.Entity.EntityState.Unchanged);
				base.State = global::System.Data.Entity.EntityState.Unchanged;
			}
			this._cache.RemoveEntryFromKeylessStore(this._wrappedEntity);
			this._wrappedEntity.DetachContext();
			this._wrappedEntity.ObjectStateEntry = null;
			object entity = this._wrappedEntity.Entity;
			this._wrappedEntity = global::System.Data.Entity.Core.Objects.Internal.NullEntityWrapper.NullWrapper;
			this.SetChangeTrackingFlags();
			this._cache.OnObjectStateManagerChanged(global::System.ComponentModel.CollectionChangeAction.Remove, entity);
		}

		// Token: 0x06003098 RID: 12440 RVA: 0x0009A1DD File Offset: 0x000983DD
		internal void AttachObjectStateManagerToEntity()
		{
			this._wrappedEntity.SetChangeTracker(this);
			this._wrappedEntity.TakeSnapshot(this);
		}

		// Token: 0x06003099 RID: 12441 RVA: 0x0009A1F8 File Offset: 0x000983F8
		internal void GetOtherKeyProperties(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.KeyValuePair<object, global::System.Data.Entity.Core.Objects.IntBox>> properties)
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember in (this._cacheTypeMetadata.DataRecordInfo.RecordType.EdmType as global::System.Data.Entity.Core.Metadata.Edm.EntityType).KeyMembers)
			{
				if (!properties.ContainsKey(edmMember.Name))
				{
					properties[edmMember.Name] = new global::System.Collections.Generic.KeyValuePair<object, global::System.Data.Entity.Core.Objects.IntBox>(this.GetCurrentEntityValue(edmMember.Name), new global::System.Data.Entity.Core.Objects.IntBox(1));
				}
			}
		}

		// Token: 0x0600309A RID: 12442 RVA: 0x0009A290 File Offset: 0x00098490
		internal void AddOriginalValueAt(int index, global::System.Data.Entity.Core.Objects.StateManagerMemberMetadata memberMetadata, object userObject, object value)
		{
			global::System.Data.Entity.Core.Objects.StateManagerValue stateManagerValue = new global::System.Data.Entity.Core.Objects.StateManagerValue(memberMetadata, userObject, value);
			if (index >= 0)
			{
				this._originalValues[index] = stateManagerValue;
				return;
			}
			if (this._originalValues == null)
			{
				this._originalValues = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.StateManagerValue>();
			}
			this._originalValues.Add(stateManagerValue);
		}

		// Token: 0x0600309B RID: 12443 RVA: 0x0009A2DC File Offset: 0x000984DC
		internal void CompareKeyProperties(object changed)
		{
			global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata cacheTypeMetadata = this._cacheTypeMetadata;
			int fieldCount = this.GetFieldCount(cacheTypeMetadata);
			for (int i = 0; i < fieldCount; i++)
			{
				global::System.Data.Entity.Core.Objects.StateManagerMemberMetadata stateManagerMemberMetadata = cacheTypeMetadata.Member(i);
				if (stateManagerMemberMetadata.IsPartOfKey)
				{
					object value = stateManagerMemberMetadata.GetValue(changed);
					object value2 = stateManagerMemberMetadata.GetValue(this._wrappedEntity.Entity);
					if (!global::System.Data.Entity.Core.Common.Utils.ByValueEqualityComparer.Default.Equals(value, value2))
					{
						throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_CannotModifyKeyProperty(stateManagerMemberMetadata.CLayerName));
					}
				}
			}
		}

		// Token: 0x0600309C RID: 12444 RVA: 0x0009A358 File Offset: 0x00098558
		internal object GetCurrentEntityValue(string memberName)
		{
			int ordinalforOLayerMemberName = this._cacheTypeMetadata.GetOrdinalforOLayerMemberName(memberName);
			return this.GetCurrentEntityValue(this._cacheTypeMetadata, ordinalforOLayerMemberName, this._wrappedEntity.Entity, global::System.Data.Entity.Core.Objects.ObjectStateValueRecord.CurrentUpdatable);
		}

		// Token: 0x0600309D RID: 12445 RVA: 0x0009A38B File Offset: 0x0009858B
		internal void VerifyEntityValueIsEditable(global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata typeMetadata, int ordinal, string memberName)
		{
			if (base.State == global::System.Data.Entity.EntityState.Deleted)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_CantModifyDetachedDeletedEntries);
			}
			if (typeMetadata.Member(ordinal).IsPartOfKey && base.State != global::System.Data.Entity.EntityState.Added)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_CannotModifyKeyProperty(memberName));
			}
		}

		// Token: 0x0600309E RID: 12446 RVA: 0x0009A3C4 File Offset: 0x000985C4
		internal void SetCurrentEntityValue(global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata metadata, int ordinal, object userObject, object newValue)
		{
			base.ValidateState();
			global::System.Data.Entity.Core.Objects.StateManagerMemberMetadata stateManagerMemberMetadata = metadata.Member(ordinal);
			if (stateManagerMemberMetadata.IsComplex)
			{
				if (newValue == null || newValue == global::System.DBNull.Value)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ComplexObject_NullableComplexTypesNotSupported(stateManagerMemberMetadata.CLayerName));
				}
				global::System.Data.Entity.Core.IExtendedDataRecord extendedDataRecord = newValue as global::System.Data.Entity.Core.IExtendedDataRecord;
				if (extendedDataRecord == null)
				{
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_InvalidTypeForComplexTypeProperty, "newValue");
				}
				newValue = this._cache.ComplexTypeMaterializer.CreateComplex(extendedDataRecord, extendedDataRecord.DataRecordInfo, null);
			}
			this._wrappedEntity.SetCurrentValue(this, stateManagerMemberMetadata, ordinal, userObject, newValue);
		}

		// Token: 0x0600309F RID: 12447 RVA: 0x0009A44C File Offset: 0x0009864C
		private void TransitionRelationshipsForAdd()
		{
			foreach (global::System.Data.Entity.Core.Objects.RelationshipEntry relationshipEntry in this._cache.CopyOfRelationshipsByKey(this.EntityKey))
			{
				if (relationshipEntry.State == global::System.Data.Entity.EntityState.Unchanged)
				{
					base.ObjectStateManager.ChangeState(relationshipEntry, global::System.Data.Entity.EntityState.Unchanged, global::System.Data.Entity.EntityState.Added);
					relationshipEntry.State = global::System.Data.Entity.EntityState.Added;
				}
				else if (relationshipEntry.State == global::System.Data.Entity.EntityState.Deleted)
				{
					relationshipEntry.DeleteUnnecessaryKeyEntries();
					relationshipEntry.DetachRelationshipEntry();
				}
			}
		}

		// Token: 0x060030A0 RID: 12448 RVA: 0x0009A4B2 File Offset: 0x000986B2
		[global::System.Diagnostics.Conditional("DEBUG")]
		private void VerifyIsNotRelated()
		{
		}

		// Token: 0x060030A1 RID: 12449 RVA: 0x0009A4B4 File Offset: 0x000986B4
		internal void ChangeObjectState(global::System.Data.Entity.EntityState requestedState)
		{
			if (!this.IsKeyEntry)
			{
				global::System.Data.Entity.EntityState state = base.State;
				switch (state)
				{
				case global::System.Data.Entity.EntityState.Detached:
				case global::System.Data.Entity.EntityState.Detached | global::System.Data.Entity.EntityState.Unchanged:
					break;
				case global::System.Data.Entity.EntityState.Unchanged:
					switch (requestedState)
					{
					case global::System.Data.Entity.EntityState.Detached:
						this.Detach();
						return;
					case global::System.Data.Entity.EntityState.Unchanged:
						return;
					case global::System.Data.Entity.EntityState.Detached | global::System.Data.Entity.EntityState.Unchanged:
						break;
					case global::System.Data.Entity.EntityState.Added:
						base.ObjectStateManager.ReplaceKeyWithTemporaryKey(this);
						this._modifiedFields = null;
						this._originalValues = null;
						this._originalComplexObjects = null;
						base.State = global::System.Data.Entity.EntityState.Added;
						this.TransitionRelationshipsForAdd();
						return;
					default:
						if (requestedState == global::System.Data.Entity.EntityState.Deleted)
						{
							this.Delete(true);
							return;
						}
						if (requestedState == global::System.Data.Entity.EntityState.Modified)
						{
							this.SetModified();
							this.SetModifiedAll();
							return;
						}
						break;
					}
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ObjectContext_InvalidEntityState, "requestedState");
				case global::System.Data.Entity.EntityState.Added:
					switch (requestedState)
					{
					case global::System.Data.Entity.EntityState.Detached:
						this.Detach();
						return;
					case global::System.Data.Entity.EntityState.Unchanged:
						this.AcceptChanges();
						return;
					case global::System.Data.Entity.EntityState.Detached | global::System.Data.Entity.EntityState.Unchanged:
						break;
					case global::System.Data.Entity.EntityState.Added:
						this.TransitionRelationshipsForAdd();
						return;
					default:
						if (requestedState == global::System.Data.Entity.EntityState.Deleted)
						{
							this._cache.ForgetEntryWithConceptualNull(this, true);
							this.AcceptChanges();
							this.Delete(true);
							return;
						}
						if (requestedState == global::System.Data.Entity.EntityState.Modified)
						{
							this.AcceptChanges();
							this.SetModified();
							this.SetModifiedAll();
							return;
						}
						break;
					}
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ObjectContext_InvalidEntityState, "requestedState");
				default:
					if (state == global::System.Data.Entity.EntityState.Deleted)
					{
						switch (requestedState)
						{
						case global::System.Data.Entity.EntityState.Detached:
							this.Detach();
							return;
						case global::System.Data.Entity.EntityState.Unchanged:
							this._modifiedFields = null;
							this._originalValues = null;
							this._originalComplexObjects = null;
							base.ObjectStateManager.ChangeState(this, global::System.Data.Entity.EntityState.Deleted, global::System.Data.Entity.EntityState.Unchanged);
							base.State = global::System.Data.Entity.EntityState.Unchanged;
							this._wrappedEntity.TakeSnapshot(this);
							this._cache.FixupReferencesByForeignKeys(this, false);
							this._cache.OnObjectStateManagerChanged(global::System.ComponentModel.CollectionChangeAction.Add, this.Entity);
							return;
						case global::System.Data.Entity.EntityState.Detached | global::System.Data.Entity.EntityState.Unchanged:
							break;
						case global::System.Data.Entity.EntityState.Added:
							this.TransitionRelationshipsForAdd();
							base.ObjectStateManager.ReplaceKeyWithTemporaryKey(this);
							this._modifiedFields = null;
							this._originalValues = null;
							this._originalComplexObjects = null;
							base.State = global::System.Data.Entity.EntityState.Added;
							this._cache.FixupReferencesByForeignKeys(this, false);
							this._cache.OnObjectStateManagerChanged(global::System.ComponentModel.CollectionChangeAction.Add, this.Entity);
							return;
						default:
							if (requestedState == global::System.Data.Entity.EntityState.Deleted)
							{
								return;
							}
							if (requestedState == global::System.Data.Entity.EntityState.Modified)
							{
								base.ObjectStateManager.ChangeState(this, global::System.Data.Entity.EntityState.Deleted, global::System.Data.Entity.EntityState.Modified);
								base.State = global::System.Data.Entity.EntityState.Modified;
								this.SetModifiedAll();
								this._cache.FixupReferencesByForeignKeys(this, false);
								this._cache.OnObjectStateManagerChanged(global::System.ComponentModel.CollectionChangeAction.Add, this.Entity);
								return;
							}
							break;
						}
						throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ObjectContext_InvalidEntityState, "requestedState");
					}
					if (state != global::System.Data.Entity.EntityState.Modified)
					{
						return;
					}
					switch (requestedState)
					{
					case global::System.Data.Entity.EntityState.Detached:
						this.Detach();
						return;
					case global::System.Data.Entity.EntityState.Unchanged:
						this.AcceptChanges();
						return;
					case global::System.Data.Entity.EntityState.Detached | global::System.Data.Entity.EntityState.Unchanged:
						break;
					case global::System.Data.Entity.EntityState.Added:
						base.ObjectStateManager.ReplaceKeyWithTemporaryKey(this);
						this._modifiedFields = null;
						this._originalValues = null;
						this._originalComplexObjects = null;
						base.State = global::System.Data.Entity.EntityState.Added;
						this.TransitionRelationshipsForAdd();
						return;
					default:
						if (requestedState == global::System.Data.Entity.EntityState.Deleted)
						{
							this.Delete(true);
							return;
						}
						if (requestedState == global::System.Data.Entity.EntityState.Modified)
						{
							this.SetModified();
							this.SetModifiedAll();
							return;
						}
						break;
					}
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ObjectContext_InvalidEntityState, "requestedState");
				}
				return;
			}
			if (requestedState == global::System.Data.Entity.EntityState.Unchanged)
			{
				return;
			}
			throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_CannotModifyKeyEntryState);
		}

		// Token: 0x060030A2 RID: 12450 RVA: 0x0009A7A8 File Offset: 0x000989A8
		internal void UpdateOriginalValues(object entity)
		{
			global::System.Data.Entity.EntityState state = base.State;
			this.UpdateRecordWithSetModified(entity, this.EditableOriginalValues);
			if (state == global::System.Data.Entity.EntityState.Unchanged && base.State == global::System.Data.Entity.EntityState.Modified)
			{
				base.ObjectStateManager.ChangeState(this, state, global::System.Data.Entity.EntityState.Modified);
			}
		}

		// Token: 0x060030A3 RID: 12451 RVA: 0x0009A7E6 File Offset: 0x000989E6
		internal void UpdateRecordWithoutSetModified(object value, global::System.Data.Entity.Core.Objects.DbUpdatableDataRecord current)
		{
			this.UpdateRecord(value, current, global::System.Data.Entity.Core.Objects.EntityEntry.UpdateRecordBehavior.WithoutSetModified, -1);
		}

		// Token: 0x060030A4 RID: 12452 RVA: 0x0009A7F2 File Offset: 0x000989F2
		internal void UpdateRecordWithSetModified(object value, global::System.Data.Entity.Core.Objects.DbUpdatableDataRecord current)
		{
			this.UpdateRecord(value, current, global::System.Data.Entity.Core.Objects.EntityEntry.UpdateRecordBehavior.WithSetModified, -1);
		}

		// Token: 0x060030A5 RID: 12453 RVA: 0x0009A800 File Offset: 0x00098A00
		private void UpdateRecord(object value, global::System.Data.Entity.Core.Objects.DbUpdatableDataRecord current, global::System.Data.Entity.Core.Objects.EntityEntry.UpdateRecordBehavior behavior, int propertyIndex)
		{
			global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata metadata = current._metadata;
			foreach (global::System.Data.Entity.Core.Common.FieldMetadata fieldMetadata in metadata.DataRecordInfo.FieldMetadata)
			{
				int ordinal = fieldMetadata.Ordinal;
				global::System.Data.Entity.Core.Objects.StateManagerMemberMetadata stateManagerMemberMetadata = metadata.Member(ordinal);
				object obj = stateManagerMemberMetadata.GetValue(value) ?? global::System.DBNull.Value;
				if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsComplexType(fieldMetadata.FieldType.TypeUsage.EdmType))
				{
					object value2 = current.GetValue(ordinal);
					if (value2 == global::System.DBNull.Value)
					{
						throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ComplexObject_NullableComplexTypesNotSupported(fieldMetadata.FieldType.Name));
					}
					if (obj != global::System.DBNull.Value)
					{
						this.UpdateRecord(obj, (global::System.Data.Entity.Core.Objects.DbUpdatableDataRecord)value2, behavior, (propertyIndex == -1) ? ordinal : propertyIndex);
					}
				}
				else if (this.HasRecordValueChanged(current, ordinal, obj) && !stateManagerMemberMetadata.IsPartOfKey)
				{
					current.SetValue(ordinal, obj);
					if (behavior == global::System.Data.Entity.Core.Objects.EntityEntry.UpdateRecordBehavior.WithSetModified)
					{
						this.SetModifiedPropertyInternal((propertyIndex == -1) ? ordinal : propertyIndex);
					}
				}
			}
		}

		// Token: 0x060030A6 RID: 12454 RVA: 0x0009A914 File Offset: 0x00098B14
		internal bool HasRecordValueChanged(global::System.Data.Common.DbDataRecord record, int propertyIndex, object newFieldValue)
		{
			object value = record.GetValue(propertyIndex);
			return (value != newFieldValue && (global::System.DBNull.Value == newFieldValue || global::System.DBNull.Value == value || !global::System.Data.Entity.Core.Common.Utils.ByValueEqualityComparer.Default.Equals(value, newFieldValue))) || (this._cache.EntryHasConceptualNull(this) && this._modifiedFields != null && this._modifiedFields[propertyIndex]);
		}

		// Token: 0x060030A7 RID: 12455 RVA: 0x0009A974 File Offset: 0x00098B74
		internal void ApplyCurrentValuesInternal(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedCurrentEntity)
		{
			if (base.State != global::System.Data.Entity.EntityState.Modified && base.State != global::System.Data.Entity.EntityState.Unchanged)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectContext_EntityMustBeUnchangedOrModified(base.State.ToString()));
			}
			if (this.WrappedEntity.IdentityType != wrappedCurrentEntity.IdentityType)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ObjectContext_EntitiesHaveDifferentType(this.Entity.GetType().FullName, wrappedCurrentEntity.Entity.GetType().FullName));
			}
			this.CompareKeyProperties(wrappedCurrentEntity.Entity);
			this.UpdateCurrentValueRecord(wrappedCurrentEntity.Entity);
		}

		// Token: 0x060030A8 RID: 12456 RVA: 0x0009AA0E File Offset: 0x00098C0E
		internal void UpdateCurrentValueRecord(object value)
		{
			this._wrappedEntity.UpdateCurrentValueRecord(value, this);
		}

		// Token: 0x060030A9 RID: 12457 RVA: 0x0009AA20 File Offset: 0x00098C20
		internal void ApplyOriginalValuesInternal(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedOriginalEntity)
		{
			if (base.State != global::System.Data.Entity.EntityState.Modified && base.State != global::System.Data.Entity.EntityState.Unchanged && base.State != global::System.Data.Entity.EntityState.Deleted)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectContext_EntityMustBeUnchangedOrModifiedOrDeleted(base.State.ToString()));
			}
			if (this.WrappedEntity.IdentityType != wrappedOriginalEntity.IdentityType)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ObjectContext_EntitiesHaveDifferentType(this.Entity.GetType().FullName, wrappedOriginalEntity.Entity.GetType().FullName));
			}
			this.CompareKeyProperties(wrappedOriginalEntity.Entity);
			this.UpdateOriginalValues(wrappedOriginalEntity.Entity);
		}

		// Token: 0x060030AA RID: 12458 RVA: 0x0009AAC4 File Offset: 0x00098CC4
		internal void RemoveFromForeignKeyIndex()
		{
			if (!this.IsKeyEntry)
			{
				foreach (global::System.Data.Entity.Core.Objects.DataClasses.EntityReference entityReference in this.FindFKRelatedEnds())
				{
					foreach (global::System.Data.Entity.Core.EntityKey foreignKey in entityReference.GetAllKeyValues())
					{
						this._cache.RemoveEntryFromForeignKeyIndex(entityReference, foreignKey, this);
					}
				}
			}
		}

		// Token: 0x060030AB RID: 12459 RVA: 0x0009AB58 File Offset: 0x00098D58
		internal void FixupReferencesByForeignKeys(bool replaceAddedRefs, global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase restrictTo = null)
		{
			this._cache.TransactionManager.BeginGraphUpdate();
			bool setIsLoaded = !this._cache.TransactionManager.IsAttachTracking && !this._cache.TransactionManager.IsAddTracking;
			try
			{
				global::System.Collections.Generic.IEnumerable<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>> foreignKeyDependents = this.ForeignKeyDependents;
				global::System.Func<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>, bool> <>9__0;
				global::System.Func<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>, bool> predicate;
				if ((predicate = <>9__0) == null)
				{
					predicate = (<>9__0 = ((global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint> t) => restrictTo == null || t.Item1.SourceSet.Identity == restrictTo.Identity || t.Item1.TargetSet.Identity == restrictTo.Identity));
				}
				foreach (global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint> tuple in foreignKeyDependents.Where(predicate))
				{
					global::System.Data.Entity.Core.Objects.DataClasses.EntityReference entityReference = this.WrappedEntity.RelationshipManager.GetRelatedEndInternal(tuple.Item1.ElementType, (global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember)tuple.Item2.FromRole) as global::System.Data.Entity.Core.Objects.DataClasses.EntityReference;
					if (!global::System.Data.Entity.Core.Objects.Internal.ForeignKeyFactory.IsConceptualNullKey(entityReference.CachedForeignKey))
					{
						this.FixupEntityReferenceToPrincipal(entityReference, null, setIsLoaded, replaceAddedRefs);
					}
				}
			}
			finally
			{
				this._cache.TransactionManager.EndGraphUpdate();
			}
		}

		// Token: 0x060030AC RID: 12460 RVA: 0x0009AC74 File Offset: 0x00098E74
		internal void FixupEntityReferenceByForeignKey(global::System.Data.Entity.Core.Objects.DataClasses.EntityReference reference)
		{
			reference.IsLoaded = false;
			if (global::System.Data.Entity.Core.Objects.Internal.ForeignKeyFactory.IsConceptualNullKey(reference.CachedForeignKey))
			{
				base.ObjectStateManager.ForgetEntryWithConceptualNull(this, false);
			}
			global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper referenceValue = reference.ReferenceValue;
			global::System.Data.Entity.Core.EntityKey entityKey = global::System.Data.Entity.Core.Objects.Internal.ForeignKeyFactory.CreateKeyFromForeignKeyValues(this, reference);
			bool flag;
			if (entityKey == null || referenceValue.Entity == null)
			{
				flag = true;
			}
			else
			{
				global::System.Data.Entity.Core.EntityKey entityKey2 = referenceValue.EntityKey;
				global::System.Data.Entity.Core.Objects.EntityEntry objectStateEntry = referenceValue.ObjectStateEntry;
				if ((entityKey2 == null || entityKey2.IsTemporary) && objectStateEntry != null)
				{
					entityKey2 = new global::System.Data.Entity.Core.EntityKey((global::System.Data.Entity.Core.Metadata.Edm.EntitySet)objectStateEntry.EntitySet, objectStateEntry.CurrentValues);
				}
				flag = !entityKey.Equals(entityKey2);
			}
			if (this._cache.TransactionManager.RelationshipBeingUpdated != reference)
			{
				if (!flag)
				{
					return;
				}
				this._cache.TransactionManager.BeginGraphUpdate();
				if (entityKey != null)
				{
					this._cache.TransactionManager.EntityBeingReparented = this.Entity;
				}
				try
				{
					this.FixupEntityReferenceToPrincipal(reference, entityKey, false, true);
					return;
				}
				finally
				{
					this._cache.TransactionManager.EntityBeingReparented = null;
					this._cache.TransactionManager.EndGraphUpdate();
				}
			}
			this.FixupEntityReferenceToPrincipal(reference, entityKey, false, false);
		}

		// Token: 0x060030AD RID: 12461 RVA: 0x0009AD90 File Offset: 0x00098F90
		internal void FixupEntityReferenceToPrincipal(global::System.Data.Entity.Core.Objects.DataClasses.EntityReference relatedEnd, global::System.Data.Entity.Core.EntityKey foreignKey, bool setIsLoaded, bool replaceExistingRef)
		{
			if (foreignKey == null)
			{
				foreignKey = global::System.Data.Entity.Core.Objects.Internal.ForeignKeyFactory.CreateKeyFromForeignKeyValues(this, relatedEnd);
			}
			bool flag = this._cache.TransactionManager.RelationshipBeingUpdated != relatedEnd && (!this._cache.TransactionManager.IsForeignKeyUpdate || relatedEnd.ReferenceValue.ObjectStateEntry == null || relatedEnd.ReferenceValue.ObjectStateEntry.State != global::System.Data.Entity.EntityState.Added);
			relatedEnd.SetCachedForeignKey(foreignKey, this);
			base.ObjectStateManager.ForgetEntryWithConceptualNull(this, false);
			if (foreignKey != null)
			{
				global::System.Data.Entity.Core.Objects.EntityEntry entityEntry;
				if (this._cache.TryGetEntityEntry(foreignKey, out entityEntry) && !entityEntry.IsKeyEntry && entityEntry.State != global::System.Data.Entity.EntityState.Deleted && (replaceExistingRef || global::System.Data.Entity.Core.Objects.EntityEntry.WillNotRefSteal(relatedEnd, entityEntry.WrappedEntity)) && relatedEnd.CanSetEntityType(entityEntry.WrappedEntity))
				{
					if (flag)
					{
						if (this._cache.TransactionManager.PopulatedEntityReferences != null)
						{
							this._cache.TransactionManager.PopulatedEntityReferences.Add(relatedEnd);
						}
						relatedEnd.SetEntityKey(foreignKey, true);
						if (this._cache.TransactionManager.PopulatedEntityReferences != null)
						{
							global::System.Data.Entity.Core.Objects.DataClasses.EntityReference entityReference = relatedEnd.GetOtherEndOfRelationship(entityEntry.WrappedEntity) as global::System.Data.Entity.Core.Objects.DataClasses.EntityReference;
							if (entityReference != null)
							{
								this._cache.TransactionManager.PopulatedEntityReferences.Add(entityReference);
							}
						}
					}
					if (setIsLoaded && entityEntry.State != global::System.Data.Entity.EntityState.Added)
					{
						relatedEnd.IsLoaded = true;
						return;
					}
				}
				else
				{
					this._cache.AddEntryContainingForeignKeyToIndex(relatedEnd, foreignKey, this);
					if (flag && replaceExistingRef && relatedEnd.ReferenceValue.Entity != null)
					{
						relatedEnd.ReferenceValue = global::System.Data.Entity.Core.Objects.Internal.NullEntityWrapper.NullWrapper;
						return;
					}
				}
			}
			else if (flag)
			{
				if (replaceExistingRef && (relatedEnd.ReferenceValue.Entity != null || relatedEnd.EntityKey != null))
				{
					relatedEnd.ReferenceValue = global::System.Data.Entity.Core.Objects.Internal.NullEntityWrapper.NullWrapper;
				}
				if (setIsLoaded)
				{
					relatedEnd.IsLoaded = true;
				}
			}
		}

		// Token: 0x060030AE RID: 12462 RVA: 0x0009AF5C File Offset: 0x0009915C
		private static bool WillNotRefSteal(global::System.Data.Entity.Core.Objects.DataClasses.EntityReference refToPrincipal, global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedPrincipal)
		{
			global::System.Data.Entity.Core.Objects.DataClasses.EntityReference entityReference = refToPrincipal.GetOtherEndOfRelationship(wrappedPrincipal) as global::System.Data.Entity.Core.Objects.DataClasses.EntityReference;
			if (refToPrincipal.ReferenceValue.Entity == null && refToPrincipal.NavigationPropertyIsNullOrMissing() && (entityReference == null || (entityReference.ReferenceValue.Entity == null && entityReference.NavigationPropertyIsNullOrMissing())))
			{
				return true;
			}
			if (entityReference != null && (entityReference.ReferenceValue.Entity == refToPrincipal.WrappedOwner.Entity || entityReference.CheckIfNavigationPropertyContainsEntity(refToPrincipal.WrappedOwner)))
			{
				return true;
			}
			if (entityReference == null || refToPrincipal.ReferenceValue.Entity == wrappedPrincipal.Entity || refToPrincipal.CheckIfNavigationPropertyContainsEntity(wrappedPrincipal))
			{
				return false;
			}
			throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityReference_CannotAddMoreThanOneEntityToEntityReference(entityReference.RelationshipNavigation.To, entityReference.RelationshipNavigation.RelationshipName));
		}

		// Token: 0x060030AF RID: 12463 RVA: 0x0009B014 File Offset: 0x00099214
		internal bool TryGetReferenceKey(global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember principalRole, out global::System.Data.Entity.Core.EntityKey principalKey)
		{
			global::System.Data.Entity.Core.Objects.DataClasses.EntityReference entityReference = this.RelationshipManager.GetRelatedEnd(principalRole.DeclaringType.FullName, principalRole.Name) as global::System.Data.Entity.Core.Objects.DataClasses.EntityReference;
			if (entityReference.CachedValue.Entity == null || entityReference.CachedValue.ObjectStateEntry == null)
			{
				principalKey = null;
				return false;
			}
			principalKey = (entityReference.EntityKey ?? entityReference.CachedValue.ObjectStateEntry.EntityKey);
			return principalKey != null;
		}

		// Token: 0x060030B0 RID: 12464 RVA: 0x0009B088 File Offset: 0x00099288
		internal void FixupForeignKeysByReference()
		{
			this._cache.TransactionManager.BeginFixupKeysByReference();
			try
			{
				this.FixupForeignKeysByReference(null);
			}
			finally
			{
				this._cache.TransactionManager.EndFixupKeysByReference();
			}
		}

		// Token: 0x060030B1 RID: 12465 RVA: 0x0009B0D0 File Offset: 0x000992D0
		private void FixupForeignKeysByReference(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.EntityEntry> visited)
		{
			if (!(base.EntitySet as global::System.Data.Entity.Core.Metadata.Edm.EntitySet).HasForeignKeyRelationships)
			{
				return;
			}
			foreach (global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint> tuple in this.ForeignKeyDependents)
			{
				global::System.Data.Entity.Core.Objects.DataClasses.EntityReference entityReference = this.RelationshipManager.GetRelatedEndInternal(tuple.Item1.ElementType.FullName, tuple.Item2.FromRole.Name) as global::System.Data.Entity.Core.Objects.DataClasses.EntityReference;
				global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper referenceValue = entityReference.ReferenceValue;
				if (referenceValue.Entity != null)
				{
					global::System.Data.Entity.Core.Objects.EntityEntry objectStateEntry = referenceValue.ObjectStateEntry;
					bool? flag = null;
					if (objectStateEntry != null && objectStateEntry.State == global::System.Data.Entity.EntityState.Added)
					{
						if (objectStateEntry == this)
						{
							flag = new bool?(entityReference.GetOtherEndOfRelationship(referenceValue) is global::System.Data.Entity.Core.Objects.DataClasses.EntityReference);
							bool? flag2 = flag;
							if (!flag2.Value)
							{
								goto IL_119;
							}
						}
						visited = (visited ?? new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.EntityEntry>());
						if (visited.Contains(this))
						{
							if (flag == null)
							{
								flag = new bool?(entityReference.GetOtherEndOfRelationship(referenceValue) is global::System.Data.Entity.Core.Objects.DataClasses.EntityReference);
							}
							if (flag.Value)
							{
								throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.RelationshipManager_CircularRelationshipsWithReferentialConstraints);
							}
						}
						else
						{
							visited.Add(this);
							objectStateEntry.FixupForeignKeysByReference(visited);
							visited.Remove(this);
						}
					}
					IL_119:
					entityReference.UpdateForeignKeyValues(this.WrappedEntity, referenceValue, null, false);
				}
				else
				{
					global::System.Data.Entity.Core.EntityKey entityKey = entityReference.EntityKey;
					if (entityKey != null && !entityKey.IsTemporary)
					{
						entityReference.UpdateForeignKeyValues(this.WrappedEntity, entityKey);
					}
				}
			}
			foreach (global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint> tuple2 in this.ForeignKeyPrincipals)
			{
				bool flag3 = false;
				bool flag4 = false;
				global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEndInternal = this.RelationshipManager.GetRelatedEndInternal(tuple2.Item1.ElementType.FullName, tuple2.Item2.ToRole.Name);
				foreach (global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper entityWrapper in relatedEndInternal.GetWrappedEntities())
				{
					global::System.Data.Entity.Core.Objects.EntityEntry objectStateEntry2 = entityWrapper.ObjectStateEntry;
					if (objectStateEntry2.State != global::System.Data.Entity.EntityState.Added && !flag4)
					{
						flag4 = true;
						foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty in tuple2.Item2.ToProperties)
						{
							int ordinalforOLayerMemberName = objectStateEntry2._cacheTypeMetadata.GetOrdinalforOLayerMemberName(edmProperty.Name);
							if (objectStateEntry2._cacheTypeMetadata.Member(ordinalforOLayerMemberName).IsPartOfKey)
							{
								flag3 = true;
								break;
							}
						}
					}
					if (objectStateEntry2.State == global::System.Data.Entity.EntityState.Added || (objectStateEntry2.State == global::System.Data.Entity.EntityState.Modified && !flag3))
					{
						(relatedEndInternal.GetOtherEndOfRelationship(entityWrapper) as global::System.Data.Entity.Core.Objects.DataClasses.EntityReference).UpdateForeignKeyValues(entityWrapper, this.WrappedEntity, null, false);
					}
				}
			}
		}

		// Token: 0x060030B2 RID: 12466 RVA: 0x0009B3FC File Offset: 0x000995FC
		private bool IsPropertyAForeignKey(string propertyName)
		{
			foreach (global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint> tuple in this.ForeignKeyDependents)
			{
				using (global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>.Enumerator enumerator2 = tuple.Item2.ToProperties.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						if (enumerator2.Current.Name == propertyName)
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x060030B3 RID: 12467 RVA: 0x0009B494 File Offset: 0x00099694
		private bool IsPropertyAForeignKey(string propertyName, out global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Utils.Pair<string, string>> relationships)
		{
			relationships = null;
			foreach (global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint> tuple in this.ForeignKeyDependents)
			{
				using (global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>.Enumerator enumerator2 = tuple.Item2.ToProperties.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						if (enumerator2.Current.Name == propertyName)
						{
							if (relationships == null)
							{
								relationships = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Utils.Pair<string, string>>();
							}
							relationships.Add(new global::System.Data.Entity.Core.Common.Utils.Pair<string, string>(tuple.Item1.ElementType.FullName, tuple.Item2.FromRole.Name));
							break;
						}
					}
				}
			}
			return relationships != null;
		}

		// Token: 0x060030B4 RID: 12468 RVA: 0x0009B570 File Offset: 0x00099770
		internal void FindRelatedEntityKeysByForeignKeys(out global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.EntityKey>> relatedEntities, bool useOriginalValues)
		{
			relatedEntities = null;
			foreach (global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint> tuple in this.ForeignKeyDependents)
			{
				global::System.Data.Entity.Core.Metadata.Edm.AssociationSet item = tuple.Item1;
				global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint item2 = tuple.Item2;
				string identity = item2.ToRole.Identity;
				global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd> associationSetEnds = item.AssociationSetEnds;
				global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember correspondingAssociationEndMember;
				if (associationSetEnds[0].CorrespondingAssociationEndMember.Identity == identity)
				{
					correspondingAssociationEndMember = associationSetEnds[1].CorrespondingAssociationEndMember;
				}
				else
				{
					correspondingAssociationEndMember = associationSetEnds[0].CorrespondingAssociationEndMember;
				}
				global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySetAtEnd = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetEntitySetAtEnd(item, correspondingAssociationEndMember);
				global::System.Data.Entity.Core.EntityKey entityKey = global::System.Data.Entity.Core.Objects.Internal.ForeignKeyFactory.CreateKeyFromForeignKeyValues(this, item2, entitySetAtEnd, useOriginalValues);
				if (entityKey != null)
				{
					global::System.Data.Entity.Core.Objects.DataClasses.EntityReference key = this.RelationshipManager.GetRelatedEndInternal(item.ElementType, (global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember)item2.FromRole) as global::System.Data.Entity.Core.Objects.DataClasses.EntityReference;
					relatedEntities = ((relatedEntities != null) ? relatedEntities : new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.EntityKey>>());
					global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.EntityKey> hashSet;
					if (!relatedEntities.TryGetValue(key, out hashSet))
					{
						hashSet = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.EntityKey>();
						relatedEntities.Add(key, hashSet);
					}
					hashSet.Add(entityKey);
				}
			}
		}

		// Token: 0x060030B5 RID: 12469 RVA: 0x0009B694 File Offset: 0x00099894
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Objects.DataClasses.EntityReference> FindFKRelatedEnds()
		{
			global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Objects.DataClasses.EntityReference> hashSet = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Objects.DataClasses.EntityReference>();
			foreach (global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint> tuple in this.ForeignKeyDependents)
			{
				global::System.Data.Entity.Core.Objects.DataClasses.EntityReference item = this.RelationshipManager.GetRelatedEndInternal(tuple.Item1.ElementType.FullName, tuple.Item2.FromRole.Name) as global::System.Data.Entity.Core.Objects.DataClasses.EntityReference;
				hashSet.Add(item);
			}
			return hashSet;
		}

		// Token: 0x060030B6 RID: 12470 RVA: 0x0009B71C File Offset: 0x0009991C
		internal void DetectChangesInForeignKeys()
		{
			global::System.Data.Entity.Core.Objects.Internal.TransactionManager transactionManager = base.ObjectStateManager.TransactionManager;
			foreach (global::System.Data.Entity.Core.Objects.DataClasses.EntityReference entityReference in this.FindFKRelatedEnds())
			{
				global::System.Data.Entity.Core.EntityKey entityKey = global::System.Data.Entity.Core.Objects.Internal.ForeignKeyFactory.CreateKeyFromForeignKeyValues(this, entityReference);
				global::System.Data.Entity.Core.EntityKey cachedForeignKey = entityReference.CachedForeignKey;
				bool flag = global::System.Data.Entity.Core.Objects.Internal.ForeignKeyFactory.IsConceptualNullKey(cachedForeignKey);
				if (cachedForeignKey != null || entityKey != null)
				{
					if (cachedForeignKey == null)
					{
						global::System.Data.Entity.Core.Objects.EntityEntry relatedEntry;
						base.ObjectStateManager.TryGetEntityEntry(entityKey, out relatedEntry);
						this.AddRelationshipDetectedByForeignKey(transactionManager.AddedRelationshipsByForeignKey, transactionManager.AddedRelationshipsByPrincipalKey, entityKey, relatedEntry, entityReference);
					}
					else if (entityKey == null)
					{
						global::System.Data.Entity.Core.Objects.EntityEntry.AddDetectedRelationship<global::System.Data.Entity.Core.EntityKey>(transactionManager.DeletedRelationshipsByForeignKey, cachedForeignKey, entityReference);
					}
					else if (!entityKey.Equals(cachedForeignKey) && (!flag || global::System.Data.Entity.Core.Objects.Internal.ForeignKeyFactory.IsConceptualNullKeyChanged(cachedForeignKey, entityKey)))
					{
						global::System.Data.Entity.Core.Objects.EntityEntry relatedEntry2;
						base.ObjectStateManager.TryGetEntityEntry(entityKey, out relatedEntry2);
						this.AddRelationshipDetectedByForeignKey(transactionManager.AddedRelationshipsByForeignKey, transactionManager.AddedRelationshipsByPrincipalKey, entityKey, relatedEntry2, entityReference);
						if (!flag)
						{
							global::System.Data.Entity.Core.Objects.EntityEntry.AddDetectedRelationship<global::System.Data.Entity.Core.EntityKey>(transactionManager.DeletedRelationshipsByForeignKey, cachedForeignKey, entityReference);
						}
					}
				}
			}
		}

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x060030B7 RID: 12471 RVA: 0x0009B83C File Offset: 0x00099A3C
		internal bool RequiresComplexChangeTracking
		{
			get
			{
				return this._requiresComplexChangeTracking;
			}
		}

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x060030B8 RID: 12472 RVA: 0x0009B844 File Offset: 0x00099A44
		internal bool RequiresScalarChangeTracking
		{
			get
			{
				return this._requiresScalarChangeTracking;
			}
		}

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x060030B9 RID: 12473 RVA: 0x0009B84C File Offset: 0x00099A4C
		internal bool RequiresAnyChangeTracking
		{
			get
			{
				return this._requiresAnyChangeTracking;
			}
		}

		// Token: 0x04001024 RID: 4132
		private global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata _cacheTypeMetadata;

		// Token: 0x04001025 RID: 4133
		private global::System.Data.Entity.Core.EntityKey _entityKey;

		// Token: 0x04001026 RID: 4134
		private global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper _wrappedEntity;

		// Token: 0x04001027 RID: 4135
		private global::System.Collections.BitArray _modifiedFields;

		// Token: 0x04001028 RID: 4136
		private global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.StateManagerValue> _originalValues;

		// Token: 0x04001029 RID: 4137
		private global::System.Collections.Generic.Dictionary<object, global::System.Collections.Generic.Dictionary<int, object>> _originalComplexObjects;

		// Token: 0x0400102A RID: 4138
		private bool _requiresComplexChangeTracking;

		// Token: 0x0400102B RID: 4139
		private bool _requiresScalarChangeTracking;

		// Token: 0x0400102C RID: 4140
		private bool _requiresAnyChangeTracking;

		// Token: 0x0400102D RID: 4141
		private global::System.Data.Entity.Core.Objects.RelationshipEntry _headRelationshipEnds;

		// Token: 0x0400102E RID: 4142
		private int _countRelationshipEnds;

		// Token: 0x0400102F RID: 4143
		internal const int s_EntityRoot = -1;

		// Token: 0x02000A0F RID: 2575
		internal struct RelationshipEndEnumerable : global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Objects.RelationshipEntry>, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.IEntityStateEntry>
		{
			// Token: 0x060060E2 RID: 24802 RVA: 0x0014C083 File Offset: 0x0014A283
			internal RelationshipEndEnumerable(global::System.Data.Entity.Core.Objects.EntityEntry entityEntry)
			{
				this._entityEntry = entityEntry;
			}

			// Token: 0x060060E3 RID: 24803 RVA: 0x0014C08C File Offset: 0x0014A28C
			public global::System.Data.Entity.Core.Objects.EntityEntry.RelationshipEndEnumerator GetEnumerator()
			{
				return new global::System.Data.Entity.Core.Objects.EntityEntry.RelationshipEndEnumerator(this._entityEntry);
			}

			// Token: 0x060060E4 RID: 24804 RVA: 0x0014C099 File Offset: 0x0014A299
			global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.IEntityStateEntry> global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.IEntityStateEntry>.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x060060E5 RID: 24805 RVA: 0x0014C0A6 File Offset: 0x0014A2A6
			global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Objects.RelationshipEntry> global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Objects.RelationshipEntry>.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x060060E6 RID: 24806 RVA: 0x0014C0B3 File Offset: 0x0014A2B3
			global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x060060E7 RID: 24807 RVA: 0x0014C0C0 File Offset: 0x0014A2C0
			internal global::System.Data.Entity.Core.Objects.RelationshipEntry[] ToArray()
			{
				global::System.Data.Entity.Core.Objects.RelationshipEntry[] array = null;
				if (this._entityEntry != null && 0 < this._entityEntry._countRelationshipEnds)
				{
					global::System.Data.Entity.Core.Objects.RelationshipEntry relationshipEntry = this._entityEntry._headRelationshipEnds;
					array = new global::System.Data.Entity.Core.Objects.RelationshipEntry[this._entityEntry._countRelationshipEnds];
					for (int i = 0; i < array.Length; i++)
					{
						array[i] = relationshipEntry;
						relationshipEntry = relationshipEntry.GetNextRelationshipEnd(this._entityEntry.EntityKey);
					}
				}
				return array ?? global::System.Data.Entity.Core.Objects.EntityEntry.RelationshipEndEnumerable.EmptyRelationshipEntryArray;
			}

			// Token: 0x0400292C RID: 10540
			internal static readonly global::System.Data.Entity.Core.Objects.RelationshipEntry[] EmptyRelationshipEntryArray = new global::System.Data.Entity.Core.Objects.RelationshipEntry[0];

			// Token: 0x0400292D RID: 10541
			private readonly global::System.Data.Entity.Core.Objects.EntityEntry _entityEntry;
		}

		// Token: 0x02000A10 RID: 2576
		internal struct RelationshipEndEnumerator : global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Objects.RelationshipEntry>, global::System.IDisposable, global::System.Collections.IEnumerator, global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.IEntityStateEntry>
		{
			// Token: 0x060060E9 RID: 24809 RVA: 0x0014C13D File Offset: 0x0014A33D
			internal RelationshipEndEnumerator(global::System.Data.Entity.Core.Objects.EntityEntry entityEntry)
			{
				this._entityEntry = entityEntry;
				this._current = null;
			}

			// Token: 0x170010AD RID: 4269
			// (get) Token: 0x060060EA RID: 24810 RVA: 0x0014C14D File Offset: 0x0014A34D
			public global::System.Data.Entity.Core.Objects.RelationshipEntry Current
			{
				get
				{
					return this._current;
				}
			}

			// Token: 0x170010AE RID: 4270
			// (get) Token: 0x060060EB RID: 24811 RVA: 0x0014C155 File Offset: 0x0014A355
			global::System.Data.Entity.Core.IEntityStateEntry global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.IEntityStateEntry>.Current
			{
				get
				{
					return this._current;
				}
			}

			// Token: 0x170010AF RID: 4271
			// (get) Token: 0x060060EC RID: 24812 RVA: 0x0014C15D File Offset: 0x0014A35D
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return this._current;
				}
			}

			// Token: 0x060060ED RID: 24813 RVA: 0x0014C165 File Offset: 0x0014A365
			public void Dispose()
			{
			}

			// Token: 0x060060EE RID: 24814 RVA: 0x0014C168 File Offset: 0x0014A368
			public bool MoveNext()
			{
				if (this._entityEntry != null)
				{
					if (this._current == null)
					{
						this._current = this._entityEntry._headRelationshipEnds;
					}
					else
					{
						this._current = this._current.GetNextRelationshipEnd(this._entityEntry.EntityKey);
					}
				}
				return this._current != null;
			}

			// Token: 0x060060EF RID: 24815 RVA: 0x0014C1BD File Offset: 0x0014A3BD
			public void Reset()
			{
			}

			// Token: 0x0400292E RID: 10542
			private readonly global::System.Data.Entity.Core.Objects.EntityEntry _entityEntry;

			// Token: 0x0400292F RID: 10543
			private global::System.Data.Entity.Core.Objects.RelationshipEntry _current;
		}

		// Token: 0x02000A11 RID: 2577
		private enum UpdateRecordBehavior
		{
			// Token: 0x04002931 RID: 10545
			WithoutSetModified,
			// Token: 0x04002932 RID: 10546
			WithSetModified
		}
	}
}
