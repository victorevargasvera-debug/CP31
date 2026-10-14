using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.WebAudio
{
	// Token: 0x020000E1 RID: 225
	[global::System.Runtime.Serialization.DataContract]
	public class GetRealtimeDataResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170002BE RID: 702
		// (get) Token: 0x0600074D RID: 1869 RVA: 0x00009D14 File Offset: 0x00007F14
		// (set) Token: 0x0600074E RID: 1870 RVA: 0x00009D1C File Offset: 0x00007F1C
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.WebAudio.ContextRealtimeData realtimeData { get; set; }

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x0600074F RID: 1871 RVA: 0x00009D25 File Offset: 0x00007F25
		public global::CefSharp.DevTools.WebAudio.ContextRealtimeData RealtimeData
		{
			get
			{
				return this.realtimeData;
			}
		}
	}
}
