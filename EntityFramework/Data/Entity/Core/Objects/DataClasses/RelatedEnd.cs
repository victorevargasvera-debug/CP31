using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects.Internal;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace System.Data.Entity.Core.Objects.DataClasses
{
	// Token: 0x02000480 RID: 1152
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public abstract class RelatedEnd : global::System.Data.Entity.Core.Objects.DataClasses.IRelatedEnd
	{
		// Token: 0x06003871 RID: 14449 RVA: 0x000B83B1 File Offset: 0x000B65B1
		internal RelatedEnd()
		{
			this._wrappedOwner = global::System.Data.Entity.Core.Objects.Internal.NullEntityWrapper.NullWrapper;
		}

		// Token: 0x06003872 RID: 14450 RVA: 0x000B83C4 File Offset: 0x000B65C4
		internal RelatedEnd(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedOwner, global::System.Data.Entity.Core.Objects.DataClasses.RelationshipNavigation navigation, global::System.Data.Entity.Core.Objects.DataClasses.IRelationshipFixer relationshipFixer)
		{
			this.InitializeRelatedEnd(wrappedOwner, navigation, relationshipFixer);
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06003873 RID: 14451 RVA: 0x000B83D5 File Offset: 0x000B65D5
		// (remove) Token: 0x06003874 RID: 14452 RVA: 0x000B83F4 File Offset: 0x000B65F4
		public event global::System.ComponentModel.CollectionChangeEventHandler AssociationChanged
		{
			add
			{
				this.CheckOwnerNull();
				this._onAssociationChanged = (global::System.ComponentModel.CollectionChangeEventHandler)global::System.Delegate.Combine(this._onAssociationChanged, value);
			}
			remove
			{
				this.CheckOwnerNull();
				this._onAssociationChanged = (global::System.ComponentModel.CollectionChangeEventHandler)global::System.Delegate.Remove(this._onAssociationChanged, value);
			}
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06003875 RID: 14453 RVA: 0x000B8413 File Offset: 0x000B6613
		// (remove) Token: 0x06003876 RID: 14454 RVA: 0x000B8415 File Offset: 0x000B6615
		internal virtual event global::System.ComponentModel.CollectionChangeEventHandler AssociationChangedForObjectView
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x06003877 RID: 14455 RVA: 0x000B8417 File Offset: 0x000B6617
		internal bool IsForeignKey
		{
			get
			{
				return ((global::System.Data.Entity.Core.Metadata.Edm.AssociationType)this._relationMetadata).IsForeignKey;
			}
		}

		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x06003878 RID: 14456 RVA: 0x000B8429 File Offset: 0x000B6629
		internal global::System.Data.Entity.Core.Objects.DataClasses.RelationshipNavigation RelationshipNavigation
		{
			get
			{
				return this._navigation;
			}
		}

		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x06003879 RID: 14457 RVA: 0x000B8431 File Offset: 0x000B6631
		[global::System.Xml.Serialization.SoapIgnore]
		[global::System.Xml.Serialization.XmlIgnore]
		public string RelationshipName
		{
			get
			{
				this.CheckOwnerNull();
				return this._navigation.RelationshipName;
			}
		}

		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x0600387A RID: 14458 RVA: 0x000B8444 File Offset: 0x000B6644
		[global::System.Xml.Serialization.SoapIgnore]
		[global::System.Xml.Serialization.XmlIgnore]
		public virtual string SourceRoleName
		{
			get
			{
				this.CheckOwnerNull();
				return this._navigation.From;
			}
		}

		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x0600387B RID: 14459 RVA: 0x000B8457 File Offset: 0x000B6657
		[global::System.Xml.Serialization.SoapIgnore]
		[global::System.Xml.Serialization.XmlIgnore]
		public virtual string TargetRoleName
		{
			get
			{
				this.CheckOwnerNull();
				return this._navigation.To;
			}
		}

		// Token: 0x0600387C RID: 14460 RVA: 0x000B846A File Offset: 0x000B666A
		global::System.Collections.IEnumerable global::System.Data.Entity.Core.Objects.DataClasses.IRelatedEnd.CreateSourceQuery()
		{
			this.CheckOwnerNull();
			return this.CreateSourceQueryInternal();
		}

		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x0600387D RID: 14461 RVA: 0x000B8478 File Offset: 0x000B6678
		internal virtual global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper WrappedOwner
		{
			get
			{
				return this._wrappedOwner;
			}
		}

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x0600387E RID: 14462 RVA: 0x000B8480 File Offset: 0x000B6680
		internal virtual global::System.Data.Entity.Core.Objects.ObjectContext ObjectContext
		{
			get
			{
				return this._context;
			}
		}

		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x0600387F RID: 14463 RVA: 0x000B8488 File Offset: 0x000B6688
		internal virtual global::System.Data.Entity.Core.Objects.Internal.EntityWrapperFactory EntityWrapperFactory
		{
			get
			{
				if (this._entityWrapperFactory == null)
				{
					this._entityWrapperFactory = new global::System.Data.Entity.Core.Objects.Internal.EntityWrapperFactory();
				}
				return this._entityWrapperFactory;
			}
		}

		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x06003880 RID: 14464 RVA: 0x000B84A3 File Offset: 0x000B66A3
		[global::System.Xml.Serialization.SoapIgnore]
		[global::System.Xml.Serialization.XmlIgnore]
		public virtual global::System.Data.Entity.Core.Metadata.Edm.RelationshipSet RelationshipSet
		{
			get
			{
				this.CheckOwnerNull();
				return this._relationshipSet;
			}
		}

		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x06003881 RID: 14465 RVA: 0x000B84B1 File Offset: 0x000B66B1
		internal virtual global::System.Data.Entity.Core.Metadata.Edm.RelationshipType RelationMetadata
		{
			get
			{
				return this._relationMetadata;
			}
		}

		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x06003882 RID: 14466 RVA: 0x000B84B9 File Offset: 0x000B66B9
		internal virtual global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember ToEndMember
		{
			get
			{
				return this._toEndMember;
			}
		}

		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x06003883 RID: 14467 RVA: 0x000B84C1 File Offset: 0x000B66C1
		internal bool UsingNoTracking
		{
			get
			{
				return this._usingNoTracking;
			}
		}

		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x06003884 RID: 14468 RVA: 0x000B84C9 File Offset: 0x000B66C9
		internal global::System.Data.Entity.Core.Objects.MergeOption DefaultMergeOption
		{
			get
			{
				if (!this.UsingNoTracking)
				{
					return global::System.Data.Entity.Core.Objects.MergeOption.AppendOnly;
				}
				return global::System.Data.Entity.Core.Objects.MergeOption.NoTracking;
			}
		}

		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x06003885 RID: 14469 RVA: 0x000B84D6 File Offset: 0x000B66D6
		internal virtual global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember FromEndMember
		{
			get
			{
				return this._fromEndMember;
			}
		}

		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x06003886 RID: 14470 RVA: 0x000B84DE File Offset: 0x000B66DE
		// (set) Token: 0x06003887 RID: 14471 RVA: 0x000B84EC File Offset: 0x000B66EC
		[global::System.Xml.Serialization.SoapIgnore]
		[global::System.Xml.Serialization.XmlIgnore]
		public bool IsLoaded
		{
			get
			{
				this.CheckOwnerNull();
				return this._isLoaded;
			}
			set
			{
				this.CheckOwnerNull();
				this._isLoaded = value;
			}
		}

		// Token: 0x06003888 RID: 14472 RVA: 0x000B84FC File Offset: 0x000B66FC
		internal global::System.Data.Entity.Core.Objects.ObjectQuery<TEntity> CreateSourceQuery<TEntity>(global::System.Data.Entity.Core.Objects.MergeOption mergeOption, out bool hasResults)
		{
			if (this._context == null)
			{
				hasResults = false;
				return null;
			}
			global::System.Data.Entity.Core.Objects.EntityEntry entityEntry = this._context.ObjectStateManager.FindEntityEntry(this._wrappedOwner.Entity);
			global::System.Data.Entity.EntityState entityState;
			if (entityEntry == null)
			{
				if (!this.UsingNoTracking)
				{
					throw global::System.Data.Entity.Resources.Error.Collections_InvalidEntityStateSource();
				}
				entityState = global::System.Data.Entity.EntityState.Detached;
			}
			else
			{
				entityState = entityEntry.State;
			}
			if (entityState == global::System.Data.Entity.EntityState.Added && (!this.IsForeignKey || !this.IsDependentEndOfReferentialConstraint(false)))
			{
				throw global::System.Data.Entity.Resources.Error.Collections_InvalidEntityStateSource();
			}
			if ((entityState != global::System.Data.Entity.EntityState.Detached || !this.UsingNoTracking) && entityState != global::System.Data.Entity.EntityState.Modified && entityState != global::System.Data.Entity.EntityState.Unchanged && entityState != global::System.Data.Entity.EntityState.Deleted && entityState != global::System.Data.Entity.EntityState.Added)
			{
				hasResults = false;
				return null;
			}
			if (this._sourceQuery == null)
			{
				this._sourceQuery = this.GenerateQueryText();
			}
			global::System.Data.Entity.Core.Objects.ObjectQuery<TEntity> objectQuery = new global::System.Data.Entity.Core.Objects.ObjectQuery<TEntity>(this._sourceQuery, this._context, mergeOption);
			hasResults = this.AddQueryParameters<TEntity>(objectQuery);
			objectQuery.Parameters.SetReadOnly(true);
			return objectQuery;
		}

		// Token: 0x06003889 RID: 14473 RVA: 0x000B85C8 File Offset: 0x000B67C8
		private string GenerateQueryText()
		{
			global::System.Data.Entity.Core.EntityKey entityKey = this._wrappedOwner.EntityKey;
			if (entityKey == null)
			{
				throw global::System.Data.Entity.Resources.Error.EntityKey_UnexpectedNull();
			}
			global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType = (global::System.Data.Entity.Core.Metadata.Edm.AssociationType)this._relationMetadata;
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = ((global::System.Data.Entity.Core.Metadata.Edm.AssociationSet)this._relationshipSet).AssociationSetEnds[this._toEndMember.Name].EntitySet;
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetEntityTypeForEnd((global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember)this._toEndMember);
			bool ofTypeRequired = false;
			if (!entitySet.ElementType.EdmEquals(entityType) && !global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsSubTypeOf(entitySet.ElementType, entityType))
			{
				ofTypeRequired = true;
				entityType = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)this.ObjectContext.MetadataWorkspace.GetOSpaceTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(entityType)).EdmType;
			}
			global::System.Text.StringBuilder stringBuilder;
			if (associationType.IsForeignKey)
			{
				global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint referentialConstraint = associationType.ReferentialConstraints[0];
				global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> fromProperties = referentialConstraint.FromProperties;
				global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> toProperties = referentialConstraint.ToProperties;
				if (!referentialConstraint.ToRole.EdmEquals(this._toEndMember))
				{
					stringBuilder = new global::System.Text.StringBuilder("SELECT VALUE P FROM ");
					global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd.AppendEntitySet(stringBuilder, entitySet, entityType, ofTypeRequired);
					stringBuilder.Append(" AS P WHERE ");
					global::System.Data.Entity.Core.Common.Utils.AliasGenerator aliasGenerator = new global::System.Data.Entity.Core.Common.Utils.AliasGenerator("EntityKeyValue");
					this._sourceQueryParamProperties = toProperties;
					for (int i = 0; i < fromProperties.Count; i++)
					{
						if (i > 0)
						{
							stringBuilder.Append(" AND ");
						}
						stringBuilder.Append("P.[");
						stringBuilder.Append(fromProperties[i].Name);
						stringBuilder.Append("] = @");
						stringBuilder.Append(aliasGenerator.Next());
					}
					return stringBuilder.ToString();
				}
				stringBuilder = new global::System.Text.StringBuilder("SELECT VALUE D FROM ");
				global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd.AppendEntitySet(stringBuilder, entitySet, entityType, ofTypeRequired);
				stringBuilder.Append(" AS D WHERE ");
				global::System.Data.Entity.Core.Common.Utils.AliasGenerator aliasGenerator2 = new global::System.Data.Entity.Core.Common.Utils.AliasGenerator("EntityKeyValue");
				this._sourceQueryParamProperties = fromProperties;
				for (int j = 0; j < toProperties.Count; j++)
				{
					if (j > 0)
					{
						stringBuilder.Append(" AND ");
					}
					stringBuilder.Append("D.[");
					stringBuilder.Append(toProperties[j].Name);
					stringBuilder.Append("] = @");
					stringBuilder.Append(aliasGenerator2.Next());
				}
			}
			else
			{
				stringBuilder = new global::System.Text.StringBuilder("SELECT VALUE [TargetEntity] FROM (SELECT VALUE x FROM ");
				stringBuilder.Append("[");
				stringBuilder.Append(this._relationshipSet.EntityContainer.Name);
				stringBuilder.Append("].[");
				stringBuilder.Append(this._relationshipSet.Name);
				stringBuilder.Append("] AS x WHERE Key(x.[");
				stringBuilder.Append(this._fromEndMember.Name);
				stringBuilder.Append("]) = ");
				global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd.AppendKeyParameterRow(stringBuilder, entityKey.GetEntitySet(this.ObjectContext.MetadataWorkspace).ElementType.KeyMembers);
				stringBuilder.Append(") AS [AssociationEntry] INNER JOIN ");
				global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd.AppendEntitySet(stringBuilder, entitySet, entityType, ofTypeRequired);
				stringBuilder.Append(" AS [TargetEntity] ON Key([AssociationEntry].[");
				stringBuilder.Append(this._toEndMember.Name);
				stringBuilder.Append("]) = Key(Ref([TargetEntity]))");
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600388A RID: 14474 RVA: 0x000B88EC File Offset: 0x000B6AEC
		private bool AddQueryParameters<TEntity>(global::System.Data.Entity.Core.Objects.ObjectQuery<TEntity> query)
		{
			global::System.Data.Entity.Core.EntityKey entityKey = this._wrappedOwner.EntityKey;
			if (entityKey == null)
			{
				throw global::System.Data.Entity.Resources.Error.EntityKey_UnexpectedNull();
			}
			bool result = true;
			global::System.Data.Entity.Core.Common.Utils.AliasGenerator aliasGenerator = new global::System.Data.Entity.Core.Common.Utils.AliasGenerator("EntityKeyValue");
			using (global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> enumerator = (this._sourceQueryParamProperties ?? entityKey.GetEntitySet(this.ObjectContext.MetadataWorkspace).ElementType.KeyMembers).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					global::System.Data.Entity.Core.Metadata.Edm.EdmMember parameterMember = enumerator.Current;
					object obj;
					if (this._sourceQueryParamProperties == null)
					{
						obj = this._wrappedOwner.EntityKey.EntityKeyValues.Single((global::System.Data.Entity.Core.EntityKeyMember ekv) => ekv.Key == parameterMember.Name).Value;
					}
					else if (this.CachedForeignKeyIsConceptualNull())
					{
						obj = null;
					}
					else
					{
						obj = this.GetCurrentValueFromEntity(parameterMember);
					}
					global::System.Data.Entity.Core.Objects.ObjectParameter objectParameter;
					if (obj == null)
					{
						global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = parameterMember.TypeUsage.EdmType;
						global::System.Type type = global::System.Data.Entity.Core.Metadata.Edm.Helper.IsPrimitiveType(edmType) ? ((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)edmType).ClrEquivalentType : this.ObjectContext.MetadataWorkspace.GetObjectSpaceType((global::System.Data.Entity.Core.Metadata.Edm.EnumType)edmType).ClrType;
						objectParameter = new global::System.Data.Entity.Core.Objects.ObjectParameter(aliasGenerator.Next(), type);
						result = false;
					}
					else
					{
						objectParameter = new global::System.Data.Entity.Core.Objects.ObjectParameter(aliasGenerator.Next(), obj);
					}
					objectParameter.TypeUsage = global::System.Data.Entity.Core.Metadata.Edm.Helper.GetModelTypeUsage(parameterMember);
					query.Parameters.Add(objectParameter);
				}
			}
			return result;
		}

		// Token: 0x0600388B RID: 14475 RVA: 0x000B8A78 File Offset: 0x000B6C78
		private object GetCurrentValueFromEntity(global::System.Data.Entity.Core.Metadata.Edm.EdmMember member)
		{
			global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata orAddStateManagerTypeMetadata = this._context.ObjectStateManager.GetOrAddStateManagerTypeMetadata(member.DeclaringType);
			return orAddStateManagerTypeMetadata.Member(orAddStateManagerTypeMetadata.GetOrdinalforCLayerMemberName(member.Name)).GetValue(this._wrappedOwner.Entity);
		}

		// Token: 0x0600388C RID: 14476 RVA: 0x000B8AB4 File Offset: 0x000B6CB4
		private static void AppendKeyParameterRow(global::System.Text.StringBuilder sourceBuilder, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> keyMembers)
		{
			sourceBuilder.Append("ROW(");
			global::System.Data.Entity.Core.Common.Utils.AliasGenerator aliasGenerator = new global::System.Data.Entity.Core.Common.Utils.AliasGenerator("EntityKeyValue");
			int count = keyMembers.Count;
			for (int i = 0; i < count; i++)
			{
				string value = aliasGenerator.Next();
				sourceBuilder.Append("@");
				sourceBuilder.Append(value);
				sourceBuilder.Append(" AS ");
				sourceBuilder.Append(value);
				if (i < count - 1)
				{
					sourceBuilder.Append(",");
				}
			}
			sourceBuilder.Append(")");
		}

		// Token: 0x0600388D RID: 14477 RVA: 0x000B8B38 File Offset: 0x000B6D38
		private static void AppendEntitySet(global::System.Text.StringBuilder sourceBuilder, global::System.Data.Entity.Core.Metadata.Edm.EntitySet targetEntitySet, global::System.Data.Entity.Core.Metadata.Edm.EntityType targetEntityType, bool ofTypeRequired)
		{
			if (ofTypeRequired)
			{
				sourceBuilder.Append("OfType(");
			}
			sourceBuilder.Append("[");
			sourceBuilder.Append(targetEntitySet.EntityContainer.Name);
			sourceBuilder.Append("].[");
			sourceBuilder.Append(targetEntitySet.Name);
			sourceBuilder.Append("]");
			if (ofTypeRequired)
			{
				sourceBuilder.Append(", [");
				if (!string.IsNullOrEmpty(targetEntityType.NamespaceName))
				{
					sourceBuilder.Append(targetEntityType.NamespaceName);
					sourceBuilder.Append("].[");
				}
				sourceBuilder.Append(targetEntityType.Name);
				sourceBuilder.Append("])");
			}
		}

		// Token: 0x0600388E RID: 14478 RVA: 0x000B8BE8 File Offset: 0x000B6DE8
		internal virtual global::System.Data.Entity.Core.Objects.ObjectQuery<TEntity> ValidateLoad<TEntity>(global::System.Data.Entity.Core.Objects.MergeOption mergeOption, string relatedEndName, out bool hasResults)
		{
			global::System.Data.Entity.Core.Objects.ObjectQuery<TEntity> objectQuery = this.CreateSourceQuery<TEntity>(mergeOption, out hasResults);
			if (objectQuery == null)
			{
				throw global::System.Data.Entity.Resources.Error.RelatedEnd_RelatedEndNotAttachedToContext(relatedEndName);
			}
			global::System.Data.Entity.Core.Objects.EntityEntry entityEntry = this.ObjectContext.ObjectStateManager.FindEntityEntry(this._wrappedOwner.Entity);
			if (entityEntry != null && entityEntry.State == global::System.Data.Entity.EntityState.Deleted)
			{
				throw global::System.Data.Entity.Resources.Error.Collections_InvalidEntityStateLoad(relatedEndName);
			}
			if (this.UsingNoTracking != (mergeOption == global::System.Data.Entity.Core.Objects.MergeOption.NoTracking))
			{
				throw global::System.Data.Entity.Resources.Error.RelatedEnd_MismatchedMergeOptionOnLoad(mergeOption);
			}
			if (this.UsingNoTracking)
			{
				if (this.IsLoaded)
				{
					throw global::System.Data.Entity.Resources.Error.RelatedEnd_LoadCalledOnAlreadyLoadedNoTrackedRelatedEnd();
				}
				if (!this.IsEmpty())
				{
					throw global::System.Data.Entity.Resources.Error.RelatedEnd_LoadCalledOnNonEmptyNoTrackedRelatedEnd();
				}
			}
			return objectQuery;
		}

		// Token: 0x0600388F RID: 14479 RVA: 0x000B8C74 File Offset: 0x000B6E74
		public void Load()
		{
			this.Load(this.DefaultMergeOption);
		}

		// Token: 0x06003890 RID: 14480 RVA: 0x000B8C82 File Offset: 0x000B6E82
		public global::System.Threading.Tasks.Task LoadAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			return this.LoadAsync(this.DefaultMergeOption, cancellationToken);
		}

		// Token: 0x06003891 RID: 14481
		public abstract void Load(global::System.Data.Entity.Core.Objects.MergeOption mergeOption);

		// Token: 0x06003892 RID: 14482
		public abstract global::System.Threading.Tasks.Task LoadAsync(global::System.Data.Entity.Core.Objects.MergeOption mergeOption, global::System.Threading.CancellationToken cancellationToken);

		// Token: 0x06003893 RID: 14483 RVA: 0x000B8C94 File Offset: 0x000B6E94
		internal void DeferredLoad()
		{
			if (this._wrappedOwner != null && this._wrappedOwner != global::System.Data.Entity.Core.Objects.Internal.NullEntityWrapper.NullWrapper && !this.IsLoaded && this._context != null && this._context.ContextOptions.LazyLoadingEnabled && !this._context.InMaterialization && this.CanDeferredLoad && (this.UsingNoTracking || (this._wrappedOwner.ObjectStateEntry != null && (this._wrappedOwner.ObjectStateEntry.State == global::System.Data.Entity.EntityState.Unchanged || this._wrappedOwner.ObjectStateEntry.State == global::System.Data.Entity.EntityState.Modified || (this._wrappedOwner.ObjectStateEntry.State == global::System.Data.Entity.EntityState.Added && this.IsForeignKey && this.IsDependentEndOfReferentialConstraint(false))))))
			{
				this._context.ContextOptions.LazyLoadingEnabled = false;
				try
				{
					this.Load();
				}
				finally
				{
					this._context.ContextOptions.LazyLoadingEnabled = true;
				}
			}
		}

		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x06003894 RID: 14484 RVA: 0x000B8DA0 File Offset: 0x000B6FA0
		internal virtual bool CanDeferredLoad
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06003895 RID: 14485 RVA: 0x000B8DA4 File Offset: 0x000B6FA4
		internal virtual void Merge<TEntity>(global::System.Collections.Generic.IEnumerable<TEntity> collection, global::System.Data.Entity.Core.Objects.MergeOption mergeOption, bool setIsLoaded)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper> list = collection as global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>;
			if (list == null)
			{
				list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>();
				global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = ((global::System.Data.Entity.Core.Metadata.Edm.AssociationSet)this.RelationshipSet).AssociationSetEnds[this.TargetRoleName].EntitySet;
				foreach (TEntity tentity in collection)
				{
					global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper entityWrapper = this.EntityWrapperFactory.WrapEntityUsingContext(tentity, this.ObjectContext);
					if (mergeOption == global::System.Data.Entity.Core.Objects.MergeOption.NoTracking)
					{
						this.EntityWrapperFactory.UpdateNoTrackingWrapper(entityWrapper, this.ObjectContext, entitySet);
					}
					list.Add(entityWrapper);
				}
			}
			this.Merge<TEntity>(list, mergeOption, setIsLoaded);
		}

		// Token: 0x06003896 RID: 14486 RVA: 0x000B8E5C File Offset: 0x000B705C
		internal virtual void Merge<TEntity>(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper> collection, global::System.Data.Entity.Core.Objects.MergeOption mergeOption, bool setIsLoaded)
		{
			if (this.WrappedOwner.EntityKey == null)
			{
				throw global::System.Data.Entity.Resources.Error.EntityKey_UnexpectedNull();
			}
			this.ObjectContext.ObjectStateManager.UpdateRelationships(this.ObjectContext, mergeOption, (global::System.Data.Entity.Core.Metadata.Edm.AssociationSet)this.RelationshipSet, (global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember)this.FromEndMember, this.WrappedOwner, (global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember)this.ToEndMember, collection, setIsLoaded);
			if (setIsLoaded)
			{
				this._isLoaded = true;
			}
		}

		// Token: 0x06003897 RID: 14487 RVA: 0x000B8ECD File Offset: 0x000B70CD
		void global::System.Data.Entity.Core.Objects.DataClasses.IRelatedEnd.Attach(global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithRelationships entity)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithRelationships>(entity, "entity");
			((global::System.Data.Entity.Core.Objects.DataClasses.IRelatedEnd)this).Attach(entity);
		}

		// Token: 0x06003898 RID: 14488 RVA: 0x000B8EE2 File Offset: 0x000B70E2
		void global::System.Data.Entity.Core.Objects.DataClasses.IRelatedEnd.Attach(object entity)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<object>(entity, "entity");
			this.CheckOwnerNull();
			this.Attach(new global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper[]
			{
				this.EntityWrapperFactory.WrapEntityUsingContext(entity, this.ObjectContext)
			}, false);
		}

		// Token: 0x06003899 RID: 14489 RVA: 0x000B8F18 File Offset: 0x000B7118
		internal void Attach(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper> wrappedEntities, bool allowCollection)
		{
			this.CheckOwnerNull();
			this.ValidateOwnerForAttach();
			int num = 0;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>();
			foreach (global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper entityWrapper in wrappedEntities)
			{
				this.ValidateEntityForAttach(entityWrapper, num++, allowCollection);
				list.Add(entityWrapper);
			}
			this._suppressEvents = true;
			try
			{
				this.Merge<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>(list, global::System.Data.Entity.Core.Objects.MergeOption.OverwriteChanges, false);
				global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint referentialConstraint = ((global::System.Data.Entity.Core.Metadata.Edm.AssociationType)this.RelationMetadata).ReferentialConstraints.FirstOrDefault<global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>();
				if (referentialConstraint != null)
				{
					global::System.Data.Entity.Core.Objects.ObjectStateManager objectStateManager = this.ObjectContext.ObjectStateManager;
					global::System.Data.Entity.Core.Objects.EntityEntry entityEntry = objectStateManager.FindEntityEntry(this._wrappedOwner.Entity);
					if (this.IsDependentEndOfReferentialConstraint(false))
					{
						if (!global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd.VerifyRIConstraintsWithRelatedEntry(referentialConstraint, new global::System.Func<string, object>(entityEntry.GetCurrentEntityValue), list[0].ObjectStateEntry.EntityKey))
						{
							throw new global::System.InvalidOperationException(referentialConstraint.BuildConstraintExceptionMessage());
						}
					}
					else
					{
						foreach (global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity in list)
						{
							global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd otherEndOfRelationship = this.GetOtherEndOfRelationship(wrappedEntity);
							if (otherEndOfRelationship.IsDependentEndOfReferentialConstraint(false))
							{
								global::System.Data.Entity.Core.Objects.EntityEntry @object = objectStateManager.FindEntityEntry(otherEndOfRelationship.WrappedOwner.Entity);
								if (!global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd.VerifyRIConstraintsWithRelatedEntry(referentialConstraint, new global::System.Func<string, object>(@object.GetCurrentEntityValue), entityEntry.EntityKey))
								{
									throw new global::System.InvalidOperationException(referentialConstraint.BuildConstraintExceptionMessage());
								}
							}
						}
					}
				}
			}
			finally
			{
				this._suppressEvents = false;
			}
			this.OnAssociationChanged(global::System.ComponentModel.CollectionChangeAction.Refresh, null);
		}

		// Token: 0x0600389A RID: 14490 RVA: 0x000B90E0 File Offset: 0x000B72E0
		internal void ValidateOwnerForAttach()
		{
			if (this.ObjectContext == null || this.UsingNoTracking)
			{
				throw global::System.Data.Entity.Resources.Error.RelatedEnd_InvalidOwnerStateForAttach();
			}
			global::System.Data.Entity.Core.Objects.EntityEntry entityEntry = this.ObjectContext.ObjectStateManager.GetEntityEntry(this._wrappedOwner.Entity);
			if (entityEntry.State != global::System.Data.Entity.EntityState.Modified && entityEntry.State != global::System.Data.Entity.EntityState.Unchanged)
			{
				throw global::System.Data.Entity.Resources.Error.RelatedEnd_InvalidOwnerStateForAttach();
			}
		}

		// Token: 0x0600389B RID: 14491 RVA: 0x000B9138 File Offset: 0x000B7338
		internal void ValidateEntityForAttach(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity, int index, bool allowCollection)
		{
			if (wrappedEntity == null || wrappedEntity.Entity == null)
			{
				if (allowCollection)
				{
					throw global::System.Data.Entity.Resources.Error.RelatedEnd_InvalidNthElementNullForAttach(index);
				}
				throw new global::System.ArgumentNullException("wrappedEntity");
			}
			else
			{
				this.VerifyType(wrappedEntity);
				global::System.Data.Entity.Core.Objects.EntityEntry entityEntry = this.ObjectContext.ObjectStateManager.FindEntityEntry(wrappedEntity.Entity);
				if (entityEntry == null || entityEntry.Entity != wrappedEntity.Entity)
				{
					if (allowCollection)
					{
						throw global::System.Data.Entity.Resources.Error.RelatedEnd_InvalidNthElementContextForAttach(index);
					}
					throw global::System.Data.Entity.Resources.Error.RelatedEnd_InvalidEntityContextForAttach();
				}
				else
				{
					if (entityEntry.State == global::System.Data.Entity.EntityState.Unchanged || entityEntry.State == global::System.Data.Entity.EntityState.Modified)
					{
						return;
					}
					if (allowCollection)
					{
						throw global::System.Data.Entity.Resources.Error.RelatedEnd_InvalidNthElementStateForAttach(index);
					}
					throw global::System.Data.Entity.Resources.Error.RelatedEnd_InvalidEntityStateForAttach();
				}
			}
		}

		// Token: 0x0600389C RID: 14492
		internal abstract global::System.Collections.IEnumerable CreateSourceQueryInternal();

		// Token: 0x0600389D RID: 14493 RVA: 0x000B91D6 File Offset: 0x000B73D6
		void global::System.Data.Entity.Core.Objects.DataClasses.IRelatedEnd.Add(global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithRelationships entity)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithRelationships>(entity, "entity");
			((global::System.Data.Entity.Core.Objects.DataClasses.IRelatedEnd)this).Add(entity);
		}

		// Token: 0x0600389E RID: 14494 RVA: 0x000B91EB File Offset: 0x000B73EB
		void global::System.Data.Entity.Core.Objects.DataClasses.IRelatedEnd.Add(object entity)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<object>(entity, "entity");
			this.Add(this.EntityWrapperFactory.WrapEntityUsingContext(entity, this.ObjectContext));
		}

		// Token: 0x0600389F RID: 14495 RVA: 0x000B9211 File Offset: 0x000B7411
		internal void Add(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity)
		{
			if (this._wrappedOwner.Entity != null)
			{
				this.Add(wrappedEntity, true);
				return;
			}
			this.DisconnectedAdd(wrappedEntity);
		}

		// Token: 0x060038A0 RID: 14496 RVA: 0x000B9230 File Offset: 0x000B7430
		bool global::System.Data.Entity.Core.Objects.DataClasses.IRelatedEnd.Remove(global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithRelationships entity)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithRelationships>(entity, "entity");
			return ((global::System.Data.Entity.Core.Objects.DataClasses.IRelatedEnd)this).Remove(entity);
		}

		// Token: 0x060038A1 RID: 14497 RVA: 0x000B9245 File Offset: 0x000B7445
		bool global::System.Data.Entity.Core.Objects.DataClasses.IRelatedEnd.Remove(object entity)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<object>(entity, "entity");
			this.DeferredLoad();
			return this.Remove(this.EntityWrapperFactory.WrapEntityUsingContext(entity, this.ObjectContext), false);
		}

		// Token: 0x060038A2 RID: 14498 RVA: 0x000B9272 File Offset: 0x000B7472
		internal bool Remove(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity, bool preserveForeignKey)
		{
			if (this._wrappedOwner.Entity == null)
			{
				return this.DisconnectedRemove(wrappedEntity);
			}
			if (this.ContainsEntity(wrappedEntity))
			{
				this.Remove(wrappedEntity, true, false, false, true, preserveForeignKey);
				return true;
			}
			return false;
		}

		// Token: 0x060038A3 RID: 14499
		internal abstract void DisconnectedAdd(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity);

		// Token: 0x060038A4 RID: 14500
		internal abstract bool DisconnectedRemove(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity);

		// Token: 0x060038A5 RID: 14501 RVA: 0x000B92A1 File Offset: 0x000B74A1
		internal void Add(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity, bool applyConstraints)
		{
			if (this._context != null && !this.UsingNoTracking)
			{
				this.ValidateStateForAdd(this._wrappedOwner);
				this.ValidateStateForAdd(wrappedEntity);
			}
			this.Add(wrappedEntity, applyConstraints, false, false, true, true);
		}

		// Token: 0x060038A6 RID: 14502 RVA: 0x000B92D4 File Offset: 0x000B74D4
		internal void CheckRelationEntitySet(global::System.Data.Entity.Core.Metadata.Edm.EntitySet set)
		{
			if (((global::System.Data.Entity.Core.Metadata.Edm.AssociationSet)this._relationshipSet).AssociationSetEnds[this._navigation.To] != null && ((global::System.Data.Entity.Core.Metadata.Edm.AssociationSet)this._relationshipSet).AssociationSetEnds[this._navigation.To].EntitySet != set)
			{
				throw global::System.Data.Entity.Resources.Error.RelatedEnd_EntitySetIsNotValidForRelationship(set.EntityContainer.Name, set.Name, this._navigation.To, this._relationshipSet.EntityContainer.Name, this._relationshipSet.Name);
			}
		}

		// Token: 0x060038A7 RID: 14503 RVA: 0x000B9368 File Offset: 0x000B7568
		internal void ValidateStateForAdd(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity)
		{
			global::System.Data.Entity.Core.Objects.EntityEntry entityEntry = this.ObjectContext.ObjectStateManager.FindEntityEntry(wrappedEntity.Entity);
			if (entityEntry != null && entityEntry.State == global::System.Data.Entity.EntityState.Deleted)
			{
				throw global::System.Data.Entity.Resources.Error.RelatedEnd_UnableToAddRelationshipWithDeletedEntity();
			}
		}

		// Token: 0x060038A8 RID: 14504 RVA: 0x000B93A0 File Offset: 0x000B75A0
		internal void Add(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedTarget, bool applyConstraints, bool addRelationshipAsUnchanged, bool relationshipAlreadyExists, bool allowModifyingOtherEndOfRelationship, bool forceForeignKeyChanges)
		{
			if (!this.VerifyEntityForAdd(wrappedTarget, relationshipAlreadyExists))
			{
				return;
			}
			global::System.Data.Entity.Core.EntityKey entityKey = wrappedTarget.EntityKey;
			if (entityKey != null && this.ObjectContext != null)
			{
				this.CheckRelationEntitySet(entityKey.GetEntitySet(this.ObjectContext.MetadataWorkspace));
			}
			global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd otherEndOfRelationship = this.GetOtherEndOfRelationship(wrappedTarget);
			this.ValidateContextsAreCompatible(otherEndOfRelationship);
			otherEndOfRelationship.VerifyEntityForAdd(this._wrappedOwner, relationshipAlreadyExists);
			otherEndOfRelationship.VerifyMultiplicityConstraintsForAdd(!allowModifyingOtherEndOfRelationship);
			if (this.CheckIfNavigationPropertyContainsEntity(wrappedTarget))
			{
				this.AddToLocalCache(wrappedTarget, applyConstraints);
			}
			else
			{
				this.AddToCache(wrappedTarget, applyConstraints);
			}
			if (otherEndOfRelationship.CheckIfNavigationPropertyContainsEntity(this.WrappedOwner))
			{
				otherEndOfRelationship.AddToLocalCache(this._wrappedOwner, false);
			}
			else
			{
				otherEndOfRelationship.AddToCache(this._wrappedOwner, false);
			}
			this.SynchronizeContexts(otherEndOfRelationship, relationshipAlreadyExists, addRelationshipAsUnchanged);
			if (this.ObjectContext != null && this.IsForeignKey && !this.ObjectContext.ObjectStateManager.TransactionManager.IsGraphUpdate && !this.UpdateDependentEndForeignKey(otherEndOfRelationship, forceForeignKeyChanges))
			{
				otherEndOfRelationship.UpdateDependentEndForeignKey(this, forceForeignKeyChanges);
			}
			otherEndOfRelationship.OnAssociationChanged(global::System.ComponentModel.CollectionChangeAction.Add, this._wrappedOwner.Entity);
			this.OnAssociationChanged(global::System.ComponentModel.CollectionChangeAction.Add, wrappedTarget.Entity);
		}

		// Token: 0x060038A9 RID: 14505 RVA: 0x000B94BB File Offset: 0x000B76BB
		internal virtual void AddToNavigationPropertyIfCompatible(global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd otherRelatedEnd)
		{
			this.AddToNavigationProperty(otherRelatedEnd.WrappedOwner);
		}

		// Token: 0x060038AA RID: 14506 RVA: 0x000B94C9 File Offset: 0x000B76C9
		internal virtual bool CachedForeignKeyIsConceptualNull()
		{
			return false;
		}

		// Token: 0x060038AB RID: 14507 RVA: 0x000B94CC File Offset: 0x000B76CC
		internal virtual bool UpdateDependentEndForeignKey(global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd targetRelatedEnd, bool forceForeignKeyChanges)
		{
			return false;
		}

		// Token: 0x060038AC RID: 14508 RVA: 0x000B94CF File Offset: 0x000B76CF
		internal virtual void VerifyDetachedKeyMatches(global::System.Data.Entity.Core.EntityKey entityKey)
		{
		}

		// Token: 0x060038AD RID: 14509 RVA: 0x000B94D4 File Offset: 0x000B76D4
		private void ValidateContextsAreCompatible(global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd targetRelatedEnd)
		{
			if (this.ObjectContext == targetRelatedEnd.ObjectContext && this.ObjectContext != null)
			{
				if (this.UsingNoTracking != targetRelatedEnd.UsingNoTracking)
				{
					throw global::System.Data.Entity.Resources.Error.RelatedEnd_CannotCreateRelationshipBetweenTrackedAndNoTrackedEntities(this.UsingNoTracking ? this._navigation.From : this._navigation.To);
				}
			}
			else if (this.ObjectContext != null && targetRelatedEnd.ObjectContext != null)
			{
				if (this.UsingNoTracking && targetRelatedEnd.UsingNoTracking)
				{
					targetRelatedEnd.WrappedOwner.ResetContext(this.ObjectContext, this.GetTargetEntitySetFromRelationshipSet(), global::System.Data.Entity.Core.Objects.MergeOption.NoTracking);
					return;
				}
				throw global::System.Data.Entity.Resources.Error.RelatedEnd_CannotCreateRelationshipEntitiesInDifferentContexts();
			}
			else if ((this._context == null || this.UsingNoTracking) && targetRelatedEnd.ObjectContext != null && !targetRelatedEnd.UsingNoTracking)
			{
				targetRelatedEnd.ValidateStateForAdd(targetRelatedEnd.WrappedOwner);
			}
		}

		// Token: 0x060038AE RID: 14510 RVA: 0x000B959C File Offset: 0x000B779C
		private void SynchronizeContexts(global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd targetRelatedEnd, bool relationshipAlreadyExists, bool addRelationshipAsUnchanged)
		{
			global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd = null;
			global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper entityWrapper = null;
			global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedOwner = targetRelatedEnd.WrappedOwner;
			if (this.ObjectContext == targetRelatedEnd.ObjectContext && this.ObjectContext != null)
			{
				if (!this.IsForeignKey && !relationshipAlreadyExists && !this.UsingNoTracking)
				{
					if (!this.ObjectContext.ObjectStateManager.TransactionManager.IsLocalPublicAPI && this.WrappedOwner.EntityKey != null && !this.WrappedOwner.EntityKey.IsTemporary && this.IsDependentEndOfReferentialConstraint(false))
					{
						addRelationshipAsUnchanged = true;
					}
					this.AddRelationshipToObjectStateManager(wrappedOwner, addRelationshipAsUnchanged, false);
				}
				if (wrappedOwner.RequiresRelationshipChangeTracking && (this.ObjectContext.ObjectStateManager.TransactionManager.IsAddTracking || this.ObjectContext.ObjectStateManager.TransactionManager.IsAttachTracking || this.ObjectContext.ObjectStateManager.TransactionManager.IsDetectChanges))
				{
					this.AddToNavigationProperty(wrappedOwner);
					targetRelatedEnd.AddToNavigationProperty(this._wrappedOwner);
					return;
				}
			}
			else if (this.ObjectContext != null || targetRelatedEnd.ObjectContext != null)
			{
				if (this.ObjectContext == null)
				{
					relatedEnd = targetRelatedEnd;
					entityWrapper = this._wrappedOwner;
				}
				else
				{
					relatedEnd = this;
					entityWrapper = wrappedOwner;
				}
				if (!relatedEnd.UsingNoTracking)
				{
					global::System.Data.Entity.Core.Objects.Internal.TransactionManager transactionManager = relatedEnd.WrappedOwner.Context.ObjectStateManager.TransactionManager;
					transactionManager.BeginAddTracking();
					try
					{
						bool flag = true;
						try
						{
							if (transactionManager.TrackProcessedEntities)
							{
								if (!transactionManager.WrappedEntities.ContainsKey(entityWrapper.Entity))
								{
									transactionManager.WrappedEntities.Add(entityWrapper.Entity, entityWrapper);
								}
								transactionManager.ProcessedEntities.Add(relatedEnd.WrappedOwner);
							}
							relatedEnd.AddGraphToObjectStateManager(entityWrapper, relationshipAlreadyExists, addRelationshipAsUnchanged, false);
							if (entityWrapper.RequiresRelationshipChangeTracking && this.TargetAccessor.HasProperty)
							{
								targetRelatedEnd.AddToNavigationProperty(this._wrappedOwner);
							}
							flag = false;
						}
						finally
						{
							if (flag)
							{
								relatedEnd.WrappedOwner.Context.ObjectStateManager.DegradePromotedRelationships();
								relatedEnd.FixupOtherEndOfRelationshipForRemove(entityWrapper, false);
								relatedEnd.RemoveFromCache(entityWrapper, false, false);
								entityWrapper.RelationshipManager.NodeVisited = true;
								global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager.RemoveRelatedEntitiesFromObjectStateManager(entityWrapper);
								global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd.RemoveEntityFromObjectStateManager(entityWrapper);
							}
						}
					}
					finally
					{
						transactionManager.EndAddTracking();
					}
				}
			}
		}

		// Token: 0x060038AF RID: 14511 RVA: 0x000B97C8 File Offset: 0x000B79C8
		private void AddGraphToObjectStateManager(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity, bool relationshipAlreadyExists, bool addRelationshipAsUnchanged, bool doAttach)
		{
			this.AddEntityToObjectStateManager(wrappedEntity, doAttach);
			if (!relationshipAlreadyExists && this.ObjectContext != null && wrappedEntity.Context != null)
			{
				if (!this.IsForeignKey)
				{
					this.AddRelationshipToObjectStateManager(wrappedEntity, addRelationshipAsUnchanged, doAttach);
				}
				if (wrappedEntity.RequiresRelationshipChangeTracking || this.WrappedOwner.RequiresRelationshipChangeTracking)
				{
					this.UpdateSnapshotOfRelationships(wrappedEntity);
					if (doAttach)
					{
						global::System.Data.Entity.Core.Objects.EntityEntry entityEntry = this._context.ObjectStateManager.GetEntityEntry(wrappedEntity.Entity);
						wrappedEntity.RelationshipManager.CheckReferentialConstraintProperties(entityEntry);
					}
				}
			}
			global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd.WalkObjectGraphToIncludeAllRelatedEntities(wrappedEntity, addRelationshipAsUnchanged, doAttach);
		}

		// Token: 0x060038B0 RID: 14512 RVA: 0x000B9850 File Offset: 0x000B7A50
		private void UpdateSnapshotOfRelationships(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity)
		{
			global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd otherEndOfRelationship = this.GetOtherEndOfRelationship(wrappedEntity);
			if (!otherEndOfRelationship.ContainsEntity(this.WrappedOwner))
			{
				otherEndOfRelationship.AddToLocalCache(this.WrappedOwner, false);
			}
		}

		// Token: 0x060038B1 RID: 14513 RVA: 0x000B9880 File Offset: 0x000B7A80
		internal void Remove(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity, bool doFixup, bool deleteEntity, bool deleteOwner, bool applyReferentialConstraints, bool preserveForeignKey)
		{
			if (wrappedEntity.RequiresRelationshipChangeTracking && doFixup && this.TargetAccessor.HasProperty && !this.CheckIfNavigationPropertyContainsEntity(wrappedEntity))
			{
				this.GetOtherEndOfRelationship(wrappedEntity).RemoveFromNavigationProperty(this.WrappedOwner);
			}
			if (!this.ContainsEntity(wrappedEntity))
			{
				return;
			}
			if (this._context != null && doFixup && applyReferentialConstraints && this.IsDependentEndOfReferentialConstraint(false))
			{
				this.GetOtherEndOfRelationship(wrappedEntity).Remove(this._wrappedOwner, doFixup, deleteEntity, deleteOwner, applyReferentialConstraints, preserveForeignKey);
				return;
			}
			bool flag = this.RemoveFromCache(wrappedEntity, false, preserveForeignKey);
			if (!this.UsingNoTracking && this.ObjectContext != null && !this.IsForeignKey)
			{
				global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd.MarkRelationshipAsDeletedInObjectStateManager(wrappedEntity, this._wrappedOwner, this._relationshipSet, this._navigation);
			}
			if (doFixup)
			{
				this.FixupOtherEndOfRelationshipForRemove(wrappedEntity, preserveForeignKey);
				if ((this._context == null || !this._context.ObjectStateManager.TransactionManager.IsLocalPublicAPI) && this._context != null && (deleteEntity || (deleteOwner && global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd.CheckCascadeDeleteFlag(this._fromEndMember)) || (applyReferentialConstraints && this.IsPrincipalEndOfReferentialConstraint())) && wrappedEntity.Entity != this._context.ObjectStateManager.TransactionManager.EntityBeingReparented && this._context.ObjectStateManager.EntityInvokingFKSetter != wrappedEntity.Entity)
				{
					this.EnsureRelationshipNavigationAccessorsInitialized();
					global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd.RemoveEntityFromRelatedEnds(wrappedEntity, this._wrappedOwner, this._navigation.Reverse);
					global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd.MarkEntityAsDeletedInObjectStateManager(wrappedEntity);
				}
			}
			if (flag)
			{
				this.OnAssociationChanged(global::System.ComponentModel.CollectionChangeAction.Remove, wrappedEntity.Entity);
			}
		}

		// Token: 0x060038B2 RID: 14514 RVA: 0x000B99FC File Offset: 0x000B7BFC
		internal bool IsDependentEndOfReferentialConstraint(bool checkIdentifying)
		{
			if (this._relationMetadata != null)
			{
				foreach (global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint referentialConstraint in ((global::System.Data.Entity.Core.Metadata.Edm.AssociationType)this.RelationMetadata).ReferentialConstraints)
				{
					if (referentialConstraint.ToRole == this.FromEndMember)
					{
						if (checkIdentifying)
						{
							return global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd.CheckIfAllPropertiesAreKeyProperties(referentialConstraint.ToRole.GetEntityType().KeyMemberNames, referentialConstraint.ToProperties);
						}
						return true;
					}
				}
				return false;
			}
			return false;
		}

		// Token: 0x060038B3 RID: 14515 RVA: 0x000B9A90 File Offset: 0x000B7C90
		internal bool IsPrincipalEndOfReferentialConstraint()
		{
			if (this._relationMetadata != null)
			{
				foreach (global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint referentialConstraint in ((global::System.Data.Entity.Core.Metadata.Edm.AssociationType)this._relationMetadata).ReferentialConstraints)
				{
					if (referentialConstraint.FromRole == this._fromEndMember)
					{
						return global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd.CheckIfAllPropertiesAreKeyProperties(referentialConstraint.ToRole.GetEntityType().KeyMemberNames, referentialConstraint.ToProperties);
					}
				}
				return false;
			}
			return false;
		}

		// Token: 0x060038B4 RID: 14516 RVA: 0x000B9B20 File Offset: 0x000B7D20
		internal static bool CheckIfAllPropertiesAreKeyProperties(string[] keyMemberNames, global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> toProperties)
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty in toProperties)
			{
				bool flag = false;
				for (int i = 0; i < keyMemberNames.Length; i++)
				{
					if (keyMemberNames[i] == edmProperty.Name)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060038B5 RID: 14517 RVA: 0x000B9BA0 File Offset: 0x000B7DA0
		internal void IncludeEntity(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity, bool addRelationshipAsUnchanged, bool doAttach)
		{
			global::System.Data.Entity.Core.Objects.EntityEntry entityEntry = this._context.ObjectStateManager.FindEntityEntry(wrappedEntity.Entity);
			if (entityEntry != null && entityEntry.State == global::System.Data.Entity.EntityState.Deleted)
			{
				throw global::System.Data.Entity.Resources.Error.RelatedEnd_UnableToAddRelationshipWithDeletedEntity();
			}
			if (wrappedEntity.RequiresRelationshipChangeTracking || this.WrappedOwner.RequiresRelationshipChangeTracking)
			{
				global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd otherEndOfRelationship = this.GetOtherEndOfRelationship(wrappedEntity);
				this.ObjectContext.GetTypeUsage(otherEndOfRelationship.WrappedOwner.IdentityType);
				otherEndOfRelationship.AddToNavigationPropertyIfCompatible(this);
			}
			if (entityEntry == null)
			{
				this.AddGraphToObjectStateManager(wrappedEntity, false, addRelationshipAsUnchanged, doAttach);
				return;
			}
			if (this.FindRelationshipEntryInObjectStateManager(wrappedEntity) == null)
			{
				this.VerifyDetachedKeyMatches(wrappedEntity.EntityKey);
				if (this.ObjectContext != null && wrappedEntity.Context != null)
				{
					if (!this.IsForeignKey)
					{
						if (entityEntry.State == global::System.Data.Entity.EntityState.Added)
						{
							this.AddRelationshipToObjectStateManager(wrappedEntity, addRelationshipAsUnchanged, false);
						}
						else
						{
							this.AddRelationshipToObjectStateManager(wrappedEntity, addRelationshipAsUnchanged, doAttach);
						}
					}
					if (wrappedEntity.RequiresRelationshipChangeTracking || this.WrappedOwner.RequiresRelationshipChangeTracking)
					{
						this.UpdateSnapshotOfRelationships(wrappedEntity);
						if (doAttach && entityEntry.State != global::System.Data.Entity.EntityState.Added)
						{
							global::System.Data.Entity.Core.Objects.EntityEntry entityEntry2 = this.ObjectContext.ObjectStateManager.GetEntityEntry(wrappedEntity.Entity);
							wrappedEntity.RelationshipManager.CheckReferentialConstraintProperties(entityEntry2);
						}
					}
				}
			}
		}

		// Token: 0x060038B6 RID: 14518 RVA: 0x000B9CBC File Offset: 0x000B7EBC
		internal void MarkForeignKeyPropertiesModified()
		{
			global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint referentialConstraint = ((global::System.Data.Entity.Core.Metadata.Edm.AssociationType)this.RelationMetadata).ReferentialConstraints[0];
			global::System.Data.Entity.Core.Objects.EntityEntry objectStateEntry = this.WrappedOwner.ObjectStateEntry;
			if (objectStateEntry.State == global::System.Data.Entity.EntityState.Unchanged || objectStateEntry.State == global::System.Data.Entity.EntityState.Modified)
			{
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty in referentialConstraint.ToProperties)
				{
					objectStateEntry.SetModifiedProperty(edmProperty.Name);
				}
			}
		}

		// Token: 0x060038B7 RID: 14519
		internal abstract bool CheckIfNavigationPropertyContainsEntity(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrapper);

		// Token: 0x060038B8 RID: 14520
		internal abstract void VerifyNavigationPropertyForAdd(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrapper);

		// Token: 0x060038B9 RID: 14521 RVA: 0x000B9D4C File Offset: 0x000B7F4C
		internal void AddToNavigationProperty(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrapper)
		{
			if (this.TargetAccessor.HasProperty && !this.CheckIfNavigationPropertyContainsEntity(wrapper))
			{
				global::System.Data.Entity.Core.Objects.Internal.TransactionManager transactionManager = wrapper.Context.ObjectStateManager.TransactionManager;
				if (transactionManager.IsAddTracking || transactionManager.IsAttachTracking)
				{
					wrapper.Context.ObjectStateManager.TrackPromotedRelationship(this, wrapper);
				}
				this.AddToObjectCache(wrapper);
			}
		}

		// Token: 0x060038BA RID: 14522 RVA: 0x000B9DA9 File Offset: 0x000B7FA9
		internal void RemoveFromNavigationProperty(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrapper)
		{
			if (this.TargetAccessor.HasProperty && this.CheckIfNavigationPropertyContainsEntity(wrapper))
			{
				this.RemoveFromObjectCache(wrapper);
			}
		}

		// Token: 0x060038BB RID: 14523 RVA: 0x000B9DCC File Offset: 0x000B7FCC
		internal void ExcludeEntity(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity)
		{
			if (!this._context.ObjectStateManager.TransactionManager.TrackProcessedEntities || (!this._context.ObjectStateManager.TransactionManager.IsAttachTracking && !this._context.ObjectStateManager.TransactionManager.IsAddTracking) || this._context.ObjectStateManager.TransactionManager.ProcessedEntities.Contains(wrappedEntity))
			{
				global::System.Data.Entity.Core.Objects.EntityEntry entityEntry = this._context.ObjectStateManager.FindEntityEntry(wrappedEntity.Entity);
				if (entityEntry != null && entityEntry.State != global::System.Data.Entity.EntityState.Deleted && !wrappedEntity.RelationshipManager.NodeVisited)
				{
					wrappedEntity.RelationshipManager.NodeVisited = true;
					global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager.RemoveRelatedEntitiesFromObjectStateManager(wrappedEntity);
					if (!this.IsForeignKey)
					{
						global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd.RemoveRelationshipFromObjectStateManager(wrappedEntity, this._wrappedOwner, this._relationshipSet, this._navigation);
					}
					global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd.RemoveEntityFromObjectStateManager(wrappedEntity);
					return;
				}
				if (!this.IsForeignKey && this.FindRelationshipEntryInObjectStateManager(wrappedEntity) != null)
				{
					global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd.RemoveRelationshipFromObjectStateManager(wrappedEntity, this._wrappedOwner, this._relationshipSet, this._navigation);
				}
			}
		}

		// Token: 0x060038BC RID: 14524 RVA: 0x000B9ED0 File Offset: 0x000B80D0
		internal global::System.Data.Entity.Core.Objects.RelationshipEntry FindRelationshipEntryInObjectStateManager(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity)
		{
			global::System.Data.Entity.Core.EntityKey entityKey = wrappedEntity.EntityKey;
			global::System.Data.Entity.Core.EntityKey entityKey2 = this._wrappedOwner.EntityKey;
			return this._context.ObjectStateManager.FindRelationship(this._relationshipSet, new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.EntityKey>(this._navigation.From, entityKey2), new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.EntityKey>(this._navigation.To, entityKey));
		}

		// Token: 0x060038BD RID: 14525 RVA: 0x000B9F28 File Offset: 0x000B8128
		internal void Clear(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity, global::System.Data.Entity.Core.Objects.DataClasses.RelationshipNavigation navigation, bool doCascadeDelete)
		{
			this.ClearCollectionOrRef(wrappedEntity, navigation, doCascadeDelete);
		}

		// Token: 0x060038BE RID: 14526 RVA: 0x000B9F34 File Offset: 0x000B8134
		internal void CheckReferentialConstraintProperties(global::System.Data.Entity.Core.Objects.EntityEntry ownerEntry)
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint referentialConstraint in ((global::System.Data.Entity.Core.Metadata.Edm.AssociationType)this.RelationMetadata).ReferentialConstraints)
			{
				if (referentialConstraint.ToRole == this.FromEndMember)
				{
					if (!this.CheckReferentialConstraintPrincipalProperty(ownerEntry, referentialConstraint))
					{
						throw new global::System.InvalidOperationException(referentialConstraint.BuildConstraintExceptionMessage());
					}
				}
				else if (referentialConstraint.FromRole == this.FromEndMember && !this.CheckReferentialConstraintDependentProperty(ownerEntry, referentialConstraint))
				{
					throw new global::System.InvalidOperationException(referentialConstraint.BuildConstraintExceptionMessage());
				}
			}
		}

		// Token: 0x060038BF RID: 14527 RVA: 0x000B9FD4 File Offset: 0x000B81D4
		internal virtual bool CheckReferentialConstraintPrincipalProperty(global::System.Data.Entity.Core.Objects.EntityEntry ownerEntry, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint constraint)
		{
			return false;
		}

		// Token: 0x060038C0 RID: 14528 RVA: 0x000B9FD8 File Offset: 0x000B81D8
		internal virtual bool CheckReferentialConstraintDependentProperty(global::System.Data.Entity.Core.Objects.EntityEntry ownerEntry, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint constraint)
		{
			if (!this.IsEmpty())
			{
				foreach (global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper entityWrapper in this.GetWrappedEntities())
				{
					global::System.Data.Entity.Core.Objects.EntityEntry objectStateEntry = entityWrapper.ObjectStateEntry;
					if (objectStateEntry != null && objectStateEntry.State != global::System.Data.Entity.EntityState.Added && objectStateEntry.State != global::System.Data.Entity.EntityState.Deleted && objectStateEntry.State != global::System.Data.Entity.EntityState.Detached && !global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd.VerifyRIConstraintsWithRelatedEntry(constraint, new global::System.Func<string, object>(objectStateEntry.GetCurrentEntityValue), ownerEntry.EntityKey))
					{
						return false;
					}
				}
				return true;
			}
			return true;
		}

		// Token: 0x060038C1 RID: 14529 RVA: 0x000BA06C File Offset: 0x000B826C
		internal static bool VerifyRIConstraintsWithRelatedEntry(global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint constraint, global::System.Func<string, object> getDependentPropertyValue, global::System.Data.Entity.Core.EntityKey principalKey)
		{
			for (int i = 0; i < constraint.FromProperties.Count; i++)
			{
				string name = constraint.FromProperties[i].Name;
				string name2 = constraint.ToProperties[i].Name;
				object x = principalKey.FindValueByName(name);
				object y = getDependentPropertyValue(name2);
				if (!global::System.Data.Entity.Core.Common.Utils.ByValueEqualityComparer.Default.Equals(x, y))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060038C2 RID: 14530 RVA: 0x000BA0D6 File Offset: 0x000B82D6
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			this.DeferredLoad();
			return this.GetInternalEnumerable().GetEnumerator();
		}

		// Token: 0x060038C3 RID: 14531 RVA: 0x000BA0EC File Offset: 0x000B82EC
		internal void RemoveAll()
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper> list = null;
			bool flag = false;
			try
			{
				this._suppressEvents = true;
				foreach (global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper item in this.GetWrappedEntities())
				{
					if (list == null)
					{
						list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>();
					}
					list.Add(item);
				}
				if (flag = (list != null && list.Count > 0))
				{
					foreach (global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity in list)
					{
						this.Remove(wrappedEntity, true, false, true, true, false);
					}
				}
			}
			finally
			{
				this._suppressEvents = false;
			}
			if (flag)
			{
				this.OnAssociationChanged(global::System.ComponentModel.CollectionChangeAction.Refresh, null);
			}
		}

		// Token: 0x060038C4 RID: 14532 RVA: 0x000BA1C8 File Offset: 0x000B83C8
		internal virtual void DetachAll(global::System.Data.Entity.EntityState ownerEntityState)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>();
			foreach (global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper item in this.GetWrappedEntities())
			{
				list.Add(item);
			}
			bool flag = ownerEntityState == global::System.Data.Entity.EntityState.Added || this._fromEndMember.RelationshipMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many;
			foreach (global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity in list)
			{
				if (!this.ContainsEntity(wrappedEntity))
				{
					return;
				}
				if (flag)
				{
					global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd.DetachRelationshipFromObjectStateManager(wrappedEntity, this._wrappedOwner, this._relationshipSet, this._navigation);
				}
				global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd otherEndOfRelationship = this.GetOtherEndOfRelationship(wrappedEntity);
				otherEndOfRelationship.RemoveFromCache(this._wrappedOwner, true, false);
				otherEndOfRelationship.OnAssociationChanged(global::System.ComponentModel.CollectionChangeAction.Remove, this._wrappedOwner.Entity);
			}
			foreach (global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity2 in list)
			{
				this.GetOtherEndOfRelationship(wrappedEntity2);
				this.RemoveFromCache(wrappedEntity2, false, false);
			}
			this.OnAssociationChanged(global::System.ComponentModel.CollectionChangeAction.Refresh, null);
		}

		// Token: 0x060038C5 RID: 14533 RVA: 0x000BA310 File Offset: 0x000B8510
		internal void AddToCache(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity, bool applyConstraints)
		{
			this.AddToLocalCache(wrappedEntity, applyConstraints);
			this.AddToObjectCache(wrappedEntity);
		}

		// Token: 0x060038C6 RID: 14534
		internal abstract void AddToLocalCache(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity, bool applyConstraints);

		// Token: 0x060038C7 RID: 14535
		internal abstract void AddToObjectCache(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity);

		// Token: 0x060038C8 RID: 14536 RVA: 0x000BA321 File Offset: 0x000B8521
		internal bool RemoveFromCache(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity, bool resetIsLoaded, bool preserveForeignKey)
		{
			bool result = this.RemoveFromLocalCache(wrappedEntity, resetIsLoaded, preserveForeignKey);
			this.RemoveFromObjectCache(wrappedEntity);
			return result;
		}

		// Token: 0x060038C9 RID: 14537
		internal abstract bool RemoveFromLocalCache(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity, bool resetIsLoaded, bool preserveForeignKey);

		// Token: 0x060038CA RID: 14538
		internal abstract bool RemoveFromObjectCache(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity);

		// Token: 0x060038CB RID: 14539 RVA: 0x000BA334 File Offset: 0x000B8534
		internal virtual bool VerifyEntityForAdd(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity, bool relationshipAlreadyExists)
		{
			if (relationshipAlreadyExists && this.ContainsEntity(wrappedEntity))
			{
				return false;
			}
			this.VerifyType(wrappedEntity);
			return true;
		}

		// Token: 0x060038CC RID: 14540
		internal abstract void VerifyType(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity);

		// Token: 0x060038CD RID: 14541
		internal abstract bool CanSetEntityType(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity);

		// Token: 0x060038CE RID: 14542
		internal abstract void Include(bool addRelationshipAsUnchanged, bool doAttach);

		// Token: 0x060038CF RID: 14543
		internal abstract void Exclude();

		// Token: 0x060038D0 RID: 14544
		internal abstract void ClearCollectionOrRef(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity, global::System.Data.Entity.Core.Objects.DataClasses.RelationshipNavigation navigation, bool doCascadeDelete);

		// Token: 0x060038D1 RID: 14545
		internal abstract bool ContainsEntity(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity);

		// Token: 0x060038D2 RID: 14546
		internal abstract global::System.Collections.IEnumerable GetInternalEnumerable();

		// Token: 0x060038D3 RID: 14547
		internal abstract global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper> GetWrappedEntities();

		// Token: 0x060038D4 RID: 14548
		internal abstract void RetrieveReferentialConstraintProperties(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.KeyValuePair<object, global::System.Data.Entity.Core.Objects.IntBox>> keyValues, global::System.Collections.Generic.HashSet<object> visited);

		// Token: 0x060038D5 RID: 14549
		internal abstract bool IsEmpty();

		// Token: 0x060038D6 RID: 14550
		internal abstract void OnRelatedEndClear();

		// Token: 0x060038D7 RID: 14551
		internal abstract void ClearWrappedValues();

		// Token: 0x060038D8 RID: 14552
		internal abstract void VerifyMultiplicityConstraintsForAdd(bool applyConstraints);

		// Token: 0x060038D9 RID: 14553 RVA: 0x000BA34C File Offset: 0x000B854C
		internal virtual void OnAssociationChanged(global::System.ComponentModel.CollectionChangeAction collectionChangeAction, object entity)
		{
			if (!this._suppressEvents && this._onAssociationChanged != null)
			{
				this._onAssociationChanged(this, new global::System.ComponentModel.CollectionChangeEventArgs(collectionChangeAction, entity));
			}
		}

		// Token: 0x060038DA RID: 14554 RVA: 0x000BA374 File Offset: 0x000B8574
		internal virtual void AddEntityToObjectStateManager(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity, bool doAttach)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet targetEntitySetFromRelationshipSet = this.GetTargetEntitySetFromRelationshipSet();
			if (!doAttach)
			{
				this._context.AddSingleObject(targetEntitySetFromRelationshipSet, wrappedEntity, "entity");
				return;
			}
			this._context.AttachSingleObject(wrappedEntity, targetEntitySetFromRelationshipSet);
		}

		// Token: 0x060038DB RID: 14555 RVA: 0x000BA3AC File Offset: 0x000B85AC
		internal global::System.Data.Entity.Core.Metadata.Edm.EntitySet GetTargetEntitySetFromRelationshipSet()
		{
			global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet = (global::System.Data.Entity.Core.Metadata.Edm.AssociationSet)this._relationshipSet;
			global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember = (global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember)this.ToEndMember;
			return associationSet.AssociationSetEnds[associationEndMember.Name].EntitySet;
		}

		// Token: 0x060038DC RID: 14556 RVA: 0x000BA3E8 File Offset: 0x000B85E8
		private global::System.Data.Entity.Core.Objects.RelationshipEntry AddRelationshipToObjectStateManager(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity, bool addRelationshipAsUnchanged, bool doAttach)
		{
			global::System.Data.Entity.Core.EntityKey entityKey = this._wrappedOwner.EntityKey;
			global::System.Data.Entity.Core.EntityKey entityKey2 = wrappedEntity.EntityKey;
			if (entityKey == null)
			{
				throw global::System.Data.Entity.Resources.Error.EntityKey_UnexpectedNull();
			}
			if (entityKey2 == null)
			{
				throw global::System.Data.Entity.Resources.Error.EntityKey_UnexpectedNull();
			}
			return this.ObjectContext.ObjectStateManager.AddRelation(new global::System.Data.Entity.Core.Objects.RelationshipWrapper((global::System.Data.Entity.Core.Metadata.Edm.AssociationSet)this._relationshipSet, new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.EntityKey>(this._navigation.From, entityKey), new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.EntityKey>(this._navigation.To, entityKey2)), (addRelationshipAsUnchanged || doAttach) ? global::System.Data.Entity.EntityState.Unchanged : global::System.Data.Entity.EntityState.Added);
		}

		// Token: 0x060038DD RID: 14557 RVA: 0x000BA468 File Offset: 0x000B8668
		private static void WalkObjectGraphToIncludeAllRelatedEntities(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity, bool addRelationshipAsUnchanged, bool doAttach)
		{
			foreach (global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd in wrappedEntity.RelationshipManager.Relationships)
			{
				relatedEnd.Include(addRelationshipAsUnchanged, doAttach);
			}
		}

		// Token: 0x060038DE RID: 14558 RVA: 0x000BA4BC File Offset: 0x000B86BC
		internal static void RemoveEntityFromObjectStateManager(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity)
		{
			global::System.Data.Entity.Core.Objects.EntityEntry entityEntry;
			if (wrappedEntity.Context != null && wrappedEntity.Context.ObjectStateManager.TransactionManager.IsAttachTracking && wrappedEntity.Context.ObjectStateManager.TransactionManager.PromotedKeyEntries.TryGetValue(wrappedEntity.Entity, out entityEntry))
			{
				entityEntry.DegradeEntry();
				return;
			}
			entityEntry = global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd.MarkEntityAsDeletedInObjectStateManager(wrappedEntity);
			if (entityEntry != null && entityEntry.State != global::System.Data.Entity.EntityState.Detached)
			{
				entityEntry.AcceptChanges();
			}
		}

		// Token: 0x060038DF RID: 14559 RVA: 0x000BA52C File Offset: 0x000B872C
		private static void RemoveRelationshipFromObjectStateManager(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity, global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedOwner, global::System.Data.Entity.Core.Metadata.Edm.RelationshipSet relationshipSet, global::System.Data.Entity.Core.Objects.DataClasses.RelationshipNavigation navigation)
		{
			global::System.Data.Entity.Core.Objects.RelationshipEntry relationshipEntry = global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd.MarkRelationshipAsDeletedInObjectStateManager(wrappedEntity, wrappedOwner, relationshipSet, navigation);
			if (relationshipEntry != null && relationshipEntry.State != global::System.Data.Entity.EntityState.Detached)
			{
				relationshipEntry.AcceptChanges();
			}
		}

		// Token: 0x060038E0 RID: 14560 RVA: 0x000BA555 File Offset: 0x000B8755
		private void FixupOtherEndOfRelationshipForRemove(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity, bool preserveForeignKey)
		{
			global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd otherEndOfRelationship = this.GetOtherEndOfRelationship(wrappedEntity);
			otherEndOfRelationship.Remove(this._wrappedOwner, false, false, false, false, preserveForeignKey);
			otherEndOfRelationship.RemoveFromNavigationProperty(this._wrappedOwner);
		}

		// Token: 0x060038E1 RID: 14561 RVA: 0x000BA57C File Offset: 0x000B877C
		private static global::System.Data.Entity.Core.Objects.EntityEntry MarkEntityAsDeletedInObjectStateManager(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity)
		{
			global::System.Data.Entity.Core.Objects.EntityEntry entityEntry = null;
			if (wrappedEntity.Context != null)
			{
				entityEntry = wrappedEntity.Context.ObjectStateManager.FindEntityEntry(wrappedEntity.Entity);
				if (entityEntry != null)
				{
					entityEntry.Delete(false);
				}
			}
			return entityEntry;
		}

		// Token: 0x060038E2 RID: 14562 RVA: 0x000BA5B8 File Offset: 0x000B87B8
		private static global::System.Data.Entity.Core.Objects.RelationshipEntry MarkRelationshipAsDeletedInObjectStateManager(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity, global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedOwner, global::System.Data.Entity.Core.Metadata.Edm.RelationshipSet relationshipSet, global::System.Data.Entity.Core.Objects.DataClasses.RelationshipNavigation navigation)
		{
			global::System.Data.Entity.Core.Objects.RelationshipEntry result = null;
			if (wrappedOwner.Context != null && wrappedEntity.Context != null && relationshipSet != null)
			{
				global::System.Data.Entity.Core.EntityKey entityKey = wrappedOwner.EntityKey;
				global::System.Data.Entity.Core.EntityKey entityKey2 = wrappedEntity.EntityKey;
				result = wrappedEntity.Context.ObjectStateManager.DeleteRelationship(relationshipSet, new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.EntityKey>(navigation.From, entityKey), new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.EntityKey>(navigation.To, entityKey2));
			}
			return result;
		}

		// Token: 0x060038E3 RID: 14563 RVA: 0x000BA614 File Offset: 0x000B8814
		private static void DetachRelationshipFromObjectStateManager(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity, global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedOwner, global::System.Data.Entity.Core.Metadata.Edm.RelationshipSet relationshipSet, global::System.Data.Entity.Core.Objects.DataClasses.RelationshipNavigation navigation)
		{
			if (wrappedOwner.Context != null && wrappedEntity.Context != null && relationshipSet != null)
			{
				global::System.Data.Entity.Core.EntityKey entityKey = wrappedOwner.EntityKey;
				global::System.Data.Entity.Core.EntityKey entityKey2 = wrappedEntity.EntityKey;
				global::System.Data.Entity.Core.Objects.RelationshipEntry relationshipEntry = wrappedEntity.Context.ObjectStateManager.FindRelationship(relationshipSet, new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.EntityKey>(navigation.From, entityKey), new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.EntityKey>(navigation.To, entityKey2));
				if (relationshipEntry != null)
				{
					relationshipEntry.DetachRelationshipEntry();
				}
			}
		}

		// Token: 0x060038E4 RID: 14564 RVA: 0x000BA678 File Offset: 0x000B8878
		private static void RemoveEntityFromRelatedEnds(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity1, global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity2, global::System.Data.Entity.Core.Objects.DataClasses.RelationshipNavigation navigation)
		{
			foreach (global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd in wrappedEntity1.RelationshipManager.Relationships)
			{
				bool doCascadeDelete = global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd.CheckCascadeDeleteFlag(relatedEnd.FromEndMember) || relatedEnd.IsPrincipalEndOfReferentialConstraint();
				relatedEnd.Clear(wrappedEntity2, navigation, doCascadeDelete);
			}
		}

		// Token: 0x060038E5 RID: 14565 RVA: 0x000BA6E8 File Offset: 0x000B88E8
		private static bool CheckCascadeDeleteFlag(global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember relationEndProperty)
		{
			return relationEndProperty != null && relationEndProperty.DeleteBehavior == global::System.Data.Entity.Core.Metadata.Edm.OperationAction.Cascade;
		}

		// Token: 0x060038E6 RID: 14566 RVA: 0x000BA6F8 File Offset: 0x000B88F8
		internal void AttachContext(global::System.Data.Entity.Core.Objects.ObjectContext context, global::System.Data.Entity.Core.Objects.MergeOption mergeOption)
		{
			if (!this._wrappedOwner.InitializingProxyRelatedEnds)
			{
				global::System.Data.Entity.Core.EntityKey entityKey = this._wrappedOwner.EntityKey;
				if (entityKey == null)
				{
					throw global::System.Data.Entity.Resources.Error.EntityKey_UnexpectedNull();
				}
				global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = entityKey.GetEntitySet(context.MetadataWorkspace);
				this.AttachContext(context, entitySet, mergeOption);
			}
		}

		// Token: 0x060038E7 RID: 14567 RVA: 0x000BA73C File Offset: 0x000B893C
		internal void AttachContext(global::System.Data.Entity.Core.Objects.ObjectContext context, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Data.Entity.Core.Objects.MergeOption mergeOption)
		{
			global::System.Data.Entity.Core.EntityUtil.CheckArgumentMergeOption(mergeOption);
			this._wrappedOwner.RelationshipManager.NodeVisited = false;
			if (this._context == context && this._usingNoTracking == (mergeOption == global::System.Data.Entity.Core.Objects.MergeOption.NoTracking))
			{
				return;
			}
			bool flag = true;
			try
			{
				this._sourceQuery = null;
				this._context = context;
				this._entityWrapperFactory = context.EntityWrapperFactory;
				this._usingNoTracking = (mergeOption == global::System.Data.Entity.Core.Objects.MergeOption.NoTracking);
				global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType;
				global::System.Data.Entity.Core.Metadata.Edm.RelationshipSet relationshipSet;
				this.FindRelationshipSet(this._context, entitySet, out edmType, out relationshipSet);
				if (relationshipSet == null)
				{
					foreach (global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySetBase in entitySet.EntityContainer.BaseEntitySets)
					{
						global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet = entitySetBase as global::System.Data.Entity.Core.Metadata.Edm.AssociationSet;
						if (associationSet != null && associationSet.ElementType == edmType && associationSet.AssociationSetEnds[this._navigation.From].EntitySet != entitySet && associationSet.AssociationSetEnds[this._navigation.From].EntitySet.ElementType == entitySet.ElementType)
						{
							throw global::System.Data.Entity.Resources.Error.RelatedEnd_EntitySetIsNotValidForRelationship(entitySet.EntityContainer.Name, entitySet.Name, this._navigation.From, entitySetBase.EntityContainer.Name, entitySetBase.Name);
						}
					}
					throw global::System.Data.Entity.Resources.Error.Collections_NoRelationshipSetMatched(this._navigation.RelationshipName);
				}
				this._relationshipSet = relationshipSet;
				this._relationMetadata = (global::System.Data.Entity.Core.Metadata.Edm.RelationshipType)edmType;
				bool flag2 = false;
				bool flag3 = false;
				foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember in ((global::System.Data.Entity.Core.Metadata.Edm.AssociationType)this._relationMetadata).AssociationEndMembers)
				{
					if (associationEndMember.Name == this._navigation.From)
					{
						flag2 = true;
						this._fromEndMember = associationEndMember;
					}
					if (associationEndMember.Name == this._navigation.To)
					{
						flag3 = true;
						this._toEndMember = associationEndMember;
					}
				}
				if (!flag2 || !flag3)
				{
					throw global::System.Data.Entity.Resources.Error.RelatedEnd_RelatedEndNotFound();
				}
				this.ValidateDetachedEntityKey();
				flag = false;
			}
			finally
			{
				if (flag)
				{
					this.DetachContext();
				}
			}
		}

		// Token: 0x060038E8 RID: 14568 RVA: 0x000BA9A0 File Offset: 0x000B8BA0
		internal virtual void ValidateDetachedEntityKey()
		{
		}

		// Token: 0x060038E9 RID: 14569 RVA: 0x000BA9A4 File Offset: 0x000B8BA4
		internal void FindRelationshipSet(global::System.Data.Entity.Core.Objects.ObjectContext context, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, out global::System.Data.Entity.Core.Metadata.Edm.EdmType relationshipType, out global::System.Data.Entity.Core.Metadata.Edm.RelationshipSet relationshipSet)
		{
			if (this._navigation.AssociationType == null || this._navigation.AssociationType.Index < 0)
			{
				global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd.FindRelationshipSet(context, this._navigation, entitySet, out relationshipType, out relationshipSet);
				return;
			}
			global::System.Data.Entity.Core.Metadata.Edm.MetadataOptimization metadataOptimization = context.MetadataWorkspace.MetadataOptimization;
			global::System.Data.Entity.Core.Metadata.Edm.AssociationType cspaceAssociationType = metadataOptimization.GetCSpaceAssociationType(this._navigation.AssociationType);
			relationshipType = cspaceAssociationType;
			relationshipSet = metadataOptimization.FindCSpaceAssociationSet(cspaceAssociationType, this._navigation.From, entitySet);
		}

		// Token: 0x060038EA RID: 14570 RVA: 0x000BAA1C File Offset: 0x000B8C1C
		internal static void FindRelationshipSet(global::System.Data.Entity.Core.Objects.ObjectContext context, global::System.Data.Entity.Core.Objects.DataClasses.RelationshipNavigation navigation, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, out global::System.Data.Entity.Core.Metadata.Edm.EdmType relationshipType, out global::System.Data.Entity.Core.Metadata.Edm.RelationshipSet relationshipSet)
		{
			relationshipType = context.MetadataWorkspace.GetItem<global::System.Data.Entity.Core.Metadata.Edm.EdmType>(navigation.RelationshipName, global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace);
			if (relationshipType == null)
			{
				throw global::System.Data.Entity.Resources.Error.Collections_NoRelationshipSetMatched(navigation.RelationshipName);
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet in entitySet.AssociationSets)
			{
				if (associationSet.ElementType == relationshipType && associationSet.AssociationSetEnds[navigation.From].EntitySet == entitySet)
				{
					relationshipSet = associationSet;
					return;
				}
			}
			relationshipSet = null;
		}

		// Token: 0x060038EB RID: 14571 RVA: 0x000BAAB4 File Offset: 0x000B8CB4
		internal void DetachContext()
		{
			if (this._context != null && this.ObjectContext.ObjectStateManager.TransactionManager.IsAttachTracking)
			{
				global::System.Data.Entity.Core.Objects.MergeOption? originalMergeOption = this.ObjectContext.ObjectStateManager.TransactionManager.OriginalMergeOption;
				global::System.Data.Entity.Core.Objects.MergeOption mergeOption = global::System.Data.Entity.Core.Objects.MergeOption.NoTracking;
				if (originalMergeOption.GetValueOrDefault() == mergeOption & originalMergeOption != null)
				{
					this._usingNoTracking = true;
					return;
				}
			}
			this._sourceQuery = null;
			this._context = null;
			this._relationshipSet = null;
			this._fromEndMember = null;
			this._toEndMember = null;
			this._relationMetadata = null;
			this._isLoaded = false;
		}

		// Token: 0x060038EC RID: 14572 RVA: 0x000BAB45 File Offset: 0x000B8D45
		internal global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd GetOtherEndOfRelationship(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity)
		{
			this.EnsureRelationshipNavigationAccessorsInitialized();
			return wrappedEntity.RelationshipManager.GetRelatedEnd(this._navigation.Reverse, this._relationshipFixer);
		}

		// Token: 0x060038ED RID: 14573 RVA: 0x000BAB69 File Offset: 0x000B8D69
		internal virtual void CheckOwnerNull()
		{
			if (this._wrappedOwner.Entity == null)
			{
				throw global::System.Data.Entity.Resources.Error.RelatedEnd_OwnerIsNull();
			}
		}

		// Token: 0x060038EE RID: 14574 RVA: 0x000BAB7E File Offset: 0x000B8D7E
		internal void InitializeRelatedEnd(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedOwner, global::System.Data.Entity.Core.Objects.DataClasses.RelationshipNavigation navigation, global::System.Data.Entity.Core.Objects.DataClasses.IRelationshipFixer relationshipFixer)
		{
			this.SetWrappedOwner(wrappedOwner);
			this._navigation = navigation;
			this._relationshipFixer = relationshipFixer;
		}

		// Token: 0x060038EF RID: 14575 RVA: 0x000BAB95 File Offset: 0x000B8D95
		internal void SetWrappedOwner(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedOwner)
		{
			this._wrappedOwner = ((wrappedOwner != null) ? wrappedOwner : global::System.Data.Entity.Core.Objects.Internal.NullEntityWrapper.NullWrapper);
			this._owner = (wrappedOwner.Entity as global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithRelationships);
		}

		// Token: 0x060038F0 RID: 14576 RVA: 0x000BABB9 File Offset: 0x000B8DB9
		internal static bool IsValidEntityKeyType(global::System.Data.Entity.Core.EntityKey entityKey)
		{
			return !entityKey.IsTemporary && global::System.Data.Entity.Core.EntityKey.EntityNotValidKey != entityKey && global::System.Data.Entity.Core.EntityKey.NoEntitySetKey != entityKey;
		}

		// Token: 0x060038F1 RID: 14577 RVA: 0x000BABD8 File Offset: 0x000B8DD8
		[global::System.Runtime.Serialization.OnDeserialized]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void OnDeserialized(global::System.Runtime.Serialization.StreamingContext context)
		{
			this._wrappedOwner = this.EntityWrapperFactory.WrapEntityUsingContext(this._owner, this.ObjectContext);
		}

		// Token: 0x17000AE6 RID: 2790
		// (get) Token: 0x060038F2 RID: 14578 RVA: 0x000BABF8 File Offset: 0x000B8DF8
		internal global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty NavigationProperty
		{
			get
			{
				if (this.navigationPropertyCache == null && this._wrappedOwner.Context != null && this.TargetAccessor.HasProperty)
				{
					string propertyName = this.TargetAccessor.PropertyName;
					global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navigationProperty;
					if (!this._wrappedOwner.Context.MetadataWorkspace.GetItem<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(this._wrappedOwner.IdentityType.FullNameWithNesting(), global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OSpace).NavigationProperties.TryGetValue(propertyName, false, out navigationProperty))
					{
						throw global::System.Data.Entity.Resources.Error.RelationshipManager_NavigationPropertyNotFound(propertyName);
					}
					this.navigationPropertyCache = navigationProperty;
				}
				return this.navigationPropertyCache;
			}
		}

		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x060038F3 RID: 14579 RVA: 0x000BAC7D File Offset: 0x000B8E7D
		internal global::System.Data.Entity.Core.Metadata.Edm.NavigationPropertyAccessor TargetAccessor
		{
			get
			{
				if (this._wrappedOwner.Entity != null)
				{
					this.EnsureRelationshipNavigationAccessorsInitialized();
					return this.RelationshipNavigation.ToPropertyAccessor;
				}
				return global::System.Data.Entity.Core.Metadata.Edm.NavigationPropertyAccessor.NoNavigationProperty;
			}
		}

		// Token: 0x060038F4 RID: 14580 RVA: 0x000BACA4 File Offset: 0x000B8EA4
		private void EnsureRelationshipNavigationAccessorsInitialized()
		{
			if (!this.RelationshipNavigation.IsInitialized)
			{
				global::System.Data.Entity.Core.Metadata.Edm.NavigationPropertyAccessor navigationPropertyAccessor = null;
				global::System.Data.Entity.Core.Metadata.Edm.NavigationPropertyAccessor navigationPropertyAccessor2 = null;
				string relationshipName = this._navigation.RelationshipName;
				string from = this._navigation.From;
				string to = this._navigation.To;
				global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType = (this.RelationMetadata as global::System.Data.Entity.Core.Metadata.Edm.AssociationType) ?? this._wrappedOwner.RelationshipManager.GetRelationshipType(relationshipName);
				global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember end;
				if (associationType.AssociationEndMembers.TryGetValue(from, false, out end))
				{
					navigationPropertyAccessor2 = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetNavigationPropertyAccessor(global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetEntityTypeForEnd(end), relationshipName, from, to);
				}
				global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember end2;
				if (associationType.AssociationEndMembers.TryGetValue(to, false, out end2))
				{
					navigationPropertyAccessor = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetNavigationPropertyAccessor(global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetEntityTypeForEnd(end2), relationshipName, to, from);
				}
				if (navigationPropertyAccessor == null || navigationPropertyAccessor2 == null)
				{
					throw global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager.UnableToGetMetadata(this.WrappedOwner, relationshipName);
				}
				this.RelationshipNavigation.InitializeAccessors(navigationPropertyAccessor, navigationPropertyAccessor2);
			}
		}

		// Token: 0x060038F5 RID: 14581 RVA: 0x000BAD6E File Offset: 0x000B8F6E
		internal bool DisableLazyLoading()
		{
			if (this._context == null)
			{
				return false;
			}
			bool lazyLoadingEnabled = this._context.ContextOptions.LazyLoadingEnabled;
			this._context.ContextOptions.LazyLoadingEnabled = false;
			return lazyLoadingEnabled;
		}

		// Token: 0x060038F6 RID: 14582 RVA: 0x000BAD9B File Offset: 0x000B8F9B
		internal void ResetLazyLoading(bool state)
		{
			if (this._context != null)
			{
				this._context.ContextOptions.LazyLoadingEnabled = state;
			}
		}

		// Token: 0x040012EE RID: 4846
		private const string _entityKeyParamName = "EntityKeyValue";

		// Token: 0x040012EF RID: 4847
		[global::System.Obsolete]
		private global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithRelationships _owner;

		// Token: 0x040012F0 RID: 4848
		private global::System.Data.Entity.Core.Objects.DataClasses.RelationshipNavigation _navigation;

		// Token: 0x040012F1 RID: 4849
		private global::System.Data.Entity.Core.Objects.DataClasses.IRelationshipFixer _relationshipFixer;

		// Token: 0x040012F2 RID: 4850
		internal bool _isLoaded;

		// Token: 0x040012F3 RID: 4851
		[global::System.NonSerialized]
		private global::System.Data.Entity.Core.Metadata.Edm.RelationshipSet _relationshipSet;

		// Token: 0x040012F4 RID: 4852
		[global::System.NonSerialized]
		private global::System.Data.Entity.Core.Objects.ObjectContext _context;

		// Token: 0x040012F5 RID: 4853
		[global::System.NonSerialized]
		private bool _usingNoTracking;

		// Token: 0x040012F6 RID: 4854
		[global::System.NonSerialized]
		private global::System.Data.Entity.Core.Metadata.Edm.RelationshipType _relationMetadata;

		// Token: 0x040012F7 RID: 4855
		[global::System.NonSerialized]
		private global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember _fromEndMember;

		// Token: 0x040012F8 RID: 4856
		[global::System.NonSerialized]
		private global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember _toEndMember;

		// Token: 0x040012F9 RID: 4857
		[global::System.NonSerialized]
		private string _sourceQuery;

		// Token: 0x040012FA RID: 4858
		[global::System.NonSerialized]
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> _sourceQueryParamProperties;

		// Token: 0x040012FB RID: 4859
		[global::System.NonSerialized]
		internal bool _suppressEvents;

		// Token: 0x040012FC RID: 4860
		[global::System.NonSerialized]
		internal global::System.ComponentModel.CollectionChangeEventHandler _onAssociationChanged;

		// Token: 0x040012FD RID: 4861
		[global::System.NonSerialized]
		private global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper _wrappedOwner;

		// Token: 0x040012FE RID: 4862
		[global::System.NonSerialized]
		private global::System.Data.Entity.Core.Objects.Internal.EntityWrapperFactory _entityWrapperFactory;

		// Token: 0x040012FF RID: 4863
		[global::System.NonSerialized]
		private global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navigationPropertyCache;
	}
}
