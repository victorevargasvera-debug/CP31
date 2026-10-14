using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects.Internal;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace System.Data.Entity.Core.Objects.DataClasses
{
	// Token: 0x02000479 RID: 1145
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class EntityReference<TEntity> : global::System.Data.Entity.Core.Objects.DataClasses.EntityReference where TEntity : class
	{
		// Token: 0x0600382E RID: 14382 RVA: 0x000B773C File Offset: 0x000B593C
		public EntityReference()
		{
			this._wrappedCachedValue = global::System.Data.Entity.Core.Objects.Internal.NullEntityWrapper.NullWrapper;
		}

		// Token: 0x0600382F RID: 14383 RVA: 0x000B774F File Offset: 0x000B594F
		internal EntityReference(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedOwner, global::System.Data.Entity.Core.Objects.DataClasses.RelationshipNavigation navigation, global::System.Data.Entity.Core.Objects.DataClasses.IRelationshipFixer relationshipFixer) : base(wrappedOwner, navigation, relationshipFixer)
		{
			this._wrappedCachedValue = global::System.Data.Entity.Core.Objects.Internal.NullEntityWrapper.NullWrapper;
		}

		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x06003830 RID: 14384 RVA: 0x000B7765 File Offset: 0x000B5965
		// (set) Token: 0x06003831 RID: 14385 RVA: 0x000B777D File Offset: 0x000B597D
		[global::System.Xml.Serialization.SoapIgnore]
		[global::System.Xml.Serialization.XmlIgnore]
		public TEntity Value
		{
			get
			{
				base.DeferredLoad();
				return (TEntity)((object)this.ReferenceValue.Entity);
			}
			set
			{
				this.ReferenceValue = this.EntityWrapperFactory.WrapEntityUsingContext(value, this.ObjectContext);
			}
		}

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x06003832 RID: 14386 RVA: 0x000B779C File Offset: 0x000B599C
		internal override global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper CachedValue
		{
			get
			{
				return this._wrappedCachedValue;
			}
		}

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x06003833 RID: 14387 RVA: 0x000B77A4 File Offset: 0x000B59A4
		// (set) Token: 0x06003834 RID: 14388 RVA: 0x000B77B4 File Offset: 0x000B59B4
		internal override global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper ReferenceValue
		{
			get
			{
				this.CheckOwnerNull();
				return this._wrappedCachedValue;
			}
			set
			{
				this.CheckOwnerNull();
				if (value.Entity != null && value.Entity == this._wrappedCachedValue.Entity)
				{
					return;
				}
				if (value.Entity != null)
				{
					base.ValidateOwnerWithRIConstraints(value, (value == global::System.Data.Entity.Core.Objects.Internal.NullEntityWrapper.NullWrapper) ? null : value.EntityKey, true);
					global::System.Data.Entity.Core.Objects.ObjectContext objectContext = this.ObjectContext ?? value.Context;
					if (objectContext != null)
					{
						objectContext.ObjectStateManager.TransactionManager.EntityBeingReparented = base.GetDependentEndOfReferentialConstraint(value.Entity);
					}
					try
					{
						base.Add(value, false);
						return;
					}
					finally
					{
						if (objectContext != null)
						{
							objectContext.ObjectStateManager.TransactionManager.EntityBeingReparented = null;
						}
					}
				}
				if (base.UsingNoTracking)
				{
					if (this._wrappedCachedValue.Entity != null)
					{
						base.GetOtherEndOfRelationship(this._wrappedCachedValue).OnRelatedEndClear();
					}
					this._isLoaded = false;
				}
				else if (this.ObjectContext != null && this.ObjectContext.ContextOptions.UseConsistentNullReferenceBehavior)
				{
					base.AttemptToNullFKsOnRefOrKeySetToNull();
				}
				this.ClearCollectionOrRef(null, null, false);
			}
		}

		// Token: 0x06003835 RID: 14389 RVA: 0x000B78C0 File Offset: 0x000B5AC0
		public override void Load(global::System.Data.Entity.Core.Objects.MergeOption mergeOption)
		{
			this.CheckOwnerNull();
			bool flag;
			global::System.Data.Entity.Core.Objects.ObjectQuery<TEntity> objectQuery = this.ValidateLoad<TEntity>(mergeOption, "EntityReference", out flag);
			this._suppressEvents = true;
			try
			{
				global::System.Collections.Generic.IList<TEntity> refreshedValue = null;
				if (flag)
				{
					refreshedValue = objectQuery.Execute(objectQuery.MergeOption).ToList<TEntity>();
				}
				this.HandleRefreshedValue(mergeOption, refreshedValue);
			}
			finally
			{
				this._suppressEvents = false;
			}
			this.OnAssociationChanged(global::System.ComponentModel.CollectionChangeAction.Refresh, null);
		}

		// Token: 0x06003836 RID: 14390 RVA: 0x000B792C File Offset: 0x000B5B2C
		public override async global::System.Threading.Tasks.Task LoadAsync(global::System.Data.Entity.Core.Objects.MergeOption mergeOption, global::System.Threading.CancellationToken cancellationToken)
		{
			this.CheckOwnerNull();
			cancellationToken.ThrowIfCancellationRequested();
			bool flag;
			global::System.Data.Entity.Core.Objects.ObjectQuery<TEntity> objectQuery = this.ValidateLoad<TEntity>(mergeOption, "EntityReference", out flag);
			this._suppressEvents = true;
			try
			{
				global::System.Collections.Generic.IList<TEntity> refreshedValue = null;
				if (flag)
				{
					refreshedValue = await(await objectQuery.ExecuteAsync(objectQuery.MergeOption, cancellationToken).WithCurrentCulture<global::System.Data.Entity.Core.Objects.ObjectResult<TEntity>>()).ToListAsync(cancellationToken).WithCurrentCulture<global::System.Collections.Generic.List<TEntity>>();
				}
				this.HandleRefreshedValue(mergeOption, refreshedValue);
			}
			finally
			{
				this._suppressEvents = false;
			}
			this.OnAssociationChanged(global::System.ComponentModel.CollectionChangeAction.Refresh, null);
		}

		// Token: 0x06003837 RID: 14391 RVA: 0x000B7984 File Offset: 0x000B5B84
		private void HandleRefreshedValue(global::System.Data.Entity.Core.Objects.MergeOption mergeOption, global::System.Collections.Generic.IList<TEntity> refreshedValue)
		{
			if (refreshedValue == null || !refreshedValue.Any<TEntity>())
			{
				if (!((global::System.Data.Entity.Core.Metadata.Edm.AssociationType)this.RelationMetadata).IsForeignKey && this.ToEndMember.RelationshipMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One)
				{
					throw global::System.Data.Entity.Resources.Error.EntityReference_LessThanExpectedRelatedEntitiesFound();
				}
				if (mergeOption == global::System.Data.Entity.Core.Objects.MergeOption.OverwriteChanges || mergeOption == global::System.Data.Entity.Core.Objects.MergeOption.PreserveChanges)
				{
					global::System.Data.Entity.Core.EntityKey entityKey = this.WrappedOwner.EntityKey;
					if (entityKey == null)
					{
						throw global::System.Data.Entity.Resources.Error.EntityKey_UnexpectedNull();
					}
					this.ObjectContext.ObjectStateManager.RemoveRelationships(mergeOption, (global::System.Data.Entity.Core.Metadata.Edm.AssociationSet)this.RelationshipSet, entityKey, (global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember)this.FromEndMember);
				}
				this._isLoaded = true;
				return;
			}
			else
			{
				if (refreshedValue.Count<TEntity>() == 1)
				{
					this.Merge<TEntity>(refreshedValue, mergeOption, true);
					return;
				}
				throw global::System.Data.Entity.Resources.Error.EntityReference_MoreThanExpectedRelatedEntitiesFound();
			}
		}

		// Token: 0x06003838 RID: 14392 RVA: 0x000B7A27 File Offset: 0x000B5C27
		internal override global::System.Collections.IEnumerable GetInternalEnumerable()
		{
			this.CheckOwnerNull();
			if (this.ReferenceValue.Entity != null)
			{
				return new object[]
				{
					this.ReferenceValue.Entity
				};
			}
			return global::System.Linq.Enumerable.Empty<object>();
		}

		// Token: 0x06003839 RID: 14393 RVA: 0x000B7A56 File Offset: 0x000B5C56
		internal override global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper> GetWrappedEntities()
		{
			if (this._wrappedCachedValue.Entity != null)
			{
				return new global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper[]
				{
					this._wrappedCachedValue
				};
			}
			return new global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper[0];
		}

		// Token: 0x0600383A RID: 14394 RVA: 0x000B7A7B File Offset: 0x000B5C7B
		public void Attach(TEntity entity)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<TEntity>(entity, "entity");
			this.CheckOwnerNull();
			base.Attach(new global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper[]
			{
				this.EntityWrapperFactory.WrapEntityUsingContext(entity, this.ObjectContext)
			}, false);
		}

		// Token: 0x0600383B RID: 14395 RVA: 0x000B7AB8 File Offset: 0x000B5CB8
		internal override void Include(bool addRelationshipAsUnchanged, bool doAttach)
		{
			if (this._wrappedCachedValue.Entity != null)
			{
				global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper entityWrapper = this.EntityWrapperFactory.WrapEntityUsingContext(this._wrappedCachedValue.Entity, this.WrappedOwner.Context);
				if (entityWrapper != this._wrappedCachedValue)
				{
					this._wrappedCachedValue = entityWrapper;
				}
				base.IncludeEntity(this._wrappedCachedValue, addRelationshipAsUnchanged, doAttach);
				return;
			}
			if (base.DetachedEntityKey != null)
			{
				this.IncludeEntityKey(doAttach);
			}
		}

		// Token: 0x0600383C RID: 14396 RVA: 0x000B7B28 File Offset: 0x000B5D28
		private void IncludeEntityKey(bool doAttach)
		{
			global::System.Data.Entity.Core.Objects.ObjectStateManager objectStateManager = this.ObjectContext.ObjectStateManager;
			bool flag = false;
			bool flag2 = false;
			global::System.Data.Entity.Core.Objects.EntityEntry entityEntry = objectStateManager.FindEntityEntry(base.DetachedEntityKey);
			if (entityEntry == null)
			{
				flag2 = true;
				flag = true;
			}
			else if (entityEntry.IsKeyEntry)
			{
				if (this.FromEndMember.RelationshipMultiplicity != global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many)
				{
					foreach (global::System.Data.Entity.Core.Objects.RelationshipEntry relationshipEntry in this.ObjectContext.ObjectStateManager.FindRelationshipsByKey(base.DetachedEntityKey))
					{
						if (relationshipEntry.IsSameAssociationSetAndRole((global::System.Data.Entity.Core.Metadata.Edm.AssociationSet)this.RelationshipSet, (global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember)this.ToEndMember, base.DetachedEntityKey) && relationshipEntry.State != global::System.Data.Entity.EntityState.Deleted)
						{
							throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateManager_EntityConflictsWithKeyEntry);
						}
					}
				}
				flag = true;
			}
			else
			{
				global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity = entityEntry.WrappedEntity;
				if (entityEntry.State == global::System.Data.Entity.EntityState.Deleted)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.RelatedEnd_UnableToAddRelationshipWithDeletedEntity);
				}
				global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEndInternal = wrappedEntity.RelationshipManager.GetRelatedEndInternal(base.RelationshipName, base.RelationshipNavigation.From);
				if (this.FromEndMember.RelationshipMultiplicity != global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many && !relatedEndInternal.IsEmpty())
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateManager_EntityConflictsWithKeyEntry);
				}
				base.Add(wrappedEntity, true, doAttach, false, true, true);
				objectStateManager.TransactionManager.PopulatedEntityReferences.Add(this);
			}
			if (flag && !base.IsForeignKey)
			{
				if (flag2)
				{
					global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = base.DetachedEntityKey.GetEntitySet(this.ObjectContext.MetadataWorkspace);
					objectStateManager.AddKeyEntry(base.DetachedEntityKey, entitySet);
				}
				global::System.Data.Entity.Core.EntityKey entityKey = this.WrappedOwner.EntityKey;
				if (entityKey == null)
				{
					throw global::System.Data.Entity.Resources.Error.EntityKey_UnexpectedNull();
				}
				global::System.Data.Entity.Core.Objects.RelationshipWrapper wrapper = new global::System.Data.Entity.Core.Objects.RelationshipWrapper((global::System.Data.Entity.Core.Metadata.Edm.AssociationSet)this.RelationshipSet, base.RelationshipNavigation.From, entityKey, base.RelationshipNavigation.To, base.DetachedEntityKey);
				objectStateManager.AddNewRelation(wrapper, doAttach ? global::System.Data.Entity.EntityState.Unchanged : global::System.Data.Entity.EntityState.Added);
			}
		}

		// Token: 0x0600383D RID: 14397 RVA: 0x000B7D18 File Offset: 0x000B5F18
		internal override void Exclude()
		{
			if (this._wrappedCachedValue.Entity == null)
			{
				if (base.DetachedEntityKey != null)
				{
					this.ExcludeEntityKey();
				}
				return;
			}
			global::System.Data.Entity.Core.Objects.Internal.TransactionManager transactionManager = this.ObjectContext.ObjectStateManager.TransactionManager;
			bool flag = transactionManager.PopulatedEntityReferences.Contains(this);
			bool flag2 = transactionManager.AlignedEntityReferences.Contains(this);
			if ((transactionManager.ProcessedEntities != null && transactionManager.ProcessedEntities.Contains(this._wrappedCachedValue)) || (!flag && !flag2))
			{
				base.ExcludeEntity(this._wrappedCachedValue);
				return;
			}
			global::System.Data.Entity.Core.Objects.RelationshipEntry relationshipEntry = base.IsForeignKey ? null : base.FindRelationshipEntryInObjectStateManager(this._wrappedCachedValue);
			base.Remove(this._wrappedCachedValue, flag, false, false, false, true);
			if (relationshipEntry != null && relationshipEntry.State != global::System.Data.Entity.EntityState.Detached)
			{
				relationshipEntry.AcceptChanges();
			}
			if (flag)
			{
				transactionManager.PopulatedEntityReferences.Remove(this);
				return;
			}
			transactionManager.AlignedEntityReferences.Remove(this);
		}

		// Token: 0x0600383E RID: 14398 RVA: 0x000B7DFC File Offset: 0x000B5FFC
		private void ExcludeEntityKey()
		{
			global::System.Data.Entity.Core.EntityKey entityKey = this.WrappedOwner.EntityKey;
			global::System.Data.Entity.Core.Objects.RelationshipEntry relationshipEntry = this.ObjectContext.ObjectStateManager.FindRelationship(this.RelationshipSet, new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.EntityKey>(base.RelationshipNavigation.From, entityKey), new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.EntityKey>(base.RelationshipNavigation.To, base.DetachedEntityKey));
			if (relationshipEntry != null)
			{
				relationshipEntry.Delete(false);
				if (relationshipEntry.State != global::System.Data.Entity.EntityState.Detached)
				{
					relationshipEntry.AcceptChanges();
				}
			}
		}

		// Token: 0x0600383F RID: 14399 RVA: 0x000B7E6C File Offset: 0x000B606C
		internal override void ClearCollectionOrRef(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity, global::System.Data.Entity.Core.Objects.DataClasses.RelationshipNavigation navigation, bool doCascadeDelete)
		{
			if (wrappedEntity == null)
			{
				wrappedEntity = global::System.Data.Entity.Core.Objects.Internal.NullEntityWrapper.NullWrapper;
			}
			if (this._wrappedCachedValue.Entity != null)
			{
				if (wrappedEntity.Entity == this._wrappedCachedValue.Entity && navigation.Equals(base.RelationshipNavigation))
				{
					base.Remove(this._wrappedCachedValue, false, false, false, false, false);
				}
				else
				{
					base.Remove(this._wrappedCachedValue, true, doCascadeDelete, false, true, false);
				}
			}
			else if (this.WrappedOwner.Entity != null && this.WrappedOwner.Context != null && !base.UsingNoTracking)
			{
				this.WrappedOwner.Context.ObjectStateManager.GetEntityEntry(this.WrappedOwner.Entity).DeleteRelationshipsThatReferenceKeys(this.RelationshipSet, this.ToEndMember);
			}
			if (this.WrappedOwner.Entity != null)
			{
				base.DetachedEntityKey = null;
			}
		}

		// Token: 0x06003840 RID: 14400 RVA: 0x000B7F3E File Offset: 0x000B613E
		internal override void ClearWrappedValues()
		{
			this._cachedValue = default(TEntity);
			this._wrappedCachedValue = global::System.Data.Entity.Core.Objects.Internal.NullEntityWrapper.NullWrapper;
		}

		// Token: 0x06003841 RID: 14401 RVA: 0x000B7F57 File Offset: 0x000B6157
		internal override bool CanSetEntityType(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity)
		{
			return wrappedEntity.Entity is TEntity;
		}

		// Token: 0x06003842 RID: 14402 RVA: 0x000B7F67 File Offset: 0x000B6167
		internal override void VerifyType(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity)
		{
			if (!this.CanSetEntityType(wrappedEntity))
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.RelatedEnd_InvalidContainedType_Reference(wrappedEntity.Entity.GetType().FullName, typeof(TEntity).FullName));
			}
		}

		// Token: 0x06003843 RID: 14403 RVA: 0x000B7F9C File Offset: 0x000B619C
		internal override void DisconnectedAdd(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity)
		{
			this.CheckOwnerNull();
		}

		// Token: 0x06003844 RID: 14404 RVA: 0x000B7FA4 File Offset: 0x000B61A4
		internal override bool DisconnectedRemove(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity)
		{
			this.CheckOwnerNull();
			return false;
		}

		// Token: 0x06003845 RID: 14405 RVA: 0x000B7FAD File Offset: 0x000B61AD
		internal override bool RemoveFromLocalCache(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity, bool resetIsLoaded, bool preserveForeignKey)
		{
			this._wrappedCachedValue = global::System.Data.Entity.Core.Objects.Internal.NullEntityWrapper.NullWrapper;
			this._cachedValue = default(TEntity);
			if (resetIsLoaded)
			{
				this._isLoaded = false;
			}
			if (this.ObjectContext != null && base.IsForeignKey && !preserveForeignKey)
			{
				base.NullAllForeignKeys();
			}
			return true;
		}

		// Token: 0x06003846 RID: 14406 RVA: 0x000B7FEA File Offset: 0x000B61EA
		internal override bool RemoveFromObjectCache(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity)
		{
			if (base.TargetAccessor.HasProperty)
			{
				this.WrappedOwner.RemoveNavigationPropertyValue(this, wrappedEntity.Entity);
			}
			return true;
		}

		// Token: 0x06003847 RID: 14407 RVA: 0x000B800C File Offset: 0x000B620C
		internal override void RetrieveReferentialConstraintProperties(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.KeyValuePair<object, global::System.Data.Entity.Core.Objects.IntBox>> properties, global::System.Collections.Generic.HashSet<object> visited)
		{
			if (this._wrappedCachedValue.Entity != null)
			{
				foreach (global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint referentialConstraint in ((global::System.Data.Entity.Core.Metadata.Edm.AssociationType)this.RelationMetadata).ReferentialConstraints)
				{
					if (referentialConstraint.ToRole == this.FromEndMember)
					{
						if (visited.Contains(this._wrappedCachedValue))
						{
							throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.RelationshipManager_CircularRelationshipsWithReferentialConstraints);
						}
						visited.Add(this._wrappedCachedValue);
						global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.KeyValuePair<object, global::System.Data.Entity.Core.Objects.IntBox>> dictionary;
						this._wrappedCachedValue.RelationshipManager.RetrieveReferentialConstraintProperties(out dictionary, visited, true);
						for (int i = 0; i < referentialConstraint.FromProperties.Count; i++)
						{
							global::System.Data.Entity.Core.Objects.EntityEntry.AddOrIncreaseCounter(referentialConstraint, properties, referentialConstraint.ToProperties[i].Name, dictionary[referentialConstraint.FromProperties[i].Name].Key);
						}
					}
				}
			}
		}

		// Token: 0x06003848 RID: 14408 RVA: 0x000B8114 File Offset: 0x000B6314
		internal override bool IsEmpty()
		{
			return this._wrappedCachedValue.Entity == null;
		}

		// Token: 0x06003849 RID: 14409 RVA: 0x000B8124 File Offset: 0x000B6324
		internal override void VerifyMultiplicityConstraintsForAdd(bool applyConstraints)
		{
			if (applyConstraints && !this.IsEmpty())
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityReference_CannotAddMoreThanOneEntityToEntityReference(base.RelationshipNavigation.To, base.RelationshipNavigation.RelationshipName));
			}
		}

		// Token: 0x0600384A RID: 14410 RVA: 0x000B8152 File Offset: 0x000B6352
		internal override void OnRelatedEndClear()
		{
			this._isLoaded = false;
		}

		// Token: 0x0600384B RID: 14411 RVA: 0x000B815B File Offset: 0x000B635B
		internal override bool ContainsEntity(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity)
		{
			return this._wrappedCachedValue.Entity != null && this._wrappedCachedValue.Entity == wrappedEntity.Entity;
		}

		// Token: 0x0600384C RID: 14412 RVA: 0x000B8180 File Offset: 0x000B6380
		public global::System.Data.Entity.Core.Objects.ObjectQuery<TEntity> CreateSourceQuery()
		{
			this.CheckOwnerNull();
			bool flag;
			return base.CreateSourceQuery<TEntity>(base.DefaultMergeOption, out flag);
		}

		// Token: 0x0600384D RID: 14413 RVA: 0x000B81A1 File Offset: 0x000B63A1
		internal override global::System.Collections.IEnumerable CreateSourceQueryInternal()
		{
			return this.CreateSourceQuery();
		}

		// Token: 0x0600384E RID: 14414 RVA: 0x000B81AC File Offset: 0x000B63AC
		internal void InitializeWithValue(global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd)
		{
			global::System.Data.Entity.Core.Objects.DataClasses.EntityReference<TEntity> entityReference = relatedEnd as global::System.Data.Entity.Core.Objects.DataClasses.EntityReference<TEntity>;
			if (entityReference != null && entityReference._wrappedCachedValue.Entity != null)
			{
				this._wrappedCachedValue = entityReference._wrappedCachedValue;
				this._cachedValue = (TEntity)((object)this._wrappedCachedValue.Entity);
			}
		}

		// Token: 0x0600384F RID: 14415 RVA: 0x000B81F2 File Offset: 0x000B63F2
		internal override bool CheckIfNavigationPropertyContainsEntity(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrapper)
		{
			return base.TargetAccessor.HasProperty && this.WrappedOwner.GetNavigationPropertyValue(this) == wrapper.Entity;
		}

		// Token: 0x06003850 RID: 14416 RVA: 0x000B8218 File Offset: 0x000B6418
		internal override void VerifyNavigationPropertyForAdd(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrapper)
		{
			if (base.TargetAccessor.HasProperty)
			{
				object navigationPropertyValue = this.WrappedOwner.GetNavigationPropertyValue(this);
				if (navigationPropertyValue != null && navigationPropertyValue != wrapper.Entity)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityReference_CannotAddMoreThanOneEntityToEntityReference(base.RelationshipNavigation.To, base.RelationshipNavigation.RelationshipName));
				}
			}
		}

		// Token: 0x06003851 RID: 14417 RVA: 0x000B826C File Offset: 0x000B646C
		[global::System.Runtime.Serialization.OnDeserialized]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void OnRefDeserialized(global::System.Runtime.Serialization.StreamingContext context)
		{
			this._wrappedCachedValue = this.EntityWrapperFactory.WrapEntityUsingContext(this._cachedValue, this.ObjectContext);
		}

		// Token: 0x06003852 RID: 14418 RVA: 0x000B8290 File Offset: 0x000B6490
		[global::System.Runtime.Serialization.OnSerializing]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void OnSerializing(global::System.Runtime.Serialization.StreamingContext context)
		{
			if (!(this.WrappedOwner.Entity is global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithRelationships))
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.RelatedEnd_CannotSerialize("EntityReference"));
			}
		}

		// Token: 0x06003853 RID: 14419 RVA: 0x000B82B4 File Offset: 0x000B64B4
		internal override void AddToLocalCache(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity, bool applyConstraints)
		{
			if (wrappedEntity != this._wrappedCachedValue)
			{
				global::System.Data.Entity.Core.Objects.Internal.TransactionManager transactionManager = (this.ObjectContext != null) ? this.ObjectContext.ObjectStateManager.TransactionManager : null;
				if (applyConstraints && this._wrappedCachedValue.Entity != null && (transactionManager == null || transactionManager.ProcessedEntities == null || transactionManager.ProcessedEntities.Contains(this._wrappedCachedValue)))
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityReference_CannotAddMoreThanOneEntityToEntityReference(base.RelationshipNavigation.To, base.RelationshipNavigation.RelationshipName));
				}
				if (transactionManager != null && wrappedEntity.Entity != null)
				{
					transactionManager.BeginRelatedEndAdd();
				}
				try
				{
					this.ClearCollectionOrRef(null, null, false);
					this._wrappedCachedValue = wrappedEntity;
					this._cachedValue = (TEntity)((object)wrappedEntity.Entity);
				}
				finally
				{
					if (transactionManager != null && transactionManager.IsRelatedEndAdd)
					{
						transactionManager.EndRelatedEndAdd();
					}
				}
			}
		}

		// Token: 0x06003854 RID: 14420 RVA: 0x000B8390 File Offset: 0x000B6590
		internal override void AddToObjectCache(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity)
		{
			if (base.TargetAccessor.HasProperty)
			{
				this.WrappedOwner.SetNavigationPropertyValue(this, wrappedEntity.Entity);
			}
		}

		// Token: 0x040012EC RID: 4844
		private TEntity _cachedValue;

		// Token: 0x040012ED RID: 4845
		[global::System.NonSerialized]
		private global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper _wrappedCachedValue;
	}
}
