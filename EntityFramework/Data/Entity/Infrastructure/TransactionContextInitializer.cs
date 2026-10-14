using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Data.Entity.Internal;
using System.Data.Entity.Migrations;
using System.Data.Entity.Migrations.Infrastructure;
using System.Data.Entity.Migrations.Model;
using System.Data.Entity.Migrations.Sql;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Transactions;
using System.Xml.Linq;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x02000265 RID: 613
	internal class TransactionContextInitializer<TContext> : global::System.Data.Entity.IDatabaseInitializer<TContext> where TContext : global::System.Data.Entity.Infrastructure.TransactionContext
	{
		// Token: 0x06001F18 RID: 7960 RVA: 0x00055830 File Offset: 0x00053A30
		public void InitializeDatabase(TContext context)
		{
			global::System.Data.Entity.Core.EntityClient.EntityConnection entityConnection = (global::System.Data.Entity.Core.EntityClient.EntityConnection)context.ObjectContext.Connection;
			if (entityConnection.State == global::System.Data.ConnectionState.Open && entityConnection.CurrentTransaction != null)
			{
				try
				{
					using (new global::System.Transactions.TransactionScope(global::System.Transactions.TransactionScopeOption.Suppress))
					{
						context.Transactions.AsNoTracking<global::System.Data.Entity.Infrastructure.TransactionRow>().WithExecutionStrategy(new global::System.Data.Entity.Infrastructure.DefaultExecutionStrategy()).Count<global::System.Data.Entity.Infrastructure.TransactionRow>();
					}
				}
				catch (global::System.Data.Entity.Core.EntityException)
				{
					global::System.Data.Entity.Infrastructure.DbContextInfo currentInfo = global::System.Data.Entity.Infrastructure.DbContextInfo.CurrentInfo;
					global::System.Data.Entity.Infrastructure.DbContextInfo.CurrentInfo = null;
					try
					{
						global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Sql.MigrationStatement> migrationStatements = global::System.Data.Entity.Infrastructure.TransactionContextInitializer<TContext>.GenerateMigrationStatements(context);
						global::System.Data.Entity.Migrations.DbMigrator dbMigrator = new global::System.Data.Entity.Migrations.DbMigrator(context.InternalContext.MigrationsConfiguration, context, global::System.Data.Entity.Internal.DatabaseExistenceState.Exists, true);
						using (new global::System.Transactions.TransactionScope(global::System.Transactions.TransactionScopeOption.Suppress))
						{
							dbMigrator.ExecuteStatements(migrationStatements, entityConnection.CurrentTransaction.StoreTransaction);
						}
					}
					finally
					{
						global::System.Data.Entity.Infrastructure.DbContextInfo.CurrentInfo = currentInfo;
					}
				}
			}
		}

		// Token: 0x06001F19 RID: 7961 RVA: 0x0005593C File Offset: 0x00053B3C
		internal static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Sql.MigrationStatement> GenerateMigrationStatements(global::System.Data.Entity.Infrastructure.TransactionContext context)
		{
			if (global::System.Data.Entity.DbConfiguration.DependencyResolver.GetService(context.InternalContext.ProviderName) != null)
			{
				global::System.Data.Entity.Migrations.Sql.MigrationSqlGenerator sqlGenerator = context.InternalContext.MigrationsConfiguration.GetSqlGenerator(context.InternalContext.ProviderName);
				global::System.Data.Common.DbConnection connection = context.Database.Connection;
				global::System.Xml.Linq.XDocument model = new global::System.Data.Entity.DbModelBuilder().Build(connection).GetModel();
				global::System.Data.Entity.Migrations.Model.CreateTableOperation createTableOperation = (global::System.Data.Entity.Migrations.Model.CreateTableOperation)new global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer().Diff(model, context.GetModel(), null, null, null, null).Single<global::System.Data.Entity.Migrations.Model.MigrationOperation>();
				string providerManifestToken = (context.InternalContext.ModelProviderInfo != null) ? context.InternalContext.ModelProviderInfo.ProviderManifestToken : global::System.Data.Entity.DbConfiguration.DependencyResolver.GetService<global::System.Data.Entity.Infrastructure.IManifestTokenResolver>().ResolveManifestToken(connection);
				return sqlGenerator.Generate(new global::System.Data.Entity.Migrations.Model.CreateTableOperation[]
				{
					createTableOperation
				}, providerManifestToken);
			}
			return new global::System.Data.Entity.Migrations.Sql.MigrationStatement[]
			{
				new global::System.Data.Entity.Migrations.Sql.MigrationStatement
				{
					Sql = ((global::System.Data.Entity.Infrastructure.IObjectContextAdapter)context).ObjectContext.CreateDatabaseScript(),
					SuppressTransaction = true
				}
			};
		}
	}
}
