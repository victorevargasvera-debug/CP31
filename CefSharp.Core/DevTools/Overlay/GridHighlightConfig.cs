using System;
using System.Runtime.Serialization;
using CefSharp.DevTools.DOM;

namespace CefSharp.DevTools.Overlay
{
	// Token: 0x020001C1 RID: 449
	[global::System.Runtime.Serialization.DataContract]
	public class GridHighlightConfig : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06000D7D RID: 3453 RVA: 0x0000FBFB File Offset: 0x0000DDFB
		// (set) Token: 0x06000D7E RID: 3454 RVA: 0x0000FC03 File Offset: 0x0000DE03
		[global::System.Runtime.Serialization.DataMember(Name = "showGridExtensionLines", IsRequired = false)]
		public bool? ShowGridExtensionLines { get; set; }

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06000D7F RID: 3455 RVA: 0x0000FC0C File Offset: 0x0000DE0C
		// (set) Token: 0x06000D80 RID: 3456 RVA: 0x0000FC14 File Offset: 0x0000DE14
		[global::System.Runtime.Serialization.DataMember(Name = "showPositiveLineNumbers", IsRequired = false)]
		public bool? ShowPositiveLineNumbers { get; set; }

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06000D81 RID: 3457 RVA: 0x0000FC1D File Offset: 0x0000DE1D
		// (set) Token: 0x06000D82 RID: 3458 RVA: 0x0000FC25 File Offset: 0x0000DE25
		[global::System.Runtime.Serialization.DataMember(Name = "showNegativeLineNumbers", IsRequired = false)]
		public bool? ShowNegativeLineNumbers { get; set; }

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06000D83 RID: 3459 RVA: 0x0000FC2E File Offset: 0x0000DE2E
		// (set) Token: 0x06000D84 RID: 3460 RVA: 0x0000FC36 File Offset: 0x0000DE36
		[global::System.Runtime.Serialization.DataMember(Name = "showAreaNames", IsRequired = false)]
		public bool? ShowAreaNames { get; set; }

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06000D85 RID: 3461 RVA: 0x0000FC3F File Offset: 0x0000DE3F
		// (set) Token: 0x06000D86 RID: 3462 RVA: 0x0000FC47 File Offset: 0x0000DE47
		[global::System.Runtime.Serialization.DataMember(Name = "showLineNames", IsRequired = false)]
		public bool? ShowLineNames { get; set; }

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06000D87 RID: 3463 RVA: 0x0000FC50 File Offset: 0x0000DE50
		// (set) Token: 0x06000D88 RID: 3464 RVA: 0x0000FC58 File Offset: 0x0000DE58
		[global::System.Runtime.Serialization.DataMember(Name = "showTrackSizes", IsRequired = false)]
		public bool? ShowTrackSizes { get; set; }

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06000D89 RID: 3465 RVA: 0x0000FC61 File Offset: 0x0000DE61
		// (set) Token: 0x06000D8A RID: 3466 RVA: 0x0000FC69 File Offset: 0x0000DE69
		[global::System.Runtime.Serialization.DataMember(Name = "gridBorderColor", IsRequired = false)]
		public global::CefSharp.DevTools.DOM.RGBA GridBorderColor { get; set; }

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06000D8B RID: 3467 RVA: 0x0000FC72 File Offset: 0x0000DE72
		// (set) Token: 0x06000D8C RID: 3468 RVA: 0x0000FC7A File Offset: 0x0000DE7A
		[global::System.Runtime.Serialization.DataMember(Name = "cellBorderColor", IsRequired = false)]
		public global::CefSharp.DevTools.DOM.RGBA CellBorderColor { get; set; }

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06000D8D RID: 3469 RVA: 0x0000FC83 File Offset: 0x0000DE83
		// (set) Token: 0x06000D8E RID: 3470 RVA: 0x0000FC8B File Offset: 0x0000DE8B
		[global::System.Runtime.Serialization.DataMember(Name = "rowLineColor", IsRequired = false)]
		public global::CefSharp.DevTools.DOM.RGBA RowLineColor { get; set; }

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06000D8F RID: 3471 RVA: 0x0000FC94 File Offset: 0x0000DE94
		// (set) Token: 0x06000D90 RID: 3472 RVA: 0x0000FC9C File Offset: 0x0000DE9C
		[global::System.Runtime.Serialization.DataMember(Name = "columnLineColor", IsRequired = false)]
		public global::CefSharp.DevTools.DOM.RGBA ColumnLineColor { get; set; }

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06000D91 RID: 3473 RVA: 0x0000FCA5 File Offset: 0x0000DEA5
		// (set) Token: 0x06000D92 RID: 3474 RVA: 0x0000FCAD File Offset: 0x0000DEAD
		[global::System.Runtime.Serialization.DataMember(Name = "gridBorderDash", IsRequired = false)]
		public bool? GridBorderDash { get; set; }

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06000D93 RID: 3475 RVA: 0x0000FCB6 File Offset: 0x0000DEB6
		// (set) Token: 0x06000D94 RID: 3476 RVA: 0x0000FCBE File Offset: 0x0000DEBE
		[global::System.Runtime.Serialization.DataMember(Name = "cellBorderDash", IsRequired = false)]
		public bool? CellBorderDash { get; set; }

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06000D95 RID: 3477 RVA: 0x0000FCC7 File Offset: 0x0000DEC7
		// (set) Token: 0x06000D96 RID: 3478 RVA: 0x0000FCCF File Offset: 0x0000DECF
		[global::System.Runtime.Serialization.DataMember(Name = "rowLineDash", IsRequired = false)]
		public bool? RowLineDash { get; set; }

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06000D97 RID: 3479 RVA: 0x0000FCD8 File Offset: 0x0000DED8
		// (set) Token: 0x06000D98 RID: 3480 RVA: 0x0000FCE0 File Offset: 0x0000DEE0
		[global::System.Runtime.Serialization.DataMember(Name = "columnLineDash", IsRequired = false)]
		public bool? ColumnLineDash { get; set; }

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06000D99 RID: 3481 RVA: 0x0000FCE9 File Offset: 0x0000DEE9
		// (set) Token: 0x06000D9A RID: 3482 RVA: 0x0000FCF1 File Offset: 0x0000DEF1
		[global::System.Runtime.Serialization.DataMember(Name = "rowGapColor", IsRequired = false)]
		public global::CefSharp.DevTools.DOM.RGBA RowGapColor { get; set; }

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06000D9B RID: 3483 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		// (set) Token: 0x06000D9C RID: 3484 RVA: 0x0000FD02 File Offset: 0x0000DF02
		[global::System.Runtime.Serialization.DataMember(Name = "rowHatchColor", IsRequired = false)]
		public global::CefSharp.DevTools.DOM.RGBA RowHatchColor { get; set; }

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06000D9D RID: 3485 RVA: 0x0000FD0B File Offset: 0x0000DF0B
		// (set) Token: 0x06000D9E RID: 3486 RVA: 0x0000FD13 File Offset: 0x0000DF13
		[global::System.Runtime.Serialization.DataMember(Name = "columnGapColor", IsRequired = false)]
		public global::CefSharp.DevTools.DOM.RGBA ColumnGapColor { get; set; }

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06000D9F RID: 3487 RVA: 0x0000FD1C File Offset: 0x0000DF1C
		// (set) Token: 0x06000DA0 RID: 3488 RVA: 0x0000FD24 File Offset: 0x0000DF24
		[global::System.Runtime.Serialization.DataMember(Name = "columnHatchColor", IsRequired = false)]
		public global::CefSharp.DevTools.DOM.RGBA ColumnHatchColor { get; set; }

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06000DA1 RID: 3489 RVA: 0x0000FD2D File Offset: 0x0000DF2D
		// (set) Token: 0x06000DA2 RID: 3490 RVA: 0x0000FD35 File Offset: 0x0000DF35
		[global::System.Runtime.Serialization.DataMember(Name = "areaBorderColor", IsRequired = false)]
		public global::CefSharp.DevTools.DOM.RGBA AreaBorderColor { get; set; }

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06000DA3 RID: 3491 RVA: 0x0000FD3E File Offset: 0x0000DF3E
		// (set) Token: 0x06000DA4 RID: 3492 RVA: 0x0000FD46 File Offset: 0x0000DF46
		[global::System.Runtime.Serialization.DataMember(Name = "gridBackgroundColor", IsRequired = false)]
		public global::CefSharp.DevTools.DOM.RGBA GridBackgroundColor { get; set; }
	}
}
