using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x02000228 RID: 552
	public abstract class DbExecutionStrategy : global::System.Data.Entity.Infrastructure.IDbExecutionStrategy
	{
		// Token: 0x06001D08 RID: 7432 RVA: 0x00051D0A File Offset: 0x0004FF0A
		protected DbExecutionStrategy() : this(5, global::System.Data.Entity.Infrastructure.DbExecutionStrategy.DefaultMaxDelay)
		{
		}

		// Token: 0x06001D09 RID: 7433 RVA: 0x00051D18 File Offset: 0x0004FF18
		protected DbExecutionStrategy(int maxRetryCount, global::System.TimeSpan maxDelay)
		{
			if (maxRetryCount < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("maxRetryCount");
			}
			if (maxDelay.TotalMilliseconds < 0.0)
			{
				throw new global::System.ArgumentOutOfRangeException("maxDelay");
			}
			this._maxRetryCount = maxRetryCount;
			this._maxDelay = maxDelay;
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06001D0A RID: 7434 RVA: 0x00051D7B File Offset: 0x0004FF7B
		public bool RetriesOnFailure
		{
			get
			{
				return !global::System.Data.Entity.Infrastructure.DbExecutionStrategy.Suspended;
			}
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06001D0B RID: 7435 RVA: 0x00051D88 File Offset: 0x0004FF88
		// (set) Token: 0x06001D0C RID: 7436 RVA: 0x00051DAC File Offset: 0x0004FFAC
		protected internal static bool Suspended
		{
			get
			{
				return ((bool?)global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("ExecutionStrategySuspended")).GetValueOrDefault();
			}
			set
			{
				global::System.Runtime.Remoting.Messaging.CallContext.LogicalSetData("ExecutionStrategySuspended", value);
			}
		}

		// Token: 0x06001D0D RID: 7437 RVA: 0x00051DC0 File Offset: 0x0004FFC0
		public void Execute(global::System.Action operation)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Action>(operation, "operation");
			this.Execute<object>(delegate()
			{
				operation();
				return null;
			});
		}

		// Token: 0x06001D0E RID: 7438 RVA: 0x00051E00 File Offset: 0x00050000
		public TResult Execute<TResult>(global::System.Func<TResult> operation)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<TResult>>(operation, "operation");
			if (this.RetriesOnFailure)
			{
				this.EnsurePreexecutionState();
				global::System.TimeSpan? nextDelay;
				for (;;)
				{
					try
					{
						global::System.Data.Entity.Infrastructure.DbExecutionStrategy.Suspended = true;
						return operation();
					}
					catch (global::System.Exception ex)
					{
						if (!global::System.Data.Entity.Infrastructure.DbExecutionStrategy.UnwrapAndHandleException<bool>(ex, new global::System.Func<global::System.Exception, bool>(this.ShouldRetryOn)))
						{
							throw;
						}
						nextDelay = this.GetNextDelay(ex);
						if (nextDelay == null)
						{
							throw new global::System.Data.Entity.Infrastructure.RetryLimitExceededException(global::System.Data.Entity.Resources.Strings.ExecutionStrategy_RetryLimitExceeded(this._maxRetryCount, base.GetType().Name), ex);
						}
					}
					finally
					{
						global::System.Data.Entity.Infrastructure.DbExecutionStrategy.Suspended = false;
					}
					if (nextDelay < global::System.TimeSpan.Zero)
					{
						break;
					}
					global::System.Threading.Thread.Sleep(nextDelay.Value);
				}
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ExecutionStrategy_NegativeDelay(nextDelay));
			}
			return operation();
		}

		// Token: 0x06001D0F RID: 7439 RVA: 0x00051EFC File Offset: 0x000500FC
		public global::System.Threading.Tasks.Task ExecuteAsync(global::System.Func<global::System.Threading.Tasks.Task> operation, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Infrastructure.DbExecutionStrategy.<>c__DisplayClass19_0 CS$<>8__locals1 = new global::System.Data.Entity.Infrastructure.DbExecutionStrategy.<>c__DisplayClass19_0();
			CS$<>8__locals1.operation = operation;
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Threading.Tasks.Task>>(CS$<>8__locals1.operation, "operation");
			if (this.RetriesOnFailure)
			{
				this.EnsurePreexecutionState();
			}
			cancellationToken.ThrowIfCancellationRequested();
			return this.ProtectedExecuteAsync<bool>(delegate
			{
				global::System.Data.Entity.Infrastructure.DbExecutionStrategy.<>c__DisplayClass19_0.<<ExecuteAsync>b__0>d <<ExecuteAsync>b__0>d;
				<<ExecuteAsync>b__0>d.<>4__this = CS$<>8__locals1;
				<<ExecuteAsync>b__0>d.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool>.Create();
				<<ExecuteAsync>b__0>d.<>1__state = -1;
				global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool> <>t__builder = <<ExecuteAsync>b__0>d.<>t__builder;
				<>t__builder.Start<global::System.Data.Entity.Infrastructure.DbExecutionStrategy.<>c__DisplayClass19_0.<<ExecuteAsync>b__0>d>(ref <<ExecuteAsync>b__0>d);
				return <<ExecuteAsync>b__0>d.<>t__builder.Task;
			}, cancellationToken);
		}

		// Token: 0x06001D10 RID: 7440 RVA: 0x00051F4F File Offset: 0x0005014F
		public global::System.Threading.Tasks.Task<TResult> ExecuteAsync<TResult>(global::System.Func<global::System.Threading.Tasks.Task<TResult>> operation, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Threading.Tasks.Task<TResult>>>(operation, "operation");
			if (this.RetriesOnFailure)
			{
				this.EnsurePreexecutionState();
			}
			cancellationToken.ThrowIfCancellationRequested();
			return this.ProtectedExecuteAsync<TResult>(operation, cancellationToken);
		}

		// Token: 0x06001D11 RID: 7441 RVA: 0x00051F7C File Offset: 0x0005017C
		private async global::System.Threading.Tasks.Task<TResult> ProtectedExecuteAsync<TResult>(global::System.Func<global::System.Threading.Tasks.Task<TResult>> operation, global::System.Threading.CancellationToken cancellationToken)
		{
			if (this.RetriesOnFailure)
			{
				global::System.TimeSpan? nextDelay;
				for (;;)
				{
					try
					{
						global::System.Data.Entity.Infrastructure.DbExecutionStrategy.Suspended = true;
						return await operation().WithCurrentCulture<TResult>();
					}
					catch (global::System.Exception ex)
					{
						if (!global::System.Data.Entity.Infrastructure.DbExecutionStrategy.UnwrapAndHandleException<bool>(ex, new global::System.Func<global::System.Exception, bool>(this.ShouldRetryOn)))
						{
							throw;
						}
						nextDelay = this.GetNextDelay(ex);
						if (nextDelay == null)
						{
							throw new global::System.Data.Entity.Infrastructure.RetryLimitExceededException(global::System.Data.Entity.Resources.Strings.ExecutionStrategy_RetryLimitExceeded(this._maxRetryCount, base.GetType().Name), ex);
						}
					}
					finally
					{
						global::System.Data.Entity.Infrastructure.DbExecutionStrategy.Suspended = false;
					}
					if (nextDelay < global::System.TimeSpan.Zero)
					{
						break;
					}
					await global::System.Threading.Tasks.Task.Delay(nextDelay.Value, cancellationToken).WithCurrentCulture();
				}
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ExecutionStrategy_NegativeDelay(nextDelay));
			}
			return await operation().WithCurrentCulture<TResult>();
		}

		// Token: 0x06001D12 RID: 7442 RVA: 0x00051FD1 File Offset: 0x000501D1
		private void EnsurePreexecutionState()
		{
			if (global::System.Transactions.Transaction.Current != null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ExecutionStrategy_ExistingTransaction(base.GetType().Name));
			}
			this._exceptionsEncountered.Clear();
		}

		// Token: 0x06001D13 RID: 7443 RVA: 0x00052004 File Offset: 0x00050204
		protected internal virtual global::System.TimeSpan? GetNextDelay(global::System.Exception lastException)
		{
			this._exceptionsEncountered.Add(lastException);
			int num = this._exceptionsEncountered.Count - 1;
			if (num < this._maxRetryCount)
			{
				double num2 = (global::System.Math.Pow(2.0, (double)num) - 1.0) * (1.0 + this._random.NextDouble() * 0.10000000000000009);
				return new global::System.TimeSpan?(global::System.TimeSpan.FromMilliseconds(global::System.Math.Min(global::System.Data.Entity.Infrastructure.DbExecutionStrategy.DefaultCoefficient.TotalMilliseconds * num2, this._maxDelay.TotalMilliseconds)));
			}
			return null;
		}

		// Token: 0x06001D14 RID: 7444 RVA: 0x000520A8 File Offset: 0x000502A8
		public static T UnwrapAndHandleException<T>(global::System.Exception exception, global::System.Func<global::System.Exception, T> exceptionHandler)
		{
			global::System.Data.Entity.Core.EntityException ex = exception as global::System.Data.Entity.Core.EntityException;
			if (ex != null)
			{
				return global::System.Data.Entity.Infrastructure.DbExecutionStrategy.UnwrapAndHandleException<T>(ex.InnerException, exceptionHandler);
			}
			global::System.Data.Entity.Infrastructure.DbUpdateException ex2 = exception as global::System.Data.Entity.Infrastructure.DbUpdateException;
			if (ex2 != null)
			{
				return global::System.Data.Entity.Infrastructure.DbExecutionStrategy.UnwrapAndHandleException<T>(ex2.InnerException, exceptionHandler);
			}
			global::System.Data.Entity.Core.UpdateException ex3 = exception as global::System.Data.Entity.Core.UpdateException;
			if (ex3 != null)
			{
				return global::System.Data.Entity.Infrastructure.DbExecutionStrategy.UnwrapAndHandleException<T>(ex3.InnerException, exceptionHandler);
			}
			return exceptionHandler(exception);
		}

		// Token: 0x06001D15 RID: 7445
		protected internal abstract bool ShouldRetryOn(global::System.Exception exception);

		// Token: 0x04000B12 RID: 2834
		private readonly global::System.Collections.Generic.List<global::System.Exception> _exceptionsEncountered = new global::System.Collections.Generic.List<global::System.Exception>();

		// Token: 0x04000B13 RID: 2835
		private readonly global::System.Random _random = new global::System.Random();

		// Token: 0x04000B14 RID: 2836
		private readonly int _maxRetryCount;

		// Token: 0x04000B15 RID: 2837
		private readonly global::System.TimeSpan _maxDelay;

		// Token: 0x04000B16 RID: 2838
		private const string ContextName = "ExecutionStrategySuspended";

		// Token: 0x04000B17 RID: 2839
		private const int DefaultMaxRetryCount = 5;

		// Token: 0x04000B18 RID: 2840
		private const double DefaultRandomFactor = 1.1;

		// Token: 0x04000B19 RID: 2841
		private const double DefaultExponentialBase = 2.0;

		// Token: 0x04000B1A RID: 2842
		private static readonly global::System.TimeSpan DefaultCoefficient = global::System.TimeSpan.FromSeconds(1.0);

		// Token: 0x04000B1B RID: 2843
		private static readonly global::System.TimeSpan DefaultMaxDelay = global::System.TimeSpan.FromSeconds(30.0);
	}
}
