using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Memory
{
	// Token: 0x02000245 RID: 581
	[global::System.Runtime.Serialization.DataContract]
	public class SamplingProfile : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x06001210 RID: 4624 RVA: 0x00013ADD File Offset: 0x00011CDD
		// (set) Token: 0x06001211 RID: 4625 RVA: 0x00013AE5 File Offset: 0x00011CE5
		[global::System.Runtime.Serialization.DataMember(Name = "samples", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Memory.SamplingProfileNode> Samples { get; set; }

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06001212 RID: 4626 RVA: 0x00013AEE File Offset: 0x00011CEE
		// (set) Token: 0x06001213 RID: 4627 RVA: 0x00013AF6 File Offset: 0x00011CF6
		[global::System.Runtime.Serialization.DataMember(Name = "modules", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Memory.Module> Modules { get; set; }
	}
}
