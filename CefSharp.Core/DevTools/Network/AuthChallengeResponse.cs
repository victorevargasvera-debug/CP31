using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x02000201 RID: 513
	[global::System.Runtime.Serialization.DataContract]
	public class AuthChallengeResponse : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06000FBC RID: 4028 RVA: 0x0001190C File Offset: 0x0000FB0C
		// (set) Token: 0x06000FBD RID: 4029 RVA: 0x00011928 File Offset: 0x0000FB28
		public global::CefSharp.DevTools.Network.AuthChallengeResponseResponse Response
		{
			get
			{
				return (global::CefSharp.DevTools.Network.AuthChallengeResponseResponse)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Network.AuthChallengeResponseResponse), this.response);
			}
			set
			{
				this.response = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06000FBE RID: 4030 RVA: 0x0001193B File Offset: 0x0000FB3B
		// (set) Token: 0x06000FBF RID: 4031 RVA: 0x00011943 File Offset: 0x0000FB43
		[global::System.Runtime.Serialization.DataMember(Name = "response", IsRequired = true)]
		internal string response { get; set; }

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06000FC0 RID: 4032 RVA: 0x0001194C File Offset: 0x0000FB4C
		// (set) Token: 0x06000FC1 RID: 4033 RVA: 0x00011954 File Offset: 0x0000FB54
		[global::System.Runtime.Serialization.DataMember(Name = "username", IsRequired = false)]
		public string Username { get; set; }

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06000FC2 RID: 4034 RVA: 0x0001195D File Offset: 0x0000FB5D
		// (set) Token: 0x06000FC3 RID: 4035 RVA: 0x00011965 File Offset: 0x0000FB65
		[global::System.Runtime.Serialization.DataMember(Name = "password", IsRequired = false)]
		public string Password { get; set; }
	}
}
