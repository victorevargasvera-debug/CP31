using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CefSharp.DevTools.BackgroundService
{
	// Token: 0x02000347 RID: 839
	public class BackgroundServiceClient : global::CefSharp.DevTools.DevToolsDomainBase
	{
		// Token: 0x06001986 RID: 6534 RVA: 0x0001B6D6 File Offset: 0x000198D6
		public BackgroundServiceClient(global::CefSharp.DevTools.IDevToolsClient client)
		{
			this._client = client;
		}

		// Token: 0x140000B0 RID: 176
		// (add) Token: 0x06001987 RID: 6535 RVA: 0x0001B6E5 File Offset: 0x000198E5
		// (remove) Token: 0x06001988 RID: 6536 RVA: 0x0001B6F8 File Offset: 0x000198F8
		public event global::System.EventHandler<global::CefSharp.DevTools.BackgroundService.RecordingStateChangedEventArgs> RecordingStateChanged
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.BackgroundService.RecordingStateChangedEventArgs>("BackgroundService.recordingStateChanged", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.BackgroundService.RecordingStateChangedEventArgs>("BackgroundService.recordingStateChanged", value);
			}
		}

		// Token: 0x140000B1 RID: 177
		// (add) Token: 0x06001989 RID: 6537 RVA: 0x0001B70C File Offset: 0x0001990C
		// (remove) Token: 0x0600198A RID: 6538 RVA: 0x0001B71F File Offset: 0x0001991F
		public event global::System.EventHandler<global::CefSharp.DevTools.BackgroundService.BackgroundServiceEventReceivedEventArgs> BackgroundServiceEventReceived
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.BackgroundService.BackgroundServiceEventReceivedEventArgs>("BackgroundService.backgroundServiceEventReceived", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.BackgroundService.BackgroundServiceEventReceivedEventArgs>("BackgroundService.backgroundServiceEventReceived", value);
			}
		}

		// Token: 0x0600198B RID: 6539 RVA: 0x0001B734 File Offset: 0x00019934
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> StartObservingAsync(global::CefSharp.DevTools.BackgroundService.ServiceName service)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("service", base.EnumToString(service));
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("BackgroundService.startObserving", dictionary);
		}

		// Token: 0x0600198C RID: 6540 RVA: 0x0001B770 File Offset: 0x00019970
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> StopObservingAsync(global::CefSharp.DevTools.BackgroundService.ServiceName service)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("service", base.EnumToString(service));
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("BackgroundService.stopObserving", dictionary);
		}

		// Token: 0x0600198D RID: 6541 RVA: 0x0001B7AC File Offset: 0x000199AC
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetRecordingAsync(bool shouldRecord, global::CefSharp.DevTools.BackgroundService.ServiceName service)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("shouldRecord", shouldRecord);
			dictionary.Add("service", base.EnumToString(service));
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("BackgroundService.setRecording", dictionary);
		}

		// Token: 0x0600198E RID: 6542 RVA: 0x0001B7F8 File Offset: 0x000199F8
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> ClearEventsAsync(global::CefSharp.DevTools.BackgroundService.ServiceName service)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("service", base.EnumToString(service));
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("BackgroundService.clearEvents", dictionary);
		}

		// Token: 0x04000D25 RID: 3365
		private global::CefSharp.DevTools.IDevToolsClient _client;
	}
}
