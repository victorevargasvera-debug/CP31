using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity.Core.Objects.Internal;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;

namespace System.Data.Entity.Core.Objects
{
	// Token: 0x02000424 RID: 1060
	public class ObjectStateManager : global::System.Data.Entity.Core.IEntityStateManager
	{
		// Token: 0x0600331C RID: 13084 RVA: 0x000A21CF File Offset: 0x000A03CF
		internal ObjectStateManager()
		{
		}

		// Token: 0x0600331D RID: 13085 RVA: 0x000A21E4 File Offset: 0x000A03E4
		public ObjectStateManager(global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace metadataWorkspace)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace>(metadataWorkspace, "metadataWorkspace");
			this._metadataWorkspace = metadataWorkspace;
			this._metadataStore = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmType, global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata>();
			this._metadataMapping = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.EntitySetQualifiedType, global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata>(global::System.Data.Entity.Core.Objects.EntitySetQualifiedType.EqualityComparer);
			this._isDisposed = false;
			this._entityWrapperFactory = new global::System.Data.Entity.Core.Objects.Internal.EntityWrapperFactory();
			this.TransactionManager = new global::System.Data.Entity.Core.Objects.Internal.TransactionManager();
		}

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x0600331E RID: 13086 RVA: 0x000A224D File Offset: 0x000A044D
		// (set) Token: 0x0600331F RID: 13087 RVA: 0x000A2255 File Offset: 0x000A0455
		internal virtual object ChangingObject { get; set; }

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x06003320 RID: 13088 RVA: 0x000A225E File Offset: 0x000A045E
		// (set) Token: 0x06003321 RID: 13089 RVA: 0x000A2266 File Offset: 0x000A0466
		internal virtual string ChangingEntityMember { get; set; }

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x06003322 RID: 13090 RVA: 0x000A226F File Offset: 0x000A046F
		// (set) Token: 0x06003323 RID: 13091 RVA: 0x000A2277 File Offset: 0x000A0477
		internal virtual string ChangingMember { get; set; }

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x06003324 RID: 13092 RVA: 0x000A2280 File Offset: 0x000A0480
		// (set) Token: 0x06003325 RID: 13093 RVA: 0x000A2288 File Offset: 0x000A0488
		internal virtual global::System.Data.Entity.EntityState ChangingState { get; set; }

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x06003326 RID: 13094 RVA: 0x000A2291 File Offset: 0x000A0491
		// (set) Token: 0x06003327 RID: 13095 RVA: 0x000A2299 File Offset: 0x000A0499
		internal virtual bool SaveOriginalValues { get; set; }

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x06003328 RID: 13096 RVA: 0x000A22A2 File Offset: 0x000A04A2
		// (set) Token: 0x06003329 RID: 13097 RVA: 0x000A22AA File Offset: 0x000A04AA
		internal virtual object ChangingOldValue { get; set; }

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x0600332A RID: 13098 RVA: 0x000A22B3 File Offset: 0x000A04B3
		internal virtual bool InRelationshipFixup
		{
			get
			{
				return this._inRelationshipFixup;
			}
		}

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x0600332B RID: 13099 RVA: 0x000A22BB File Offset: 0x000A04BB
		internal virtual global::System.Data.Entity.Core.Objects.Internal.ComplexTypeMaterializer ComplexTypeMaterializer
		{
			get
			{
				if (this._complexTypeMaterializer == null)
				{
					this._complexTypeMaterializer = new global::System.Data.Entity.Core.Objects.Internal.ComplexTypeMaterializer(this.MetadataWorkspace);
				}
				return this._complexTypeMaterializer;
			}
		}

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x0600332C RID: 13100 RVA: 0x000A22DC File Offset: 0x000A04DC
		// (set) Token: 0x0600332D RID: 13101 RVA: 0x000A22E4 File Offset: 0x000A04E4
		internal virtual global::System.Data.Entity.Core.Objects.Internal.TransactionManager TransactionManager { get; private set; }

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x0600332E RID: 13102 RVA: 0x000A22ED File Offset: 0x000A04ED
		internal virtual global::System.Data.Entity.Core.Objects.Internal.EntityWrapperFactory EntityWrapperFactory
		{
			get
			{
				return this._entityWrapperFactory;
			}
		}

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x0600332F RID: 13103 RVA: 0x000A22F5 File Offset: 0x000A04F5
		public virtual global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace MetadataWorkspace
		{
			get
			{
				return this._metadataWorkspace;
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06003330 RID: 13104 RVA: 0x000A22FD File Offset: 0x000A04FD
		// (remove) Token: 0x06003331 RID: 13105 RVA: 0x000A2316 File Offset: 0x000A0516
		public event global::System.ComponentModel.CollectionChangeEventHandler ObjectStateManagerChanged
		{
			add
			{
				this.onObjectStateManagerChangedDelegate = (global::System.ComponentModel.CollectionChangeEventHandler)global::System.Delegate.Combine(this.onObjectStateManagerChangedDelegate, value);
			}
			remove
			{
				this.onObjectStateManagerChangedDelegate = (global::System.ComponentModel.CollectionChangeEventHandler)global::System.Delegate.Remove(this.onObjectStateManagerChangedDelegate, value);
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06003332 RID: 13106 RVA: 0x000A232F File Offset: 0x000A052F
		// (remove) Token: 0x06003333 RID: 13107 RVA: 0x000A2348 File Offset: 0x000A0548
		internal event global::System.ComponentModel.CollectionChangeEventHandler EntityDeleted
		{
			add
			{
				this.onEntityDeletedDelegate = (global::System.ComponentModel.CollectionChangeEventHandler)global::System.Delegate.Combine(this.onEntityDeletedDelegate, value);
			}
			remove
			{
				this.onEntityDeletedDelegate = (global::System.ComponentModel.CollectionChangeEventHandler)global::System.Delegate.Remove(this.onEntityDeletedDelegate, value);
			}
		}

		// Token: 0x06003334 RID: 13108 RVA: 0x000A2361 File Offset: 0x000A0561
		internal virtual void OnObjectStateManagerChanged(global::System.ComponentModel.CollectionChangeAction action, object entity)
		{
			if (this.onObjectStateManagerChangedDelegate != null)
			{
				this.onObjectStateManagerChangedDelegate(this, new global::System.ComponentModel.CollectionChangeEventArgs(action, entity));
			}
		}

		// Token: 0x06003335 RID: 13109 RVA: 0x000A237E File Offset: 0x000A057E
		private void OnEntityDeleted(global::System.ComponentModel.CollectionChangeAction action, object entity)
		{
			if (this.onEntityDeletedDelegate != null)
			{
				this.onEntityDeletedDelegate(this, new global::System.ComponentModel.CollectionChangeEventArgs(action, entity));
			}
		}

		// Token: 0x06003336 RID: 13110 RVA: 0x000A239B File Offset: 0x000A059B
		internal virtual global::System.Data.Entity.Core.Objects.EntityEntry AddKeyEntry(global::System.Data.Entity.Core.EntityKey entityKey, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet)
		{
			if (this.FindEntityEntry(entityKey) != null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateManager_ObjectStateManagerContainsThisEntityKey(entitySet.ElementType.Name));
			}
			return this.InternalAddEntityEntry(entityKey, entitySet);
		}

		// Token: 0x06003337 RID: 13111 RVA: 0x000A23C4 File Offset: 0x000A05C4
		internal global::System.Data.Entity.Core.Objects.EntityEntry GetOrAddKeyEntry(global::System.Data.Entity.Core.EntityKey entityKey, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet)
		{
			global::System.Data.Entity.Core.Objects.EntityEntry result;
			if (this.TryGetEntityEntry(entityKey, out result))
			{
				return result;
			}
			return this.InternalAddEntityEntry(entityKey, entitySet);
		}

		// Token: 0x06003338 RID: 13112 RVA: 0x000A23E8 File Offset: 0x000A05E8
		private global::System.Data.Entity.Core.Objects.EntityEntry InternalAddEntityEntry(global::System.Data.Entity.Core.EntityKey entityKey, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet)
		{
			global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata orAddStateManagerTypeMetadata = this.GetOrAddStateManagerTypeMetadata(entitySet.ElementType);
			global::System.Data.Entity.Core.Objects.EntityEntry entityEntry = new global::System.Data.Entity.Core.Objects.EntityEntry(entityKey, entitySet, this, orAddStateManagerTypeMetadata);
			this.AddEntityEntryToDictionary(entityEntry, entityEntry.State);
			return entityEntry;
		}

		// Token: 0x06003339 RID: 13113 RVA: 0x000A241C File Offset: 0x000A061C
		private void ValidateProxyType(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity)
		{
			global::System.Type identityType = wrappedEntity.IdentityType;
			global::System.Type type = wrappedEntity.Entity.GetType();
			if (identityType != type)
			{
				global::System.Data.Entity.Core.Objects.Internal.EntityProxyTypeInfo proxyType = global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.GetProxyType(this.MetadataWorkspace.GetItem<global::System.Data.Entity.Core.Metadata.Edm.ClrEntityType>(identityType.FullNameWithNesting(), global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OSpace), this.MetadataWorkspace);
				if (proxyType == null || proxyType.ProxyType != type)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityProxyTypeInfo_DuplicateOSpaceType(identityType.FullName));
				}
			}
		}

		// Token: 0x0600333A RID: 13114 RVA: 0x000A2488 File Offset: 0x000A0688
		internal virtual global::System.Data.Entity.Core.Objects.EntityEntry AddEntry(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedObject, global::System.Data.Entity.Core.EntityKey passedKey, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, string argumentName, bool isAdded)
		{
			global::System.Data.Entity.Core.EntityKey entityKey = passedKey;
			global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata orAddStateManagerTypeMetadata = this.GetOrAddStateManagerTypeMetadata(wrappedObject.IdentityType, entitySet);
			this.ValidateProxyType(wrappedObject);
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = orAddStateManagerTypeMetadata.CdmMetadata.EdmType;
			if (isAdded && !entitySet.ElementType.IsAssignableFrom(edmType))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ObjectStateManager_EntityTypeDoesnotMatchtoEntitySetType(wrappedObject.Entity.GetType().Name, global::System.Data.Entity.Core.Common.TypeHelpers.GetFullName(entitySet.EntityContainer.Name, entitySet.Name)), argumentName);
			}
			global::System.Data.Entity.Core.EntityKey entityKey2;
			if (isAdded)
			{
				entityKey2 = wrappedObject.GetEntityKeyFromEntity();
			}
			else
			{
				entityKey2 = wrappedObject.EntityKey;
			}
			if (entityKey2 != null)
			{
				entityKey = entityKey2;
				if (entityKey == null)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityKey_UnexpectedNull);
				}
				if (wrappedObject.EntityKey != entityKey)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityKey_DoesntMatchKeyOnEntity(wrappedObject.Entity.GetType().FullName));
				}
			}
			if (entityKey != null && !entityKey.IsTemporary && !isAdded)
			{
				this.CheckKeyMatchesEntity(wrappedObject, entityKey, entitySet, false);
			}
			global::System.Data.Entity.Core.Objects.EntityEntry entityEntry;
			if (!isAdded || ((!(entityKey2 == null) || (entityEntry = this.FindEntityEntry(wrappedObject.Entity)) == null) && (!(entityKey2 != null) || (entityEntry = this.FindEntityEntry(entityKey2)) == null)))
			{
				if (entityKey == null || (isAdded && !entityKey.IsTemporary))
				{
					entityKey = new global::System.Data.Entity.Core.EntityKey(entitySet);
					wrappedObject.EntityKey = entityKey;
				}
				if (!wrappedObject.OwnsRelationshipManager)
				{
					wrappedObject.RelationshipManager.ClearRelatedEndWrappers();
				}
				global::System.Data.Entity.Core.Objects.EntityEntry entityEntry2 = new global::System.Data.Entity.Core.Objects.EntityEntry(wrappedObject, entityKey, entitySet, this, orAddStateManagerTypeMetadata, isAdded ? global::System.Data.Entity.EntityState.Added : global::System.Data.Entity.EntityState.Unchanged);
				entityEntry2.AttachObjectStateManagerToEntity();
				this.AddEntityEntryToDictionary(entityEntry2, entityEntry2.State);
				this.OnObjectStateManagerChanged(global::System.ComponentModel.CollectionChangeAction.Add, entityEntry2.Entity);
				if (!isAdded)
				{
					this.FixupReferencesByForeignKeys(entityEntry2, false);
				}
				return entityEntry2;
			}
			if (entityEntry.Entity != wrappedObject.Entity)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateManager_ObjectStateManagerContainsThisEntityKey(wrappedObject.IdentityType.FullName));
			}
			if (entityEntry.State != global::System.Data.Entity.EntityState.Added)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateManager_DoesnotAllowToReAddUnchangedOrModifiedOrDeletedEntity(entityEntry.State));
			}
			return null;
		}

		// Token: 0x0600333B RID: 13115 RVA: 0x000A265C File Offset: 0x000A085C
		internal virtual void FixupReferencesByForeignKeys(global::System.Data.Entity.Core.Objects.EntityEntry newEntry, bool replaceAddedRefs = false)
		{
			if (!((global::System.Data.Entity.Core.Metadata.Edm.EntitySet)newEntry.EntitySet).HasForeignKeyRelationships)
			{
				return;
			}
			newEntry.FixupReferencesByForeignKeys(replaceAddedRefs, null);
			foreach (global::System.Data.Entity.Core.Objects.EntityEntry entityEntry in this.GetNonFixedupEntriesContainingForeignKey(newEntry.EntityKey))
			{
				entityEntry.FixupReferencesByForeignKeys(false, newEntry.EntitySet);
			}
			this.RemoveForeignKeyFromIndex(newEntry.EntityKey);
		}

		// Token: 0x0600333C RID: 13116 RVA: 0x000A26DC File Offset: 0x000A08DC
		internal virtual void AddEntryContainingForeignKeyToIndex(global::System.Data.Entity.Core.Objects.DataClasses.EntityReference relatedEnd, global::System.Data.Entity.Core.EntityKey foreignKey, global::System.Data.Entity.Core.Objects.EntityEntry entry)
		{
			global::System.Collections.Generic.HashSet<global::System.Tuple<global::System.Data.Entity.Core.Objects.DataClasses.EntityReference, global::System.Data.Entity.Core.Objects.EntityEntry>> hashSet;
			if (!this._danglingForeignKeys.TryGetValue(foreignKey, out hashSet))
			{
				hashSet = new global::System.Collections.Generic.HashSet<global::System.Tuple<global::System.Data.Entity.Core.Objects.DataClasses.EntityReference, global::System.Data.Entity.Core.Objects.EntityEntry>>();
				this._danglingForeignKeys.Add(foreignKey, hashSet);
			}
			hashSet.Add(global::System.Tuple.Create<global::System.Data.Entity.Core.Objects.DataClasses.EntityReference, global::System.Data.Entity.Core.Objects.EntityEntry>(relatedEnd, entry));
		}

		// Token: 0x0600333D RID: 13117 RVA: 0x000A271C File Offset: 0x000A091C
		[global::System.Diagnostics.Conditional("DEBUG")]
		internal virtual void AssertEntryDoesNotExistInForeignKeyIndex(global::System.Data.Entity.Core.Objects.EntityEntry entry)
		{
			using (global::System.Collections.Generic.IEnumerator<global::System.Tuple<global::System.Data.Entity.Core.Objects.DataClasses.EntityReference, global::System.Data.Entity.Core.Objects.EntityEntry>> enumerator = this._danglingForeignKeys.SelectMany((global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.EntityKey, global::System.Collections.Generic.HashSet<global::System.Tuple<global::System.Data.Entity.Core.Objects.DataClasses.EntityReference, global::System.Data.Entity.Core.Objects.EntityEntry>>> kv) => kv.Value).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Item2.State != global::System.Data.Entity.EntityState.Detached)
					{
						global::System.Data.Entity.EntityState state = entry.State;
					}
				}
			}
		}

		// Token: 0x0600333E RID: 13118 RVA: 0x000A279C File Offset: 0x000A099C
		[global::System.Diagnostics.Conditional("DEBUG")]
		internal virtual void AssertAllForeignKeyIndexEntriesAreValid()
		{
			if (this.GetMaxEntityEntriesForDetectChanges() > 100)
			{
				return;
			}
			new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Objects.ObjectStateEntry>(this.GetObjectStateEntriesInternal(~global::System.Data.Entity.EntityState.Detached));
			foreach (global::System.Tuple<global::System.Data.Entity.Core.Objects.DataClasses.EntityReference, global::System.Data.Entity.Core.Objects.EntityEntry> tuple in this._danglingForeignKeys.SelectMany((global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.EntityKey, global::System.Collections.Generic.HashSet<global::System.Tuple<global::System.Data.Entity.Core.Objects.DataClasses.EntityReference, global::System.Data.Entity.Core.Objects.EntityEntry>>> kv) => kv.Value))
			{
			}
		}

		// Token: 0x0600333F RID: 13119 RVA: 0x000A2820 File Offset: 0x000A0A20
		internal virtual void RemoveEntryFromForeignKeyIndex(global::System.Data.Entity.Core.Objects.DataClasses.EntityReference relatedEnd, global::System.Data.Entity.Core.EntityKey foreignKey, global::System.Data.Entity.Core.Objects.EntityEntry entry)
		{
			global::System.Collections.Generic.HashSet<global::System.Tuple<global::System.Data.Entity.Core.Objects.DataClasses.EntityReference, global::System.Data.Entity.Core.Objects.EntityEntry>> hashSet;
			if (this._danglingForeignKeys.TryGetValue(foreignKey, out hashSet))
			{
				hashSet.Remove(global::System.Tuple.Create<global::System.Data.Entity.Core.Objects.DataClasses.EntityReference, global::System.Data.Entity.Core.Objects.EntityEntry>(relatedEnd, entry));
			}
		}

		// Token: 0x06003340 RID: 13120 RVA: 0x000A284B File Offset: 0x000A0A4B
		internal virtual void RemoveForeignKeyFromIndex(global::System.Data.Entity.Core.EntityKey foreignKey)
		{
			this._danglingForeignKeys.Remove(foreignKey);
		}

		// Token: 0x06003341 RID: 13121 RVA: 0x000A285C File Offset: 0x000A0A5C
		internal virtual global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Objects.EntityEntry> GetNonFixedupEntriesContainingForeignKey(global::System.Data.Entity.Core.EntityKey foreignKey)
		{
			global::System.Collections.Generic.HashSet<global::System.Tuple<global::System.Data.Entity.Core.Objects.DataClasses.EntityReference, global::System.Data.Entity.Core.Objects.EntityEntry>> source;
			if (this._danglingForeignKeys.TryGetValue(foreignKey, out source))
			{
				return (from e in source
				select e.Item2).ToList<global::System.Data.Entity.Core.Objects.EntityEntry>();
			}
			return global::System.Linq.Enumerable.Empty<global::System.Data.Entity.Core.Objects.EntityEntry>();
		}

		// Token: 0x06003342 RID: 13122 RVA: 0x000A28A9 File Offset: 0x000A0AA9
		internal virtual void RememberEntryWithConceptualNull(global::System.Data.Entity.Core.Objects.EntityEntry entry)
		{
			if (this._entriesWithConceptualNulls == null)
			{
				this._entriesWithConceptualNulls = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Objects.EntityEntry>();
			}
			this._entriesWithConceptualNulls.Add(entry);
		}

		// Token: 0x06003343 RID: 13123 RVA: 0x000A28CB File Offset: 0x000A0ACB
		internal virtual bool SomeEntryWithConceptualNullExists()
		{
			return this._entriesWithConceptualNulls != null && this._entriesWithConceptualNulls.Count != 0;
		}

		// Token: 0x06003344 RID: 13124 RVA: 0x000A28E5 File Offset: 0x000A0AE5
		internal virtual bool EntryHasConceptualNull(global::System.Data.Entity.Core.Objects.EntityEntry entry)
		{
			return this._entriesWithConceptualNulls != null && this._entriesWithConceptualNulls.Contains(entry);
		}

		// Token: 0x06003345 RID: 13125 RVA: 0x000A2900 File Offset: 0x000A0B00
		internal virtual void ForgetEntryWithConceptualNull(global::System.Data.Entity.Core.Objects.EntityEntry entry, bool resetAllKeys)
		{
			if (!entry.IsKeyEntry && this._entriesWithConceptualNulls != null && this._entriesWithConceptualNulls.Remove(entry) && entry.RelationshipManager.HasRelationships)
			{
				foreach (global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd in entry.RelationshipManager.Relationships)
				{
					global::System.Data.Entity.Core.Objects.DataClasses.EntityReference entityReference = relatedEnd as global::System.Data.Entity.Core.Objects.DataClasses.EntityReference;
					if (entityReference != null && global::System.Data.Entity.Core.Objects.Internal.ForeignKeyFactory.IsConceptualNullKey(entityReference.CachedForeignKey))
					{
						if (!resetAllKeys)
						{
							this._entriesWithConceptualNulls.Add(entry);
							break;
						}
						entityReference.SetCachedForeignKey(null, null);
					}
				}
			}
		}

		// Token: 0x06003346 RID: 13126 RVA: 0x000A29AC File Offset: 0x000A0BAC
		internal virtual void PromoteKeyEntryInitialization(global::System.Data.Entity.Core.Objects.ObjectContext contextToAttach, global::System.Data.Entity.Core.Objects.EntityEntry keyEntry, global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity, bool replacingEntry)
		{
			global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata orAddStateManagerTypeMetadata = this.GetOrAddStateManagerTypeMetadata(wrappedEntity.IdentityType, (global::System.Data.Entity.Core.Metadata.Edm.EntitySet)keyEntry.EntitySet);
			this.ValidateProxyType(wrappedEntity);
			keyEntry.PromoteKeyEntry(wrappedEntity, orAddStateManagerTypeMetadata);
			this.AddEntryToKeylessStore(keyEntry);
			if (replacingEntry)
			{
				wrappedEntity.SetChangeTracker(null);
			}
			wrappedEntity.SetChangeTracker(keyEntry);
			if (contextToAttach != null)
			{
				wrappedEntity.AttachContext(contextToAttach, (global::System.Data.Entity.Core.Metadata.Edm.EntitySet)keyEntry.EntitySet, global::System.Data.Entity.Core.Objects.MergeOption.AppendOnly);
			}
			wrappedEntity.TakeSnapshot(keyEntry);
			this.OnObjectStateManagerChanged(global::System.ComponentModel.CollectionChangeAction.Add, keyEntry.Entity);
		}

		// Token: 0x06003347 RID: 13127 RVA: 0x000A2A24 File Offset: 0x000A0C24
		internal virtual void PromoteKeyEntry(global::System.Data.Entity.Core.Objects.EntityEntry keyEntry, global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity, bool replacingEntry, bool setIsLoaded, bool keyEntryInitialized)
		{
			if (!keyEntryInitialized)
			{
				this.PromoteKeyEntryInitialization(null, keyEntry, wrappedEntity, replacingEntry);
			}
			bool flag = true;
			try
			{
				foreach (global::System.Data.Entity.Core.Objects.RelationshipEntry relationshipEntry in this.CopyOfRelationshipsByKey(keyEntry.EntityKey))
				{
					if (relationshipEntry.State != global::System.Data.Entity.EntityState.Deleted)
					{
						global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember = keyEntry.GetAssociationEndMember(relationshipEntry);
						global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember otherAssociationEnd = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetOtherAssociationEnd(associationEndMember);
						global::System.Data.Entity.Core.Objects.EntityEntry otherEndOfRelationship = keyEntry.GetOtherEndOfRelationship(relationshipEntry);
						global::System.Data.Entity.Core.Objects.ObjectStateManager.AddEntityToCollectionOrReference(global::System.Data.Entity.Core.Objects.MergeOption.AppendOnly, wrappedEntity, associationEndMember, otherEndOfRelationship.WrappedEntity, otherAssociationEnd, setIsLoaded, true, true);
					}
				}
				this.FixupReferencesByForeignKeys(keyEntry, false);
				flag = false;
			}
			finally
			{
				if (flag)
				{
					keyEntry.DetachObjectStateManagerFromEntity();
					this.RemoveEntryFromKeylessStore(wrappedEntity);
					keyEntry.DegradeEntry();
				}
			}
			if (this.TransactionManager.IsAttachTracking)
			{
				this.TransactionManager.PromotedKeyEntries.Add(wrappedEntity.Entity, keyEntry);
			}
		}

		// Token: 0x06003348 RID: 13128 RVA: 0x000A2AF4 File Offset: 0x000A0CF4
		internal virtual void TrackPromotedRelationship(global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd, global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity)
		{
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper> list;
			if (!this.TransactionManager.PromotedRelationships.TryGetValue(relatedEnd, out list))
			{
				list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>();
				this.TransactionManager.PromotedRelationships.Add(relatedEnd, list);
			}
			list.Add(wrappedEntity);
		}

		// Token: 0x06003349 RID: 13129 RVA: 0x000A2B38 File Offset: 0x000A0D38
		internal virtual void DegradePromotedRelationships()
		{
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>> keyValuePair in this.TransactionManager.PromotedRelationships)
			{
				foreach (global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper entityWrapper in keyValuePair.Value)
				{
					if (keyValuePair.Key.RemoveFromCache(entityWrapper, false, false))
					{
						keyValuePair.Key.OnAssociationChanged(global::System.ComponentModel.CollectionChangeAction.Remove, entityWrapper.Entity);
					}
				}
			}
		}

		// Token: 0x0600334A RID: 13130 RVA: 0x000A2BE4 File Offset: 0x000A0DE4
		internal static void AddEntityToCollectionOrReference(global::System.Data.Entity.Core.Objects.MergeOption mergeOption, global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedSource, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember sourceMember, global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedTarget, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember targetMember, bool setIsLoaded, bool relationshipAlreadyExists, bool inKeyEntryPromotion)
		{
			global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEndInternal = wrappedSource.RelationshipManager.GetRelatedEndInternal(sourceMember.DeclaringType.FullName, targetMember.Name);
			if (targetMember.RelationshipMultiplicity != global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many)
			{
				global::System.Data.Entity.Core.Objects.DataClasses.EntityReference entityReference = (global::System.Data.Entity.Core.Objects.DataClasses.EntityReference)relatedEndInternal;
				switch (mergeOption)
				{
				case global::System.Data.Entity.Core.Objects.MergeOption.AppendOnly:
					if (inKeyEntryPromotion && !entityReference.IsEmpty() && entityReference.ReferenceValue.Entity != wrappedTarget.Entity)
					{
						throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateManager_EntityConflictsWithKeyEntry);
					}
					break;
				case global::System.Data.Entity.Core.Objects.MergeOption.OverwriteChanges:
				case global::System.Data.Entity.Core.Objects.MergeOption.PreserveChanges:
				{
					global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper referenceValue = entityReference.ReferenceValue;
					if (referenceValue != null && referenceValue.Entity != null && referenceValue != wrappedTarget)
					{
						global::System.Data.Entity.Core.Objects.RelationshipEntry relationshipEntry = relatedEndInternal.FindRelationshipEntryInObjectStateManager(referenceValue);
						relatedEndInternal.RemoveAll();
						if (relationshipEntry != null && relationshipEntry.State == global::System.Data.Entity.EntityState.Deleted)
						{
							relationshipEntry.AcceptChanges();
						}
					}
					break;
				}
				}
			}
			global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd = null;
			if (mergeOption == global::System.Data.Entity.Core.Objects.MergeOption.NoTracking)
			{
				relatedEnd = relatedEndInternal.GetOtherEndOfRelationship(wrappedTarget);
				if (relatedEnd.IsLoaded)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.Collections_CannotFillTryDifferentMergeOption(relatedEnd.SourceRoleName, relatedEnd.RelationshipName));
				}
			}
			if (relatedEnd == null)
			{
				relatedEnd = relatedEndInternal.GetOtherEndOfRelationship(wrappedTarget);
			}
			relatedEndInternal.Add(wrappedTarget, true, true, relationshipAlreadyExists, true, true);
			global::System.Data.Entity.Core.Objects.ObjectStateManager.UpdateRelatedEnd(relatedEndInternal, wrappedTarget, setIsLoaded, mergeOption);
			global::System.Data.Entity.Core.Objects.ObjectStateManager.UpdateRelatedEnd(relatedEnd, wrappedSource, setIsLoaded, mergeOption);
			if (inKeyEntryPromotion && wrappedSource.Context.ObjectStateManager.TransactionManager.IsAttachTracking)
			{
				wrappedSource.Context.ObjectStateManager.TrackPromotedRelationship(relatedEndInternal, wrappedTarget);
				wrappedSource.Context.ObjectStateManager.TrackPromotedRelationship(relatedEnd, wrappedSource);
			}
		}

		// Token: 0x0600334B RID: 13131 RVA: 0x000A2D38 File Offset: 0x000A0F38
		private static void UpdateRelatedEnd(global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd, global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedRelatedEntity, bool setIsLoaded, global::System.Data.Entity.Core.Objects.MergeOption mergeOption)
		{
			global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember = (global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember)relatedEnd.ToEndMember;
			if (associationEndMember.RelationshipMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One || associationEndMember.RelationshipMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne)
			{
				if (setIsLoaded)
				{
					relatedEnd.IsLoaded = true;
				}
				if (mergeOption == global::System.Data.Entity.Core.Objects.MergeOption.NoTracking)
				{
					global::System.Data.Entity.Core.EntityKey entityKey = wrappedRelatedEntity.EntityKey;
					if (entityKey == null)
					{
						throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityKey_UnexpectedNull);
					}
					((global::System.Data.Entity.Core.Objects.DataClasses.EntityReference)relatedEnd).DetachedEntityKey = entityKey;
				}
			}
		}

		// Token: 0x0600334C RID: 13132 RVA: 0x000A2D94 File Offset: 0x000A0F94
		internal virtual int UpdateRelationships(global::System.Data.Entity.Core.Objects.ObjectContext context, global::System.Data.Entity.Core.Objects.MergeOption mergeOption, global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember sourceMember, global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedSource, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember targetMember, global::System.Collections.IList targets, bool setIsLoaded)
		{
			int num = 0;
			global::System.Data.Entity.Core.EntityKey sourceKey = wrappedSource.EntityKey;
			context.ObjectStateManager.TransactionManager.BeginGraphUpdate();
			try
			{
				if (targets != null)
				{
					if (mergeOption == global::System.Data.Entity.Core.Objects.MergeOption.NoTracking)
					{
						global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEndInternal = wrappedSource.RelationshipManager.GetRelatedEndInternal(sourceMember.DeclaringType.FullName, targetMember.Name);
						if (!relatedEndInternal.IsEmpty())
						{
							throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.Collections_CannotFillTryDifferentMergeOption(relatedEndInternal.SourceRoleName, relatedEndInternal.RelationshipName));
						}
					}
					global::System.Lazy<global::System.Linq.ILookup<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Objects.RelationshipEntry>> lazy = new global::System.Lazy<global::System.Linq.ILookup<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Objects.RelationshipEntry>>(() => global::System.Data.Entity.Core.Objects.ObjectStateManager.GetRelationshipLookup(context.ObjectStateManager, associationSet, sourceMember, sourceKey));
					foreach (object obj in targets)
					{
						global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper entityWrapper = obj as global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper;
						if (entityWrapper == null)
						{
							entityWrapper = this.EntityWrapperFactory.WrapEntityUsingContext(obj, context);
						}
						num++;
						if (mergeOption == global::System.Data.Entity.Core.Objects.MergeOption.NoTracking)
						{
							global::System.Data.Entity.Core.Objects.ObjectStateManager.AddEntityToCollectionOrReference(global::System.Data.Entity.Core.Objects.MergeOption.NoTracking, wrappedSource, sourceMember, entityWrapper, targetMember, setIsLoaded, true, false);
						}
						else
						{
							global::System.Data.Entity.Core.Objects.ObjectStateManager objectStateManager = context.ObjectStateManager;
							global::System.Data.Entity.Core.EntityKey entityKey = entityWrapper.EntityKey;
							global::System.Data.Entity.EntityState entityState;
							if (!global::System.Data.Entity.Core.Objects.ObjectStateManager.TryUpdateExistingRelationships(context, mergeOption, associationSet, sourceMember, lazy.Value, wrappedSource, targetMember, entityKey, setIsLoaded, out entityState))
							{
								bool flag = true;
								global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity relationshipMultiplicity = sourceMember.RelationshipMultiplicity;
								if (relationshipMultiplicity > global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One)
								{
									if (relationshipMultiplicity != global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many)
									{
									}
								}
								else
								{
									global::System.Linq.ILookup<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Objects.RelationshipEntry> relationshipLookup = global::System.Data.Entity.Core.Objects.ObjectStateManager.GetRelationshipLookup(context.ObjectStateManager, associationSet, targetMember, entityKey);
									flag = !global::System.Data.Entity.Core.Objects.ObjectStateManager.TryUpdateExistingRelationships(context, mergeOption, associationSet, targetMember, relationshipLookup, entityWrapper, sourceMember, sourceKey, setIsLoaded, out entityState);
								}
								if (flag)
								{
									if (entityState != global::System.Data.Entity.EntityState.Deleted)
									{
										global::System.Data.Entity.Core.Objects.ObjectStateManager.AddEntityToCollectionOrReference(mergeOption, wrappedSource, sourceMember, entityWrapper, targetMember, setIsLoaded, false, false);
									}
									else
									{
										global::System.Data.Entity.Core.Objects.RelationshipWrapper wrapper = new global::System.Data.Entity.Core.Objects.RelationshipWrapper(associationSet, sourceMember.Name, sourceKey, targetMember.Name, entityKey);
										objectStateManager.AddNewRelation(wrapper, global::System.Data.Entity.EntityState.Deleted);
									}
								}
							}
						}
					}
				}
				if (num == 0)
				{
					global::System.Data.Entity.Core.Objects.ObjectStateManager.EnsureCollectionNotNull(sourceMember, wrappedSource, targetMember);
				}
			}
			finally
			{
				context.ObjectStateManager.TransactionManager.EndGraphUpdate();
			}
			return num;
		}

		// Token: 0x0600334D RID: 13133 RVA: 0x000A301C File Offset: 0x000A121C
		internal static global::System.Linq.ILookup<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Objects.RelationshipEntry> GetRelationshipLookup(global::System.Data.Entity.Core.Objects.ObjectStateManager manager, global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember sourceMember, global::System.Data.Entity.Core.EntityKey sourceKey)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.RelationshipEntry> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.RelationshipEntry>();
			foreach (global::System.Data.Entity.Core.Objects.RelationshipEntry relationshipEntry in manager.FindRelationshipsByKey(sourceKey))
			{
				if (relationshipEntry.IsSameAssociationSetAndRole(associationSet, sourceMember, sourceKey))
				{
					list.Add(relationshipEntry);
				}
			}
			return list.ToLookup((global::System.Data.Entity.Core.Objects.RelationshipEntry r) => r.RelationshipWrapper.GetOtherEntityKey(sourceKey));
		}

		// Token: 0x0600334E RID: 13134 RVA: 0x000A30B0 File Offset: 0x000A12B0
		private static void EnsureCollectionNotNull(global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember sourceMember, global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedSource, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember targetMember)
		{
			global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEndInternal = wrappedSource.RelationshipManager.GetRelatedEndInternal(sourceMember.DeclaringType.FullName, targetMember.Name);
			global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember = (global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember)relatedEndInternal.ToEndMember;
			if (associationEndMember != null && associationEndMember.RelationshipMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many && relatedEndInternal.TargetAccessor.HasProperty)
			{
				wrappedSource.EnsureCollectionNotNull(relatedEndInternal);
			}
		}

		// Token: 0x0600334F RID: 13135 RVA: 0x000A3108 File Offset: 0x000A1308
		internal virtual void RemoveRelationships(global::System.Data.Entity.Core.Objects.MergeOption mergeOption, global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet, global::System.Data.Entity.Core.EntityKey sourceKey, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember sourceMember)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.RelationshipEntry> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.RelationshipEntry>(16);
			if (mergeOption == global::System.Data.Entity.Core.Objects.MergeOption.OverwriteChanges)
			{
				using (global::System.Data.Entity.Core.Objects.EntityEntry.RelationshipEndEnumerator enumerator = this.FindRelationshipsByKey(sourceKey).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						global::System.Data.Entity.Core.Objects.RelationshipEntry relationshipEntry = enumerator.Current;
						if (relationshipEntry.IsSameAssociationSetAndRole(associationSet, sourceMember, sourceKey))
						{
							list.Add(relationshipEntry);
						}
					}
					goto IL_A9;
				}
			}
			if (mergeOption == global::System.Data.Entity.Core.Objects.MergeOption.PreserveChanges)
			{
				foreach (global::System.Data.Entity.Core.Objects.RelationshipEntry relationshipEntry2 in this.FindRelationshipsByKey(sourceKey))
				{
					if (relationshipEntry2.IsSameAssociationSetAndRole(associationSet, sourceMember, sourceKey) && relationshipEntry2.State != global::System.Data.Entity.EntityState.Added)
					{
						list.Add(relationshipEntry2);
					}
				}
			}
			IL_A9:
			foreach (global::System.Data.Entity.Core.Objects.RelationshipEntry relationshipToRemove in list)
			{
				global::System.Data.Entity.Core.Objects.ObjectStateManager.RemoveRelatedEndsAndDetachRelationship(relationshipToRemove, true);
			}
		}

		// Token: 0x06003350 RID: 13136 RVA: 0x000A3218 File Offset: 0x000A1418
		internal static bool TryUpdateExistingRelationships(global::System.Data.Entity.Core.Objects.ObjectContext context, global::System.Data.Entity.Core.Objects.MergeOption mergeOption, global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember sourceMember, global::System.Linq.ILookup<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Objects.RelationshipEntry> relationshipLookup, global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedSource, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember targetMember, global::System.Data.Entity.Core.EntityKey targetKey, bool setIsLoaded, out global::System.Data.Entity.EntityState newEntryState)
		{
			newEntryState = global::System.Data.Entity.EntityState.Unchanged;
			if (associationSet.ElementType.IsForeignKey)
			{
				return true;
			}
			bool flag = true;
			global::System.Data.Entity.Core.Objects.ObjectStateManager objectStateManager = context.ObjectStateManager;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.RelationshipEntry> list = null;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.RelationshipEntry> list2 = null;
			foreach (global::System.Data.Entity.Core.Objects.RelationshipEntry item in relationshipLookup[targetKey])
			{
				if (list2 == null)
				{
					list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.RelationshipEntry>(16);
				}
				list2.Add(item);
			}
			global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity relationshipMultiplicity = targetMember.RelationshipMultiplicity;
			if (relationshipMultiplicity > global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One)
			{
				if (relationshipMultiplicity != global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many)
				{
				}
			}
			else
			{
				global::System.Func<global::System.Linq.IGrouping<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Objects.RelationshipEntry>, bool> <>9__0;
				global::System.Func<global::System.Linq.IGrouping<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Objects.RelationshipEntry>, bool> predicate;
				if ((predicate = <>9__0) == null)
				{
					predicate = (<>9__0 = ((global::System.Linq.IGrouping<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Objects.RelationshipEntry> g) => g.Key != targetKey));
				}
				foreach (global::System.Data.Entity.Core.Objects.RelationshipEntry relationshipEntry in relationshipLookup.Where(predicate).SelectMany((global::System.Linq.IGrouping<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Objects.RelationshipEntry> re) => re))
				{
					switch (mergeOption)
					{
					case global::System.Data.Entity.Core.Objects.MergeOption.AppendOnly:
						if (relationshipEntry.State != global::System.Data.Entity.EntityState.Deleted)
						{
							flag = false;
						}
						break;
					case global::System.Data.Entity.Core.Objects.MergeOption.OverwriteChanges:
						if (list == null)
						{
							list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.RelationshipEntry>(16);
						}
						list.Add(relationshipEntry);
						break;
					case global::System.Data.Entity.Core.Objects.MergeOption.PreserveChanges:
					{
						global::System.Data.Entity.EntityState state = relationshipEntry.State;
						if (state != global::System.Data.Entity.EntityState.Unchanged)
						{
							if (state != global::System.Data.Entity.EntityState.Added)
							{
								if (state == global::System.Data.Entity.EntityState.Deleted)
								{
									newEntryState = global::System.Data.Entity.EntityState.Deleted;
									if (list == null)
									{
										list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.RelationshipEntry>(16);
									}
									list.Add(relationshipEntry);
								}
							}
							else
							{
								newEntryState = global::System.Data.Entity.EntityState.Deleted;
							}
						}
						else
						{
							if (list == null)
							{
								list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.RelationshipEntry>(16);
							}
							list.Add(relationshipEntry);
						}
						break;
					}
					}
				}
			}
			if (list != null)
			{
				foreach (global::System.Data.Entity.Core.Objects.RelationshipEntry relationshipEntry2 in list)
				{
					if (relationshipEntry2.State != global::System.Data.Entity.EntityState.Detached)
					{
						global::System.Data.Entity.Core.Objects.ObjectStateManager.RemoveRelatedEndsAndDetachRelationship(relationshipEntry2, setIsLoaded);
					}
				}
			}
			if (list2 != null)
			{
				foreach (global::System.Data.Entity.Core.Objects.RelationshipEntry relationshipEntry3 in list2)
				{
					flag = false;
					switch (mergeOption)
					{
					case global::System.Data.Entity.Core.Objects.MergeOption.OverwriteChanges:
						if (relationshipEntry3.State == global::System.Data.Entity.EntityState.Added)
						{
							relationshipEntry3.AcceptChanges();
						}
						else if (relationshipEntry3.State == global::System.Data.Entity.EntityState.Deleted)
						{
							global::System.Data.Entity.Core.Objects.EntityEntry entityEntry = objectStateManager.GetEntityEntry(targetKey);
							if (entityEntry.State != global::System.Data.Entity.EntityState.Deleted)
							{
								if (!entityEntry.IsKeyEntry)
								{
									global::System.Data.Entity.Core.Objects.ObjectStateManager.AddEntityToCollectionOrReference(mergeOption, wrappedSource, sourceMember, entityEntry.WrappedEntity, targetMember, setIsLoaded, true, false);
								}
								relationshipEntry3.RevertDelete();
							}
						}
						break;
					case global::System.Data.Entity.Core.Objects.MergeOption.PreserveChanges:
						if (relationshipEntry3.State == global::System.Data.Entity.EntityState.Added)
						{
							relationshipEntry3.AcceptChanges();
						}
						break;
					}
				}
			}
			return !flag;
		}

		// Token: 0x06003351 RID: 13137 RVA: 0x000A34F4 File Offset: 0x000A16F4
		internal static void RemoveRelatedEndsAndDetachRelationship(global::System.Data.Entity.Core.Objects.RelationshipEntry relationshipToRemove, bool setIsLoaded)
		{
			if (setIsLoaded)
			{
				global::System.Data.Entity.Core.Objects.ObjectStateManager.UnloadReferenceRelatedEnds(relationshipToRemove);
			}
			if (relationshipToRemove.State != global::System.Data.Entity.EntityState.Deleted)
			{
				relationshipToRemove.Delete();
			}
			if (relationshipToRemove.State != global::System.Data.Entity.EntityState.Detached)
			{
				relationshipToRemove.AcceptChanges();
			}
		}

		// Token: 0x06003352 RID: 13138 RVA: 0x000A3520 File Offset: 0x000A1720
		private static void UnloadReferenceRelatedEnds(global::System.Data.Entity.Core.Objects.RelationshipEntry relationshipEntry)
		{
			global::System.Data.Entity.Core.Objects.ObjectStateManager objectStateManager = relationshipEntry.ObjectStateManager;
			global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember> associationEndMembers = relationshipEntry.RelationshipWrapper.AssociationEndMembers;
			global::System.Data.Entity.Core.Objects.ObjectStateManager.UnloadReferenceRelatedEnds(objectStateManager, relationshipEntry, relationshipEntry.RelationshipWrapper.GetEntityKey(0), associationEndMembers[1].Name);
			global::System.Data.Entity.Core.Objects.ObjectStateManager.UnloadReferenceRelatedEnds(objectStateManager, relationshipEntry, relationshipEntry.RelationshipWrapper.GetEntityKey(1), associationEndMembers[0].Name);
		}

		// Token: 0x06003353 RID: 13139 RVA: 0x000A357C File Offset: 0x000A177C
		private static void UnloadReferenceRelatedEnds(global::System.Data.Entity.Core.Objects.ObjectStateManager cache, global::System.Data.Entity.Core.Objects.RelationshipEntry relationshipEntry, global::System.Data.Entity.Core.EntityKey sourceEntityKey, string targetRoleName)
		{
			global::System.Data.Entity.Core.Objects.EntityEntry entityEntry = cache.GetEntityEntry(sourceEntityKey);
			if (entityEntry.WrappedEntity.Entity != null)
			{
				global::System.Data.Entity.Core.Objects.DataClasses.EntityReference entityReference = entityEntry.WrappedEntity.RelationshipManager.GetRelatedEndInternal(((global::System.Data.Entity.Core.Metadata.Edm.AssociationSet)relationshipEntry.EntitySet).ElementType.FullName, targetRoleName) as global::System.Data.Entity.Core.Objects.DataClasses.EntityReference;
				if (entityReference != null)
				{
					entityReference.IsLoaded = false;
				}
			}
		}

		// Token: 0x06003354 RID: 13140 RVA: 0x000A35D4 File Offset: 0x000A17D4
		internal virtual global::System.Data.Entity.Core.Objects.EntityEntry AttachEntry(global::System.Data.Entity.Core.EntityKey entityKey, global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedObject, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet)
		{
			global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata orAddStateManagerTypeMetadata = this.GetOrAddStateManagerTypeMetadata(wrappedObject.IdentityType, entitySet);
			this.ValidateProxyType(wrappedObject);
			this.CheckKeyMatchesEntity(wrappedObject, entityKey, entitySet, true);
			if (!wrappedObject.OwnsRelationshipManager)
			{
				wrappedObject.RelationshipManager.ClearRelatedEndWrappers();
			}
			global::System.Data.Entity.Core.Objects.EntityEntry entityEntry = new global::System.Data.Entity.Core.Objects.EntityEntry(wrappedObject, entityKey, entitySet, this, orAddStateManagerTypeMetadata, global::System.Data.Entity.EntityState.Unchanged);
			entityEntry.AttachObjectStateManagerToEntity();
			this.AddEntityEntryToDictionary(entityEntry, entityEntry.State);
			this.OnObjectStateManagerChanged(global::System.ComponentModel.CollectionChangeAction.Add, entityEntry.Entity);
			return entityEntry;
		}

		// Token: 0x06003355 RID: 13141 RVA: 0x000A3640 File Offset: 0x000A1840
		private void CheckKeyMatchesEntity(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity, global::System.Data.Entity.Core.EntityKey entityKey, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySetForType, bool forAttach)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = entityKey.GetEntitySet(this.MetadataWorkspace);
			if (entitySet == null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateManager_InvalidKey);
			}
			entityKey.ValidateEntityKey(this._metadataWorkspace, entitySet);
			global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata orAddStateManagerTypeMetadata = this.GetOrAddStateManagerTypeMetadata(wrappedEntity.IdentityType, entitySetForType);
			for (int i = 0; i < entitySet.ElementType.KeyMembers.Count; i++)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember = entitySet.ElementType.KeyMembers[i];
				int ordinalforCLayerMemberName = orAddStateManagerTypeMetadata.GetOrdinalforCLayerMemberName(edmMember.Name);
				if (ordinalforCLayerMemberName < 0)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateManager_InvalidKey);
				}
				object value = orAddStateManagerTypeMetadata.Member(ordinalforCLayerMemberName).GetValue(wrappedEntity.Entity);
				object y = entityKey.FindValueByName(edmMember.Name);
				if (!global::System.Data.Entity.Core.Common.Utils.ByValueEqualityComparer.Default.Equals(value, y))
				{
					throw new global::System.InvalidOperationException(forAttach ? global::System.Data.Entity.Resources.Strings.ObjectStateManager_KeyPropertyDoesntMatchValueInKeyForAttach : global::System.Data.Entity.Resources.Strings.ObjectStateManager_KeyPropertyDoesntMatchValueInKey);
				}
			}
		}

		// Token: 0x06003356 RID: 13142 RVA: 0x000A371C File Offset: 0x000A191C
		internal virtual global::System.Data.Entity.Core.Objects.RelationshipEntry AddNewRelation(global::System.Data.Entity.Core.Objects.RelationshipWrapper wrapper, global::System.Data.Entity.EntityState desiredState)
		{
			global::System.Data.Entity.Core.Objects.RelationshipEntry relationshipEntry = new global::System.Data.Entity.Core.Objects.RelationshipEntry(this, desiredState, wrapper);
			this.AddRelationshipEntryToDictionary(relationshipEntry, desiredState);
			this.AddRelationshipToLookup(relationshipEntry);
			return relationshipEntry;
		}

		// Token: 0x06003357 RID: 13143 RVA: 0x000A3744 File Offset: 0x000A1944
		internal virtual global::System.Data.Entity.Core.Objects.RelationshipEntry AddRelation(global::System.Data.Entity.Core.Objects.RelationshipWrapper wrapper, global::System.Data.Entity.EntityState desiredState)
		{
			global::System.Data.Entity.Core.Objects.RelationshipEntry relationshipEntry = this.FindRelationship(wrapper);
			if (relationshipEntry == null)
			{
				relationshipEntry = this.AddNewRelation(wrapper, desiredState);
			}
			else if (global::System.Data.Entity.EntityState.Deleted != relationshipEntry.State)
			{
				if (global::System.Data.Entity.EntityState.Unchanged == desiredState)
				{
					relationshipEntry.AcceptChanges();
				}
				else if (global::System.Data.Entity.EntityState.Deleted == desiredState)
				{
					relationshipEntry.AcceptChanges();
					relationshipEntry.Delete(false);
				}
			}
			else if (global::System.Data.Entity.EntityState.Deleted != desiredState)
			{
				relationshipEntry.RevertDelete();
			}
			return relationshipEntry;
		}

		// Token: 0x06003358 RID: 13144 RVA: 0x000A379C File Offset: 0x000A199C
		private void AddRelationshipToLookup(global::System.Data.Entity.Core.Objects.RelationshipEntry relationship)
		{
			this.AddRelationshipEndToLookup(relationship.RelationshipWrapper.Key0, relationship);
			if (!relationship.RelationshipWrapper.Key0.Equals(relationship.RelationshipWrapper.Key1))
			{
				this.AddRelationshipEndToLookup(relationship.RelationshipWrapper.Key1, relationship);
			}
		}

		// Token: 0x06003359 RID: 13145 RVA: 0x000A37EA File Offset: 0x000A19EA
		private void AddRelationshipEndToLookup(global::System.Data.Entity.Core.EntityKey key, global::System.Data.Entity.Core.Objects.RelationshipEntry relationship)
		{
			this.GetEntityEntry(key).AddRelationshipEnd(relationship);
		}

		// Token: 0x0600335A RID: 13146 RVA: 0x000A37FC File Offset: 0x000A19FC
		private void DeleteRelationshipFromLookup(global::System.Data.Entity.Core.Objects.RelationshipEntry relationship)
		{
			this.DeleteRelationshipEndFromLookup(relationship.RelationshipWrapper.Key0, relationship);
			if (!relationship.RelationshipWrapper.Key0.Equals(relationship.RelationshipWrapper.Key1))
			{
				this.DeleteRelationshipEndFromLookup(relationship.RelationshipWrapper.Key1, relationship);
			}
		}

		// Token: 0x0600335B RID: 13147 RVA: 0x000A384A File Offset: 0x000A1A4A
		private void DeleteRelationshipEndFromLookup(global::System.Data.Entity.Core.EntityKey key, global::System.Data.Entity.Core.Objects.RelationshipEntry relationship)
		{
			this.GetEntityEntry(key).RemoveRelationshipEnd(relationship);
		}

		// Token: 0x0600335C RID: 13148 RVA: 0x000A3859 File Offset: 0x000A1A59
		internal virtual global::System.Data.Entity.Core.Objects.RelationshipEntry FindRelationship(global::System.Data.Entity.Core.Metadata.Edm.RelationshipSet relationshipSet, global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.EntityKey> roleAndKey1, global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.EntityKey> roleAndKey2)
		{
			if (roleAndKey1.Value == null || roleAndKey2.Value == null)
			{
				return null;
			}
			return this.FindRelationship(new global::System.Data.Entity.Core.Objects.RelationshipWrapper((global::System.Data.Entity.Core.Metadata.Edm.AssociationSet)relationshipSet, roleAndKey1, roleAndKey2));
		}

		// Token: 0x0600335D RID: 13149 RVA: 0x000A3884 File Offset: 0x000A1A84
		internal virtual global::System.Data.Entity.Core.Objects.RelationshipEntry FindRelationship(global::System.Data.Entity.Core.Objects.RelationshipWrapper relationshipWrapper)
		{
			global::System.Data.Entity.Core.Objects.RelationshipEntry result = null;
			if ((this._unchangedRelationshipStore == null || !this._unchangedRelationshipStore.TryGetValue(relationshipWrapper, out result)) && (this._deletedRelationshipStore == null || !this._deletedRelationshipStore.TryGetValue(relationshipWrapper, out result)))
			{
				if (this._addedRelationshipStore != null)
				{
					this._addedRelationshipStore.TryGetValue(relationshipWrapper, out result);
				}
			}
			return result;
		}

		// Token: 0x0600335E RID: 13150 RVA: 0x000A38E4 File Offset: 0x000A1AE4
		internal virtual global::System.Data.Entity.Core.Objects.RelationshipEntry DeleteRelationship(global::System.Data.Entity.Core.Metadata.Edm.RelationshipSet relationshipSet, global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.EntityKey> roleAndKey1, global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.EntityKey> roleAndKey2)
		{
			global::System.Data.Entity.Core.Objects.RelationshipEntry relationshipEntry = this.FindRelationship(relationshipSet, roleAndKey1, roleAndKey2);
			if (relationshipEntry != null)
			{
				relationshipEntry.Delete(false);
			}
			return relationshipEntry;
		}

		// Token: 0x0600335F RID: 13151 RVA: 0x000A3906 File Offset: 0x000A1B06
		internal virtual void DeleteKeyEntry(global::System.Data.Entity.Core.Objects.EntityEntry keyEntry)
		{
			if (keyEntry != null && keyEntry.IsKeyEntry)
			{
				this.ChangeState(keyEntry, keyEntry.State, global::System.Data.Entity.EntityState.Detached);
			}
		}

		// Token: 0x06003360 RID: 13152 RVA: 0x000A3924 File Offset: 0x000A1B24
		internal virtual global::System.Data.Entity.Core.Objects.RelationshipEntry[] CopyOfRelationshipsByKey(global::System.Data.Entity.Core.EntityKey key)
		{
			return this.FindRelationshipsByKey(key).ToArray();
		}

		// Token: 0x06003361 RID: 13153 RVA: 0x000A3940 File Offset: 0x000A1B40
		internal virtual global::System.Data.Entity.Core.Objects.EntityEntry.RelationshipEndEnumerable FindRelationshipsByKey(global::System.Data.Entity.Core.EntityKey key)
		{
			return new global::System.Data.Entity.Core.Objects.EntityEntry.RelationshipEndEnumerable(this.FindEntityEntry(key));
		}

		// Token: 0x06003362 RID: 13154 RVA: 0x000A394E File Offset: 0x000A1B4E
		global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.IEntityStateEntry> global::System.Data.Entity.Core.IEntityStateManager.FindRelationshipsByKey(global::System.Data.Entity.Core.EntityKey key)
		{
			return this.FindRelationshipsByKey(key);
		}

		// Token: 0x06003363 RID: 13155 RVA: 0x000A395C File Offset: 0x000A1B5C
		[global::System.Diagnostics.Conditional("DEBUG")]
		private void ValidateKeylessEntityStore()
		{
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Objects.EntityEntry>[] array = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Objects.EntityEntry>[]
			{
				this._unchangedEntityStore,
				this._modifiedEntityStore,
				this._addedEntityStore,
				this._deletedEntityStore
			};
			if (this._keylessEntityStore != null)
			{
				if (this._keylessEntityStore.Count == array.Sum(delegate(global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Objects.EntityEntry> s)
				{
					if (s != null)
					{
						return s.Count;
					}
					return 0;
				}))
				{
					return;
				}
			}
			if (this._keylessEntityStore != null)
			{
				foreach (global::System.Data.Entity.Core.Objects.EntityEntry entityEntry in this._keylessEntityStore.Values)
				{
					bool flag = false;
					if (this._addedEntityStore != null)
					{
						global::System.Data.Entity.Core.Objects.EntityEntry entityEntry2;
						flag = this._addedEntityStore.TryGetValue(entityEntry.EntityKey, out entityEntry2);
					}
					if (this._modifiedEntityStore != null)
					{
						global::System.Data.Entity.Core.Objects.EntityEntry entityEntry2;
						flag |= this._modifiedEntityStore.TryGetValue(entityEntry.EntityKey, out entityEntry2);
					}
					if (this._deletedEntityStore != null)
					{
						global::System.Data.Entity.Core.Objects.EntityEntry entityEntry2;
						flag |= this._deletedEntityStore.TryGetValue(entityEntry.EntityKey, out entityEntry2);
					}
					if (this._unchangedEntityStore != null)
					{
						global::System.Data.Entity.Core.Objects.EntityEntry entityEntry2;
						flag |= this._unchangedEntityStore.TryGetValue(entityEntry.EntityKey, out entityEntry2);
					}
				}
			}
			foreach (global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Objects.EntityEntry> dictionary in array)
			{
				if (dictionary != null)
				{
					foreach (global::System.Data.Entity.Core.Objects.EntityEntry entityEntry3 in dictionary.Values)
					{
						if (entityEntry3.Entity != null && !(entityEntry3.Entity is global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithKey))
						{
							global::System.Data.Entity.Core.Objects.EntityEntry entityEntry4;
							this._keylessEntityStore.TryGetValue(entityEntry3.Entity, out entityEntry4);
						}
					}
				}
			}
		}

		// Token: 0x06003364 RID: 13156 RVA: 0x000A3B30 File Offset: 0x000A1D30
		private bool TryGetEntryFromKeylessStore(object entity, out global::System.Data.Entity.Core.Objects.EntityEntry entryRef)
		{
			entryRef = null;
			if (entity == null)
			{
				return false;
			}
			if (this._keylessEntityStore != null && this._keylessEntityStore.TryGetValue(entity, out entryRef))
			{
				return true;
			}
			entryRef = null;
			return false;
		}

		// Token: 0x06003365 RID: 13157 RVA: 0x000A3B57 File Offset: 0x000A1D57
		public virtual global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Objects.ObjectStateEntry> GetObjectStateEntries(global::System.Data.Entity.EntityState state)
		{
			if ((global::System.Data.Entity.EntityState.Detached & state) != (global::System.Data.Entity.EntityState)0)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ObjectStateManager_DetachedObjectStateEntriesDoesNotExistInObjectStateManager);
			}
			return this.GetObjectStateEntriesInternal(state);
		}

		// Token: 0x06003366 RID: 13158 RVA: 0x000A3B70 File Offset: 0x000A1D70
		global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.IEntityStateEntry> global::System.Data.Entity.Core.IEntityStateManager.GetEntityStateEntries(global::System.Data.Entity.EntityState state)
		{
			foreach (global::System.Data.Entity.Core.Objects.ObjectStateEntry objectStateEntry in this.GetObjectStateEntriesInternal(state))
			{
				yield return objectStateEntry;
			}
			global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Objects.ObjectStateEntry> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x06003367 RID: 13159 RVA: 0x000A3B88 File Offset: 0x000A1D88
		internal virtual bool HasChanges()
		{
			return (this._addedRelationshipStore != null && this._addedRelationshipStore.Count > 0) || (this._addedEntityStore != null && this._addedEntityStore.Count > 0) || (this._modifiedEntityStore != null && this._modifiedEntityStore.Count > 0) || (this._deletedRelationshipStore != null && this._deletedRelationshipStore.Count > 0) || (this._deletedEntityStore != null && this._deletedEntityStore.Count > 0);
		}

		// Token: 0x06003368 RID: 13160 RVA: 0x000A3C08 File Offset: 0x000A1E08
		internal virtual int GetObjectStateEntriesCount(global::System.Data.Entity.EntityState state)
		{
			int num = 0;
			if ((global::System.Data.Entity.EntityState.Added & state) != (global::System.Data.Entity.EntityState)0)
			{
				num += ((this._addedRelationshipStore != null) ? this._addedRelationshipStore.Count : 0);
				num += ((this._addedEntityStore != null) ? this._addedEntityStore.Count : 0);
			}
			if ((global::System.Data.Entity.EntityState.Modified & state) != (global::System.Data.Entity.EntityState)0)
			{
				num += ((this._modifiedEntityStore != null) ? this._modifiedEntityStore.Count : 0);
			}
			if ((global::System.Data.Entity.EntityState.Deleted & state) != (global::System.Data.Entity.EntityState)0)
			{
				num += ((this._deletedRelationshipStore != null) ? this._deletedRelationshipStore.Count : 0);
				num += ((this._deletedEntityStore != null) ? this._deletedEntityStore.Count : 0);
			}
			if ((global::System.Data.Entity.EntityState.Unchanged & state) != (global::System.Data.Entity.EntityState)0)
			{
				num += ((this._unchangedRelationshipStore != null) ? this._unchangedRelationshipStore.Count : 0);
				num += ((this._unchangedEntityStore != null) ? this._unchangedEntityStore.Count : 0);
			}
			return num;
		}

		// Token: 0x06003369 RID: 13161 RVA: 0x000A3CDC File Offset: 0x000A1EDC
		private int GetMaxEntityEntriesForDetectChanges()
		{
			int num = 0;
			if (this._addedEntityStore != null)
			{
				num += this._addedEntityStore.Count;
			}
			if (this._modifiedEntityStore != null)
			{
				num += this._modifiedEntityStore.Count;
			}
			if (this._deletedEntityStore != null)
			{
				num += this._deletedEntityStore.Count;
			}
			if (this._unchangedEntityStore != null)
			{
				num += this._unchangedEntityStore.Count;
			}
			return num;
		}

		// Token: 0x0600336A RID: 13162 RVA: 0x000A3D44 File Offset: 0x000A1F44
		internal virtual global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Objects.ObjectStateEntry> GetObjectStateEntriesInternal(global::System.Data.Entity.EntityState state)
		{
			int num = this.GetObjectStateEntriesCount(state);
			global::System.Data.Entity.Core.Objects.ObjectStateEntry[] array = new global::System.Data.Entity.Core.Objects.ObjectStateEntry[num];
			num = 0;
			if ((global::System.Data.Entity.EntityState.Added & state) != (global::System.Data.Entity.EntityState)0 && this._addedRelationshipStore != null)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Objects.RelationshipWrapper, global::System.Data.Entity.Core.Objects.RelationshipEntry> keyValuePair in this._addedRelationshipStore)
				{
					array[num++] = keyValuePair.Value;
				}
			}
			if ((global::System.Data.Entity.EntityState.Deleted & state) != (global::System.Data.Entity.EntityState)0 && this._deletedRelationshipStore != null)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Objects.RelationshipWrapper, global::System.Data.Entity.Core.Objects.RelationshipEntry> keyValuePair2 in this._deletedRelationshipStore)
				{
					array[num++] = keyValuePair2.Value;
				}
			}
			if ((global::System.Data.Entity.EntityState.Unchanged & state) != (global::System.Data.Entity.EntityState)0 && this._unchangedRelationshipStore != null)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Objects.RelationshipWrapper, global::System.Data.Entity.Core.Objects.RelationshipEntry> keyValuePair3 in this._unchangedRelationshipStore)
				{
					array[num++] = keyValuePair3.Value;
				}
			}
			if ((global::System.Data.Entity.EntityState.Added & state) != (global::System.Data.Entity.EntityState)0 && this._addedEntityStore != null)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Objects.EntityEntry> keyValuePair4 in this._addedEntityStore)
				{
					array[num++] = keyValuePair4.Value;
				}
			}
			if ((global::System.Data.Entity.EntityState.Modified & state) != (global::System.Data.Entity.EntityState)0 && this._modifiedEntityStore != null)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Objects.EntityEntry> keyValuePair5 in this._modifiedEntityStore)
				{
					array[num++] = keyValuePair5.Value;
				}
			}
			if ((global::System.Data.Entity.EntityState.Deleted & state) != (global::System.Data.Entity.EntityState)0 && this._deletedEntityStore != null)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Objects.EntityEntry> keyValuePair6 in this._deletedEntityStore)
				{
					array[num++] = keyValuePair6.Value;
				}
			}
			if ((global::System.Data.Entity.EntityState.Unchanged & state) != (global::System.Data.Entity.EntityState)0 && this._unchangedEntityStore != null)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Objects.EntityEntry> keyValuePair7 in this._unchangedEntityStore)
				{
					array[num++] = keyValuePair7.Value;
				}
			}
			return array;
		}

		// Token: 0x0600336B RID: 13163 RVA: 0x000A3FCC File Offset: 0x000A21CC
		private global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Objects.EntityEntry> GetEntityEntriesForDetectChanges()
		{
			if (!this._detectChangesNeeded)
			{
				return null;
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.EntityEntry> list = null;
			this.GetEntityEntriesForDetectChanges(this._addedEntityStore, ref list);
			this.GetEntityEntriesForDetectChanges(this._modifiedEntityStore, ref list);
			this.GetEntityEntriesForDetectChanges(this._deletedEntityStore, ref list);
			this.GetEntityEntriesForDetectChanges(this._unchangedEntityStore, ref list);
			if (list == null)
			{
				this._detectChangesNeeded = false;
			}
			return list;
		}

		// Token: 0x0600336C RID: 13164 RVA: 0x000A4028 File Offset: 0x000A2228
		private void GetEntityEntriesForDetectChanges(global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Objects.EntityEntry> entityStore, ref global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.EntityEntry> entries)
		{
			if (entityStore != null)
			{
				foreach (global::System.Data.Entity.Core.Objects.EntityEntry entityEntry in entityStore.Values)
				{
					if (entityEntry.RequiresAnyChangeTracking)
					{
						if (entries == null)
						{
							entries = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.EntityEntry>(this.GetMaxEntityEntriesForDetectChanges());
						}
						entries.Add(entityEntry);
					}
				}
			}
		}

		// Token: 0x0600336D RID: 13165 RVA: 0x000A4098 File Offset: 0x000A2298
		internal virtual void FixupKey(global::System.Data.Entity.Core.Objects.EntityEntry entry)
		{
			global::System.Data.Entity.Core.EntityKey entityKey = entry.EntityKey;
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = (global::System.Data.Entity.Core.Metadata.Edm.EntitySet)entry.EntitySet;
			bool hasForeignKeyRelationships = entitySet.HasForeignKeyRelationships;
			bool hasIndependentRelationships = entitySet.HasIndependentRelationships;
			if (hasForeignKeyRelationships)
			{
				entry.FixupForeignKeysByReference();
			}
			global::System.Data.Entity.Core.EntityKey entityKey2;
			try
			{
				entityKey2 = new global::System.Data.Entity.Core.EntityKey((global::System.Data.Entity.Core.Metadata.Edm.EntitySet)entry.EntitySet, entry.CurrentValues);
			}
			catch (global::System.ArgumentException innerException)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ObjectStateManager_ChangeStateFromAddedWithNullKeyIsInvalid, innerException);
			}
			global::System.Data.Entity.Core.Objects.EntityEntry entityEntry = this.FindEntityEntry(entityKey2);
			if (entityEntry != null)
			{
				if (!entityEntry.IsKeyEntry)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateManager_CannotFixUpKeyToExistingValues(entry.WrappedEntity.IdentityType.FullName));
				}
				entityKey2 = entityEntry.EntityKey;
			}
			global::System.Data.Entity.Core.Objects.RelationshipEntry[] array = null;
			if (hasIndependentRelationships)
			{
				array = entry.GetRelationshipEnds().ToArray();
				foreach (global::System.Data.Entity.Core.Objects.RelationshipEntry relationshipEntry in array)
				{
					this.RemoveObjectStateEntryFromDictionary(relationshipEntry, relationshipEntry.State);
				}
			}
			this.RemoveObjectStateEntryFromDictionary(entry, global::System.Data.Entity.EntityState.Added);
			this.ResetEntityKey(entry, entityKey2);
			if (hasIndependentRelationships)
			{
				entry.UpdateRelationshipEnds(entityKey, entityEntry);
				foreach (global::System.Data.Entity.Core.Objects.RelationshipEntry relationshipEntry2 in array)
				{
					this.AddRelationshipEntryToDictionary(relationshipEntry2, relationshipEntry2.State);
				}
			}
			if (entityEntry != null)
			{
				this.PromoteKeyEntry(entityEntry, entry.WrappedEntity, true, false, false);
				entry = entityEntry;
			}
			else
			{
				this.AddEntityEntryToDictionary(entry, global::System.Data.Entity.EntityState.Unchanged);
			}
			if (hasForeignKeyRelationships)
			{
				this.FixupReferencesByForeignKeys(entry, false);
			}
		}

		// Token: 0x0600336E RID: 13166 RVA: 0x000A41FC File Offset: 0x000A23FC
		internal virtual void ReplaceKeyWithTemporaryKey(global::System.Data.Entity.Core.Objects.EntityEntry entry)
		{
			global::System.Data.Entity.Core.EntityKey entityKey = entry.EntityKey;
			global::System.Data.Entity.Core.EntityKey value = new global::System.Data.Entity.Core.EntityKey(entry.EntitySet);
			global::System.Data.Entity.Core.Objects.RelationshipEntry[] array = entry.GetRelationshipEnds().ToArray();
			foreach (global::System.Data.Entity.Core.Objects.RelationshipEntry relationshipEntry in array)
			{
				this.RemoveObjectStateEntryFromDictionary(relationshipEntry, relationshipEntry.State);
			}
			this.RemoveObjectStateEntryFromDictionary(entry, entry.State);
			this.ResetEntityKey(entry, value);
			entry.UpdateRelationshipEnds(entityKey, null);
			foreach (global::System.Data.Entity.Core.Objects.RelationshipEntry relationshipEntry2 in array)
			{
				this.AddRelationshipEntryToDictionary(relationshipEntry2, relationshipEntry2.State);
			}
			this.AddEntityEntryToDictionary(entry, global::System.Data.Entity.EntityState.Added);
		}

		// Token: 0x0600336F RID: 13167 RVA: 0x000A42A8 File Offset: 0x000A24A8
		private void ResetEntityKey(global::System.Data.Entity.Core.Objects.EntityEntry entry, global::System.Data.Entity.Core.EntityKey value)
		{
			global::System.Data.Entity.Core.EntityKey entityKey = entry.WrappedEntity.EntityKey;
			if (entityKey == null || value.Equals(entityKey))
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateManager_AcceptChangesEntityKeyIsNotValid);
			}
			try
			{
				this._inRelationshipFixup = true;
				entry.WrappedEntity.EntityKey = value;
				global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity = entry.WrappedEntity;
				if (wrappedEntity.EntityKey != value)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityKey_DoesntMatchKeyOnEntity(wrappedEntity.Entity.GetType().FullName));
				}
			}
			finally
			{
				this._inRelationshipFixup = false;
			}
			entry.EntityKey = value;
		}

		// Token: 0x06003370 RID: 13168 RVA: 0x000A4344 File Offset: 0x000A2544
		public virtual global::System.Data.Entity.Core.Objects.ObjectStateEntry ChangeObjectState(object entity, global::System.Data.Entity.EntityState entityState)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<object>(entity, "entity");
			global::System.Data.Entity.Core.EntityUtil.CheckValidStateForChangeEntityState(entityState);
			global::System.Data.Entity.Core.Objects.EntityEntry entityEntry = null;
			this.TransactionManager.BeginLocalPublicAPI();
			try
			{
				global::System.Data.Entity.Core.EntityKey entityKey = entity as global::System.Data.Entity.Core.EntityKey;
				entityEntry = ((entityKey != null) ? this.FindEntityEntry(entityKey) : this.FindEntityEntry(entity));
				if (entityEntry == null)
				{
					if (entityState == global::System.Data.Entity.EntityState.Detached)
					{
						return null;
					}
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateManager_NoEntryExistsForObject(entity.GetType().FullName));
				}
				else
				{
					entityEntry.ChangeObjectState(entityState);
				}
			}
			finally
			{
				this.TransactionManager.EndLocalPublicAPI();
			}
			return entityEntry;
		}

		// Token: 0x06003371 RID: 13169 RVA: 0x000A43DC File Offset: 0x000A25DC
		public virtual global::System.Data.Entity.Core.Objects.ObjectStateEntry ChangeRelationshipState(object sourceEntity, object targetEntity, string navigationProperty, global::System.Data.Entity.EntityState relationshipState)
		{
			global::System.Data.Entity.Core.Objects.EntityEntry entityEntry;
			global::System.Data.Entity.Core.Objects.EntityEntry targetEntry;
			this.VerifyParametersForChangeRelationshipState(sourceEntity, targetEntity, out entityEntry, out targetEntry);
			global::System.Data.Entity.Utilities.Check.NotEmpty(navigationProperty, "navigationProperty");
			global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd = entityEntry.WrappedEntity.RelationshipManager.GetRelatedEnd(navigationProperty, false);
			return this.ChangeRelationshipState(entityEntry, targetEntry, relatedEnd, relationshipState);
		}

		// Token: 0x06003372 RID: 13170 RVA: 0x000A4420 File Offset: 0x000A2620
		public virtual global::System.Data.Entity.Core.Objects.ObjectStateEntry ChangeRelationshipState<TEntity>(TEntity sourceEntity, object targetEntity, global::System.Linq.Expressions.Expression<global::System.Func<TEntity, object>> navigationPropertySelector, global::System.Data.Entity.EntityState relationshipState) where TEntity : class
		{
			global::System.Data.Entity.Core.Objects.EntityEntry entityEntry;
			global::System.Data.Entity.Core.Objects.EntityEntry targetEntry;
			this.VerifyParametersForChangeRelationshipState(sourceEntity, targetEntity, out entityEntry, out targetEntry);
			bool throwArgumentException;
			string navigationProperty = global::System.Data.Entity.Core.Objects.ObjectContext.ParsePropertySelectorExpression<TEntity>(navigationPropertySelector, out throwArgumentException);
			global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd = entityEntry.WrappedEntity.RelationshipManager.GetRelatedEnd(navigationProperty, throwArgumentException);
			return this.ChangeRelationshipState(entityEntry, targetEntry, relatedEnd, relationshipState);
		}

		// Token: 0x06003373 RID: 13171 RVA: 0x000A4468 File Offset: 0x000A2668
		public virtual global::System.Data.Entity.Core.Objects.ObjectStateEntry ChangeRelationshipState(object sourceEntity, object targetEntity, string relationshipName, string targetRoleName, global::System.Data.Entity.EntityState relationshipState)
		{
			global::System.Data.Entity.Core.Objects.EntityEntry entityEntry;
			global::System.Data.Entity.Core.Objects.EntityEntry targetEntry;
			this.VerifyParametersForChangeRelationshipState(sourceEntity, targetEntity, out entityEntry, out targetEntry);
			global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEndInternal = entityEntry.WrappedEntity.RelationshipManager.GetRelatedEndInternal(relationshipName, targetRoleName);
			return this.ChangeRelationshipState(entityEntry, targetEntry, relatedEndInternal, relationshipState);
		}

		// Token: 0x06003374 RID: 13172 RVA: 0x000A44A0 File Offset: 0x000A26A0
		private global::System.Data.Entity.Core.Objects.ObjectStateEntry ChangeRelationshipState(global::System.Data.Entity.Core.Objects.EntityEntry sourceEntry, global::System.Data.Entity.Core.Objects.EntityEntry targetEntry, global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd, global::System.Data.Entity.EntityState relationshipState)
		{
			global::System.Data.Entity.Core.Objects.ObjectStateManager.VerifyInitialStateForChangeRelationshipState(sourceEntry, targetEntry, relatedEnd, relationshipState);
			global::System.Data.Entity.Core.Objects.RelationshipWrapper relationshipWrapper = new global::System.Data.Entity.Core.Objects.RelationshipWrapper((global::System.Data.Entity.Core.Metadata.Edm.AssociationSet)relatedEnd.RelationshipSet, new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.EntityKey>(relatedEnd.SourceRoleName, sourceEntry.EntityKey), new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.EntityKey>(relatedEnd.TargetRoleName, targetEntry.EntityKey));
			global::System.Data.Entity.Core.Objects.RelationshipEntry relationshipEntry = this.FindRelationship(relationshipWrapper);
			if (relationshipEntry == null && relationshipState == global::System.Data.Entity.EntityState.Detached)
			{
				return null;
			}
			this.TransactionManager.BeginLocalPublicAPI();
			try
			{
				if (relationshipEntry != null)
				{
					relationshipEntry.ChangeRelationshipState(targetEntry, relatedEnd, relationshipState);
				}
				else
				{
					relationshipEntry = this.CreateRelationship(targetEntry, relatedEnd, relationshipWrapper, relationshipState);
				}
			}
			finally
			{
				this.TransactionManager.EndLocalPublicAPI();
			}
			if (relationshipState != global::System.Data.Entity.EntityState.Detached)
			{
				return relationshipEntry;
			}
			return null;
		}

		// Token: 0x06003375 RID: 13173 RVA: 0x000A4548 File Offset: 0x000A2748
		private void VerifyParametersForChangeRelationshipState(object sourceEntity, object targetEntity, out global::System.Data.Entity.Core.Objects.EntityEntry sourceEntry, out global::System.Data.Entity.Core.Objects.EntityEntry targetEntry)
		{
			sourceEntry = this.GetEntityEntryByObjectOrEntityKey(sourceEntity);
			targetEntry = this.GetEntityEntryByObjectOrEntityKey(targetEntity);
		}

		// Token: 0x06003376 RID: 13174 RVA: 0x000A4560 File Offset: 0x000A2760
		private static void VerifyInitialStateForChangeRelationshipState(global::System.Data.Entity.Core.Objects.EntityEntry sourceEntry, global::System.Data.Entity.Core.Objects.EntityEntry targetEntry, global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd, global::System.Data.Entity.EntityState relationshipState)
		{
			relatedEnd.VerifyType(targetEntry.WrappedEntity);
			if (relatedEnd.IsForeignKey)
			{
				throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ObjectStateManager_ChangeRelationshipStateNotSupportedForForeignKeyAssociations);
			}
			global::System.Data.Entity.Core.EntityUtil.CheckValidStateForChangeRelationshipState(relationshipState, "relationshipState");
			if ((sourceEntry.State == global::System.Data.Entity.EntityState.Deleted || targetEntry.State == global::System.Data.Entity.EntityState.Deleted) && relationshipState != global::System.Data.Entity.EntityState.Deleted && relationshipState != global::System.Data.Entity.EntityState.Detached)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateManager_CannotChangeRelationshipStateEntityDeleted);
			}
			if ((sourceEntry.State == global::System.Data.Entity.EntityState.Added || targetEntry.State == global::System.Data.Entity.EntityState.Added) && relationshipState != global::System.Data.Entity.EntityState.Added && relationshipState != global::System.Data.Entity.EntityState.Detached)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateManager_CannotChangeRelationshipStateEntityAdded);
			}
		}

		// Token: 0x06003377 RID: 13175 RVA: 0x000A45E4 File Offset: 0x000A27E4
		private global::System.Data.Entity.Core.Objects.RelationshipEntry CreateRelationship(global::System.Data.Entity.Core.Objects.EntityEntry targetEntry, global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd, global::System.Data.Entity.Core.Objects.RelationshipWrapper relationshipWrapper, global::System.Data.Entity.EntityState requestedState)
		{
			global::System.Data.Entity.Core.Objects.RelationshipEntry relationshipEntry = null;
			switch (requestedState)
			{
			case global::System.Data.Entity.EntityState.Detached:
			case global::System.Data.Entity.EntityState.Detached | global::System.Data.Entity.EntityState.Unchanged:
				break;
			case global::System.Data.Entity.EntityState.Unchanged:
				relatedEnd.Add(targetEntry.WrappedEntity, true, false, false, false, true);
				relationshipEntry = this.FindRelationship(relationshipWrapper);
				relationshipEntry.AcceptChanges();
				break;
			case global::System.Data.Entity.EntityState.Added:
				relatedEnd.Add(targetEntry.WrappedEntity, true, false, false, false, true);
				relationshipEntry = this.FindRelationship(relationshipWrapper);
				break;
			default:
				if (requestedState == global::System.Data.Entity.EntityState.Deleted)
				{
					relationshipEntry = this.AddNewRelation(relationshipWrapper, global::System.Data.Entity.EntityState.Deleted);
				}
				break;
			}
			return relationshipEntry;
		}

		// Token: 0x06003378 RID: 13176 RVA: 0x000A465C File Offset: 0x000A285C
		private global::System.Data.Entity.Core.Objects.EntityEntry GetEntityEntryByObjectOrEntityKey(object o)
		{
			global::System.Data.Entity.Core.EntityKey entityKey = o as global::System.Data.Entity.Core.EntityKey;
			global::System.Data.Entity.Core.Objects.EntityEntry entityEntry = (entityKey != null) ? this.FindEntityEntry(entityKey) : this.FindEntityEntry(o);
			if (entityEntry == null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateManager_NoEntryExistsForObject(o.GetType().FullName));
			}
			if (entityEntry.IsKeyEntry)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateManager_CannotChangeRelationshipStateKeyEntry);
			}
			return entityEntry;
		}

		// Token: 0x06003379 RID: 13177 RVA: 0x000A46B5 File Offset: 0x000A28B5
		global::System.Data.Entity.Core.IEntityStateEntry global::System.Data.Entity.Core.IEntityStateManager.GetEntityStateEntry(global::System.Data.Entity.Core.EntityKey key)
		{
			return this.GetEntityEntry(key);
		}

		// Token: 0x0600337A RID: 13178 RVA: 0x000A46C0 File Offset: 0x000A28C0
		public virtual global::System.Data.Entity.Core.Objects.ObjectStateEntry GetObjectStateEntry(global::System.Data.Entity.Core.EntityKey key)
		{
			global::System.Data.Entity.Core.Objects.ObjectStateEntry result;
			if (!this.TryGetObjectStateEntry(key, out result))
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateManager_NoEntryExistForEntityKey);
			}
			return result;
		}

		// Token: 0x0600337B RID: 13179 RVA: 0x000A46E4 File Offset: 0x000A28E4
		internal virtual global::System.Data.Entity.Core.Objects.EntityEntry GetEntityEntry(global::System.Data.Entity.Core.EntityKey key)
		{
			global::System.Data.Entity.Core.Objects.EntityEntry result;
			if (!this.TryGetEntityEntry(key, out result))
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateManager_NoEntryExistForEntityKey);
			}
			return result;
		}

		// Token: 0x0600337C RID: 13180 RVA: 0x000A4708 File Offset: 0x000A2908
		public virtual global::System.Data.Entity.Core.Objects.ObjectStateEntry GetObjectStateEntry(object entity)
		{
			global::System.Data.Entity.Core.Objects.ObjectStateEntry result;
			if (!this.TryGetObjectStateEntry(entity, out result))
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateManager_NoEntryExistsForObject(entity.GetType().FullName));
			}
			return result;
		}

		// Token: 0x0600337D RID: 13181 RVA: 0x000A4737 File Offset: 0x000A2937
		internal virtual global::System.Data.Entity.Core.Objects.EntityEntry GetEntityEntry(object entity)
		{
			global::System.Data.Entity.Core.Objects.EntityEntry entityEntry = this.FindEntityEntry(entity);
			if (entityEntry == null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateManager_NoEntryExistsForObject(entity.GetType().FullName));
			}
			return entityEntry;
		}

		// Token: 0x0600337E RID: 13182 RVA: 0x000A475C File Offset: 0x000A295C
		public virtual bool TryGetObjectStateEntry(object entity, out global::System.Data.Entity.Core.Objects.ObjectStateEntry entry)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<object>(entity, "entity");
			entry = null;
			global::System.Data.Entity.Core.EntityKey entityKey = entity as global::System.Data.Entity.Core.EntityKey;
			if (entityKey != null)
			{
				return this.TryGetObjectStateEntry(entityKey, out entry);
			}
			entry = this.FindEntityEntry(entity);
			return entry != null;
		}

		// Token: 0x0600337F RID: 13183 RVA: 0x000A47A0 File Offset: 0x000A29A0
		bool global::System.Data.Entity.Core.IEntityStateManager.TryGetEntityStateEntry(global::System.Data.Entity.Core.EntityKey key, out global::System.Data.Entity.Core.IEntityStateEntry entry)
		{
			global::System.Data.Entity.Core.Objects.ObjectStateEntry objectStateEntry;
			bool result = this.TryGetObjectStateEntry(key, out objectStateEntry);
			entry = objectStateEntry;
			return result;
		}

		// Token: 0x06003380 RID: 13184 RVA: 0x000A47BC File Offset: 0x000A29BC
		bool global::System.Data.Entity.Core.IEntityStateManager.TryGetReferenceKey(global::System.Data.Entity.Core.EntityKey dependentKey, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember principalRole, out global::System.Data.Entity.Core.EntityKey principalKey)
		{
			global::System.Data.Entity.Core.Objects.EntityEntry entityEntry;
			if (!this.TryGetEntityEntry(dependentKey, out entityEntry))
			{
				principalKey = null;
				return false;
			}
			return entityEntry.TryGetReferenceKey(principalRole, out principalKey);
		}

		// Token: 0x06003381 RID: 13185 RVA: 0x000A47E4 File Offset: 0x000A29E4
		public virtual bool TryGetObjectStateEntry(global::System.Data.Entity.Core.EntityKey key, out global::System.Data.Entity.Core.Objects.ObjectStateEntry entry)
		{
			global::System.Data.Entity.Core.Objects.EntityEntry entityEntry;
			bool result = this.TryGetEntityEntry(key, out entityEntry);
			entry = entityEntry;
			return result;
		}

		// Token: 0x06003382 RID: 13186 RVA: 0x000A4800 File Offset: 0x000A2A00
		internal virtual bool TryGetEntityEntry(global::System.Data.Entity.Core.EntityKey key, out global::System.Data.Entity.Core.Objects.EntityEntry entry)
		{
			entry = null;
			bool result;
			if (key.IsTemporary)
			{
				result = (this._addedEntityStore != null && this._addedEntityStore.TryGetValue(key, out entry));
			}
			else
			{
				result = ((this._unchangedEntityStore != null && this._unchangedEntityStore.TryGetValue(key, out entry)) || (this._modifiedEntityStore != null && this._modifiedEntityStore.TryGetValue(key, out entry)) || (this._deletedEntityStore != null && this._deletedEntityStore.TryGetValue(key, out entry)));
			}
			return result;
		}

		// Token: 0x06003383 RID: 13187 RVA: 0x000A4880 File Offset: 0x000A2A80
		internal virtual global::System.Data.Entity.Core.Objects.EntityEntry FindEntityEntry(global::System.Data.Entity.Core.EntityKey key)
		{
			global::System.Data.Entity.Core.Objects.EntityEntry result = null;
			if (key != null)
			{
				this.TryGetEntityEntry(key, out result);
			}
			return result;
		}

		// Token: 0x06003384 RID: 13188 RVA: 0x000A48A0 File Offset: 0x000A2AA0
		internal virtual global::System.Data.Entity.Core.Objects.EntityEntry FindEntityEntry(object entity)
		{
			global::System.Data.Entity.Core.Objects.EntityEntry entityEntry = null;
			global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithKey entityWithKey = entity as global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithKey;
			if (entityWithKey != null)
			{
				global::System.Data.Entity.Core.EntityKey entityKey = entityWithKey.EntityKey;
				if (entityKey != null)
				{
					this.TryGetEntityEntry(entityKey, out entityEntry);
				}
			}
			else
			{
				this.TryGetEntryFromKeylessStore(entity, out entityEntry);
			}
			if (entityEntry != null && entity != entityEntry.Entity)
			{
				entityEntry = null;
			}
			return entityEntry;
		}

		// Token: 0x06003385 RID: 13189 RVA: 0x000A48E8 File Offset: 0x000A2AE8
		public virtual global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager GetRelationshipManager(object entity)
		{
			global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager result;
			if (!this.TryGetRelationshipManager(entity, out result))
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateManager_CannotGetRelationshipManagerForDetachedPocoEntity);
			}
			return result;
		}

		// Token: 0x06003386 RID: 13190 RVA: 0x000A490C File Offset: 0x000A2B0C
		public virtual bool TryGetRelationshipManager(object entity, out global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager relationshipManager)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<object>(entity, "entity");
			global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithRelationships entityWithRelationships = entity as global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithRelationships;
			if (entityWithRelationships != null)
			{
				relationshipManager = entityWithRelationships.RelationshipManager;
				if (relationshipManager == null)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.RelationshipManager_UnexpectedNull);
				}
				if (relationshipManager.WrappedOwner.Entity != entity)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.RelationshipManager_InvalidRelationshipManagerOwner);
				}
			}
			else
			{
				global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper entityWrapper = this.EntityWrapperFactory.WrapEntityUsingStateManager(entity, this);
				if (entityWrapper.Context == null)
				{
					relationshipManager = null;
					return false;
				}
				relationshipManager = entityWrapper.RelationshipManager;
			}
			return true;
		}

		// Token: 0x06003387 RID: 13191 RVA: 0x000A4984 File Offset: 0x000A2B84
		internal virtual void ChangeState(global::System.Data.Entity.Core.Objects.RelationshipEntry entry, global::System.Data.Entity.EntityState oldState, global::System.Data.Entity.EntityState newState)
		{
			if (newState == global::System.Data.Entity.EntityState.Detached)
			{
				this.DeleteRelationshipFromLookup(entry);
				this.RemoveObjectStateEntryFromDictionary(entry, oldState);
				entry.Reset();
				return;
			}
			this.RemoveObjectStateEntryFromDictionary(entry, oldState);
			this.AddRelationshipEntryToDictionary(entry, newState);
		}

		// Token: 0x06003388 RID: 13192 RVA: 0x000A49B0 File Offset: 0x000A2BB0
		internal virtual void ChangeState(global::System.Data.Entity.Core.Objects.EntityEntry entry, global::System.Data.Entity.EntityState oldState, global::System.Data.Entity.EntityState newState)
		{
			bool flag = !entry.IsKeyEntry;
			if (newState == global::System.Data.Entity.EntityState.Detached)
			{
				foreach (global::System.Data.Entity.Core.Objects.RelationshipEntry relationshipEntry in this.CopyOfRelationshipsByKey(entry.EntityKey))
				{
					this.ChangeState(relationshipEntry, relationshipEntry.State, global::System.Data.Entity.EntityState.Detached);
				}
				this.RemoveObjectStateEntryFromDictionary(entry, oldState);
				global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity = entry.WrappedEntity;
				entry.Reset();
				if (flag && wrappedEntity.Entity != null && !this.TransactionManager.IsAttachTracking)
				{
					this.OnEntityDeleted(global::System.ComponentModel.CollectionChangeAction.Remove, wrappedEntity.Entity);
					this.OnObjectStateManagerChanged(global::System.ComponentModel.CollectionChangeAction.Remove, wrappedEntity.Entity);
				}
			}
			else
			{
				this.RemoveObjectStateEntryFromDictionary(entry, oldState);
				this.AddEntityEntryToDictionary(entry, newState);
			}
			if (newState == global::System.Data.Entity.EntityState.Deleted)
			{
				entry.RemoveFromForeignKeyIndex();
				this.ForgetEntryWithConceptualNull(entry, true);
				if (flag)
				{
					this.OnEntityDeleted(global::System.ComponentModel.CollectionChangeAction.Remove, entry.Entity);
					this.OnObjectStateManagerChanged(global::System.ComponentModel.CollectionChangeAction.Remove, entry.Entity);
				}
			}
		}

		// Token: 0x06003389 RID: 13193 RVA: 0x000A4A84 File Offset: 0x000A2C84
		private void AddRelationshipEntryToDictionary(global::System.Data.Entity.Core.Objects.RelationshipEntry entry, global::System.Data.Entity.EntityState state)
		{
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.RelationshipWrapper, global::System.Data.Entity.Core.Objects.RelationshipEntry> dictionary = null;
			if (state != global::System.Data.Entity.EntityState.Unchanged)
			{
				if (state != global::System.Data.Entity.EntityState.Added)
				{
					if (state == global::System.Data.Entity.EntityState.Deleted)
					{
						if (this._deletedRelationshipStore == null)
						{
							this._deletedRelationshipStore = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.RelationshipWrapper, global::System.Data.Entity.Core.Objects.RelationshipEntry>();
						}
						dictionary = this._deletedRelationshipStore;
					}
				}
				else
				{
					if (this._addedRelationshipStore == null)
					{
						this._addedRelationshipStore = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.RelationshipWrapper, global::System.Data.Entity.Core.Objects.RelationshipEntry>();
					}
					dictionary = this._addedRelationshipStore;
				}
			}
			else
			{
				if (this._unchangedRelationshipStore == null)
				{
					this._unchangedRelationshipStore = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.RelationshipWrapper, global::System.Data.Entity.Core.Objects.RelationshipEntry>();
				}
				dictionary = this._unchangedRelationshipStore;
			}
			dictionary.Add(entry.RelationshipWrapper, entry);
		}

		// Token: 0x0600338A RID: 13194 RVA: 0x000A4B00 File Offset: 0x000A2D00
		private void AddEntityEntryToDictionary(global::System.Data.Entity.Core.Objects.EntityEntry entry, global::System.Data.Entity.EntityState state)
		{
			if (entry.RequiresAnyChangeTracking)
			{
				this._detectChangesNeeded = true;
			}
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Objects.EntityEntry> dictionary = null;
			if (state <= global::System.Data.Entity.EntityState.Added)
			{
				if (state != global::System.Data.Entity.EntityState.Unchanged)
				{
					if (state == global::System.Data.Entity.EntityState.Added)
					{
						if (this._addedEntityStore == null)
						{
							this._addedEntityStore = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Objects.EntityEntry>();
						}
						dictionary = this._addedEntityStore;
					}
				}
				else
				{
					if (this._unchangedEntityStore == null)
					{
						this._unchangedEntityStore = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Objects.EntityEntry>();
					}
					dictionary = this._unchangedEntityStore;
				}
			}
			else if (state != global::System.Data.Entity.EntityState.Deleted)
			{
				if (state == global::System.Data.Entity.EntityState.Modified)
				{
					if (this._modifiedEntityStore == null)
					{
						this._modifiedEntityStore = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Objects.EntityEntry>();
					}
					dictionary = this._modifiedEntityStore;
				}
			}
			else
			{
				if (this._deletedEntityStore == null)
				{
					this._deletedEntityStore = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Objects.EntityEntry>();
				}
				dictionary = this._deletedEntityStore;
			}
			dictionary.Add(entry.EntityKey, entry);
			this.AddEntryToKeylessStore(entry);
		}

		// Token: 0x0600338B RID: 13195 RVA: 0x000A4BBC File Offset: 0x000A2DBC
		private void AddEntryToKeylessStore(global::System.Data.Entity.Core.Objects.EntityEntry entry)
		{
			if (entry.Entity != null && !(entry.Entity is global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithKey))
			{
				if (this._keylessEntityStore == null)
				{
					this._keylessEntityStore = new global::System.Collections.Generic.Dictionary<object, global::System.Data.Entity.Core.Objects.EntityEntry>(global::System.Data.Entity.Infrastructure.ObjectReferenceEqualityComparer.Default);
				}
				if (!this._keylessEntityStore.ContainsKey(entry.Entity))
				{
					this._keylessEntityStore.Add(entry.Entity, entry);
				}
			}
		}

		// Token: 0x0600338C RID: 13196 RVA: 0x000A4C1C File Offset: 0x000A2E1C
		private void RemoveObjectStateEntryFromDictionary(global::System.Data.Entity.Core.Objects.RelationshipEntry entry, global::System.Data.Entity.EntityState state)
		{
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.RelationshipWrapper, global::System.Data.Entity.Core.Objects.RelationshipEntry> dictionary = null;
			if (state != global::System.Data.Entity.EntityState.Unchanged)
			{
				if (state != global::System.Data.Entity.EntityState.Added)
				{
					if (state == global::System.Data.Entity.EntityState.Deleted)
					{
						dictionary = this._deletedRelationshipStore;
					}
				}
				else
				{
					dictionary = this._addedRelationshipStore;
				}
			}
			else
			{
				dictionary = this._unchangedRelationshipStore;
			}
			dictionary.Remove(entry.RelationshipWrapper);
			if (dictionary.Count == 0)
			{
				if (state == global::System.Data.Entity.EntityState.Unchanged)
				{
					this._unchangedRelationshipStore = null;
					return;
				}
				if (state == global::System.Data.Entity.EntityState.Added)
				{
					this._addedRelationshipStore = null;
					return;
				}
				if (state != global::System.Data.Entity.EntityState.Deleted)
				{
					return;
				}
				this._deletedRelationshipStore = null;
			}
		}

		// Token: 0x0600338D RID: 13197 RVA: 0x000A4C8C File Offset: 0x000A2E8C
		private void RemoveObjectStateEntryFromDictionary(global::System.Data.Entity.Core.Objects.EntityEntry entry, global::System.Data.Entity.EntityState state)
		{
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Objects.EntityEntry> dictionary = null;
			if (state <= global::System.Data.Entity.EntityState.Added)
			{
				if (state != global::System.Data.Entity.EntityState.Unchanged)
				{
					if (state == global::System.Data.Entity.EntityState.Added)
					{
						dictionary = this._addedEntityStore;
					}
				}
				else
				{
					dictionary = this._unchangedEntityStore;
				}
			}
			else if (state != global::System.Data.Entity.EntityState.Deleted)
			{
				if (state == global::System.Data.Entity.EntityState.Modified)
				{
					dictionary = this._modifiedEntityStore;
				}
			}
			else
			{
				dictionary = this._deletedEntityStore;
			}
			dictionary.Remove(entry.EntityKey);
			this.RemoveEntryFromKeylessStore(entry.WrappedEntity);
			if (dictionary.Count == 0)
			{
				if (state <= global::System.Data.Entity.EntityState.Added)
				{
					if (state == global::System.Data.Entity.EntityState.Unchanged)
					{
						this._unchangedEntityStore = null;
						return;
					}
					if (state != global::System.Data.Entity.EntityState.Added)
					{
						return;
					}
					this._addedEntityStore = null;
					return;
				}
				else
				{
					if (state == global::System.Data.Entity.EntityState.Deleted)
					{
						this._deletedEntityStore = null;
						return;
					}
					if (state != global::System.Data.Entity.EntityState.Modified)
					{
						return;
					}
					this._modifiedEntityStore = null;
				}
			}
		}

		// Token: 0x0600338E RID: 13198 RVA: 0x000A4D2D File Offset: 0x000A2F2D
		internal virtual void RemoveEntryFromKeylessStore(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity)
		{
			if (wrappedEntity != null && wrappedEntity.Entity != null && !(wrappedEntity.Entity is global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithKey))
			{
				this._keylessEntityStore.Remove(wrappedEntity.Entity);
			}
		}

		// Token: 0x0600338F RID: 13199 RVA: 0x000A4D5C File Offset: 0x000A2F5C
		internal virtual global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata GetOrAddStateManagerTypeMetadata(global::System.Type entityType, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet)
		{
			global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata result;
			if (!this._metadataMapping.TryGetValue(new global::System.Data.Entity.Core.Objects.EntitySetQualifiedType(entityType, entitySet), out result))
			{
				result = this.AddStateManagerTypeMetadata(entitySet, (global::System.Data.Entity.Core.Mapping.ObjectTypeMapping)this.MetadataWorkspace.GetMap(entityType.FullNameWithNesting(), global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OSpace, global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OCSpace));
			}
			return result;
		}

		// Token: 0x06003390 RID: 13200 RVA: 0x000A4DA0 File Offset: 0x000A2FA0
		internal virtual global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata GetOrAddStateManagerTypeMetadata(global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType)
		{
			global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata result;
			if (!this._metadataStore.TryGetValue(edmType, out result))
			{
				result = this.AddStateManagerTypeMetadata(edmType, (global::System.Data.Entity.Core.Mapping.ObjectTypeMapping)this.MetadataWorkspace.GetMap(edmType, global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OCSpace));
			}
			return result;
		}

		// Token: 0x06003391 RID: 13201 RVA: 0x000A4DD8 File Offset: 0x000A2FD8
		private global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata AddStateManagerTypeMetadata(global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Data.Entity.Core.Mapping.ObjectTypeMapping mapping)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = mapping.EdmType;
			global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata stateManagerTypeMetadata;
			if (!this._metadataStore.TryGetValue(edmType, out stateManagerTypeMetadata))
			{
				stateManagerTypeMetadata = new global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata(edmType, mapping);
				this._metadataStore.Add(edmType, stateManagerTypeMetadata);
			}
			global::System.Data.Entity.Core.Objects.EntitySetQualifiedType key = new global::System.Data.Entity.Core.Objects.EntitySetQualifiedType(mapping.ClrType.ClrType, entitySet);
			if (!this._metadataMapping.ContainsKey(key))
			{
				this._metadataMapping.Add(key, stateManagerTypeMetadata);
				return stateManagerTypeMetadata;
			}
			throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.Mapping_CannotMapCLRTypeMultipleTimes(stateManagerTypeMetadata.CdmMetadata.EdmType.FullName));
		}

		// Token: 0x06003392 RID: 13202 RVA: 0x000A4E60 File Offset: 0x000A3060
		private global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata AddStateManagerTypeMetadata(global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType, global::System.Data.Entity.Core.Mapping.ObjectTypeMapping mapping)
		{
			global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata stateManagerTypeMetadata = new global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata(edmType, mapping);
			this._metadataStore.Add(edmType, stateManagerTypeMetadata);
			return stateManagerTypeMetadata;
		}

		// Token: 0x06003393 RID: 13203 RVA: 0x000A4E83 File Offset: 0x000A3083
		internal virtual void Dispose()
		{
			this._isDisposed = true;
		}

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x06003394 RID: 13204 RVA: 0x000A4E8C File Offset: 0x000A308C
		internal virtual bool IsDisposed
		{
			get
			{
				return this._isDisposed;
			}
		}

		// Token: 0x06003395 RID: 13205 RVA: 0x000A4E94 File Offset: 0x000A3094
		internal virtual void DetectChanges()
		{
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Objects.EntityEntry> entityEntriesForDetectChanges = this.GetEntityEntriesForDetectChanges();
			if (entityEntriesForDetectChanges == null)
			{
				return;
			}
			if (this.TransactionManager.BeginDetectChanges())
			{
				try
				{
					global::System.Data.Entity.Core.Objects.ObjectStateManager.DetectChangesInNavigationProperties(entityEntriesForDetectChanges);
					global::System.Data.Entity.Core.Objects.ObjectStateManager.DetectChangesInScalarAndComplexProperties(entityEntriesForDetectChanges);
					global::System.Data.Entity.Core.Objects.ObjectStateManager.DetectChangesInForeignKeys(entityEntriesForDetectChanges);
					this.DetectConflicts(entityEntriesForDetectChanges);
					this.TransactionManager.BeginAlignChanges();
					this.AlignChangesInRelationships(entityEntriesForDetectChanges);
				}
				finally
				{
					this.TransactionManager.EndAlignChanges();
					this.TransactionManager.EndDetectChanges();
				}
			}
		}

		// Token: 0x06003396 RID: 13206 RVA: 0x000A4F10 File Offset: 0x000A3110
		private void DetectConflicts(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Objects.EntityEntry> entries)
		{
			global::System.Data.Entity.Core.Objects.Internal.TransactionManager transactionManager = this.TransactionManager;
			foreach (global::System.Data.Entity.Core.Objects.EntityEntry entityEntry in entries)
			{
				global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>> dictionary;
				transactionManager.AddedRelationshipsByGraph.TryGetValue(entityEntry.WrappedEntity, out dictionary);
				global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.EntityKey>> dictionary2;
				transactionManager.AddedRelationshipsByForeignKey.TryGetValue(entityEntry.WrappedEntity, out dictionary2);
				if (dictionary != null && dictionary.Count > 0 && entityEntry.State == global::System.Data.Entity.EntityState.Deleted)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.RelatedEnd_UnableToAddRelationshipWithDeletedEntity);
				}
				if (dictionary2 != null)
				{
					foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.EntityKey>> keyValuePair in dictionary2)
					{
						if ((entityEntry.State == global::System.Data.Entity.EntityState.Unchanged || entityEntry.State == global::System.Data.Entity.EntityState.Modified) && keyValuePair.Key.IsDependentEndOfReferentialConstraint(true) && keyValuePair.Value.Count > 0)
						{
							throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityReference_CannotChangeReferentialConstraintProperty);
						}
						if (keyValuePair.Key is global::System.Data.Entity.Core.Objects.DataClasses.EntityReference && keyValuePair.Value.Count > 1)
						{
							throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateManager_ConflictingChangesOfRelationshipDetected(keyValuePair.Key.RelationshipNavigation.To, keyValuePair.Key.RelationshipNavigation.RelationshipName));
						}
					}
				}
				if (dictionary != null)
				{
					global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.KeyValuePair<object, global::System.Data.Entity.Core.Objects.IntBox>> properties = new global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.KeyValuePair<object, global::System.Data.Entity.Core.Objects.IntBox>>();
					foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>> keyValuePair2 in dictionary)
					{
						if (keyValuePair2.Key.IsForeignKey && (entityEntry.State == global::System.Data.Entity.EntityState.Unchanged || entityEntry.State == global::System.Data.Entity.EntityState.Modified) && keyValuePair2.Key.IsDependentEndOfReferentialConstraint(true) && keyValuePair2.Value.Count > 0)
						{
							throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityReference_CannotChangeReferentialConstraintProperty);
						}
						global::System.Data.Entity.Core.Objects.DataClasses.EntityReference entityReference = keyValuePair2.Key as global::System.Data.Entity.Core.Objects.DataClasses.EntityReference;
						if (entityReference != null)
						{
							if (keyValuePair2.Value.Count > 1)
							{
								throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateManager_ConflictingChangesOfRelationshipDetected(keyValuePair2.Key.RelationshipNavigation.To, keyValuePair2.Key.RelationshipNavigation.RelationshipName));
							}
							if (keyValuePair2.Value.Count == 1)
							{
								global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper entityWrapper = keyValuePair2.Value.First<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>();
								global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.EntityKey> hashSet = null;
								global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.EntityKey>> dictionary3;
								if (dictionary2 != null)
								{
									dictionary2.TryGetValue(keyValuePair2.Key, out hashSet);
								}
								else if (transactionManager.AddedRelationshipsByPrincipalKey.TryGetValue(entityEntry.WrappedEntity, out dictionary3))
								{
									dictionary3.TryGetValue(keyValuePair2.Key, out hashSet);
								}
								global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.EntityKey>> dictionary4;
								global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.EntityKey> hashSet2;
								if (hashSet != null && hashSet.Count > 0)
								{
									if (this.GetPermanentKey(entityEntry.WrappedEntity, entityReference, entityWrapper) != hashSet.First<global::System.Data.Entity.Core.EntityKey>())
									{
										throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateManager_ConflictingChangesOfRelationshipDetected(entityReference.RelationshipNavigation.To, entityReference.RelationshipNavigation.RelationshipName));
									}
								}
								else if (transactionManager.DeletedRelationshipsByForeignKey.TryGetValue(entityEntry.WrappedEntity, out dictionary4) && dictionary4.TryGetValue(keyValuePair2.Key, out hashSet2) && hashSet2.Count > 0)
								{
									throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateManager_ConflictingChangesOfRelationshipDetected(entityReference.RelationshipNavigation.To, entityReference.RelationshipNavigation.RelationshipName));
								}
								global::System.Data.Entity.Core.Objects.EntityEntry entityEntry2 = this.FindEntityEntry(entityWrapper.Entity);
								if (entityEntry2 != null && (entityEntry2.State == global::System.Data.Entity.EntityState.Unchanged || entityEntry2.State == global::System.Data.Entity.EntityState.Modified))
								{
									global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.KeyValuePair<object, global::System.Data.Entity.Core.Objects.IntBox>> dictionary5 = new global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.KeyValuePair<object, global::System.Data.Entity.Core.Objects.IntBox>>();
									entityEntry2.GetOtherKeyProperties(dictionary5);
									foreach (global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint referentialConstraint in ((global::System.Data.Entity.Core.Metadata.Edm.AssociationType)entityReference.RelationMetadata).ReferentialConstraints)
									{
										if (referentialConstraint.ToRole == entityReference.FromEndMember)
										{
											for (int i = 0; i < referentialConstraint.FromProperties.Count; i++)
											{
												global::System.Data.Entity.Core.Objects.EntityEntry.AddOrIncreaseCounter(referentialConstraint, properties, referentialConstraint.ToProperties[i].Name, dictionary5[referentialConstraint.FromProperties[i].Name].Key);
											}
											break;
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06003397 RID: 13207 RVA: 0x000A5380 File Offset: 0x000A3580
		internal virtual global::System.Data.Entity.Core.EntityKey GetPermanentKey(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper entityFrom, global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEndFrom, global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper entityTo)
		{
			global::System.Data.Entity.Core.EntityKey entityKey = null;
			if (entityTo.ObjectStateEntry != null)
			{
				entityKey = entityTo.ObjectStateEntry.EntityKey;
			}
			if (entityKey == null || entityKey.IsTemporary)
			{
				entityKey = this.CreateEntityKey(global::System.Data.Entity.Core.Objects.ObjectStateManager.GetEntitySetOfOtherEnd(entityFrom, relatedEndFrom), entityTo.Entity);
			}
			return entityKey;
		}

		// Token: 0x06003398 RID: 13208 RVA: 0x000A53CC File Offset: 0x000A35CC
		private static global::System.Data.Entity.Core.Metadata.Edm.EntitySet GetEntitySetOfOtherEnd(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper entity, global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd)
		{
			global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet = (global::System.Data.Entity.Core.Metadata.Edm.AssociationSet)relatedEnd.RelationshipSet;
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = associationSet.AssociationSetEnds[0].EntitySet;
			if (entitySet.Name != entity.EntityKey.EntitySetName)
			{
				return entitySet;
			}
			return associationSet.AssociationSetEnds[1].EntitySet;
		}

		// Token: 0x06003399 RID: 13209 RVA: 0x000A5424 File Offset: 0x000A3624
		private static void DetectChangesInForeignKeys(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Objects.EntityEntry> entries)
		{
			foreach (global::System.Data.Entity.Core.Objects.EntityEntry entityEntry in entries)
			{
				if (entityEntry.State == global::System.Data.Entity.EntityState.Added || entityEntry.State == global::System.Data.Entity.EntityState.Modified)
				{
					entityEntry.DetectChangesInForeignKeys();
				}
			}
		}

		// Token: 0x0600339A RID: 13210 RVA: 0x000A5480 File Offset: 0x000A3680
		private void AlignChangesInRelationships(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Objects.EntityEntry> entries)
		{
			this.PerformDelete(entries);
			this.PerformAdd(entries);
		}

		// Token: 0x0600339B RID: 13211 RVA: 0x000A5490 File Offset: 0x000A3690
		private void PerformAdd(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Objects.EntityEntry> entries)
		{
			global::System.Data.Entity.Core.Objects.Internal.TransactionManager transactionManager = this.TransactionManager;
			foreach (global::System.Data.Entity.Core.Objects.EntityEntry entityEntry in entries)
			{
				if (entityEntry.State != global::System.Data.Entity.EntityState.Detached && !entityEntry.IsKeyEntry)
				{
					foreach (global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd in entityEntry.WrappedEntity.RelationshipManager.Relationships)
					{
						global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.EntityKey> hashSet = null;
						global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.EntityKey>> dictionary;
						if (relatedEnd is global::System.Data.Entity.Core.Objects.DataClasses.EntityReference && transactionManager.AddedRelationshipsByForeignKey.TryGetValue(entityEntry.WrappedEntity, out dictionary))
						{
							dictionary.TryGetValue(relatedEnd, out hashSet);
						}
						global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper> hashSet2 = null;
						global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>> dictionary2;
						if (transactionManager.AddedRelationshipsByGraph.TryGetValue(entityEntry.WrappedEntity, out dictionary2))
						{
							dictionary2.TryGetValue(relatedEnd, out hashSet2);
						}
						if (hashSet != null)
						{
							foreach (global::System.Data.Entity.Core.EntityKey key in hashSet)
							{
								global::System.Data.Entity.Core.Objects.EntityEntry entityEntry2;
								if (this.TryGetEntityEntry(key, out entityEntry2) && entityEntry2.WrappedEntity.Entity != null)
								{
									hashSet2 = ((hashSet2 != null) ? hashSet2 : new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>());
									if (entityEntry2.State != global::System.Data.Entity.EntityState.Deleted)
									{
										hashSet2.Remove(entityEntry2.WrappedEntity);
										this.PerformAdd(entityEntry.WrappedEntity, relatedEnd, entityEntry2.WrappedEntity, true);
									}
								}
								else
								{
									global::System.Data.Entity.Core.Objects.DataClasses.EntityReference reference = relatedEnd as global::System.Data.Entity.Core.Objects.DataClasses.EntityReference;
									entityEntry.FixupEntityReferenceByForeignKey(reference);
								}
							}
						}
						if (hashSet2 != null)
						{
							foreach (global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper entityToAdd in hashSet2)
							{
								this.PerformAdd(entityEntry.WrappedEntity, relatedEnd, entityToAdd, false);
							}
						}
					}
				}
			}
		}

		// Token: 0x0600339C RID: 13212 RVA: 0x000A56B8 File Offset: 0x000A38B8
		private void PerformAdd(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedOwner, global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd, global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper entityToAdd, bool isForeignKeyChange)
		{
			relatedEnd.ValidateStateForAdd(relatedEnd.WrappedOwner);
			relatedEnd.ValidateStateForAdd(entityToAdd);
			if (relatedEnd.IsPrincipalEndOfReferentialConstraint())
			{
				global::System.Data.Entity.Core.Objects.DataClasses.EntityReference entityReference = relatedEnd.GetOtherEndOfRelationship(entityToAdd) as global::System.Data.Entity.Core.Objects.DataClasses.EntityReference;
				if (entityReference != null && this.IsReparentingReference(entityToAdd, entityReference))
				{
					this.TransactionManager.EntityBeingReparented = entityReference.GetDependentEndOfReferentialConstraint(entityReference.ReferenceValue.Entity);
				}
			}
			else if (relatedEnd.IsDependentEndOfReferentialConstraint(false))
			{
				global::System.Data.Entity.Core.Objects.DataClasses.EntityReference entityReference2 = relatedEnd as global::System.Data.Entity.Core.Objects.DataClasses.EntityReference;
				if (entityReference2 != null && this.IsReparentingReference(wrappedOwner, entityReference2))
				{
					this.TransactionManager.EntityBeingReparented = entityReference2.GetDependentEndOfReferentialConstraint(entityReference2.ReferenceValue.Entity);
				}
			}
			try
			{
				relatedEnd.Add(entityToAdd, false, false, false, true, !isForeignKeyChange);
			}
			finally
			{
				this.TransactionManager.EntityBeingReparented = null;
			}
		}

		// Token: 0x0600339D RID: 13213 RVA: 0x000A5784 File Offset: 0x000A3984
		private void PerformDelete(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Objects.EntityEntry> entries)
		{
			global::System.Data.Entity.Core.Objects.Internal.TransactionManager transactionManager = this.TransactionManager;
			foreach (global::System.Data.Entity.Core.Objects.EntityEntry entityEntry in entries)
			{
				if (entityEntry.State != global::System.Data.Entity.EntityState.Detached && entityEntry.State != global::System.Data.Entity.EntityState.Deleted && !entityEntry.IsKeyEntry)
				{
					foreach (global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd in entityEntry.WrappedEntity.RelationshipManager.Relationships)
					{
						global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.EntityKey> hashSet = null;
						global::System.Data.Entity.Core.Objects.DataClasses.EntityReference entityReference = relatedEnd as global::System.Data.Entity.Core.Objects.DataClasses.EntityReference;
						global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.EntityKey>> dictionary;
						if (entityReference != null && transactionManager.DeletedRelationshipsByForeignKey.TryGetValue(entityEntry.WrappedEntity, out dictionary))
						{
							dictionary.TryGetValue(entityReference, out hashSet);
						}
						global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper> hashSet2 = null;
						global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>> dictionary2;
						if (transactionManager.DeletedRelationshipsByGraph.TryGetValue(entityEntry.WrappedEntity, out dictionary2))
						{
							dictionary2.TryGetValue(relatedEnd, out hashSet2);
						}
						if (hashSet != null)
						{
							foreach (global::System.Data.Entity.Core.EntityKey entityKey in hashSet)
							{
								global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper entityWrapper = null;
								global::System.Data.Entity.Core.Objects.EntityEntry entityEntry2;
								if (this.TryGetEntityEntry(entityKey, out entityEntry2) && entityEntry2.WrappedEntity.Entity != null)
								{
									entityWrapper = entityEntry2.WrappedEntity;
								}
								else if (entityReference != null && entityReference.ReferenceValue != global::System.Data.Entity.Core.Objects.Internal.NullEntityWrapper.NullWrapper && entityReference.ReferenceValue.EntityKey.IsTemporary && this.TryGetEntityEntry(entityReference.ReferenceValue.EntityKey, out entityEntry2) && entityEntry2.WrappedEntity.Entity != null)
								{
									global::System.Data.Entity.Core.EntityKey key = new global::System.Data.Entity.Core.EntityKey((global::System.Data.Entity.Core.Metadata.Edm.EntitySet)entityEntry2.EntitySet, entityEntry2.CurrentValues);
									if (entityKey == key)
									{
										entityWrapper = entityEntry2.WrappedEntity;
									}
								}
								if (entityWrapper != null)
								{
									hashSet2 = ((hashSet2 != null) ? hashSet2 : new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>());
									bool preserveForeignKey = this.ShouldPreserveForeignKeyForDependent(entityEntry.WrappedEntity, relatedEnd, entityWrapper, hashSet2);
									hashSet2.Remove(entityWrapper);
									if (entityReference != null && this.IsReparentingReference(entityEntry.WrappedEntity, entityReference))
									{
										this.TransactionManager.EntityBeingReparented = entityReference.GetDependentEndOfReferentialConstraint(entityReference.ReferenceValue.Entity);
									}
									try
									{
										relatedEnd.Remove(entityWrapper, preserveForeignKey);
									}
									finally
									{
										this.TransactionManager.EntityBeingReparented = null;
									}
									if (entityEntry.State == global::System.Data.Entity.EntityState.Detached || entityEntry.State == global::System.Data.Entity.EntityState.Deleted)
									{
										break;
									}
									if (entityEntry.IsKeyEntry)
									{
										break;
									}
								}
								if (entityReference != null && entityReference.IsForeignKey && entityReference.IsDependentEndOfReferentialConstraint(false))
								{
									entityReference.SetCachedForeignKey(global::System.Data.Entity.Core.Objects.Internal.ForeignKeyFactory.CreateKeyFromForeignKeyValues(entityEntry, entityReference), entityEntry);
								}
							}
						}
						if (hashSet2 != null)
						{
							foreach (global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper entityWrapper2 in hashSet2)
							{
								bool preserveForeignKey2 = this.ShouldPreserveForeignKeyForPrincipal(entityEntry.WrappedEntity, relatedEnd, entityWrapper2, hashSet2);
								if (entityReference != null && this.IsReparentingReference(entityEntry.WrappedEntity, entityReference))
								{
									this.TransactionManager.EntityBeingReparented = entityReference.GetDependentEndOfReferentialConstraint(entityReference.ReferenceValue.Entity);
								}
								try
								{
									relatedEnd.Remove(entityWrapper2, preserveForeignKey2);
								}
								finally
								{
									this.TransactionManager.EntityBeingReparented = null;
								}
								if (entityEntry.State == global::System.Data.Entity.EntityState.Detached || entityEntry.State == global::System.Data.Entity.EntityState.Deleted)
								{
									break;
								}
								if (entityEntry.IsKeyEntry)
								{
									break;
								}
							}
						}
						if (entityEntry.State == global::System.Data.Entity.EntityState.Detached || entityEntry.State == global::System.Data.Entity.EntityState.Deleted)
						{
							break;
						}
						if (entityEntry.IsKeyEntry)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600339E RID: 13214 RVA: 0x000A5B7C File Offset: 0x000A3D7C
		private bool ShouldPreserveForeignKeyForPrincipal(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper entity, global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd, global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper relatedEntity, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper> entitiesToDelete)
		{
			bool result = false;
			if (relatedEnd.IsForeignKey)
			{
				global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd otherEndOfRelationship = relatedEnd.GetOtherEndOfRelationship(relatedEntity);
				if (otherEndOfRelationship.IsDependentEndOfReferentialConstraint(false))
				{
					global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.EntityKey> hashSet = null;
					global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.EntityKey>> dictionary;
					global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>> dictionary2;
					if (this.TransactionManager.DeletedRelationshipsByForeignKey.TryGetValue(relatedEntity, out dictionary) && dictionary.TryGetValue(otherEndOfRelationship, out hashSet) && hashSet.Count > 0 && this.TransactionManager.DeletedRelationshipsByGraph.TryGetValue(relatedEntity, out dictionary2) && dictionary2.TryGetValue(otherEndOfRelationship, out entitiesToDelete))
					{
						result = this.ShouldPreserveForeignKeyForDependent(relatedEntity, otherEndOfRelationship, entity, entitiesToDelete);
					}
				}
			}
			return result;
		}

		// Token: 0x0600339F RID: 13215 RVA: 0x000A5C00 File Offset: 0x000A3E00
		private bool ShouldPreserveForeignKeyForDependent(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper entity, global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd, global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper relatedEntity, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper> entitiesToDelete)
		{
			bool flag = entitiesToDelete.Contains(relatedEntity);
			return !flag || (flag && !this.HasAddedReference(entity, relatedEnd as global::System.Data.Entity.Core.Objects.DataClasses.EntityReference));
		}

		// Token: 0x060033A0 RID: 13216 RVA: 0x000A5C30 File Offset: 0x000A3E30
		private bool HasAddedReference(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedOwner, global::System.Data.Entity.Core.Objects.DataClasses.EntityReference reference)
		{
			global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper> hashSet = null;
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>> dictionary;
			return reference != null && this.TransactionManager.AddedRelationshipsByGraph.TryGetValue(wrappedOwner, out dictionary) && dictionary.TryGetValue(reference, out hashSet) && hashSet.Count > 0;
		}

		// Token: 0x060033A1 RID: 13217 RVA: 0x000A5C70 File Offset: 0x000A3E70
		private bool IsReparentingReference(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity, global::System.Data.Entity.Core.Objects.DataClasses.EntityReference reference)
		{
			global::System.Data.Entity.Core.Objects.Internal.TransactionManager transactionManager = this.TransactionManager;
			if (reference.IsPrincipalEndOfReferentialConstraint())
			{
				wrappedEntity = reference.ReferenceValue;
				reference = ((wrappedEntity.Entity == null) ? null : (reference.GetOtherEndOfRelationship(wrappedEntity) as global::System.Data.Entity.Core.Objects.DataClasses.EntityReference));
			}
			if (wrappedEntity.Entity != null && reference != null)
			{
				global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.EntityKey> hashSet = null;
				global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.EntityKey>> dictionary;
				if (transactionManager.AddedRelationshipsByForeignKey.TryGetValue(wrappedEntity, out dictionary) && dictionary.TryGetValue(reference, out hashSet) && hashSet.Count > 0)
				{
					return true;
				}
				global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper> hashSet2 = null;
				global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>> dictionary2;
				if (transactionManager.AddedRelationshipsByGraph.TryGetValue(wrappedEntity, out dictionary2) && dictionary2.TryGetValue(reference, out hashSet2) && hashSet2.Count > 0)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060033A2 RID: 13218 RVA: 0x000A5D0C File Offset: 0x000A3F0C
		private static void DetectChangesInNavigationProperties(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Objects.EntityEntry> entries)
		{
			foreach (global::System.Data.Entity.Core.Objects.EntityEntry entityEntry in entries)
			{
				if (entityEntry.WrappedEntity.RequiresRelationshipChangeTracking)
				{
					entityEntry.DetectChangesInRelationshipsOfSingleEntity();
				}
			}
		}

		// Token: 0x060033A3 RID: 13219 RVA: 0x000A5D60 File Offset: 0x000A3F60
		private static void DetectChangesInScalarAndComplexProperties(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Objects.EntityEntry> entries)
		{
			foreach (global::System.Data.Entity.Core.Objects.EntityEntry entityEntry in entries)
			{
				if (entityEntry.State != global::System.Data.Entity.EntityState.Added && (entityEntry.RequiresScalarChangeTracking || entityEntry.RequiresComplexChangeTracking))
				{
					entityEntry.DetectChangesInProperties(!entityEntry.RequiresScalarChangeTracking);
				}
			}
		}

		// Token: 0x060033A4 RID: 13220 RVA: 0x000A5DCC File Offset: 0x000A3FCC
		internal virtual global::System.Data.Entity.Core.EntityKey CreateEntityKey(global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, object entity)
		{
			global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> keyMembers = entitySet.ElementType.KeyMembers;
			global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata orAddStateManagerTypeMetadata = this.GetOrAddStateManagerTypeMetadata(global::System.Data.Entity.Core.EntityUtil.GetEntityIdentityType(entity.GetType()), entitySet);
			object[] array = new object[keyMembers.Count];
			for (int i = 0; i < keyMembers.Count; i++)
			{
				string name = keyMembers[i].Name;
				int ordinalforCLayerMemberName = orAddStateManagerTypeMetadata.GetOrdinalforCLayerMemberName(name);
				if (ordinalforCLayerMemberName < 0)
				{
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ObjectStateManager_EntityTypeDoesnotMatchtoEntitySetType(entity.GetType().FullName, entitySet.Name), "entity");
				}
				array[i] = orAddStateManagerTypeMetadata.Member(ordinalforCLayerMemberName).GetValue(entity);
				if (array[i] == null)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityKey_NullKeyValue(name, entitySet.ElementType.Name));
				}
			}
			if (array.Length == 1)
			{
				return new global::System.Data.Entity.Core.EntityKey(entitySet, array[0]);
			}
			return new global::System.Data.Entity.Core.EntityKey(entitySet, array);
		}

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x060033A5 RID: 13221 RVA: 0x000A5E98 File Offset: 0x000A4098
		// (set) Token: 0x060033A6 RID: 13222 RVA: 0x000A5EA0 File Offset: 0x000A40A0
		internal virtual object EntityInvokingFKSetter { get; set; }

		// Token: 0x04001099 RID: 4249
		private const int InitialListSize = 16;

		// Token: 0x0400109A RID: 4250
		private global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Objects.EntityEntry> _addedEntityStore;

		// Token: 0x0400109B RID: 4251
		private global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Objects.EntityEntry> _modifiedEntityStore;

		// Token: 0x0400109C RID: 4252
		private global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Objects.EntityEntry> _deletedEntityStore;

		// Token: 0x0400109D RID: 4253
		private global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Objects.EntityEntry> _unchangedEntityStore;

		// Token: 0x0400109E RID: 4254
		private global::System.Collections.Generic.Dictionary<object, global::System.Data.Entity.Core.Objects.EntityEntry> _keylessEntityStore;

		// Token: 0x0400109F RID: 4255
		private global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.RelationshipWrapper, global::System.Data.Entity.Core.Objects.RelationshipEntry> _addedRelationshipStore;

		// Token: 0x040010A0 RID: 4256
		private global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.RelationshipWrapper, global::System.Data.Entity.Core.Objects.RelationshipEntry> _deletedRelationshipStore;

		// Token: 0x040010A1 RID: 4257
		private global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.RelationshipWrapper, global::System.Data.Entity.Core.Objects.RelationshipEntry> _unchangedRelationshipStore;

		// Token: 0x040010A2 RID: 4258
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmType, global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata> _metadataStore;

		// Token: 0x040010A3 RID: 4259
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.EntitySetQualifiedType, global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata> _metadataMapping;

		// Token: 0x040010A4 RID: 4260
		private readonly global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace _metadataWorkspace;

		// Token: 0x040010A5 RID: 4261
		private global::System.ComponentModel.CollectionChangeEventHandler onObjectStateManagerChangedDelegate;

		// Token: 0x040010A6 RID: 4262
		private global::System.ComponentModel.CollectionChangeEventHandler onEntityDeletedDelegate;

		// Token: 0x040010A7 RID: 4263
		private bool _inRelationshipFixup;

		// Token: 0x040010A8 RID: 4264
		private bool _isDisposed;

		// Token: 0x040010A9 RID: 4265
		private global::System.Data.Entity.Core.Objects.Internal.ComplexTypeMaterializer _complexTypeMaterializer;

		// Token: 0x040010AA RID: 4266
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.EntityKey, global::System.Collections.Generic.HashSet<global::System.Tuple<global::System.Data.Entity.Core.Objects.DataClasses.EntityReference, global::System.Data.Entity.Core.Objects.EntityEntry>>> _danglingForeignKeys = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.EntityKey, global::System.Collections.Generic.HashSet<global::System.Tuple<global::System.Data.Entity.Core.Objects.DataClasses.EntityReference, global::System.Data.Entity.Core.Objects.EntityEntry>>>();

		// Token: 0x040010AB RID: 4267
		private global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Objects.EntityEntry> _entriesWithConceptualNulls;

		// Token: 0x040010AC RID: 4268
		private readonly global::System.Data.Entity.Core.Objects.Internal.EntityWrapperFactory _entityWrapperFactory;

		// Token: 0x040010AD RID: 4269
		private bool _detectChangesNeeded;
	}
}
