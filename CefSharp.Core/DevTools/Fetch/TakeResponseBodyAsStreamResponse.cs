using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Fetch
{
	// Token: 0x020000ED RID: 237
	[global::System.Runtime.Serialization.DataContract]
	public class TakeResponseBodyAsStreamResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x060007C0 RID: 1984 RVA: 0x0000A32E File Offset: 0x0000852E
		// (set) Token: 0x060007C1 RID: 1985 RVA: 0x0000A336 File Offset: 0x00008536
		[global::System.Runtime.Serialization.DataMember]
		internal string stream { get; set; }

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x060007C2 RID: 1986 RVA: 0x0000A33F File Offset: 0x0000853F
		public string Stream
		{
			get
			{
				return this.stream;
			}
		}
	}
}
