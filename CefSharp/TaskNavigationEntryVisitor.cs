using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CefSharp.Internals;

namespace CefSharp
{
	// Token: 0x020000A2 RID: 162
	public class TaskNavigationEntryVisitor : global::CefSharp.INavigationEntryVisitor, global::System.IDisposable
	{
		// Token: 0x0600049C RID: 1180 RVA: 0x00006E00 File Offset: 0x00005000
		public TaskNavigationEntryVisitor()
		{
			this.taskCompletionSource = new global::System.Threading.Tasks.TaskCompletionSource<global::System.Collections.Generic.List<global::CefSharp.NavigationEntry>>();
			this.list = new global::System.Collections.Generic.List<global::CefSharp.NavigationEntry>();
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00006E1E File Offset: 0x0000501E
		bool global::CefSharp.INavigationEntryVisitor.Visit(global::CefSharp.NavigationEntry entry, bool current, int index, int total)
		{
			this.list.Add(entry);
			return true;
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00006E2D File Offset: 0x0000502D
		void global::System.IDisposable.Dispose()
		{
			if (this.list != null)
			{
				this.taskCompletionSource.TrySetResultAsync(this.list);
			}
			this.list = null;
			this.taskCompletionSource = null;
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x00006E56 File Offset: 0x00005056
		public global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<global::CefSharp.NavigationEntry>> Task
		{
			get
			{
				return this.taskCompletionSource.Task;
			}
		}

		// Token: 0x04000302 RID: 770
		private global::System.Threading.Tasks.TaskCompletionSource<global::System.Collections.Generic.List<global::CefSharp.NavigationEntry>> taskCompletionSource;

		// Token: 0x04000303 RID: 771
		private global::System.Collections.Generic.List<global::CefSharp.NavigationEntry> list;
	}
}
