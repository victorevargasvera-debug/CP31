using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x02000187 RID: 391
	[global::System.Runtime.Serialization.DataContract]
	public class CompilationCacheParams : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06000BF6 RID: 3062 RVA: 0x0000E065 File Offset: 0x0000C265
		// (set) Token: 0x06000BF7 RID: 3063 RVA: 0x0000E06D File Offset: 0x0000C26D
		[global::System.Runtime.Serialization.DataMember(Name = "url", IsRequired = true)]
		public string Url { get; set; }

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06000BF8 RID: 3064 RVA: 0x0000E076 File Offset: 0x0000C276
		// (set) Token: 0x06000BF9 RID: 3065 RVA: 0x0000E07E File Offset: 0x0000C27E
		[global::System.Runtime.Serialization.DataMember(Name = "eager", IsRequired = false)]
		public bool? Eager { get; set; }
	}
}
