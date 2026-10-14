using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting;
using System.Data.Entity.Core.Mapping.ViewGeneration.Structures;
using System.Data.Entity.Core.Mapping.ViewGeneration.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Linq;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration
{
	// Token: 0x0200056D RID: 1389
	internal class ViewgenContext : global::System.Data.Entity.Core.Common.Utils.InternalBase
	{
		// Token: 0x060043BB RID: 17339 RVA: 0x000EA790 File Offset: 0x000E8990
		internal ViewgenContext(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget viewTarget, global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase extent, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> extentCells, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CqlIdentifiers identifiers, global::System.Data.Entity.Core.Mapping.ViewGeneration.ConfigViewGenerator config, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap queryDomainMap, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap updateDomainMap, global::System.Data.Entity.Core.Mapping.EntityContainerMapping entityContainerMapping)
		{
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell cell in extentCells)
			{
			}
			this.m_extent = extent;
			this.m_viewTarget = viewTarget;
			this.m_config = config;
			this.m_edmItemCollection = entityContainerMapping.StorageMappingItemCollection.EdmItemCollection;
			this.m_entityContainerMapping = entityContainerMapping;
			this.m_identifiers = identifiers;
			updateDomainMap = updateDomainMap.MakeCopy();
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap domainMap = (viewTarget == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget.QueryView) ? queryDomainMap : updateDomainMap;
			this.m_memberMaps = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberMaps(viewTarget, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectionIndex.Create(extent, this.m_edmItemCollection), queryDomainMap, updateDomainMap);
			global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryKBChaseSupport fragmentQueryKBChaseSupport = new global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryKBChaseSupport();
			fragmentQueryKBChaseSupport.CreateVariableConstraints(extent, domainMap, this.m_edmItemCollection);
			this.m_leftFragmentQP = new global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryProcessor(fragmentQueryKBChaseSupport);
			this.m_rewritingCache = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery>>(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery.GetEqualityComparer(this.m_leftFragmentQP));
			if (!this.CreateLeftCellWrappers(extentCells, viewTarget))
			{
				return;
			}
			global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryKBChaseSupport fragmentQueryKBChaseSupport2 = new global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryKBChaseSupport();
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap memberDomainMap = (viewTarget == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget.QueryView) ? updateDomainMap : queryDomainMap;
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper leftCellWrapper in this.m_cellWrappers)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase rightExtent = leftCellWrapper.RightExtent;
				fragmentQueryKBChaseSupport2.CreateVariableConstraints(rightExtent, memberDomainMap, this.m_edmItemCollection);
				fragmentQueryKBChaseSupport2.CreateAssociationConstraints(rightExtent, memberDomainMap, this.m_edmItemCollection);
			}
			if (this.m_viewTarget == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget.UpdateView)
			{
				this.CreateConstraintsForForeignKeyAssociationsAffectingThisWrapper(fragmentQueryKBChaseSupport2, memberDomainMap);
			}
			this.m_rightFragmentQP = new global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryProcessor(fragmentQueryKBChaseSupport2);
			if (this.m_viewTarget == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget.QueryView)
			{
				this.CheckConcurrencyControlTokens();
			}
			this.m_cellWrappers.Sort(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper.Comparer);
		}

		// Token: 0x060043BC RID: 17340 RVA: 0x000EA930 File Offset: 0x000E8B30
		private void CreateConstraintsForForeignKeyAssociationsAffectingThisWrapper(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryKB rightKB, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap rightDomainMap)
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationSet assocSet in new global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewgenContext.OneToOneFkAssociationsForEntitiesFilter().Filter((from it in (from it in this.m_cellWrappers
			select it.RightExtent).OfType<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>()
			select it.ElementType).ToList<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(), this.m_entityContainerMapping.EdmEntityContainer.BaseEntitySets.OfType<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet>()))
			{
				rightKB.CreateEquivalenceConstraintForOneToOneForeignKeyAssociation(assocSet, rightDomainMap);
			}
		}

		// Token: 0x17000D6C RID: 3436
		// (get) Token: 0x060043BD RID: 17341 RVA: 0x000EA9F0 File Offset: 0x000E8BF0
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget ViewTarget
		{
			get
			{
				return this.m_viewTarget;
			}
		}

		// Token: 0x17000D6D RID: 3437
		// (get) Token: 0x060043BE RID: 17342 RVA: 0x000EA9F8 File Offset: 0x000E8BF8
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberMaps MemberMaps
		{
			get
			{
				return this.m_memberMaps;
			}
		}

		// Token: 0x17000D6E RID: 3438
		// (get) Token: 0x060043BF RID: 17343 RVA: 0x000EAA00 File Offset: 0x000E8C00
		internal global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase Extent
		{
			get
			{
				return this.m_extent;
			}
		}

		// Token: 0x17000D6F RID: 3439
		// (get) Token: 0x060043C0 RID: 17344 RVA: 0x000EAA08 File Offset: 0x000E8C08
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.ConfigViewGenerator Config
		{
			get
			{
				return this.m_config;
			}
		}

		// Token: 0x17000D70 RID: 3440
		// (get) Token: 0x060043C1 RID: 17345 RVA: 0x000EAA10 File Offset: 0x000E8C10
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CqlIdentifiers CqlIdentifiers
		{
			get
			{
				return this.m_identifiers;
			}
		}

		// Token: 0x17000D71 RID: 3441
		// (get) Token: 0x060043C2 RID: 17346 RVA: 0x000EAA18 File Offset: 0x000E8C18
		internal global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection EdmItemCollection
		{
			get
			{
				return this.m_edmItemCollection;
			}
		}

		// Token: 0x17000D72 RID: 3442
		// (get) Token: 0x060043C3 RID: 17347 RVA: 0x000EAA20 File Offset: 0x000E8C20
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryProcessor LeftFragmentQP
		{
			get
			{
				return this.m_leftFragmentQP;
			}
		}

		// Token: 0x17000D73 RID: 3443
		// (get) Token: 0x060043C4 RID: 17348 RVA: 0x000EAA28 File Offset: 0x000E8C28
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryProcessor RightFragmentQP
		{
			get
			{
				return this.m_rightFragmentQP;
			}
		}

		// Token: 0x17000D74 RID: 3444
		// (get) Token: 0x060043C5 RID: 17349 RVA: 0x000EAA30 File Offset: 0x000E8C30
		internal global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper> AllWrappersForExtent
		{
			get
			{
				return this.m_cellWrappers;
			}
		}

		// Token: 0x17000D75 RID: 3445
		// (get) Token: 0x060043C6 RID: 17350 RVA: 0x000EAA38 File Offset: 0x000E8C38
		internal global::System.Data.Entity.Core.Mapping.EntityContainerMapping EntityContainerMapping
		{
			get
			{
				return this.m_entityContainerMapping;
			}
		}

		// Token: 0x060043C7 RID: 17351 RVA: 0x000EAA40 File Offset: 0x000E8C40
		internal bool TryGetCachedRewriting(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery query, out global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> rewriting)
		{
			return this.m_rewritingCache.TryGetValue(query, out rewriting);
		}

		// Token: 0x060043C8 RID: 17352 RVA: 0x000EAA4F File Offset: 0x000E8C4F
		internal void SetCachedRewriting(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery query, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> rewriting)
		{
			this.m_rewritingCache[query] = rewriting;
		}

		// Token: 0x060043C9 RID: 17353 RVA: 0x000EAA60 File Offset: 0x000E8C60
		private void CheckConcurrencyControlTokens()
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase elementType = this.m_extent.ElementType;
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> concurrencyMembersForTypeHierarchy = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetConcurrencyMembersForTypeHierarchy(elementType, this.m_edmItemCollection);
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> set = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath.EqualityComparer);
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember in concurrencyMembersForTypeHierarchy)
			{
				if (!edmMember.DeclaringType.IsAssignableFrom(elementType))
				{
					string message = global::System.Data.Entity.Resources.Strings.ViewGen_Concurrency_Derived_Class(edmMember.Name, edmMember.DeclaringType.Name, this.m_extent);
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ExceptionHelpers.ThrowMappingException(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record(global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ViewGenErrorCode.ConcurrencyDerivedClass, message, this.m_cellWrappers, string.Empty), this.m_config);
				}
				set.Add(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath(this.m_extent, edmMember));
			}
			if (concurrencyMembersForTypeHierarchy.Count > 0)
			{
				foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper leftCellWrapper in this.m_cellWrappers)
				{
					global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> set2 = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>(from oneOf in leftCellWrapper.OnlyInputCell.CQuery.WhereClause.MemberRestrictions
					select oneOf.RestrictedMemberSlot.MemberPath, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath.EqualityComparer);
					set2.Intersect(set);
					if (set2.Count > 0)
					{
						global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
						stringBuilder.AppendLine(global::System.Data.Entity.Resources.Strings.ViewGen_Concurrency_Invalid_Condition(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath.PropertiesToUserString(set2, false), this.m_extent.Name));
						global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ExceptionHelpers.ThrowMappingException(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record(global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ViewGenErrorCode.ConcurrencyTokenHasCondition, stringBuilder.ToString(), new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper[]
						{
							leftCellWrapper
						}, string.Empty), this.m_config);
					}
				}
			}
		}

		// Token: 0x060043CA RID: 17354 RVA: 0x000EAC2C File Offset: 0x000E8E2C
		private bool CreateLeftCellWrappers(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> extentCells, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget viewTarget)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> list = global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewgenContext.AlignFields(extentCells, this.m_memberMaps.ProjectedSlotMap, viewTarget);
			this.m_cellWrappers = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper>();
			for (int i = 0; i < list.Count; i++)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell cell = list[i];
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery leftQuery = cell.GetLeftQuery(viewTarget);
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery rightQuery = cell.GetRightQuery(viewTarget);
				global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> nonNullSlots = leftQuery.GetNonNullSlots();
				global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery fragmentQuery = global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery.Create(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateLiteral(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellIdBoolean(this.m_identifiers, extentCells[i].CellNumber), this.m_memberMaps.LeftDomainMap), leftQuery);
				if (viewTarget == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget.UpdateView)
				{
					fragmentQuery = (this.m_leftFragmentQP.CreateDerivedViewBySelectingConstantAttributes(fragmentQuery) ?? fragmentQuery);
				}
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper item = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper(this.m_viewTarget, nonNullSlots, fragmentQuery, leftQuery, rightQuery, this.m_memberMaps, extentCells[i]);
				this.m_cellWrappers.Add(item);
			}
			return true;
		}

		// Token: 0x060043CB RID: 17355 RVA: 0x000EAD04 File Offset: 0x000E8F04
		private static global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> AlignFields(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> cells, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectionIndex projectedSlotMap, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget viewTarget)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell>();
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell cell in cells)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery leftQuery = cell.GetLeftQuery(viewTarget);
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery rightQuery = cell.GetRightQuery(viewTarget);
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery cellQuery;
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery cellQuery2;
				leftQuery.CreateFieldAlignedCellQueries(rightQuery, projectedSlotMap, out cellQuery, out cellQuery2);
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell item = (viewTarget == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget.QueryView) ? global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell.CreateCS(cellQuery, cellQuery2, cell.CellLabel, cell.CellNumber) : global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell.CreateCS(cellQuery2, cellQuery, cell.CellLabel, cell.CellNumber);
				list.Add(item);
			}
			return list;
		}

		// Token: 0x060043CC RID: 17356 RVA: 0x000EADA0 File Offset: 0x000E8FA0
		internal override void ToCompactString(global::System.Text.StringBuilder builder)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper.WrappersToStringBuilder(builder, this.m_cellWrappers, "Left Cell Wrappers");
		}

		// Token: 0x04001845 RID: 6213
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.ConfigViewGenerator m_config;

		// Token: 0x04001846 RID: 6214
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget m_viewTarget;

		// Token: 0x04001847 RID: 6215
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase m_extent;

		// Token: 0x04001848 RID: 6216
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberMaps m_memberMaps;

		// Token: 0x04001849 RID: 6217
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection m_edmItemCollection;

		// Token: 0x0400184A RID: 6218
		private readonly global::System.Data.Entity.Core.Mapping.EntityContainerMapping m_entityContainerMapping;

		// Token: 0x0400184B RID: 6219
		private global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper> m_cellWrappers;

		// Token: 0x0400184C RID: 6220
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryProcessor m_leftFragmentQP;

		// Token: 0x0400184D RID: 6221
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryProcessor m_rightFragmentQP;

		// Token: 0x0400184E RID: 6222
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CqlIdentifiers m_identifiers;

		// Token: 0x0400184F RID: 6223
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery>> m_rewritingCache;

		// Token: 0x02000B7F RID: 2943
		internal class OneToOneFkAssociationsForEntitiesFilter
		{
			// Token: 0x06006687 RID: 26247 RVA: 0x0015F11C File Offset: 0x0015D31C
			public virtual global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet> Filter(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EntityType> entityTypes, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet> associationSets)
			{
				global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember, bool> <>9__1;
				return associationSets.Where(delegate(global::System.Data.Entity.Core.Metadata.Edm.AssociationSet a)
				{
					if (a.ElementType.IsForeignKey)
					{
						global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember> associationEndMembers = a.ElementType.AssociationEndMembers;
						global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember, bool> predicate;
						if ((predicate = <>9__1) == null)
						{
							predicate = (<>9__1 = ((global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember aem) => aem.RelationshipMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One && entityTypes.Contains(aem.GetEntityType())));
						}
						return associationEndMembers.All(predicate);
					}
					return false;
				});
			}
		}
	}
}
