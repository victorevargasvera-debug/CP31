using System;
using System.Windows;

namespace Infragistics.Windows.Controls.Events
{
	// Token: 0x02000153 RID: 339
	public class SelectedOperatorChangedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06000B72 RID: 2930 RVA: 0x00025B7E File Offset: 0x00023D7E
		internal SelectedOperatorChangedEventArgs(global::Infragistics.Windows.Controls.ComparisonOperator? oldValue, global::Infragistics.Windows.Controls.ComparisonOperator? newValue)
		{
			this._newValue = newValue;
			this._oldValue = oldValue;
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000B73 RID: 2931 RVA: 0x00025B94 File Offset: 0x00023D94
		public global::Infragistics.Windows.Controls.ComparisonOperator? OldValue
		{
			get
			{
				return this._oldValue;
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000B74 RID: 2932 RVA: 0x00025B9C File Offset: 0x00023D9C
		public global::Infragistics.Windows.Controls.ComparisonOperator? NewValue
		{
			get
			{
				return this._newValue;
			}
		}

		// Token: 0x04000573 RID: 1395
		private global::Infragistics.Windows.Controls.ComparisonOperator? _oldValue;

		// Token: 0x04000574 RID: 1396
		private global::Infragistics.Windows.Controls.ComparisonOperator? _newValue;
	}
}
