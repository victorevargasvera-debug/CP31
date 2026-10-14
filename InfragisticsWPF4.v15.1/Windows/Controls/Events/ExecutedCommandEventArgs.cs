using System;
using System.Windows;
using System.Windows.Input;

namespace Infragistics.Windows.Controls.Events
{
	// Token: 0x02000152 RID: 338
	public class ExecutedCommandEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06000B6E RID: 2926 RVA: 0x00025B4E File Offset: 0x00023D4E
		public ExecutedCommandEventArgs(global::System.Windows.Input.RoutedCommand command) : this(command, null)
		{
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x00025B58 File Offset: 0x00023D58
		public ExecutedCommandEventArgs(global::System.Windows.Input.RoutedCommand command, object parameter)
		{
			this._command = command;
			this._parameter = parameter;
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000B70 RID: 2928 RVA: 0x00025B6E File Offset: 0x00023D6E
		public global::System.Windows.Input.RoutedCommand Command
		{
			get
			{
				return this._command;
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000B71 RID: 2929 RVA: 0x00025B76 File Offset: 0x00023D76
		public object Parameter
		{
			get
			{
				return this._parameter;
			}
		}

		// Token: 0x04000571 RID: 1393
		private global::System.Windows.Input.RoutedCommand _command;

		// Token: 0x04000572 RID: 1394
		private object _parameter;
	}
}
