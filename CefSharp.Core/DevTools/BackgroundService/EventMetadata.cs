using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.BackgroundService
{
	// Token: 0x02000343 RID: 835
	[global::System.Runtime.Serialization.DataContract]
	public class EventMetadata : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x06001964 RID: 6500 RVA: 0x0001B57B File Offset: 0x0001977B
		// (set) Token: 0x06001965 RID: 6501 RVA: 0x0001B583 File Offset: 0x00019783
		[global::System.Runtime.Serialization.DataMember(Name = "key", IsRequired = true)]
		public string Key { get; set; }

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x06001966 RID: 6502 RVA: 0x0001B58C File Offset: 0x0001978C
		// (set) Token: 0x06001967 RID: 6503 RVA: 0x0001B594 File Offset: 0x00019794
		[global::System.Runtime.Serialization.DataMember(Name = "value", IsRequired = true)]
		public string Value { get; set; }
	}
}
