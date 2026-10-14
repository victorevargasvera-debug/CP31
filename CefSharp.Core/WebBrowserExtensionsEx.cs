using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using CefSharp.Fluent;
using CefSharp.Internals;

namespace CefSharp
{
	// Token: 0x02000010 RID: 16
	public static class WebBrowserExtensionsEx
	{
		// Token: 0x06000124 RID: 292 RVA: 0x0000350C File Offset: 0x0000170C
		public static global::System.Threading.Tasks.Task<global::CefSharp.NavigationEntry> GetVisibleNavigationEntryAsync(this global::CefSharp.IChromiumWebBrowserBase browser)
		{
			global::CefSharp.IBrowserHost host = browser.GetBrowserHost();
			if (host == null)
			{
				return global::System.Threading.Tasks.Task.FromResult<global::CefSharp.NavigationEntry>(null);
			}
			if (global::CefSharp.Cef.CurrentlyOnThread(global::CefSharp.CefThreadIds.TID_UI))
			{
				global::CefSharp.NavigationEntry visibleNavigationEntry = host.GetVisibleNavigationEntry();
				return global::System.Threading.Tasks.Task.FromResult<global::CefSharp.NavigationEntry>(visibleNavigationEntry);
			}
			global::System.Threading.Tasks.TaskCompletionSource<global::CefSharp.NavigationEntry> tcs = new global::System.Threading.Tasks.TaskCompletionSource<global::CefSharp.NavigationEntry>();
			global::CefSharp.Cef.UIThreadTaskFactory.StartNew(delegate()
			{
				global::CefSharp.NavigationEntry visibleNavigationEntry2 = host.GetVisibleNavigationEntry();
				tcs.TrySetResultAsync(visibleNavigationEntry2);
			});
			return tcs.Task;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00003584 File Offset: 0x00001784
		public static void DownloadUrl(this global::CefSharp.IFrame frame, string url, global::System.Action<global::CefSharp.IUrlRequest, global::System.IO.Stream> completeHandler)
		{
			if (!frame.IsValid)
			{
				throw new global::System.Exception("Frame is invalid, unable to continue.");
			}
			global::CefSharp.Cef.UIThreadTaskFactory.StartNew(delegate()
			{
				global::CefSharp.IRequest request = frame.CreateRequest(false);
				request.Method = "GET";
				request.Url = url;
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
				global::CefSharp.IUrlRequestClient client = global::CefSharp.Fluent.UrlRequestClient.Create().OnDownloadData(delegate(global::CefSharp.IUrlRequest req, global::System.IO.Stream stream)
				{
					stream.CopyTo(memoryStream);
				}).OnRequestComplete(delegate(global::CefSharp.IUrlRequest req)
				{
					memoryStream.Position = 0L;
					global::System.Action<global::CefSharp.IUrlRequest, global::System.IO.Stream> completeHandler2 = completeHandler;
					if (completeHandler2 == null)
					{
						return;
					}
					completeHandler2(req, memoryStream);
				}).Build();
				global::CefSharp.IUrlRequest urlRequest = frame.CreateUrlRequest(request, client);
			});
		}

		// Token: 0x06000126 RID: 294 RVA: 0x000035DC File Offset: 0x000017DC
		public static global::System.Threading.Tasks.Task<byte[]> DownloadUrlAsync(this global::CefSharp.IFrame frame, string url)
		{
			if (!frame.IsValid)
			{
				throw new global::System.Exception("Frame is invalid, unable to continue.");
			}
			global::System.Threading.Tasks.TaskCompletionSource<byte[]> taskCompletionSource = new global::System.Threading.Tasks.TaskCompletionSource<byte[]>();
			global::CefSharp.Cef.UIThreadTaskFactory.StartNew(delegate()
			{
				global::CefSharp.IRequest request = frame.CreateRequest(false);
				request.Method = "GET";
				request.Url = url;
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
				global::CefSharp.IUrlRequestClient client = global::CefSharp.Fluent.UrlRequestClient.Create().OnDownloadData(delegate(global::CefSharp.IUrlRequest req, global::System.IO.Stream stream)
				{
					stream.CopyTo(memoryStream);
				}).OnRequestComplete(delegate(global::CefSharp.IUrlRequest req)
				{
					if (req.RequestStatus == global::CefSharp.UrlRequestStatus.Success)
					{
						taskCompletionSource.TrySetResultAsync(memoryStream.ToArray());
						return;
					}
					taskCompletionSource.TrySetExceptionAsync(new global::System.Exception("RequestStatus:" + req.RequestStatus.ToString() + ";StatusCode:" + req.Response.StatusCode.ToString()));
				}).Build();
				global::CefSharp.IUrlRequest urlRequest = frame.CreateUrlRequest(request, client);
			});
			return taskCompletionSource.Task;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00003644 File Offset: 0x00001844
		public static void ToggleAudioMute(this global::CefSharp.IChromiumWebBrowserBase browser)
		{
			if (browser.IsDisposed || global::CefSharp.Cef.IsShutdown)
			{
				return;
			}
			global::CefSharp.Cef.UIThreadTaskFactory.StartNew(delegate()
			{
				global::CefSharp.IBrowser browserCore = browser.BrowserCore;
				if (browserCore == null || browserCore.IsDisposed)
				{
					return;
				}
				global::CefSharp.IBrowserHost host = browserCore.GetHost();
				bool isAudioMuted = host.IsAudioMuted;
				host.SetAudioMuted(!isAudioMuted);
			});
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0000368C File Offset: 0x0000188C
		public static global::System.Threading.Tasks.Task<T> EvaluateScriptAsync<T>(this global::CefSharp.IFrame frame, string script, global::System.TimeSpan? timeout = null)
		{
			global::CefSharp.WebBrowserExtensionsEx.<EvaluateScriptAsync>d__4<T> <EvaluateScriptAsync>d__;
			<EvaluateScriptAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<T>.Create();
			<EvaluateScriptAsync>d__.frame = frame;
			<EvaluateScriptAsync>d__.script = script;
			<EvaluateScriptAsync>d__.timeout = timeout;
			<EvaluateScriptAsync>d__.<>1__state = -1;
			<EvaluateScriptAsync>d__.<>t__builder.Start<global::CefSharp.WebBrowserExtensionsEx.<EvaluateScriptAsync>d__4<T>>(ref <EvaluateScriptAsync>d__);
			return <EvaluateScriptAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x000036E0 File Offset: 0x000018E0
		public static global::System.Threading.Tasks.Task<T> EvaluateScriptAsync<T>(this global::CefSharp.IBrowser browser, string script, global::System.TimeSpan? timeout = null)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserNull(browser);
			global::System.Threading.Tasks.Task<T> result;
			using (global::CefSharp.IFrame mainFrame = browser.MainFrame)
			{
				result = mainFrame.EvaluateScriptAsync(script, timeout);
			}
			return result;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00003720 File Offset: 0x00001920
		public static global::System.Threading.Tasks.Task<T> EvaluateScriptAsync<T>(this global::CefSharp.IChromiumWebBrowserBase chromiumWebBrowser, string script, global::System.TimeSpan? timeout = null)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfChromiumWebBrowserDisposed(chromiumWebBrowser);
			global::CefSharp.IWebBrowser webBrowser = chromiumWebBrowser as global::CefSharp.IWebBrowser;
			if (webBrowser != null && !webBrowser.CanExecuteJavascriptInMainFrame)
			{
				global::CefSharp.WebBrowserExtensions.ThrowExceptionIfCanExecuteJavascriptInMainFrameFalse();
			}
			return chromiumWebBrowser.BrowserCore.EvaluateScriptAsync(script, timeout);
		}
	}
}
