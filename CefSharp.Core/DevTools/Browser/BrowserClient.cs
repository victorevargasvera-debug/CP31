using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CefSharp.DevTools.Browser
{
	// Token: 0x02000341 RID: 833
	public class BrowserClient : global::CefSharp.DevTools.DevToolsDomainBase
	{
		// Token: 0x0600194E RID: 6478 RVA: 0x0001B0BB File Offset: 0x000192BB
		public BrowserClient(global::CefSharp.DevTools.IDevToolsClient client)
		{
			this._client = client;
		}

		// Token: 0x140000AE RID: 174
		// (add) Token: 0x0600194F RID: 6479 RVA: 0x0001B0CA File Offset: 0x000192CA
		// (remove) Token: 0x06001950 RID: 6480 RVA: 0x0001B0DD File Offset: 0x000192DD
		public event global::System.EventHandler<global::CefSharp.DevTools.Browser.DownloadWillBeginEventArgs> DownloadWillBegin
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Browser.DownloadWillBeginEventArgs>("Browser.downloadWillBegin", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Browser.DownloadWillBeginEventArgs>("Browser.downloadWillBegin", value);
			}
		}

		// Token: 0x140000AF RID: 175
		// (add) Token: 0x06001951 RID: 6481 RVA: 0x0001B0F1 File Offset: 0x000192F1
		// (remove) Token: 0x06001952 RID: 6482 RVA: 0x0001B104 File Offset: 0x00019304
		public event global::System.EventHandler<global::CefSharp.DevTools.Browser.DownloadProgressEventArgs> DownloadProgress
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Browser.DownloadProgressEventArgs>("Browser.downloadProgress", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Browser.DownloadProgressEventArgs>("Browser.downloadProgress", value);
			}
		}

		// Token: 0x06001953 RID: 6483 RVA: 0x0001B118 File Offset: 0x00019318
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetPermissionAsync(global::CefSharp.DevTools.Browser.PermissionDescriptor permission, global::CefSharp.DevTools.Browser.PermissionSetting setting, string origin = null, string browserContextId = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("permission", permission.ToDictionary());
			dictionary.Add("setting", base.EnumToString(setting));
			if (!string.IsNullOrEmpty(origin))
			{
				dictionary.Add("origin", origin);
			}
			if (!string.IsNullOrEmpty(browserContextId))
			{
				dictionary.Add("browserContextId", browserContextId);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Browser.setPermission", dictionary);
		}

		// Token: 0x06001954 RID: 6484 RVA: 0x0001B190 File Offset: 0x00019390
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> GrantPermissionsAsync(global::CefSharp.DevTools.Browser.PermissionType[] permissions, string origin = null, string browserContextId = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("permissions", base.EnumToString(permissions));
			if (!string.IsNullOrEmpty(origin))
			{
				dictionary.Add("origin", origin);
			}
			if (!string.IsNullOrEmpty(browserContextId))
			{
				dictionary.Add("browserContextId", browserContextId);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Browser.grantPermissions", dictionary);
		}

		// Token: 0x06001955 RID: 6485 RVA: 0x0001B1F0 File Offset: 0x000193F0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> ResetPermissionsAsync(string browserContextId = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (!string.IsNullOrEmpty(browserContextId))
			{
				dictionary.Add("browserContextId", browserContextId);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Browser.resetPermissions", dictionary);
		}

		// Token: 0x06001956 RID: 6486 RVA: 0x0001B228 File Offset: 0x00019428
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetDownloadBehaviorAsync(global::CefSharp.DevTools.Browser.SetDownloadBehaviorBehavior behavior, string browserContextId = null, string downloadPath = null, bool? eventsEnabled = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("behavior", base.EnumToString(behavior));
			if (!string.IsNullOrEmpty(browserContextId))
			{
				dictionary.Add("browserContextId", browserContextId);
			}
			if (!string.IsNullOrEmpty(downloadPath))
			{
				dictionary.Add("downloadPath", downloadPath);
			}
			if (eventsEnabled != null)
			{
				dictionary.Add("eventsEnabled", eventsEnabled.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Browser.setDownloadBehavior", dictionary);
		}

		// Token: 0x06001957 RID: 6487 RVA: 0x0001B2AC File Offset: 0x000194AC
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> CancelDownloadAsync(string guid, string browserContextId = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("guid", guid);
			if (!string.IsNullOrEmpty(browserContextId))
			{
				dictionary.Add("browserContextId", browserContextId);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Browser.cancelDownload", dictionary);
		}

		// Token: 0x06001958 RID: 6488 RVA: 0x0001B2F0 File Offset: 0x000194F0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> CloseAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Browser.close", parameters);
		}

		// Token: 0x06001959 RID: 6489 RVA: 0x0001B310 File Offset: 0x00019510
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> CrashAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Browser.crash", parameters);
		}

		// Token: 0x0600195A RID: 6490 RVA: 0x0001B330 File Offset: 0x00019530
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> CrashGpuProcessAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Browser.crashGpuProcess", parameters);
		}

		// Token: 0x0600195B RID: 6491 RVA: 0x0001B350 File Offset: 0x00019550
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Browser.GetVersionResponse> GetVersionAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Browser.GetVersionResponse>("Browser.getVersion", parameters);
		}

		// Token: 0x0600195C RID: 6492 RVA: 0x0001B370 File Offset: 0x00019570
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Browser.GetBrowserCommandLineResponse> GetBrowserCommandLineAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Browser.GetBrowserCommandLineResponse>("Browser.getBrowserCommandLine", parameters);
		}

		// Token: 0x0600195D RID: 6493 RVA: 0x0001B390 File Offset: 0x00019590
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Browser.GetHistogramsResponse> GetHistogramsAsync(string query = null, bool? delta = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (!string.IsNullOrEmpty(query))
			{
				dictionary.Add("query", query);
			}
			if (delta != null)
			{
				dictionary.Add("delta", delta.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Browser.GetHistogramsResponse>("Browser.getHistograms", dictionary);
		}

		// Token: 0x0600195E RID: 6494 RVA: 0x0001B3E8 File Offset: 0x000195E8
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Browser.GetHistogramResponse> GetHistogramAsync(string name, bool? delta = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("name", name);
			if (delta != null)
			{
				dictionary.Add("delta", delta.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Browser.GetHistogramResponse>("Browser.getHistogram", dictionary);
		}

		// Token: 0x0600195F RID: 6495 RVA: 0x0001B438 File Offset: 0x00019638
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Browser.GetWindowBoundsResponse> GetWindowBoundsAsync(int windowId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("windowId", windowId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Browser.GetWindowBoundsResponse>("Browser.getWindowBounds", dictionary);
		}

		// Token: 0x06001960 RID: 6496 RVA: 0x0001B470 File Offset: 0x00019670
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Browser.GetWindowForTargetResponse> GetWindowForTargetAsync(string targetId = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (!string.IsNullOrEmpty(targetId))
			{
				dictionary.Add("targetId", targetId);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Browser.GetWindowForTargetResponse>("Browser.getWindowForTarget", dictionary);
		}

		// Token: 0x06001961 RID: 6497 RVA: 0x0001B4A8 File Offset: 0x000196A8
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetWindowBoundsAsync(int windowId, global::CefSharp.DevTools.Browser.Bounds bounds)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("windowId", windowId);
			dictionary.Add("bounds", bounds.ToDictionary());
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Browser.setWindowBounds", dictionary);
		}

		// Token: 0x06001962 RID: 6498 RVA: 0x0001B4F0 File Offset: 0x000196F0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetDockTileAsync(string badgeLabel = null, byte[] image = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (!string.IsNullOrEmpty(badgeLabel))
			{
				dictionary.Add("badgeLabel", badgeLabel);
			}
			if (image != null)
			{
				dictionary.Add("image", base.ToBase64String(image));
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Browser.setDockTile", dictionary);
		}

		// Token: 0x06001963 RID: 6499 RVA: 0x0001B540 File Offset: 0x00019740
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> ExecuteBrowserCommandAsync(global::CefSharp.DevTools.Browser.BrowserCommandId commandId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("commandId", base.EnumToString(commandId));
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Browser.executeBrowserCommand", dictionary);
		}

		// Token: 0x04000D10 RID: 3344
		private global::CefSharp.DevTools.IDevToolsClient _client;
	}
}
