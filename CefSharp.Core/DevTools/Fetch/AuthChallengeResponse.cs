using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Fetch
{
	// Token: 0x020000E9 RID: 233
	[global::System.Runtime.Serialization.DataContract]
	public class AuthChallengeResponse : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170002CC RID: 716
		// (get) Token: 0x0600078A RID: 1930 RVA: 0x0000A0EE File Offset: 0x000082EE
		// (set) Token: 0x0600078B RID: 1931 RVA: 0x0000A10A File Offset: 0x0000830A
		public global::CefSharp.DevTools.Fetch.AuthChallengeResponseResponse Response
		{
			get
			{
				return (global::CefSharp.DevTools.Fetch.AuthChallengeResponseResponse)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Fetch.AuthChallengeResponseResponse), this.response);
			}
			set
			{
				this.response = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x0600078C RID: 1932 RVA: 0x0000A11D File Offset: 0x0000831D
		// (set) Token: 0x0600078D RID: 1933 RVA: 0x0000A125 File Offset: 0x00008325
		[global::System.Runtime.Serialization.DataMember(Name = "response", IsRequired = true)]
		internal string response { get; set; }

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x0600078E RID: 1934 RVA: 0x0000A12E File Offset: 0x0000832E
		// (set) Token: 0x0600078F RID: 1935 RVA: 0x0000A136 File Offset: 0x00008336
		[global::System.Runtime.Serialization.DataMember(Name = "username", IsRequired = false)]
		public string Username { get; set; }

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000790 RID: 1936 RVA: 0x0000A13F File Offset: 0x0000833F
		// (set) Token: 0x06000791 RID: 1937 RVA: 0x0000A147 File Offset: 0x00008347
		[global::System.Runtime.Serialization.DataMember(Name = "password", IsRequired = false)]
		public string Password { get; set; }
	}
}
