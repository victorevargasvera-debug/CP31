using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x02000239 RID: 569
	[global::System.Runtime.Serialization.DataContract]
	public class GetResponseBodyResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x06001185 RID: 4485 RVA: 0x00012A96 File Offset: 0x00010C96
		// (set) Token: 0x06001186 RID: 4486 RVA: 0x00012A9E File Offset: 0x00010C9E
		[global::System.Runtime.Serialization.DataMember]
		internal string body { get; set; }

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x06001187 RID: 4487 RVA: 0x00012AA7 File Offset: 0x00010CA7
		public string Body
		{
			get
			{
				return this.body;
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06001188 RID: 4488 RVA: 0x00012AAF File Offset: 0x00010CAF
		// (set) Token: 0x06001189 RID: 4489 RVA: 0x00012AB7 File Offset: 0x00010CB7
		[global::System.Runtime.Serialization.DataMember]
		internal bool base64Encoded { get; set; }

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x0600118A RID: 4490 RVA: 0x00012AC0 File Offset: 0x00010CC0
		public bool Base64Encoded
		{
			get
			{
				return this.base64Encoded;
			}
		}
	}
}
