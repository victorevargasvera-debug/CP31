using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x020001B5 RID: 437
	[global::System.Runtime.Serialization.DataContract]
	public class NavigateResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06000CFF RID: 3327 RVA: 0x0000EA44 File Offset: 0x0000CC44
		// (set) Token: 0x06000D00 RID: 3328 RVA: 0x0000EA4C File Offset: 0x0000CC4C
		[global::System.Runtime.Serialization.DataMember]
		internal string frameId { get; set; }

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06000D01 RID: 3329 RVA: 0x0000EA55 File Offset: 0x0000CC55
		public string FrameId
		{
			get
			{
				return this.frameId;
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06000D02 RID: 3330 RVA: 0x0000EA5D File Offset: 0x0000CC5D
		// (set) Token: 0x06000D03 RID: 3331 RVA: 0x0000EA65 File Offset: 0x0000CC65
		[global::System.Runtime.Serialization.DataMember]
		internal string loaderId { get; set; }

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06000D04 RID: 3332 RVA: 0x0000EA6E File Offset: 0x0000CC6E
		public string LoaderId
		{
			get
			{
				return this.loaderId;
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06000D05 RID: 3333 RVA: 0x0000EA76 File Offset: 0x0000CC76
		// (set) Token: 0x06000D06 RID: 3334 RVA: 0x0000EA7E File Offset: 0x0000CC7E
		[global::System.Runtime.Serialization.DataMember]
		internal string errorText { get; set; }

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06000D07 RID: 3335 RVA: 0x0000EA87 File Offset: 0x0000CC87
		public string ErrorText
		{
			get
			{
				return this.errorText;
			}
		}
	}
}
