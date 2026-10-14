using System;
using System.Windows;

namespace Infragistics.Controls
{
	// Token: 0x020000F3 RID: 243
	internal class PanEventArgs : global::Infragistics.Controls.TouchHandleableEventArgs
	{
		// Token: 0x0600088F RID: 2191 RVA: 0x0001DF60 File Offset: 0x0001C160
		public PanEventArgs(global::System.Windows.Point p)
		{
			this.DeltaPoint = p;
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000890 RID: 2192 RVA: 0x0001DF6F File Offset: 0x0001C16F
		// (set) Token: 0x06000891 RID: 2193 RVA: 0x0001DF77 File Offset: 0x0001C177
		public global::System.Windows.Point DeltaPoint { get; protected set; }
	}
}
