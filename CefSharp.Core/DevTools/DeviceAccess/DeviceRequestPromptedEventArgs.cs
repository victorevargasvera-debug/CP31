using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DeviceAccess
{
	// Token: 0x020000B1 RID: 177
	[global::System.Runtime.Serialization.DataContract]
	public class DeviceRequestPromptedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000615 RID: 1557 RVA: 0x00008D96 File Offset: 0x00006F96
		// (set) Token: 0x06000616 RID: 1558 RVA: 0x00008D9E File Offset: 0x00006F9E
		[global::System.Runtime.Serialization.DataMember(Name = "id", IsRequired = true)]
		public string Id { get; private set; }

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000617 RID: 1559 RVA: 0x00008DA7 File Offset: 0x00006FA7
		// (set) Token: 0x06000618 RID: 1560 RVA: 0x00008DAF File Offset: 0x00006FAF
		[global::System.Runtime.Serialization.DataMember(Name = "devices", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.DeviceAccess.PromptDevice> Devices { get; private set; }
	}
}
