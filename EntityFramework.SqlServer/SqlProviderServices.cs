using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Hierarchy;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity.Migrations.Sql;
using System.Data.Entity.Spatial;
using System.Data.Entity.SqlServer.Resources;
using System.Data.Entity.SqlServer.SqlGen;
using System.Data.Entity.SqlServer.Utilities;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;

namespace System.Data.Entity.SqlServer
{
	// Token: 0x02000010 RID: 16
	public sealed class SqlProviderServices : global::System.Data.Entity.Core.Common.DbProviderServices
	{
		// Token: 0x06000106 RID: 262 RVA: 0x00005068 File Offset: 0x00003268
		private SqlProviderServices()
		{
			base.AddDependencyResolver(new global::System.Data.Entity.Infrastructure.DependencyResolution.SingletonDependencyResolver<global::System.Data.Entity.Infrastructure.IDbConnectionFactory>(new global::System.Data.Entity.Infrastructure.LocalDbConnectionFactory()));
			base.AddDependencyResolver(new global::System.Data.Entity.Infrastructure.DependencyResolution.ExecutionStrategyResolver<global::System.Data.Entity.SqlServer.DefaultSqlExecutionStrategy>("System.Data.SqlClient", null, () => new global::System.Data.Entity.SqlServer.DefaultSqlExecutionStrategy()));
			base.AddDependencyResolver(new global::System.Data.Entity.Infrastructure.DependencyResolution.SingletonDependencyResolver<global::System.Func<global::System.Data.Entity.Migrations.Sql.MigrationSqlGenerator>>(() => new global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator(), "System.Data.SqlClient"));
			base.AddDependencyResolver(new global::System.Data.Entity.Infrastructure.DependencyResolution.SingletonDependencyResolver<global::System.Data.Entity.Infrastructure.TableExistenceChecker>(new global::System.Data.Entity.SqlServer.SqlTableExistenceChecker(), "System.Data.SqlClient"));
			base.AddDependencyResolver(new global::System.Data.Entity.Infrastructure.DependencyResolution.SingletonDependencyResolver<global::System.Data.Entity.Spatial.DbSpatialServices>(global::System.Data.Entity.SqlServer.SqlSpatialServices.Instance, delegate(object k)
			{
				if (k == null)
				{
					return true;
				}
				global::System.Data.Entity.Infrastructure.DbProviderInfo dbProviderInfo = k as global::System.Data.Entity.Infrastructure.DbProviderInfo;
				return dbProviderInfo != null && dbProviderInfo.ProviderInvariantName == "System.Data.SqlClient" && global::System.Data.Entity.SqlServer.SqlProviderServices.SupportsSpatial(dbProviderInfo.ProviderManifestToken);
			}));
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000107 RID: 263 RVA: 0x00005139 File Offset: 0x00003339
		public static global::System.Data.Entity.SqlServer.SqlProviderServices Instance
		{
			get
			{
				return global::System.Data.Entity.SqlServer.SqlProviderServices._providerInstance;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000108 RID: 264 RVA: 0x00005140 File Offset: 0x00003340
		// (set) Token: 0x06000109 RID: 265 RVA: 0x00005147 File Offset: 0x00003347
		public static string SqlServerTypesAssemblyName { get; set; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600010A RID: 266 RVA: 0x0000514F File Offset: 0x0000334F
		// (set) Token: 0x0600010B RID: 267 RVA: 0x00005156 File Offset: 0x00003356
		public static bool TruncateDecimalsToScale
		{
			get
			{
				return global::System.Data.Entity.SqlServer.SqlProviderServices._truncateDecimalsToScale;
			}
			set
			{
				global::System.Data.Entity.SqlServer.SqlProviderServices._truncateDecimalsToScale = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600010C RID: 268 RVA: 0x0000515E File Offset: 0x0000335E
		// (set) Token: 0x0600010D RID: 269 RVA: 0x00005165 File Offset: 0x00003365
		public static bool UseScopeIdentity
		{
			get
			{
				return global::System.Data.Entity.SqlServer.SqlProviderServices._useScopeIdentity;
			}
			set
			{
				global::System.Data.Entity.SqlServer.SqlProviderServices._useScopeIdentity = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600010E RID: 270 RVA: 0x0000516D File Offset: 0x0000336D
		// (set) Token: 0x0600010F RID: 271 RVA: 0x00005174 File Offset: 0x00003374
		public static bool UseRowNumberOrderingInOffsetQueries
		{
			get
			{
				return global::System.Data.Entity.SqlServer.SqlProviderServices._useRowNumberOrderingInOffsetQueries;
			}
			set
			{
				global::System.Data.Entity.SqlServer.SqlProviderServices._useRowNumberOrderingInOffsetQueries = value;
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0000517C File Offset: 0x0000337C
		public override void RegisterInfoMessageHandler(global::System.Data.Common.DbConnection connection, global::System.Action<string> handler)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Common.DbConnection>(connection, "connection");
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Action<string>>(handler, "handler");
			global::System.Data.SqlClient.SqlConnection sqlConnection = connection as global::System.Data.SqlClient.SqlConnection;
			if (sqlConnection == null)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.SqlServer.Resources.Strings.Mapping_Provider_WrongConnectionType(typeof(global::System.Data.SqlClient.SqlConnection)));
			}
			sqlConnection.InfoMessage += delegate(object _, global::System.Data.SqlClient.SqlInfoMessageEventArgs e)
			{
				if (!string.IsNullOrWhiteSpace(e.Message))
				{
					handler(e.Message);
				}
			};
		}

		// Token: 0x06000111 RID: 273 RVA: 0x000051E4 File Offset: 0x000033E4
		protected override global::System.Data.Entity.Core.Common.DbCommandDefinition CreateDbCommandDefinition(global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest, global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree commandTree)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.DbProviderManifest>(providerManifest, "providerManifest");
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree>(commandTree, "commandTree");
			global::System.Data.Common.DbCommand prototype = global::System.Data.Entity.SqlServer.SqlProviderServices.CreateCommand(providerManifest, commandTree);
			return this.CreateCommandDefinition(prototype);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00005218 File Offset: 0x00003418
		protected override global::System.Data.Common.DbCommand CloneDbCommand(global::System.Data.Common.DbCommand fromDbCommand)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Common.DbCommand>(fromDbCommand, "fromDbCommand");
			global::System.Data.SqlClient.SqlCommand sqlCommand = fromDbCommand as global::System.Data.SqlClient.SqlCommand;
			if (sqlCommand == null)
			{
				return base.CloneDbCommand(fromDbCommand);
			}
			global::System.Data.SqlClient.SqlCommand sqlCommand2 = new global::System.Data.SqlClient.SqlCommand();
			sqlCommand2.CommandText = sqlCommand.CommandText;
			sqlCommand2.CommandTimeout = sqlCommand.CommandTimeout;
			sqlCommand2.CommandType = sqlCommand.CommandType;
			sqlCommand2.Connection = sqlCommand.Connection;
			sqlCommand2.Transaction = sqlCommand.Transaction;
			sqlCommand2.UpdatedRowSource = sqlCommand.UpdatedRowSource;
			foreach (object obj in sqlCommand.Parameters)
			{
				global::System.ICloneable cloneable = obj as global::System.ICloneable;
				sqlCommand2.Parameters.Add((cloneable == null) ? obj : cloneable.Clone());
			}
			return sqlCommand2;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x000052F8 File Offset: 0x000034F8
		private static global::System.Data.Common.DbCommand CreateCommand(global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest, global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree commandTree)
		{
			global::System.Data.Entity.SqlServer.SqlProviderManifest sqlProviderManifest = providerManifest as global::System.Data.Entity.SqlServer.SqlProviderManifest;
			if (sqlProviderManifest == null)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.SqlServer.Resources.Strings.Mapping_Provider_WrongManifestType(typeof(global::System.Data.Entity.SqlServer.SqlProviderManifest)));
			}
			global::System.Data.Entity.SqlServer.SqlVersion sqlVersion = sqlProviderManifest.SqlVersion;
			global::System.Data.SqlClient.SqlCommand sqlCommand = new global::System.Data.SqlClient.SqlCommand();
			global::System.Collections.Generic.List<global::System.Data.SqlClient.SqlParameter> list;
			global::System.Data.CommandType commandType;
			global::System.Collections.Generic.HashSet<string> hashSet;
			sqlCommand.CommandText = global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.GenerateSql(commandTree, sqlVersion, out list, out commandType, out hashSet);
			sqlCommand.CommandType = commandType;
			global::System.Data.Entity.Core.Metadata.Edm.EdmFunction edmFunction = null;
			if (commandTree.CommandTreeKind == global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTreeKind.Function)
			{
				edmFunction = ((global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionCommandTree)commandTree).EdmFunction;
			}
			foreach (global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> keyValuePair in commandTree.Parameters)
			{
				global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter functionParameter;
				global::System.Data.SqlClient.SqlParameter value;
				if (edmFunction != null && edmFunction.Parameters.TryGetValue(keyValuePair.Key, false, out functionParameter))
				{
					value = global::System.Data.Entity.SqlServer.SqlProviderServices.CreateSqlParameter(functionParameter.Name, functionParameter.TypeUsage, functionParameter.Mode, global::System.DBNull.Value, false, sqlVersion);
				}
				else
				{
					global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type = (hashSet != null && hashSet.Contains(keyValuePair.Key)) ? keyValuePair.Value.ForceNonUnicode() : keyValuePair.Value;
					value = global::System.Data.Entity.SqlServer.SqlProviderServices.CreateSqlParameter(keyValuePair.Key, type, global::System.Data.Entity.Core.Metadata.Edm.ParameterMode.In, global::System.DBNull.Value, false, sqlVersion);
				}
				sqlCommand.Parameters.Add(value);
			}
			if (list != null && 0 < list.Count)
			{
				if (commandTree.CommandTreeKind != global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTreeKind.Delete && commandTree.CommandTreeKind != global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTreeKind.Insert && commandTree.CommandTreeKind != global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTreeKind.Update)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.SqlServer.Resources.Strings.ADP_InternalProviderError(1017));
				}
				foreach (global::System.Data.SqlClient.SqlParameter value2 in list)
				{
					sqlCommand.Parameters.Add(value2);
				}
			}
			return sqlCommand;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x000054BC File Offset: 0x000036BC
		protected override void SetDbParameterValue(global::System.Data.Common.DbParameter parameter, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage parameterType, object value)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Common.DbParameter>(parameter, "parameter");
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(parameterType, "parameterType");
			value = global::System.Data.Entity.SqlServer.SqlProviderServices.EnsureSqlParameterValue(value);
			if (parameterType.IsPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String) || parameterType.IsPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary))
			{
				if (global::System.Data.Entity.SqlServer.SqlProviderServices.GetParameterSize(parameterType, (parameter.Direction & global::System.Data.ParameterDirection.Output) == global::System.Data.ParameterDirection.Output) != null)
				{
					parameter.Value = value;
					return;
				}
				int size = parameter.Size;
				parameter.Size = 0;
				parameter.Value = value;
				if (size > -1)
				{
					if (parameter.Size < size)
					{
						parameter.Size = size;
						return;
					}
				}
				else
				{
					int nonMaxLength = global::System.Data.Entity.SqlServer.SqlProviderServices.GetNonMaxLength(((global::System.Data.SqlClient.SqlParameter)parameter).SqlDbType);
					if (parameter.Size < nonMaxLength)
					{
						parameter.Size = nonMaxLength;
						return;
					}
					if (parameter.Size > nonMaxLength)
					{
						parameter.Size = -1;
						return;
					}
				}
			}
			else
			{
				parameter.Value = value;
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00005588 File Offset: 0x00003788
		protected override string GetDbProviderManifestToken(global::System.Data.Common.DbConnection connection)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Common.DbConnection>(connection, "connection");
			if (string.IsNullOrEmpty(global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.GetConnectionString(connection, new global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext())))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.SqlServer.Resources.Strings.UnableToDetermineStoreVersion);
			}
			string providerManifestToken = null;
			try
			{
				global::System.Data.Entity.SqlServer.SqlProviderServices.UsingConnection(connection, delegate(global::System.Data.Common.DbConnection conn)
				{
					providerManifestToken = global::System.Data.Entity.SqlServer.SqlProviderServices.QueryForManifestToken(conn);
				});
				return providerManifestToken;
			}
			catch
			{
			}
			try
			{
				this.UsingMasterConnection(connection, delegate(global::System.Data.Common.DbConnection conn)
				{
					providerManifestToken = global::System.Data.Entity.SqlServer.SqlProviderServices.QueryForManifestToken(conn);
				});
				return providerManifestToken;
			}
			catch
			{
			}
			return "2008";
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00005638 File Offset: 0x00003838
		private static string QueryForManifestToken(global::System.Data.Common.DbConnection conn)
		{
			global::System.Data.Entity.SqlServer.SqlVersion sqlVersion = global::System.Data.Entity.SqlServer.SqlVersionUtils.GetSqlVersion(conn);
			global::System.Data.Entity.SqlServer.ServerType serverType = (sqlVersion >= global::System.Data.Entity.SqlServer.SqlVersion.Sql11) ? global::System.Data.Entity.SqlServer.SqlVersionUtils.GetServerType(conn) : global::System.Data.Entity.SqlServer.ServerType.OnPremises;
			return global::System.Data.Entity.SqlServer.SqlVersionUtils.GetVersionHint(sqlVersion, serverType);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00005660 File Offset: 0x00003860
		protected override global::System.Data.Entity.Core.Common.DbProviderManifest GetDbProviderManifest(string versionHint)
		{
			if (string.IsNullOrEmpty(versionHint))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.SqlServer.Resources.Strings.UnableToDetermineStoreVersion);
			}
			return this._providerManifests.GetOrAdd(versionHint, (string s) => new global::System.Data.Entity.SqlServer.SqlProviderManifest(s));
		}

		// Token: 0x06000118 RID: 280 RVA: 0x000056A0 File Offset: 0x000038A0
		protected override global::System.Data.Entity.Spatial.DbSpatialDataReader GetDbSpatialDataReader(global::System.Data.Common.DbDataReader fromReader, string versionHint)
		{
			global::System.Data.SqlClient.SqlDataReader sqlDataReader = fromReader as global::System.Data.SqlClient.SqlDataReader;
			if (sqlDataReader == null)
			{
				throw new global::System.Data.Entity.Core.ProviderIncompatibleException(global::System.Data.Entity.SqlServer.Resources.Strings.SqlProvider_NeedSqlDataReader(fromReader.GetType()));
			}
			if (!global::System.Data.Entity.SqlServer.SqlProviderServices.SupportsSpatial(versionHint))
			{
				return null;
			}
			return new global::System.Data.Entity.SqlServer.SqlSpatialDataReader(base.GetSpatialServices(new global::System.Data.Entity.Infrastructure.DbProviderInfo("System.Data.SqlClient", versionHint)), new global::System.Data.Entity.SqlServer.Utilities.SqlDataReaderWrapper(sqlDataReader));
		}

		// Token: 0x06000119 RID: 281 RVA: 0x000056EE File Offset: 0x000038EE
		[global::System.Obsolete("Return DbSpatialServices from the GetService method. See http://go.microsoft.com/fwlink/?LinkId=260882 for more information.")]
		protected override global::System.Data.Entity.Spatial.DbSpatialServices DbGetSpatialServices(string versionHint)
		{
			if (!global::System.Data.Entity.SqlServer.SqlProviderServices.SupportsSpatial(versionHint))
			{
				return null;
			}
			return global::System.Data.Entity.SqlServer.SqlSpatialServices.Instance;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x000056FF File Offset: 0x000038FF
		private static bool SupportsSpatial(string versionHint)
		{
			if (string.IsNullOrEmpty(versionHint))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.SqlServer.Resources.Strings.UnableToDetermineStoreVersion);
			}
			return global::System.Data.Entity.SqlServer.SqlVersionUtils.GetSqlVersion(versionHint) >= global::System.Data.Entity.SqlServer.SqlVersion.Sql10;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00005724 File Offset: 0x00003924
		internal static global::System.Data.SqlClient.SqlParameter CreateSqlParameter(string name, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, global::System.Data.Entity.Core.Metadata.Edm.ParameterMode mode, object value, bool preventTruncation, global::System.Data.Entity.SqlServer.SqlVersion version)
		{
			value = global::System.Data.Entity.SqlServer.SqlProviderServices.EnsureSqlParameterValue(value);
			global::System.Data.SqlClient.SqlParameter sqlParameter = new global::System.Data.SqlClient.SqlParameter(name, value);
			global::System.Data.ParameterDirection parameterDirection = global::System.Data.Entity.SqlServer.SqlProviderServices.ParameterModeToParameterDirection(mode);
			if (sqlParameter.Direction != parameterDirection)
			{
				sqlParameter.Direction = parameterDirection;
			}
			bool flag = mode > global::System.Data.Entity.Core.Metadata.Edm.ParameterMode.In;
			int? num;
			byte? b;
			byte? b2;
			string udtTypeName;
			global::System.Data.SqlDbType sqlDbType = global::System.Data.Entity.SqlServer.SqlProviderServices.GetSqlDbType(type, flag, version, out num, out b, out b2, out udtTypeName);
			if (sqlParameter.SqlDbType != sqlDbType)
			{
				sqlParameter.SqlDbType = sqlDbType;
			}
			if (sqlDbType == global::System.Data.SqlDbType.Udt)
			{
				sqlParameter.UdtTypeName = udtTypeName;
			}
			if (num != null)
			{
				if (flag || sqlParameter.Size != num.Value)
				{
					if (preventTruncation && num.Value != -1)
					{
						sqlParameter.Size = global::System.Math.Max(sqlParameter.Size, num.Value);
					}
					else
					{
						sqlParameter.Size = num.Value;
					}
				}
			}
			else
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind = ((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)type.EdmType).PrimitiveTypeKind;
				if (primitiveTypeKind == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String)
				{
					sqlParameter.Size = global::System.Data.Entity.SqlServer.SqlProviderServices.GetDefaultStringMaxLength(version, sqlDbType);
				}
				else if (primitiveTypeKind == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary)
				{
					sqlParameter.Size = global::System.Data.Entity.SqlServer.SqlProviderServices.GetDefaultBinaryMaxLength(version);
				}
			}
			if (b != null && (flag || (sqlParameter.Precision != b.Value && global::System.Data.Entity.SqlServer.SqlProviderServices._truncateDecimalsToScale)))
			{
				sqlParameter.Precision = b.Value;
			}
			if (b2 != null && (flag || (sqlParameter.Scale != b2.Value && global::System.Data.Entity.SqlServer.SqlProviderServices._truncateDecimalsToScale)))
			{
				sqlParameter.Scale = b2.Value;
			}
			bool flag2 = type.IsNullable();
			if (flag || flag2 != sqlParameter.IsNullable)
			{
				sqlParameter.IsNullable = flag2;
			}
			return sqlParameter;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x000058B3 File Offset: 0x00003AB3
		private static global::System.Data.ParameterDirection ParameterModeToParameterDirection(global::System.Data.Entity.Core.Metadata.Edm.ParameterMode mode)
		{
			switch (mode)
			{
			case global::System.Data.Entity.Core.Metadata.Edm.ParameterMode.In:
				return global::System.Data.ParameterDirection.Input;
			case global::System.Data.Entity.Core.Metadata.Edm.ParameterMode.Out:
				return global::System.Data.ParameterDirection.Output;
			case global::System.Data.Entity.Core.Metadata.Edm.ParameterMode.InOut:
				return global::System.Data.ParameterDirection.InputOutput;
			case global::System.Data.Entity.Core.Metadata.Edm.ParameterMode.ReturnValue:
				return global::System.Data.ParameterDirection.ReturnValue;
			default:
				return (global::System.Data.ParameterDirection)0;
			}
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000058D8 File Offset: 0x00003AD8
		internal static object EnsureSqlParameterValue(object value)
		{
			if (value != null && value != global::System.DBNull.Value && value.GetType().IsClass())
			{
				global::System.Data.Entity.Spatial.DbGeography dbGeography = value as global::System.Data.Entity.Spatial.DbGeography;
				if (dbGeography != null)
				{
					value = global::System.Data.Entity.SqlServer.SqlTypesAssemblyLoader.DefaultInstance.GetSqlTypesAssembly().ConvertToSqlTypesGeography(dbGeography);
				}
				else
				{
					global::System.Data.Entity.Spatial.DbGeometry dbGeometry = value as global::System.Data.Entity.Spatial.DbGeometry;
					if (dbGeometry != null)
					{
						value = global::System.Data.Entity.SqlServer.SqlTypesAssemblyLoader.DefaultInstance.GetSqlTypesAssembly().ConvertToSqlTypesGeometry(dbGeometry);
					}
					else
					{
						global::System.Data.Entity.Hierarchy.HierarchyId hierarchyId = value as global::System.Data.Entity.Hierarchy.HierarchyId;
						if (hierarchyId != null)
						{
							value = global::System.Data.Entity.SqlServer.SqlTypesAssemblyLoader.DefaultInstance.GetSqlTypesAssembly().ConvertToSqlTypesHierarchyId(hierarchyId);
						}
					}
				}
			}
			return value;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0000595C File Offset: 0x00003B5C
		private static global::System.Data.SqlDbType GetSqlDbType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, bool isOutParam, global::System.Data.Entity.SqlServer.SqlVersion version, out int? size, out byte? precision, out byte? scale, out string udtName)
		{
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind = ((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)type.EdmType).PrimitiveTypeKind;
			size = null;
			precision = null;
			scale = null;
			udtName = null;
			switch (primitiveTypeKind)
			{
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary:
				size = global::System.Data.Entity.SqlServer.SqlProviderServices.GetParameterSize(type, isOutParam);
				return global::System.Data.Entity.SqlServer.SqlProviderServices.GetBinaryDbType(type);
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean:
				return global::System.Data.SqlDbType.Bit;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Byte:
				return global::System.Data.SqlDbType.TinyInt;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTime:
				if (!global::System.Data.Entity.SqlServer.SqlVersionUtils.IsPreKatmai(version))
				{
					precision = global::System.Data.Entity.SqlServer.SqlProviderServices.GetKatmaiDateTimePrecision(type, isOutParam);
					return global::System.Data.SqlDbType.DateTime2;
				}
				return global::System.Data.SqlDbType.DateTime;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Decimal:
				precision = global::System.Data.Entity.SqlServer.SqlProviderServices.GetParameterPrecision(type, null);
				scale = global::System.Data.Entity.SqlServer.SqlProviderServices.GetScale(type);
				return global::System.Data.SqlDbType.Decimal;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Double:
				return global::System.Data.SqlDbType.Float;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Guid:
				return global::System.Data.SqlDbType.UniqueIdentifier;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Single:
				return global::System.Data.SqlDbType.Real;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.SByte:
				return global::System.Data.SqlDbType.SmallInt;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int16:
				return global::System.Data.SqlDbType.SmallInt;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32:
				return global::System.Data.SqlDbType.Int;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int64:
				return global::System.Data.SqlDbType.BigInt;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String:
				size = global::System.Data.Entity.SqlServer.SqlProviderServices.GetParameterSize(type, isOutParam);
				return global::System.Data.Entity.SqlServer.SqlProviderServices.GetStringDbType(type);
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Time:
				if (!global::System.Data.Entity.SqlServer.SqlVersionUtils.IsPreKatmai(version))
				{
					precision = global::System.Data.Entity.SqlServer.SqlProviderServices.GetKatmaiDateTimePrecision(type, isOutParam);
				}
				return global::System.Data.SqlDbType.Time;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTimeOffset:
				if (!global::System.Data.Entity.SqlServer.SqlVersionUtils.IsPreKatmai(version))
				{
					precision = global::System.Data.Entity.SqlServer.SqlProviderServices.GetKatmaiDateTimePrecision(type, isOutParam);
				}
				return global::System.Data.SqlDbType.DateTimeOffset;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geometry:
				udtName = "geometry";
				return global::System.Data.SqlDbType.Udt;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geography:
				udtName = "geography";
				return global::System.Data.SqlDbType.Udt;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.HierarchyId:
				udtName = "hierarchyid";
				return global::System.Data.SqlDbType.Udt;
			}
			return global::System.Data.SqlDbType.Variant;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00005AF4 File Offset: 0x00003CF4
		private static int? GetParameterSize(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, bool isOutParam)
		{
			global::System.Data.Entity.Core.Metadata.Edm.Facet facet;
			if (type.Facets.TryGetValue("MaxLength", false, out facet) && facet.Value != null)
			{
				if (facet.IsUnbounded)
				{
					return new int?(-1);
				}
				return (int?)facet.Value;
			}
			else
			{
				if (isOutParam)
				{
					return new int?(-1);
				}
				return null;
			}
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00005B4C File Offset: 0x00003D4C
		private static int GetNonMaxLength(global::System.Data.SqlDbType type)
		{
			int result = -1;
			if (type == global::System.Data.SqlDbType.NChar || type == global::System.Data.SqlDbType.NVarChar)
			{
				result = 4000;
			}
			else if (type == global::System.Data.SqlDbType.Char || type == global::System.Data.SqlDbType.VarChar || type == global::System.Data.SqlDbType.Binary || type == global::System.Data.SqlDbType.VarBinary)
			{
				result = 8000;
			}
			return result;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00005B88 File Offset: 0x00003D88
		private static int GetDefaultStringMaxLength(global::System.Data.Entity.SqlServer.SqlVersion version, global::System.Data.SqlDbType type)
		{
			int result;
			if (version < global::System.Data.Entity.SqlServer.SqlVersion.Sql9)
			{
				if (type == global::System.Data.SqlDbType.NChar || type == global::System.Data.SqlDbType.NVarChar)
				{
					result = 4000;
				}
				else
				{
					result = 8000;
				}
			}
			else
			{
				result = -1;
			}
			return result;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00005BB8 File Offset: 0x00003DB8
		private static int GetDefaultBinaryMaxLength(global::System.Data.Entity.SqlServer.SqlVersion version)
		{
			int result;
			if (version < global::System.Data.Entity.SqlServer.SqlVersion.Sql9)
			{
				result = 8000;
			}
			else
			{
				result = -1;
			}
			return result;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00005BD8 File Offset: 0x00003DD8
		private static byte? GetKatmaiDateTimePrecision(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, bool isOutParam)
		{
			byte? defaultIfUndefined = isOutParam ? new byte?((byte)7) : null;
			return global::System.Data.Entity.SqlServer.SqlProviderServices.GetParameterPrecision(type, defaultIfUndefined);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00005C04 File Offset: 0x00003E04
		private static byte? GetParameterPrecision(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, byte? defaultIfUndefined)
		{
			byte value;
			if (type.TryGetPrecision(out value))
			{
				return new byte?(value);
			}
			return defaultIfUndefined;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00005C24 File Offset: 0x00003E24
		private static byte? GetScale(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			byte value;
			if (type.TryGetScale(out value))
			{
				return new byte?(value);
			}
			return null;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00005C4C File Offset: 0x00003E4C
		private static global::System.Data.SqlDbType GetStringDbType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			global::System.Data.SqlDbType result;
			if (type.EdmType.Name.ToLowerInvariant() == "xml")
			{
				result = global::System.Data.SqlDbType.Xml;
			}
			else
			{
				bool flag;
				if (!type.TryGetIsUnicode(out flag))
				{
					flag = true;
				}
				if (type.IsFixedLength())
				{
					result = (flag ? global::System.Data.SqlDbType.NChar : global::System.Data.SqlDbType.Char);
				}
				else
				{
					result = (flag ? global::System.Data.SqlDbType.NVarChar : global::System.Data.SqlDbType.VarChar);
				}
			}
			return result;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00005CA4 File Offset: 0x00003EA4
		private static global::System.Data.SqlDbType GetBinaryDbType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			if (!type.IsFixedLength())
			{
				return global::System.Data.SqlDbType.VarBinary;
			}
			return global::System.Data.SqlDbType.Binary;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00005CB2 File Offset: 0x00003EB2
		protected override string DbCreateDatabaseScript(string providerManifestToken, global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection storeItemCollection)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<string>(providerManifestToken, "providerManifestToken");
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection>(storeItemCollection, "storeItemCollection");
			return global::System.Data.Entity.SqlServer.SqlProviderServices.CreateObjectsScript(global::System.Data.Entity.SqlServer.SqlVersionUtils.GetSqlVersion(providerManifestToken), storeItemCollection);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00005CD8 File Offset: 0x00003ED8
		protected override void DbCreateDatabase(global::System.Data.Common.DbConnection connection, int? commandTimeout, global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection storeItemCollection)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Common.DbConnection>(connection, "connection");
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection>(storeItemCollection, "storeItemCollection");
			global::System.Data.SqlClient.SqlConnection requiredSqlConnection = global::System.Data.Entity.SqlServer.SqlProviderUtilities.GetRequiredSqlConnection(connection);
			string databaseName;
			string dataFileName;
			string logFileName;
			global::System.Data.Entity.SqlServer.SqlProviderServices.GetOrGenerateDatabaseNameAndGetFileNames(requiredSqlConnection, out databaseName, out dataFileName, out logFileName);
			string createDatabaseScript = global::System.Data.Entity.SqlServer.SqlDdlBuilder.CreateDatabaseScript(databaseName, dataFileName, logFileName);
			global::System.Data.Entity.SqlServer.SqlVersion sqlVersion = this.CreateDatabaseFromScript(commandTimeout, requiredSqlConnection, createDatabaseScript);
			try
			{
				global::System.Data.SqlClient.SqlConnection.ClearPool(requiredSqlConnection);
				string setDatabaseOptionsScript = global::System.Data.Entity.SqlServer.SqlDdlBuilder.SetDatabaseOptionsScript(sqlVersion, databaseName);
				if (!string.IsNullOrEmpty(setDatabaseOptionsScript))
				{
					this.UsingMasterConnection(requiredSqlConnection, delegate(global::System.Data.Common.DbConnection conn)
					{
						using (global::System.Data.Common.DbCommand dbCommand = global::System.Data.Entity.SqlServer.SqlProviderServices.CreateCommand(conn, setDatabaseOptionsScript, commandTimeout))
						{
							global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Command.NonQuery(dbCommand, new global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext());
						}
					});
				}
				string createObjectsScript = global::System.Data.Entity.SqlServer.SqlProviderServices.CreateObjectsScript(sqlVersion, storeItemCollection);
				if (!string.IsNullOrWhiteSpace(createObjectsScript))
				{
					global::System.Data.Entity.SqlServer.SqlProviderServices.UsingConnection(requiredSqlConnection, delegate(global::System.Data.Common.DbConnection conn)
					{
						using (global::System.Data.Common.DbCommand dbCommand = global::System.Data.Entity.SqlServer.SqlProviderServices.CreateCommand(conn, createObjectsScript, commandTimeout))
						{
							global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Command.NonQuery(dbCommand, new global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext());
						}
					});
				}
			}
			catch (global::System.Exception ex)
			{
				try
				{
					this.DropDatabase(requiredSqlConnection, commandTimeout, databaseName);
				}
				catch (global::System.Exception ex2)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.SqlServer.Resources.Strings.SqlProvider_IncompleteCreateDatabase, new global::System.AggregateException(global::System.Data.Entity.SqlServer.Resources.Strings.SqlProvider_IncompleteCreateDatabaseAggregate, new global::System.Exception[]
					{
						ex,
						ex2
					}));
				}
				throw;
			}
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00005DF4 File Offset: 0x00003FF4
		private static void GetOrGenerateDatabaseNameAndGetFileNames(global::System.Data.SqlClient.SqlConnection sqlConnection, out string databaseName, out string dataFileName, out string logFileName)
		{
			global::System.Data.SqlClient.SqlConnectionStringBuilder sqlConnectionStringBuilder = new global::System.Data.SqlClient.SqlConnectionStringBuilder(global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.GetConnectionString(sqlConnection, new global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext()));
			string attachDBFilename = sqlConnectionStringBuilder.AttachDBFilename;
			if (string.IsNullOrEmpty(attachDBFilename))
			{
				dataFileName = null;
				logFileName = null;
			}
			else
			{
				dataFileName = global::System.Data.Entity.SqlServer.SqlProviderServices.GetMdfFileName(attachDBFilename);
				logFileName = global::System.Data.Entity.SqlServer.SqlProviderServices.GetLdfFileName(dataFileName);
			}
			if (!string.IsNullOrEmpty(sqlConnectionStringBuilder.InitialCatalog))
			{
				databaseName = sqlConnectionStringBuilder.InitialCatalog;
				return;
			}
			if (dataFileName != null)
			{
				databaseName = global::System.Data.Entity.SqlServer.SqlProviderServices.GenerateDatabaseName(dataFileName);
				return;
			}
			throw new global::System.InvalidOperationException(global::System.Data.Entity.SqlServer.Resources.Strings.SqlProvider_DdlGeneration_MissingInitialCatalog);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00005E72 File Offset: 0x00004072
		private static string GetLdfFileName(string dataFileName)
		{
			return global::System.IO.Path.Combine(new global::System.IO.FileInfo(dataFileName).Directory.FullName, global::System.IO.Path.GetFileNameWithoutExtension(dataFileName) + "_log.ldf");
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00005E9C File Offset: 0x0000409C
		private static string GenerateDatabaseName(string mdfFileName)
		{
			char[] array = global::System.IO.Path.GetFileNameWithoutExtension(mdfFileName.ToUpper(global::System.Globalization.CultureInfo.InvariantCulture)).ToCharArray();
			for (int i = 0; i < array.Length; i++)
			{
				if (!char.IsLetterOrDigit(array[i]))
				{
					array[i] = '_';
				}
			}
			string text = new string(array);
			text = ((text.Length > 30) ? text.Substring(0, 30) : text);
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}_{1}", new object[]
			{
				text,
				global::System.Guid.NewGuid().ToString("N", global::System.Globalization.CultureInfo.InvariantCulture)
			});
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00005F2D File Offset: 0x0000412D
		private static string GetMdfFileName(string attachDBFile)
		{
			return global::System.Data.Entity.Core.Common.DbProviderServices.ExpandDataDirectory(attachDBFile);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00005F38 File Offset: 0x00004138
		internal global::System.Data.Entity.SqlServer.SqlVersion CreateDatabaseFromScript(int? commandTimeout, global::System.Data.Common.DbConnection sqlConnection, string createDatabaseScript)
		{
			global::System.Data.Entity.SqlServer.SqlVersion sqlVersion = (global::System.Data.Entity.SqlServer.SqlVersion)0;
			this.UsingMasterConnection(sqlConnection, delegate(global::System.Data.Common.DbConnection conn)
			{
				using (global::System.Data.Common.DbCommand dbCommand = global::System.Data.Entity.SqlServer.SqlProviderServices.CreateCommand(conn, createDatabaseScript, commandTimeout))
				{
					global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Command.NonQuery(dbCommand, new global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext());
				}
				sqlVersion = global::System.Data.Entity.SqlServer.SqlVersionUtils.GetSqlVersion(conn);
			});
			return sqlVersion;
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00005F7C File Offset: 0x0000417C
		protected override bool DbDatabaseExists(global::System.Data.Common.DbConnection connection, int? commandTimeout, global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection storeItemCollection)
		{
			return this.DbDatabaseExists(connection, commandTimeout, new global::System.Lazy<global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection>(() => storeItemCollection));
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00005FB0 File Offset: 0x000041B0
		protected override bool DbDatabaseExists(global::System.Data.Common.DbConnection connection, int? commandTimeout, global::System.Lazy<global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection> storeItemCollection)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Common.DbConnection>(connection, "connection");
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Lazy<global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection>>(storeItemCollection, "storeItemCollection");
			if (connection.State == global::System.Data.ConnectionState.Open)
			{
				return true;
			}
			global::System.Data.SqlClient.SqlConnection requiredSqlConnection = global::System.Data.Entity.SqlServer.SqlProviderUtilities.GetRequiredSqlConnection(connection);
			global::System.Data.SqlClient.SqlConnectionStringBuilder sqlConnectionStringBuilder = new global::System.Data.SqlClient.SqlConnectionStringBuilder(global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.GetConnectionString(requiredSqlConnection, new global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext()));
			if (string.IsNullOrEmpty(sqlConnectionStringBuilder.InitialCatalog) && string.IsNullOrEmpty(sqlConnectionStringBuilder.AttachDBFilename))
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.SqlServer.Resources.Strings.SqlProvider_DdlGeneration_MissingInitialCatalog);
			}
			if (!string.IsNullOrEmpty(sqlConnectionStringBuilder.InitialCatalog) && this.CheckDatabaseExists(requiredSqlConnection, commandTimeout, sqlConnectionStringBuilder.InitialCatalog))
			{
				return true;
			}
			if (!string.IsNullOrEmpty(sqlConnectionStringBuilder.AttachDBFilename))
			{
				try
				{
					global::System.Data.Entity.SqlServer.SqlProviderServices.UsingConnection(requiredSqlConnection, delegate(global::System.Data.Common.DbConnection con)
					{
					});
					return true;
				}
				catch (global::System.Data.SqlClient.SqlException innerException)
				{
					if (!string.IsNullOrEmpty(sqlConnectionStringBuilder.InitialCatalog))
					{
						return this.CheckDatabaseExists(requiredSqlConnection, commandTimeout, sqlConnectionStringBuilder.InitialCatalog);
					}
					string fileName = global::System.Data.Entity.SqlServer.SqlProviderServices.GetMdfFileName(sqlConnectionStringBuilder.AttachDBFilename);
					bool databaseDoesNotExistInSysTables = false;
					this.UsingMasterConnection(requiredSqlConnection, delegate(global::System.Data.Common.DbConnection conn)
					{
						global::System.Data.Entity.SqlServer.SqlVersion sqlVersion = global::System.Data.Entity.SqlServer.SqlVersionUtils.GetSqlVersion(conn);
						string commandText = global::System.Data.Entity.SqlServer.SqlDdlBuilder.CreateCountDatabasesBasedOnFileNameScript(fileName, sqlVersion == global::System.Data.Entity.SqlServer.SqlVersion.Sql8);
						using (global::System.Data.Common.DbCommand dbCommand = global::System.Data.Entity.SqlServer.SqlProviderServices.CreateCommand(conn, commandText, commandTimeout))
						{
							int num = (int)global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Command.Scalar(dbCommand, new global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext());
							databaseDoesNotExistInSysTables = (num == 0);
						}
					});
					if (databaseDoesNotExistInSysTables)
					{
						return false;
					}
					throw new global::System.InvalidOperationException(global::System.Data.Entity.SqlServer.Resources.Strings.SqlProvider_DdlGeneration_CannotTellIfDatabaseExists, innerException);
				}
				return false;
			}
			return false;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00006110 File Offset: 0x00004310
		private bool CheckDatabaseExists(global::System.Data.SqlClient.SqlConnection sqlConnection, int? commandTimeout, string databaseName)
		{
			bool databaseExists = false;
			this.UsingMasterConnection(sqlConnection, delegate(global::System.Data.Common.DbConnection conn)
			{
				string commandText = global::System.Data.Entity.SqlServer.SqlDdlBuilder.CreateDatabaseExistsScript(databaseName);
				using (global::System.Data.Common.DbCommand dbCommand = global::System.Data.Entity.SqlServer.SqlProviderServices.CreateCommand(conn, commandText, commandTimeout))
				{
					databaseExists = ((int)global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Command.Scalar(dbCommand, new global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext()) >= 1);
				}
			});
			return databaseExists;
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00006154 File Offset: 0x00004354
		protected override void DbDeleteDatabase(global::System.Data.Common.DbConnection connection, int? commandTimeout, global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection storeItemCollection)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Common.DbConnection>(connection, "connection");
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection>(storeItemCollection, "storeItemCollection");
			global::System.Data.SqlClient.SqlConnection requiredSqlConnection = global::System.Data.Entity.SqlServer.SqlProviderUtilities.GetRequiredSqlConnection(connection);
			global::System.Data.SqlClient.SqlConnectionStringBuilder sqlConnectionStringBuilder = new global::System.Data.SqlClient.SqlConnectionStringBuilder(global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.GetConnectionString(requiredSqlConnection, new global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext()));
			string initialCatalog = sqlConnectionStringBuilder.InitialCatalog;
			string attachDBFilename = sqlConnectionStringBuilder.AttachDBFilename;
			if (!string.IsNullOrEmpty(initialCatalog))
			{
				this.DropDatabase(requiredSqlConnection, commandTimeout, initialCatalog);
				return;
			}
			if (!string.IsNullOrEmpty(attachDBFilename))
			{
				string fullFileName = global::System.Data.Entity.SqlServer.SqlProviderServices.GetMdfFileName(attachDBFilename);
				global::System.Collections.Generic.List<string> databaseNames = new global::System.Collections.Generic.List<string>();
				this.UsingMasterConnection(requiredSqlConnection, delegate(global::System.Data.Common.DbConnection conn)
				{
					global::System.Data.Entity.SqlServer.SqlVersion sqlVersion = global::System.Data.Entity.SqlServer.SqlVersionUtils.GetSqlVersion(conn);
					string commandText = global::System.Data.Entity.SqlServer.SqlDdlBuilder.CreateGetDatabaseNamesBasedOnFileNameScript(fullFileName, sqlVersion == global::System.Data.Entity.SqlServer.SqlVersion.Sql8);
					global::System.Data.Common.DbCommand command = global::System.Data.Entity.SqlServer.SqlProviderServices.CreateCommand(conn, commandText, commandTimeout);
					using (global::System.Data.Common.DbDataReader dbDataReader = global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Command.Reader(command, new global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext()))
					{
						while (dbDataReader.Read())
						{
							databaseNames.Add(dbDataReader.GetString(0));
						}
					}
				});
				if (databaseNames.Count > 0)
				{
					using (global::System.Collections.Generic.List<string>.Enumerator enumerator = databaseNames.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							string databaseName = enumerator.Current;
							this.DropDatabase(requiredSqlConnection, commandTimeout, databaseName);
						}
						return;
					}
				}
				throw new global::System.InvalidOperationException(global::System.Data.Entity.SqlServer.Resources.Strings.SqlProvider_DdlGeneration_CannotDeleteDatabaseNoInitialCatalog);
			}
			throw new global::System.InvalidOperationException(global::System.Data.Entity.SqlServer.Resources.Strings.SqlProvider_DdlGeneration_MissingInitialCatalog);
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00006274 File Offset: 0x00004474
		private void DropDatabase(global::System.Data.SqlClient.SqlConnection sqlConnection, int? commandTimeout, string databaseName)
		{
			global::System.Data.SqlClient.SqlConnection.ClearAllPools();
			string dropDatabaseScript = global::System.Data.Entity.SqlServer.SqlDdlBuilder.DropDatabaseScript(databaseName);
			try
			{
				this.UsingMasterConnection(sqlConnection, delegate(global::System.Data.Common.DbConnection conn)
				{
					using (global::System.Data.Common.DbCommand dbCommand = global::System.Data.Entity.SqlServer.SqlProviderServices.CreateCommand(conn, dropDatabaseScript, commandTimeout))
					{
						global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Command.NonQuery(dbCommand, new global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext());
					}
				});
			}
			catch (global::System.Data.SqlClient.SqlException ex)
			{
				using (global::System.Collections.IEnumerator enumerator = ex.Errors.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (((global::System.Data.SqlClient.SqlError)enumerator.Current).Number == 5120)
						{
							return;
						}
					}
				}
				throw;
			}
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00006314 File Offset: 0x00004514
		private static string CreateObjectsScript(global::System.Data.Entity.SqlServer.SqlVersion version, global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection storeItemCollection)
		{
			return global::System.Data.Entity.SqlServer.SqlDdlBuilder.CreateObjectsScript(storeItemCollection, version != global::System.Data.Entity.SqlServer.SqlVersion.Sql8);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00006324 File Offset: 0x00004524
		private static global::System.Data.Common.DbCommand CreateCommand(global::System.Data.Common.DbConnection sqlConnection, string commandText, int? commandTimeout)
		{
			if (string.IsNullOrEmpty(commandText))
			{
				commandText = global::System.Environment.NewLine;
			}
			global::System.Data.Common.DbCommand dbCommand = sqlConnection.CreateCommand();
			dbCommand.CommandText = commandText;
			if (commandTimeout != null)
			{
				dbCommand.CommandTimeout = commandTimeout.Value;
			}
			return dbCommand;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00006368 File Offset: 0x00004568
		private static void UsingConnection(global::System.Data.Common.DbConnection sqlConnection, global::System.Action<global::System.Data.Common.DbConnection> act)
		{
			global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext interceptionContext = new global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext();
			string holdConnectionString = global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.GetConnectionString(sqlConnection, interceptionContext);
			global::System.Data.Entity.Core.Common.DbProviderServices.GetExecutionStrategy(sqlConnection, "System.Data.SqlClient").Execute(delegate()
			{
				bool flag = global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.GetState(sqlConnection, interceptionContext) == global::System.Data.ConnectionState.Closed;
				if (flag)
				{
					if (global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.GetState(sqlConnection, new global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext()) == global::System.Data.ConnectionState.Closed && !global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.GetConnectionString(sqlConnection, interceptionContext).Equals(holdConnectionString, global::System.StringComparison.Ordinal))
					{
						global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.SetConnectionString(sqlConnection, new global::System.Data.Entity.Infrastructure.Interception.DbConnectionPropertyInterceptionContext<string>().WithValue(holdConnectionString));
					}
					global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.Open(sqlConnection, interceptionContext);
				}
				try
				{
					act(sqlConnection);
				}
				finally
				{
					if (flag && global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.GetState(sqlConnection, interceptionContext) == global::System.Data.ConnectionState.Open)
					{
						global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.Close(sqlConnection, interceptionContext);
						if (!global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.GetConnectionString(sqlConnection, interceptionContext).Equals(holdConnectionString, global::System.StringComparison.Ordinal))
						{
							global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.SetConnectionString(sqlConnection, new global::System.Data.Entity.Infrastructure.Interception.DbConnectionPropertyInterceptionContext<string>().WithValue(holdConnectionString));
						}
					}
				}
			});
		}

		// Token: 0x06000137 RID: 311 RVA: 0x000063D8 File Offset: 0x000045D8
		private void UsingMasterConnection(global::System.Data.Common.DbConnection sqlConnection, global::System.Action<global::System.Data.Common.DbConnection> act)
		{
			global::System.Data.SqlClient.SqlConnectionStringBuilder sqlConnectionStringBuilder = new global::System.Data.SqlClient.SqlConnectionStringBuilder(global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.GetConnectionString(sqlConnection, new global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext()))
			{
				InitialCatalog = "master",
				AttachDBFilename = string.Empty
			};
			try
			{
				using (global::System.Data.Common.DbConnection dbConnection = this.CloneDbConnection(sqlConnection))
				{
					global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.SetConnectionString(dbConnection, new global::System.Data.Entity.Infrastructure.Interception.DbConnectionPropertyInterceptionContext<string>().WithValue(sqlConnectionStringBuilder.ConnectionString));
					global::System.Data.Entity.SqlServer.SqlProviderServices.UsingConnection(dbConnection, act);
				}
			}
			catch (global::System.Data.SqlClient.SqlException innerException)
			{
				if (!sqlConnectionStringBuilder.IntegratedSecurity && (string.IsNullOrEmpty(sqlConnectionStringBuilder.UserID) || string.IsNullOrEmpty(sqlConnectionStringBuilder.Password)))
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.SqlServer.Resources.Strings.SqlProvider_CredentialsMissingForMasterConnection, innerException);
				}
				throw;
			}
		}

		// Token: 0x06000138 RID: 312 RVA: 0x000064A0 File Offset: 0x000046A0
		public override global::System.Data.Common.DbConnection CloneDbConnection(global::System.Data.Common.DbConnection connection, global::System.Data.Common.DbProviderFactory factory)
		{
			global::System.ICloneable cloneable = connection as global::System.ICloneable;
			if (cloneable != null)
			{
				return (global::System.Data.Common.DbConnection)cloneable.Clone();
			}
			return base.CloneDbConnection(connection, factory);
		}

		// Token: 0x04000017 RID: 23
		public const string ProviderInvariantName = "System.Data.SqlClient";

		// Token: 0x04000018 RID: 24
		private global::System.Collections.Concurrent.ConcurrentDictionary<string, global::System.Data.Entity.SqlServer.SqlProviderManifest> _providerManifests = new global::System.Collections.Concurrent.ConcurrentDictionary<string, global::System.Data.Entity.SqlServer.SqlProviderManifest>();

		// Token: 0x04000019 RID: 25
		private static readonly global::System.Data.Entity.SqlServer.SqlProviderServices _providerInstance = new global::System.Data.Entity.SqlServer.SqlProviderServices();

		// Token: 0x0400001A RID: 26
		private static bool _truncateDecimalsToScale = true;

		// Token: 0x0400001B RID: 27
		private static bool _useScopeIdentity = true;

		// Token: 0x0400001C RID: 28
		private static bool _useRowNumberOrderingInOffsetQueries = true;
	}
}
