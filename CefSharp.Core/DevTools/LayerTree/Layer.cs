using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.LayerTree
{
	// Token: 0x02000258 RID: 600
	[global::System.Runtime.Serialization.DataContract]
	public class Layer : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x06001285 RID: 4741 RVA: 0x0001417C File Offset: 0x0001237C
		// (set) Token: 0x06001286 RID: 4742 RVA: 0x00014184 File Offset: 0x00012384
		[global::System.Runtime.Serialization.DataMember(Name = "layerId", IsRequired = true)]
		public string LayerId { get; set; }

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x06001287 RID: 4743 RVA: 0x0001418D File Offset: 0x0001238D
		// (set) Token: 0x06001288 RID: 4744 RVA: 0x00014195 File Offset: 0x00012395
		[global::System.Runtime.Serialization.DataMember(Name = "parentLayerId", IsRequired = false)]
		public string ParentLayerId { get; set; }

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x06001289 RID: 4745 RVA: 0x0001419E File Offset: 0x0001239E
		// (set) Token: 0x0600128A RID: 4746 RVA: 0x000141A6 File Offset: 0x000123A6
		[global::System.Runtime.Serialization.DataMember(Name = "backendNodeId", IsRequired = false)]
		public int? BackendNodeId { get; set; }

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x0600128B RID: 4747 RVA: 0x000141AF File Offset: 0x000123AF
		// (set) Token: 0x0600128C RID: 4748 RVA: 0x000141B7 File Offset: 0x000123B7
		[global::System.Runtime.Serialization.DataMember(Name = "offsetX", IsRequired = true)]
		public double OffsetX { get; set; }

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x0600128D RID: 4749 RVA: 0x000141C0 File Offset: 0x000123C0
		// (set) Token: 0x0600128E RID: 4750 RVA: 0x000141C8 File Offset: 0x000123C8
		[global::System.Runtime.Serialization.DataMember(Name = "offsetY", IsRequired = true)]
		public double OffsetY { get; set; }

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x0600128F RID: 4751 RVA: 0x000141D1 File Offset: 0x000123D1
		// (set) Token: 0x06001290 RID: 4752 RVA: 0x000141D9 File Offset: 0x000123D9
		[global::System.Runtime.Serialization.DataMember(Name = "width", IsRequired = true)]
		public double Width { get; set; }

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x06001291 RID: 4753 RVA: 0x000141E2 File Offset: 0x000123E2
		// (set) Token: 0x06001292 RID: 4754 RVA: 0x000141EA File Offset: 0x000123EA
		[global::System.Runtime.Serialization.DataMember(Name = "height", IsRequired = true)]
		public double Height { get; set; }

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x06001293 RID: 4755 RVA: 0x000141F3 File Offset: 0x000123F3
		// (set) Token: 0x06001294 RID: 4756 RVA: 0x000141FB File Offset: 0x000123FB
		[global::System.Runtime.Serialization.DataMember(Name = "transform", IsRequired = false)]
		public double[] Transform { get; set; }

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x06001295 RID: 4757 RVA: 0x00014204 File Offset: 0x00012404
		// (set) Token: 0x06001296 RID: 4758 RVA: 0x0001420C File Offset: 0x0001240C
		[global::System.Runtime.Serialization.DataMember(Name = "anchorX", IsRequired = false)]
		public double? AnchorX { get; set; }

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x06001297 RID: 4759 RVA: 0x00014215 File Offset: 0x00012415
		// (set) Token: 0x06001298 RID: 4760 RVA: 0x0001421D File Offset: 0x0001241D
		[global::System.Runtime.Serialization.DataMember(Name = "anchorY", IsRequired = false)]
		public double? AnchorY { get; set; }

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x06001299 RID: 4761 RVA: 0x00014226 File Offset: 0x00012426
		// (set) Token: 0x0600129A RID: 4762 RVA: 0x0001422E File Offset: 0x0001242E
		[global::System.Runtime.Serialization.DataMember(Name = "anchorZ", IsRequired = false)]
		public double? AnchorZ { get; set; }

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x0600129B RID: 4763 RVA: 0x00014237 File Offset: 0x00012437
		// (set) Token: 0x0600129C RID: 4764 RVA: 0x0001423F File Offset: 0x0001243F
		[global::System.Runtime.Serialization.DataMember(Name = "paintCount", IsRequired = true)]
		public int PaintCount { get; set; }

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x0600129D RID: 4765 RVA: 0x00014248 File Offset: 0x00012448
		// (set) Token: 0x0600129E RID: 4766 RVA: 0x00014250 File Offset: 0x00012450
		[global::System.Runtime.Serialization.DataMember(Name = "drawsContent", IsRequired = true)]
		public bool DrawsContent { get; set; }

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x0600129F RID: 4767 RVA: 0x00014259 File Offset: 0x00012459
		// (set) Token: 0x060012A0 RID: 4768 RVA: 0x00014261 File Offset: 0x00012461
		[global::System.Runtime.Serialization.DataMember(Name = "invisible", IsRequired = false)]
		public bool? Invisible { get; set; }

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x060012A1 RID: 4769 RVA: 0x0001426A File Offset: 0x0001246A
		// (set) Token: 0x060012A2 RID: 4770 RVA: 0x00014272 File Offset: 0x00012472
		[global::System.Runtime.Serialization.DataMember(Name = "scrollRects", IsRequired = false)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.LayerTree.ScrollRect> ScrollRects { get; set; }

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x060012A3 RID: 4771 RVA: 0x0001427B File Offset: 0x0001247B
		// (set) Token: 0x060012A4 RID: 4772 RVA: 0x00014283 File Offset: 0x00012483
		[global::System.Runtime.Serialization.DataMember(Name = "stickyPositionConstraint", IsRequired = false)]
		public global::CefSharp.DevTools.LayerTree.StickyPositionConstraint StickyPositionConstraint { get; set; }
	}
}
