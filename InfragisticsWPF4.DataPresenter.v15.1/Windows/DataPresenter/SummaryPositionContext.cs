using System;
using System.Collections.Generic;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001F3 RID: 499
	internal class SummaryPositionContext : global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria
	{
		// Token: 0x06001F0D RID: 7949 RVA: 0x00087D7C File Offset: 0x00085F7C
		internal SummaryPositionContext(global::Infragistics.Windows.DataPresenter.SummaryPosition position, global::Infragistics.Windows.DataPresenter.Field positionField)
		{
			this._position = position;
			this._positionField = positionField;
		}

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x06001F0E RID: 7950 RVA: 0x00087D92 File Offset: 0x00085F92
		public global::Infragistics.Windows.DataPresenter.SummaryPosition Position
		{
			get
			{
				return this._position;
			}
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x06001F0F RID: 7951 RVA: 0x00087D9A File Offset: 0x00085F9A
		public global::Infragistics.Windows.DataPresenter.Field PositionField
		{
			get
			{
				return this._positionField;
			}
		}

		// Token: 0x06001F10 RID: 7952 RVA: 0x00087DA2 File Offset: 0x00085FA2
		public bool DoesSummaryMatch(global::Infragistics.Windows.DataPresenter.SummaryResult result)
		{
			return this._position == result.PositionResolved && (global::Infragistics.Windows.DataPresenter.SummaryPosition.UseSummaryPositionField != this._position || this._positionField == result.PositionFieldResolved);
		}

		// Token: 0x06001F11 RID: 7953 RVA: 0x00087DCD File Offset: 0x00085FCD
		internal global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult> Filter(global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult> results)
		{
			return global::Infragistics.Windows.DataPresenter.GridUtilities.Filter<global::Infragistics.Windows.DataPresenter.SummaryResult>(results, this, false);
		}

		// Token: 0x06001F12 RID: 7954 RVA: 0x00087DD8 File Offset: 0x00085FD8
		bool global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria.MeetsCriteria(object resultObj)
		{
			global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult = resultObj as global::Infragistics.Windows.DataPresenter.SummaryResult;
			return summaryResult != null && this.DoesSummaryMatch(summaryResult);
		}

		// Token: 0x04000D12 RID: 3346
		private global::Infragistics.Windows.DataPresenter.SummaryPosition _position;

		// Token: 0x04000D13 RID: 3347
		private global::Infragistics.Windows.DataPresenter.Field _positionField;
	}
}
