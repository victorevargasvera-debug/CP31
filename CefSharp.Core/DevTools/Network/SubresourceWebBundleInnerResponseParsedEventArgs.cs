using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x02000232 RID: 562
	[global::System.Runtime.Serialization.DataContract]
	public class SubresourceWebBundleInnerResponseParsedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06001162 RID: 4450 RVA: 0x00012971 File Offset: 0x00010B71
		// (set) Token: 0x06001163 RID: 4451 RVA: 0x00012979 File Offset: 0x00010B79
		[global::System.Runtime.Serialization.DataMember(Name = "innerRequestId", IsRequired = true)]
		public string InnerRequestId { get; private set; }

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x06001164 RID: 4452 RVA: 0x00012982 File Offset: 0x00010B82
		// (set) Token: 0x06001165 RID: 4453 RVA: 0x0001298A File Offset: 0x00010B8A
		[global::System.Runtime.Serialization.DataMember(Name = "innerRequestURL", IsRequired = true)]
		public string InnerRequestURL { get; private set; }

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x06001166 RID: 4454 RVA: 0x00012993 File Offset: 0x00010B93
		// (set) Token: 0x06001167 RID: 4455 RVA: 0x0001299B File Offset: 0x00010B9B
		[global::System.Runtime.Serialization.DataMember(Name = "bundleRequestId", IsRequired = false)]
		public string BundleRequestId { get; private set; }
	}
}
