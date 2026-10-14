using System;
using System.Collections.Generic;
using System.Windows;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020000F8 RID: 248
	internal class ReportRecordEnumerator : global::Infragistics.Windows.DataPresenter.ExportRecordEnumeratorBase
	{
		// Token: 0x06000D5E RID: 3422 RVA: 0x0003A8DB File Offset: 0x00038ADB
		internal ReportRecordEnumerator(global::Infragistics.Windows.DataPresenter.DataPresenterReportControl reportControl, global::Infragistics.Windows.DataPresenter.ViewableRecordCollection sourceRecords, global::Infragistics.Windows.DataPresenter.IExportOptions exportOptions, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record> flattenedList) : base(reportControl, sourceRecords, exportOptions)
		{
			global::Infragistics.CoreUtilities.ValidateNotNull(flattenedList, "flattenedList");
			this._flattenedList = flattenedList;
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000D5F RID: 3423 RVA: 0x0003A8FA File Offset: 0x00038AFA
		internal global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record> FlattenedList
		{
			get
			{
				return this._flattenedList;
			}
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x0003A904 File Offset: 0x00038B04
		protected override bool InitializeRecordParams(global::Infragistics.Windows.DataPresenter.Record record, global::Infragistics.Windows.DataPresenter.ProcessRecordParams recordParams)
		{
			global::System.Windows.Visibility visibilityResolved = record.VisibilityResolved;
			if (visibilityResolved != global::System.Windows.Visibility.Visible || !record.IsExpanded)
			{
				recordParams.SkipDescendants = true;
			}
			return visibilityResolved != global::System.Windows.Visibility.Collapsed;
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x0003A931 File Offset: 0x00038B31
		protected override void ProcessRecord(global::Infragistics.Windows.DataPresenter.Record record, global::Infragistics.Windows.DataPresenter.ProcessRecordParams recordParams)
		{
			this._flattenedList.Add(record);
		}

		// Token: 0x04000533 RID: 1331
		private global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record> _flattenedList;
	}
}
