using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CefSharp.Internals;
using CefSharp.JavascriptBinding;
using CefSharp.Web;

namespace CefSharp
{
	// Token: 0x020000A6 RID: 166
	public static class WebBrowserExtensions
	{
		// Token: 0x060004B6 RID: 1206 RVA: 0x00006F7E File Offset: 0x0000517E
		[global::System.Obsolete("This method has been removed, see https://github.com/cefsharp/CefSharp/issues/2990 for details on migrating your code.")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public static void RegisterJsObject(this global::CefSharp.IWebBrowser webBrowser, string name, object objectToBind, global::CefSharp.BindingOptions options = null)
		{
			throw new global::System.NotImplementedException("This method has been removed, see https://github.com/cefsharp/CefSharp/issues/2990 for details on migrating your code.");
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00006F8A File Offset: 0x0000518A
		[global::System.Obsolete("This method has been removed, see https://github.com/cefsharp/CefSharp/issues/2990 for details on migrating your code.")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public static void RegisterAsyncJsObject(this global::CefSharp.IWebBrowser webBrowser, string name, object objectToBind, global::CefSharp.BindingOptions options = null)
		{
			throw new global::System.NotImplementedException("This method has been removed, see https://github.com/cefsharp/CefSharp/issues/2990 for details on migrating your code.");
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00006F98 File Offset: 0x00005198
		public static global::CefSharp.IFrame GetMainFrame(this global::CefSharp.IChromiumWebBrowserBase browser)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfChromiumWebBrowserDisposed(browser);
			global::CefSharp.IBrowser browserCore = browser.BrowserCore;
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserNull(browserCore);
			return browserCore.MainFrame;
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00006FC0 File Offset: 0x000051C0
		public static global::CefSharp.IFrame GetFocusedFrame(this global::CefSharp.IChromiumWebBrowserBase browser)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfChromiumWebBrowserDisposed(browser);
			global::CefSharp.IBrowser browserCore = browser.BrowserCore;
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserNull(browserCore);
			return browserCore.FocusedFrame;
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00006FE6 File Offset: 0x000051E6
		public static void Undo(this global::CefSharp.IChromiumWebBrowserBase browser)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfChromiumWebBrowserDisposed(browser);
			browser.BrowserCore.Undo();
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00006FFC File Offset: 0x000051FC
		public static void Undo(this global::CefSharp.IBrowser browser)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserNull(browser);
			using (global::CefSharp.IFrame focusedFrame = browser.FocusedFrame)
			{
				global::CefSharp.WebBrowserExtensions.ThrowExceptionIfFrameNull(focusedFrame);
				focusedFrame.Undo();
			}
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00007040 File Offset: 0x00005240
		public static void Redo(this global::CefSharp.IChromiumWebBrowserBase browser)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfChromiumWebBrowserDisposed(browser);
			browser.BrowserCore.Redo();
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00007054 File Offset: 0x00005254
		public static void Redo(this global::CefSharp.IBrowser browser)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserNull(browser);
			using (global::CefSharp.IFrame focusedFrame = browser.FocusedFrame)
			{
				global::CefSharp.WebBrowserExtensions.ThrowExceptionIfFrameNull(focusedFrame);
				focusedFrame.Redo();
			}
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00007098 File Offset: 0x00005298
		public static void Cut(this global::CefSharp.IChromiumWebBrowserBase browser)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfChromiumWebBrowserDisposed(browser);
			browser.BrowserCore.Cut();
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x000070AC File Offset: 0x000052AC
		public static void Cut(this global::CefSharp.IBrowser browser)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserNull(browser);
			using (global::CefSharp.IFrame focusedFrame = browser.FocusedFrame)
			{
				global::CefSharp.WebBrowserExtensions.ThrowExceptionIfFrameNull(focusedFrame);
				focusedFrame.Cut();
			}
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x000070F0 File Offset: 0x000052F0
		public static void Copy(this global::CefSharp.IChromiumWebBrowserBase browser)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfChromiumWebBrowserDisposed(browser);
			browser.BrowserCore.Copy();
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00007104 File Offset: 0x00005304
		public static void Copy(this global::CefSharp.IBrowser browser)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserNull(browser);
			using (global::CefSharp.IFrame focusedFrame = browser.FocusedFrame)
			{
				global::CefSharp.WebBrowserExtensions.ThrowExceptionIfFrameNull(focusedFrame);
				focusedFrame.Copy();
			}
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00007148 File Offset: 0x00005348
		public static void Paste(this global::CefSharp.IChromiumWebBrowserBase browser)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfChromiumWebBrowserDisposed(browser);
			browser.BrowserCore.Paste();
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x0000715C File Offset: 0x0000535C
		public static void Paste(this global::CefSharp.IBrowser browser)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserNull(browser);
			using (global::CefSharp.IFrame focusedFrame = browser.FocusedFrame)
			{
				global::CefSharp.WebBrowserExtensions.ThrowExceptionIfFrameNull(focusedFrame);
				focusedFrame.Paste();
			}
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x000071A0 File Offset: 0x000053A0
		public static void Delete(this global::CefSharp.IChromiumWebBrowserBase browser)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfChromiumWebBrowserDisposed(browser);
			browser.BrowserCore.Delete();
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x000071B4 File Offset: 0x000053B4
		public static void Delete(this global::CefSharp.IBrowser browser)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserNull(browser);
			using (global::CefSharp.IFrame focusedFrame = browser.FocusedFrame)
			{
				global::CefSharp.WebBrowserExtensions.ThrowExceptionIfFrameNull(focusedFrame);
				focusedFrame.Delete();
			}
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x000071F8 File Offset: 0x000053F8
		public static void SelectAll(this global::CefSharp.IChromiumWebBrowserBase browser)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfChromiumWebBrowserDisposed(browser);
			browser.BrowserCore.SelectAll();
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x0000720C File Offset: 0x0000540C
		public static void SelectAll(this global::CefSharp.IBrowser browser)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserNull(browser);
			using (global::CefSharp.IFrame focusedFrame = browser.FocusedFrame)
			{
				global::CefSharp.WebBrowserExtensions.ThrowExceptionIfFrameNull(focusedFrame);
				focusedFrame.SelectAll();
			}
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00007250 File Offset: 0x00005450
		public static void ViewSource(this global::CefSharp.IChromiumWebBrowserBase browser)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfChromiumWebBrowserDisposed(browser);
			browser.BrowserCore.ViewSource();
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00007264 File Offset: 0x00005464
		public static void ViewSource(this global::CefSharp.IBrowser browser)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserNull(browser);
			using (global::CefSharp.IFrame mainFrame = browser.MainFrame)
			{
				global::CefSharp.WebBrowserExtensions.ThrowExceptionIfFrameNull(mainFrame);
				mainFrame.ViewSource();
			}
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x000072A8 File Offset: 0x000054A8
		public static global::System.Threading.Tasks.Task<string> GetSourceAsync(this global::CefSharp.IChromiumWebBrowserBase browser)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfChromiumWebBrowserDisposed(browser);
			return browser.BrowserCore.GetSourceAsync();
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x000072BC File Offset: 0x000054BC
		public static global::System.Threading.Tasks.Task<string> GetSourceAsync(this global::CefSharp.IBrowser browser)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserNull(browser);
			global::System.Threading.Tasks.Task<string> sourceAsync;
			using (global::CefSharp.IFrame focusedFrame = browser.FocusedFrame)
			{
				global::CefSharp.WebBrowserExtensions.ThrowExceptionIfFrameNull(focusedFrame);
				sourceAsync = focusedFrame.GetSourceAsync();
			}
			return sourceAsync;
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00007300 File Offset: 0x00005500
		public static global::System.Threading.Tasks.Task<string> GetTextAsync(this global::CefSharp.IChromiumWebBrowserBase browser)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfChromiumWebBrowserDisposed(browser);
			return browser.BrowserCore.GetTextAsync();
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00007314 File Offset: 0x00005514
		public static global::System.Threading.Tasks.Task<string> GetTextAsync(this global::CefSharp.IBrowser browser)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserNull(browser);
			global::System.Threading.Tasks.Task<string> textAsync;
			using (global::CefSharp.IFrame focusedFrame = browser.FocusedFrame)
			{
				global::CefSharp.WebBrowserExtensions.ThrowExceptionIfFrameNull(focusedFrame);
				textAsync = focusedFrame.GetTextAsync();
			}
			return textAsync;
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00007358 File Offset: 0x00005558
		public static void StartDownload(this global::CefSharp.IChromiumWebBrowserBase browser, string url)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfChromiumWebBrowserDisposed(browser);
			browser.BrowserCore.StartDownload(url);
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x0000736C File Offset: 0x0000556C
		public static void StartDownload(this global::CefSharp.IBrowser browser, string url)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserNull(browser);
			global::CefSharp.IBrowserHost host = browser.GetHost();
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserHostNull(host);
			host.StartDownload(url);
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00007394 File Offset: 0x00005594
		public static global::System.Threading.Tasks.Task<global::CefSharp.LoadUrlAsyncResponse> LoadUrlAsync(global::CefSharp.IChromiumWebBrowserBase chromiumWebBrowser, string url)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfChromiumWebBrowserDisposed(chromiumWebBrowser);
			if (string.IsNullOrEmpty(url))
			{
				throw new global::System.ArgumentNullException("url");
			}
			global::System.Threading.Tasks.TaskCompletionSource<global::CefSharp.LoadUrlAsyncResponse> tcs = new global::System.Threading.Tasks.TaskCompletionSource<global::CefSharp.LoadUrlAsyncResponse>();
			global::System.EventHandler<global::CefSharp.LoadErrorEventArgs> loadErrorHandler = null;
			global::System.EventHandler<global::CefSharp.LoadingStateChangedEventArgs> loadingStateChangeHandler = null;
			loadErrorHandler = delegate(object sender, global::CefSharp.LoadErrorEventArgs args)
			{
				if (args.ErrorCode == global::CefSharp.CefErrorCode.Aborted)
				{
					return;
				}
				chromiumWebBrowser.LoadError -= loadErrorHandler;
				chromiumWebBrowser.LoadingStateChanged -= loadingStateChangeHandler;
				tcs.TrySetResultAsync(new global::CefSharp.LoadUrlAsyncResponse(args.ErrorCode, -1));
			};
			loadingStateChangeHandler = delegate(object sender, global::CefSharp.LoadingStateChangedEventArgs args)
			{
				if (!args.IsLoading)
				{
					chromiumWebBrowser.LoadError -= loadErrorHandler;
					chromiumWebBrowser.LoadingStateChanged -= loadingStateChangeHandler;
					global::CefSharp.IBrowserHost host = args.Browser.GetHost();
					global::CefSharp.NavigationEntry navigationEntry = (host != null) ? host.GetVisibleNavigationEntry() : null;
					int num = (navigationEntry != null) ? navigationEntry.HttpStatusCode : -1;
					if (num == 0)
					{
						num = -1;
					}
					tcs.TrySetResultAsync(new global::CefSharp.LoadUrlAsyncResponse((num == -1) ? global::CefSharp.CefErrorCode.Failed : global::CefSharp.CefErrorCode.None, num));
				}
			};
			chromiumWebBrowser.LoadError += loadErrorHandler;
			chromiumWebBrowser.LoadingStateChanged += loadingStateChangeHandler;
			chromiumWebBrowser.LoadUrl(url);
			return tcs.Task;
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00007444 File Offset: 0x00005644
		public static global::System.Threading.Tasks.Task<global::CefSharp.WaitForNavigationAsyncResponse> WaitForNavigationAsync(global::CefSharp.IChromiumWebBrowserBase chromiumWebBrowser, global::System.TimeSpan? timeout = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			global::CefSharp.WebBrowserExtensions.<WaitForNavigationAsync>d__30 <WaitForNavigationAsync>d__;
			<WaitForNavigationAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<global::CefSharp.WaitForNavigationAsyncResponse>.Create();
			<WaitForNavigationAsync>d__.chromiumWebBrowser = chromiumWebBrowser;
			<WaitForNavigationAsync>d__.timeout = timeout;
			<WaitForNavigationAsync>d__.cancellationToken = cancellationToken;
			<WaitForNavigationAsync>d__.<>1__state = -1;
			<WaitForNavigationAsync>d__.<>t__builder.Start<global::CefSharp.WebBrowserExtensions.<WaitForNavigationAsync>d__30>(ref <WaitForNavigationAsync>d__);
			return <WaitForNavigationAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x00007498 File Offset: 0x00005698
		public static global::System.Threading.Tasks.Task<global::CefSharp.WaitForSelectorAsyncResponse> WaitForSelectorAsync(this global::CefSharp.IWebBrowser chromiumWebBrowser, string selector, global::System.TimeSpan? timeout = null, bool removed = false)
		{
			global::CefSharp.WebBrowserExtensions.<WaitForSelectorAsync>d__31 <WaitForSelectorAsync>d__;
			<WaitForSelectorAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<global::CefSharp.WaitForSelectorAsyncResponse>.Create();
			<WaitForSelectorAsync>d__.chromiumWebBrowser = chromiumWebBrowser;
			<WaitForSelectorAsync>d__.selector = selector;
			<WaitForSelectorAsync>d__.timeout = timeout;
			<WaitForSelectorAsync>d__.removed = removed;
			<WaitForSelectorAsync>d__.<>1__state = -1;
			<WaitForSelectorAsync>d__.<>t__builder.Start<global::CefSharp.WebBrowserExtensions.<WaitForSelectorAsync>d__31>(ref <WaitForSelectorAsync>d__);
			return <WaitForSelectorAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x000074F3 File Offset: 0x000056F3
		public static void ExecuteScriptAsync(this global::CefSharp.IChromiumWebBrowserBase browser, string methodName, params object[] args)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfChromiumWebBrowserDisposed(browser);
			browser.BrowserCore.ExecuteScriptAsync(methodName, args);
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00007508 File Offset: 0x00005708
		public static void ExecuteScriptAsync(this global::CefSharp.IBrowser browser, string methodName, params object[] args)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserNull(browser);
			string scriptForJavascriptMethodWithArgs = global::CefSharp.WebBrowserExtensions.GetScriptForJavascriptMethodWithArgs(methodName, args);
			browser.ExecuteScriptAsync(scriptForJavascriptMethodWithArgs);
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x0000752C File Offset: 0x0000572C
		public static void ExecuteScriptAsync(this global::CefSharp.IChromiumWebBrowserBase browser, string script)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfChromiumWebBrowserDisposed(browser);
			using (global::CefSharp.IFrame mainFrame = browser.GetMainFrame())
			{
				global::CefSharp.WebBrowserExtensions.ThrowExceptionIfFrameNull(mainFrame);
				mainFrame.ExecuteJavaScriptAsync(script, "about:blank", 1);
			}
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x00007578 File Offset: 0x00005778
		public static void ExecuteScriptAsync(this global::CefSharp.IBrowser browser, string script)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserNull(browser);
			using (global::CefSharp.IFrame mainFrame = browser.MainFrame)
			{
				global::CefSharp.WebBrowserExtensions.ThrowExceptionIfFrameNull(mainFrame);
				mainFrame.ExecuteJavaScriptAsync(script, "about:blank", 1);
			}
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x000075C4 File Offset: 0x000057C4
		public static void ExecuteScriptAsyncWhenPageLoaded(this global::CefSharp.IChromiumWebBrowserBase webBrowser, string script, bool oneTime = true)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfChromiumWebBrowserDisposed(webBrowser);
			bool flag = !webBrowser.IsBrowserInitialized || !oneTime;
			if (webBrowser.IsBrowserInitialized)
			{
				global::CefSharp.IBrowser browserCore = webBrowser.BrowserCore;
				if (browserCore.HasDocument && !browserCore.IsLoading)
				{
					webBrowser.ExecuteScriptAsync(script);
				}
				else
				{
					flag = true;
				}
			}
			if (flag)
			{
				global::System.EventHandler<global::CefSharp.LoadingStateChangedEventArgs> handler = null;
				handler = delegate(object sender, global::CefSharp.LoadingStateChangedEventArgs args)
				{
					if (!args.IsLoading)
					{
						if (oneTime)
						{
							webBrowser.LoadingStateChanged -= handler;
						}
						webBrowser.ExecuteScriptAsync(script);
					}
				};
				webBrowser.LoadingStateChanged += handler;
			}
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x0000767C File Offset: 0x0000587C
		public static void LoadUrlWithPostData(this global::CefSharp.IChromiumWebBrowserBase browser, string url, byte[] postDataBytes, string contentType = null)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfChromiumWebBrowserDisposed(browser);
			browser.BrowserCore.LoadUrlWithPostData(url, postDataBytes, contentType);
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x00007694 File Offset: 0x00005894
		public static void LoadUrlWithPostData(this global::CefSharp.IBrowser browser, string url, byte[] postDataBytes, string contentType = null)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserNull(browser);
			using (global::CefSharp.IFrame mainFrame = browser.MainFrame)
			{
				global::CefSharp.WebBrowserExtensions.ThrowExceptionIfFrameNull(mainFrame);
				global::CefSharp.IRequest request = mainFrame.CreateRequest(true);
				request.Url = url;
				request.Method = "POST";
				request.Flags = global::CefSharp.UrlRequestFlags.AllowStoredCredentials;
				request.PostData.AddData(postDataBytes);
				if (!string.IsNullOrEmpty(contentType))
				{
					request.Headers = new global::System.Collections.Specialized.NameValueCollection
					{
						{
							"Content-Type",
							contentType
						}
					};
				}
				mainFrame.LoadRequest(request);
			}
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00007728 File Offset: 0x00005928
		public static bool LoadHtml(this global::CefSharp.IWebBrowser browser, string html, string url)
		{
			return browser.LoadHtml(html, url, global::System.Text.Encoding.UTF8, false);
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x00007738 File Offset: 0x00005938
		public static void LoadHtml(this global::CefSharp.IChromiumWebBrowserBase browser, string html, bool base64Encode = false)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfChromiumWebBrowserDisposed(browser);
			global::CefSharp.Web.HtmlString htmlString = new global::CefSharp.Web.HtmlString(html, base64Encode, null);
			browser.LoadUrl(htmlString.ToDataUriString());
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x00007760 File Offset: 0x00005960
		public static void LoadHtml(this global::CefSharp.IFrame frame, string html, bool base64Encode = false)
		{
			global::CefSharp.Web.HtmlString htmlString = new global::CefSharp.Web.HtmlString(html, base64Encode, null);
			frame.LoadUrl(htmlString.ToDataUriString());
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00007784 File Offset: 0x00005984
		public static bool LoadHtml(this global::CefSharp.IWebBrowser browser, string html, string url, global::System.Text.Encoding encoding, bool oneTimeUse = false)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfChromiumWebBrowserDisposed(browser);
			if (browser.ResourceRequestHandlerFactory == null)
			{
				browser.ResourceRequestHandlerFactory = new global::CefSharp.ResourceRequestHandlerFactory(null);
			}
			global::CefSharp.ResourceRequestHandlerFactory resourceRequestHandlerFactory = browser.ResourceRequestHandlerFactory as global::CefSharp.ResourceRequestHandlerFactory;
			if (resourceRequestHandlerFactory == null)
			{
				throw new global::System.Exception("LoadHtml can only be used with the default IResourceRequestHandlerFactory(DefaultResourceRequestHandlerFactory) implementation");
			}
			if (resourceRequestHandlerFactory.RegisterHandler(url, global::CefSharp.ResourceHandler.GetByteArray(html, encoding, true), "text/html", oneTimeUse))
			{
				browser.Load(url);
				return true;
			}
			return false;
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x000077E8 File Offset: 0x000059E8
		public static void RegisterResourceHandler(this global::CefSharp.IWebBrowser browser, string url, global::System.IO.Stream stream, string mimeType = "text/html", bool oneTimeUse = false)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfChromiumWebBrowserDisposed(browser);
			if (browser.ResourceRequestHandlerFactory == null)
			{
				browser.ResourceRequestHandlerFactory = new global::CefSharp.ResourceRequestHandlerFactory(null);
			}
			global::CefSharp.ResourceRequestHandlerFactory resourceRequestHandlerFactory = browser.ResourceRequestHandlerFactory as global::CefSharp.ResourceRequestHandlerFactory;
			if (resourceRequestHandlerFactory == null)
			{
				throw new global::System.Exception("RegisterResourceHandler can only be used with the default IResourceRequestHandlerFactory(DefaultResourceRequestHandlerFactory) implementation");
			}
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
			{
				stream.CopyTo(memoryStream);
				resourceRequestHandlerFactory.RegisterHandler(url, memoryStream.ToArray(), mimeType, oneTimeUse);
			}
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x00007864 File Offset: 0x00005A64
		public static void UnRegisterResourceHandler(this global::CefSharp.IWebBrowser browser, string url)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfChromiumWebBrowserDisposed(browser);
			global::CefSharp.ResourceRequestHandlerFactory resourceRequestHandlerFactory = browser.ResourceRequestHandlerFactory as global::CefSharp.ResourceRequestHandlerFactory;
			if (resourceRequestHandlerFactory == null)
			{
				throw new global::System.Exception("UnRegisterResourceHandler can only be used with the default IResourceRequestHandlerFactory(DefaultResourceRequestHandlerFactory) implementation");
			}
			resourceRequestHandlerFactory.UnregisterHandler(url);
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00007899 File Offset: 0x00005A99
		public static void Stop(this global::CefSharp.IChromiumWebBrowserBase browser)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfChromiumWebBrowserDisposed(browser);
			browser.BrowserCore.Stop();
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x000078AC File Offset: 0x00005AAC
		public static void Stop(this global::CefSharp.IBrowser browser)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserNull(browser);
			browser.StopLoad();
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x000078BA File Offset: 0x00005ABA
		public static void Back(this global::CefSharp.IChromiumWebBrowserBase browser)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfChromiumWebBrowserDisposed(browser);
			browser.BrowserCore.Back();
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x000078CD File Offset: 0x00005ACD
		public static void Back(this global::CefSharp.IBrowser browser)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserNull(browser);
			browser.GoBack();
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x000078DB File Offset: 0x00005ADB
		public static void Forward(this global::CefSharp.IChromiumWebBrowserBase browser)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfChromiumWebBrowserDisposed(browser);
			browser.BrowserCore.Forward();
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x000078EE File Offset: 0x00005AEE
		public static void Forward(this global::CefSharp.IBrowser browser)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserNull(browser);
			browser.GoForward();
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x000078FC File Offset: 0x00005AFC
		public static void Reload(this global::CefSharp.IChromiumWebBrowserBase browser)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfChromiumWebBrowserDisposed(browser);
			browser.Reload(false);
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x0000790B File Offset: 0x00005B0B
		public static void Reload(this global::CefSharp.IChromiumWebBrowserBase browser, bool ignoreCache)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfChromiumWebBrowserDisposed(browser);
			browser.BrowserCore.Reload(ignoreCache);
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x0000791F File Offset: 0x00005B1F
		public static void Reload(this global::CefSharp.IBrowser browser, bool ignoreCache = false)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserNull(browser);
			browser.Reload(ignoreCache);
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00007930 File Offset: 0x00005B30
		public static global::CefSharp.ICookieManager GetCookieManager(this global::CefSharp.IChromiumWebBrowserBase browser, global::CefSharp.ICompletionCallback callback = null)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfChromiumWebBrowserDisposed(browser);
			global::CefSharp.IBrowserHost browserHost = browser.GetBrowserHost();
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserHostNull(browserHost);
			global::CefSharp.IRequestContext requestContext = browserHost.RequestContext;
			if (requestContext == null)
			{
				throw new global::System.Exception("RequestContext is null, unable to obtain cookie manager");
			}
			return requestContext.GetCookieManager(callback);
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x0000796C File Offset: 0x00005B6C
		public static global::CefSharp.IRequestContext GetRequestContext(this global::CefSharp.IChromiumWebBrowserBase browser)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfChromiumWebBrowserDisposed(browser);
			global::CefSharp.IBrowserHost browserHost = browser.GetBrowserHost();
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserHostNull(browserHost);
			return browserHost.RequestContext;
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x00007994 File Offset: 0x00005B94
		public static global::System.Threading.Tasks.Task<double> GetZoomLevelAsync(this global::CefSharp.IBrowser browser)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserNull(browser);
			global::CefSharp.IBrowserHost host = browser.GetHost();
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserHostNull(host);
			return host.GetZoomLevelAsync();
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x000079BA File Offset: 0x00005BBA
		public static global::System.Threading.Tasks.Task<double> GetZoomLevelAsync(this global::CefSharp.IChromiumWebBrowserBase browser)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfChromiumWebBrowserDisposed(browser);
			return browser.BrowserCore.GetZoomLevelAsync();
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x000079D0 File Offset: 0x00005BD0
		public static void SetZoomLevel(this global::CefSharp.IBrowser browser, double zoomLevel)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserNull(browser);
			global::CefSharp.IBrowserHost host = browser.GetHost();
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserHostNull(host);
			host.SetZoomLevel(zoomLevel);
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x000079F7 File Offset: 0x00005BF7
		public static void SetZoomLevel(this global::CefSharp.IChromiumWebBrowserBase browser, double zoomLevel)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfChromiumWebBrowserDisposed(browser);
			browser.BrowserCore.SetZoomLevel(zoomLevel);
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00007A0C File Offset: 0x00005C0C
		public static void Find(this global::CefSharp.IBrowser browser, string searchText, bool forward, bool matchCase, bool findNext)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserNull(browser);
			global::CefSharp.IBrowserHost host = browser.GetHost();
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserHostNull(host);
			host.Find(searchText, forward, matchCase, findNext);
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x00007A37 File Offset: 0x00005C37
		public static void Find(this global::CefSharp.IChromiumWebBrowserBase browser, string searchText, bool forward, bool matchCase, bool findNext)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfChromiumWebBrowserDisposed(browser);
			browser.BrowserCore.Find(searchText, forward, matchCase, findNext);
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x00007A50 File Offset: 0x00005C50
		public static void StopFinding(this global::CefSharp.IBrowser browser, bool clearSelection)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserNull(browser);
			global::CefSharp.IBrowserHost host = browser.GetHost();
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserHostNull(host);
			host.StopFinding(clearSelection);
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x00007A77 File Offset: 0x00005C77
		public static void StopFinding(this global::CefSharp.IChromiumWebBrowserBase browser, bool clearSelection)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfChromiumWebBrowserDisposed(browser);
			browser.BrowserCore.StopFinding(clearSelection);
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00007A8C File Offset: 0x00005C8C
		public static void Print(this global::CefSharp.IBrowser browser)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserNull(browser);
			global::CefSharp.IBrowserHost host = browser.GetHost();
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserHostNull(host);
			host.Print();
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x00007AB2 File Offset: 0x00005CB2
		public static void Print(this global::CefSharp.IChromiumWebBrowserBase browser)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfChromiumWebBrowserDisposed(browser);
			browser.BrowserCore.Print();
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00007AC8 File Offset: 0x00005CC8
		public static global::System.Threading.Tasks.Task<bool> PrintToPdfAsync(this global::CefSharp.IBrowser browser, string path, global::CefSharp.PdfPrintSettings settings = null)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserNull(browser);
			global::CefSharp.IBrowserHost host = browser.GetHost();
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserHostNull(host);
			global::CefSharp.TaskPrintToPdfCallback taskPrintToPdfCallback = new global::CefSharp.TaskPrintToPdfCallback();
			host.PrintToPdf(path, settings, taskPrintToPdfCallback);
			return taskPrintToPdfCallback.Task;
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00007AFD File Offset: 0x00005CFD
		public static global::System.Threading.Tasks.Task<bool> PrintToPdfAsync(this global::CefSharp.IChromiumWebBrowserBase browser, string path, global::CefSharp.PdfPrintSettings settings = null)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfChromiumWebBrowserDisposed(browser);
			return browser.BrowserCore.PrintToPdfAsync(path, settings);
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x00007B14 File Offset: 0x00005D14
		public static void ShowDevTools(this global::CefSharp.IBrowser browser, global::CefSharp.IWindowInfo windowInfo = null, int inspectElementAtX = 0, int inspectElementAtY = 0)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserNull(browser);
			global::CefSharp.IBrowserHost host = browser.GetHost();
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserHostNull(host);
			host.ShowDevTools(windowInfo, inspectElementAtX, inspectElementAtY);
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x00007B3D File Offset: 0x00005D3D
		public static void ShowDevTools(this global::CefSharp.IChromiumWebBrowserBase browser, global::CefSharp.IWindowInfo windowInfo = null, int inspectElementAtX = 0, int inspectElementAtY = 0)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfChromiumWebBrowserDisposed(browser);
			browser.BrowserCore.ShowDevTools(windowInfo, inspectElementAtX, inspectElementAtY);
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x00007B54 File Offset: 0x00005D54
		public static void CloseDevTools(this global::CefSharp.IBrowser browser)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserNull(browser);
			global::CefSharp.IBrowserHost host = browser.GetHost();
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserHostNull(host);
			host.CloseDevTools();
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x00007B7A File Offset: 0x00005D7A
		public static void CloseDevTools(this global::CefSharp.IChromiumWebBrowserBase browser)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfChromiumWebBrowserDisposed(browser);
			browser.BrowserCore.CloseDevTools();
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00007B90 File Offset: 0x00005D90
		public static void ReplaceMisspelling(this global::CefSharp.IBrowser browser, string word)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserNull(browser);
			global::CefSharp.IBrowserHost host = browser.GetHost();
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserHostNull(host);
			host.ReplaceMisspelling(word);
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00007BB7 File Offset: 0x00005DB7
		public static void ReplaceMisspelling(this global::CefSharp.IChromiumWebBrowserBase browser, string word)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfChromiumWebBrowserDisposed(browser);
			browser.BrowserCore.ReplaceMisspelling(word);
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00007BCC File Offset: 0x00005DCC
		public static void AddWordToDictionary(this global::CefSharp.IBrowser browser, string word)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserNull(browser);
			global::CefSharp.IBrowserHost host = browser.GetHost();
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserHostNull(host);
			host.AddWordToDictionary(word);
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00007BF3 File Offset: 0x00005DF3
		public static void AddWordToDictionary(this global::CefSharp.IChromiumWebBrowserBase browser, string word)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfChromiumWebBrowserDisposed(browser);
			browser.BrowserCore.AddWordToDictionary(word);
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00007C07 File Offset: 0x00005E07
		public static global::CefSharp.IBrowserHost GetBrowserHost(this global::CefSharp.IChromiumWebBrowserBase browser)
		{
			global::CefSharp.IBrowser browserCore = browser.BrowserCore;
			if (browserCore == null)
			{
				return null;
			}
			return browserCore.GetHost();
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00007C1A File Offset: 0x00005E1A
		public static void SendMouseWheelEvent(this global::CefSharp.IChromiumWebBrowserBase browser, int x, int y, int deltaX, int deltaY, global::CefSharp.CefEventFlags modifiers)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfChromiumWebBrowserDisposed(browser);
			browser.BrowserCore.SendMouseWheelEvent(x, y, deltaX, deltaY, modifiers);
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00007C34 File Offset: 0x00005E34
		public static void SendMouseWheelEvent(this global::CefSharp.IBrowser browser, int x, int y, int deltaX, int deltaY, global::CefSharp.CefEventFlags modifiers)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserNull(browser);
			global::CefSharp.IBrowserHost host = browser.GetHost();
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserHostNull(host);
			host.SendMouseWheelEvent(new global::CefSharp.MouseEvent(x, y, modifiers), deltaX, deltaY);
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00007C66 File Offset: 0x00005E66
		public static void SendMouseWheelEvent(this global::CefSharp.IBrowserHost host, int x, int y, int deltaX, int deltaY, global::CefSharp.CefEventFlags modifiers)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserHostNull(host);
			host.SendMouseWheelEvent(new global::CefSharp.MouseEvent(x, y, modifiers), deltaX, deltaY);
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00007C80 File Offset: 0x00005E80
		public static void SendMouseClickEvent(this global::CefSharp.IBrowserHost host, int x, int y, global::CefSharp.MouseButtonType mouseButtonType, bool mouseUp, int clickCount, global::CefSharp.CefEventFlags modifiers)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserHostNull(host);
			host.SendMouseClickEvent(new global::CefSharp.MouseEvent(x, y, modifiers), mouseButtonType, mouseUp, clickCount);
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00007C9C File Offset: 0x00005E9C
		public static void SendMouseMoveEvent(this global::CefSharp.IBrowserHost host, int x, int y, bool mouseLeave, global::CefSharp.CefEventFlags modifiers)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserHostNull(host);
			host.SendMouseMoveEvent(new global::CefSharp.MouseEvent(x, y, modifiers), mouseLeave);
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x00007CB4 File Offset: 0x00005EB4
		public static global::System.Threading.Tasks.Task<global::CefSharp.JavascriptResponse> EvaluateScriptAsPromiseAsync(this global::CefSharp.IWebBrowser chromiumWebBrowser, string script, global::System.TimeSpan? timeout = null)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfChromiumWebBrowserDisposed(chromiumWebBrowser);
			global::CefSharp.JavascriptBinding.JavascriptBindingSettings settings = chromiumWebBrowser.JavascriptObjectRepository.Settings;
			string promiseHandlerScript = global::CefSharp.WebBrowserExtensions.GetPromiseHandlerScript(script, settings.JavascriptBindingApiGlobalObjectName);
			return chromiumWebBrowser.EvaluateScriptAsync(promiseHandlerScript, timeout, true);
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x00007CEC File Offset: 0x00005EEC
		public static global::System.Threading.Tasks.Task<global::CefSharp.JavascriptResponse> EvaluateScriptAsPromiseAsync(this global::CefSharp.IBrowser browser, string script, global::System.TimeSpan? timeout = null)
		{
			string promiseHandlerScript = global::CefSharp.WebBrowserExtensions.GetPromiseHandlerScript(script, null);
			return browser.EvaluateScriptAsync(promiseHandlerScript, timeout, true);
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x00007D0C File Offset: 0x00005F0C
		public static global::System.Threading.Tasks.Task<global::CefSharp.JavascriptResponse> EvaluateScriptAsPromiseAsync(this global::CefSharp.IFrame frame, string script, global::System.TimeSpan? timeout = null, string javascriptBindingApiGlobalObjectName = null)
		{
			string promiseHandlerScript = global::CefSharp.WebBrowserExtensions.GetPromiseHandlerScript(script, javascriptBindingApiGlobalObjectName);
			return frame.EvaluateScriptAsync(promiseHandlerScript, "about:blank", 1, timeout, true);
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x00007D30 File Offset: 0x00005F30
		private static string GetPromiseHandlerScript(string script, string javascriptBindingApiGlobalObjectName)
		{
			string text = "cefSharp.sendEvalScriptResponse";
			if (!string.IsNullOrWhiteSpace(javascriptBindingApiGlobalObjectName))
			{
				if (char.IsLower(javascriptBindingApiGlobalObjectName[0]))
				{
					text = javascriptBindingApiGlobalObjectName + ".sendEvalScriptResponse";
				}
				else
				{
					text = javascriptBindingApiGlobalObjectName + ".SendEvalScriptResponse";
				}
			}
			return string.Concat(new string[]
			{
				"let innerImmediatelyInvokedFuncExpression = (async function() { ",
				script,
				" })(); Promise.resolve(innerImmediatelyInvokedFuncExpression).then((val) => ",
				text,
				"(cefSharpInternalCallbackId, true, val, false)).catch ((reason) => ",
				text,
				"(cefSharpInternalCallbackId, false, String(reason), false)); return 'CefSharpDefEvalScriptRes';"
			});
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x00007DB0 File Offset: 0x00005FB0
		public static global::System.Threading.Tasks.Task<global::CefSharp.JavascriptResponse> EvaluateScriptAsync(this global::CefSharp.IChromiumWebBrowserBase browser, string script, global::System.TimeSpan? timeout = null, bool useImmediatelyInvokedFuncExpression = false)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfChromiumWebBrowserDisposed(browser);
			global::CefSharp.IWebBrowser webBrowser = browser as global::CefSharp.IWebBrowser;
			if (webBrowser != null && !webBrowser.CanExecuteJavascriptInMainFrame)
			{
				global::CefSharp.WebBrowserExtensions.ThrowExceptionIfCanExecuteJavascriptInMainFrameFalse();
			}
			return browser.BrowserCore.EvaluateScriptAsync(script, timeout, useImmediatelyInvokedFuncExpression);
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00007DE8 File Offset: 0x00005FE8
		public static global::System.Threading.Tasks.Task<global::CefSharp.JavascriptResponse> EvaluateScriptAsync(this global::CefSharp.IBrowser browser, string script, global::System.TimeSpan? timeout = null, bool useImmediatelyInvokedFuncExpression = false)
		{
			if (timeout != null && timeout.Value.TotalMilliseconds > 4294967295.0)
			{
				throw new global::System.ArgumentOutOfRangeException("timeout", "Timeout greater than Maximum allowable value of " + uint.MaxValue.ToString());
			}
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfBrowserNull(browser);
			global::System.Threading.Tasks.Task<global::CefSharp.JavascriptResponse> result;
			using (global::CefSharp.IFrame mainFrame = browser.MainFrame)
			{
				global::CefSharp.WebBrowserExtensions.ThrowExceptionIfFrameNull(mainFrame);
				result = mainFrame.EvaluateScriptAsync(script, "about:blank", 1, timeout, useImmediatelyInvokedFuncExpression);
			}
			return result;
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x00007E78 File Offset: 0x00006078
		public static global::System.Threading.Tasks.Task<global::CefSharp.JavascriptResponse> EvaluateScriptAsync(this global::CefSharp.IChromiumWebBrowserBase browser, string methodName, params object[] args)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfChromiumWebBrowserDisposed(browser);
			return browser.EvaluateScriptAsync(null, methodName, args);
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x00007E9C File Offset: 0x0000609C
		public static global::System.Threading.Tasks.Task<global::CefSharp.JavascriptResponse> EvaluateScriptAsync(this global::CefSharp.IChromiumWebBrowserBase browser, global::System.TimeSpan? timeout, string methodName, params object[] args)
		{
			global::CefSharp.WebBrowserExtensions.ThrowExceptionIfChromiumWebBrowserDisposed(browser);
			string scriptForJavascriptMethodWithArgs = global::CefSharp.WebBrowserExtensions.GetScriptForJavascriptMethodWithArgs(methodName, args);
			return browser.EvaluateScriptAsync(scriptForJavascriptMethodWithArgs, timeout, false);
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00007EC0 File Offset: 0x000060C0
		public static void SetAsPopup(this global::CefSharp.IWebBrowser browser)
		{
			global::CefSharp.Internals.IWebBrowserInternal webBrowserInternal = (global::CefSharp.Internals.IWebBrowserInternal)browser;
			webBrowserInternal.HasParent = true;
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00007EDB File Offset: 0x000060DB
		public static void DisposeDevToolsContext(this global::CefSharp.Internals.IWebBrowserInternal webBrowserInternal)
		{
			if (webBrowserInternal == null)
			{
				return;
			}
			global::System.IDisposable devToolsContext = webBrowserInternal.DevToolsContext;
			if (devToolsContext != null)
			{
				devToolsContext.Dispose();
			}
			webBrowserInternal.DevToolsContext = null;
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00007EF9 File Offset: 0x000060F9
		public static void FreeDevToolsContext(this global::CefSharp.Internals.IWebBrowserInternal webBrowserInternal)
		{
			if (webBrowserInternal == null)
			{
				return;
			}
			webBrowserInternal.DevToolsContext = null;
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x00007F06 File Offset: 0x00006106
		// (set) Token: 0x06000511 RID: 1297 RVA: 0x00007F0D File Offset: 0x0000610D
		public static global::System.Func<string, string> EncodeScriptParam { get; set; } = (string str) => str.Replace("\\", "\\\\").Replace("'", "\\'").Replace("\t", "\\t").Replace("\r", "\\r").Replace("\n", "\\n");

		// Token: 0x06000512 RID: 1298 RVA: 0x00007F18 File Offset: 0x00006118
		private static bool IsNumeric(this object value)
		{
			return value is sbyte || value is byte || value is short || value is ushort || value is int || value is uint || value is long || value is ulong || value is float || value is double || value is decimal;
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00007F80 File Offset: 0x00006180
		public static string GetScriptForJavascriptMethodWithArgs(string methodName, object[] args)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(methodName);
			stringBuilder.Append("(");
			if (args.Length != 0)
			{
				for (int i = 0; i < args.Length; i++)
				{
					object obj = args[i];
					if (obj == null)
					{
						stringBuilder.Append("null");
					}
					else if (obj.IsNumeric())
					{
						stringBuilder.Append(global::System.Convert.ToString(args[i], global::System.Globalization.CultureInfo.InvariantCulture));
					}
					else if (obj is bool)
					{
						stringBuilder.Append(args[i].ToString().ToLowerInvariant());
					}
					else
					{
						stringBuilder.Append("'");
						stringBuilder.Append(global::CefSharp.WebBrowserExtensions.EncodeScriptParam(obj.ToString()));
						stringBuilder.Append("'");
					}
					stringBuilder.Append(", ");
				}
				stringBuilder.Remove(stringBuilder.Length - 2, 2);
			}
			stringBuilder.Append(");");
			return stringBuilder.ToString();
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00008070 File Offset: 0x00006270
		public static void ThrowExceptionIfChromiumWebBrowserDisposed(global::CefSharp.IChromiumWebBrowserBase browser)
		{
			if (browser == null)
			{
				throw new global::System.ArgumentNullException("browser");
			}
			if (browser.IsDisposed)
			{
				global::System.Type type = browser.GetType();
				throw new global::System.ObjectDisposedException(type.Name);
			}
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x000080A6 File Offset: 0x000062A6
		public static void ThrowExceptionIfFrameNull(global::CefSharp.IFrame frame)
		{
			if (frame == null)
			{
				throw new global::System.Exception("IFrame instance is null. Browser has likely not finished initializing or is in the process of disposing.");
			}
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x000080B6 File Offset: 0x000062B6
		public static void ThrowExceptionIfBrowserNull(global::CefSharp.IBrowser browser)
		{
			if (browser == null)
			{
				throw new global::System.Exception("IBrowser instance is null. Browser has likely not finished initializing or is in the process of disposing.");
			}
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x000080C6 File Offset: 0x000062C6
		public static void ThrowExceptionIfBrowserHostNull(global::CefSharp.IBrowserHost browserHost)
		{
			if (browserHost == null)
			{
				throw new global::System.Exception("IBrowserHost instance is null. Browser has likely not finished initializing or is in the process of disposing.");
			}
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x000080D6 File Offset: 0x000062D6
		public static void ThrowExceptionIfCanExecuteJavascriptInMainFrameFalse()
		{
			throw new global::System.Exception("Unable to execute javascript at this time, scripts can only be executed within a V8Context. Use the IWebBrowser.CanExecuteJavascriptInMainFrame property to guard against this exception. See https://github.com/cefsharp/CefSharp/wiki/General-Usage#when-can-i-start-executing-javascript for more details on when you can execute javascript. For frames that do not contain Javascript then no V8Context will be created. Executing a script once the frame has loaded it's possible to create a V8Context. You can use browser.GetMainFrame().ExecuteJavaScriptAsync(script) or browser.GetMainFrame().EvaluateScriptAsync to bypass these checks (advanced users only).");
		}

		// Token: 0x0400030C RID: 780
		public const string BrowserNullExceptionString = "IBrowser instance is null. Browser has likely not finished initializing or is in the process of disposing.";

		// Token: 0x0400030D RID: 781
		public const string BrowserHostNullExceptionString = "IBrowserHost instance is null. Browser has likely not finished initializing or is in the process of disposing.";

		// Token: 0x0400030E RID: 782
		public const string FrameNullExceptionString = "IFrame instance is null. Browser has likely not finished initializing or is in the process of disposing.";
	}
}
