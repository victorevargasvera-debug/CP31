using System;

namespace CefSharp
{
	// Token: 0x02000061 RID: 97
	public interface IPermissionHandler
	{
		// Token: 0x06000162 RID: 354
		bool OnRequestMediaAccessPermission(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, string requestingOrigin, global::CefSharp.MediaAccessPermissionType requestedPermissions, global::CefSharp.IMediaAccessCallback callback);

		// Token: 0x06000163 RID: 355
		bool OnShowPermissionPrompt(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, ulong promptId, string requestingOrigin, global::CefSharp.PermissionRequestType requestedPermissions, global::CefSharp.IPermissionPromptCallback callback);

		// Token: 0x06000164 RID: 356
		void OnDismissPermissionPrompt(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, ulong promptId, global::CefSharp.PermissionRequestResult result);
	}
}
