using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Browser
{
	// Token: 0x02000335 RID: 821
	[global::System.Runtime.Serialization.DataContract]
	public class Bucket : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x06001903 RID: 6403 RVA: 0x0001AE2A File Offset: 0x0001902A
		// (set) Token: 0x06001904 RID: 6404 RVA: 0x0001AE32 File Offset: 0x00019032
		[global::System.Runtime.Serialization.DataMember(Name = "low", IsRequired = true)]
		public int Low { get; set; }

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x06001905 RID: 6405 RVA: 0x0001AE3B File Offset: 0x0001903B
		// (set) Token: 0x06001906 RID: 6406 RVA: 0x0001AE43 File Offset: 0x00019043
		[global::System.Runtime.Serialization.DataMember(Name = "high", IsRequired = true)]
		public int High { get; set; }

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x06001907 RID: 6407 RVA: 0x0001AE4C File Offset: 0x0001904C
		// (set) Token: 0x06001908 RID: 6408 RVA: 0x0001AE54 File Offset: 0x00019054
		[global::System.Runtime.Serialization.DataMember(Name = "count", IsRequired = true)]
		public int Count { get; set; }
	}
}
