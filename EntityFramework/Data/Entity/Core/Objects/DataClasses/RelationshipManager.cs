using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects.Internal;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;

namespace System.Data.Entity.Core.Objects.DataClasses
{
	// Token: 0x02000483 RID: 1155
	[global::System.Serializable]
	public class RelationshipManager
	{
		// Token: 0x060038F9 RID: 14585 RVA: 0x000BADE2 File Offset: 0x000B8FE2
		private RelationshipManager()
		{
			this._entityWrapperFactory = new global::System.Data.Entity.Core.Objects.Internal.EntityWrapperFactory();
			this._expensiveLoader = new global::System.Data.Entity.Core.Metadata.Edm.ExpensiveOSpaceLoader();
		}

		// Token: 0x060038FA RID: 14586 RVA: 0x000BAE00 File Offset: 0x000B9000
		internal RelationshipManager(global::System.Data.Entity.Core.Metadata.Edm.ExpensiveOSpaceLoader expensiveLoader)
		{
			this._entityWrapperFactory = new global::System.Data.Entity.Core.Objects.Internal.EntityWrapperFactory();
			this._expensiveLoader = (expensiveLoader ?? new global::System.Data.Entity.Core.Metadata.Edm.ExpensiveOSpaceLoader());
		}

		// Token: 0x060038FB RID: 14587 RVA: 0x000BAE23 File Offset: 0x000B9023
		internal void SetExpensiveLoader(global::System.Data.Entity.Core.Metadata.Edm.ExpensiveOSpaceLoader loader)
		{
			this._expensiveLoader = loader;
		}

		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x060038FC RID: 14588 RVA: 0x000BAE2C File Offset: 0x000B902C
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd> Relationships
		{
			get
			{
				this.EnsureRelationshipsInitialized();
				return this._relationships.ToArray();
			}
		}

		// Token: 0x060038FD RID: 14589 RVA: 0x000BAE3F File Offset: 0x000B903F
		private void EnsureRelationshipsInitialized()
		{
			if (this._relationships == null)
			{
				this._relationships = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd>();
			}
		}

		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x060038FE RID: 14590 RVA: 0x000BAE54 File Offset: 0x000B9054
		// (set) Token: 0x060038FF RID: 14591 RVA: 0x000BAE5C File Offset: 0x000B905C
		internal bool NodeVisited
		{
			get
			{
				return this._nodeVisited;
			}
			set
			{
				this._nodeVisited = value;
			}
		}

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x06003900 RID: 14592 RVA: 0x000BAE65 File Offset: 0x000B9065
		internal global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper WrappedOwner
		{
			get
			{
				if (this._wrappedOwner == null)
				{
					this._wrappedOwner = global::System.Data.Entity.Core.Objects.Internal.EntityWrapperFactory.CreateNewWrapper(this._owner, null);
				}
				return this._wrappedOwner;
			}
		}

		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x06003901 RID: 14593 RVA: 0x000BAE87 File Offset: 0x000B9087
		internal virtual global::System.Data.Entity.Core.Objects.Internal.EntityWrapperFactory EntityWrapperFactory
		{
			get
			{
				return this._entityWrapperFactory;
			}
		}

		// Token: 0x06003902 RID: 14594 RVA: 0x000BAE8F File Offset: 0x000B908F
		public static global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager Create(global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithRelationships owner)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithRelationships>(owner, "owner");
			return new global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager
			{
				_owner = owner
			};
		}

		// Token: 0x06003903 RID: 14595 RVA: 0x000BAEA9 File Offset: 0x000B90A9
		internal static global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager Create()
		{
			return new global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager();
		}

		// Token: 0x06003904 RID: 14596 RVA: 0x000BAEB0 File Offset: 0x000B90B0
		internal void SetWrappedOwner(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedOwner, object expectedOwner)
		{
			this._wrappedOwner = wrappedOwner;
			if (this._owner != null && expectedOwner != this._owner)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.RelationshipManager_InvalidRelationshipManagerOwner);
			}
			if (this._relationships != null)
			{
				foreach (global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd in this._relationships)
				{
					relatedEnd.SetWrappedOwner(wrappedOwner);
				}
			}
		}

		// Token: 0x06003905 RID: 14597 RVA: 0x000BAF2C File Offset: 0x000B912C
		internal global::System.Data.Entity.Core.Objects.DataClasses.EntityCollection<TTargetEntity> GetRelatedCollection<TSourceEntity, TTargetEntity>(global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember sourceMember, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember targetMember, global::System.Data.Entity.Core.Metadata.Edm.NavigationPropertyAccessor sourceAccessor, global::System.Data.Entity.Core.Metadata.Edm.NavigationPropertyAccessor targetAccessor, global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd existingRelatedEnd) where TSourceEntity : class where TTargetEntity : class
		{
			string fullName = sourceMember.DeclaringType.FullName;
			string name = targetMember.Name;
			global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity relationshipMultiplicity = sourceMember.RelationshipMultiplicity;
			global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd;
			this.TryGetCachedRelatedEnd(fullName, name, out relatedEnd);
			global::System.Data.Entity.Core.Objects.DataClasses.EntityCollection<TTargetEntity> entityCollection = relatedEnd as global::System.Data.Entity.Core.Objects.DataClasses.EntityCollection<TTargetEntity>;
			if (existingRelatedEnd != null)
			{
				if (relatedEnd != null)
				{
					this._relationships.Remove(relatedEnd);
				}
				global::System.Data.Entity.Core.Objects.DataClasses.RelationshipNavigation navigation = new global::System.Data.Entity.Core.Objects.DataClasses.RelationshipNavigation((global::System.Data.Entity.Core.Metadata.Edm.AssociationType)sourceMember.DeclaringType, sourceMember.Name, targetMember.Name, sourceAccessor, targetAccessor);
				global::System.Data.Entity.Core.Objects.DataClasses.EntityCollection<TTargetEntity> entityCollection2 = this.CreateRelatedEnd<TSourceEntity, TTargetEntity>(navigation, relationshipMultiplicity, global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, existingRelatedEnd) as global::System.Data.Entity.Core.Objects.DataClasses.EntityCollection<TTargetEntity>;
				if (entityCollection2 != null)
				{
					bool flag = true;
					try
					{
						global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager.RemergeCollections<TTargetEntity>(entityCollection, entityCollection2);
						flag = false;
					}
					finally
					{
						if (flag && relatedEnd != null)
						{
							this._relationships.Remove(entityCollection2);
							this._relationships.Add(relatedEnd);
						}
					}
				}
				return entityCollection2;
			}
			if (relatedEnd != null)
			{
				return entityCollection;
			}
			global::System.Data.Entity.Core.Objects.DataClasses.RelationshipNavigation navigation2 = new global::System.Data.Entity.Core.Objects.DataClasses.RelationshipNavigation((global::System.Data.Entity.Core.Metadata.Edm.AssociationType)sourceMember.DeclaringType, sourceMember.Name, targetMember.Name, sourceAccessor, targetAccessor);
			return this.CreateRelatedEnd<TSourceEntity, TTargetEntity>(navigation2, relationshipMultiplicity, global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, existingRelatedEnd) as global::System.Data.Entity.Core.Objects.DataClasses.EntityCollection<TTargetEntity>;
		}

		// Token: 0x06003906 RID: 14598 RVA: 0x000BB030 File Offset: 0x000B9230
		private static void RemergeCollections<TTargetEntity>(global::System.Data.Entity.Core.Objects.DataClasses.EntityCollection<TTargetEntity> previousCollection, global::System.Data.Entity.Core.Objects.DataClasses.EntityCollection<TTargetEntity> collection) where TTargetEntity : class
		{
			int num = 0;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>(collection.CountInternal);
			foreach (global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper item in collection.GetWrappedEntities())
			{
				list.Add(item);
			}
			foreach (global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity in list)
			{
				bool flag = true;
				if (previousCollection != null && previousCollection.ContainsEntity(wrappedEntity))
				{
					num++;
					flag = false;
				}
				if (flag)
				{
					collection.Remove(wrappedEntity, false);
					collection.Add(wrappedEntity);
				}
			}
			if (previousCollection != null && num != previousCollection.CountInternal)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.Collections_UnableToMergeCollections);
			}
		}

		// Token: 0x06003907 RID: 14599 RVA: 0x000BB108 File Offset: 0x000B9308
		internal global::System.Data.Entity.Core.Objects.DataClasses.EntityReference<TTargetEntity> GetRelatedReference<TSourceEntity, TTargetEntity>(global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember sourceMember, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember targetMember, global::System.Data.Entity.Core.Metadata.Edm.NavigationPropertyAccessor sourceAccessor, global::System.Data.Entity.Core.Metadata.Edm.NavigationPropertyAccessor targetAccessor, global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd existingRelatedEnd) where TSourceEntity : class where TTargetEntity : class
		{
			string fullName = sourceMember.DeclaringType.FullName;
			string name = targetMember.Name;
			global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity relationshipMultiplicity = sourceMember.RelationshipMultiplicity;
			global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd;
			if (this.TryGetCachedRelatedEnd(fullName, name, out relatedEnd))
			{
				return relatedEnd as global::System.Data.Entity.Core.Objects.DataClasses.EntityReference<TTargetEntity>;
			}
			global::System.Data.Entity.Core.Objects.DataClasses.RelationshipNavigation navigation = new global::System.Data.Entity.Core.Objects.DataClasses.RelationshipNavigation((global::System.Data.Entity.Core.Metadata.Edm.AssociationType)sourceMember.DeclaringType, sourceMember.Name, targetMember.Name, sourceAccessor, targetAccessor);
			return this.CreateRelatedEnd<TSourceEntity, TTargetEntity>(navigation, relationshipMultiplicity, global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One, existingRelatedEnd) as global::System.Data.Entity.Core.Objects.DataClasses.EntityReference<TTargetEntity>;
		}

		// Token: 0x06003908 RID: 14600 RVA: 0x000BB174 File Offset: 0x000B9374
		internal global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd GetRelatedEnd(string navigationProperty, bool throwArgumentException = false)
		{
			global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedOwner = this.WrappedOwner;
			global::System.Data.Entity.Core.Metadata.Edm.EntityType item = wrappedOwner.Context.MetadataWorkspace.GetItem<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(wrappedOwner.IdentityType.FullNameWithNesting(), global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OSpace);
			global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember;
			if (!wrappedOwner.Context.Perspective.TryGetMember(item, navigationProperty, false, out edmMember) || !(edmMember is global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty))
			{
				string message = global::System.Data.Entity.Resources.Strings.RelationshipManager_NavigationPropertyNotFound(navigationProperty);
				throw throwArgumentException ? new global::System.ArgumentException(message) : new global::System.InvalidOperationException(message);
			}
			global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navigationProperty2 = (global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty)edmMember;
			return this.GetRelatedEndInternal(navigationProperty2.RelationshipType.FullName, navigationProperty2.ToEndMember.Name);
		}

		// Token: 0x06003909 RID: 14601 RVA: 0x000BB203 File Offset: 0x000B9403
		public global::System.Data.Entity.Core.Objects.DataClasses.IRelatedEnd GetRelatedEnd(string relationshipName, string targetRoleName)
		{
			return this.GetRelatedEndInternal(this.PrependNamespaceToRelationshipName(relationshipName), targetRoleName);
		}

		// Token: 0x0600390A RID: 14602 RVA: 0x000BB214 File Offset: 0x000B9414
		internal global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd GetRelatedEndInternal(string relationshipName, string targetRoleName)
		{
			global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedOwner = this.WrappedOwner;
			if (wrappedOwner.Context == null && wrappedOwner.RequiresRelationshipChangeTracking)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.RelationshipManager_CannotGetRelatEndForDetachedPocoEntity);
			}
			global::System.Data.Entity.Core.Metadata.Edm.AssociationType relationshipType = this.GetRelationshipType(relationshipName);
			return this.GetRelatedEndInternal(relationshipName, targetRoleName, null, relationshipType);
		}

		// Token: 0x0600390B RID: 14603 RVA: 0x000BB258 File Offset: 0x000B9458
		private global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd GetRelatedEndInternal(string relationshipName, string targetRoleName, global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd existingRelatedEnd, global::System.Data.Entity.Core.Metadata.Edm.AssociationType relationship)
		{
			global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember;
			global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember targetMember;
			global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager.GetAssociationEnds(relationship, targetRoleName, out associationEndMember, out targetMember);
			global::System.Type clrType = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetEntityTypeForEnd(associationEndMember).ClrType;
			global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedOwner = this.WrappedOwner;
			if (!clrType.IsAssignableFrom(wrappedOwner.IdentityType))
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.RelationshipManager_OwnerIsNotSourceType(wrappedOwner.IdentityType.FullName, clrType.FullName, associationEndMember.Name, relationshipName));
			}
			if (!this.VerifyRelationship(relationship, associationEndMember.Name))
			{
				return null;
			}
			return global::System.Data.Entity.Core.Objects.DelegateFactory.GetRelatedEnd(this, associationEndMember, targetMember, existingRelatedEnd);
		}

		// Token: 0x0600390C RID: 14604 RVA: 0x000BB2D0 File Offset: 0x000B94D0
		internal global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd GetRelatedEndInternal(global::System.Data.Entity.Core.Metadata.Edm.AssociationType csAssociationType, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember csTargetEnd)
		{
			global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedOwner = this.WrappedOwner;
			if (wrappedOwner.Context == null && wrappedOwner.RequiresRelationshipChangeTracking)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.RelationshipManager_CannotGetRelatEndForDetachedPocoEntity);
			}
			global::System.Data.Entity.Core.Metadata.Edm.AssociationType relationshipType = this.GetRelationshipType(csAssociationType);
			global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember;
			global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember targetMember;
			global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager.GetAssociationEnds(relationshipType, csTargetEnd.Name, out associationEndMember, out targetMember);
			global::System.Type clrType = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetEntityTypeForEnd(associationEndMember).ClrType;
			if (!clrType.IsAssignableFrom(wrappedOwner.IdentityType))
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.RelationshipManager_OwnerIsNotSourceType(wrappedOwner.IdentityType.FullName, clrType.FullName, associationEndMember.Name, csAssociationType.FullName));
			}
			if (!this.VerifyRelationship(relationshipType, csAssociationType, associationEndMember.Name))
			{
				return null;
			}
			return global::System.Data.Entity.Core.Objects.DelegateFactory.GetRelatedEnd(this, associationEndMember, targetMember, null);
		}

		// Token: 0x0600390D RID: 14605 RVA: 0x000BB378 File Offset: 0x000B9578
		private static void GetAssociationEnds(global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType, string targetRoleName, out global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember sourceEnd, out global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember targetEnd)
		{
			targetEnd = associationType.TargetEnd;
			if (targetEnd.Identity != targetRoleName)
			{
				sourceEnd = targetEnd;
				targetEnd = associationType.SourceEnd;
				if (targetEnd.Identity != targetRoleName)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.RelationshipManager_InvalidTargetRole(associationType.FullName, targetRoleName));
				}
			}
			else
			{
				sourceEnd = associationType.SourceEnd;
			}
		}

		// Token: 0x0600390E RID: 14606 RVA: 0x000BB3D4 File Offset: 0x000B95D4
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void InitializeRelatedReference<TTargetEntity>(string relationshipName, string targetRoleName, global::System.Data.Entity.Core.Objects.DataClasses.EntityReference<TTargetEntity> entityReference) where TTargetEntity : class
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(relationshipName, "relationshipName");
			global::System.Data.Entity.Utilities.Check.NotNull<string>(targetRoleName, "targetRoleName");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Objects.DataClasses.EntityReference<TTargetEntity>>(entityReference, "entityReference");
			if (entityReference.WrappedOwner.Entity != null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.RelationshipManager_ReferenceAlreadyInitialized(global::System.Data.Entity.Resources.Strings.RelationshipManager_InitializeIsForDeserialization));
			}
			global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedOwner = this.WrappedOwner;
			if (wrappedOwner.Context != null && wrappedOwner.MergeOption != global::System.Data.Entity.Core.Objects.MergeOption.NoTracking)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.RelationshipManager_RelationshipManagerAttached(global::System.Data.Entity.Resources.Strings.RelationshipManager_InitializeIsForDeserialization));
			}
			relationshipName = this.PrependNamespaceToRelationshipName(relationshipName);
			global::System.Data.Entity.Core.Metadata.Edm.AssociationType relationshipType = this.GetRelationshipType(relationshipName);
			global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd;
			if (this.TryGetCachedRelatedEnd(relationshipName, targetRoleName, out relatedEnd))
			{
				if (!relatedEnd.IsEmpty())
				{
					entityReference.InitializeWithValue(relatedEnd);
				}
				this._relationships.Remove(relatedEnd);
			}
			if (!(this.GetRelatedEndInternal(relationshipName, targetRoleName, entityReference, relationshipType) is global::System.Data.Entity.Core.Objects.DataClasses.EntityReference<TTargetEntity>))
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityReference_ExpectedReferenceGotCollection(typeof(TTargetEntity).Name, targetRoleName, relationshipName));
			}
		}

		// Token: 0x0600390F RID: 14607 RVA: 0x000BB4B0 File Offset: 0x000B96B0
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void InitializeRelatedCollection<TTargetEntity>(string relationshipName, string targetRoleName, global::System.Data.Entity.Core.Objects.DataClasses.EntityCollection<TTargetEntity> entityCollection) where TTargetEntity : class
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(relationshipName, "relationshipName");
			global::System.Data.Entity.Utilities.Check.NotNull<string>(targetRoleName, "targetRoleName");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Objects.DataClasses.EntityCollection<TTargetEntity>>(entityCollection, "entityCollection");
			if (entityCollection.WrappedOwner.Entity != null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.RelationshipManager_CollectionAlreadyInitialized(global::System.Data.Entity.Resources.Strings.RelationshipManager_CollectionInitializeIsForDeserialization));
			}
			global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedOwner = this.WrappedOwner;
			if (wrappedOwner.Context != null && wrappedOwner.MergeOption != global::System.Data.Entity.Core.Objects.MergeOption.NoTracking)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.RelationshipManager_CollectionRelationshipManagerAttached(global::System.Data.Entity.Resources.Strings.RelationshipManager_CollectionInitializeIsForDeserialization));
			}
			relationshipName = this.PrependNamespaceToRelationshipName(relationshipName);
			global::System.Data.Entity.Core.Metadata.Edm.AssociationType relationshipType = this.GetRelationshipType(relationshipName);
			if (!(this.GetRelatedEndInternal(relationshipName, targetRoleName, entityCollection, relationshipType) is global::System.Data.Entity.Core.Objects.DataClasses.EntityCollection<TTargetEntity>))
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.Collections_ExpectedCollectionGotReference(typeof(TTargetEntity).Name, targetRoleName, relationshipName));
			}
		}

		// Token: 0x06003910 RID: 14608 RVA: 0x000BB564 File Offset: 0x000B9764
		internal string PrependNamespaceToRelationshipName(string relationshipName)
		{
			if (!relationshipName.Contains("."))
			{
				global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType;
				if (global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.TryGetAssociationTypeFromProxyInfo(this.WrappedOwner, relationshipName, out associationType))
				{
					return associationType.FullName;
				}
				if (this._relationships != null)
				{
					string text = (from r in this._relationships
					select r.RelationshipName).FirstOrDefault((string n) => n.Substring(n.LastIndexOf('.') + 1) == relationshipName);
					if (text != null)
					{
						return text;
					}
				}
				string text2 = this.WrappedOwner.IdentityType.FullNameWithNesting();
				global::System.Data.Entity.Core.Metadata.Edm.ObjectItemCollection objectItemCollection = global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager.GetObjectItemCollection(this.WrappedOwner);
				global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = null;
				if (objectItemCollection != null)
				{
					objectItemCollection.TryGetItem<global::System.Data.Entity.Core.Metadata.Edm.EdmType>(text2, out edmType);
				}
				else
				{
					global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.EdmType> dictionary = this._expensiveLoader.LoadTypesExpensiveWay(this.WrappedOwner.IdentityType.Assembly());
					if (dictionary != null)
					{
						dictionary.TryGetValue(text2, out edmType);
					}
				}
				global::System.Data.Entity.Core.Metadata.Edm.ClrEntityType clrEntityType = edmType as global::System.Data.Entity.Core.Metadata.Edm.ClrEntityType;
				if (clrEntityType != null)
				{
					return clrEntityType.CSpaceNamespaceName + "." + relationshipName;
				}
			}
			return relationshipName;
		}

		// Token: 0x06003911 RID: 14609 RVA: 0x000BB681 File Offset: 0x000B9881
		private static global::System.Data.Entity.Core.Metadata.Edm.ObjectItemCollection GetObjectItemCollection(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedOwner)
		{
			if (wrappedOwner.Context != null)
			{
				return (global::System.Data.Entity.Core.Metadata.Edm.ObjectItemCollection)wrappedOwner.Context.MetadataWorkspace.GetItemCollection(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OSpace);
			}
			return null;
		}

		// Token: 0x06003912 RID: 14610 RVA: 0x000BB6A4 File Offset: 0x000B98A4
		private bool TryGetOwnerEntityType(out global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			global::System.Data.Entity.Core.Mapping.DefaultObjectMappingItemCollection defaultObjectMappingItemCollection;
			global::System.Data.Entity.Core.Mapping.MappingBase mappingBase;
			if (global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager.TryGetObjectMappingItemCollection(this.WrappedOwner, out defaultObjectMappingItemCollection) && defaultObjectMappingItemCollection.TryGetMap(this.WrappedOwner.IdentityType.FullNameWithNesting(), global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OSpace, out mappingBase))
			{
				global::System.Data.Entity.Core.Mapping.ObjectTypeMapping objectTypeMapping = (global::System.Data.Entity.Core.Mapping.ObjectTypeMapping)mappingBase;
				if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEntityType(objectTypeMapping.EdmType))
				{
					entityType = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)objectTypeMapping.EdmType;
					return true;
				}
			}
			entityType = null;
			return false;
		}

		// Token: 0x06003913 RID: 14611 RVA: 0x000BB702 File Offset: 0x000B9902
		private static bool TryGetObjectMappingItemCollection(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedOwner, out global::System.Data.Entity.Core.Mapping.DefaultObjectMappingItemCollection collection)
		{
			if (wrappedOwner.Context != null && wrappedOwner.Context.MetadataWorkspace != null)
			{
				collection = (global::System.Data.Entity.Core.Mapping.DefaultObjectMappingItemCollection)wrappedOwner.Context.MetadataWorkspace.GetItemCollection(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OCSpace);
				return collection != null;
			}
			collection = null;
			return false;
		}

		// Token: 0x06003914 RID: 14612 RVA: 0x000BB73C File Offset: 0x000B993C
		internal global::System.Data.Entity.Core.Metadata.Edm.AssociationType GetRelationshipType(global::System.Data.Entity.Core.Metadata.Edm.AssociationType csAssociationType)
		{
			global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace metadataWorkspace = this.WrappedOwner.Context.MetadataWorkspace;
			if (metadataWorkspace != null)
			{
				return metadataWorkspace.MetadataOptimization.GetOSpaceAssociationType(csAssociationType, () => this.GetRelationshipType(csAssociationType.FullName));
			}
			return this.GetRelationshipType(csAssociationType.FullName);
		}

		// Token: 0x06003915 RID: 14613 RVA: 0x000BB7A0 File Offset: 0x000B99A0
		internal global::System.Data.Entity.Core.Metadata.Edm.AssociationType GetRelationshipType(string relationshipName)
		{
			global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType = null;
			global::System.Data.Entity.Core.Metadata.Edm.ObjectItemCollection objectItemCollection = global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager.GetObjectItemCollection(this.WrappedOwner);
			if (objectItemCollection != null)
			{
				associationType = objectItemCollection.GetRelationshipType(relationshipName);
			}
			if (associationType == null)
			{
				global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.TryGetAssociationTypeFromProxyInfo(this.WrappedOwner, relationshipName, out associationType);
			}
			if (associationType == null && this._relationships != null)
			{
				associationType = (from e in this._relationships
				where e.RelationshipName == relationshipName
				select e.RelationMetadata).OfType<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>().FirstOrDefault<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>();
			}
			if (associationType == null)
			{
				associationType = this._expensiveLoader.GetRelationshipTypeExpensiveWay(this.WrappedOwner.IdentityType, relationshipName);
			}
			if (associationType == null)
			{
				throw global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager.UnableToGetMetadata(this.WrappedOwner, relationshipName);
			}
			return associationType;
		}

		// Token: 0x06003916 RID: 14614 RVA: 0x000BB878 File Offset: 0x000B9A78
		internal static global::System.Exception UnableToGetMetadata(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedOwner, string relationshipName)
		{
			global::System.ArgumentException ex = new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.RelationshipManager_UnableToFindRelationshipTypeInMetadata(relationshipName), "relationshipName");
			if (global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.IsProxyType(wrappedOwner.Entity.GetType()))
			{
				return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityProxyTypeInfo_ProxyMetadataIsUnavailable(wrappedOwner.IdentityType.FullName), ex);
			}
			return ex;
		}

		// Token: 0x06003917 RID: 14615 RVA: 0x000BB8C0 File Offset: 0x000B9AC0
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember> GetAllTargetEnds(global::System.Data.Entity.Core.Metadata.Edm.EntityType ownerEntityType, global::System.Data.Entity.Core.Metadata.Edm.EntitySet ownerEntitySet)
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationSet assocSet in ownerEntitySet.AssociationSets)
			{
				if (assocSet.ElementType.AssociationEndMembers[1].GetEntityType().IsAssignableFrom(ownerEntityType))
				{
					yield return assocSet.ElementType.AssociationEndMembers[0];
				}
				if (assocSet.ElementType.AssociationEndMembers[0].GetEntityType().IsAssignableFrom(ownerEntityType))
				{
					yield return assocSet.ElementType.AssociationEndMembers[1];
				}
				assocSet = null;
			}
			global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x06003918 RID: 14616 RVA: 0x000BB8D7 File Offset: 0x000B9AD7
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember> GetAllTargetEnds(global::System.Type entityClrType)
		{
			global::System.Data.Entity.Core.Metadata.Edm.ObjectItemCollection objectItemCollection = global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager.GetObjectItemCollection(this.WrappedOwner);
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.AssociationType> enumerable;
			if (objectItemCollection != null)
			{
				enumerable = objectItemCollection.GetItems<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>();
			}
			else
			{
				enumerable = global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.TryGetAllAssociationTypesFromProxyInfo(this.WrappedOwner);
				if (enumerable == null)
				{
					enumerable = this._expensiveLoader.GetAllRelationshipTypesExpensiveWay(entityClrType.Assembly());
				}
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationType association in enumerable)
			{
				global::System.Data.Entity.Core.Metadata.Edm.RefType refType = association.AssociationEndMembers[0].TypeUsage.EdmType as global::System.Data.Entity.Core.Metadata.Edm.RefType;
				if (refType != null && refType.ElementType.ClrType.IsAssignableFrom(entityClrType))
				{
					yield return association.AssociationEndMembers[1];
				}
				refType = (association.AssociationEndMembers[1].TypeUsage.EdmType as global::System.Data.Entity.Core.Metadata.Edm.RefType);
				if (refType != null && refType.ElementType.ClrType.IsAssignableFrom(entityClrType))
				{
					yield return association.AssociationEndMembers[0];
				}
				association = null;
			}
			global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Metadata.Edm.AssociationType> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x06003919 RID: 14617 RVA: 0x000BB8F0 File Offset: 0x000B9AF0
		private bool VerifyRelationship(global::System.Data.Entity.Core.Metadata.Edm.AssociationType relationship, string sourceEndName)
		{
			global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedOwner = this.WrappedOwner;
			if (wrappedOwner.Context == null)
			{
				return true;
			}
			global::System.Data.Entity.Core.EntityKey entityKey = wrappedOwner.EntityKey;
			return entityKey == null || global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager.VerifyRelationship(wrappedOwner, entityKey, relationship, sourceEndName);
		}

		// Token: 0x0600391A RID: 14618 RVA: 0x000BB92C File Offset: 0x000B9B2C
		private bool VerifyRelationship(global::System.Data.Entity.Core.Metadata.Edm.AssociationType osAssociationType, global::System.Data.Entity.Core.Metadata.Edm.AssociationType csAssociationType, string sourceEndName)
		{
			global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedOwner = this.WrappedOwner;
			if (wrappedOwner.Context == null)
			{
				return true;
			}
			global::System.Data.Entity.Core.EntityKey entityKey = wrappedOwner.EntityKey;
			if (entityKey == null)
			{
				return true;
			}
			if (osAssociationType.Index < 0)
			{
				return global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager.VerifyRelationship(wrappedOwner, entityKey, osAssociationType, sourceEndName);
			}
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet;
			if (wrappedOwner.Context.MetadataWorkspace.MetadataOptimization.FindCSpaceAssociationSet(csAssociationType, sourceEndName, entityKey.EntitySetName, entityKey.EntityContainerName, out entitySet) == null)
			{
				throw global::System.Data.Entity.Resources.Error.Collections_NoRelationshipSetMatched(osAssociationType.FullName);
			}
			return true;
		}

		// Token: 0x0600391B RID: 14619 RVA: 0x000BB9A8 File Offset: 0x000B9BA8
		private static bool VerifyRelationship(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedOwner, global::System.Data.Entity.Core.EntityKey ownerKey, global::System.Data.Entity.Core.Metadata.Edm.AssociationType relationship, string sourceEndName)
		{
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage;
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet;
			if (wrappedOwner.Context.Perspective.TryGetTypeByName(relationship.FullName, false, out typeUsage) && wrappedOwner.Context.MetadataWorkspace.MetadataOptimization.FindCSpaceAssociationSet((global::System.Data.Entity.Core.Metadata.Edm.AssociationType)typeUsage.EdmType, sourceEndName, ownerKey.EntitySetName, ownerKey.EntityContainerName, out entitySet) == null)
			{
				throw global::System.Data.Entity.Resources.Error.Collections_NoRelationshipSetMatched(relationship.FullName);
			}
			return true;
		}

		// Token: 0x0600391C RID: 14620 RVA: 0x000BBA0E File Offset: 0x000B9C0E
		public global::System.Data.Entity.Core.Objects.DataClasses.EntityCollection<TTargetEntity> GetRelatedCollection<TTargetEntity>(string relationshipName, string targetRoleName) where TTargetEntity : class
		{
			global::System.Data.Entity.Core.Objects.DataClasses.EntityCollection<TTargetEntity> entityCollection = this.GetRelatedEndInternal(this.PrependNamespaceToRelationshipName(relationshipName), targetRoleName) as global::System.Data.Entity.Core.Objects.DataClasses.EntityCollection<TTargetEntity>;
			if (entityCollection == null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.Collections_ExpectedCollectionGotReference(typeof(TTargetEntity).Name, targetRoleName, relationshipName));
			}
			return entityCollection;
		}

		// Token: 0x0600391D RID: 14621 RVA: 0x000BBA42 File Offset: 0x000B9C42
		public global::System.Data.Entity.Core.Objects.DataClasses.EntityReference<TTargetEntity> GetRelatedReference<TTargetEntity>(string relationshipName, string targetRoleName) where TTargetEntity : class
		{
			global::System.Data.Entity.Core.Objects.DataClasses.EntityReference<TTargetEntity> entityReference = this.GetRelatedEndInternal(this.PrependNamespaceToRelationshipName(relationshipName), targetRoleName) as global::System.Data.Entity.Core.Objects.DataClasses.EntityReference<TTargetEntity>;
			if (entityReference == null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityReference_ExpectedReferenceGotCollection(typeof(TTargetEntity).Name, targetRoleName, relationshipName));
			}
			return entityReference;
		}

		// Token: 0x0600391E RID: 14622 RVA: 0x000BBA78 File Offset: 0x000B9C78
		internal global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd GetRelatedEnd(global::System.Data.Entity.Core.Objects.DataClasses.RelationshipNavigation navigation, global::System.Data.Entity.Core.Objects.DataClasses.IRelationshipFixer relationshipFixer)
		{
			global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd result;
			if (this.TryGetCachedRelatedEnd(navigation.RelationshipName, navigation.To, out result))
			{
				return result;
			}
			result = relationshipFixer.CreateSourceEnd(navigation, this);
			return result;
		}

		// Token: 0x0600391F RID: 14623 RVA: 0x000BBAA8 File Offset: 0x000B9CA8
		internal global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd CreateRelatedEnd<TSourceEntity, TTargetEntity>(global::System.Data.Entity.Core.Objects.DataClasses.RelationshipNavigation navigation, global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity sourceRoleMultiplicity, global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity targetRoleMultiplicity, global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd existingRelatedEnd) where TSourceEntity : class where TTargetEntity : class
		{
			global::System.Data.Entity.Core.Objects.DataClasses.IRelationshipFixer relationshipFixer = new global::System.Data.Entity.Core.Objects.DataClasses.RelationshipFixer<TSourceEntity, TTargetEntity>(sourceRoleMultiplicity, targetRoleMultiplicity);
			global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedOwner = this.WrappedOwner;
			global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd;
			if (targetRoleMultiplicity > global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One)
			{
				if (targetRoleMultiplicity != global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many)
				{
					global::System.Type typeFromHandle = typeof(global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity);
					string name = typeFromHandle.Name;
					object name2 = typeFromHandle.Name;
					int num = (int)targetRoleMultiplicity;
					throw new global::System.ArgumentOutOfRangeException(name, global::System.Data.Entity.Resources.Strings.ADP_InvalidEnumerationValue(name2, num.ToString(global::System.Globalization.CultureInfo.InvariantCulture)));
				}
				if (existingRelatedEnd != null)
				{
					existingRelatedEnd.InitializeRelatedEnd(wrappedOwner, navigation, relationshipFixer);
					relatedEnd = existingRelatedEnd;
				}
				else
				{
					relatedEnd = new global::System.Data.Entity.Core.Objects.DataClasses.EntityCollection<TTargetEntity>(wrappedOwner, navigation, relationshipFixer);
				}
			}
			else if (existingRelatedEnd != null)
			{
				existingRelatedEnd.InitializeRelatedEnd(wrappedOwner, navigation, relationshipFixer);
				relatedEnd = existingRelatedEnd;
			}
			else
			{
				relatedEnd = new global::System.Data.Entity.Core.Objects.DataClasses.EntityReference<TTargetEntity>(wrappedOwner, navigation, relationshipFixer);
			}
			if (wrappedOwner.Context != null)
			{
				relatedEnd.AttachContext(wrappedOwner.Context, wrappedOwner.MergeOption);
			}
			this.EnsureRelationshipsInitialized();
			this._relationships.Add(relatedEnd);
			return relatedEnd;
		}

		// Token: 0x06003920 RID: 14624 RVA: 0x000BBB6A File Offset: 0x000B9D6A
		public global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Objects.DataClasses.IRelatedEnd> GetAllRelatedEnds()
		{
			global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedOwner = this.WrappedOwner;
			global::System.Data.Entity.Core.Metadata.Edm.EntityType ownerEntityType;
			if (wrappedOwner.Context != null && wrappedOwner.Context.MetadataWorkspace != null && this.TryGetOwnerEntityType(out ownerEntityType))
			{
				global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = wrappedOwner.Context.GetEntitySet(wrappedOwner.EntityKey.EntitySetName, wrappedOwner.EntityKey.EntityContainerName);
				foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember in global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager.GetAllTargetEnds(ownerEntityType, entitySet))
				{
					yield return this.GetRelatedEnd(associationEndMember.DeclaringType.FullName, associationEndMember.Name);
				}
				global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember> enumerator = null;
			}
			else if (wrappedOwner.Entity != null)
			{
				foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember2 in this.GetAllTargetEnds(wrappedOwner.IdentityType))
				{
					yield return this.GetRelatedEnd(associationEndMember2.DeclaringType.FullName, associationEndMember2.Name);
				}
				global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember> enumerator = null;
			}
			yield break;
			yield break;
		}

		// Token: 0x06003921 RID: 14625 RVA: 0x000BBB7C File Offset: 0x000B9D7C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.Runtime.Serialization.OnSerializing]
		public void OnSerializing(global::System.Runtime.Serialization.StreamingContext context)
		{
			global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedOwner = this.WrappedOwner;
			if (!(wrappedOwner.Entity is global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithRelationships))
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.RelatedEnd_CannotSerialize("RelationshipManager"));
			}
			if (wrappedOwner.Context != null && wrappedOwner.MergeOption != global::System.Data.Entity.Core.Objects.MergeOption.NoTracking)
			{
				foreach (global::System.Data.Entity.Core.Objects.DataClasses.IRelatedEnd relatedEnd in this.GetAllRelatedEnds())
				{
					global::System.Data.Entity.Core.Objects.DataClasses.EntityReference entityReference = ((global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd)relatedEnd) as global::System.Data.Entity.Core.Objects.DataClasses.EntityReference;
					if (entityReference != null && entityReference.EntityKey != null)
					{
						entityReference.DetachedEntityKey = entityReference.EntityKey;
					}
				}
			}
		}

		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x06003922 RID: 14626 RVA: 0x000BBC20 File Offset: 0x000B9E20
		internal bool HasRelationships
		{
			get
			{
				return this._relationships != null;
			}
		}

		// Token: 0x06003923 RID: 14627 RVA: 0x000BBC2C File Offset: 0x000B9E2C
		internal void AddRelatedEntitiesToObjectStateManager(bool doAttach)
		{
			if (this._relationships != null)
			{
				bool flag = true;
				try
				{
					foreach (global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd in this.Relationships)
					{
						relatedEnd.Include(false, doAttach);
					}
					flag = false;
				}
				finally
				{
					if (flag)
					{
						global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedOwner = this.WrappedOwner;
						global::System.Data.Entity.Core.Objects.Internal.TransactionManager transactionManager = wrappedOwner.Context.ObjectStateManager.TransactionManager;
						wrappedOwner.Context.ObjectStateManager.DegradePromotedRelationships();
						this.NodeVisited = true;
						global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager.RemoveRelatedEntitiesFromObjectStateManager(wrappedOwner);
						global::System.Data.Entity.Core.Objects.EntityEntry entityEntry;
						if (transactionManager.IsAttachTracking && transactionManager.PromotedKeyEntries.TryGetValue(wrappedOwner.Entity, out entityEntry))
						{
							entityEntry.DegradeEntry();
						}
						else
						{
							global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd.RemoveEntityFromObjectStateManager(wrappedOwner);
						}
					}
				}
			}
		}

		// Token: 0x06003924 RID: 14628 RVA: 0x000BBCFC File Offset: 0x000B9EFC
		internal static void RemoveRelatedEntitiesFromObjectStateManager(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity)
		{
			foreach (global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd in wrappedEntity.RelationshipManager.Relationships)
			{
				if (relatedEnd.ObjectContext != null)
				{
					relatedEnd.Exclude();
					relatedEnd.DetachContext();
				}
			}
		}

		// Token: 0x06003925 RID: 14629 RVA: 0x000BBD5C File Offset: 0x000B9F5C
		internal void RemoveEntityFromRelationships()
		{
			if (this._relationships != null)
			{
				foreach (global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd in this.Relationships)
				{
					relatedEnd.RemoveAll();
				}
			}
		}

		// Token: 0x06003926 RID: 14630 RVA: 0x000BBDB0 File Offset: 0x000B9FB0
		internal void NullAllFKsInDependentsForWhichThisIsThePrincipal()
		{
			if (this._relationships != null)
			{
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.DataClasses.EntityReference> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.DataClasses.EntityReference>();
				foreach (global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd in this.Relationships)
				{
					if (relatedEnd.IsForeignKey)
					{
						foreach (global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity in relatedEnd.GetWrappedEntities())
						{
							global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd otherEndOfRelationship = relatedEnd.GetOtherEndOfRelationship(wrappedEntity);
							if (otherEndOfRelationship.IsDependentEndOfReferentialConstraint(false))
							{
								list.Add((global::System.Data.Entity.Core.Objects.DataClasses.EntityReference)otherEndOfRelationship);
							}
						}
					}
				}
				foreach (global::System.Data.Entity.Core.Objects.DataClasses.EntityReference entityReference in list)
				{
					entityReference.NullAllForeignKeys();
				}
			}
		}

		// Token: 0x06003927 RID: 14631 RVA: 0x000BBEA4 File Offset: 0x000BA0A4
		internal void DetachEntityFromRelationships(global::System.Data.Entity.EntityState ownerEntityState)
		{
			if (this._relationships != null)
			{
				foreach (global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd in this.Relationships)
				{
					relatedEnd.DetachAll(ownerEntityState);
				}
			}
		}

		// Token: 0x06003928 RID: 14632 RVA: 0x000BBEF8 File Offset: 0x000BA0F8
		internal void RemoveEntity(string toRole, string relationshipName, global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity)
		{
			global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd;
			if (this.TryGetCachedRelatedEnd(relationshipName, toRole, out relatedEnd))
			{
				relatedEnd.Remove(wrappedEntity, false);
			}
		}

		// Token: 0x06003929 RID: 14633 RVA: 0x000BBF1C File Offset: 0x000BA11C
		internal void ClearRelatedEndWrappers()
		{
			if (this._relationships != null)
			{
				foreach (global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd in this.Relationships)
				{
					((global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd)relatedEnd).ClearWrappedValues();
				}
			}
		}

		// Token: 0x0600392A RID: 14634 RVA: 0x000BBF74 File Offset: 0x000BA174
		internal void RetrieveReferentialConstraintProperties(out global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.KeyValuePair<object, global::System.Data.Entity.Core.Objects.IntBox>> properties, global::System.Collections.Generic.HashSet<object> visited, bool includeOwnValues)
		{
			global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedOwner = this.WrappedOwner;
			properties = new global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.KeyValuePair<object, global::System.Data.Entity.Core.Objects.IntBox>>();
			global::System.Data.Entity.Core.EntityKey entityKey = wrappedOwner.EntityKey;
			if (entityKey.IsTemporary)
			{
				global::System.Collections.Generic.List<string> list;
				bool flag;
				this.FindNamesOfReferentialConstraintProperties(out list, out flag, false);
				if (list != null)
				{
					if (this._relationships != null)
					{
						foreach (global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd in this._relationships)
						{
							relatedEnd.RetrieveReferentialConstraintProperties(properties, visited);
						}
					}
					if (!global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager.CheckIfAllPropertiesWereRetrieved(properties, list))
					{
						wrappedOwner.Context.ObjectStateManager.FindEntityEntry(entityKey).RetrieveReferentialConstraintPropertiesFromKeyEntries(properties);
						if (!global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager.CheckIfAllPropertiesWereRetrieved(properties, list))
						{
							throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.RelationshipManager_UnableToRetrieveReferentialConstraintProperties);
						}
					}
				}
			}
			if (!entityKey.IsTemporary || includeOwnValues)
			{
				wrappedOwner.Context.ObjectStateManager.FindEntityEntry(entityKey).GetOtherKeyProperties(properties);
			}
		}

		// Token: 0x0600392B RID: 14635 RVA: 0x000BC05C File Offset: 0x000BA25C
		private static bool CheckIfAllPropertiesWereRetrieved(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.KeyValuePair<object, global::System.Data.Entity.Core.Objects.IntBox>> properties, global::System.Collections.Generic.List<string> propertiesToRetrieve)
		{
			bool flag = true;
			global::System.Collections.Generic.List<int> list = new global::System.Collections.Generic.List<int>();
			global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<object, global::System.Data.Entity.Core.Objects.IntBox>> values = properties.Values;
			foreach (global::System.Collections.Generic.KeyValuePair<object, global::System.Data.Entity.Core.Objects.IntBox> keyValuePair in values)
			{
				list.Add(keyValuePair.Value.Value);
			}
			foreach (string key in propertiesToRetrieve)
			{
				if (!properties.ContainsKey(key))
				{
					flag = false;
					break;
				}
				global::System.Collections.Generic.KeyValuePair<object, global::System.Data.Entity.Core.Objects.IntBox> keyValuePair2 = properties[key];
				keyValuePair2.Value.Value = keyValuePair2.Value.Value - 1;
				if (keyValuePair2.Value.Value < 0)
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<object, global::System.Data.Entity.Core.Objects.IntBox> keyValuePair3 in values)
				{
					if (keyValuePair3.Value.Value != 0)
					{
						flag = false;
						break;
					}
				}
			}
			if (!flag)
			{
				global::System.Collections.Generic.IEnumerator<int> enumerator3 = list.GetEnumerator();
				foreach (global::System.Collections.Generic.KeyValuePair<object, global::System.Data.Entity.Core.Objects.IntBox> keyValuePair4 in values)
				{
					enumerator3.MoveNext();
					keyValuePair4.Value.Value = enumerator3.Current;
				}
			}
			return flag;
		}

		// Token: 0x0600392C RID: 14636 RVA: 0x000BC1E0 File Offset: 0x000BA3E0
		internal void CheckReferentialConstraintProperties(global::System.Data.Entity.Core.Objects.EntityEntry ownerEntry)
		{
			if (this.HasReferentialConstraintPropertiesToCheck() && this._relationships != null)
			{
				foreach (global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd in this._relationships)
				{
					relatedEnd.CheckReferentialConstraintProperties(ownerEntry);
				}
			}
		}

		// Token: 0x0600392D RID: 14637 RVA: 0x000BC244 File Offset: 0x000BA444
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.Runtime.Serialization.OnDeserialized]
		public void OnDeserialized(global::System.Runtime.Serialization.StreamingContext context)
		{
			this._entityWrapperFactory = new global::System.Data.Entity.Core.Objects.Internal.EntityWrapperFactory();
			this._expensiveLoader = new global::System.Data.Entity.Core.Metadata.Edm.ExpensiveOSpaceLoader();
			this._wrappedOwner = this.EntityWrapperFactory.WrapEntityUsingContext(this._owner, null);
		}

		// Token: 0x0600392E RID: 14638 RVA: 0x000BC274 File Offset: 0x000BA474
		private bool TryGetCachedRelatedEnd(string relationshipName, string targetRoleName, out global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd)
		{
			relatedEnd = null;
			if (this._relationships != null)
			{
				foreach (global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd2 in this._relationships)
				{
					global::System.Data.Entity.Core.Objects.DataClasses.RelationshipNavigation relationshipNavigation = relatedEnd2.RelationshipNavigation;
					if (relationshipNavigation.RelationshipName == relationshipName && relationshipNavigation.To == targetRoleName)
					{
						relatedEnd = relatedEnd2;
						return true;
					}
				}
				return false;
			}
			return false;
		}

		// Token: 0x0600392F RID: 14639 RVA: 0x000BC2F8 File Offset: 0x000BA4F8
		internal bool FindNamesOfReferentialConstraintProperties(out global::System.Collections.Generic.List<string> propertiesToRetrieve, out bool propertiesToPropagateExist, bool skipFK)
		{
			global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedOwner = this.WrappedOwner;
			global::System.Data.Entity.Core.EntityKey entityKey = wrappedOwner.EntityKey;
			if (entityKey == null)
			{
				throw global::System.Data.Entity.Resources.Error.EntityKey_UnexpectedNull();
			}
			propertiesToRetrieve = null;
			propertiesToPropagateExist = false;
			if (wrappedOwner.Context == null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.RelationshipManager_UnexpectedNullContext);
			}
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = entityKey.GetEntitySet(wrappedOwner.Context.MetadataWorkspace);
			global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet> associationSets = entitySet.AssociationSets;
			bool result = false;
			foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet in associationSets)
			{
				if (skipFK && associationSet.ElementType.IsForeignKey)
				{
					result = true;
				}
				else
				{
					foreach (global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint referentialConstraint in associationSet.ElementType.ReferentialConstraints)
					{
						if (referentialConstraint.ToRole.TypeUsage.EdmType == entitySet.ElementType.GetReferenceType())
						{
							propertiesToRetrieve = (propertiesToRetrieve ?? new global::System.Collections.Generic.List<string>());
							foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty in referentialConstraint.ToProperties)
							{
								propertiesToRetrieve.Add(edmProperty.Name);
							}
						}
						if (referentialConstraint.FromRole.TypeUsage.EdmType == entitySet.ElementType.GetReferenceType())
						{
							propertiesToPropagateExist = true;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06003930 RID: 14640 RVA: 0x000BC484 File Offset: 0x000BA684
		internal bool HasReferentialConstraintPropertiesToCheck()
		{
			global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedOwner = this.WrappedOwner;
			global::System.Data.Entity.Core.EntityKey entityKey = wrappedOwner.EntityKey;
			if (entityKey == null)
			{
				throw global::System.Data.Entity.Resources.Error.EntityKey_UnexpectedNull();
			}
			if (wrappedOwner.Context == null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.RelationshipManager_UnexpectedNullContext);
			}
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = entityKey.GetEntitySet(wrappedOwner.Context.MetadataWorkspace);
			foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet in entitySet.AssociationSets)
			{
				foreach (global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint referentialConstraint in associationSet.ElementType.ReferentialConstraints)
				{
					if (referentialConstraint.ToRole.TypeUsage.EdmType == entitySet.ElementType.GetReferenceType())
					{
						return true;
					}
					if (referentialConstraint.FromRole.TypeUsage.EdmType == entitySet.ElementType.GetReferenceType())
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06003931 RID: 14641 RVA: 0x000BC594 File Offset: 0x000BA794
		internal bool IsOwner(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity)
		{
			global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedOwner = this.WrappedOwner;
			return wrappedEntity.Entity == wrappedOwner.Entity;
		}

		// Token: 0x06003932 RID: 14642 RVA: 0x000BC5B8 File Offset: 0x000BA7B8
		internal void AttachContextToRelatedEnds(global::System.Data.Entity.Core.Objects.ObjectContext context, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Data.Entity.Core.Objects.MergeOption mergeOption)
		{
			if (this._relationships != null)
			{
				foreach (global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd in this.Relationships)
				{
					global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType;
					global::System.Data.Entity.Core.Metadata.Edm.RelationshipSet relationshipSet;
					relatedEnd.FindRelationshipSet(context, entitySet, out edmType, out relationshipSet);
					if (relationshipSet != null || !relatedEnd.IsEmpty())
					{
						relatedEnd.AttachContext(context, entitySet, mergeOption);
					}
					else
					{
						this._relationships.Remove(relatedEnd);
					}
				}
			}
		}

		// Token: 0x06003933 RID: 14643 RVA: 0x000BC638 File Offset: 0x000BA838
		internal void ResetContextOnRelatedEnds(global::System.Data.Entity.Core.Objects.ObjectContext context, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Data.Entity.Core.Objects.MergeOption mergeOption)
		{
			if (this._relationships != null)
			{
				foreach (global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd in this.Relationships)
				{
					relatedEnd.AttachContext(context, entitySet, mergeOption);
					foreach (global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper entityWrapper in relatedEnd.GetWrappedEntities())
					{
						entityWrapper.ResetContext(context, relatedEnd.GetTargetEntitySetFromRelationshipSet(), mergeOption);
					}
				}
			}
		}

		// Token: 0x06003934 RID: 14644 RVA: 0x000BC6D0 File Offset: 0x000BA8D0
		internal void DetachContextFromRelatedEnds()
		{
			if (this._relationships != null)
			{
				foreach (global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd in this._relationships)
				{
					relatedEnd.DetachContext();
				}
			}
		}

		// Token: 0x06003935 RID: 14645 RVA: 0x000BC728 File Offset: 0x000BA928
		[global::System.Diagnostics.Conditional("DEBUG")]
		internal void VerifyIsNotRelated()
		{
			if (this._relationships != null)
			{
				foreach (global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd in this._relationships)
				{
					relatedEnd.IsEmpty();
				}
			}
		}

		// Token: 0x04001304 RID: 4868
		private global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithRelationships _owner;

		// Token: 0x04001305 RID: 4869
		private global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd> _relationships;

		// Token: 0x04001306 RID: 4870
		[global::System.NonSerialized]
		private bool _nodeVisited;

		// Token: 0x04001307 RID: 4871
		[global::System.NonSerialized]
		private global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper _wrappedOwner;

		// Token: 0x04001308 RID: 4872
		[global::System.NonSerialized]
		private global::System.Data.Entity.Core.Objects.Internal.EntityWrapperFactory _entityWrapperFactory;

		// Token: 0x04001309 RID: 4873
		[global::System.NonSerialized]
		private global::System.Data.Entity.Core.Metadata.Edm.ExpensiveOSpaceLoader _expensiveLoader;
	}
}
