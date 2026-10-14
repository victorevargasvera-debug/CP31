using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CefSharp.DevTools.DOM
{
	// Token: 0x020002E6 RID: 742
	public class DOMClient : global::CefSharp.DevTools.DevToolsDomainBase
	{
		// Token: 0x06001667 RID: 5735 RVA: 0x00017FF5 File Offset: 0x000161F5
		public DOMClient(global::CefSharp.DevTools.IDevToolsClient client)
		{
			this._client = client;
		}

		// Token: 0x14000098 RID: 152
		// (add) Token: 0x06001668 RID: 5736 RVA: 0x00018004 File Offset: 0x00016204
		// (remove) Token: 0x06001669 RID: 5737 RVA: 0x00018017 File Offset: 0x00016217
		public event global::System.EventHandler<global::CefSharp.DevTools.DOM.AttributeModifiedEventArgs> AttributeModified
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.DOM.AttributeModifiedEventArgs>("DOM.attributeModified", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.DOM.AttributeModifiedEventArgs>("DOM.attributeModified", value);
			}
		}

		// Token: 0x14000099 RID: 153
		// (add) Token: 0x0600166A RID: 5738 RVA: 0x0001802B File Offset: 0x0001622B
		// (remove) Token: 0x0600166B RID: 5739 RVA: 0x0001803E File Offset: 0x0001623E
		public event global::System.EventHandler<global::CefSharp.DevTools.DOM.AttributeRemovedEventArgs> AttributeRemoved
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.DOM.AttributeRemovedEventArgs>("DOM.attributeRemoved", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.DOM.AttributeRemovedEventArgs>("DOM.attributeRemoved", value);
			}
		}

		// Token: 0x1400009A RID: 154
		// (add) Token: 0x0600166C RID: 5740 RVA: 0x00018052 File Offset: 0x00016252
		// (remove) Token: 0x0600166D RID: 5741 RVA: 0x00018065 File Offset: 0x00016265
		public event global::System.EventHandler<global::CefSharp.DevTools.DOM.CharacterDataModifiedEventArgs> CharacterDataModified
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.DOM.CharacterDataModifiedEventArgs>("DOM.characterDataModified", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.DOM.CharacterDataModifiedEventArgs>("DOM.characterDataModified", value);
			}
		}

		// Token: 0x1400009B RID: 155
		// (add) Token: 0x0600166E RID: 5742 RVA: 0x00018079 File Offset: 0x00016279
		// (remove) Token: 0x0600166F RID: 5743 RVA: 0x0001808C File Offset: 0x0001628C
		public event global::System.EventHandler<global::CefSharp.DevTools.DOM.ChildNodeCountUpdatedEventArgs> ChildNodeCountUpdated
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.DOM.ChildNodeCountUpdatedEventArgs>("DOM.childNodeCountUpdated", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.DOM.ChildNodeCountUpdatedEventArgs>("DOM.childNodeCountUpdated", value);
			}
		}

		// Token: 0x1400009C RID: 156
		// (add) Token: 0x06001670 RID: 5744 RVA: 0x000180A0 File Offset: 0x000162A0
		// (remove) Token: 0x06001671 RID: 5745 RVA: 0x000180B3 File Offset: 0x000162B3
		public event global::System.EventHandler<global::CefSharp.DevTools.DOM.ChildNodeInsertedEventArgs> ChildNodeInserted
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.DOM.ChildNodeInsertedEventArgs>("DOM.childNodeInserted", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.DOM.ChildNodeInsertedEventArgs>("DOM.childNodeInserted", value);
			}
		}

		// Token: 0x1400009D RID: 157
		// (add) Token: 0x06001672 RID: 5746 RVA: 0x000180C7 File Offset: 0x000162C7
		// (remove) Token: 0x06001673 RID: 5747 RVA: 0x000180DA File Offset: 0x000162DA
		public event global::System.EventHandler<global::CefSharp.DevTools.DOM.ChildNodeRemovedEventArgs> ChildNodeRemoved
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.DOM.ChildNodeRemovedEventArgs>("DOM.childNodeRemoved", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.DOM.ChildNodeRemovedEventArgs>("DOM.childNodeRemoved", value);
			}
		}

		// Token: 0x1400009E RID: 158
		// (add) Token: 0x06001674 RID: 5748 RVA: 0x000180EE File Offset: 0x000162EE
		// (remove) Token: 0x06001675 RID: 5749 RVA: 0x00018101 File Offset: 0x00016301
		public event global::System.EventHandler<global::CefSharp.DevTools.DOM.DistributedNodesUpdatedEventArgs> DistributedNodesUpdated
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.DOM.DistributedNodesUpdatedEventArgs>("DOM.distributedNodesUpdated", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.DOM.DistributedNodesUpdatedEventArgs>("DOM.distributedNodesUpdated", value);
			}
		}

		// Token: 0x1400009F RID: 159
		// (add) Token: 0x06001676 RID: 5750 RVA: 0x00018115 File Offset: 0x00016315
		// (remove) Token: 0x06001677 RID: 5751 RVA: 0x00018128 File Offset: 0x00016328
		public event global::System.EventHandler<global::System.EventArgs> DocumentUpdated
		{
			add
			{
				this._client.AddEventHandler<global::System.EventArgs>("DOM.documentUpdated", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::System.EventArgs>("DOM.documentUpdated", value);
			}
		}

		// Token: 0x140000A0 RID: 160
		// (add) Token: 0x06001678 RID: 5752 RVA: 0x0001813C File Offset: 0x0001633C
		// (remove) Token: 0x06001679 RID: 5753 RVA: 0x0001814F File Offset: 0x0001634F
		public event global::System.EventHandler<global::CefSharp.DevTools.DOM.InlineStyleInvalidatedEventArgs> InlineStyleInvalidated
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.DOM.InlineStyleInvalidatedEventArgs>("DOM.inlineStyleInvalidated", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.DOM.InlineStyleInvalidatedEventArgs>("DOM.inlineStyleInvalidated", value);
			}
		}

		// Token: 0x140000A1 RID: 161
		// (add) Token: 0x0600167A RID: 5754 RVA: 0x00018163 File Offset: 0x00016363
		// (remove) Token: 0x0600167B RID: 5755 RVA: 0x00018176 File Offset: 0x00016376
		public event global::System.EventHandler<global::CefSharp.DevTools.DOM.PseudoElementAddedEventArgs> PseudoElementAdded
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.DOM.PseudoElementAddedEventArgs>("DOM.pseudoElementAdded", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.DOM.PseudoElementAddedEventArgs>("DOM.pseudoElementAdded", value);
			}
		}

		// Token: 0x140000A2 RID: 162
		// (add) Token: 0x0600167C RID: 5756 RVA: 0x0001818A File Offset: 0x0001638A
		// (remove) Token: 0x0600167D RID: 5757 RVA: 0x0001819D File Offset: 0x0001639D
		public event global::System.EventHandler<global::System.EventArgs> TopLayerElementsUpdated
		{
			add
			{
				this._client.AddEventHandler<global::System.EventArgs>("DOM.topLayerElementsUpdated", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::System.EventArgs>("DOM.topLayerElementsUpdated", value);
			}
		}

		// Token: 0x140000A3 RID: 163
		// (add) Token: 0x0600167E RID: 5758 RVA: 0x000181B1 File Offset: 0x000163B1
		// (remove) Token: 0x0600167F RID: 5759 RVA: 0x000181C4 File Offset: 0x000163C4
		public event global::System.EventHandler<global::CefSharp.DevTools.DOM.PseudoElementRemovedEventArgs> PseudoElementRemoved
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.DOM.PseudoElementRemovedEventArgs>("DOM.pseudoElementRemoved", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.DOM.PseudoElementRemovedEventArgs>("DOM.pseudoElementRemoved", value);
			}
		}

		// Token: 0x140000A4 RID: 164
		// (add) Token: 0x06001680 RID: 5760 RVA: 0x000181D8 File Offset: 0x000163D8
		// (remove) Token: 0x06001681 RID: 5761 RVA: 0x000181EB File Offset: 0x000163EB
		public event global::System.EventHandler<global::CefSharp.DevTools.DOM.SetChildNodesEventArgs> SetChildNodes
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.DOM.SetChildNodesEventArgs>("DOM.setChildNodes", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.DOM.SetChildNodesEventArgs>("DOM.setChildNodes", value);
			}
		}

		// Token: 0x140000A5 RID: 165
		// (add) Token: 0x06001682 RID: 5762 RVA: 0x000181FF File Offset: 0x000163FF
		// (remove) Token: 0x06001683 RID: 5763 RVA: 0x00018212 File Offset: 0x00016412
		public event global::System.EventHandler<global::CefSharp.DevTools.DOM.ShadowRootPoppedEventArgs> ShadowRootPopped
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.DOM.ShadowRootPoppedEventArgs>("DOM.shadowRootPopped", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.DOM.ShadowRootPoppedEventArgs>("DOM.shadowRootPopped", value);
			}
		}

		// Token: 0x140000A6 RID: 166
		// (add) Token: 0x06001684 RID: 5764 RVA: 0x00018226 File Offset: 0x00016426
		// (remove) Token: 0x06001685 RID: 5765 RVA: 0x00018239 File Offset: 0x00016439
		public event global::System.EventHandler<global::CefSharp.DevTools.DOM.ShadowRootPushedEventArgs> ShadowRootPushed
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.DOM.ShadowRootPushedEventArgs>("DOM.shadowRootPushed", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.DOM.ShadowRootPushedEventArgs>("DOM.shadowRootPushed", value);
			}
		}

		// Token: 0x06001686 RID: 5766 RVA: 0x00018250 File Offset: 0x00016450
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DOM.CollectClassNamesFromSubtreeResponse> CollectClassNamesFromSubtreeAsync(int nodeId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("nodeId", nodeId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DOM.CollectClassNamesFromSubtreeResponse>("DOM.collectClassNamesFromSubtree", dictionary);
		}

		// Token: 0x06001687 RID: 5767 RVA: 0x00018288 File Offset: 0x00016488
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DOM.CopyToResponse> CopyToAsync(int nodeId, int targetNodeId, int? insertBeforeNodeId = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("nodeId", nodeId);
			dictionary.Add("targetNodeId", targetNodeId);
			if (insertBeforeNodeId != null)
			{
				dictionary.Add("insertBeforeNodeId", insertBeforeNodeId.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DOM.CopyToResponse>("DOM.copyTo", dictionary);
		}

		// Token: 0x06001688 RID: 5768 RVA: 0x000182F0 File Offset: 0x000164F0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DOM.DescribeNodeResponse> DescribeNodeAsync(int? nodeId = null, int? backendNodeId = null, string objectId = null, int? depth = null, bool? pierce = null)
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
			if (depth != null)
			{
				dictionary.Add("depth", depth.Value);
			}
			if (pierce != null)
			{
				dictionary.Add("pierce", pierce.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DOM.DescribeNodeResponse>("DOM.describeNode", dictionary);
		}

		// Token: 0x06001689 RID: 5769 RVA: 0x000183A8 File Offset: 0x000165A8
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> ScrollIntoViewIfNeededAsync(int? nodeId = null, int? backendNodeId = null, string objectId = null, global::CefSharp.DevTools.DOM.Rect rect = null)
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
			if (rect != null)
			{
				dictionary.Add("rect", rect.ToDictionary());
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("DOM.scrollIntoViewIfNeeded", dictionary);
		}

		// Token: 0x0600168A RID: 5770 RVA: 0x00018438 File Offset: 0x00016638
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> DisableAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("DOM.disable", parameters);
		}

		// Token: 0x0600168B RID: 5771 RVA: 0x00018458 File Offset: 0x00016658
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> DiscardSearchResultsAsync(string searchId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("searchId", searchId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("DOM.discardSearchResults", dictionary);
		}

		// Token: 0x0600168C RID: 5772 RVA: 0x00018488 File Offset: 0x00016688
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> EnableAsync(global::CefSharp.DevTools.DOM.EnableIncludeWhitespace? includeWhitespace = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (includeWhitespace != null)
			{
				dictionary.Add("includeWhitespace", base.EnumToString(includeWhitespace));
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("DOM.enable", dictionary);
		}

		// Token: 0x0600168D RID: 5773 RVA: 0x000184CC File Offset: 0x000166CC
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> FocusAsync(int? nodeId = null, int? backendNodeId = null, string objectId = null)
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
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("DOM.focus", dictionary);
		}

		// Token: 0x0600168E RID: 5774 RVA: 0x00018544 File Offset: 0x00016744
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DOM.GetAttributesResponse> GetAttributesAsync(int nodeId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("nodeId", nodeId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DOM.GetAttributesResponse>("DOM.getAttributes", dictionary);
		}

		// Token: 0x0600168F RID: 5775 RVA: 0x0001857C File Offset: 0x0001677C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DOM.GetBoxModelResponse> GetBoxModelAsync(int? nodeId = null, int? backendNodeId = null, string objectId = null)
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
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DOM.GetBoxModelResponse>("DOM.getBoxModel", dictionary);
		}

		// Token: 0x06001690 RID: 5776 RVA: 0x000185F4 File Offset: 0x000167F4
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DOM.GetContentQuadsResponse> GetContentQuadsAsync(int? nodeId = null, int? backendNodeId = null, string objectId = null)
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
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DOM.GetContentQuadsResponse>("DOM.getContentQuads", dictionary);
		}

		// Token: 0x06001691 RID: 5777 RVA: 0x0001866C File Offset: 0x0001686C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DOM.GetDocumentResponse> GetDocumentAsync(int? depth = null, bool? pierce = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (depth != null)
			{
				dictionary.Add("depth", depth.Value);
			}
			if (pierce != null)
			{
				dictionary.Add("pierce", pierce.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DOM.GetDocumentResponse>("DOM.getDocument", dictionary);
		}

		// Token: 0x06001692 RID: 5778 RVA: 0x000186D0 File Offset: 0x000168D0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DOM.GetNodesForSubtreeByStyleResponse> GetNodesForSubtreeByStyleAsync(int nodeId, global::System.Collections.Generic.IList<global::CefSharp.DevTools.DOM.CSSComputedStyleProperty> computedStyles, bool? pierce = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("nodeId", nodeId);
			dictionary.Add("computedStyles", from x in computedStyles
			select x.ToDictionary());
			if (pierce != null)
			{
				dictionary.Add("pierce", pierce.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DOM.GetNodesForSubtreeByStyleResponse>("DOM.getNodesForSubtreeByStyle", dictionary);
		}

		// Token: 0x06001693 RID: 5779 RVA: 0x00018758 File Offset: 0x00016958
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DOM.GetNodeForLocationResponse> GetNodeForLocationAsync(int x, int y, bool? includeUserAgentShadowDOM = null, bool? ignorePointerEventsNone = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("x", x);
			dictionary.Add("y", y);
			if (includeUserAgentShadowDOM != null)
			{
				dictionary.Add("includeUserAgentShadowDOM", includeUserAgentShadowDOM.Value);
			}
			if (ignorePointerEventsNone != null)
			{
				dictionary.Add("ignorePointerEventsNone", ignorePointerEventsNone.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DOM.GetNodeForLocationResponse>("DOM.getNodeForLocation", dictionary);
		}

		// Token: 0x06001694 RID: 5780 RVA: 0x000187E0 File Offset: 0x000169E0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DOM.GetOuterHTMLResponse> GetOuterHTMLAsync(int? nodeId = null, int? backendNodeId = null, string objectId = null)
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
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DOM.GetOuterHTMLResponse>("DOM.getOuterHTML", dictionary);
		}

		// Token: 0x06001695 RID: 5781 RVA: 0x00018858 File Offset: 0x00016A58
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DOM.GetRelayoutBoundaryResponse> GetRelayoutBoundaryAsync(int nodeId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("nodeId", nodeId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DOM.GetRelayoutBoundaryResponse>("DOM.getRelayoutBoundary", dictionary);
		}

		// Token: 0x06001696 RID: 5782 RVA: 0x00018890 File Offset: 0x00016A90
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DOM.GetSearchResultsResponse> GetSearchResultsAsync(string searchId, int fromIndex, int toIndex)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("searchId", searchId);
			dictionary.Add("fromIndex", fromIndex);
			dictionary.Add("toIndex", toIndex);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DOM.GetSearchResultsResponse>("DOM.getSearchResults", dictionary);
		}

		// Token: 0x06001697 RID: 5783 RVA: 0x000188E4 File Offset: 0x00016AE4
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> HideHighlightAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("DOM.hideHighlight", parameters);
		}

		// Token: 0x06001698 RID: 5784 RVA: 0x00018904 File Offset: 0x00016B04
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> HighlightNodeAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("DOM.highlightNode", parameters);
		}

		// Token: 0x06001699 RID: 5785 RVA: 0x00018924 File Offset: 0x00016B24
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> HighlightRectAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("DOM.highlightRect", parameters);
		}

		// Token: 0x0600169A RID: 5786 RVA: 0x00018944 File Offset: 0x00016B44
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> MarkUndoableStateAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("DOM.markUndoableState", parameters);
		}

		// Token: 0x0600169B RID: 5787 RVA: 0x00018964 File Offset: 0x00016B64
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DOM.MoveToResponse> MoveToAsync(int nodeId, int targetNodeId, int? insertBeforeNodeId = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("nodeId", nodeId);
			dictionary.Add("targetNodeId", targetNodeId);
			if (insertBeforeNodeId != null)
			{
				dictionary.Add("insertBeforeNodeId", insertBeforeNodeId.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DOM.MoveToResponse>("DOM.moveTo", dictionary);
		}

		// Token: 0x0600169C RID: 5788 RVA: 0x000189CC File Offset: 0x00016BCC
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DOM.PerformSearchResponse> PerformSearchAsync(string query, bool? includeUserAgentShadowDOM = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("query", query);
			if (includeUserAgentShadowDOM != null)
			{
				dictionary.Add("includeUserAgentShadowDOM", includeUserAgentShadowDOM.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DOM.PerformSearchResponse>("DOM.performSearch", dictionary);
		}

		// Token: 0x0600169D RID: 5789 RVA: 0x00018A1C File Offset: 0x00016C1C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DOM.PushNodeByPathToFrontendResponse> PushNodeByPathToFrontendAsync(string path)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("path", path);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DOM.PushNodeByPathToFrontendResponse>("DOM.pushNodeByPathToFrontend", dictionary);
		}

		// Token: 0x0600169E RID: 5790 RVA: 0x00018A4C File Offset: 0x00016C4C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DOM.PushNodesByBackendIdsToFrontendResponse> PushNodesByBackendIdsToFrontendAsync(int[] backendNodeIds)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("backendNodeIds", backendNodeIds);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DOM.PushNodesByBackendIdsToFrontendResponse>("DOM.pushNodesByBackendIdsToFrontend", dictionary);
		}

		// Token: 0x0600169F RID: 5791 RVA: 0x00018A7C File Offset: 0x00016C7C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DOM.QuerySelectorResponse> QuerySelectorAsync(int nodeId, string selector)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("nodeId", nodeId);
			dictionary.Add("selector", selector);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DOM.QuerySelectorResponse>("DOM.querySelector", dictionary);
		}

		// Token: 0x060016A0 RID: 5792 RVA: 0x00018AC0 File Offset: 0x00016CC0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DOM.QuerySelectorAllResponse> QuerySelectorAllAsync(int nodeId, string selector)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("nodeId", nodeId);
			dictionary.Add("selector", selector);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DOM.QuerySelectorAllResponse>("DOM.querySelectorAll", dictionary);
		}

		// Token: 0x060016A1 RID: 5793 RVA: 0x00018B04 File Offset: 0x00016D04
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DOM.GetTopLayerElementsResponse> GetTopLayerElementsAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DOM.GetTopLayerElementsResponse>("DOM.getTopLayerElements", parameters);
		}

		// Token: 0x060016A2 RID: 5794 RVA: 0x00018B24 File Offset: 0x00016D24
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> RedoAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("DOM.redo", parameters);
		}

		// Token: 0x060016A3 RID: 5795 RVA: 0x00018B44 File Offset: 0x00016D44
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> RemoveAttributeAsync(int nodeId, string name)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("nodeId", nodeId);
			dictionary.Add("name", name);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("DOM.removeAttribute", dictionary);
		}

		// Token: 0x060016A4 RID: 5796 RVA: 0x00018B88 File Offset: 0x00016D88
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> RemoveNodeAsync(int nodeId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("nodeId", nodeId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("DOM.removeNode", dictionary);
		}

		// Token: 0x060016A5 RID: 5797 RVA: 0x00018BC0 File Offset: 0x00016DC0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> RequestChildNodesAsync(int nodeId, int? depth = null, bool? pierce = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("nodeId", nodeId);
			if (depth != null)
			{
				dictionary.Add("depth", depth.Value);
			}
			if (pierce != null)
			{
				dictionary.Add("pierce", pierce.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("DOM.requestChildNodes", dictionary);
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x00018C38 File Offset: 0x00016E38
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DOM.RequestNodeResponse> RequestNodeAsync(string objectId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("objectId", objectId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DOM.RequestNodeResponse>("DOM.requestNode", dictionary);
		}

		// Token: 0x060016A7 RID: 5799 RVA: 0x00018C68 File Offset: 0x00016E68
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DOM.ResolveNodeResponse> ResolveNodeAsync(int? nodeId = null, int? backendNodeId = null, string objectGroup = null, int? executionContextId = null)
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
			if (!string.IsNullOrEmpty(objectGroup))
			{
				dictionary.Add("objectGroup", objectGroup);
			}
			if (executionContextId != null)
			{
				dictionary.Add("executionContextId", executionContextId.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DOM.ResolveNodeResponse>("DOM.resolveNode", dictionary);
		}

		// Token: 0x060016A8 RID: 5800 RVA: 0x00018D00 File Offset: 0x00016F00
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetAttributeValueAsync(int nodeId, string name, string value)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("nodeId", nodeId);
			dictionary.Add("name", name);
			dictionary.Add("value", value);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("DOM.setAttributeValue", dictionary);
		}

		// Token: 0x060016A9 RID: 5801 RVA: 0x00018D50 File Offset: 0x00016F50
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetAttributesAsTextAsync(int nodeId, string text, string name = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("nodeId", nodeId);
			dictionary.Add("text", text);
			if (!string.IsNullOrEmpty(name))
			{
				dictionary.Add("name", name);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("DOM.setAttributesAsText", dictionary);
		}

		// Token: 0x060016AA RID: 5802 RVA: 0x00018DA8 File Offset: 0x00016FA8
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetFileInputFilesAsync(string[] files, int? nodeId = null, int? backendNodeId = null, string objectId = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("files", files);
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
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("DOM.setFileInputFiles", dictionary);
		}

		// Token: 0x060016AB RID: 5803 RVA: 0x00018E30 File Offset: 0x00017030
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetNodeStackTracesEnabledAsync(bool enable)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("enable", enable);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("DOM.setNodeStackTracesEnabled", dictionary);
		}

		// Token: 0x060016AC RID: 5804 RVA: 0x00018E68 File Offset: 0x00017068
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DOM.GetNodeStackTracesResponse> GetNodeStackTracesAsync(int nodeId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("nodeId", nodeId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DOM.GetNodeStackTracesResponse>("DOM.getNodeStackTraces", dictionary);
		}

		// Token: 0x060016AD RID: 5805 RVA: 0x00018EA0 File Offset: 0x000170A0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DOM.GetFileInfoResponse> GetFileInfoAsync(string objectId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("objectId", objectId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DOM.GetFileInfoResponse>("DOM.getFileInfo", dictionary);
		}

		// Token: 0x060016AE RID: 5806 RVA: 0x00018ED0 File Offset: 0x000170D0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetInspectedNodeAsync(int nodeId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("nodeId", nodeId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("DOM.setInspectedNode", dictionary);
		}

		// Token: 0x060016AF RID: 5807 RVA: 0x00018F08 File Offset: 0x00017108
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DOM.SetNodeNameResponse> SetNodeNameAsync(int nodeId, string name)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("nodeId", nodeId);
			dictionary.Add("name", name);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DOM.SetNodeNameResponse>("DOM.setNodeName", dictionary);
		}

		// Token: 0x060016B0 RID: 5808 RVA: 0x00018F4C File Offset: 0x0001714C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetNodeValueAsync(int nodeId, string value)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("nodeId", nodeId);
			dictionary.Add("value", value);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("DOM.setNodeValue", dictionary);
		}

		// Token: 0x060016B1 RID: 5809 RVA: 0x00018F90 File Offset: 0x00017190
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetOuterHTMLAsync(int nodeId, string outerHTML)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("nodeId", nodeId);
			dictionary.Add("outerHTML", outerHTML);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("DOM.setOuterHTML", dictionary);
		}

		// Token: 0x060016B2 RID: 5810 RVA: 0x00018FD4 File Offset: 0x000171D4
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> UndoAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("DOM.undo", parameters);
		}

		// Token: 0x060016B3 RID: 5811 RVA: 0x00018FF4 File Offset: 0x000171F4
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DOM.GetFrameOwnerResponse> GetFrameOwnerAsync(string frameId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("frameId", frameId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DOM.GetFrameOwnerResponse>("DOM.getFrameOwner", dictionary);
		}

		// Token: 0x060016B4 RID: 5812 RVA: 0x00019024 File Offset: 0x00017224
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DOM.GetContainerForNodeResponse> GetContainerForNodeAsync(int nodeId, string containerName = null, global::CefSharp.DevTools.DOM.PhysicalAxes? physicalAxes = null, global::CefSharp.DevTools.DOM.LogicalAxes? logicalAxes = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("nodeId", nodeId);
			if (!string.IsNullOrEmpty(containerName))
			{
				dictionary.Add("containerName", containerName);
			}
			if (physicalAxes != null)
			{
				dictionary.Add("physicalAxes", base.EnumToString(physicalAxes));
			}
			if (logicalAxes != null)
			{
				dictionary.Add("logicalAxes", base.EnumToString(logicalAxes));
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DOM.GetContainerForNodeResponse>("DOM.getContainerForNode", dictionary);
		}

		// Token: 0x060016B5 RID: 5813 RVA: 0x000190B0 File Offset: 0x000172B0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DOM.GetQueryingDescendantsForContainerResponse> GetQueryingDescendantsForContainerAsync(int nodeId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("nodeId", nodeId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DOM.GetQueryingDescendantsForContainerResponse>("DOM.getQueryingDescendantsForContainer", dictionary);
		}

		// Token: 0x04000BE5 RID: 3045
		private global::CefSharp.DevTools.IDevToolsClient _client;
	}
}
