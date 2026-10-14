using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Audits
{
	// Token: 0x02000365 RID: 869
	[global::System.Runtime.Serialization.DataContract]
	public class GenericIssueDetails : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x06001A47 RID: 6727 RVA: 0x0001BFC3 File Offset: 0x0001A1C3
		// (set) Token: 0x06001A48 RID: 6728 RVA: 0x0001BFDF File Offset: 0x0001A1DF
		public global::CefSharp.DevTools.Audits.GenericIssueErrorType ErrorType
		{
			get
			{
				return (global::CefSharp.DevTools.Audits.GenericIssueErrorType)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Audits.GenericIssueErrorType), this.errorType);
			}
			set
			{
				this.errorType = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x06001A49 RID: 6729 RVA: 0x0001BFF2 File Offset: 0x0001A1F2
		// (set) Token: 0x06001A4A RID: 6730 RVA: 0x0001BFFA File Offset: 0x0001A1FA
		[global::System.Runtime.Serialization.DataMember(Name = "errorType", IsRequired = true)]
		internal string errorType { get; set; }

		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x06001A4B RID: 6731 RVA: 0x0001C003 File Offset: 0x0001A203
		// (set) Token: 0x06001A4C RID: 6732 RVA: 0x0001C00B File Offset: 0x0001A20B
		[global::System.Runtime.Serialization.DataMember(Name = "frameId", IsRequired = false)]
		public string FrameId { get; set; }

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x06001A4D RID: 6733 RVA: 0x0001C014 File Offset: 0x0001A214
		// (set) Token: 0x06001A4E RID: 6734 RVA: 0x0001C01C File Offset: 0x0001A21C
		[global::System.Runtime.Serialization.DataMember(Name = "violatingNodeId", IsRequired = false)]
		public int? ViolatingNodeId { get; set; }

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x06001A4F RID: 6735 RVA: 0x0001C025 File Offset: 0x0001A225
		// (set) Token: 0x06001A50 RID: 6736 RVA: 0x0001C02D File Offset: 0x0001A22D
		[global::System.Runtime.Serialization.DataMember(Name = "violatingNodeAttribute", IsRequired = false)]
		public string ViolatingNodeAttribute { get; set; }
	}
}
