using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Target
{
	// Token: 0x0200010C RID: 268
	[global::System.Runtime.Serialization.DataContract]
	public class CreateBrowserContextResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000326 RID: 806
		// (get) Token: 0x0600086E RID: 2158 RVA: 0x0000AF64 File Offset: 0x00009164
		// (set) Token: 0x0600086F RID: 2159 RVA: 0x0000AF6C File Offset: 0x0000916C
		[global::System.Runtime.Serialization.DataMember]
		internal string browserContextId { get; set; }

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000870 RID: 2160 RVA: 0x0000AF75 File Offset: 0x00009175
		public string BrowserContextId
		{
			get
			{
				return this.browserContextId;
			}
		}
	}
}
