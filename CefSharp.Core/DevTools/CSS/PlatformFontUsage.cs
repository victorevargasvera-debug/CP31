using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x0200030C RID: 780
	[global::System.Runtime.Serialization.DataContract]
	public class PlatformFontUsage : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x060017EF RID: 6127 RVA: 0x00019EAB File Offset: 0x000180AB
		// (set) Token: 0x060017F0 RID: 6128 RVA: 0x00019EB3 File Offset: 0x000180B3
		[global::System.Runtime.Serialization.DataMember(Name = "familyName", IsRequired = true)]
		public string FamilyName { get; set; }

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x060017F1 RID: 6129 RVA: 0x00019EBC File Offset: 0x000180BC
		// (set) Token: 0x060017F2 RID: 6130 RVA: 0x00019EC4 File Offset: 0x000180C4
		[global::System.Runtime.Serialization.DataMember(Name = "isCustomFont", IsRequired = true)]
		public bool IsCustomFont { get; set; }

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x060017F3 RID: 6131 RVA: 0x00019ECD File Offset: 0x000180CD
		// (set) Token: 0x060017F4 RID: 6132 RVA: 0x00019ED5 File Offset: 0x000180D5
		[global::System.Runtime.Serialization.DataMember(Name = "glyphCount", IsRequired = true)]
		public double GlyphCount { get; set; }
	}
}
