using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CefSharp.DevTools.Tracing
{
	// Token: 0x020000FB RID: 251
	public class TracingClient : global::CefSharp.DevTools.DevToolsDomainBase
	{
		// Token: 0x06000809 RID: 2057 RVA: 0x0000A985 File Offset: 0x00008B85
		public TracingClient(global::CefSharp.DevTools.IDevToolsClient client)
		{
			this._client = client;
		}

		// Token: 0x1400003B RID: 59
		// (add) Token: 0x0600080A RID: 2058 RVA: 0x0000A994 File Offset: 0x00008B94
		// (remove) Token: 0x0600080B RID: 2059 RVA: 0x0000A9A7 File Offset: 0x00008BA7
		public event global::System.EventHandler<global::CefSharp.DevTools.Tracing.BufferUsageEventArgs> BufferUsage
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Tracing.BufferUsageEventArgs>("Tracing.bufferUsage", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Tracing.BufferUsageEventArgs>("Tracing.bufferUsage", value);
			}
		}

		// Token: 0x1400003C RID: 60
		// (add) Token: 0x0600080C RID: 2060 RVA: 0x0000A9BB File Offset: 0x00008BBB
		// (remove) Token: 0x0600080D RID: 2061 RVA: 0x0000A9CE File Offset: 0x00008BCE
		public event global::System.EventHandler<global::CefSharp.DevTools.Tracing.DataCollectedEventArgs> DataCollected
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Tracing.DataCollectedEventArgs>("Tracing.dataCollected", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Tracing.DataCollectedEventArgs>("Tracing.dataCollected", value);
			}
		}

		// Token: 0x1400003D RID: 61
		// (add) Token: 0x0600080E RID: 2062 RVA: 0x0000A9E2 File Offset: 0x00008BE2
		// (remove) Token: 0x0600080F RID: 2063 RVA: 0x0000A9F5 File Offset: 0x00008BF5
		public event global::System.EventHandler<global::CefSharp.DevTools.Tracing.TracingCompleteEventArgs> TracingComplete
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Tracing.TracingCompleteEventArgs>("Tracing.tracingComplete", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Tracing.TracingCompleteEventArgs>("Tracing.tracingComplete", value);
			}
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x0000AA0C File Offset: 0x00008C0C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> EndAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Tracing.end", parameters);
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x0000AA2C File Offset: 0x00008C2C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Tracing.GetCategoriesResponse> GetCategoriesAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Tracing.GetCategoriesResponse>("Tracing.getCategories", parameters);
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x0000AA4C File Offset: 0x00008C4C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> RecordClockSyncMarkerAsync(string syncId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("syncId", syncId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Tracing.recordClockSyncMarker", dictionary);
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x0000AA7C File Offset: 0x00008C7C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Tracing.RequestMemoryDumpResponse> RequestMemoryDumpAsync(bool? deterministic = null, global::CefSharp.DevTools.Tracing.MemoryDumpLevelOfDetail? levelOfDetail = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (deterministic != null)
			{
				dictionary.Add("deterministic", deterministic.Value);
			}
			if (levelOfDetail != null)
			{
				dictionary.Add("levelOfDetail", base.EnumToString(levelOfDetail));
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Tracing.RequestMemoryDumpResponse>("Tracing.requestMemoryDump", dictionary);
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x0000AAE0 File Offset: 0x00008CE0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> StartAsync(string categories = null, string options = null, double? bufferUsageReportingInterval = null, global::CefSharp.DevTools.Tracing.StartTransferMode? transferMode = null, global::CefSharp.DevTools.Tracing.StreamFormat? streamFormat = null, global::CefSharp.DevTools.Tracing.StreamCompression? streamCompression = null, global::CefSharp.DevTools.Tracing.TraceConfig traceConfig = null, byte[] perfettoConfig = null, global::CefSharp.DevTools.Tracing.TracingBackend? tracingBackend = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (!string.IsNullOrEmpty(categories))
			{
				dictionary.Add("categories", categories);
			}
			if (!string.IsNullOrEmpty(options))
			{
				dictionary.Add("options", options);
			}
			if (bufferUsageReportingInterval != null)
			{
				dictionary.Add("bufferUsageReportingInterval", bufferUsageReportingInterval.Value);
			}
			if (transferMode != null)
			{
				dictionary.Add("transferMode", base.EnumToString(transferMode));
			}
			if (streamFormat != null)
			{
				dictionary.Add("streamFormat", base.EnumToString(streamFormat));
			}
			if (streamCompression != null)
			{
				dictionary.Add("streamCompression", base.EnumToString(streamCompression));
			}
			if (traceConfig != null)
			{
				dictionary.Add("traceConfig", traceConfig.ToDictionary());
			}
			if (perfettoConfig != null)
			{
				dictionary.Add("perfettoConfig", base.ToBase64String(perfettoConfig));
			}
			if (tracingBackend != null)
			{
				dictionary.Add("tracingBackend", base.EnumToString(tracingBackend));
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Tracing.start", dictionary);
		}

		// Token: 0x040003A5 RID: 933
		private global::CefSharp.DevTools.IDevToolsClient _client;
	}
}
