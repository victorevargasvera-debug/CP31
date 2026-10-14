using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Overlay
{
	// Token: 0x020001CA RID: 458
	[global::System.Runtime.Serialization.DataContract]
	public class GridNodeHighlightConfig : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06000DF5 RID: 3573 RVA: 0x0001004E File Offset: 0x0000E24E
		// (set) Token: 0x06000DF6 RID: 3574 RVA: 0x00010056 File Offset: 0x0000E256
		[global::System.Runtime.Serialization.DataMember(Name = "gridHighlightConfig", IsRequired = true)]
		public global::CefSharp.DevTools.Overlay.GridHighlightConfig GridHighlightConfig { get; set; }

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06000DF7 RID: 3575 RVA: 0x0001005F File Offset: 0x0000E25F
		// (set) Token: 0x06000DF8 RID: 3576 RVA: 0x00010067 File Offset: 0x0000E267
		[global::System.Runtime.Serialization.DataMember(Name = "nodeId", IsRequired = true)]
		public int NodeId { get; set; }
	}
}
