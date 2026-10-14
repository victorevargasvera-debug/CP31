using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Media
{
	// Token: 0x020000B6 RID: 182
	[global::System.Runtime.Serialization.DataContract]
	public class PlayerEvent : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700024C RID: 588
		// (get) Token: 0x0600062D RID: 1581 RVA: 0x00008F27 File Offset: 0x00007127
		// (set) Token: 0x0600062E RID: 1582 RVA: 0x00008F2F File Offset: 0x0000712F
		[global::System.Runtime.Serialization.DataMember(Name = "timestamp", IsRequired = true)]
		public double Timestamp { get; set; }

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x0600062F RID: 1583 RVA: 0x00008F38 File Offset: 0x00007138
		// (set) Token: 0x06000630 RID: 1584 RVA: 0x00008F40 File Offset: 0x00007140
		[global::System.Runtime.Serialization.DataMember(Name = "value", IsRequired = true)]
		public string Value { get; set; }
	}
}
