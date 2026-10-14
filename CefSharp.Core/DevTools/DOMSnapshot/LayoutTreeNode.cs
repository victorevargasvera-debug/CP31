using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using CefSharp.DevTools.DOM;

namespace CefSharp.DevTools.DOMSnapshot
{
	// Token: 0x020002A0 RID: 672
	[global::System.Runtime.Serialization.DataContract]
	public class LayoutTreeNode : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x0600147E RID: 5246 RVA: 0x00016C72 File Offset: 0x00014E72
		// (set) Token: 0x0600147F RID: 5247 RVA: 0x00016C7A File Offset: 0x00014E7A
		[global::System.Runtime.Serialization.DataMember(Name = "domNodeIndex", IsRequired = true)]
		public int DomNodeIndex { get; set; }

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x06001480 RID: 5248 RVA: 0x00016C83 File Offset: 0x00014E83
		// (set) Token: 0x06001481 RID: 5249 RVA: 0x00016C8B File Offset: 0x00014E8B
		[global::System.Runtime.Serialization.DataMember(Name = "boundingBox", IsRequired = true)]
		public global::CefSharp.DevTools.DOM.Rect BoundingBox { get; set; }

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x06001482 RID: 5250 RVA: 0x00016C94 File Offset: 0x00014E94
		// (set) Token: 0x06001483 RID: 5251 RVA: 0x00016C9C File Offset: 0x00014E9C
		[global::System.Runtime.Serialization.DataMember(Name = "layoutText", IsRequired = false)]
		public string LayoutText { get; set; }

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x06001484 RID: 5252 RVA: 0x00016CA5 File Offset: 0x00014EA5
		// (set) Token: 0x06001485 RID: 5253 RVA: 0x00016CAD File Offset: 0x00014EAD
		[global::System.Runtime.Serialization.DataMember(Name = "inlineTextNodes", IsRequired = false)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.DOMSnapshot.InlineTextBox> InlineTextNodes { get; set; }

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x06001486 RID: 5254 RVA: 0x00016CB6 File Offset: 0x00014EB6
		// (set) Token: 0x06001487 RID: 5255 RVA: 0x00016CBE File Offset: 0x00014EBE
		[global::System.Runtime.Serialization.DataMember(Name = "styleIndex", IsRequired = false)]
		public int? StyleIndex { get; set; }

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x06001488 RID: 5256 RVA: 0x00016CC7 File Offset: 0x00014EC7
		// (set) Token: 0x06001489 RID: 5257 RVA: 0x00016CCF File Offset: 0x00014ECF
		[global::System.Runtime.Serialization.DataMember(Name = "paintOrder", IsRequired = false)]
		public int? PaintOrder { get; set; }

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x0600148A RID: 5258 RVA: 0x00016CD8 File Offset: 0x00014ED8
		// (set) Token: 0x0600148B RID: 5259 RVA: 0x00016CE0 File Offset: 0x00014EE0
		[global::System.Runtime.Serialization.DataMember(Name = "isStackingContext", IsRequired = false)]
		public bool? IsStackingContext { get; set; }
	}
}
