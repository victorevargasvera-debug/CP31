using System;
using Infragistics.Windows.Controls.Events;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002A7 RID: 679
	public class SortingEventArgs : global::Infragistics.Windows.Controls.Events.CancelableRoutedEventArgs
	{
		// Token: 0x06001E4B RID: 7755 RVA: 0x000818FE File Offset: 0x0007FAFE
		public SortingEventArgs(global::Infragistics.Windows.DataPresenter.FieldLayout layout, global::Infragistics.Windows.DataPresenter.FieldSortDescription sortDescription, bool replaceExistingSortCriteria)
		{
			this._layout = layout;
			this._sortDescription = sortDescription;
			this._replaceExistingSortCriteria = replaceExistingSortCriteria;
			this._field = sortDescription.Field;
		}

		// Token: 0x06001E4C RID: 7756 RVA: 0x00081927 File Offset: 0x0007FB27
		internal SortingEventArgs(global::Infragistics.Windows.DataPresenter.FieldLayout layout, global::Infragistics.Windows.DataPresenter.Field field)
		{
			this._layout = layout;
			this._field = field;
			this._replaceExistingSortCriteria = false;
		}

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x06001E4D RID: 7757 RVA: 0x00081944 File Offset: 0x0007FB44
		public global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				return this._layout;
			}
		}

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x06001E4E RID: 7758 RVA: 0x0008194C File Offset: 0x0007FB4C
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x06001E4F RID: 7759 RVA: 0x00081954 File Offset: 0x0007FB54
		public global::Infragistics.Windows.DataPresenter.FieldSortDescription SortDescription
		{
			get
			{
				return this._sortDescription;
			}
		}

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x06001E50 RID: 7760 RVA: 0x0008195C File Offset: 0x0007FB5C
		// (set) Token: 0x06001E51 RID: 7761 RVA: 0x00081964 File Offset: 0x0007FB64
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

		// Token: 0x04000EF0 RID: 3824
		private global::Infragistics.Windows.DataPresenter.FieldLayout _layout;

		// Token: 0x04000EF1 RID: 3825
		private global::Infragistics.Windows.DataPresenter.FieldSortDescription _sortDescription;

		// Token: 0x04000EF2 RID: 3826
		private bool _replaceExistingSortCriteria;

		// Token: 0x04000EF3 RID: 3827
		private global::Infragistics.Windows.DataPresenter.Field _field;
	}
}
