using System;
using System.Threading.Tasks;
using CefSharp.Internals;

namespace CefSharp
{
	// Token: 0x020000A3 RID: 163
	public class TaskStringVisitor : global::CefSharp.IStringVisitor, global::System.IDisposable
	{
		// Token: 0x060004A0 RID: 1184 RVA: 0x00006E63 File Offset: 0x00005063
		public TaskStringVisitor()
		{
			this.taskCompletionSource = new global::System.Threading.Tasks.TaskCompletionSource<string>();
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00006E76 File Offset: 0x00005076
		void global::CefSharp.IStringVisitor.Visit(string str)
		{
			this.taskCompletionSource.TrySetResultAsync(str);
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060004A2 RID: 1186 RVA: 0x00006E84 File Offset: 0x00005084
		public global::System.Threading.Tasks.Task<string> Task
		{
			get
			{
				return this.taskCompletionSource.Task;
			}
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00006E91 File Offset: 0x00005091
		void global::System.IDisposable.Dispose()
		{
		}

		// Token: 0x04000304 RID: 772
		private readonly global::System.Threading.Tasks.TaskCompletionSource<string> taskCompletionSource;
	}
}
