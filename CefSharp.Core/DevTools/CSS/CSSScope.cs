using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x02000309 RID: 777
	[global::System.Runtime.Serialization.DataContract]
	public class CSSScope : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x060017DA RID: 6106 RVA: 0x00019DFA File Offset: 0x00017FFA
		// (set) Token: 0x060017DB RID: 6107 RVA: 0x00019E02 File Offset: 0x00018002
		[global::System.Runtime.Serialization.DataMember(Name = "text", IsRequired = true)]
		public string Text { get; set; }

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x060017DC RID: 6108 RVA: 0x00019E0B File Offset: 0x0001800B
		// (set) Token: 0x060017DD RID: 6109 RVA: 0x00019E13 File Offset: 0x00018013
		[global::System.Runtime.Serialization.DataMember(Name = "range", IsRequired = false)]
		public global::CefSharp.DevTools.CSS.SourceRange Range { get; set; }

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x060017DE RID: 6110 RVA: 0x00019E1C File Offset: 0x0001801C
		// (set) Token: 0x060017DF RID: 6111 RVA: 0x00019E24 File Offset: 0x00018024
		[global::System.Runtime.Serialization.DataMember(Name = "styleSheetId", IsRequired = false)]
		public string StyleSheetId { get; set; }
	}
}
