using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x02000301 RID: 769
	[global::System.Runtime.Serialization.DataContract]
	public class CSSStyle : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x06001783 RID: 6019 RVA: 0x00019AC0 File Offset: 0x00017CC0
		// (set) Token: 0x06001784 RID: 6020 RVA: 0x00019AC8 File Offset: 0x00017CC8
		[global::System.Runtime.Serialization.DataMember(Name = "styleSheetId", IsRequired = false)]
		public string StyleSheetId { get; set; }

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x06001785 RID: 6021 RVA: 0x00019AD1 File Offset: 0x00017CD1
		// (set) Token: 0x06001786 RID: 6022 RVA: 0x00019AD9 File Offset: 0x00017CD9
		[global::System.Runtime.Serialization.DataMember(Name = "cssProperties", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.CSS.CSSProperty> CssProperties { get; set; }

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x06001787 RID: 6023 RVA: 0x00019AE2 File Offset: 0x00017CE2
		// (set) Token: 0x06001788 RID: 6024 RVA: 0x00019AEA File Offset: 0x00017CEA
		[global::System.Runtime.Serialization.DataMember(Name = "shorthandEntries", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.CSS.ShorthandEntry> ShorthandEntries { get; set; }

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x06001789 RID: 6025 RVA: 0x00019AF3 File Offset: 0x00017CF3
		// (set) Token: 0x0600178A RID: 6026 RVA: 0x00019AFB File Offset: 0x00017CFB
		[global::System.Runtime.Serialization.DataMember(Name = "cssText", IsRequired = false)]
		public string CssText { get; set; }

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x0600178B RID: 6027 RVA: 0x00019B04 File Offset: 0x00017D04
		// (set) Token: 0x0600178C RID: 6028 RVA: 0x00019B0C File Offset: 0x00017D0C
		[global::System.Runtime.Serialization.DataMember(Name = "range", IsRequired = false)]
		public global::CefSharp.DevTools.CSS.SourceRange Range { get; set; }
	}
}
