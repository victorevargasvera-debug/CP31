using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOM
{
	// Token: 0x020002DC RID: 732
	[global::System.Runtime.Serialization.DataContract]
	public class GetTopLayerElementsResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x06001640 RID: 5696 RVA: 0x00017EB3 File Offset: 0x000160B3
		// (set) Token: 0x06001641 RID: 5697 RVA: 0x00017EBB File Offset: 0x000160BB
		[global::System.Runtime.Serialization.DataMember]
		internal int[] nodeIds { get; set; }

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x06001642 RID: 5698 RVA: 0x00017EC4 File Offset: 0x000160C4
		public int[] NodeIds
		{
			get
			{
				return this.nodeIds;
			}
		}
	}
}
