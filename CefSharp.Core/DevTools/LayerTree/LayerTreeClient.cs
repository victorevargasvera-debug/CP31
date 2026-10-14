using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CefSharp.DevTools.DOM;

namespace CefSharp.DevTools.LayerTree
{
	// Token: 0x02000261 RID: 609
	public class LayerTreeClient : global::CefSharp.DevTools.DevToolsDomainBase
	{
		// Token: 0x060012C9 RID: 4809 RVA: 0x000143B6 File Offset: 0x000125B6
		public LayerTreeClient(global::CefSharp.DevTools.IDevToolsClient client)
		{
			this._client = client;
		}

		// Token: 0x1400008C RID: 140
		// (add) Token: 0x060012CA RID: 4810 RVA: 0x000143C5 File Offset: 0x000125C5
		// (remove) Token: 0x060012CB RID: 4811 RVA: 0x000143D8 File Offset: 0x000125D8
		public event global::System.EventHandler<global::CefSharp.DevTools.LayerTree.LayerPaintedEventArgs> LayerPainted
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.LayerTree.LayerPaintedEventArgs>("LayerTree.layerPainted", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.LayerTree.LayerPaintedEventArgs>("LayerTree.layerPainted", value);
			}
		}

		// Token: 0x1400008D RID: 141
		// (add) Token: 0x060012CC RID: 4812 RVA: 0x000143EC File Offset: 0x000125EC
		// (remove) Token: 0x060012CD RID: 4813 RVA: 0x000143FF File Offset: 0x000125FF
		public event global::System.EventHandler<global::CefSharp.DevTools.LayerTree.LayerTreeDidChangeEventArgs> LayerTreeDidChange
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.LayerTree.LayerTreeDidChangeEventArgs>("LayerTree.layerTreeDidChange", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.LayerTree.LayerTreeDidChangeEventArgs>("LayerTree.layerTreeDidChange", value);
			}
		}

		// Token: 0x060012CE RID: 4814 RVA: 0x00014414 File Offset: 0x00012614
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.LayerTree.CompositingReasonsResponse> CompositingReasonsAsync(string layerId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("layerId", layerId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.LayerTree.CompositingReasonsResponse>("LayerTree.compositingReasons", dictionary);
		}

		// Token: 0x060012CF RID: 4815 RVA: 0x00014444 File Offset: 0x00012644
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> DisableAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("LayerTree.disable", parameters);
		}

		// Token: 0x060012D0 RID: 4816 RVA: 0x00014464 File Offset: 0x00012664
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> EnableAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("LayerTree.enable", parameters);
		}

		// Token: 0x060012D1 RID: 4817 RVA: 0x00014484 File Offset: 0x00012684
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.LayerTree.LoadSnapshotResponse> LoadSnapshotAsync(global::System.Collections.Generic.IList<global::CefSharp.DevTools.LayerTree.PictureTile> tiles)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("tiles", from x in tiles
			select x.ToDictionary());
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.LayerTree.LoadSnapshotResponse>("LayerTree.loadSnapshot", dictionary);
		}

		// Token: 0x060012D2 RID: 4818 RVA: 0x000144D8 File Offset: 0x000126D8
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.LayerTree.MakeSnapshotResponse> MakeSnapshotAsync(string layerId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("layerId", layerId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.LayerTree.MakeSnapshotResponse>("LayerTree.makeSnapshot", dictionary);
		}

		// Token: 0x060012D3 RID: 4819 RVA: 0x00014508 File Offset: 0x00012708
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.LayerTree.ProfileSnapshotResponse> ProfileSnapshotAsync(string snapshotId, int? minRepeatCount = null, double? minDuration = null, global::CefSharp.DevTools.DOM.Rect clipRect = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("snapshotId", snapshotId);
			if (minRepeatCount != null)
			{
				dictionary.Add("minRepeatCount", minRepeatCount.Value);
			}
			if (minDuration != null)
			{
				dictionary.Add("minDuration", minDuration.Value);
			}
			if (clipRect != null)
			{
				dictionary.Add("clipRect", clipRect.ToDictionary());
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.LayerTree.ProfileSnapshotResponse>("LayerTree.profileSnapshot", dictionary);
		}

		// Token: 0x060012D4 RID: 4820 RVA: 0x00014590 File Offset: 0x00012790
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> ReleaseSnapshotAsync(string snapshotId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("snapshotId", snapshotId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("LayerTree.releaseSnapshot", dictionary);
		}

		// Token: 0x060012D5 RID: 4821 RVA: 0x000145C0 File Offset: 0x000127C0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.LayerTree.ReplaySnapshotResponse> ReplaySnapshotAsync(string snapshotId, int? fromStep = null, int? toStep = null, double? scale = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("snapshotId", snapshotId);
			if (fromStep != null)
			{
				dictionary.Add("fromStep", fromStep.Value);
			}
			if (toStep != null)
			{
				dictionary.Add("toStep", toStep.Value);
			}
			if (scale != null)
			{
				dictionary.Add("scale", scale.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.LayerTree.ReplaySnapshotResponse>("LayerTree.replaySnapshot", dictionary);
		}

		// Token: 0x060012D6 RID: 4822 RVA: 0x00014650 File Offset: 0x00012850
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.LayerTree.SnapshotCommandLogResponse> SnapshotCommandLogAsync(string snapshotId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("snapshotId", snapshotId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.LayerTree.SnapshotCommandLogResponse>("LayerTree.snapshotCommandLog", dictionary);
		}

		// Token: 0x04000A18 RID: 2584
		private global::CefSharp.DevTools.IDevToolsClient _client;
	}
}
