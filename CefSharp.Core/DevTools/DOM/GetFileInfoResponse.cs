using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOM
{
	// Token: 0x020002E0 RID: 736
	[global::System.Runtime.Serialization.DataContract]
	public class GetFileInfoResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x06001650 RID: 5712 RVA: 0x00017F37 File Offset: 0x00016137
		// (set) Token: 0x06001651 RID: 5713 RVA: 0x00017F3F File Offset: 0x0001613F
		[global::System.Runtime.Serialization.DataMember]
		internal string path { get; set; }

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x06001652 RID: 5714 RVA: 0x00017F48 File Offset: 0x00016148
		public string Path
		{
			get
			{
				return this.path;
			}
		}
	}
}
