using System;
using System.Threading.Tasks;

namespace System.Data.Entity.Utilities
{
	// Token: 0x02000082 RID: 130
	internal static class TaskHelper
	{
		// Token: 0x06000458 RID: 1112 RVA: 0x0000F278 File Offset: 0x0000D478
		internal static global::System.Threading.Tasks.Task<T> FromException<T>(global::System.Exception ex)
		{
			global::System.Threading.Tasks.TaskCompletionSource<T> taskCompletionSource = new global::System.Threading.Tasks.TaskCompletionSource<T>();
			taskCompletionSource.SetException(ex);
			return taskCompletionSource.Task;
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x0000F28B File Offset: 0x0000D48B
		internal static global::System.Threading.Tasks.Task<T> FromCancellation<T>()
		{
			global::System.Threading.Tasks.TaskCompletionSource<T> taskCompletionSource = new global::System.Threading.Tasks.TaskCompletionSource<T>();
			taskCompletionSource.SetCanceled();
			return taskCompletionSource.Task;
		}
	}
}
