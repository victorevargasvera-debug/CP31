using System;
using System.Windows.Input;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001E4 RID: 484
	internal class DelegateCommand : global::System.Windows.Input.ICommand
	{
		// Token: 0x06001B9F RID: 7071 RVA: 0x00075E1D File Offset: 0x0007401D
		internal DelegateCommand(global::System.Action<object> execute, global::System.Predicate<object> canExecute)
		{
			global::Infragistics.CoreUtilities.ValidateNotNull(execute, "execute");
			this._execute = execute;
			this._canExecute = canExecute;
		}

		// Token: 0x06001BA0 RID: 7072 RVA: 0x00075E3E File Offset: 0x0007403E
		internal DelegateCommand(global::System.Action<object> execute) : this(execute, null)
		{
		}

		// Token: 0x06001BA1 RID: 7073 RVA: 0x00075E48 File Offset: 0x00074048
		bool global::System.Windows.Input.ICommand.CanExecute(object parameter)
		{
			return this._canExecute == null || this._canExecute(parameter);
		}

		// Token: 0x1400006C RID: 108
		// (add) Token: 0x06001BA2 RID: 7074 RVA: 0x00075E60 File Offset: 0x00074060
		// (remove) Token: 0x06001BA3 RID: 7075 RVA: 0x00075E68 File Offset: 0x00074068
		event global::System.EventHandler global::System.Windows.Input.ICommand.CanExecuteChanged
		{
			add
			{
				global::System.Windows.Input.CommandManager.RequerySuggested += value;
			}
			remove
			{
				global::System.Windows.Input.CommandManager.RequerySuggested -= value;
			}
		}

		// Token: 0x06001BA4 RID: 7076 RVA: 0x00075E70 File Offset: 0x00074070
		void global::System.Windows.Input.ICommand.Execute(object parameter)
		{
			this._execute(parameter);
		}

		// Token: 0x04000B67 RID: 2919
		private global::System.Predicate<object> _canExecute;

		// Token: 0x04000B68 RID: 2920
		private global::System.Action<object> _execute;
	}
}
