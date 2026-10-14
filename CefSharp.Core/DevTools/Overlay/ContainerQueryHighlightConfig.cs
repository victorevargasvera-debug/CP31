using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Overlay
{
	// Token: 0x020001CF RID: 463
	[global::System.Runtime.Serialization.DataContract]
	public class ContainerQueryHighlightConfig : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06000E14 RID: 3604 RVA: 0x00010153 File Offset: 0x0000E353
		// (set) Token: 0x06000E15 RID: 3605 RVA: 0x0001015B File Offset: 0x0000E35B
		[global::System.Runtime.Serialization.DataMember(Name = "containerQueryContainerHighlightConfig", IsRequired = true)]
		public global::CefSharp.DevTools.Overlay.ContainerQueryContainerHighlightConfig ContainerQueryContainerHighlightConfig { get; set; }

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06000E16 RID: 3606 RVA: 0x00010164 File Offset: 0x0000E364
		// (set) Token: 0x06000E17 RID: 3607 RVA: 0x0001016C File Offset: 0x0000E36C
		[global::System.Runtime.Serialization.DataMember(Name = "nodeId", IsRequired = true)]
		public int NodeId { get; set; }
	}
}
