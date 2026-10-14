using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.WebAuthn
{
	// Token: 0x020000C8 RID: 200
	[global::System.Runtime.Serialization.DataContract]
	public class GetCredentialsResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x1700027B RID: 635
		// (get) Token: 0x060006A4 RID: 1700 RVA: 0x00009411 File Offset: 0x00007611
		// (set) Token: 0x060006A5 RID: 1701 RVA: 0x00009419 File Offset: 0x00007619
		[global::System.Runtime.Serialization.DataMember]
		internal global::System.Collections.Generic.IList<global::CefSharp.DevTools.WebAuthn.Credential> credentials { get; set; }

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x060006A6 RID: 1702 RVA: 0x00009422 File Offset: 0x00007622
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.WebAuthn.Credential> Credentials
		{
			get
			{
				return this.credentials;
			}
		}
	}
}
