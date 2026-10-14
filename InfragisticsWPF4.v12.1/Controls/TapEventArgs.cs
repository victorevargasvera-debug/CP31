using System;
using System.Windows;

namespace Infragistics.Controls
{
	// Token: 0x020000D7 RID: 215
	internal class TapEventArgs : global::Infragistics.Controls.TouchHandleableEventArgs
	{
		// Token: 0x06000798 RID: 1944 RVA: 0x0001A40C File Offset: 0x0001860C
		public TapEventArgs(global::System.Windows.Point p, global::System.Windows.UIElement element)
		{
			this.Point = p;
			this.Element = element;
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000799 RID: 1945 RVA: 0x0001A422 File Offset: 0x00018622
		// (set) Token: 0x0600079A RID: 1946 RVA: 0x0001A42A File Offset: 0x0001862A
		public global::System.Windows.Point Point { get; protected set; }

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x0600079B RID: 1947 RVA: 0x0001A433 File Offset: 0x00018633
		// (set) Token: 0x0600079C RID: 1948 RVA: 0x0001A43B File Offset: 0x0001863B
		public global::System.Windows.UIElement Element { get; protected set; }
	}
}
