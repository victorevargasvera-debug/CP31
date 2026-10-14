using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002AA RID: 682
	public class SummarySelectionControlClosedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06001E59 RID: 7769 RVA: 0x000819D4 File Offset: 0x0007FBD4
		internal SummarySelectionControlClosedEventArgs(global::Infragistics.Windows.DataPresenter.Field field, bool summariesChanged)
		{
			this._field = field;
			this._summariesChanged = summariesChanged;
		}

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x06001E5A RID: 7770 RVA: 0x000819EA File Offset: 0x0007FBEA
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x06001E5B RID: 7771 RVA: 0x000819F2 File Offset: 0x0007FBF2
		public bool SummariesChanged
		{
			get
			{
				return this._summariesChanged;
			}
		}

		// Token: 0x04000EF8 RID: 3832
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x04000EF9 RID: 3833
		private bool _summariesChanged;
	}
}
