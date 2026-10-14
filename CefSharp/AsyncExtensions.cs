using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CefSharp
{
	// Token: 0x02000002 RID: 2
	public static class AsyncExtensions
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public static global::System.Threading.Tasks.Task<int> DeleteCookiesAsync(this global::CefSharp.ICookieManager cookieManager, string url = null, string name = null)
		{
			if (cookieManager == null)
			{
				throw new global::System.ArgumentNullException("cookieManager");
			}
			if (cookieManager.IsDisposed)
			{
				throw new global::System.ObjectDisposedException("CookieManager");
			}
			global::CefSharp.TaskDeleteCookiesCallback taskDeleteCookiesCallback = new global::CefSharp.TaskDeleteCookiesCallback();
			if (cookieManager.DeleteCookies(url, name, taskDeleteCookiesCallback))
			{
				return taskDeleteCookiesCallback.Task;
			}
			return global::System.Threading.Tasks.Task.FromResult<int>(-1);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x0000209C File Offset: 0x0000029C
		public static global::System.Threading.Tasks.Task<bool> SetCookieAsync(this global::CefSharp.ICookieManager cookieManager, string url, global::CefSharp.Cookie cookie)
		{
			if (cookieManager == null)
			{
				throw new global::System.ArgumentNullException("cookieManager");
			}
			if (cookieManager.IsDisposed)
			{
				throw new global::System.ObjectDisposedException("CookieManager");
			}
			global::CefSharp.TaskSetCookieCallback taskSetCookieCallback = new global::CefSharp.TaskSetCookieCallback();
			if (cookieManager.SetCookie(url, cookie, taskSetCookieCallback))
			{
				return taskSetCookieCallback.Task;
			}
			return global::System.Threading.Tasks.Task.FromResult<bool>(false);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000020E8 File Offset: 0x000002E8
		public static global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<global::CefSharp.Cookie>> VisitAllCookiesAsync(this global::CefSharp.ICookieManager cookieManager)
		{
			global::CefSharp.TaskCookieVisitor taskCookieVisitor = new global::CefSharp.TaskCookieVisitor();
			if (cookieManager.VisitAllCookies(taskCookieVisitor))
			{
				return taskCookieVisitor.Task;
			}
			return global::System.Threading.Tasks.Task.FromResult<global::System.Collections.Generic.List<global::CefSharp.Cookie>>(null);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002114 File Offset: 0x00000314
		public static global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<global::CefSharp.Cookie>> VisitUrlCookiesAsync(this global::CefSharp.ICookieManager cookieManager, string url, bool includeHttpOnly)
		{
			global::CefSharp.TaskCookieVisitor taskCookieVisitor = new global::CefSharp.TaskCookieVisitor();
			if (cookieManager.VisitUrlCookies(url, includeHttpOnly, taskCookieVisitor))
			{
				return taskCookieVisitor.Task;
			}
			return global::System.Threading.Tasks.Task.FromResult<global::System.Collections.Generic.List<global::CefSharp.Cookie>>(null);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002140 File Offset: 0x00000340
		public static global::System.Threading.Tasks.Task<bool> FlushStoreAsync(this global::CefSharp.ICookieManager cookieManager)
		{
			global::CefSharp.TaskCompletionCallback taskCompletionCallback = new global::CefSharp.TaskCompletionCallback();
			if (cookieManager.FlushStore(taskCompletionCallback))
			{
				return taskCompletionCallback.Task;
			}
			return global::System.Threading.Tasks.Task.FromResult<bool>(false);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000216C File Offset: 0x0000036C
		public static global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<global::CefSharp.NavigationEntry>> GetNavigationEntriesAsync(this global::CefSharp.IBrowserHost browserHost, bool currentOnly = false)
		{
			global::CefSharp.TaskNavigationEntryVisitor taskNavigationEntryVisitor = new global::CefSharp.TaskNavigationEntryVisitor();
			browserHost.GetNavigationEntries(taskNavigationEntryVisitor, currentOnly);
			return taskNavigationEntryVisitor.Task;
		}
	}
}
