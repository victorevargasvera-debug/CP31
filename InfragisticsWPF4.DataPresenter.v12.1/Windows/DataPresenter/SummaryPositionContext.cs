using System;
using System.Collections.Generic;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001CC RID: 460
	internal class SummaryPositionContext : global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria
	{
		// Token: 0x06001AFA RID: 6906 RVA: 0x00074040 File Offset: 0x00072240
		internal SummaryPositionContext(global::Infragistics.Windows.DataPresenter.SummaryPosition position, global::Infragistics.Windows.DataPresenter.Field positionField)
		{
			this._position = position;
			this._positionField = positionField;
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06001AFB RID: 6907 RVA: 0x00074056 File Offset: 0x00072256
		public global::Infragistics.Windows.DataPresenter.SummaryPosition Position
		{
			get
			{
				return this._position;
			}
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x06001AFC RID: 6908 RVA: 0x0007405E File Offset: 0x0007225E
		public global::Infragistics.Windows.DataPresenter.Field PositionField
		{
			get
			{
				return this._positionField;
			}
		}

		// Token: 0x06001AFD RID: 6909 RVA: 0x00074066 File Offset: 0x00072266
		public bool DoesSummaryMatch(global::Infragistics.Windows.DataPresenter.SummaryResult result)
		{
			return this._position == result.PositionResolved && (global::Infragistics.Windows.DataPresenter.SummaryPosition.UseSummaryPositionField != this._position || this._positionField == result.PositionFieldResolved);
		}

		// Token: 0x06001AFE RID: 6910 RVA: 0x00074091 File Offset: 0x00072291
		internal global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult> Filter(global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult> results)
		{
			return global::Infragistics.Windows.DataPresenter.GridUtilities.Filter<global::Infragistics.Windows.DataPresenter.SummaryResult>(results, this, false);
		}

		// Token: 0x06001AFF RID: 6911 RVA: 0x0007409C File Offset: 0x0007229C
		bool global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria.MeetsCriteria(object resultObj)
		{
			global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult = resultObj as global::Infragistics.Windows.DataPresenter.SummaryResult;
			return summaryResult != null && this.DoesSummaryMatch(summaryResult);
		}

		// Token: 0x04000B26 RID: 2854
		private global::Infragistics.Windows.DataPresenter.SummaryPosition _position;

		// Token: 0x04000B27 RID: 2855
		private global::Infragistics.Windows.DataPresenter.Field _positionField;
	}
}
