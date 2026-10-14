using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity.Core.Objects.Internal;
using System.Data.Entity.Hierarchy;
using System.Data.Entity.Resources;
using System.Data.Entity.Spatial;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.Core.Common.Internal.Materialization
{
	// Token: 0x0200063F RID: 1599
	internal abstract class Shaper
	{
		// Token: 0x06004CFF RID: 19711 RVA: 0x0010EDC4 File Offset: 0x0010CFC4
		internal Shaper(global::System.Data.Common.DbDataReader reader, global::System.Data.Entity.Core.Objects.ObjectContext context, global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace workspace, global::System.Data.Entity.Core.Objects.MergeOption mergeOption, int stateCount, bool streaming)
		{
			this.Reader = reader;
			this.MergeOption = mergeOption;
			this.State = new object[stateCount];
			this.Context = context;
			this.Workspace = workspace;
			this._spatialReader = new global::System.Lazy<global::System.Data.Entity.Spatial.DbSpatialDataReader>(new global::System.Func<global::System.Data.Entity.Spatial.DbSpatialDataReader>(this.CreateSpatialDataReader));
			this.Streaming = streaming;
		}

		// Token: 0x06004D00 RID: 19712 RVA: 0x0010EE24 File Offset: 0x0010D024
		public TElement Discriminate<TElement>(object[] discriminatorValues, global::System.Func<object[], global::System.Data.Entity.Core.Metadata.Edm.EntityType> discriminate, global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Func<global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper, TElement>>[] elementDelegates)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = discriminate(discriminatorValues);
			global::System.Func<global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper, TElement> func = null;
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Func<global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper, TElement>> keyValuePair in elementDelegates)
			{
				if (keyValuePair.Key == entityType)
				{
					func = keyValuePair.Value;
				}
			}
			return func(this);
		}

		// Token: 0x06004D01 RID: 19713 RVA: 0x0010EE6D File Offset: 0x0010D06D
		public global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper HandleEntityNoTracking<TEntity>(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity)
		{
			this.RegisterMaterializedEntityForEvent(wrappedEntity);
			return wrappedEntity;
		}

		// Token: 0x06004D02 RID: 19714 RVA: 0x0010EE78 File Offset: 0x0010D078
		public global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper HandleEntity<TEntity>(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity, global::System.Data.Entity.Core.EntityKey entityKey, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet)
		{
			global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper entityWrapper = wrappedEntity;
			if (entityKey != null)
			{
				global::System.Data.Entity.Core.Objects.EntityEntry entityEntry = this.Context.ObjectStateManager.FindEntityEntry(entityKey);
				if (entityEntry != null && !entityEntry.IsKeyEntry)
				{
					this.UpdateEntry<TEntity>(wrappedEntity, entityEntry);
					entityWrapper = entityEntry.WrappedEntity;
				}
				else
				{
					this.RegisterMaterializedEntityForEvent(entityWrapper);
					if (entityEntry == null)
					{
						this.Context.ObjectStateManager.AddEntry(wrappedEntity, entityKey, entitySet, "HandleEntity", false);
					}
					else
					{
						this.Context.ObjectStateManager.PromoteKeyEntry(entityEntry, wrappedEntity, false, true, false);
					}
				}
			}
			return entityWrapper;
		}

		// Token: 0x06004D03 RID: 19715 RVA: 0x0010EEF4 File Offset: 0x0010D0F4
		public global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper HandleEntityAppendOnly<TEntity>(global::System.Func<global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper, global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper> constructEntityDelegate, global::System.Data.Entity.Core.EntityKey entityKey, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet)
		{
			global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper entityWrapper;
			if (entityKey == null)
			{
				entityWrapper = constructEntityDelegate(this);
				this.RegisterMaterializedEntityForEvent(entityWrapper);
			}
			else
			{
				global::System.Data.Entity.Core.Objects.EntityEntry entityEntry = this.Context.ObjectStateManager.FindEntityEntry(entityKey);
				if (entityEntry != null && !entityEntry.IsKeyEntry)
				{
					if (typeof(TEntity) != entityEntry.WrappedEntity.IdentityType)
					{
						global::System.Data.Entity.Core.EntityKey entityKey2 = entityEntry.EntityKey;
						throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.Materializer_RecyclingEntity(global::System.Data.Entity.Core.Common.TypeHelpers.GetFullName(entityKey2.EntityContainerName, entityKey2.EntitySetName), typeof(TEntity).FullName, entityEntry.WrappedEntity.IdentityType.FullName));
					}
					if (global::System.Data.Entity.EntityState.Added == entityEntry.State)
					{
						throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.Materializer_AddedEntityAlreadyExists(typeof(TEntity).FullName));
					}
					entityWrapper = entityEntry.WrappedEntity;
				}
				else
				{
					entityWrapper = constructEntityDelegate(this);
					this.RegisterMaterializedEntityForEvent(entityWrapper);
					if (entityEntry == null)
					{
						this.Context.ObjectStateManager.AddEntry(entityWrapper, entityKey, entitySet, "HandleEntity", false);
					}
					else
					{
						this.Context.ObjectStateManager.PromoteKeyEntry(entityEntry, entityWrapper, false, true, false);
					}
				}
			}
			return entityWrapper;
		}

		// Token: 0x06004D04 RID: 19716 RVA: 0x0010F00C File Offset: 0x0010D20C
		public global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper HandleFullSpanCollection<TTargetEntity>(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity, global::System.Data.Entity.Core.Common.Internal.Materialization.Coordinator<TTargetEntity> coordinator, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember targetMember)
		{
			if (wrappedEntity.Entity != null)
			{
				coordinator.RegisterCloseHandler(delegate(global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper state, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper> spannedEntities)
				{
					this.FullSpanAction<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>(wrappedEntity, spannedEntities, targetMember);
				});
			}
			return wrappedEntity;
		}

		// Token: 0x06004D05 RID: 19717 RVA: 0x0010F05C File Offset: 0x0010D25C
		public global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper HandleFullSpanElement(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedSource, global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedSpannedEntity, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember targetMember)
		{
			if (wrappedSource.Entity == null)
			{
				return wrappedSource;
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper> list = null;
			if (wrappedSpannedEntity.Entity != null)
			{
				list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>(1);
				list.Add(wrappedSpannedEntity);
			}
			else
			{
				global::System.Data.Entity.Core.EntityKey entityKey = wrappedSource.EntityKey;
				this.CheckClearedEntryOnSpan(null, wrappedSource, entityKey, targetMember);
			}
			this.FullSpanAction<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>(wrappedSource, list, targetMember);
			return wrappedSource;
		}

		// Token: 0x06004D06 RID: 19718 RVA: 0x0010F0A8 File Offset: 0x0010D2A8
		public global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper HandleRelationshipSpan(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity, global::System.Data.Entity.Core.EntityKey targetKey, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember targetMember)
		{
			if (wrappedEntity.Entity == null)
			{
				return wrappedEntity;
			}
			global::System.Data.Entity.Core.EntityKey entityKey = wrappedEntity.EntityKey;
			global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember otherAssociationEnd = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetOtherAssociationEnd(targetMember);
			this.CheckClearedEntryOnSpan(targetKey, wrappedEntity, entityKey, targetMember);
			global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd;
			if (targetKey != null)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet;
				global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet = this.Context.MetadataWorkspace.MetadataOptimization.FindCSpaceAssociationSet((global::System.Data.Entity.Core.Metadata.Edm.AssociationType)targetMember.DeclaringType, targetMember.Name, targetKey.EntitySetName, targetKey.EntityContainerName, out entitySet);
				global::System.Data.Entity.Core.Objects.ObjectStateManager objectStateManager = this.Context.ObjectStateManager;
				global::System.Linq.ILookup<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Objects.RelationshipEntry> relationshipLookup = global::System.Data.Entity.Core.Objects.ObjectStateManager.GetRelationshipLookup(this.Context.ObjectStateManager, associationSet, otherAssociationEnd, entityKey);
				global::System.Data.Entity.EntityState entityState;
				if (!global::System.Data.Entity.Core.Objects.ObjectStateManager.TryUpdateExistingRelationships(this.Context, this.MergeOption, associationSet, otherAssociationEnd, relationshipLookup, wrappedEntity, targetMember, targetKey, true, out entityState))
				{
					global::System.Data.Entity.Core.Objects.EntityEntry entityEntry = objectStateManager.GetOrAddKeyEntry(targetKey, entitySet);
					bool flag = true;
					global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity relationshipMultiplicity = otherAssociationEnd.RelationshipMultiplicity;
					if (relationshipMultiplicity > global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One)
					{
						if (relationshipMultiplicity != global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many)
						{
						}
					}
					else
					{
						global::System.Linq.ILookup<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Objects.RelationshipEntry> relationshipLookup2 = global::System.Data.Entity.Core.Objects.ObjectStateManager.GetRelationshipLookup(this.Context.ObjectStateManager, associationSet, targetMember, targetKey);
						flag = !global::System.Data.Entity.Core.Objects.ObjectStateManager.TryUpdateExistingRelationships(this.Context, this.MergeOption, associationSet, targetMember, relationshipLookup2, entityEntry.WrappedEntity, otherAssociationEnd, entityKey, true, out entityState);
						if (entityEntry.State == global::System.Data.Entity.EntityState.Detached)
						{
							entityEntry = objectStateManager.AddKeyEntry(targetKey, entitySet);
						}
					}
					if (flag)
					{
						if (entityEntry.IsKeyEntry || entityState == global::System.Data.Entity.EntityState.Deleted)
						{
							global::System.Data.Entity.Core.Objects.RelationshipWrapper wrapper = new global::System.Data.Entity.Core.Objects.RelationshipWrapper(associationSet, otherAssociationEnd.Name, entityKey, targetMember.Name, targetKey);
							objectStateManager.AddNewRelation(wrapper, entityState);
						}
						else if (entityEntry.State != global::System.Data.Entity.EntityState.Deleted)
						{
							global::System.Data.Entity.Core.Objects.ObjectStateManager.AddEntityToCollectionOrReference(this.MergeOption, wrappedEntity, otherAssociationEnd, entityEntry.WrappedEntity, targetMember, true, false, false);
						}
						else
						{
							global::System.Data.Entity.Core.Objects.RelationshipWrapper wrapper2 = new global::System.Data.Entity.Core.Objects.RelationshipWrapper(associationSet, otherAssociationEnd.Name, entityKey, targetMember.Name, targetKey);
							objectStateManager.AddNewRelation(wrapper2, global::System.Data.Entity.EntityState.Deleted);
						}
					}
				}
			}
			else if (this.TryGetRelatedEnd(wrappedEntity, (global::System.Data.Entity.Core.Metadata.Edm.AssociationType)targetMember.DeclaringType, otherAssociationEnd.Name, targetMember.Name, out relatedEnd))
			{
				this.SetIsLoadedForSpan(relatedEnd, false);
			}
			return wrappedEntity;
		}

		// Token: 0x06004D07 RID: 19719 RVA: 0x0010F274 File Offset: 0x0010D474
		private bool TryGetRelatedEnd(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity, global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType, string sourceEndName, string targetEndName, out global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd)
		{
			global::System.Data.Entity.Core.Metadata.Edm.AssociationType ospaceAssociationType = this.Workspace.MetadataOptimization.GetOSpaceAssociationType(associationType, () => this.Workspace.GetItemCollection(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OSpace).GetItem<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>(associationType.FullName));
			global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember = null;
			global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember2 = null;
			foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember3 in ospaceAssociationType.AssociationEndMembers)
			{
				if (associationEndMember3.Name == sourceEndName)
				{
					associationEndMember = associationEndMember3;
				}
				else if (associationEndMember3.Name == targetEndName)
				{
					associationEndMember2 = associationEndMember3;
				}
			}
			if (associationEndMember != null && associationEndMember2 != null)
			{
				bool flag = false;
				global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet;
				if (wrappedEntity.EntityKey == null)
				{
					flag = true;
				}
				else if (this.Workspace.MetadataOptimization.FindCSpaceAssociationSet(associationType, sourceEndName, wrappedEntity.EntityKey.EntitySetName, wrappedEntity.EntityKey.EntityContainerName, out entitySet) != null)
				{
					flag = true;
				}
				if (flag)
				{
					relatedEnd = global::System.Data.Entity.Core.Objects.DelegateFactory.GetRelatedEnd(wrappedEntity.RelationshipManager, associationEndMember, associationEndMember2, null);
					return true;
				}
			}
			relatedEnd = null;
			return false;
		}

		// Token: 0x06004D08 RID: 19720 RVA: 0x0010F390 File Offset: 0x0010D590
		private void SetIsLoadedForSpan(global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd, bool forceToTrue)
		{
			if (!forceToTrue)
			{
				forceToTrue = relatedEnd.IsEmpty();
				global::System.Data.Entity.Core.Objects.DataClasses.EntityReference entityReference = relatedEnd as global::System.Data.Entity.Core.Objects.DataClasses.EntityReference;
				if (entityReference != null)
				{
					forceToTrue &= (entityReference.EntityKey == null);
				}
			}
			if (forceToTrue || this.MergeOption == global::System.Data.Entity.Core.Objects.MergeOption.OverwriteChanges)
			{
				relatedEnd.IsLoaded = true;
			}
		}

		// Token: 0x06004D09 RID: 19721 RVA: 0x0010F3D5 File Offset: 0x0010D5D5
		public global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper HandleIEntityWithKey<TEntity>(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet)
		{
			return this.HandleEntity<TEntity>(wrappedEntity, wrappedEntity.EntityKey, entitySet);
		}

		// Token: 0x06004D0A RID: 19722 RVA: 0x0010F3E5 File Offset: 0x0010D5E5
		public bool SetColumnValue(int recordStateSlotNumber, int ordinal, object value)
		{
			((global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState)this.State[recordStateSlotNumber]).SetColumnValue(ordinal, value);
			return true;
		}

		// Token: 0x06004D0B RID: 19723 RVA: 0x0010F3FD File Offset: 0x0010D5FD
		public bool SetEntityRecordInfo(int recordStateSlotNumber, global::System.Data.Entity.Core.EntityKey entityKey, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet)
		{
			((global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState)this.State[recordStateSlotNumber]).SetEntityRecordInfo(entityKey, entitySet);
			return true;
		}

		// Token: 0x06004D0C RID: 19724 RVA: 0x0010F415 File Offset: 0x0010D615
		public bool SetState<T>(int ordinal, T value)
		{
			this.State[ordinal] = value;
			return true;
		}

		// Token: 0x06004D0D RID: 19725 RVA: 0x0010F426 File Offset: 0x0010D626
		public T SetStatePassthrough<T>(int ordinal, T value)
		{
			this.State[ordinal] = value;
			return value;
		}

		// Token: 0x06004D0E RID: 19726 RVA: 0x0010F437 File Offset: 0x0010D637
		public TProperty GetPropertyValueWithErrorHandling<TProperty>(int ordinal, string propertyName, string typeName)
		{
			return new global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper.PropertyErrorHandlingValueReader<TProperty>(propertyName, typeName).GetValue(this.Reader, ordinal);
		}

		// Token: 0x06004D0F RID: 19727 RVA: 0x0010F44C File Offset: 0x0010D64C
		public TColumn GetColumnValueWithErrorHandling<TColumn>(int ordinal)
		{
			return new global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper.ColumnErrorHandlingValueReader<TColumn>().GetValue(this.Reader, ordinal);
		}

		// Token: 0x06004D10 RID: 19728 RVA: 0x0010F45F File Offset: 0x0010D65F
		public global::System.Data.Entity.Hierarchy.HierarchyId GetHierarchyIdColumnValue(int ordinal)
		{
			return new global::System.Data.Entity.Hierarchy.HierarchyId(this.Reader.GetValue(ordinal).ToString());
		}

		// Token: 0x06004D11 RID: 19729 RVA: 0x0010F477 File Offset: 0x0010D677
		protected virtual global::System.Data.Entity.Spatial.DbSpatialDataReader CreateSpatialDataReader()
		{
			return global::System.Data.Entity.Spatial.SpatialHelpers.CreateSpatialDataReader(this.Workspace, this.Reader);
		}

		// Token: 0x06004D12 RID: 19730 RVA: 0x0010F48A File Offset: 0x0010D68A
		public global::System.Data.Entity.Spatial.DbGeography GetGeographyColumnValue(int ordinal)
		{
			if (this.Streaming)
			{
				return this._spatialReader.Value.GetGeography(ordinal);
			}
			return (global::System.Data.Entity.Spatial.DbGeography)this.Reader.GetValue(ordinal);
		}

		// Token: 0x06004D13 RID: 19731 RVA: 0x0010F4B7 File Offset: 0x0010D6B7
		public global::System.Data.Entity.Spatial.DbGeometry GetGeometryColumnValue(int ordinal)
		{
			if (this.Streaming)
			{
				return this._spatialReader.Value.GetGeometry(ordinal);
			}
			return (global::System.Data.Entity.Spatial.DbGeometry)this.Reader.GetValue(ordinal);
		}

		// Token: 0x06004D14 RID: 19732 RVA: 0x0010F4E4 File Offset: 0x0010D6E4
		public TColumn GetSpatialColumnValueWithErrorHandling<TColumn>(int ordinal, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind spatialTypeKind)
		{
			TColumn value;
			if (spatialTypeKind == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geography)
			{
				if (this.Streaming)
				{
					value = new global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper.ColumnErrorHandlingValueReader<TColumn>((global::System.Data.Common.DbDataReader reader, int column) => (TColumn)((object)this._spatialReader.Value.GetGeography(column)), (global::System.Data.Common.DbDataReader reader, int column) => this._spatialReader.Value.GetGeography(column)).GetValue(this.Reader, ordinal);
				}
				else
				{
					value = new global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper.ColumnErrorHandlingValueReader<TColumn>((global::System.Data.Common.DbDataReader reader, int column) => (TColumn)((object)this.Reader.GetValue(column)), (global::System.Data.Common.DbDataReader reader, int column) => this.Reader.GetValue(column)).GetValue(this.Reader, ordinal);
				}
			}
			else if (this.Streaming)
			{
				value = new global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper.ColumnErrorHandlingValueReader<TColumn>((global::System.Data.Common.DbDataReader reader, int column) => (TColumn)((object)this._spatialReader.Value.GetGeometry(column)), (global::System.Data.Common.DbDataReader reader, int column) => this._spatialReader.Value.GetGeometry(column)).GetValue(this.Reader, ordinal);
			}
			else
			{
				value = new global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper.ColumnErrorHandlingValueReader<TColumn>((global::System.Data.Common.DbDataReader reader, int column) => (TColumn)((object)this.Reader.GetValue(column)), (global::System.Data.Common.DbDataReader reader, int column) => this.Reader.GetValue(column)).GetValue(this.Reader, ordinal);
			}
			return value;
		}

		// Token: 0x06004D15 RID: 19733 RVA: 0x0010F5B8 File Offset: 0x0010D7B8
		public TProperty GetSpatialPropertyValueWithErrorHandling<TProperty>(int ordinal, string propertyName, string typeName, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind spatialTypeKind)
		{
			TProperty value;
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsGeographicTypeKind(spatialTypeKind))
			{
				if (this.Streaming)
				{
					value = new global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper.PropertyErrorHandlingValueReader<TProperty>(propertyName, typeName, (global::System.Data.Common.DbDataReader reader, int column) => (TProperty)((object)this._spatialReader.Value.GetGeography(column)), (global::System.Data.Common.DbDataReader reader, int column) => this._spatialReader.Value.GetGeography(column)).GetValue(this.Reader, ordinal);
				}
				else
				{
					value = new global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper.PropertyErrorHandlingValueReader<TProperty>(propertyName, typeName, (global::System.Data.Common.DbDataReader reader, int column) => (TProperty)((object)this.Reader.GetValue(column)), (global::System.Data.Common.DbDataReader reader, int column) => this.Reader.GetValue(column)).GetValue(this.Reader, ordinal);
				}
			}
			else if (this.Streaming)
			{
				value = new global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper.PropertyErrorHandlingValueReader<TProperty>(propertyName, typeName, (global::System.Data.Common.DbDataReader reader, int column) => (TProperty)((object)this._spatialReader.Value.GetGeometry(column)), (global::System.Data.Common.DbDataReader reader, int column) => this._spatialReader.Value.GetGeometry(column)).GetValue(this.Reader, ordinal);
			}
			else
			{
				value = new global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper.PropertyErrorHandlingValueReader<TProperty>(propertyName, typeName, (global::System.Data.Common.DbDataReader reader, int column) => (TProperty)((object)this.Reader.GetValue(column)), (global::System.Data.Common.DbDataReader reader, int column) => this.Reader.GetValue(column)).GetValue(this.Reader, ordinal);
			}
			return value;
		}

		// Token: 0x06004D16 RID: 19734 RVA: 0x0010F698 File Offset: 0x0010D898
		private void CheckClearedEntryOnSpan(object targetValue, global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedSource, global::System.Data.Entity.Core.EntityKey sourceKey, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember targetMember)
		{
			if (sourceKey != null && targetValue == null && (this.MergeOption == global::System.Data.Entity.Core.Objects.MergeOption.PreserveChanges || this.MergeOption == global::System.Data.Entity.Core.Objects.MergeOption.OverwriteChanges))
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmType elementType = ((global::System.Data.Entity.Core.Metadata.Edm.RefType)global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetOtherAssociationEnd(targetMember).TypeUsage.EdmType).ElementType;
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage;
				if (!this.Context.Perspective.TryGetType(wrappedSource.IdentityType, out typeUsage) || typeUsage.EdmType.EdmEquals(elementType) || global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsSubTypeOf(typeUsage.EdmType, elementType))
				{
					this.CheckClearedEntryOnSpan(sourceKey, targetMember);
				}
			}
		}

		// Token: 0x06004D17 RID: 19735 RVA: 0x0010F718 File Offset: 0x0010D918
		private void CheckClearedEntryOnSpan(global::System.Data.Entity.Core.EntityKey sourceKey, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember targetMember)
		{
			global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember otherAssociationEnd = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetOtherAssociationEnd(targetMember);
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet;
			global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet = this.Context.MetadataWorkspace.MetadataOptimization.FindCSpaceAssociationSet((global::System.Data.Entity.Core.Metadata.Edm.AssociationType)otherAssociationEnd.DeclaringType, otherAssociationEnd.Name, sourceKey.EntitySetName, sourceKey.EntityContainerName, out entitySet);
			if (associationSet != null)
			{
				this.Context.ObjectStateManager.RemoveRelationships(this.MergeOption, associationSet, sourceKey, otherAssociationEnd);
			}
		}

		// Token: 0x06004D18 RID: 19736 RVA: 0x0010F780 File Offset: 0x0010D980
		private void FullSpanAction<TTargetEntity>(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedSource, global::System.Collections.Generic.IList<TTargetEntity> spannedEntities, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember targetMember)
		{
			if (wrappedSource.Entity != null)
			{
				global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember otherAssociationEnd = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetOtherAssociationEnd(targetMember);
				global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd;
				if (this.TryGetRelatedEnd(wrappedSource, (global::System.Data.Entity.Core.Metadata.Edm.AssociationType)targetMember.DeclaringType, otherAssociationEnd.Name, targetMember.Name, out relatedEnd))
				{
					int num = this.Context.ObjectStateManager.UpdateRelationships(this.Context, this.MergeOption, (global::System.Data.Entity.Core.Metadata.Edm.AssociationSet)relatedEnd.RelationshipSet, otherAssociationEnd, wrappedSource, targetMember, (global::System.Collections.Generic.List<TTargetEntity>)spannedEntities, true);
					this.SetIsLoadedForSpan(relatedEnd, num > 0);
				}
			}
		}

		// Token: 0x06004D19 RID: 19737 RVA: 0x0010F7FC File Offset: 0x0010D9FC
		private void UpdateEntry<TEntity>(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity, global::System.Data.Entity.Core.Objects.EntityEntry existingEntry)
		{
			global::System.Type typeFromHandle = typeof(TEntity);
			if (typeFromHandle != existingEntry.WrappedEntity.IdentityType)
			{
				global::System.Data.Entity.Core.EntityKey entityKey = existingEntry.EntityKey;
				throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.Materializer_RecyclingEntity(global::System.Data.Entity.Core.Common.TypeHelpers.GetFullName(entityKey.EntityContainerName, entityKey.EntitySetName), typeFromHandle.FullName, existingEntry.WrappedEntity.IdentityType.FullName));
			}
			if (global::System.Data.Entity.EntityState.Added == existingEntry.State)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.Materializer_AddedEntityAlreadyExists(typeFromHandle.FullName));
			}
			if (this.MergeOption != global::System.Data.Entity.Core.Objects.MergeOption.AppendOnly)
			{
				if (global::System.Data.Entity.Core.Objects.MergeOption.OverwriteChanges == this.MergeOption)
				{
					if (global::System.Data.Entity.EntityState.Deleted == existingEntry.State)
					{
						existingEntry.RevertDelete();
					}
					existingEntry.UpdateCurrentValueRecord(wrappedEntity.Entity);
					this.Context.ObjectStateManager.ForgetEntryWithConceptualNull(existingEntry, true);
					existingEntry.AcceptChanges();
					this.Context.ObjectStateManager.FixupReferencesByForeignKeys(existingEntry, true);
					return;
				}
				if (global::System.Data.Entity.EntityState.Unchanged == existingEntry.State)
				{
					existingEntry.UpdateCurrentValueRecord(wrappedEntity.Entity);
					this.Context.ObjectStateManager.ForgetEntryWithConceptualNull(existingEntry, true);
					existingEntry.AcceptChanges();
					this.Context.ObjectStateManager.FixupReferencesByForeignKeys(existingEntry, true);
					return;
				}
				if (this.Context.ContextOptions.UseLegacyPreserveChangesBehavior)
				{
					existingEntry.UpdateRecordWithoutSetModified(wrappedEntity.Entity, existingEntry.EditableOriginalValues);
					return;
				}
				existingEntry.UpdateRecordWithSetModified(wrappedEntity.Entity, existingEntry.EditableOriginalValues);
			}
		}

		// Token: 0x06004D1A RID: 19738 RVA: 0x0010F94C File Offset: 0x0010DB4C
		public void RaiseMaterializedEvents()
		{
			if (this._materializedEntities != null)
			{
				foreach (global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper entityWrapper in this._materializedEntities)
				{
					this.Context.OnObjectMaterialized(entityWrapper.Entity);
				}
				this._materializedEntities.Clear();
			}
		}

		// Token: 0x06004D1B RID: 19739 RVA: 0x0010F9B8 File Offset: 0x0010DBB8
		public void InitializeForOnMaterialize()
		{
			if (this.Context.OnMaterializedHasHandlers)
			{
				if (this._materializedEntities == null)
				{
					this._materializedEntities = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>();
					return;
				}
			}
			else if (this._materializedEntities != null)
			{
				this._materializedEntities = null;
			}
		}

		// Token: 0x06004D1C RID: 19740 RVA: 0x0010F9EA File Offset: 0x0010DBEA
		protected void RegisterMaterializedEntityForEvent(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity)
		{
			if (this._materializedEntities != null)
			{
				this._materializedEntities.Add(wrappedEntity);
			}
		}

		// Token: 0x04001B5C RID: 7004
		private global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper> _materializedEntities;

		// Token: 0x04001B5D RID: 7005
		public readonly global::System.Data.Common.DbDataReader Reader;

		// Token: 0x04001B5E RID: 7006
		public readonly object[] State;

		// Token: 0x04001B5F RID: 7007
		public readonly global::System.Data.Entity.Core.Objects.ObjectContext Context;

		// Token: 0x04001B60 RID: 7008
		public readonly global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace Workspace;

		// Token: 0x04001B61 RID: 7009
		public readonly global::System.Data.Entity.Core.Objects.MergeOption MergeOption;

		// Token: 0x04001B62 RID: 7010
		protected readonly bool Streaming;

		// Token: 0x04001B63 RID: 7011
		private readonly global::System.Lazy<global::System.Data.Entity.Spatial.DbSpatialDataReader> _spatialReader;

		// Token: 0x02000C60 RID: 3168
		internal abstract class ErrorHandlingValueReader<T>
		{
			// Token: 0x06006AE0 RID: 27360 RVA: 0x0016C064 File Offset: 0x0016A264
			protected ErrorHandlingValueReader(global::System.Func<global::System.Data.Common.DbDataReader, int, T> typedValueAccessor, global::System.Func<global::System.Data.Common.DbDataReader, int, object> untypedValueAccessor)
			{
				this.getTypedValue = typedValueAccessor;
				this.getUntypedValue = untypedValueAccessor;
			}

			// Token: 0x06006AE1 RID: 27361 RVA: 0x0016C07A File Offset: 0x0016A27A
			protected ErrorHandlingValueReader() : this(new global::System.Func<global::System.Data.Common.DbDataReader, int, T>(global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper.ErrorHandlingValueReader<T>.GetTypedValueDefault), new global::System.Func<global::System.Data.Common.DbDataReader, int, object>(global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper.ErrorHandlingValueReader<T>.GetUntypedValueDefault))
			{
			}

			// Token: 0x06006AE2 RID: 27362 RVA: 0x0016C09C File Offset: 0x0016A29C
			private static T GetTypedValueDefault(global::System.Data.Common.DbDataReader reader, int ordinal)
			{
				global::System.Type underlyingType = global::System.Nullable.GetUnderlyingType(typeof(T));
				if (underlyingType != null && underlyingType.IsEnum())
				{
					return (T)((object)global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper.ErrorHandlingValueReader<T>.GetGenericTypedValueDefaultMethod(underlyingType).Invoke(null, new object[]
					{
						reader,
						ordinal
					}));
				}
				bool flag;
				return (T)((object)global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.GetReaderMethod(typeof(T), out flag).Invoke(reader, new object[]
				{
					ordinal
				}));
			}

			// Token: 0x06006AE3 RID: 27363 RVA: 0x0016C11A File Offset: 0x0016A31A
			public static global::System.Reflection.MethodInfo GetGenericTypedValueDefaultMethod(global::System.Type underlyingType)
			{
				return typeof(global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper.ErrorHandlingValueReader<>).MakeGenericType(new global::System.Type[]
				{
					underlyingType
				}).GetOnlyDeclaredMethod("GetTypedValueDefault");
			}

			// Token: 0x06006AE4 RID: 27364 RVA: 0x0016C13F File Offset: 0x0016A33F
			private static object GetUntypedValueDefault(global::System.Data.Common.DbDataReader reader, int ordinal)
			{
				return reader.GetValue(ordinal);
			}

			// Token: 0x06006AE5 RID: 27365 RVA: 0x0016C148 File Offset: 0x0016A348
			internal T GetValue(global::System.Data.Common.DbDataReader reader, int ordinal)
			{
				if (reader.IsDBNull(ordinal))
				{
					try
					{
						return (T)((object)null);
					}
					catch (global::System.NullReferenceException)
					{
						throw this.CreateNullValueException();
					}
				}
				T result;
				try
				{
					result = this.getTypedValue(reader, ordinal);
				}
				catch (global::System.Exception e)
				{
					if (e.IsCatchableExceptionType())
					{
						object obj = this.getUntypedValue(reader, ordinal);
						global::System.Type type = (obj == null) ? null : obj.GetType();
						if (!typeof(T).IsAssignableFrom(type))
						{
							throw this.CreateWrongTypeException(type);
						}
					}
					throw;
				}
				return result;
			}

			// Token: 0x06006AE6 RID: 27366
			protected abstract global::System.Exception CreateNullValueException();

			// Token: 0x06006AE7 RID: 27367
			protected abstract global::System.Exception CreateWrongTypeException(global::System.Type resultType);

			// Token: 0x040030F8 RID: 12536
			private readonly global::System.Func<global::System.Data.Common.DbDataReader, int, T> getTypedValue;

			// Token: 0x040030F9 RID: 12537
			private readonly global::System.Func<global::System.Data.Common.DbDataReader, int, object> getUntypedValue;
		}

		// Token: 0x02000C61 RID: 3169
		private class ColumnErrorHandlingValueReader<TColumn> : global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper.ErrorHandlingValueReader<TColumn>
		{
			// Token: 0x06006AE8 RID: 27368 RVA: 0x0016C1DC File Offset: 0x0016A3DC
			internal ColumnErrorHandlingValueReader()
			{
			}

			// Token: 0x06006AE9 RID: 27369 RVA: 0x0016C1E4 File Offset: 0x0016A3E4
			internal ColumnErrorHandlingValueReader(global::System.Func<global::System.Data.Common.DbDataReader, int, TColumn> typedAccessor, global::System.Func<global::System.Data.Common.DbDataReader, int, object> untypedAccessor) : base(typedAccessor, untypedAccessor)
			{
			}

			// Token: 0x06006AEA RID: 27370 RVA: 0x0016C1EE File Offset: 0x0016A3EE
			protected override global::System.Exception CreateNullValueException()
			{
				return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.Materializer_NullReferenceCast(typeof(TColumn)));
			}

			// Token: 0x06006AEB RID: 27371 RVA: 0x0016C204 File Offset: 0x0016A404
			protected override global::System.Exception CreateWrongTypeException(global::System.Type resultType)
			{
				return global::System.Data.Entity.Core.EntityUtil.ValueInvalidCast(resultType, typeof(TColumn));
			}
		}

		// Token: 0x02000C62 RID: 3170
		private class PropertyErrorHandlingValueReader<TProperty> : global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper.ErrorHandlingValueReader<TProperty>
		{
			// Token: 0x06006AEC RID: 27372 RVA: 0x0016C216 File Offset: 0x0016A416
			internal PropertyErrorHandlingValueReader(string propertyName, string typeName)
			{
				this._propertyName = propertyName;
				this._typeName = typeName;
			}

			// Token: 0x06006AED RID: 27373 RVA: 0x0016C22C File Offset: 0x0016A42C
			internal PropertyErrorHandlingValueReader(string propertyName, string typeName, global::System.Func<global::System.Data.Common.DbDataReader, int, TProperty> typedAccessor, global::System.Func<global::System.Data.Common.DbDataReader, int, object> untypedAccessor) : base(typedAccessor, untypedAccessor)
			{
				this._propertyName = propertyName;
				this._typeName = typeName;
			}

			// Token: 0x06006AEE RID: 27374 RVA: 0x0016C245 File Offset: 0x0016A445
			protected override global::System.Exception CreateNullValueException()
			{
				return new global::System.Data.ConstraintException(global::System.Data.Entity.Resources.Strings.Materializer_SetInvalidValue(global::System.Nullable.GetUnderlyingType(typeof(TProperty)) ?? typeof(TProperty), this._typeName, this._propertyName, "null"));
			}

			// Token: 0x06006AEF RID: 27375 RVA: 0x0016C27F File Offset: 0x0016A47F
			protected override global::System.Exception CreateWrongTypeException(global::System.Type resultType)
			{
				return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.Materializer_SetInvalidValue(global::System.Nullable.GetUnderlyingType(typeof(TProperty)) ?? typeof(TProperty), this._typeName, this._propertyName, resultType));
			}

			// Token: 0x040030FA RID: 12538
			private readonly string _propertyName;

			// Token: 0x040030FB RID: 12539
			private readonly string _typeName;
		}
	}
}
