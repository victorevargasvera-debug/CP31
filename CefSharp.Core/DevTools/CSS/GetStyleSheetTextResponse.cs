using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x02000321 RID: 801
	[global::System.Runtime.Serialization.DataContract]
	public class GetStyleSheetTextResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x0600188C RID: 6284 RVA: 0x0001A409 File Offset: 0x00018609
		// (set) Token: 0x0600188D RID: 6285 RVA: 0x0001A411 File Offset: 0x00018611
		[global::System.Runtime.Serialization.DataMember]
		internal string text { get; set; }

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x0600188E RID: 6286 RVA: 0x0001A41A File Offset: 0x0001861A
		public string Text
		{
			get
			{
				return this.text;
			}
		}
	}
}
