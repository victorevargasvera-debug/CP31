using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x02000181 RID: 385
	[global::System.Runtime.Serialization.DataContract]
	public class FontSizes : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06000BE7 RID: 3047 RVA: 0x0000DFE7 File Offset: 0x0000C1E7
		// (set) Token: 0x06000BE8 RID: 3048 RVA: 0x0000DFEF File Offset: 0x0000C1EF
		[global::System.Runtime.Serialization.DataMember(Name = "standard", IsRequired = false)]
		public int? Standard { get; set; }

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06000BE9 RID: 3049 RVA: 0x0000DFF8 File Offset: 0x0000C1F8
		// (set) Token: 0x06000BEA RID: 3050 RVA: 0x0000E000 File Offset: 0x0000C200
		[global::System.Runtime.Serialization.DataMember(Name = "fixed", IsRequired = false)]
		public int? Fixed { get; set; }
	}
}
