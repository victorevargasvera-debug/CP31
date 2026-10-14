using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Profiler
{
	// Token: 0x0200005F RID: 95
	[global::System.Runtime.Serialization.DataContract]
	public class CoverageRange : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x000067DD File Offset: 0x000049DD
		// (set) Token: 0x060003A9 RID: 937 RVA: 0x000067E5 File Offset: 0x000049E5
		[global::System.Runtime.Serialization.DataMember(Name = "startOffset", IsRequired = true)]
		public int StartOffset { get; set; }

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060003AA RID: 938 RVA: 0x000067EE File Offset: 0x000049EE
		// (set) Token: 0x060003AB RID: 939 RVA: 0x000067F6 File Offset: 0x000049F6
		[global::System.Runtime.Serialization.DataMember(Name = "endOffset", IsRequired = true)]
		public int EndOffset { get; set; }

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060003AC RID: 940 RVA: 0x000067FF File Offset: 0x000049FF
		// (set) Token: 0x060003AD RID: 941 RVA: 0x00006807 File Offset: 0x00004A07
		[global::System.Runtime.Serialization.DataMember(Name = "count", IsRequired = true)]
		public int Count { get; set; }
	}
}
