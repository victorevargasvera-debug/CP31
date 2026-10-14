using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x0200023A RID: 570
	[global::System.Runtime.Serialization.DataContract]
	public class GetRequestPostDataResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x0600118C RID: 4492 RVA: 0x00012AD0 File Offset: 0x00010CD0
		// (set) Token: 0x0600118D RID: 4493 RVA: 0x00012AD8 File Offset: 0x00010CD8
		[global::System.Runtime.Serialization.DataMember]
		internal string postData { get; set; }

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x0600118E RID: 4494 RVA: 0x00012AE1 File Offset: 0x00010CE1
		public string PostData
		{
			get
			{
				return this.postData;
			}
		}
	}
}
