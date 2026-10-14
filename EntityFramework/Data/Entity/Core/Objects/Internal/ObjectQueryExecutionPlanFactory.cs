using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.Internal.Materialization;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.EntityClient.Internal;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects.ELinq;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Objects.Internal
{
	// Token: 0x02000451 RID: 1105
	internal class ObjectQueryExecutionPlanFactory
	{
		// Token: 0x060035EE RID: 13806 RVA: 0x000ACAA0 File Offset: 0x000AACA0
		public ObjectQueryExecutionPlanFactory(global::System.Data.Entity.Core.Common.Internal.Materialization.Translator translator = null)
		{
			this._translator = (translator ?? new global::System.Data.Entity.Core.Common.Internal.Materialization.Translator());
		}

		// Token: 0x060035EF RID: 13807 RVA: 0x000ACAB8 File Offset: 0x000AACB8
		public virtual global::System.Data.Entity.Core.Objects.Internal.ObjectQueryExecutionPlan Prepare(global::System.Data.Entity.Core.Objects.ObjectContext context, global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree tree, global::System.Type elementType, global::System.Data.Entity.Core.Objects.MergeOption mergeOption, bool streaming, global::System.Data.Entity.Core.Objects.Span span, global::System.Collections.Generic.IEnumerable<global::System.Tuple<global::System.Data.Entity.Core.Objects.ObjectParameter, global::System.Data.Entity.Core.Objects.ELinq.QueryParameterExpression>> compiledQueryParameters, global::System.Data.Entity.Core.Common.Utils.AliasGenerator aliasGenerator)
		{
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage resultType = tree.Query.ResultType;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression query;
			global::System.Data.Entity.Core.Objects.Internal.SpanIndex spanIndex;
			if (global::System.Data.Entity.Core.Objects.Internal.ObjectSpanRewriter.TryRewrite(tree, span, mergeOption, aliasGenerator, out query, out spanIndex))
			{
				tree = global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree.FromValidExpression(tree.MetadataWorkspace, tree.DataSpace, query, tree.UseDatabaseNullSemantics, tree.DisableFilterOverProjectionSimplificationForCustomFunctions);
			}
			else
			{
				spanIndex = null;
			}
			global::System.Data.Entity.Core.EntityClient.Internal.EntityCommandDefinition entityCommandDefinition = global::System.Data.Entity.Core.Objects.Internal.ObjectQueryExecutionPlanFactory.CreateCommandDefinition(context, tree);
			global::System.Data.Entity.Core.Common.Internal.Materialization.ShaperFactory resultShaperFactory = global::System.Data.Entity.Core.Common.Internal.Materialization.Translator.TranslateColumnMap(this._translator, elementType, entityCommandDefinition.CreateColumnMap(null), context.MetadataWorkspace, spanIndex, mergeOption, streaming, false);
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = null;
			if (resultType.EdmType.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.CollectionType && entityCommandDefinition.EntitySets != null)
			{
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet2 in entityCommandDefinition.EntitySets)
				{
					if (entitySet2 != null && entitySet2.ElementType.IsAssignableFrom(((global::System.Data.Entity.Core.Metadata.Edm.CollectionType)resultType.EdmType).TypeUsage.EdmType))
					{
						if (entitySet != null)
						{
							entitySet = null;
							break;
						}
						entitySet = entitySet2;
					}
				}
			}
			return new global::System.Data.Entity.Core.Objects.Internal.ObjectQueryExecutionPlan(entityCommandDefinition, resultShaperFactory, resultType, mergeOption, streaming, entitySet, compiledQueryParameters);
		}

		// Token: 0x060035F0 RID: 13808 RVA: 0x000ACBD4 File Offset: 0x000AADD4
		private static global::System.Data.Entity.Core.EntityClient.Internal.EntityCommandDefinition CreateCommandDefinition(global::System.Data.Entity.Core.Objects.ObjectContext context, global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree tree)
		{
			global::System.Data.Common.DbConnection connection = context.Connection;
			if (connection == null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectQuery_InvalidConnection);
			}
			global::System.Data.Entity.Core.Common.DbProviderServices providerServices = global::System.Data.Entity.Core.Common.DbProviderServices.GetProviderServices(connection);
			global::System.Data.Entity.Core.Common.DbCommandDefinition dbCommandDefinition;
			try
			{
				dbCommandDefinition = providerServices.CreateCommandDefinition(tree, context.InterceptionContext);
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
			if (dbCommandDefinition == null)
			{
				throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ADP_ProviderDoesNotSupportCommandTrees);
			}
			return (global::System.Data.Entity.Core.EntityClient.Internal.EntityCommandDefinition)dbCommandDefinition;
		}

		// Token: 0x0400116B RID: 4459
		private readonly global::System.Data.Entity.Core.Common.Internal.Materialization.Translator _translator;
	}
}
