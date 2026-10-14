using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002A5 RID: 677
	public class SelectedItemsChangedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06001E46 RID: 7750 RVA: 0x000818C1 File Offset: 0x0007FAC1
		internal SelectedItemsChangedEventArgs(global::System.Type type)
		{
			this._type = type;
		}

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x06001E47 RID: 7751 RVA: 0x000818D0 File Offset: 0x0007FAD0
		public global::System.Type Type
		{
			get
			{
				return this._type;
			}
		}

		// Token: 0x04000EED RID: 3821
		private global::System.Type _type;
	}
}
