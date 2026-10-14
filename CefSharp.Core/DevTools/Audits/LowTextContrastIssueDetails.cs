using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Audits
{
	// Token: 0x0200035E RID: 862
	[global::System.Runtime.Serialization.DataContract]
	public class LowTextContrastIssueDetails : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x06001A0C RID: 6668 RVA: 0x0001BD94 File Offset: 0x00019F94
		// (set) Token: 0x06001A0D RID: 6669 RVA: 0x0001BD9C File Offset: 0x00019F9C
		[global::System.Runtime.Serialization.DataMember(Name = "violatingNodeId", IsRequired = true)]
		public int ViolatingNodeId { get; set; }

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x06001A0E RID: 6670 RVA: 0x0001BDA5 File Offset: 0x00019FA5
		// (set) Token: 0x06001A0F RID: 6671 RVA: 0x0001BDAD File Offset: 0x00019FAD
		[global::System.Runtime.Serialization.DataMember(Name = "violatingNodeSelector", IsRequired = true)]
		public string ViolatingNodeSelector { get; set; }

		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x06001A10 RID: 6672 RVA: 0x0001BDB6 File Offset: 0x00019FB6
		// (set) Token: 0x06001A11 RID: 6673 RVA: 0x0001BDBE File Offset: 0x00019FBE
		[global::System.Runtime.Serialization.DataMember(Name = "contrastRatio", IsRequired = true)]
		public double ContrastRatio { get; set; }

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x06001A12 RID: 6674 RVA: 0x0001BDC7 File Offset: 0x00019FC7
		// (set) Token: 0x06001A13 RID: 6675 RVA: 0x0001BDCF File Offset: 0x00019FCF
		[global::System.Runtime.Serialization.DataMember(Name = "thresholdAA", IsRequired = true)]
		public double ThresholdAA { get; set; }

		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x06001A14 RID: 6676 RVA: 0x0001BDD8 File Offset: 0x00019FD8
		// (set) Token: 0x06001A15 RID: 6677 RVA: 0x0001BDE0 File Offset: 0x00019FE0
		[global::System.Runtime.Serialization.DataMember(Name = "thresholdAAA", IsRequired = true)]
		public double ThresholdAAA { get; set; }

		// Token: 0x17000A38 RID: 2616
		// (get) Token: 0x06001A16 RID: 6678 RVA: 0x0001BDE9 File Offset: 0x00019FE9
		// (set) Token: 0x06001A17 RID: 6679 RVA: 0x0001BDF1 File Offset: 0x00019FF1
		[global::System.Runtime.Serialization.DataMember(Name = "fontSize", IsRequired = true)]
		public string FontSize { get; set; }

		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x06001A18 RID: 6680 RVA: 0x0001BDFA File Offset: 0x00019FFA
		// (set) Token: 0x06001A19 RID: 6681 RVA: 0x0001BE02 File Offset: 0x0001A002
		[global::System.Runtime.Serialization.DataMember(Name = "fontWeight", IsRequired = true)]
		public string FontWeight { get; set; }
	}
}
