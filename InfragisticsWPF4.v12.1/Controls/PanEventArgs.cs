using System;
using System.Windows;

namespace Infragistics.Controls
{
	// Token: 0x020000D5 RID: 213
	internal class PanEventArgs : global::Infragistics.Controls.TouchHandleableEventArgs
	{
		// Token: 0x06000790 RID: 1936 RVA: 0x0001A3B4 File Offset: 0x000185B4
		public PanEventArgs(global::System.Windows.Point p)
		{
			this.DeltaPoint = p;
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000791 RID: 1937 RVA: 0x0001A3C3 File Offset: 0x000185C3
		// (set) Token: 0x06000792 RID: 1938 RVA: 0x0001A3CB File Offset: 0x000185CB
		public global::System.Windows.Point DeltaPoint { get; protected set; }
	}
}
