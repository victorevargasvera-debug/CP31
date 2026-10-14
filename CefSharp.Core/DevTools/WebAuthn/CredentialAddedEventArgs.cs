using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.WebAuthn
{
	// Token: 0x020000C4 RID: 196
	[global::System.Runtime.Serialization.DataContract]
	public class CredentialAddedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000692 RID: 1682 RVA: 0x0000937B File Offset: 0x0000757B
		// (set) Token: 0x06000693 RID: 1683 RVA: 0x00009383 File Offset: 0x00007583
		[global::System.Runtime.Serialization.DataMember(Name = "authenticatorId", IsRequired = true)]
		public string AuthenticatorId { get; private set; }

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000694 RID: 1684 RVA: 0x0000938C File Offset: 0x0000758C
		// (set) Token: 0x06000695 RID: 1685 RVA: 0x00009394 File Offset: 0x00007594
		[global::System.Runtime.Serialization.DataMember(Name = "credential", IsRequired = true)]
		public global::CefSharp.DevTools.WebAuthn.Credential Credential { get; private set; }
	}
}
