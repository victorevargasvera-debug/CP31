using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Profiler
{
	// Token: 0x02000061 RID: 97
	[global::System.Runtime.Serialization.DataContract]
	public class ScriptCoverage : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060003B6 RID: 950 RVA: 0x00006853 File Offset: 0x00004A53
		// (set) Token: 0x060003B7 RID: 951 RVA: 0x0000685B File Offset: 0x00004A5B
		[global::System.Runtime.Serialization.DataMember(Name = "scriptId", IsRequired = true)]
		public string ScriptId { get; set; }

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x00006864 File Offset: 0x00004A64
		// (set) Token: 0x060003B9 RID: 953 RVA: 0x0000686C File Offset: 0x00004A6C
		[global::System.Runtime.Serialization.DataMember(Name = "url", IsRequired = true)]
		public string Url { get; set; }

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060003BA RID: 954 RVA: 0x00006875 File Offset: 0x00004A75
		// (set) Token: 0x060003BB RID: 955 RVA: 0x0000687D File Offset: 0x00004A7D
		[global::System.Runtime.Serialization.DataMember(Name = "functions", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Profiler.FunctionCoverage> Functions { get; set; }
	}
}
