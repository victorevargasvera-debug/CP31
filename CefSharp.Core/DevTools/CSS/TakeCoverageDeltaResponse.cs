using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x0200032D RID: 813
	[global::System.Runtime.Serialization.DataContract]
	public class TakeCoverageDeltaResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x060018BC RID: 6332 RVA: 0x0001A595 File Offset: 0x00018795
		// (set) Token: 0x060018BD RID: 6333 RVA: 0x0001A59D File Offset: 0x0001879D
		[global::System.Runtime.Serialization.DataMember]
		internal global::System.Collections.Generic.IList<global::CefSharp.DevTools.CSS.RuleUsage> coverage { get; set; }

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x060018BE RID: 6334 RVA: 0x0001A5A6 File Offset: 0x000187A6
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.CSS.RuleUsage> Coverage
		{
			get
			{
				return this.coverage;
			}
		}

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x060018BF RID: 6335 RVA: 0x0001A5AE File Offset: 0x000187AE
		// (set) Token: 0x060018C0 RID: 6336 RVA: 0x0001A5B6 File Offset: 0x000187B6
		[global::System.Runtime.Serialization.DataMember]
		internal double timestamp { get; set; }

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x060018C1 RID: 6337 RVA: 0x0001A5BF File Offset: 0x000187BF
		public double Timestamp
		{
			get
			{
				return this.timestamp;
			}
		}
	}
}
