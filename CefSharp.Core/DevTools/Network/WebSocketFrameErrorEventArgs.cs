using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x02000224 RID: 548
	[global::System.Runtime.Serialization.DataContract]
	public class WebSocketFrameErrorEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x060010EF RID: 4335 RVA: 0x0001254C File Offset: 0x0001074C
		// (set) Token: 0x060010F0 RID: 4336 RVA: 0x00012554 File Offset: 0x00010754
		[global::System.Runtime.Serialization.DataMember(Name = "requestId", IsRequired = true)]
		public string RequestId { get; private set; }

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x060010F1 RID: 4337 RVA: 0x0001255D File Offset: 0x0001075D
		// (set) Token: 0x060010F2 RID: 4338 RVA: 0x00012565 File Offset: 0x00010765
		[global::System.Runtime.Serialization.DataMember(Name = "timestamp", IsRequired = true)]
		public double Timestamp { get; private set; }

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x060010F3 RID: 4339 RVA: 0x0001256E File Offset: 0x0001076E
		// (set) Token: 0x060010F4 RID: 4340 RVA: 0x00012576 File Offset: 0x00010776
		[global::System.Runtime.Serialization.DataMember(Name = "errorMessage", IsRequired = true)]
		public string ErrorMessage { get; private set; }
	}
}
