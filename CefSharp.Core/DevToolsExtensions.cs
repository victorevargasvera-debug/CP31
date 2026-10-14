using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using CefSharp.DevTools;
using CefSharp.Internals;
using CefSharp.Web;

namespace CefSharp
{
	// Token: 0x02000005 RID: 5
	public static class DevToolsExtensions
	{
		// Token: 0x060000A5 RID: 165 RVA: 0x00002B00 File Offset: 0x00000D00
		public static int ExecuteDevToolsMethod(this global::CefSharp.IBrowserHost browserHost, int messageId, string method, global::CefSharp.Web.JsonString parameters)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserHostNull(browserHost);
			string paramsAsJson = (parameters == null) ? null : parameters.Json;
			return browserHost.ExecuteDevToolsMethod(messageId, method, paramsAsJson);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002B2C File Offset: 0x00000D2C
		public static global::System.Threading.Tasks.Task<int> ExecuteDevToolsMethodAsync(this global::CefSharp.IBrowser browser, int messageId, string method, global::System.Collections.Generic.IDictionary<string, object> parameters = null)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserNull(browser);
			global::CefSharp.IBrowserHost browserHost = browser.GetHost();
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserHostNull(browserHost);
			if (global::CefSharp.Internals.CefThread.CurrentlyOnUiThread)
			{
				return global::System.Threading.Tasks.Task.FromResult<int>(browserHost.ExecuteDevToolsMethod(messageId, method, parameters));
			}
			if (global::CefSharp.Internals.CefThread.CanExecuteOnUiThread)
			{
				return global::CefSharp.Internals.CefThread.ExecuteOnUiThread<int>(() => browserHost.ExecuteDevToolsMethod(messageId, method, parameters));
			}
			return global::System.Threading.Tasks.Task.FromResult<int>(0);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002BBC File Offset: 0x00000DBC
		public static global::System.Threading.Tasks.Task<int> ExecuteDevToolsMethodAsync(this global::CefSharp.IChromiumWebBrowserBase chromiumWebBrowser, int messageId, string method, global::System.Collections.Generic.IDictionary<string, object> parameters = null)
		{
			global::CefSharp.IBrowser browserCore = chromiumWebBrowser.BrowserCore;
			return browserCore.ExecuteDevToolsMethodAsync(messageId, method, parameters);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002BDC File Offset: 0x00000DDC
		public static global::CefSharp.DevTools.DevToolsClient GetDevToolsClient(this global::CefSharp.IChromiumWebBrowserBase chromiumWebBrowser)
		{
			global::CefSharp.IBrowser browserCore = chromiumWebBrowser.BrowserCore;
			return browserCore.GetDevToolsClient();
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002BF8 File Offset: 0x00000DF8
		public static global::CefSharp.DevTools.DevToolsClient GetDevToolsClient(this global::CefSharp.IBrowser browser)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserNull(browser);
			global::CefSharp.IBrowserHost host = browser.GetHost();
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserHostNull(host);
			global::CefSharp.DevTools.DevToolsClient devToolsClient = new global::CefSharp.DevTools.DevToolsClient(browser);
			global::CefSharp.IRegistration devToolsObserverRegistration = host.AddDevToolsMessageObserver(devToolsClient);
			devToolsClient.SetDevToolsObserverRegistration(devToolsObserverRegistration);
			return devToolsClient;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002C30 File Offset: 0x00000E30
		public static global::System.Threading.Tasks.Task<bool> SetMainFrameDocumentContentAsync(this global::CefSharp.IChromiumWebBrowserBase chromiumWebBrowser, string html)
		{
			global::CefSharp.IBrowser browserCore = chromiumWebBrowser.BrowserCore;
			return browserCore.SetMainFrameDocumentContentAsync(html);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002C4C File Offset: 0x00000E4C
		public static global::System.Threading.Tasks.Task<bool> SetMainFrameDocumentContentAsync(this global::CefSharp.IBrowser browser, string html)
		{
			global::CefSharp.DevToolsExtensions.<SetMainFrameDocumentContentAsync>d__6 <SetMainFrameDocumentContentAsync>d__;
			<SetMainFrameDocumentContentAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool>.Create();
			<SetMainFrameDocumentContentAsync>d__.browser = browser;
			<SetMainFrameDocumentContentAsync>d__.html = html;
			<SetMainFrameDocumentContentAsync>d__.<>1__state = -1;
			<SetMainFrameDocumentContentAsync>d__.<>t__builder.Start<global::CefSharp.DevToolsExtensions.<SetMainFrameDocumentContentAsync>d__6>(ref <SetMainFrameDocumentContentAsync>d__);
			return <SetMainFrameDocumentContentAsync>d__.<>t__builder.Task;
		}
	}
}
