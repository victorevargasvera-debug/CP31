using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Media
{
	// Token: 0x020000BA RID: 186
	[global::System.Runtime.Serialization.DataContract]
	public class PlayerEventsAddedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000647 RID: 1607 RVA: 0x00009002 File Offset: 0x00007202
		// (set) Token: 0x06000648 RID: 1608 RVA: 0x0000900A File Offset: 0x0000720A
		[global::System.Runtime.Serialization.DataMember(Name = "playerId", IsRequired = true)]
		public string PlayerId { get; private set; }

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000649 RID: 1609 RVA: 0x00009013 File Offset: 0x00007213
		// (set) Token: 0x0600064A RID: 1610 RVA: 0x0000901B File Offset: 0x0000721B
		[global::System.Runtime.Serialization.DataMember(Name = "events", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Media.PlayerEvent> Events { get; private set; }
	}
}
