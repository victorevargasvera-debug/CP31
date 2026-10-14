using System;
using System.Threading.Tasks;

namespace IdentityModel.Internal
{
	// Token: 0x02000031 RID: 49
	internal class AsyncLazy<T> : global::System.Lazy<global::System.Threading.Tasks.Task<T>>
	{
		// Token: 0x06000069 RID: 105 RVA: 0x00002E60 File Offset: 0x00001060
		public AsyncLazy(global::System.Func<global::System.Threading.Tasks.Task<T>> taskFactory) : base(() => global::System.Threading.Tasks.Task.Factory.StartNew<global::System.Threading.Tasks.Task<T>>(taskFactory).Unwrap<T>())
		{
		}
	}
}
