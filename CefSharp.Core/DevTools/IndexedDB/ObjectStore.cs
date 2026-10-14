using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.IndexedDB
{
	// Token: 0x02000272 RID: 626
	[global::System.Runtime.Serialization.DataContract]
	public class ObjectStore : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06001323 RID: 4899 RVA: 0x0001533A File Offset: 0x0001353A
		// (set) Token: 0x06001324 RID: 4900 RVA: 0x00015342 File Offset: 0x00013542
		[global::System.Runtime.Serialization.DataMember(Name = "name", IsRequired = true)]
		public string Name { get; set; }

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06001325 RID: 4901 RVA: 0x0001534B File Offset: 0x0001354B
		// (set) Token: 0x06001326 RID: 4902 RVA: 0x00015353 File Offset: 0x00013553
		[global::System.Runtime.Serialization.DataMember(Name = "keyPath", IsRequired = true)]
		public global::CefSharp.DevTools.IndexedDB.KeyPath KeyPath { get; set; }

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x06001327 RID: 4903 RVA: 0x0001535C File Offset: 0x0001355C
		// (set) Token: 0x06001328 RID: 4904 RVA: 0x00015364 File Offset: 0x00013564
		[global::System.Runtime.Serialization.DataMember(Name = "autoIncrement", IsRequired = true)]
		public bool AutoIncrement { get; set; }

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x06001329 RID: 4905 RVA: 0x0001536D File Offset: 0x0001356D
		// (set) Token: 0x0600132A RID: 4906 RVA: 0x00015375 File Offset: 0x00013575
		[global::System.Runtime.Serialization.DataMember(Name = "indexes", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.IndexedDB.ObjectStoreIndex> Indexes { get; set; }
	}
}
