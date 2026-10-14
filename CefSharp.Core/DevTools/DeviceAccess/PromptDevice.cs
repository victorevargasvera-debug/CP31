using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DeviceAccess
{
	// Token: 0x020000B0 RID: 176
	[global::System.Runtime.Serialization.DataContract]
	public class PromptDevice : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000610 RID: 1552 RVA: 0x00008D6C File Offset: 0x00006F6C
		// (set) Token: 0x06000611 RID: 1553 RVA: 0x00008D74 File Offset: 0x00006F74
		[global::System.Runtime.Serialization.DataMember(Name = "id", IsRequired = true)]
		public string Id { get; set; }

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000612 RID: 1554 RVA: 0x00008D7D File Offset: 0x00006F7D
		// (set) Token: 0x06000613 RID: 1555 RVA: 0x00008D85 File Offset: 0x00006F85
		[global::System.Runtime.Serialization.DataMember(Name = "name", IsRequired = true)]
		public string Name { get; set; }
	}
}
