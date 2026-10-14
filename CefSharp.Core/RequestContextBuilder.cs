using System;
using CefSharp.Core;
using CefSharp.Handler;

namespace CefSharp
{
	// Token: 0x0200000D RID: 13
	public class RequestContextBuilder
	{
		// Token: 0x06000103 RID: 259 RVA: 0x000031ED File Offset: 0x000013ED
		private void ThrowExceptionIfContextAlreadySet()
		{
			if (this._otherContext != null)
			{
				throw new global::System.Exception("A call to WithSharedSettings has already been made, it is no possible to provide custom settings.");
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00003202 File Offset: 0x00001402
		private void ThrowExceptionIfCustomSettingSpecified()
		{
			if (this._settings != null)
			{
				throw new global::System.Exception("A call to WithCachePath/PersistUserPreferences has already been made, it's not possible to share settings with another RequestContext.");
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00003218 File Offset: 0x00001418
		public global::CefSharp.IRequestContext Create()
		{
			if (this._otherContext != null)
			{
				return new global::CefSharp.Core.RequestContext(this._otherContext, this._handler);
			}
			if (this._settings != null)
			{
				return new global::CefSharp.Core.RequestContext(this._settings.settings, this._handler);
			}
			if (this._handler != null)
			{
				return new global::CefSharp.Core.RequestContext(this._handler);
			}
			return new global::CefSharp.Core.RequestContext();
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00003277 File Offset: 0x00001477
		public global::CefSharp.RequestContextBuilder OnInitialize(global::System.Action<global::CefSharp.IRequestContext> action)
		{
			if (this._handler == null)
			{
				this._handler = new global::CefSharp.Handler.RequestContextHandler();
			}
			this._handler.OnInitialize(action);
			return this;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000329A File Offset: 0x0000149A
		public global::CefSharp.RequestContextBuilder WithCachePath(string cachePath)
		{
			this.ThrowExceptionIfContextAlreadySet();
			if (this._settings == null)
			{
				this._settings = new global::CefSharp.RequestContextSettings();
			}
			this._settings.CachePath = cachePath;
			return this;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000032C2 File Offset: 0x000014C2
		public global::CefSharp.RequestContextBuilder PersistUserPreferences()
		{
			this.ThrowExceptionIfContextAlreadySet();
			if (this._settings == null)
			{
				this._settings = new global::CefSharp.RequestContextSettings();
			}
			this._settings.PersistUserPreferences = true;
			return this;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000032EA File Offset: 0x000014EA
		public global::CefSharp.RequestContextBuilder WithPreference(string name, object value)
		{
			if (this._handler == null)
			{
				this._handler = new global::CefSharp.Handler.RequestContextHandler();
			}
			this._handler.SetPreferenceOnContextInitialized(name, value);
			return this;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00003310 File Offset: 0x00001510
		public global::CefSharp.RequestContextBuilder WithProxyServer(string host)
		{
			if (this._handler == null)
			{
				this._handler = new global::CefSharp.Handler.RequestContextHandler();
			}
			this._handler.SetProxyOnContextInitialized(host, null);
			return this;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00003347 File Offset: 0x00001547
		public global::CefSharp.RequestContextBuilder WithProxyServer(string host, int? port)
		{
			if (this._handler == null)
			{
				this._handler = new global::CefSharp.Handler.RequestContextHandler();
			}
			this._handler.SetProxyOnContextInitialized(host, port);
			return this;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0000336B File Offset: 0x0000156B
		public global::CefSharp.RequestContextBuilder WithProxyServer(string scheme, string host, int? port)
		{
			if (this._handler == null)
			{
				this._handler = new global::CefSharp.Handler.RequestContextHandler();
			}
			this._handler.SetProxyOnContextInitialized(scheme, host, port);
			return this;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00003390 File Offset: 0x00001590
		public global::CefSharp.RequestContextBuilder WithSharedSettings(global::CefSharp.IRequestContext other)
		{
			if (other == null)
			{
				throw new global::System.ArgumentNullException("other");
			}
			this.ThrowExceptionIfCustomSettingSpecified();
			this._otherContext = other;
			return this;
		}

		// Token: 0x04000009 RID: 9
		private global::CefSharp.RequestContextSettings _settings;

		// Token: 0x0400000A RID: 10
		private global::CefSharp.IRequestContext _otherContext;

		// Token: 0x0400000B RID: 11
		private global::CefSharp.Handler.RequestContextHandler _handler;
	}
}
