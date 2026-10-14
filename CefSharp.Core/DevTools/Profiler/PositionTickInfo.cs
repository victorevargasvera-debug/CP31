using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Profiler
{
	// Token: 0x0200005E RID: 94
	[global::System.Runtime.Serialization.DataContract]
	public class PositionTickInfo : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x000067B3 File Offset: 0x000049B3
		// (set) Token: 0x060003A4 RID: 932 RVA: 0x000067BB File Offset: 0x000049BB
		[global::System.Runtime.Serialization.DataMember(Name = "line", IsRequired = true)]
		public int Line { get; set; }

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060003A5 RID: 933 RVA: 0x000067C4 File Offset: 0x000049C4
		// (set) Token: 0x060003A6 RID: 934 RVA: 0x000067CC File Offset: 0x000049CC
		[global::System.Runtime.Serialization.DataMember(Name = "ticks", IsRequired = true)]
		public int Ticks { get; set; }
	}
}
