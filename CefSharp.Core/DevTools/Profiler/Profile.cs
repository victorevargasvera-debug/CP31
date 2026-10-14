using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Profiler
{
	// Token: 0x0200005D RID: 93
	[global::System.Runtime.Serialization.DataContract]
	public class Profile : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000398 RID: 920 RVA: 0x00006756 File Offset: 0x00004956
		// (set) Token: 0x06000399 RID: 921 RVA: 0x0000675E File Offset: 0x0000495E
		[global::System.Runtime.Serialization.DataMember(Name = "nodes", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Profiler.ProfileNode> Nodes { get; set; }

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x0600039A RID: 922 RVA: 0x00006767 File Offset: 0x00004967
		// (set) Token: 0x0600039B RID: 923 RVA: 0x0000676F File Offset: 0x0000496F
		[global::System.Runtime.Serialization.DataMember(Name = "startTime", IsRequired = true)]
		public double StartTime { get; set; }

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x0600039C RID: 924 RVA: 0x00006778 File Offset: 0x00004978
		// (set) Token: 0x0600039D RID: 925 RVA: 0x00006780 File Offset: 0x00004980
		[global::System.Runtime.Serialization.DataMember(Name = "endTime", IsRequired = true)]
		public double EndTime { get; set; }

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x0600039E RID: 926 RVA: 0x00006789 File Offset: 0x00004989
		// (set) Token: 0x0600039F RID: 927 RVA: 0x00006791 File Offset: 0x00004991
		[global::System.Runtime.Serialization.DataMember(Name = "samples", IsRequired = false)]
		public int[] Samples { get; set; }

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x0000679A File Offset: 0x0000499A
		// (set) Token: 0x060003A1 RID: 929 RVA: 0x000067A2 File Offset: 0x000049A2
		[global::System.Runtime.Serialization.DataMember(Name = "timeDeltas", IsRequired = false)]
		public int[] TimeDeltas { get; set; }
	}
}
