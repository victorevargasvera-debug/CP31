using System;
using System.ComponentModel;
using System.Data.Common;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Infrastructure.Interception
{
	// Token: 0x02000287 RID: 647
	public class DbTransactionDispatcher
	{
		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x06002094 RID: 8340 RVA: 0x0005B520 File Offset: 0x00059720
		internal global::System.Data.Entity.Infrastructure.Interception.InternalDispatcher<global::System.Data.Entity.Infrastructure.Interception.IDbTransactionInterceptor> InternalDispatcher
		{
			get
			{
				return this._internalDispatcher;
			}
		}

		// Token: 0x06002095 RID: 8341 RVA: 0x0005B528 File Offset: 0x00059728
		internal DbTransactionDispatcher()
		{
		}

		// Token: 0x06002096 RID: 8342 RVA: 0x0005B53C File Offset: 0x0005973C
		public virtual global::System.Data.Common.DbConnection GetConnection(global::System.Data.Common.DbTransaction transaction, global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext interceptionContext)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbTransaction>(transaction, "transaction");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext>(interceptionContext, "interceptionContext");
			return this.InternalDispatcher.Dispatch<global::System.Data.Common.DbTransaction, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext<global::System.Data.Common.DbConnection>, global::System.Data.Common.DbConnection>(transaction, (global::System.Data.Common.DbTransaction t, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext<global::System.Data.Common.DbConnection> c) => t.Connection, new global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext<global::System.Data.Common.DbConnection>(interceptionContext), delegate(global::System.Data.Entity.Infrastructure.Interception.IDbTransactionInterceptor i, global::System.Data.Common.DbTransaction t, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext<global::System.Data.Common.DbConnection> c)
			{
				i.ConnectionGetting(t, c);
			}, delegate(global::System.Data.Entity.Infrastructure.Interception.IDbTransactionInterceptor i, global::System.Data.Common.DbTransaction t, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext<global::System.Data.Common.DbConnection> c)
			{
				i.ConnectionGot(t, c);
			});
		}

		// Token: 0x06002097 RID: 8343 RVA: 0x0005B5D0 File Offset: 0x000597D0
		public virtual global::System.Data.IsolationLevel GetIsolationLevel(global::System.Data.Common.DbTransaction transaction, global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext interceptionContext)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbTransaction>(transaction, "transaction");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext>(interceptionContext, "interceptionContext");
			return this.InternalDispatcher.Dispatch<global::System.Data.Common.DbTransaction, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext<global::System.Data.IsolationLevel>, global::System.Data.IsolationLevel>(transaction, (global::System.Data.Common.DbTransaction t, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext<global::System.Data.IsolationLevel> c) => t.IsolationLevel, new global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext<global::System.Data.IsolationLevel>(interceptionContext), delegate(global::System.Data.Entity.Infrastructure.Interception.IDbTransactionInterceptor i, global::System.Data.Common.DbTransaction t, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext<global::System.Data.IsolationLevel> c)
			{
				i.IsolationLevelGetting(t, c);
			}, delegate(global::System.Data.Entity.Infrastructure.Interception.IDbTransactionInterceptor i, global::System.Data.Common.DbTransaction t, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext<global::System.Data.IsolationLevel> c)
			{
				i.IsolationLevelGot(t, c);
			});
		}

		// Token: 0x06002098 RID: 8344 RVA: 0x0005B664 File Offset: 0x00059864
		public virtual void Commit(global::System.Data.Common.DbTransaction transaction, global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext interceptionContext)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbTransaction>(transaction, "transaction");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext>(interceptionContext, "interceptionContext");
			this.InternalDispatcher.Dispatch<global::System.Data.Common.DbTransaction, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext>(transaction, delegate(global::System.Data.Common.DbTransaction t, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext c)
			{
				t.Commit();
			}, new global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext(interceptionContext).WithConnection(transaction.Connection), delegate(global::System.Data.Entity.Infrastructure.Interception.IDbTransactionInterceptor i, global::System.Data.Common.DbTransaction t, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext c)
			{
				i.Committing(t, c);
			}, delegate(global::System.Data.Entity.Infrastructure.Interception.IDbTransactionInterceptor i, global::System.Data.Common.DbTransaction t, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext c)
			{
				i.Committed(t, c);
			});
		}

		// Token: 0x06002099 RID: 8345 RVA: 0x0005B704 File Offset: 0x00059904
		public virtual void Dispose(global::System.Data.Common.DbTransaction transaction, global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext interceptionContext)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbTransaction>(transaction, "transaction");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext>(interceptionContext, "interceptionContext");
			global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext dbTransactionInterceptionContext = new global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext(interceptionContext);
			if (transaction.Connection != null)
			{
				dbTransactionInterceptionContext = dbTransactionInterceptionContext.WithConnection(transaction.Connection);
			}
			this.InternalDispatcher.Dispatch<global::System.Data.Common.DbTransaction, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext>(transaction, delegate(global::System.Data.Common.DbTransaction t, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext c)
			{
				t.Dispose();
			}, dbTransactionInterceptionContext, delegate(global::System.Data.Entity.Infrastructure.Interception.IDbTransactionInterceptor i, global::System.Data.Common.DbTransaction t, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext c)
			{
				i.Disposing(t, c);
			}, delegate(global::System.Data.Entity.Infrastructure.Interception.IDbTransactionInterceptor i, global::System.Data.Common.DbTransaction t, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext c)
			{
				i.Disposed(t, c);
			});
		}

		// Token: 0x0600209A RID: 8346 RVA: 0x0005B7B0 File Offset: 0x000599B0
		public virtual void Rollback(global::System.Data.Common.DbTransaction transaction, global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext interceptionContext)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbTransaction>(transaction, "transaction");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext>(interceptionContext, "interceptionContext");
			this.InternalDispatcher.Dispatch<global::System.Data.Common.DbTransaction, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext>(transaction, delegate(global::System.Data.Common.DbTransaction t, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext c)
			{
				t.Rollback();
			}, new global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext(interceptionContext).WithConnection(transaction.Connection), delegate(global::System.Data.Entity.Infrastructure.Interception.IDbTransactionInterceptor i, global::System.Data.Common.DbTransaction t, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext c)
			{
				i.RollingBack(t, c);
			}, delegate(global::System.Data.Entity.Infrastructure.Interception.IDbTransactionInterceptor i, global::System.Data.Common.DbTransaction t, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext c)
			{
				i.RolledBack(t, c);
			});
		}

		// Token: 0x0600209B RID: 8347 RVA: 0x0005B84F File Offset: 0x00059A4F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600209C RID: 8348 RVA: 0x0005B857 File Offset: 0x00059A57
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x0600209D RID: 8349 RVA: 0x0005B860 File Offset: 0x00059A60
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x0600209E RID: 8350 RVA: 0x0005B868 File Offset: 0x00059A68
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000B87 RID: 2951
		private readonly global::System.Data.Entity.Infrastructure.Interception.InternalDispatcher<global::System.Data.Entity.Infrastructure.Interception.IDbTransactionInterceptor> _internalDispatcher = new global::System.Data.Entity.Infrastructure.Interception.InternalDispatcher<global::System.Data.Entity.Infrastructure.Interception.IDbTransactionInterceptor>();
	}
}
