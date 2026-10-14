using System;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Windows.DockManager.Events
{
	// Token: 0x02000069 RID: 105
	public class FilesMenuOpeningEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x060003C6 RID: 966 RVA: 0x00014F9A File Offset: 0x0001319A
		public FilesMenuOpeningEventArgs(global::System.Windows.Controls.ItemCollection items)
		{
			global::Infragistics.Windows.DockManager.DockManagerUtilities.ThrowIfNull(items, "items");
			this._items = items;
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x00014FB4 File Offset: 0x000131B4
		public global::System.Windows.Controls.ItemCollection Items
		{
			get
			{
				return this._items;
			}
		}

		// Token: 0x04000277 RID: 631
		private global::System.Windows.Controls.ItemCollection _items;
	}
}
