using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x0200020F RID: 527
	[global::System.Runtime.Serialization.DataContract]
	public class CrossOriginOpenerPolicyStatus : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x0600100E RID: 4110 RVA: 0x00011C75 File Offset: 0x0000FE75
		// (set) Token: 0x0600100F RID: 4111 RVA: 0x00011C91 File Offset: 0x0000FE91
		public global::CefSharp.DevTools.Network.CrossOriginOpenerPolicyValue Value
		{
			get
			{
				return (global::CefSharp.DevTools.Network.CrossOriginOpenerPolicyValue)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Network.CrossOriginOpenerPolicyValue), this.value);
			}
			set
			{
				this.value = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06001010 RID: 4112 RVA: 0x00011CA4 File Offset: 0x0000FEA4
		// (set) Token: 0x06001011 RID: 4113 RVA: 0x00011CAC File Offset: 0x0000FEAC
		[global::System.Runtime.Serialization.DataMember(Name = "value", IsRequired = true)]
		internal string value { get; set; }

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06001012 RID: 4114 RVA: 0x00011CB5 File Offset: 0x0000FEB5
		// (set) Token: 0x06001013 RID: 4115 RVA: 0x00011CD1 File Offset: 0x0000FED1
		public global::CefSharp.DevTools.Network.CrossOriginOpenerPolicyValue ReportOnlyValue
		{
			get
			{
				return (global::CefSharp.DevTools.Network.CrossOriginOpenerPolicyValue)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Network.CrossOriginOpenerPolicyValue), this.reportOnlyValue);
			}
			set
			{
				this.reportOnlyValue = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06001014 RID: 4116 RVA: 0x00011CE4 File Offset: 0x0000FEE4
		// (set) Token: 0x06001015 RID: 4117 RVA: 0x00011CEC File Offset: 0x0000FEEC
		[global::System.Runtime.Serialization.DataMember(Name = "reportOnlyValue", IsRequired = true)]
		internal string reportOnlyValue { get; set; }

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06001016 RID: 4118 RVA: 0x00011CF5 File Offset: 0x0000FEF5
		// (set) Token: 0x06001017 RID: 4119 RVA: 0x00011CFD File Offset: 0x0000FEFD
		[global::System.Runtime.Serialization.DataMember(Name = "reportingEndpoint", IsRequired = false)]
		public string ReportingEndpoint { get; set; }

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06001018 RID: 4120 RVA: 0x00011D06 File Offset: 0x0000FF06
		// (set) Token: 0x06001019 RID: 4121 RVA: 0x00011D0E File Offset: 0x0000FF0E
		[global::System.Runtime.Serialization.DataMember(Name = "reportOnlyReportingEndpoint", IsRequired = false)]
		public string ReportOnlyReportingEndpoint { get; set; }
	}
}
