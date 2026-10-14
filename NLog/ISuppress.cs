using System;
using System.Threading.Tasks;

namespace NLog
{
	// Token: 0x02000009 RID: 9
	public interface ISuppress
	{
		// Token: 0x06000179 RID: 377
		void Swallow(global::System.Action action);

		// Token: 0x0600017A RID: 378
		T Swallow<T>(global::System.Func<T> func);

		// Token: 0x0600017B RID: 379
		T Swallow<T>(global::System.Func<T> func, T fallback);

		// Token: 0x0600017C RID: 380
		void Swallow(global::System.Threading.Tasks.Task task);

		// Token: 0x0600017D RID: 381
		global::System.Threading.Tasks.Task SwallowAsync(global::System.Threading.Tasks.Task task);

		// Token: 0x0600017E RID: 382
		global::System.Threading.Tasks.Task SwallowAsync(global::System.Func<global::System.Threading.Tasks.Task> asyncAction);

		// Token: 0x0600017F RID: 383
		global::System.Threading.Tasks.Task<TResult> SwallowAsync<TResult>(global::System.Func<global::System.Threading.Tasks.Task<TResult>> asyncFunc);

		// Token: 0x06000180 RID: 384
		global::System.Threading.Tasks.Task<TResult> SwallowAsync<TResult>(global::System.Func<global::System.Threading.Tasks.Task<TResult>> asyncFunc, TResult fallback);
	}
}
