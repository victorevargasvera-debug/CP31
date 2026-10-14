using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CefSharp.DevTools.Inspector
{
	// Token: 0x02000263 RID: 611
	public class InspectorClient : global::CefSharp.DevTools.DevToolsDomainBase
	{
		// Token: 0x060012DA RID: 4826 RVA: 0x00014699 File Offset: 0x00012899
		public InspectorClient(global::CefSharp.DevTools.IDevToolsClient client)
		{
			this._client = client;
		}

		// Token: 0x1400008E RID: 142
		// (add) Token: 0x060012DB RID: 4827 RVA: 0x000146A8 File Offset: 0x000128A8
		// (remove) Token: 0x060012DC RID: 4828 RVA: 0x000146BB File Offset: 0x000128BB
		public event global::System.EventHandler<global::CefSharp.DevTools.Inspector.DetachedEventArgs> Detached
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Inspector.DetachedEventArgs>("Inspector.detached", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Inspector.DetachedEventArgs>("Inspector.detached", value);
			}
		}

		// Token: 0x1400008F RID: 143
		// (add) Token: 0x060012DD RID: 4829 RVA: 0x000146CF File Offset: 0x000128CF
		// (remove) Token: 0x060012DE RID: 4830 RVA: 0x000146E2 File Offset: 0x000128E2
		public event global::System.EventHandler<global::System.EventArgs> TargetCrashed
		{
			add
			{
				this._client.AddEventHandler<global::System.EventArgs>("Inspector.targetCrashed", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::System.EventArgs>("Inspector.targetCrashed", value);
			}
		}

		// Token: 0x14000090 RID: 144
		// (add) Token: 0x060012DF RID: 4831 RVA: 0x000146F6 File Offset: 0x000128F6
		// (remove) Token: 0x060012E0 RID: 4832 RVA: 0x00014709 File Offset: 0x00012909
		public event global::System.EventHandler<global::System.EventArgs> TargetReloadedAfterCrash
		{
			add
			{
				this._client.AddEventHandler<global::System.EventArgs>("Inspector.targetReloadedAfterCrash", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::System.EventArgs>("Inspector.targetReloadedAfterCrash", value);
			}
		}

		// Token: 0x060012E1 RID: 4833 RVA: 0x00014720 File Offset: 0x00012920
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> DisableAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Inspector.disable", parameters);
		}

		// Token: 0x060012E2 RID: 4834 RVA: 0x00014740 File Offset: 0x00012940
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> EnableAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Inspector.enable", parameters);
		}

		// Token: 0x04000A1A RID: 2586
		private global::CefSharp.DevTools.IDevToolsClient _client;
	}
}
