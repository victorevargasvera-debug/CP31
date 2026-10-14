using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NLog.Internal;

namespace NLog.Common
{
	// Token: 0x0200018A RID: 394
	public static class AsyncHelpers
	{
		// Token: 0x060010C5 RID: 4293 RVA: 0x0002CA1C File Offset: 0x0002AC1C
		internal static int GetManagedThreadId()
		{
			return global::System.Threading.Thread.CurrentThread.ManagedThreadId;
		}

		// Token: 0x060010C6 RID: 4294 RVA: 0x0002CA28 File Offset: 0x0002AC28
		internal static void StartAsyncTask(global::System.Action<object> action, object state)
		{
			global::System.Threading.Tasks.Task.Factory.StartNew(action, state, global::System.Threading.CancellationToken.None, global::System.Threading.Tasks.TaskCreationOptions.None, global::System.Threading.Tasks.TaskScheduler.Default);
		}

		// Token: 0x060010C7 RID: 4295 RVA: 0x0002CA42 File Offset: 0x0002AC42
		internal static void WaitForDelay(global::System.TimeSpan delay)
		{
			global::System.Threading.Thread.Sleep(delay);
		}

		// Token: 0x060010C8 RID: 4296 RVA: 0x0002CA4C File Offset: 0x0002AC4C
		public static void ForEachItemSequentially<T>(global::System.Collections.Generic.IEnumerable<T> items, global::NLog.Common.AsyncContinuation asyncContinuation, global::NLog.Common.AsynchronousAction<T> action)
		{
			action = global::NLog.Common.AsyncHelpers.ExceptionGuard<T>(action);
			global::NLog.Common.AsyncContinuation invokeNext = null;
			global::System.Collections.Generic.IEnumerator<T> enumerator = items.GetEnumerator();
			invokeNext = delegate(global::System.Exception ex)
			{
				if (ex != null)
				{
					asyncContinuation(ex);
					return;
				}
				if (!enumerator.MoveNext())
				{
					enumerator.Dispose();
					asyncContinuation(null);
					return;
				}
				action(enumerator.Current, global::NLog.Common.AsyncHelpers.PreventMultipleCalls(invokeNext));
			};
			invokeNext(null);
		}

		// Token: 0x060010C9 RID: 4297 RVA: 0x0002CAB0 File Offset: 0x0002ACB0
		public static void Repeat(int repeatCount, global::NLog.Common.AsyncContinuation asyncContinuation, global::NLog.Common.AsynchronousAction action)
		{
			action = global::NLog.Common.AsyncHelpers.ExceptionGuard(action);
			global::NLog.Common.AsyncContinuation invokeNext = null;
			int remaining = repeatCount;
			invokeNext = delegate(global::System.Exception ex)
			{
				if (ex != null)
				{
					asyncContinuation(ex);
					return;
				}
				int remaining = remaining;
				remaining--;
				if (remaining <= 0)
				{
					asyncContinuation(null);
					return;
				}
				action(global::NLog.Common.AsyncHelpers.PreventMultipleCalls(invokeNext));
			};
			invokeNext(null);
		}

		// Token: 0x060010CA RID: 4298 RVA: 0x0002CB0C File Offset: 0x0002AD0C
		public static global::NLog.Common.AsyncContinuation PrecededBy(global::NLog.Common.AsyncContinuation asyncContinuation, global::NLog.Common.AsynchronousAction action)
		{
			action = global::NLog.Common.AsyncHelpers.ExceptionGuard(action);
			return delegate(global::System.Exception ex)
			{
				if (ex != null)
				{
					asyncContinuation(ex);
					return;
				}
				action(global::NLog.Common.AsyncHelpers.PreventMultipleCalls(asyncContinuation));
			};
		}

		// Token: 0x060010CB RID: 4299 RVA: 0x0002CB3D File Offset: 0x0002AD3D
		public static global::NLog.Common.AsyncContinuation WithTimeout(global::NLog.Common.AsyncContinuation asyncContinuation, global::System.TimeSpan timeout)
		{
			return new global::NLog.Common.AsyncContinuation(new global::NLog.Internal.TimeoutContinuation(asyncContinuation, timeout).Function);
		}

		// Token: 0x060010CC RID: 4300 RVA: 0x0002CB54 File Offset: 0x0002AD54
		public static void ForEachItemInParallel<T>(global::System.Collections.Generic.IEnumerable<T> values, global::NLog.Common.AsyncContinuation asyncContinuation, global::NLog.Common.AsynchronousAction<T> action)
		{
			action = global::NLog.Common.AsyncHelpers.ExceptionGuard<T>(action);
			global::System.Collections.Generic.List<T> list = new global::System.Collections.Generic.List<T>(values);
			int remaining = list.Count;
			global::System.Collections.Generic.List<global::System.Exception> exceptions = new global::System.Collections.Generic.List<global::System.Exception>();
			global::NLog.Common.InternalLogger.Trace<int>("ForEachItemInParallel() {0} items", list.Count);
			if (remaining == 0)
			{
				asyncContinuation(null);
				return;
			}
			global::NLog.Common.AsyncContinuation continuation = delegate(global::System.Exception ex)
			{
				global::NLog.Common.InternalLogger.Trace<global::System.Exception>("Continuation invoked: {0}", ex);
				global::System.Collections.Generic.List<global::System.Exception> exceptions;
				if (ex != null)
				{
					exceptions = exceptions;
					lock (exceptions)
					{
						exceptions.Add(ex);
					}
				}
				int num = global::System.Threading.Interlocked.Decrement(ref remaining);
				global::NLog.Common.InternalLogger.Trace<int>("Parallel task completed. {0} items remaining", num);
				if (num == 0)
				{
					asyncContinuation(global::NLog.Common.AsyncHelpers.GetCombinedException(exceptions));
				}
			};
			foreach (T itemCopy2 in list)
			{
				T itemCopy = itemCopy2;
				global::NLog.Common.AsyncHelpers.StartAsyncTask(delegate(object s)
				{
					try
					{
						action(itemCopy, global::NLog.Common.AsyncHelpers.PreventMultipleCalls(continuation));
					}
					catch (global::System.Exception ex)
					{
						global::NLog.Common.InternalLogger.Error(ex, "ForEachItemInParallel - Unhandled Exception");
						if (ex.MustBeRethrownImmediately())
						{
							throw;
						}
					}
				}, null);
			}
		}

		// Token: 0x060010CD RID: 4301 RVA: 0x0002CC3C File Offset: 0x0002AE3C
		public static void RunSynchronously(global::NLog.Common.AsynchronousAction action)
		{
			global::System.Threading.ManualResetEvent ev = new global::System.Threading.ManualResetEvent(false);
			global::System.Exception lastException = null;
			action(global::NLog.Common.AsyncHelpers.PreventMultipleCalls(delegate(global::System.Exception ex)
			{
				lastException = ex;
				ev.Set();
			}));
			ev.WaitOne();
			if (lastException != null)
			{
				throw new global::NLog.NLogRuntimeException("Asynchronous exception has occurred.", lastException);
			}
		}

		// Token: 0x060010CE RID: 4302 RVA: 0x0002CC9E File Offset: 0x0002AE9E
		public static global::NLog.Common.AsyncContinuation PreventMultipleCalls(global::NLog.Common.AsyncContinuation asyncContinuation)
		{
			if (asyncContinuation.Target is global::NLog.Internal.SingleCallContinuation)
			{
				return asyncContinuation;
			}
			return new global::NLog.Common.AsyncContinuation(new global::NLog.Internal.SingleCallContinuation(asyncContinuation).Function);
		}

		// Token: 0x060010CF RID: 4303 RVA: 0x0002CCC0 File Offset: 0x0002AEC0
		public static global::System.Exception GetCombinedException(global::System.Collections.Generic.IList<global::System.Exception> exceptions)
		{
			if (exceptions.Count == 0)
			{
				return null;
			}
			if (exceptions.Count == 1)
			{
				return exceptions[0];
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			string value = string.Empty;
			string newLine = global::NLog.Internal.EnvironmentHelper.NewLine;
			foreach (global::System.Exception ex in exceptions)
			{
				stringBuilder.Append(value);
				stringBuilder.Append(ex.ToString());
				stringBuilder.Append(newLine);
				value = newLine;
			}
			return new global::NLog.NLogRuntimeException("Got multiple exceptions:\r\n" + stringBuilder);
		}

		// Token: 0x060010D0 RID: 4304 RVA: 0x0002CD60 File Offset: 0x0002AF60
		private static global::NLog.Common.AsynchronousAction ExceptionGuard(global::NLog.Common.AsynchronousAction action)
		{
			return delegate(global::NLog.Common.AsyncContinuation cont)
			{
				try
				{
					action(cont);
				}
				catch (global::System.Exception exception)
				{
					if (exception.MustBeRethrown())
					{
						throw;
					}
					cont(exception);
				}
			};
		}

		// Token: 0x060010D1 RID: 4305 RVA: 0x0002CD79 File Offset: 0x0002AF79
		private static global::NLog.Common.AsynchronousAction<T> ExceptionGuard<T>(global::NLog.Common.AsynchronousAction<T> action)
		{
			return delegate(T argument, global::NLog.Common.AsyncContinuation cont)
			{
				try
				{
					action(argument, cont);
				}
				catch (global::System.Exception exception)
				{
					if (exception.MustBeRethrown())
					{
						throw;
					}
					cont(exception);
				}
			};
		}

		// Token: 0x060010D2 RID: 4306 RVA: 0x0002CD94 File Offset: 0x0002AF94
		internal static bool WaitForDispose(this global::System.Threading.Timer timer, global::System.TimeSpan timeout)
		{
			timer.Change(-1, -1);
			if (timeout != global::System.TimeSpan.Zero)
			{
				global::System.Threading.ManualResetEvent manualResetEvent = new global::System.Threading.ManualResetEvent(false);
				if (timer.Dispose(manualResetEvent) && !manualResetEvent.WaitOne((int)timeout.TotalMilliseconds))
				{
					return false;
				}
				manualResetEvent.Close();
			}
			else
			{
				timer.Dispose();
			}
			return true;
		}
	}
}
