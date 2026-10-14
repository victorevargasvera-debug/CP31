using System;
using System.Collections.Generic;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001CB RID: 459
	internal class SummaryDisplayAreaContext : global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria
	{
		// Token: 0x06001AEA RID: 6890 RVA: 0x00073E74 File Offset: 0x00072074
		private SummaryDisplayAreaContext(global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas matchAny) : this(matchAny, global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.None, global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.None, matchAny)
		{
		}

		// Token: 0x06001AEB RID: 6891 RVA: 0x00073E80 File Offset: 0x00072080
		private SummaryDisplayAreaContext(global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas matchAny, global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas matchAll, global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas matchNone, global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas displayArea)
		{
			this._matchAny = matchAny;
			this._matchAll = matchAll;
			this._matchNone = matchNone;
			this._displayArea = displayArea;
		}

		// Token: 0x06001AEC RID: 6892 RVA: 0x00073EA8 File Offset: 0x000720A8
		public override bool Equals(object obj)
		{
			global::Infragistics.Windows.DataPresenter.SummaryDisplayAreaContext summaryDisplayAreaContext = obj as global::Infragistics.Windows.DataPresenter.SummaryDisplayAreaContext;
			return summaryDisplayAreaContext != null && (this._displayArea == summaryDisplayAreaContext._displayArea && this._matchAll == summaryDisplayAreaContext._matchAll && this._matchAny == summaryDisplayAreaContext._matchAny) && this._matchNone == summaryDisplayAreaContext._matchNone;
		}

		// Token: 0x06001AED RID: 6893 RVA: 0x00073EFB File Offset: 0x000720FB
		public override int GetHashCode()
		{
			return (int)(this._displayArea ^ this._matchAll ^ this._matchAny ^ this._matchNone);
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x06001AEE RID: 6894 RVA: 0x00073F18 File Offset: 0x00072118
		internal static global::Infragistics.Windows.DataPresenter.SummaryDisplayAreaContext AllExceptGroupbySummaries
		{
			get
			{
				return new global::Infragistics.Windows.DataPresenter.SummaryDisplayAreaContext(global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.Top | global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.TopFixed | global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.Bottom | global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.BottomFixed);
			}
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x06001AEF RID: 6895 RVA: 0x00073F21 File Offset: 0x00072121
		internal static global::Infragistics.Windows.DataPresenter.SummaryDisplayAreaContext BottomScrollingSummariesContext
		{
			get
			{
				return new global::Infragistics.Windows.DataPresenter.SummaryDisplayAreaContext(global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.Bottom);
			}
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x06001AF0 RID: 6896 RVA: 0x00073F29 File Offset: 0x00072129
		internal global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas DisplayArea
		{
			get
			{
				return this._displayArea;
			}
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x06001AF1 RID: 6897 RVA: 0x00073F31 File Offset: 0x00072131
		internal static global::Infragistics.Windows.DataPresenter.SummaryDisplayAreaContext InGroupByRecordsSummariesContext
		{
			get
			{
				return new global::Infragistics.Windows.DataPresenter.SummaryDisplayAreaContext(global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.InGroupByRecords);
			}
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06001AF2 RID: 6898 RVA: 0x00073F3A File Offset: 0x0007213A
		internal bool IsDisplayAreaBottom
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.Bottom == this._displayArea || global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.BottomFixed == this._displayArea;
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06001AF3 RID: 6899 RVA: 0x00073F50 File Offset: 0x00072150
		internal bool IsDisplayAreaTop
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.Top == this._displayArea || global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.TopFixed == this._displayArea;
			}
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06001AF4 RID: 6900 RVA: 0x00073F66 File Offset: 0x00072166
		internal bool IsGroupByRecordSummaries
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.InGroupByRecords == this._matchAny;
			}
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06001AF5 RID: 6901 RVA: 0x00073F72 File Offset: 0x00072172
		internal static global::Infragistics.Windows.DataPresenter.SummaryDisplayAreaContext NoneSummariesContext
		{
			get
			{
				return new global::Infragistics.Windows.DataPresenter.SummaryDisplayAreaContext(global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.None);
			}
		}

		// Token: 0x06001AF6 RID: 6902 RVA: 0x00073F7C File Offset: 0x0007217C
		internal bool DoesSummaryMatch(global::Infragistics.Windows.DataPresenter.SummaryResult summary)
		{
			global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas displayAreaResolved = summary.DisplayAreaResolved;
			return (this._matchAny == global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.None || (this._matchAny & displayAreaResolved) != global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.None) && this._matchAll == (this._matchAll & displayAreaResolved) && (this._matchNone & displayAreaResolved) == global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.None && global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.None != displayAreaResolved;
		}

		// Token: 0x06001AF7 RID: 6903 RVA: 0x00073FC5 File Offset: 0x000721C5
		internal global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult> Filter(global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult> results)
		{
			return global::Infragistics.Windows.DataPresenter.GridUtilities.Filter<global::Infragistics.Windows.DataPresenter.SummaryResult>(results, this, false);
		}

		// Token: 0x06001AF8 RID: 6904 RVA: 0x00073FD0 File Offset: 0x000721D0
		internal static global::Infragistics.Windows.DataPresenter.SummaryDisplayAreaContext GetContext(bool top, bool isFixed, global::Infragistics.Windows.DataPresenter.SummaryResultCollection results)
		{
			global::Infragistics.Windows.DataPresenter.RecordCollectionBase records = results.Records;
			global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas summaryDisplayAreas = top ? (isFixed ? global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.TopFixed : global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.Top) : (isFixed ? global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.BottomFixed : global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.Bottom);
			global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas summaryDisplayAreas2 = global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.None;
			if (!records.IsTopLevel)
			{
				summaryDisplayAreas2 |= global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.TopLevelOnly;
			}
			if (records.RecordsType != global::Infragistics.Windows.DataPresenter.RecordType.DataRecord)
			{
				summaryDisplayAreas2 |= global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.DataRecordsOnly;
			}
			return new global::Infragistics.Windows.DataPresenter.SummaryDisplayAreaContext(global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.None, summaryDisplayAreas, summaryDisplayAreas2, summaryDisplayAreas);
		}

		// Token: 0x06001AF9 RID: 6905 RVA: 0x00074020 File Offset: 0x00072220
		bool global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria.MeetsCriteria(object resultObj)
		{
			global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult = resultObj as global::Infragistics.Windows.DataPresenter.SummaryResult;
			return summaryResult != null && this.DoesSummaryMatch(summaryResult);
		}

		// Token: 0x04000B21 RID: 2849
		internal const global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas ALL_EXCEPT_GROUPBY_SUMMARIES = global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.Top | global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.TopFixed | global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.Bottom | global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.BottomFixed;

		// Token: 0x04000B22 RID: 2850
		private global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas _matchAny;

		// Token: 0x04000B23 RID: 2851
		private global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas _matchAll;

		// Token: 0x04000B24 RID: 2852
		private global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas _matchNone;

		// Token: 0x04000B25 RID: 2853
		private global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas _displayArea;
	}
}
