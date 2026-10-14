using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Common;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Metadata.Edm.Provider;
using System.Data.Entity.Core.Query.InternalTrees;
using System.Data.Entity.Core.Query.PlanCompiler;
using System.Data.Entity.Core.Query.ResultAssembly;
using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity.Internal;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity.Core.EntityClient.Internal
{
	// Token: 0x020005E6 RID: 1510
	internal class EntityCommandDefinition : global::System.Data.Entity.Core.Common.DbCommandDefinition
	{
		// Token: 0x060049DC RID: 18908 RVA: 0x00104FA3 File Offset: 0x001031A3
		internal EntityCommandDefinition()
		{
		}

		// Token: 0x060049DD RID: 18909 RVA: 0x00104FAC File Offset: 0x001031AC
		internal EntityCommandDefinition(global::System.Data.Common.DbProviderFactory storeProviderFactory, global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree commandTree, global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext interceptionContext, global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver resolver = null, global::System.Data.Entity.Core.Query.ResultAssembly.BridgeDataReaderFactory bridgeDataReaderFactory = null, global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapFactory columnMapFactory = null)
		{
			this._bridgeDataReaderFactory = (bridgeDataReaderFactory ?? new global::System.Data.Entity.Core.Query.ResultAssembly.BridgeDataReaderFactory(null));
			this._columnMapFactory = (columnMapFactory ?? new global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapFactory());
			this._storeProviderServices = (((resolver != null) ? resolver.GetService(storeProviderFactory.GetProviderInvariantName()) : null) ?? storeProviderFactory.GetProviderServices());
			try
			{
				if (commandTree.CommandTreeKind == global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTreeKind.Query)
				{
					global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.ProviderCommandInfo> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.ProviderCommandInfo>();
					global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap columnMap;
					int fieldsRequired;
					global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Compile(commandTree, out list, out columnMap, out fieldsRequired, out this._entitySets);
					this._columnMapGenerators = new global::System.Data.Entity.Core.EntityClient.Internal.EntityCommandDefinition.IColumnMapGenerator[]
					{
						new global::System.Data.Entity.Core.EntityClient.Internal.EntityCommandDefinition.ConstantColumnMapGenerator(columnMap, fieldsRequired)
					};
					this._mappedCommandDefinitions = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.DbCommandDefinition>(list.Count);
					using (global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.ProviderCommandInfo>.Enumerator enumerator = list.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							global::System.Data.Entity.Core.Query.PlanCompiler.ProviderCommandInfo providerCommandInfo = enumerator.Current;
							global::System.Data.Entity.Core.Common.DbCommandDefinition dbCommandDefinition = this._storeProviderServices.CreateCommandDefinition(providerCommandInfo.CommandTree, interceptionContext);
							if (dbCommandDefinition == null)
							{
								throw new global::System.Data.Entity.Core.ProviderIncompatibleException(global::System.Data.Entity.Resources.Strings.ProviderReturnedNullForCreateCommandDefinition);
							}
							this._mappedCommandDefinitions.Add(dbCommandDefinition);
						}
						goto IL_23C;
					}
				}
				global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionCommandTree dbFunctionCommandTree = (global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionCommandTree)commandTree;
				global::System.Data.Entity.Core.Mapping.FunctionImportMappingNonComposable targetFunctionMapping = global::System.Data.Entity.Core.EntityClient.Internal.EntityCommandDefinition.GetTargetFunctionMapping(dbFunctionCommandTree);
				global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter> returnParameters = dbFunctionCommandTree.EdmFunction.ReturnParameters;
				int num = (returnParameters.Count > 1) ? returnParameters.Count : 1;
				this._columnMapGenerators = new global::System.Data.Entity.Core.EntityClient.Internal.EntityCommandDefinition.IColumnMapGenerator[num];
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage resultType = this.DetermineStoreResultType(targetFunctionMapping, 0, out this._columnMapGenerators[0]);
				for (int i = 1; i < num; i++)
				{
					this.DetermineStoreResultType(targetFunctionMapping, i, out this._columnMapGenerators[i]);
				}
				global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>> list2 = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>>();
				foreach (global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> item in dbFunctionCommandTree.Parameters)
				{
					list2.Add(item);
				}
				global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionCommandTree commandTree2 = new global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionCommandTree(dbFunctionCommandTree.MetadataWorkspace, global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace, targetFunctionMapping.TargetFunction, resultType, list2);
				global::System.Data.Entity.Core.Common.DbCommandDefinition item2 = this._storeProviderServices.CreateCommandDefinition(commandTree2);
				this._mappedCommandDefinitions = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.DbCommandDefinition>(1)
				{
					item2
				};
				if (targetFunctionMapping.FunctionImport.EntitySets.FirstOrDefault<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>() != null)
				{
					this._entitySets = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>();
					this._entitySets.Add(targetFunctionMapping.FunctionImport.EntitySets.FirstOrDefault<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>());
					this._entitySets.MakeReadOnly();
				}
				IL_23C:
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.EntityClient.EntityParameter> list3 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.EntityClient.EntityParameter>();
				foreach (global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> queryParameter in commandTree.Parameters)
				{
					global::System.Data.Entity.Core.EntityClient.EntityParameter item3 = global::System.Data.Entity.Core.EntityClient.Internal.EntityCommandDefinition.CreateEntityParameterFromQueryParameter(queryParameter);
					list3.Add(item3);
				}
				this._parameters = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.EntityClient.EntityParameter>(list3);
			}
			catch (global::System.Data.Entity.Core.EntityCommandCompilationException)
			{
				throw;
			}
			catch (global::System.Exception ex)
			{
				if (ex.IsCatchableExceptionType())
				{
					throw new global::System.Data.Entity.Core.EntityCommandCompilationException(global::System.Data.Entity.Resources.Strings.EntityClient_CommandDefinitionPreparationFailed, ex);
				}
				throw;
			}
		}

		// Token: 0x060049DE RID: 18910 RVA: 0x001052E0 File Offset: 0x001034E0
		protected EntityCommandDefinition(global::System.Data.Entity.Core.Query.ResultAssembly.BridgeDataReaderFactory factory = null, global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapFactory columnMapFactory = null, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.DbCommandDefinition> mappedCommandDefinitions = null)
		{
			this._bridgeDataReaderFactory = (factory ?? new global::System.Data.Entity.Core.Query.ResultAssembly.BridgeDataReaderFactory(null));
			this._columnMapFactory = (columnMapFactory ?? new global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapFactory());
			this._mappedCommandDefinitions = mappedCommandDefinitions;
		}

		// Token: 0x060049DF RID: 18911 RVA: 0x00105310 File Offset: 0x00103510
		private global::System.Data.Entity.Core.Metadata.Edm.TypeUsage DetermineStoreResultType(global::System.Data.Entity.Core.Mapping.FunctionImportMappingNonComposable mapping, int resultSetIndex, out global::System.Data.Entity.Core.EntityClient.Internal.EntityCommandDefinition.IColumnMapGenerator columnMapGenerator)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmFunction functionImport = mapping.FunctionImport;
			global::System.Data.Entity.Core.Metadata.Edm.StructuralType structuralType;
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage;
			if (global::System.Data.Entity.Core.Common.Utils.MetadataHelper.TryGetFunctionImportReturnType<global::System.Data.Entity.Core.Metadata.Edm.StructuralType>(functionImport, resultSetIndex, out structuralType))
			{
				global::System.Data.Entity.Core.EntityClient.Internal.EntityCommandDefinition.ValidateEdmResultType(structuralType, functionImport);
				global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = (functionImport.EntitySets.Count > resultSetIndex) ? functionImport.EntitySets[resultSetIndex] : null;
				columnMapGenerator = new global::System.Data.Entity.Core.EntityClient.Internal.EntityCommandDefinition.FunctionColumnMapGenerator(mapping, resultSetIndex, entitySet, structuralType, this._columnMapFactory);
				typeUsage = mapping.GetExpectedTargetResultType(resultSetIndex);
			}
			else
			{
				global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter returnParameter = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetReturnParameter(functionImport, resultSetIndex);
				if (returnParameter != null && returnParameter.TypeUsage != null)
				{
					typeUsage = returnParameter.TypeUsage;
					global::System.Data.Entity.Core.Query.InternalTrees.ScalarColumnMap elementMap = new global::System.Data.Entity.Core.Query.InternalTrees.ScalarColumnMap(((global::System.Data.Entity.Core.Metadata.Edm.CollectionType)typeUsage.EdmType).TypeUsage, string.Empty, 0, 0);
					global::System.Data.Entity.Core.Query.InternalTrees.SimpleCollectionColumnMap columnMap = new global::System.Data.Entity.Core.Query.InternalTrees.SimpleCollectionColumnMap(typeUsage, string.Empty, elementMap, null, null);
					columnMapGenerator = new global::System.Data.Entity.Core.EntityClient.Internal.EntityCommandDefinition.ConstantColumnMapGenerator(columnMap, 1);
				}
				else
				{
					typeUsage = null;
					columnMapGenerator = new global::System.Data.Entity.Core.EntityClient.Internal.EntityCommandDefinition.ConstantColumnMapGenerator(null, 0);
				}
			}
			return typeUsage;
		}

		// Token: 0x060049E0 RID: 18912 RVA: 0x001053D4 File Offset: 0x001035D4
		private static void ValidateEdmResultType(global::System.Data.Entity.Core.Metadata.Edm.EdmType resultType, global::System.Data.Entity.Core.Metadata.Edm.EdmFunction functionImport)
		{
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsComplexType(resultType))
			{
				global::System.Data.Entity.Core.Metadata.Edm.ComplexType complexType = resultType as global::System.Data.Entity.Core.Metadata.Edm.ComplexType;
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty in complexType.Properties)
				{
					if (edmProperty.TypeUsage.EdmType.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.ComplexType)
					{
						throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ComplexTypeAsReturnTypeAndNestedComplexProperty(edmProperty.Name, complexType.Name, functionImport.FullName));
					}
				}
			}
		}

		// Token: 0x060049E1 RID: 18913 RVA: 0x00105460 File Offset: 0x00103660
		private static global::System.Data.Entity.Core.Mapping.FunctionImportMappingNonComposable GetTargetFunctionMapping(global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionCommandTree functionCommandTree)
		{
			global::System.Data.Entity.Core.Mapping.FunctionImportMapping functionImportMapping;
			if (!functionCommandTree.MetadataWorkspace.TryGetFunctionImportMapping(functionCommandTree.EdmFunction, out functionImportMapping))
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityClient_UnmappedFunctionImport(functionCommandTree.EdmFunction.FullName));
			}
			return (global::System.Data.Entity.Core.Mapping.FunctionImportMappingNonComposable)functionImportMapping;
		}

		// Token: 0x17000EA0 RID: 3744
		// (get) Token: 0x060049E2 RID: 18914 RVA: 0x0010549E File Offset: 0x0010369E
		internal virtual global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.EntityClient.EntityParameter> Parameters
		{
			get
			{
				return this._parameters;
			}
		}

		// Token: 0x17000EA1 RID: 3745
		// (get) Token: 0x060049E3 RID: 18915 RVA: 0x001054A6 File Offset: 0x001036A6
		internal virtual global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> EntitySets
		{
			get
			{
				return this._entitySets;
			}
		}

		// Token: 0x060049E4 RID: 18916 RVA: 0x001054AE File Offset: 0x001036AE
		public override global::System.Data.Common.DbCommand CreateCommand()
		{
			return new global::System.Data.Entity.Core.EntityClient.EntityCommand(this, new global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext(), null);
		}

		// Token: 0x060049E5 RID: 18917 RVA: 0x001054BC File Offset: 0x001036BC
		internal global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap CreateColumnMap(global::System.Data.Common.DbDataReader storeDataReader)
		{
			return this.CreateColumnMap(storeDataReader, 0);
		}

		// Token: 0x060049E6 RID: 18918 RVA: 0x001054C6 File Offset: 0x001036C6
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap CreateColumnMap(global::System.Data.Common.DbDataReader storeDataReader, int resultSetIndex)
		{
			return this._columnMapGenerators[resultSetIndex].CreateColumnMap(storeDataReader);
		}

		// Token: 0x060049E7 RID: 18919 RVA: 0x001054D6 File Offset: 0x001036D6
		private static global::System.Data.Entity.Core.EntityClient.EntityParameter CreateEntityParameterFromQueryParameter(global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> queryParameter)
		{
			global::System.Data.Entity.Core.EntityClient.EntityParameter entityParameter = new global::System.Data.Entity.Core.EntityClient.EntityParameter();
			entityParameter.ParameterName = queryParameter.Key;
			global::System.Data.Entity.Core.EntityClient.Internal.EntityCommandDefinition.PopulateParameterFromTypeUsage(entityParameter, queryParameter.Value, false);
			return entityParameter;
		}

		// Token: 0x060049E8 RID: 18920 RVA: 0x001054F8 File Offset: 0x001036F8
		internal static void PopulateParameterFromTypeUsage(global::System.Data.Entity.Core.EntityClient.EntityParameter parameter, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, bool isOutParam)
		{
			if (type != null)
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind;
				if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEnumType(type.EdmType))
				{
					type = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(global::System.Data.Entity.Core.Metadata.Edm.Helper.GetUnderlyingEdmTypeForEnumType(type.EdmType));
				}
				else if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsSpatialType(type, out primitiveTypeKind))
				{
					parameter.EdmType = global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.Instance.GetPrimitiveType(primitiveTypeKind);
				}
			}
			global::System.Data.Entity.Core.Common.DbCommandDefinition.PopulateParameterFromTypeUsage(parameter, type, isOutParam);
		}

		// Token: 0x060049E9 RID: 18921 RVA: 0x0010554C File Offset: 0x0010374C
		internal virtual global::System.Data.Common.DbDataReader Execute(global::System.Data.Entity.Core.EntityClient.EntityCommand entityCommand, global::System.Data.CommandBehavior behavior)
		{
			if (global::System.Data.CommandBehavior.SequentialAccess != (behavior & global::System.Data.CommandBehavior.SequentialAccess))
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ADP_MustUseSequentialAccess);
			}
			global::System.Data.Common.DbDataReader dbDataReader = this.ExecuteStoreCommands(entityCommand, behavior & ~global::System.Data.CommandBehavior.SequentialAccess);
			global::System.Data.Common.DbDataReader result = null;
			if (dbDataReader != null)
			{
				try
				{
					global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap columnMap = this.CreateColumnMap(dbDataReader, 0);
					if (columnMap == null)
					{
						global::System.Data.Entity.Core.Common.Utils.CommandHelper.ConsumeReader(dbDataReader);
						result = dbDataReader;
					}
					else
					{
						global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace metadataWorkspace = entityCommand.Connection.GetMetadataWorkspace();
						global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap> nextResultColumnMaps = this.GetNextResultColumnMaps(dbDataReader);
						result = this._bridgeDataReaderFactory.Create(dbDataReader, columnMap, metadataWorkspace, nextResultColumnMaps);
					}
				}
				catch
				{
					dbDataReader.Dispose();
					throw;
				}
			}
			return result;
		}

		// Token: 0x060049EA RID: 18922 RVA: 0x001055D8 File Offset: 0x001037D8
		internal virtual async global::System.Threading.Tasks.Task<global::System.Data.Common.DbDataReader> ExecuteAsync(global::System.Data.Entity.Core.EntityClient.EntityCommand entityCommand, global::System.Data.CommandBehavior behavior, global::System.Threading.CancellationToken cancellationToken)
		{
			if (global::System.Data.CommandBehavior.SequentialAccess != (behavior & global::System.Data.CommandBehavior.SequentialAccess))
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ADP_MustUseSequentialAccess);
			}
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Common.DbDataReader dbDataReader = await this.ExecuteStoreCommandsAsync(entityCommand, behavior & ~global::System.Data.CommandBehavior.SequentialAccess, cancellationToken).WithCurrentCulture<global::System.Data.Common.DbDataReader>();
			global::System.Data.Common.DbDataReader storeDataReader = dbDataReader;
			global::System.Data.Common.DbDataReader result = null;
			if (storeDataReader != null)
			{
				try
				{
					global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap columnMap = this.CreateColumnMap(storeDataReader, 0);
					if (columnMap == null)
					{
						await global::System.Data.Entity.Core.Common.Utils.CommandHelper.ConsumeReaderAsync(storeDataReader, cancellationToken).WithCurrentCulture();
						result = storeDataReader;
					}
					else
					{
						global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace metadataWorkspace = entityCommand.Connection.GetMetadataWorkspace();
						global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap> nextResultColumnMaps = this.GetNextResultColumnMaps(storeDataReader);
						result = this._bridgeDataReaderFactory.Create(storeDataReader, columnMap, metadataWorkspace, nextResultColumnMaps);
					}
				}
				catch
				{
					storeDataReader.Dispose();
					throw;
				}
			}
			return result;
		}

		// Token: 0x060049EB RID: 18923 RVA: 0x00105635 File Offset: 0x00103835
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap> GetNextResultColumnMaps(global::System.Data.Common.DbDataReader storeDataReader)
		{
			int num;
			for (int i = 1; i < this._columnMapGenerators.Length; i = num)
			{
				yield return this.CreateColumnMap(storeDataReader, i);
				num = i + 1;
			}
			yield break;
		}

		// Token: 0x060049EC RID: 18924 RVA: 0x0010564C File Offset: 0x0010384C
		internal virtual global::System.Data.Common.DbDataReader ExecuteStoreCommands(global::System.Data.Entity.Core.EntityClient.EntityCommand entityCommand, global::System.Data.CommandBehavior behavior)
		{
			global::System.Data.Common.DbCommand dbCommand = this.PrepareEntityCommandBeforeExecution(entityCommand);
			global::System.Data.Common.DbDataReader result = null;
			try
			{
				result = dbCommand.ExecuteReader(behavior);
			}
			catch (global::System.Exception ex)
			{
				if (ex.IsCatchableExceptionType())
				{
					throw new global::System.Data.Entity.Core.EntityCommandExecutionException(global::System.Data.Entity.Resources.Strings.EntityClient_CommandDefinitionExecutionFailed, ex);
				}
				throw;
			}
			return result;
		}

		// Token: 0x060049ED RID: 18925 RVA: 0x00105698 File Offset: 0x00103898
		internal virtual async global::System.Threading.Tasks.Task<global::System.Data.Common.DbDataReader> ExecuteStoreCommandsAsync(global::System.Data.Entity.Core.EntityClient.EntityCommand entityCommand, global::System.Data.CommandBehavior behavior, global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Common.DbCommand dbCommand = this.PrepareEntityCommandBeforeExecution(entityCommand);
			global::System.Data.Common.DbDataReader result = null;
			try
			{
				result = await dbCommand.ExecuteReaderAsync(behavior, cancellationToken).WithCurrentCulture<global::System.Data.Common.DbDataReader>();
			}
			catch (global::System.Exception ex)
			{
				if (ex.IsCatchableExceptionType())
				{
					throw new global::System.Data.Entity.Core.EntityCommandExecutionException(global::System.Data.Entity.Resources.Strings.EntityClient_CommandDefinitionExecutionFailed, ex);
				}
				throw;
			}
			return result;
		}

		// Token: 0x060049EE RID: 18926 RVA: 0x001056F8 File Offset: 0x001038F8
		private global::System.Data.Common.DbCommand PrepareEntityCommandBeforeExecution(global::System.Data.Entity.Core.EntityClient.EntityCommand entityCommand)
		{
			if (1 != this._mappedCommandDefinitions.Count)
			{
				throw new global::System.NotSupportedException("MARS");
			}
			global::System.Data.Entity.Core.EntityClient.EntityTransaction entityTransaction = entityCommand.ValidateAndGetEntityTransaction();
			global::System.Data.Entity.Internal.InterceptableDbCommand interceptableDbCommand = new global::System.Data.Entity.Internal.InterceptableDbCommand(this._mappedCommandDefinitions[0].CreateCommand(), entityCommand.InterceptionContext, null);
			global::System.Data.Entity.Core.Common.Utils.CommandHelper.SetStoreProviderCommandState(entityCommand, entityTransaction, interceptableDbCommand);
			bool flag = false;
			if (interceptableDbCommand.Parameters != null)
			{
				foreach (object obj in interceptableDbCommand.Parameters)
				{
					global::System.Data.Common.DbParameter dbParameter = (global::System.Data.Common.DbParameter)obj;
					int num = entityCommand.Parameters.IndexOf(dbParameter.ParameterName);
					if (-1 != num)
					{
						global::System.Data.Entity.Core.EntityClient.Internal.EntityCommandDefinition.SyncParameterProperties(entityCommand.Parameters[num], dbParameter, this._storeProviderServices);
						if (dbParameter.Direction != global::System.Data.ParameterDirection.Input)
						{
							flag = true;
						}
					}
				}
			}
			if (flag)
			{
				entityCommand.SetStoreProviderCommand(interceptableDbCommand);
			}
			return interceptableDbCommand;
		}

		// Token: 0x060049EF RID: 18927 RVA: 0x001057E8 File Offset: 0x001039E8
		private static void SyncParameterProperties(global::System.Data.Entity.Core.EntityClient.EntityParameter entityParameter, global::System.Data.Common.DbParameter storeParameter, global::System.Data.Entity.Core.Common.DbProviderServices storeProviderServices)
		{
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage primitiveTypeUsageForScalar = global::System.Data.Entity.Core.Common.TypeHelpers.GetPrimitiveTypeUsageForScalar(entityParameter.GetTypeUsage());
			storeProviderServices.SetParameterValue(storeParameter, primitiveTypeUsageForScalar, entityParameter.Value);
			if (entityParameter.IsDirectionSpecified)
			{
				storeParameter.Direction = entityParameter.Direction;
			}
			if (entityParameter.IsIsNullableSpecified)
			{
				storeParameter.IsNullable = entityParameter.IsNullable;
			}
			if (entityParameter.IsSizeSpecified)
			{
				storeParameter.Size = entityParameter.Size;
			}
			if (entityParameter.IsPrecisionSpecified)
			{
				((global::System.Data.IDbDataParameter)storeParameter).Precision = entityParameter.Precision;
			}
			if (entityParameter.IsScaleSpecified)
			{
				((global::System.Data.IDbDataParameter)storeParameter).Scale = entityParameter.Scale;
			}
		}

		// Token: 0x060049F0 RID: 18928 RVA: 0x00105878 File Offset: 0x00103A78
		internal virtual string ToTraceString()
		{
			if (this._mappedCommandDefinitions == null)
			{
				return string.Empty;
			}
			if (this._mappedCommandDefinitions.Count == 1)
			{
				return this._mappedCommandDefinitions[0].CreateCommand().CommandText;
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			foreach (global::System.Data.Entity.Core.Common.DbCommandDefinition dbCommandDefinition in this._mappedCommandDefinitions)
			{
				global::System.Data.Common.DbCommand dbCommand = dbCommandDefinition.CreateCommand();
				stringBuilder.Append(dbCommand.CommandText);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x04001A0F RID: 6671
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.DbCommandDefinition> _mappedCommandDefinitions;

		// Token: 0x04001A10 RID: 6672
		private readonly global::System.Data.Entity.Core.EntityClient.Internal.EntityCommandDefinition.IColumnMapGenerator[] _columnMapGenerators;

		// Token: 0x04001A11 RID: 6673
		private readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.EntityClient.EntityParameter> _parameters;

		// Token: 0x04001A12 RID: 6674
		private readonly global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> _entitySets;

		// Token: 0x04001A13 RID: 6675
		private readonly global::System.Data.Entity.Core.Query.ResultAssembly.BridgeDataReaderFactory _bridgeDataReaderFactory;

		// Token: 0x04001A14 RID: 6676
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapFactory _columnMapFactory;

		// Token: 0x04001A15 RID: 6677
		private readonly global::System.Data.Entity.Core.Common.DbProviderServices _storeProviderServices;

		// Token: 0x02000C2C RID: 3116
		private interface IColumnMapGenerator
		{
			// Token: 0x060069F7 RID: 27127
			global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap CreateColumnMap(global::System.Data.Common.DbDataReader reader);
		}

		// Token: 0x02000C2D RID: 3117
		private sealed class ConstantColumnMapGenerator : global::System.Data.Entity.Core.EntityClient.Internal.EntityCommandDefinition.IColumnMapGenerator
		{
			// Token: 0x060069F8 RID: 27128 RVA: 0x00169E00 File Offset: 0x00168000
			internal ConstantColumnMapGenerator(global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap columnMap, int fieldsRequired)
			{
				this._columnMap = columnMap;
				this._fieldsRequired = fieldsRequired;
			}

			// Token: 0x060069F9 RID: 27129 RVA: 0x00169E16 File Offset: 0x00168016
			global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap global::System.Data.Entity.Core.EntityClient.Internal.EntityCommandDefinition.IColumnMapGenerator.CreateColumnMap(global::System.Data.Common.DbDataReader reader)
			{
				if (reader != null && reader.FieldCount < this._fieldsRequired)
				{
					throw new global::System.Data.Entity.Core.EntityCommandExecutionException(global::System.Data.Entity.Resources.Strings.EntityClient_TooFewColumns);
				}
				return this._columnMap;
			}

			// Token: 0x04003041 RID: 12353
			private readonly global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap _columnMap;

			// Token: 0x04003042 RID: 12354
			private readonly int _fieldsRequired;
		}

		// Token: 0x02000C2E RID: 3118
		private sealed class FunctionColumnMapGenerator : global::System.Data.Entity.Core.EntityClient.Internal.EntityCommandDefinition.IColumnMapGenerator
		{
			// Token: 0x060069FA RID: 27130 RVA: 0x00169E3A File Offset: 0x0016803A
			internal FunctionColumnMapGenerator(global::System.Data.Entity.Core.Mapping.FunctionImportMappingNonComposable mapping, int resultSetIndex, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Data.Entity.Core.Metadata.Edm.StructuralType baseStructuralType, global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapFactory columnMapFactory)
			{
				this._mapping = mapping;
				this._entitySet = entitySet;
				this._baseStructuralType = baseStructuralType;
				this._resultSetIndex = resultSetIndex;
				this._columnMapFactory = columnMapFactory;
			}

			// Token: 0x060069FB RID: 27131 RVA: 0x00169E67 File Offset: 0x00168067
			global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap global::System.Data.Entity.Core.EntityClient.Internal.EntityCommandDefinition.IColumnMapGenerator.CreateColumnMap(global::System.Data.Common.DbDataReader reader)
			{
				return this._columnMapFactory.CreateFunctionImportStructuralTypeColumnMap(reader, this._mapping, this._resultSetIndex, this._entitySet, this._baseStructuralType);
			}

			// Token: 0x04003043 RID: 12355
			private readonly global::System.Data.Entity.Core.Mapping.FunctionImportMappingNonComposable _mapping;

			// Token: 0x04003044 RID: 12356
			private readonly global::System.Data.Entity.Core.Metadata.Edm.EntitySet _entitySet;

			// Token: 0x04003045 RID: 12357
			private readonly global::System.Data.Entity.Core.Metadata.Edm.StructuralType _baseStructuralType;

			// Token: 0x04003046 RID: 12358
			private readonly int _resultSetIndex;

			// Token: 0x04003047 RID: 12359
			private readonly global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapFactory _columnMapFactory;
		}
	}
}
