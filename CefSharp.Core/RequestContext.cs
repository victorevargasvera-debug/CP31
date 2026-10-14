using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using CefSharp.Core;

namespace CefSharp
{
	// Token: 0x0200000C RID: 12
	public class RequestContext : global::CefSharp.IRequestContext, global::System.IDisposable
	{
		// Token: 0x060000E4 RID: 228 RVA: 0x00002F49 File Offset: 0x00001149
		public RequestContext()
		{
			this.requestContext = new global::CefSharp.Core.RequestContext();
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002F5C File Offset: 0x0000115C
		public RequestContext(global::CefSharp.IRequestContext otherRequestContext)
		{
			if (otherRequestContext == null)
			{
				throw new global::System.ArgumentNullException("otherRequestContext");
			}
			this.requestContext = new global::CefSharp.Core.RequestContext(otherRequestContext);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002F7E File Offset: 0x0000117E
		public RequestContext(global::CefSharp.IRequestContext otherRequestContext, global::CefSharp.IRequestContextHandler requestContextHandler)
		{
			if (otherRequestContext == null)
			{
				throw new global::System.ArgumentNullException("otherRequestContext");
			}
			if (requestContextHandler == null)
			{
				throw new global::System.ArgumentNullException("requestContextHandler");
			}
			this.requestContext = new global::CefSharp.Core.RequestContext(otherRequestContext, requestContextHandler);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002FAF File Offset: 0x000011AF
		public RequestContext(global::CefSharp.IRequestContextHandler requestContextHandler)
		{
			if (requestContextHandler == null)
			{
				throw new global::System.ArgumentNullException("requestContextHandler");
			}
			this.requestContext = new global::CefSharp.Core.RequestContext(requestContextHandler);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002FD1 File Offset: 0x000011D1
		public RequestContext(global::CefSharp.RequestContextSettings settings)
		{
			if (settings == null)
			{
				throw new global::System.ArgumentNullException("settings");
			}
			this.requestContext = new global::CefSharp.Core.RequestContext(settings.settings);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002FF8 File Offset: 0x000011F8
		public RequestContext(global::CefSharp.RequestContextSettings settings, global::CefSharp.IRequestContextHandler requestContextHandler)
		{
			if (settings == null)
			{
				throw new global::System.ArgumentNullException("settings");
			}
			if (requestContextHandler == null)
			{
				throw new global::System.ArgumentNullException("requestContextHandler");
			}
			this.requestContext = new global::CefSharp.Core.RequestContext(settings.settings, requestContextHandler);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00003030 File Offset: 0x00001230
		public static global::CefSharp.RequestContextBuilder Configure()
		{
			return new global::CefSharp.RequestContextBuilder();
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000EB RID: 235 RVA: 0x00003044 File Offset: 0x00001244
		public bool IsGlobal
		{
			get
			{
				return this.requestContext.IsGlobal;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000EC RID: 236 RVA: 0x00003051 File Offset: 0x00001251
		public string CachePath
		{
			get
			{
				return this.requestContext.CachePath;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000ED RID: 237 RVA: 0x0000305E File Offset: 0x0000125E
		public bool IsDisposed
		{
			get
			{
				return this.requestContext.IsDisposed;
			}
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000306B File Offset: 0x0000126B
		public bool IsSame(global::CefSharp.IRequestContext context)
		{
			return this.requestContext.IsSame(context);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00003079 File Offset: 0x00001279
		public bool IsSharingWith(global::CefSharp.IRequestContext context)
		{
			return this.requestContext.IsSharingWith(context);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00003087 File Offset: 0x00001287
		public global::CefSharp.ICookieManager GetCookieManager(global::CefSharp.ICompletionCallback callback)
		{
			return this.requestContext.GetCookieManager(callback);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00003095 File Offset: 0x00001295
		public bool RegisterSchemeHandlerFactory(string schemeName, string domainName, global::CefSharp.ISchemeHandlerFactory factory)
		{
			return this.requestContext.RegisterSchemeHandlerFactory(schemeName, domainName, factory);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x000030A5 File Offset: 0x000012A5
		public bool ClearSchemeHandlerFactories()
		{
			return this.requestContext.ClearSchemeHandlerFactories();
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x000030B2 File Offset: 0x000012B2
		public bool HasPreference(string name)
		{
			return this.requestContext.HasPreference(name);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x000030C0 File Offset: 0x000012C0
		public object GetPreference(string name)
		{
			return this.requestContext.GetPreference(name);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000030CE File Offset: 0x000012CE
		public global::System.Collections.Generic.IDictionary<string, object> GetAllPreferences(bool includeDefaults)
		{
			return this.requestContext.GetAllPreferences(includeDefaults);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x000030DC File Offset: 0x000012DC
		public bool CanSetPreference(string name)
		{
			return this.requestContext.CanSetPreference(name);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x000030EA File Offset: 0x000012EA
		public bool SetPreference(string name, object value, out string error)
		{
			return this.requestContext.SetPreference(name, value, ref error);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x000030FA File Offset: 0x000012FA
		public void ClearCertificateExceptions(global::CefSharp.ICompletionCallback callback)
		{
			this.requestContext.ClearCertificateExceptions(callback);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00003108 File Offset: 0x00001308
		public void ClearHttpAuthCredentials(global::CefSharp.ICompletionCallback callback = null)
		{
			this.requestContext.ClearHttpAuthCredentials(callback);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00003116 File Offset: 0x00001316
		public void CloseAllConnections(global::CefSharp.ICompletionCallback callback)
		{
			this.requestContext.CloseAllConnections(callback);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00003124 File Offset: 0x00001324
		public global::System.Threading.Tasks.Task<global::CefSharp.ResolveCallbackResult> ResolveHostAsync(global::System.Uri origin)
		{
			return this.requestContext.ResolveHostAsync(origin);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00003132 File Offset: 0x00001332
		public bool DidLoadExtension(string extensionId)
		{
			return this.requestContext.DidLoadExtension(extensionId);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00003140 File Offset: 0x00001340
		public global::CefSharp.IExtension GetExtension(string extensionId)
		{
			return this.requestContext.GetExtension(extensionId);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0000314E File Offset: 0x0000134E
		public bool GetExtensions(out global::System.Collections.Generic.IList<string> extensionIds)
		{
			return this.requestContext.GetExtensions(ref extensionIds);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0000315C File Offset: 0x0000135C
		public bool HasExtension(string extensionId)
		{
			return this.requestContext.CanSetPreference(extensionId);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000316C File Offset: 0x0000136C
		public void LoadExtension(string rootDirectory, string manifestJson, global::CefSharp.IExtensionHandler handler)
		{
			if (global::CefSharp.Cef.CurrentlyOnThread(global::CefSharp.CefThreadIds.TID_UI))
			{
				this.requestContext.LoadExtension(rootDirectory, manifestJson, handler);
				return;
			}
			global::CefSharp.Cef.UIThreadTaskFactory.StartNew(delegate()
			{
				this.requestContext.LoadExtension(rootDirectory, manifestJson, handler);
			});
		}

		// Token: 0x06000101 RID: 257 RVA: 0x000031D8 File Offset: 0x000013D8
		public void Dispose()
		{
			this.requestContext.Dispose();
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000031E5 File Offset: 0x000013E5
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public global::CefSharp.IRequestContext UnWrap()
		{
			return this.requestContext;
		}

		// Token: 0x04000008 RID: 8
		private global::CefSharp.Core.RequestContext requestContext;
	}
}
