using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CefSharp.DevTools.Accessibility
{
	// Token: 0x02000390 RID: 912
	public class AccessibilityClient : global::CefSharp.DevTools.DevToolsDomainBase
	{
		// Token: 0x06001B6D RID: 7021 RVA: 0x0001CD85 File Offset: 0x0001AF85
		public AccessibilityClient(global::CefSharp.DevTools.IDevToolsClient client)
		{
			this._client = client;
		}

		// Token: 0x140000B6 RID: 182
		// (add) Token: 0x06001B6E RID: 7022 RVA: 0x0001CD94 File Offset: 0x0001AF94
		// (remove) Token: 0x06001B6F RID: 7023 RVA: 0x0001CDA7 File Offset: 0x0001AFA7
		public event global::System.EventHandler<global::CefSharp.DevTools.Accessibility.LoadCompleteEventArgs> LoadComplete
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Accessibility.LoadCompleteEventArgs>("Accessibility.loadComplete", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Accessibility.LoadCompleteEventArgs>("Accessibility.loadComplete", value);
			}
		}

		// Token: 0x140000B7 RID: 183
		// (add) Token: 0x06001B70 RID: 7024 RVA: 0x0001CDBB File Offset: 0x0001AFBB
		// (remove) Token: 0x06001B71 RID: 7025 RVA: 0x0001CDCE File Offset: 0x0001AFCE
		public event global::System.EventHandler<global::CefSharp.DevTools.Accessibility.NodesUpdatedEventArgs> NodesUpdated
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Accessibility.NodesUpdatedEventArgs>("Accessibility.nodesUpdated", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Accessibility.NodesUpdatedEventArgs>("Accessibility.nodesUpdated", value);
			}
		}

		// Token: 0x06001B72 RID: 7026 RVA: 0x0001CDE4 File Offset: 0x0001AFE4
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> DisableAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Accessibility.disable", parameters);
		}

		// Token: 0x06001B73 RID: 7027 RVA: 0x0001CE04 File Offset: 0x0001B004
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> EnableAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Accessibility.enable", parameters);
		}

		// Token: 0x06001B74 RID: 7028 RVA: 0x0001CE24 File Offset: 0x0001B024
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Accessibility.GetPartialAXTreeResponse> GetPartialAXTreeAsync(int? nodeId = null, int? backendNodeId = null, string objectId = null, bool? fetchRelatives = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (nodeId != null)
			{
				dictionary.Add("nodeId", nodeId.Value);
			}
			if (backendNodeId != null)
			{
				dictionary.Add("backendNodeId", backendNodeId.Value);
			}
			if (!string.IsNullOrEmpty(objectId))
			{
				dictionary.Add("objectId", objectId);
			}
			if (fetchRelatives != null)
			{
				dictionary.Add("fetchRelatives", fetchRelatives.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Accessibility.GetPartialAXTreeResponse>("Accessibility.getPartialAXTree", dictionary);
		}

		// Token: 0x06001B75 RID: 7029 RVA: 0x0001CEBC File Offset: 0x0001B0BC
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Accessibility.GetFullAXTreeResponse> GetFullAXTreeAsync(int? depth = null, string frameId = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (depth != null)
			{
				dictionary.Add("depth", depth.Value);
			}
			if (!string.IsNullOrEmpty(frameId))
			{
				dictionary.Add("frameId", frameId);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Accessibility.GetFullAXTreeResponse>("Accessibility.getFullAXTree", dictionary);
		}

		// Token: 0x06001B76 RID: 7030 RVA: 0x0001CF14 File Offset: 0x0001B114
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Accessibility.GetRootAXNodeResponse> GetRootAXNodeAsync(string frameId = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (!string.IsNullOrEmpty(frameId))
			{
				dictionary.Add("frameId", frameId);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Accessibility.GetRootAXNodeResponse>("Accessibility.getRootAXNode", dictionary);
		}

		// Token: 0x06001B77 RID: 7031 RVA: 0x0001CF4C File Offset: 0x0001B14C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Accessibility.GetAXNodeAndAncestorsResponse> GetAXNodeAndAncestorsAsync(int? nodeId = null, int? backendNodeId = null, string objectId = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (nodeId != null)
			{
				dictionary.Add("nodeId", nodeId.Value);
			}
			if (backendNodeId != null)
			{
				dictionary.Add("backendNodeId", backendNodeId.Value);
			}
			if (!string.IsNullOrEmpty(objectId))
			{
				dictionary.Add("objectId", objectId);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Accessibility.GetAXNodeAndAncestorsResponse>("Accessibility.getAXNodeAndAncestors", dictionary);
		}

		// Token: 0x06001B78 RID: 7032 RVA: 0x0001CFC4 File Offset: 0x0001B1C4
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Accessibility.GetChildAXNodesResponse> GetChildAXNodesAsync(string id, string frameId = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("id", id);
			if (!string.IsNullOrEmpty(frameId))
			{
				dictionary.Add("frameId", frameId);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Accessibility.GetChildAXNodesResponse>("Accessibility.getChildAXNodes", dictionary);
		}

		// Token: 0x06001B79 RID: 7033 RVA: 0x0001D008 File Offset: 0x0001B208
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Accessibility.QueryAXTreeResponse> QueryAXTreeAsync(int? nodeId = null, int? backendNodeId = null, string objectId = null, string accessibleName = null, string role = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (nodeId != null)
			{
				dictionary.Add("nodeId", nodeId.Value);
			}
			if (backendNodeId != null)
			{
				dictionary.Add("backendNodeId", backendNodeId.Value);
			}
			if (!string.IsNullOrEmpty(objectId))
			{
				dictionary.Add("objectId", objectId);
			}
			if (!string.IsNullOrEmpty(accessibleName))
			{
				dictionary.Add("accessibleName", accessibleName);
			}
			if (!string.IsNullOrEmpty(role))
			{
				dictionary.Add("role", role);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Accessibility.QueryAXTreeResponse>("Accessibility.queryAXTree", dictionary);
		}

		// Token: 0x04000ED0 RID: 3792
		private global::CefSharp.DevTools.IDevToolsClient _client;
	}
}
