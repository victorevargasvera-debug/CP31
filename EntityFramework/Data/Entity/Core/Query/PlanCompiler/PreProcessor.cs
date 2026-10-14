using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Mapping.ViewGeneration;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Query.InternalTrees;
using System.Data.Entity.Resources;
using System.Runtime.CompilerServices;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x0200035A RID: 858
	internal class PreProcessor : global::System.Data.Entity.Core.Query.PlanCompiler.SubqueryTrackingVisitor
	{
		// Token: 0x0600297F RID: 10623 RVA: 0x000841CC File Offset: 0x000823CC
		private PreProcessor(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler planCompilerState) : base(planCompilerState)
		{
			this.m_relPropertyHelper = new global::System.Data.Entity.Core.Query.InternalTrees.RelPropertyHelper(base.m_command.MetadataWorkspace, base.m_command.ReferencedRelProperties);
		}

		// Token: 0x06002980 RID: 10624 RVA: 0x00084264 File Offset: 0x00082464
		internal static void Process(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler planCompilerState, out global::System.Data.Entity.Core.Query.PlanCompiler.StructuredTypeInfo typeInfo, out global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[]> tvfResultKeys)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PreProcessor preProcessor = new global::System.Data.Entity.Core.Query.PlanCompiler.PreProcessor(planCompilerState);
			preProcessor.Process(out tvfResultKeys);
			global::System.Data.Entity.Core.Query.PlanCompiler.StructuredTypeInfo.Process(planCompilerState.Command, preProcessor.m_referencedTypes, preProcessor.m_referencedEntitySets, preProcessor.m_freeFloatingEntityConstructorTypes, preProcessor.m_suppressDiscriminatorMaps ? null : preProcessor.m_discriminatorMaps, preProcessor.m_relPropertyHelper, preProcessor.m_typesNeedingNullSentinel, out typeInfo);
		}

		// Token: 0x06002981 RID: 10625 RVA: 0x000842BC File Offset: 0x000824BC
		internal void Process(out global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[]> tvfResultKeys)
		{
			base.m_command.Root = base.VisitNode(base.m_command.Root);
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var var in base.m_command.Vars)
			{
				this.AddTypeReference(var.Type);
			}
			if (this.m_referencedTypes.Count > 0)
			{
				this.m_compilerState.MarkPhaseAsNeeded(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompilerPhase.NTE);
				((global::System.Data.Entity.Core.Query.InternalTrees.PhysicalProjectOp)base.m_command.Root.Op).ColumnMap.Accept<global::System.Collections.Generic.HashSet<string>>(global::System.Data.Entity.Core.Query.PlanCompiler.StructuredTypeNullabilityAnalyzer.Instance, this.m_typesNeedingNullSentinel);
			}
			tvfResultKeys = this.m_tvfResultKeys;
		}

		// Token: 0x06002982 RID: 10626 RVA: 0x0008437C File Offset: 0x0008257C
		private void AddEntitySetReference(global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet)
		{
			this.m_referencedEntitySets.Add(entitySet);
			if (!this.m_referencedEntityContainers.Contains(entitySet.EntityContainer))
			{
				this.m_referencedEntityContainers.Add(entitySet.EntityContainer);
			}
		}

		// Token: 0x06002983 RID: 10627 RVA: 0x000843B0 File Offset: 0x000825B0
		private void AddTypeReference(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			if (global::System.Data.Entity.Core.Query.PlanCompiler.TypeUtils.IsStructuredType(type) || global::System.Data.Entity.Core.Query.PlanCompiler.TypeUtils.IsCollectionType(type) || global::System.Data.Entity.Core.Query.PlanCompiler.TypeUtils.IsEnumerationType(type))
			{
				this.m_referencedTypes.Add(type);
			}
		}

		// Token: 0x06002984 RID: 10628 RVA: 0x000843D8 File Offset: 0x000825D8
		private global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.RelationshipSet> GetRelationshipSets(global::System.Data.Entity.Core.Metadata.Edm.RelationshipType relType)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.RelationshipSet> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.RelationshipSet>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntityContainer entityContainer in this.m_referencedEntityContainers)
			{
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySetBase in entityContainer.BaseEntitySets)
				{
					global::System.Data.Entity.Core.Metadata.Edm.RelationshipSet relationshipSet = entitySetBase as global::System.Data.Entity.Core.Metadata.Edm.RelationshipSet;
					if (relationshipSet != null && relationshipSet.ElementType.Equals(relType))
					{
						list.Add(relationshipSet);
					}
				}
			}
			return list;
		}

		// Token: 0x06002985 RID: 10629 RVA: 0x00084484 File Offset: 0x00082684
		private global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> GetEntitySets(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage entityType)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntityContainer entityContainer in this.m_referencedEntityContainers)
			{
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySetBase in entityContainer.BaseEntitySets)
				{
					global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = entitySetBase as global::System.Data.Entity.Core.Metadata.Edm.EntitySet;
					if (entitySet != null && (entitySet.ElementType.Equals(entityType.EdmType) || global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsSubTypeOf(entityType.EdmType, entitySet.ElementType) || global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsSubTypeOf(entitySet.ElementType, entityType.EdmType)))
					{
						list.Add(entitySet);
					}
				}
			}
			return list;
		}

		// Token: 0x06002986 RID: 10630 RVA: 0x0008455C File Offset: 0x0008275C
		private global::System.Data.Entity.Core.Query.InternalTrees.Node ExpandView(global::System.Data.Entity.Core.Query.InternalTrees.ScanTableOp scanTableOp, ref global::System.Data.Entity.Core.Query.InternalTrees.IsOfOp typeFilter)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase extent = scanTableOp.Table.TableMetadata.Extent;
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(extent != null, "The target of a ScanTableOp must reference an EntitySet to be used with ExpandView");
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(extent.EntityContainer.DataSpace == global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace, "Store entity sets cannot have Query Mapping Views and should not be used with ExpandView");
			if (typeFilter != null && !typeFilter.IsOfOnly && global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsSubTypeOf(extent.ElementType, typeFilter.IsOfType.EdmType))
			{
				typeFilter = null;
			}
			global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView generatedView = null;
			global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase entityTypeBase = scanTableOp.Table.TableMetadata.Extent.ElementType;
			bool includeSubtypes = true;
			if (typeFilter != null)
			{
				entityTypeBase = (global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase)typeFilter.IsOfType.EdmType;
				includeSubtypes = !typeFilter.IsOfOnly;
				if (base.m_command.MetadataWorkspace.TryGetGeneratedViewOfType(extent, entityTypeBase, includeSubtypes, out generatedView))
				{
					typeFilter = null;
				}
			}
			if (generatedView == null)
			{
				generatedView = base.m_command.MetadataWorkspace.GetGeneratedView(extent);
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(generatedView != null, global::System.Data.Entity.Resources.Strings.ADP_NoQueryMappingView(extent.EntityContainer.Name, extent.Name));
			global::System.Data.Entity.Core.Query.InternalTrees.Node internalTree = generatedView.GetInternalTree(base.m_command);
			this.DetermineDiscriminatorMapUsage(internalTree, extent, entityTypeBase, includeSubtypes);
			global::System.Data.Entity.Core.Query.InternalTrees.ScanViewOp op = base.m_command.CreateScanViewOp(scanTableOp.Table);
			return base.m_command.CreateNode(op, internalTree);
		}

		// Token: 0x06002987 RID: 10631 RVA: 0x00084694 File Offset: 0x00082894
		private void DetermineDiscriminatorMapUsage(global::System.Data.Entity.Core.Query.InternalTrees.Node viewNode, global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySet, global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase rootEntityType, bool includeSubtypes)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.ExplicitDiscriminatorMap discriminatorMap = null;
			if (viewNode.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Project)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.DiscriminatedNewEntityOp discriminatedNewEntityOp = viewNode.Child1.Child0.Child0.Op as global::System.Data.Entity.Core.Query.InternalTrees.DiscriminatedNewEntityOp;
				if (discriminatedNewEntityOp != null)
				{
					discriminatorMap = discriminatedNewEntityOp.DiscriminatorMap;
				}
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.DiscriminatorMapInfo discriminatorMapInfo;
			if (!this.m_discriminatorMaps.TryGetValue(entitySet, out discriminatorMapInfo))
			{
				if (rootEntityType == null)
				{
					rootEntityType = entitySet.ElementType;
					includeSubtypes = true;
				}
				discriminatorMapInfo = new global::System.Data.Entity.Core.Query.PlanCompiler.DiscriminatorMapInfo(rootEntityType, includeSubtypes, discriminatorMap);
				this.m_discriminatorMaps.Add(entitySet, discriminatorMapInfo);
				return;
			}
			discriminatorMapInfo.Merge(rootEntityType, includeSubtypes, discriminatorMap);
		}

		// Token: 0x06002988 RID: 10632 RVA: 0x00084718 File Offset: 0x00082918
		private global::System.Data.Entity.Core.Query.InternalTrees.Node RewriteNavigateOp(global::System.Data.Entity.Core.Query.InternalTrees.Node navigateOpNode, global::System.Data.Entity.Core.Query.InternalTrees.NavigateOp navigateOp, out global::System.Data.Entity.Core.Query.InternalTrees.Var outputVar)
		{
			outputVar = null;
			if (!global::System.Data.Entity.Core.Metadata.Edm.Helper.IsAssociationType(navigateOp.Relationship))
			{
				throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.Cqt_RelNav_NoCompositions);
			}
			if (navigateOpNode.Child0.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.GetEntityRef && (navigateOp.ToEnd.RelationshipMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne || navigateOp.ToEnd.RelationshipMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One))
			{
				bool condition = base.m_command.IsRelPropertyReferenced(navigateOp.RelProperty);
				string str = "Unreferenced rel property? ";
				global::System.Data.Entity.Core.Query.InternalTrees.RelProperty relProperty = navigateOp.RelProperty;
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(condition, str + ((relProperty != null) ? relProperty.ToString() : null));
				global::System.Data.Entity.Core.Query.InternalTrees.Op op = base.m_command.CreateRelPropertyOp(navigateOp.RelProperty);
				return base.m_command.CreateNode(op, navigateOpNode.Child0.Child0);
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.RelationshipSet> relationshipSets = this.GetRelationshipSets(navigateOp.Relationship);
			if (relationshipSets.Count != 0)
			{
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var>();
				foreach (global::System.Data.Entity.Core.Metadata.Edm.RelationshipSet extent in relationshipSets)
				{
					global::System.Data.Entity.Core.Query.InternalTrees.TableMD tableMetadata = global::System.Data.Entity.Core.Query.InternalTrees.Command.CreateTableDefinition(extent);
					global::System.Data.Entity.Core.Query.InternalTrees.ScanTableOp scanTableOp = base.m_command.CreateScanTableOp(tableMetadata);
					global::System.Data.Entity.Core.Query.InternalTrees.Node item = base.m_command.CreateNode(scanTableOp);
					global::System.Data.Entity.Core.Query.InternalTrees.Var item2 = scanTableOp.Table.Columns[0];
					list2.Add(item2);
					list.Add(item);
				}
				global::System.Data.Entity.Core.Query.InternalTrees.Node arg = null;
				global::System.Data.Entity.Core.Query.InternalTrees.Var v;
				base.m_command.BuildUnionAllLadder(list, list2, out arg, out v);
				global::System.Data.Entity.Core.Query.InternalTrees.Node computedExpression = base.m_command.CreateNode(base.m_command.CreatePropertyOp(navigateOp.ToEnd), base.m_command.CreateNode(base.m_command.CreateVarRefOp(v)));
				global::System.Data.Entity.Core.Query.InternalTrees.Node arg2 = base.m_command.CreateNode(base.m_command.CreatePropertyOp(navigateOp.FromEnd), base.m_command.CreateNode(base.m_command.CreateVarRefOp(v)));
				global::System.Data.Entity.Core.Query.InternalTrees.Node arg3 = base.m_command.BuildComparison(global::System.Data.Entity.Core.Query.InternalTrees.OpType.EQ, navigateOpNode.Child0, arg2, true);
				global::System.Data.Entity.Core.Query.InternalTrees.Node input = base.m_command.CreateNode(base.m_command.CreateFilterOp(), arg, arg3);
				global::System.Data.Entity.Core.Query.InternalTrees.Var var;
				global::System.Data.Entity.Core.Query.InternalTrees.Node node = base.m_command.BuildProject(input, computedExpression, out var);
				global::System.Data.Entity.Core.Query.InternalTrees.Node result;
				if (navigateOp.ToEnd.RelationshipMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many)
				{
					result = base.m_command.BuildCollect(node, var);
				}
				else
				{
					result = node;
					outputVar = var;
				}
				return result;
			}
			if (navigateOp.ToEnd.RelationshipMultiplicity != global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many)
			{
				return base.m_command.CreateNode(base.m_command.CreateNullOp(navigateOp.Type));
			}
			return base.m_command.CreateNode(base.m_command.CreateNewMultisetOp(navigateOp.Type));
		}

		// Token: 0x06002989 RID: 10633 RVA: 0x000849AC File Offset: 0x00082BAC
		private global::System.Data.Entity.Core.Query.InternalTrees.Node BuildOfTypeTable(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySet, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage ofType, out global::System.Data.Entity.Core.Query.InternalTrees.Var resultVar)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.TableMD tableMetadata = global::System.Data.Entity.Core.Query.InternalTrees.Command.CreateTableDefinition(entitySet);
			global::System.Data.Entity.Core.Query.InternalTrees.ScanTableOp scanTableOp = base.m_command.CreateScanTableOp(tableMetadata);
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = base.m_command.CreateNode(scanTableOp);
			global::System.Data.Entity.Core.Query.InternalTrees.Var var = scanTableOp.Table.Columns[0];
			global::System.Data.Entity.Core.Query.InternalTrees.Node result;
			if (ofType != null && !entitySet.ElementType.EdmEquals(ofType.EdmType))
			{
				base.m_command.BuildOfTypeTree(node, var, ofType, true, out result, out resultVar);
			}
			else
			{
				result = node;
				resultVar = var;
			}
			return result;
		}

		// Token: 0x0600298A RID: 10634 RVA: 0x00084A20 File Offset: 0x00082C20
		private global::System.Data.Entity.Core.Query.InternalTrees.Node RewriteDerefOp(global::System.Data.Entity.Core.Query.InternalTrees.Node derefOpNode, global::System.Data.Entity.Core.Query.InternalTrees.DerefOp derefOp, out global::System.Data.Entity.Core.Query.InternalTrees.Var outputVar)
		{
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type = derefOp.Type;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> entitySets = this.GetEntitySets(type);
			if (entitySets.Count == 0)
			{
				outputVar = null;
				return base.m_command.CreateNode(base.m_command.CreateNullOp(type));
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet in entitySets)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Var item2;
				global::System.Data.Entity.Core.Query.InternalTrees.Node item = this.BuildOfTypeTable(entitySet, type, out item2);
				list.Add(item);
				list2.Add(item2);
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg;
			global::System.Data.Entity.Core.Query.InternalTrees.Var var;
			base.m_command.BuildUnionAllLadder(list, list2, out arg, out var);
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg2 = base.m_command.CreateNode(base.m_command.CreateGetEntityRefOp(derefOpNode.Child0.Op.Type), base.m_command.CreateNode(base.m_command.CreateVarRefOp(var)));
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg3 = base.m_command.BuildComparison(global::System.Data.Entity.Core.Query.InternalTrees.OpType.EQ, derefOpNode.Child0, arg2, true);
			global::System.Data.Entity.Core.Query.InternalTrees.Node result = base.m_command.CreateNode(base.m_command.CreateFilterOp(), arg, arg3);
			outputVar = var;
			return result;
		}

		// Token: 0x0600298B RID: 10635 RVA: 0x00084B4C File Offset: 0x00082D4C
		private static global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase FindTargetEntitySet(global::System.Data.Entity.Core.Metadata.Edm.RelationshipSet relationshipSet, global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember targetEnd)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySetBase = null;
			global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet = (global::System.Data.Entity.Core.Metadata.Edm.AssociationSet)relationshipSet;
			entitySetBase = null;
			foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd associationSetEnd in associationSet.AssociationSetEnds)
			{
				if (associationSetEnd.CorrespondingAssociationEndMember.EdmEquals(targetEnd))
				{
					entitySetBase = associationSetEnd.EntitySet;
					break;
				}
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(entitySetBase != null, "Could not find entity set for relationship set " + ((relationshipSet != null) ? relationshipSet.ToString() : null) + ";association end " + ((targetEnd != null) ? targetEnd.ToString() : null));
			return entitySetBase;
		}

		// Token: 0x0600298C RID: 10636 RVA: 0x00084BEC File Offset: 0x00082DEC
		private global::System.Data.Entity.Core.Query.InternalTrees.Node BuildJoinForNavProperty(global::System.Data.Entity.Core.Metadata.Edm.RelationshipSet relSet, global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember end, out global::System.Data.Entity.Core.Query.InternalTrees.Var rsVar, out global::System.Data.Entity.Core.Query.InternalTrees.Var esVar)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySet = global::System.Data.Entity.Core.Query.PlanCompiler.PreProcessor.FindTargetEntitySet(relSet, end);
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg = this.BuildOfTypeTable(relSet, null, out rsVar);
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg2 = this.BuildOfTypeTable(entitySet, global::System.Data.Entity.Core.Common.TypeHelpers.GetElementTypeUsage(end.TypeUsage), out esVar);
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg3 = base.m_command.BuildComparison(global::System.Data.Entity.Core.Query.InternalTrees.OpType.EQ, base.m_command.CreateNode(base.m_command.CreateGetEntityRefOp(end.TypeUsage), base.m_command.CreateNode(base.m_command.CreateVarRefOp(esVar))), base.m_command.CreateNode(base.m_command.CreatePropertyOp(end), base.m_command.CreateNode(base.m_command.CreateVarRefOp(rsVar))), true);
			return base.m_command.CreateNode(base.m_command.CreateInnerJoinOp(), arg, arg2, arg3);
		}

		// Token: 0x0600298D RID: 10637 RVA: 0x00084CAC File Offset: 0x00082EAC
		private global::System.Data.Entity.Core.Query.InternalTrees.Node RewriteManyToOneNavigationProperty(global::System.Data.Entity.Core.Query.InternalTrees.RelProperty relProperty, global::System.Data.Entity.Core.Query.InternalTrees.Node sourceEntityNode, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage resultType)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.RelPropertyOp op = base.m_command.CreateRelPropertyOp(relProperty);
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg = base.m_command.CreateNode(op, sourceEntityNode);
			global::System.Data.Entity.Core.Query.InternalTrees.DerefOp op2 = base.m_command.CreateDerefOp(resultType);
			return base.m_command.CreateNode(op2, arg);
		}

		// Token: 0x0600298E RID: 10638 RVA: 0x00084CF0 File Offset: 0x00082EF0
		private global::System.Data.Entity.Core.Query.InternalTrees.Node RewriteOneToManyNavigationProperty(global::System.Data.Entity.Core.Query.InternalTrees.RelProperty relProperty, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.RelationshipSet> relationshipSets, global::System.Data.Entity.Core.Query.InternalTrees.Node sourceRefNode)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Var relOpVar;
			global::System.Data.Entity.Core.Query.InternalTrees.Node relOpNode = this.RewriteFromOneNavigationProperty(relProperty, relationshipSets, sourceRefNode, out relOpVar);
			return base.m_command.BuildCollect(relOpNode, relOpVar);
		}

		// Token: 0x0600298F RID: 10639 RVA: 0x00084D18 File Offset: 0x00082F18
		private global::System.Data.Entity.Core.Query.InternalTrees.Node RewriteOneToOneNavigationProperty(global::System.Data.Entity.Core.Query.InternalTrees.RelProperty relProperty, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.RelationshipSet> relationshipSets, global::System.Data.Entity.Core.Query.InternalTrees.Node sourceRefNode)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Var outputVar;
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = this.RewriteFromOneNavigationProperty(relProperty, relationshipSets, sourceRefNode, out outputVar);
			node = base.VisitNode(node);
			return base.AddSubqueryToParentRelOp(outputVar, node);
		}

		// Token: 0x06002990 RID: 10640 RVA: 0x00084D44 File Offset: 0x00082F44
		private global::System.Data.Entity.Core.Query.InternalTrees.Node RewriteFromOneNavigationProperty(global::System.Data.Entity.Core.Query.InternalTrees.RelProperty relProperty, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.RelationshipSet> relationshipSets, global::System.Data.Entity.Core.Query.InternalTrees.Node sourceRefNode, out global::System.Data.Entity.Core.Query.InternalTrees.Var outputVar)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(relationshipSets.Count > 0, "expected at least one relationship set here");
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(relProperty.FromEnd.RelationshipMultiplicity != global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, "Expected source end multiplicity to be one. Found 'Many' instead " + ((relProperty != null) ? relProperty.ToString() : null));
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage elementTypeUsage = global::System.Data.Entity.Core.Common.TypeHelpers.GetElementTypeUsage(relProperty.ToEnd.TypeUsage);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>(relationshipSets.Count);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var>(relationshipSets.Count);
			foreach (global::System.Data.Entity.Core.Metadata.Edm.RelationshipSet relationshipSet in relationshipSets)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySet = global::System.Data.Entity.Core.Query.PlanCompiler.PreProcessor.FindTargetEntitySet(relationshipSet, relProperty.ToEnd);
				global::System.Data.Entity.Core.Query.InternalTrees.Var item2;
				global::System.Data.Entity.Core.Query.InternalTrees.Node item = this.BuildOfTypeTable(entitySet, elementTypeUsage, out item2);
				list.Add(item);
				list2.Add(item2);
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg;
			base.m_command.BuildUnionAllLadder(list, list2, out arg, out outputVar);
			global::System.Data.Entity.Core.Query.InternalTrees.RelProperty relProperty2 = new global::System.Data.Entity.Core.Query.InternalTrees.RelProperty(relProperty.Relationship, relProperty.ToEnd, relProperty.FromEnd);
			bool condition = base.m_command.IsRelPropertyReferenced(relProperty2);
			string str = "Unreferenced rel property? ";
			global::System.Data.Entity.Core.Query.InternalTrees.RelProperty relProperty3 = relProperty2;
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(condition, str + ((relProperty3 != null) ? relProperty3.ToString() : null));
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg2 = base.m_command.CreateNode(base.m_command.CreateRelPropertyOp(relProperty2), base.m_command.CreateNode(base.m_command.CreateVarRefOp(outputVar)));
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg3 = base.m_command.BuildComparison(global::System.Data.Entity.Core.Query.InternalTrees.OpType.EQ, sourceRefNode, arg2, true);
			return base.m_command.CreateNode(base.m_command.CreateFilterOp(), arg, arg3);
		}

		// Token: 0x06002991 RID: 10641 RVA: 0x00084ED4 File Offset: 0x000830D4
		private global::System.Data.Entity.Core.Query.InternalTrees.Node RewriteManyToManyNavigationProperty(global::System.Data.Entity.Core.Query.InternalTrees.RelProperty relProperty, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.RelationshipSet> relationshipSets, global::System.Data.Entity.Core.Query.InternalTrees.Node sourceRefNode)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(relationshipSets.Count > 0, "expected at least one relationship set here");
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(relProperty.ToEnd.RelationshipMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many && relProperty.FromEnd.RelationshipMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, "Expected target end multiplicity to be 'many'. Found " + ((relProperty != null) ? relProperty.ToString() : null) + "; multiplicity = " + relProperty.ToEnd.RelationshipMultiplicity.ToString());
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>(relationshipSets.Count);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var>(relationshipSets.Count * 2);
			foreach (global::System.Data.Entity.Core.Metadata.Edm.RelationshipSet relSet in relationshipSets)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Var item2;
				global::System.Data.Entity.Core.Query.InternalTrees.Var item3;
				global::System.Data.Entity.Core.Query.InternalTrees.Node item = this.BuildJoinForNavProperty(relSet, relProperty.ToEnd, out item2, out item3);
				list.Add(item);
				list2.Add(item2);
				list2.Add(item3);
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg;
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Query.InternalTrees.Var> list3;
			base.m_command.BuildUnionAllLadder(list, list2, out arg, out list3);
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg2 = base.m_command.CreateNode(base.m_command.CreatePropertyOp(relProperty.FromEnd), base.m_command.CreateNode(base.m_command.CreateVarRefOp(list3[0])));
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg3 = base.m_command.BuildComparison(global::System.Data.Entity.Core.Query.InternalTrees.OpType.EQ, sourceRefNode, arg2, true);
			global::System.Data.Entity.Core.Query.InternalTrees.Node inputNode = base.m_command.CreateNode(base.m_command.CreateFilterOp(), arg, arg3);
			global::System.Data.Entity.Core.Query.InternalTrees.Node relOpNode = base.m_command.BuildProject(inputNode, new global::System.Data.Entity.Core.Query.InternalTrees.Var[]
			{
				list3[1]
			}, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]);
			return base.m_command.BuildCollect(relOpNode, list3[1]);
		}

		// Token: 0x06002992 RID: 10642 RVA: 0x00085084 File Offset: 0x00083284
		private global::System.Data.Entity.Core.Query.InternalTrees.Node RewriteNavigationProperty(global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navProperty, global::System.Data.Entity.Core.Query.InternalTrees.Node sourceEntityNode, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage resultType)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.RelProperty relProperty = new global::System.Data.Entity.Core.Query.InternalTrees.RelProperty(navProperty.RelationshipType, navProperty.FromEndMember, navProperty.ToEndMember);
			bool condition = base.m_command.IsRelPropertyReferenced(relProperty) || relProperty.ToEnd.RelationshipMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many;
			string str = "Unreferenced rel property? ";
			global::System.Data.Entity.Core.Query.InternalTrees.RelProperty relProperty2 = relProperty;
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(condition, str + ((relProperty2 != null) ? relProperty2.ToString() : null));
			if (relProperty.FromEnd.RelationshipMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many && relProperty.ToEnd.RelationshipMultiplicity != global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many)
			{
				return this.RewriteManyToOneNavigationProperty(relProperty, sourceEntityNode, resultType);
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.RelationshipSet> relationshipSets = this.GetRelationshipSets(relProperty.Relationship);
			if (relationshipSets.Count == 0)
			{
				if (relProperty.ToEnd.RelationshipMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many)
				{
					return base.m_command.CreateNode(base.m_command.CreateNewMultisetOp(resultType));
				}
				return base.m_command.CreateNode(base.m_command.CreateNullOp(resultType));
			}
			else
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Node sourceRefNode = base.m_command.CreateNode(base.m_command.CreateGetEntityRefOp(relProperty.FromEnd.TypeUsage), sourceEntityNode);
				if (relProperty.ToEnd.RelationshipMultiplicity != global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many)
				{
					return this.RewriteOneToOneNavigationProperty(relProperty, relationshipSets, sourceRefNode);
				}
				if (relProperty.FromEnd.RelationshipMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many)
				{
					return this.RewriteManyToManyNavigationProperty(relProperty, relationshipSets, sourceRefNode);
				}
				return this.RewriteOneToManyNavigationProperty(relProperty, relationshipSets, sourceRefNode);
			}
		}

		// Token: 0x06002993 RID: 10643 RVA: 0x000851B9 File Offset: 0x000833B9
		protected override global::System.Data.Entity.Core.Query.InternalTrees.Node VisitScalarOpDefault(global::System.Data.Entity.Core.Query.InternalTrees.ScalarOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitChildren(n);
			this.AddTypeReference(op.Type);
			return n;
		}

		// Token: 0x06002994 RID: 10644 RVA: 0x000851D0 File Offset: 0x000833D0
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.DerefOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitScalarOpDefault(op, n);
			global::System.Data.Entity.Core.Query.InternalTrees.Var var;
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = this.RewriteDerefOp(n, op, out var);
			node = base.VisitNode(node);
			if (var != null)
			{
				node = base.AddSubqueryToParentRelOp(var, node);
			}
			return node;
		}

		// Token: 0x06002995 RID: 10645 RVA: 0x00085208 File Offset: 0x00083408
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.ElementOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitScalarOpDefault(op, n);
			global::System.Data.Entity.Core.Query.InternalTrees.Node child = n.Child0;
			global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp projectOp = (global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp)child.Op;
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(projectOp.Outputs.Count == 1, "input to ElementOp has more than one output var?");
			global::System.Data.Entity.Core.Query.InternalTrees.Var first = projectOp.Outputs.First;
			return base.AddSubqueryToParentRelOp(first, child);
		}

		// Token: 0x06002996 RID: 10646 RVA: 0x0008525B File Offset: 0x0008345B
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.ExistsOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.m_compilerState.MarkPhaseAsNeeded(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompilerPhase.Normalization);
			return base.Visit(op, n);
		}

		// Token: 0x06002997 RID: 10647 RVA: 0x00085274 File Offset: 0x00083474
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.FunctionOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			if (!op.Function.IsFunctionImport)
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(op.Function.EntitySet == null, "Entity type scope is not supported on functions that aren't mapped.");
				if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsCollectionType(op.Type) || global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompilerUtil.IsCollectionAggregateFunction(op, n))
				{
					this.m_compilerState.MarkPhaseAsNeeded(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompilerPhase.NestPullup);
					this.m_compilerState.MarkPhaseAsNeeded(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompilerPhase.Normalization);
				}
				return base.Visit(op, n);
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(op.Function.IsComposableAttribute, "Cannot process a non-composable function inside query tree composition.");
			global::System.Data.Entity.Core.Mapping.FunctionImportMapping functionImportMapping = null;
			if (!base.m_command.MetadataWorkspace.TryGetFunctionImportMapping(op.Function, out functionImportMapping))
			{
				throw new global::System.Data.Entity.Core.MetadataException(global::System.Data.Entity.Resources.Strings.EntityClient_UnmappedFunctionImport(op.Function.FullName));
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(functionImportMapping is global::System.Data.Entity.Core.Mapping.FunctionImportMappingComposable, "Composable function import must have corresponding mapping.");
			global::System.Data.Entity.Core.Mapping.FunctionImportMappingComposable functionImportMappingComposable = (global::System.Data.Entity.Core.Mapping.FunctionImportMappingComposable)functionImportMapping;
			this.VisitChildren(n);
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = functionImportMappingComposable.GetInternalTree(base.m_command, n.Children);
			if (op.Function.EntitySet != null)
			{
				this.m_entityTypeScopes.Push(op.Function.EntitySet);
				this.AddEntitySetReference(op.Function.EntitySet);
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(functionImportMappingComposable.TvfKeys != null && functionImportMappingComposable.TvfKeys.Length != 0, "Function imports returning entities must have inferred keys.");
				if (!this.m_tvfResultKeys.ContainsKey(functionImportMappingComposable.TargetFunction))
				{
					this.m_tvfResultKeys.Add(functionImportMappingComposable.TargetFunction, functionImportMappingComposable.TvfKeys);
				}
			}
			node = base.VisitNode(node);
			if (op.Function.EntitySet != null)
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(this.m_entityTypeScopes.Pop() == op.Function.EntitySet, "m_entityTypeScopes stack is broken");
			}
			return node;
		}

		// Token: 0x06002998 RID: 10648 RVA: 0x00085410 File Offset: 0x00083610
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.CaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitScalarOpDefault(op, n);
			bool flag;
			if (global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompilerUtil.IsRowTypeCaseOpWithNullability(op, n, out flag))
			{
				this.m_typesNeedingNullSentinel.Add(op.Type.EdmType.Identity);
			}
			return n;
		}

		// Token: 0x06002999 RID: 10649 RVA: 0x0008544E File Offset: 0x0008364E
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.ConditionalOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitScalarOpDefault(op, n);
			this.ProcessConditionalOp(op, n);
			return n;
		}

		// Token: 0x0600299A RID: 10650 RVA: 0x00085464 File Offset: 0x00083664
		private void ProcessConditionalOp(global::System.Data.Entity.Core.Query.InternalTrees.ConditionalOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			if ((op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.IsNull && global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsRowType(n.Child0.Op.Type)) || global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsComplexType(n.Child0.Op.Type))
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.StructuredTypeNullabilityAnalyzer.MarkAsNeedingNullSentinel(this.m_typesNeedingNullSentinel, n.Child0.Op.Type);
			}
		}

		// Token: 0x0600299B RID: 10651 RVA: 0x000854C4 File Offset: 0x000836C4
		private static void ValidateNavPropertyOp(global::System.Data.Entity.Core.Query.InternalTrees.PropertyOp op)
		{
			global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navigationProperty = (global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty)op.PropertyInfo;
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = navigationProperty.ToEndMember.TypeUsage;
			if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsReferenceType(typeUsage))
			{
				typeUsage = global::System.Data.Entity.Core.Common.TypeHelpers.GetElementTypeUsage(typeUsage);
			}
			if (navigationProperty.ToEndMember.RelationshipMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many)
			{
				typeUsage = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(typeUsage.EdmType.GetCollectionType());
			}
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsStructurallyEqualOrPromotableTo(typeUsage, op.Type))
			{
				throw new global::System.Data.Entity.Core.MetadataException(global::System.Data.Entity.Resources.Strings.EntityClient_IncompatibleNavigationPropertyResult(navigationProperty.DeclaringType.FullName, navigationProperty.Name));
			}
		}

		// Token: 0x0600299C RID: 10652 RVA: 0x00085544 File Offset: 0x00083744
		private global::System.Data.Entity.Core.Query.InternalTrees.Node VisitNavPropertyOp(global::System.Data.Entity.Core.Query.InternalTrees.PropertyOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PreProcessor.ValidateNavPropertyOp(op);
			if (!global::System.Data.Entity.Core.Query.PlanCompiler.PreProcessor.IsNavigationPropertyOverVarRef(n.Child0))
			{
				this.VisitScalarOpDefault(op, n);
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.PreProcessor.NavigationPropertyOpInfo navigationPropertyOpInfo = new global::System.Data.Entity.Core.Query.PlanCompiler.PreProcessor.NavigationPropertyOpInfo(n, base.FindRelOpAncestor(), base.m_command);
			global::System.Data.Entity.Core.Query.InternalTrees.Node node;
			if (this._navigationPropertyOpRewrites.TryGetValue(navigationPropertyOpInfo, out node))
			{
				return global::System.Data.Entity.Core.Query.InternalTrees.OpCopier.Copy(base.m_command, node);
			}
			navigationPropertyOpInfo.Seal();
			node = this.RewriteNavigationProperty((global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty)op.PropertyInfo, n.Child0, op.Type);
			node = base.VisitNode(node);
			this._navigationPropertyOpRewrites.Add(navigationPropertyOpInfo, node);
			return node;
		}

		// Token: 0x0600299D RID: 10653 RVA: 0x000855D8 File Offset: 0x000837D8
		private static bool IsNavigationPropertyOverVarRef(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			if (n.Op.OpType != global::System.Data.Entity.Core.Query.InternalTrees.OpType.Property || !global::System.Data.Entity.Core.Metadata.Edm.Helper.IsNavigationProperty(((global::System.Data.Entity.Core.Query.InternalTrees.PropertyOp)n.Op).PropertyInfo))
			{
				return false;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node child = n.Child0;
			if (child.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.SoftCast)
			{
				child = child.Child0;
			}
			return child.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.VarRef;
		}

		// Token: 0x0600299E RID: 10654 RVA: 0x00085638 File Offset: 0x00083838
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.PropertyOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Node result;
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsNavigationProperty(op.PropertyInfo))
			{
				result = this.VisitNavPropertyOp(op, n);
			}
			else
			{
				result = this.VisitScalarOpDefault(op, n);
			}
			return result;
		}

		// Token: 0x0600299F RID: 10655 RVA: 0x00085667 File Offset: 0x00083867
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.RefOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitScalarOpDefault(op, n);
			this.AddEntitySetReference(op.EntitySet);
			return n;
		}

		// Token: 0x060029A0 RID: 10656 RVA: 0x0008567F File Offset: 0x0008387F
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.TreatOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			n = base.Visit(op, n);
			if (this.CanRewriteTypeTest(op.Type.EdmType, n.Child0.Op.Type.EdmType))
			{
				return n.Child0;
			}
			return n;
		}

		// Token: 0x060029A1 RID: 10657 RVA: 0x000856BC File Offset: 0x000838BC
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.IsOfOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitScalarOpDefault(op, n);
			this.AddTypeReference(op.IsOfType);
			if (this.CanRewriteTypeTest(op.IsOfType.EdmType, n.Child0.Op.Type.EdmType))
			{
				n = this.RewriteIsOfAsIsNull(op, n);
			}
			if (op.IsOfOnly && op.IsOfType.EdmType.Abstract)
			{
				this.m_suppressDiscriminatorMaps = true;
			}
			return n;
		}

		// Token: 0x060029A2 RID: 10658 RVA: 0x00085734 File Offset: 0x00083934
		private bool CanRewriteTypeTest(global::System.Data.Entity.Core.Metadata.Edm.EdmType testType, global::System.Data.Entity.Core.Metadata.Edm.EdmType argumentType)
		{
			if (!testType.EdmEquals(argumentType))
			{
				return false;
			}
			if (testType.BaseType != null)
			{
				return false;
			}
			int num = 0;
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType in global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetTypeAndSubtypesOf(testType, base.m_command.MetadataWorkspace, true))
			{
				num++;
				if (2 == num)
				{
					break;
				}
			}
			return 1 == num;
		}

		// Token: 0x060029A3 RID: 10659 RVA: 0x000857AC File Offset: 0x000839AC
		private global::System.Data.Entity.Core.Query.InternalTrees.Node RewriteIsOfAsIsNull(global::System.Data.Entity.Core.Query.InternalTrees.IsOfOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.ConditionalOp op2 = base.m_command.CreateConditionalOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.IsNull);
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = base.m_command.CreateNode(op2, n.Child0);
			this.ProcessConditionalOp(op2, node);
			global::System.Data.Entity.Core.Query.InternalTrees.ConditionalOp op3 = base.m_command.CreateConditionalOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Not);
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg = base.m_command.CreateNode(op3, node);
			global::System.Data.Entity.Core.Query.InternalTrees.ConstantBaseOp op4 = base.m_command.CreateConstantOp(op.Type, true);
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg2 = base.m_command.CreateNode(op4);
			global::System.Data.Entity.Core.Query.InternalTrees.NullOp op5 = base.m_command.CreateNullOp(op.Type);
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg3 = base.m_command.CreateNode(op5);
			global::System.Data.Entity.Core.Query.InternalTrees.CaseOp op6 = base.m_command.CreateCaseOp(op.Type);
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg4 = base.m_command.CreateNode(op6, arg, arg2, arg3);
			global::System.Data.Entity.Core.Query.InternalTrees.ComparisonOp op7 = base.m_command.CreateComparisonOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.EQ, false);
			return base.m_command.CreateNode(op7, arg4, arg2);
		}

		// Token: 0x060029A4 RID: 10660 RVA: 0x00085890 File Offset: 0x00083A90
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.NavigateOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitScalarOpDefault(op, n);
			global::System.Data.Entity.Core.Query.InternalTrees.Var var;
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = this.RewriteNavigateOp(n, op, out var);
			node = base.VisitNode(node);
			if (var != null)
			{
				node = base.AddSubqueryToParentRelOp(var, node);
			}
			return node;
		}

		// Token: 0x060029A5 RID: 10661 RVA: 0x000858C6 File Offset: 0x00083AC6
		private global::System.Data.Entity.Core.Metadata.Edm.EntitySet GetCurrentEntityTypeScope()
		{
			if (this.m_entityTypeScopes.Count == 0)
			{
				return null;
			}
			return this.m_entityTypeScopes.Peek();
		}

		// Token: 0x060029A6 RID: 10662 RVA: 0x000858E4 File Offset: 0x00083AE4
		private static global::System.Data.Entity.Core.Metadata.Edm.RelationshipSet FindRelationshipSet(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySet, global::System.Data.Entity.Core.Query.InternalTrees.RelProperty relProperty)
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySetBase in entitySet.EntityContainer.BaseEntitySets)
			{
				global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet = entitySetBase as global::System.Data.Entity.Core.Metadata.Edm.AssociationSet;
				if (associationSet != null && associationSet.ElementType.EdmEquals(relProperty.Relationship) && associationSet.AssociationSetEnds[relProperty.FromEnd.Identity].EntitySet.EdmEquals(entitySet))
				{
					return associationSet;
				}
			}
			return null;
		}

		// Token: 0x060029A7 RID: 10663 RVA: 0x0008597C File Offset: 0x00083B7C
		private static int FindPosition(global::System.Data.Entity.Core.Metadata.Edm.EdmType type, global::System.Data.Entity.Core.Metadata.Edm.EdmMember member)
		{
			int num = 0;
			using (global::System.Collections.IEnumerator enumerator = global::System.Data.Entity.Core.Common.TypeHelpers.GetAllStructuralMembers(type).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (((global::System.Data.Entity.Core.Metadata.Edm.EdmMember)enumerator.Current).EdmEquals(member))
					{
						return num;
					}
					num++;
				}
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(false, "Could not find property " + ((member != null) ? member.ToString() : null) + " in type " + type.Name);
			return -1;
		}

		// Token: 0x060029A8 RID: 10664 RVA: 0x00085A0C File Offset: 0x00083C0C
		private global::System.Data.Entity.Core.Query.InternalTrees.Node BuildKeyExpressionForNewEntityOp(global::System.Data.Entity.Core.Query.InternalTrees.Op op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.NewEntity || op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.DiscriminatedNewEntity, "BuildKeyExpression: Unexpected OpType:" + op.OpType.ToString());
			int num = (op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.DiscriminatedNewEntity) ? 1 : 0;
			global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase entityTypeBase = (global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase)op.Type.EdmType;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>> list2 = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember in entityTypeBase.KeyMembers)
			{
				int num2 = global::System.Data.Entity.Core.Query.PlanCompiler.PreProcessor.FindPosition(entityTypeBase, edmMember) + num;
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(n.Children.Count > num2, "invalid position " + num2.ToString() + "; total count = " + n.Children.Count.ToString());
				list.Add(n.Children[num2]);
				list2.Add(new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(edmMember.Name, edmMember.TypeUsage));
			}
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type = global::System.Data.Entity.Core.Common.TypeHelpers.CreateRowTypeUsage(list2);
			global::System.Data.Entity.Core.Query.InternalTrees.NewRecordOp op2 = base.m_command.CreateNewRecordOp(type);
			return base.m_command.CreateNode(op2, list);
		}

		// Token: 0x060029A9 RID: 10665 RVA: 0x00085B60 File Offset: 0x00083D60
		private global::System.Data.Entity.Core.Query.InternalTrees.Node BuildRelPropertyExpression(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySet, global::System.Data.Entity.Core.Query.InternalTrees.RelProperty relProperty, global::System.Data.Entity.Core.Query.InternalTrees.Node keyExpr)
		{
			keyExpr = global::System.Data.Entity.Core.Query.InternalTrees.OpCopier.Copy(base.m_command, keyExpr);
			global::System.Data.Entity.Core.Metadata.Edm.RelationshipSet relationshipSet = global::System.Data.Entity.Core.Query.PlanCompiler.PreProcessor.FindRelationshipSet(entitySet, relProperty);
			if (relationshipSet == null)
			{
				return base.m_command.CreateNode(base.m_command.CreateNullOp(relProperty.ToEnd.TypeUsage));
			}
			global::System.Data.Entity.Core.Query.InternalTrees.ScanTableOp scanTableOp = base.m_command.CreateScanTableOp(global::System.Data.Entity.Core.Query.InternalTrees.Command.CreateTableDefinition(relationshipSet));
			bool condition = scanTableOp.Table.Columns.Count == 1;
			string str = "Unexpected column count for table:";
			global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase extent = scanTableOp.Table.TableMetadata.Extent;
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(condition, str + ((extent != null) ? extent.ToString() : null) + "=" + scanTableOp.Table.Columns.Count.ToString());
			global::System.Data.Entity.Core.Query.InternalTrees.Var var = scanTableOp.Table.Columns[0];
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg = base.m_command.CreateNode(scanTableOp);
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg2 = base.m_command.CreateNode(base.m_command.CreatePropertyOp(relProperty.FromEnd), base.m_command.CreateNode(base.m_command.CreateVarRefOp(var)));
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg3 = base.m_command.BuildComparison(global::System.Data.Entity.Core.Query.InternalTrees.OpType.EQ, keyExpr, base.m_command.CreateNode(base.m_command.CreateGetRefKeyOp(keyExpr.Op.Type), arg2), true);
			global::System.Data.Entity.Core.Query.InternalTrees.Node n = base.m_command.CreateNode(base.m_command.CreateFilterOp(), arg, arg3);
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = base.VisitNode(n);
			node = base.AddSubqueryToParentRelOp(var, node);
			return base.m_command.CreateNode(base.m_command.CreatePropertyOp(relProperty.ToEnd), node);
		}

		// Token: 0x060029AA RID: 10666 RVA: 0x00085CF0 File Offset: 0x00083EF0
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.InternalTrees.Node> BuildAllRelPropertyExpressions(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySet, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty> relPropertyList, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty, global::System.Data.Entity.Core.Query.InternalTrees.Node> prebuiltExpressions, global::System.Data.Entity.Core.Query.InternalTrees.Node keyExpr)
		{
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.RelProperty relProperty in relPropertyList)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Node node;
				if (!prebuiltExpressions.TryGetValue(relProperty, out node))
				{
					node = this.BuildRelPropertyExpression(entitySet, relProperty, keyExpr);
				}
				yield return node;
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty>.Enumerator enumerator = default(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty>.Enumerator);
			yield break;
			yield break;
		}

		// Token: 0x060029AB RID: 10667 RVA: 0x00085D20 File Offset: 0x00083F20
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.NewEntityOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			if (op.Scoped || op.Type.EdmType.BuiltInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntityType)
			{
				return base.Visit(op, n);
			}
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)op.Type.EdmType;
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet currentEntityTypeScope = this.GetCurrentEntityTypeScope();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty> list;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list2;
			if (currentEntityTypeScope == null)
			{
				this.m_freeFloatingEntityConstructorTypes.Add(entityType);
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(op.RelationshipProperties == null || op.RelationshipProperties.Count == 0, "Related Entities cannot be specified for Entity constructors that are not part of the Query Mapping View for an Entity Set.");
				this.VisitScalarOpDefault(op, n);
				list = op.RelationshipProperties;
				list2 = n.Children;
			}
			else
			{
				list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty>(this.m_relPropertyHelper.GetRelProperties(entityType));
				int num = op.RelationshipProperties.Count - 1;
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty> list3 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty>(op.RelationshipProperties);
				int i = n.Children.Count - 1;
				while (i >= entityType.Properties.Count)
				{
					if (!list.Contains(op.RelationshipProperties[num]))
					{
						n.Children.RemoveAt(i);
						list3.RemoveAt(num);
					}
					i--;
					num--;
				}
				this.VisitScalarOpDefault(op, n);
				global::System.Data.Entity.Core.Query.InternalTrees.Node keyExpr = this.BuildKeyExpressionForNewEntityOp(op, n);
				global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty, global::System.Data.Entity.Core.Query.InternalTrees.Node> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty, global::System.Data.Entity.Core.Query.InternalTrees.Node>();
				num = 0;
				int j = entityType.Properties.Count;
				while (j < n.Children.Count)
				{
					dictionary[list3[num]] = n.Children[j];
					j++;
					num++;
				}
				list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
				for (int k = 0; k < entityType.Properties.Count; k++)
				{
					list2.Add(n.Children[k]);
				}
				foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node item in this.BuildAllRelPropertyExpressions(currentEntityTypeScope, list, dictionary, keyExpr))
				{
					list2.Add(item);
				}
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Op op2 = base.m_command.CreateScopedNewEntityOp(op.Type, list, currentEntityTypeScope);
			return base.m_command.CreateNode(op2, list2);
		}

		// Token: 0x060029AC RID: 10668 RVA: 0x00085F48 File Offset: 0x00084148
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.DiscriminatedNewEntityOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty> hashSet = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty>();
			foreach (global::System.Collections.Generic.KeyValuePair<object, global::System.Data.Entity.Core.Metadata.Edm.EntityType> keyValuePair in op.DiscriminatorMap.TypeMap)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase value = keyValuePair.Value;
				this.AddTypeReference(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(value));
				foreach (global::System.Data.Entity.Core.Query.InternalTrees.RelProperty item in this.m_relPropertyHelper.GetRelProperties(value))
				{
					hashSet.Add(item);
				}
			}
			list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty>(hashSet);
			this.VisitScalarOpDefault(op, n);
			global::System.Data.Entity.Core.Query.InternalTrees.Node keyExpr = this.BuildKeyExpressionForNewEntityOp(op, n);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
			int num = n.Children.Count - op.RelationshipProperties.Count;
			for (int i = 0; i < num; i++)
			{
				list2.Add(n.Children[i]);
			}
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty, global::System.Data.Entity.Core.Query.InternalTrees.Node> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty, global::System.Data.Entity.Core.Query.InternalTrees.Node>();
			int j = num;
			int num2 = 0;
			while (j < n.Children.Count)
			{
				dictionary[op.RelationshipProperties[num2]] = n.Children[j];
				j++;
				num2++;
			}
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node item2 in this.BuildAllRelPropertyExpressions(op.EntitySet, list, dictionary, keyExpr))
			{
				list2.Add(item2);
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Op op2 = base.m_command.CreateDiscriminatedNewEntityOp(op.Type, op.DiscriminatorMap, op.EntitySet, list);
			return base.m_command.CreateNode(op2, list2);
		}

		// Token: 0x060029AD RID: 10669 RVA: 0x0008612C File Offset: 0x0008432C
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.NewMultisetOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = null;
			global::System.Data.Entity.Core.Query.InternalTrees.Var var = null;
			global::System.Data.Entity.Core.Metadata.Edm.CollectionType edmType = global::System.Data.Entity.Core.Common.TypeHelpers.GetEdmType<global::System.Data.Entity.Core.Metadata.Edm.CollectionType>(op.Type);
			if (!n.HasChild0)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Node arg = base.m_command.CreateNode(base.m_command.CreateSingleRowTableOp());
				global::System.Data.Entity.Core.Query.InternalTrees.Node input = base.m_command.CreateNode(base.m_command.CreateFilterOp(), arg, base.m_command.CreateNode(base.m_command.CreateFalseOp()));
				global::System.Data.Entity.Core.Query.InternalTrees.Node computedExpression = base.m_command.CreateNode(base.m_command.CreateNullOp(edmType.TypeUsage));
				global::System.Data.Entity.Core.Query.InternalTrees.Var var2;
				node = base.m_command.BuildProject(input, computedExpression, out var2);
				var = var2;
			}
			else if (n.Children.Count == 1 || global::System.Data.Entity.Core.Query.PlanCompiler.PreProcessor.AreAllConstantsOrNulls(n.Children))
			{
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var>();
				foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node computedExpression2 in n.Children)
				{
					global::System.Data.Entity.Core.Query.InternalTrees.Node input2 = base.m_command.CreateNode(base.m_command.CreateSingleRowTableOp());
					global::System.Data.Entity.Core.Query.InternalTrees.Var item2;
					global::System.Data.Entity.Core.Query.InternalTrees.Node item = base.m_command.BuildProject(input2, computedExpression2, out item2);
					list.Add(item);
					list2.Add(item2);
				}
				base.m_command.BuildUnionAllLadder(list, list2, out node, out var);
			}
			else
			{
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list3 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var> list4 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var>();
				for (int i = 0; i < n.Children.Count; i++)
				{
					global::System.Data.Entity.Core.Query.InternalTrees.Node input3 = base.m_command.CreateNode(base.m_command.CreateSingleRowTableOp());
					global::System.Data.Entity.Core.Query.InternalTrees.Node computedExpression3 = base.m_command.CreateNode(base.m_command.CreateInternalConstantOp(base.m_command.IntegerType, i));
					global::System.Data.Entity.Core.Query.InternalTrees.Var item4;
					global::System.Data.Entity.Core.Query.InternalTrees.Node item3 = base.m_command.BuildProject(input3, computedExpression3, out item4);
					list3.Add(item3);
					list4.Add(item4);
				}
				base.m_command.BuildUnionAllLadder(list3, list4, out node, out var);
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list5 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>(n.Children.Count * 2 + 1);
				for (int j = 0; j < n.Children.Count; j++)
				{
					if (j != n.Children.Count - 1)
					{
						global::System.Data.Entity.Core.Query.InternalTrees.ComparisonOp op2 = base.m_command.CreateComparisonOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.EQ, false);
						global::System.Data.Entity.Core.Query.InternalTrees.Node item5 = base.m_command.CreateNode(op2, base.m_command.CreateNode(base.m_command.CreateVarRefOp(var)), base.m_command.CreateNode(base.m_command.CreateConstantOp(base.m_command.IntegerType, j)));
						list5.Add(item5);
					}
					list5.Add(n.Children[j]);
				}
				global::System.Data.Entity.Core.Query.InternalTrees.Node computedExpression4 = base.m_command.CreateNode(base.m_command.CreateCaseOp(edmType.TypeUsage), list5);
				node = base.m_command.BuildProject(node, computedExpression4, out var);
			}
			global::System.Data.Entity.Core.Query.InternalTrees.PhysicalProjectOp op3 = base.m_command.CreatePhysicalProjectOp(var);
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg2 = base.m_command.CreateNode(op3, node);
			global::System.Data.Entity.Core.Query.InternalTrees.CollectOp op4 = base.m_command.CreateCollectOp(op.Type);
			global::System.Data.Entity.Core.Query.InternalTrees.Node n2 = base.m_command.CreateNode(op4, arg2);
			return base.VisitNode(n2);
		}

		// Token: 0x060029AE RID: 10670 RVA: 0x00086474 File Offset: 0x00084674
		private static bool AreAllConstantsOrNulls(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> nodes)
		{
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node node in nodes)
			{
				if (node.Op.OpType != global::System.Data.Entity.Core.Query.InternalTrees.OpType.Constant && node.Op.OpType != global::System.Data.Entity.Core.Query.InternalTrees.OpType.Null)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060029AF RID: 10671 RVA: 0x000864E0 File Offset: 0x000846E0
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.CollectOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.m_compilerState.MarkPhaseAsNeeded(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompilerPhase.NestPullup);
			return this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x060029B0 RID: 10672 RVA: 0x000864F8 File Offset: 0x000846F8
		private void HandleTableOpMetadata(global::System.Data.Entity.Core.Query.InternalTrees.ScanTableBaseOp op)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = op.Table.TableMetadata.Extent as global::System.Data.Entity.Core.Metadata.Edm.EntitySet;
			if (entitySet != null)
			{
				this.AddEntitySetReference(entitySet);
			}
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(op.Table.TableMetadata.Extent.ElementType);
			this.AddTypeReference(type);
		}

		// Token: 0x060029B1 RID: 10673 RVA: 0x00086548 File Offset: 0x00084748
		private global::System.Data.Entity.Core.Query.InternalTrees.Node ProcessScanTable(global::System.Data.Entity.Core.Query.InternalTrees.Node scanTableNode, global::System.Data.Entity.Core.Query.InternalTrees.ScanTableOp scanTableOp, ref global::System.Data.Entity.Core.Query.InternalTrees.IsOfOp typeFilter)
		{
			this.HandleTableOpMetadata(scanTableOp);
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(scanTableOp.Table.TableMetadata.Extent != null, "ScanTableOp must reference a table with an extent");
			if (scanTableOp.Table.TableMetadata.Extent.EntityContainer.DataSpace == global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace)
			{
				return scanTableNode;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node n = this.ExpandView(scanTableOp, ref typeFilter);
			return base.VisitNode(n);
		}

		// Token: 0x060029B2 RID: 10674 RVA: 0x000865AC File Offset: 0x000847AC
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.ScanTableOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.IsOfOp isOfOp = null;
			return this.ProcessScanTable(n, op, ref isOfOp);
		}

		// Token: 0x060029B3 RID: 10675 RVA: 0x000865C8 File Offset: 0x000847C8
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.ScanViewOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			bool flag = false;
			if (op.Table.TableMetadata.Extent.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntitySet)
			{
				this.m_entityTypeScopes.Push((global::System.Data.Entity.Core.Metadata.Edm.EntitySet)op.Table.TableMetadata.Extent);
				flag = true;
			}
			this.HandleTableOpMetadata(op);
			this.VisitRelOpDefault(op, n);
			if (flag)
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(this.m_entityTypeScopes.Pop() == op.Table.TableMetadata.Extent, "m_entityTypeScopes stack is broken");
			}
			return n;
		}

		// Token: 0x060029B4 RID: 10676 RVA: 0x0008664D File Offset: 0x0008484D
		protected override global::System.Data.Entity.Core.Query.InternalTrees.Node VisitJoinOp(global::System.Data.Entity.Core.Query.InternalTrees.JoinBaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			if (op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.InnerJoin || op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.LeftOuterJoin)
			{
				this.m_compilerState.MarkPhaseAsNeeded(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompilerPhase.JoinElimination);
			}
			if (base.ProcessJoinOp(n))
			{
				this.m_compilerState.MarkPhaseAsNeeded(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompilerPhase.Normalization);
			}
			return n;
		}

		// Token: 0x060029B5 RID: 10677 RVA: 0x00086685 File Offset: 0x00084885
		protected override global::System.Data.Entity.Core.Query.InternalTrees.Node VisitApplyOp(global::System.Data.Entity.Core.Query.InternalTrees.ApplyBaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.m_compilerState.MarkPhaseAsNeeded(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompilerPhase.JoinElimination);
			return this.VisitRelOpDefault(op, n);
		}

		// Token: 0x060029B6 RID: 10678 RVA: 0x0008669B File Offset: 0x0008489B
		private bool IsSortUnnecessary()
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = this.m_ancestors.Peek();
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(node != null, "unexpected SortOp as root node?");
			return node.Op.OpType != global::System.Data.Entity.Core.Query.InternalTrees.OpType.PhysicalProject;
		}

		// Token: 0x060029B7 RID: 10679 RVA: 0x000866C7 File Offset: 0x000848C7
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.SortOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			if (this.IsSortUnnecessary())
			{
				return base.VisitNode(n.Child0);
			}
			return this.VisitRelOpDefault(op, n);
		}

		// Token: 0x060029B8 RID: 10680 RVA: 0x000866E8 File Offset: 0x000848E8
		private static bool IsOfTypeOverScanTable(global::System.Data.Entity.Core.Query.InternalTrees.Node n, out global::System.Data.Entity.Core.Query.InternalTrees.IsOfOp typeFilter)
		{
			typeFilter = null;
			global::System.Data.Entity.Core.Query.InternalTrees.IsOfOp isOfOp = n.Child1.Op as global::System.Data.Entity.Core.Query.InternalTrees.IsOfOp;
			if (isOfOp == null)
			{
				return false;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.ScanTableOp scanTableOp = n.Child0.Op as global::System.Data.Entity.Core.Query.InternalTrees.ScanTableOp;
			if (scanTableOp == null || scanTableOp.Table.Columns.Count != 1)
			{
				return false;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp varRefOp = n.Child1.Child0.Op as global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp;
			if (varRefOp == null || varRefOp.Var != scanTableOp.Table.Columns[0])
			{
				return false;
			}
			typeFilter = isOfOp;
			return true;
		}

		// Token: 0x060029B9 RID: 10681 RVA: 0x00086770 File Offset: 0x00084970
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.FilterOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.IsOfOp isOfOp;
			if (global::System.Data.Entity.Core.Query.PlanCompiler.PreProcessor.IsOfTypeOverScanTable(n, out isOfOp))
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Node node = this.ProcessScanTable(n.Child0, (global::System.Data.Entity.Core.Query.InternalTrees.ScanTableOp)n.Child0.Op, ref isOfOp);
				if (isOfOp != null)
				{
					n.Child1 = base.VisitNode(n.Child1);
					n.Child0 = node;
					node = n;
				}
				return node;
			}
			return this.VisitRelOpDefault(op, n);
		}

		// Token: 0x060029BA RID: 10682 RVA: 0x000867D0 File Offset: 0x000849D0
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(n.HasChild0, "projectOp without input?");
			if (global::System.Data.Entity.Core.Query.InternalTrees.OpType.Sort == n.Child0.Op.OpType || global::System.Data.Entity.Core.Query.InternalTrees.OpType.ConstrainedSort == n.Child0.Op.OpType)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.SortBaseOp sortBaseOp = (global::System.Data.Entity.Core.Query.InternalTrees.SortBaseOp)n.Child0.Op;
				if (sortBaseOp.Keys.Count > 0)
				{
					global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Query.InternalTrees.Node> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
					list.Add(n);
					for (int i = 1; i < n.Child0.Children.Count; i++)
					{
						list.Add(n.Child0.Children[i]);
					}
					n.Child0 = n.Child0.Child0;
					foreach (global::System.Data.Entity.Core.Query.InternalTrees.SortKey sortKey in sortBaseOp.Keys)
					{
						op.Outputs.Set(sortKey.Var);
					}
					return base.VisitNode(base.m_command.CreateNode(sortBaseOp, list));
				}
			}
			return this.VisitRelOpDefault(op, n);
		}

		// Token: 0x060029BB RID: 10683 RVA: 0x000868F8 File Offset: 0x00084AF8
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.GroupByIntoOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.m_compilerState.MarkPhaseAsNeeded(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompilerPhase.AggregatePushdown);
			return base.Visit(op, n);
		}

		// Token: 0x060029BC RID: 10684 RVA: 0x0008690E File Offset: 0x00084B0E
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.ComparisonOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			if (op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.EQ || op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.NE)
			{
				this.m_compilerState.MarkPhaseAsNeeded(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompilerPhase.NullSemantics);
			}
			return base.Visit(op, n);
		}

		// Token: 0x04000E5A RID: 3674
		private readonly global::System.Collections.Generic.Stack<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> m_entityTypeScopes = new global::System.Collections.Generic.Stack<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>();

		// Token: 0x04000E5B RID: 3675
		private readonly global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer> m_referencedEntityContainers = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer>();

		// Token: 0x04000E5C RID: 3676
		private readonly global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> m_referencedEntitySets = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>();

		// Token: 0x04000E5D RID: 3677
		private readonly global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> m_referencedTypes = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>();

		// Token: 0x04000E5E RID: 3678
		private readonly global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.EntityType> m_freeFloatingEntityConstructorTypes = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.EntityType>();

		// Token: 0x04000E5F RID: 3679
		private readonly global::System.Collections.Generic.HashSet<string> m_typesNeedingNullSentinel = new global::System.Collections.Generic.HashSet<string>();

		// Token: 0x04000E60 RID: 3680
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[]> m_tvfResultKeys = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[]>();

		// Token: 0x04000E61 RID: 3681
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.RelPropertyHelper m_relPropertyHelper;

		// Token: 0x04000E62 RID: 3682
		private bool m_suppressDiscriminatorMaps;

		// Token: 0x04000E63 RID: 3683
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Query.PlanCompiler.DiscriminatorMapInfo> m_discriminatorMaps = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Query.PlanCompiler.DiscriminatorMapInfo>();

		// Token: 0x04000E64 RID: 3684
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.PlanCompiler.PreProcessor.NavigationPropertyOpInfo, global::System.Data.Entity.Core.Query.InternalTrees.Node> _navigationPropertyOpRewrites = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.PlanCompiler.PreProcessor.NavigationPropertyOpInfo, global::System.Data.Entity.Core.Query.InternalTrees.Node>();

		// Token: 0x020009F3 RID: 2547
		private class NavigationPropertyOpInfo
		{
			// Token: 0x06006035 RID: 24629 RVA: 0x00149E34 File Offset: 0x00148034
			public NavigationPropertyOpInfo(global::System.Data.Entity.Core.Query.InternalTrees.Node node, global::System.Data.Entity.Core.Query.InternalTrees.Node root, global::System.Data.Entity.Core.Query.InternalTrees.Command command)
			{
				this._node = node;
				this._root = root;
				this._command = command;
				this._hashCode = ((((this._root != null) ? global::System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(this._root) : 0) * 397 ^ global::System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(global::System.Data.Entity.Core.Query.PlanCompiler.PreProcessor.NavigationPropertyOpInfo.GetProperty(this._node))) * 397 ^ this._node.GetNodeInfo(this._command).HashValue);
			}

			// Token: 0x06006036 RID: 24630 RVA: 0x00149EAC File Offset: 0x001480AC
			public override int GetHashCode()
			{
				return this._hashCode;
			}

			// Token: 0x06006037 RID: 24631 RVA: 0x00149EB4 File Offset: 0x001480B4
			public override bool Equals(object obj)
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.PreProcessor.NavigationPropertyOpInfo navigationPropertyOpInfo = obj as global::System.Data.Entity.Core.Query.PlanCompiler.PreProcessor.NavigationPropertyOpInfo;
				return navigationPropertyOpInfo != null && this._root != null && this._root == navigationPropertyOpInfo._root && global::System.Data.Entity.Core.Query.PlanCompiler.PreProcessor.NavigationPropertyOpInfo.GetProperty(this._node) == global::System.Data.Entity.Core.Query.PlanCompiler.PreProcessor.NavigationPropertyOpInfo.GetProperty(navigationPropertyOpInfo._node) && this._node.IsEquivalent(navigationPropertyOpInfo._node);
			}

			// Token: 0x06006038 RID: 24632 RVA: 0x00149F0C File Offset: 0x0014810C
			public void Seal()
			{
				this._node = global::System.Data.Entity.Core.Query.InternalTrees.OpCopier.Copy(this._command, this._node);
			}

			// Token: 0x06006039 RID: 24633 RVA: 0x00149F25 File Offset: 0x00148125
			private static global::System.Data.Entity.Core.Metadata.Edm.EdmMember GetProperty(global::System.Data.Entity.Core.Query.InternalTrees.Node node)
			{
				return ((global::System.Data.Entity.Core.Query.InternalTrees.PropertyOp)node.Op).PropertyInfo;
			}

			// Token: 0x040028BF RID: 10431
			private global::System.Data.Entity.Core.Query.InternalTrees.Node _node;

			// Token: 0x040028C0 RID: 10432
			private readonly global::System.Data.Entity.Core.Query.InternalTrees.Node _root;

			// Token: 0x040028C1 RID: 10433
			private readonly global::System.Data.Entity.Core.Query.InternalTrees.Command _command;

			// Token: 0x040028C2 RID: 10434
			private readonly int _hashCode;
		}
	}
}
