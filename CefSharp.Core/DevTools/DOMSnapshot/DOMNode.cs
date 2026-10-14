using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using CefSharp.DevTools.DOM;
using CefSharp.DevTools.DOMDebugger;

namespace CefSharp.DevTools.DOMSnapshot
{
	// Token: 0x0200029E RID: 670
	[global::System.Runtime.Serialization.DataContract]
	public class DOMNode : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x0600143A RID: 5178 RVA: 0x000169F5 File Offset: 0x00014BF5
		// (set) Token: 0x0600143B RID: 5179 RVA: 0x000169FD File Offset: 0x00014BFD
		[global::System.Runtime.Serialization.DataMember(Name = "nodeType", IsRequired = true)]
		public int NodeType { get; set; }

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x0600143C RID: 5180 RVA: 0x00016A06 File Offset: 0x00014C06
		// (set) Token: 0x0600143D RID: 5181 RVA: 0x00016A0E File Offset: 0x00014C0E
		[global::System.Runtime.Serialization.DataMember(Name = "nodeName", IsRequired = true)]
		public string NodeName { get; set; }

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x0600143E RID: 5182 RVA: 0x00016A17 File Offset: 0x00014C17
		// (set) Token: 0x0600143F RID: 5183 RVA: 0x00016A1F File Offset: 0x00014C1F
		[global::System.Runtime.Serialization.DataMember(Name = "nodeValue", IsRequired = true)]
		public string NodeValue { get; set; }

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x06001440 RID: 5184 RVA: 0x00016A28 File Offset: 0x00014C28
		// (set) Token: 0x06001441 RID: 5185 RVA: 0x00016A30 File Offset: 0x00014C30
		[global::System.Runtime.Serialization.DataMember(Name = "textValue", IsRequired = false)]
		public string TextValue { get; set; }

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x06001442 RID: 5186 RVA: 0x00016A39 File Offset: 0x00014C39
		// (set) Token: 0x06001443 RID: 5187 RVA: 0x00016A41 File Offset: 0x00014C41
		[global::System.Runtime.Serialization.DataMember(Name = "inputValue", IsRequired = false)]
		public string InputValue { get; set; }

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x06001444 RID: 5188 RVA: 0x00016A4A File Offset: 0x00014C4A
		// (set) Token: 0x06001445 RID: 5189 RVA: 0x00016A52 File Offset: 0x00014C52
		[global::System.Runtime.Serialization.DataMember(Name = "inputChecked", IsRequired = false)]
		public bool? InputChecked { get; set; }

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x06001446 RID: 5190 RVA: 0x00016A5B File Offset: 0x00014C5B
		// (set) Token: 0x06001447 RID: 5191 RVA: 0x00016A63 File Offset: 0x00014C63
		[global::System.Runtime.Serialization.DataMember(Name = "optionSelected", IsRequired = false)]
		public bool? OptionSelected { get; set; }

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x06001448 RID: 5192 RVA: 0x00016A6C File Offset: 0x00014C6C
		// (set) Token: 0x06001449 RID: 5193 RVA: 0x00016A74 File Offset: 0x00014C74
		[global::System.Runtime.Serialization.DataMember(Name = "backendNodeId", IsRequired = true)]
		public int BackendNodeId { get; set; }

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x0600144A RID: 5194 RVA: 0x00016A7D File Offset: 0x00014C7D
		// (set) Token: 0x0600144B RID: 5195 RVA: 0x00016A85 File Offset: 0x00014C85
		[global::System.Runtime.Serialization.DataMember(Name = "childNodeIndexes", IsRequired = false)]
		public int[] ChildNodeIndexes { get; set; }

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x0600144C RID: 5196 RVA: 0x00016A8E File Offset: 0x00014C8E
		// (set) Token: 0x0600144D RID: 5197 RVA: 0x00016A96 File Offset: 0x00014C96
		[global::System.Runtime.Serialization.DataMember(Name = "attributes", IsRequired = false)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.DOMSnapshot.NameValue> Attributes { get; set; }

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x0600144E RID: 5198 RVA: 0x00016A9F File Offset: 0x00014C9F
		// (set) Token: 0x0600144F RID: 5199 RVA: 0x00016AA7 File Offset: 0x00014CA7
		[global::System.Runtime.Serialization.DataMember(Name = "pseudoElementIndexes", IsRequired = false)]
		public int[] PseudoElementIndexes { get; set; }

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x06001450 RID: 5200 RVA: 0x00016AB0 File Offset: 0x00014CB0
		// (set) Token: 0x06001451 RID: 5201 RVA: 0x00016AB8 File Offset: 0x00014CB8
		[global::System.Runtime.Serialization.DataMember(Name = "layoutNodeIndex", IsRequired = false)]
		public int? LayoutNodeIndex { get; set; }

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x06001452 RID: 5202 RVA: 0x00016AC1 File Offset: 0x00014CC1
		// (set) Token: 0x06001453 RID: 5203 RVA: 0x00016AC9 File Offset: 0x00014CC9
		[global::System.Runtime.Serialization.DataMember(Name = "documentURL", IsRequired = false)]
		public string DocumentURL { get; set; }

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x06001454 RID: 5204 RVA: 0x00016AD2 File Offset: 0x00014CD2
		// (set) Token: 0x06001455 RID: 5205 RVA: 0x00016ADA File Offset: 0x00014CDA
		[global::System.Runtime.Serialization.DataMember(Name = "baseURL", IsRequired = false)]
		public string BaseURL { get; set; }

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x06001456 RID: 5206 RVA: 0x00016AE3 File Offset: 0x00014CE3
		// (set) Token: 0x06001457 RID: 5207 RVA: 0x00016AEB File Offset: 0x00014CEB
		[global::System.Runtime.Serialization.DataMember(Name = "contentLanguage", IsRequired = false)]
		public string ContentLanguage { get; set; }

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x06001458 RID: 5208 RVA: 0x00016AF4 File Offset: 0x00014CF4
		// (set) Token: 0x06001459 RID: 5209 RVA: 0x00016AFC File Offset: 0x00014CFC
		[global::System.Runtime.Serialization.DataMember(Name = "documentEncoding", IsRequired = false)]
		public string DocumentEncoding { get; set; }

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x0600145A RID: 5210 RVA: 0x00016B05 File Offset: 0x00014D05
		// (set) Token: 0x0600145B RID: 5211 RVA: 0x00016B0D File Offset: 0x00014D0D
		[global::System.Runtime.Serialization.DataMember(Name = "publicId", IsRequired = false)]
		public string PublicId { get; set; }

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x0600145C RID: 5212 RVA: 0x00016B16 File Offset: 0x00014D16
		// (set) Token: 0x0600145D RID: 5213 RVA: 0x00016B1E File Offset: 0x00014D1E
		[global::System.Runtime.Serialization.DataMember(Name = "systemId", IsRequired = false)]
		public string SystemId { get; set; }

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x0600145E RID: 5214 RVA: 0x00016B27 File Offset: 0x00014D27
		// (set) Token: 0x0600145F RID: 5215 RVA: 0x00016B2F File Offset: 0x00014D2F
		[global::System.Runtime.Serialization.DataMember(Name = "frameId", IsRequired = false)]
		public string FrameId { get; set; }

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x06001460 RID: 5216 RVA: 0x00016B38 File Offset: 0x00014D38
		// (set) Token: 0x06001461 RID: 5217 RVA: 0x00016B40 File Offset: 0x00014D40
		[global::System.Runtime.Serialization.DataMember(Name = "contentDocumentIndex", IsRequired = false)]
		public int? ContentDocumentIndex { get; set; }

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x06001462 RID: 5218 RVA: 0x00016B49 File Offset: 0x00014D49
		// (set) Token: 0x06001463 RID: 5219 RVA: 0x00016B65 File Offset: 0x00014D65
		public global::CefSharp.DevTools.DOM.PseudoType? PseudoType
		{
			get
			{
				return (global::CefSharp.DevTools.DOM.PseudoType?)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.DOM.PseudoType?), this.pseudoType);
			}
			set
			{
				this.pseudoType = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x06001464 RID: 5220 RVA: 0x00016B78 File Offset: 0x00014D78
		// (set) Token: 0x06001465 RID: 5221 RVA: 0x00016B80 File Offset: 0x00014D80
		[global::System.Runtime.Serialization.DataMember(Name = "pseudoType", IsRequired = false)]
		internal string pseudoType { get; set; }

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x06001466 RID: 5222 RVA: 0x00016B89 File Offset: 0x00014D89
		// (set) Token: 0x06001467 RID: 5223 RVA: 0x00016BA5 File Offset: 0x00014DA5
		public global::CefSharp.DevTools.DOM.ShadowRootType? ShadowRootType
		{
			get
			{
				return (global::CefSharp.DevTools.DOM.ShadowRootType?)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.DOM.ShadowRootType?), this.shadowRootType);
			}
			set
			{
				this.shadowRootType = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x06001468 RID: 5224 RVA: 0x00016BB8 File Offset: 0x00014DB8
		// (set) Token: 0x06001469 RID: 5225 RVA: 0x00016BC0 File Offset: 0x00014DC0
		[global::System.Runtime.Serialization.DataMember(Name = "shadowRootType", IsRequired = false)]
		internal string shadowRootType { get; set; }

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x0600146A RID: 5226 RVA: 0x00016BC9 File Offset: 0x00014DC9
		// (set) Token: 0x0600146B RID: 5227 RVA: 0x00016BD1 File Offset: 0x00014DD1
		[global::System.Runtime.Serialization.DataMember(Name = "isClickable", IsRequired = false)]
		public bool? IsClickable { get; set; }

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x0600146C RID: 5228 RVA: 0x00016BDA File Offset: 0x00014DDA
		// (set) Token: 0x0600146D RID: 5229 RVA: 0x00016BE2 File Offset: 0x00014DE2
		[global::System.Runtime.Serialization.DataMember(Name = "eventListeners", IsRequired = false)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.DOMDebugger.EventListener> EventListeners { get; set; }

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x0600146E RID: 5230 RVA: 0x00016BEB File Offset: 0x00014DEB
		// (set) Token: 0x0600146F RID: 5231 RVA: 0x00016BF3 File Offset: 0x00014DF3
		[global::System.Runtime.Serialization.DataMember(Name = "currentSourceURL", IsRequired = false)]
		public string CurrentSourceURL { get; set; }

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x06001470 RID: 5232 RVA: 0x00016BFC File Offset: 0x00014DFC
		// (set) Token: 0x06001471 RID: 5233 RVA: 0x00016C04 File Offset: 0x00014E04
		[global::System.Runtime.Serialization.DataMember(Name = "originURL", IsRequired = false)]
		public string OriginURL { get; set; }

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x06001472 RID: 5234 RVA: 0x00016C0D File Offset: 0x00014E0D
		// (set) Token: 0x06001473 RID: 5235 RVA: 0x00016C15 File Offset: 0x00014E15
		[global::System.Runtime.Serialization.DataMember(Name = "scrollOffsetX", IsRequired = false)]
		public double? ScrollOffsetX { get; set; }

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x06001474 RID: 5236 RVA: 0x00016C1E File Offset: 0x00014E1E
		// (set) Token: 0x06001475 RID: 5237 RVA: 0x00016C26 File Offset: 0x00014E26
		[global::System.Runtime.Serialization.DataMember(Name = "scrollOffsetY", IsRequired = false)]
		public double? ScrollOffsetY { get; set; }
	}
}
