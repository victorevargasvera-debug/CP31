using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.CommandTrees.Internal;
using System.Data.Entity.Core.Common.EntitySql;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping.ViewGeneration.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Query.InternalTrees;
using System.Data.Entity.Core.Query.PlanCompiler;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration
{
	// Token: 0x0200056A RID: 1386
	internal sealed class GeneratedView : global::System.Data.Entity.Core.Common.Utils.InternalBase
	{
		// Token: 0x060043A8 RID: 17320 RVA: 0x000E9BC0 File Offset: 0x000E7DC0
		internal static global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView CreateGeneratedView(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase extent, global::System.Data.Entity.Core.Metadata.Edm.EdmType type, global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree commandTree, string eSQL, global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection mappingItemCollection, global::System.Data.Entity.Core.Mapping.ViewGeneration.ConfigViewGenerator config)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.DiscriminatorMap discriminatorMap = null;
			if (commandTree != null)
			{
				commandTree = global::System.Data.Entity.Core.Common.CommandTrees.Internal.ViewSimplifier.SimplifyView(extent, commandTree);
				if (extent.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntitySet)
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.DiscriminatorMap.TryCreateDiscriminatorMap((global::System.Data.Entity.Core.Metadata.Edm.EntitySet)extent, commandTree.Query, out discriminatorMap);
				}
			}
			return new global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView(extent, type, commandTree, eSQL, discriminatorMap, mappingItemCollection, config);
		}

		// Token: 0x060043A9 RID: 17321 RVA: 0x000E9C07 File Offset: 0x000E7E07
		internal static global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView CreateGeneratedViewForFKAssociationSet(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase extent, global::System.Data.Entity.Core.Metadata.Edm.EdmType type, global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree commandTree, global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection mappingItemCollection, global::System.Data.Entity.Core.Mapping.ViewGeneration.ConfigViewGenerator config)
		{
			return new global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView(extent, type, commandTree, null, null, mappingItemCollection, config);
		}

		// Token: 0x060043AA RID: 17322 RVA: 0x000E9C18 File Offset: 0x000E7E18
		internal static bool TryParseUserSpecifiedView(global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping setMapping, global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase type, string eSQL, bool includeSubtypes, global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection mappingItemCollection, global::System.Data.Entity.Core.Mapping.ViewGeneration.ConfigViewGenerator config, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> errors, out global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView generatedView)
		{
			bool flag = false;
			global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree dbQueryCommandTree;
			global::System.Data.Entity.Core.Mapping.ViewGeneration.DiscriminatorMap discriminatorMap;
			global::System.Exception ex;
			if (!global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView.TryParseView(eSQL, true, setMapping.Set, mappingItemCollection, config, out dbQueryCommandTree, out discriminatorMap, out ex))
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError item = new global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError(global::System.Data.Entity.Resources.Strings.Mapping_Invalid_QueryView2(setMapping.Set.Name, ex.Message), 2068, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, setMapping.EntityContainerMapping.SourceLocation, setMapping.StartLineNumber, setMapping.StartLinePosition, ex);
				errors.Add(item);
				flag = true;
			}
			else
			{
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError item2 in global::System.Data.Entity.Core.Mapping.ViewValidator.ValidateQueryView(dbQueryCommandTree, setMapping, type, includeSubtypes))
				{
					errors.Add(item2);
					flag = true;
				}
				global::System.Data.Entity.Core.Metadata.Edm.CollectionType collectionType = dbQueryCommandTree.Query.ResultType.EdmType as global::System.Data.Entity.Core.Metadata.Edm.CollectionType;
				if (collectionType == null || !setMapping.Set.ElementType.IsAssignableFrom(collectionType.TypeUsage.EdmType))
				{
					global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError item3 = new global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError(global::System.Data.Entity.Resources.Strings.Mapping_Invalid_QueryView_Type(setMapping.Set.Name), 2069, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, setMapping.EntityContainerMapping.SourceLocation, setMapping.StartLineNumber, setMapping.StartLinePosition);
					errors.Add(item3);
					flag = true;
				}
			}
			if (!flag)
			{
				generatedView = new global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView(setMapping.Set, type, dbQueryCommandTree, eSQL, discriminatorMap, mappingItemCollection, config);
				return true;
			}
			generatedView = null;
			return false;
		}

		// Token: 0x060043AB RID: 17323 RVA: 0x000E9D70 File Offset: 0x000E7F70
		private GeneratedView(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase extent, global::System.Data.Entity.Core.Metadata.Edm.EdmType type, global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree commandTree, string eSQL, global::System.Data.Entity.Core.Mapping.ViewGeneration.DiscriminatorMap discriminatorMap, global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection mappingItemCollection, global::System.Data.Entity.Core.Mapping.ViewGeneration.ConfigViewGenerator config)
		{
			this.m_extent = extent;
			this.m_type = type;
			this.m_commandTree = commandTree;
			this.m_eSQL = eSQL;
			this.m_discriminatorMap = discriminatorMap;
			this.m_mappingItemCollection = mappingItemCollection;
			this.m_config = config;
			if (this.m_config.IsViewTracing)
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(1024);
				this.ToCompactString(stringBuilder);
				global::System.Data.Entity.Core.Common.Utils.Helpers.FormatTraceLine("CQL view for {0}", new object[]
				{
					stringBuilder.ToString()
				});
			}
		}

		// Token: 0x17000D6B RID: 3435
		// (get) Token: 0x060043AC RID: 17324 RVA: 0x000E9DF0 File Offset: 0x000E7FF0
		internal string eSQL
		{
			get
			{
				return this.m_eSQL;
			}
		}

		// Token: 0x060043AD RID: 17325 RVA: 0x000E9DF8 File Offset: 0x000E7FF8
		internal global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree GetCommandTree()
		{
			if (this.m_commandTree != null)
			{
				return this.m_commandTree;
			}
			global::System.Exception ex;
			if (global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView.TryParseView(this.m_eSQL, false, this.m_extent, this.m_mappingItemCollection, this.m_config, out this.m_commandTree, out this.m_discriminatorMap, out ex))
			{
				return this.m_commandTree;
			}
			throw new global::System.Data.Entity.Core.MappingException(global::System.Data.Entity.Resources.Strings.Mapping_Invalid_QueryView(this.m_extent.Name, ex.Message));
		}

		// Token: 0x060043AE RID: 17326 RVA: 0x000E9E64 File Offset: 0x000E8064
		internal global::System.Data.Entity.Core.Query.InternalTrees.Node GetInternalTree(global::System.Data.Entity.Core.Query.InternalTrees.Command targetIqtCommand)
		{
			if (this.m_internalTreeNode == null)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Command command = global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.Generate(this.GetCommandTree(), this.m_discriminatorMap);
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(command.Root.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.PhysicalProject, "Expected a physical projectOp at the root of the tree - found " + command.Root.Op.OpType.ToString());
				command.DisableVarVecEnumCaching();
				this.m_internalTreeNode = command.Root.Child0;
			}
			return global::System.Data.Entity.Core.Query.InternalTrees.OpCopier.Copy(targetIqtCommand, this.m_internalTreeNode);
		}

		// Token: 0x060043AF RID: 17327 RVA: 0x000E9EF0 File Offset: 0x000E80F0
		private static bool TryParseView(string eSQL, bool isUserSpecified, global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase extent, global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection mappingItemCollection, global::System.Data.Entity.Core.Mapping.ViewGeneration.ConfigViewGenerator config, out global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree commandTree, out global::System.Data.Entity.Core.Mapping.ViewGeneration.DiscriminatorMap discriminatorMap, out global::System.Exception parserException)
		{
			commandTree = null;
			discriminatorMap = null;
			parserException = null;
			config.StartSingleWatch(global::System.Data.Entity.Core.Mapping.ViewGeneration.PerfType.ViewParsing);
			try
			{
				global::System.Data.Entity.Core.Common.EntitySql.ParserOptions.CompilationMode compilationMode = global::System.Data.Entity.Core.Common.EntitySql.ParserOptions.CompilationMode.RestrictedViewGenerationMode;
				if (isUserSpecified)
				{
					compilationMode = global::System.Data.Entity.Core.Common.EntitySql.ParserOptions.CompilationMode.UserViewGenerationMode;
				}
				commandTree = (global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree)global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ExternalCalls.CompileView(eSQL, mappingItemCollection, compilationMode);
				commandTree = global::System.Data.Entity.Core.Common.CommandTrees.Internal.ViewSimplifier.SimplifyView(extent, commandTree);
				if (extent.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntitySet)
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.DiscriminatorMap.TryCreateDiscriminatorMap((global::System.Data.Entity.Core.Metadata.Edm.EntitySet)extent, commandTree.Query, out discriminatorMap);
				}
			}
			catch (global::System.Exception ex)
			{
				if (!ex.IsCatchableExceptionType())
				{
					throw;
				}
				parserException = ex;
			}
			finally
			{
				config.StopSingleWatch(global::System.Data.Entity.Core.Mapping.ViewGeneration.PerfType.ViewParsing);
			}
			return parserException == null;
		}

		// Token: 0x060043B0 RID: 17328 RVA: 0x000E9F98 File Offset: 0x000E8198
		internal override void ToCompactString(global::System.Text.StringBuilder builder)
		{
			bool flag = this.m_type != this.m_extent.ElementType;
			if (flag)
			{
				builder.Append("OFTYPE(");
			}
			builder.AppendFormat("{0}.{1}", this.m_extent.EntityContainer.Name, this.m_extent.Name);
			if (flag)
			{
				builder.Append(", ").Append(this.m_type.Name).Append(')');
			}
			builder.AppendLine(" = ");
			if (!string.IsNullOrEmpty(this.m_eSQL))
			{
				builder.Append(this.m_eSQL);
				return;
			}
			builder.Append(this.m_commandTree.Print());
		}

		// Token: 0x0400182A RID: 6186
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase m_extent;

		// Token: 0x0400182B RID: 6187
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EdmType m_type;

		// Token: 0x0400182C RID: 6188
		private global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree m_commandTree;

		// Token: 0x0400182D RID: 6189
		private readonly string m_eSQL;

		// Token: 0x0400182E RID: 6190
		private global::System.Data.Entity.Core.Query.InternalTrees.Node m_internalTreeNode;

		// Token: 0x0400182F RID: 6191
		private global::System.Data.Entity.Core.Mapping.ViewGeneration.DiscriminatorMap m_discriminatorMap;

		// Token: 0x04001830 RID: 6192
		private readonly global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection m_mappingItemCollection;

		// Token: 0x04001831 RID: 6193
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.ConfigViewGenerator m_config;
	}
}
