using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Media
{
	// Token: 0x020000BB RID: 187
	[global::System.Runtime.Serialization.DataContract]
	public class PlayerMessagesLoggedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000259 RID: 601
		// (get) Token: 0x0600064C RID: 1612 RVA: 0x0000902C File Offset: 0x0000722C
		// (set) Token: 0x0600064D RID: 1613 RVA: 0x00009034 File Offset: 0x00007234
		[global::System.Runtime.Serialization.DataMember(Name = "playerId", IsRequired = true)]
		public string PlayerId { get; private set; }

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x0600064E RID: 1614 RVA: 0x0000903D File Offset: 0x0000723D
		// (set) Token: 0x0600064F RID: 1615 RVA: 0x00009045 File Offset: 0x00007245
		[global::System.Runtime.Serialization.DataMember(Name = "messages", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Media.PlayerMessage> Messages { get; private set; }
	}
}
