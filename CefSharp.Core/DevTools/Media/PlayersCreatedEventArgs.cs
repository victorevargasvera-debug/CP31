using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Media
{
	// Token: 0x020000BD RID: 189
	[global::System.Runtime.Serialization.DataContract]
	public class PlayersCreatedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000656 RID: 1622 RVA: 0x00009080 File Offset: 0x00007280
		// (set) Token: 0x06000657 RID: 1623 RVA: 0x00009088 File Offset: 0x00007288
		[global::System.Runtime.Serialization.DataMember(Name = "players", IsRequired = true)]
		public string[] Players { get; private set; }
	}
}
