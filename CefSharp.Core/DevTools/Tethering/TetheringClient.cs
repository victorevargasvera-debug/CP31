using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CefSharp.DevTools.Tethering
{
	// Token: 0x020000FE RID: 254
	public class TetheringClient : global::CefSharp.DevTools.DevToolsDomainBase
	{
		// Token: 0x0600081B RID: 2075 RVA: 0x0000AC2F File Offset: 0x00008E2F
		public TetheringClient(global::CefSharp.DevTools.IDevToolsClient client)
		{
			this._client = client;
		}

		// Token: 0x1400003E RID: 62
		// (add) Token: 0x0600081C RID: 2076 RVA: 0x0000AC3E File Offset: 0x00008E3E
		// (remove) Token: 0x0600081D RID: 2077 RVA: 0x0000AC51 File Offset: 0x00008E51
		public event global::System.EventHandler<global::CefSharp.DevTools.Tethering.AcceptedEventArgs> Accepted
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Tethering.AcceptedEventArgs>("Tethering.accepted", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Tethering.AcceptedEventArgs>("Tethering.accepted", value);
			}
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x0000AC68 File Offset: 0x00008E68
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> BindAsync(int port)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("port", port);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Tethering.bind", dictionary);
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x0000ACA0 File Offset: 0x00008EA0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> UnbindAsync(int port)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("port", port);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Tethering.unbind", dictionary);
		}

		// Token: 0x040003A8 RID: 936
		private global::CefSharp.DevTools.IDevToolsClient _client;
	}
}
