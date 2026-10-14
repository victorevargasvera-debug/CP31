using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Audits
{
	// Token: 0x02000362 RID: 866
	[global::System.Runtime.Serialization.DataContract]
	public class QuirksModeIssueDetails : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x06001A37 RID: 6711 RVA: 0x0001BF3C File Offset: 0x0001A13C
		// (set) Token: 0x06001A38 RID: 6712 RVA: 0x0001BF44 File Offset: 0x0001A144
		[global::System.Runtime.Serialization.DataMember(Name = "isLimitedQuirksMode", IsRequired = true)]
		public bool IsLimitedQuirksMode { get; set; }

		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x06001A39 RID: 6713 RVA: 0x0001BF4D File Offset: 0x0001A14D
		// (set) Token: 0x06001A3A RID: 6714 RVA: 0x0001BF55 File Offset: 0x0001A155
		[global::System.Runtime.Serialization.DataMember(Name = "documentNodeId", IsRequired = true)]
		public int DocumentNodeId { get; set; }

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x06001A3B RID: 6715 RVA: 0x0001BF5E File Offset: 0x0001A15E
		// (set) Token: 0x06001A3C RID: 6716 RVA: 0x0001BF66 File Offset: 0x0001A166
		[global::System.Runtime.Serialization.DataMember(Name = "url", IsRequired = true)]
		public string Url { get; set; }

		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x06001A3D RID: 6717 RVA: 0x0001BF6F File Offset: 0x0001A16F
		// (set) Token: 0x06001A3E RID: 6718 RVA: 0x0001BF77 File Offset: 0x0001A177
		[global::System.Runtime.Serialization.DataMember(Name = "frameId", IsRequired = true)]
		public string FrameId { get; set; }

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x06001A3F RID: 6719 RVA: 0x0001BF80 File Offset: 0x0001A180
		// (set) Token: 0x06001A40 RID: 6720 RVA: 0x0001BF88 File Offset: 0x0001A188
		[global::System.Runtime.Serialization.DataMember(Name = "loaderId", IsRequired = true)]
		public string LoaderId { get; set; }
	}
}
