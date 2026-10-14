using System;
using System.Windows;

namespace Infragistics.Controls.Menus
{
	// Token: 0x02000018 RID: 24
	public class TreeExitEditingEventArgs : global::Infragistics.Controls.Menus.CancellableNodeEventArgs
	{
		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000079 RID: 121 RVA: 0x000033DA File Offset: 0x000015DA
		// (set) Token: 0x0600007A RID: 122 RVA: 0x000033E2 File Offset: 0x000015E2
		public object NewValue { get; set; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600007B RID: 123 RVA: 0x000033EB File Offset: 0x000015EB
		// (set) Token: 0x0600007C RID: 124 RVA: 0x000033F3 File Offset: 0x000015F3
		public bool EditingCanceled { get; protected internal set; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600007D RID: 125 RVA: 0x000033FC File Offset: 0x000015FC
		// (set) Token: 0x0600007E RID: 126 RVA: 0x00003404 File Offset: 0x00001604
		public global::System.Windows.FrameworkElement Editor { get; protected internal set; }
	}
}
