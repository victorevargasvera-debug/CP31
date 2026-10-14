using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity.SqlServer.Utilities
{
	// Token: 0x02000023 RID: 35
	public static class TaskExtensions
	{
		// Token: 0x060003D5 RID: 981 RVA: 0x0000F350 File Offset: 0x0000D550
		public static global::System.Data.Entity.SqlServer.Utilities.TaskExtensions.CultureAwaiter<T> WithCurrentCulture<T>(this global::System.Threading.Tasks.Task<T> task)
		{
			return new global::System.Data.Entity.SqlServer.Utilities.TaskExtensions.CultureAwaiter<T>(task);
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x0000F358 File Offset: 0x0000D558
		public static global::System.Data.Entity.SqlServer.Utilities.TaskExtensions.CultureAwaiter WithCurrentCulture(this global::System.Threading.Tasks.Task task)
		{
			return new global::System.Data.Entity.SqlServer.Utilities.TaskExtensions.CultureAwaiter(task);
		}

		// Token: 0x0200006C RID: 108
		public struct CultureAwaiter<T> : global::System.Runtime.CompilerServices.ICriticalNotifyCompletion, global::System.Runtime.CompilerServices.INotifyCompletion
		{
			// Token: 0x0600067E RID: 1662 RVA: 0x0001B58F File Offset: 0x0001978F
			public CultureAwaiter(global::System.Threading.Tasks.Task<T> task)
			{
				this._task = task;
			}

			// Token: 0x0600067F RID: 1663 RVA: 0x0001B598 File Offset: 0x00019798
			public global::System.Data.Entity.SqlServer.Utilities.TaskExtensions.CultureAwaiter<T> GetAwaiter()
			{
				return this;
			}

			// Token: 0x170000EF RID: 239
			// (get) Token: 0x06000680 RID: 1664 RVA: 0x0001B5A0 File Offset: 0x000197A0
			public bool IsCompleted
			{
				get
				{
					return this._task.IsCompleted;
				}
			}

			// Token: 0x06000681 RID: 1665 RVA: 0x0001B5B0 File Offset: 0x000197B0
			public T GetResult()
			{
				return this._task.GetAwaiter().GetResult();
			}

			// Token: 0x06000682 RID: 1666 RVA: 0x0001B5D0 File Offset: 0x000197D0
			public void OnCompleted(global::System.Action continuation)
			{
				throw new global::System.NotImplementedException();
			}

			// Token: 0x06000683 RID: 1667 RVA: 0x0001B5D8 File Offset: 0x000197D8
			public void UnsafeOnCompleted(global::System.Action continuation)
			{
				global::System.Globalization.CultureInfo currentCulture = global::System.Threading.Thread.CurrentThread.CurrentCulture;
				global::System.Globalization.CultureInfo currentUICulture = global::System.Threading.Thread.CurrentThread.CurrentUICulture;
				this._task.ConfigureAwait(false).GetAwaiter().UnsafeOnCompleted(delegate
				{
					global::System.Globalization.CultureInfo currentCulture = global::System.Threading.Thread.CurrentThread.CurrentCulture;
					global::System.Globalization.CultureInfo currentUICulture = global::System.Threading.Thread.CurrentThread.CurrentUICulture;
					global::System.Threading.Thread.CurrentThread.CurrentCulture = currentCulture;
					global::System.Threading.Thread.CurrentThread.CurrentUICulture = currentUICulture;
					try
					{
						continuation();
					}
					finally
					{
						global::System.Threading.Thread.CurrentThread.CurrentCulture = currentCulture;
						global::System.Threading.Thread.CurrentThread.CurrentUICulture = currentUICulture;
					}
				});
			}

			// Token: 0x040001CC RID: 460
			private readonly global::System.Threading.Tasks.Task<T> _task;
		}

		// Token: 0x0200006D RID: 109
		public struct CultureAwaiter : global::System.Runtime.CompilerServices.ICriticalNotifyCompletion, global::System.Runtime.CompilerServices.INotifyCompletion
		{
			// Token: 0x06000684 RID: 1668 RVA: 0x0001B63A File Offset: 0x0001983A
			public CultureAwaiter(global::System.Threading.Tasks.Task task)
			{
				this._task = task;
			}

			// Token: 0x06000685 RID: 1669 RVA: 0x0001B643 File Offset: 0x00019843
			public global::System.Data.Entity.SqlServer.Utilities.TaskExtensions.CultureAwaiter GetAwaiter()
			{
				return this;
			}

			// Token: 0x170000F0 RID: 240
			// (get) Token: 0x06000686 RID: 1670 RVA: 0x0001B64B File Offset: 0x0001984B
			public bool IsCompleted
			{
				get
				{
					return this._task.IsCompleted;
				}
			}

			// Token: 0x06000687 RID: 1671 RVA: 0x0001B658 File Offset: 0x00019858
			public void GetResult()
			{
				this._task.GetAwaiter().GetResult();
			}

			// Token: 0x06000688 RID: 1672 RVA: 0x0001B678 File Offset: 0x00019878
			public void OnCompleted(global::System.Action continuation)
			{
				throw new global::System.NotImplementedException();
			}

			// Token: 0x06000689 RID: 1673 RVA: 0x0001B680 File Offset: 0x00019880
			public void UnsafeOnCompleted(global::System.Action continuation)
			{
				global::System.Globalization.CultureInfo currentCulture = global::System.Threading.Thread.CurrentThread.CurrentCulture;
				global::System.Globalization.CultureInfo currentUICulture = global::System.Threading.Thread.CurrentThread.CurrentUICulture;
				this._task.ConfigureAwait(false).GetAwaiter().UnsafeOnCompleted(delegate
				{
					global::System.Globalization.CultureInfo currentCulture = global::System.Threading.Thread.CurrentThread.CurrentCulture;
					global::System.Globalization.CultureInfo currentUICulture = global::System.Threading.Thread.CurrentThread.CurrentUICulture;
					global::System.Threading.Thread.CurrentThread.CurrentCulture = currentCulture;
					global::System.Threading.Thread.CurrentThread.CurrentUICulture = currentUICulture;
					try
					{
						continuation();
					}
					finally
					{
						global::System.Threading.Thread.CurrentThread.CurrentCulture = currentCulture;
						global::System.Threading.Thread.CurrentThread.CurrentUICulture = currentUICulture;
					}
				});
			}

			// Token: 0x040001CD RID: 461
			private readonly global::System.Threading.Tasks.Task _task;
		}
	}
}
