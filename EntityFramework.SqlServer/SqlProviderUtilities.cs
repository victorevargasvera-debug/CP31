using System;
using System.Data.Common;
using System.Data.Entity.SqlServer.Resources;
using System.Data.SqlClient;

namespace System.Data.Entity.SqlServer
{
	// Token: 0x02000011 RID: 17
	internal class SqlProviderUtilities
	{
		// Token: 0x0600013A RID: 314 RVA: 0x000064EC File Offset: 0x000046EC
		internal static global::System.Data.SqlClient.SqlConnection GetRequiredSqlConnection(global::System.Data.Common.DbConnection connection)
		{
			global::System.Data.SqlClient.SqlConnection sqlConnection = connection as global::System.Data.SqlClient.SqlConnection;
			if (sqlConnection == null)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.SqlServer.Resources.Strings.Mapping_Provider_WrongConnectionType(typeof(global::System.Data.SqlClient.SqlConnection)));
			}
			return sqlConnection;
		}
	}
}
