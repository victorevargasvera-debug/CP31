using System;
using System.ComponentModel;
using System.Windows;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001A8 RID: 424
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class SummaryRecordCellArea : global::Infragistics.Windows.DataPresenter.RecordCellAreaBase
	{
		// Token: 0x0600175F RID: 5983 RVA: 0x0006748C File Offset: 0x0006568C
		static SummaryRecordCellArea()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordCellArea)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
		}

		// Token: 0x06001761 RID: 5985 RVA: 0x000674E2 File Offset: 0x000656E2
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			if (global::System.Windows.FrameworkElement.DataContextProperty == e.Property)
			{
				this.UpdateContentAndTemplate();
			}
		}

		// Token: 0x06001762 RID: 5986 RVA: 0x00067500 File Offset: 0x00065700
		private void UpdateContentAndTemplate()
		{
			global::Infragistics.Windows.DataPresenter.SummaryRecord summaryRecord = base.DataContext as global::Infragistics.Windows.DataPresenter.SummaryRecord;
			global::System.Windows.DataTemplate contentTemplate = null;
			if (summaryRecord != null)
			{
				contentTemplate = summaryRecord.FieldLayout.StyleGenerator.GeneratedSummaryVirtualCellAreaTemplate;
			}
			base.Content = summaryRecord;
			base.ContentTemplate = contentTemplate;
		}
	}
}
