using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x02000320 RID: 800
	[global::System.Runtime.Serialization.DataContract]
	public class GetPlatformFontsForNodeResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x06001888 RID: 6280 RVA: 0x0001A3E8 File Offset: 0x000185E8
		// (set) Token: 0x06001889 RID: 6281 RVA: 0x0001A3F0 File Offset: 0x000185F0
		[global::System.Runtime.Serialization.DataMember]
		internal global::System.Collections.Generic.IList<global::CefSharp.DevTools.CSS.PlatformFontUsage> fonts { get; set; }

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x0600188A RID: 6282 RVA: 0x0001A3F9 File Offset: 0x000185F9
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.CSS.PlatformFontUsage> Fonts
		{
			get
			{
				return this.fonts;
			}
		}
	}
}
