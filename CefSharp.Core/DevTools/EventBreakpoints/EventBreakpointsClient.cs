using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CefSharp.DevTools.EventBreakpoints
{
	// Token: 0x02000031 RID: 49
	public class EventBreakpointsClient : global::CefSharp.DevTools.DevToolsDomainBase
	{
		// Token: 0x0600023B RID: 571 RVA: 0x00005137 File Offset: 0x00003337
		public EventBreakpointsClient(global::CefSharp.DevTools.IDevToolsClient client)
		{
			this._client = client;
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00005148 File Offset: 0x00003348
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetInstrumentationBreakpointAsync(string eventName)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("eventName", eventName);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("EventBreakpoints.setInstrumentationBreakpoint", dictionary);
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00005178 File Offset: 0x00003378
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> RemoveInstrumentationBreakpointAsync(string eventName)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("eventName", eventName);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("EventBreakpoints.removeInstrumentationBreakpoint", dictionary);
		}

		// Token: 0x0400006C RID: 108
		private global::CefSharp.DevTools.IDevToolsClient _client;
	}
}
