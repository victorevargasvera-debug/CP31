using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOM
{
	// Token: 0x020002B9 RID: 697
	[global::System.Runtime.Serialization.DataContract]
	public class BoxModel : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x06001588 RID: 5512 RVA: 0x000178B3 File Offset: 0x00015AB3
		// (set) Token: 0x06001589 RID: 5513 RVA: 0x000178BB File Offset: 0x00015ABB
		[global::System.Runtime.Serialization.DataMember(Name = "content", IsRequired = true)]
		public double[] Content { get; set; }

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x0600158A RID: 5514 RVA: 0x000178C4 File Offset: 0x00015AC4
		// (set) Token: 0x0600158B RID: 5515 RVA: 0x000178CC File Offset: 0x00015ACC
		[global::System.Runtime.Serialization.DataMember(Name = "padding", IsRequired = true)]
		public double[] Padding { get; set; }

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x0600158C RID: 5516 RVA: 0x000178D5 File Offset: 0x00015AD5
		// (set) Token: 0x0600158D RID: 5517 RVA: 0x000178DD File Offset: 0x00015ADD
		[global::System.Runtime.Serialization.DataMember(Name = "border", IsRequired = true)]
		public double[] Border { get; set; }

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x0600158E RID: 5518 RVA: 0x000178E6 File Offset: 0x00015AE6
		// (set) Token: 0x0600158F RID: 5519 RVA: 0x000178EE File Offset: 0x00015AEE
		[global::System.Runtime.Serialization.DataMember(Name = "margin", IsRequired = true)]
		public double[] Margin { get; set; }

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x06001590 RID: 5520 RVA: 0x000178F7 File Offset: 0x00015AF7
		// (set) Token: 0x06001591 RID: 5521 RVA: 0x000178FF File Offset: 0x00015AFF
		[global::System.Runtime.Serialization.DataMember(Name = "width", IsRequired = true)]
		public int Width { get; set; }

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x06001592 RID: 5522 RVA: 0x00017908 File Offset: 0x00015B08
		// (set) Token: 0x06001593 RID: 5523 RVA: 0x00017910 File Offset: 0x00015B10
		[global::System.Runtime.Serialization.DataMember(Name = "height", IsRequired = true)]
		public int Height { get; set; }

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x06001594 RID: 5524 RVA: 0x00017919 File Offset: 0x00015B19
		// (set) Token: 0x06001595 RID: 5525 RVA: 0x00017921 File Offset: 0x00015B21
		[global::System.Runtime.Serialization.DataMember(Name = "shapeOutside", IsRequired = false)]
		public global::CefSharp.DevTools.DOM.ShapeOutsideInfo ShapeOutside { get; set; }
	}
}
