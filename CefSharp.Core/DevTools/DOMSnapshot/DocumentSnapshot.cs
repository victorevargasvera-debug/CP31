using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOMSnapshot
{
	// Token: 0x020002A6 RID: 678
	[global::System.Runtime.Serialization.DataContract]
	public class DocumentSnapshot : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x060014A2 RID: 5282 RVA: 0x00016DA1 File Offset: 0x00014FA1
		// (set) Token: 0x060014A3 RID: 5283 RVA: 0x00016DA9 File Offset: 0x00014FA9
		[global::System.Runtime.Serialization.DataMember(Name = "documentURL", IsRequired = true)]
		public int DocumentURL { get; set; }

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x060014A4 RID: 5284 RVA: 0x00016DB2 File Offset: 0x00014FB2
		// (set) Token: 0x060014A5 RID: 5285 RVA: 0x00016DBA File Offset: 0x00014FBA
		[global::System.Runtime.Serialization.DataMember(Name = "title", IsRequired = true)]
		public int Title { get; set; }

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x060014A6 RID: 5286 RVA: 0x00016DC3 File Offset: 0x00014FC3
		// (set) Token: 0x060014A7 RID: 5287 RVA: 0x00016DCB File Offset: 0x00014FCB
		[global::System.Runtime.Serialization.DataMember(Name = "baseURL", IsRequired = true)]
		public int BaseURL { get; set; }

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x060014A8 RID: 5288 RVA: 0x00016DD4 File Offset: 0x00014FD4
		// (set) Token: 0x060014A9 RID: 5289 RVA: 0x00016DDC File Offset: 0x00014FDC
		[global::System.Runtime.Serialization.DataMember(Name = "contentLanguage", IsRequired = true)]
		public int ContentLanguage { get; set; }

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x060014AA RID: 5290 RVA: 0x00016DE5 File Offset: 0x00014FE5
		// (set) Token: 0x060014AB RID: 5291 RVA: 0x00016DED File Offset: 0x00014FED
		[global::System.Runtime.Serialization.DataMember(Name = "encodingName", IsRequired = true)]
		public int EncodingName { get; set; }

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x060014AC RID: 5292 RVA: 0x00016DF6 File Offset: 0x00014FF6
		// (set) Token: 0x060014AD RID: 5293 RVA: 0x00016DFE File Offset: 0x00014FFE
		[global::System.Runtime.Serialization.DataMember(Name = "publicId", IsRequired = true)]
		public int PublicId { get; set; }

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x060014AE RID: 5294 RVA: 0x00016E07 File Offset: 0x00015007
		// (set) Token: 0x060014AF RID: 5295 RVA: 0x00016E0F File Offset: 0x0001500F
		[global::System.Runtime.Serialization.DataMember(Name = "systemId", IsRequired = true)]
		public int SystemId { get; set; }

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x060014B0 RID: 5296 RVA: 0x00016E18 File Offset: 0x00015018
		// (set) Token: 0x060014B1 RID: 5297 RVA: 0x00016E20 File Offset: 0x00015020
		[global::System.Runtime.Serialization.DataMember(Name = "frameId", IsRequired = true)]
		public int FrameId { get; set; }

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x060014B2 RID: 5298 RVA: 0x00016E29 File Offset: 0x00015029
		// (set) Token: 0x060014B3 RID: 5299 RVA: 0x00016E31 File Offset: 0x00015031
		[global::System.Runtime.Serialization.DataMember(Name = "nodes", IsRequired = true)]
		public global::CefSharp.DevTools.DOMSnapshot.NodeTreeSnapshot Nodes { get; set; }

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x060014B4 RID: 5300 RVA: 0x00016E3A File Offset: 0x0001503A
		// (set) Token: 0x060014B5 RID: 5301 RVA: 0x00016E42 File Offset: 0x00015042
		[global::System.Runtime.Serialization.DataMember(Name = "layout", IsRequired = true)]
		public global::CefSharp.DevTools.DOMSnapshot.LayoutTreeSnapshot Layout { get; set; }

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x060014B6 RID: 5302 RVA: 0x00016E4B File Offset: 0x0001504B
		// (set) Token: 0x060014B7 RID: 5303 RVA: 0x00016E53 File Offset: 0x00015053
		[global::System.Runtime.Serialization.DataMember(Name = "textBoxes", IsRequired = true)]
		public global::CefSharp.DevTools.DOMSnapshot.TextBoxSnapshot TextBoxes { get; set; }

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x060014B8 RID: 5304 RVA: 0x00016E5C File Offset: 0x0001505C
		// (set) Token: 0x060014B9 RID: 5305 RVA: 0x00016E64 File Offset: 0x00015064
		[global::System.Runtime.Serialization.DataMember(Name = "scrollOffsetX", IsRequired = false)]
		public double? ScrollOffsetX { get; set; }

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x060014BA RID: 5306 RVA: 0x00016E6D File Offset: 0x0001506D
		// (set) Token: 0x060014BB RID: 5307 RVA: 0x00016E75 File Offset: 0x00015075
		[global::System.Runtime.Serialization.DataMember(Name = "scrollOffsetY", IsRequired = false)]
		public double? ScrollOffsetY { get; set; }

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x060014BC RID: 5308 RVA: 0x00016E7E File Offset: 0x0001507E
		// (set) Token: 0x060014BD RID: 5309 RVA: 0x00016E86 File Offset: 0x00015086
		[global::System.Runtime.Serialization.DataMember(Name = "contentWidth", IsRequired = false)]
		public double? ContentWidth { get; set; }

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x060014BE RID: 5310 RVA: 0x00016E8F File Offset: 0x0001508F
		// (set) Token: 0x060014BF RID: 5311 RVA: 0x00016E97 File Offset: 0x00015097
		[global::System.Runtime.Serialization.DataMember(Name = "contentHeight", IsRequired = false)]
		public double? ContentHeight { get; set; }
	}
}
