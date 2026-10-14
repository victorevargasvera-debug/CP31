using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x02000211 RID: 529
	[global::System.Runtime.Serialization.DataContract]
	public class CrossOriginEmbedderPolicyStatus : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x0600101B RID: 4123 RVA: 0x00011D1F File Offset: 0x0000FF1F
		// (set) Token: 0x0600101C RID: 4124 RVA: 0x00011D3B File Offset: 0x0000FF3B
		public global::CefSharp.DevTools.Network.CrossOriginEmbedderPolicyValue Value
		{
			get
			{
				return (global::CefSharp.DevTools.Network.CrossOriginEmbedderPolicyValue)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Network.CrossOriginEmbedderPolicyValue), this.value);
			}
			set
			{
				this.value = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x0600101D RID: 4125 RVA: 0x00011D4E File Offset: 0x0000FF4E
		// (set) Token: 0x0600101E RID: 4126 RVA: 0x00011D56 File Offset: 0x0000FF56
		[global::System.Runtime.Serialization.DataMember(Name = "value", IsRequired = true)]
		internal string value { get; set; }

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x0600101F RID: 4127 RVA: 0x00011D5F File Offset: 0x0000FF5F
		// (set) Token: 0x06001020 RID: 4128 RVA: 0x00011D7B File Offset: 0x0000FF7B
		public global::CefSharp.DevTools.Network.CrossOriginEmbedderPolicyValue ReportOnlyValue
		{
			get
			{
				return (global::CefSharp.DevTools.Network.CrossOriginEmbedderPolicyValue)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Network.CrossOriginEmbedderPolicyValue), this.reportOnlyValue);
			}
			set
			{
				this.reportOnlyValue = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06001021 RID: 4129 RVA: 0x00011D8E File Offset: 0x0000FF8E
		// (set) Token: 0x06001022 RID: 4130 RVA: 0x00011D96 File Offset: 0x0000FF96
		[global::System.Runtime.Serialization.DataMember(Name = "reportOnlyValue", IsRequired = true)]
		internal string reportOnlyValue { get; set; }

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x06001023 RID: 4131 RVA: 0x00011D9F File Offset: 0x0000FF9F
		// (set) Token: 0x06001024 RID: 4132 RVA: 0x00011DA7 File Offset: 0x0000FFA7
		[global::System.Runtime.Serialization.DataMember(Name = "reportingEndpoint", IsRequired = false)]
		public string ReportingEndpoint { get; set; }

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06001025 RID: 4133 RVA: 0x00011DB0 File Offset: 0x0000FFB0
		// (set) Token: 0x06001026 RID: 4134 RVA: 0x00011DB8 File Offset: 0x0000FFB8
		[global::System.Runtime.Serialization.DataMember(Name = "reportOnlyReportingEndpoint", IsRequired = false)]
		public string ReportOnlyReportingEndpoint { get; set; }
	}
}
