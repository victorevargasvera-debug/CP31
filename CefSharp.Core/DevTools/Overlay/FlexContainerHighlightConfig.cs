using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Overlay
{
	// Token: 0x020001C2 RID: 450
	[global::System.Runtime.Serialization.DataContract]
	public class FlexContainerHighlightConfig : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06000DA6 RID: 3494 RVA: 0x0000FD57 File Offset: 0x0000DF57
		// (set) Token: 0x06000DA7 RID: 3495 RVA: 0x0000FD5F File Offset: 0x0000DF5F
		[global::System.Runtime.Serialization.DataMember(Name = "containerBorder", IsRequired = false)]
		public global::CefSharp.DevTools.Overlay.LineStyle ContainerBorder { get; set; }

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06000DA8 RID: 3496 RVA: 0x0000FD68 File Offset: 0x0000DF68
		// (set) Token: 0x06000DA9 RID: 3497 RVA: 0x0000FD70 File Offset: 0x0000DF70
		[global::System.Runtime.Serialization.DataMember(Name = "lineSeparator", IsRequired = false)]
		public global::CefSharp.DevTools.Overlay.LineStyle LineSeparator { get; set; }

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06000DAA RID: 3498 RVA: 0x0000FD79 File Offset: 0x0000DF79
		// (set) Token: 0x06000DAB RID: 3499 RVA: 0x0000FD81 File Offset: 0x0000DF81
		[global::System.Runtime.Serialization.DataMember(Name = "itemSeparator", IsRequired = false)]
		public global::CefSharp.DevTools.Overlay.LineStyle ItemSeparator { get; set; }

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06000DAC RID: 3500 RVA: 0x0000FD8A File Offset: 0x0000DF8A
		// (set) Token: 0x06000DAD RID: 3501 RVA: 0x0000FD92 File Offset: 0x0000DF92
		[global::System.Runtime.Serialization.DataMember(Name = "mainDistributedSpace", IsRequired = false)]
		public global::CefSharp.DevTools.Overlay.BoxStyle MainDistributedSpace { get; set; }

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06000DAE RID: 3502 RVA: 0x0000FD9B File Offset: 0x0000DF9B
		// (set) Token: 0x06000DAF RID: 3503 RVA: 0x0000FDA3 File Offset: 0x0000DFA3
		[global::System.Runtime.Serialization.DataMember(Name = "crossDistributedSpace", IsRequired = false)]
		public global::CefSharp.DevTools.Overlay.BoxStyle CrossDistributedSpace { get; set; }

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06000DB0 RID: 3504 RVA: 0x0000FDAC File Offset: 0x0000DFAC
		// (set) Token: 0x06000DB1 RID: 3505 RVA: 0x0000FDB4 File Offset: 0x0000DFB4
		[global::System.Runtime.Serialization.DataMember(Name = "rowGapSpace", IsRequired = false)]
		public global::CefSharp.DevTools.Overlay.BoxStyle RowGapSpace { get; set; }

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06000DB2 RID: 3506 RVA: 0x0000FDBD File Offset: 0x0000DFBD
		// (set) Token: 0x06000DB3 RID: 3507 RVA: 0x0000FDC5 File Offset: 0x0000DFC5
		[global::System.Runtime.Serialization.DataMember(Name = "columnGapSpace", IsRequired = false)]
		public global::CefSharp.DevTools.Overlay.BoxStyle ColumnGapSpace { get; set; }

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06000DB4 RID: 3508 RVA: 0x0000FDCE File Offset: 0x0000DFCE
		// (set) Token: 0x06000DB5 RID: 3509 RVA: 0x0000FDD6 File Offset: 0x0000DFD6
		[global::System.Runtime.Serialization.DataMember(Name = "crossAlignment", IsRequired = false)]
		public global::CefSharp.DevTools.Overlay.LineStyle CrossAlignment { get; set; }
	}
}
