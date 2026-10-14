using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x02000230 RID: 560
	[global::System.Runtime.Serialization.DataContract]
	public class SubresourceWebBundleMetadataReceivedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x06001158 RID: 4440 RVA: 0x0001291D File Offset: 0x00010B1D
		// (set) Token: 0x06001159 RID: 4441 RVA: 0x00012925 File Offset: 0x00010B25
		[global::System.Runtime.Serialization.DataMember(Name = "requestId", IsRequired = true)]
		public string RequestId { get; private set; }

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x0600115A RID: 4442 RVA: 0x0001292E File Offset: 0x00010B2E
		// (set) Token: 0x0600115B RID: 4443 RVA: 0x00012936 File Offset: 0x00010B36
		[global::System.Runtime.Serialization.DataMember(Name = "urls", IsRequired = true)]
		public string[] Urls { get; private set; }
	}
}
