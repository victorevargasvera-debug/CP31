using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x02000233 RID: 563
	[global::System.Runtime.Serialization.DataContract]
	public class SubresourceWebBundleInnerResponseErrorEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x06001169 RID: 4457 RVA: 0x000129AC File Offset: 0x00010BAC
		// (set) Token: 0x0600116A RID: 4458 RVA: 0x000129B4 File Offset: 0x00010BB4
		[global::System.Runtime.Serialization.DataMember(Name = "innerRequestId", IsRequired = true)]
		public string InnerRequestId { get; private set; }

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x0600116B RID: 4459 RVA: 0x000129BD File Offset: 0x00010BBD
		// (set) Token: 0x0600116C RID: 4460 RVA: 0x000129C5 File Offset: 0x00010BC5
		[global::System.Runtime.Serialization.DataMember(Name = "innerRequestURL", IsRequired = true)]
		public string InnerRequestURL { get; private set; }

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x0600116D RID: 4461 RVA: 0x000129CE File Offset: 0x00010BCE
		// (set) Token: 0x0600116E RID: 4462 RVA: 0x000129D6 File Offset: 0x00010BD6
		[global::System.Runtime.Serialization.DataMember(Name = "errorMessage", IsRequired = true)]
		public string ErrorMessage { get; private set; }

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x0600116F RID: 4463 RVA: 0x000129DF File Offset: 0x00010BDF
		// (set) Token: 0x06001170 RID: 4464 RVA: 0x000129E7 File Offset: 0x00010BE7
		[global::System.Runtime.Serialization.DataMember(Name = "bundleRequestId", IsRequired = false)]
		public string BundleRequestId { get; private set; }
	}
}
