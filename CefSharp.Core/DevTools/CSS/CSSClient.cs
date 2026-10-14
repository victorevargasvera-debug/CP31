using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x0200032E RID: 814
	public class CSSClient : global::CefSharp.DevTools.DevToolsDomainBase
	{
		// Token: 0x060018C3 RID: 6339 RVA: 0x0001A5CF File Offset: 0x000187CF
		public CSSClient(global::CefSharp.DevTools.IDevToolsClient client)
		{
			this._client = client;
		}

		// Token: 0x140000A9 RID: 169
		// (add) Token: 0x060018C4 RID: 6340 RVA: 0x0001A5DE File Offset: 0x000187DE
		// (remove) Token: 0x060018C5 RID: 6341 RVA: 0x0001A5F1 File Offset: 0x000187F1
		public event global::System.EventHandler<global::CefSharp.DevTools.CSS.FontsUpdatedEventArgs> FontsUpdated
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.CSS.FontsUpdatedEventArgs>("CSS.fontsUpdated", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.CSS.FontsUpdatedEventArgs>("CSS.fontsUpdated", value);
			}
		}

		// Token: 0x140000AA RID: 170
		// (add) Token: 0x060018C6 RID: 6342 RVA: 0x0001A605 File Offset: 0x00018805
		// (remove) Token: 0x060018C7 RID: 6343 RVA: 0x0001A618 File Offset: 0x00018818
		public event global::System.EventHandler<global::System.EventArgs> MediaQueryResultChanged
		{
			add
			{
				this._client.AddEventHandler<global::System.EventArgs>("CSS.mediaQueryResultChanged", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::System.EventArgs>("CSS.mediaQueryResultChanged", value);
			}
		}

		// Token: 0x140000AB RID: 171
		// (add) Token: 0x060018C8 RID: 6344 RVA: 0x0001A62C File Offset: 0x0001882C
		// (remove) Token: 0x060018C9 RID: 6345 RVA: 0x0001A63F File Offset: 0x0001883F
		public event global::System.EventHandler<global::CefSharp.DevTools.CSS.StyleSheetAddedEventArgs> StyleSheetAdded
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.CSS.StyleSheetAddedEventArgs>("CSS.styleSheetAdded", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.CSS.StyleSheetAddedEventArgs>("CSS.styleSheetAdded", value);
			}
		}

		// Token: 0x140000AC RID: 172
		// (add) Token: 0x060018CA RID: 6346 RVA: 0x0001A653 File Offset: 0x00018853
		// (remove) Token: 0x060018CB RID: 6347 RVA: 0x0001A666 File Offset: 0x00018866
		public event global::System.EventHandler<global::CefSharp.DevTools.CSS.StyleSheetChangedEventArgs> StyleSheetChanged
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.CSS.StyleSheetChangedEventArgs>("CSS.styleSheetChanged", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.CSS.StyleSheetChangedEventArgs>("CSS.styleSheetChanged", value);
			}
		}

		// Token: 0x140000AD RID: 173
		// (add) Token: 0x060018CC RID: 6348 RVA: 0x0001A67A File Offset: 0x0001887A
		// (remove) Token: 0x060018CD RID: 6349 RVA: 0x0001A68D File Offset: 0x0001888D
		public event global::System.EventHandler<global::CefSharp.DevTools.CSS.StyleSheetRemovedEventArgs> StyleSheetRemoved
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.CSS.StyleSheetRemovedEventArgs>("CSS.styleSheetRemoved", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.CSS.StyleSheetRemovedEventArgs>("CSS.styleSheetRemoved", value);
			}
		}

		// Token: 0x060018CE RID: 6350 RVA: 0x0001A6A4 File Offset: 0x000188A4
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.CSS.AddRuleResponse> AddRuleAsync(string styleSheetId, string ruleText, global::CefSharp.DevTools.CSS.SourceRange location)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("styleSheetId", styleSheetId);
			dictionary.Add("ruleText", ruleText);
			dictionary.Add("location", location.ToDictionary());
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.CSS.AddRuleResponse>("CSS.addRule", dictionary);
		}

		// Token: 0x060018CF RID: 6351 RVA: 0x0001A6F4 File Offset: 0x000188F4
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.CSS.CollectClassNamesResponse> CollectClassNamesAsync(string styleSheetId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("styleSheetId", styleSheetId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.CSS.CollectClassNamesResponse>("CSS.collectClassNames", dictionary);
		}

		// Token: 0x060018D0 RID: 6352 RVA: 0x0001A724 File Offset: 0x00018924
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.CSS.CreateStyleSheetResponse> CreateStyleSheetAsync(string frameId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("frameId", frameId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.CSS.CreateStyleSheetResponse>("CSS.createStyleSheet", dictionary);
		}

		// Token: 0x060018D1 RID: 6353 RVA: 0x0001A754 File Offset: 0x00018954
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> DisableAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("CSS.disable", parameters);
		}

		// Token: 0x060018D2 RID: 6354 RVA: 0x0001A774 File Offset: 0x00018974
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> EnableAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("CSS.enable", parameters);
		}

		// Token: 0x060018D3 RID: 6355 RVA: 0x0001A794 File Offset: 0x00018994
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> ForcePseudoStateAsync(int nodeId, string[] forcedPseudoClasses)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("nodeId", nodeId);
			dictionary.Add("forcedPseudoClasses", forcedPseudoClasses);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("CSS.forcePseudoState", dictionary);
		}

		// Token: 0x060018D4 RID: 6356 RVA: 0x0001A7D8 File Offset: 0x000189D8
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.CSS.GetBackgroundColorsResponse> GetBackgroundColorsAsync(int nodeId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("nodeId", nodeId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.CSS.GetBackgroundColorsResponse>("CSS.getBackgroundColors", dictionary);
		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x0001A810 File Offset: 0x00018A10
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.CSS.GetComputedStyleForNodeResponse> GetComputedStyleForNodeAsync(int nodeId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("nodeId", nodeId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.CSS.GetComputedStyleForNodeResponse>("CSS.getComputedStyleForNode", dictionary);
		}

		// Token: 0x060018D6 RID: 6358 RVA: 0x0001A848 File Offset: 0x00018A48
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.CSS.GetInlineStylesForNodeResponse> GetInlineStylesForNodeAsync(int nodeId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("nodeId", nodeId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.CSS.GetInlineStylesForNodeResponse>("CSS.getInlineStylesForNode", dictionary);
		}

		// Token: 0x060018D7 RID: 6359 RVA: 0x0001A880 File Offset: 0x00018A80
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.CSS.GetMatchedStylesForNodeResponse> GetMatchedStylesForNodeAsync(int nodeId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("nodeId", nodeId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.CSS.GetMatchedStylesForNodeResponse>("CSS.getMatchedStylesForNode", dictionary);
		}

		// Token: 0x060018D8 RID: 6360 RVA: 0x0001A8B8 File Offset: 0x00018AB8
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.CSS.GetMediaQueriesResponse> GetMediaQueriesAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.CSS.GetMediaQueriesResponse>("CSS.getMediaQueries", parameters);
		}

		// Token: 0x060018D9 RID: 6361 RVA: 0x0001A8D8 File Offset: 0x00018AD8
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.CSS.GetPlatformFontsForNodeResponse> GetPlatformFontsForNodeAsync(int nodeId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("nodeId", nodeId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.CSS.GetPlatformFontsForNodeResponse>("CSS.getPlatformFontsForNode", dictionary);
		}

		// Token: 0x060018DA RID: 6362 RVA: 0x0001A910 File Offset: 0x00018B10
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.CSS.GetStyleSheetTextResponse> GetStyleSheetTextAsync(string styleSheetId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("styleSheetId", styleSheetId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.CSS.GetStyleSheetTextResponse>("CSS.getStyleSheetText", dictionary);
		}

		// Token: 0x060018DB RID: 6363 RVA: 0x0001A940 File Offset: 0x00018B40
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.CSS.GetLayersForNodeResponse> GetLayersForNodeAsync(int nodeId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("nodeId", nodeId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.CSS.GetLayersForNodeResponse>("CSS.getLayersForNode", dictionary);
		}

		// Token: 0x060018DC RID: 6364 RVA: 0x0001A978 File Offset: 0x00018B78
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> TrackComputedStyleUpdatesAsync(global::System.Collections.Generic.IList<global::CefSharp.DevTools.CSS.CSSComputedStyleProperty> propertiesToTrack)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("propertiesToTrack", from x in propertiesToTrack
			select x.ToDictionary());
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("CSS.trackComputedStyleUpdates", dictionary);
		}

		// Token: 0x060018DD RID: 6365 RVA: 0x0001A9CC File Offset: 0x00018BCC
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.CSS.TakeComputedStyleUpdatesResponse> TakeComputedStyleUpdatesAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.CSS.TakeComputedStyleUpdatesResponse>("CSS.takeComputedStyleUpdates", parameters);
		}

		// Token: 0x060018DE RID: 6366 RVA: 0x0001A9EC File Offset: 0x00018BEC
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetEffectivePropertyValueForNodeAsync(int nodeId, string propertyName, string value)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("nodeId", nodeId);
			dictionary.Add("propertyName", propertyName);
			dictionary.Add("value", value);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("CSS.setEffectivePropertyValueForNode", dictionary);
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x0001AA3C File Offset: 0x00018C3C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.CSS.SetKeyframeKeyResponse> SetKeyframeKeyAsync(string styleSheetId, global::CefSharp.DevTools.CSS.SourceRange range, string keyText)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("styleSheetId", styleSheetId);
			dictionary.Add("range", range.ToDictionary());
			dictionary.Add("keyText", keyText);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.CSS.SetKeyframeKeyResponse>("CSS.setKeyframeKey", dictionary);
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x0001AA8C File Offset: 0x00018C8C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.CSS.SetMediaTextResponse> SetMediaTextAsync(string styleSheetId, global::CefSharp.DevTools.CSS.SourceRange range, string text)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("styleSheetId", styleSheetId);
			dictionary.Add("range", range.ToDictionary());
			dictionary.Add("text", text);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.CSS.SetMediaTextResponse>("CSS.setMediaText", dictionary);
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x0001AADC File Offset: 0x00018CDC
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.CSS.SetContainerQueryTextResponse> SetContainerQueryTextAsync(string styleSheetId, global::CefSharp.DevTools.CSS.SourceRange range, string text)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("styleSheetId", styleSheetId);
			dictionary.Add("range", range.ToDictionary());
			dictionary.Add("text", text);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.CSS.SetContainerQueryTextResponse>("CSS.setContainerQueryText", dictionary);
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x0001AB2C File Offset: 0x00018D2C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.CSS.SetSupportsTextResponse> SetSupportsTextAsync(string styleSheetId, global::CefSharp.DevTools.CSS.SourceRange range, string text)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("styleSheetId", styleSheetId);
			dictionary.Add("range", range.ToDictionary());
			dictionary.Add("text", text);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.CSS.SetSupportsTextResponse>("CSS.setSupportsText", dictionary);
		}

		// Token: 0x060018E3 RID: 6371 RVA: 0x0001AB7C File Offset: 0x00018D7C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.CSS.SetScopeTextResponse> SetScopeTextAsync(string styleSheetId, global::CefSharp.DevTools.CSS.SourceRange range, string text)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("styleSheetId", styleSheetId);
			dictionary.Add("range", range.ToDictionary());
			dictionary.Add("text", text);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.CSS.SetScopeTextResponse>("CSS.setScopeText", dictionary);
		}

		// Token: 0x060018E4 RID: 6372 RVA: 0x0001ABCC File Offset: 0x00018DCC
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.CSS.SetRuleSelectorResponse> SetRuleSelectorAsync(string styleSheetId, global::CefSharp.DevTools.CSS.SourceRange range, string selector)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("styleSheetId", styleSheetId);
			dictionary.Add("range", range.ToDictionary());
			dictionary.Add("selector", selector);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.CSS.SetRuleSelectorResponse>("CSS.setRuleSelector", dictionary);
		}

		// Token: 0x060018E5 RID: 6373 RVA: 0x0001AC1C File Offset: 0x00018E1C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.CSS.SetStyleSheetTextResponse> SetStyleSheetTextAsync(string styleSheetId, string text)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("styleSheetId", styleSheetId);
			dictionary.Add("text", text);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.CSS.SetStyleSheetTextResponse>("CSS.setStyleSheetText", dictionary);
		}

		// Token: 0x060018E6 RID: 6374 RVA: 0x0001AC58 File Offset: 0x00018E58
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.CSS.SetStyleTextsResponse> SetStyleTextsAsync(global::System.Collections.Generic.IList<global::CefSharp.DevTools.CSS.StyleDeclarationEdit> edits)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("edits", from x in edits
			select x.ToDictionary());
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.CSS.SetStyleTextsResponse>("CSS.setStyleTexts", dictionary);
		}

		// Token: 0x060018E7 RID: 6375 RVA: 0x0001ACAC File Offset: 0x00018EAC
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> StartRuleUsageTrackingAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("CSS.startRuleUsageTracking", parameters);
		}

		// Token: 0x060018E8 RID: 6376 RVA: 0x0001ACCC File Offset: 0x00018ECC
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.CSS.StopRuleUsageTrackingResponse> StopRuleUsageTrackingAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.CSS.StopRuleUsageTrackingResponse>("CSS.stopRuleUsageTracking", parameters);
		}

		// Token: 0x060018E9 RID: 6377 RVA: 0x0001ACEC File Offset: 0x00018EEC
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.CSS.TakeCoverageDeltaResponse> TakeCoverageDeltaAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.CSS.TakeCoverageDeltaResponse>("CSS.takeCoverageDelta", parameters);
		}

		// Token: 0x060018EA RID: 6378 RVA: 0x0001AD0C File Offset: 0x00018F0C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetLocalFontsEnabledAsync(bool enabled)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("enabled", enabled);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("CSS.setLocalFontsEnabled", dictionary);
		}

		// Token: 0x04000CBA RID: 3258
		private global::CefSharp.DevTools.IDevToolsClient _client;
	}
}
