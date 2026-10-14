using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Internal;
using System.Data.Entity.Migrations.Edm;
using System.Data.Entity.Migrations.Infrastructure;
using System.Data.Entity.Migrations.Model;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Reflection;
using System.Transactions;
using System.Xml.Linq;

namespace System.Data.Entity.Migrations.History
{
	// Token: 0x020000DC RID: 220
	internal class HistoryRepository : global::System.Data.Entity.Internal.RepositoryBase
	{
		// Token: 0x060010BF RID: 4287 RVA: 0x00025684 File Offset: 0x00023884
		public HistoryRepository(global::System.Data.Entity.Internal.InternalContext usersContext, string connectionString, global::System.Data.Common.DbProviderFactory providerFactory, string contextKey, int? commandTimeout, global::System.Func<global::System.Data.Common.DbConnection, string, global::System.Data.Entity.Migrations.History.HistoryContext> historyContextFactory, global::System.Collections.Generic.IEnumerable<string> schemas = null, global::System.Data.Entity.DbContext contextForInterception = null, global::System.Data.Entity.Internal.DatabaseExistenceState initialExistence = global::System.Data.Entity.Internal.DatabaseExistenceState.Unknown, global::System.Func<global::System.Exception, bool> permissionDeniedDetector = null) : base(usersContext, connectionString, providerFactory)
		{
			this._initialExistence = initialExistence;
			this._permissionDeniedDetector = permissionDeniedDetector;
			this._commandTimeout = commandTimeout;
			this._existingTransaction = usersContext.TryGetCurrentStoreTransaction();
			this._schemas = new string[]
			{
				"dbo"
			}.Concat(schemas ?? global::System.Linq.Enumerable.Empty<string>()).Distinct<string>();
			this._contextForInterception = contextForInterception;
			this._historyContextFactory = historyContextFactory;
			global::System.Data.Common.DbConnection connection = null;
			try
			{
				connection = base.CreateConnection();
				using (global::System.Data.Entity.Migrations.History.HistoryContext historyContext = this.CreateContext(connection, null))
				{
					global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = ((global::System.Data.Entity.Infrastructure.IObjectContextAdapter)historyContext).ObjectContext.MetadataWorkspace.GetItems<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace).Single((global::System.Data.Entity.Core.Metadata.Edm.EntityType et) => et.GetClrType() == typeof(global::System.Data.Entity.Migrations.History.HistoryRow));
					int? maxLength = entityType.Properties.Single((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty p) => p.GetClrPropertyInfo().IsSameAs(global::System.Data.Entity.Migrations.History.HistoryRepository.MigrationIdProperty)).MaxLength;
					this._migrationIdMaxLength = ((maxLength != null) ? maxLength.Value : 150);
					maxLength = entityType.Properties.Single((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty p) => p.GetClrPropertyInfo().IsSameAs(global::System.Data.Entity.Migrations.History.HistoryRepository.ContextKeyProperty)).MaxLength;
					this._contextKeyMaxLength = ((maxLength != null) ? maxLength.Value : 300);
				}
			}
			finally
			{
				base.DisposeConnection(connection);
			}
			this._contextKey = contextKey.RestrictTo(this._contextKeyMaxLength);
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x060010C0 RID: 4288 RVA: 0x0002581C File Offset: 0x00023A1C
		public int ContextKeyMaxLength
		{
			get
			{
				return this._contextKeyMaxLength;
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x060010C1 RID: 4289 RVA: 0x00025824 File Offset: 0x00023A24
		public int MigrationIdMaxLength
		{
			get
			{
				return this._migrationIdMaxLength;
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x060010C2 RID: 4290 RVA: 0x0002582C File Offset: 0x00023A2C
		// (set) Token: 0x060010C3 RID: 4291 RVA: 0x00025834 File Offset: 0x00023A34
		public string CurrentSchema
		{
			get
			{
				return this._currentSchema;
			}
			set
			{
				this._currentSchema = value;
			}
		}

		// Token: 0x060010C4 RID: 4292 RVA: 0x00025840 File Offset: 0x00023A40
		public virtual global::System.Xml.Linq.XDocument GetLastModel(out string migrationId, out string productVersion, string contextKey = null)
		{
			migrationId = null;
			productVersion = null;
			if (!this.Exists(contextKey))
			{
				return null;
			}
			global::System.Data.Common.DbConnection connection = null;
			global::System.Xml.Linq.XDocument result;
			try
			{
				connection = base.CreateConnection();
				using (global::System.Data.Entity.Migrations.History.HistoryContext historyContext = this.CreateContext(connection, null))
				{
					using (new global::System.Transactions.TransactionScope(global::System.Transactions.TransactionScopeOption.Suppress))
					{
						var <>f__AnonymousType = (from h in this.CreateHistoryQuery(historyContext, contextKey)
						orderby h.MigrationId descending
						select h into s
						select new
						{
							s.MigrationId,
							s.Model,
							s.ProductVersion
						}).FirstOrDefault();
						if (<>f__AnonymousType == null)
						{
							result = null;
						}
						else
						{
							migrationId = <>f__AnonymousType.MigrationId;
							productVersion = <>f__AnonymousType.ProductVersion;
							result = new global::System.Data.Entity.Migrations.Edm.ModelCompressor().Decompress(<>f__AnonymousType.Model);
						}
					}
				}
			}
			finally
			{
				base.DisposeConnection(connection);
			}
			return result;
		}

		// Token: 0x060010C5 RID: 4293 RVA: 0x00025A3C File Offset: 0x00023C3C
		public virtual global::System.Xml.Linq.XDocument GetModel(string migrationId, out string productVersion)
		{
			productVersion = null;
			if (!this.Exists(null))
			{
				return null;
			}
			migrationId = migrationId.RestrictTo(this._migrationIdMaxLength);
			global::System.Data.Common.DbConnection connection = null;
			global::System.Xml.Linq.XDocument result;
			try
			{
				connection = base.CreateConnection();
				using (global::System.Data.Entity.Migrations.History.HistoryContext historyContext = this.CreateContext(connection, null))
				{
					var <>f__AnonymousType = (from h in this.CreateHistoryQuery(historyContext, null)
					where h.MigrationId == migrationId
					select new
					{
						h.Model,
						h.ProductVersion
					}).SingleOrDefault();
					if (<>f__AnonymousType == null)
					{
						result = null;
					}
					else
					{
						productVersion = <>f__AnonymousType.ProductVersion;
						result = new global::System.Data.Entity.Migrations.Edm.ModelCompressor().Decompress(<>f__AnonymousType.Model);
					}
				}
			}
			finally
			{
				base.DisposeConnection(connection);
			}
			return result;
		}

		// Token: 0x060010C6 RID: 4294 RVA: 0x00025C1C File Offset: 0x00023E1C
		public virtual global::System.Collections.Generic.IEnumerable<string> GetPendingMigrations(global::System.Collections.Generic.IEnumerable<string> localMigrations)
		{
			if (!this.Exists(null))
			{
				return localMigrations;
			}
			global::System.Data.Common.DbConnection connection = null;
			global::System.Collections.Generic.IEnumerable<string> result;
			try
			{
				connection = base.CreateConnection();
				using (global::System.Data.Entity.Migrations.History.HistoryContext historyContext = this.CreateContext(connection, null))
				{
					global::System.Collections.Generic.List<string> list;
					using (new global::System.Transactions.TransactionScope(global::System.Transactions.TransactionScopeOption.Suppress))
					{
						list = (from h in this.CreateHistoryQuery(historyContext, null)
						select h.MigrationId).ToList<string>();
					}
					localMigrations = (from m in localMigrations
					select m.RestrictTo(this._migrationIdMaxLength)).ToArray<string>();
					global::System.Collections.Generic.IEnumerable<string> source = localMigrations.Except(list);
					string text = list.FirstOrDefault<string>();
					string text2 = localMigrations.FirstOrDefault<string>();
					if (text != text2 && text != null && text.MigrationName() == global::System.Data.Entity.Resources.Strings.InitialCreate && text2 != null && text2.MigrationName() == global::System.Data.Entity.Resources.Strings.InitialCreate)
					{
						source = source.Skip(1);
					}
					result = source.ToList<string>();
				}
			}
			finally
			{
				base.DisposeConnection(connection);
			}
			return result;
		}

		// Token: 0x060010C7 RID: 4295 RVA: 0x00025D64 File Offset: 0x00023F64
		public virtual global::System.Collections.Generic.IEnumerable<string> GetMigrationsSince(string migrationId)
		{
			bool flag = this.Exists(null);
			global::System.Data.Common.DbConnection connection = null;
			global::System.Collections.Generic.IEnumerable<string> result;
			try
			{
				connection = base.CreateConnection();
				using (global::System.Data.Entity.Migrations.History.HistoryContext historyContext = this.CreateContext(connection, null))
				{
					global::System.Linq.IQueryable<global::System.Data.Entity.Migrations.History.HistoryRow> source = this.CreateHistoryQuery(historyContext, null);
					migrationId = migrationId.RestrictTo(this._migrationIdMaxLength);
					if (migrationId != "0")
					{
						if (!flag || !source.Any((global::System.Data.Entity.Migrations.History.HistoryRow h) => h.MigrationId == migrationId))
						{
							throw global::System.Data.Entity.Resources.Error.MigrationNotFound(migrationId);
						}
						source = from h in source
						where string.Compare(h.MigrationId, migrationId, global::System.StringComparison.Ordinal) > 0
						select h;
					}
					else if (!flag)
					{
						return global::System.Linq.Enumerable.Empty<string>();
					}
					result = (from h in source
					orderby h.MigrationId descending
					select h.MigrationId).ToList<string>();
				}
			}
			finally
			{
				base.DisposeConnection(connection);
			}
			return result;
		}

		// Token: 0x060010C8 RID: 4296 RVA: 0x00025FE4 File Offset: 0x000241E4
		public virtual string GetMigrationId(string migrationName)
		{
			if (!this.Exists(null))
			{
				return null;
			}
			global::System.Data.Common.DbConnection connection = null;
			string result;
			try
			{
				connection = base.CreateConnection();
				using (global::System.Data.Entity.Migrations.History.HistoryContext historyContext = this.CreateContext(connection, null))
				{
					global::System.Collections.Generic.List<string> source = (from h in this.CreateHistoryQuery(historyContext, null)
					select h.MigrationId into m
					where m.Substring(16) == migrationName
					select m).ToList<string>();
					if (!source.Any<string>())
					{
						result = null;
					}
					else
					{
						if (source.Count<string>() != 1)
						{
							throw global::System.Data.Entity.Resources.Error.AmbiguousMigrationName(migrationName);
						}
						result = source.Single<string>();
					}
				}
			}
			finally
			{
				base.DisposeConnection(connection);
			}
			return result;
		}

		// Token: 0x060010C9 RID: 4297 RVA: 0x00026164 File Offset: 0x00024364
		private global::System.Linq.IQueryable<global::System.Data.Entity.Migrations.History.HistoryRow> CreateHistoryQuery(global::System.Data.Entity.Migrations.History.HistoryContext context, string contextKey = null)
		{
			global::System.Linq.IQueryable<global::System.Data.Entity.Migrations.History.HistoryRow> queryable = context.History;
			contextKey = ((!string.IsNullOrWhiteSpace(contextKey)) ? contextKey.RestrictTo(this._contextKeyMaxLength) : this._contextKey);
			if (this._contextKeyColumnExists)
			{
				queryable = from h in queryable
				where h.ContextKey == contextKey
				select h;
			}
			return queryable;
		}

		// Token: 0x060010CA RID: 4298 RVA: 0x00026220 File Offset: 0x00024420
		public virtual bool IsShared()
		{
			if (!this.Exists(null) || !this._contextKeyColumnExists)
			{
				return false;
			}
			global::System.Data.Common.DbConnection connection = null;
			bool result;
			try
			{
				connection = base.CreateConnection();
				using (global::System.Data.Entity.Migrations.History.HistoryContext historyContext = this.CreateContext(connection, null))
				{
					result = historyContext.History.Any((global::System.Data.Entity.Migrations.History.HistoryRow hr) => hr.ContextKey != this._contextKey);
				}
			}
			finally
			{
				base.DisposeConnection(connection);
			}
			return result;
		}

		// Token: 0x060010CB RID: 4299 RVA: 0x000262EC File Offset: 0x000244EC
		public virtual bool HasMigrations()
		{
			if (!this.Exists(null))
			{
				return false;
			}
			if (!this._contextKeyColumnExists)
			{
				return true;
			}
			global::System.Data.Common.DbConnection connection = null;
			bool result;
			try
			{
				connection = base.CreateConnection();
				using (global::System.Data.Entity.Migrations.History.HistoryContext historyContext = this.CreateContext(connection, null))
				{
					result = (historyContext.History.Count((global::System.Data.Entity.Migrations.History.HistoryRow hr) => hr.ContextKey == this._contextKey) > 0);
				}
			}
			finally
			{
				base.DisposeConnection(connection);
			}
			return result;
		}

		// Token: 0x060010CC RID: 4300 RVA: 0x000263C0 File Offset: 0x000245C0
		public virtual bool Exists(string contextKey = null)
		{
			if (this._exists == null)
			{
				this._exists = new bool?(this.QueryExists(contextKey ?? this._contextKey));
			}
			return this._exists.Value;
		}

		// Token: 0x060010CD RID: 4301 RVA: 0x000263F8 File Offset: 0x000245F8
		private bool QueryExists(string contextKey)
		{
			if (this._initialExistence == global::System.Data.Entity.Internal.DatabaseExistenceState.DoesNotExist)
			{
				return false;
			}
			global::System.Data.Common.DbConnection connection = null;
			try
			{
				connection = base.CreateConnection();
				if (this._initialExistence == global::System.Data.Entity.Internal.DatabaseExistenceState.Unknown)
				{
					using (global::System.Data.Entity.Migrations.History.HistoryContext historyContext = this.CreateContext(connection, null))
					{
						if (!historyContext.Database.Exists())
						{
							return false;
						}
					}
				}
				foreach (string text in this._schemas.Reverse<string>())
				{
					using (global::System.Data.Entity.Migrations.History.HistoryContext historyContext2 = this.CreateContext(connection, text))
					{
						this._currentSchema = text;
						this._contextKeyColumnExists = true;
						try
						{
							using (new global::System.Transactions.TransactionScope(global::System.Transactions.TransactionScopeOption.Suppress))
							{
								contextKey = contextKey.RestrictTo(this._contextKeyMaxLength);
								if (historyContext2.History.Count((global::System.Data.Entity.Migrations.History.HistoryRow hr) => hr.ContextKey == contextKey) > 0)
								{
									return true;
								}
							}
						}
						catch (global::System.Data.Entity.Core.EntityException ex)
						{
							if (this._permissionDeniedDetector != null && this._permissionDeniedDetector(ex.InnerException))
							{
								throw;
							}
							this._contextKeyColumnExists = false;
						}
						if (!this._contextKeyColumnExists)
						{
							try
							{
								using (new global::System.Transactions.TransactionScope(global::System.Transactions.TransactionScopeOption.Suppress))
								{
									historyContext2.History.Count<global::System.Data.Entity.Migrations.History.HistoryRow>();
								}
							}
							catch (global::System.Data.Entity.Core.EntityException ex2)
							{
								if (this._permissionDeniedDetector != null && this._permissionDeniedDetector(ex2.InnerException))
								{
									throw;
								}
								this._currentSchema = null;
							}
						}
					}
				}
			}
			finally
			{
				base.DisposeConnection(connection);
			}
			return !string.IsNullOrWhiteSpace(this._currentSchema);
		}

		// Token: 0x060010CE RID: 4302 RVA: 0x000266BC File Offset: 0x000248BC
		public virtual void ResetExists()
		{
			this._exists = null;
		}

		// Token: 0x060010CF RID: 4303 RVA: 0x000266CA File Offset: 0x000248CA
		public virtual global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.MigrationOperation> GetUpgradeOperations()
		{
			if (!this.Exists(null))
			{
				yield break;
			}
			global::System.Data.Common.DbConnection connection = null;
			try
			{
				connection = base.CreateConnection();
				string tableName = "dbo.__MigrationHistory";
				global::System.Data.Entity.Core.Common.DbProviderManifest dbProviderManifest;
				if (connection.GetProviderInfo(out dbProviderManifest).IsSqlCe())
				{
					tableName = "__MigrationHistory";
				}
				using (global::System.Data.Entity.Migrations.History.LegacyHistoryContext context = new global::System.Data.Entity.Migrations.History.LegacyHistoryContext(connection))
				{
					bool flag = false;
					try
					{
						this.InjectInterceptionContext(context);
						using (new global::System.Transactions.TransactionScope(global::System.Transactions.TransactionScopeOption.Suppress))
						{
							(from h in context.History
							select h.CreatedOn).FirstOrDefault<global::System.DateTime>();
						}
						flag = true;
					}
					catch (global::System.Data.Entity.Core.EntityException)
					{
					}
					if (flag)
					{
						yield return new global::System.Data.Entity.Migrations.Model.DropColumnOperation(tableName, "CreatedOn", null);
					}
				}
				global::System.Data.Entity.Migrations.History.LegacyHistoryContext context = null;
				using (global::System.Data.Entity.Migrations.History.HistoryContext context2 = this.CreateContext(connection, null))
				{
					if (!this._contextKeyColumnExists)
					{
						if (this._historyContextFactory != global::System.Data.Entity.Migrations.History.HistoryContext.DefaultFactory)
						{
							throw global::System.Data.Entity.Resources.Error.UnableToUpgradeHistoryWhenCustomFactory();
						}
						yield return new global::System.Data.Entity.Migrations.Model.AddColumnOperation(tableName, new global::System.Data.Entity.Migrations.Model.ColumnModel(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String)
						{
							MaxLength = new int?(this._contextKeyMaxLength),
							Name = "ContextKey",
							IsNullable = new bool?(false),
							DefaultValue = this._contextKey
						}, null);
						global::System.Xml.Linq.XDocument model = new global::System.Data.Entity.DbModelBuilder().Build(connection).GetModel();
						global::System.Data.Entity.Migrations.Model.CreateTableOperation createTableOperation = (global::System.Data.Entity.Migrations.Model.CreateTableOperation)new global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer().Diff(model, context2.GetModel(), null, null, null, null).Single<global::System.Data.Entity.Migrations.Model.MigrationOperation>();
						global::System.Data.Entity.Migrations.Model.DropPrimaryKeyOperation dropPrimaryKeyOperation = new global::System.Data.Entity.Migrations.Model.DropPrimaryKeyOperation(null)
						{
							Table = tableName,
							CreateTableOperation = createTableOperation
						};
						dropPrimaryKeyOperation.Columns.Add("MigrationId");
						yield return dropPrimaryKeyOperation;
						yield return new global::System.Data.Entity.Migrations.Model.AlterColumnOperation(tableName, new global::System.Data.Entity.Migrations.Model.ColumnModel(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String)
						{
							MaxLength = new int?(this._migrationIdMaxLength),
							Name = "MigrationId",
							IsNullable = new bool?(false)
						}, false, null);
						global::System.Data.Entity.Migrations.Model.AddPrimaryKeyOperation addPrimaryKeyOperation = new global::System.Data.Entity.Migrations.Model.AddPrimaryKeyOperation(null)
						{
							Table = tableName
						};
						addPrimaryKeyOperation.Columns.Add("MigrationId");
						addPrimaryKeyOperation.Columns.Add("ContextKey");
						yield return addPrimaryKeyOperation;
					}
				}
				global::System.Data.Entity.Migrations.History.HistoryContext context2 = null;
				tableName = null;
			}
			finally
			{
				base.DisposeConnection(connection);
			}
			yield break;
			yield break;
		}

		// Token: 0x060010D0 RID: 4304 RVA: 0x000266DC File Offset: 0x000248DC
		public virtual global::System.Data.Entity.Migrations.Model.MigrationOperation CreateInsertOperation(string migrationId, global::System.Data.Entity.Migrations.Infrastructure.VersionedModel versionedModel)
		{
			global::System.Data.Common.DbConnection connection = null;
			global::System.Data.Entity.Migrations.Model.MigrationOperation result;
			try
			{
				connection = base.CreateConnection();
				using (global::System.Data.Entity.Migrations.History.HistoryContext historyContext = this.CreateContext(connection, null))
				{
					historyContext.History.Add(new global::System.Data.Entity.Migrations.History.HistoryRow
					{
						MigrationId = migrationId.RestrictTo(this._migrationIdMaxLength),
						ContextKey = this._contextKey,
						Model = new global::System.Data.Entity.Migrations.Edm.ModelCompressor().Compress(versionedModel.Model),
						ProductVersion = (versionedModel.Version ?? global::System.Data.Entity.Migrations.History.HistoryRepository._productVersion)
					});
					using (global::System.Data.Entity.Internal.CommandTracer commandTracer = new global::System.Data.Entity.Internal.CommandTracer(historyContext))
					{
						historyContext.SaveChanges();
						result = new global::System.Data.Entity.Migrations.Model.HistoryOperation(commandTracer.CommandTrees.OfType<global::System.Data.Entity.Core.Common.CommandTrees.DbModificationCommandTree>().ToList<global::System.Data.Entity.Core.Common.CommandTrees.DbModificationCommandTree>(), null);
					}
				}
			}
			finally
			{
				base.DisposeConnection(connection);
			}
			return result;
		}

		// Token: 0x060010D1 RID: 4305 RVA: 0x000267C4 File Offset: 0x000249C4
		public virtual global::System.Data.Entity.Migrations.Model.MigrationOperation CreateDeleteOperation(string migrationId)
		{
			global::System.Data.Common.DbConnection connection = null;
			global::System.Data.Entity.Migrations.Model.MigrationOperation result;
			try
			{
				connection = base.CreateConnection();
				using (global::System.Data.Entity.Migrations.History.HistoryContext historyContext = this.CreateContext(connection, null))
				{
					global::System.Data.Entity.Migrations.History.HistoryRow entity = new global::System.Data.Entity.Migrations.History.HistoryRow
					{
						MigrationId = migrationId.RestrictTo(this._migrationIdMaxLength),
						ContextKey = this._contextKey
					};
					historyContext.History.Attach(entity);
					historyContext.History.Remove(entity);
					using (global::System.Data.Entity.Internal.CommandTracer commandTracer = new global::System.Data.Entity.Internal.CommandTracer(historyContext))
					{
						historyContext.SaveChanges();
						result = new global::System.Data.Entity.Migrations.Model.HistoryOperation(commandTracer.CommandTrees.OfType<global::System.Data.Entity.Core.Common.CommandTrees.DbModificationCommandTree>().ToList<global::System.Data.Entity.Core.Common.CommandTrees.DbModificationCommandTree>(), null);
					}
				}
			}
			finally
			{
				base.DisposeConnection(connection);
			}
			return result;
		}

		// Token: 0x060010D2 RID: 4306 RVA: 0x00026890 File Offset: 0x00024A90
		public virtual global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree> CreateDiscoveryQueryTrees()
		{
			global::System.Data.Common.DbConnection connection = null;
			try
			{
				connection = base.CreateConnection();
				foreach (string schema in this._schemas)
				{
					using (global::System.Data.Entity.Migrations.History.HistoryContext context = this.CreateContext(connection, schema))
					{
						global::System.Linq.IOrderedQueryable<string> orderedQueryable = from h in context.History
						where h.ContextKey == this._contextKey
						select h into s
						select s.MigrationId into s
						orderby s descending
						select s;
						global::System.Data.Entity.Infrastructure.DbQuery<string> dbQuery = orderedQueryable as global::System.Data.Entity.Infrastructure.DbQuery<string>;
						if (dbQuery != null)
						{
							dbQuery.InternalQuery.ObjectQuery.EnablePlanCaching = false;
						}
						using (global::System.Data.Entity.Internal.CommandTracer commandTracer = new global::System.Data.Entity.Internal.CommandTracer(context))
						{
							orderedQueryable.First<string>();
							global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree dbQueryCommandTree = commandTracer.CommandTrees.OfType<global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree>().Single((global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree t) => t.DataSpace == global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace);
							yield return new global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree(dbQueryCommandTree.MetadataWorkspace, dbQueryCommandTree.DataSpace, dbQueryCommandTree.Query.Accept<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(new global::System.Data.Entity.Migrations.History.HistoryRepository.ParameterInliner(commandTracer.DbCommands.Single<global::System.Data.Common.DbCommand>().Parameters)));
						}
						global::System.Data.Entity.Internal.CommandTracer commandTracer = null;
					}
					global::System.Data.Entity.Migrations.History.HistoryContext context = null;
				}
				global::System.Collections.Generic.IEnumerator<string> enumerator = null;
			}
			finally
			{
				base.DisposeConnection(connection);
			}
			yield break;
			yield break;
		}

		// Token: 0x060010D3 RID: 4307 RVA: 0x000268A0 File Offset: 0x00024AA0
		public virtual void BootstrapUsingEFProviderDdl(global::System.Data.Entity.Migrations.Infrastructure.VersionedModel versionedModel)
		{
			global::System.Data.Common.DbConnection connection = null;
			try
			{
				connection = base.CreateConnection();
				using (global::System.Data.Entity.Migrations.History.HistoryContext historyContext = this.CreateContext(connection, null))
				{
					historyContext.Database.ExecuteSqlCommand(((global::System.Data.Entity.Infrastructure.IObjectContextAdapter)historyContext).ObjectContext.CreateDatabaseScript(), new object[0]);
					historyContext.History.Add(new global::System.Data.Entity.Migrations.History.HistoryRow
					{
						MigrationId = global::System.Data.Entity.Migrations.Infrastructure.MigrationAssembly.CreateMigrationId(global::System.Data.Entity.Resources.Strings.InitialCreate).RestrictTo(this._migrationIdMaxLength),
						ContextKey = this._contextKey,
						Model = new global::System.Data.Entity.Migrations.Edm.ModelCompressor().Compress(versionedModel.Model),
						ProductVersion = (versionedModel.Version ?? global::System.Data.Entity.Migrations.History.HistoryRepository._productVersion)
					});
					historyContext.SaveChanges();
				}
			}
			finally
			{
				base.DisposeConnection(connection);
			}
		}

		// Token: 0x060010D4 RID: 4308 RVA: 0x00026978 File Offset: 0x00024B78
		public global::System.Data.Entity.Migrations.History.HistoryContext CreateContext(global::System.Data.Common.DbConnection connection, string schema = null)
		{
			global::System.Data.Entity.Migrations.History.HistoryContext historyContext = this._historyContextFactory(connection, schema ?? this.CurrentSchema);
			historyContext.Database.CommandTimeout = this._commandTimeout;
			if (this._existingTransaction != null && this._existingTransaction.Connection == connection)
			{
				historyContext.Database.UseTransaction(this._existingTransaction);
			}
			this.InjectInterceptionContext(historyContext);
			return historyContext;
		}

		// Token: 0x060010D5 RID: 4309 RVA: 0x000269DD File Offset: 0x00024BDD
		private void InjectInterceptionContext(global::System.Data.Entity.DbContext context)
		{
			if (this._contextForInterception != null)
			{
				global::System.Data.Entity.Core.Objects.ObjectContext objectContext = context.InternalContext.ObjectContext;
				objectContext.InterceptionContext = objectContext.InterceptionContext.WithDbContext(this._contextForInterception);
			}
		}

		// Token: 0x040008B6 RID: 2230
		private static readonly string _productVersion = typeof(global::System.Data.Entity.Migrations.History.HistoryRepository).Assembly().GetInformationalVersion();

		// Token: 0x040008B7 RID: 2231
		public static readonly global::System.Reflection.PropertyInfo MigrationIdProperty = typeof(global::System.Data.Entity.Migrations.History.HistoryRow).GetDeclaredProperty("MigrationId");

		// Token: 0x040008B8 RID: 2232
		public static readonly global::System.Reflection.PropertyInfo ContextKeyProperty = typeof(global::System.Data.Entity.Migrations.History.HistoryRow).GetDeclaredProperty("ContextKey");

		// Token: 0x040008B9 RID: 2233
		private readonly string _contextKey;

		// Token: 0x040008BA RID: 2234
		private readonly int? _commandTimeout;

		// Token: 0x040008BB RID: 2235
		private readonly global::System.Collections.Generic.IEnumerable<string> _schemas;

		// Token: 0x040008BC RID: 2236
		private readonly global::System.Func<global::System.Data.Common.DbConnection, string, global::System.Data.Entity.Migrations.History.HistoryContext> _historyContextFactory;

		// Token: 0x040008BD RID: 2237
		private readonly global::System.Data.Entity.DbContext _contextForInterception;

		// Token: 0x040008BE RID: 2238
		private readonly int _contextKeyMaxLength;

		// Token: 0x040008BF RID: 2239
		private readonly int _migrationIdMaxLength;

		// Token: 0x040008C0 RID: 2240
		private readonly global::System.Data.Entity.Internal.DatabaseExistenceState _initialExistence;

		// Token: 0x040008C1 RID: 2241
		private readonly global::System.Func<global::System.Exception, bool> _permissionDeniedDetector;

		// Token: 0x040008C2 RID: 2242
		private readonly global::System.Data.Common.DbTransaction _existingTransaction;

		// Token: 0x040008C3 RID: 2243
		private string _currentSchema;

		// Token: 0x040008C4 RID: 2244
		private bool? _exists;

		// Token: 0x040008C5 RID: 2245
		private bool _contextKeyColumnExists;

		// Token: 0x020007B5 RID: 1973
		private class ParameterInliner : global::System.Data.Entity.Core.Common.CommandTrees.DefaultExpressionVisitor
		{
			// Token: 0x06005829 RID: 22569 RVA: 0x0013759C File Offset: 0x0013579C
			public ParameterInliner(global::System.Data.Common.DbParameterCollection parameters)
			{
				this._parameters = parameters;
			}

			// Token: 0x0600582A RID: 22570 RVA: 0x001375AB File Offset: 0x001357AB
			public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression expression)
			{
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(this._parameters[expression.ParameterName].Value);
			}

			// Token: 0x0600582B RID: 22571 RVA: 0x001375C8 File Offset: 0x001357C8
			public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbOrExpression expression)
			{
				return expression.Left.Accept<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(this);
			}

			// Token: 0x0600582C RID: 22572 RVA: 0x001375D6 File Offset: 0x001357D6
			public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbAndExpression expression)
			{
				if (expression.Right is global::System.Data.Entity.Core.Common.CommandTrees.DbNotExpression)
				{
					return expression.Left.Accept<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(this);
				}
				return base.Visit(expression);
			}

			// Token: 0x0400210C RID: 8460
			private readonly global::System.Data.Common.DbParameterCollection _parameters;
		}
	}
}
