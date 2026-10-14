using System;
using System.Windows.Input;

namespace Infragistics.Windows.Controls.Events
{
	// Token: 0x02000132 RID: 306
	public class ExecutingCommandEventArgs : global::Infragistics.Windows.Controls.Events.CancelableRoutedEventArgs
	{
		// Token: 0x06000A69 RID: 2665 RVA: 0x00021F3E File Offset: 0x0002013E
		public ExecutingCommandEventArgs(global::System.Windows.Input.RoutedCommand command) : this(command, null)
		{
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x00021F48 File Offset: 0x00020148
		public ExecutingCommandEventArgs(global::System.Windows.Input.RoutedCommand command, object parameter)
		{
			this._command = command;
			this._parameter = parameter;
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000A6B RID: 2667 RVA: 0x00021F65 File Offset: 0x00020165
		public global::System.Windows.Input.RoutedCommand Command
		{
			get
			{
				return this._command;
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000A6C RID: 2668 RVA: 0x00021F6D File Offset: 0x0002016D
		// (set) Token: 0x06000A6D RID: 2669 RVA: 0x00021F75 File Offset: 0x00020175
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

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000A6E RID: 2670 RVA: 0x00021F7E File Offset: 0x0002017E
		public object Parameter
		{
			get
			{
				return this._parameter;
			}
		}

		// Token: 0x040004B8 RID: 1208
		private global::System.Windows.Input.RoutedCommand _command;

		// Token: 0x040004B9 RID: 1209
		private object _parameter;

		// Token: 0x040004BA RID: 1210
		private bool _continueKeyRouting = true;
	}
}
