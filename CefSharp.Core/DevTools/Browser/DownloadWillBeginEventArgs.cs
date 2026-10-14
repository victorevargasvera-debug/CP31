using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Browser
{
	// Token: 0x02000337 RID: 823
	[global::System.Runtime.Serialization.DataContract]
	public class DownloadWillBeginEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x06001913 RID: 6419 RVA: 0x0001AEB1 File Offset: 0x000190B1
		// (set) Token: 0x06001914 RID: 6420 RVA: 0x0001AEB9 File Offset: 0x000190B9
		[global::System.Runtime.Serialization.DataMember(Name = "frameId", IsRequired = true)]
		public string FrameId { get; private set; }

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x06001915 RID: 6421 RVA: 0x0001AEC2 File Offset: 0x000190C2
		// (set) Token: 0x06001916 RID: 6422 RVA: 0x0001AECA File Offset: 0x000190CA
		[global::System.Runtime.Serialization.DataMember(Name = "guid", IsRequired = true)]
		public string Guid { get; private set; }

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x06001917 RID: 6423 RVA: 0x0001AED3 File Offset: 0x000190D3
		// (set) Token: 0x06001918 RID: 6424 RVA: 0x0001AEDB File Offset: 0x000190DB
		[global::System.Runtime.Serialization.DataMember(Name = "url", IsRequired = true)]
		public string Url { get; private set; }

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x06001919 RID: 6425 RVA: 0x0001AEE4 File Offset: 0x000190E4
		// (set) Token: 0x0600191A RID: 6426 RVA: 0x0001AEEC File Offset: 0x000190EC
		[global::System.Runtime.Serialization.DataMember(Name = "suggestedFilename", IsRequired = true)]
		public string SuggestedFilename { get; private set; }
	}
}
