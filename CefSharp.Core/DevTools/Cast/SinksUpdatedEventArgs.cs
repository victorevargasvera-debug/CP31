using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Cast
{
	// Token: 0x020002E8 RID: 744
	[global::System.Runtime.Serialization.DataContract]
	public class SinksUpdatedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x060016BD RID: 5821 RVA: 0x00019120 File Offset: 0x00017320
		// (set) Token: 0x060016BE RID: 5822 RVA: 0x00019128 File Offset: 0x00017328
		[global::System.Runtime.Serialization.DataMember(Name = "sinks", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Cast.Sink> Sinks { get; private set; }
	}
}
