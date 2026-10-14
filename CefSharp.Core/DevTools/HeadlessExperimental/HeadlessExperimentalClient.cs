using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CefSharp.DevTools.HeadlessExperimental
{
	// Token: 0x02000282 RID: 642
	public class HeadlessExperimentalClient : global::CefSharp.DevTools.DevToolsDomainBase
	{
		// Token: 0x0600138B RID: 5003 RVA: 0x000159F6 File Offset: 0x00013BF6
		public HeadlessExperimentalClient(global::CefSharp.DevTools.IDevToolsClient client)
		{
			this._client = client;
		}

		// Token: 0x0600138C RID: 5004 RVA: 0x00015A08 File Offset: 0x00013C08
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.HeadlessExperimental.BeginFrameResponse> BeginFrameAsync(double? frameTimeTicks = null, double? interval = null, bool? noDisplayUpdates = null, global::CefSharp.DevTools.HeadlessExperimental.ScreenshotParams screenshot = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (frameTimeTicks != null)
			{
				dictionary.Add("frameTimeTicks", frameTimeTicks.Value);
			}
			if (interval != null)
			{
				dictionary.Add("interval", interval.Value);
			}
			if (noDisplayUpdates != null)
			{
				dictionary.Add("noDisplayUpdates", noDisplayUpdates.Value);
			}
			if (screenshot != null)
			{
				dictionary.Add("screenshot", screenshot.ToDictionary());
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.HeadlessExperimental.BeginFrameResponse>("HeadlessExperimental.beginFrame", dictionary);
		}

		// Token: 0x04000A89 RID: 2697
		private global::CefSharp.DevTools.IDevToolsClient _client;
	}
}
