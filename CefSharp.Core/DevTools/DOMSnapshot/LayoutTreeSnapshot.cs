using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOMSnapshot
{
	// Token: 0x020002A8 RID: 680
	[global::System.Runtime.Serialization.DataContract]
	public class LayoutTreeSnapshot : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x060014E4 RID: 5348 RVA: 0x00016FD1 File Offset: 0x000151D1
		// (set) Token: 0x060014E5 RID: 5349 RVA: 0x00016FD9 File Offset: 0x000151D9
		[global::System.Runtime.Serialization.DataMember(Name = "nodeIndex", IsRequired = true)]
		public int[] NodeIndex { get; set; }

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x060014E6 RID: 5350 RVA: 0x00016FE2 File Offset: 0x000151E2
		// (set) Token: 0x060014E7 RID: 5351 RVA: 0x00016FEA File Offset: 0x000151EA
		[global::System.Runtime.Serialization.DataMember(Name = "styles", IsRequired = true)]
		public int[] Styles { get; set; }

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x060014E8 RID: 5352 RVA: 0x00016FF3 File Offset: 0x000151F3
		// (set) Token: 0x060014E9 RID: 5353 RVA: 0x00016FFB File Offset: 0x000151FB
		[global::System.Runtime.Serialization.DataMember(Name = "bounds", IsRequired = true)]
		public double[] Bounds { get; set; }

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x060014EA RID: 5354 RVA: 0x00017004 File Offset: 0x00015204
		// (set) Token: 0x060014EB RID: 5355 RVA: 0x0001700C File Offset: 0x0001520C
		[global::System.Runtime.Serialization.DataMember(Name = "text", IsRequired = true)]
		public int[] Text { get; set; }

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x060014EC RID: 5356 RVA: 0x00017015 File Offset: 0x00015215
		// (set) Token: 0x060014ED RID: 5357 RVA: 0x0001701D File Offset: 0x0001521D
		[global::System.Runtime.Serialization.DataMember(Name = "stackingContexts", IsRequired = true)]
		public global::CefSharp.DevTools.DOMSnapshot.RareBooleanData StackingContexts { get; set; }

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x060014EE RID: 5358 RVA: 0x00017026 File Offset: 0x00015226
		// (set) Token: 0x060014EF RID: 5359 RVA: 0x0001702E File Offset: 0x0001522E
		[global::System.Runtime.Serialization.DataMember(Name = "paintOrders", IsRequired = false)]
		public int[] PaintOrders { get; set; }

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x060014F0 RID: 5360 RVA: 0x00017037 File Offset: 0x00015237
		// (set) Token: 0x060014F1 RID: 5361 RVA: 0x0001703F File Offset: 0x0001523F
		[global::System.Runtime.Serialization.DataMember(Name = "offsetRects", IsRequired = false)]
		public double[] OffsetRects { get; set; }

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x060014F2 RID: 5362 RVA: 0x00017048 File Offset: 0x00015248
		// (set) Token: 0x060014F3 RID: 5363 RVA: 0x00017050 File Offset: 0x00015250
		[global::System.Runtime.Serialization.DataMember(Name = "scrollRects", IsRequired = false)]
		public double[] ScrollRects { get; set; }

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x060014F4 RID: 5364 RVA: 0x00017059 File Offset: 0x00015259
		// (set) Token: 0x060014F5 RID: 5365 RVA: 0x00017061 File Offset: 0x00015261
		[global::System.Runtime.Serialization.DataMember(Name = "clientRects", IsRequired = false)]
		public double[] ClientRects { get; set; }

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x060014F6 RID: 5366 RVA: 0x0001706A File Offset: 0x0001526A
		// (set) Token: 0x060014F7 RID: 5367 RVA: 0x00017072 File Offset: 0x00015272
		[global::System.Runtime.Serialization.DataMember(Name = "blendedBackgroundColors", IsRequired = false)]
		public int[] BlendedBackgroundColors { get; set; }

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x060014F8 RID: 5368 RVA: 0x0001707B File Offset: 0x0001527B
		// (set) Token: 0x060014F9 RID: 5369 RVA: 0x00017083 File Offset: 0x00015283
		[global::System.Runtime.Serialization.DataMember(Name = "textColorOpacities", IsRequired = false)]
		public double[] TextColorOpacities { get; set; }
	}
}
