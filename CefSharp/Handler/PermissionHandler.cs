using System;

namespace CefSharp.Handler
{
	// Token: 0x02000110 RID: 272
	public class PermissionHandler : global::CefSharp.IPermissionHandler
	{
		// Token: 0x0600080E RID: 2062 RVA: 0x0000CBB3 File Offset: 0x0000ADB3
		bool global::CefSharp.IPermissionHandler.OnRequestMediaAccessPermission(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, string requestingOrigin, global::CefSharp.MediaAccessPermissionType requestedPermissions, global::CefSharp.IMediaAccessCallback callback)
		{
			return this.OnRequestMediaAccessPermission(chromiumWebBrowser, browser, frame, requestingOrigin, requestedPermissions, callback);
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x0000CBC4 File Offset: 0x0000ADC4
		protected virtual bool OnRequestMediaAccessPermission(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, string requestingOrigin, global::CefSharp.MediaAccessPermissionType requestedPermissions, global::CefSharp.IMediaAccessCallback callback)
		{
			bool result;
			try
			{
				result = false;
			}
			finally
			{
				if (callback != null)
				{
					callback.Dispose();
				}
			}
			return result;
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x0000CBF4 File Offset: 0x0000ADF4
		bool global::CefSharp.IPermissionHandler.OnShowPermissionPrompt(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, ulong promptId, string requestingOrigin, global::CefSharp.PermissionRequestType requestedPermissions, global::CefSharp.IPermissionPromptCallback callback)
		{
			return this.OnShowPermissionPrompt(chromiumWebBrowser, browser, promptId, requestingOrigin, requestedPermissions, callback);
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x0000CC08 File Offset: 0x0000AE08
		protected virtual bool OnShowPermissionPrompt(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, ulong promptId, string requestingOrigin, global::CefSharp.PermissionRequestType requestedPermissions, global::CefSharp.IPermissionPromptCallback callback)
		{
			bool result;
			try
			{
				result = false;
			}
			finally
			{
				if (callback != null)
				{
					callback.Dispose();
				}
			}
			return result;
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x0000CC38 File Offset: 0x0000AE38
		void global::CefSharp.IPermissionHandler.OnDismissPermissionPrompt(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, ulong promptId, global::CefSharp.PermissionRequestResult result)
		{
			this.OnDismissPermissionPrompt(chromiumWebBrowser, browser, promptId, result);
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x0000CC45 File Offset: 0x0000AE45
		protected virtual void OnDismissPermissionPrompt(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, ulong promptId, global::CefSharp.PermissionRequestResult result)
		{
		}
	}
}
