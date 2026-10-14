using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x0200023C RID: 572
	[global::System.Runtime.Serialization.DataContract]
	public class TakeResponseBodyForInterceptionAsStreamResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x06001197 RID: 4503 RVA: 0x00012B2B File Offset: 0x00010D2B
		// (set) Token: 0x06001198 RID: 4504 RVA: 0x00012B33 File Offset: 0x00010D33
		[global::System.Runtime.Serialization.DataMember]
		internal string stream { get; set; }

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x06001199 RID: 4505 RVA: 0x00012B3C File Offset: 0x00010D3C
		public string Stream
		{
			get
			{
				return this.stream;
			}
		}
	}
}
