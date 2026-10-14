using System;
using System.Windows;

namespace Infragistics.Windows.Controls.Events
{
	// Token: 0x02000154 RID: 340
	public class SortStatusChangedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06000B75 RID: 2933 RVA: 0x00025BA4 File Offset: 0x00023DA4
		public SortStatusChangedEventArgs(global::Infragistics.Windows.Controls.SortStatus previousValue, global::Infragistics.Windows.Controls.SortStatus currentValue)
		{
			this._previousValue = previousValue;
			this._currentValue = currentValue;
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000B76 RID: 2934 RVA: 0x00025BBA File Offset: 0x00023DBA
		public global::Infragistics.Windows.Controls.SortStatus PreviousValue
		{
			get
			{
				return this._previousValue;
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000B77 RID: 2935 RVA: 0x00025BC2 File Offset: 0x00023DC2
		public global::Infragistics.Windows.Controls.SortStatus CurrentValue
		{
			get
			{
				return this._currentValue;
			}
		}

		// Token: 0x04000575 RID: 1397
		private global::Infragistics.Windows.Controls.SortStatus _previousValue;

		// Token: 0x04000576 RID: 1398
		private global::Infragistics.Windows.Controls.SortStatus _currentValue;
	}
}
