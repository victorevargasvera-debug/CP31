using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.IndexedDB
{
	// Token: 0x02000276 RID: 630
	[global::System.Runtime.Serialization.DataContract]
	public class KeyRange : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x06001342 RID: 4930 RVA: 0x0001545E File Offset: 0x0001365E
		// (set) Token: 0x06001343 RID: 4931 RVA: 0x00015466 File Offset: 0x00013666
		[global::System.Runtime.Serialization.DataMember(Name = "lower", IsRequired = false)]
		public global::CefSharp.DevTools.IndexedDB.Key Lower { get; set; }

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x06001344 RID: 4932 RVA: 0x0001546F File Offset: 0x0001366F
		// (set) Token: 0x06001345 RID: 4933 RVA: 0x00015477 File Offset: 0x00013677
		[global::System.Runtime.Serialization.DataMember(Name = "upper", IsRequired = false)]
		public global::CefSharp.DevTools.IndexedDB.Key Upper { get; set; }

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x06001346 RID: 4934 RVA: 0x00015480 File Offset: 0x00013680
		// (set) Token: 0x06001347 RID: 4935 RVA: 0x00015488 File Offset: 0x00013688
		[global::System.Runtime.Serialization.DataMember(Name = "lowerOpen", IsRequired = true)]
		public bool LowerOpen { get; set; }

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x06001348 RID: 4936 RVA: 0x00015491 File Offset: 0x00013691
		// (set) Token: 0x06001349 RID: 4937 RVA: 0x00015499 File Offset: 0x00013699
		[global::System.Runtime.Serialization.DataMember(Name = "upperOpen", IsRequired = true)]
		public bool UpperOpen { get; set; }
	}
}
