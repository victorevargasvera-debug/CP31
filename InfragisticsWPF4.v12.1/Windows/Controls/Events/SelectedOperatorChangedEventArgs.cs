using System;
using System.Windows;

namespace Infragistics.Windows.Controls.Events
{
	// Token: 0x02000134 RID: 308
	public class SelectedOperatorChangedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06000A73 RID: 2675 RVA: 0x00021FB6 File Offset: 0x000201B6
		internal SelectedOperatorChangedEventArgs(global::Infragistics.Windows.Controls.ComparisonOperator? oldValue, global::Infragistics.Windows.Controls.ComparisonOperator? newValue)
		{
			this._newValue = newValue;
			this._oldValue = oldValue;
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000A74 RID: 2676 RVA: 0x00021FCC File Offset: 0x000201CC
		public global::Infragistics.Windows.Controls.ComparisonOperator? OldValue
		{
			get
			{
				return this._oldValue;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000A75 RID: 2677 RVA: 0x00021FD4 File Offset: 0x000201D4
		public global::Infragistics.Windows.Controls.ComparisonOperator? NewValue
		{
			get
			{
				return this._newValue;
			}
		}

		// Token: 0x040004BD RID: 1213
		private global::Infragistics.Windows.Controls.ComparisonOperator? _oldValue;

		// Token: 0x040004BE RID: 1214
		private global::Infragistics.Windows.Controls.ComparisonOperator? _newValue;
	}
}
