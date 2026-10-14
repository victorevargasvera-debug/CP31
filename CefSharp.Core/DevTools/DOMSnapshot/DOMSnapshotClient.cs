using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CefSharp.DevTools.DOMSnapshot
{
	// Token: 0x020002AB RID: 683
	public class DOMSnapshotClient : global::CefSharp.DevTools.DevToolsDomainBase
	{
		// Token: 0x0600150B RID: 5387 RVA: 0x0001711A File Offset: 0x0001531A
		public DOMSnapshotClient(global::CefSharp.DevTools.IDevToolsClient client)
		{
			this._client = client;
		}

		// Token: 0x0600150C RID: 5388 RVA: 0x0001712C File Offset: 0x0001532C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> DisableAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("DOMSnapshot.disable", parameters);
		}

		// Token: 0x0600150D RID: 5389 RVA: 0x0001714C File Offset: 0x0001534C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> EnableAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("DOMSnapshot.enable", parameters);
		}

		// Token: 0x0600150E RID: 5390 RVA: 0x0001716C File Offset: 0x0001536C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DOMSnapshot.CaptureSnapshotResponse> CaptureSnapshotAsync(string[] computedStyles, bool? includePaintOrder = null, bool? includeDOMRects = null, bool? includeBlendedBackgroundColors = null, bool? includeTextColorOpacities = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("computedStyles", computedStyles);
			if (includePaintOrder != null)
			{
				dictionary.Add("includePaintOrder", includePaintOrder.Value);
			}
			if (includeDOMRects != null)
			{
				dictionary.Add("includeDOMRects", includeDOMRects.Value);
			}
			if (includeBlendedBackgroundColors != null)
			{
				dictionary.Add("includeBlendedBackgroundColors", includeBlendedBackgroundColors.Value);
			}
			if (includeTextColorOpacities != null)
			{
				dictionary.Add("includeTextColorOpacities", includeTextColorOpacities.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DOMSnapshot.CaptureSnapshotResponse>("DOMSnapshot.captureSnapshot", dictionary);
		}

		// Token: 0x04000B34 RID: 2868
		private global::CefSharp.DevTools.IDevToolsClient _client;
	}
}
