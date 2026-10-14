using System;
using System.Windows.Input;

namespace Infragistics.Windows.Controls.Events
{
	// Token: 0x02000151 RID: 337
	public class ExecutingCommandEventArgs : global::Infragistics.Windows.Controls.Events.CancelableRoutedEventArgs
	{
		// Token: 0x06000B68 RID: 2920 RVA: 0x00025B06 File Offset: 0x00023D06
		public ExecutingCommandEventArgs(global::System.Windows.Input.RoutedCommand command) : this(command, null)
		{
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x00025B10 File Offset: 0x00023D10
		public ExecutingCommandEventArgs(global::System.Windows.Input.RoutedCommand command, object parameter)
		{
			this._command = command;
			this._parameter = parameter;
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000B6A RID: 2922 RVA: 0x00025B2D File Offset: 0x00023D2D
		public global::System.Windows.Input.RoutedCommand Command
		{
			get
			{
				return this._command;
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000B6B RID: 2923 RVA: 0x00025B35 File Offset: 0x00023D35
		// (set) Token: 0x06000B6C RID: 2924 RVA: 0x00025B3D File Offset: 0x00023D3D
		public bool ContinueKeyRouting
		{
			get
			{
				return this._continueKeyRouting;
			}
			set
			{
				this._continueKeyRouting = value;
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000B6D RID: 2925 RVA: 0x00025B46 File Offset: 0x00023D46
		public object Parameter
		{
			get
			{
				return this._parameter;
			}
		}

		// Token: 0x0400056E RID: 1390
		private global::System.Windows.Input.RoutedCommand _command;

		// Token: 0x0400056F RID: 1391
		private object _parameter;

		// Token: 0x04000570 RID: 1392
		private bool _continueKeyRouting = true;
	}
}
