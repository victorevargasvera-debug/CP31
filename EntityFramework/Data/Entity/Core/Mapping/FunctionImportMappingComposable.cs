using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping.ViewGeneration;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Query.InternalTrees;
using System.Data.Entity.Core.Query.PlanCompiler;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x02000538 RID: 1336
	public sealed class FunctionImportMappingComposable : global::System.Data.Entity.Core.Mapping.FunctionImportMapping
	{
		// Token: 0x060041D4 RID: 16852 RVA: 0x000DD300 File Offset: 0x000DB500
		public FunctionImportMappingComposable(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction functionImport, global::System.Data.Entity.Core.Metadata.Edm.EdmFunction targetFunction, global::System.Data.Entity.Core.Mapping.FunctionImportResultMapping resultMapping, global::System.Data.Entity.Core.Mapping.EntityContainerMapping containerMapping) : base(global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>(functionImport, "functionImport"), global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>(targetFunction, "targetFunction"))
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Mapping.FunctionImportResultMapping>(resultMapping, "resultMapping");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Mapping.EntityContainerMapping>(containerMapping, "containerMapping");
			if (!functionImport.IsComposableAttribute)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.NonComposableFunctionCannotBeMappedAsComposable("functionImport"));
			}
			if (!targetFunction.IsComposableAttribute)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.NonComposableFunctionCannotBeMappedAsComposable("targetFunction"));
			}
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType;
			if (!global::System.Data.Entity.Core.Common.Utils.MetadataHelper.TryGetFunctionImportReturnType<global::System.Data.Entity.Core.Metadata.Edm.EdmType>(functionImport, 0, out edmType))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.InvalidReturnTypeForComposableFunction);
			}
			global::System.Data.Entity.Core.Metadata.Edm.EdmFunction edmFunction = (containerMapping.StorageMappingItemCollection != null) ? containerMapping.StorageMappingItemCollection.StoreItemCollection.ConvertToCTypeFunction(targetFunction) : global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection.ConvertFunctionSignatureToCType(targetFunction);
			global::System.Data.Entity.Core.Metadata.Edm.RowType tvfReturnType = global::System.Data.Entity.Core.Common.TypeHelpers.GetTvfReturnType(edmFunction);
			global::System.Data.Entity.Core.Metadata.Edm.RowType tvfReturnType2 = global::System.Data.Entity.Core.Common.TypeHelpers.GetTvfReturnType(targetFunction);
			if (tvfReturnType == null)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Mapping_FunctionImport_ResultMapping_InvalidSType(functionImport.Identity), "functionImport");
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError>();
			global::System.Data.Entity.Core.Mapping.FunctionImportMappingComposableHelper functionImportMappingComposableHelper = new global::System.Data.Entity.Core.Mapping.FunctionImportMappingComposableHelper(containerMapping, string.Empty, list);
			global::System.Data.Entity.Core.Mapping.FunctionImportMappingComposable functionImportMappingComposable;
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsStructuralType(edmType))
			{
				functionImportMappingComposableHelper.TryCreateFunctionImportMappingComposableWithStructuralResult(functionImport, edmFunction, resultMapping.SourceList, tvfReturnType, tvfReturnType2, global::System.Data.Entity.Core.Mapping.LineInfo.Empty, out functionImportMappingComposable);
			}
			else
			{
				functionImportMappingComposableHelper.TryCreateFunctionImportMappingComposableWithScalarResult(functionImport, edmFunction, targetFunction, edmType, tvfReturnType, global::System.Data.Entity.Core.Mapping.LineInfo.Empty, out functionImportMappingComposable);
			}
			if (functionImportMappingComposable == null)
			{
				throw new global::System.InvalidOperationException((list.Count > 0) ? list[0].Message : string.Empty);
			}
			this._containerMapping = functionImportMappingComposable._containerMapping;
			this.m_commandParameters = functionImportMappingComposable.m_commandParameters;
			this.m_structuralTypeMappings = functionImportMappingComposable.m_structuralTypeMappings;
			this.m_targetFunctionKeys = functionImportMappingComposable.m_targetFunctionKeys;
			this._resultMapping = resultMapping;
		}

		// Token: 0x060041D5 RID: 16853 RVA: 0x000DD484 File Offset: 0x000DB684
		internal FunctionImportMappingComposable(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction functionImport, global::System.Data.Entity.Core.Metadata.Edm.EdmFunction targetFunction, global::System.Collections.Generic.List<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.StructuralType, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping>, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.PropertyMapping>>> structuralTypeMappings) : base(functionImport, targetFunction)
		{
			if (!functionImport.IsComposableAttribute)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.NonComposableFunctionCannotBeMappedAsComposable("functionImport"));
			}
			if (!targetFunction.IsComposableAttribute)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.NonComposableFunctionCannotBeMappedAsComposable("targetFunction"));
			}
			global::System.Data.Entity.Core.Metadata.Edm.EdmType type;
			if (!global::System.Data.Entity.Core.Common.Utils.MetadataHelper.TryGetFunctionImportReturnType<global::System.Data.Entity.Core.Metadata.Edm.EdmType>(functionImport, 0, out type))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.InvalidReturnTypeForComposableFunction);
			}
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsScalarType(type) && (structuralTypeMappings == null || structuralTypeMappings.Count == 0))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.StructuralTypeMappingsMustNotBeNullForFunctionImportsReturningNonScalarValues);
			}
			this.m_structuralTypeMappings = structuralTypeMappings;
		}

		// Token: 0x060041D6 RID: 16854 RVA: 0x000DD504 File Offset: 0x000DB704
		internal FunctionImportMappingComposable(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction functionImport, global::System.Data.Entity.Core.Metadata.Edm.EdmFunction targetFunction, global::System.Collections.Generic.List<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.StructuralType, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping>, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.PropertyMapping>>> structuralTypeMappings, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[] targetFunctionKeys, global::System.Data.Entity.Core.Mapping.EntityContainerMapping containerMapping) : base(functionImport, targetFunction)
		{
			this._containerMapping = containerMapping;
			this.m_commandParameters = (from p in functionImport.Parameters
			select global::System.Data.Entity.Core.Common.TypeHelpers.GetPrimitiveTypeUsageForScalar(p.TypeUsage).Parameter(p.Name)).ToArray<global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression>();
			this.m_structuralTypeMappings = structuralTypeMappings;
			this.m_targetFunctionKeys = targetFunctionKeys;
		}

		// Token: 0x17000D0B RID: 3339
		// (get) Token: 0x060041D7 RID: 16855 RVA: 0x000DD565 File Offset: 0x000DB765
		public global::System.Data.Entity.Core.Mapping.FunctionImportResultMapping ResultMapping
		{
			get
			{
				return this._resultMapping;
			}
		}

		// Token: 0x060041D8 RID: 16856 RVA: 0x000DD56D File Offset: 0x000DB76D
		internal override void SetReadOnly()
		{
			global::System.Data.Entity.Core.Mapping.MappingItem.SetReadOnly(this._resultMapping);
			base.SetReadOnly();
		}

		// Token: 0x17000D0C RID: 3340
		// (get) Token: 0x060041D9 RID: 16857 RVA: 0x000DD580 File Offset: 0x000DB780
		internal global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.StructuralType, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping>, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.PropertyMapping>>> StructuralTypeMappings
		{
			get
			{
				if (this.m_structuralTypeMappings != null)
				{
					return new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.StructuralType, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping>, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.PropertyMapping>>>(this.m_structuralTypeMappings);
				}
				return null;
			}
		}

		// Token: 0x17000D0D RID: 3341
		// (get) Token: 0x060041DA RID: 16858 RVA: 0x000DD597 File Offset: 0x000DB797
		internal global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[] TvfKeys
		{
			get
			{
				return this.m_targetFunctionKeys;
			}
		}

		// Token: 0x060041DB RID: 16859 RVA: 0x000DD5A0 File Offset: 0x000DB7A0
		internal global::System.Data.Entity.Core.Query.InternalTrees.Node GetInternalTree(global::System.Data.Entity.Core.Query.InternalTrees.Command targetIqtCommand, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Query.InternalTrees.Node> targetIqtArguments)
		{
			if (this.m_internalTreeNode == null)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.DiscriminatorMap discriminatorMap;
				global::System.Data.Entity.Core.Query.InternalTrees.Command command = global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.Generate(this.GenerateFunctionView(out discriminatorMap), discriminatorMap);
				global::System.Data.Entity.Core.Query.InternalTrees.Node root = command.Root;
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(root.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.PhysicalProject, "Expected a physical projectOp at the root of the tree - found " + root.Op.OpType.ToString());
				global::System.Data.Entity.Core.Query.InternalTrees.PhysicalProjectOp physicalProjectOp = (global::System.Data.Entity.Core.Query.InternalTrees.PhysicalProjectOp)root.Op;
				global::System.Data.Entity.Core.Query.InternalTrees.Node child = root.Child0;
				command.DisableVarVecEnumCaching();
				global::System.Data.Entity.Core.Query.InternalTrees.Node node = child;
				global::System.Data.Entity.Core.Query.InternalTrees.Var var = physicalProjectOp.Outputs[0];
				if (!global::System.Data.Entity.Core.Query.InternalTrees.Command.EqualTypes(physicalProjectOp.ColumnMap.Type, base.FunctionImport.ReturnParameter.TypeUsage))
				{
					global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = ((global::System.Data.Entity.Core.Metadata.Edm.CollectionType)base.FunctionImport.ReturnParameter.TypeUsage.EdmType).TypeUsage;
					global::System.Data.Entity.Core.Query.InternalTrees.Node arg = command.CreateNode(command.CreateVarRefOp(var));
					global::System.Data.Entity.Core.Query.InternalTrees.Node definingExpr = command.CreateNode(command.CreateSoftCastOp(typeUsage), arg);
					global::System.Data.Entity.Core.Query.InternalTrees.Node arg2 = command.CreateVarDefListNode(definingExpr, out var);
					global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp op = command.CreateProjectOp(var);
					node = command.CreateNode(op, node, arg2);
				}
				this.m_internalTreeNode = command.BuildCollect(node, var);
			}
			global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Query.InternalTrees.Node> dictionary = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Query.InternalTrees.Node>(this.m_commandParameters.Length);
			for (int i = 0; i < this.m_commandParameters.Length; i++)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression dbParameterReferenceExpression = this.m_commandParameters[i];
				global::System.Data.Entity.Core.Query.InternalTrees.Node node2 = targetIqtArguments[i];
				if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEnumerationType(node2.Op.Type))
				{
					node2 = targetIqtCommand.CreateNode(targetIqtCommand.CreateSoftCastOp(global::System.Data.Entity.Core.Common.TypeHelpers.CreateEnumUnderlyingTypeUsage(node2.Op.Type)), node2);
				}
				dictionary.Add(dbParameterReferenceExpression.ParameterName, node2);
			}
			return global::System.Data.Entity.Core.Mapping.FunctionImportMappingComposable.FunctionViewOpCopier.Copy(targetIqtCommand, this.m_internalTreeNode, dictionary);
		}

		// Token: 0x060041DC RID: 16860 RVA: 0x000DD750 File Offset: 0x000DB950
		internal global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree GenerateFunctionView(out global::System.Data.Entity.Core.Mapping.ViewGeneration.DiscriminatorMap discriminatorMap)
		{
			discriminatorMap = null;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression storeFunctionInvoke = base.TargetFunction.Invoke(this.GetParametersForTargetFunctionCall());
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression query;
			if (this.m_structuralTypeMappings != null)
			{
				query = this.GenerateStructuralTypeResultMappingView(storeFunctionInvoke, out discriminatorMap);
			}
			else
			{
				query = this.GenerateScalarResultMappingView(storeFunctionInvoke);
			}
			return global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree.FromValidExpression(this._containerMapping.StorageMappingItemCollection.Workspace, global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace, query, true, false);
		}

		// Token: 0x060041DD RID: 16861 RVA: 0x000DD7A6 File Offset: 0x000DB9A6
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> GetParametersForTargetFunctionCall()
		{
			using (global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter>.Enumerator enumerator = base.TargetFunction.Parameters.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter targetParameter = enumerator.Current;
					global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter value = base.FunctionImport.Parameters.Single((global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter p) => p.Name == targetParameter.Name);
					yield return this.m_commandParameters[base.FunctionImport.Parameters.IndexOf(value)];
				}
			}
			global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter>.Enumerator enumerator = default(global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter>.Enumerator);
			yield break;
			yield break;
		}

		// Token: 0x060041DE RID: 16862 RVA: 0x000DD7B8 File Offset: 0x000DB9B8
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression GenerateStructuralTypeResultMappingView(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression storeFunctionInvoke, out global::System.Data.Entity.Core.Mapping.ViewGeneration.DiscriminatorMap discriminatorMap)
		{
			discriminatorMap = null;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = storeFunctionInvoke;
			if (this.m_structuralTypeMappings.Count == 1)
			{
				global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.StructuralType, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping>, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.PropertyMapping>> tuple = this.m_structuralTypeMappings[0];
				global::System.Data.Entity.Core.Metadata.Edm.StructuralType item = tuple.Item1;
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping> conditions = tuple.Item2;
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.PropertyMapping> item2 = tuple.Item3;
				if (conditions.Count > 0)
				{
					dbExpression = from row in dbExpression
					where global::System.Data.Entity.Core.Mapping.FunctionImportMappingComposable.GenerateStructuralTypeConditionsPredicate(conditions, row)
					select row;
				}
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding = dbExpression.BindAs("row");
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression projection = global::System.Data.Entity.Core.Mapping.FunctionImportMappingComposable.GenerateStructuralTypeMappingView(item, item2, dbExpressionBinding.Variable);
				dbExpression = dbExpressionBinding.Project(projection);
			}
			else
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding binding = dbExpression.BindAs("row");
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> list = (from m in this.m_structuralTypeMappings
				select global::System.Data.Entity.Core.Mapping.FunctionImportMappingComposable.GenerateStructuralTypeConditionsPredicate(m.Item2, binding.Variable)).ToList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>();
				dbExpression = binding.Filter(global::System.Data.Entity.Core.Common.Utils.Helpers.BuildBalancedTreeInPlace<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(list.ToArray(), (global::System.Data.Entity.Core.Common.CommandTrees.DbExpression prev, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression next) => prev.Or(next)));
				binding = dbExpression.BindAs("row");
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(this.m_structuralTypeMappings.Count);
				foreach (global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.StructuralType, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping>, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.PropertyMapping>> tuple2 in this.m_structuralTypeMappings)
				{
					global::System.Data.Entity.Core.Metadata.Edm.StructuralType item3 = tuple2.Item1;
					global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.PropertyMapping> item4 = tuple2.Item3;
					list2.Add(global::System.Data.Entity.Core.Mapping.FunctionImportMappingComposable.GenerateStructuralTypeMappingView(item3, item4, binding.Variable));
				}
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression projection2 = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Case(list.Take(this.m_structuralTypeMappings.Count - 1), list2.Take(this.m_structuralTypeMappings.Count - 1), list2[this.m_structuralTypeMappings.Count - 1]);
				dbExpression = binding.Project(projection2);
				global::System.Data.Entity.Core.Mapping.ViewGeneration.DiscriminatorMap.TryCreateDiscriminatorMap(base.FunctionImport.EntitySet, dbExpression, out discriminatorMap);
			}
			return dbExpression;
		}

		// Token: 0x060041DF RID: 16863 RVA: 0x000DD9B4 File Offset: 0x000DBBB4
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression GenerateStructuralTypeMappingView(global::System.Data.Entity.Core.Metadata.Edm.StructuralType structuralType, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.PropertyMapping> propertyMappings, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression row)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(global::System.Data.Entity.Core.Common.TypeHelpers.GetAllStructuralMembers(structuralType).Count);
			for (int i = 0; i < propertyMappings.Count; i++)
			{
				global::System.Data.Entity.Core.Mapping.PropertyMapping mapping = propertyMappings[i];
				list.Add(global::System.Data.Entity.Core.Mapping.FunctionImportMappingComposable.GeneratePropertyMappingView(mapping, row));
			}
			return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(structuralType).New(list);
		}

		// Token: 0x060041E0 RID: 16864 RVA: 0x000DDA04 File Offset: 0x000DBC04
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression GenerateStructuralTypeConditionsPredicate(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping> conditions, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression row)
		{
			return global::System.Data.Entity.Core.Common.Utils.Helpers.BuildBalancedTreeInPlace<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>((from c in conditions
			select global::System.Data.Entity.Core.Mapping.FunctionImportMappingComposable.GeneratePredicate(c, row)).ToArray<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(), (global::System.Data.Entity.Core.Common.CommandTrees.DbExpression prev, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression next) => prev.And(next));
		}

		// Token: 0x060041E1 RID: 16865 RVA: 0x000DDA5C File Offset: 0x000DBC5C
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression GeneratePredicate(global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping condition, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression row)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = global::System.Data.Entity.Core.Mapping.FunctionImportMappingComposable.GenerateColumnRef(row, condition.Column);
			if (condition.IsNull == null)
			{
				return dbExpression.Equal(dbExpression.ResultType.Constant(condition.Value));
			}
			if (!condition.IsNull.Value)
			{
				return dbExpression.IsNull().Not();
			}
			return dbExpression.IsNull();
		}

		// Token: 0x060041E2 RID: 16866 RVA: 0x000DDAC0 File Offset: 0x000DBCC0
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression GeneratePropertyMappingView(global::System.Data.Entity.Core.Mapping.PropertyMapping mapping, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression row)
		{
			global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping scalarPropertyMapping = (global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping)mapping;
			return global::System.Data.Entity.Core.Mapping.FunctionImportMappingComposable.GenerateScalarPropertyMappingView(scalarPropertyMapping.Property, scalarPropertyMapping.Column, row);
		}

		// Token: 0x060041E3 RID: 16867 RVA: 0x000DDAE8 File Offset: 0x000DBCE8
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression GenerateScalarPropertyMappingView(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty columnProperty, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression row)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = global::System.Data.Entity.Core.Mapping.FunctionImportMappingComposable.GenerateColumnRef(row, columnProperty);
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEqual(dbExpression.ResultType, edmProperty.TypeUsage))
			{
				dbExpression = dbExpression.CastTo(edmProperty.TypeUsage);
			}
			return dbExpression;
		}

		// Token: 0x060041E4 RID: 16868 RVA: 0x000DDB1E File Offset: 0x000DBD1E
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression GenerateColumnRef(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression row, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty column)
		{
			global::System.Data.Entity.Core.Metadata.Edm.RowType rowType = (global::System.Data.Entity.Core.Metadata.Edm.RowType)row.ResultType.EdmType;
			return row.Property(column.Name);
		}

		// Token: 0x060041E5 RID: 16869 RVA: 0x000DDB40 File Offset: 0x000DBD40
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression GenerateScalarResultMappingView(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression storeFunctionInvoke)
		{
			global::System.Data.Entity.Core.Metadata.Edm.CollectionType functionImportReturnType;
			global::System.Data.Entity.Core.Common.Utils.MetadataHelper.TryGetFunctionImportReturnCollectionType(base.FunctionImport, 0, out functionImportReturnType);
			global::System.Data.Entity.Core.Metadata.Edm.RowType rowType = (global::System.Data.Entity.Core.Metadata.Edm.RowType)((global::System.Data.Entity.Core.Metadata.Edm.CollectionType)storeFunctionInvoke.ResultType.EdmType).TypeUsage.EdmType;
			global::System.Data.Entity.Core.Metadata.Edm.EdmProperty column = rowType.Properties[0];
			global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> scalarView = delegate(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression row)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression dbPropertyExpression = row.Property(column);
				if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEqual(functionImportReturnType.TypeUsage, column.TypeUsage))
				{
					return dbPropertyExpression;
				}
				return dbPropertyExpression.CastTo(functionImportReturnType.TypeUsage);
			};
			return from row in storeFunctionInvoke
			select scalarView(row);
		}

		// Token: 0x040016D2 RID: 5842
		private readonly global::System.Data.Entity.Core.Mapping.FunctionImportResultMapping _resultMapping;

		// Token: 0x040016D3 RID: 5843
		private readonly global::System.Data.Entity.Core.Mapping.EntityContainerMapping _containerMapping;

		// Token: 0x040016D4 RID: 5844
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression[] m_commandParameters;

		// Token: 0x040016D5 RID: 5845
		private readonly global::System.Collections.Generic.List<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.StructuralType, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping>, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.PropertyMapping>>> m_structuralTypeMappings;

		// Token: 0x040016D6 RID: 5846
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[] m_targetFunctionKeys;

		// Token: 0x040016D7 RID: 5847
		private global::System.Data.Entity.Core.Query.InternalTrees.Node m_internalTreeNode;

		// Token: 0x02000B3A RID: 2874
		private sealed class FunctionViewOpCopier : global::System.Data.Entity.Core.Query.InternalTrees.OpCopier
		{
			// Token: 0x06006569 RID: 25961 RVA: 0x0015BF40 File Offset: 0x0015A140
			private FunctionViewOpCopier(global::System.Data.Entity.Core.Query.InternalTrees.Command cmd, global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Query.InternalTrees.Node> viewArguments) : base(cmd)
			{
				this.m_viewArguments = viewArguments;
			}

			// Token: 0x0600656A RID: 25962 RVA: 0x0015BF50 File Offset: 0x0015A150
			internal static global::System.Data.Entity.Core.Query.InternalTrees.Node Copy(global::System.Data.Entity.Core.Query.InternalTrees.Command cmd, global::System.Data.Entity.Core.Query.InternalTrees.Node viewNode, global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Query.InternalTrees.Node> viewArguments)
			{
				return new global::System.Data.Entity.Core.Mapping.FunctionImportMappingComposable.FunctionViewOpCopier(cmd, viewArguments).CopyNode(viewNode);
			}

			// Token: 0x0600656B RID: 25963 RVA: 0x0015BF60 File Offset: 0x0015A160
			public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Node n2;
				if (op.Var.VarType == global::System.Data.Entity.Core.Query.InternalTrees.VarType.Parameter && this.m_viewArguments.TryGetValue(((global::System.Data.Entity.Core.Query.InternalTrees.ParameterVar)op.Var).ParameterName, out n2))
				{
					return global::System.Data.Entity.Core.Query.InternalTrees.OpCopier.Copy(this.m_destCmd, n2);
				}
				return base.Visit(op, n);
			}

			// Token: 0x04002D4C RID: 11596
			private readonly global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Query.InternalTrees.Node> m_viewArguments;
		}
	}
}
