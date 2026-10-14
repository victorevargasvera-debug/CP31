using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Target
{
	// Token: 0x020000FF RID: 255
	[global::System.Runtime.Serialization.DataContract]
	public class TargetInfo : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000820 RID: 2080 RVA: 0x0000ACD5 File Offset: 0x00008ED5
		// (set) Token: 0x06000821 RID: 2081 RVA: 0x0000ACDD File Offset: 0x00008EDD
		[global::System.Runtime.Serialization.DataMember(Name = "targetId", IsRequired = true)]
		public string TargetId { get; set; }

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000822 RID: 2082 RVA: 0x0000ACE6 File Offset: 0x00008EE6
		// (set) Token: 0x06000823 RID: 2083 RVA: 0x0000ACEE File Offset: 0x00008EEE
		[global::System.Runtime.Serialization.DataMember(Name = "type", IsRequired = true)]
		public string Type { get; set; }

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000824 RID: 2084 RVA: 0x0000ACF7 File Offset: 0x00008EF7
		// (set) Token: 0x06000825 RID: 2085 RVA: 0x0000ACFF File Offset: 0x00008EFF
		[global::System.Runtime.Serialization.DataMember(Name = "title", IsRequired = true)]
		public string Title { get; set; }

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000826 RID: 2086 RVA: 0x0000AD08 File Offset: 0x00008F08
		// (set) Token: 0x06000827 RID: 2087 RVA: 0x0000AD10 File Offset: 0x00008F10
		[global::System.Runtime.Serialization.DataMember(Name = "url", IsRequired = true)]
		public string Url { get; set; }

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000828 RID: 2088 RVA: 0x0000AD19 File Offset: 0x00008F19
		// (set) Token: 0x06000829 RID: 2089 RVA: 0x0000AD21 File Offset: 0x00008F21
		[global::System.Runtime.Serialization.DataMember(Name = "attached", IsRequired = true)]
		public bool Attached { get; set; }

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x0600082A RID: 2090 RVA: 0x0000AD2A File Offset: 0x00008F2A
		// (set) Token: 0x0600082B RID: 2091 RVA: 0x0000AD32 File Offset: 0x00008F32
		[global::System.Runtime.Serialization.DataMember(Name = "openerId", IsRequired = false)]
		public string OpenerId { get; set; }

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x0600082C RID: 2092 RVA: 0x0000AD3B File Offset: 0x00008F3B
		// (set) Token: 0x0600082D RID: 2093 RVA: 0x0000AD43 File Offset: 0x00008F43
		[global::System.Runtime.Serialization.DataMember(Name = "canAccessOpener", IsRequired = true)]
		public bool CanAccessOpener { get; set; }

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x0600082E RID: 2094 RVA: 0x0000AD4C File Offset: 0x00008F4C
		// (set) Token: 0x0600082F RID: 2095 RVA: 0x0000AD54 File Offset: 0x00008F54
		[global::System.Runtime.Serialization.DataMember(Name = "openerFrameId", IsRequired = false)]
		public string OpenerFrameId { get; set; }

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000830 RID: 2096 RVA: 0x0000AD5D File Offset: 0x00008F5D
		// (set) Token: 0x06000831 RID: 2097 RVA: 0x0000AD65 File Offset: 0x00008F65
		[global::System.Runtime.Serialization.DataMember(Name = "browserContextId", IsRequired = false)]
		public string BrowserContextId { get; set; }

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000832 RID: 2098 RVA: 0x0000AD6E File Offset: 0x00008F6E
		// (set) Token: 0x06000833 RID: 2099 RVA: 0x0000AD76 File Offset: 0x00008F76
		[global::System.Runtime.Serialization.DataMember(Name = "subtype", IsRequired = false)]
		public string Subtype { get; set; }
	}
}
