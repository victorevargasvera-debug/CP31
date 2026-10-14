using System;
using System.Runtime.Serialization;
using CefSharp.DevTools.DOM;

namespace CefSharp.DevTools.Overlay
{
	// Token: 0x020001C8 RID: 456
	[global::System.Runtime.Serialization.DataContract]
	public class HighlightConfig : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06000DCA RID: 3530 RVA: 0x0000FEA5 File Offset: 0x0000E0A5
		// (set) Token: 0x06000DCB RID: 3531 RVA: 0x0000FEAD File Offset: 0x0000E0AD
		[global::System.Runtime.Serialization.DataMember(Name = "showInfo", IsRequired = false)]
		public bool? ShowInfo { get; set; }

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06000DCC RID: 3532 RVA: 0x0000FEB6 File Offset: 0x0000E0B6
		// (set) Token: 0x06000DCD RID: 3533 RVA: 0x0000FEBE File Offset: 0x0000E0BE
		[global::System.Runtime.Serialization.DataMember(Name = "showStyles", IsRequired = false)]
		public bool? ShowStyles { get; set; }

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06000DCE RID: 3534 RVA: 0x0000FEC7 File Offset: 0x0000E0C7
		// (set) Token: 0x06000DCF RID: 3535 RVA: 0x0000FECF File Offset: 0x0000E0CF
		[global::System.Runtime.Serialization.DataMember(Name = "showRulers", IsRequired = false)]
		public bool? ShowRulers { get; set; }

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06000DD0 RID: 3536 RVA: 0x0000FED8 File Offset: 0x0000E0D8
		// (set) Token: 0x06000DD1 RID: 3537 RVA: 0x0000FEE0 File Offset: 0x0000E0E0
		[global::System.Runtime.Serialization.DataMember(Name = "showAccessibilityInfo", IsRequired = false)]
		public bool? ShowAccessibilityInfo { get; set; }

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06000DD2 RID: 3538 RVA: 0x0000FEE9 File Offset: 0x0000E0E9
		// (set) Token: 0x06000DD3 RID: 3539 RVA: 0x0000FEF1 File Offset: 0x0000E0F1
		[global::System.Runtime.Serialization.DataMember(Name = "showExtensionLines", IsRequired = false)]
		public bool? ShowExtensionLines { get; set; }

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06000DD4 RID: 3540 RVA: 0x0000FEFA File Offset: 0x0000E0FA
		// (set) Token: 0x06000DD5 RID: 3541 RVA: 0x0000FF02 File Offset: 0x0000E102
		[global::System.Runtime.Serialization.DataMember(Name = "contentColor", IsRequired = false)]
		public global::CefSharp.DevTools.DOM.RGBA ContentColor { get; set; }

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06000DD6 RID: 3542 RVA: 0x0000FF0B File Offset: 0x0000E10B
		// (set) Token: 0x06000DD7 RID: 3543 RVA: 0x0000FF13 File Offset: 0x0000E113
		[global::System.Runtime.Serialization.DataMember(Name = "paddingColor", IsRequired = false)]
		public global::CefSharp.DevTools.DOM.RGBA PaddingColor { get; set; }

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06000DD8 RID: 3544 RVA: 0x0000FF1C File Offset: 0x0000E11C
		// (set) Token: 0x06000DD9 RID: 3545 RVA: 0x0000FF24 File Offset: 0x0000E124
		[global::System.Runtime.Serialization.DataMember(Name = "borderColor", IsRequired = false)]
		public global::CefSharp.DevTools.DOM.RGBA BorderColor { get; set; }

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06000DDA RID: 3546 RVA: 0x0000FF2D File Offset: 0x0000E12D
		// (set) Token: 0x06000DDB RID: 3547 RVA: 0x0000FF35 File Offset: 0x0000E135
		[global::System.Runtime.Serialization.DataMember(Name = "marginColor", IsRequired = false)]
		public global::CefSharp.DevTools.DOM.RGBA MarginColor { get; set; }

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06000DDC RID: 3548 RVA: 0x0000FF3E File Offset: 0x0000E13E
		// (set) Token: 0x06000DDD RID: 3549 RVA: 0x0000FF46 File Offset: 0x0000E146
		[global::System.Runtime.Serialization.DataMember(Name = "eventTargetColor", IsRequired = false)]
		public global::CefSharp.DevTools.DOM.RGBA EventTargetColor { get; set; }

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06000DDE RID: 3550 RVA: 0x0000FF4F File Offset: 0x0000E14F
		// (set) Token: 0x06000DDF RID: 3551 RVA: 0x0000FF57 File Offset: 0x0000E157
		[global::System.Runtime.Serialization.DataMember(Name = "shapeColor", IsRequired = false)]
		public global::CefSharp.DevTools.DOM.RGBA ShapeColor { get; set; }

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06000DE0 RID: 3552 RVA: 0x0000FF60 File Offset: 0x0000E160
		// (set) Token: 0x06000DE1 RID: 3553 RVA: 0x0000FF68 File Offset: 0x0000E168
		[global::System.Runtime.Serialization.DataMember(Name = "shapeMarginColor", IsRequired = false)]
		public global::CefSharp.DevTools.DOM.RGBA ShapeMarginColor { get; set; }

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06000DE2 RID: 3554 RVA: 0x0000FF71 File Offset: 0x0000E171
		// (set) Token: 0x06000DE3 RID: 3555 RVA: 0x0000FF79 File Offset: 0x0000E179
		[global::System.Runtime.Serialization.DataMember(Name = "cssGridColor", IsRequired = false)]
		public global::CefSharp.DevTools.DOM.RGBA CssGridColor { get; set; }

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06000DE4 RID: 3556 RVA: 0x0000FF82 File Offset: 0x0000E182
		// (set) Token: 0x06000DE5 RID: 3557 RVA: 0x0000FF9E File Offset: 0x0000E19E
		public global::CefSharp.DevTools.Overlay.ColorFormat? ColorFormat
		{
			get
			{
				return (global::CefSharp.DevTools.Overlay.ColorFormat?)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Overlay.ColorFormat?), this.colorFormat);
			}
			set
			{
				this.colorFormat = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06000DE6 RID: 3558 RVA: 0x0000FFB1 File Offset: 0x0000E1B1
		// (set) Token: 0x06000DE7 RID: 3559 RVA: 0x0000FFB9 File Offset: 0x0000E1B9
		[global::System.Runtime.Serialization.DataMember(Name = "colorFormat", IsRequired = false)]
		internal string colorFormat { get; set; }

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06000DE8 RID: 3560 RVA: 0x0000FFC2 File Offset: 0x0000E1C2
		// (set) Token: 0x06000DE9 RID: 3561 RVA: 0x0000FFCA File Offset: 0x0000E1CA
		[global::System.Runtime.Serialization.DataMember(Name = "gridHighlightConfig", IsRequired = false)]
		public global::CefSharp.DevTools.Overlay.GridHighlightConfig GridHighlightConfig { get; set; }

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06000DEA RID: 3562 RVA: 0x0000FFD3 File Offset: 0x0000E1D3
		// (set) Token: 0x06000DEB RID: 3563 RVA: 0x0000FFDB File Offset: 0x0000E1DB
		[global::System.Runtime.Serialization.DataMember(Name = "flexContainerHighlightConfig", IsRequired = false)]
		public global::CefSharp.DevTools.Overlay.FlexContainerHighlightConfig FlexContainerHighlightConfig { get; set; }

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06000DEC RID: 3564 RVA: 0x0000FFE4 File Offset: 0x0000E1E4
		// (set) Token: 0x06000DED RID: 3565 RVA: 0x0000FFEC File Offset: 0x0000E1EC
		[global::System.Runtime.Serialization.DataMember(Name = "flexItemHighlightConfig", IsRequired = false)]
		public global::CefSharp.DevTools.Overlay.FlexItemHighlightConfig FlexItemHighlightConfig { get; set; }

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06000DEE RID: 3566 RVA: 0x0000FFF5 File Offset: 0x0000E1F5
		// (set) Token: 0x06000DEF RID: 3567 RVA: 0x00010011 File Offset: 0x0000E211
		public global::CefSharp.DevTools.Overlay.ContrastAlgorithm? ContrastAlgorithm
		{
			get
			{
				return (global::CefSharp.DevTools.Overlay.ContrastAlgorithm?)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Overlay.ContrastAlgorithm?), this.contrastAlgorithm);
			}
			set
			{
				this.contrastAlgorithm = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06000DF0 RID: 3568 RVA: 0x00010024 File Offset: 0x0000E224
		// (set) Token: 0x06000DF1 RID: 3569 RVA: 0x0001002C File Offset: 0x0000E22C
		[global::System.Runtime.Serialization.DataMember(Name = "contrastAlgorithm", IsRequired = false)]
		internal string contrastAlgorithm { get; set; }

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06000DF2 RID: 3570 RVA: 0x00010035 File Offset: 0x0000E235
		// (set) Token: 0x06000DF3 RID: 3571 RVA: 0x0001003D File Offset: 0x0000E23D
		[global::System.Runtime.Serialization.DataMember(Name = "containerQueryContainerHighlightConfig", IsRequired = false)]
		public global::CefSharp.DevTools.Overlay.ContainerQueryContainerHighlightConfig ContainerQueryContainerHighlightConfig { get; set; }
	}
}
