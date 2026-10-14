using System;

namespace Infragistics.Controls.Menus
{
	// Token: 0x02000011 RID: 17
	public abstract class CancellableNodeEventArgs : global::Infragistics.CancellableEventArgs
	{
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00003309 File Offset: 0x00001509
		// (set) Token: 0x06000061 RID: 97 RVA: 0x00003311 File Offset: 0x00001511
		public global::Infragistics.Controls.Menus.XamDataTreeNode Node { get; internal set; }
	}
}
