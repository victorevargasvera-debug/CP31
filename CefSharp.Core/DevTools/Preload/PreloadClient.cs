using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CefSharp.DevTools.Preload
{
	// Token: 0x020000AF RID: 175
	public class PreloadClient : global::CefSharp.DevTools.DevToolsDomainBase
	{
		// Token: 0x060005FF RID: 1535 RVA: 0x00008C0B File Offset: 0x00006E0B
		public PreloadClient(global::CefSharp.DevTools.IDevToolsClient client)
		{
			this._client = client;
		}

		// Token: 0x1400001D RID: 29
		// (add) Token: 0x06000600 RID: 1536 RVA: 0x00008C1A File Offset: 0x00006E1A
		// (remove) Token: 0x06000601 RID: 1537 RVA: 0x00008C2D File Offset: 0x00006E2D
		public event global::System.EventHandler<global::CefSharp.DevTools.Preload.RuleSetUpdatedEventArgs> RuleSetUpdated
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Preload.RuleSetUpdatedEventArgs>("Preload.ruleSetUpdated", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Preload.RuleSetUpdatedEventArgs>("Preload.ruleSetUpdated", value);
			}
		}

		// Token: 0x1400001E RID: 30
		// (add) Token: 0x06000602 RID: 1538 RVA: 0x00008C41 File Offset: 0x00006E41
		// (remove) Token: 0x06000603 RID: 1539 RVA: 0x00008C54 File Offset: 0x00006E54
		public event global::System.EventHandler<global::CefSharp.DevTools.Preload.RuleSetRemovedEventArgs> RuleSetRemoved
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Preload.RuleSetRemovedEventArgs>("Preload.ruleSetRemoved", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Preload.RuleSetRemovedEventArgs>("Preload.ruleSetRemoved", value);
			}
		}

		// Token: 0x1400001F RID: 31
		// (add) Token: 0x06000604 RID: 1540 RVA: 0x00008C68 File Offset: 0x00006E68
		// (remove) Token: 0x06000605 RID: 1541 RVA: 0x00008C7B File Offset: 0x00006E7B
		public event global::System.EventHandler<global::CefSharp.DevTools.Preload.PrerenderAttemptCompletedEventArgs> PrerenderAttemptCompleted
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Preload.PrerenderAttemptCompletedEventArgs>("Preload.prerenderAttemptCompleted", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Preload.PrerenderAttemptCompletedEventArgs>("Preload.prerenderAttemptCompleted", value);
			}
		}

		// Token: 0x14000020 RID: 32
		// (add) Token: 0x06000606 RID: 1542 RVA: 0x00008C8F File Offset: 0x00006E8F
		// (remove) Token: 0x06000607 RID: 1543 RVA: 0x00008CA2 File Offset: 0x00006EA2
		public event global::System.EventHandler<global::CefSharp.DevTools.Preload.PreloadEnabledStateUpdatedEventArgs> PreloadEnabledStateUpdated
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Preload.PreloadEnabledStateUpdatedEventArgs>("Preload.preloadEnabledStateUpdated", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Preload.PreloadEnabledStateUpdatedEventArgs>("Preload.preloadEnabledStateUpdated", value);
			}
		}

		// Token: 0x14000021 RID: 33
		// (add) Token: 0x06000608 RID: 1544 RVA: 0x00008CB6 File Offset: 0x00006EB6
		// (remove) Token: 0x06000609 RID: 1545 RVA: 0x00008CC9 File Offset: 0x00006EC9
		public event global::System.EventHandler<global::CefSharp.DevTools.Preload.PrefetchStatusUpdatedEventArgs> PrefetchStatusUpdated
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Preload.PrefetchStatusUpdatedEventArgs>("Preload.prefetchStatusUpdated", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Preload.PrefetchStatusUpdatedEventArgs>("Preload.prefetchStatusUpdated", value);
			}
		}

		// Token: 0x14000022 RID: 34
		// (add) Token: 0x0600060A RID: 1546 RVA: 0x00008CDD File Offset: 0x00006EDD
		// (remove) Token: 0x0600060B RID: 1547 RVA: 0x00008CF0 File Offset: 0x00006EF0
		public event global::System.EventHandler<global::CefSharp.DevTools.Preload.PrerenderStatusUpdatedEventArgs> PrerenderStatusUpdated
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Preload.PrerenderStatusUpdatedEventArgs>("Preload.prerenderStatusUpdated", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Preload.PrerenderStatusUpdatedEventArgs>("Preload.prerenderStatusUpdated", value);
			}
		}

		// Token: 0x14000023 RID: 35
		// (add) Token: 0x0600060C RID: 1548 RVA: 0x00008D04 File Offset: 0x00006F04
		// (remove) Token: 0x0600060D RID: 1549 RVA: 0x00008D17 File Offset: 0x00006F17
		public event global::System.EventHandler<global::CefSharp.DevTools.Preload.PreloadingAttemptSourcesUpdatedEventArgs> PreloadingAttemptSourcesUpdated
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Preload.PreloadingAttemptSourcesUpdatedEventArgs>("Preload.preloadingAttemptSourcesUpdated", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Preload.PreloadingAttemptSourcesUpdatedEventArgs>("Preload.preloadingAttemptSourcesUpdated", value);
			}
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00008D2C File Offset: 0x00006F2C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> EnableAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Preload.enable", parameters);
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00008D4C File Offset: 0x00006F4C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> DisableAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Preload.disable", parameters);
		}

		// Token: 0x040002BB RID: 699
		private global::CefSharp.DevTools.IDevToolsClient _client;
	}
}
