using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x0200023B RID: 571
	[global::System.Runtime.Serialization.DataContract]
	public class GetResponseBodyForInterceptionResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06001190 RID: 4496 RVA: 0x00012AF1 File Offset: 0x00010CF1
		// (set) Token: 0x06001191 RID: 4497 RVA: 0x00012AF9 File Offset: 0x00010CF9
		[global::System.Runtime.Serialization.DataMember]
		internal string body { get; set; }

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x06001192 RID: 4498 RVA: 0x00012B02 File Offset: 0x00010D02
		public string Body
		{
			get
			{
				return this.body;
			}
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x06001193 RID: 4499 RVA: 0x00012B0A File Offset: 0x00010D0A
		// (set) Token: 0x06001194 RID: 4500 RVA: 0x00012B12 File Offset: 0x00010D12
		[global::System.Runtime.Serialization.DataMember]
		internal bool base64Encoded { get; set; }

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x06001195 RID: 4501 RVA: 0x00012B1B File Offset: 0x00010D1B
		public bool Base64Encoded
		{
			get
			{
				return this.base64Encoded;
			}
		}
	}
}
