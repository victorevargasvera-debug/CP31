using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x02000220 RID: 544
	[global::System.Runtime.Serialization.DataContract]
	public class SignedExchangeReceivedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x060010CD RID: 4301 RVA: 0x0001240F File Offset: 0x0001060F
		// (set) Token: 0x060010CE RID: 4302 RVA: 0x00012417 File Offset: 0x00010617
		[global::System.Runtime.Serialization.DataMember(Name = "requestId", IsRequired = true)]
		public string RequestId { get; private set; }

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x060010CF RID: 4303 RVA: 0x00012420 File Offset: 0x00010620
		// (set) Token: 0x060010D0 RID: 4304 RVA: 0x00012428 File Offset: 0x00010628
		[global::System.Runtime.Serialization.DataMember(Name = "info", IsRequired = true)]
		public global::CefSharp.DevTools.Network.SignedExchangeInfo Info { get; private set; }
	}
}
