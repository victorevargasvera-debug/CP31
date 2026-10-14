using System;
using System.Windows.Controls;

namespace Infragistics.DragDrop
{
	// Token: 0x02000005 RID: 5
	public class DragObject
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000058 RID: 88 RVA: 0x000052AE File Offset: 0x000034AE
		// (set) Token: 0x06000059 RID: 89 RVA: 0x000052B6 File Offset: 0x000034B6
		public object Data { get; internal set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600005A RID: 90 RVA: 0x000052BF File Offset: 0x000034BF
		// (set) Token: 0x0600005B RID: 91 RVA: 0x000052C7 File Offset: 0x000034C7
		public global::System.Windows.Controls.Image DragImage { get; internal set; }
	}
}
