using System;
using System.Windows.Controls;

namespace Infragistics.DragDrop
{
	// Token: 0x02000005 RID: 5
	public class DragObject
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00005442 File Offset: 0x00003642
		// (set) Token: 0x0600005B RID: 91 RVA: 0x0000544A File Offset: 0x0000364A
		public object Data { get; internal set; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00005453 File Offset: 0x00003653
		// (set) Token: 0x0600005D RID: 93 RVA: 0x0000545B File Offset: 0x0000365B
		public global::System.Windows.Controls.Image DragImage { get; internal set; }
	}
}
