using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x0200020C RID: 524
	[global::System.Runtime.Serialization.DataContract]
	public class ConnectTiming : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06001000 RID: 4096 RVA: 0x00011BC3 File Offset: 0x0000FDC3
		// (set) Token: 0x06001001 RID: 4097 RVA: 0x00011BCB File Offset: 0x0000FDCB
		[global::System.Runtime.Serialization.DataMember(Name = "requestTime", IsRequired = true)]
		public double RequestTime { get; set; }
	}
}
