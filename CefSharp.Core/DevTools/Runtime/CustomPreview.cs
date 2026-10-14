using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Runtime
{
	// Token: 0x02000037 RID: 55
	[global::System.Runtime.Serialization.DataContract]
	public class CustomPreview : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000260 RID: 608 RVA: 0x00005322 File Offset: 0x00003522
		// (set) Token: 0x06000261 RID: 609 RVA: 0x0000532A File Offset: 0x0000352A
		[global::System.Runtime.Serialization.DataMember(Name = "header", IsRequired = true)]
		public string Header { get; set; }

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000262 RID: 610 RVA: 0x00005333 File Offset: 0x00003533
		// (set) Token: 0x06000263 RID: 611 RVA: 0x0000533B File Offset: 0x0000353B
		[global::System.Runtime.Serialization.DataMember(Name = "bodyGetterId", IsRequired = false)]
		public string BodyGetterId { get; set; }
	}
}
