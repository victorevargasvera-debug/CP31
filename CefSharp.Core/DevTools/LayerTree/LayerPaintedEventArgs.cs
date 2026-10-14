using System;
using System.Runtime.Serialization;
using CefSharp.DevTools.DOM;

namespace CefSharp.DevTools.LayerTree
{
	// Token: 0x02000259 RID: 601
	[global::System.Runtime.Serialization.DataContract]
	public class LayerPaintedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x060012A6 RID: 4774 RVA: 0x00014294 File Offset: 0x00012494
		// (set) Token: 0x060012A7 RID: 4775 RVA: 0x0001429C File Offset: 0x0001249C
		[global::System.Runtime.Serialization.DataMember(Name = "layerId", IsRequired = true)]
		public string LayerId { get; private set; }

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x060012A8 RID: 4776 RVA: 0x000142A5 File Offset: 0x000124A5
		// (set) Token: 0x060012A9 RID: 4777 RVA: 0x000142AD File Offset: 0x000124AD
		[global::System.Runtime.Serialization.DataMember(Name = "clip", IsRequired = true)]
		public global::CefSharp.DevTools.DOM.Rect Clip { get; private set; }
	}
}
