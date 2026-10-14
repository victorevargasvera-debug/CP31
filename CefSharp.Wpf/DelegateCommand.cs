using System;
using System.Windows.Input;

namespace CefSharp.Wpf
{
	// Token: 0x02000004 RID: 4
	internal class DelegateCommand : global::System.Windows.Input.ICommand
	{
		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06000117 RID: 279 RVA: 0x000050B0 File Offset: 0x000032B0
		// (remove) Token: 0x06000118 RID: 280 RVA: 0x000050E8 File Offset: 0x000032E8
		public event global::System.EventHandler CanExecuteChanged;

		// Token: 0x06000119 RID: 281 RVA: 0x0000511D File Offset: 0x0000331D
		public DelegateCommand(global::System.Action commandHandler, global::System.Func<bool> canExecuteHandler = null)
		{
			this.commandHandler = commandHandler;
			this.canExecuteHandler = canExecuteHandler;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00005133 File Offset: 0x00003333
		public void Execute(object parameter)
		{
			this.commandHandler();
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00005140 File Offset: 0x00003340
		public bool CanExecute(object parameter)
		{
			return this.canExecuteHandler == null || this.canExecuteHandler();
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00005157 File Offset: 0x00003357
		public void RaiseCanExecuteChanged()
		{
			if (this.CanExecuteChanged != null)
			{
				this.CanExecuteChanged(this, global::System.EventArgs.Empty);
			}
		}

		// Token: 0x04000065 RID: 101
		private readonly global::System.Action commandHandler;

		// Token: 0x04000066 RID: 102
		private readonly global::System.Func<bool> canExecuteHandler;
	}
}
