using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020000FE RID: 254
	public interface IDataPresenterExporterAsync : global::Infragistics.Windows.DataPresenter.IDataPresenterExporter
	{
		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000D89 RID: 3465
		global::Infragistics.Windows.DataPresenter.ExportInfo ExportInfo { get; }

		// Token: 0x06000D8A RID: 3466
		void CancelExport(global::Infragistics.Windows.DataPresenter.RecordExportCancellationInfo cancelInfo);
	}
}
