using System;
using System.Windows;
using System.Windows.Input;

namespace Infragistics.Windows.Controls.Events
{
	// Token: 0x02000133 RID: 307
	public class ExecutedCommandEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06000A6F RID: 2671 RVA: 0x00021F86 File Offset: 0x00020186
		public ExecutedCommandEventArgs(global::System.Windows.Input.RoutedCommand command) : this(command, null)
		{
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x00021F90 File Offset: 0x00020190
		public ExecutedCommandEventArgs(global::System.Windows.Input.RoutedCommand command, object parameter)
		{
			this._command = command;
			this._parameter = parameter;
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000A71 RID: 2673 RVA: 0x00021FA6 File Offset: 0x000201A6
		public global::System.Windows.Input.RoutedCommand Command
		{
			get
			{
				return this._command;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000A72 RID: 2674 RVA: 0x00021FAE File Offset: 0x000201AE
		public object Parameter
		{
			get
			{
				return this._parameter;
			}
		}

		// Token: 0x040004BB RID: 1211
		private global::System.Windows.Input.RoutedCommand _command;

		// Token: 0x040004BC RID: 1212
		private object _parameter;
	}
}
