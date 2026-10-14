using System;
using System.Threading.Tasks;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200011A RID: 282
	public interface IDataPresenterExporterAsync : global::Infragistics.Windows.DataPresenter.IDataPresenterExporter
	{
		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x060010E9 RID: 4329
		global::Infragistics.Windows.DataPresenter.ExportInfo ExportInfo { get; }

		// Token: 0x060010EA RID: 4330
		void CancelExport(global::Infragistics.Windows.DataPresenter.RecordExportCancellationInfo cancelInfo);

		// Token: 0x060010EB RID: 4331
		global::System.Threading.Tasks.Task EndExportAsync(bool cancelled);
	}
}
