using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CefSharp.DevTools.Memory
{
	// Token: 0x0200024B RID: 587
	public class MemoryClient : global::CefSharp.DevTools.DevToolsDomainBase
	{
		// Token: 0x06001234 RID: 4660 RVA: 0x00013C09 File Offset: 0x00011E09
		public MemoryClient(global::CefSharp.DevTools.IDevToolsClient client)
		{
			this._client = client;
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x00013C18 File Offset: 0x00011E18
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Memory.GetDOMCountersResponse> GetDOMCountersAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Memory.GetDOMCountersResponse>("Memory.getDOMCounters", parameters);
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x00013C38 File Offset: 0x00011E38
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> PrepareForLeakDetectionAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Memory.prepareForLeakDetection", parameters);
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x00013C58 File Offset: 0x00011E58
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> ForciblyPurgeJavaScriptMemoryAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Memory.forciblyPurgeJavaScriptMemory", parameters);
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x00013C78 File Offset: 0x00011E78
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetPressureNotificationsSuppressedAsync(bool suppressed)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("suppressed", suppressed);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Memory.setPressureNotificationsSuppressed", dictionary);
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x00013CB0 File Offset: 0x00011EB0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SimulatePressureNotificationAsync(global::CefSharp.DevTools.Memory.PressureLevel level)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("level", base.EnumToString(level));
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Memory.simulatePressureNotification", dictionary);
		}

		// Token: 0x0600123A RID: 4666 RVA: 0x00013CEC File Offset: 0x00011EEC
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> StartSamplingAsync(int? samplingInterval = null, bool? suppressRandomness = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (samplingInterval != null)
			{
				dictionary.Add("samplingInterval", samplingInterval.Value);
			}
			if (suppressRandomness != null)
			{
				dictionary.Add("suppressRandomness", suppressRandomness.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Memory.startSampling", dictionary);
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x00013D50 File Offset: 0x00011F50
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> StopSamplingAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Memory.stopSampling", parameters);
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x00013D70 File Offset: 0x00011F70
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Memory.GetAllTimeSamplingProfileResponse> GetAllTimeSamplingProfileAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Memory.GetAllTimeSamplingProfileResponse>("Memory.getAllTimeSamplingProfile", parameters);
		}

		// Token: 0x0600123D RID: 4669 RVA: 0x00013D90 File Offset: 0x00011F90
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Memory.GetBrowserSamplingProfileResponse> GetBrowserSamplingProfileAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Memory.GetBrowserSamplingProfileResponse>("Memory.getBrowserSamplingProfile", parameters);
		}

		// Token: 0x0600123E RID: 4670 RVA: 0x00013DB0 File Offset: 0x00011FB0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Memory.GetSamplingProfileResponse> GetSamplingProfileAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Memory.GetSamplingProfileResponse>("Memory.getSamplingProfile", parameters);
		}

		// Token: 0x040009C4 RID: 2500
		private global::CefSharp.DevTools.IDevToolsClient _client;
	}
}
