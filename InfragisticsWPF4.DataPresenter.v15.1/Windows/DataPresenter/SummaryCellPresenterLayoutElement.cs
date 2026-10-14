using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200005E RID: 94
	public sealed class SummaryCellPresenterLayoutElement : global::Infragistics.Windows.DataPresenter.CellPresenterLayoutElementBase
	{
		// Token: 0x0600050B RID: 1291 RVA: 0x000121DC File Offset: 0x000103DC
		internal override global::System.Windows.FrameworkElement CreateCellValuePresenter(global::System.Windows.FrameworkElement oldElem)
		{
			global::Infragistics.Windows.DataPresenter.SummaryResultsPresenter summaryResultsPresenter = oldElem as global::Infragistics.Windows.DataPresenter.SummaryResultsPresenter;
			if (summaryResultsPresenter == null)
			{
				summaryResultsPresenter = new global::Infragistics.Windows.DataPresenter.SummaryResultsPresenter();
			}
			return summaryResultsPresenter;
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x000121FA File Offset: 0x000103FA
		internal override global::System.Windows.FrameworkElement CreateLabelPresenter(global::System.Windows.FrameworkElement oldElem)
		{
			return global::Infragistics.Windows.DataPresenter.CellPresenterLayoutElement.CreateLabelPresenter(oldElem, base.Field);
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00012208 File Offset: 0x00010408
		internal override void GetFieldAndRecordForCaching(out global::Infragistics.Windows.DataPresenter.Field field, out global::Infragistics.Windows.DataPresenter.Record record)
		{
			if (this._cachedParentCellPresenter == null)
			{
				this._cachedParentCellPresenter = (global::Infragistics.Windows.Utilities.GetAncestorFromType(this, typeof(global::Infragistics.Windows.DataPresenter.SummaryCellPresenter), false, null, typeof(global::Infragistics.Windows.DataPresenter.RecordListControl)) as global::Infragistics.Windows.DataPresenter.SummaryCellPresenter);
			}
			field = ((this._cachedParentCellPresenter != null) ? this._cachedParentCellPresenter.Field : null);
			record = (base.DataContext as global::Infragistics.Windows.DataPresenter.Record);
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x0001226C File Offset: 0x0001046C
		internal override void InitializeCellValuePresenter(global::System.Windows.FrameworkElement cvp)
		{
			global::Infragistics.Windows.DataPresenter.SummaryResultsPresenter summaryResultsPresenter = cvp as global::Infragistics.Windows.DataPresenter.SummaryResultsPresenter;
			if (summaryResultsPresenter != null)
			{
				summaryResultsPresenter.SetValue(global::Infragistics.Windows.DataPresenter.DataItemPresenter.FieldProperty, base.Field);
			}
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00012294 File Offset: 0x00010494
		internal override void ReleaseCellValuePresenter(global::System.Windows.FrameworkElement cellValuePresenter, bool recycle)
		{
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00012296 File Offset: 0x00010496
		internal override void ReleaseLabelPresenter(global::System.Windows.FrameworkElement labelPresenter, bool recycle)
		{
			if (recycle)
			{
				global::Infragistics.Windows.DataPresenter.CellPresenterLayoutElement.ReleaseLabelPresenter(labelPresenter, base.Field);
			}
		}

		// Token: 0x04000163 RID: 355
		private global::Infragistics.Windows.DataPresenter.SummaryCellPresenter _cachedParentCellPresenter;
	}
}
