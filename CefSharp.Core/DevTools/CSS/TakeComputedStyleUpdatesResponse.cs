using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x02000323 RID: 803
	[global::System.Runtime.Serialization.DataContract]
	public class TakeComputedStyleUpdatesResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x06001894 RID: 6292 RVA: 0x0001A44B File Offset: 0x0001864B
		// (set) Token: 0x06001895 RID: 6293 RVA: 0x0001A453 File Offset: 0x00018653
		[global::System.Runtime.Serialization.DataMember]
		internal int[] nodeIds { get; set; }

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x06001896 RID: 6294 RVA: 0x0001A45C File Offset: 0x0001865C
		public int[] NodeIds
		{
			get
			{
				return this.nodeIds;
			}
		}
	}
}
