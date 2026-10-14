using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CefSharp.DevTools.Cast
{
	// Token: 0x020002EA RID: 746
	public class CastClient : global::CefSharp.DevTools.DevToolsDomainBase
	{
		// Token: 0x060016C3 RID: 5827 RVA: 0x00019152 File Offset: 0x00017352
		public CastClient(global::CefSharp.DevTools.IDevToolsClient client)
		{
			this._client = client;
		}

		// Token: 0x140000A7 RID: 167
		// (add) Token: 0x060016C4 RID: 5828 RVA: 0x00019161 File Offset: 0x00017361
		// (remove) Token: 0x060016C5 RID: 5829 RVA: 0x00019174 File Offset: 0x00017374
		public event global::System.EventHandler<global::CefSharp.DevTools.Cast.SinksUpdatedEventArgs> SinksUpdated
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Cast.SinksUpdatedEventArgs>("Cast.sinksUpdated", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Cast.SinksUpdatedEventArgs>("Cast.sinksUpdated", value);
			}
		}

		// Token: 0x140000A8 RID: 168
		// (add) Token: 0x060016C6 RID: 5830 RVA: 0x00019188 File Offset: 0x00017388
		// (remove) Token: 0x060016C7 RID: 5831 RVA: 0x0001919B File Offset: 0x0001739B
		public event global::System.EventHandler<global::CefSharp.DevTools.Cast.IssueUpdatedEventArgs> IssueUpdated
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Cast.IssueUpdatedEventArgs>("Cast.issueUpdated", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Cast.IssueUpdatedEventArgs>("Cast.issueUpdated", value);
			}
		}

		// Token: 0x060016C8 RID: 5832 RVA: 0x000191B0 File Offset: 0x000173B0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> EnableAsync(string presentationUrl = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (!string.IsNullOrEmpty(presentationUrl))
			{
				dictionary.Add("presentationUrl", presentationUrl);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Cast.enable", dictionary);
		}

		// Token: 0x060016C9 RID: 5833 RVA: 0x000191E8 File Offset: 0x000173E8
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> DisableAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Cast.disable", parameters);
		}

		// Token: 0x060016CA RID: 5834 RVA: 0x00019208 File Offset: 0x00017408
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetSinkToUseAsync(string sinkName)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("sinkName", sinkName);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Cast.setSinkToUse", dictionary);
		}

		// Token: 0x060016CB RID: 5835 RVA: 0x00019238 File Offset: 0x00017438
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> StartDesktopMirroringAsync(string sinkName)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("sinkName", sinkName);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Cast.startDesktopMirroring", dictionary);
		}

		// Token: 0x060016CC RID: 5836 RVA: 0x00019268 File Offset: 0x00017468
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> StartTabMirroringAsync(string sinkName)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("sinkName", sinkName);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Cast.startTabMirroring", dictionary);
		}

		// Token: 0x060016CD RID: 5837 RVA: 0x00019298 File Offset: 0x00017498
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> StopCastingAsync(string sinkName)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("sinkName", sinkName);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Cast.stopCasting", dictionary);
		}

		// Token: 0x04000BEB RID: 3051
		private global::CefSharp.DevTools.IDevToolsClient _client;
	}
}
