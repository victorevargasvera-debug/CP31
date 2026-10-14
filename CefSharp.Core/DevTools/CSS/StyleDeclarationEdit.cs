using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x02000313 RID: 787
	[global::System.Runtime.Serialization.DataContract]
	public class StyleDeclarationEdit : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x06001834 RID: 6196 RVA: 0x0001A12E File Offset: 0x0001832E
		// (set) Token: 0x06001835 RID: 6197 RVA: 0x0001A136 File Offset: 0x00018336
		[global::System.Runtime.Serialization.DataMember(Name = "styleSheetId", IsRequired = true)]
		public string StyleSheetId { get; set; }

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x06001836 RID: 6198 RVA: 0x0001A13F File Offset: 0x0001833F
		// (set) Token: 0x06001837 RID: 6199 RVA: 0x0001A147 File Offset: 0x00018347
		[global::System.Runtime.Serialization.DataMember(Name = "range", IsRequired = true)]
		public global::CefSharp.DevTools.CSS.SourceRange Range { get; set; }

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x06001838 RID: 6200 RVA: 0x0001A150 File Offset: 0x00018350
		// (set) Token: 0x06001839 RID: 6201 RVA: 0x0001A158 File Offset: 0x00018358
		[global::System.Runtime.Serialization.DataMember(Name = "text", IsRequired = true)]
		public string Text { get; set; }
	}
}
