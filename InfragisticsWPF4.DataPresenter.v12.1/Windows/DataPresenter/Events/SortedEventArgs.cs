using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002A8 RID: 680
	public class SortedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06001E52 RID: 7762 RVA: 0x0008196D File Offset: 0x0007FB6D
		public SortedEventArgs(global::Infragistics.Windows.DataPresenter.FieldLayout layout, global::Infragistics.Windows.DataPresenter.FieldSortDescription sortDescription)
		{
			this._layout = layout;
			this._sortDescription = sortDescription;
			this._field = sortDescription.Field;
		}

		// Token: 0x06001E53 RID: 7763 RVA: 0x0008198F File Offset: 0x0007FB8F
		internal SortedEventArgs(global::Infragistics.Windows.DataPresenter.FieldLayout layout, global::Infragistics.Windows.DataPresenter.Field field)
		{
			this._layout = layout;
			this._field = field;
		}

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x06001E54 RID: 7764 RVA: 0x000819A5 File Offset: 0x0007FBA5
		public global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				return this._layout;
			}
		}

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x06001E55 RID: 7765 RVA: 0x000819AD File Offset: 0x0007FBAD
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x06001E56 RID: 7766 RVA: 0x000819B5 File Offset: 0x0007FBB5
		public global::Infragistics.Windows.DataPresenter.FieldSortDescription SortDescription
		{
			get
			{
				return this._sortDescription;
			}
		}

		// Token: 0x04000EF4 RID: 3828
		private global::Infragistics.Windows.DataPresenter.FieldLayout _layout;

		// Token: 0x04000EF5 RID: 3829
		private global::Infragistics.Windows.DataPresenter.FieldSortDescription _sortDescription;

		// Token: 0x04000EF6 RID: 3830
		private global::Infragistics.Windows.DataPresenter.Field _field;
	}
}
