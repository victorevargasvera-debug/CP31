using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x02000322 RID: 802
	[global::System.Runtime.Serialization.DataContract]
	public class GetLayersForNodeResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x06001890 RID: 6288 RVA: 0x0001A42A File Offset: 0x0001862A
		// (set) Token: 0x06001891 RID: 6289 RVA: 0x0001A432 File Offset: 0x00018632
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.CSS.CSSLayerData rootLayer { get; set; }

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x06001892 RID: 6290 RVA: 0x0001A43B File Offset: 0x0001863B
		public global::CefSharp.DevTools.CSS.CSSLayerData RootLayer
		{
			get
			{
				return this.rootLayer;
			}
		}
	}
}
