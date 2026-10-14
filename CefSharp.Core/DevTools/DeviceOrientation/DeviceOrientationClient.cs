using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CefSharp.DevTools.DeviceOrientation
{
	// Token: 0x02000030 RID: 48
	public class DeviceOrientationClient : global::CefSharp.DevTools.DevToolsDomainBase
	{
		// Token: 0x06000238 RID: 568 RVA: 0x000050B0 File Offset: 0x000032B0
		public DeviceOrientationClient(global::CefSharp.DevTools.IDevToolsClient client)
		{
			this._client = client;
		}

		// Token: 0x06000239 RID: 569 RVA: 0x000050C0 File Offset: 0x000032C0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> ClearDeviceOrientationOverrideAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("DeviceOrientation.clearDeviceOrientationOverride", parameters);
		}

		// Token: 0x0600023A RID: 570 RVA: 0x000050E0 File Offset: 0x000032E0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetDeviceOrientationOverrideAsync(double alpha, double beta, double gamma)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("alpha", alpha);
			dictionary.Add("beta", beta);
			dictionary.Add("gamma", gamma);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("DeviceOrientation.setDeviceOrientationOverride", dictionary);
		}

		// Token: 0x0400006B RID: 107
		private global::CefSharp.DevTools.IDevToolsClient _client;
	}
}
