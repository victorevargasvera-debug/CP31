using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.IndexedDB
{
	// Token: 0x02000273 RID: 627
	[global::System.Runtime.Serialization.DataContract]
	public class ObjectStoreIndex : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x0600132C RID: 4908 RVA: 0x00015386 File Offset: 0x00013586
		// (set) Token: 0x0600132D RID: 4909 RVA: 0x0001538E File Offset: 0x0001358E
		[global::System.Runtime.Serialization.DataMember(Name = "name", IsRequired = true)]
		public string Name { get; set; }

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x0600132E RID: 4910 RVA: 0x00015397 File Offset: 0x00013597
		// (set) Token: 0x0600132F RID: 4911 RVA: 0x0001539F File Offset: 0x0001359F
		[global::System.Runtime.Serialization.DataMember(Name = "keyPath", IsRequired = true)]
		public global::CefSharp.DevTools.IndexedDB.KeyPath KeyPath { get; set; }

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06001330 RID: 4912 RVA: 0x000153A8 File Offset: 0x000135A8
		// (set) Token: 0x06001331 RID: 4913 RVA: 0x000153B0 File Offset: 0x000135B0
		[global::System.Runtime.Serialization.DataMember(Name = "unique", IsRequired = true)]
		public bool Unique { get; set; }

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x06001332 RID: 4914 RVA: 0x000153B9 File Offset: 0x000135B9
		// (set) Token: 0x06001333 RID: 4915 RVA: 0x000153C1 File Offset: 0x000135C1
		[global::System.Runtime.Serialization.DataMember(Name = "multiEntry", IsRequired = true)]
		public bool MultiEntry { get; set; }
	}
}
