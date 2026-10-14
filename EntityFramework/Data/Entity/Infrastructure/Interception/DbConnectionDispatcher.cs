using System;
using System.ComponentModel;
using System.Data.Common;
using System.Data.Entity.Utilities;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity.Infrastructure.Interception
{
	// Token: 0x02000280 RID: 640
	public class DbConnectionDispatcher
	{
		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06002041 RID: 8257 RVA: 0x0005A70F File Offset: 0x0005890F
		internal global::System.Data.Entity.Infrastructure.Interception.InternalDispatcher<global::System.Data.Entity.Infrastructure.Interception.IDbConnectionInterceptor> InternalDispatcher
		{
			get
			{
				return this._internalDispatcher;
			}
		}

		// Token: 0x06002042 RID: 8258 RVA: 0x0005A717 File Offset: 0x00058917
		internal DbConnectionDispatcher()
		{
		}

		// Token: 0x06002043 RID: 8259 RVA: 0x0005A72C File Offset: 0x0005892C
		public virtual global::System.Data.Common.DbTransaction BeginTransaction(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.BeginTransactionInterceptionContext interceptionContext)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbConnection>(connection, "connection");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.BeginTransactionInterceptionContext>(interceptionContext, "interceptionContext");
			return this.InternalDispatcher.Dispatch<global::System.Data.Common.DbConnection, global::System.Data.Entity.Infrastructure.Interception.BeginTransactionInterceptionContext, global::System.Data.Common.DbTransaction>(connection, (global::System.Data.Common.DbConnection t, global::System.Data.Entity.Infrastructure.Interception.BeginTransactionInterceptionContext c) => t.BeginTransaction(c.IsolationLevel), new global::System.Data.Entity.Infrastructure.Interception.BeginTransactionInterceptionContext(interceptionContext), delegate(global::System.Data.Entity.Infrastructure.Interception.IDbConnectionInterceptor i, global::System.Data.Common.DbConnection t, global::System.Data.Entity.Infrastructure.Interception.BeginTransactionInterceptionContext c)
			{
				i.BeginningTransaction(t, c);
			}, delegate(global::System.Data.Entity.Infrastructure.Interception.IDbConnectionInterceptor i, global::System.Data.Common.DbConnection t, global::System.Data.Entity.Infrastructure.Interception.BeginTransactionInterceptionContext c)
			{
				i.BeganTransaction(t, c);
			});
		}

		// Token: 0x06002044 RID: 8260 RVA: 0x0005A7C0 File Offset: 0x000589C0
		public virtual void Close(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext interceptionContext)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbConnection>(connection, "connection");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext>(interceptionContext, "interceptionContext");
			this.InternalDispatcher.Dispatch<global::System.Data.Common.DbConnection, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext>(connection, delegate(global::System.Data.Common.DbConnection t, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext c)
			{
				t.Close();
			}, new global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext(interceptionContext), delegate(global::System.Data.Entity.Infrastructure.Interception.IDbConnectionInterceptor i, global::System.Data.Common.DbConnection t, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext c)
			{
				i.Closing(t, c);
			}, delegate(global::System.Data.Entity.Infrastructure.Interception.IDbConnectionInterceptor i, global::System.Data.Common.DbConnection t, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext c)
			{
				i.Closed(t, c);
			});
		}

		// Token: 0x06002045 RID: 8261 RVA: 0x0005A854 File Offset: 0x00058A54
		public virtual void Dispose(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext interceptionContext)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbConnection>(connection, "connection");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext>(interceptionContext, "interceptionContext");
			this.InternalDispatcher.Dispatch<global::System.Data.Common.DbConnection, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext>(connection, delegate(global::System.Data.Common.DbConnection t, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext c)
			{
				try
				{
				}
				finally
				{
					if (t != null)
					{
						((global::System.IDisposable)t).Dispose();
					}
				}
			}, new global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext(interceptionContext), delegate(global::System.Data.Entity.Infrastructure.Interception.IDbConnectionInterceptor i, global::System.Data.Common.DbConnection t, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext c)
			{
				i.Disposing(t, c);
			}, delegate(global::System.Data.Entity.Infrastructure.Interception.IDbConnectionInterceptor i, global::System.Data.Common.DbConnection t, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext c)
			{
				i.Disposed(t, c);
			});
		}

		// Token: 0x06002046 RID: 8262 RVA: 0x0005A8E8 File Offset: 0x00058AE8
		public virtual string GetConnectionString(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext interceptionContext)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbConnection>(connection, "connection");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext>(interceptionContext, "interceptionContext");
			return this.InternalDispatcher.Dispatch<global::System.Data.Common.DbConnection, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<string>, string>(connection, (global::System.Data.Common.DbConnection t, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<string> c) => t.ConnectionString, new global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<string>(interceptionContext), delegate(global::System.Data.Entity.Infrastructure.Interception.IDbConnectionInterceptor i, global::System.Data.Common.DbConnection t, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<string> c)
			{
				i.ConnectionStringGetting(t, c);
			}, delegate(global::System.Data.Entity.Infrastructure.Interception.IDbConnectionInterceptor i, global::System.Data.Common.DbConnection t, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<string> c)
			{
				i.ConnectionStringGot(t, c);
			});
		}

		// Token: 0x06002047 RID: 8263 RVA: 0x0005A97C File Offset: 0x00058B7C
		public virtual void SetConnectionString(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbConnectionPropertyInterceptionContext<string> interceptionContext)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbConnection>(connection, "connection");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbConnectionPropertyInterceptionContext<string>>(interceptionContext, "interceptionContext");
			this.InternalDispatcher.Dispatch<global::System.Data.Common.DbConnection, global::System.Data.Entity.Infrastructure.Interception.DbConnectionPropertyInterceptionContext<string>>(connection, delegate(global::System.Data.Common.DbConnection t, global::System.Data.Entity.Infrastructure.Interception.DbConnectionPropertyInterceptionContext<string> c)
			{
				t.ConnectionString = c.Value;
			}, new global::System.Data.Entity.Infrastructure.Interception.DbConnectionPropertyInterceptionContext<string>(interceptionContext), delegate(global::System.Data.Entity.Infrastructure.Interception.IDbConnectionInterceptor i, global::System.Data.Common.DbConnection t, global::System.Data.Entity.Infrastructure.Interception.DbConnectionPropertyInterceptionContext<string> c)
			{
				i.ConnectionStringSetting(t, c);
			}, delegate(global::System.Data.Entity.Infrastructure.Interception.IDbConnectionInterceptor i, global::System.Data.Common.DbConnection t, global::System.Data.Entity.Infrastructure.Interception.DbConnectionPropertyInterceptionContext<string> c)
			{
				i.ConnectionStringSet(t, c);
			});
		}

		// Token: 0x06002048 RID: 8264 RVA: 0x0005AA10 File Offset: 0x00058C10
		public virtual int GetConnectionTimeout(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext interceptionContext)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbConnection>(connection, "connection");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext>(interceptionContext, "interceptionContext");
			return this.InternalDispatcher.Dispatch<global::System.Data.Common.DbConnection, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<int>, int>(connection, (global::System.Data.Common.DbConnection t, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<int> c) => t.ConnectionTimeout, new global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<int>(interceptionContext), delegate(global::System.Data.Entity.Infrastructure.Interception.IDbConnectionInterceptor i, global::System.Data.Common.DbConnection t, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<int> c)
			{
				i.ConnectionTimeoutGetting(t, c);
			}, delegate(global::System.Data.Entity.Infrastructure.Interception.IDbConnectionInterceptor i, global::System.Data.Common.DbConnection t, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<int> c)
			{
				i.ConnectionTimeoutGot(t, c);
			});
		}

		// Token: 0x06002049 RID: 8265 RVA: 0x0005AAA4 File Offset: 0x00058CA4
		public virtual string GetDatabase(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext interceptionContext)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbConnection>(connection, "connection");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext>(interceptionContext, "interceptionContext");
			return this.InternalDispatcher.Dispatch<global::System.Data.Common.DbConnection, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<string>, string>(connection, (global::System.Data.Common.DbConnection t, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<string> c) => t.Database, new global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<string>(interceptionContext), delegate(global::System.Data.Entity.Infrastructure.Interception.IDbConnectionInterceptor i, global::System.Data.Common.DbConnection t, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<string> c)
			{
				i.DatabaseGetting(t, c);
			}, delegate(global::System.Data.Entity.Infrastructure.Interception.IDbConnectionInterceptor i, global::System.Data.Common.DbConnection t, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<string> c)
			{
				i.DatabaseGot(t, c);
			});
		}

		// Token: 0x0600204A RID: 8266 RVA: 0x0005AB38 File Offset: 0x00058D38
		public virtual string GetDataSource(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext interceptionContext)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbConnection>(connection, "connection");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext>(interceptionContext, "interceptionContext");
			return this.InternalDispatcher.Dispatch<global::System.Data.Common.DbConnection, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<string>, string>(connection, (global::System.Data.Common.DbConnection t, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<string> c) => t.DataSource, new global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<string>(interceptionContext), delegate(global::System.Data.Entity.Infrastructure.Interception.IDbConnectionInterceptor i, global::System.Data.Common.DbConnection t, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<string> c)
			{
				i.DataSourceGetting(t, c);
			}, delegate(global::System.Data.Entity.Infrastructure.Interception.IDbConnectionInterceptor i, global::System.Data.Common.DbConnection t, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<string> c)
			{
				i.DataSourceGot(t, c);
			});
		}

		// Token: 0x0600204B RID: 8267 RVA: 0x0005ABCC File Offset: 0x00058DCC
		public virtual void EnlistTransaction(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.EnlistTransactionInterceptionContext interceptionContext)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbConnection>(connection, "connection");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.EnlistTransactionInterceptionContext>(interceptionContext, "interceptionContext");
			this.InternalDispatcher.Dispatch<global::System.Data.Common.DbConnection, global::System.Data.Entity.Infrastructure.Interception.EnlistTransactionInterceptionContext>(connection, delegate(global::System.Data.Common.DbConnection t, global::System.Data.Entity.Infrastructure.Interception.EnlistTransactionInterceptionContext c)
			{
				t.EnlistTransaction(c.Transaction);
			}, new global::System.Data.Entity.Infrastructure.Interception.EnlistTransactionInterceptionContext(interceptionContext), delegate(global::System.Data.Entity.Infrastructure.Interception.IDbConnectionInterceptor i, global::System.Data.Common.DbConnection t, global::System.Data.Entity.Infrastructure.Interception.EnlistTransactionInterceptionContext c)
			{
				i.EnlistingTransaction(t, c);
			}, delegate(global::System.Data.Entity.Infrastructure.Interception.IDbConnectionInterceptor i, global::System.Data.Common.DbConnection t, global::System.Data.Entity.Infrastructure.Interception.EnlistTransactionInterceptionContext c)
			{
				i.EnlistedTransaction(t, c);
			});
		}

		// Token: 0x0600204C RID: 8268 RVA: 0x0005AC60 File Offset: 0x00058E60
		public virtual void Open(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext interceptionContext)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbConnection>(connection, "connection");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext>(interceptionContext, "interceptionContext");
			this.InternalDispatcher.Dispatch<global::System.Data.Common.DbConnection, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext>(connection, delegate(global::System.Data.Common.DbConnection t, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext c)
			{
				t.Open();
			}, new global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext(interceptionContext), delegate(global::System.Data.Entity.Infrastructure.Interception.IDbConnectionInterceptor i, global::System.Data.Common.DbConnection t, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext c)
			{
				i.Opening(t, c);
			}, delegate(global::System.Data.Entity.Infrastructure.Interception.IDbConnectionInterceptor i, global::System.Data.Common.DbConnection t, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext c)
			{
				i.Opened(t, c);
			});
		}

		// Token: 0x0600204D RID: 8269 RVA: 0x0005ACF4 File Offset: 0x00058EF4
		public virtual global::System.Threading.Tasks.Task OpenAsync(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext interceptionContext, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbConnection>(connection, "connection");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext>(interceptionContext, "interceptionContext");
			return this.InternalDispatcher.DispatchAsync<global::System.Data.Common.DbConnection, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext>(connection, (global::System.Data.Common.DbConnection t, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext c, global::System.Threading.CancellationToken ct) => t.OpenAsync(ct), new global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext(interceptionContext).AsAsync(), delegate(global::System.Data.Entity.Infrastructure.Interception.IDbConnectionInterceptor i, global::System.Data.Common.DbConnection t, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext c)
			{
				i.Opening(t, c);
			}, delegate(global::System.Data.Entity.Infrastructure.Interception.IDbConnectionInterceptor i, global::System.Data.Common.DbConnection t, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext c)
			{
				i.Opened(t, c);
			}, cancellationToken);
		}

		// Token: 0x0600204E RID: 8270 RVA: 0x0005AD90 File Offset: 0x00058F90
		public virtual string GetServerVersion(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext interceptionContext)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbConnection>(connection, "connection");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext>(interceptionContext, "interceptionContext");
			return this.InternalDispatcher.Dispatch<global::System.Data.Common.DbConnection, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<string>, string>(connection, (global::System.Data.Common.DbConnection t, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<string> c) => t.ServerVersion, new global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<string>(interceptionContext), delegate(global::System.Data.Entity.Infrastructure.Interception.IDbConnectionInterceptor i, global::System.Data.Common.DbConnection t, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<string> c)
			{
				i.ServerVersionGetting(t, c);
			}, delegate(global::System.Data.Entity.Infrastructure.Interception.IDbConnectionInterceptor i, global::System.Data.Common.DbConnection t, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<string> c)
			{
				i.ServerVersionGot(t, c);
			});
		}

		// Token: 0x0600204F RID: 8271 RVA: 0x0005AE24 File Offset: 0x00059024
		public virtual global::System.Data.ConnectionState GetState(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext interceptionContext)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbConnection>(connection, "connection");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext>(interceptionContext, "interceptionContext");
			return this.InternalDispatcher.Dispatch<global::System.Data.Common.DbConnection, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<global::System.Data.ConnectionState>, global::System.Data.ConnectionState>(connection, (global::System.Data.Common.DbConnection t, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<global::System.Data.ConnectionState> c) => t.State, new global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<global::System.Data.ConnectionState>(interceptionContext), delegate(global::System.Data.Entity.Infrastructure.Interception.IDbConnectionInterceptor i, global::System.Data.Common.DbConnection t, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<global::System.Data.ConnectionState> c)
			{
				i.StateGetting(t, c);
			}, delegate(global::System.Data.Entity.Infrastructure.Interception.IDbConnectionInterceptor i, global::System.Data.Common.DbConnection t, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<global::System.Data.ConnectionState> c)
			{
				i.StateGot(t, c);
			});
		}

		// Token: 0x06002050 RID: 8272 RVA: 0x0005AEB8 File Offset: 0x000590B8
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06002051 RID: 8273 RVA: 0x0005AEC0 File Offset: 0x000590C0
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06002052 RID: 8274 RVA: 0x0005AEC9 File Offset: 0x000590C9
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06002053 RID: 8275 RVA: 0x0005AED1 File Offset: 0x000590D1
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000B7B RID: 2939
		private readonly global::System.Data.Entity.Infrastructure.Interception.InternalDispatcher<global::System.Data.Entity.Infrastructure.Interception.IDbConnectionInterceptor> _internalDispatcher = new global::System.Data.Entity.Infrastructure.Interception.InternalDispatcher<global::System.Data.Entity.Infrastructure.Interception.IDbConnectionInterceptor>();
	}
}
