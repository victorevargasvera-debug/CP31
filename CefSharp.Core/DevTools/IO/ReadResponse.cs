using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.IO
{
	// Token: 0x0200002D RID: 45
	[global::System.Runtime.Serialization.DataContract]
	public class ReadResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000226 RID: 550 RVA: 0x00004F5A File Offset: 0x0000315A
		// (set) Token: 0x06000227 RID: 551 RVA: 0x00004F62 File Offset: 0x00003162
		[global::System.Runtime.Serialization.DataMember]
		internal bool? base64Encoded { get; set; }

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000228 RID: 552 RVA: 0x00004F6B File Offset: 0x0000316B
		public bool? Base64Encoded
		{
			get
			{
				return this.base64Encoded;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000229 RID: 553 RVA: 0x00004F73 File Offset: 0x00003173
		// (set) Token: 0x0600022A RID: 554 RVA: 0x00004F7B File Offset: 0x0000317B
		[global::System.Runtime.Serialization.DataMember]
		internal string data { get; set; }

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600022B RID: 555 RVA: 0x00004F84 File Offset: 0x00003184
		public string Data
		{
			get
			{
				return this.data;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600022C RID: 556 RVA: 0x00004F8C File Offset: 0x0000318C
		// (set) Token: 0x0600022D RID: 557 RVA: 0x00004F94 File Offset: 0x00003194
		[global::System.Runtime.Serialization.DataMember]
		internal bool eof { get; set; }

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x0600022E RID: 558 RVA: 0x00004F9D File Offset: 0x0000319D
		public bool Eof
		{
			get
			{
				return this.eof;
			}
		}
	}
}
