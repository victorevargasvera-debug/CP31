using System;
using System.Collections.Generic;
using System.Windows;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000116 RID: 278
	internal class ReportRecordEnumerator : global::Infragistics.Windows.DataPresenter.ExportRecordEnumeratorBase
	{
		// Token: 0x060010DA RID: 4314 RVA: 0x0004B641 File Offset: 0x00049841
		internal ReportRecordEnumerator(global::Infragistics.Windows.DataPresenter.DataPresenterReportControl reportControl, global::Infragistics.Windows.DataPresenter.ViewableRecordCollection sourceRecords, global::Infragistics.Windows.DataPresenter.IExportOptions exportOptions, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record> flattenedList) : base(reportControl, sourceRecords, exportOptions)
		{
			global::Infragistics.CoreUtilities.ValidateNotNull(flattenedList, "flattenedList");
			this._flattenedList = flattenedList;
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x060010DB RID: 4315 RVA: 0x0004B660 File Offset: 0x00049860
		internal global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record> FlattenedList
		{
			get
			{
				return this._flattenedList;
			}
		}

		// Token: 0x060010DC RID: 4316 RVA: 0x0004B668 File Offset: 0x00049868
		protected override bool InitializeRecordParams(global::Infragistics.Windows.DataPresenter.Record record, global::Infragistics.Windows.DataPresenter.ProcessRecordParams recordParams)
		{
			global::System.Windows.Visibility visibilityResolved = record.VisibilityResolved;
			if (visibilityResolved != global::System.Windows.Visibility.Visible || !record.IsExpanded)
			{
				recordParams.SkipDescendants = true;
			}
			return visibilityResolved != global::System.Windows.Visibility.Collapsed;
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x0004B695 File Offset: 0x00049895
		protected override void ProcessRecord(global::Infragistics.Windows.DataPresenter.Record record, global::Infragistics.Windows.DataPresenter.ProcessRecordParams recordParams)
		{
			this._flattenedList.Add(record);
		}

		// Token: 0x040006D4 RID: 1748
		private global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record> _flattenedList;
	}
}
