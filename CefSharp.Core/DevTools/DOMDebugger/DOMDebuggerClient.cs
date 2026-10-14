using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CefSharp.DevTools.DOMDebugger
{
	// Token: 0x020002B0 RID: 688
	public class DOMDebuggerClient : global::CefSharp.DevTools.DevToolsDomainBase
	{
		// Token: 0x06001528 RID: 5416 RVA: 0x000172EF File Offset: 0x000154EF
		public DOMDebuggerClient(global::CefSharp.DevTools.IDevToolsClient client)
		{
			this._client = client;
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x00017300 File Offset: 0x00015500
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DOMDebugger.GetEventListenersResponse> GetEventListenersAsync(string objectId, int? depth = null, bool? pierce = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("objectId", objectId);
			if (depth != null)
			{
				dictionary.Add("depth", depth.Value);
			}
			if (pierce != null)
			{
				dictionary.Add("pierce", pierce.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DOMDebugger.GetEventListenersResponse>("DOMDebugger.getEventListeners", dictionary);
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x00017370 File Offset: 0x00015570
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> RemoveDOMBreakpointAsync(int nodeId, global::CefSharp.DevTools.DOMDebugger.DOMBreakpointType type)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("nodeId", nodeId);
			dictionary.Add("type", base.EnumToString(type));
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("DOMDebugger.removeDOMBreakpoint", dictionary);
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x000173BC File Offset: 0x000155BC
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> RemoveEventListenerBreakpointAsync(string eventName, string targetName = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("eventName", eventName);
			if (!string.IsNullOrEmpty(targetName))
			{
				dictionary.Add("targetName", targetName);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("DOMDebugger.removeEventListenerBreakpoint", dictionary);
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x00017400 File Offset: 0x00015600
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> RemoveInstrumentationBreakpointAsync(string eventName)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("eventName", eventName);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("DOMDebugger.removeInstrumentationBreakpoint", dictionary);
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x00017430 File Offset: 0x00015630
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> RemoveXHRBreakpointAsync(string url)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("url", url);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("DOMDebugger.removeXHRBreakpoint", dictionary);
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x00017460 File Offset: 0x00015660
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetBreakOnCSPViolationAsync(global::CefSharp.DevTools.DOMDebugger.CSPViolationType[] violationTypes)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("violationTypes", base.EnumToString(violationTypes));
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("DOMDebugger.setBreakOnCSPViolation", dictionary);
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x00017498 File Offset: 0x00015698
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetDOMBreakpointAsync(int nodeId, global::CefSharp.DevTools.DOMDebugger.DOMBreakpointType type)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("nodeId", nodeId);
			dictionary.Add("type", base.EnumToString(type));
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("DOMDebugger.setDOMBreakpoint", dictionary);
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x000174E4 File Offset: 0x000156E4
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetEventListenerBreakpointAsync(string eventName, string targetName = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("eventName", eventName);
			if (!string.IsNullOrEmpty(targetName))
			{
				dictionary.Add("targetName", targetName);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("DOMDebugger.setEventListenerBreakpoint", dictionary);
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x00017528 File Offset: 0x00015728
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetInstrumentationBreakpointAsync(string eventName)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("eventName", eventName);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("DOMDebugger.setInstrumentationBreakpoint", dictionary);
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x00017558 File Offset: 0x00015758
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetXHRBreakpointAsync(string url)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("url", url);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("DOMDebugger.setXHRBreakpoint", dictionary);
		}

		// Token: 0x04000B47 RID: 2887
		private global::CefSharp.DevTools.IDevToolsClient _client;
	}
}
