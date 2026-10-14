using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x0200030F RID: 783
	[global::System.Runtime.Serialization.DataContract]
	public class CSSTryRule : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x06001816 RID: 6166 RVA: 0x00019FF5 File Offset: 0x000181F5
		// (set) Token: 0x06001817 RID: 6167 RVA: 0x00019FFD File Offset: 0x000181FD
		[global::System.Runtime.Serialization.DataMember(Name = "styleSheetId", IsRequired = false)]
		public string StyleSheetId { get; set; }

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x06001818 RID: 6168 RVA: 0x0001A006 File Offset: 0x00018206
		// (set) Token: 0x06001819 RID: 6169 RVA: 0x0001A022 File Offset: 0x00018222
		public global::CefSharp.DevTools.CSS.StyleSheetOrigin Origin
		{
			get
			{
				return (global::CefSharp.DevTools.CSS.StyleSheetOrigin)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.CSS.StyleSheetOrigin), this.origin);
			}
			set
			{
				this.origin = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x0600181A RID: 6170 RVA: 0x0001A035 File Offset: 0x00018235
		// (set) Token: 0x0600181B RID: 6171 RVA: 0x0001A03D File Offset: 0x0001823D
		[global::System.Runtime.Serialization.DataMember(Name = "origin", IsRequired = true)]
		internal string origin { get; set; }

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x0600181C RID: 6172 RVA: 0x0001A046 File Offset: 0x00018246
		// (set) Token: 0x0600181D RID: 6173 RVA: 0x0001A04E File Offset: 0x0001824E
		[global::System.Runtime.Serialization.DataMember(Name = "style", IsRequired = true)]
		public global::CefSharp.DevTools.CSS.CSSStyle Style { get; set; }
	}
}
