using System;
using System.Data.Entity.Core;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.SqlServer.Resources;
using System.Data.Entity.SqlServer.Utilities;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity.SqlServer
{
	// Token: 0x02000005 RID: 5
	internal sealed class DefaultSqlExecutionStrategy : global::System.Data.Entity.Infrastructure.IDbExecutionStrategy
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00002338 File Offset: 0x00000538
		public bool RetriesOnFailure
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000233C File Offset: 0x0000053C
		public void Execute(global::System.Action operation)
		{
			if (operation == null)
			{
				throw new global::System.ArgumentNullException("operation");
			}
			this.Execute<object>(delegate()
			{
				operation();
				return null;
			});
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000237C File Offset: 0x0000057C
		public TResult Execute<TResult>(global::System.Func<TResult> operation)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Func<TResult>>(operation, "operation");
			TResult result;
			try
			{
				result = operation();
			}
			catch (global::System.Exception ex)
			{
				if (global::System.Data.Entity.Infrastructure.DbExecutionStrategy.UnwrapAndHandleException<bool>(ex, new global::System.Func<global::System.Exception, bool>(global::System.Data.Entity.SqlServer.SqlAzureRetriableExceptionDetector.ShouldRetryOn)))
				{
					throw new global::System.Data.Entity.Core.EntityException(global::System.Data.Entity.SqlServer.Resources.Strings.TransientExceptionDetected, ex);
				}
				throw;
			}
			return result;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000023D4 File Offset: 0x000005D4
		public global::System.Threading.Tasks.Task ExecuteAsync(global::System.Func<global::System.Threading.Tasks.Task> operation, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.SqlServer.DefaultSqlExecutionStrategy.<>c__DisplayClass4_0 CS$<>8__locals1 = new global::System.Data.Entity.SqlServer.DefaultSqlExecutionStrategy.<>c__DisplayClass4_0();
			CS$<>8__locals1.operation = operation;
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Func<global::System.Threading.Tasks.Task>>(CS$<>8__locals1.operation, "operation");
			cancellationToken.ThrowIfCancellationRequested();
			return global::System.Data.Entity.SqlServer.DefaultSqlExecutionStrategy.ExecuteAsyncImplementation<bool>(delegate
			{
				global::System.Data.Entity.SqlServer.DefaultSqlExecutionStrategy.<>c__DisplayClass4_0.<<ExecuteAsync>b__0>d <<ExecuteAsync>b__0>d;
				<<ExecuteAsync>b__0>d.<>4__this = CS$<>8__locals1;
				<<ExecuteAsync>b__0>d.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool>.Create();
				<<ExecuteAsync>b__0>d.<>1__state = -1;
				global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool> <>t__builder = <<ExecuteAsync>b__0>d.<>t__builder;
				<>t__builder.Start<global::System.Data.Entity.SqlServer.DefaultSqlExecutionStrategy.<>c__DisplayClass4_0.<<ExecuteAsync>b__0>d>(ref <<ExecuteAsync>b__0>d);
				return <<ExecuteAsync>b__0>d.<>t__builder.Task;
			});
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0000240A File Offset: 0x0000060A
		public global::System.Threading.Tasks.Task<TResult> ExecuteAsync<TResult>(global::System.Func<global::System.Threading.Tasks.Task<TResult>> operation, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Func<global::System.Threading.Tasks.Task<TResult>>>(operation, "operation");
			cancellationToken.ThrowIfCancellationRequested();
			return global::System.Data.Entity.SqlServer.DefaultSqlExecutionStrategy.ExecuteAsyncImplementation<TResult>(operation);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002428 File Offset: 0x00000628
		private static async global::System.Threading.Tasks.Task<TResult> ExecuteAsyncImplementation<TResult>(global::System.Func<global::System.Threading.Tasks.Task<TResult>> func)
		{
			TResult result;
			try
			{
				result = await func().ConfigureAwait(false);
			}
			catch (global::System.Exception ex)
			{
				if (global::System.Data.Entity.Infrastructure.DbExecutionStrategy.UnwrapAndHandleException<bool>(ex, new global::System.Func<global::System.Exception, bool>(global::System.Data.Entity.SqlServer.SqlAzureRetriableExceptionDetector.ShouldRetryOn)))
				{
					throw new global::System.Data.Entity.Core.EntityException(global::System.Data.Entity.SqlServer.Resources.Strings.TransientExceptionDetected, ex);
				}
				throw;
			}
			return result;
		}
	}
}
