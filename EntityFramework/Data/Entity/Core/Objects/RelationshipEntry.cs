using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity.Core.Objects.Internal;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Diagnostics;

namespace System.Data.Entity.Core.Objects
{
	// Token: 0x0200042E RID: 1070
	internal sealed class RelationshipEntry : global::System.Data.Entity.Core.Objects.ObjectStateEntry
	{
		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x06003405 RID: 13317 RVA: 0x000A729B File Offset: 0x000A549B
		internal global::System.Data.Entity.Core.EntityKey Key0
		{
			get
			{
				return this.RelationshipWrapper.Key0;
			}
		}

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x06003406 RID: 13318 RVA: 0x000A72A8 File Offset: 0x000A54A8
		internal global::System.Data.Entity.Core.EntityKey Key1
		{
			get
			{
				return this.RelationshipWrapper.Key1;
			}
		}

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x06003407 RID: 13319 RVA: 0x000A72B5 File Offset: 0x000A54B5
		internal override global::System.Collections.BitArray ModifiedProperties
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06003408 RID: 13320 RVA: 0x000A72B8 File Offset: 0x000A54B8
		internal RelationshipEntry(global::System.Data.Entity.Core.Objects.ObjectStateManager cache, global::System.Data.Entity.EntityState state, global::System.Data.Entity.Core.Objects.RelationshipWrapper relationshipWrapper) : base(cache, null, state)
		{
			this._entitySet = relationshipWrapper.AssociationSet;
			this._relationshipWrapper = relationshipWrapper;
		}

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x06003409 RID: 13321 RVA: 0x000A72D6 File Offset: 0x000A54D6
		public override bool IsRelationship
		{
			get
			{
				base.ValidateState();
				return true;
			}
		}

		// Token: 0x0600340A RID: 13322 RVA: 0x000A72E0 File Offset: 0x000A54E0
		public override void AcceptChanges()
		{
			base.ValidateState();
			global::System.Data.Entity.EntityState state = base.State;
			if (state <= global::System.Data.Entity.EntityState.Added)
			{
				if (state != global::System.Data.Entity.EntityState.Unchanged)
				{
					if (state != global::System.Data.Entity.EntityState.Added)
					{
						return;
					}
					this._cache.ChangeState(this, global::System.Data.Entity.EntityState.Added, global::System.Data.Entity.EntityState.Unchanged);
					base.State = global::System.Data.Entity.EntityState.Unchanged;
				}
			}
			else
			{
				if (state != global::System.Data.Entity.EntityState.Deleted)
				{
					return;
				}
				this.DeleteUnnecessaryKeyEntries();
				if (this._cache != null)
				{
					this._cache.ChangeState(this, global::System.Data.Entity.EntityState.Deleted, global::System.Data.Entity.EntityState.Detached);
					return;
				}
			}
		}

		// Token: 0x0600340B RID: 13323 RVA: 0x000A7343 File Offset: 0x000A5543
		public override void Delete()
		{
			this.Delete(true);
		}

		// Token: 0x0600340C RID: 13324 RVA: 0x000A734C File Offset: 0x000A554C
		public override global::System.Collections.Generic.IEnumerable<string> GetModifiedProperties()
		{
			base.ValidateState();
			yield break;
		}

		// Token: 0x0600340D RID: 13325 RVA: 0x000A735C File Offset: 0x000A555C
		public override void SetModified()
		{
			base.ValidateState();
			throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_CantModifyRelationState);
		}

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x0600340E RID: 13326 RVA: 0x000A736E File Offset: 0x000A556E
		public override object Entity
		{
			get
			{
				base.ValidateState();
				return null;
			}
		}

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x0600340F RID: 13327 RVA: 0x000A7377 File Offset: 0x000A5577
		// (set) Token: 0x06003410 RID: 13328 RVA: 0x000A7380 File Offset: 0x000A5580
		public override global::System.Data.Entity.Core.EntityKey EntityKey
		{
			get
			{
				base.ValidateState();
				return null;
			}
			internal set
			{
			}
		}

		// Token: 0x06003411 RID: 13329 RVA: 0x000A7382 File Offset: 0x000A5582
		public override void SetModifiedProperty(string propertyName)
		{
			base.ValidateState();
			throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_CantModifyRelationState);
		}

		// Token: 0x06003412 RID: 13330 RVA: 0x000A7394 File Offset: 0x000A5594
		public override void RejectPropertyChanges(string propertyName)
		{
			base.ValidateState();
			throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_CantModifyRelationState);
		}

		// Token: 0x06003413 RID: 13331 RVA: 0x000A73A6 File Offset: 0x000A55A6
		public override bool IsPropertyChanged(string propertyName)
		{
			base.ValidateState();
			throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_CantModifyRelationState);
		}

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x06003414 RID: 13332 RVA: 0x000A73B8 File Offset: 0x000A55B8
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		public override global::System.Data.Common.DbDataRecord OriginalValues
		{
			get
			{
				base.ValidateState();
				if (base.State == global::System.Data.Entity.EntityState.Added)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_OriginalValuesDoesNotExist);
				}
				return new global::System.Data.Entity.Core.Objects.ObjectStateEntryDbDataRecord(this);
			}
		}

		// Token: 0x06003415 RID: 13333 RVA: 0x000A73DA File Offset: 0x000A55DA
		public override global::System.Data.Entity.Core.Objects.OriginalValueRecord GetUpdatableOriginalValues()
		{
			throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_CantModifyRelationValues);
		}

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x06003416 RID: 13334 RVA: 0x000A73E6 File Offset: 0x000A55E6
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
				return new global::System.Data.Entity.Core.Objects.ObjectStateEntryDbUpdatableDataRecord(this);
			}
		}

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x06003417 RID: 13335 RVA: 0x000A7408 File Offset: 0x000A5608
		public override global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager RelationshipManager
		{
			get
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_RelationshipAndKeyEntriesDoNotHaveRelationshipManagers);
			}
		}

		// Token: 0x06003418 RID: 13336 RVA: 0x000A7414 File Offset: 0x000A5614
		public override void ChangeState(global::System.Data.Entity.EntityState state)
		{
			global::System.Data.Entity.Core.EntityUtil.CheckValidStateForChangeRelationshipState(state, "state");
			if (base.State == global::System.Data.Entity.EntityState.Detached && state == global::System.Data.Entity.EntityState.Detached)
			{
				return;
			}
			base.ValidateState();
			if (this.RelationshipWrapper.Key0 == this.Key0)
			{
				base.ObjectStateManager.ChangeRelationshipState(this.Key0, this.Key1, this.RelationshipWrapper.AssociationSet.ElementType.FullName, this.RelationshipWrapper.AssociationEndMembers[1].Name, state);
				return;
			}
			base.ObjectStateManager.ChangeRelationshipState(this.Key0, this.Key1, this.RelationshipWrapper.AssociationSet.ElementType.FullName, this.RelationshipWrapper.AssociationEndMembers[0].Name, state);
		}

		// Token: 0x06003419 RID: 13337 RVA: 0x000A74E1 File Offset: 0x000A56E1
		public override void ApplyCurrentValues(object currentEntity)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<object>(currentEntity, "currentEntity");
			throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_CantModifyRelationValues);
		}

		// Token: 0x0600341A RID: 13338 RVA: 0x000A74F9 File Offset: 0x000A56F9
		public override void ApplyOriginalValues(object originalEntity)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<object>(originalEntity, "originalEntity");
			throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_CantModifyRelationValues);
		}

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x0600341B RID: 13339 RVA: 0x000A7511 File Offset: 0x000A5711
		internal override bool IsKeyEntry
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600341C RID: 13340 RVA: 0x000A7514 File Offset: 0x000A5714
		internal override int GetFieldCount(global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata metadata)
		{
			return this._relationshipWrapper.AssociationEndMembers.Count;
		}

		// Token: 0x0600341D RID: 13341 RVA: 0x000A7526 File Offset: 0x000A5726
		internal override global::System.Data.Entity.Core.Common.DataRecordInfo GetDataRecordInfo(global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata metadata, object userObject)
		{
			return new global::System.Data.Entity.Core.Common.DataRecordInfo(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(((global::System.Data.Entity.Core.Metadata.Edm.RelationshipSet)base.EntitySet).ElementType));
		}

		// Token: 0x0600341E RID: 13342 RVA: 0x000A7542 File Offset: 0x000A5742
		internal override void SetModifiedAll()
		{
			base.ValidateState();
			throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_CantModifyRelationState);
		}

		// Token: 0x0600341F RID: 13343 RVA: 0x000A7554 File Offset: 0x000A5754
		internal override global::System.Type GetFieldType(int ordinal, global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata metadata)
		{
			return typeof(global::System.Data.Entity.Core.EntityKey);
		}

		// Token: 0x06003420 RID: 13344 RVA: 0x000A7560 File Offset: 0x000A5760
		internal override string GetCLayerName(int ordinal, global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata metadata)
		{
			global::System.Data.Entity.Core.Objects.RelationshipEntry.ValidateRelationshipRange(ordinal);
			return this._relationshipWrapper.AssociationEndMembers[ordinal].Name;
		}

		// Token: 0x06003421 RID: 13345 RVA: 0x000A7580 File Offset: 0x000A5780
		internal override int GetOrdinalforCLayerName(string name, global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata metadata)
		{
			global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember> associationEndMembers = this._relationshipWrapper.AssociationEndMembers;
			global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember value;
			if (associationEndMembers.TryGetValue(name, false, out value))
			{
				return associationEndMembers.IndexOf(value);
			}
			return -1;
		}

		// Token: 0x06003422 RID: 13346 RVA: 0x000A75AE File Offset: 0x000A57AE
		internal override void RevertDelete()
		{
			base.State = global::System.Data.Entity.EntityState.Unchanged;
			this._cache.ChangeState(this, global::System.Data.Entity.EntityState.Deleted, base.State);
		}

		// Token: 0x06003423 RID: 13347 RVA: 0x000A75CA File Offset: 0x000A57CA
		internal override void EntityMemberChanging(string entityMemberName)
		{
			throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_CantModifyRelationValues);
		}

		// Token: 0x06003424 RID: 13348 RVA: 0x000A75D6 File Offset: 0x000A57D6
		internal override void EntityMemberChanged(string entityMemberName)
		{
			throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_CantModifyRelationValues);
		}

		// Token: 0x06003425 RID: 13349 RVA: 0x000A75E2 File Offset: 0x000A57E2
		internal override void EntityComplexMemberChanging(string entityMemberName, object complexObject, string complexObjectMemberName)
		{
			throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_CantModifyRelationValues);
		}

		// Token: 0x06003426 RID: 13350 RVA: 0x000A75EE File Offset: 0x000A57EE
		internal override void EntityComplexMemberChanged(string entityMemberName, object complexObject, string complexObjectMemberName)
		{
			throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_CantModifyRelationValues);
		}

		// Token: 0x06003427 RID: 13351 RVA: 0x000A75FC File Offset: 0x000A57FC
		internal bool IsSameAssociationSetAndRole(global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationMember, global::System.Data.Entity.Core.EntityKey entityKey)
		{
			if (this._entitySet != associationSet)
			{
				return false;
			}
			if (this._relationshipWrapper.AssociationSet.ElementType.AssociationEndMembers[0].Name == associationMember.Name)
			{
				return entityKey == this.Key0;
			}
			return entityKey == this.Key1;
		}

		// Token: 0x06003428 RID: 13352 RVA: 0x000A765A File Offset: 0x000A585A
		private object GetCurrentRelationValue(int ordinal, bool throwException)
		{
			global::System.Data.Entity.Core.Objects.RelationshipEntry.ValidateRelationshipRange(ordinal);
			base.ValidateState();
			if (base.State == global::System.Data.Entity.EntityState.Deleted && throwException)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_CurrentValuesDoesNotExist);
			}
			return this._relationshipWrapper.GetEntityKey(ordinal);
		}

		// Token: 0x06003429 RID: 13353 RVA: 0x000A768C File Offset: 0x000A588C
		private static void ValidateRelationshipRange(int ordinal)
		{
			if (1 < ordinal)
			{
				throw new global::System.ArgumentOutOfRangeException("ordinal");
			}
		}

		// Token: 0x0600342A RID: 13354 RVA: 0x000A769D File Offset: 0x000A589D
		internal object GetCurrentRelationValue(int ordinal)
		{
			return this.GetCurrentRelationValue(ordinal, true);
		}

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x0600342B RID: 13355 RVA: 0x000A76A7 File Offset: 0x000A58A7
		// (set) Token: 0x0600342C RID: 13356 RVA: 0x000A76AF File Offset: 0x000A58AF
		internal global::System.Data.Entity.Core.Objects.RelationshipWrapper RelationshipWrapper
		{
			get
			{
				return this._relationshipWrapper;
			}
			set
			{
				this._relationshipWrapper = value;
			}
		}

		// Token: 0x0600342D RID: 13357 RVA: 0x000A76B8 File Offset: 0x000A58B8
		internal override void Reset()
		{
			this._relationshipWrapper = null;
			base.Reset();
		}

		// Token: 0x0600342E RID: 13358 RVA: 0x000A76C8 File Offset: 0x000A58C8
		internal void ChangeRelatedEnd(global::System.Data.Entity.Core.EntityKey oldKey, global::System.Data.Entity.Core.EntityKey newKey)
		{
			if (!oldKey.Equals(this.Key0))
			{
				this.RelationshipWrapper = new global::System.Data.Entity.Core.Objects.RelationshipWrapper(this.RelationshipWrapper, 1, newKey);
				return;
			}
			if (oldKey.Equals(this.Key1))
			{
				this.RelationshipWrapper = new global::System.Data.Entity.Core.Objects.RelationshipWrapper(this.RelationshipWrapper.AssociationSet, newKey);
				return;
			}
			this.RelationshipWrapper = new global::System.Data.Entity.Core.Objects.RelationshipWrapper(this.RelationshipWrapper, 0, newKey);
		}

		// Token: 0x0600342F RID: 13359 RVA: 0x000A7730 File Offset: 0x000A5930
		internal void DeleteUnnecessaryKeyEntries()
		{
			for (int i = 0; i < 2; i++)
			{
				global::System.Data.Entity.Core.EntityKey key = this.GetCurrentRelationValue(i, false) as global::System.Data.Entity.Core.EntityKey;
				global::System.Data.Entity.Core.Objects.EntityEntry entityEntry = this._cache.GetEntityEntry(key);
				if (entityEntry.IsKeyEntry)
				{
					bool flag = false;
					using (global::System.Data.Entity.Core.Objects.EntityEntry.RelationshipEndEnumerator enumerator = this._cache.FindRelationshipsByKey(key).GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							if (enumerator.Current != this)
							{
								flag = true;
								break;
							}
						}
					}
					if (!flag)
					{
						this._cache.DeleteKeyEntry(entityEntry);
						return;
					}
				}
			}
		}

		// Token: 0x06003430 RID: 13360 RVA: 0x000A77D0 File Offset: 0x000A59D0
		internal void Delete(bool doFixup)
		{
			base.ValidateState();
			if (doFixup)
			{
				if (base.State != global::System.Data.Entity.EntityState.Deleted)
				{
					global::System.Data.Entity.Core.Objects.EntityEntry entityEntry = this._cache.GetEntityEntry((global::System.Data.Entity.Core.EntityKey)this.GetCurrentRelationValue(0));
					global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity = entityEntry.WrappedEntity;
					global::System.Data.Entity.Core.Objects.EntityEntry entityEntry2 = this._cache.GetEntityEntry((global::System.Data.Entity.Core.EntityKey)this.GetCurrentRelationValue(1));
					global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity2 = entityEntry2.WrappedEntity;
					if (wrappedEntity.Entity != null && wrappedEntity2.Entity != null)
					{
						string name = this._relationshipWrapper.AssociationEndMembers[1].Name;
						string fullName = ((global::System.Data.Entity.Core.Metadata.Edm.AssociationSet)this._entitySet).ElementType.FullName;
						wrappedEntity.RelationshipManager.RemoveEntity(name, fullName, wrappedEntity2);
						return;
					}
					global::System.Data.Entity.Core.EntityKey entityKey;
					global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager relationshipManager;
					if (wrappedEntity.Entity == null)
					{
						entityKey = entityEntry.EntityKey;
						relationshipManager = wrappedEntity2.RelationshipManager;
					}
					else
					{
						entityKey = entityEntry2.EntityKey;
						relationshipManager = wrappedEntity.RelationshipManager;
					}
					global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember = this.RelationshipWrapper.GetAssociationEndMember(entityKey);
					((global::System.Data.Entity.Core.Objects.DataClasses.EntityReference)relationshipManager.GetRelatedEndInternal(associationEndMember.DeclaringType.FullName, associationEndMember.Name)).DetachedEntityKey = null;
					if (base.State == global::System.Data.Entity.EntityState.Added)
					{
						this.DeleteUnnecessaryKeyEntries();
						this.DetachRelationshipEntry();
						return;
					}
					this._cache.ChangeState(this, base.State, global::System.Data.Entity.EntityState.Deleted);
					base.State = global::System.Data.Entity.EntityState.Deleted;
					return;
				}
			}
			else
			{
				global::System.Data.Entity.EntityState state = base.State;
				if (state != global::System.Data.Entity.EntityState.Unchanged)
				{
					if (state != global::System.Data.Entity.EntityState.Added)
					{
						return;
					}
					this.DeleteUnnecessaryKeyEntries();
					this.DetachRelationshipEntry();
					return;
				}
				else
				{
					this._cache.ChangeState(this, global::System.Data.Entity.EntityState.Unchanged, global::System.Data.Entity.EntityState.Deleted);
					base.State = global::System.Data.Entity.EntityState.Deleted;
				}
			}
		}

		// Token: 0x06003431 RID: 13361 RVA: 0x000A7953 File Offset: 0x000A5B53
		internal object GetOriginalRelationValue(int ordinal)
		{
			return this.GetCurrentRelationValue(ordinal, false);
		}

		// Token: 0x06003432 RID: 13362 RVA: 0x000A795D File Offset: 0x000A5B5D
		internal void DetachRelationshipEntry()
		{
			if (this._cache != null)
			{
				this._cache.ChangeState(this, base.State, global::System.Data.Entity.EntityState.Detached);
			}
		}

		// Token: 0x06003433 RID: 13363 RVA: 0x000A797C File Offset: 0x000A5B7C
		internal void ChangeRelationshipState(global::System.Data.Entity.Core.Objects.EntityEntry targetEntry, global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd, global::System.Data.Entity.EntityState requestedState)
		{
			global::System.Data.Entity.EntityState state = base.State;
			if (state != global::System.Data.Entity.EntityState.Unchanged)
			{
				if (state != global::System.Data.Entity.EntityState.Added)
				{
					if (state != global::System.Data.Entity.EntityState.Deleted)
					{
						return;
					}
					switch (requestedState)
					{
					case global::System.Data.Entity.EntityState.Detached:
						this.AcceptChanges();
						break;
					case global::System.Data.Entity.EntityState.Unchanged:
						relatedEnd.Add(targetEntry.WrappedEntity, true, false, true, false, true);
						base.ObjectStateManager.ChangeState(this, global::System.Data.Entity.EntityState.Deleted, global::System.Data.Entity.EntityState.Unchanged);
						base.State = global::System.Data.Entity.EntityState.Unchanged;
						return;
					case global::System.Data.Entity.EntityState.Detached | global::System.Data.Entity.EntityState.Unchanged:
						break;
					case global::System.Data.Entity.EntityState.Added:
						relatedEnd.Add(targetEntry.WrappedEntity, true, false, true, false, true);
						base.ObjectStateManager.ChangeState(this, global::System.Data.Entity.EntityState.Deleted, global::System.Data.Entity.EntityState.Added);
						base.State = global::System.Data.Entity.EntityState.Added;
						return;
					default:
						return;
					}
				}
				else
				{
					switch (requestedState)
					{
					case global::System.Data.Entity.EntityState.Detached:
						this.Delete();
						return;
					case global::System.Data.Entity.EntityState.Unchanged:
						this.AcceptChanges();
						return;
					case global::System.Data.Entity.EntityState.Detached | global::System.Data.Entity.EntityState.Unchanged:
					case global::System.Data.Entity.EntityState.Added:
						break;
					default:
						if (requestedState != global::System.Data.Entity.EntityState.Deleted)
						{
							return;
						}
						this.AcceptChanges();
						this.Delete();
						return;
					}
				}
			}
			else
			{
				switch (requestedState)
				{
				case global::System.Data.Entity.EntityState.Detached:
					this.Delete();
					this.AcceptChanges();
					return;
				case global::System.Data.Entity.EntityState.Unchanged:
				case global::System.Data.Entity.EntityState.Detached | global::System.Data.Entity.EntityState.Unchanged:
					break;
				case global::System.Data.Entity.EntityState.Added:
					base.ObjectStateManager.ChangeState(this, global::System.Data.Entity.EntityState.Unchanged, global::System.Data.Entity.EntityState.Added);
					base.State = global::System.Data.Entity.EntityState.Added;
					return;
				default:
					if (requestedState != global::System.Data.Entity.EntityState.Deleted)
					{
						return;
					}
					this.Delete();
					return;
				}
			}
		}

		// Token: 0x06003434 RID: 13364 RVA: 0x000A7A90 File Offset: 0x000A5C90
		internal global::System.Data.Entity.Core.Objects.RelationshipEntry GetNextRelationshipEnd(global::System.Data.Entity.Core.EntityKey entityKey)
		{
			if (!entityKey.Equals(this.Key0))
			{
				return this.NextKey1;
			}
			return this.NextKey0;
		}

		// Token: 0x06003435 RID: 13365 RVA: 0x000A7AAD File Offset: 0x000A5CAD
		internal void SetNextRelationshipEnd(global::System.Data.Entity.Core.EntityKey entityKey, global::System.Data.Entity.Core.Objects.RelationshipEntry nextEnd)
		{
			if (entityKey.Equals(this.Key0))
			{
				this.NextKey0 = nextEnd;
				return;
			}
			this.NextKey1 = nextEnd;
		}

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x06003436 RID: 13366 RVA: 0x000A7ACC File Offset: 0x000A5CCC
		// (set) Token: 0x06003437 RID: 13367 RVA: 0x000A7AD4 File Offset: 0x000A5CD4
		internal global::System.Data.Entity.Core.Objects.RelationshipEntry NextKey0 { get; set; }

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x06003438 RID: 13368 RVA: 0x000A7ADD File Offset: 0x000A5CDD
		// (set) Token: 0x06003439 RID: 13369 RVA: 0x000A7AE5 File Offset: 0x000A5CE5
		internal global::System.Data.Entity.Core.Objects.RelationshipEntry NextKey1 { get; set; }

		// Token: 0x040010D4 RID: 4308
		internal global::System.Data.Entity.Core.Objects.RelationshipWrapper _relationshipWrapper;
	}
}
