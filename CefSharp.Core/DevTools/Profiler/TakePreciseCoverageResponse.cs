using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Profiler
{
	// Token: 0x02000068 RID: 104
	[global::System.Runtime.Serialization.DataContract]
	public class TakePreciseCoverageResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x000069B3 File Offset: 0x00004BB3
		// (set) Token: 0x060003E1 RID: 993 RVA: 0x000069BB File Offset: 0x00004BBB
		[global::System.Runtime.Serialization.DataMember]
		internal global::System.Collections.Generic.IList<global::CefSharp.DevTools.Profiler.ScriptCoverage> result { get; set; }

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x000069C4 File Offset: 0x00004BC4
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Profiler.ScriptCoverage> Result
		{
			get
			{
				return this.result;
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x000069CC File Offset: 0x00004BCC
		// (set) Token: 0x060003E4 RID: 996 RVA: 0x000069D4 File Offset: 0x00004BD4
		[global::System.Runtime.Serialization.DataMember]
		internal double timestamp { get; set; }

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060003E5 RID: 997 RVA: 0x000069DD File Offset: 0x00004BDD
		public double Timestamp
		{
			get
			{
				return this.timestamp;
			}
		}
	}
}
