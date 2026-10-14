using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Profiler
{
	// Token: 0x02000065 RID: 101
	[global::System.Runtime.Serialization.DataContract]
	public class GetBestEffortCoverageResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x00006950 File Offset: 0x00004B50
		// (set) Token: 0x060003D5 RID: 981 RVA: 0x00006958 File Offset: 0x00004B58
		[global::System.Runtime.Serialization.DataMember]
		internal global::System.Collections.Generic.IList<global::CefSharp.DevTools.Profiler.ScriptCoverage> result { get; set; }

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x00006961 File Offset: 0x00004B61
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Profiler.ScriptCoverage> Result
		{
			get
			{
				return this.result;
			}
		}
	}
}
