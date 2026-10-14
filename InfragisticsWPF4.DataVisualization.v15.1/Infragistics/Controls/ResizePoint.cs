using System;
using System.Windows;

namespace Infragistics.Controls
{
	// Token: 0x02000028 RID: 40
	internal class ResizePoint
	{
		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000215 RID: 533 RVA: 0x0000A5C2 File Offset: 0x000087C2
		// (set) Token: 0x06000216 RID: 534 RVA: 0x0000A5CA File Offset: 0x000087CA
		public uint PointerId { get; set; }

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000217 RID: 535 RVA: 0x0000A5D3 File Offset: 0x000087D3
		// (set) Token: 0x06000218 RID: 536 RVA: 0x0000A5DB File Offset: 0x000087DB
		public global::System.Windows.Point PreviousPoint { get; set; }

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000219 RID: 537 RVA: 0x0000A5E4 File Offset: 0x000087E4
		// (set) Token: 0x0600021A RID: 538 RVA: 0x0000A5EC File Offset: 0x000087EC
		public global::Infragistics.Controls.ThumbNode Thumb { get; set; }

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600021B RID: 539 RVA: 0x0000A5F5 File Offset: 0x000087F5
		// (set) Token: 0x0600021C RID: 540 RVA: 0x0000A5FD File Offset: 0x000087FD
		public global::System.Windows.Point FirstPoint { get; set; }

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600021D RID: 541 RVA: 0x0000A606 File Offset: 0x00008806
		// (set) Token: 0x0600021E RID: 542 RVA: 0x0000A60E File Offset: 0x0000880E
		public bool IsLeft { get; set; }

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600021F RID: 543 RVA: 0x0000A617 File Offset: 0x00008817
		// (set) Token: 0x06000220 RID: 544 RVA: 0x0000A61F File Offset: 0x0000881F
		public bool IsTop { get; set; }
	}
}
