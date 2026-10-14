using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x0200030E RID: 782
	[global::System.Runtime.Serialization.DataContract]
	public class FontFace : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x06001801 RID: 6145 RVA: 0x00019F43 File Offset: 0x00018143
		// (set) Token: 0x06001802 RID: 6146 RVA: 0x00019F4B File Offset: 0x0001814B
		[global::System.Runtime.Serialization.DataMember(Name = "fontFamily", IsRequired = true)]
		public string FontFamily { get; set; }

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x06001803 RID: 6147 RVA: 0x00019F54 File Offset: 0x00018154
		// (set) Token: 0x06001804 RID: 6148 RVA: 0x00019F5C File Offset: 0x0001815C
		[global::System.Runtime.Serialization.DataMember(Name = "fontStyle", IsRequired = true)]
		public string FontStyle { get; set; }

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x06001805 RID: 6149 RVA: 0x00019F65 File Offset: 0x00018165
		// (set) Token: 0x06001806 RID: 6150 RVA: 0x00019F6D File Offset: 0x0001816D
		[global::System.Runtime.Serialization.DataMember(Name = "fontVariant", IsRequired = true)]
		public string FontVariant { get; set; }

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x06001807 RID: 6151 RVA: 0x00019F76 File Offset: 0x00018176
		// (set) Token: 0x06001808 RID: 6152 RVA: 0x00019F7E File Offset: 0x0001817E
		[global::System.Runtime.Serialization.DataMember(Name = "fontWeight", IsRequired = true)]
		public string FontWeight { get; set; }

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x06001809 RID: 6153 RVA: 0x00019F87 File Offset: 0x00018187
		// (set) Token: 0x0600180A RID: 6154 RVA: 0x00019F8F File Offset: 0x0001818F
		[global::System.Runtime.Serialization.DataMember(Name = "fontStretch", IsRequired = true)]
		public string FontStretch { get; set; }

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x0600180B RID: 6155 RVA: 0x00019F98 File Offset: 0x00018198
		// (set) Token: 0x0600180C RID: 6156 RVA: 0x00019FA0 File Offset: 0x000181A0
		[global::System.Runtime.Serialization.DataMember(Name = "fontDisplay", IsRequired = true)]
		public string FontDisplay { get; set; }

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x0600180D RID: 6157 RVA: 0x00019FA9 File Offset: 0x000181A9
		// (set) Token: 0x0600180E RID: 6158 RVA: 0x00019FB1 File Offset: 0x000181B1
		[global::System.Runtime.Serialization.DataMember(Name = "unicodeRange", IsRequired = true)]
		public string UnicodeRange { get; set; }

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x0600180F RID: 6159 RVA: 0x00019FBA File Offset: 0x000181BA
		// (set) Token: 0x06001810 RID: 6160 RVA: 0x00019FC2 File Offset: 0x000181C2
		[global::System.Runtime.Serialization.DataMember(Name = "src", IsRequired = true)]
		public string Src { get; set; }

		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x06001811 RID: 6161 RVA: 0x00019FCB File Offset: 0x000181CB
		// (set) Token: 0x06001812 RID: 6162 RVA: 0x00019FD3 File Offset: 0x000181D3
		[global::System.Runtime.Serialization.DataMember(Name = "platformFontFamily", IsRequired = true)]
		public string PlatformFontFamily { get; set; }

		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x06001813 RID: 6163 RVA: 0x00019FDC File Offset: 0x000181DC
		// (set) Token: 0x06001814 RID: 6164 RVA: 0x00019FE4 File Offset: 0x000181E4
		[global::System.Runtime.Serialization.DataMember(Name = "fontVariationAxes", IsRequired = false)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.CSS.FontVariationAxis> FontVariationAxes { get; set; }
	}
}
