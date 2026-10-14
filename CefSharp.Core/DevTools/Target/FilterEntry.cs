using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Target
{
	// Token: 0x02000100 RID: 256
	[global::System.Runtime.Serialization.DataContract]
	public class FilterEntry : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000835 RID: 2101 RVA: 0x0000AD87 File Offset: 0x00008F87
		// (set) Token: 0x06000836 RID: 2102 RVA: 0x0000AD8F File Offset: 0x00008F8F
		[global::System.Runtime.Serialization.DataMember(Name = "exclude", IsRequired = false)]
		public bool? Exclude { get; set; }

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000837 RID: 2103 RVA: 0x0000AD98 File Offset: 0x00008F98
		// (set) Token: 0x06000838 RID: 2104 RVA: 0x0000ADA0 File Offset: 0x00008FA0
		[global::System.Runtime.Serialization.DataMember(Name = "type", IsRequired = false)]
		public string Type { get; set; }
	}
}
