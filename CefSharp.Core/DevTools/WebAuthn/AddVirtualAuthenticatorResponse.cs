using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.WebAuthn
{
	// Token: 0x020000C6 RID: 198
	[global::System.Runtime.Serialization.DataContract]
	public class AddVirtualAuthenticatorResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000277 RID: 631
		// (get) Token: 0x0600069C RID: 1692 RVA: 0x000093CF File Offset: 0x000075CF
		// (set) Token: 0x0600069D RID: 1693 RVA: 0x000093D7 File Offset: 0x000075D7
		[global::System.Runtime.Serialization.DataMember]
		internal string authenticatorId { get; set; }

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x0600069E RID: 1694 RVA: 0x000093E0 File Offset: 0x000075E0
		public string AuthenticatorId
		{
			get
			{
				return this.authenticatorId;
			}
		}
	}
}
