using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.WebAuthn
{
	// Token: 0x020000C5 RID: 197
	[global::System.Runtime.Serialization.DataContract]
	public class CredentialAssertedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000697 RID: 1687 RVA: 0x000093A5 File Offset: 0x000075A5
		// (set) Token: 0x06000698 RID: 1688 RVA: 0x000093AD File Offset: 0x000075AD
		[global::System.Runtime.Serialization.DataMember(Name = "authenticatorId", IsRequired = true)]
		public string AuthenticatorId { get; private set; }

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000699 RID: 1689 RVA: 0x000093B6 File Offset: 0x000075B6
		// (set) Token: 0x0600069A RID: 1690 RVA: 0x000093BE File Offset: 0x000075BE
		[global::System.Runtime.Serialization.DataMember(Name = "credential", IsRequired = true)]
		public global::CefSharp.DevTools.WebAuthn.Credential Credential { get; private set; }
	}
}
