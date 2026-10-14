using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x020001AC RID: 428
	[global::System.Runtime.Serialization.DataContract]
	public class GetAppManifestResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06000CBA RID: 3258 RVA: 0x0000E808 File Offset: 0x0000CA08
		// (set) Token: 0x06000CBB RID: 3259 RVA: 0x0000E810 File Offset: 0x0000CA10
		[global::System.Runtime.Serialization.DataMember]
		internal string url { get; set; }

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06000CBC RID: 3260 RVA: 0x0000E819 File Offset: 0x0000CA19
		public string Url
		{
			get
			{
				return this.url;
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06000CBD RID: 3261 RVA: 0x0000E821 File Offset: 0x0000CA21
		// (set) Token: 0x06000CBE RID: 3262 RVA: 0x0000E829 File Offset: 0x0000CA29
		[global::System.Runtime.Serialization.DataMember]
		internal global::System.Collections.Generic.IList<global::CefSharp.DevTools.Page.AppManifestError> errors { get; set; }

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06000CBF RID: 3263 RVA: 0x0000E832 File Offset: 0x0000CA32
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Page.AppManifestError> Errors
		{
			get
			{
				return this.errors;
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06000CC0 RID: 3264 RVA: 0x0000E83A File Offset: 0x0000CA3A
		// (set) Token: 0x06000CC1 RID: 3265 RVA: 0x0000E842 File Offset: 0x0000CA42
		[global::System.Runtime.Serialization.DataMember]
		internal string data { get; set; }

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06000CC2 RID: 3266 RVA: 0x0000E84B File Offset: 0x0000CA4B
		public string Data
		{
			get
			{
				return this.data;
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06000CC3 RID: 3267 RVA: 0x0000E853 File Offset: 0x0000CA53
		// (set) Token: 0x06000CC4 RID: 3268 RVA: 0x0000E85B File Offset: 0x0000CA5B
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.Page.AppManifestParsedProperties parsed { get; set; }

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06000CC5 RID: 3269 RVA: 0x0000E864 File Offset: 0x0000CA64
		public global::CefSharp.DevTools.Page.AppManifestParsedProperties Parsed
		{
			get
			{
				return this.parsed;
			}
		}
	}
}
