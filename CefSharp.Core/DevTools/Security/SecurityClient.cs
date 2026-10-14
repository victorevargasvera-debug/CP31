using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CefSharp.DevTools.Security
{
	// Token: 0x02000155 RID: 341
	public class SecurityClient : global::CefSharp.DevTools.DevToolsDomainBase
	{
		// Token: 0x06000ABA RID: 2746 RVA: 0x0000D344 File Offset: 0x0000B544
		public SecurityClient(global::CefSharp.DevTools.IDevToolsClient client)
		{
			this._client = client;
		}

		// Token: 0x14000051 RID: 81
		// (add) Token: 0x06000ABB RID: 2747 RVA: 0x0000D353 File Offset: 0x0000B553
		// (remove) Token: 0x06000ABC RID: 2748 RVA: 0x0000D366 File Offset: 0x0000B566
		public event global::System.EventHandler<global::CefSharp.DevTools.Security.VisibleSecurityStateChangedEventArgs> VisibleSecurityStateChanged
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Security.VisibleSecurityStateChangedEventArgs>("Security.visibleSecurityStateChanged", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Security.VisibleSecurityStateChangedEventArgs>("Security.visibleSecurityStateChanged", value);
			}
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x0000D37C File Offset: 0x0000B57C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> DisableAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Security.disable", parameters);
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x0000D39C File Offset: 0x0000B59C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> EnableAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Security.enable", parameters);
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x0000D3BC File Offset: 0x0000B5BC
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetIgnoreCertificateErrorsAsync(bool ignore)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("ignore", ignore);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Security.setIgnoreCertificateErrors", dictionary);
		}

		// Token: 0x040004D7 RID: 1239
		private global::CefSharp.DevTools.IDevToolsClient _client;
	}
}
