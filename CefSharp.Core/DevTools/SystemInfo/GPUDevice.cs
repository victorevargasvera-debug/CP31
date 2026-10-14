using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.SystemInfo
{
	// Token: 0x02000113 RID: 275
	[global::System.Runtime.Serialization.DataContract]
	public class GPUDevice : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000332 RID: 818
		// (get) Token: 0x060008A6 RID: 2214 RVA: 0x0000B6EA File Offset: 0x000098EA
		// (set) Token: 0x060008A7 RID: 2215 RVA: 0x0000B6F2 File Offset: 0x000098F2
		[global::System.Runtime.Serialization.DataMember(Name = "vendorId", IsRequired = true)]
		public double VendorId { get; set; }

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x060008A8 RID: 2216 RVA: 0x0000B6FB File Offset: 0x000098FB
		// (set) Token: 0x060008A9 RID: 2217 RVA: 0x0000B703 File Offset: 0x00009903
		[global::System.Runtime.Serialization.DataMember(Name = "deviceId", IsRequired = true)]
		public double DeviceId { get; set; }

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x060008AA RID: 2218 RVA: 0x0000B70C File Offset: 0x0000990C
		// (set) Token: 0x060008AB RID: 2219 RVA: 0x0000B714 File Offset: 0x00009914
		[global::System.Runtime.Serialization.DataMember(Name = "subSysId", IsRequired = false)]
		public double? SubSysId { get; set; }

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x060008AC RID: 2220 RVA: 0x0000B71D File Offset: 0x0000991D
		// (set) Token: 0x060008AD RID: 2221 RVA: 0x0000B725 File Offset: 0x00009925
		[global::System.Runtime.Serialization.DataMember(Name = "revision", IsRequired = false)]
		public double? Revision { get; set; }

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x060008AE RID: 2222 RVA: 0x0000B72E File Offset: 0x0000992E
		// (set) Token: 0x060008AF RID: 2223 RVA: 0x0000B736 File Offset: 0x00009936
		[global::System.Runtime.Serialization.DataMember(Name = "vendorString", IsRequired = true)]
		public string VendorString { get; set; }

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x060008B0 RID: 2224 RVA: 0x0000B73F File Offset: 0x0000993F
		// (set) Token: 0x060008B1 RID: 2225 RVA: 0x0000B747 File Offset: 0x00009947
		[global::System.Runtime.Serialization.DataMember(Name = "deviceString", IsRequired = true)]
		public string DeviceString { get; set; }

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x060008B2 RID: 2226 RVA: 0x0000B750 File Offset: 0x00009950
		// (set) Token: 0x060008B3 RID: 2227 RVA: 0x0000B758 File Offset: 0x00009958
		[global::System.Runtime.Serialization.DataMember(Name = "driverVendor", IsRequired = true)]
		public string DriverVendor { get; set; }

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x060008B4 RID: 2228 RVA: 0x0000B761 File Offset: 0x00009961
		// (set) Token: 0x060008B5 RID: 2229 RVA: 0x0000B769 File Offset: 0x00009969
		[global::System.Runtime.Serialization.DataMember(Name = "driverVersion", IsRequired = true)]
		public string DriverVersion { get; set; }
	}
}
