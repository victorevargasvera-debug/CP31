using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping.ViewGeneration;
using System.Data.Entity.Core.Mapping.ViewGeneration.Structures;
using System.Data.Entity.Core.Mapping.ViewGeneration.Validation;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x02000529 RID: 1321
	public class EntityContainerMapping : global::System.Data.Entity.Core.Mapping.MappingBase
	{
		// Token: 0x06004133 RID: 16691 RVA: 0x000DBFB4 File Offset: 0x000DA1B4
		public EntityContainerMapping(global::System.Data.Entity.Core.Metadata.Edm.EntityContainer conceptualEntityContainer, global::System.Data.Entity.Core.Metadata.Edm.EntityContainer storeEntityContainer, global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection mappingItemCollection, bool generateUpdateViews) : this(conceptualEntityContainer, storeEntityContainer, mappingItemCollection, true, generateUpdateViews)
		{
		}

		// Token: 0x06004134 RID: 16692 RVA: 0x000DBFC4 File Offset: 0x000DA1C4
		internal EntityContainerMapping(global::System.Data.Entity.Core.Metadata.Edm.EntityContainer entityContainer, global::System.Data.Entity.Core.Metadata.Edm.EntityContainer storageEntityContainer, global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection storageMappingItemCollection, bool validate, bool generateUpdateViews)
		{
			this.m_entitySetMappings = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping>(global::System.StringComparer.Ordinal);
			this.m_associationSetMappings = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping>(global::System.StringComparer.Ordinal);
			this.m_functionImportMappings = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction, global::System.Data.Entity.Core.Mapping.FunctionImportMapping>();
			base..ctor(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.MetadataFlags.CSSpace);
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer>(entityContainer, "entityContainer");
			this.m_entityContainer = entityContainer;
			this.m_storageEntityContainer = storageEntityContainer;
			this.m_storageMappingItemCollection = storageMappingItemCollection;
			this.m_memoizedCellGroupEvaluator = new global::System.Data.Entity.Core.Common.Utils.Memoizer<global::System.Data.Entity.Core.Mapping.InputForComputingCellGroups, global::System.Data.Entity.Core.Mapping.OutputFromComputeCellGroups>(new global::System.Func<global::System.Data.Entity.Core.Mapping.InputForComputingCellGroups, global::System.Data.Entity.Core.Mapping.OutputFromComputeCellGroups>(this.ComputeCellGroups), default(global::System.Data.Entity.Core.Mapping.InputForComputingCellGroups));
			this.identity = entityContainer.Identity;
			this.m_validate = validate;
			this.m_generateUpdateViews = generateUpdateViews;
		}

		// Token: 0x06004135 RID: 16693 RVA: 0x000DC065 File Offset: 0x000DA265
		internal EntityContainerMapping(global::System.Data.Entity.Core.Metadata.Edm.EntityContainer entityContainer) : this(entityContainer, null, null, false, false)
		{
		}

		// Token: 0x06004136 RID: 16694 RVA: 0x000DC072 File Offset: 0x000DA272
		internal EntityContainerMapping()
		{
			this.m_entitySetMappings = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping>(global::System.StringComparer.Ordinal);
			this.m_associationSetMappings = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping>(global::System.StringComparer.Ordinal);
			this.m_functionImportMappings = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction, global::System.Data.Entity.Core.Mapping.FunctionImportMapping>();
			base..ctor();
		}

		// Token: 0x17000CC3 RID: 3267
		// (get) Token: 0x06004137 RID: 16695 RVA: 0x000DC0A5 File Offset: 0x000DA2A5
		public global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection MappingItemCollection
		{
			get
			{
				return this.m_storageMappingItemCollection;
			}
		}

		// Token: 0x17000CC4 RID: 3268
		// (get) Token: 0x06004138 RID: 16696 RVA: 0x000DC0AD File Offset: 0x000DA2AD
		internal global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection StorageMappingItemCollection
		{
			get
			{
				return this.MappingItemCollection;
			}
		}

		// Token: 0x17000CC5 RID: 3269
		// (get) Token: 0x06004139 RID: 16697 RVA: 0x000DC0B5 File Offset: 0x000DA2B5
		public override global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind
		{
			get
			{
				return global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.MetadataItem;
			}
		}

		// Token: 0x17000CC6 RID: 3270
		// (get) Token: 0x0600413A RID: 16698 RVA: 0x000DC0B9 File Offset: 0x000DA2B9
		internal override global::System.Data.Entity.Core.Metadata.Edm.MetadataItem EdmItem
		{
			get
			{
				return this.m_entityContainer;
			}
		}

		// Token: 0x17000CC7 RID: 3271
		// (get) Token: 0x0600413B RID: 16699 RVA: 0x000DC0C1 File Offset: 0x000DA2C1
		internal override string Identity
		{
			get
			{
				return this.identity;
			}
		}

		// Token: 0x17000CC8 RID: 3272
		// (get) Token: 0x0600413C RID: 16700 RVA: 0x000DC0C9 File Offset: 0x000DA2C9
		internal bool IsEmpty
		{
			get
			{
				return this.m_entitySetMappings.Count == 0 && this.m_associationSetMappings.Count == 0;
			}
		}

		// Token: 0x17000CC9 RID: 3273
		// (get) Token: 0x0600413D RID: 16701 RVA: 0x000DC0E8 File Offset: 0x000DA2E8
		internal bool HasViews
		{
			get
			{
				if (!this.HasMappingFragments())
				{
					return this.AllSetMaps.Any((global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping setMap) => setMap.QueryView != null);
				}
				return true;
			}
		}

		// Token: 0x17000CCA RID: 3274
		// (get) Token: 0x0600413E RID: 16702 RVA: 0x000DC11E File Offset: 0x000DA31E
		// (set) Token: 0x0600413F RID: 16703 RVA: 0x000DC126 File Offset: 0x000DA326
		internal string SourceLocation { get; set; }

		// Token: 0x17000CCB RID: 3275
		// (get) Token: 0x06004140 RID: 16704 RVA: 0x000DC12F File Offset: 0x000DA32F
		public global::System.Data.Entity.Core.Metadata.Edm.EntityContainer ConceptualEntityContainer
		{
			get
			{
				return this.m_entityContainer;
			}
		}

		// Token: 0x17000CCC RID: 3276
		// (get) Token: 0x06004141 RID: 16705 RVA: 0x000DC137 File Offset: 0x000DA337
		internal global::System.Data.Entity.Core.Metadata.Edm.EntityContainer EdmEntityContainer
		{
			get
			{
				return this.ConceptualEntityContainer;
			}
		}

		// Token: 0x17000CCD RID: 3277
		// (get) Token: 0x06004142 RID: 16706 RVA: 0x000DC13F File Offset: 0x000DA33F
		public global::System.Data.Entity.Core.Metadata.Edm.EntityContainer StoreEntityContainer
		{
			get
			{
				return this.m_storageEntityContainer;
			}
		}

		// Token: 0x17000CCE RID: 3278
		// (get) Token: 0x06004143 RID: 16707 RVA: 0x000DC147 File Offset: 0x000DA347
		internal global::System.Data.Entity.Core.Metadata.Edm.EntityContainer StorageEntityContainer
		{
			get
			{
				return this.StoreEntityContainer;
			}
		}

		// Token: 0x17000CCF RID: 3279
		// (get) Token: 0x06004144 RID: 16708 RVA: 0x000DC14F File Offset: 0x000DA34F
		internal global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping> EntitySetMaps
		{
			get
			{
				return new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping>(new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping>(this.m_entitySetMappings.Values));
			}
		}

		// Token: 0x17000CD0 RID: 3280
		// (get) Token: 0x06004145 RID: 16709 RVA: 0x000DC166 File Offset: 0x000DA366
		public virtual global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.EntitySetMapping> EntitySetMappings
		{
			get
			{
				return this.EntitySetMaps.OfType<global::System.Data.Entity.Core.Mapping.EntitySetMapping>();
			}
		}

		// Token: 0x17000CD1 RID: 3281
		// (get) Token: 0x06004146 RID: 16710 RVA: 0x000DC173 File Offset: 0x000DA373
		public virtual global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.AssociationSetMapping> AssociationSetMappings
		{
			get
			{
				return this.RelationshipSetMaps.OfType<global::System.Data.Entity.Core.Mapping.AssociationSetMapping>();
			}
		}

		// Token: 0x17000CD2 RID: 3282
		// (get) Token: 0x06004147 RID: 16711 RVA: 0x000DC180 File Offset: 0x000DA380
		public global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.FunctionImportMapping> FunctionImportMappings
		{
			get
			{
				return this.m_functionImportMappings.Values;
			}
		}

		// Token: 0x17000CD3 RID: 3283
		// (get) Token: 0x06004148 RID: 16712 RVA: 0x000DC18D File Offset: 0x000DA38D
		internal global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping> RelationshipSetMaps
		{
			get
			{
				return new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping>(new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping>(this.m_associationSetMappings.Values));
			}
		}

		// Token: 0x17000CD4 RID: 3284
		// (get) Token: 0x06004149 RID: 16713 RVA: 0x000DC1A4 File Offset: 0x000DA3A4
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping> AllSetMaps
		{
			get
			{
				return this.m_entitySetMappings.Values.Concat(this.m_associationSetMappings.Values);
			}
		}

		// Token: 0x17000CD5 RID: 3285
		// (get) Token: 0x0600414A RID: 16714 RVA: 0x000DC1C1 File Offset: 0x000DA3C1
		// (set) Token: 0x0600414B RID: 16715 RVA: 0x000DC1C9 File Offset: 0x000DA3C9
		internal int StartLineNumber { get; set; }

		// Token: 0x17000CD6 RID: 3286
		// (get) Token: 0x0600414C RID: 16716 RVA: 0x000DC1D2 File Offset: 0x000DA3D2
		// (set) Token: 0x0600414D RID: 16717 RVA: 0x000DC1DA File Offset: 0x000DA3DA
		internal int StartLinePosition { get; set; }

		// Token: 0x17000CD7 RID: 3287
		// (get) Token: 0x0600414E RID: 16718 RVA: 0x000DC1E3 File Offset: 0x000DA3E3
		internal bool Validate
		{
			get
			{
				return this.m_validate;
			}
		}

		// Token: 0x17000CD8 RID: 3288
		// (get) Token: 0x0600414F RID: 16719 RVA: 0x000DC1EB File Offset: 0x000DA3EB
		public bool GenerateUpdateViews
		{
			get
			{
				return this.m_generateUpdateViews;
			}
		}

		// Token: 0x06004150 RID: 16720 RVA: 0x000DC1F4 File Offset: 0x000DA3F4
		internal global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping GetEntitySetMapping(string setName)
		{
			global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping result = null;
			this.m_entitySetMappings.TryGetValue(setName, out result);
			return result;
		}

		// Token: 0x06004151 RID: 16721 RVA: 0x000DC214 File Offset: 0x000DA414
		internal global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping GetAssociationSetMapping(string setName)
		{
			global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping result = null;
			this.m_associationSetMappings.TryGetValue(setName, out result);
			return result;
		}

		// Token: 0x06004152 RID: 16722 RVA: 0x000DC234 File Offset: 0x000DA434
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.AssociationSetMapping> GetRelationshipSetMappingsFor(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase edmEntitySet, global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase storeEntitySet)
		{
			global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd, bool> <>9__2;
			return (from global::System.Data.Entity.Core.Mapping.AssociationSetMapping w in this.m_associationSetMappings.Values
			where w.StoreEntitySet != null && w.StoreEntitySet == storeEntitySet
			select w).Where(delegate(global::System.Data.Entity.Core.Mapping.AssociationSetMapping associationSetMap)
			{
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd> associationSetEnds = (associationSetMap.Set as global::System.Data.Entity.Core.Metadata.Edm.AssociationSet).AssociationSetEnds;
				global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd, bool> predicate;
				if ((predicate = <>9__2) == null)
				{
					predicate = (<>9__2 = ((global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd associationSetEnd) => associationSetEnd.EntitySet == edmEntitySet));
				}
				return associationSetEnds.Any(predicate);
			});
		}

		// Token: 0x06004153 RID: 16723 RVA: 0x000DC288 File Offset: 0x000DA488
		internal global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping GetSetMapping(string setName)
		{
			global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping entitySetBaseMapping = this.GetEntitySetMapping(setName);
			if (entitySetBaseMapping == null)
			{
				entitySetBaseMapping = this.GetAssociationSetMapping(setName);
			}
			return entitySetBaseMapping;
		}

		// Token: 0x06004154 RID: 16724 RVA: 0x000DC2AC File Offset: 0x000DA4AC
		public void AddSetMapping(global::System.Data.Entity.Core.Mapping.EntitySetMapping setMapping)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Mapping.EntitySetMapping>(setMapping, "setMapping");
			global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
			if (!this.m_entitySetMappings.ContainsKey(setMapping.Set.Name))
			{
				this.m_entitySetMappings.Add(setMapping.Set.Name, setMapping);
			}
		}

		// Token: 0x06004155 RID: 16725 RVA: 0x000DC2FA File Offset: 0x000DA4FA
		public void RemoveSetMapping(global::System.Data.Entity.Core.Mapping.EntitySetMapping setMapping)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Mapping.EntitySetMapping>(setMapping, "setMapping");
			global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
			this.m_entitySetMappings.Remove(setMapping.Set.Name);
		}

		// Token: 0x06004156 RID: 16726 RVA: 0x000DC328 File Offset: 0x000DA528
		public void AddSetMapping(global::System.Data.Entity.Core.Mapping.AssociationSetMapping setMapping)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Mapping.AssociationSetMapping>(setMapping, "setMapping");
			global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
			if (!this.m_associationSetMappings.ContainsKey(setMapping.Set.Name))
			{
				this.m_associationSetMappings.Add(setMapping.Set.Name, setMapping);
			}
		}

		// Token: 0x06004157 RID: 16727 RVA: 0x000DC376 File Offset: 0x000DA576
		public void RemoveSetMapping(global::System.Data.Entity.Core.Mapping.AssociationSetMapping setMapping)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Mapping.AssociationSetMapping>(setMapping, "setMapping");
			global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
			this.m_associationSetMappings.Remove(setMapping.Set.Name);
		}

		// Token: 0x06004158 RID: 16728 RVA: 0x000DC3A1 File Offset: 0x000DA5A1
		internal bool ContainsAssociationSetMapping(global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet)
		{
			return this.m_associationSetMappings.ContainsKey(associationSet.Name);
		}

		// Token: 0x06004159 RID: 16729 RVA: 0x000DC3B4 File Offset: 0x000DA5B4
		public void AddFunctionImportMapping(global::System.Data.Entity.Core.Mapping.FunctionImportMapping functionImportMapping)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Mapping.FunctionImportMapping>(functionImportMapping, "functionImportMapping");
			global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
			this.m_functionImportMappings.Add(functionImportMapping.FunctionImport, functionImportMapping);
		}

		// Token: 0x0600415A RID: 16730 RVA: 0x000DC3DA File Offset: 0x000DA5DA
		public void RemoveFunctionImportMapping(global::System.Data.Entity.Core.Mapping.FunctionImportMapping functionImportMapping)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Mapping.FunctionImportMapping>(functionImportMapping, "functionImportMapping");
			global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
			this.m_functionImportMappings.Remove(functionImportMapping.FunctionImport);
		}

		// Token: 0x0600415B RID: 16731 RVA: 0x000DC400 File Offset: 0x000DA600
		internal override void SetReadOnly()
		{
			global::System.Data.Entity.Core.Mapping.MappingItem.SetReadOnly(this.m_entitySetMappings.Values);
			global::System.Data.Entity.Core.Mapping.MappingItem.SetReadOnly(this.m_associationSetMappings.Values);
			global::System.Data.Entity.Core.Mapping.MappingItem.SetReadOnly(this.m_functionImportMappings.Values);
			base.SetReadOnly();
		}

		// Token: 0x0600415C RID: 16732 RVA: 0x000DC438 File Offset: 0x000DA638
		internal bool HasQueryViewForSetMap(string setName)
		{
			global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping setMapping = this.GetSetMapping(setName);
			return setMapping != null && setMapping.QueryView != null;
		}

		// Token: 0x0600415D RID: 16733 RVA: 0x000DC45C File Offset: 0x000DA65C
		internal bool HasMappingFragments()
		{
			foreach (global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping entitySetBaseMapping in this.AllSetMaps)
			{
				using (global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Mapping.TypeMapping> enumerator2 = entitySetBaseMapping.TypeMappings.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						if (enumerator2.Current.MappingFragments.Count > 0)
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0600415E RID: 16734 RVA: 0x000DC4E8 File Offset: 0x000DA6E8
		internal virtual bool TryGetFunctionImportMapping(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction functionImport, out global::System.Data.Entity.Core.Mapping.FunctionImportMapping mapping)
		{
			return this.m_functionImportMappings.TryGetValue(functionImport, out mapping);
		}

		// Token: 0x0600415F RID: 16735 RVA: 0x000DC4F7 File Offset: 0x000DA6F7
		internal global::System.Data.Entity.Core.Mapping.OutputFromComputeCellGroups GetCellgroups(global::System.Data.Entity.Core.Mapping.InputForComputingCellGroups args)
		{
			return this.m_memoizedCellGroupEvaluator.Evaluate(args);
		}

		// Token: 0x06004160 RID: 16736 RVA: 0x000DC508 File Offset: 0x000DA708
		private global::System.Data.Entity.Core.Mapping.OutputFromComputeCellGroups ComputeCellGroups(global::System.Data.Entity.Core.Mapping.InputForComputingCellGroups args)
		{
			global::System.Data.Entity.Core.Mapping.OutputFromComputeCellGroups outputFromComputeCellGroups = default(global::System.Data.Entity.Core.Mapping.OutputFromComputeCellGroups);
			outputFromComputeCellGroups.Success = true;
			global::System.Data.Entity.Core.Mapping.ViewGeneration.CellCreator cellCreator = new global::System.Data.Entity.Core.Mapping.ViewGeneration.CellCreator(args.ContainerMapping);
			outputFromComputeCellGroups.Cells = cellCreator.GenerateCells();
			outputFromComputeCellGroups.Identifiers = cellCreator.Identifiers;
			if (outputFromComputeCellGroups.Cells.Count <= 0)
			{
				outputFromComputeCellGroups.Success = false;
				return outputFromComputeCellGroups;
			}
			outputFromComputeCellGroups.ForeignKeyConstraints = global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ForeignConstraint.GetForeignConstraints(args.ContainerMapping.StorageEntityContainer);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell>> source = new global::System.Data.Entity.Core.Mapping.ViewGeneration.CellPartitioner(outputFromComputeCellGroups.Cells, outputFromComputeCellGroups.ForeignKeyConstraints).GroupRelatedCells();
			outputFromComputeCellGroups.CellGroups = (from setOfCells in source
			select new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell>(from cell in setOfCells
			select new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell(cell))).ToList<global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell>>();
			return outputFromComputeCellGroups;
		}

		// Token: 0x04001699 RID: 5785
		private readonly string identity;

		// Token: 0x0400169A RID: 5786
		private readonly bool m_validate;

		// Token: 0x0400169B RID: 5787
		private readonly bool m_generateUpdateViews;

		// Token: 0x0400169C RID: 5788
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EntityContainer m_entityContainer;

		// Token: 0x0400169D RID: 5789
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EntityContainer m_storageEntityContainer;

		// Token: 0x0400169E RID: 5790
		private readonly global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping> m_entitySetMappings;

		// Token: 0x0400169F RID: 5791
		private readonly global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping> m_associationSetMappings;

		// Token: 0x040016A0 RID: 5792
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction, global::System.Data.Entity.Core.Mapping.FunctionImportMapping> m_functionImportMappings;

		// Token: 0x040016A1 RID: 5793
		private readonly global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection m_storageMappingItemCollection;

		// Token: 0x040016A2 RID: 5794
		private readonly global::System.Data.Entity.Core.Common.Utils.Memoizer<global::System.Data.Entity.Core.Mapping.InputForComputingCellGroups, global::System.Data.Entity.Core.Mapping.OutputFromComputeCellGroups> m_memoizedCellGroupEvaluator;
	}
}
