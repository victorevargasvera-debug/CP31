using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CefSharp.DevTools.DOM;

namespace CefSharp.DevTools.Overlay
{
	// Token: 0x020001DA RID: 474
	public class OverlayClient : global::CefSharp.DevTools.DevToolsDomainBase
	{
		// Token: 0x06000E3F RID: 3647 RVA: 0x000102BA File Offset: 0x0000E4BA
		public OverlayClient(global::CefSharp.DevTools.IDevToolsClient client)
		{
			this._client = client;
		}

		// Token: 0x1400006A RID: 106
		// (add) Token: 0x06000E40 RID: 3648 RVA: 0x000102C9 File Offset: 0x0000E4C9
		// (remove) Token: 0x06000E41 RID: 3649 RVA: 0x000102DC File Offset: 0x0000E4DC
		public event global::System.EventHandler<global::CefSharp.DevTools.Overlay.InspectNodeRequestedEventArgs> InspectNodeRequested
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Overlay.InspectNodeRequestedEventArgs>("Overlay.inspectNodeRequested", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Overlay.InspectNodeRequestedEventArgs>("Overlay.inspectNodeRequested", value);
			}
		}

		// Token: 0x1400006B RID: 107
		// (add) Token: 0x06000E42 RID: 3650 RVA: 0x000102F0 File Offset: 0x0000E4F0
		// (remove) Token: 0x06000E43 RID: 3651 RVA: 0x00010303 File Offset: 0x0000E503
		public event global::System.EventHandler<global::CefSharp.DevTools.Overlay.NodeHighlightRequestedEventArgs> NodeHighlightRequested
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Overlay.NodeHighlightRequestedEventArgs>("Overlay.nodeHighlightRequested", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Overlay.NodeHighlightRequestedEventArgs>("Overlay.nodeHighlightRequested", value);
			}
		}

		// Token: 0x1400006C RID: 108
		// (add) Token: 0x06000E44 RID: 3652 RVA: 0x00010317 File Offset: 0x0000E517
		// (remove) Token: 0x06000E45 RID: 3653 RVA: 0x0001032A File Offset: 0x0000E52A
		public event global::System.EventHandler<global::CefSharp.DevTools.Overlay.ScreenshotRequestedEventArgs> ScreenshotRequested
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Overlay.ScreenshotRequestedEventArgs>("Overlay.screenshotRequested", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Overlay.ScreenshotRequestedEventArgs>("Overlay.screenshotRequested", value);
			}
		}

		// Token: 0x1400006D RID: 109
		// (add) Token: 0x06000E46 RID: 3654 RVA: 0x0001033E File Offset: 0x0000E53E
		// (remove) Token: 0x06000E47 RID: 3655 RVA: 0x00010351 File Offset: 0x0000E551
		public event global::System.EventHandler<global::System.EventArgs> InspectModeCanceled
		{
			add
			{
				this._client.AddEventHandler<global::System.EventArgs>("Overlay.inspectModeCanceled", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::System.EventArgs>("Overlay.inspectModeCanceled", value);
			}
		}

		// Token: 0x06000E48 RID: 3656 RVA: 0x00010368 File Offset: 0x0000E568
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> DisableAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Overlay.disable", parameters);
		}

		// Token: 0x06000E49 RID: 3657 RVA: 0x00010388 File Offset: 0x0000E588
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> EnableAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Overlay.enable", parameters);
		}

		// Token: 0x06000E4A RID: 3658 RVA: 0x000103A8 File Offset: 0x0000E5A8
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Overlay.GetHighlightObjectForTestResponse> GetHighlightObjectForTestAsync(int nodeId, bool? includeDistance = null, bool? includeStyle = null, global::CefSharp.DevTools.Overlay.ColorFormat? colorFormat = null, bool? showAccessibilityInfo = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("nodeId", nodeId);
			if (includeDistance != null)
			{
				dictionary.Add("includeDistance", includeDistance.Value);
			}
			if (includeStyle != null)
			{
				dictionary.Add("includeStyle", includeStyle.Value);
			}
			if (colorFormat != null)
			{
				dictionary.Add("colorFormat", base.EnumToString(colorFormat));
			}
			if (showAccessibilityInfo != null)
			{
				dictionary.Add("showAccessibilityInfo", showAccessibilityInfo.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Overlay.GetHighlightObjectForTestResponse>("Overlay.getHighlightObjectForTest", dictionary);
		}

		// Token: 0x06000E4B RID: 3659 RVA: 0x00010460 File Offset: 0x0000E660
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Overlay.GetGridHighlightObjectsForTestResponse> GetGridHighlightObjectsForTestAsync(int[] nodeIds)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("nodeIds", nodeIds);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Overlay.GetGridHighlightObjectsForTestResponse>("Overlay.getGridHighlightObjectsForTest", dictionary);
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x00010490 File Offset: 0x0000E690
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Overlay.GetSourceOrderHighlightObjectForTestResponse> GetSourceOrderHighlightObjectForTestAsync(int nodeId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("nodeId", nodeId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Overlay.GetSourceOrderHighlightObjectForTestResponse>("Overlay.getSourceOrderHighlightObjectForTest", dictionary);
		}

		// Token: 0x06000E4D RID: 3661 RVA: 0x000104C8 File Offset: 0x0000E6C8
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> HideHighlightAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Overlay.hideHighlight", parameters);
		}

		// Token: 0x06000E4E RID: 3662 RVA: 0x000104E8 File Offset: 0x0000E6E8
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> HighlightNodeAsync(global::CefSharp.DevTools.Overlay.HighlightConfig highlightConfig, int? nodeId = null, int? backendNodeId = null, string objectId = null, string selector = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("highlightConfig", highlightConfig.ToDictionary());
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
			if (!string.IsNullOrEmpty(selector))
			{
				dictionary.Add("selector", selector);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Overlay.highlightNode", dictionary);
		}

		// Token: 0x06000E4F RID: 3663 RVA: 0x0001058C File Offset: 0x0000E78C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> HighlightQuadAsync(double[] quad, global::CefSharp.DevTools.DOM.RGBA color = null, global::CefSharp.DevTools.DOM.RGBA outlineColor = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("quad", quad);
			if (color != null)
			{
				dictionary.Add("color", color.ToDictionary());
			}
			if (outlineColor != null)
			{
				dictionary.Add("outlineColor", outlineColor.ToDictionary());
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Overlay.highlightQuad", dictionary);
		}

		// Token: 0x06000E50 RID: 3664 RVA: 0x000105E4 File Offset: 0x0000E7E4
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> HighlightRectAsync(int x, int y, int width, int height, global::CefSharp.DevTools.DOM.RGBA color = null, global::CefSharp.DevTools.DOM.RGBA outlineColor = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("x", x);
			dictionary.Add("y", y);
			dictionary.Add("width", width);
			dictionary.Add("height", height);
			if (color != null)
			{
				dictionary.Add("color", color.ToDictionary());
			}
			if (outlineColor != null)
			{
				dictionary.Add("outlineColor", outlineColor.ToDictionary());
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Overlay.highlightRect", dictionary);
		}

		// Token: 0x06000E51 RID: 3665 RVA: 0x0001067C File Offset: 0x0000E87C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> HighlightSourceOrderAsync(global::CefSharp.DevTools.Overlay.SourceOrderConfig sourceOrderConfig, int? nodeId = null, int? backendNodeId = null, string objectId = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("sourceOrderConfig", sourceOrderConfig.ToDictionary());
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
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Overlay.highlightSourceOrder", dictionary);
		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x00010708 File Offset: 0x0000E908
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetInspectModeAsync(global::CefSharp.DevTools.Overlay.InspectMode mode, global::CefSharp.DevTools.Overlay.HighlightConfig highlightConfig = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("mode", base.EnumToString(mode));
			if (highlightConfig != null)
			{
				dictionary.Add("highlightConfig", highlightConfig.ToDictionary());
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Overlay.setInspectMode", dictionary);
		}

		// Token: 0x06000E53 RID: 3667 RVA: 0x00010758 File Offset: 0x0000E958
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetShowAdHighlightsAsync(bool show)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("show", show);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Overlay.setShowAdHighlights", dictionary);
		}

		// Token: 0x06000E54 RID: 3668 RVA: 0x00010790 File Offset: 0x0000E990
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetPausedInDebuggerMessageAsync(string message = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (!string.IsNullOrEmpty(message))
			{
				dictionary.Add("message", message);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Overlay.setPausedInDebuggerMessage", dictionary);
		}

		// Token: 0x06000E55 RID: 3669 RVA: 0x000107C8 File Offset: 0x0000E9C8
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetShowDebugBordersAsync(bool show)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("show", show);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Overlay.setShowDebugBorders", dictionary);
		}

		// Token: 0x06000E56 RID: 3670 RVA: 0x00010800 File Offset: 0x0000EA00
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetShowFPSCounterAsync(bool show)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("show", show);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Overlay.setShowFPSCounter", dictionary);
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x00010838 File Offset: 0x0000EA38
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetShowGridOverlaysAsync(global::System.Collections.Generic.IList<global::CefSharp.DevTools.Overlay.GridNodeHighlightConfig> gridNodeHighlightConfigs)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("gridNodeHighlightConfigs", from x in gridNodeHighlightConfigs
			select x.ToDictionary());
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Overlay.setShowGridOverlays", dictionary);
		}

		// Token: 0x06000E58 RID: 3672 RVA: 0x0001088C File Offset: 0x0000EA8C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetShowFlexOverlaysAsync(global::System.Collections.Generic.IList<global::CefSharp.DevTools.Overlay.FlexNodeHighlightConfig> flexNodeHighlightConfigs)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("flexNodeHighlightConfigs", from x in flexNodeHighlightConfigs
			select x.ToDictionary());
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Overlay.setShowFlexOverlays", dictionary);
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x000108E0 File Offset: 0x0000EAE0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetShowScrollSnapOverlaysAsync(global::System.Collections.Generic.IList<global::CefSharp.DevTools.Overlay.ScrollSnapHighlightConfig> scrollSnapHighlightConfigs)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("scrollSnapHighlightConfigs", from x in scrollSnapHighlightConfigs
			select x.ToDictionary());
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Overlay.setShowScrollSnapOverlays", dictionary);
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x00010934 File Offset: 0x0000EB34
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetShowContainerQueryOverlaysAsync(global::System.Collections.Generic.IList<global::CefSharp.DevTools.Overlay.ContainerQueryHighlightConfig> containerQueryHighlightConfigs)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("containerQueryHighlightConfigs", from x in containerQueryHighlightConfigs
			select x.ToDictionary());
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Overlay.setShowContainerQueryOverlays", dictionary);
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x00010988 File Offset: 0x0000EB88
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetShowPaintRectsAsync(bool result)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("result", result);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Overlay.setShowPaintRects", dictionary);
		}

		// Token: 0x06000E5C RID: 3676 RVA: 0x000109C0 File Offset: 0x0000EBC0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetShowLayoutShiftRegionsAsync(bool result)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("result", result);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Overlay.setShowLayoutShiftRegions", dictionary);
		}

		// Token: 0x06000E5D RID: 3677 RVA: 0x000109F8 File Offset: 0x0000EBF8
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetShowScrollBottleneckRectsAsync(bool show)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("show", show);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Overlay.setShowScrollBottleneckRects", dictionary);
		}

		// Token: 0x06000E5E RID: 3678 RVA: 0x00010A30 File Offset: 0x0000EC30
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetShowWebVitalsAsync(bool show)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("show", show);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Overlay.setShowWebVitals", dictionary);
		}

		// Token: 0x06000E5F RID: 3679 RVA: 0x00010A68 File Offset: 0x0000EC68
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetShowViewportSizeOnResizeAsync(bool show)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("show", show);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Overlay.setShowViewportSizeOnResize", dictionary);
		}

		// Token: 0x06000E60 RID: 3680 RVA: 0x00010AA0 File Offset: 0x0000ECA0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetShowHingeAsync(global::CefSharp.DevTools.Overlay.HingeConfig hingeConfig = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (hingeConfig != null)
			{
				dictionary.Add("hingeConfig", hingeConfig.ToDictionary());
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Overlay.setShowHinge", dictionary);
		}

		// Token: 0x06000E61 RID: 3681 RVA: 0x00010AD8 File Offset: 0x0000ECD8
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetShowIsolatedElementsAsync(global::System.Collections.Generic.IList<global::CefSharp.DevTools.Overlay.IsolatedElementHighlightConfig> isolatedElementHighlightConfigs)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("isolatedElementHighlightConfigs", from x in isolatedElementHighlightConfigs
			select x.ToDictionary());
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Overlay.setShowIsolatedElements", dictionary);
		}

		// Token: 0x0400076D RID: 1901
		private global::CefSharp.DevTools.IDevToolsClient _client;
	}
}
