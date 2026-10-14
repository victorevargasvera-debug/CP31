using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x0200030B RID: 779
	[global::System.Runtime.Serialization.DataContract]
	public class CSSLayerData : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x060017E8 RID: 6120 RVA: 0x00019E70 File Offset: 0x00018070
		// (set) Token: 0x060017E9 RID: 6121 RVA: 0x00019E78 File Offset: 0x00018078
		[global::System.Runtime.Serialization.DataMember(Name = "name", IsRequired = true)]
		public string Name { get; set; }

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x060017EA RID: 6122 RVA: 0x00019E81 File Offset: 0x00018081
		// (set) Token: 0x060017EB RID: 6123 RVA: 0x00019E89 File Offset: 0x00018089
		[global::System.Runtime.Serialization.DataMember(Name = "subLayers", IsRequired = false)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.CSS.CSSLayerData> SubLayers { get; set; }

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x060017EC RID: 6124 RVA: 0x00019E92 File Offset: 0x00018092
		// (set) Token: 0x060017ED RID: 6125 RVA: 0x00019E9A File Offset: 0x0001809A
		[global::System.Runtime.Serialization.DataMember(Name = "order", IsRequired = true)]
		public double Order { get; set; }
	}
}
