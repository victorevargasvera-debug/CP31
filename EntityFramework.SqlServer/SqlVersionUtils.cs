using System;
using System.Data.Common;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity.SqlServer.Resources;
using System.Globalization;

namespace System.Data.Entity.SqlServer
{
	// Token: 0x0200001A RID: 26
	internal static class SqlVersionUtils
	{
		// Token: 0x0600036A RID: 874 RVA: 0x0000E884 File Offset: 0x0000CA84
		internal static global::System.Data.Entity.SqlServer.SqlVersion GetSqlVersion(global::System.Data.Common.DbConnection connection)
		{
			int num = int.Parse(global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.GetServerVersion(connection, new global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext()).Substring(0, 2), global::System.Globalization.CultureInfo.InvariantCulture);
			if (num >= 11)
			{
				return global::System.Data.Entity.SqlServer.SqlVersion.Sql11;
			}
			if (num == 10)
			{
				return global::System.Data.Entity.SqlServer.SqlVersion.Sql10;
			}
			if (num == 9)
			{
				return global::System.Data.Entity.SqlServer.SqlVersion.Sql9;
			}
			return global::System.Data.Entity.SqlServer.SqlVersion.Sql8;
		}

		// Token: 0x0600036B RID: 875 RVA: 0x0000E8D4 File Offset: 0x0000CAD4
		internal static global::System.Data.Entity.SqlServer.ServerType GetServerType(global::System.Data.Common.DbConnection connection)
		{
			global::System.Data.Entity.SqlServer.ServerType result;
			using (global::System.Data.Common.DbCommand dbCommand = connection.CreateCommand())
			{
				dbCommand.CommandText = "select cast(serverproperty('EngineEdition') as int)";
				using (global::System.Data.Common.DbDataReader dbDataReader = global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Command.Reader(dbCommand, new global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext()))
				{
					dbDataReader.Read();
					result = ((dbDataReader.GetInt32(0) == 5) ? global::System.Data.Entity.SqlServer.ServerType.Cloud : global::System.Data.Entity.SqlServer.ServerType.OnPremises);
				}
			}
			return result;
		}

		// Token: 0x0600036C RID: 876 RVA: 0x0000E954 File Offset: 0x0000CB54
		internal static string GetVersionHint(global::System.Data.Entity.SqlServer.SqlVersion version, global::System.Data.Entity.SqlServer.ServerType serverType)
		{
			if (serverType == global::System.Data.Entity.SqlServer.ServerType.Cloud)
			{
				return "2012.Azure";
			}
			if (version <= global::System.Data.Entity.SqlServer.SqlVersion.Sql9)
			{
				if (version == global::System.Data.Entity.SqlServer.SqlVersion.Sql8)
				{
					return "2000";
				}
				if (version == global::System.Data.Entity.SqlServer.SqlVersion.Sql9)
				{
					return "2005";
				}
			}
			else
			{
				if (version == global::System.Data.Entity.SqlServer.SqlVersion.Sql10)
				{
					return "2008";
				}
				if (version == global::System.Data.Entity.SqlServer.SqlVersion.Sql11)
				{
					return "2012";
				}
			}
			throw new global::System.ArgumentException(global::System.Data.Entity.SqlServer.Resources.Strings.UnableToDetermineStoreVersion);
		}

		// Token: 0x0600036D RID: 877 RVA: 0x0000E9AC File Offset: 0x0000CBAC
		internal static global::System.Data.Entity.SqlServer.SqlVersion GetSqlVersion(string versionHint)
		{
			if (!string.IsNullOrEmpty(versionHint) && versionHint != null)
			{
				if (versionHint == "2000")
				{
					return global::System.Data.Entity.SqlServer.SqlVersion.Sql8;
				}
				if (versionHint == "2005")
				{
					return global::System.Data.Entity.SqlServer.SqlVersion.Sql9;
				}
				if (versionHint == "2008")
				{
					return global::System.Data.Entity.SqlServer.SqlVersion.Sql10;
				}
				if (versionHint == "2012")
				{
					return global::System.Data.Entity.SqlServer.SqlVersion.Sql11;
				}
				if (versionHint == "2012.Azure")
				{
					return global::System.Data.Entity.SqlServer.SqlVersion.Sql11;
				}
			}
			throw new global::System.ArgumentException(global::System.Data.Entity.SqlServer.Resources.Strings.UnableToDetermineStoreVersion);
		}

		// Token: 0x0600036E RID: 878 RVA: 0x0000EA20 File Offset: 0x0000CC20
		internal static bool IsPreKatmai(global::System.Data.Entity.SqlServer.SqlVersion sqlVersion)
		{
			return sqlVersion == global::System.Data.Entity.SqlServer.SqlVersion.Sql8 || sqlVersion == global::System.Data.Entity.SqlServer.SqlVersion.Sql9;
		}
	}
}
