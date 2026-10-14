using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOMSnapshot
{
	// Token: 0x020002A7 RID: 679
	[global::System.Runtime.Serialization.DataContract]
	public class NodeTreeSnapshot : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x060014C1 RID: 5313 RVA: 0x00016EA8 File Offset: 0x000150A8
		// (set) Token: 0x060014C2 RID: 5314 RVA: 0x00016EB0 File Offset: 0x000150B0
		[global::System.Runtime.Serialization.DataMember(Name = "parentIndex", IsRequired = false)]
		public int[] ParentIndex { get; set; }

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x060014C3 RID: 5315 RVA: 0x00016EB9 File Offset: 0x000150B9
		// (set) Token: 0x060014C4 RID: 5316 RVA: 0x00016EC1 File Offset: 0x000150C1
		[global::System.Runtime.Serialization.DataMember(Name = "nodeType", IsRequired = false)]
		public int[] NodeType { get; set; }

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x060014C5 RID: 5317 RVA: 0x00016ECA File Offset: 0x000150CA
		// (set) Token: 0x060014C6 RID: 5318 RVA: 0x00016ED2 File Offset: 0x000150D2
		[global::System.Runtime.Serialization.DataMember(Name = "shadowRootType", IsRequired = false)]
		public global::CefSharp.DevTools.DOMSnapshot.RareStringData ShadowRootType { get; set; }

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x060014C7 RID: 5319 RVA: 0x00016EDB File Offset: 0x000150DB
		// (set) Token: 0x060014C8 RID: 5320 RVA: 0x00016EE3 File Offset: 0x000150E3
		[global::System.Runtime.Serialization.DataMember(Name = "nodeName", IsRequired = false)]
		public int[] NodeName { get; set; }

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x060014C9 RID: 5321 RVA: 0x00016EEC File Offset: 0x000150EC
		// (set) Token: 0x060014CA RID: 5322 RVA: 0x00016EF4 File Offset: 0x000150F4
		[global::System.Runtime.Serialization.DataMember(Name = "nodeValue", IsRequired = false)]
		public int[] NodeValue { get; set; }

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x060014CB RID: 5323 RVA: 0x00016EFD File Offset: 0x000150FD
		// (set) Token: 0x060014CC RID: 5324 RVA: 0x00016F05 File Offset: 0x00015105
		[global::System.Runtime.Serialization.DataMember(Name = "backendNodeId", IsRequired = false)]
		public int[] BackendNodeId { get; set; }

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x060014CD RID: 5325 RVA: 0x00016F0E File Offset: 0x0001510E
		// (set) Token: 0x060014CE RID: 5326 RVA: 0x00016F16 File Offset: 0x00015116
		[global::System.Runtime.Serialization.DataMember(Name = "attributes", IsRequired = false)]
		public int[] Attributes { get; set; }

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x060014CF RID: 5327 RVA: 0x00016F1F File Offset: 0x0001511F
		// (set) Token: 0x060014D0 RID: 5328 RVA: 0x00016F27 File Offset: 0x00015127
		[global::System.Runtime.Serialization.DataMember(Name = "textValue", IsRequired = false)]
		public global::CefSharp.DevTools.DOMSnapshot.RareStringData TextValue { get; set; }

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x060014D1 RID: 5329 RVA: 0x00016F30 File Offset: 0x00015130
		// (set) Token: 0x060014D2 RID: 5330 RVA: 0x00016F38 File Offset: 0x00015138
		[global::System.Runtime.Serialization.DataMember(Name = "inputValue", IsRequired = false)]
		public global::CefSharp.DevTools.DOMSnapshot.RareStringData InputValue { get; set; }

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x060014D3 RID: 5331 RVA: 0x00016F41 File Offset: 0x00015141
		// (set) Token: 0x060014D4 RID: 5332 RVA: 0x00016F49 File Offset: 0x00015149
		[global::System.Runtime.Serialization.DataMember(Name = "inputChecked", IsRequired = false)]
		public global::CefSharp.DevTools.DOMSnapshot.RareBooleanData InputChecked { get; set; }

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x060014D5 RID: 5333 RVA: 0x00016F52 File Offset: 0x00015152
		// (set) Token: 0x060014D6 RID: 5334 RVA: 0x00016F5A File Offset: 0x0001515A
		[global::System.Runtime.Serialization.DataMember(Name = "optionSelected", IsRequired = false)]
		public global::CefSharp.DevTools.DOMSnapshot.RareBooleanData OptionSelected { get; set; }

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x060014D7 RID: 5335 RVA: 0x00016F63 File Offset: 0x00015163
		// (set) Token: 0x060014D8 RID: 5336 RVA: 0x00016F6B File Offset: 0x0001516B
		[global::System.Runtime.Serialization.DataMember(Name = "contentDocumentIndex", IsRequired = false)]
		public global::CefSharp.DevTools.DOMSnapshot.RareIntegerData ContentDocumentIndex { get; set; }

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x060014D9 RID: 5337 RVA: 0x00016F74 File Offset: 0x00015174
		// (set) Token: 0x060014DA RID: 5338 RVA: 0x00016F7C File Offset: 0x0001517C
		[global::System.Runtime.Serialization.DataMember(Name = "pseudoType", IsRequired = false)]
		public global::CefSharp.DevTools.DOMSnapshot.RareStringData PseudoType { get; set; }

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x060014DB RID: 5339 RVA: 0x00016F85 File Offset: 0x00015185
		// (set) Token: 0x060014DC RID: 5340 RVA: 0x00016F8D File Offset: 0x0001518D
		[global::System.Runtime.Serialization.DataMember(Name = "pseudoIdentifier", IsRequired = false)]
		public global::CefSharp.DevTools.DOMSnapshot.RareStringData PseudoIdentifier { get; set; }

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x060014DD RID: 5341 RVA: 0x00016F96 File Offset: 0x00015196
		// (set) Token: 0x060014DE RID: 5342 RVA: 0x00016F9E File Offset: 0x0001519E
		[global::System.Runtime.Serialization.DataMember(Name = "isClickable", IsRequired = false)]
		public global::CefSharp.DevTools.DOMSnapshot.RareBooleanData IsClickable { get; set; }

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x060014DF RID: 5343 RVA: 0x00016FA7 File Offset: 0x000151A7
		// (set) Token: 0x060014E0 RID: 5344 RVA: 0x00016FAF File Offset: 0x000151AF
		[global::System.Runtime.Serialization.DataMember(Name = "currentSourceURL", IsRequired = false)]
		public global::CefSharp.DevTools.DOMSnapshot.RareStringData CurrentSourceURL { get; set; }

		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x060014E1 RID: 5345 RVA: 0x00016FB8 File Offset: 0x000151B8
		// (set) Token: 0x060014E2 RID: 5346 RVA: 0x00016FC0 File Offset: 0x000151C0
		[global::System.Runtime.Serialization.DataMember(Name = "originURL", IsRequired = false)]
		public global::CefSharp.DevTools.DOMSnapshot.RareStringData OriginURL { get; set; }
	}
}
