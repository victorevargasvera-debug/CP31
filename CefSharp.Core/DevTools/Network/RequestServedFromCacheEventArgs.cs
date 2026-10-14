using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x0200021D RID: 541
	[global::System.Runtime.Serialization.DataContract]
	public class RequestServedFromCacheEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x060010A6 RID: 4262 RVA: 0x00012289 File Offset: 0x00010489
		// (set) Token: 0x060010A7 RID: 4263 RVA: 0x00012291 File Offset: 0x00010491
		[global::System.Runtime.Serialization.DataMember(Name = "requestId", IsRequired = true)]
		public string RequestId { get; private set; }
	}
}
