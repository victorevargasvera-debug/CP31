using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.WebAuthn
{
	// Token: 0x020000C7 RID: 199
	[global::System.Runtime.Serialization.DataContract]
	public class GetCredentialResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000279 RID: 633
		// (get) Token: 0x060006A0 RID: 1696 RVA: 0x000093F0 File Offset: 0x000075F0
		// (set) Token: 0x060006A1 RID: 1697 RVA: 0x000093F8 File Offset: 0x000075F8
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.WebAuthn.Credential credential { get; set; }

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x060006A2 RID: 1698 RVA: 0x00009401 File Offset: 0x00007601
		public global::CefSharp.DevTools.WebAuthn.Credential Credential
		{
			get
			{
				return this.credential;
			}
		}
	}
}
