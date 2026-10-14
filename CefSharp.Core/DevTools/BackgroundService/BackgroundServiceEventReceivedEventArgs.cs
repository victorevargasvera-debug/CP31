using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.BackgroundService
{
	// Token: 0x02000346 RID: 838
	[global::System.Runtime.Serialization.DataContract]
	public class BackgroundServiceEventReceivedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x06001983 RID: 6531 RVA: 0x0001B6BD File Offset: 0x000198BD
		// (set) Token: 0x06001984 RID: 6532 RVA: 0x0001B6C5 File Offset: 0x000198C5
		[global::System.Runtime.Serialization.DataMember(Name = "backgroundServiceEvent", IsRequired = true)]
		public global::CefSharp.DevTools.BackgroundService.BackgroundServiceEvent BackgroundServiceEvent { get; private set; }
	}
}
