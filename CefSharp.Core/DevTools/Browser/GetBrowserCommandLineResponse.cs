using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Browser
{
	// Token: 0x0200033B RID: 827
	[global::System.Runtime.Serialization.DataContract]
	public class GetBrowserCommandLineResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x06001937 RID: 6455 RVA: 0x0001AFFD File Offset: 0x000191FD
		// (set) Token: 0x06001938 RID: 6456 RVA: 0x0001B005 File Offset: 0x00019205
		[global::System.Runtime.Serialization.DataMember]
		internal string[] arguments { get; set; }

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x06001939 RID: 6457 RVA: 0x0001B00E File Offset: 0x0001920E
		public string[] Arguments
		{
			get
			{
				return this.arguments;
			}
		}
	}
}
