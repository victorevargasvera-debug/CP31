using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity.Migrations.Infrastructure;
using System.Data.Entity.Migrations.Sql;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x02000262 RID: 610
	public class CommitFailureHandler : global::System.Data.Entity.Infrastructure.TransactionHandler
	{
		// Token: 0x06001EF4 RID: 7924 RVA: 0x00054F7D File Offset: 0x0005317D
		public CommitFailureHandler() : this((global::System.Data.Common.DbConnection c) => new global::System.Data.Entity.Infrastructure.TransactionContext(c))
		{
		}

		// Token: 0x06001EF5 RID: 7925 RVA: 0x00054FA4 File Offset: 0x000531A4
		public CommitFailureHandler(global::System.Func<global::System.Data.Common.DbConnection, global::System.Data.Entity.Infrastructure.TransactionContext> transactionContextFactory)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Common.DbConnection, global::System.Data.Entity.Infrastructure.TransactionContext>>(transactionContextFactory, "transactionContextFactory");
			this._transactionContextFactory = transactionContextFactory;
			this.Transactions = new global::System.Collections.Generic.Dictionary<global::System.Data.Common.DbTransaction, global::System.Data.Entity.Infrastructure.TransactionRow>();
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x06001EF6 RID: 7926 RVA: 0x00054FD5 File Offset: 0x000531D5
		// (set) Token: 0x06001EF7 RID: 7927 RVA: 0x00054FDD File Offset: 0x000531DD
		protected internal global::System.Data.Entity.Infrastructure.TransactionContext TransactionContext { get; private set; }

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x06001EF8 RID: 7928 RVA: 0x00054FE6 File Offset: 0x000531E6
		// (set) Token: 0x06001EF9 RID: 7929 RVA: 0x00054FEE File Offset: 0x000531EE
		private protected global::System.Collections.Generic.Dictionary<global::System.Data.Common.DbTransaction, global::System.Data.Entity.Infrastructure.TransactionRow> Transactions { protected get; private set; }

		// Token: 0x06001EFA RID: 7930 RVA: 0x00054FF7 File Offset: 0x000531F7
		protected virtual global::System.Data.Entity.Infrastructure.IDbExecutionStrategy GetExecutionStrategy()
		{
			return null;
		}

		// Token: 0x06001EFB RID: 7931 RVA: 0x00054FFC File Offset: 0x000531FC
		public override void Initialize(global::System.Data.Entity.Core.Objects.ObjectContext context)
		{
			base.Initialize(context);
			global::System.Data.Common.DbConnection storeConnection = ((global::System.Data.Entity.Core.EntityClient.EntityConnection)base.ObjectContext.Connection).StoreConnection;
			this.Initialize(storeConnection);
		}

		// Token: 0x06001EFC RID: 7932 RVA: 0x0005502D File Offset: 0x0005322D
		public override void Initialize(global::System.Data.Entity.DbContext context, global::System.Data.Common.DbConnection connection)
		{
			base.Initialize(context, connection);
			this.Initialize(connection);
		}

		// Token: 0x06001EFD RID: 7933 RVA: 0x00055040 File Offset: 0x00053240
		private void Initialize(global::System.Data.Common.DbConnection connection)
		{
			global::System.Data.Entity.Infrastructure.DbContextInfo currentInfo = global::System.Data.Entity.Infrastructure.DbContextInfo.CurrentInfo;
			global::System.Data.Entity.Infrastructure.DbContextInfo.CurrentInfo = null;
			try
			{
				this.TransactionContext = this._transactionContextFactory(connection);
				if (this.TransactionContext != null)
				{
					this.TransactionContext.Configuration.LazyLoadingEnabled = false;
					this.TransactionContext.Configuration.AutoDetectChangesEnabled = false;
					this.TransactionContext.Database.Initialize(false);
				}
			}
			finally
			{
				global::System.Data.Entity.Infrastructure.DbContextInfo.CurrentInfo = currentInfo;
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x06001EFE RID: 7934 RVA: 0x000550C0 File Offset: 0x000532C0
		protected virtual int PruningLimit
		{
			get
			{
				return 20;
			}
		}

		// Token: 0x06001EFF RID: 7935 RVA: 0x000550C4 File Offset: 0x000532C4
		protected override void Dispose(bool disposing)
		{
			if (!base.IsDisposed && disposing && this.TransactionContext != null)
			{
				if (this._rowsToDelete.Any<global::System.Data.Entity.Infrastructure.TransactionRow>())
				{
					try
					{
						this.PruneTransactionHistory(true, false);
					}
					catch (global::System.Exception)
					{
					}
				}
				this.TransactionContext.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001F00 RID: 7936 RVA: 0x00055124 File Offset: 0x00053324
		public override string BuildDatabaseInitializationScript()
		{
			if (this.TransactionContext != null)
			{
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Sql.MigrationStatement> migrationStatements = global::System.Data.Entity.Infrastructure.TransactionContextInitializer<global::System.Data.Entity.Infrastructure.TransactionContext>.GenerateMigrationStatements(this.TransactionContext);
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				global::System.Data.Entity.Migrations.Infrastructure.MigratorScriptingDecorator.BuildSqlScript(migrationStatements, stringBuilder);
				return stringBuilder.ToString();
			}
			return null;
		}

		// Token: 0x06001F01 RID: 7937 RVA: 0x00055158 File Offset: 0x00053358
		public override void BeganTransaction(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.BeginTransactionInterceptionContext interceptionContext)
		{
			if (this.TransactionContext == null || !this.MatchesParentContext(connection, interceptionContext) || interceptionContext.Result == null)
			{
				return;
			}
			global::System.Guid transactionId = global::System.Guid.NewGuid();
			bool flag = false;
			bool flag2 = false;
			global::System.Data.Entity.Core.Objects.ObjectContext objectContext = ((global::System.Data.Entity.Infrastructure.IObjectContextAdapter)this.TransactionContext).ObjectContext;
			((global::System.Data.Entity.Core.EntityClient.EntityConnection)objectContext.Connection).UseStoreTransaction(interceptionContext.Result);
			while (!flag)
			{
				global::System.Data.Entity.Infrastructure.TransactionRow transactionRow = new global::System.Data.Entity.Infrastructure.TransactionRow
				{
					Id = transactionId,
					CreationTime = global::System.DateTime.Now
				};
				this.Transactions.Add(interceptionContext.Result, transactionRow);
				this.TransactionContext.Transactions.Add(transactionRow);
				try
				{
					objectContext.SaveChangesInternal(global::System.Data.Entity.Core.Objects.SaveOptions.AcceptAllChangesAfterSave, true);
					flag = true;
				}
				catch (global::System.Data.Entity.Core.UpdateException)
				{
					this.Transactions.Remove(interceptionContext.Result);
					this.TransactionContext.Entry<global::System.Data.Entity.Infrastructure.TransactionRow>(transactionRow).State = global::System.Data.Entity.EntityState.Detached;
					if (flag2)
					{
						throw;
					}
					try
					{
						if (this.TransactionContext.Transactions.AsNoTracking<global::System.Data.Entity.Infrastructure.TransactionRow>().WithExecutionStrategy(new global::System.Data.Entity.Infrastructure.DefaultExecutionStrategy()).FirstOrDefault((global::System.Data.Entity.Infrastructure.TransactionRow t) => t.Id == transactionId) == null)
						{
							throw;
						}
						transactionId = global::System.Guid.NewGuid();
					}
					catch (global::System.Data.Entity.Core.EntityCommandExecutionException)
					{
						this.TransactionContext.Database.Initialize(true);
						flag2 = true;
					}
				}
			}
		}

		// Token: 0x06001F02 RID: 7938 RVA: 0x0005531C File Offset: 0x0005351C
		public override void Committed(global::System.Data.Common.DbTransaction transaction, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext interceptionContext)
		{
			global::System.Data.Entity.Infrastructure.TransactionRow transactionRow;
			if (this.TransactionContext == null || (interceptionContext.Connection != null && !this.MatchesParentContext(interceptionContext.Connection, interceptionContext)) || !this.Transactions.TryGetValue(transaction, out transactionRow))
			{
				return;
			}
			this.Transactions.Remove(transaction);
			if (interceptionContext.Exception == null)
			{
				this.PruneTransactionHistory(transactionRow);
				return;
			}
			global::System.Data.Entity.Infrastructure.TransactionRow transactionRow2 = null;
			bool suspended = global::System.Data.Entity.Infrastructure.DbExecutionStrategy.Suspended;
			try
			{
				global::System.Data.Entity.Infrastructure.DbExecutionStrategy.Suspended = false;
				global::System.Data.Entity.Infrastructure.IDbExecutionStrategy executionStrategy = this.GetExecutionStrategy() ?? global::System.Data.Entity.Core.Common.DbProviderServices.GetExecutionStrategy(interceptionContext.Connection);
				transactionRow2 = this.TransactionContext.Transactions.AsNoTracking<global::System.Data.Entity.Infrastructure.TransactionRow>().WithExecutionStrategy(executionStrategy).SingleOrDefault((global::System.Data.Entity.Infrastructure.TransactionRow t) => t.Id == transactionRow.Id);
			}
			catch (global::System.Data.Entity.Core.EntityCommandExecutionException)
			{
			}
			finally
			{
				global::System.Data.Entity.Infrastructure.DbExecutionStrategy.Suspended = suspended;
			}
			if (transactionRow2 != null)
			{
				interceptionContext.Exception = null;
				this.PruneTransactionHistory(transactionRow);
				return;
			}
			this.TransactionContext.Entry<global::System.Data.Entity.Infrastructure.TransactionRow>(transactionRow).State = global::System.Data.Entity.EntityState.Detached;
		}

		// Token: 0x06001F03 RID: 7939 RVA: 0x000554A4 File Offset: 0x000536A4
		public override void RolledBack(global::System.Data.Common.DbTransaction transaction, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext interceptionContext)
		{
			global::System.Data.Entity.Infrastructure.TransactionRow entity;
			if (this.TransactionContext == null || (interceptionContext.Connection != null && !this.MatchesParentContext(interceptionContext.Connection, interceptionContext)) || !this.Transactions.TryGetValue(transaction, out entity))
			{
				return;
			}
			this.Transactions.Remove(transaction);
			this.TransactionContext.Entry<global::System.Data.Entity.Infrastructure.TransactionRow>(entity).State = global::System.Data.Entity.EntityState.Detached;
		}

		// Token: 0x06001F04 RID: 7940 RVA: 0x00055500 File Offset: 0x00053700
		public override void Disposed(global::System.Data.Common.DbTransaction transaction, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext interceptionContext)
		{
			this.RolledBack(transaction, interceptionContext);
		}

		// Token: 0x06001F05 RID: 7941 RVA: 0x0005550C File Offset: 0x0005370C
		public virtual void ClearTransactionHistory()
		{
			foreach (global::System.Data.Entity.Infrastructure.TransactionRow transaction in this.TransactionContext.Transactions)
			{
				this.MarkTransactionForPruning(transaction);
			}
			this.PruneTransactionHistory(true, true);
		}

		// Token: 0x06001F06 RID: 7942 RVA: 0x00055568 File Offset: 0x00053768
		public global::System.Threading.Tasks.Task ClearTransactionHistoryAsync()
		{
			return this.ClearTransactionHistoryAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001F07 RID: 7943 RVA: 0x00055578 File Offset: 0x00053778
		public virtual async global::System.Threading.Tasks.Task ClearTransactionHistoryAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			await this.TransactionContext.Transactions.ForEachAsync(new global::System.Action<global::System.Data.Entity.Infrastructure.TransactionRow>(this.MarkTransactionForPruning), cancellationToken).WithCurrentCulture();
			await this.PruneTransactionHistoryAsync(true, true, cancellationToken).WithCurrentCulture();
		}

		// Token: 0x06001F08 RID: 7944 RVA: 0x000555C5 File Offset: 0x000537C5
		protected virtual void MarkTransactionForPruning(global::System.Data.Entity.Infrastructure.TransactionRow transaction)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.TransactionRow>(transaction, "transaction");
			if (!this._rowsToDelete.Contains(transaction))
			{
				this._rowsToDelete.Add(transaction);
			}
		}

		// Token: 0x06001F09 RID: 7945 RVA: 0x000555EE File Offset: 0x000537EE
		public void PruneTransactionHistory()
		{
			this.PruneTransactionHistory(true, true);
		}

		// Token: 0x06001F0A RID: 7946 RVA: 0x000555F8 File Offset: 0x000537F8
		public global::System.Threading.Tasks.Task PruneTransactionHistoryAsync()
		{
			return this.PruneTransactionHistoryAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001F0B RID: 7947 RVA: 0x00055605 File Offset: 0x00053805
		public global::System.Threading.Tasks.Task PruneTransactionHistoryAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			return this.PruneTransactionHistoryAsync(true, true, cancellationToken);
		}

		// Token: 0x06001F0C RID: 7948 RVA: 0x00055610 File Offset: 0x00053810
		protected virtual void PruneTransactionHistory(bool force, bool useExecutionStrategy)
		{
			if (this._rowsToDelete.Count > 0 && (force || this._rowsToDelete.Count > this.PruningLimit))
			{
				foreach (global::System.Data.Entity.Infrastructure.TransactionRow transactionRow in this.TransactionContext.Transactions.ToList<global::System.Data.Entity.Infrastructure.TransactionRow>())
				{
					if (this._rowsToDelete.Contains(transactionRow))
					{
						this.TransactionContext.Transactions.Remove(transactionRow);
					}
				}
				global::System.Data.Entity.Core.Objects.ObjectContext objectContext = ((global::System.Data.Entity.Infrastructure.IObjectContextAdapter)this.TransactionContext).ObjectContext;
				try
				{
					objectContext.SaveChangesInternal(global::System.Data.Entity.Core.Objects.SaveOptions.None, !useExecutionStrategy);
					this._rowsToDelete.Clear();
				}
				finally
				{
					objectContext.AcceptAllChanges();
				}
			}
		}

		// Token: 0x06001F0D RID: 7949 RVA: 0x000556E8 File Offset: 0x000538E8
		protected virtual async global::System.Threading.Tasks.Task PruneTransactionHistoryAsync(bool force, bool useExecutionStrategy, global::System.Threading.CancellationToken cancellationToken)
		{
			if (this._rowsToDelete.Count > 0 && (force || this._rowsToDelete.Count > this.PruningLimit))
			{
				foreach (global::System.Data.Entity.Infrastructure.TransactionRow transactionRow in this.TransactionContext.Transactions.ToList<global::System.Data.Entity.Infrastructure.TransactionRow>())
				{
					if (this._rowsToDelete.Contains(transactionRow))
					{
						this.TransactionContext.Transactions.Remove(transactionRow);
					}
				}
				global::System.Data.Entity.Core.Objects.ObjectContext objectContext = ((global::System.Data.Entity.Infrastructure.IObjectContextAdapter)this.TransactionContext).ObjectContext;
				try
				{
					await((global::System.Data.Entity.Infrastructure.IObjectContextAdapter)this.TransactionContext).ObjectContext.SaveChangesInternalAsync(global::System.Data.Entity.Core.Objects.SaveOptions.None, !useExecutionStrategy, cancellationToken).WithCurrentCulture<int>();
					this._rowsToDelete.Clear();
				}
				finally
				{
					objectContext.AcceptAllChanges();
				}
				objectContext = null;
			}
		}

		// Token: 0x06001F0E RID: 7950 RVA: 0x00055748 File Offset: 0x00053948
		private void PruneTransactionHistory(global::System.Data.Entity.Infrastructure.TransactionRow transaction)
		{
			this.MarkTransactionForPruning(transaction);
			try
			{
				this.PruneTransactionHistory(false, false);
			}
			catch (global::System.Data.DataException)
			{
			}
		}

		// Token: 0x06001F0F RID: 7951 RVA: 0x0005577C File Offset: 0x0005397C
		public static global::System.Data.Entity.Infrastructure.CommitFailureHandler FromContext(global::System.Data.Entity.DbContext context)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.DbContext>(context, "context");
			return global::System.Data.Entity.Infrastructure.CommitFailureHandler.FromContext(((global::System.Data.Entity.Infrastructure.IObjectContextAdapter)context).ObjectContext);
		}

		// Token: 0x06001F10 RID: 7952 RVA: 0x00055795 File Offset: 0x00053995
		public static global::System.Data.Entity.Infrastructure.CommitFailureHandler FromContext(global::System.Data.Entity.Core.Objects.ObjectContext context)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Objects.ObjectContext>(context, "context");
			return context.TransactionHandler as global::System.Data.Entity.Infrastructure.CommitFailureHandler;
		}

		// Token: 0x04000B41 RID: 2881
		private readonly global::System.Collections.Generic.HashSet<global::System.Data.Entity.Infrastructure.TransactionRow> _rowsToDelete = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Infrastructure.TransactionRow>();

		// Token: 0x04000B42 RID: 2882
		private readonly global::System.Func<global::System.Data.Common.DbConnection, global::System.Data.Entity.Infrastructure.TransactionContext> _transactionContextFactory;
	}
}
