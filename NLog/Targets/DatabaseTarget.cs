using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Reflection;
using System.Text;
using System.Transactions;
using NLog.Common;
using NLog.Config;
using NLog.Internal;
using NLog.Layouts;

namespace NLog.Targets
{
	// Token: 0x02000031 RID: 49
	[global::NLog.Targets.Target("Database")]
	public class DatabaseTarget : global::NLog.Targets.Target, global::NLog.Config.IInstallable
	{
		// Token: 0x06000508 RID: 1288 RVA: 0x0000A460 File Offset: 0x00008660
		public DatabaseTarget()
		{
			this.Parameters = new global::System.Collections.Generic.List<global::NLog.Targets.DatabaseParameterInfo>();
			this.InstallDdlCommands = new global::System.Collections.Generic.List<global::NLog.Targets.DatabaseCommandInfo>();
			this.UninstallDdlCommands = new global::System.Collections.Generic.List<global::NLog.Targets.DatabaseCommandInfo>();
			this.DBProvider = "sqlserver";
			this.DBHost = ".";
			this.ConnectionStringsSettings = global::System.Configuration.ConfigurationManager.ConnectionStrings;
			this.CommandType = global::System.Data.CommandType.Text;
			base.OptimizeBufferReuse = (base.GetType() == typeof(global::NLog.Targets.DatabaseTarget));
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x0000A4DC File Offset: 0x000086DC
		public DatabaseTarget(string name) : this()
		{
			base.Name = name;
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600050A RID: 1290 RVA: 0x0000A4EB File Offset: 0x000086EB
		// (set) Token: 0x0600050B RID: 1291 RVA: 0x0000A4F3 File Offset: 0x000086F3
		[global::NLog.Config.RequiredParameter]
		[global::System.ComponentModel.DefaultValue("sqlserver")]
		public string DBProvider { get; set; }

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600050C RID: 1292 RVA: 0x0000A4FC File Offset: 0x000086FC
		// (set) Token: 0x0600050D RID: 1293 RVA: 0x0000A504 File Offset: 0x00008704
		public string ConnectionStringName { get; set; }

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x0000A50D File Offset: 0x0000870D
		// (set) Token: 0x0600050F RID: 1295 RVA: 0x0000A515 File Offset: 0x00008715
		public global::NLog.Layouts.Layout ConnectionString { get; set; }

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x0000A51E File Offset: 0x0000871E
		// (set) Token: 0x06000511 RID: 1297 RVA: 0x0000A526 File Offset: 0x00008726
		public global::NLog.Layouts.Layout InstallConnectionString { get; set; }

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000512 RID: 1298 RVA: 0x0000A52F File Offset: 0x0000872F
		// (set) Token: 0x06000513 RID: 1299 RVA: 0x0000A537 File Offset: 0x00008737
		[global::NLog.Config.ArrayParameter(typeof(global::NLog.Targets.DatabaseCommandInfo), "install-command")]
		public global::System.Collections.Generic.IList<global::NLog.Targets.DatabaseCommandInfo> InstallDdlCommands { get; private set; }

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000514 RID: 1300 RVA: 0x0000A540 File Offset: 0x00008740
		// (set) Token: 0x06000515 RID: 1301 RVA: 0x0000A548 File Offset: 0x00008748
		[global::NLog.Config.ArrayParameter(typeof(global::NLog.Targets.DatabaseCommandInfo), "uninstall-command")]
		public global::System.Collections.Generic.IList<global::NLog.Targets.DatabaseCommandInfo> UninstallDdlCommands { get; private set; }

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x0000A551 File Offset: 0x00008751
		// (set) Token: 0x06000517 RID: 1303 RVA: 0x0000A559 File Offset: 0x00008759
		[global::System.ComponentModel.DefaultValue(false)]
		public bool KeepConnection { get; set; }

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000518 RID: 1304 RVA: 0x0000A562 File Offset: 0x00008762
		// (set) Token: 0x06000519 RID: 1305 RVA: 0x0000A56A File Offset: 0x0000876A
		[global::System.Obsolete("Value will be ignored as logging code always executes outside of a transaction. Marked obsolete on NLog 4.0 and it will be removed in NLog 6.")]
		public bool? UseTransactions { get; set; }

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600051A RID: 1306 RVA: 0x0000A573 File Offset: 0x00008773
		// (set) Token: 0x0600051B RID: 1307 RVA: 0x0000A57B File Offset: 0x0000877B
		public global::NLog.Layouts.Layout DBHost { get; set; }

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600051C RID: 1308 RVA: 0x0000A584 File Offset: 0x00008784
		// (set) Token: 0x0600051D RID: 1309 RVA: 0x0000A58C File Offset: 0x0000878C
		public global::NLog.Layouts.Layout DBUserName { get; set; }

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600051E RID: 1310 RVA: 0x0000A595 File Offset: 0x00008795
		// (set) Token: 0x0600051F RID: 1311 RVA: 0x0000A59D File Offset: 0x0000879D
		public global::NLog.Layouts.Layout DBPassword { get; set; }

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000520 RID: 1312 RVA: 0x0000A5A6 File Offset: 0x000087A6
		// (set) Token: 0x06000521 RID: 1313 RVA: 0x0000A5AE File Offset: 0x000087AE
		public global::NLog.Layouts.Layout DBDatabase { get; set; }

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000522 RID: 1314 RVA: 0x0000A5B7 File Offset: 0x000087B7
		// (set) Token: 0x06000523 RID: 1315 RVA: 0x0000A5BF File Offset: 0x000087BF
		[global::NLog.Config.RequiredParameter]
		public global::NLog.Layouts.Layout CommandText { get; set; }

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000524 RID: 1316 RVA: 0x0000A5C8 File Offset: 0x000087C8
		// (set) Token: 0x06000525 RID: 1317 RVA: 0x0000A5D0 File Offset: 0x000087D0
		[global::System.ComponentModel.DefaultValue(global::System.Data.CommandType.Text)]
		public global::System.Data.CommandType CommandType { get; set; }

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000526 RID: 1318 RVA: 0x0000A5D9 File Offset: 0x000087D9
		// (set) Token: 0x06000527 RID: 1319 RVA: 0x0000A5E1 File Offset: 0x000087E1
		[global::NLog.Config.ArrayParameter(typeof(global::NLog.Targets.DatabaseParameterInfo), "parameter")]
		public global::System.Collections.Generic.IList<global::NLog.Targets.DatabaseParameterInfo> Parameters { get; private set; }

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x0000A5EA File Offset: 0x000087EA
		// (set) Token: 0x06000529 RID: 1321 RVA: 0x0000A5F2 File Offset: 0x000087F2
		internal global::System.Data.Common.DbProviderFactory ProviderFactory { get; set; }

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x0000A5FB File Offset: 0x000087FB
		// (set) Token: 0x0600052B RID: 1323 RVA: 0x0000A603 File Offset: 0x00008803
		internal global::System.Configuration.ConnectionStringSettingsCollection ConnectionStringsSettings { get; set; }

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600052C RID: 1324 RVA: 0x0000A60C File Offset: 0x0000880C
		// (set) Token: 0x0600052D RID: 1325 RVA: 0x0000A614 File Offset: 0x00008814
		internal global::System.Type ConnectionType { get; set; }

		// Token: 0x0600052E RID: 1326 RVA: 0x0000A61D File Offset: 0x0000881D
		public void Install(global::NLog.Config.InstallationContext installationContext)
		{
			this.RunInstallCommands(installationContext, this.InstallDdlCommands);
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x0000A62C File Offset: 0x0000882C
		public void Uninstall(global::NLog.Config.InstallationContext installationContext)
		{
			this.RunInstallCommands(installationContext, this.UninstallDdlCommands);
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x0000A63C File Offset: 0x0000883C
		public bool? IsInstalled(global::NLog.Config.InstallationContext installationContext)
		{
			return null;
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x0000A654 File Offset: 0x00008854
		internal global::System.Data.IDbConnection OpenConnection(string connectionString)
		{
			global::System.Data.IDbConnection dbConnection;
			if (this.ProviderFactory != null)
			{
				dbConnection = this.ProviderFactory.CreateConnection();
			}
			else
			{
				dbConnection = (global::System.Data.IDbConnection)global::System.Activator.CreateInstance(this.ConnectionType);
			}
			if (dbConnection == null)
			{
				throw new global::NLog.NLogRuntimeException("Creation of connection failed");
			}
			dbConnection.ConnectionString = connectionString;
			dbConnection.Open();
			return dbConnection;
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x0000A6A4 File Offset: 0x000088A4
		protected override void InitializeTarget()
		{
			base.InitializeTarget();
			if (this.UseTransactions != null)
			{
				global::NLog.Common.InternalLogger.Warn<string>("DatabaseTarget(Name={0}): UseTransactions property is obsolete and will not be used - will be removed in NLog 6", base.Name);
			}
			bool flag = false;
			string text = string.Empty;
			if (!string.IsNullOrEmpty(this.ConnectionStringName))
			{
				global::System.Configuration.ConnectionStringSettings connectionStringSettings = this.ConnectionStringsSettings[this.ConnectionStringName];
				if (connectionStringSettings == null)
				{
					throw new global::NLog.NLogConfigurationException(string.Format("Connection string '{0}' is not declared in <connectionStrings /> section.", this.ConnectionStringName));
				}
				string connectionString = connectionStringSettings.ConnectionString;
				if (!string.IsNullOrEmpty((connectionString != null) ? connectionString.Trim() : null))
				{
					this.ConnectionString = global::NLog.Layouts.SimpleLayout.Escape(connectionStringSettings.ConnectionString.Trim());
				}
				string providerName = connectionStringSettings.ProviderName;
				text = (((providerName != null) ? providerName.Trim() : null) ?? string.Empty);
			}
			if (this.ConnectionString != null)
			{
				try
				{
					string connectionString2 = this.BuildConnectionString(global::NLog.LogEventInfo.CreateNullEvent());
					global::System.Data.Common.DbConnectionStringBuilder dbConnectionStringBuilder = new global::System.Data.Common.DbConnectionStringBuilder
					{
						ConnectionString = connectionString2
					};
					object obj;
					if (dbConnectionStringBuilder.TryGetValue("provider connection string", out obj))
					{
						object obj2;
						if (dbConnectionStringBuilder.TryGetValue("provider", out obj2))
						{
							string text2 = obj2.ToString();
							text = (((text2 != null) ? text2.Trim() : null) ?? string.Empty);
						}
						this.ConnectionString = global::NLog.Layouts.SimpleLayout.Escape(obj.ToString());
					}
				}
				catch (global::System.Exception ex)
				{
					if (!string.IsNullOrEmpty(this.ConnectionStringName))
					{
						global::NLog.Common.InternalLogger.Warn(ex, "DatabaseTarget(Name={0}): DbConnectionStringBuilder failed to parse '{1}' ConnectionString", new object[]
						{
							base.Name,
							this.ConnectionStringName
						});
					}
					else
					{
						global::NLog.Common.InternalLogger.Warn(ex, "DatabaseTarget(Name={0}): DbConnectionStringBuilder failed to parse ConnectionString", new object[]
						{
							base.Name
						});
					}
				}
			}
			if (string.IsNullOrEmpty(text))
			{
				string dbprovider = this.DBProvider;
				string text3 = ((dbprovider != null) ? dbprovider.Trim() : null) ?? string.Empty;
				if (!string.IsNullOrEmpty(text3))
				{
					foreach (object obj3 in global::System.Data.Common.DbProviderFactories.GetFactoryClasses().Rows)
					{
						string text4 = (string)((global::System.Data.DataRow)obj3)["InvariantName"];
						if (string.Equals(text4, text3, global::System.StringComparison.OrdinalIgnoreCase))
						{
							text = text4;
							break;
						}
					}
				}
			}
			if (!string.IsNullOrEmpty(text))
			{
				try
				{
					this.ProviderFactory = global::System.Data.Common.DbProviderFactories.GetFactory(text);
					flag = true;
				}
				catch (global::System.Exception ex2)
				{
					global::NLog.Common.InternalLogger.Error(ex2, "DatabaseTarget(Name={0}): DbProviderFactories failed to get factory from ProviderName={1}", new object[]
					{
						base.Name,
						text
					});
					throw;
				}
			}
			if (!flag)
			{
				try
				{
					this.SetConnectionType();
					if (this.ConnectionType == null)
					{
						global::NLog.Common.InternalLogger.Warn<string, string>("DatabaseTarget(Name={0}): No ConnectionType created from DBProvider={1}", base.Name, this.DBProvider);
					}
				}
				catch (global::System.Exception ex3)
				{
					global::NLog.Common.InternalLogger.Error(ex3, "DatabaseTarget(Name={0}): Failed to create ConnectionType from DBProvider={1}", new object[]
					{
						base.Name,
						this.DBProvider
					});
					throw;
				}
			}
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x0000A988 File Offset: 0x00008B88
		private void SetConnectionType()
		{
			string a = this.DBProvider.ToUpperInvariant();
			if (a == "SQLSERVER" || a == "MSSQL" || a == "MICROSOFT" || a == "MSDE")
			{
				global::System.Reflection.Assembly assembly = typeof(global::System.Data.IDbConnection).GetAssembly();
				this.ConnectionType = assembly.GetType("System.Data.SqlClient.SqlConnection", true, true);
				return;
			}
			if (a == "OLEDB")
			{
				global::System.Reflection.Assembly assembly2 = typeof(global::System.Data.IDbConnection).GetAssembly();
				this.ConnectionType = assembly2.GetType("System.Data.OleDb.OleDbConnection", true, true);
				return;
			}
			if (!(a == "ODBC"))
			{
				this.ConnectionType = global::System.Type.GetType(this.DBProvider, true, true);
				return;
			}
			global::System.Reflection.Assembly assembly3 = typeof(global::System.Data.IDbConnection).GetAssembly();
			this.ConnectionType = assembly3.GetType("System.Data.Odbc.OdbcConnection", true, true);
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x0000AA70 File Offset: 0x00008C70
		protected override void CloseTarget()
		{
			base.CloseTarget();
			global::NLog.Common.InternalLogger.Trace<string>("DatabaseTarget(Name={0}): Close connection because of CloseTarget", base.Name);
			this.CloseConnection();
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x0000AA90 File Offset: 0x00008C90
		protected override void Write(global::NLog.LogEventInfo logEvent)
		{
			try
			{
				this.WriteEventToDatabase(logEvent);
			}
			catch (global::System.Exception ex)
			{
				global::NLog.Common.InternalLogger.Error(ex, "DatabaseTarget(Name={0}): Error when writing to database.", new object[]
				{
					base.Name
				});
				if (ex.MustBeRethrownImmediately())
				{
					throw;
				}
				global::NLog.Common.InternalLogger.Trace<string>("DatabaseTarget(Name={0}): Close connection because of error", base.Name);
				this.CloseConnection();
				throw;
			}
			finally
			{
				if (!this.KeepConnection)
				{
					global::NLog.Common.InternalLogger.Trace<string>("DatabaseTarget(Name={0}): Close connection (KeepConnection = false).", base.Name);
					this.CloseConnection();
				}
			}
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x0000AB20 File Offset: 0x00008D20
		[global::System.Obsolete("Instead override Write(IList<AsyncLogEventInfo> logEvents. Marked obsolete on NLog 4.5")]
		protected override void Write(global::NLog.Common.AsyncLogEventInfo[] logEvents)
		{
			this.Write(logEvents);
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x0000AB2C File Offset: 0x00008D2C
		protected override void Write(global::System.Collections.Generic.IList<global::NLog.Common.AsyncLogEventInfo> logEvents)
		{
			global::NLog.Internal.SortHelpers.ReadOnlySingleBucketDictionary<string, global::System.Collections.Generic.IList<global::NLog.Common.AsyncLogEventInfo>> readOnlySingleBucketDictionary = logEvents.BucketSort((global::NLog.Common.AsyncLogEventInfo c) => this.BuildConnectionString(c.LogEvent));
			try
			{
				foreach (global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.IList<global::NLog.Common.AsyncLogEventInfo>> keyValuePair in readOnlySingleBucketDictionary)
				{
					for (int i = 0; i < keyValuePair.Value.Count; i++)
					{
						global::NLog.Common.AsyncLogEventInfo asyncLogEventInfo = keyValuePair.Value[i];
						try
						{
							this.WriteEventToDatabase(asyncLogEventInfo.LogEvent);
							asyncLogEventInfo.Continuation(null);
						}
						catch (global::System.Exception ex)
						{
							global::NLog.Common.InternalLogger.Error(ex, "DatabaseTarget(Name={0}): Error when writing to database.", new object[]
							{
								base.Name
							});
							if (ex.MustBeRethrownImmediately())
							{
								throw;
							}
							global::NLog.Common.InternalLogger.Trace<string>("DatabaseTarget(Name={0}): Close connection because of exception", base.Name);
							this.CloseConnection();
							asyncLogEventInfo.Continuation(ex);
							if (ex.MustBeRethrown())
							{
								throw;
							}
						}
					}
				}
			}
			finally
			{
				if (!this.KeepConnection)
				{
					global::NLog.Common.InternalLogger.Trace<string>("DatabaseTarget(Name={0}): Close connection because of KeepConnection=false", base.Name);
					this.CloseConnection();
				}
			}
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x0000AC68 File Offset: 0x00008E68
		private void WriteEventToDatabase(global::NLog.LogEventInfo logEvent)
		{
			using (global::System.Transactions.TransactionScope transactionScope = new global::System.Transactions.TransactionScope(global::System.Transactions.TransactionScopeOption.Suppress))
			{
				this.EnsureConnectionOpen(this.BuildConnectionString(logEvent));
				using (global::System.Data.IDbCommand dbCommand = this._activeConnection.CreateCommand())
				{
					dbCommand.CommandText = base.RenderLogEvent(this.CommandText, logEvent);
					dbCommand.CommandType = this.CommandType;
					global::NLog.Common.InternalLogger.Trace<string, global::System.Data.CommandType, string>("DatabaseTarget(Name={0}): Executing {1}: {2}", base.Name, dbCommand.CommandType, dbCommand.CommandText);
					this.AddParametersToCommand(dbCommand, this.Parameters, logEvent);
					int arg = dbCommand.ExecuteNonQuery();
					global::NLog.Common.InternalLogger.Trace<string, int>("DatabaseTarget(Name={0}): Finished execution, result = {1}", base.Name, arg);
				}
				transactionScope.Complete();
			}
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x0000AD30 File Offset: 0x00008F30
		protected string BuildConnectionString(global::NLog.LogEventInfo logEvent)
		{
			if (this.ConnectionString != null)
			{
				return base.RenderLogEvent(this.ConnectionString, logEvent);
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("Server=");
			stringBuilder.Append(base.RenderLogEvent(this.DBHost, logEvent));
			stringBuilder.Append(";");
			if (this.DBUserName == null)
			{
				stringBuilder.Append("Trusted_Connection=SSPI;");
			}
			else
			{
				stringBuilder.Append("User id=");
				stringBuilder.Append(base.RenderLogEvent(this.DBUserName, logEvent));
				stringBuilder.Append(";Password=");
				stringBuilder.Append(base.RenderLogEvent(this.DBPassword, logEvent));
				stringBuilder.Append(";");
			}
			if (this.DBDatabase != null)
			{
				stringBuilder.Append("Database=");
				stringBuilder.Append(base.RenderLogEvent(this.DBDatabase, logEvent));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x0000AE18 File Offset: 0x00009018
		private void EnsureConnectionOpen(string connectionString)
		{
			if (this._activeConnection != null && this._activeConnectionString != connectionString)
			{
				global::NLog.Common.InternalLogger.Trace<string>("DatabaseTarget(Name={0}): Close connection because of opening new.", base.Name);
				this.CloseConnection();
			}
			if (this._activeConnection != null)
			{
				return;
			}
			global::NLog.Common.InternalLogger.Trace<string>("DatabaseTarget(Name={0}): Open connection.", base.Name);
			this._activeConnection = this.OpenConnection(connectionString);
			this._activeConnectionString = connectionString;
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x0000AE7E File Offset: 0x0000907E
		private void CloseConnection()
		{
			if (this._activeConnection != null)
			{
				this._activeConnection.Close();
				this._activeConnection.Dispose();
				this._activeConnection = null;
				this._activeConnectionString = null;
			}
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x0000AEAC File Offset: 0x000090AC
		private void RunInstallCommands(global::NLog.Config.InstallationContext installationContext, global::System.Collections.Generic.IEnumerable<global::NLog.Targets.DatabaseCommandInfo> commands)
		{
			global::NLog.LogEventInfo logEvent = installationContext.CreateLogEvent();
			try
			{
				foreach (global::NLog.Targets.DatabaseCommandInfo databaseCommandInfo in commands)
				{
					string connectionString;
					if (databaseCommandInfo.ConnectionString != null)
					{
						connectionString = base.RenderLogEvent(databaseCommandInfo.ConnectionString, logEvent);
					}
					else if (this.InstallConnectionString != null)
					{
						connectionString = base.RenderLogEvent(this.InstallConnectionString, logEvent);
					}
					else
					{
						connectionString = this.BuildConnectionString(logEvent);
					}
					if (this.ConnectionType == null)
					{
						this.SetConnectionType();
					}
					this.EnsureConnectionOpen(connectionString);
					using (global::System.Data.IDbCommand dbCommand = this._activeConnection.CreateCommand())
					{
						dbCommand.CommandType = databaseCommandInfo.CommandType;
						dbCommand.CommandText = base.RenderLogEvent(databaseCommandInfo.Text, logEvent);
						this.AddParametersToCommand(dbCommand, databaseCommandInfo.Parameters, logEvent);
						try
						{
							installationContext.Trace("DatabaseTarget(Name={0}) - Executing {1} '{2}'", new object[]
							{
								base.Name,
								dbCommand.CommandType,
								dbCommand.CommandText
							});
							dbCommand.ExecuteNonQuery();
						}
						catch (global::System.Exception ex)
						{
							if (ex.MustBeRethrownImmediately())
							{
								throw;
							}
							if (!databaseCommandInfo.IgnoreFailures && !installationContext.IgnoreFailures)
							{
								installationContext.Error(ex.Message, new object[0]);
								throw;
							}
							installationContext.Warning(ex.Message, new object[0]);
						}
					}
				}
			}
			finally
			{
				global::NLog.Common.InternalLogger.Trace<string>("DatabaseTarget(Name={0}): Close connection after install.", base.Name);
				this.CloseConnection();
			}
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x0000B088 File Offset: 0x00009288
		private void AddParametersToCommand(global::System.Data.IDbCommand command, global::System.Collections.Generic.IList<global::NLog.Targets.DatabaseParameterInfo> databaseParameterInfos, global::NLog.LogEventInfo logEvent)
		{
			for (int i = 0; i < databaseParameterInfos.Count; i++)
			{
				global::NLog.Targets.DatabaseParameterInfo databaseParameterInfo = databaseParameterInfos[i];
				global::System.Data.IDbDataParameter dbDataParameter = command.CreateParameter();
				dbDataParameter.Direction = global::System.Data.ParameterDirection.Input;
				if (databaseParameterInfo.Name != null)
				{
					dbDataParameter.ParameterName = databaseParameterInfo.Name;
				}
				if (databaseParameterInfo.Size != 0)
				{
					dbDataParameter.Size = databaseParameterInfo.Size;
				}
				if (databaseParameterInfo.Precision != 0)
				{
					dbDataParameter.Precision = databaseParameterInfo.Precision;
				}
				if (databaseParameterInfo.Scale != 0)
				{
					dbDataParameter.Scale = databaseParameterInfo.Scale;
				}
				string value = base.RenderLogEvent(databaseParameterInfo.Layout, logEvent);
				dbDataParameter.Value = value;
				command.Parameters.Add(dbDataParameter);
				global::NLog.Common.InternalLogger.Trace<string, object, global::System.Data.DbType>("  DatabaseTarget: Parameter: '{0}' = '{1}' ({2})", dbDataParameter.ParameterName, dbDataParameter.Value, dbDataParameter.DbType);
			}
		}

		// Token: 0x04000091 RID: 145
		private global::System.Data.IDbConnection _activeConnection;

		// Token: 0x04000092 RID: 146
		private string _activeConnectionString;
	}
}
