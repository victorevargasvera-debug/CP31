using System;
using System.Threading;
using System.Threading.Tasks;

namespace CefSharp.Internals.Tasks
{
	// Token: 0x020000FE RID: 254
	public class SyncContextTaskCompletionSource<TResult> : global::System.Threading.Tasks.TaskCompletionSource<TResult>
	{
		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000776 RID: 1910 RVA: 0x0000C650 File Offset: 0x0000A850
		// (set) Token: 0x06000777 RID: 1911 RVA: 0x0000C658 File Offset: 0x0000A858
		public global::System.Threading.SynchronizationContext SyncContext { get; set; }
	}
}
