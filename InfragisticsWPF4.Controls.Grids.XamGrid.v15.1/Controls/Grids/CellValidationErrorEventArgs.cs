using System;
using System.Windows.Controls;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020001B6 RID: 438
	public class CellValidationErrorEventArgs : global::System.EventArgs
	{
		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000BC2 RID: 3010 RVA: 0x0002A4F1 File Offset: 0x000286F1
		// (set) Token: 0x06000BC3 RID: 3011 RVA: 0x0002A4F9 File Offset: 0x000286F9
		public global::System.Windows.Controls.ValidationErrorEventArgs ValidationErrorEventArgs { get; protected internal set; }

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000BC4 RID: 3012 RVA: 0x0002A502 File Offset: 0x00028702
		// (set) Token: 0x06000BC5 RID: 3013 RVA: 0x0002A50A File Offset: 0x0002870A
		public global::Infragistics.Controls.Grids.Cell Cell { get; protected internal set; }

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000BC6 RID: 3014 RVA: 0x0002A513 File Offset: 0x00028713
		// (set) Token: 0x06000BC7 RID: 3015 RVA: 0x0002A51B File Offset: 0x0002871B
		public bool Handled { get; set; }
	}
}
