using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CefSharp.DevTools.Target
{
	// Token: 0x02000111 RID: 273
	public class TargetClient : global::CefSharp.DevTools.DevToolsDomainBase
	{
		// Token: 0x06000882 RID: 2178 RVA: 0x0000B009 File Offset: 0x00009209
		public TargetClient(global::CefSharp.DevTools.IDevToolsClient client)
		{
			this._client = client;
		}

		// Token: 0x1400003F RID: 63
		// (add) Token: 0x06000883 RID: 2179 RVA: 0x0000B018 File Offset: 0x00009218
		// (remove) Token: 0x06000884 RID: 2180 RVA: 0x0000B02B File Offset: 0x0000922B
		public event global::System.EventHandler<global::CefSharp.DevTools.Target.AttachedToTargetEventArgs> AttachedToTarget
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Target.AttachedToTargetEventArgs>("Target.attachedToTarget", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Target.AttachedToTargetEventArgs>("Target.attachedToTarget", value);
			}
		}

		// Token: 0x14000040 RID: 64
		// (add) Token: 0x06000885 RID: 2181 RVA: 0x0000B03F File Offset: 0x0000923F
		// (remove) Token: 0x06000886 RID: 2182 RVA: 0x0000B052 File Offset: 0x00009252
		public event global::System.EventHandler<global::CefSharp.DevTools.Target.DetachedFromTargetEventArgs> DetachedFromTarget
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Target.DetachedFromTargetEventArgs>("Target.detachedFromTarget", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Target.DetachedFromTargetEventArgs>("Target.detachedFromTarget", value);
			}
		}

		// Token: 0x14000041 RID: 65
		// (add) Token: 0x06000887 RID: 2183 RVA: 0x0000B066 File Offset: 0x00009266
		// (remove) Token: 0x06000888 RID: 2184 RVA: 0x0000B079 File Offset: 0x00009279
		public event global::System.EventHandler<global::CefSharp.DevTools.Target.ReceivedMessageFromTargetEventArgs> ReceivedMessageFromTarget
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Target.ReceivedMessageFromTargetEventArgs>("Target.receivedMessageFromTarget", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Target.ReceivedMessageFromTargetEventArgs>("Target.receivedMessageFromTarget", value);
			}
		}

		// Token: 0x14000042 RID: 66
		// (add) Token: 0x06000889 RID: 2185 RVA: 0x0000B08D File Offset: 0x0000928D
		// (remove) Token: 0x0600088A RID: 2186 RVA: 0x0000B0A0 File Offset: 0x000092A0
		public event global::System.EventHandler<global::CefSharp.DevTools.Target.TargetCreatedEventArgs> TargetCreated
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Target.TargetCreatedEventArgs>("Target.targetCreated", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Target.TargetCreatedEventArgs>("Target.targetCreated", value);
			}
		}

		// Token: 0x14000043 RID: 67
		// (add) Token: 0x0600088B RID: 2187 RVA: 0x0000B0B4 File Offset: 0x000092B4
		// (remove) Token: 0x0600088C RID: 2188 RVA: 0x0000B0C7 File Offset: 0x000092C7
		public event global::System.EventHandler<global::CefSharp.DevTools.Target.TargetDestroyedEventArgs> TargetDestroyed
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Target.TargetDestroyedEventArgs>("Target.targetDestroyed", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Target.TargetDestroyedEventArgs>("Target.targetDestroyed", value);
			}
		}

		// Token: 0x14000044 RID: 68
		// (add) Token: 0x0600088D RID: 2189 RVA: 0x0000B0DB File Offset: 0x000092DB
		// (remove) Token: 0x0600088E RID: 2190 RVA: 0x0000B0EE File Offset: 0x000092EE
		public event global::System.EventHandler<global::CefSharp.DevTools.Target.TargetCrashedEventArgs> TargetCrashed
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Target.TargetCrashedEventArgs>("Target.targetCrashed", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Target.TargetCrashedEventArgs>("Target.targetCrashed", value);
			}
		}

		// Token: 0x14000045 RID: 69
		// (add) Token: 0x0600088F RID: 2191 RVA: 0x0000B102 File Offset: 0x00009302
		// (remove) Token: 0x06000890 RID: 2192 RVA: 0x0000B115 File Offset: 0x00009315
		public event global::System.EventHandler<global::CefSharp.DevTools.Target.TargetInfoChangedEventArgs> TargetInfoChanged
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Target.TargetInfoChangedEventArgs>("Target.targetInfoChanged", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Target.TargetInfoChangedEventArgs>("Target.targetInfoChanged", value);
			}
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x0000B12C File Offset: 0x0000932C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> ActivateTargetAsync(string targetId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("targetId", targetId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Target.activateTarget", dictionary);
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x0000B15C File Offset: 0x0000935C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Target.AttachToTargetResponse> AttachToTargetAsync(string targetId, bool? flatten = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("targetId", targetId);
			if (flatten != null)
			{
				dictionary.Add("flatten", flatten.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Target.AttachToTargetResponse>("Target.attachToTarget", dictionary);
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x0000B1AC File Offset: 0x000093AC
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Target.AttachToBrowserTargetResponse> AttachToBrowserTargetAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Target.AttachToBrowserTargetResponse>("Target.attachToBrowserTarget", parameters);
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x0000B1CC File Offset: 0x000093CC
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Target.CloseTargetResponse> CloseTargetAsync(string targetId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("targetId", targetId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Target.CloseTargetResponse>("Target.closeTarget", dictionary);
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x0000B1FC File Offset: 0x000093FC
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> ExposeDevToolsProtocolAsync(string targetId, string bindingName = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("targetId", targetId);
			if (!string.IsNullOrEmpty(bindingName))
			{
				dictionary.Add("bindingName", bindingName);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Target.exposeDevToolsProtocol", dictionary);
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x0000B240 File Offset: 0x00009440
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Target.CreateBrowserContextResponse> CreateBrowserContextAsync(bool? disposeOnDetach = null, string proxyServer = null, string proxyBypassList = null, string[] originsWithUniversalNetworkAccess = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (disposeOnDetach != null)
			{
				dictionary.Add("disposeOnDetach", disposeOnDetach.Value);
			}
			if (!string.IsNullOrEmpty(proxyServer))
			{
				dictionary.Add("proxyServer", proxyServer);
			}
			if (!string.IsNullOrEmpty(proxyBypassList))
			{
				dictionary.Add("proxyBypassList", proxyBypassList);
			}
			if (originsWithUniversalNetworkAccess != null)
			{
				dictionary.Add("originsWithUniversalNetworkAccess", originsWithUniversalNetworkAccess);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Target.CreateBrowserContextResponse>("Target.createBrowserContext", dictionary);
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x0000B2C0 File Offset: 0x000094C0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Target.GetBrowserContextsResponse> GetBrowserContextsAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Target.GetBrowserContextsResponse>("Target.getBrowserContexts", parameters);
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x0000B2E0 File Offset: 0x000094E0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Target.CreateTargetResponse> CreateTargetAsync(string url, int? width = null, int? height = null, string browserContextId = null, bool? enableBeginFrameControl = null, bool? newWindow = null, bool? background = null, bool? forTab = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("url", url);
			if (width != null)
			{
				dictionary.Add("width", width.Value);
			}
			if (height != null)
			{
				dictionary.Add("height", height.Value);
			}
			if (!string.IsNullOrEmpty(browserContextId))
			{
				dictionary.Add("browserContextId", browserContextId);
			}
			if (enableBeginFrameControl != null)
			{
				dictionary.Add("enableBeginFrameControl", enableBeginFrameControl.Value);
			}
			if (newWindow != null)
			{
				dictionary.Add("newWindow", newWindow.Value);
			}
			if (background != null)
			{
				dictionary.Add("background", background.Value);
			}
			if (forTab != null)
			{
				dictionary.Add("forTab", forTab.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Target.CreateTargetResponse>("Target.createTarget", dictionary);
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x0000B3E8 File Offset: 0x000095E8
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> DetachFromTargetAsync(string sessionId = null, string targetId = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (!string.IsNullOrEmpty(sessionId))
			{
				dictionary.Add("sessionId", sessionId);
			}
			if (!string.IsNullOrEmpty(targetId))
			{
				dictionary.Add("targetId", targetId);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Target.detachFromTarget", dictionary);
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x0000B434 File Offset: 0x00009634
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> DisposeBrowserContextAsync(string browserContextId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("browserContextId", browserContextId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Target.disposeBrowserContext", dictionary);
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x0000B464 File Offset: 0x00009664
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Target.GetTargetInfoResponse> GetTargetInfoAsync(string targetId = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (!string.IsNullOrEmpty(targetId))
			{
				dictionary.Add("targetId", targetId);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Target.GetTargetInfoResponse>("Target.getTargetInfo", dictionary);
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x0000B49C File Offset: 0x0000969C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Target.GetTargetsResponse> GetTargetsAsync(global::System.Collections.Generic.IList<global::CefSharp.DevTools.Target.TargetFilter> filter = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (filter != null)
			{
				dictionary.Add("filter", from x in filter
				select x.ToDictionary());
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Target.GetTargetsResponse>("Target.getTargets", dictionary);
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x0000B4F4 File Offset: 0x000096F4
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetAutoAttachAsync(bool autoAttach, bool waitForDebuggerOnStart, bool? flatten = null, global::System.Collections.Generic.IList<global::CefSharp.DevTools.Target.TargetFilter> filter = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("autoAttach", autoAttach);
			dictionary.Add("waitForDebuggerOnStart", waitForDebuggerOnStart);
			if (flatten != null)
			{
				dictionary.Add("flatten", flatten.Value);
			}
			if (filter != null)
			{
				dictionary.Add("filter", from x in filter
				select x.ToDictionary());
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Target.setAutoAttach", dictionary);
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x0000B590 File Offset: 0x00009790
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> AutoAttachRelatedAsync(string targetId, bool waitForDebuggerOnStart, global::System.Collections.Generic.IList<global::CefSharp.DevTools.Target.TargetFilter> filter = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("targetId", targetId);
			dictionary.Add("waitForDebuggerOnStart", waitForDebuggerOnStart);
			if (filter != null)
			{
				dictionary.Add("filter", from x in filter
				select x.ToDictionary());
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Target.autoAttachRelated", dictionary);
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x0000B604 File Offset: 0x00009804
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetDiscoverTargetsAsync(bool discover, global::System.Collections.Generic.IList<global::CefSharp.DevTools.Target.TargetFilter> filter = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("discover", discover);
			if (filter != null)
			{
				dictionary.Add("filter", from x in filter
				select x.ToDictionary());
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Target.setDiscoverTargets", dictionary);
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x0000B66C File Offset: 0x0000986C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetRemoteLocationsAsync(global::System.Collections.Generic.IList<global::CefSharp.DevTools.Target.RemoteLocation> locations)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("locations", from x in locations
			select x.ToDictionary());
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Target.setRemoteLocations", dictionary);
		}

		// Token: 0x040003CD RID: 973
		private global::CefSharp.DevTools.IDevToolsClient _client;
	}
}
