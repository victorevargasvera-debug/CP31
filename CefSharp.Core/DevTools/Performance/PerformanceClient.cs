using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CefSharp.DevTools.Performance
{
	// Token: 0x02000160 RID: 352
	public class PerformanceClient : global::CefSharp.DevTools.DevToolsDomainBase
	{
		// Token: 0x06000B01 RID: 2817 RVA: 0x0000D659 File Offset: 0x0000B859
		public PerformanceClient(global::CefSharp.DevTools.IDevToolsClient client)
		{
			this._client = client;
		}

		// Token: 0x14000053 RID: 83
		// (add) Token: 0x06000B02 RID: 2818 RVA: 0x0000D668 File Offset: 0x0000B868
		// (remove) Token: 0x06000B03 RID: 2819 RVA: 0x0000D67B File Offset: 0x0000B87B
		public event global::System.EventHandler<global::CefSharp.DevTools.Performance.MetricsEventArgs> Metrics
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Performance.MetricsEventArgs>("Performance.metrics", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Performance.MetricsEventArgs>("Performance.metrics", value);
			}
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x0000D690 File Offset: 0x0000B890
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> DisableAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Performance.disable", parameters);
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x0000D6B0 File Offset: 0x0000B8B0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> EnableAsync(global::CefSharp.DevTools.Performance.EnableTimeDomain? timeDomain = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (timeDomain != null)
			{
				dictionary.Add("timeDomain", base.EnumToString(timeDomain));
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Performance.enable", dictionary);
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x0000D6F4 File Offset: 0x0000B8F4
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Performance.GetMetricsResponse> GetMetricsAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Performance.GetMetricsResponse>("Performance.getMetrics", parameters);
		}

		// Token: 0x040004F6 RID: 1270
		private global::CefSharp.DevTools.IDevToolsClient _client;
	}
}
