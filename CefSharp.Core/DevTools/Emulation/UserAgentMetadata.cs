using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Emulation
{
	// Token: 0x0200028A RID: 650
	[global::System.Runtime.Serialization.DataContract]
	public class UserAgentMetadata : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x060013A7 RID: 5031 RVA: 0x00015BB9 File Offset: 0x00013DB9
		// (set) Token: 0x060013A8 RID: 5032 RVA: 0x00015BC1 File Offset: 0x00013DC1
		[global::System.Runtime.Serialization.DataMember(Name = "brands", IsRequired = false)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Emulation.UserAgentBrandVersion> Brands { get; set; }

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x060013A9 RID: 5033 RVA: 0x00015BCA File Offset: 0x00013DCA
		// (set) Token: 0x060013AA RID: 5034 RVA: 0x00015BD2 File Offset: 0x00013DD2
		[global::System.Runtime.Serialization.DataMember(Name = "fullVersionList", IsRequired = false)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Emulation.UserAgentBrandVersion> FullVersionList { get; set; }

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x060013AB RID: 5035 RVA: 0x00015BDB File Offset: 0x00013DDB
		// (set) Token: 0x060013AC RID: 5036 RVA: 0x00015BE3 File Offset: 0x00013DE3
		[global::System.Runtime.Serialization.DataMember(Name = "fullVersion", IsRequired = false)]
		public string FullVersion { get; set; }

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x060013AD RID: 5037 RVA: 0x00015BEC File Offset: 0x00013DEC
		// (set) Token: 0x060013AE RID: 5038 RVA: 0x00015BF4 File Offset: 0x00013DF4
		[global::System.Runtime.Serialization.DataMember(Name = "platform", IsRequired = true)]
		public string Platform { get; set; }

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x060013AF RID: 5039 RVA: 0x00015BFD File Offset: 0x00013DFD
		// (set) Token: 0x060013B0 RID: 5040 RVA: 0x00015C05 File Offset: 0x00013E05
		[global::System.Runtime.Serialization.DataMember(Name = "platformVersion", IsRequired = true)]
		public string PlatformVersion { get; set; }

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x060013B1 RID: 5041 RVA: 0x00015C0E File Offset: 0x00013E0E
		// (set) Token: 0x060013B2 RID: 5042 RVA: 0x00015C16 File Offset: 0x00013E16
		[global::System.Runtime.Serialization.DataMember(Name = "architecture", IsRequired = true)]
		public string Architecture { get; set; }

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x060013B3 RID: 5043 RVA: 0x00015C1F File Offset: 0x00013E1F
		// (set) Token: 0x060013B4 RID: 5044 RVA: 0x00015C27 File Offset: 0x00013E27
		[global::System.Runtime.Serialization.DataMember(Name = "model", IsRequired = true)]
		public string Model { get; set; }

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x060013B5 RID: 5045 RVA: 0x00015C30 File Offset: 0x00013E30
		// (set) Token: 0x060013B6 RID: 5046 RVA: 0x00015C38 File Offset: 0x00013E38
		[global::System.Runtime.Serialization.DataMember(Name = "mobile", IsRequired = true)]
		public bool Mobile { get; set; }

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x060013B7 RID: 5047 RVA: 0x00015C41 File Offset: 0x00013E41
		// (set) Token: 0x060013B8 RID: 5048 RVA: 0x00015C49 File Offset: 0x00013E49
		[global::System.Runtime.Serialization.DataMember(Name = "bitness", IsRequired = false)]
		public string Bitness { get; set; }

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x060013B9 RID: 5049 RVA: 0x00015C52 File Offset: 0x00013E52
		// (set) Token: 0x060013BA RID: 5050 RVA: 0x00015C5A File Offset: 0x00013E5A
		[global::System.Runtime.Serialization.DataMember(Name = "wow64", IsRequired = false)]
		public bool? Wow64 { get; set; }
	}
}
