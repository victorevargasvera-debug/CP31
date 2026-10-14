using System;
using Infragistics.Windows.Controls.Events;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002EA RID: 746
	public class SortingEventArgs : global::Infragistics.Windows.Controls.Events.CancelableRoutedEventArgs
	{
		// Token: 0x060022D3 RID: 8915 RVA: 0x00098092 File Offset: 0x00096292
		public SortingEventArgs(global::Infragistics.Windows.DataPresenter.FieldLayout layout, global::Infragistics.Windows.DataPresenter.FieldSortDescription sortDescription, bool replaceExistingSortCriteria)
		{
			this._layout = layout;
			this._sortDescription = sortDescription;
			this._replaceExistingSortCriteria = replaceExistingSortCriteria;
			this._field = sortDescription.Field;
		}

		// Token: 0x060022D4 RID: 8916 RVA: 0x000980BB File Offset: 0x000962BB
		internal SortingEventArgs(global::Infragistics.Windows.DataPresenter.FieldLayout layout, global::Infragistics.Windows.DataPresenter.Field field)
		{
			this._layout = layout;
			this._field = field;
			this._replaceExistingSortCriteria = false;
		}

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x060022D5 RID: 8917 RVA: 0x000980D8 File Offset: 0x000962D8
		public global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				return this._layout;
			}
		}

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x060022D6 RID: 8918 RVA: 0x000980E0 File Offset: 0x000962E0
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x060022D7 RID: 8919 RVA: 0x000980E8 File Offset: 0x000962E8
		public global::Infragistics.Windows.DataPresenter.FieldSortDescription SortDescription
		{
			get
			{
				return this._sortDescription;
			}
		}

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x060022D8 RID: 8920 RVA: 0x000980F0 File Offset: 0x000962F0
		// (set) Token: 0x060022D9 RID: 8921 RVA: 0x000980F8 File Offset: 0x000962F8
		public bool ReplaceExistingSortCriteria
		{
			get
			{
				return this._replaceExistingSortCriteria;
			}
			set
			{
				this._replaceExistingSortCriteria = value;
			}
		}

		// Token: 0x0400115A RID: 4442
		private global::Infragistics.Windows.DataPresenter.FieldLayout _layout;

		// Token: 0x0400115B RID: 4443
		private global::Infragistics.Windows.DataPresenter.FieldSortDescription _sortDescription;

		// Token: 0x0400115C RID: 4444
		private bool _replaceExistingSortCriteria;

		// Token: 0x0400115D RID: 4445
		private global::Infragistics.Windows.DataPresenter.Field _field;
	}
}
