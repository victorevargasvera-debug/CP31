using System;

namespace Infragistics.Controls.Menus
{
	// Token: 0x0200001F RID: 31
	public class ActiveNodeChangingEventArgs : global::Infragistics.CancellableEventArgs
	{
		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600009A RID: 154 RVA: 0x000034F6 File Offset: 0x000016F6
		// (set) Token: 0x0600009B RID: 155 RVA: 0x000034FE File Offset: 0x000016FE
		public global::Infragistics.Controls.Menus.XamDataTreeNode OriginalActiveTreeNode { get; protected internal set; }

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00003507 File Offset: 0x00001707
		// (set) Token: 0x0600009D RID: 157 RVA: 0x0000350F File Offset: 0x0000170F
		public global::Infragistics.Controls.Menus.XamDataTreeNode NewActiveTreeNode { get; protected internal set; }
	}
}
