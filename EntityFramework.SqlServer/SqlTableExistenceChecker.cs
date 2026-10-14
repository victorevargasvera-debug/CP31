using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Infrastructure.Interception;
using System.Text;

namespace System.Data.Entity.SqlServer
{
	// Token: 0x02000016 RID: 22
	internal class SqlTableExistenceChecker : global::System.Data.Entity.Infrastructure.TableExistenceChecker
	{
		// Token: 0x0600022D RID: 557 RVA: 0x0000BCB4 File Offset: 0x00009EB4
		public override bool AnyModelTableExistsInDatabase(global::System.Data.Entity.Core.Objects.ObjectContext context, global::System.Data.Common.DbConnection connection, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> modelTables, string edmMetadataContextTableName)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet in modelTables)
			{
				stringBuilder.Append("'");
				stringBuilder.Append((string)entitySet.MetadataProperties["Schema"].Value);
				stringBuilder.Append(".");
				stringBuilder.Append(this.GetTableName(entitySet));
				stringBuilder.Append("',");
			}
			stringBuilder.Remove(stringBuilder.Length - 1, 1);
			bool result;
			using (global::System.Data.Common.DbCommand command = connection.CreateCommand())
			{
				global::System.Data.Common.DbCommand command2 = command;
				string[] array = new string[5];
				array[0] = "\r\nSELECT Count(*)\r\nFROM INFORMATION_SCHEMA.TABLES AS t\r\nWHERE t.TABLE_SCHEMA + '.' + t.TABLE_NAME IN (";
				int num = 1;
				global::System.Text.StringBuilder stringBuilder2 = stringBuilder;
				array[num] = ((stringBuilder2 != null) ? stringBuilder2.ToString() : null);
				array[2] = ")\r\n    OR t.TABLE_NAME = '";
				array[3] = edmMetadataContextTableName;
				array[4] = "'";
				command2.CommandText = string.Concat(array);
				bool flag = true;
				if (global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.GetState(connection, context.InterceptionContext) == global::System.Data.ConnectionState.Open)
				{
					flag = false;
					global::System.Data.Entity.Core.EntityClient.EntityTransaction currentTransaction = ((global::System.Data.Entity.Core.EntityClient.EntityConnection)context.Connection).CurrentTransaction;
					if (currentTransaction != null)
					{
						command.Transaction = currentTransaction.StoreTransaction;
					}
				}
				global::System.Data.Entity.Infrastructure.IDbExecutionStrategy executionStrategy = global::System.Data.Entity.Core.Common.DbProviderServices.GetExecutionStrategy(connection);
				try
				{
					result = executionStrategy.Execute<bool>(delegate()
					{
						if (global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.GetState(connection, context.InterceptionContext) == global::System.Data.ConnectionState.Broken)
						{
							global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.Close(connection, context.InterceptionContext);
						}
						if (global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.GetState(connection, context.InterceptionContext) == global::System.Data.ConnectionState.Closed)
						{
							global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.Open(connection, context.InterceptionContext);
						}
						return (int)global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Command.Scalar(command, new global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext(context.InterceptionContext)) > 0;
					});
				}
				finally
				{
					if (flag && global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.GetState(connection, context.InterceptionContext) != global::System.Data.ConnectionState.Closed)
					{
						global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.Close(connection, context.InterceptionContext);
					}
				}
			}
			return result;
		}
	}
}
