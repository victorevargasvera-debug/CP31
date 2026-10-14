using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002ED RID: 749
	public class SummarySelectionControlClosedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x060022E1 RID: 8929 RVA: 0x00098168 File Offset: 0x00096368
		internal SummarySelectionControlClosedEventArgs(global::Infragistics.Windows.DataPresenter.Field field, bool summariesChanged)
		{
			this._field = field;
			this._summariesChanged = summariesChanged;
		}

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x060022E2 RID: 8930 RVA: 0x0009817E File Offset: 0x0009637E
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x060022E3 RID: 8931 RVA: 0x00098186 File Offset: 0x00096386
		public bool SummariesChanged
		{
			get
			{
				return this._summariesChanged;
			}
		}

		// Token: 0x04001162 RID: 4450
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x04001163 RID: 4451
		private bool _summariesChanged;
	}
}
