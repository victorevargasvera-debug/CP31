using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CefSharp.DevTools.PerformanceTimeline
{
	// Token: 0x0200015B RID: 347
	public class PerformanceTimelineClient : global::CefSharp.DevTools.DevToolsDomainBase
	{
		// Token: 0x06000AEF RID: 2799 RVA: 0x0000D57E File Offset: 0x0000B77E
		public PerformanceTimelineClient(global::CefSharp.DevTools.IDevToolsClient client)
		{
			this._client = client;
		}

		// Token: 0x14000052 RID: 82
		// (add) Token: 0x06000AF0 RID: 2800 RVA: 0x0000D58D File Offset: 0x0000B78D
		// (remove) Token: 0x06000AF1 RID: 2801 RVA: 0x0000D5A0 File Offset: 0x0000B7A0
		public event global::System.EventHandler<global::CefSharp.DevTools.PerformanceTimeline.TimelineEventAddedEventArgs> TimelineEventAdded
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.PerformanceTimeline.TimelineEventAddedEventArgs>("PerformanceTimeline.timelineEventAdded", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.PerformanceTimeline.TimelineEventAddedEventArgs>("PerformanceTimeline.timelineEventAdded", value);
			}
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x0000D5B4 File Offset: 0x0000B7B4
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> EnableAsync(string[] eventTypes)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("eventTypes", eventTypes);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("PerformanceTimeline.enable", dictionary);
		}

		// Token: 0x040004ED RID: 1261
		private global::CefSharp.DevTools.IDevToolsClient _client;
	}
}
