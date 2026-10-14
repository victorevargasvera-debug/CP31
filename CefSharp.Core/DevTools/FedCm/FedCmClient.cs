using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CefSharp.DevTools.FedCm
{
	// Token: 0x0200009E RID: 158
	public class FedCmClient : global::CefSharp.DevTools.DevToolsDomainBase
	{
		// Token: 0x060005A3 RID: 1443 RVA: 0x00008724 File Offset: 0x00006924
		public FedCmClient(global::CefSharp.DevTools.IDevToolsClient client)
		{
			this._client = client;
		}

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x060005A4 RID: 1444 RVA: 0x00008733 File Offset: 0x00006933
		// (remove) Token: 0x060005A5 RID: 1445 RVA: 0x00008746 File Offset: 0x00006946
		public event global::System.EventHandler<global::CefSharp.DevTools.FedCm.DialogShownEventArgs> DialogShown
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.FedCm.DialogShownEventArgs>("FedCm.dialogShown", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.FedCm.DialogShownEventArgs>("FedCm.dialogShown", value);
			}
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x0000875C File Offset: 0x0000695C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> EnableAsync(bool? disableRejectionDelay = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (disableRejectionDelay != null)
			{
				dictionary.Add("disableRejectionDelay", disableRejectionDelay.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("FedCm.enable", dictionary);
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x000087A0 File Offset: 0x000069A0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> DisableAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("FedCm.disable", parameters);
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x000087C0 File Offset: 0x000069C0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SelectAccountAsync(string dialogId, int accountIndex)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("dialogId", dialogId);
			dictionary.Add("accountIndex", accountIndex);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("FedCm.selectAccount", dictionary);
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00008804 File Offset: 0x00006A04
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> DismissDialogAsync(string dialogId, bool? triggerCooldown = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("dialogId", dialogId);
			if (triggerCooldown != null)
			{
				dictionary.Add("triggerCooldown", triggerCooldown.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("FedCm.dismissDialog", dictionary);
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00008854 File Offset: 0x00006A54
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> ResetCooldownAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("FedCm.resetCooldown", parameters);
		}

		// Token: 0x04000249 RID: 585
		private global::CefSharp.DevTools.IDevToolsClient _client;
	}
}
