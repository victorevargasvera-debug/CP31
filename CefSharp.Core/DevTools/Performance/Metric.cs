using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Performance
{
	// Token: 0x0200015C RID: 348
	[global::System.Runtime.Serialization.DataContract]
	public class Metric : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06000AF3 RID: 2803 RVA: 0x0000D5E4 File Offset: 0x0000B7E4
		// (set) Token: 0x06000AF4 RID: 2804 RVA: 0x0000D5EC File Offset: 0x0000B7EC
		[global::System.Runtime.Serialization.DataMember(Name = "name", IsRequired = true)]
		public string Name { get; set; }

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06000AF5 RID: 2805 RVA: 0x0000D5F5 File Offset: 0x0000B7F5
		// (set) Token: 0x06000AF6 RID: 2806 RVA: 0x0000D5FD File Offset: 0x0000B7FD
		[global::System.Runtime.Serialization.DataMember(Name = "value", IsRequired = true)]
		public double Value { get; set; }
	}
}
