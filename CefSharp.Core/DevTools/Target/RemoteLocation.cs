using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Target
{
	// Token: 0x02000101 RID: 257
	[global::System.Runtime.Serialization.DataContract]
	public class RemoteLocation : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000310 RID: 784
		// (get) Token: 0x0600083A RID: 2106 RVA: 0x0000ADB1 File Offset: 0x00008FB1
		// (set) Token: 0x0600083B RID: 2107 RVA: 0x0000ADB9 File Offset: 0x00008FB9
		[global::System.Runtime.Serialization.DataMember(Name = "host", IsRequired = true)]
		public string Host { get; set; }

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x0600083C RID: 2108 RVA: 0x0000ADC2 File Offset: 0x00008FC2
		// (set) Token: 0x0600083D RID: 2109 RVA: 0x0000ADCA File Offset: 0x00008FCA
		[global::System.Runtime.Serialization.DataMember(Name = "port", IsRequired = true)]
		public int Port { get; set; }
	}
}
