using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using CefSharp.Internals;
using CefSharp.Preferences;
using CefSharp.SchemeHandler;

namespace CefSharp
{
	// Token: 0x02000092 RID: 146
	public static class RequestContextExtensions
	{
		// Token: 0x06000404 RID: 1028 RVA: 0x00003D0E File Offset: 0x00001F0E
		public static void LoadExtensionFromDirectory(this global::CefSharp.IRequestContext requestContext, string rootDirectory, global::CefSharp.IExtensionHandler handler)
		{
			requestContext.LoadExtension(global::System.IO.Path.GetFullPath(rootDirectory), null, handler);
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x00003D20 File Offset: 0x00001F20
		public static void LoadExtensionsFromDirectory(this global::CefSharp.IRequestContext requestContext, string rootDirectory, global::CefSharp.IExtensionHandler handler)
		{
			string fullPath = global::System.IO.Path.GetFullPath(rootDirectory);
			foreach (string text in global::System.IO.Directory.GetDirectories(fullPath))
			{
				if (global::System.IO.File.Exists(global::System.IO.Path.Combine(text, "manifest.json")))
				{
					requestContext.LoadExtension(text, null, handler);
				}
			}
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00003D68 File Offset: 0x00001F68
		public static global::System.Threading.Tasks.Task<global::CefSharp.ICookieManager> GetCookieManagerAsync(this global::CefSharp.IRequestContext requestContext)
		{
			global::CefSharp.RequestContextExtensions.<GetCookieManagerAsync>d__3 <GetCookieManagerAsync>d__;
			<GetCookieManagerAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<global::CefSharp.ICookieManager>.Create();
			<GetCookieManagerAsync>d__.requestContext = requestContext;
			<GetCookieManagerAsync>d__.<>1__state = -1;
			<GetCookieManagerAsync>d__.<>t__builder.Start<global::CefSharp.RequestContextExtensions.<GetCookieManagerAsync>d__3>(ref <GetCookieManagerAsync>d__);
			return <GetCookieManagerAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00003DAC File Offset: 0x00001FAC
		public static global::System.Threading.Tasks.Task<global::CefSharp.Preferences.SetPreferenceResponse> SetPreferenceAsync(this global::CefSharp.IRequestContext requestContext, string name, object value)
		{
			if (global::CefSharp.Internals.CefThread.HasShutdown)
			{
				return global::System.Threading.Tasks.Task.FromResult<global::CefSharp.Preferences.SetPreferenceResponse>(new global::CefSharp.Preferences.SetPreferenceResponse(false, "Cef.Shutdown has already been called, it is no longer possible to call SetPreferenceAsync."));
			}
			global::System.Func<global::CefSharp.Preferences.SetPreferenceResponse> func = delegate()
			{
				string errorMessage;
				bool success = requestContext.SetPreference(name, value, out errorMessage);
				return new global::CefSharp.Preferences.SetPreferenceResponse(success, errorMessage);
			};
			if (global::CefSharp.Internals.CefThread.CurrentlyOnUiThread)
			{
				return global::System.Threading.Tasks.Task.FromResult<global::CefSharp.Preferences.SetPreferenceResponse>(func());
			}
			return global::CefSharp.Internals.CefThread.ExecuteOnUiThread<global::CefSharp.Preferences.SetPreferenceResponse>(func);
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00003E12 File Offset: 0x00002012
		public static global::System.Threading.Tasks.Task<global::CefSharp.Preferences.SetProxyResponse> SetProxyAsync(this global::CefSharp.IRequestContext requestContext, string host, int? port)
		{
			return requestContext.SetProxyAsync(null, host, port);
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00003E20 File Offset: 0x00002020
		public static global::System.Threading.Tasks.Task<global::CefSharp.Preferences.SetProxyResponse> SetProxyAsync(this global::CefSharp.IRequestContext requestContext, string scheme, string host, int? port)
		{
			if (global::CefSharp.Internals.CefThread.HasShutdown)
			{
				return global::System.Threading.Tasks.Task.FromResult<global::CefSharp.Preferences.SetProxyResponse>(new global::CefSharp.Preferences.SetProxyResponse(false, "Cef.Shutdown has already been called, it is no longer possible to call SetProxyAsync."));
			}
			global::System.Func<global::CefSharp.Preferences.SetProxyResponse> func = delegate()
			{
				bool success = false;
				string errorMessage;
				if (requestContext.CanSetPreference("proxy"))
				{
					global::System.Collections.Generic.IDictionary<string, object> proxyDictionary = global::CefSharp.RequestContextExtensions.GetProxyDictionary(scheme, host, port);
					success = requestContext.SetPreference("proxy", proxyDictionary, out errorMessage);
				}
				else
				{
					errorMessage = "Unable to set the proxy preference, it is read-only. If you specified the proxy settings with command line args it is not possible to change the proxy settings via this method.";
				}
				return new global::CefSharp.Preferences.SetProxyResponse(success, errorMessage);
			};
			if (global::CefSharp.Internals.CefThread.CurrentlyOnUiThread)
			{
				return global::System.Threading.Tasks.Task.FromResult<global::CefSharp.Preferences.SetProxyResponse>(func());
			}
			return global::CefSharp.Internals.CefThread.ExecuteOnUiThread<global::CefSharp.Preferences.SetProxyResponse>(func);
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00003E90 File Offset: 0x00002090
		public static bool SetProxy(this global::CefSharp.IRequestContext requestContext, string scheme, string host, int? port, out string errorMessage)
		{
			global::System.Collections.Generic.IDictionary<string, object> proxyDictionary = global::CefSharp.RequestContextExtensions.GetProxyDictionary(scheme, host, port);
			if (requestContext.CanSetPreference("proxy"))
			{
				return requestContext.SetPreference("proxy", proxyDictionary, out errorMessage);
			}
			throw new global::System.Exception("Unable to set the proxy preference, it is read-only. If you specified the proxy settings with command line args it is not possible to change the proxy settings via this method.");
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00003ECC File Offset: 0x000020CC
		public static bool SetProxy(this global::CefSharp.IRequestContext requestContext, string host, int? port, out string errorMessage)
		{
			return requestContext.SetProxy(null, host, port, out errorMessage);
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00003ED8 File Offset: 0x000020D8
		public static bool SetProxy(this global::CefSharp.IRequestContext requestContext, string host, out string errorMessage)
		{
			return requestContext.SetProxy(null, host, null, out errorMessage);
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00003EF8 File Offset: 0x000020F8
		public static global::System.Collections.Generic.IDictionary<string, object> GetProxyDictionary(string scheme, string host, int? port)
		{
			if (string.IsNullOrWhiteSpace(scheme))
			{
				scheme = "http";
			}
			if (!global::CefSharp.RequestContextExtensions.ProxySchemes.Contains(scheme.ToLower()))
			{
				throw new global::System.ArgumentException("Invalid Scheme, see https://bitbucket.org/chromiumembedded/cef/wiki/GeneralUsage.md#markdown-header-proxy-resolution for a list of valid schemes.", "scheme");
			}
			if (string.IsNullOrWhiteSpace(host))
			{
				throw new global::System.ArgumentException("Cannot be null or empty", "host");
			}
			if (port != null)
			{
				int? num = port;
				int num2 = 0;
				if (!(num.GetValueOrDefault() < num2 & num != null))
				{
					num = port;
					num2 = 65535;
					if (!(num.GetValueOrDefault() > num2 & num != null))
					{
						goto IL_9C;
					}
				}
				throw new global::System.ArgumentOutOfRangeException("port", port, "Invalid TCP Port");
			}
			IL_9C:
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary["mode"] = "fixed_servers";
			string key = "server";
			string str = scheme;
			string str2 = "://";
			string str3;
			if (port == null)
			{
				str3 = "";
			}
			else
			{
				string str4 = ":";
				int? num = port;
				str3 = str4 + num.ToString();
			}
			dictionary[key] = str + str2 + host + str3;
			return dictionary;
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00003FF8 File Offset: 0x000021F8
		public static global::System.Threading.Tasks.Task<bool> ClearHttpAuthCredentialsAsync(this global::CefSharp.IRequestContext requestContext)
		{
			global::CefSharp.TaskCompletionCallback taskCompletionCallback = new global::CefSharp.TaskCompletionCallback();
			requestContext.ClearHttpAuthCredentials(taskCompletionCallback);
			return taskCompletionCallback.Task;
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00004018 File Offset: 0x00002218
		public static void RegisterOwinSchemeHandlerFactory(this global::CefSharp.IRequestContext requestContext, string schemeName, string domainName, global::System.Func<global::System.Collections.Generic.IDictionary<string, object>, global::System.Threading.Tasks.Task> appFunc)
		{
			requestContext.RegisterSchemeHandlerFactory(schemeName, domainName, new global::CefSharp.SchemeHandler.OwinSchemeHandlerFactory(appFunc));
		}

		// Token: 0x040002D0 RID: 720
		private static string[] ProxySchemes = new string[]
		{
			"http",
			"socks",
			"socks4",
			"socks5"
		};
	}
}
