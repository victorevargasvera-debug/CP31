using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x020001A9 RID: 425
	[global::System.Runtime.Serialization.DataContract]
	public class CaptureScreenshotResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06000CAE RID: 3246 RVA: 0x0000E79F File Offset: 0x0000C99F
		// (set) Token: 0x06000CAF RID: 3247 RVA: 0x0000E7A7 File Offset: 0x0000C9A7
		[global::System.Runtime.Serialization.DataMember]
		internal string data { get; set; }

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06000CB0 RID: 3248 RVA: 0x0000E7B0 File Offset: 0x0000C9B0
		public byte[] Data
		{
			get
			{
				return base.Convert(this.data);
			}
		}
	}
}
