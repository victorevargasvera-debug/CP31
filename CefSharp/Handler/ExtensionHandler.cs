using System;

namespace CefSharp.Handler
{
	// Token: 0x02000108 RID: 264
	public class ExtensionHandler : global::CefSharp.IExtensionHandler, global::System.IDisposable
	{
		// Token: 0x060007C6 RID: 1990 RVA: 0x0000C8AF File Offset: 0x0000AAAF
		void global::CefSharp.IExtensionHandler.OnExtensionLoadFailed(global::CefSharp.CefErrorCode errorCode)
		{
			this.OnExtensionLoadFailed(errorCode);
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x0000C8B8 File Offset: 0x0000AAB8
		protected virtual void OnExtensionLoadFailed(global::CefSharp.CefErrorCode errorCode)
		{
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x0000C8BA File Offset: 0x0000AABA
		void global::CefSharp.IExtensionHandler.OnExtensionLoaded(global::CefSharp.IExtension extension)
		{
			this.OnExtensionLoaded(extension);
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x0000C8C3 File Offset: 0x0000AAC3
		protected virtual void OnExtensionLoaded(global::CefSharp.IExtension extension)
		{
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x0000C8C5 File Offset: 0x0000AAC5
		void global::CefSharp.IExtensionHandler.OnExtensionUnloaded(global::CefSharp.IExtension extension)
		{
			this.OnExtensionUnloaded(extension);
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x0000C8CE File Offset: 0x0000AACE
		protected virtual void OnExtensionUnloaded(global::CefSharp.IExtension extension)
		{
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x0000C8D0 File Offset: 0x0000AAD0
		bool global::CefSharp.IExtensionHandler.OnBeforeBackgroundBrowser(global::CefSharp.IExtension extension, string url, global::CefSharp.IBrowserSettings settings)
		{
			return this.OnBeforeBackgroundBrowser(extension, url, settings);
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x0000C8DB File Offset: 0x0000AADB
		protected virtual bool OnBeforeBackgroundBrowser(global::CefSharp.IExtension extension, string url, global::CefSharp.IBrowserSettings settings)
		{
			return false;
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x0000C8E0 File Offset: 0x0000AAE0
		bool global::CefSharp.IExtensionHandler.OnBeforeBrowser(global::CefSharp.IExtension extension, global::CefSharp.IBrowser browser, global::CefSharp.IBrowser activeBrowser, int index, string url, bool active, global::CefSharp.IWindowInfo windowInfo, global::CefSharp.IBrowserSettings settings)
		{
			return this.OnBeforeBrowser(extension, browser, activeBrowser, index, url, active, windowInfo, settings);
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x0000C900 File Offset: 0x0000AB00
		protected virtual bool OnBeforeBrowser(global::CefSharp.IExtension extension, global::CefSharp.IBrowser browser, global::CefSharp.IBrowser activeBrowser, int index, string url, bool active, global::CefSharp.IWindowInfo windowInfo, global::CefSharp.IBrowserSettings settings)
		{
			return false;
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x0000C903 File Offset: 0x0000AB03
		global::CefSharp.IBrowser global::CefSharp.IExtensionHandler.GetActiveBrowser(global::CefSharp.IExtension extension, global::CefSharp.IBrowser browser, bool includeIncognito)
		{
			return this.GetActiveBrowser(extension, browser, includeIncognito);
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x0000C90E File Offset: 0x0000AB0E
		protected virtual global::CefSharp.IBrowser GetActiveBrowser(global::CefSharp.IExtension extension, global::CefSharp.IBrowser browser, bool includeIncognito)
		{
			return null;
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x0000C911 File Offset: 0x0000AB11
		bool global::CefSharp.IExtensionHandler.CanAccessBrowser(global::CefSharp.IExtension extension, global::CefSharp.IBrowser browser, bool includeIncognito, global::CefSharp.IBrowser targetBrowser)
		{
			return this.CanAccessBrowser(extension, browser, includeIncognito, targetBrowser);
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x0000C91E File Offset: 0x0000AB1E
		protected virtual bool CanAccessBrowser(global::CefSharp.IExtension extension, global::CefSharp.IBrowser browser, bool includeIncognito, global::CefSharp.IBrowser targetBrowser)
		{
			return false;
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x0000C921 File Offset: 0x0000AB21
		bool global::CefSharp.IExtensionHandler.GetExtensionResource(global::CefSharp.IExtension extension, global::CefSharp.IBrowser browser, string file, global::CefSharp.IGetExtensionResourceCallback callback)
		{
			return this.GetExtensionResource(extension, browser, file, callback);
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x0000C92E File Offset: 0x0000AB2E
		protected virtual bool GetExtensionResource(global::CefSharp.IExtension extension, global::CefSharp.IBrowser browser, string file, global::CefSharp.IGetExtensionResourceCallback callback)
		{
			return false;
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x060007D6 RID: 2006 RVA: 0x0000C931 File Offset: 0x0000AB31
		public bool IsDisposed
		{
			get
			{
				return this.isDisposed;
			}
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x0000C939 File Offset: 0x0000AB39
		protected virtual void Dispose(bool disposing)
		{
			this.isDisposed = true;
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x0000C942 File Offset: 0x0000AB42
		void global::System.IDisposable.Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x040003DD RID: 989
		private bool isDisposed;
	}
}
