using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Input
{
	// Token: 0x02000268 RID: 616
	[global::System.Runtime.Serialization.DataContract]
	public class DragData : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x06001303 RID: 4867 RVA: 0x0001486F File Offset: 0x00012A6F
		// (set) Token: 0x06001304 RID: 4868 RVA: 0x00014877 File Offset: 0x00012A77
		[global::System.Runtime.Serialization.DataMember(Name = "items", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Input.DragDataItem> Items { get; set; }

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x06001305 RID: 4869 RVA: 0x00014880 File Offset: 0x00012A80
		// (set) Token: 0x06001306 RID: 4870 RVA: 0x00014888 File Offset: 0x00012A88
		[global::System.Runtime.Serialization.DataMember(Name = "files", IsRequired = false)]
		public string[] Files { get; set; }

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x06001307 RID: 4871 RVA: 0x00014891 File Offset: 0x00012A91
		// (set) Token: 0x06001308 RID: 4872 RVA: 0x00014899 File Offset: 0x00012A99
		[global::System.Runtime.Serialization.DataMember(Name = "dragOperationsMask", IsRequired = true)]
		public int DragOperationsMask { get; set; }
	}
}
