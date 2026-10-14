using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x0200031A RID: 794
	[global::System.Runtime.Serialization.DataContract]
	public class CreateStyleSheetResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x0600184F RID: 6223 RVA: 0x0001A20F File Offset: 0x0001840F
		// (set) Token: 0x06001850 RID: 6224 RVA: 0x0001A217 File Offset: 0x00018417
		[global::System.Runtime.Serialization.DataMember]
		internal string styleSheetId { get; set; }

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x06001851 RID: 6225 RVA: 0x0001A220 File Offset: 0x00018420
		public string StyleSheetId
		{
			get
			{
				return this.styleSheetId;
			}
		}
	}
}
