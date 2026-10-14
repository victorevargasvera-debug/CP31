using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity.Utilities
{
	// Token: 0x02000081 RID: 129
	public static class TaskExtensions
	{
		// Token: 0x06000456 RID: 1110 RVA: 0x0000F268 File Offset: 0x0000D468
		public static global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<T> WithCurrentCulture<T>(this global::System.Threading.Tasks.Task<T> task)
		{
			return new global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<T>(task);
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x0000F270 File Offset: 0x0000D470
		public static global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter WithCurrentCulture(this global::System.Threading.Tasks.Task task)
		{
			return new global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter(task);
		}

		// Token: 0x02000713 RID: 1811
		public struct CultureAwaiter<T> : global::System.Runtime.CompilerServices.ICriticalNotifyCompletion, global::System.Runtime.CompilerServices.INotifyCompletion
		{
			// Token: 0x06005510 RID: 21776 RVA: 0x001308ED File Offset: 0x0012EAED
			public CultureAwaiter(global::System.Threading.Tasks.Task<T> task)
			{
				this._task = task;
			}

			// Token: 0x06005511 RID: 21777 RVA: 0x001308F6 File Offset: 0x0012EAF6
			public global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<T> GetAwaiter()
			{
				return this;
			}

			// Token: 0x17001014 RID: 4116
			// (get) Token: 0x06005512 RID: 21778 RVA: 0x001308FE File Offset: 0x0012EAFE
			public bool IsCompleted
			{
				get
				{
					return this._task.IsCompleted;
				}
			}

			// Token: 0x06005513 RID: 21779 RVA: 0x0013090C File Offset: 0x0012EB0C
			public T GetResult()
			{
				return this._task.GetAwaiter().GetResult();
			}

			// Token: 0x06005514 RID: 21780 RVA: 0x0013092C File Offset: 0x0012EB2C
			public void OnCompleted(global::System.Action continuation)
			{
				throw new global::System.NotImplementedException();
			}

			// Token: 0x06005515 RID: 21781 RVA: 0x00130934 File Offset: 0x0012EB34
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

			// Token: 0x04001E61 RID: 7777
			private readonly global::System.Threading.Tasks.Task<T> _task;
		}

		// Token: 0x02000714 RID: 1812
		public struct CultureAwaiter : global::System.Runtime.CompilerServices.ICriticalNotifyCompletion, global::System.Runtime.CompilerServices.INotifyCompletion
		{
			// Token: 0x06005516 RID: 21782 RVA: 0x00130996 File Offset: 0x0012EB96
			public CultureAwaiter(global::System.Threading.Tasks.Task task)
			{
				this._task = task;
			}

			// Token: 0x06005517 RID: 21783 RVA: 0x0013099F File Offset: 0x0012EB9F
			public global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter GetAwaiter()
			{
				return this;
			}

			// Token: 0x17001015 RID: 4117
			// (get) Token: 0x06005518 RID: 21784 RVA: 0x001309A7 File Offset: 0x0012EBA7
			public bool IsCompleted
			{
				get
				{
					return this._task.IsCompleted;
				}
			}

			// Token: 0x06005519 RID: 21785 RVA: 0x001309B4 File Offset: 0x0012EBB4
			public void GetResult()
			{
				this._task.GetAwaiter().GetResult();
			}

			// Token: 0x0600551A RID: 21786 RVA: 0x001309D4 File Offset: 0x0012EBD4
			public void OnCompleted(global::System.Action continuation)
			{
				throw new global::System.NotImplementedException();
			}

			// Token: 0x0600551B RID: 21787 RVA: 0x001309DC File Offset: 0x0012EBDC
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

			// Token: 0x04001E62 RID: 7778
			private readonly global::System.Threading.Tasks.Task _task;
		}
	}
}
