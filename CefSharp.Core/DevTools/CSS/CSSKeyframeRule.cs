using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x02000312 RID: 786
	[global::System.Runtime.Serialization.DataContract]
	public class CSSKeyframeRule : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x06001829 RID: 6185 RVA: 0x0001A0B3 File Offset: 0x000182B3
		// (set) Token: 0x0600182A RID: 6186 RVA: 0x0001A0BB File Offset: 0x000182BB
		[global::System.Runtime.Serialization.DataMember(Name = "styleSheetId", IsRequired = false)]
		public string StyleSheetId { get; set; }

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x0600182B RID: 6187 RVA: 0x0001A0C4 File Offset: 0x000182C4
		// (set) Token: 0x0600182C RID: 6188 RVA: 0x0001A0E0 File Offset: 0x000182E0
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

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x0600182D RID: 6189 RVA: 0x0001A0F3 File Offset: 0x000182F3
		// (set) Token: 0x0600182E RID: 6190 RVA: 0x0001A0FB File Offset: 0x000182FB
		[global::System.Runtime.Serialization.DataMember(Name = "origin", IsRequired = true)]
		internal string origin { get; set; }

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x0600182F RID: 6191 RVA: 0x0001A104 File Offset: 0x00018304
		// (set) Token: 0x06001830 RID: 6192 RVA: 0x0001A10C File Offset: 0x0001830C
		[global::System.Runtime.Serialization.DataMember(Name = "keyText", IsRequired = true)]
		public global::CefSharp.DevTools.CSS.Value KeyText { get; set; }

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x06001831 RID: 6193 RVA: 0x0001A115 File Offset: 0x00018315
		// (set) Token: 0x06001832 RID: 6194 RVA: 0x0001A11D File Offset: 0x0001831D
		[global::System.Runtime.Serialization.DataMember(Name = "style", IsRequired = true)]
		public global::CefSharp.DevTools.CSS.CSSStyle Style { get; set; }
	}
}
