using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOM
{
	// Token: 0x020002B8 RID: 696
	[global::System.Runtime.Serialization.DataContract]
	public class RGBA : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x0600157F RID: 5503 RVA: 0x00017867 File Offset: 0x00015A67
		// (set) Token: 0x06001580 RID: 5504 RVA: 0x0001786F File Offset: 0x00015A6F
		[global::System.Runtime.Serialization.DataMember(Name = "r", IsRequired = true)]
		public int R { get; set; }

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x06001581 RID: 5505 RVA: 0x00017878 File Offset: 0x00015A78
		// (set) Token: 0x06001582 RID: 5506 RVA: 0x00017880 File Offset: 0x00015A80
		[global::System.Runtime.Serialization.DataMember(Name = "g", IsRequired = true)]
		public int G { get; set; }

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x06001583 RID: 5507 RVA: 0x00017889 File Offset: 0x00015A89
		// (set) Token: 0x06001584 RID: 5508 RVA: 0x00017891 File Offset: 0x00015A91
		[global::System.Runtime.Serialization.DataMember(Name = "b", IsRequired = true)]
		public int B { get; set; }

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x06001585 RID: 5509 RVA: 0x0001789A File Offset: 0x00015A9A
		// (set) Token: 0x06001586 RID: 5510 RVA: 0x000178A2 File Offset: 0x00015AA2
		[global::System.Runtime.Serialization.DataMember(Name = "a", IsRequired = false)]
		public double? A { get; set; }
	}
}
