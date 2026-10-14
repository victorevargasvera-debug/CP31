using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x02000308 RID: 776
	[global::System.Runtime.Serialization.DataContract]
	public class CSSSupports : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x060017D1 RID: 6097 RVA: 0x00019DAE File Offset: 0x00017FAE
		// (set) Token: 0x060017D2 RID: 6098 RVA: 0x00019DB6 File Offset: 0x00017FB6
		[global::System.Runtime.Serialization.DataMember(Name = "text", IsRequired = true)]
		public string Text { get; set; }

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x060017D3 RID: 6099 RVA: 0x00019DBF File Offset: 0x00017FBF
		// (set) Token: 0x060017D4 RID: 6100 RVA: 0x00019DC7 File Offset: 0x00017FC7
		[global::System.Runtime.Serialization.DataMember(Name = "active", IsRequired = true)]
		public bool Active { get; set; }

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x060017D5 RID: 6101 RVA: 0x00019DD0 File Offset: 0x00017FD0
		// (set) Token: 0x060017D6 RID: 6102 RVA: 0x00019DD8 File Offset: 0x00017FD8
		[global::System.Runtime.Serialization.DataMember(Name = "range", IsRequired = false)]
		public global::CefSharp.DevTools.CSS.SourceRange Range { get; set; }

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x060017D7 RID: 6103 RVA: 0x00019DE1 File Offset: 0x00017FE1
		// (set) Token: 0x060017D8 RID: 6104 RVA: 0x00019DE9 File Offset: 0x00017FE9
		[global::System.Runtime.Serialization.DataMember(Name = "styleSheetId", IsRequired = false)]
		public string StyleSheetId { get; set; }
	}
}
