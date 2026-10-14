using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002C7 RID: 711
	public class FieldLayoutInitializedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06002261 RID: 8801 RVA: 0x00097AC8 File Offset: 0x00095CC8
		public FieldLayoutInitializedEventArgs(global::Infragistics.Windows.DataPresenter.FieldLayout layout)
		{
			this._layout = layout;
		}

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x06002262 RID: 8802 RVA: 0x00097AD7 File Offset: 0x00095CD7
		public global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				return this._layout;
			}
		}

		// Token: 0x04001117 RID: 4375
		private global::Infragistics.Windows.DataPresenter.FieldLayout _layout;
	}
}
