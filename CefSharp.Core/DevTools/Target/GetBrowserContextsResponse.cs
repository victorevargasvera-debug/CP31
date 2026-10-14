using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Target
{
	// Token: 0x0200010D RID: 269
	[global::System.Runtime.Serialization.DataContract]
	public class GetBrowserContextsResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000872 RID: 2162 RVA: 0x0000AF85 File Offset: 0x00009185
		// (set) Token: 0x06000873 RID: 2163 RVA: 0x0000AF8D File Offset: 0x0000918D
		[global::System.Runtime.Serialization.DataMember]
		internal string[] browserContextIds { get; set; }

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000874 RID: 2164 RVA: 0x0000AF96 File Offset: 0x00009196
		public string[] BrowserContextIds
		{
			get
			{
				return this.browserContextIds;
			}
		}
	}
}
