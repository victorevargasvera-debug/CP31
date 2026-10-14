using System;
using System.Collections.Generic;
using System.Windows;

namespace Infragistics.Controls.Menus
{
	// Token: 0x0200000E RID: 14
	public class OpenedEventArgs : global::System.EventArgs
	{
		// Token: 0x06000051 RID: 81 RVA: 0x000030FE File Offset: 0x000012FE
		internal OpenedEventArgs(global::Infragistics.Controls.Menus.XamContextMenu contextMenu, global::System.Windows.Point mouseLocation, global::System.Windows.Point menuLocation)
		{
			this.MouseClickLocation = mouseLocation;
			this.ContextMenuLocation = menuLocation;
			this._contextMenu = contextMenu;
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000052 RID: 82 RVA: 0x0000311B File Offset: 0x0000131B
		// (set) Token: 0x06000053 RID: 83 RVA: 0x00003123 File Offset: 0x00001323
		public global::System.Windows.Point MouseClickLocation { get; internal set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000054 RID: 84 RVA: 0x0000312C File Offset: 0x0000132C
		// (set) Token: 0x06000055 RID: 85 RVA: 0x00003134 File Offset: 0x00001334
		public global::System.Windows.Point ContextMenuLocation { get; internal set; }

		// Token: 0x06000056 RID: 86 RVA: 0x0000313D File Offset: 0x0000133D
		public global::System.Collections.Generic.List<T> GetClickedElements<T>() where T : global::System.Windows.UIElement
		{
			return this._contextMenu.GetClickedElements<T>();
		}

		// Token: 0x0400002B RID: 43
		private readonly global::Infragistics.Controls.Menus.XamContextMenu _contextMenu;
	}
}
