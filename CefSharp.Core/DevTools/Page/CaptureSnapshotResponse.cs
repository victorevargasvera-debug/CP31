using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x020001AA RID: 426
	[global::System.Runtime.Serialization.DataContract]
	public class CaptureSnapshotResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06000CB2 RID: 3250 RVA: 0x0000E7C6 File Offset: 0x0000C9C6
		// (set) Token: 0x06000CB3 RID: 3251 RVA: 0x0000E7CE File Offset: 0x0000C9CE
		[global::System.Runtime.Serialization.DataMember]
		internal string data { get; set; }

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06000CB4 RID: 3252 RVA: 0x0000E7D7 File Offset: 0x0000C9D7
		public string Data
		{
			get
			{
				return this.data;
			}
		}
	}
}
