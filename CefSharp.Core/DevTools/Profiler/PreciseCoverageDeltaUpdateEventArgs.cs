using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Profiler
{
	// Token: 0x02000064 RID: 100
	[global::System.Runtime.Serialization.DataContract]
	public class PreciseCoverageDeltaUpdateEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060003CD RID: 973 RVA: 0x00006915 File Offset: 0x00004B15
		// (set) Token: 0x060003CE RID: 974 RVA: 0x0000691D File Offset: 0x00004B1D
		[global::System.Runtime.Serialization.DataMember(Name = "timestamp", IsRequired = true)]
		public double Timestamp { get; private set; }

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060003CF RID: 975 RVA: 0x00006926 File Offset: 0x00004B26
		// (set) Token: 0x060003D0 RID: 976 RVA: 0x0000692E File Offset: 0x00004B2E
		[global::System.Runtime.Serialization.DataMember(Name = "occasion", IsRequired = true)]
		public string Occasion { get; private set; }

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060003D1 RID: 977 RVA: 0x00006937 File Offset: 0x00004B37
		// (set) Token: 0x060003D2 RID: 978 RVA: 0x0000693F File Offset: 0x00004B3F
		[global::System.Runtime.Serialization.DataMember(Name = "result", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Profiler.ScriptCoverage> Result { get; private set; }
	}
}
