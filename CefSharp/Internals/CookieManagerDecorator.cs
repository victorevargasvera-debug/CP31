using System;
using System.Threading.Tasks;

namespace CefSharp.Internals
{
	// Token: 0x020000D0 RID: 208
	public class CookieManagerDecorator : global::CefSharp.ICookieManager, global::System.IDisposable
	{
		// Token: 0x06000625 RID: 1573 RVA: 0x00009E7C File Offset: 0x0000807C
		internal CookieManagerDecorator(global::CefSharp.ICookieManager manager, global::CefSharp.TaskCompletionCallback callback)
		{
			if (manager == null)
			{
				throw new global::System.ArgumentNullException("manager");
			}
			if (callback == null)
			{
				throw new global::System.ArgumentNullException("manager");
			}
			this.manager = manager;
			if (callback.Task.Status == global::System.Threading.Tasks.TaskStatus.RanToCompletion)
			{
				this.managerReady = callback.Task.Result;
				return;
			}
			callback.Task.ContinueWith(delegate(global::System.Threading.Tasks.Task<bool> x)
			{
				this.managerReady = x.Result;
			});
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000626 RID: 1574 RVA: 0x00009EEC File Offset: 0x000080EC
		bool global::CefSharp.ICookieManager.IsDisposed
		{
			get
			{
				return this.manager.IsDisposed;
			}
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00009EF9 File Offset: 0x000080F9
		bool global::CefSharp.ICookieManager.DeleteCookies(string url, string name, global::CefSharp.IDeleteCookiesCallback callback)
		{
			if (this.managerReady)
			{
				return this.manager.DeleteCookies(url, name, callback);
			}
			throw new global::System.InvalidOperationException("CookieManager store is not initialized.");
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x00009F1E File Offset: 0x0000811E
		void global::System.IDisposable.Dispose()
		{
			this.manager.Dispose();
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x00009F2B File Offset: 0x0000812B
		bool global::CefSharp.ICookieManager.FlushStore(global::CefSharp.ICompletionCallback callback)
		{
			if (this.managerReady)
			{
				return this.manager.FlushStore(callback);
			}
			throw new global::System.InvalidOperationException("CookieManager store is not initialized.");
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00009F4E File Offset: 0x0000814E
		bool global::CefSharp.ICookieManager.SetCookie(string url, global::CefSharp.Cookie cookie, global::CefSharp.ISetCookieCallback callback)
		{
			if (this.managerReady)
			{
				return this.manager.SetCookie(url, cookie, callback);
			}
			throw new global::System.InvalidOperationException("CookieManager store is not initialized.");
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00009F73 File Offset: 0x00008173
		bool global::CefSharp.ICookieManager.VisitAllCookies(global::CefSharp.ICookieVisitor visitor)
		{
			if (this.managerReady)
			{
				return this.manager.VisitAllCookies(visitor);
			}
			throw new global::System.InvalidOperationException("CookieManager store is not initialized.");
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x00009F96 File Offset: 0x00008196
		bool global::CefSharp.ICookieManager.VisitUrlCookies(string url, bool includeHttpOnly, global::CefSharp.ICookieVisitor visitor)
		{
			if (this.managerReady)
			{
				return this.manager.VisitUrlCookies(url, includeHttpOnly, visitor);
			}
			throw new global::System.InvalidOperationException("CookieManager store is not initialized.");
		}

		// Token: 0x0400037B RID: 891
		private const string NotInitialziedExceptionMsg = "CookieManager store is not initialized.";

		// Token: 0x0400037C RID: 892
		private global::CefSharp.ICookieManager manager;

		// Token: 0x0400037D RID: 893
		private volatile bool managerReady;
	}
}
