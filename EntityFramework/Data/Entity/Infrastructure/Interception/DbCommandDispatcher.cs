using System;
using System.ComponentModel;
using System.Data.Common;
using System.Data.Entity.Utilities;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity.Infrastructure.Interception
{
	// Token: 0x02000278 RID: 632
	public class DbCommandDispatcher
	{
		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x06001FE2 RID: 8162 RVA: 0x00059E88 File Offset: 0x00058088
		internal global::System.Data.Entity.Infrastructure.Interception.InternalDispatcher<global::System.Data.Entity.Infrastructure.Interception.IDbCommandInterceptor> InternalDispatcher
		{
			get
			{
				return this._internalDispatcher;
			}
		}

		// Token: 0x06001FE3 RID: 8163 RVA: 0x00059E90 File Offset: 0x00058090
		internal DbCommandDispatcher()
		{
		}

		// Token: 0x06001FE4 RID: 8164 RVA: 0x00059EA4 File Offset: 0x000580A4
		public virtual int NonQuery(global::System.Data.Common.DbCommand command, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext interceptionContext)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbCommand>(command, "command");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext>(interceptionContext, "interceptionContext");
			return this._internalDispatcher.Dispatch<global::System.Data.Common.DbCommand, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<int>, int>(command, (global::System.Data.Common.DbCommand t, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<int> c) => t.ExecuteNonQuery(), new global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<int>(interceptionContext), delegate(global::System.Data.Entity.Infrastructure.Interception.IDbCommandInterceptor i, global::System.Data.Common.DbCommand t, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<int> c)
			{
				i.NonQueryExecuting(t, c);
			}, delegate(global::System.Data.Entity.Infrastructure.Interception.IDbCommandInterceptor i, global::System.Data.Common.DbCommand t, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<int> c)
			{
				i.NonQueryExecuted(t, c);
			});
		}

		// Token: 0x06001FE5 RID: 8165 RVA: 0x00059F38 File Offset: 0x00058138
		public virtual object Scalar(global::System.Data.Common.DbCommand command, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext interceptionContext)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbCommand>(command, "command");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext>(interceptionContext, "interceptionContext");
			return this._internalDispatcher.Dispatch<global::System.Data.Common.DbCommand, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<object>, object>(command, (global::System.Data.Common.DbCommand t, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<object> c) => t.ExecuteScalar(), new global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<object>(interceptionContext), delegate(global::System.Data.Entity.Infrastructure.Interception.IDbCommandInterceptor i, global::System.Data.Common.DbCommand t, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<object> c)
			{
				i.ScalarExecuting(t, c);
			}, delegate(global::System.Data.Entity.Infrastructure.Interception.IDbCommandInterceptor i, global::System.Data.Common.DbCommand t, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<object> c)
			{
				i.ScalarExecuted(t, c);
			});
		}

		// Token: 0x06001FE6 RID: 8166 RVA: 0x00059FCC File Offset: 0x000581CC
		public virtual global::System.Data.Common.DbDataReader Reader(global::System.Data.Common.DbCommand command, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext interceptionContext)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbCommand>(command, "command");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext>(interceptionContext, "interceptionContext");
			return this._internalDispatcher.Dispatch<global::System.Data.Common.DbCommand, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<global::System.Data.Common.DbDataReader>, global::System.Data.Common.DbDataReader>(command, (global::System.Data.Common.DbCommand t, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<global::System.Data.Common.DbDataReader> c) => t.ExecuteReader(c.CommandBehavior), new global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<global::System.Data.Common.DbDataReader>(interceptionContext), delegate(global::System.Data.Entity.Infrastructure.Interception.IDbCommandInterceptor i, global::System.Data.Common.DbCommand t, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<global::System.Data.Common.DbDataReader> c)
			{
				i.ReaderExecuting(t, c);
			}, delegate(global::System.Data.Entity.Infrastructure.Interception.IDbCommandInterceptor i, global::System.Data.Common.DbCommand t, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<global::System.Data.Common.DbDataReader> c)
			{
				i.ReaderExecuted(t, c);
			});
		}

		// Token: 0x06001FE7 RID: 8167 RVA: 0x0005A060 File Offset: 0x00058260
		public virtual global::System.Threading.Tasks.Task<int> NonQueryAsync(global::System.Data.Common.DbCommand command, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext interceptionContext, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbCommand>(command, "command");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext>(interceptionContext, "interceptionContext");
			return this._internalDispatcher.DispatchAsync<global::System.Data.Common.DbCommand, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<int>, int>(command, (global::System.Data.Common.DbCommand t, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<int> c, global::System.Threading.CancellationToken ct) => t.ExecuteNonQueryAsync(ct), new global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<int>(interceptionContext).AsAsync(), delegate(global::System.Data.Entity.Infrastructure.Interception.IDbCommandInterceptor i, global::System.Data.Common.DbCommand t, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<int> c)
			{
				i.NonQueryExecuting(t, c);
			}, delegate(global::System.Data.Entity.Infrastructure.Interception.IDbCommandInterceptor i, global::System.Data.Common.DbCommand t, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<int> c)
			{
				i.NonQueryExecuted(t, c);
			}, cancellationToken);
		}

		// Token: 0x06001FE8 RID: 8168 RVA: 0x0005A0FC File Offset: 0x000582FC
		public virtual global::System.Threading.Tasks.Task<object> ScalarAsync(global::System.Data.Common.DbCommand command, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext interceptionContext, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbCommand>(command, "command");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext>(interceptionContext, "interceptionContext");
			return this._internalDispatcher.DispatchAsync<global::System.Data.Common.DbCommand, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<object>, object>(command, (global::System.Data.Common.DbCommand t, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<object> c, global::System.Threading.CancellationToken ct) => t.ExecuteScalarAsync(ct), new global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<object>(interceptionContext).AsAsync(), delegate(global::System.Data.Entity.Infrastructure.Interception.IDbCommandInterceptor i, global::System.Data.Common.DbCommand t, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<object> c)
			{
				i.ScalarExecuting(t, c);
			}, delegate(global::System.Data.Entity.Infrastructure.Interception.IDbCommandInterceptor i, global::System.Data.Common.DbCommand t, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<object> c)
			{
				i.ScalarExecuted(t, c);
			}, cancellationToken);
		}

		// Token: 0x06001FE9 RID: 8169 RVA: 0x0005A198 File Offset: 0x00058398
		public virtual global::System.Threading.Tasks.Task<global::System.Data.Common.DbDataReader> ReaderAsync(global::System.Data.Common.DbCommand command, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext interceptionContext, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbCommand>(command, "command");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext>(interceptionContext, "interceptionContext");
			return this._internalDispatcher.DispatchAsync<global::System.Data.Common.DbCommand, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<global::System.Data.Common.DbDataReader>, global::System.Data.Common.DbDataReader>(command, (global::System.Data.Common.DbCommand t, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<global::System.Data.Common.DbDataReader> c, global::System.Threading.CancellationToken ct) => t.ExecuteReaderAsync(c.CommandBehavior, ct), new global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<global::System.Data.Common.DbDataReader>(interceptionContext).AsAsync(), delegate(global::System.Data.Entity.Infrastructure.Interception.IDbCommandInterceptor i, global::System.Data.Common.DbCommand t, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<global::System.Data.Common.DbDataReader> c)
			{
				i.ReaderExecuting(t, c);
			}, delegate(global::System.Data.Entity.Infrastructure.Interception.IDbCommandInterceptor i, global::System.Data.Common.DbCommand t, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<global::System.Data.Common.DbDataReader> c)
			{
				i.ReaderExecuted(t, c);
			}, cancellationToken);
		}

		// Token: 0x06001FEA RID: 8170 RVA: 0x0005A232 File Offset: 0x00058432
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06001FEB RID: 8171 RVA: 0x0005A23A File Offset: 0x0005843A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06001FEC RID: 8172 RVA: 0x0005A243 File Offset: 0x00058443
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06001FED RID: 8173 RVA: 0x0005A24B File Offset: 0x0005844B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000B75 RID: 2933
		private readonly global::System.Data.Entity.Infrastructure.Interception.InternalDispatcher<global::System.Data.Entity.Infrastructure.Interception.IDbCommandInterceptor> _internalDispatcher = new global::System.Data.Entity.Infrastructure.Interception.InternalDispatcher<global::System.Data.Entity.Infrastructure.Interception.IDbCommandInterceptor>();
	}
}
