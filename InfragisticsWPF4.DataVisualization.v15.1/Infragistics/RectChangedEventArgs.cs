using System;
using System.Windows;

namespace Infragistics
{
	// Token: 0x02000050 RID: 80
	public sealed class RectChangedEventArgs : global::System.EventArgs
	{
		// Token: 0x06000436 RID: 1078 RVA: 0x000110B3 File Offset: 0x0000F2B3
		public RectChangedEventArgs(global::System.Windows.Rect oldRect, global::System.Windows.Rect newRect)
		{
			this.OldRect = oldRect;
			this.NewRect = newRect;
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000437 RID: 1079 RVA: 0x000110C9 File Offset: 0x0000F2C9
		// (set) Token: 0x06000438 RID: 1080 RVA: 0x000110D1 File Offset: 0x0000F2D1
		public global::System.Windows.Rect OldRect { get; private set; }

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000439 RID: 1081 RVA: 0x000110DA File Offset: 0x0000F2DA
		// (set) Token: 0x0600043A RID: 1082 RVA: 0x000110E2 File Offset: 0x0000F2E2
		public global::System.Windows.Rect NewRect { get; private set; }
	}
}
