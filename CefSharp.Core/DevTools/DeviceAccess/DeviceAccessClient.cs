using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CefSharp.DevTools.DeviceAccess
{
	// Token: 0x020000B2 RID: 178
	public class DeviceAccessClient : global::CefSharp.DevTools.DevToolsDomainBase
	{
		// Token: 0x0600061A RID: 1562 RVA: 0x00008DC0 File Offset: 0x00006FC0
		public DeviceAccessClient(global::CefSharp.DevTools.IDevToolsClient client)
		{
			this._client = client;
		}

		// Token: 0x14000024 RID: 36
		// (add) Token: 0x0600061B RID: 1563 RVA: 0x00008DCF File Offset: 0x00006FCF
		// (remove) Token: 0x0600061C RID: 1564 RVA: 0x00008DE2 File Offset: 0x00006FE2
		public event global::System.EventHandler<global::CefSharp.DevTools.DeviceAccess.DeviceRequestPromptedEventArgs> DeviceRequestPrompted
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.DeviceAccess.DeviceRequestPromptedEventArgs>("DeviceAccess.deviceRequestPrompted", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.DeviceAccess.DeviceRequestPromptedEventArgs>("DeviceAccess.deviceRequestPrompted", value);
			}
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00008DF8 File Offset: 0x00006FF8
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> EnableAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("DeviceAccess.enable", parameters);
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00008E18 File Offset: 0x00007018
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> DisableAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("DeviceAccess.disable", parameters);
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00008E38 File Offset: 0x00007038
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SelectPromptAsync(string id, string deviceId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("id", id);
			dictionary.Add("deviceId", deviceId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("DeviceAccess.selectPrompt", dictionary);
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00008E74 File Offset: 0x00007074
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> CancelPromptAsync(string id)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("id", id);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("DeviceAccess.cancelPrompt", dictionary);
		}

		// Token: 0x040002C0 RID: 704
		private global::CefSharp.DevTools.IDevToolsClient _client;
	}
}
