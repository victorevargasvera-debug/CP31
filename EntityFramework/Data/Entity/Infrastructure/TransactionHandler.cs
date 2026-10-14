using System;
using System.Data.Common;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x02000266 RID: 614
	public abstract class TransactionHandler : global::System.Data.Entity.Infrastructure.Interception.IDbTransactionInterceptor, global::System.Data.Entity.Infrastructure.Interception.IDbInterceptor, global::System.Data.Entity.Infrastructure.Interception.IDbConnectionInterceptor, global::System.IDisposable
	{
		// Token: 0x06001F1B RID: 7963 RVA: 0x00055A2A File Offset: 0x00053C2A
		protected TransactionHandler()
		{
			global::System.Data.Entity.Infrastructure.Interception.DbInterception.Add(this);
		}

		// Token: 0x06001F1C RID: 7964 RVA: 0x00055A38 File Offset: 0x00053C38
		public virtual void Initialize(global::System.Data.Entity.Core.Objects.ObjectContext context)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Objects.ObjectContext>(context, "context");
			if (this.ObjectContext != null || this.DbContext != null || this.Connection != null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.TransactionHandler_AlreadyInitialized);
			}
			this.ObjectContext = context;
			this.DbContext = context.InterceptionContext.DbContexts.FirstOrDefault<global::System.Data.Entity.DbContext>();
			this.Connection = ((global::System.Data.Entity.Core.EntityClient.EntityConnection)this.ObjectContext.Connection).StoreConnection;
		}

		// Token: 0x06001F1D RID: 7965 RVA: 0x00055AAC File Offset: 0x00053CAC
		public virtual void Initialize(global::System.Data.Entity.DbContext context, global::System.Data.Common.DbConnection connection)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.DbContext>(context, "context");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbConnection>(connection, "connection");
			if (this.ObjectContext != null || this.DbContext != null || this.Connection != null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.TransactionHandler_AlreadyInitialized);
			}
			this.DbContext = context;
			this.Connection = connection;
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x06001F1E RID: 7966 RVA: 0x00055B02 File Offset: 0x00053D02
		// (set) Token: 0x06001F1F RID: 7967 RVA: 0x00055B2B File Offset: 0x00053D2B
		public global::System.Data.Entity.Core.Objects.ObjectContext ObjectContext
		{
			get
			{
				if (this._objectContext == null || !this._objectContext.IsAlive)
				{
					return null;
				}
				return (global::System.Data.Entity.Core.Objects.ObjectContext)this._objectContext.Target;
			}
			private set
			{
				this._objectContext = new global::System.WeakReference(value);
			}
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x06001F20 RID: 7968 RVA: 0x00055B39 File Offset: 0x00053D39
		// (set) Token: 0x06001F21 RID: 7969 RVA: 0x00055B62 File Offset: 0x00053D62
		public global::System.Data.Entity.DbContext DbContext
		{
			get
			{
				if (this._dbContext == null || !this._dbContext.IsAlive)
				{
					return null;
				}
				return (global::System.Data.Entity.DbContext)this._dbContext.Target;
			}
			private set
			{
				this._dbContext = new global::System.WeakReference(value);
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x06001F22 RID: 7970 RVA: 0x00055B70 File Offset: 0x00053D70
		// (set) Token: 0x06001F23 RID: 7971 RVA: 0x00055B99 File Offset: 0x00053D99
		public global::System.Data.Common.DbConnection Connection
		{
			get
			{
				if (this._connection == null || !this._connection.IsAlive)
				{
					return null;
				}
				return (global::System.Data.Common.DbConnection)this._connection.Target;
			}
			private set
			{
				this._connection = new global::System.WeakReference(value);
			}
		}

		// Token: 0x06001F24 RID: 7972 RVA: 0x00055BA7 File Offset: 0x00053DA7
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x06001F25 RID: 7973 RVA: 0x00055BB6 File Offset: 0x00053DB6
		// (set) Token: 0x06001F26 RID: 7974 RVA: 0x00055BBE File Offset: 0x00053DBE
		protected bool IsDisposed { get; set; }

		// Token: 0x06001F27 RID: 7975 RVA: 0x00055BC7 File Offset: 0x00053DC7
		protected virtual void Dispose(bool disposing)
		{
			if (!this.IsDisposed)
			{
				global::System.Data.Entity.Infrastructure.Interception.DbInterception.Remove(this);
				this.IsDisposed = true;
			}
		}

		// Token: 0x06001F28 RID: 7976 RVA: 0x00055BE0 File Offset: 0x00053DE0
		protected internal virtual bool MatchesParentContext(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext interceptionContext)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbConnection>(connection, "connection");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext>(interceptionContext, "interceptionContext");
			return (this.DbContext != null && interceptionContext.DbContexts.Contains(this.DbContext, new global::System.Func<global::System.Data.Entity.DbContext, global::System.Data.Entity.DbContext, bool>(object.ReferenceEquals))) || (this.ObjectContext != null && interceptionContext.ObjectContexts.Contains(this.ObjectContext, new global::System.Func<global::System.Data.Entity.Core.Objects.ObjectContext, global::System.Data.Entity.Core.Objects.ObjectContext, bool>(object.ReferenceEquals))) || (this.Connection != null && !interceptionContext.ObjectContexts.Any<global::System.Data.Entity.Core.Objects.ObjectContext>() && !interceptionContext.DbContexts.Any<global::System.Data.Entity.DbContext>() && connection == this.Connection);
		}

		// Token: 0x06001F29 RID: 7977
		public abstract string BuildDatabaseInitializationScript();

		// Token: 0x06001F2A RID: 7978 RVA: 0x00055C84 File Offset: 0x00053E84
		public virtual void BeginningTransaction(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.BeginTransactionInterceptionContext interceptionContext)
		{
		}

		// Token: 0x06001F2B RID: 7979 RVA: 0x00055C86 File Offset: 0x00053E86
		public virtual void BeganTransaction(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.BeginTransactionInterceptionContext interceptionContext)
		{
		}

		// Token: 0x06001F2C RID: 7980 RVA: 0x00055C88 File Offset: 0x00053E88
		public virtual void Closing(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext interceptionContext)
		{
		}

		// Token: 0x06001F2D RID: 7981 RVA: 0x00055C8A File Offset: 0x00053E8A
		public virtual void Closed(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext interceptionContext)
		{
		}

		// Token: 0x06001F2E RID: 7982 RVA: 0x00055C8C File Offset: 0x00053E8C
		public virtual void ConnectionStringGetting(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<string> interceptionContext)
		{
		}

		// Token: 0x06001F2F RID: 7983 RVA: 0x00055C8E File Offset: 0x00053E8E
		public virtual void ConnectionStringGot(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<string> interceptionContext)
		{
		}

		// Token: 0x06001F30 RID: 7984 RVA: 0x00055C90 File Offset: 0x00053E90
		public virtual void ConnectionStringSetting(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbConnectionPropertyInterceptionContext<string> interceptionContext)
		{
		}

		// Token: 0x06001F31 RID: 7985 RVA: 0x00055C92 File Offset: 0x00053E92
		public virtual void ConnectionStringSet(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbConnectionPropertyInterceptionContext<string> interceptionContext)
		{
		}

		// Token: 0x06001F32 RID: 7986 RVA: 0x00055C94 File Offset: 0x00053E94
		public virtual void ConnectionTimeoutGetting(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<int> interceptionContext)
		{
		}

		// Token: 0x06001F33 RID: 7987 RVA: 0x00055C96 File Offset: 0x00053E96
		public virtual void ConnectionTimeoutGot(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<int> interceptionContext)
		{
		}

		// Token: 0x06001F34 RID: 7988 RVA: 0x00055C98 File Offset: 0x00053E98
		public virtual void DatabaseGetting(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<string> interceptionContext)
		{
		}

		// Token: 0x06001F35 RID: 7989 RVA: 0x00055C9A File Offset: 0x00053E9A
		public virtual void DatabaseGot(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<string> interceptionContext)
		{
		}

		// Token: 0x06001F36 RID: 7990 RVA: 0x00055C9C File Offset: 0x00053E9C
		public virtual void DataSourceGetting(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<string> interceptionContext)
		{
		}

		// Token: 0x06001F37 RID: 7991 RVA: 0x00055C9E File Offset: 0x00053E9E
		public virtual void DataSourceGot(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<string> interceptionContext)
		{
		}

		// Token: 0x06001F38 RID: 7992 RVA: 0x00055CA0 File Offset: 0x00053EA0
		public virtual void Disposing(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext interceptionContext)
		{
		}

		// Token: 0x06001F39 RID: 7993 RVA: 0x00055CA2 File Offset: 0x00053EA2
		public virtual void Disposed(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext interceptionContext)
		{
		}

		// Token: 0x06001F3A RID: 7994 RVA: 0x00055CA4 File Offset: 0x00053EA4
		public virtual void EnlistingTransaction(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.EnlistTransactionInterceptionContext interceptionContext)
		{
		}

		// Token: 0x06001F3B RID: 7995 RVA: 0x00055CA6 File Offset: 0x00053EA6
		public virtual void EnlistedTransaction(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.EnlistTransactionInterceptionContext interceptionContext)
		{
		}

		// Token: 0x06001F3C RID: 7996 RVA: 0x00055CA8 File Offset: 0x00053EA8
		public virtual void Opening(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext interceptionContext)
		{
		}

		// Token: 0x06001F3D RID: 7997 RVA: 0x00055CAA File Offset: 0x00053EAA
		public virtual void Opened(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext interceptionContext)
		{
		}

		// Token: 0x06001F3E RID: 7998 RVA: 0x00055CAC File Offset: 0x00053EAC
		public virtual void ServerVersionGetting(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<string> interceptionContext)
		{
		}

		// Token: 0x06001F3F RID: 7999 RVA: 0x00055CAE File Offset: 0x00053EAE
		public virtual void ServerVersionGot(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<string> interceptionContext)
		{
		}

		// Token: 0x06001F40 RID: 8000 RVA: 0x00055CB0 File Offset: 0x00053EB0
		public virtual void StateGetting(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<global::System.Data.ConnectionState> interceptionContext)
		{
		}

		// Token: 0x06001F41 RID: 8001 RVA: 0x00055CB2 File Offset: 0x00053EB2
		public virtual void StateGot(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<global::System.Data.ConnectionState> interceptionContext)
		{
		}

		// Token: 0x06001F42 RID: 8002 RVA: 0x00055CB4 File Offset: 0x00053EB4
		public virtual void ConnectionGetting(global::System.Data.Common.DbTransaction transaction, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext<global::System.Data.Common.DbConnection> interceptionContext)
		{
		}

		// Token: 0x06001F43 RID: 8003 RVA: 0x00055CB6 File Offset: 0x00053EB6
		public virtual void ConnectionGot(global::System.Data.Common.DbTransaction transaction, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext<global::System.Data.Common.DbConnection> interceptionContext)
		{
		}

		// Token: 0x06001F44 RID: 8004 RVA: 0x00055CB8 File Offset: 0x00053EB8
		public virtual void IsolationLevelGetting(global::System.Data.Common.DbTransaction transaction, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext<global::System.Data.IsolationLevel> interceptionContext)
		{
		}

		// Token: 0x06001F45 RID: 8005 RVA: 0x00055CBA File Offset: 0x00053EBA
		public virtual void IsolationLevelGot(global::System.Data.Common.DbTransaction transaction, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext<global::System.Data.IsolationLevel> interceptionContext)
		{
		}

		// Token: 0x06001F46 RID: 8006 RVA: 0x00055CBC File Offset: 0x00053EBC
		public virtual void Committing(global::System.Data.Common.DbTransaction transaction, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext interceptionContext)
		{
		}

		// Token: 0x06001F47 RID: 8007 RVA: 0x00055CBE File Offset: 0x00053EBE
		public virtual void Committed(global::System.Data.Common.DbTransaction transaction, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext interceptionContext)
		{
		}

		// Token: 0x06001F48 RID: 8008 RVA: 0x00055CC0 File Offset: 0x00053EC0
		public virtual void Disposing(global::System.Data.Common.DbTransaction transaction, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext interceptionContext)
		{
		}

		// Token: 0x06001F49 RID: 8009 RVA: 0x00055CC2 File Offset: 0x00053EC2
		public virtual void Disposed(global::System.Data.Common.DbTransaction transaction, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext interceptionContext)
		{
		}

		// Token: 0x06001F4A RID: 8010 RVA: 0x00055CC4 File Offset: 0x00053EC4
		public virtual void RollingBack(global::System.Data.Common.DbTransaction transaction, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext interceptionContext)
		{
		}

		// Token: 0x06001F4B RID: 8011 RVA: 0x00055CC6 File Offset: 0x00053EC6
		public virtual void RolledBack(global::System.Data.Common.DbTransaction transaction, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext interceptionContext)
		{
		}

		// Token: 0x04000B47 RID: 2887
		private global::System.WeakReference _objectContext;

		// Token: 0x04000B48 RID: 2888
		private global::System.WeakReference _dbContext;

		// Token: 0x04000B49 RID: 2889
		private global::System.WeakReference _connection;
	}
}
