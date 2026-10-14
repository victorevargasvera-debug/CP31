using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Profiler
{
	// Token: 0x02000060 RID: 96
	[global::System.Runtime.Serialization.DataContract]
	public class FunctionCoverage : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060003AF RID: 943 RVA: 0x00006818 File Offset: 0x00004A18
		// (set) Token: 0x060003B0 RID: 944 RVA: 0x00006820 File Offset: 0x00004A20
		[global::System.Runtime.Serialization.DataMember(Name = "functionName", IsRequired = true)]
		public string FunctionName { get; set; }

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060003B1 RID: 945 RVA: 0x00006829 File Offset: 0x00004A29
		// (set) Token: 0x060003B2 RID: 946 RVA: 0x00006831 File Offset: 0x00004A31
		[global::System.Runtime.Serialization.DataMember(Name = "ranges", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Profiler.CoverageRange> Ranges { get; set; }

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x0000683A File Offset: 0x00004A3A
		// (set) Token: 0x060003B4 RID: 948 RVA: 0x00006842 File Offset: 0x00004A42
		[global::System.Runtime.Serialization.DataMember(Name = "isBlockCoverage", IsRequired = true)]
		public bool IsBlockCoverage { get; set; }
	}
}
