using System;
using System.Collections.Generic;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001F2 RID: 498
	internal class SummaryDisplayAreaContext : global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria
	{
		// Token: 0x06001EFD RID: 7933 RVA: 0x00087BB0 File Offset: 0x00085DB0
		private SummaryDisplayAreaContext(global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas matchAny) : this(matchAny, global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.None, global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.None, matchAny)
		{
		}

		// Token: 0x06001EFE RID: 7934 RVA: 0x00087BBC File Offset: 0x00085DBC
		private SummaryDisplayAreaContext(global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas matchAny, global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas matchAll, global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas matchNone, global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas displayArea)
		{
			this._matchAny = matchAny;
			this._matchAll = matchAll;
			this._matchNone = matchNone;
			this._displayArea = displayArea;
		}

		// Token: 0x06001EFF RID: 7935 RVA: 0x00087BE4 File Offset: 0x00085DE4
		public override bool Equals(object obj)
		{
			global::Infragistics.Windows.DataPresenter.SummaryDisplayAreaContext summaryDisplayAreaContext = obj as global::Infragistics.Windows.DataPresenter.SummaryDisplayAreaContext;
			return summaryDisplayAreaContext != null && (this._displayArea == summaryDisplayAreaContext._displayArea && this._matchAll == summaryDisplayAreaContext._matchAll && this._matchAny == summaryDisplayAreaContext._matchAny) && this._matchNone == summaryDisplayAreaContext._matchNone;
		}

		// Token: 0x06001F00 RID: 7936 RVA: 0x00087C37 File Offset: 0x00085E37
		public override int GetHashCode()
		{
			return (int)(this._displayArea ^ this._matchAll ^ this._matchAny ^ this._matchNone);
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x06001F01 RID: 7937 RVA: 0x00087C54 File Offset: 0x00085E54
		internal static global::Infragistics.Windows.DataPresenter.SummaryDisplayAreaContext AllExceptGroupbySummaries
		{
			get
			{
				return new global::Infragistics.Windows.DataPresenter.SummaryDisplayAreaContext(global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.Top | global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.TopFixed | global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.Bottom | global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.BottomFixed);
			}
		}

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x06001F02 RID: 7938 RVA: 0x00087C5D File Offset: 0x00085E5D
		internal static global::Infragistics.Windows.DataPresenter.SummaryDisplayAreaContext BottomScrollingSummariesContext
		{
			get
			{
				return new global::Infragistics.Windows.DataPresenter.SummaryDisplayAreaContext(global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.Bottom);
			}
		}

		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x06001F03 RID: 7939 RVA: 0x00087C65 File Offset: 0x00085E65
		internal global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas DisplayArea
		{
			get
			{
				return this._displayArea;
			}
		}

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x06001F04 RID: 7940 RVA: 0x00087C6D File Offset: 0x00085E6D
		internal static global::Infragistics.Windows.DataPresenter.SummaryDisplayAreaContext InGroupByRecordsSummariesContext
		{
			get
			{
				return new global::Infragistics.Windows.DataPresenter.SummaryDisplayAreaContext(global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.InGroupByRecords);
			}
		}

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x06001F05 RID: 7941 RVA: 0x00087C76 File Offset: 0x00085E76
		internal bool IsDisplayAreaBottom
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.Bottom == this._displayArea || global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.BottomFixed == this._displayArea;
			}
		}

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x06001F06 RID: 7942 RVA: 0x00087C8C File Offset: 0x00085E8C
		internal bool IsDisplayAreaTop
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.Top == this._displayArea || global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.TopFixed == this._displayArea;
			}
		}

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x06001F07 RID: 7943 RVA: 0x00087CA2 File Offset: 0x00085EA2
		internal bool IsGroupByRecordSummaries
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.InGroupByRecords == this._matchAny;
			}
		}

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x06001F08 RID: 7944 RVA: 0x00087CAE File Offset: 0x00085EAE
		internal static global::Infragistics.Windows.DataPresenter.SummaryDisplayAreaContext NoneSummariesContext
		{
			get
			{
				return new global::Infragistics.Windows.DataPresenter.SummaryDisplayAreaContext(global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.None);
			}
		}

		// Token: 0x06001F09 RID: 7945 RVA: 0x00087CB8 File Offset: 0x00085EB8
		internal bool DoesSummaryMatch(global::Infragistics.Windows.DataPresenter.SummaryResult summary)
		{
			global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas displayAreaResolved = summary.DisplayAreaResolved;
			return (this._matchAny == global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.None || (this._matchAny & displayAreaResolved) != global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.None) && this._matchAll == (this._matchAll & displayAreaResolved) && (this._matchNone & displayAreaResolved) == global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.None && global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.None != displayAreaResolved;
		}

		// Token: 0x06001F0A RID: 7946 RVA: 0x00087D01 File Offset: 0x00085F01
		internal global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult> Filter(global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult> results)
		{
			return global::Infragistics.Windows.DataPresenter.GridUtilities.Filter<global::Infragistics.Windows.DataPresenter.SummaryResult>(results, this, false);
		}

		// Token: 0x06001F0B RID: 7947 RVA: 0x00087D0C File Offset: 0x00085F0C
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

		// Token: 0x06001F0C RID: 7948 RVA: 0x00087D5C File Offset: 0x00085F5C
		bool global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria.MeetsCriteria(object resultObj)
		{
			global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult = resultObj as global::Infragistics.Windows.DataPresenter.SummaryResult;
			return summaryResult != null && this.DoesSummaryMatch(summaryResult);
		}

		// Token: 0x04000D0D RID: 3341
		internal const global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas ALL_EXCEPT_GROUPBY_SUMMARIES = global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.Top | global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.TopFixed | global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.Bottom | global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.BottomFixed;

		// Token: 0x04000D0E RID: 3342
		private global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas _matchAny;

		// Token: 0x04000D0F RID: 3343
		private global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas _matchAll;

		// Token: 0x04000D10 RID: 3344
		private global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas _matchNone;

		// Token: 0x04000D11 RID: 3345
		private global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas _displayArea;
	}
}
