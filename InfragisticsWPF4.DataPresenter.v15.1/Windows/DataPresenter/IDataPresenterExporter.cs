using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000119 RID: 281
	public interface IDataPresenterExporter
	{
		// Token: 0x060010E4 RID: 4324
		void BeginExport(global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter, global::Infragistics.Windows.DataPresenter.IExportOptions exportOptions);

		// Token: 0x060010E5 RID: 4325
		void ProcessRecord(global::Infragistics.Windows.DataPresenter.Record record, global::Infragistics.Windows.DataPresenter.ProcessRecordParams processRecordParams);

		// Token: 0x060010E6 RID: 4326
		void EndExport(bool cancelled);

		// Token: 0x060010E7 RID: 4327
		void OnObjectCloned(global::System.Windows.DependencyObject sourceDependencyObject, global::System.Windows.DependencyObject targetDependencyObject);

		// Token: 0x060010E8 RID: 4328
		bool InitializeRecord(global::Infragistics.Windows.DataPresenter.Record record, global::Infragistics.Windows.DataPresenter.ProcessRecordParams processRecordParams);
	}
}
