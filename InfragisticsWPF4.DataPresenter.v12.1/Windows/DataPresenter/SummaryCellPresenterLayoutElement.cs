using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200005A RID: 90
	public sealed class SummaryCellPresenterLayoutElement : global::Infragistics.Windows.DataPresenter.CellPresenterLayoutElementBase
	{
		// Token: 0x060004AC RID: 1196 RVA: 0x000109A8 File Offset: 0x0000EBA8
		internal override global::System.Windows.FrameworkElement CreateCellValuePresenter(global::System.Windows.FrameworkElement oldElem)
		{
			global::Infragistics.Windows.DataPresenter.SummaryResultsPresenter summaryResultsPresenter = oldElem as global::Infragistics.Windows.DataPresenter.SummaryResultsPresenter;
			if (summaryResultsPresenter == null)
			{
				summaryResultsPresenter = new global::Infragistics.Windows.DataPresenter.SummaryResultsPresenter();
			}
			return summaryResultsPresenter;
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x000109C6 File Offset: 0x0000EBC6
		internal override global::System.Windows.FrameworkElement CreateLabelPresenter(global::System.Windows.FrameworkElement oldElem)
		{
			return global::Infragistics.Windows.DataPresenter.CellPresenterLayoutElement.CreateLabelPresenter(oldElem, base.Field);
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x000109D4 File Offset: 0x0000EBD4
		internal override void GetFieldAndRecordForCaching(out global::Infragistics.Windows.DataPresenter.Field field, out global::Infragistics.Windows.DataPresenter.Record record)
		{
			if (this._cachedParentCellPresenter == null)
			{
				this._cachedParentCellPresenter = (global::Infragistics.Windows.Utilities.GetAncestorFromType(this, typeof(global::Infragistics.Windows.DataPresenter.SummaryCellPresenter), false, null, typeof(global::Infragistics.Windows.DataPresenter.RecordListControl)) as global::Infragistics.Windows.DataPresenter.SummaryCellPresenter);
			}
			field = ((this._cachedParentCellPresenter != null) ? this._cachedParentCellPresenter.Field : null);
			record = (base.DataContext as global::Infragistics.Windows.DataPresenter.Record);
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00010A38 File Offset: 0x0000EC38
		internal override void InitializeCellValuePresenter(global::System.Windows.FrameworkElement cvp)
		{
			global::Infragistics.Windows.DataPresenter.SummaryResultsPresenter summaryResultsPresenter = cvp as global::Infragistics.Windows.DataPresenter.SummaryResultsPresenter;
			if (summaryResultsPresenter != null)
			{
				summaryResultsPresenter.SetValue(global::Infragistics.Windows.DataPresenter.DataItemPresenter.FieldProperty, base.Field);
			}
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00010A60 File Offset: 0x0000EC60
		internal override void ReleaseCellValuePresenter(global::System.Windows.FrameworkElement cellValuePresenter, bool recycle)
		{
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00010A62 File Offset: 0x0000EC62
		internal override void ReleaseLabelPresenter(global::System.Windows.FrameworkElement labelPresenter, bool recycle)
		{
			if (recycle)
			{
				global::Infragistics.Windows.DataPresenter.CellPresenterLayoutElement.ReleaseLabelPresenter(labelPresenter, base.Field);
			}
		}

		// Token: 0x04000138 RID: 312
		private global::Infragistics.Windows.DataPresenter.SummaryCellPresenter _cachedParentCellPresenter;
	}
}
