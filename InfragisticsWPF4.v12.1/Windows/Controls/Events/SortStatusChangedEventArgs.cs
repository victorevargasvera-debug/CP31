using System;
using System.Windows;

namespace Infragistics.Windows.Controls.Events
{
	// Token: 0x02000135 RID: 309
	public class SortStatusChangedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06000A76 RID: 2678 RVA: 0x00021FDC File Offset: 0x000201DC
		public SortStatusChangedEventArgs(global::Infragistics.Windows.Controls.SortStatus previousValue, global::Infragistics.Windows.Controls.SortStatus currentValue)
		{
			this._previousValue = previousValue;
			this._currentValue = currentValue;
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000A77 RID: 2679 RVA: 0x00021FF2 File Offset: 0x000201F2
		public global::Infragistics.Windows.Controls.SortStatus PreviousValue
		{
			get
			{
				return this._previousValue;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000A78 RID: 2680 RVA: 0x00021FFA File Offset: 0x000201FA
		public global::Infragistics.Windows.Controls.SortStatus CurrentValue
		{
			get
			{
				return this._currentValue;
			}
		}

		// Token: 0x040004BF RID: 1215
		private global::Infragistics.Windows.Controls.SortStatus _previousValue;

		// Token: 0x040004C0 RID: 1216
		private global::Infragistics.Windows.Controls.SortStatus _currentValue;
	}
}
