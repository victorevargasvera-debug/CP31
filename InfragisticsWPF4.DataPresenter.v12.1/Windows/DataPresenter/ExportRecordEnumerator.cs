using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020000F7 RID: 247
	internal class ExportRecordEnumerator : global::Infragistics.Windows.DataPresenter.ExportRecordEnumeratorBase
	{
		// Token: 0x06000D5B RID: 3419 RVA: 0x0003A898 File Offset: 0x00038A98
		internal ExportRecordEnumerator(global::Infragistics.Windows.DataPresenter.DataPresenterExportControl exportControl, global::Infragistics.Windows.DataPresenter.ViewableRecordCollection sourceRecords, global::Infragistics.Windows.DataPresenter.IExportOptions exportOptions) : base(exportControl, sourceRecords, exportOptions)
		{
			this._exporter = exportControl.Exporter;
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x0003A8AF File Offset: 0x00038AAF
		protected override bool InitializeRecordParams(global::Infragistics.Windows.DataPresenter.Record record, global::Infragistics.Windows.DataPresenter.ProcessRecordParams recordParams)
		{
			return this._exporter.InitializeRecord(record, recordParams);
		}

		// Token: 0x06000D5D RID: 3421 RVA: 0x0003A8BE File Offset: 0x00038ABE
		protected override void ProcessRecord(global::Infragistics.Windows.DataPresenter.Record record, global::Infragistics.Windows.DataPresenter.ProcessRecordParams recordParams)
		{
			this._exporter.ProcessRecord(record, recordParams);
			this.ProcessedRecordCount++;
		}

		// Token: 0x04000531 RID: 1329
		private global::Infragistics.Windows.DataPresenter.IDataPresenterExporter _exporter;

		// Token: 0x04000532 RID: 1330
		internal int ProcessedRecordCount;
	}
}
