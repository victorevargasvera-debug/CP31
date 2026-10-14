using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000115 RID: 277
	internal class ExportRecordEnumerator : global::Infragistics.Windows.DataPresenter.ExportRecordEnumeratorBase
	{
		// Token: 0x060010D7 RID: 4311 RVA: 0x0004B5F8 File Offset: 0x000497F8
		internal ExportRecordEnumerator(global::Infragistics.Windows.DataPresenter.DataPresenterExportControl exportControl, global::Infragistics.Windows.DataPresenter.ViewableRecordCollection sourceRecords, global::Infragistics.Windows.DataPresenter.IExportOptions exportOptions) : base(exportControl, sourceRecords, exportOptions)
		{
			this._exporter = exportControl.Exporter;
		}

		// Token: 0x060010D8 RID: 4312 RVA: 0x0004B60F File Offset: 0x0004980F
		protected override bool InitializeRecordParams(global::Infragistics.Windows.DataPresenter.Record record, global::Infragistics.Windows.DataPresenter.ProcessRecordParams recordParams)
		{
			return this._exporter.InitializeRecord(record, recordParams);
		}

		// Token: 0x060010D9 RID: 4313 RVA: 0x0004B61E File Offset: 0x0004981E
		protected override void ProcessRecord(global::Infragistics.Windows.DataPresenter.Record record, global::Infragistics.Windows.DataPresenter.ProcessRecordParams recordParams)
		{
			record.LoadVirtualData();
			this._exporter.ProcessRecord(record, recordParams);
			this.ProcessedRecordCount++;
		}

		// Token: 0x040006D2 RID: 1746
		private global::Infragistics.Windows.DataPresenter.IDataPresenterExporter _exporter;

		// Token: 0x040006D3 RID: 1747
		internal int ProcessedRecordCount;
	}
}
