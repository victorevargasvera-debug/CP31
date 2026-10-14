using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CefSharp.DevTools.Log
{
	// Token: 0x02000253 RID: 595
	public class LogClient : global::CefSharp.DevTools.DevToolsDomainBase
	{
		// Token: 0x06001266 RID: 4710 RVA: 0x00013F92 File Offset: 0x00012192
		public LogClient(global::CefSharp.DevTools.IDevToolsClient client)
		{
			this._client = client;
		}

		// Token: 0x1400008B RID: 139
		// (add) Token: 0x06001267 RID: 4711 RVA: 0x00013FA1 File Offset: 0x000121A1
		// (remove) Token: 0x06001268 RID: 4712 RVA: 0x00013FB4 File Offset: 0x000121B4
		public event global::System.EventHandler<global::CefSharp.DevTools.Log.EntryAddedEventArgs> EntryAdded
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Log.EntryAddedEventArgs>("Log.entryAdded", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Log.EntryAddedEventArgs>("Log.entryAdded", value);
			}
		}

		// Token: 0x06001269 RID: 4713 RVA: 0x00013FC8 File Offset: 0x000121C8
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> ClearAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Log.clear", parameters);
		}

		// Token: 0x0600126A RID: 4714 RVA: 0x00013FE8 File Offset: 0x000121E8
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> DisableAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Log.disable", parameters);
		}

		// Token: 0x0600126B RID: 4715 RVA: 0x00014008 File Offset: 0x00012208
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> EnableAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Log.enable", parameters);
		}

		// Token: 0x0600126C RID: 4716 RVA: 0x00014028 File Offset: 0x00012228
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> StartViolationsReportAsync(global::System.Collections.Generic.IList<global::CefSharp.DevTools.Log.ViolationSetting> config)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("config", from x in config
			select x.ToDictionary());
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Log.startViolationsReport", dictionary);
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x0001407C File Offset: 0x0001227C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> StopViolationsReportAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Log.stopViolationsReport", parameters);
		}

		// Token: 0x040009F0 RID: 2544
		private global::CefSharp.DevTools.IDevToolsClient _client;
	}
}
