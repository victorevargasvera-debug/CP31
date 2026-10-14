using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x020001B3 RID: 435
	[global::System.Runtime.Serialization.DataContract]
	public class GetResourceContentResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06000CF4 RID: 3316 RVA: 0x0000E9E9 File Offset: 0x0000CBE9
		// (set) Token: 0x06000CF5 RID: 3317 RVA: 0x0000E9F1 File Offset: 0x0000CBF1
		[global::System.Runtime.Serialization.DataMember]
		internal string content { get; set; }

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06000CF6 RID: 3318 RVA: 0x0000E9FA File Offset: 0x0000CBFA
		public string Content
		{
			get
			{
				return this.content;
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06000CF7 RID: 3319 RVA: 0x0000EA02 File Offset: 0x0000CC02
		// (set) Token: 0x06000CF8 RID: 3320 RVA: 0x0000EA0A File Offset: 0x0000CC0A
		[global::System.Runtime.Serialization.DataMember]
		internal bool base64Encoded { get; set; }

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06000CF9 RID: 3321 RVA: 0x0000EA13 File Offset: 0x0000CC13
		public bool Base64Encoded
		{
			get
			{
				return this.base64Encoded;
			}
		}
	}
}
