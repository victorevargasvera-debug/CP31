using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Fetch
{
	// Token: 0x020000EC RID: 236
	[global::System.Runtime.Serialization.DataContract]
	public class GetResponseBodyResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x060007B9 RID: 1977 RVA: 0x0000A2F4 File Offset: 0x000084F4
		// (set) Token: 0x060007BA RID: 1978 RVA: 0x0000A2FC File Offset: 0x000084FC
		[global::System.Runtime.Serialization.DataMember]
		internal string body { get; set; }

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x060007BB RID: 1979 RVA: 0x0000A305 File Offset: 0x00008505
		public string Body
		{
			get
			{
				return this.body;
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x060007BC RID: 1980 RVA: 0x0000A30D File Offset: 0x0000850D
		// (set) Token: 0x060007BD RID: 1981 RVA: 0x0000A315 File Offset: 0x00008515
		[global::System.Runtime.Serialization.DataMember]
		internal bool base64Encoded { get; set; }

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x060007BE RID: 1982 RVA: 0x0000A31E File Offset: 0x0000851E
		public bool Base64Encoded
		{
			get
			{
				return this.base64Encoded;
			}
		}
	}
}
