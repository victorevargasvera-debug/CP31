using System;
using System.Runtime.Serialization;
using CefSharp.DevTools.DOM;

namespace CefSharp.DevTools.LayerTree
{
	// Token: 0x02000256 RID: 598
	[global::System.Runtime.Serialization.DataContract]
	public class StickyPositionConstraint : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x06001275 RID: 4725 RVA: 0x000140F5 File Offset: 0x000122F5
		// (set) Token: 0x06001276 RID: 4726 RVA: 0x000140FD File Offset: 0x000122FD
		[global::System.Runtime.Serialization.DataMember(Name = "stickyBoxRect", IsRequired = true)]
		public global::CefSharp.DevTools.DOM.Rect StickyBoxRect { get; set; }

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x06001277 RID: 4727 RVA: 0x00014106 File Offset: 0x00012306
		// (set) Token: 0x06001278 RID: 4728 RVA: 0x0001410E File Offset: 0x0001230E
		[global::System.Runtime.Serialization.DataMember(Name = "containingBlockRect", IsRequired = true)]
		public global::CefSharp.DevTools.DOM.Rect ContainingBlockRect { get; set; }

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x06001279 RID: 4729 RVA: 0x00014117 File Offset: 0x00012317
		// (set) Token: 0x0600127A RID: 4730 RVA: 0x0001411F File Offset: 0x0001231F
		[global::System.Runtime.Serialization.DataMember(Name = "nearestLayerShiftingStickyBox", IsRequired = false)]
		public string NearestLayerShiftingStickyBox { get; set; }

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x0600127B RID: 4731 RVA: 0x00014128 File Offset: 0x00012328
		// (set) Token: 0x0600127C RID: 4732 RVA: 0x00014130 File Offset: 0x00012330
		[global::System.Runtime.Serialization.DataMember(Name = "nearestLayerShiftingContainingBlock", IsRequired = false)]
		public string NearestLayerShiftingContainingBlock { get; set; }
	}
}
