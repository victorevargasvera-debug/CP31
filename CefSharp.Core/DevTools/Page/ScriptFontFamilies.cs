using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x02000180 RID: 384
	[global::System.Runtime.Serialization.DataContract]
	public class ScriptFontFamilies : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06000BE2 RID: 3042 RVA: 0x0000DFBD File Offset: 0x0000C1BD
		// (set) Token: 0x06000BE3 RID: 3043 RVA: 0x0000DFC5 File Offset: 0x0000C1C5
		[global::System.Runtime.Serialization.DataMember(Name = "script", IsRequired = true)]
		public string Script { get; set; }

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06000BE4 RID: 3044 RVA: 0x0000DFCE File Offset: 0x0000C1CE
		// (set) Token: 0x06000BE5 RID: 3045 RVA: 0x0000DFD6 File Offset: 0x0000C1D6
		[global::System.Runtime.Serialization.DataMember(Name = "fontFamilies", IsRequired = true)]
		public global::CefSharp.DevTools.Page.FontFamilies FontFamilies { get; set; }
	}
}
