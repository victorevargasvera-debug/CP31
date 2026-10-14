using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x020002F9 RID: 761
	[global::System.Runtime.Serialization.DataContract]
	public class Value : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x0600171D RID: 5917 RVA: 0x00019725 File Offset: 0x00017925
		// (set) Token: 0x0600171E RID: 5918 RVA: 0x0001972D File Offset: 0x0001792D
		[global::System.Runtime.Serialization.DataMember(Name = "text", IsRequired = true)]
		public string Text { get; set; }

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x0600171F RID: 5919 RVA: 0x00019736 File Offset: 0x00017936
		// (set) Token: 0x06001720 RID: 5920 RVA: 0x0001973E File Offset: 0x0001793E
		[global::System.Runtime.Serialization.DataMember(Name = "range", IsRequired = false)]
		public global::CefSharp.DevTools.CSS.SourceRange Range { get; set; }
	}
}
