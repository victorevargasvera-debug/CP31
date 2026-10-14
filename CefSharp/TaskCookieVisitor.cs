using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CefSharp.Internals;

namespace CefSharp
{
	// Token: 0x020000A1 RID: 161
	public class TaskCookieVisitor : global::CefSharp.ICookieVisitor, global::System.IDisposable
	{
		// Token: 0x06000498 RID: 1176 RVA: 0x00006D80 File Offset: 0x00004F80
		public TaskCookieVisitor()
		{
			this.taskCompletionSource = new global::System.Threading.Tasks.TaskCompletionSource<global::System.Collections.Generic.List<global::CefSharp.Cookie>>();
			this.list = new global::System.Collections.Generic.List<global::CefSharp.Cookie>();
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00006D9E File Offset: 0x00004F9E
		bool global::CefSharp.ICookieVisitor.Visit(global::CefSharp.Cookie cookie, int count, int total, ref bool deleteCookie)
		{
			this.list.Add(cookie);
			if (count == total - 1)
			{
				this.taskCompletionSource.TrySetResultAsync(this.list);
			}
			return true;
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00006DC4 File Offset: 0x00004FC4
		void global::System.IDisposable.Dispose()
		{
			if (this.list != null && this.list.Count == 0)
			{
				this.taskCompletionSource.TrySetResultAsync(this.list);
			}
			this.list = null;
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x00006DF3 File Offset: 0x00004FF3
		public global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<global::CefSharp.Cookie>> Task
		{
			get
			{
				return this.taskCompletionSource.Task;
			}
		}

		// Token: 0x04000300 RID: 768
		private readonly global::System.Threading.Tasks.TaskCompletionSource<global::System.Collections.Generic.List<global::CefSharp.Cookie>> taskCompletionSource;

		// Token: 0x04000301 RID: 769
		private global::System.Collections.Generic.List<global::CefSharp.Cookie> list;
	}
}
