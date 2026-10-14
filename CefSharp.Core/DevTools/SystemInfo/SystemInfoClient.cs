using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CefSharp.DevTools.SystemInfo
{
	// Token: 0x0200011F RID: 287
	public class SystemInfoClient : global::CefSharp.DevTools.DevToolsDomainBase
	{
		// Token: 0x06000904 RID: 2308 RVA: 0x0000BA38 File Offset: 0x00009C38
		public SystemInfoClient(global::CefSharp.DevTools.IDevToolsClient client)
		{
			this._client = client;
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x0000BA48 File Offset: 0x00009C48
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.SystemInfo.GetInfoResponse> GetInfoAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.SystemInfo.GetInfoResponse>("SystemInfo.getInfo", parameters);
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x0000BA68 File Offset: 0x00009C68
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.SystemInfo.GetFeatureStateResponse> GetFeatureStateAsync(string featureState)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("featureState", featureState);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.SystemInfo.GetFeatureStateResponse>("SystemInfo.getFeatureState", dictionary);
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x0000BA98 File Offset: 0x00009C98
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.SystemInfo.GetProcessInfoResponse> GetProcessInfoAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.SystemInfo.GetProcessInfoResponse>("SystemInfo.getProcessInfo", parameters);
		}

		// Token: 0x040003FD RID: 1021
		private global::CefSharp.DevTools.IDevToolsClient _client;
	}
}
