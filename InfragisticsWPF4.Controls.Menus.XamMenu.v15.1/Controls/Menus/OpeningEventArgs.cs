using System;
using System.Collections.Generic;
using System.Windows;

namespace Infragistics.Controls.Menus
{
	// Token: 0x0200000F RID: 15
	public class OpeningEventArgs : global::Infragistics.CancellableEventArgs
	{
		// Token: 0x06000057 RID: 87 RVA: 0x0000314A File Offset: 0x0000134A
		internal OpeningEventArgs(global::Infragistics.Controls.Menus.XamContextMenu contextMenu, global::System.Windows.Point mouseLocation)
		{
			this.MouseClickLocation = mouseLocation;
			this._contextMenu = contextMenu;
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00003160 File Offset: 0x00001360
		// (set) Token: 0x06000059 RID: 89 RVA: 0x00003168 File Offset: 0x00001368
		public global::System.Windows.Point MouseClickLocation { get; internal set; }

		// Token: 0x0600005A RID: 90 RVA: 0x00003171 File Offset: 0x00001371
		public global::System.Collections.Generic.List<T> GetClickedElements<T>() where T : global::System.Windows.UIElement
		{
			return this._contextMenu.GetClickedElements<T>();
		}

		// Token: 0x0400002E RID: 46
		private readonly global::Infragistics.Controls.Menus.XamContextMenu _contextMenu;
	}
}
