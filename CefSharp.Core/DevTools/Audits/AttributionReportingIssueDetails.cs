using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Audits
{
	// Token: 0x02000361 RID: 865
	[global::System.Runtime.Serialization.DataContract]
	public class AttributionReportingIssueDetails : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x06001A2C RID: 6700 RVA: 0x0001BEC1 File Offset: 0x0001A0C1
		// (set) Token: 0x06001A2D RID: 6701 RVA: 0x0001BEDD File Offset: 0x0001A0DD
		public global::CefSharp.DevTools.Audits.AttributionReportingIssueType ViolationType
		{
			get
			{
				return (global::CefSharp.DevTools.Audits.AttributionReportingIssueType)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Audits.AttributionReportingIssueType), this.violationType);
			}
			set
			{
				this.violationType = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x06001A2E RID: 6702 RVA: 0x0001BEF0 File Offset: 0x0001A0F0
		// (set) Token: 0x06001A2F RID: 6703 RVA: 0x0001BEF8 File Offset: 0x0001A0F8
		[global::System.Runtime.Serialization.DataMember(Name = "violationType", IsRequired = true)]
		internal string violationType { get; set; }

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x06001A30 RID: 6704 RVA: 0x0001BF01 File Offset: 0x0001A101
		// (set) Token: 0x06001A31 RID: 6705 RVA: 0x0001BF09 File Offset: 0x0001A109
		[global::System.Runtime.Serialization.DataMember(Name = "request", IsRequired = false)]
		public global::CefSharp.DevTools.Audits.AffectedRequest Request { get; set; }

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x06001A32 RID: 6706 RVA: 0x0001BF12 File Offset: 0x0001A112
		// (set) Token: 0x06001A33 RID: 6707 RVA: 0x0001BF1A File Offset: 0x0001A11A
		[global::System.Runtime.Serialization.DataMember(Name = "violatingNodeId", IsRequired = false)]
		public int? ViolatingNodeId { get; set; }

		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x06001A34 RID: 6708 RVA: 0x0001BF23 File Offset: 0x0001A123
		// (set) Token: 0x06001A35 RID: 6709 RVA: 0x0001BF2B File Offset: 0x0001A12B
		[global::System.Runtime.Serialization.DataMember(Name = "invalidParameter", IsRequired = false)]
		public string InvalidParameter { get; set; }
	}
}
