using System;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Windows.DockManager.Events
{
	// Token: 0x0200006B RID: 107
	public class PaneOptionsMenuOpeningEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x060003CB RID: 971 RVA: 0x00014FE7 File Offset: 0x000131E7
		public PaneOptionsMenuOpeningEventArgs(global::System.Windows.Controls.ItemCollection items)
		{
			global::Infragistics.Windows.DockManager.DockManagerUtilities.ThrowIfNull(items, "items");
			this._items = items;
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060003CC RID: 972 RVA: 0x00015001 File Offset: 0x00013201
		public global::System.Windows.Controls.ItemCollection Items
		{
			get
			{
				return this._items;
			}
		}

		// Token: 0x04000279 RID: 633
		private global::System.Windows.Controls.ItemCollection _items;
	}
}
