using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x020001AE RID: 430
	[global::System.Runtime.Serialization.DataContract]
	public class GetAppIdResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06000CCB RID: 3275 RVA: 0x0000E895 File Offset: 0x0000CA95
		// (set) Token: 0x06000CCC RID: 3276 RVA: 0x0000E89D File Offset: 0x0000CA9D
		[global::System.Runtime.Serialization.DataMember]
		internal string appId { get; set; }

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06000CCD RID: 3277 RVA: 0x0000E8A6 File Offset: 0x0000CAA6
		public string AppId
		{
			get
			{
				return this.appId;
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06000CCE RID: 3278 RVA: 0x0000E8AE File Offset: 0x0000CAAE
		// (set) Token: 0x06000CCF RID: 3279 RVA: 0x0000E8B6 File Offset: 0x0000CAB6
		[global::System.Runtime.Serialization.DataMember]
		internal string recommendedId { get; set; }

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06000CD0 RID: 3280 RVA: 0x0000E8BF File Offset: 0x0000CABF
		public string RecommendedId
		{
			get
			{
				return this.recommendedId;
			}
		}
	}
}
