using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Media
{
	// Token: 0x020000BC RID: 188
	[global::System.Runtime.Serialization.DataContract]
	public class PlayerErrorsRaisedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x00009056 File Offset: 0x00007256
		// (set) Token: 0x06000652 RID: 1618 RVA: 0x0000905E File Offset: 0x0000725E
		[global::System.Runtime.Serialization.DataMember(Name = "playerId", IsRequired = true)]
		public string PlayerId { get; private set; }

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000653 RID: 1619 RVA: 0x00009067 File Offset: 0x00007267
		// (set) Token: 0x06000654 RID: 1620 RVA: 0x0000906F File Offset: 0x0000726F
		[global::System.Runtime.Serialization.DataMember(Name = "errors", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Media.PlayerError> Errors { get; private set; }
	}
}
