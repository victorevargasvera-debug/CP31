using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002E8 RID: 744
	public class SelectedItemsChangedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x060022CE RID: 8910 RVA: 0x00098055 File Offset: 0x00096255
		internal SelectedItemsChangedEventArgs(global::System.Type type)
		{
			this._type = type;
		}

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x060022CF RID: 8911 RVA: 0x00098064 File Offset: 0x00096264
		public global::System.Type Type
		{
			get
			{
				return this._type;
			}
		}

		// Token: 0x04001157 RID: 4439
		private global::System.Type _type;
	}
}
