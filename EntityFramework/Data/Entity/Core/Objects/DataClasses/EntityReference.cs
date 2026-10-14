using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects.Internal;
using System.Data.Entity.Resources;
using System.Linq;
using System.Runtime.Serialization;

namespace System.Data.Entity.Core.Objects.DataClasses
{
	// Token: 0x02000478 RID: 1144
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public abstract class EntityReference : global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd
	{
		// Token: 0x0600380D RID: 14349 RVA: 0x000B6783 File Offset: 0x000B4983
		internal EntityReference()
		{
		}

		// Token: 0x0600380E RID: 14350 RVA: 0x000B678B File Offset: 0x000B498B
		internal EntityReference(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedOwner, global::System.Data.Entity.Core.Objects.DataClasses.RelationshipNavigation navigation, global::System.Data.Entity.Core.Objects.DataClasses.IRelationshipFixer relationshipFixer) : base(wrappedOwner, navigation, relationshipFixer)
		{
		}

		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x0600380F RID: 14351 RVA: 0x000B6798 File Offset: 0x000B4998
		// (set) Token: 0x06003810 RID: 14352 RVA: 0x000B68D8 File Offset: 0x000B4AD8
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Data.Entity.Core.EntityKey EntityKey
		{
			get
			{
				if (this.ObjectContext != null && !base.UsingNoTracking)
				{
					global::System.Data.Entity.Core.EntityKey entityKey = null;
					if (this.CachedValue.Entity != null)
					{
						entityKey = this.CachedValue.EntityKey;
						if (entityKey != null && !global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd.IsValidEntityKeyType(entityKey))
						{
							entityKey = null;
						}
					}
					else if (base.IsForeignKey)
					{
						if (base.IsDependentEndOfReferentialConstraint(false) && this._cachedForeignKey != null)
						{
							if (!global::System.Data.Entity.Core.Objects.Internal.ForeignKeyFactory.IsConceptualNullKey(this._cachedForeignKey))
							{
								entityKey = this._cachedForeignKey;
							}
						}
						else
						{
							entityKey = this.DetachedEntityKey;
						}
					}
					else
					{
						global::System.Data.Entity.Core.EntityKey entityKey2 = this.WrappedOwner.EntityKey;
						foreach (global::System.Data.Entity.Core.Objects.RelationshipEntry relationshipEntry in this.ObjectContext.ObjectStateManager.FindRelationshipsByKey(entityKey2))
						{
							if (relationshipEntry.State != global::System.Data.Entity.EntityState.Deleted && relationshipEntry.IsSameAssociationSetAndRole((global::System.Data.Entity.Core.Metadata.Edm.AssociationSet)this.RelationshipSet, (global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember)this.FromEndMember, entityKey2))
							{
								entityKey = relationshipEntry.RelationshipWrapper.GetOtherEntityKey(entityKey2);
							}
						}
					}
					return entityKey;
				}
				return this.DetachedEntityKey;
			}
			set
			{
				this.SetEntityKey(value, false);
			}
		}

		// Token: 0x06003811 RID: 14353 RVA: 0x000B68E4 File Offset: 0x000B4AE4
		internal void SetEntityKey(global::System.Data.Entity.Core.EntityKey value, bool forceFixup)
		{
			if (value != null && value == this.EntityKey && (this.ReferenceValue.Entity != null || (this.ReferenceValue.Entity == null && !forceFixup)))
			{
				return;
			}
			if (this.ObjectContext != null && !base.UsingNoTracking)
			{
				if (value != null && !global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd.IsValidEntityKeyType(value))
				{
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.EntityReference_CannotSetSpecialKeys, "value");
				}
				if (value == null)
				{
					if (this.AttemptToNullFKsOnRefOrKeySetToNull())
					{
						this.DetachedEntityKey = null;
						return;
					}
					this.ReferenceValue = global::System.Data.Entity.Core.Objects.Internal.NullEntityWrapper.NullWrapper;
					return;
				}
				else
				{
					global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = value.GetEntitySet(this.ObjectContext.MetadataWorkspace);
					base.CheckRelationEntitySet(entitySet);
					value.ValidateEntityKey(this.ObjectContext.MetadataWorkspace, entitySet, true, "value");
					global::System.Data.Entity.Core.Objects.ObjectStateManager objectStateManager = this.ObjectContext.ObjectStateManager;
					bool flag = false;
					bool flag2 = false;
					global::System.Data.Entity.Core.Objects.EntityEntry entityEntry = objectStateManager.FindEntityEntry(value);
					if (entityEntry != null)
					{
						if (!entityEntry.IsKeyEntry)
						{
							this.ReferenceValue = entityEntry.WrappedEntity;
						}
						else
						{
							flag = true;
						}
					}
					else
					{
						flag2 = !base.IsForeignKey;
						flag = true;
					}
					if (flag)
					{
						global::System.Data.Entity.Core.EntityKey entityKey = this.ValidateOwnerWithRIConstraints((entityEntry == null) ? null : entityEntry.WrappedEntity, value, true);
						base.ValidateStateForAdd(this.WrappedOwner);
						if (flag2)
						{
							objectStateManager.AddKeyEntry(value, entitySet);
						}
						objectStateManager.TransactionManager.EntityBeingReparented = this.WrappedOwner.Entity;
						try
						{
							this.ClearCollectionOrRef(null, null, false);
						}
						finally
						{
							objectStateManager.TransactionManager.EntityBeingReparented = null;
						}
						if (!base.IsForeignKey)
						{
							global::System.Data.Entity.Core.Objects.RelationshipWrapper wrapper = new global::System.Data.Entity.Core.Objects.RelationshipWrapper((global::System.Data.Entity.Core.Metadata.Edm.AssociationSet)this.RelationshipSet, base.RelationshipNavigation.From, entityKey, base.RelationshipNavigation.To, value);
							global::System.Data.Entity.EntityState desiredState = global::System.Data.Entity.EntityState.Added;
							if (!entityKey.IsTemporary && base.IsDependentEndOfReferentialConstraint(false))
							{
								desiredState = global::System.Data.Entity.EntityState.Unchanged;
							}
							objectStateManager.AddNewRelation(wrapper, desiredState);
							return;
						}
						this.DetachedEntityKey = value;
						if (base.IsDependentEndOfReferentialConstraint(false))
						{
							this.UpdateForeignKeyValues(this.WrappedOwner, value);
							return;
						}
					}
				}
			}
			else
			{
				this.DetachedEntityKey = value;
			}
		}

		// Token: 0x06003812 RID: 14354 RVA: 0x000B6AE8 File Offset: 0x000B4CE8
		internal bool AttemptToNullFKsOnRefOrKeySetToNull()
		{
			if (this.ReferenceValue.Entity != null || this.WrappedOwner.Entity == null || this.WrappedOwner.Context == null || base.UsingNoTracking || !base.IsForeignKey)
			{
				return false;
			}
			if (this.WrappedOwner.ObjectStateEntry.State != global::System.Data.Entity.EntityState.Added && base.IsDependentEndOfReferentialConstraint(true))
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityReference_CannotChangeReferentialConstraintProperty);
			}
			this.RemoveFromLocalCache(global::System.Data.Entity.Core.Objects.Internal.NullEntityWrapper.NullWrapper, true, false);
			return true;
		}

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x06003813 RID: 14355 RVA: 0x000B6B64 File Offset: 0x000B4D64
		internal global::System.Data.Entity.Core.EntityKey AttachedEntityKey
		{
			get
			{
				return this.EntityKey;
			}
		}

		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x06003814 RID: 14356 RVA: 0x000B6B6C File Offset: 0x000B4D6C
		// (set) Token: 0x06003815 RID: 14357 RVA: 0x000B6B74 File Offset: 0x000B4D74
		internal global::System.Data.Entity.Core.EntityKey DetachedEntityKey
		{
			get
			{
				return this._detachedEntityKey;
			}
			set
			{
				this._detachedEntityKey = value;
			}
		}

		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x06003816 RID: 14358 RVA: 0x000B6B7D File Offset: 0x000B4D7D
		internal global::System.Data.Entity.Core.EntityKey CachedForeignKey
		{
			get
			{
				return this.EntityKey ?? this._cachedForeignKey;
			}
		}

		// Token: 0x06003817 RID: 14359 RVA: 0x000B6B90 File Offset: 0x000B4D90
		internal void SetCachedForeignKey(global::System.Data.Entity.Core.EntityKey newForeignKey, global::System.Data.Entity.Core.Objects.EntityEntry source)
		{
			if (this.ObjectContext != null && this.ObjectContext.ObjectStateManager != null && source != null && this._cachedForeignKey != null && !global::System.Data.Entity.Core.Objects.Internal.ForeignKeyFactory.IsConceptualNullKey(this._cachedForeignKey) && this._cachedForeignKey != newForeignKey)
			{
				this.ObjectContext.ObjectStateManager.RemoveEntryFromForeignKeyIndex(this, this._cachedForeignKey, source);
			}
			this._cachedForeignKey = newForeignKey;
		}

		// Token: 0x06003818 RID: 14360 RVA: 0x000B6BFD File Offset: 0x000B4DFD
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.EntityKey> GetAllKeyValues()
		{
			if (this.EntityKey != null)
			{
				yield return this.EntityKey;
			}
			if (this._cachedForeignKey != null)
			{
				yield return this._cachedForeignKey;
			}
			if (this._detachedEntityKey != null)
			{
				yield return this._detachedEntityKey;
			}
			yield break;
		}

		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x06003819 RID: 14361
		internal abstract global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper CachedValue { get; }

		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x0600381A RID: 14362
		// (set) Token: 0x0600381B RID: 14363
		internal abstract global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper ReferenceValue { get; set; }

		// Token: 0x0600381C RID: 14364 RVA: 0x000B6C10 File Offset: 0x000B4E10
		internal global::System.Data.Entity.Core.EntityKey ValidateOwnerWithRIConstraints(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper targetEntity, global::System.Data.Entity.Core.EntityKey targetEntityKey, bool checkBothEnds)
		{
			global::System.Data.Entity.Core.EntityKey entityKey = this.WrappedOwner.EntityKey;
			if (entityKey != null && !entityKey.IsTemporary && base.IsDependentEndOfReferentialConstraint(true))
			{
				this.ValidateSettingRIConstraints(targetEntity, targetEntityKey == null, this.CachedForeignKey != null && this.CachedForeignKey != targetEntityKey);
			}
			else if (checkBothEnds && targetEntity != null && targetEntity.Entity != null)
			{
				global::System.Data.Entity.Core.Objects.DataClasses.EntityReference entityReference = base.GetOtherEndOfRelationship(targetEntity) as global::System.Data.Entity.Core.Objects.DataClasses.EntityReference;
				if (entityReference != null)
				{
					entityReference.ValidateOwnerWithRIConstraints(this.WrappedOwner, entityKey, false);
				}
			}
			return entityKey;
		}

		// Token: 0x0600381D RID: 14365 RVA: 0x000B6C98 File Offset: 0x000B4E98
		internal void ValidateSettingRIConstraints(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper targetEntity, bool settingToNull, bool changingForeignKeyValue)
		{
			bool flag = targetEntity != null && targetEntity.MergeOption == global::System.Data.Entity.Core.Objects.MergeOption.NoTracking;
			if (settingToNull || changingForeignKeyValue || (targetEntity != null && !flag && (targetEntity.ObjectStateEntry == null || (this.EntityKey == null && targetEntity.ObjectStateEntry.State == global::System.Data.Entity.EntityState.Deleted) || (this.CachedForeignKey == null && targetEntity.ObjectStateEntry.State == global::System.Data.Entity.EntityState.Added))))
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityReference_CannotChangeReferentialConstraintProperty);
			}
		}

		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x0600381E RID: 14366 RVA: 0x000B6D0B File Offset: 0x000B4F0B
		internal override bool CanDeferredLoad
		{
			get
			{
				return this.IsEmpty();
			}
		}

		// Token: 0x0600381F RID: 14367 RVA: 0x000B6D14 File Offset: 0x000B4F14
		internal void UpdateForeignKeyValues(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper dependentEntity, global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper principalEntity, global::System.Collections.Generic.Dictionary<int, object> changedFKs, bool forceChange)
		{
			global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint referentialConstraint = ((global::System.Data.Entity.Core.Metadata.Edm.AssociationType)this.RelationMetadata).ReferentialConstraints[0];
			bool flag = this.WrappedOwner.EntityKey != null && !this.WrappedOwner.EntityKey.IsTemporary && base.IsDependentEndOfReferentialConstraint(true);
			global::System.Data.Entity.Core.Objects.ObjectStateManager objectStateManager = this.ObjectContext.ObjectStateManager;
			objectStateManager.TransactionManager.BeginForeignKeyUpdate(this);
			try
			{
				global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = ((global::System.Data.Entity.Core.Metadata.Edm.AssociationSet)this.RelationshipSet).AssociationSetEnds[this.ToEndMember.Name].EntitySet;
				global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata orAddStateManagerTypeMetadata = objectStateManager.GetOrAddStateManagerTypeMetadata(principalEntity.IdentityType, entitySet);
				global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet2 = ((global::System.Data.Entity.Core.Metadata.Edm.AssociationSet)this.RelationshipSet).AssociationSetEnds[this.FromEndMember.Name].EntitySet;
				global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata orAddStateManagerTypeMetadata2 = objectStateManager.GetOrAddStateManagerTypeMetadata(dependentEntity.IdentityType, entitySet2);
				global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> fromProperties = referentialConstraint.FromProperties;
				int count = fromProperties.Count;
				string[] array = null;
				object[] array2 = null;
				if (count > 1)
				{
					array = entitySet.ElementType.KeyMemberNames;
					array2 = new object[count];
				}
				for (int i = 0; i < count; i++)
				{
					int ordinalforOLayerMemberName = orAddStateManagerTypeMetadata.GetOrdinalforOLayerMemberName(fromProperties[i].Name);
					object value = orAddStateManagerTypeMetadata.Member(ordinalforOLayerMemberName).GetValue(principalEntity.Entity);
					int ordinalforOLayerMemberName2 = orAddStateManagerTypeMetadata2.GetOrdinalforOLayerMemberName(referentialConstraint.ToProperties[i].Name);
					bool flag2 = !global::System.Data.Entity.Core.Common.Utils.ByValueEqualityComparer.Default.Equals(orAddStateManagerTypeMetadata2.Member(ordinalforOLayerMemberName2).GetValue(dependentEntity.Entity), value);
					if (forceChange || flag2)
					{
						if (flag)
						{
							this.ValidateSettingRIConstraints(principalEntity, value == null, flag2);
						}
						if (changedFKs != null)
						{
							object x;
							if (changedFKs.TryGetValue(ordinalforOLayerMemberName2, out x))
							{
								if (!global::System.Data.Entity.Core.Common.Utils.ByValueEqualityComparer.Default.Equals(x, value))
								{
									throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.Update_ReferentialConstraintIntegrityViolation);
								}
							}
							else
							{
								changedFKs[ordinalforOLayerMemberName2] = value;
							}
						}
						if (flag2)
						{
							dependentEntity.SetCurrentValue(dependentEntity.ObjectStateEntry, orAddStateManagerTypeMetadata2.Member(ordinalforOLayerMemberName2), -1, dependentEntity.Entity, value);
						}
					}
					if (count > 1)
					{
						int num = global::System.Array.IndexOf<string>(array, fromProperties[i].Name);
						array2[num] = value;
					}
					else
					{
						this.SetCachedForeignKey((value == null) ? null : new global::System.Data.Entity.Core.EntityKey(entitySet, value), dependentEntity.ObjectStateEntry);
					}
				}
				if (count > 1)
				{
					this.SetCachedForeignKey(array2.Any((object v) => v == null) ? null : new global::System.Data.Entity.Core.EntityKey(entitySet, array2), dependentEntity.ObjectStateEntry);
				}
				if (this.WrappedOwner.ObjectStateEntry != null)
				{
					objectStateManager.ForgetEntryWithConceptualNull(this.WrappedOwner.ObjectStateEntry, false);
				}
			}
			finally
			{
				objectStateManager.TransactionManager.EndForeignKeyUpdate();
			}
		}

		// Token: 0x06003820 RID: 14368 RVA: 0x000B6FD8 File Offset: 0x000B51D8
		internal void UpdateForeignKeyValues(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper dependentEntity, global::System.Data.Entity.Core.EntityKey principalKey)
		{
			global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint referentialConstraint = ((global::System.Data.Entity.Core.Metadata.Edm.AssociationType)this.RelationMetadata).ReferentialConstraints[0];
			global::System.Data.Entity.Core.Objects.ObjectStateManager objectStateManager = this.ObjectContext.ObjectStateManager;
			objectStateManager.TransactionManager.BeginForeignKeyUpdate(this);
			try
			{
				global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = ((global::System.Data.Entity.Core.Metadata.Edm.AssociationSet)this.RelationshipSet).AssociationSetEnds[this.FromEndMember.Name].EntitySet;
				global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata orAddStateManagerTypeMetadata = objectStateManager.GetOrAddStateManagerTypeMetadata(dependentEntity.IdentityType, entitySet);
				for (int i = 0; i < referentialConstraint.FromProperties.Count; i++)
				{
					object obj = principalKey.FindValueByName(referentialConstraint.FromProperties[i].Name);
					int ordinalforOLayerMemberName = orAddStateManagerTypeMetadata.GetOrdinalforOLayerMemberName(referentialConstraint.ToProperties[i].Name);
					object value = orAddStateManagerTypeMetadata.Member(ordinalforOLayerMemberName).GetValue(dependentEntity.Entity);
					if (!global::System.Data.Entity.Core.Common.Utils.ByValueEqualityComparer.Default.Equals(value, obj))
					{
						dependentEntity.SetCurrentValue(dependentEntity.ObjectStateEntry, orAddStateManagerTypeMetadata.Member(ordinalforOLayerMemberName), -1, dependentEntity.Entity, obj);
					}
				}
				this.SetCachedForeignKey(principalKey, dependentEntity.ObjectStateEntry);
				if (this.WrappedOwner.ObjectStateEntry != null)
				{
					objectStateManager.ForgetEntryWithConceptualNull(this.WrappedOwner.ObjectStateEntry, false);
				}
			}
			finally
			{
				objectStateManager.TransactionManager.EndForeignKeyUpdate();
			}
		}

		// Token: 0x06003821 RID: 14369 RVA: 0x000B7128 File Offset: 0x000B5328
		internal object GetDependentEndOfReferentialConstraint(object relatedValue)
		{
			if (!base.IsDependentEndOfReferentialConstraint(false))
			{
				return relatedValue;
			}
			return this.WrappedOwner.Entity;
		}

		// Token: 0x06003822 RID: 14370 RVA: 0x000B7140 File Offset: 0x000B5340
		internal bool NavigationPropertyIsNullOrMissing()
		{
			return !base.TargetAccessor.HasProperty || this.WrappedOwner.GetNavigationPropertyValue(this) == null;
		}

		// Token: 0x06003823 RID: 14371 RVA: 0x000B7160 File Offset: 0x000B5360
		internal override void AddEntityToObjectStateManager(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity, bool doAttach)
		{
			base.AddEntityToObjectStateManager(wrappedEntity, doAttach);
			if (this.DetachedEntityKey != null)
			{
				global::System.Data.Entity.Core.EntityKey entityKey = wrappedEntity.EntityKey;
				if (this.DetachedEntityKey != entityKey)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityReference_EntityKeyValueMismatch);
				}
			}
		}

		// Token: 0x06003824 RID: 14372 RVA: 0x000B71A4 File Offset: 0x000B53A4
		internal override void AddToNavigationPropertyIfCompatible(global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd otherRelatedEnd)
		{
			if (this.NavigationPropertyIsNullOrMissing())
			{
				base.AddToNavigationProperty(otherRelatedEnd.WrappedOwner);
				if (otherRelatedEnd.ObjectContext.ObjectStateManager.FindEntityEntry(otherRelatedEnd.WrappedOwner.Entity) != null && otherRelatedEnd.ObjectContext.ObjectStateManager.TransactionManager.IsAddTracking && otherRelatedEnd.IsForeignKey && base.IsDependentEndOfReferentialConstraint(false))
				{
					base.MarkForeignKeyPropertiesModified();
					return;
				}
			}
			else if (!this.CheckIfNavigationPropertyContainsEntity(otherRelatedEnd.WrappedOwner))
			{
				throw global::System.Data.Entity.Resources.Error.ObjectStateManager_ConflictingChangesOfRelationshipDetected(base.RelationshipNavigation.To, base.RelationshipNavigation.RelationshipName);
			}
		}

		// Token: 0x06003825 RID: 14373 RVA: 0x000B723B File Offset: 0x000B543B
		internal override bool CachedForeignKeyIsConceptualNull()
		{
			return global::System.Data.Entity.Core.Objects.Internal.ForeignKeyFactory.IsConceptualNullKey(this.CachedForeignKey);
		}

		// Token: 0x06003826 RID: 14374 RVA: 0x000B7248 File Offset: 0x000B5448
		internal override bool UpdateDependentEndForeignKey(global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd targetRelatedEnd, bool forceForeignKeyChanges)
		{
			if (base.IsDependentEndOfReferentialConstraint(false))
			{
				this.UpdateForeignKeyValues(this.WrappedOwner, targetRelatedEnd.WrappedOwner, null, forceForeignKeyChanges);
				return true;
			}
			return false;
		}

		// Token: 0x06003827 RID: 14375 RVA: 0x000B726C File Offset: 0x000B546C
		internal override void ValidateDetachedEntityKey()
		{
			if (this.IsEmpty() && this.DetachedEntityKey != null)
			{
				global::System.Data.Entity.Core.EntityKey detachedEntityKey = this.DetachedEntityKey;
				if (!global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd.IsValidEntityKeyType(detachedEntityKey))
				{
					throw global::System.Data.Entity.Resources.Error.EntityReference_CannotSetSpecialKeys();
				}
				global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = detachedEntityKey.GetEntitySet(this.ObjectContext.MetadataWorkspace);
				base.CheckRelationEntitySet(entitySet);
				detachedEntityKey.ValidateEntityKey(this.ObjectContext.MetadataWorkspace, entitySet);
			}
		}

		// Token: 0x06003828 RID: 14376 RVA: 0x000B72D0 File Offset: 0x000B54D0
		internal override void VerifyDetachedKeyMatches(global::System.Data.Entity.Core.EntityKey entityKey)
		{
			if (!(this.DetachedEntityKey != null) || !(this.DetachedEntityKey != entityKey))
			{
				return;
			}
			if (entityKey.IsTemporary)
			{
				throw global::System.Data.Entity.Resources.Error.RelatedEnd_CannotCreateRelationshipBetweenTrackedAndNoTrackedEntities(base.RelationshipNavigation.To);
			}
			throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityReference_EntityKeyValueMismatch);
		}

		// Token: 0x06003829 RID: 14377 RVA: 0x000B731F File Offset: 0x000B551F
		internal override void DetachAll(global::System.Data.Entity.EntityState ownerEntityState)
		{
			this.DetachedEntityKey = this.AttachedEntityKey;
			base.DetachAll(ownerEntityState);
			if (base.IsForeignKey)
			{
				this.DetachedEntityKey = null;
			}
		}

		// Token: 0x0600382A RID: 14378 RVA: 0x000B7344 File Offset: 0x000B5544
		internal override bool CheckReferentialConstraintPrincipalProperty(global::System.Data.Entity.Core.Objects.EntityEntry ownerEntry, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint constraint)
		{
			global::System.Data.Entity.Core.EntityKey principalKey;
			if (!this.IsEmpty())
			{
				global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper referenceValue = this.ReferenceValue;
				if (referenceValue.ObjectStateEntry != null && referenceValue.ObjectStateEntry.State == global::System.Data.Entity.EntityState.Added)
				{
					return true;
				}
				principalKey = this.ExtractPrincipalKey(referenceValue);
			}
			else
			{
				if ((this.ToEndMember.RelationshipMultiplicity != global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne && this.ToEndMember.RelationshipMultiplicity != global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One) || !(this.DetachedEntityKey != null))
				{
					return true;
				}
				if (base.IsForeignKey && !this.ObjectContext.ObjectStateManager.TransactionManager.IsAddTracking && !this.ObjectContext.ObjectStateManager.TransactionManager.IsAttachTracking)
				{
					principalKey = this.EntityKey;
				}
				else
				{
					principalKey = this.DetachedEntityKey;
				}
			}
			return global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd.VerifyRIConstraintsWithRelatedEntry(constraint, new global::System.Func<string, object>(ownerEntry.GetCurrentEntityValue), principalKey);
		}

		// Token: 0x0600382B RID: 14379 RVA: 0x000B7408 File Offset: 0x000B5608
		internal override bool CheckReferentialConstraintDependentProperty(global::System.Data.Entity.Core.Objects.EntityEntry ownerEntry, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint constraint)
		{
			if (!this.IsEmpty())
			{
				return base.CheckReferentialConstraintDependentProperty(ownerEntry, constraint);
			}
			if ((this.ToEndMember.RelationshipMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne || this.ToEndMember.RelationshipMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One) && this.DetachedEntityKey != null)
			{
				global::System.Data.Entity.Core.EntityKey detachedEntityKey = this.DetachedEntityKey;
				if (!global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd.VerifyRIConstraintsWithRelatedEntry(constraint, new global::System.Func<string, object>(detachedEntityKey.FindValueByName), ownerEntry.EntityKey))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600382C RID: 14380 RVA: 0x000B7474 File Offset: 0x000B5674
		private global::System.Data.Entity.Core.EntityKey ExtractPrincipalKey(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedRelatedEntity)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet targetEntitySetFromRelationshipSet = base.GetTargetEntitySetFromRelationshipSet();
			global::System.Data.Entity.Core.EntityKey entityKey = wrappedRelatedEntity.EntityKey;
			if (entityKey != null && !entityKey.IsTemporary)
			{
				global::System.Data.Entity.Core.EntityUtil.ValidateEntitySetInKey(entityKey, targetEntitySetFromRelationshipSet);
				entityKey.ValidateEntityKey(this.ObjectContext.MetadataWorkspace, targetEntitySetFromRelationshipSet);
			}
			else
			{
				entityKey = this.ObjectContext.ObjectStateManager.CreateEntityKey(targetEntitySetFromRelationshipSet, wrappedRelatedEntity.Entity);
			}
			return entityKey;
		}

		// Token: 0x0600382D RID: 14381 RVA: 0x000B74D0 File Offset: 0x000B56D0
		internal void NullAllForeignKeys()
		{
			global::System.Data.Entity.Core.Objects.ObjectStateManager objectStateManager = this.ObjectContext.ObjectStateManager;
			global::System.Data.Entity.Core.Objects.EntityEntry objectStateEntry = this.WrappedOwner.ObjectStateEntry;
			global::System.Data.Entity.Core.Objects.Internal.TransactionManager transactionManager = objectStateManager.TransactionManager;
			if (!transactionManager.IsGraphUpdate && !transactionManager.IsAttachTracking && !transactionManager.IsRelatedEndAdd)
			{
				global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint referentialConstraint = ((global::System.Data.Entity.Core.Metadata.Edm.AssociationType)this.RelationMetadata).ReferentialConstraints.Single<global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>();
				if (this.TargetRoleName == referentialConstraint.FromRole.Name)
				{
					if (transactionManager.IsDetaching)
					{
						global::System.Data.Entity.Core.EntityKey entityKey = global::System.Data.Entity.Core.Objects.Internal.ForeignKeyFactory.CreateKeyFromForeignKeyValues(objectStateEntry, this);
						if (entityKey != null)
						{
							objectStateManager.AddEntryContainingForeignKeyToIndex(this, entityKey, objectStateEntry);
							return;
						}
					}
					else if (objectStateManager.EntityInvokingFKSetter != this.WrappedOwner.Entity && !transactionManager.IsForeignKeyUpdate)
					{
						transactionManager.BeginForeignKeyUpdate(this);
						try
						{
							bool flag = true;
							bool flag2 = objectStateEntry != null && (objectStateEntry.State == global::System.Data.Entity.EntityState.Modified || objectStateEntry.State == global::System.Data.Entity.EntityState.Unchanged);
							global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = ((global::System.Data.Entity.Core.Metadata.Edm.AssociationSet)this.RelationshipSet).AssociationSetEnds[this.FromEndMember.Name].EntitySet;
							global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata orAddStateManagerTypeMetadata = objectStateManager.GetOrAddStateManagerTypeMetadata(this.WrappedOwner.IdentityType, entitySet);
							for (int i = 0; i < referentialConstraint.FromProperties.Count; i++)
							{
								string name = referentialConstraint.ToProperties[i].Name;
								int ordinalforOLayerMemberName = orAddStateManagerTypeMetadata.GetOrdinalforOLayerMemberName(name);
								global::System.Data.Entity.Core.Objects.StateManagerMemberMetadata stateManagerMemberMetadata = orAddStateManagerTypeMetadata.Member(ordinalforOLayerMemberName);
								if (stateManagerMemberMetadata.ClrMetadata.Nullable)
								{
									if (stateManagerMemberMetadata.GetValue(this.WrappedOwner.Entity) != null)
									{
										this.WrappedOwner.SetCurrentValue(this.WrappedOwner.ObjectStateEntry, orAddStateManagerTypeMetadata.Member(ordinalforOLayerMemberName), -1, this.WrappedOwner.Entity, null);
									}
									else if (flag2 && this.WrappedOwner.ObjectStateEntry.OriginalValues.GetValue(ordinalforOLayerMemberName) != null)
									{
										objectStateEntry.SetModifiedProperty(name);
									}
									flag = false;
								}
								else if (flag2)
								{
									objectStateEntry.SetModifiedProperty(name);
								}
							}
							if (flag)
							{
								if (objectStateEntry != null)
								{
									global::System.Data.Entity.Core.EntityKey entityKey2 = this.CachedForeignKey;
									if (entityKey2 == null)
									{
										entityKey2 = global::System.Data.Entity.Core.Objects.Internal.ForeignKeyFactory.CreateKeyFromForeignKeyValues(objectStateEntry, this);
									}
									if (entityKey2 != null)
									{
										this.SetCachedForeignKey(global::System.Data.Entity.Core.Objects.Internal.ForeignKeyFactory.CreateConceptualNullKey(entityKey2), objectStateEntry);
										objectStateManager.RememberEntryWithConceptualNull(objectStateEntry);
									}
								}
							}
							else
							{
								this.SetCachedForeignKey(null, objectStateEntry);
							}
						}
						finally
						{
							transactionManager.EndForeignKeyUpdate();
						}
					}
				}
			}
		}

		// Token: 0x040012EA RID: 4842
		private global::System.Data.Entity.Core.EntityKey _detachedEntityKey;

		// Token: 0x040012EB RID: 4843
		[global::System.NonSerialized]
		private global::System.Data.Entity.Core.EntityKey _cachedForeignKey;
	}
}
