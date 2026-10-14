using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x02000304 RID: 772
	[global::System.Runtime.Serialization.DataContract]
	public class CSSMedia : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x060017A1 RID: 6049 RVA: 0x00019BBE File Offset: 0x00017DBE
		// (set) Token: 0x060017A2 RID: 6050 RVA: 0x00019BC6 File Offset: 0x00017DC6
		[global::System.Runtime.Serialization.DataMember(Name = "text", IsRequired = true)]
		public string Text { get; set; }

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x060017A3 RID: 6051 RVA: 0x00019BCF File Offset: 0x00017DCF
		// (set) Token: 0x060017A4 RID: 6052 RVA: 0x00019BEB File Offset: 0x00017DEB
		public global::CefSharp.DevTools.CSS.CSSMediaSource Source
		{
			get
			{
				return (global::CefSharp.DevTools.CSS.CSSMediaSource)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.CSS.CSSMediaSource), this.source);
			}
			set
			{
				this.source = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x060017A5 RID: 6053 RVA: 0x00019BFE File Offset: 0x00017DFE
		// (set) Token: 0x060017A6 RID: 6054 RVA: 0x00019C06 File Offset: 0x00017E06
		[global::System.Runtime.Serialization.DataMember(Name = "source", IsRequired = true)]
		internal string source { get; set; }

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x060017A7 RID: 6055 RVA: 0x00019C0F File Offset: 0x00017E0F
		// (set) Token: 0x060017A8 RID: 6056 RVA: 0x00019C17 File Offset: 0x00017E17
		[global::System.Runtime.Serialization.DataMember(Name = "sourceURL", IsRequired = false)]
		public string SourceURL { get; set; }

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x060017A9 RID: 6057 RVA: 0x00019C20 File Offset: 0x00017E20
		// (set) Token: 0x060017AA RID: 6058 RVA: 0x00019C28 File Offset: 0x00017E28
		[global::System.Runtime.Serialization.DataMember(Name = "range", IsRequired = false)]
		public global::CefSharp.DevTools.CSS.SourceRange Range { get; set; }

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x060017AB RID: 6059 RVA: 0x00019C31 File Offset: 0x00017E31
		// (set) Token: 0x060017AC RID: 6060 RVA: 0x00019C39 File Offset: 0x00017E39
		[global::System.Runtime.Serialization.DataMember(Name = "styleSheetId", IsRequired = false)]
		public string StyleSheetId { get; set; }

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x060017AD RID: 6061 RVA: 0x00019C42 File Offset: 0x00017E42
		// (set) Token: 0x060017AE RID: 6062 RVA: 0x00019C4A File Offset: 0x00017E4A
		[global::System.Runtime.Serialization.DataMember(Name = "mediaList", IsRequired = false)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.CSS.MediaQuery> MediaList { get; set; }
	}
}
