using System;
using System.Data.Common;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Data.Entity.Spatial;
using System.Data.Entity.Utilities;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity.Core.Common.Utils
{
	// Token: 0x020005F4 RID: 1524
	internal static class CommandHelper
	{
		// Token: 0x06004AA8 RID: 19112 RVA: 0x00107AE4 File Offset: 0x00105CE4
		internal static void ConsumeReader(global::System.Data.Common.DbDataReader reader)
		{
			if (reader != null && !reader.IsClosed)
			{
				while (reader.NextResult())
				{
				}
			}
		}

		// Token: 0x06004AA9 RID: 19113 RVA: 0x00107AFC File Offset: 0x00105CFC
		internal static async global::System.Threading.Tasks.Task ConsumeReaderAsync(global::System.Data.Common.DbDataReader reader, global::System.Threading.CancellationToken cancellationToken)
		{
			if (reader != null && !reader.IsClosed)
			{
				cancellationToken.ThrowIfCancellationRequested();
				for (;;)
				{
					global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = reader.NextResultAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
					if (!cultureAwaiter.IsCompleted)
					{
						await cultureAwaiter;
						global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
						cultureAwaiter = cultureAwaiter2;
						cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
					}
					if (!cultureAwaiter.GetResult())
					{
						break;
					}
					cancellationToken.ThrowIfCancellationRequested();
				}
			}
		}

		// Token: 0x06004AAA RID: 19114 RVA: 0x00107B4C File Offset: 0x00105D4C
		internal static void ParseFunctionImportCommandText(string commandText, string defaultContainerName, out string containerName, out string functionImportName)
		{
			string[] array = commandText.Split(new char[]
			{
				'.'
			});
			containerName = null;
			functionImportName = null;
			if (2 == array.Length)
			{
				containerName = array[0].Trim();
				functionImportName = array[1].Trim();
			}
			else if (1 == array.Length && defaultContainerName != null)
			{
				containerName = defaultContainerName;
				functionImportName = array[0].Trim();
			}
			if (string.IsNullOrEmpty(containerName) || string.IsNullOrEmpty(functionImportName))
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityClient_InvalidStoredProcedureCommandText);
			}
		}

		// Token: 0x06004AAB RID: 19115 RVA: 0x00107BC0 File Offset: 0x00105DC0
		internal static void SetStoreProviderCommandState(global::System.Data.Entity.Core.EntityClient.EntityCommand entityCommand, global::System.Data.Entity.Core.EntityClient.EntityTransaction entityTransaction, global::System.Data.Common.DbCommand storeProviderCommand)
		{
			storeProviderCommand.CommandTimeout = entityCommand.CommandTimeout;
			storeProviderCommand.Connection = entityCommand.Connection.StoreConnection;
			storeProviderCommand.Transaction = ((entityTransaction != null) ? entityTransaction.StoreTransaction : null);
			storeProviderCommand.UpdatedRowSource = entityCommand.UpdatedRowSource;
		}

		// Token: 0x06004AAC RID: 19116 RVA: 0x00107C00 File Offset: 0x00105E00
		internal static void SetEntityParameterValues(global::System.Data.Entity.Core.EntityClient.EntityCommand entityCommand, global::System.Data.Common.DbCommand storeProviderCommand, global::System.Data.Entity.Core.EntityClient.EntityConnection connection)
		{
			foreach (object obj in storeProviderCommand.Parameters)
			{
				global::System.Data.Common.DbParameter dbParameter = (global::System.Data.Common.DbParameter)obj;
				global::System.Data.ParameterDirection direction = dbParameter.Direction;
				if ((direction & global::System.Data.ParameterDirection.Output) != (global::System.Data.ParameterDirection)0)
				{
					int num = entityCommand.Parameters.IndexOf(dbParameter.ParameterName);
					if (0 <= num)
					{
						global::System.Data.Entity.Core.EntityClient.EntityParameter entityParameter = entityCommand.Parameters[num];
						object obj2 = dbParameter.Value;
						global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = entityParameter.GetTypeUsage();
						if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsSpatialType(typeUsage))
						{
							obj2 = global::System.Data.Entity.Core.Common.Utils.CommandHelper.GetSpatialValueFromProviderValue(obj2, (global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)typeUsage.EdmType, connection);
						}
						entityParameter.Value = obj2;
					}
				}
			}
		}

		// Token: 0x06004AAD RID: 19117 RVA: 0x00107CBC File Offset: 0x00105EBC
		private static object GetSpatialValueFromProviderValue(object spatialValue, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType parameterType, global::System.Data.Entity.Core.EntityClient.EntityConnection connection)
		{
			global::System.Data.Entity.Spatial.DbSpatialServices spatialServices = global::System.Data.Entity.Core.Common.DbProviderServices.GetSpatialServices(global::System.Data.Entity.DbConfiguration.DependencyResolver, connection);
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsGeographicType(parameterType))
			{
				return spatialServices.GeographyFromProviderValue(spatialValue);
			}
			return spatialServices.GeometryFromProviderValue(spatialValue);
		}

		// Token: 0x06004AAE RID: 19118 RVA: 0x00107CEC File Offset: 0x00105EEC
		internal static global::System.Data.Entity.Core.Metadata.Edm.EdmFunction FindFunctionImport(global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace workspace, string containerName, string functionImportName)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntityContainer entityContainer;
			if (!workspace.TryGetEntityContainer(containerName, global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace, out entityContainer))
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityClient_UnableToFindFunctionImportContainer(containerName));
			}
			global::System.Data.Entity.Core.Metadata.Edm.EdmFunction edmFunction = null;
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmFunction edmFunction2 in entityContainer.FunctionImports)
			{
				if (edmFunction2.Name == functionImportName)
				{
					edmFunction = edmFunction2;
					break;
				}
			}
			if (edmFunction == null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityClient_UnableToFindFunctionImport(containerName, functionImportName));
			}
			if (edmFunction.IsComposableAttribute)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityClient_FunctionImportMustBeNonComposable(containerName + "." + functionImportName));
			}
			return edmFunction;
		}
	}
}
