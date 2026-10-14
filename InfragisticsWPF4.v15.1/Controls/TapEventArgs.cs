using System;
using System.Windows;

namespace Infragistics.Controls
{
	// Token: 0x020000F5 RID: 245
	internal class TapEventArgs : global::Infragistics.Controls.TouchHandleableEventArgs
	{
		// Token: 0x06000897 RID: 2199 RVA: 0x0001DFB8 File Offset: 0x0001C1B8
		public TapEventArgs(global::System.Windows.Point p, global::System.Windows.UIElement element)
		{
			this.Point = p;
			this.Element = element;
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000898 RID: 2200 RVA: 0x0001DFCE File Offset: 0x0001C1CE
		// (set) Token: 0x06000899 RID: 2201 RVA: 0x0001DFD6 File Offset: 0x0001C1D6
		public global::System.Windows.Point Point { get; protected set; }

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x0600089A RID: 2202 RVA: 0x0001DFDF File Offset: 0x0001C1DF
		// (set) Token: 0x0600089B RID: 2203 RVA: 0x0001DFE7 File Offset: 0x0001C1E7
		public global::System.Windows.UIElement Element { get; protected set; }
	}
}
