using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.IndexedDB
{
	// Token: 0x02000271 RID: 625
	[global::System.Runtime.Serialization.DataContract]
	public class DatabaseWithObjectStores : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x0600131C RID: 4892 RVA: 0x000152FF File Offset: 0x000134FF
		// (set) Token: 0x0600131D RID: 4893 RVA: 0x00015307 File Offset: 0x00013507
		[global::System.Runtime.Serialization.DataMember(Name = "name", IsRequired = true)]
		public string Name { get; set; }

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x0600131E RID: 4894 RVA: 0x00015310 File Offset: 0x00013510
		// (set) Token: 0x0600131F RID: 4895 RVA: 0x00015318 File Offset: 0x00013518
		[global::System.Runtime.Serialization.DataMember(Name = "version", IsRequired = true)]
		public double Version { get; set; }

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06001320 RID: 4896 RVA: 0x00015321 File Offset: 0x00013521
		// (set) Token: 0x06001321 RID: 4897 RVA: 0x00015329 File Offset: 0x00013529
		[global::System.Runtime.Serialization.DataMember(Name = "objectStores", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.IndexedDB.ObjectStore> ObjectStores { get; set; }
	}
}
