using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Debugger
{
	// Token: 0x0200007C RID: 124
	[global::System.Runtime.Serialization.DataContract]
	public class SearchMatch : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000478 RID: 1144 RVA: 0x000073D1 File Offset: 0x000055D1
		// (set) Token: 0x06000479 RID: 1145 RVA: 0x000073D9 File Offset: 0x000055D9
		[global::System.Runtime.Serialization.DataMember(Name = "lineNumber", IsRequired = true)]
		public double LineNumber { get; set; }

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x0600047A RID: 1146 RVA: 0x000073E2 File Offset: 0x000055E2
		// (set) Token: 0x0600047B RID: 1147 RVA: 0x000073EA File Offset: 0x000055EA
		[global::System.Runtime.Serialization.DataMember(Name = "lineContent", IsRequired = true)]
		public string LineContent { get; set; }
	}
}
