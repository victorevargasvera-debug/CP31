using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002EB RID: 747
	public class SortedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x060022DA RID: 8922 RVA: 0x00098101 File Offset: 0x00096301
		public SortedEventArgs(global::Infragistics.Windows.DataPresenter.FieldLayout layout, global::Infragistics.Windows.DataPresenter.FieldSortDescription sortDescription)
		{
			this._layout = layout;
			this._sortDescription = sortDescription;
			this._field = sortDescription.Field;
		}

		// Token: 0x060022DB RID: 8923 RVA: 0x00098123 File Offset: 0x00096323
		internal SortedEventArgs(global::Infragistics.Windows.DataPresenter.FieldLayout layout, global::Infragistics.Windows.DataPresenter.Field field)
		{
			this._layout = layout;
			this._field = field;
		}

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x060022DC RID: 8924 RVA: 0x00098139 File Offset: 0x00096339
		public global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				return this._layout;
			}
		}

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x060022DD RID: 8925 RVA: 0x00098141 File Offset: 0x00096341
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x060022DE RID: 8926 RVA: 0x00098149 File Offset: 0x00096349
		public global::Infragistics.Windows.DataPresenter.FieldSortDescription SortDescription
		{
			get
			{
				return this._sortDescription;
			}
		}

		// Token: 0x0400115E RID: 4446
		private global::Infragistics.Windows.DataPresenter.FieldLayout _layout;

		// Token: 0x0400115F RID: 4447
		private global::Infragistics.Windows.DataPresenter.FieldSortDescription _sortDescription;

		// Token: 0x04001160 RID: 4448
		private global::Infragistics.Windows.DataPresenter.Field _field;
	}
}
