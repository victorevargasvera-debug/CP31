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

namespace System.Data.Entity.Core.Objects.DataClasses
{
	// Token: 0x02000476 RID: 1142
	[global::System.Serializable]
	public class EntityCollection<TEntity> : global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd, global::System.Collections.Generic.ICollection<!0>, global::System.Collections.Generic.IEnumerable<!0>, global::System.Collections.IEnumerable, global::System.ComponentModel.IListSource where TEntity : class
	{
		// Token: 0x060037CC RID: 14284 RVA: 0x000B5A6B File Offset: 0x000B3C6B
		public EntityCollection()
		{
		}

		// Token: 0x060037CD RID: 14285 RVA: 0x000B5A73 File Offset: 0x000B3C73
		internal EntityCollection(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedOwner, global::System.Data.Entity.Core.Objects.DataClasses.RelationshipNavigation navigation, global::System.Data.Entity.Core.Objects.DataClasses.IRelationshipFixer relationshipFixer) : base(wrappedOwner, navigation, relationshipFixer)
		{
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x060037CE RID: 14286 RVA: 0x000B5A7E File Offset: 0x000B3C7E
		// (remove) Token: 0x060037CF RID: 14287 RVA: 0x000B5A97 File Offset: 0x000B3C97
		internal override event global::System.ComponentModel.CollectionChangeEventHandler AssociationChangedForObjectView
		{
			add
			{
				this._onAssociationChangedforObjectView = (global::System.ComponentModel.CollectionChangeEventHandler)global::System.Delegate.Combine(this._onAssociationChangedforObjectView, value);
			}
			remove
			{
				this._onAssociationChangedforObjectView = (global::System.ComponentModel.CollectionChangeEventHandler)global::System.Delegate.Remove(this._onAssociationChangedforObjectView, value);
			}
		}

		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x060037D0 RID: 14288 RVA: 0x000B5AB0 File Offset: 0x000B3CB0
		private global::System.Collections.Generic.Dictionary<TEntity, global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper> WrappedRelatedEntities
		{
			get
			{
				if (this._wrappedRelatedEntities == null)
				{
					this._wrappedRelatedEntities = new global::System.Collections.Generic.Dictionary<TEntity, global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>(global::System.Data.Entity.Infrastructure.ObjectReferenceEqualityComparer.Default);
				}
				return this._wrappedRelatedEntities;
			}
		}

		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x060037D1 RID: 14289 RVA: 0x000B5AD0 File Offset: 0x000B3CD0
		public int Count
		{
			get
			{
				base.DeferredLoad();
				return this.CountInternal;
			}
		}

		// Token: 0x17000ABC RID: 2748
		// (get) Token: 0x060037D2 RID: 14290 RVA: 0x000B5ADE File Offset: 0x000B3CDE
		internal int CountInternal
		{
			get
			{
				if (this._wrappedRelatedEntities == null)
				{
					return 0;
				}
				return this._wrappedRelatedEntities.Count;
			}
		}

		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x060037D3 RID: 14291 RVA: 0x000B5AF5 File Offset: 0x000B3CF5
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x060037D4 RID: 14292 RVA: 0x000B5AF8 File Offset: 0x000B3CF8
		bool global::System.ComponentModel.IListSource.ContainsListCollection
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060037D5 RID: 14293 RVA: 0x000B5AFB File Offset: 0x000B3CFB
		internal override void OnAssociationChanged(global::System.ComponentModel.CollectionChangeAction collectionChangeAction, object entity)
		{
			if (!this._suppressEvents)
			{
				if (this._onAssociationChangedforObjectView != null)
				{
					this._onAssociationChangedforObjectView(this, new global::System.ComponentModel.CollectionChangeEventArgs(collectionChangeAction, entity));
				}
				if (this._onAssociationChanged != null)
				{
					this._onAssociationChanged(this, new global::System.ComponentModel.CollectionChangeEventArgs(collectionChangeAction, entity));
				}
			}
		}

		// Token: 0x060037D6 RID: 14294 RVA: 0x000B5B3C File Offset: 0x000B3D3C
		global::System.Collections.IList global::System.ComponentModel.IListSource.GetList()
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = null;
			if (this.WrappedOwner.Entity != null && this.RelationshipSet != null)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = ((global::System.Data.Entity.Core.Metadata.Edm.AssociationSet)this.RelationshipSet).AssociationSetEnds[this.ToEndMember.Name].EntitySet;
				global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType2 = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)((global::System.Data.Entity.Core.Metadata.Edm.RefType)this.ToEndMember.TypeUsage.EdmType).ElementType;
				global::System.Data.Entity.Core.Metadata.Edm.EntityType elementType = entitySet.ElementType;
				if (entityType2.IsAssignableFrom(elementType))
				{
					entityType = elementType;
				}
				else
				{
					entityType = entityType2;
				}
			}
			return global::System.Data.Entity.Core.Objects.ObjectViewFactory.CreateViewForEntityCollection<TEntity>(entityType, this);
		}

		// Token: 0x060037D7 RID: 14295 RVA: 0x000B5BC5 File Offset: 0x000B3DC5
		public override void Load(global::System.Data.Entity.Core.Objects.MergeOption mergeOption)
		{
			this.CheckOwnerNull();
			this.Load(null, mergeOption);
		}

		// Token: 0x060037D8 RID: 14296 RVA: 0x000B5BD5 File Offset: 0x000B3DD5
		public override global::System.Threading.Tasks.Task LoadAsync(global::System.Data.Entity.Core.Objects.MergeOption mergeOption, global::System.Threading.CancellationToken cancellationToken)
		{
			this.CheckOwnerNull();
			cancellationToken.ThrowIfCancellationRequested();
			return this.LoadAsync(null, mergeOption, cancellationToken);
		}

		// Token: 0x060037D9 RID: 14297 RVA: 0x000B5BF0 File Offset: 0x000B3DF0
		public void Attach(global::System.Collections.Generic.IEnumerable<TEntity> entities)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<TEntity>>(entities, "entities");
			this.CheckOwnerNull();
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>();
			foreach (TEntity tentity in entities)
			{
				list.Add(this.EntityWrapperFactory.WrapEntityUsingContext(tentity, this.ObjectContext));
			}
			base.Attach(list, true);
		}

		// Token: 0x060037DA RID: 14298 RVA: 0x000B5C70 File Offset: 0x000B3E70
		public void Attach(TEntity entity)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<TEntity>(entity, "entity");
			base.Attach(new global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper[]
			{
				this.EntityWrapperFactory.WrapEntityUsingContext(entity, this.ObjectContext)
			}, false);
		}

		// Token: 0x060037DB RID: 14299 RVA: 0x000B5CA8 File Offset: 0x000B3EA8
		internal virtual void Load(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper> collection, global::System.Data.Entity.Core.Objects.MergeOption mergeOption)
		{
			bool flag;
			global::System.Data.Entity.Core.Objects.ObjectQuery<TEntity> objectQuery = this.ValidateLoad<TEntity>(mergeOption, "EntityCollection", out flag);
			this._suppressEvents = true;
			try
			{
				if (collection == null)
				{
					global::System.Collections.Generic.IEnumerable<TEntity> collection2;
					if (flag)
					{
						collection2 = objectQuery.Execute(objectQuery.MergeOption);
					}
					else
					{
						collection2 = global::System.Linq.Enumerable.Empty<TEntity>();
					}
					this.Merge<TEntity>(collection2, mergeOption, true);
				}
				else
				{
					this.Merge<TEntity>(collection, mergeOption, true);
				}
			}
			finally
			{
				this._suppressEvents = false;
			}
			this.OnAssociationChanged(global::System.ComponentModel.CollectionChangeAction.Refresh, null);
		}

		// Token: 0x060037DC RID: 14300 RVA: 0x000B5D1C File Offset: 0x000B3F1C
		internal virtual async global::System.Threading.Tasks.Task LoadAsync(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper> collection, global::System.Data.Entity.Core.Objects.MergeOption mergeOption, global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			bool flag;
			global::System.Data.Entity.Core.Objects.ObjectQuery<TEntity> objectQuery = this.ValidateLoad<TEntity>(mergeOption, "EntityCollection", out flag);
			this._suppressEvents = true;
			try
			{
				if (collection == null)
				{
					global::System.Collections.Generic.IEnumerable<TEntity> collection2;
					if (flag)
					{
						collection2 = await(await objectQuery.ExecuteAsync(objectQuery.MergeOption, cancellationToken).WithCurrentCulture<global::System.Data.Entity.Core.Objects.ObjectResult<TEntity>>()).ToListAsync(cancellationToken).WithCurrentCulture<global::System.Collections.Generic.List<TEntity>>();
					}
					else
					{
						collection2 = global::System.Linq.Enumerable.Empty<TEntity>();
					}
					this.Merge<TEntity>(collection2, mergeOption, true);
				}
				else
				{
					this.Merge<TEntity>(collection, mergeOption, true);
				}
			}
			finally
			{
				this._suppressEvents = false;
			}
			this.OnAssociationChanged(global::System.ComponentModel.CollectionChangeAction.Refresh, null);
		}

		// Token: 0x060037DD RID: 14301 RVA: 0x000B5D79 File Offset: 0x000B3F79
		public void Add(TEntity item)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<TEntity>(item, "item");
			base.Add(this.EntityWrapperFactory.WrapEntityUsingContext(item, this.ObjectContext));
		}

		// Token: 0x060037DE RID: 14302 RVA: 0x000B5DA4 File Offset: 0x000B3FA4
		internal override void DisconnectedAdd(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity)
		{
			if (wrappedEntity.Context != null && wrappedEntity.MergeOption != global::System.Data.Entity.Core.Objects.MergeOption.NoTracking)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.RelatedEnd_UnableToAddEntity);
			}
			this.VerifyType(wrappedEntity);
			base.AddToCache(wrappedEntity, false);
			this.OnAssociationChanged(global::System.ComponentModel.CollectionChangeAction.Add, wrappedEntity.Entity);
		}

		// Token: 0x060037DF RID: 14303 RVA: 0x000B5DDE File Offset: 0x000B3FDE
		internal override bool DisconnectedRemove(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity)
		{
			if (wrappedEntity.Context != null && wrappedEntity.MergeOption != global::System.Data.Entity.Core.Objects.MergeOption.NoTracking)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.RelatedEnd_UnableToRemoveEntity);
			}
			bool result = base.RemoveFromCache(wrappedEntity, false, false);
			this.OnAssociationChanged(global::System.ComponentModel.CollectionChangeAction.Remove, wrappedEntity.Entity);
			return result;
		}

		// Token: 0x060037E0 RID: 14304 RVA: 0x000B5E12 File Offset: 0x000B4012
		public bool Remove(TEntity item)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<TEntity>(item, "item");
			base.DeferredLoad();
			return this.RemoveInternal(item);
		}

		// Token: 0x060037E1 RID: 14305 RVA: 0x000B5E2D File Offset: 0x000B402D
		internal bool RemoveInternal(TEntity entity)
		{
			return base.Remove(this.EntityWrapperFactory.WrapEntityUsingContext(entity, this.ObjectContext), false);
		}

		// Token: 0x060037E2 RID: 14306 RVA: 0x000B5E50 File Offset: 0x000B4050
		internal override void Include(bool addRelationshipAsUnchanged, bool doAttach)
		{
			if (this._wrappedRelatedEntities != null && this.ObjectContext != null)
			{
				foreach (global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper entityWrapper in new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>(this._wrappedRelatedEntities.Values))
				{
					global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper entityWrapper2 = this.EntityWrapperFactory.WrapEntityUsingContext(entityWrapper.Entity, this.WrappedOwner.Context);
					if (entityWrapper2 != entityWrapper)
					{
						this._wrappedRelatedEntities[(TEntity)((object)entityWrapper2.Entity)] = entityWrapper2;
					}
					base.IncludeEntity(entityWrapper2, addRelationshipAsUnchanged, doAttach);
				}
			}
		}

		// Token: 0x060037E3 RID: 14307 RVA: 0x000B5EFC File Offset: 0x000B40FC
		internal override void Exclude()
		{
			if (this._wrappedRelatedEntities != null && this.ObjectContext != null)
			{
				if (!base.IsForeignKey)
				{
					using (global::System.Collections.Generic.Dictionary<TEntity, global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>.ValueCollection.Enumerator enumerator = this._wrappedRelatedEntities.Values.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity = enumerator.Current;
							base.ExcludeEntity(wrappedEntity);
						}
						return;
					}
				}
				global::System.Data.Entity.Core.Objects.Internal.TransactionManager transactionManager = this.ObjectContext.ObjectStateManager.TransactionManager;
				foreach (global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity2 in new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>(this._wrappedRelatedEntities.Values))
				{
					global::System.Data.Entity.Core.Objects.DataClasses.EntityReference entityReference = base.GetOtherEndOfRelationship(wrappedEntity2) as global::System.Data.Entity.Core.Objects.DataClasses.EntityReference;
					bool flag = transactionManager.PopulatedEntityReferences.Contains(entityReference);
					bool flag2 = transactionManager.AlignedEntityReferences.Contains(entityReference);
					if (flag || flag2)
					{
						entityReference.Remove(entityReference.CachedValue, flag, false, false, false, true);
						if (flag)
						{
							transactionManager.PopulatedEntityReferences.Remove(entityReference);
						}
						else
						{
							transactionManager.AlignedEntityReferences.Remove(entityReference);
						}
					}
					else
					{
						base.ExcludeEntity(wrappedEntity2);
					}
				}
			}
		}

		// Token: 0x060037E4 RID: 14308 RVA: 0x000B6044 File Offset: 0x000B4244
		internal override void ClearCollectionOrRef(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity, global::System.Data.Entity.Core.Objects.DataClasses.RelationshipNavigation navigation, bool doCascadeDelete)
		{
			if (this._wrappedRelatedEntities != null)
			{
				foreach (global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper entityWrapper in new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>(this._wrappedRelatedEntities.Values))
				{
					if (wrappedEntity.Entity == entityWrapper.Entity && navigation.Equals(base.RelationshipNavigation))
					{
						base.Remove(entityWrapper, false, false, false, false, false);
					}
					else
					{
						base.Remove(entityWrapper, true, doCascadeDelete, false, false, false);
					}
				}
			}
		}

		// Token: 0x060037E5 RID: 14309 RVA: 0x000B60D8 File Offset: 0x000B42D8
		internal override void ClearWrappedValues()
		{
			if (this._wrappedRelatedEntities != null)
			{
				this._wrappedRelatedEntities.Clear();
			}
			if (this._relatedEntities != null)
			{
				this._relatedEntities.Clear();
			}
		}

		// Token: 0x060037E6 RID: 14310 RVA: 0x000B6100 File Offset: 0x000B4300
		internal override bool CanSetEntityType(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity)
		{
			return wrappedEntity.Entity is TEntity;
		}

		// Token: 0x060037E7 RID: 14311 RVA: 0x000B6110 File Offset: 0x000B4310
		internal override void VerifyType(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity)
		{
			if (!this.CanSetEntityType(wrappedEntity))
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.RelatedEnd_InvalidContainedType_Collection(wrappedEntity.Entity.GetType().FullName, typeof(TEntity).FullName));
			}
		}

		// Token: 0x060037E8 RID: 14312 RVA: 0x000B6145 File Offset: 0x000B4345
		internal override bool RemoveFromLocalCache(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity, bool resetIsLoaded, bool preserveForeignKey)
		{
			if (this._wrappedRelatedEntities != null && this._wrappedRelatedEntities.Remove((TEntity)((object)wrappedEntity.Entity)))
			{
				if (resetIsLoaded)
				{
					this._isLoaded = false;
				}
				return true;
			}
			return false;
		}

		// Token: 0x060037E9 RID: 14313 RVA: 0x000B6174 File Offset: 0x000B4374
		internal override bool RemoveFromObjectCache(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity)
		{
			return base.TargetAccessor.HasProperty && this.WrappedOwner.CollectionRemove(this, wrappedEntity.Entity);
		}

		// Token: 0x060037EA RID: 14314 RVA: 0x000B6197 File Offset: 0x000B4397
		internal override void RetrieveReferentialConstraintProperties(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.KeyValuePair<object, global::System.Data.Entity.Core.Objects.IntBox>> properties, global::System.Collections.Generic.HashSet<object> visited)
		{
		}

		// Token: 0x060037EB RID: 14315 RVA: 0x000B6199 File Offset: 0x000B4399
		internal override bool IsEmpty()
		{
			return this._wrappedRelatedEntities == null || this._wrappedRelatedEntities.Count == 0;
		}

		// Token: 0x060037EC RID: 14316 RVA: 0x000B61B3 File Offset: 0x000B43B3
		internal override void VerifyMultiplicityConstraintsForAdd(bool applyConstraints)
		{
		}

		// Token: 0x060037ED RID: 14317 RVA: 0x000B61B5 File Offset: 0x000B43B5
		internal override void OnRelatedEndClear()
		{
			this._isLoaded = false;
		}

		// Token: 0x060037EE RID: 14318 RVA: 0x000B61BE File Offset: 0x000B43BE
		internal override bool ContainsEntity(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity)
		{
			return this._wrappedRelatedEntities != null && this._wrappedRelatedEntities.ContainsKey((TEntity)((object)wrappedEntity.Entity));
		}

		// Token: 0x060037EF RID: 14319 RVA: 0x000B61E0 File Offset: 0x000B43E0
		public new global::System.Collections.Generic.IEnumerator<TEntity> GetEnumerator()
		{
			base.DeferredLoad();
			return this.WrappedRelatedEntities.Keys.GetEnumerator();
		}

		// Token: 0x060037F0 RID: 14320 RVA: 0x000B61FD File Offset: 0x000B43FD
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			base.DeferredLoad();
			return this.WrappedRelatedEntities.Keys.GetEnumerator();
		}

		// Token: 0x060037F1 RID: 14321 RVA: 0x000B621A File Offset: 0x000B441A
		internal override global::System.Collections.IEnumerable GetInternalEnumerable()
		{
			return this.WrappedRelatedEntities.Keys;
		}

		// Token: 0x060037F2 RID: 14322 RVA: 0x000B6227 File Offset: 0x000B4427
		internal override global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper> GetWrappedEntities()
		{
			return this.WrappedRelatedEntities.Values;
		}

		// Token: 0x060037F3 RID: 14323 RVA: 0x000B6234 File Offset: 0x000B4434
		public void Clear()
		{
			base.DeferredLoad();
			if (this.WrappedOwner.Entity != null)
			{
				bool flag = this.CountInternal > 0;
				if (this._wrappedRelatedEntities != null)
				{
					global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>(this._wrappedRelatedEntities.Values);
					try
					{
						this._suppressEvents = true;
						foreach (global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity in list)
						{
							base.Remove(wrappedEntity, false);
							if (base.UsingNoTracking)
							{
								base.GetOtherEndOfRelationship(wrappedEntity).OnRelatedEndClear();
							}
						}
					}
					finally
					{
						this._suppressEvents = false;
					}
					if (base.UsingNoTracking)
					{
						this._isLoaded = false;
					}
				}
				if (flag)
				{
					this.OnAssociationChanged(global::System.ComponentModel.CollectionChangeAction.Refresh, null);
					return;
				}
			}
			else if (this._wrappedRelatedEntities != null)
			{
				this._wrappedRelatedEntities.Clear();
			}
		}

		// Token: 0x060037F4 RID: 14324 RVA: 0x000B631C File Offset: 0x000B451C
		public bool Contains(TEntity item)
		{
			base.DeferredLoad();
			return this._wrappedRelatedEntities != null && this._wrappedRelatedEntities.ContainsKey(item);
		}

		// Token: 0x060037F5 RID: 14325 RVA: 0x000B633A File Offset: 0x000B453A
		public void CopyTo(TEntity[] array, int arrayIndex)
		{
			base.DeferredLoad();
			this.WrappedRelatedEntities.Keys.CopyTo(array, arrayIndex);
		}

		// Token: 0x060037F6 RID: 14326 RVA: 0x000B6354 File Offset: 0x000B4554
		internal virtual void BulkDeleteAll(global::System.Collections.Generic.List<object> list)
		{
			if (list.Count > 0)
			{
				this._suppressEvents = true;
				try
				{
					foreach (object obj in list)
					{
						this.RemoveInternal(obj as TEntity);
					}
				}
				finally
				{
					this._suppressEvents = false;
				}
				this.OnAssociationChanged(global::System.ComponentModel.CollectionChangeAction.Refresh, null);
			}
		}

		// Token: 0x060037F7 RID: 14327 RVA: 0x000B63DC File Offset: 0x000B45DC
		internal override bool CheckIfNavigationPropertyContainsEntity(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrapper)
		{
			if (!base.TargetAccessor.HasProperty)
			{
				return false;
			}
			bool state = base.DisableLazyLoading();
			try
			{
				object navigationPropertyValue = this.WrappedOwner.GetNavigationPropertyValue(this);
				if (navigationPropertyValue != null)
				{
					global::System.Collections.Generic.IEnumerable<TEntity> enumerable = navigationPropertyValue as global::System.Collections.Generic.IEnumerable<!0>;
					if (enumerable == null)
					{
						throw new global::System.Data.Entity.Core.EntityException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_UnableToEnumerateCollection(base.TargetAccessor.PropertyName, this.WrappedOwner.Entity.GetType().FullName));
					}
					global::System.Collections.Generic.HashSet<TEntity> hashSet = navigationPropertyValue as global::System.Collections.Generic.HashSet<TEntity>;
					if (!wrapper.OverridesEqualsOrGetHashCode || (hashSet != null && hashSet.Comparer is global::System.Data.Entity.Infrastructure.ObjectReferenceEqualityComparer))
					{
						return enumerable.Contains((TEntity)((object)wrapper.Entity));
					}
					return enumerable.Any((TEntity o) => o == wrapper.Entity);
				}
			}
			finally
			{
				base.ResetLazyLoading(state);
			}
			return false;
		}

		// Token: 0x060037F8 RID: 14328 RVA: 0x000B64CC File Offset: 0x000B46CC
		internal override void VerifyNavigationPropertyForAdd(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrapper)
		{
		}

		// Token: 0x060037F9 RID: 14329 RVA: 0x000B64D0 File Offset: 0x000B46D0
		[global::System.Runtime.Serialization.OnSerializing]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void OnSerializing(global::System.Runtime.Serialization.StreamingContext context)
		{
			if (!(this.WrappedOwner.Entity is global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithRelationships))
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.RelatedEnd_CannotSerialize("EntityCollection"));
			}
			this._relatedEntities = ((this._wrappedRelatedEntities == null) ? null : new global::System.Collections.Generic.HashSet<TEntity>(this._wrappedRelatedEntities.Keys, global::System.Data.Entity.Infrastructure.ObjectReferenceEqualityComparer.Default));
		}

		// Token: 0x060037FA RID: 14330 RVA: 0x000B6528 File Offset: 0x000B4728
		[global::System.Runtime.Serialization.OnDeserialized]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void OnCollectionDeserialized(global::System.Runtime.Serialization.StreamingContext context)
		{
			if (this._relatedEntities != null)
			{
				this._relatedEntities.OnDeserialization(null);
				this._wrappedRelatedEntities = new global::System.Collections.Generic.Dictionary<TEntity, global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>(global::System.Data.Entity.Infrastructure.ObjectReferenceEqualityComparer.Default);
				foreach (TEntity tentity in this._relatedEntities)
				{
					this._wrappedRelatedEntities.Add(tentity, this.EntityWrapperFactory.WrapEntityUsingContext(tentity, this.ObjectContext));
				}
			}
		}

		// Token: 0x060037FB RID: 14331 RVA: 0x000B65BC File Offset: 0x000B47BC
		public global::System.Data.Entity.Core.Objects.ObjectQuery<TEntity> CreateSourceQuery()
		{
			this.CheckOwnerNull();
			bool flag;
			return base.CreateSourceQuery<TEntity>(base.DefaultMergeOption, out flag);
		}

		// Token: 0x060037FC RID: 14332 RVA: 0x000B65DD File Offset: 0x000B47DD
		internal override global::System.Collections.IEnumerable CreateSourceQueryInternal()
		{
			return this.CreateSourceQuery();
		}

		// Token: 0x060037FD RID: 14333 RVA: 0x000B65E5 File Offset: 0x000B47E5
		internal override void AddToLocalCache(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity, bool applyConstraints)
		{
			this.WrappedRelatedEntities[(TEntity)((object)wrappedEntity.Entity)] = wrappedEntity;
		}

		// Token: 0x060037FE RID: 14334 RVA: 0x000B65FE File Offset: 0x000B47FE
		internal override void AddToObjectCache(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity)
		{
			if (base.TargetAccessor.HasProperty)
			{
				this.WrappedOwner.CollectionAdd(this, wrappedEntity.Entity);
			}
		}

		// Token: 0x040012E3 RID: 4835
		private global::System.Collections.Generic.HashSet<TEntity> _relatedEntities;

		// Token: 0x040012E4 RID: 4836
		[global::System.NonSerialized]
		private global::System.ComponentModel.CollectionChangeEventHandler _onAssociationChangedforObjectView;

		// Token: 0x040012E5 RID: 4837
		[global::System.NonSerialized]
		private global::System.Collections.Generic.Dictionary<TEntity, global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper> _wrappedRelatedEntities;
	}
}
