using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.SystemInfo
{
	// Token: 0x0200011B RID: 283
	[global::System.Runtime.Serialization.DataContract]
	public class ProcessInfo : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000350 RID: 848
		// (get) Token: 0x060008E8 RID: 2280 RVA: 0x0000B94F File Offset: 0x00009B4F
		// (set) Token: 0x060008E9 RID: 2281 RVA: 0x0000B957 File Offset: 0x00009B57
		[global::System.Runtime.Serialization.DataMember(Name = "type", IsRequired = true)]
		public string Type { get; set; }

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x060008EA RID: 2282 RVA: 0x0000B960 File Offset: 0x00009B60
		// (set) Token: 0x060008EB RID: 2283 RVA: 0x0000B968 File Offset: 0x00009B68
		[global::System.Runtime.Serialization.DataMember(Name = "id", IsRequired = true)]
		public int Id { get; set; }

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x060008EC RID: 2284 RVA: 0x0000B971 File Offset: 0x00009B71
		// (set) Token: 0x060008ED RID: 2285 RVA: 0x0000B979 File Offset: 0x00009B79
		[global::System.Runtime.Serialization.DataMember(Name = "cpuTime", IsRequired = true)]
		public double CpuTime { get; set; }
	}
}
