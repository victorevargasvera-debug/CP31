using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity.Resources;
using System.Data.Entity.Spatial;
using System.Data.Entity.Utilities;
using System.IO;
using System.Transactions;
using System.Xml;

namespace System.Data.Entity.Core.Common
{
	// Token: 0x020005EC RID: 1516
	public abstract class DbProviderServices : global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver
	{
		// Token: 0x06004A20 RID: 18976 RVA: 0x00105EF7 File Offset: 0x001040F7
		protected DbProviderServices() : this(() => global::System.Data.Entity.DbConfiguration.DependencyResolver)
		{
		}

		// Token: 0x06004A21 RID: 18977 RVA: 0x00105F1E File Offset: 0x0010411E
		internal DbProviderServices(global::System.Func<global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver> resolver) : this(resolver, new global::System.Lazy<global::System.Data.Entity.Infrastructure.Interception.DbCommandTreeDispatcher>(() => global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.CommandTree))
		{
		}

		// Token: 0x06004A22 RID: 18978 RVA: 0x00105F4B File Offset: 0x0010414B
		internal DbProviderServices(global::System.Func<global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver> resolver, global::System.Lazy<global::System.Data.Entity.Infrastructure.Interception.DbCommandTreeDispatcher> treeDispatcher)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver>>(resolver, "resolver");
			this._resolver = new global::System.Lazy<global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver>(resolver);
			this._treeDispatcher = treeDispatcher;
		}

		// Token: 0x06004A23 RID: 18979 RVA: 0x00105F7D File Offset: 0x0010417D
		public virtual void RegisterInfoMessageHandler(global::System.Data.Common.DbConnection connection, global::System.Action<string> handler)
		{
		}

		// Token: 0x06004A24 RID: 18980 RVA: 0x00105F7F File Offset: 0x0010417F
		public global::System.Data.Entity.Core.Common.DbCommandDefinition CreateCommandDefinition(global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree commandTree)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree>(commandTree, "commandTree");
			return this.CreateCommandDefinition(commandTree, new global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext());
		}

		// Token: 0x06004A25 RID: 18981 RVA: 0x00105F9C File Offset: 0x0010419C
		internal global::System.Data.Entity.Core.Common.DbCommandDefinition CreateCommandDefinition(global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree commandTree, global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext interceptionContext)
		{
			this.ValidateDataSpace(commandTree);
			global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection storeItemCollection = (global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection)commandTree.MetadataWorkspace.GetItemCollection(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace);
			commandTree = this._treeDispatcher.Value.Created(commandTree, interceptionContext);
			return this.CreateDbCommandDefinition(storeItemCollection.ProviderManifest, commandTree, interceptionContext);
		}

		// Token: 0x06004A26 RID: 18982 RVA: 0x00105FE4 File Offset: 0x001041E4
		internal virtual global::System.Data.Entity.Core.Common.DbCommandDefinition CreateDbCommandDefinition(global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest, global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree commandTree, global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext interceptionContext)
		{
			return this.CreateDbCommandDefinition(providerManifest, commandTree);
		}

		// Token: 0x06004A27 RID: 18983 RVA: 0x00105FF0 File Offset: 0x001041F0
		public global::System.Data.Entity.Core.Common.DbCommandDefinition CreateCommandDefinition(global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest, global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree commandTree)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.DbProviderManifest>(providerManifest, "providerManifest");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree>(commandTree, "commandTree");
			global::System.Data.Entity.Core.Common.DbCommandDefinition result;
			try
			{
				result = this.CreateDbCommandDefinition(providerManifest, commandTree);
			}
			catch (global::System.Data.Entity.Core.ProviderIncompatibleException)
			{
				throw;
			}
			catch (global::System.Exception ex)
			{
				if (ex.IsCatchableExceptionType())
				{
					throw new global::System.Data.Entity.Core.ProviderIncompatibleException(global::System.Data.Entity.Resources.Strings.ProviderDidNotCreateACommandDefinition, ex);
				}
				throw;
			}
			return result;
		}

		// Token: 0x06004A28 RID: 18984
		protected abstract global::System.Data.Entity.Core.Common.DbCommandDefinition CreateDbCommandDefinition(global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest, global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree commandTree);

		// Token: 0x06004A29 RID: 18985 RVA: 0x00106058 File Offset: 0x00104258
		internal virtual void ValidateDataSpace(global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree commandTree)
		{
			if (commandTree.DataSpace != global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace)
			{
				throw new global::System.Data.Entity.Core.ProviderIncompatibleException(global::System.Data.Entity.Resources.Strings.ProviderRequiresStoreCommandTree);
			}
		}

		// Token: 0x06004A2A RID: 18986 RVA: 0x0010606E File Offset: 0x0010426E
		internal virtual global::System.Data.Common.DbCommand CreateCommand(global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree commandTree, global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext interceptionContext)
		{
			return this.CreateCommandDefinition(commandTree, interceptionContext).CreateCommand();
		}

		// Token: 0x06004A2B RID: 18987 RVA: 0x0010607D File Offset: 0x0010427D
		public virtual global::System.Data.Entity.Core.Common.DbCommandDefinition CreateCommandDefinition(global::System.Data.Common.DbCommand prototype)
		{
			return new global::System.Data.Entity.Core.Common.DbCommandDefinition(prototype, new global::System.Func<global::System.Data.Common.DbCommand, global::System.Data.Common.DbCommand>(this.CloneDbCommand));
		}

		// Token: 0x06004A2C RID: 18988 RVA: 0x00106094 File Offset: 0x00104294
		protected virtual global::System.Data.Common.DbCommand CloneDbCommand(global::System.Data.Common.DbCommand fromDbCommand)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbCommand>(fromDbCommand, "fromDbCommand");
			global::System.ICloneable cloneable = fromDbCommand as global::System.ICloneable;
			if (cloneable == null)
			{
				throw new global::System.Data.Entity.Core.ProviderIncompatibleException(global::System.Data.Entity.Resources.Strings.EntityClient_CannotCloneStoreProvider);
			}
			return (global::System.Data.Common.DbCommand)cloneable.Clone();
		}

		// Token: 0x06004A2D RID: 18989 RVA: 0x001060CD File Offset: 0x001042CD
		public virtual global::System.Data.Common.DbConnection CloneDbConnection(global::System.Data.Common.DbConnection connection)
		{
			return this.CloneDbConnection(connection, global::System.Data.Entity.Core.Common.DbProviderServices.GetProviderFactory(connection));
		}

		// Token: 0x06004A2E RID: 18990 RVA: 0x001060DC File Offset: 0x001042DC
		public virtual global::System.Data.Common.DbConnection CloneDbConnection(global::System.Data.Common.DbConnection connection, global::System.Data.Common.DbProviderFactory factory)
		{
			return factory.CreateConnection();
		}

		// Token: 0x06004A2F RID: 18991 RVA: 0x001060E4 File Offset: 0x001042E4
		public string GetProviderManifestToken(global::System.Data.Common.DbConnection connection)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbConnection>(connection, "connection");
			string result;
			try
			{
				string dbProviderManifestToken;
				using (new global::System.Transactions.TransactionScope(global::System.Transactions.TransactionScopeOption.Suppress))
				{
					dbProviderManifestToken = this.GetDbProviderManifestToken(connection);
				}
				if (dbProviderManifestToken == null)
				{
					throw new global::System.Data.Entity.Core.ProviderIncompatibleException(global::System.Data.Entity.Resources.Strings.ProviderDidNotReturnAProviderManifestToken);
				}
				result = dbProviderManifestToken;
			}
			catch (global::System.Data.Entity.Core.ProviderIncompatibleException)
			{
				throw;
			}
			catch (global::System.Exception ex)
			{
				if (ex.IsCatchableExceptionType())
				{
					throw new global::System.Data.Entity.Core.ProviderIncompatibleException(global::System.Data.Entity.Resources.Strings.ProviderDidNotReturnAProviderManifestToken, ex);
				}
				throw;
			}
			return result;
		}

		// Token: 0x06004A30 RID: 18992
		protected abstract string GetDbProviderManifestToken(global::System.Data.Common.DbConnection connection);

		// Token: 0x06004A31 RID: 18993 RVA: 0x00106170 File Offset: 0x00104370
		public global::System.Data.Entity.Core.Common.DbProviderManifest GetProviderManifest(string manifestToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(manifestToken, "manifestToken");
			global::System.Data.Entity.Core.Common.DbProviderManifest result;
			try
			{
				global::System.Data.Entity.Core.Common.DbProviderManifest dbProviderManifest = this.GetDbProviderManifest(manifestToken);
				if (dbProviderManifest == null)
				{
					throw new global::System.Data.Entity.Core.ProviderIncompatibleException(global::System.Data.Entity.Resources.Strings.ProviderDidNotReturnAProviderManifest);
				}
				result = dbProviderManifest;
			}
			catch (global::System.Data.Entity.Core.ProviderIncompatibleException)
			{
				throw;
			}
			catch (global::System.Exception ex)
			{
				if (ex.IsCatchableExceptionType())
				{
					throw new global::System.Data.Entity.Core.ProviderIncompatibleException(global::System.Data.Entity.Resources.Strings.ProviderDidNotReturnAProviderManifest, ex);
				}
				throw;
			}
			return result;
		}

		// Token: 0x06004A32 RID: 18994
		protected abstract global::System.Data.Entity.Core.Common.DbProviderManifest GetDbProviderManifest(string manifestToken);

		// Token: 0x06004A33 RID: 18995 RVA: 0x001061D8 File Offset: 0x001043D8
		public static global::System.Data.Entity.Infrastructure.IDbExecutionStrategy GetExecutionStrategy(global::System.Data.Common.DbConnection connection)
		{
			return global::System.Data.Entity.Core.Common.DbProviderServices.GetExecutionStrategy(connection, global::System.Data.Entity.Core.Common.DbProviderServices.GetProviderFactory(connection), null);
		}

		// Token: 0x06004A34 RID: 18996 RVA: 0x001061E8 File Offset: 0x001043E8
		internal static global::System.Data.Entity.Infrastructure.IDbExecutionStrategy GetExecutionStrategy(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace metadataWorkspace)
		{
			global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection storeItemCollection = (global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection)metadataWorkspace.GetItemCollection(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace);
			return global::System.Data.Entity.Core.Common.DbProviderServices.GetExecutionStrategy(connection, storeItemCollection.ProviderFactory, null);
		}

		// Token: 0x06004A35 RID: 18997 RVA: 0x0010620F File Offset: 0x0010440F
		protected static global::System.Data.Entity.Infrastructure.IDbExecutionStrategy GetExecutionStrategy(global::System.Data.Common.DbConnection connection, string providerInvariantName)
		{
			return global::System.Data.Entity.Core.Common.DbProviderServices.GetExecutionStrategy(connection, global::System.Data.Entity.Core.Common.DbProviderServices.GetProviderFactory(connection), providerInvariantName);
		}

		// Token: 0x06004A36 RID: 18998 RVA: 0x00106220 File Offset: 0x00104420
		private static global::System.Data.Entity.Infrastructure.IDbExecutionStrategy GetExecutionStrategy(global::System.Data.Common.DbConnection connection, global::System.Data.Common.DbProviderFactory providerFactory, string providerInvariantName = null)
		{
			global::System.Data.Entity.Core.EntityClient.EntityConnection entityConnection = connection as global::System.Data.Entity.Core.EntityClient.EntityConnection;
			if (entityConnection != null)
			{
				connection = entityConnection.StoreConnection;
			}
			string dataSource = global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.GetDataSource(connection, new global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext());
			global::System.Data.Entity.Infrastructure.ExecutionStrategyKey key = new global::System.Data.Entity.Infrastructure.ExecutionStrategyKey(providerFactory.GetType().FullName, dataSource);
			return global::System.Data.Entity.Core.Common.DbProviderServices._executionStrategyFactories.GetOrAdd(key, (global::System.Data.Entity.Infrastructure.ExecutionStrategyKey k) => global::System.Data.Entity.DbConfiguration.DependencyResolver.GetService(new global::System.Data.Entity.Infrastructure.ExecutionStrategyKey(providerInvariantName ?? global::System.Data.Entity.DbConfiguration.DependencyResolver.GetService(providerFactory).Name, dataSource)))();
		}

		// Token: 0x06004A37 RID: 18999 RVA: 0x001062A8 File Offset: 0x001044A8
		public global::System.Data.Entity.Spatial.DbSpatialDataReader GetSpatialDataReader(global::System.Data.Common.DbDataReader fromReader, string manifestToken)
		{
			global::System.Data.Entity.Spatial.DbSpatialDataReader dbSpatialDataReader;
			try
			{
				dbSpatialDataReader = this.GetDbSpatialDataReader(fromReader, manifestToken);
			}
			catch (global::System.Data.Entity.Core.ProviderIncompatibleException)
			{
				throw;
			}
			catch (global::System.Exception ex)
			{
				if (ex.IsCatchableExceptionType())
				{
					throw new global::System.Data.Entity.Core.ProviderIncompatibleException(global::System.Data.Entity.Resources.Strings.ProviderDidNotReturnSpatialServices, ex);
				}
				throw;
			}
			return dbSpatialDataReader;
		}

		// Token: 0x06004A38 RID: 19000 RVA: 0x001062F8 File Offset: 0x001044F8
		[global::System.Obsolete("Use GetSpatialServices(DbProviderInfo) or DbConfiguration to ensure the configured spatial services are used. See http://go.microsoft.com/fwlink/?LinkId=260882 for more information.")]
		public global::System.Data.Entity.Spatial.DbSpatialServices GetSpatialServices(string manifestToken)
		{
			global::System.Data.Entity.Spatial.DbSpatialServices result;
			try
			{
				result = this.DbGetSpatialServices(manifestToken);
			}
			catch (global::System.Data.Entity.Core.ProviderIncompatibleException)
			{
				throw;
			}
			catch (global::System.Exception innerException)
			{
				throw new global::System.Data.Entity.Core.ProviderIncompatibleException(global::System.Data.Entity.Resources.Strings.ProviderDidNotReturnSpatialServices, innerException);
			}
			return result;
		}

		// Token: 0x06004A39 RID: 19001 RVA: 0x0010633C File Offset: 0x0010453C
		internal static global::System.Data.Entity.Spatial.DbSpatialServices GetSpatialServices(global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver resolver, global::System.Data.Entity.Core.EntityClient.EntityConnection connection)
		{
			global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection storeItemCollection = (global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection)connection.GetMetadataWorkspace().GetItemCollection(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace);
			global::System.Data.Entity.Infrastructure.DbProviderInfo key = new global::System.Data.Entity.Infrastructure.DbProviderInfo(storeItemCollection.ProviderInvariantName, storeItemCollection.ProviderManifestToken);
			return global::System.Data.Entity.Core.Common.DbProviderServices.GetSpatialServices(resolver, key, () => global::System.Data.Entity.Core.Common.DbProviderServices.GetProviderServices(connection.StoreConnection));
		}

		// Token: 0x06004A3A RID: 19002 RVA: 0x00106392 File Offset: 0x00104592
		public global::System.Data.Entity.Spatial.DbSpatialServices GetSpatialServices(global::System.Data.Entity.Infrastructure.DbProviderInfo key)
		{
			return global::System.Data.Entity.Core.Common.DbProviderServices.GetSpatialServices(this._resolver.Value, key, () => this);
		}

		// Token: 0x06004A3B RID: 19003 RVA: 0x001063B4 File Offset: 0x001045B4
		private static global::System.Data.Entity.Spatial.DbSpatialServices GetSpatialServices(global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver resolver, global::System.Data.Entity.Infrastructure.DbProviderInfo key, global::System.Func<global::System.Data.Entity.Core.Common.DbProviderServices> providerServices)
		{
			global::System.Data.Entity.Spatial.DbSpatialServices orAdd = global::System.Data.Entity.Core.Common.DbProviderServices._spatialServices.GetOrAdd(key, delegate(global::System.Data.Entity.Infrastructure.DbProviderInfo k)
			{
				global::System.Data.Entity.Spatial.DbSpatialServices result;
				if ((result = resolver.GetService(k)) == null)
				{
					result = (providerServices().GetSpatialServices(k.ProviderManifestToken) ?? resolver.GetService<global::System.Data.Entity.Spatial.DbSpatialServices>());
				}
				return result;
			});
			if (orAdd == null)
			{
				throw new global::System.Data.Entity.Core.ProviderIncompatibleException(global::System.Data.Entity.Resources.Strings.ProviderDidNotReturnSpatialServices);
			}
			return orAdd;
		}

		// Token: 0x06004A3C RID: 19004 RVA: 0x001063FA File Offset: 0x001045FA
		protected virtual global::System.Data.Entity.Spatial.DbSpatialDataReader GetDbSpatialDataReader(global::System.Data.Common.DbDataReader fromReader, string manifestToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbDataReader>(fromReader, "fromReader");
			return null;
		}

		// Token: 0x06004A3D RID: 19005 RVA: 0x00106409 File Offset: 0x00104609
		[global::System.Obsolete("Return DbSpatialServices from the GetService method. See http://go.microsoft.com/fwlink/?LinkId=260882 for more information.")]
		protected virtual global::System.Data.Entity.Spatial.DbSpatialServices DbGetSpatialServices(string manifestToken)
		{
			return null;
		}

		// Token: 0x06004A3E RID: 19006 RVA: 0x0010640C File Offset: 0x0010460C
		public void SetParameterValue(global::System.Data.Common.DbParameter parameter, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage parameterType, object value)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbParameter>(parameter, "parameter");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(parameterType, "parameterType");
			this.SetDbParameterValue(parameter, parameterType, value);
		}

		// Token: 0x06004A3F RID: 19007 RVA: 0x0010642F File Offset: 0x0010462F
		protected virtual void SetDbParameterValue(global::System.Data.Common.DbParameter parameter, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage parameterType, object value)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbParameter>(parameter, "parameter");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(parameterType, "parameterType");
			parameter.Value = value;
		}

		// Token: 0x06004A40 RID: 19008 RVA: 0x00106450 File Offset: 0x00104650
		public static global::System.Data.Entity.Core.Common.DbProviderServices GetProviderServices(global::System.Data.Common.DbConnection connection)
		{
			return global::System.Data.Entity.Core.Common.DbProviderServices.GetProviderFactory(connection).GetProviderServices();
		}

		// Token: 0x06004A41 RID: 19009 RVA: 0x0010645D File Offset: 0x0010465D
		public static global::System.Data.Common.DbProviderFactory GetProviderFactory(global::System.Data.Common.DbConnection connection)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbConnection>(connection, "connection");
			global::System.Data.Common.DbProviderFactory providerFactory = connection.GetProviderFactory();
			if (providerFactory == null)
			{
				throw new global::System.Data.Entity.Core.ProviderIncompatibleException(global::System.Data.Entity.Resources.Strings.EntityClient_ReturnedNullOnProviderMethod("get_ProviderFactory", connection.GetType().ToString()));
			}
			return providerFactory;
		}

		// Token: 0x06004A42 RID: 19010 RVA: 0x0010648F File Offset: 0x0010468F
		public static global::System.Xml.XmlReader GetConceptualSchemaDefinition(string csdlName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(csdlName, "csdlName");
			return global::System.Data.Entity.Core.Common.DbProviderServices.GetXmlResource("System.Data.Resources.DbProviderServices." + csdlName + ".csdl");
		}

		// Token: 0x06004A43 RID: 19011 RVA: 0x001064B2 File Offset: 0x001046B2
		internal static global::System.Xml.XmlReader GetXmlResource(string resourceName)
		{
			global::System.IO.Stream manifestResourceStream = typeof(global::System.Data.Entity.Core.Common.DbProviderServices).Assembly().GetManifestResourceStream(resourceName);
			if (manifestResourceStream == null)
			{
				throw global::System.Data.Entity.Resources.Error.InvalidResourceName(resourceName);
			}
			return global::System.Xml.XmlReader.Create(manifestResourceStream);
		}

		// Token: 0x06004A44 RID: 19012 RVA: 0x001064D8 File Offset: 0x001046D8
		public string CreateDatabaseScript(string providerManifestToken, global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection storeItemCollection)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(providerManifestToken, "providerManifestToken");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection>(storeItemCollection, "storeItemCollection");
			return this.DbCreateDatabaseScript(providerManifestToken, storeItemCollection);
		}

		// Token: 0x06004A45 RID: 19013 RVA: 0x001064FA File Offset: 0x001046FA
		protected virtual string DbCreateDatabaseScript(string providerManifestToken, global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection storeItemCollection)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(providerManifestToken, "providerManifestToken");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection>(storeItemCollection, "storeItemCollection");
			throw new global::System.Data.Entity.Core.ProviderIncompatibleException(global::System.Data.Entity.Resources.Strings.ProviderDoesNotSupportCreateDatabaseScript);
		}

		// Token: 0x06004A46 RID: 19014 RVA: 0x0010651E File Offset: 0x0010471E
		public void CreateDatabase(global::System.Data.Common.DbConnection connection, int? commandTimeout, global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection storeItemCollection)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbConnection>(connection, "connection");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection>(storeItemCollection, "storeItemCollection");
			this.DbCreateDatabase(connection, commandTimeout, storeItemCollection);
		}

		// Token: 0x06004A47 RID: 19015 RVA: 0x00106541 File Offset: 0x00104741
		protected virtual void DbCreateDatabase(global::System.Data.Common.DbConnection connection, int? commandTimeout, global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection storeItemCollection)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbConnection>(connection, "connection");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection>(storeItemCollection, "storeItemCollection");
			throw new global::System.Data.Entity.Core.ProviderIncompatibleException(global::System.Data.Entity.Resources.Strings.ProviderDoesNotSupportCreateDatabase);
		}

		// Token: 0x06004A48 RID: 19016 RVA: 0x00106568 File Offset: 0x00104768
		public bool DatabaseExists(global::System.Data.Common.DbConnection connection, int? commandTimeout, global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection storeItemCollection)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbConnection>(connection, "connection");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection>(storeItemCollection, "storeItemCollection");
			bool result;
			using (new global::System.Transactions.TransactionScope(global::System.Transactions.TransactionScopeOption.Suppress))
			{
				result = this.DbDatabaseExists(connection, commandTimeout, storeItemCollection);
			}
			return result;
		}

		// Token: 0x06004A49 RID: 19017 RVA: 0x001065BC File Offset: 0x001047BC
		public bool DatabaseExists(global::System.Data.Common.DbConnection connection, int? commandTimeout, global::System.Lazy<global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection> storeItemCollection)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbConnection>(connection, "connection");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Lazy<global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection>>(storeItemCollection, "storeItemCollection");
			bool result;
			using (new global::System.Transactions.TransactionScope(global::System.Transactions.TransactionScopeOption.Suppress))
			{
				result = this.DbDatabaseExists(connection, commandTimeout, storeItemCollection);
			}
			return result;
		}

		// Token: 0x06004A4A RID: 19018 RVA: 0x00106610 File Offset: 0x00104810
		protected virtual bool DbDatabaseExists(global::System.Data.Common.DbConnection connection, int? commandTimeout, global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection storeItemCollection)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbConnection>(connection, "connection");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection>(storeItemCollection, "storeItemCollection");
			throw new global::System.Data.Entity.Core.ProviderIncompatibleException(global::System.Data.Entity.Resources.Strings.ProviderDoesNotSupportDatabaseExists);
		}

		// Token: 0x06004A4B RID: 19019 RVA: 0x00106634 File Offset: 0x00104834
		protected virtual bool DbDatabaseExists(global::System.Data.Common.DbConnection connection, int? commandTimeout, global::System.Lazy<global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection> storeItemCollection)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbConnection>(connection, "connection");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Lazy<global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection>>(storeItemCollection, "storeItemCollection");
			return this.DbDatabaseExists(connection, commandTimeout, storeItemCollection.Value);
		}

		// Token: 0x06004A4C RID: 19020 RVA: 0x0010665C File Offset: 0x0010485C
		public void DeleteDatabase(global::System.Data.Common.DbConnection connection, int? commandTimeout, global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection storeItemCollection)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbConnection>(connection, "connection");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection>(storeItemCollection, "storeItemCollection");
			this.DbDeleteDatabase(connection, commandTimeout, storeItemCollection);
		}

		// Token: 0x06004A4D RID: 19021 RVA: 0x0010667F File Offset: 0x0010487F
		protected virtual void DbDeleteDatabase(global::System.Data.Common.DbConnection connection, int? commandTimeout, global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection storeItemCollection)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbConnection>(connection, "connection");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection>(storeItemCollection, "storeItemCollection");
			throw new global::System.Data.Entity.Core.ProviderIncompatibleException(global::System.Data.Entity.Resources.Strings.ProviderDoesNotSupportDeleteDatabase);
		}

		// Token: 0x06004A4E RID: 19022 RVA: 0x001066A4 File Offset: 0x001048A4
		public static string ExpandDataDirectory(string path)
		{
			if (string.IsNullOrEmpty(path) || !path.StartsWith("|datadirectory|", global::System.StringComparison.OrdinalIgnoreCase))
			{
				return path;
			}
			object data = global::System.AppDomain.CurrentDomain.GetData("DataDirectory");
			string text = data as string;
			if (data != null && text == null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ADP_InvalidDataDirectory);
			}
			if (text == string.Empty)
			{
				text = global::System.AppDomain.CurrentDomain.BaseDirectory;
			}
			if (text == null)
			{
				text = string.Empty;
			}
			path = path.Substring("|datadirectory|".Length);
			if (path.StartsWith("\\", global::System.StringComparison.Ordinal))
			{
				path = path.Substring(1);
			}
			path = (text.EndsWith("\\", global::System.StringComparison.Ordinal) ? text : (text + "\\")) + path;
			if (text.Contains(".."))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ExpandingDataDirectoryFailed);
			}
			return path;
		}

		// Token: 0x06004A4F RID: 19023 RVA: 0x00106778 File Offset: 0x00104978
		protected void AddDependencyResolver(global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver resolver)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver>(resolver, "resolver");
			this._resolvers.Add(resolver);
		}

		// Token: 0x06004A50 RID: 19024 RVA: 0x00106792 File Offset: 0x00104992
		public virtual object GetService(global::System.Type type, object key)
		{
			return this._resolvers.GetService(type, key);
		}

		// Token: 0x06004A51 RID: 19025 RVA: 0x001067A1 File Offset: 0x001049A1
		public virtual global::System.Collections.Generic.IEnumerable<object> GetServices(global::System.Type type, object key)
		{
			return this._resolvers.GetServices(type, key);
		}

		// Token: 0x04001A2B RID: 6699
		private readonly global::System.Lazy<global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver> _resolver;

		// Token: 0x04001A2C RID: 6700
		private readonly global::System.Lazy<global::System.Data.Entity.Infrastructure.Interception.DbCommandTreeDispatcher> _treeDispatcher;

		// Token: 0x04001A2D RID: 6701
		private static readonly global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Data.Entity.Infrastructure.DbProviderInfo, global::System.Data.Entity.Spatial.DbSpatialServices> _spatialServices = new global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Data.Entity.Infrastructure.DbProviderInfo, global::System.Data.Entity.Spatial.DbSpatialServices>();

		// Token: 0x04001A2E RID: 6702
		private static readonly global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Data.Entity.Infrastructure.ExecutionStrategyKey, global::System.Func<global::System.Data.Entity.Infrastructure.IDbExecutionStrategy>> _executionStrategyFactories = new global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Data.Entity.Infrastructure.ExecutionStrategyKey, global::System.Func<global::System.Data.Entity.Infrastructure.IDbExecutionStrategy>>();

		// Token: 0x04001A2F RID: 6703
		private readonly global::System.Data.Entity.Infrastructure.DependencyResolution.ResolverChain _resolvers = new global::System.Data.Entity.Infrastructure.DependencyResolution.ResolverChain();
	}
}
