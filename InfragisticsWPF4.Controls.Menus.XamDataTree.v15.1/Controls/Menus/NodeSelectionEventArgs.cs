using System;

namespace Infragistics.Controls.Menus
{
	// Token: 0x0200001B RID: 27
	public class NodeSelectionEventArgs : global::System.EventArgs
	{
		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600008E RID: 142 RVA: 0x0000348B File Offset: 0x0000168B
		// (set) Token: 0x0600008F RID: 143 RVA: 0x00003493 File Offset: 0x00001693
		public global::Infragistics.Controls.Menus.SelectedNodesCollection OriginalSelectedNodes { get; protected internal set; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000090 RID: 144 RVA: 0x0000349C File Offset: 0x0000169C
		// (set) Token: 0x06000091 RID: 145 RVA: 0x000034A4 File Offset: 0x000016A4
		public global::Infragistics.Controls.Menus.SelectedNodesCollection CurrentSelectedNodes { get; protected internal set; }
	}
}
