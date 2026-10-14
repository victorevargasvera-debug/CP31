using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x02000231 RID: 561
	[global::System.Runtime.Serialization.DataContract]
	public class SubresourceWebBundleMetadataErrorEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x0600115D RID: 4445 RVA: 0x00012947 File Offset: 0x00010B47
		// (set) Token: 0x0600115E RID: 4446 RVA: 0x0001294F File Offset: 0x00010B4F
		[global::System.Runtime.Serialization.DataMember(Name = "requestId", IsRequired = true)]
		public string RequestId { get; private set; }

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x0600115F RID: 4447 RVA: 0x00012958 File Offset: 0x00010B58
		// (set) Token: 0x06001160 RID: 4448 RVA: 0x00012960 File Offset: 0x00010B60
		[global::System.Runtime.Serialization.DataMember(Name = "errorMessage", IsRequired = true)]
		public string ErrorMessage { get; private set; }
	}
}
