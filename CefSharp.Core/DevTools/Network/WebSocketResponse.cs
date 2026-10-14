using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x020001F3 RID: 499
	[global::System.Runtime.Serialization.DataContract]
	public class WebSocketResponse : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06000F29 RID: 3881 RVA: 0x000112EF File Offset: 0x0000F4EF
		// (set) Token: 0x06000F2A RID: 3882 RVA: 0x000112F7 File Offset: 0x0000F4F7
		[global::System.Runtime.Serialization.DataMember(Name = "status", IsRequired = true)]
		public int Status { get; set; }

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06000F2B RID: 3883 RVA: 0x00011300 File Offset: 0x0000F500
		// (set) Token: 0x06000F2C RID: 3884 RVA: 0x00011308 File Offset: 0x0000F508
		[global::System.Runtime.Serialization.DataMember(Name = "statusText", IsRequired = true)]
		public string StatusText { get; set; }

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06000F2D RID: 3885 RVA: 0x00011311 File Offset: 0x0000F511
		// (set) Token: 0x06000F2E RID: 3886 RVA: 0x00011319 File Offset: 0x0000F519
		[global::System.Runtime.Serialization.DataMember(Name = "headers", IsRequired = true)]
		public global::CefSharp.DevTools.Network.Headers Headers { get; set; }

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06000F2F RID: 3887 RVA: 0x00011322 File Offset: 0x0000F522
		// (set) Token: 0x06000F30 RID: 3888 RVA: 0x0001132A File Offset: 0x0000F52A
		[global::System.Runtime.Serialization.DataMember(Name = "headersText", IsRequired = false)]
		public string HeadersText { get; set; }

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06000F31 RID: 3889 RVA: 0x00011333 File Offset: 0x0000F533
		// (set) Token: 0x06000F32 RID: 3890 RVA: 0x0001133B File Offset: 0x0000F53B
		[global::System.Runtime.Serialization.DataMember(Name = "requestHeaders", IsRequired = false)]
		public global::CefSharp.DevTools.Network.Headers RequestHeaders { get; set; }

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06000F33 RID: 3891 RVA: 0x00011344 File Offset: 0x0000F544
		// (set) Token: 0x06000F34 RID: 3892 RVA: 0x0001134C File Offset: 0x0000F54C
		[global::System.Runtime.Serialization.DataMember(Name = "requestHeadersText", IsRequired = false)]
		public string RequestHeadersText { get; set; }
	}
}
