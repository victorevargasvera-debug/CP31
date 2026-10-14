using System;
using System.ComponentModel;
using System.Data.Common;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Data.Entity.Infrastructure.Interception
{
	// Token: 0x02000276 RID: 630
	public class DatabaseLogFormatter : global::System.Data.Entity.Infrastructure.Interception.IDbCommandInterceptor, global::System.Data.Entity.Infrastructure.Interception.IDbInterceptor, global::System.Data.Entity.Infrastructure.Interception.IDbConnectionInterceptor, global::System.Data.Entity.Infrastructure.Interception.IDbTransactionInterceptor
	{
		// Token: 0x06001F9E RID: 8094 RVA: 0x00059244 File Offset: 0x00057444
		public DatabaseLogFormatter(global::System.Action<string> writeAction)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Action<string>>(writeAction, "writeAction");
			this._writeAction = writeAction;
		}

		// Token: 0x06001F9F RID: 8095 RVA: 0x0005926A File Offset: 0x0005746A
		public DatabaseLogFormatter(global::System.Data.Entity.DbContext context, global::System.Action<string> writeAction)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Action<string>>(writeAction, "writeAction");
			this._context = new global::System.WeakReference(context);
			this._writeAction = writeAction;
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x06001FA0 RID: 8096 RVA: 0x0005929C File Offset: 0x0005749C
		protected internal global::System.Data.Entity.DbContext Context
		{
			get
			{
				if (this._context == null || !this._context.IsAlive)
				{
					return null;
				}
				return (global::System.Data.Entity.DbContext)this._context.Target;
			}
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x06001FA1 RID: 8097 RVA: 0x000592C5 File Offset: 0x000574C5
		internal global::System.Action<string> WriteAction
		{
			get
			{
				return this._writeAction;
			}
		}

		// Token: 0x06001FA2 RID: 8098 RVA: 0x000592CD File Offset: 0x000574CD
		protected virtual void Write(string output)
		{
			this._writeAction(output);
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x06001FA3 RID: 8099 RVA: 0x000592DB File Offset: 0x000574DB
		[global::System.Obsolete("This stopwatch can give incorrect times. Use 'GetStopwatch' instead.")]
		protected internal global::System.Diagnostics.Stopwatch Stopwatch
		{
			get
			{
				return this._stopwatch;
			}
		}

		// Token: 0x06001FA4 RID: 8100 RVA: 0x000592E4 File Offset: 0x000574E4
		protected internal global::System.Diagnostics.Stopwatch GetStopwatch(global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext interceptionContext)
		{
			if (this._context != null)
			{
				return this._stopwatch;
			}
			global::System.Data.Entity.Infrastructure.Interception.IDbMutableInterceptionContext dbMutableInterceptionContext = (global::System.Data.Entity.Infrastructure.Interception.IDbMutableInterceptionContext)interceptionContext;
			global::System.Diagnostics.Stopwatch stopwatch = (global::System.Diagnostics.Stopwatch)dbMutableInterceptionContext.MutableData.FindUserState("__LoggingStopwatch__");
			if (stopwatch == null)
			{
				stopwatch = new global::System.Diagnostics.Stopwatch();
				dbMutableInterceptionContext.MutableData.SetUserState("__LoggingStopwatch__", stopwatch);
			}
			return stopwatch;
		}

		// Token: 0x06001FA5 RID: 8101 RVA: 0x00059338 File Offset: 0x00057538
		private void RestartStopwatch(global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext interceptionContext)
		{
			global::System.Diagnostics.Stopwatch stopwatch = this.GetStopwatch(interceptionContext);
			stopwatch.Restart();
			if (stopwatch != this._stopwatch)
			{
				this._stopwatch.Restart();
			}
		}

		// Token: 0x06001FA6 RID: 8102 RVA: 0x0005935A File Offset: 0x0005755A
		private void StopStopwatch(global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext interceptionContext)
		{
			global::System.Diagnostics.Stopwatch stopwatch = this.GetStopwatch(interceptionContext);
			stopwatch.Stop();
			if (stopwatch != this._stopwatch)
			{
				this._stopwatch.Stop();
			}
		}

		// Token: 0x06001FA7 RID: 8103 RVA: 0x0005937C File Offset: 0x0005757C
		public virtual void NonQueryExecuting(global::System.Data.Common.DbCommand command, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<int> interceptionContext)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbCommand>(command, "command");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<int>>(interceptionContext, "interceptionContext");
			this.Executing<int>(command, interceptionContext);
			this.RestartStopwatch(interceptionContext);
		}

		// Token: 0x06001FA8 RID: 8104 RVA: 0x000593A5 File Offset: 0x000575A5
		public virtual void NonQueryExecuted(global::System.Data.Common.DbCommand command, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<int> interceptionContext)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbCommand>(command, "command");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<int>>(interceptionContext, "interceptionContext");
			this.StopStopwatch(interceptionContext);
			this.Executed<int>(command, interceptionContext);
		}

		// Token: 0x06001FA9 RID: 8105 RVA: 0x000593CE File Offset: 0x000575CE
		public virtual void ReaderExecuting(global::System.Data.Common.DbCommand command, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<global::System.Data.Common.DbDataReader> interceptionContext)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbCommand>(command, "command");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<global::System.Data.Common.DbDataReader>>(interceptionContext, "interceptionContext");
			this.Executing<global::System.Data.Common.DbDataReader>(command, interceptionContext);
			this.RestartStopwatch(interceptionContext);
		}

		// Token: 0x06001FAA RID: 8106 RVA: 0x000593F7 File Offset: 0x000575F7
		public virtual void ReaderExecuted(global::System.Data.Common.DbCommand command, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<global::System.Data.Common.DbDataReader> interceptionContext)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbCommand>(command, "command");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<global::System.Data.Common.DbDataReader>>(interceptionContext, "interceptionContext");
			this.StopStopwatch(interceptionContext);
			this.Executed<global::System.Data.Common.DbDataReader>(command, interceptionContext);
		}

		// Token: 0x06001FAB RID: 8107 RVA: 0x00059420 File Offset: 0x00057620
		public virtual void ScalarExecuting(global::System.Data.Common.DbCommand command, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<object> interceptionContext)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbCommand>(command, "command");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<object>>(interceptionContext, "interceptionContext");
			this.Executing<object>(command, interceptionContext);
			this.RestartStopwatch(interceptionContext);
		}

		// Token: 0x06001FAC RID: 8108 RVA: 0x00059449 File Offset: 0x00057649
		public virtual void ScalarExecuted(global::System.Data.Common.DbCommand command, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<object> interceptionContext)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbCommand>(command, "command");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<object>>(interceptionContext, "interceptionContext");
			this.StopStopwatch(interceptionContext);
			this.Executed<object>(command, interceptionContext);
		}

		// Token: 0x06001FAD RID: 8109 RVA: 0x00059474 File Offset: 0x00057674
		public virtual void Executing<TResult>(global::System.Data.Common.DbCommand command, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<TResult> interceptionContext)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbCommand>(command, "command");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<TResult>>(interceptionContext, "interceptionContext");
			if (this.Context == null || interceptionContext.DbContexts.Contains(this.Context, new global::System.Func<global::System.Data.Entity.DbContext, global::System.Data.Entity.DbContext, bool>(object.ReferenceEquals)))
			{
				this.LogCommand<TResult>(command, interceptionContext);
			}
		}

		// Token: 0x06001FAE RID: 8110 RVA: 0x000594C8 File Offset: 0x000576C8
		public virtual void Executed<TResult>(global::System.Data.Common.DbCommand command, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<TResult> interceptionContext)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbCommand>(command, "command");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<TResult>>(interceptionContext, "interceptionContext");
			if (this.Context == null || interceptionContext.DbContexts.Contains(this.Context, new global::System.Func<global::System.Data.Entity.DbContext, global::System.Data.Entity.DbContext, bool>(object.ReferenceEquals)))
			{
				this.LogResult<TResult>(command, interceptionContext);
			}
		}

		// Token: 0x06001FAF RID: 8111 RVA: 0x0005951C File Offset: 0x0005771C
		public virtual void LogCommand<TResult>(global::System.Data.Common.DbCommand command, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<TResult> interceptionContext)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbCommand>(command, "command");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<TResult>>(interceptionContext, "interceptionContext");
			string text = command.CommandText ?? "<null>";
			if (text.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.Ordinal))
			{
				this.Write(text);
			}
			else
			{
				this.Write(text);
				this.Write(global::System.Environment.NewLine);
			}
			if (command.Parameters != null)
			{
				foreach (global::System.Data.Common.DbParameter parameter in command.Parameters.OfType<global::System.Data.Common.DbParameter>())
				{
					this.LogParameter<TResult>(command, interceptionContext, parameter);
				}
			}
			this.Write(interceptionContext.IsAsync ? global::System.Data.Entity.Resources.Strings.CommandLogAsync(global::System.DateTimeOffset.Now, global::System.Environment.NewLine) : global::System.Data.Entity.Resources.Strings.CommandLogNonAsync(global::System.DateTimeOffset.Now, global::System.Environment.NewLine));
		}

		// Token: 0x06001FB0 RID: 8112 RVA: 0x00059604 File Offset: 0x00057804
		public virtual void LogParameter<TResult>(global::System.Data.Common.DbCommand command, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<TResult> interceptionContext, global::System.Data.Common.DbParameter parameter)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbCommand>(command, "command");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<TResult>>(interceptionContext, "interceptionContext");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbParameter>(parameter, "parameter");
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("-- ").Append(parameter.ParameterName).Append(": '").Append((parameter.Value == null || parameter.Value == global::System.DBNull.Value) ? "null" : parameter.Value).Append("' (Type = ").Append(parameter.DbType);
			if (parameter.Direction != global::System.Data.ParameterDirection.Input)
			{
				stringBuilder.Append(", Direction = ").Append(parameter.Direction);
			}
			if (!parameter.IsNullable)
			{
				stringBuilder.Append(", IsNullable = false");
			}
			if (parameter.Size != 0)
			{
				stringBuilder.Append(", Size = ").Append(parameter.Size);
			}
			if (((global::System.Data.IDbDataParameter)parameter).Precision != 0)
			{
				stringBuilder.Append(", Precision = ").Append(((global::System.Data.IDbDataParameter)parameter).Precision);
			}
			if (((global::System.Data.IDbDataParameter)parameter).Scale != 0)
			{
				stringBuilder.Append(", Scale = ").Append(((global::System.Data.IDbDataParameter)parameter).Scale);
			}
			stringBuilder.Append(")").Append(global::System.Environment.NewLine);
			this.Write(stringBuilder.ToString());
		}

		// Token: 0x06001FB1 RID: 8113 RVA: 0x00059758 File Offset: 0x00057958
		public virtual void LogResult<TResult>(global::System.Data.Common.DbCommand command, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<TResult> interceptionContext)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbCommand>(command, "command");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<TResult>>(interceptionContext, "interceptionContext");
			global::System.Diagnostics.Stopwatch stopwatch = this._stopwatch;
			if (this._context == null)
			{
				global::System.Diagnostics.Stopwatch stopwatch2 = (global::System.Diagnostics.Stopwatch)((global::System.Data.Entity.Infrastructure.Interception.IDbMutableInterceptionContext)interceptionContext).MutableData.FindUserState("__LoggingStopwatch__");
				if (stopwatch2 != null)
				{
					stopwatch = stopwatch2;
				}
			}
			if (interceptionContext.Exception != null)
			{
				this.Write(global::System.Data.Entity.Resources.Strings.CommandLogFailed(stopwatch.ElapsedMilliseconds, interceptionContext.Exception.Message, global::System.Environment.NewLine));
			}
			else if (interceptionContext.TaskStatus.HasFlag(global::System.Threading.Tasks.TaskStatus.Canceled))
			{
				this.Write(global::System.Data.Entity.Resources.Strings.CommandLogCanceled(stopwatch.ElapsedMilliseconds, global::System.Environment.NewLine));
			}
			else
			{
				TResult result = interceptionContext.Result;
				string p = (result == null) ? "null" : ((result is global::System.Data.Common.DbDataReader) ? result.GetType().Name : result.ToString());
				this.Write(global::System.Data.Entity.Resources.Strings.CommandLogComplete(stopwatch.ElapsedMilliseconds, p, global::System.Environment.NewLine));
			}
			this.Write(global::System.Environment.NewLine);
		}

		// Token: 0x06001FB2 RID: 8114 RVA: 0x0005987B File Offset: 0x00057A7B
		public virtual void BeginningTransaction(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.BeginTransactionInterceptionContext interceptionContext)
		{
		}

		// Token: 0x06001FB3 RID: 8115 RVA: 0x00059880 File Offset: 0x00057A80
		public virtual void BeganTransaction(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.BeginTransactionInterceptionContext interceptionContext)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbConnection>(connection, "connection");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.BeginTransactionInterceptionContext>(interceptionContext, "interceptionContext");
			if (this.Context == null || interceptionContext.DbContexts.Contains(this.Context, new global::System.Func<global::System.Data.Entity.DbContext, global::System.Data.Entity.DbContext, bool>(object.ReferenceEquals)))
			{
				if (interceptionContext.Exception != null)
				{
					this.Write(global::System.Data.Entity.Resources.Strings.TransactionStartErrorLog(global::System.DateTimeOffset.Now, interceptionContext.Exception.Message, global::System.Environment.NewLine));
					return;
				}
				this.Write(global::System.Data.Entity.Resources.Strings.TransactionStartedLog(global::System.DateTimeOffset.Now, global::System.Environment.NewLine));
			}
		}

		// Token: 0x06001FB4 RID: 8116 RVA: 0x00059914 File Offset: 0x00057B14
		public virtual void EnlistingTransaction(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.EnlistTransactionInterceptionContext interceptionContext)
		{
		}

		// Token: 0x06001FB5 RID: 8117 RVA: 0x00059916 File Offset: 0x00057B16
		public virtual void EnlistedTransaction(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.EnlistTransactionInterceptionContext interceptionContext)
		{
		}

		// Token: 0x06001FB6 RID: 8118 RVA: 0x00059918 File Offset: 0x00057B18
		public virtual void Opening(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext interceptionContext)
		{
		}

		// Token: 0x06001FB7 RID: 8119 RVA: 0x0005991C File Offset: 0x00057B1C
		public virtual void Opened(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext interceptionContext)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbConnection>(connection, "connection");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext>(interceptionContext, "interceptionContext");
			if (this.Context == null || interceptionContext.DbContexts.Contains(this.Context, new global::System.Func<global::System.Data.Entity.DbContext, global::System.Data.Entity.DbContext, bool>(object.ReferenceEquals)))
			{
				if (interceptionContext.Exception != null)
				{
					this.Write(interceptionContext.IsAsync ? global::System.Data.Entity.Resources.Strings.ConnectionOpenErrorLogAsync(global::System.DateTimeOffset.Now, interceptionContext.Exception.Message, global::System.Environment.NewLine) : global::System.Data.Entity.Resources.Strings.ConnectionOpenErrorLog(global::System.DateTimeOffset.Now, interceptionContext.Exception.Message, global::System.Environment.NewLine));
					return;
				}
				if (interceptionContext.TaskStatus.HasFlag(global::System.Threading.Tasks.TaskStatus.Canceled))
				{
					this.Write(global::System.Data.Entity.Resources.Strings.ConnectionOpenCanceledLog(global::System.DateTimeOffset.Now, global::System.Environment.NewLine));
					return;
				}
				this.Write(interceptionContext.IsAsync ? global::System.Data.Entity.Resources.Strings.ConnectionOpenedLogAsync(global::System.DateTimeOffset.Now, global::System.Environment.NewLine) : global::System.Data.Entity.Resources.Strings.ConnectionOpenedLog(global::System.DateTimeOffset.Now, global::System.Environment.NewLine));
			}
		}

		// Token: 0x06001FB8 RID: 8120 RVA: 0x00059A2D File Offset: 0x00057C2D
		public virtual void Closing(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext interceptionContext)
		{
		}

		// Token: 0x06001FB9 RID: 8121 RVA: 0x00059A30 File Offset: 0x00057C30
		public virtual void Closed(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext interceptionContext)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbConnection>(connection, "connection");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext>(interceptionContext, "interceptionContext");
			if (this.Context == null || interceptionContext.DbContexts.Contains(this.Context, new global::System.Func<global::System.Data.Entity.DbContext, global::System.Data.Entity.DbContext, bool>(object.ReferenceEquals)))
			{
				if (interceptionContext.Exception != null)
				{
					this.Write(global::System.Data.Entity.Resources.Strings.ConnectionCloseErrorLog(global::System.DateTimeOffset.Now, interceptionContext.Exception.Message, global::System.Environment.NewLine));
					return;
				}
				this.Write(global::System.Data.Entity.Resources.Strings.ConnectionClosedLog(global::System.DateTimeOffset.Now, global::System.Environment.NewLine));
			}
		}

		// Token: 0x06001FBA RID: 8122 RVA: 0x00059AC4 File Offset: 0x00057CC4
		public virtual void ConnectionStringGetting(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<string> interceptionContext)
		{
		}

		// Token: 0x06001FBB RID: 8123 RVA: 0x00059AC6 File Offset: 0x00057CC6
		public virtual void ConnectionStringGot(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<string> interceptionContext)
		{
		}

		// Token: 0x06001FBC RID: 8124 RVA: 0x00059AC8 File Offset: 0x00057CC8
		public virtual void ConnectionStringSetting(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbConnectionPropertyInterceptionContext<string> interceptionContext)
		{
		}

		// Token: 0x06001FBD RID: 8125 RVA: 0x00059ACA File Offset: 0x00057CCA
		public virtual void ConnectionStringSet(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbConnectionPropertyInterceptionContext<string> interceptionContext)
		{
		}

		// Token: 0x06001FBE RID: 8126 RVA: 0x00059ACC File Offset: 0x00057CCC
		public virtual void ConnectionTimeoutGetting(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<int> interceptionContext)
		{
		}

		// Token: 0x06001FBF RID: 8127 RVA: 0x00059ACE File Offset: 0x00057CCE
		public virtual void ConnectionTimeoutGot(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<int> interceptionContext)
		{
		}

		// Token: 0x06001FC0 RID: 8128 RVA: 0x00059AD0 File Offset: 0x00057CD0
		public virtual void DatabaseGetting(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<string> interceptionContext)
		{
		}

		// Token: 0x06001FC1 RID: 8129 RVA: 0x00059AD2 File Offset: 0x00057CD2
		public virtual void DatabaseGot(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<string> interceptionContext)
		{
		}

		// Token: 0x06001FC2 RID: 8130 RVA: 0x00059AD4 File Offset: 0x00057CD4
		public virtual void DataSourceGetting(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<string> interceptionContext)
		{
		}

		// Token: 0x06001FC3 RID: 8131 RVA: 0x00059AD6 File Offset: 0x00057CD6
		public virtual void DataSourceGot(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<string> interceptionContext)
		{
		}

		// Token: 0x06001FC4 RID: 8132 RVA: 0x00059AD8 File Offset: 0x00057CD8
		public virtual void Disposing(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext interceptionContext)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbConnection>(connection, "connection");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext>(interceptionContext, "interceptionContext");
			if ((this.Context == null || interceptionContext.DbContexts.Contains(this.Context, new global::System.Func<global::System.Data.Entity.DbContext, global::System.Data.Entity.DbContext, bool>(object.ReferenceEquals))) && connection.State == global::System.Data.ConnectionState.Open)
			{
				this.Write(global::System.Data.Entity.Resources.Strings.ConnectionDisposedLog(global::System.DateTimeOffset.Now, global::System.Environment.NewLine));
			}
		}

		// Token: 0x06001FC5 RID: 8133 RVA: 0x00059B47 File Offset: 0x00057D47
		public virtual void Disposed(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext interceptionContext)
		{
		}

		// Token: 0x06001FC6 RID: 8134 RVA: 0x00059B49 File Offset: 0x00057D49
		public virtual void ServerVersionGetting(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<string> interceptionContext)
		{
		}

		// Token: 0x06001FC7 RID: 8135 RVA: 0x00059B4B File Offset: 0x00057D4B
		public virtual void ServerVersionGot(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<string> interceptionContext)
		{
		}

		// Token: 0x06001FC8 RID: 8136 RVA: 0x00059B4D File Offset: 0x00057D4D
		public virtual void StateGetting(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<global::System.Data.ConnectionState> interceptionContext)
		{
		}

		// Token: 0x06001FC9 RID: 8137 RVA: 0x00059B4F File Offset: 0x00057D4F
		public virtual void StateGot(global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<global::System.Data.ConnectionState> interceptionContext)
		{
		}

		// Token: 0x06001FCA RID: 8138 RVA: 0x00059B51 File Offset: 0x00057D51
		public virtual void ConnectionGetting(global::System.Data.Common.DbTransaction transaction, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext<global::System.Data.Common.DbConnection> interceptionContext)
		{
		}

		// Token: 0x06001FCB RID: 8139 RVA: 0x00059B53 File Offset: 0x00057D53
		public virtual void ConnectionGot(global::System.Data.Common.DbTransaction transaction, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext<global::System.Data.Common.DbConnection> interceptionContext)
		{
		}

		// Token: 0x06001FCC RID: 8140 RVA: 0x00059B55 File Offset: 0x00057D55
		public virtual void IsolationLevelGetting(global::System.Data.Common.DbTransaction transaction, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext<global::System.Data.IsolationLevel> interceptionContext)
		{
		}

		// Token: 0x06001FCD RID: 8141 RVA: 0x00059B57 File Offset: 0x00057D57
		public virtual void IsolationLevelGot(global::System.Data.Common.DbTransaction transaction, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext<global::System.Data.IsolationLevel> interceptionContext)
		{
		}

		// Token: 0x06001FCE RID: 8142 RVA: 0x00059B59 File Offset: 0x00057D59
		public virtual void Committing(global::System.Data.Common.DbTransaction transaction, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext interceptionContext)
		{
		}

		// Token: 0x06001FCF RID: 8143 RVA: 0x00059B5C File Offset: 0x00057D5C
		public virtual void Committed(global::System.Data.Common.DbTransaction transaction, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext interceptionContext)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbTransaction>(transaction, "transaction");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext>(interceptionContext, "interceptionContext");
			if (this.Context == null || interceptionContext.DbContexts.Contains(this.Context, new global::System.Func<global::System.Data.Entity.DbContext, global::System.Data.Entity.DbContext, bool>(object.ReferenceEquals)))
			{
				if (interceptionContext.Exception != null)
				{
					this.Write(global::System.Data.Entity.Resources.Strings.TransactionCommitErrorLog(global::System.DateTimeOffset.Now, interceptionContext.Exception.Message, global::System.Environment.NewLine));
					return;
				}
				this.Write(global::System.Data.Entity.Resources.Strings.TransactionCommittedLog(global::System.DateTimeOffset.Now, global::System.Environment.NewLine));
			}
		}

		// Token: 0x06001FD0 RID: 8144 RVA: 0x00059BF0 File Offset: 0x00057DF0
		public virtual void Disposing(global::System.Data.Common.DbTransaction transaction, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext interceptionContext)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbTransaction>(transaction, "transaction");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext>(interceptionContext, "interceptionContext");
			if ((this.Context == null || interceptionContext.DbContexts.Contains(this.Context, new global::System.Func<global::System.Data.Entity.DbContext, global::System.Data.Entity.DbContext, bool>(object.ReferenceEquals))) && transaction.Connection != null)
			{
				this.Write(global::System.Data.Entity.Resources.Strings.TransactionDisposedLog(global::System.DateTimeOffset.Now, global::System.Environment.NewLine));
			}
		}

		// Token: 0x06001FD1 RID: 8145 RVA: 0x00059C5E File Offset: 0x00057E5E
		public virtual void Disposed(global::System.Data.Common.DbTransaction transaction, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext interceptionContext)
		{
		}

		// Token: 0x06001FD2 RID: 8146 RVA: 0x00059C60 File Offset: 0x00057E60
		public virtual void RollingBack(global::System.Data.Common.DbTransaction transaction, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext interceptionContext)
		{
		}

		// Token: 0x06001FD3 RID: 8147 RVA: 0x00059C64 File Offset: 0x00057E64
		public virtual void RolledBack(global::System.Data.Common.DbTransaction transaction, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext interceptionContext)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbTransaction>(transaction, "transaction");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext>(interceptionContext, "interceptionContext");
			if (this.Context == null || interceptionContext.DbContexts.Contains(this.Context, new global::System.Func<global::System.Data.Entity.DbContext, global::System.Data.Entity.DbContext, bool>(object.ReferenceEquals)))
			{
				if (interceptionContext.Exception != null)
				{
					this.Write(global::System.Data.Entity.Resources.Strings.TransactionRollbackErrorLog(global::System.DateTimeOffset.Now, interceptionContext.Exception.Message, global::System.Environment.NewLine));
					return;
				}
				this.Write(global::System.Data.Entity.Resources.Strings.TransactionRolledBackLog(global::System.DateTimeOffset.Now, global::System.Environment.NewLine));
			}
		}

		// Token: 0x06001FD4 RID: 8148 RVA: 0x00059CF8 File Offset: 0x00057EF8
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06001FD5 RID: 8149 RVA: 0x00059D00 File Offset: 0x00057F00
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06001FD6 RID: 8150 RVA: 0x00059D09 File Offset: 0x00057F09
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06001FD7 RID: 8151 RVA: 0x00059D11 File Offset: 0x00057F11
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000B6E RID: 2926
		private const string StopwatchStateKey = "__LoggingStopwatch__";

		// Token: 0x04000B6F RID: 2927
		private readonly global::System.WeakReference _context;

		// Token: 0x04000B70 RID: 2928
		private readonly global::System.Action<string> _writeAction;

		// Token: 0x04000B71 RID: 2929
		private readonly global::System.Diagnostics.Stopwatch _stopwatch = new global::System.Diagnostics.Stopwatch();
	}
}
