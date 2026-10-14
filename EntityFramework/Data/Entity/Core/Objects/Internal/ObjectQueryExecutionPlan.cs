using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Common.Internal.Materialization;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.EntityClient.Internal;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects.ELinq;
using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Data.Entity.Utilities;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity.Core.Objects.Internal
{
	// Token: 0x02000450 RID: 1104
	internal class ObjectQueryExecutionPlan
	{
		// Token: 0x060035E9 RID: 13801 RVA: 0x000AC774 File Offset: 0x000AA974
		public ObjectQueryExecutionPlan(global::System.Data.Entity.Core.Common.DbCommandDefinition commandDefinition, global::System.Data.Entity.Core.Common.Internal.Materialization.ShaperFactory resultShaperFactory, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage resultType, global::System.Data.Entity.Core.Objects.MergeOption mergeOption, bool streaming, global::System.Data.Entity.Core.Metadata.Edm.EntitySet singleEntitySet, global::System.Collections.Generic.IEnumerable<global::System.Tuple<global::System.Data.Entity.Core.Objects.ObjectParameter, global::System.Data.Entity.Core.Objects.ELinq.QueryParameterExpression>> compiledQueryParameters)
		{
			this.CommandDefinition = commandDefinition;
			this.ResultShaperFactory = resultShaperFactory;
			this.ResultType = resultType;
			this.MergeOption = mergeOption;
			this.Streaming = streaming;
			this._singleEntitySet = singleEntitySet;
			this.CompiledQueryParameters = compiledQueryParameters;
		}

		// Token: 0x060035EA RID: 13802 RVA: 0x000AC7B4 File Offset: 0x000AA9B4
		internal string ToTraceString()
		{
			global::System.Data.Entity.Core.EntityClient.Internal.EntityCommandDefinition entityCommandDefinition = this.CommandDefinition as global::System.Data.Entity.Core.EntityClient.Internal.EntityCommandDefinition;
			if (entityCommandDefinition == null)
			{
				return string.Empty;
			}
			return entityCommandDefinition.ToTraceString();
		}

		// Token: 0x060035EB RID: 13803 RVA: 0x000AC7DC File Offset: 0x000AA9DC
		internal virtual global::System.Data.Entity.Core.Objects.ObjectResult<TResultType> Execute<TResultType>(global::System.Data.Entity.Core.Objects.ObjectContext context, global::System.Data.Entity.Core.Objects.ObjectParameterCollection parameterValues)
		{
			global::System.Data.Common.DbDataReader dbDataReader = null;
			global::System.Data.Entity.Core.Objects.Internal.BufferedDataReader bufferedDataReader = null;
			global::System.Data.Entity.Core.Objects.ObjectResult<TResultType> result;
			try
			{
				using (global::System.Data.Entity.Core.EntityClient.EntityCommand entityCommand = this.PrepareEntityCommand(context, parameterValues))
				{
					dbDataReader = entityCommand.GetCommandDefinition().ExecuteStoreCommands(entityCommand, this.Streaming ? global::System.Data.CommandBehavior.Default : global::System.Data.CommandBehavior.SequentialAccess);
				}
				global::System.Data.Entity.Core.Common.Internal.Materialization.ShaperFactory<TResultType> shaperFactory = (global::System.Data.Entity.Core.Common.Internal.Materialization.ShaperFactory<TResultType>)this.ResultShaperFactory;
				global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<TResultType> shaper;
				if (this.Streaming)
				{
					shaper = shaperFactory.Create(dbDataReader, context, context.MetadataWorkspace, this.MergeOption, true, this.Streaming);
				}
				else
				{
					global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection storeItemCollection = (global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection)context.MetadataWorkspace.GetItemCollection(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace);
					global::System.Data.Entity.Core.Common.DbProviderServices service = global::System.Data.Entity.DbConfiguration.DependencyResolver.GetService(storeItemCollection.ProviderInvariantName);
					bufferedDataReader = new global::System.Data.Entity.Core.Objects.Internal.BufferedDataReader(dbDataReader);
					bufferedDataReader.Initialize(storeItemCollection.ProviderManifestToken, service, shaperFactory.ColumnTypes, shaperFactory.NullableColumns);
					shaper = shaperFactory.Create(bufferedDataReader, context, context.MetadataWorkspace, this.MergeOption, true, this.Streaming);
				}
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage resultItemType;
				if (this.ResultType.EdmType.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.CollectionType)
				{
					resultItemType = ((global::System.Data.Entity.Core.Metadata.Edm.CollectionType)this.ResultType.EdmType).TypeUsage;
				}
				else
				{
					resultItemType = this.ResultType;
				}
				result = new global::System.Data.Entity.Core.Objects.ObjectResult<TResultType>(shaper, this._singleEntitySet, resultItemType);
			}
			catch (global::System.Exception)
			{
				if (this.Streaming && dbDataReader != null)
				{
					dbDataReader.Dispose();
				}
				if (!this.Streaming && bufferedDataReader != null)
				{
					bufferedDataReader.Dispose();
				}
				throw;
			}
			return result;
		}

		// Token: 0x060035EC RID: 13804 RVA: 0x000AC958 File Offset: 0x000AAB58
		internal virtual async global::System.Threading.Tasks.Task<global::System.Data.Entity.Core.Objects.ObjectResult<TResultType>> ExecuteAsync<TResultType>(global::System.Data.Entity.Core.Objects.ObjectContext context, global::System.Data.Entity.Core.Objects.ObjectParameterCollection parameterValues, global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Common.DbDataReader storeReader = null;
			global::System.Data.Entity.Core.Objects.Internal.BufferedDataReader bufferedReader = null;
			global::System.Data.Entity.Core.Objects.ObjectResult<TResultType> result;
			try
			{
				using (global::System.Data.Entity.Core.EntityClient.EntityCommand entityCommand = this.PrepareEntityCommand(context, parameterValues))
				{
					global::System.Data.Common.DbDataReader dbDataReader = await entityCommand.GetCommandDefinition().ExecuteStoreCommandsAsync(entityCommand, this.Streaming ? global::System.Data.CommandBehavior.Default : global::System.Data.CommandBehavior.SequentialAccess, cancellationToken).WithCurrentCulture<global::System.Data.Common.DbDataReader>();
					storeReader = dbDataReader;
				}
				global::System.Data.Entity.Core.EntityClient.EntityCommand entityCommand = null;
				global::System.Data.Entity.Core.Common.Internal.Materialization.ShaperFactory<TResultType> shaperFactory = (global::System.Data.Entity.Core.Common.Internal.Materialization.ShaperFactory<TResultType>)this.ResultShaperFactory;
				global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<TResultType> shaper;
				if (this.Streaming)
				{
					shaper = shaperFactory.Create(storeReader, context, context.MetadataWorkspace, this.MergeOption, true, this.Streaming);
				}
				else
				{
					global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection storeItemCollection = (global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection)context.MetadataWorkspace.GetItemCollection(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace);
					global::System.Data.Entity.Core.Common.DbProviderServices service = global::System.Data.Entity.DbConfiguration.DependencyResolver.GetService(storeItemCollection.ProviderInvariantName);
					bufferedReader = new global::System.Data.Entity.Core.Objects.Internal.BufferedDataReader(storeReader);
					await bufferedReader.InitializeAsync(storeItemCollection.ProviderManifestToken, service, shaperFactory.ColumnTypes, shaperFactory.NullableColumns, cancellationToken).WithCurrentCulture();
					shaper = shaperFactory.Create(bufferedReader, context, context.MetadataWorkspace, this.MergeOption, true, this.Streaming);
				}
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage resultItemType;
				if (this.ResultType.EdmType.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.CollectionType)
				{
					resultItemType = ((global::System.Data.Entity.Core.Metadata.Edm.CollectionType)this.ResultType.EdmType).TypeUsage;
				}
				else
				{
					resultItemType = this.ResultType;
				}
				result = new global::System.Data.Entity.Core.Objects.ObjectResult<TResultType>(shaper, this._singleEntitySet, resultItemType);
			}
			catch (global::System.Exception)
			{
				if (this.Streaming && storeReader != null)
				{
					storeReader.Dispose();
				}
				if (!this.Streaming && bufferedReader != null)
				{
					bufferedReader.Dispose();
				}
				throw;
			}
			return result;
		}

		// Token: 0x060035ED RID: 13805 RVA: 0x000AC9B8 File Offset: 0x000AABB8
		private global::System.Data.Entity.Core.EntityClient.EntityCommand PrepareEntityCommand(global::System.Data.Entity.Core.Objects.ObjectContext context, global::System.Data.Entity.Core.Objects.ObjectParameterCollection parameterValues)
		{
			global::System.Data.Entity.Core.EntityClient.Internal.EntityCommandDefinition entityCommandDefinition = (global::System.Data.Entity.Core.EntityClient.Internal.EntityCommandDefinition)this.CommandDefinition;
			global::System.Data.Entity.Core.EntityClient.EntityConnection entityConnection = (global::System.Data.Entity.Core.EntityClient.EntityConnection)context.Connection;
			global::System.Data.Entity.Core.EntityClient.EntityCommand entityCommand = new global::System.Data.Entity.Core.EntityClient.EntityCommand(entityConnection, entityCommandDefinition, context.InterceptionContext, null);
			if (context.CommandTimeout != null)
			{
				entityCommand.CommandTimeout = context.CommandTimeout.Value;
			}
			if (parameterValues != null)
			{
				foreach (global::System.Data.Entity.Core.Objects.ObjectParameter objectParameter in parameterValues)
				{
					int num = entityCommand.Parameters.IndexOf(objectParameter.Name);
					if (num != -1)
					{
						entityCommand.Parameters[num].Value = (objectParameter.Value ?? global::System.DBNull.Value);
					}
				}
			}
			if (entityConnection.CurrentTransaction != null)
			{
				entityCommand.Transaction = entityConnection.CurrentTransaction;
			}
			return entityCommand;
		}

		// Token: 0x04001164 RID: 4452
		internal readonly global::System.Data.Entity.Core.Common.DbCommandDefinition CommandDefinition;

		// Token: 0x04001165 RID: 4453
		internal readonly bool Streaming;

		// Token: 0x04001166 RID: 4454
		internal readonly global::System.Data.Entity.Core.Common.Internal.Materialization.ShaperFactory ResultShaperFactory;

		// Token: 0x04001167 RID: 4455
		internal readonly global::System.Data.Entity.Core.Metadata.Edm.TypeUsage ResultType;

		// Token: 0x04001168 RID: 4456
		internal readonly global::System.Data.Entity.Core.Objects.MergeOption MergeOption;

		// Token: 0x04001169 RID: 4457
		internal readonly global::System.Collections.Generic.IEnumerable<global::System.Tuple<global::System.Data.Entity.Core.Objects.ObjectParameter, global::System.Data.Entity.Core.Objects.ELinq.QueryParameterExpression>> CompiledQueryParameters;

		// Token: 0x0400116A RID: 4458
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EntitySet _singleEntitySet;
	}
}
