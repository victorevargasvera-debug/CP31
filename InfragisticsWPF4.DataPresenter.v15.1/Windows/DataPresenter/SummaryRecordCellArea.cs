using System;
using System.ComponentModel;
using System.Windows;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001CB RID: 459
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class SummaryRecordCellArea : global::Infragistics.Windows.DataPresenter.RecordCellAreaBase
	{
		// Token: 0x06001B1D RID: 6941 RVA: 0x0007A0B8 File Offset: 0x000782B8
		static SummaryRecordCellArea()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordCellArea)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
		}

		// Token: 0x06001B1F RID: 6943 RVA: 0x0007A10E File Offset: 0x0007830E
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			if (global::System.Windows.FrameworkElement.DataContextProperty == e.Property)
			{
				this.UpdateContentAndTemplate();
			}
		}

		// Token: 0x06001B20 RID: 6944 RVA: 0x0007A12C File Offset: 0x0007832C
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
