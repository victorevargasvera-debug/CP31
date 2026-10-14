using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Media
{
	// Token: 0x020000B5 RID: 181
	[global::System.Runtime.Serialization.DataContract]
	public class PlayerProperty : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000628 RID: 1576 RVA: 0x00008EFD File Offset: 0x000070FD
		// (set) Token: 0x06000629 RID: 1577 RVA: 0x00008F05 File Offset: 0x00007105
		[global::System.Runtime.Serialization.DataMember(Name = "name", IsRequired = true)]
		public string Name { get; set; }

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x0600062A RID: 1578 RVA: 0x00008F0E File Offset: 0x0000710E
		// (set) Token: 0x0600062B RID: 1579 RVA: 0x00008F16 File Offset: 0x00007116
		[global::System.Runtime.Serialization.DataMember(Name = "value", IsRequired = true)]
		public string Value { get; set; }
	}
}
