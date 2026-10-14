using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020000FD RID: 253
	public interface IDataPresenterExporter
	{
		// Token: 0x06000D84 RID: 3460
		void BeginExport(global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter, global::Infragistics.Windows.DataPresenter.IExportOptions exportOptions);

		// Token: 0x06000D85 RID: 3461
		void ProcessRecord(global::Infragistics.Windows.DataPresenter.Record record, global::Infragistics.Windows.DataPresenter.ProcessRecordParams processRecordParams);

		// Token: 0x06000D86 RID: 3462
		void EndExport(bool cancelled);

		// Token: 0x06000D87 RID: 3463
		void OnObjectCloned(global::System.Windows.DependencyObject sourceDependencyObject, global::System.Windows.DependencyObject targetDependencyObject);

		// Token: 0x06000D88 RID: 3464
		bool InitializeRecord(global::Infragistics.Windows.DataPresenter.Record record, global::Infragistics.Windows.DataPresenter.ProcessRecordParams processRecordParams);
	}
}
