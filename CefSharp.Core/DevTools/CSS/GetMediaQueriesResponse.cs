using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x0200031F RID: 799
	[global::System.Runtime.Serialization.DataContract]
	public class GetMediaQueriesResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x06001884 RID: 6276 RVA: 0x0001A3C7 File Offset: 0x000185C7
		// (set) Token: 0x06001885 RID: 6277 RVA: 0x0001A3CF File Offset: 0x000185CF
		[global::System.Runtime.Serialization.DataMember]
		internal global::System.Collections.Generic.IList<global::CefSharp.DevTools.CSS.CSSMedia> medias { get; set; }

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x06001886 RID: 6278 RVA: 0x0001A3D8 File Offset: 0x000185D8
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.CSS.CSSMedia> Medias
		{
			get
			{
				return this.medias;
			}
		}
	}
}
