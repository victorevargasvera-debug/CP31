using System;
using System.Collections.Generic;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity.Infrastructure.Interception
{
	// Token: 0x02000297 RID: 663
	internal class InternalDispatcher<TInterceptor> where TInterceptor : class, global::System.Data.Entity.Infrastructure.Interception.IDbInterceptor
	{
		// Token: 0x06002108 RID: 8456 RVA: 0x0005BBFC File Offset: 0x00059DFC
		public void Add(global::System.Data.Entity.Infrastructure.Interception.IDbInterceptor interceptor)
		{
			TInterceptor tinterceptor = interceptor as TInterceptor;
			if (tinterceptor == null)
			{
				return;
			}
			object @lock = this._lock;
			lock (@lock)
			{
				global::System.Collections.Generic.List<TInterceptor> list = this._interceptors.ToList<TInterceptor>();
				list.Add(tinterceptor);
				this._interceptors = list;
			}
		}

		// Token: 0x06002109 RID: 8457 RVA: 0x0005BC6C File Offset: 0x00059E6C
		public void Remove(global::System.Data.Entity.Infrastructure.Interception.IDbInterceptor interceptor)
		{
			TInterceptor tinterceptor = interceptor as TInterceptor;
			if (tinterceptor == null)
			{
				return;
			}
			object @lock = this._lock;
			lock (@lock)
			{
				global::System.Collections.Generic.List<TInterceptor> list = this._interceptors.ToList<TInterceptor>();
				list.Remove(tinterceptor);
				this._interceptors = list;
			}
		}

		// Token: 0x0600210A RID: 8458 RVA: 0x0005BCDC File Offset: 0x00059EDC
		public TResult Dispatch<TResult>(TResult result, global::System.Func<TResult, TInterceptor, TResult> accumulator)
		{
			if (this._interceptors.Count != 0)
			{
				return this._interceptors.Aggregate(result, accumulator);
			}
			return result;
		}

		// Token: 0x0600210B RID: 8459 RVA: 0x0005BCFE File Offset: 0x00059EFE
		public void Dispatch(global::System.Action<TInterceptor> action)
		{
			if (this._interceptors.Count != 0)
			{
				this._interceptors.Each(action);
			}
		}

		// Token: 0x0600210C RID: 8460 RVA: 0x0005BD20 File Offset: 0x00059F20
		public TResult Dispatch<TInterceptionContext, TResult>(TResult result, TInterceptionContext interceptionContext, global::System.Action<TInterceptor, TInterceptionContext> intercept) where TInterceptionContext : global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext, global::System.Data.Entity.Infrastructure.Interception.IDbMutableInterceptionContext<TResult>
		{
			if (this._interceptors.Count == 0)
			{
				return result;
			}
			interceptionContext.MutableData.SetExecuted(result);
			foreach (TInterceptor arg in this._interceptors)
			{
				intercept(arg, interceptionContext);
			}
			if (interceptionContext.MutableData.Exception != null)
			{
				throw interceptionContext.MutableData.Exception;
			}
			return interceptionContext.MutableData.Result;
		}

		// Token: 0x0600210D RID: 8461 RVA: 0x0005BDCC File Offset: 0x00059FCC
		public void Dispatch<TTarget, TInterceptionContext>(TTarget target, global::System.Action<TTarget, TInterceptionContext> operation, TInterceptionContext interceptionContext, global::System.Action<TInterceptor, TTarget, TInterceptionContext> executing, global::System.Action<TInterceptor, TTarget, TInterceptionContext> executed) where TInterceptionContext : global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext, global::System.Data.Entity.Infrastructure.Interception.IDbMutableInterceptionContext
		{
			if (this._interceptors.Count == 0)
			{
				operation(target, interceptionContext);
				return;
			}
			foreach (TInterceptor arg in this._interceptors)
			{
				executing(arg, target, interceptionContext);
			}
			if (!interceptionContext.MutableData.IsExecutionSuppressed)
			{
				try
				{
					operation(target, interceptionContext);
					interceptionContext.MutableData.HasExecuted = true;
				}
				catch (global::System.Exception ex)
				{
					interceptionContext.MutableData.SetExceptionThrown(ex);
					foreach (TInterceptor arg2 in this._interceptors)
					{
						executed(arg2, target, interceptionContext);
					}
					if (interceptionContext.MutableData.Exception == ex)
					{
						throw;
					}
				}
			}
			if (interceptionContext.MutableData.OriginalException == null)
			{
				foreach (TInterceptor arg3 in this._interceptors)
				{
					executed(arg3, target, interceptionContext);
				}
			}
			if (interceptionContext.MutableData.Exception != null)
			{
				throw interceptionContext.MutableData.Exception;
			}
		}

		// Token: 0x0600210E RID: 8462 RVA: 0x0005BF64 File Offset: 0x0005A164
		public TResult Dispatch<TTarget, TInterceptionContext, TResult>(TTarget target, global::System.Func<TTarget, TInterceptionContext, TResult> operation, TInterceptionContext interceptionContext, global::System.Action<TInterceptor, TTarget, TInterceptionContext> executing, global::System.Action<TInterceptor, TTarget, TInterceptionContext> executed) where TInterceptionContext : global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext, global::System.Data.Entity.Infrastructure.Interception.IDbMutableInterceptionContext<TResult>
		{
			if (this._interceptors.Count == 0)
			{
				return operation(target, interceptionContext);
			}
			foreach (TInterceptor arg in this._interceptors)
			{
				executing(arg, target, interceptionContext);
			}
			if (!interceptionContext.MutableData.IsExecutionSuppressed)
			{
				try
				{
					interceptionContext.MutableData.SetExecuted(operation(target, interceptionContext));
				}
				catch (global::System.Exception ex)
				{
					interceptionContext.MutableData.SetExceptionThrown(ex);
					foreach (TInterceptor arg2 in this._interceptors)
					{
						executed(arg2, target, interceptionContext);
					}
					if (interceptionContext.MutableData.Exception == ex)
					{
						throw;
					}
				}
			}
			if (interceptionContext.MutableData.OriginalException == null)
			{
				foreach (TInterceptor arg3 in this._interceptors)
				{
					executed(arg3, target, interceptionContext);
				}
			}
			if (interceptionContext.MutableData.Exception != null)
			{
				throw interceptionContext.MutableData.Exception;
			}
			return interceptionContext.MutableData.Result;
		}

		// Token: 0x0600210F RID: 8463 RVA: 0x0005C10C File Offset: 0x0005A30C
		public global::System.Threading.Tasks.Task DispatchAsync<TTarget, TInterceptionContext>(TTarget target, global::System.Func<TTarget, TInterceptionContext, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task> operation, TInterceptionContext interceptionContext, global::System.Action<TInterceptor, TTarget, TInterceptionContext> executing, global::System.Action<TInterceptor, TTarget, TInterceptionContext> executed, global::System.Threading.CancellationToken cancellationToken) where TInterceptionContext : global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext, global::System.Data.Entity.Infrastructure.Interception.IDbMutableInterceptionContext
		{
			if (this._interceptors.Count == 0)
			{
				return operation(target, interceptionContext, cancellationToken);
			}
			foreach (TInterceptor arg in this._interceptors)
			{
				executing(arg, target, interceptionContext);
			}
			global::System.Threading.Tasks.Task task = interceptionContext.MutableData.IsExecutionSuppressed ? global::System.Threading.Tasks.Task.FromResult<object>(null) : operation(target, interceptionContext, cancellationToken);
			global::System.Threading.Tasks.TaskCompletionSource<object> tcs = new global::System.Threading.Tasks.TaskCompletionSource<object>();
			task.ContinueWith(delegate(global::System.Threading.Tasks.Task t)
			{
				interceptionContext.MutableData.TaskStatus = t.Status;
				if (t.IsFaulted)
				{
					interceptionContext.MutableData.SetExceptionThrown(t.Exception.InnerException);
				}
				else if (!interceptionContext.MutableData.IsExecutionSuppressed)
				{
					interceptionContext.MutableData.HasExecuted = true;
				}
				try
				{
					foreach (TInterceptor arg2 in this._interceptors)
					{
						executed(arg2, target, interceptionContext);
					}
				}
				catch (global::System.Exception exception)
				{
					interceptionContext.MutableData.Exception = exception;
				}
				if (interceptionContext.MutableData.Exception != null)
				{
					tcs.SetException(interceptionContext.MutableData.Exception);
					return;
				}
				if (t.IsCanceled)
				{
					tcs.SetCanceled();
					return;
				}
				tcs.SetResult(null);
			}, global::System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously);
			return tcs.Task;
		}

		// Token: 0x06002110 RID: 8464 RVA: 0x0005C218 File Offset: 0x0005A418
		public global::System.Threading.Tasks.Task<TResult> DispatchAsync<TTarget, TInterceptionContext, TResult>(TTarget target, global::System.Func<TTarget, TInterceptionContext, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<TResult>> operation, TInterceptionContext interceptionContext, global::System.Action<TInterceptor, TTarget, TInterceptionContext> executing, global::System.Action<TInterceptor, TTarget, TInterceptionContext> executed, global::System.Threading.CancellationToken cancellationToken) where TInterceptionContext : global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext, global::System.Data.Entity.Infrastructure.Interception.IDbMutableInterceptionContext<TResult>
		{
			cancellationToken.ThrowIfCancellationRequested();
			if (this._interceptors.Count == 0)
			{
				return operation(target, interceptionContext, cancellationToken);
			}
			foreach (TInterceptor arg in this._interceptors)
			{
				executing(arg, target, interceptionContext);
			}
			global::System.Threading.Tasks.Task<TResult> task = interceptionContext.MutableData.IsExecutionSuppressed ? global::System.Threading.Tasks.Task.FromResult<TResult>(interceptionContext.MutableData.Result) : operation(target, interceptionContext, cancellationToken);
			global::System.Threading.Tasks.TaskCompletionSource<TResult> tcs = new global::System.Threading.Tasks.TaskCompletionSource<TResult>();
			task.ContinueWith(delegate(global::System.Threading.Tasks.Task<TResult> t)
			{
				interceptionContext.MutableData.TaskStatus = t.Status;
				if (t.IsFaulted)
				{
					interceptionContext.MutableData.SetExceptionThrown(t.Exception.InnerException);
				}
				else if (!interceptionContext.MutableData.IsExecutionSuppressed)
				{
					interceptionContext.MutableData.SetExecuted((t.IsCanceled || t.IsFaulted) ? default(TResult) : t.Result);
				}
				try
				{
					foreach (TInterceptor arg2 in this._interceptors)
					{
						executed(arg2, target, interceptionContext);
					}
				}
				catch (global::System.Exception exception)
				{
					interceptionContext.MutableData.Exception = exception;
				}
				if (interceptionContext.MutableData.Exception != null)
				{
					tcs.SetException(interceptionContext.MutableData.Exception);
					return;
				}
				if (t.IsCanceled)
				{
					tcs.SetCanceled();
					return;
				}
				tcs.SetResult(interceptionContext.MutableData.Result);
			}, global::System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously);
			return tcs.Task;
		}

		// Token: 0x04000B93 RID: 2963
		private volatile global::System.Collections.Generic.List<TInterceptor> _interceptors = new global::System.Collections.Generic.List<TInterceptor>();

		// Token: 0x04000B94 RID: 2964
		private readonly object _lock = new object();
	}
}
