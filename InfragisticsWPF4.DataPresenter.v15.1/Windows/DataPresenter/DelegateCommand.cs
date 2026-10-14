using System;
using System.Windows.Input;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200020E RID: 526
	internal class DelegateCommand : global::System.Windows.Input.ICommand
	{
		// Token: 0x06001FB9 RID: 8121 RVA: 0x00089E11 File Offset: 0x00088011
		internal DelegateCommand(global::System.Action<object> execute, global::System.Predicate<object> canExecute)
		{
			global::Infragistics.CoreUtilities.ValidateNotNull(execute, "execute");
			this._execute = execute;
			this._canExecute = canExecute;
		}

		// Token: 0x06001FBA RID: 8122 RVA: 0x00089E32 File Offset: 0x00088032
		internal DelegateCommand(global::System.Action<object> execute) : this(execute, null)
		{
		}

		// Token: 0x06001FBB RID: 8123 RVA: 0x00089E3C File Offset: 0x0008803C
		bool global::System.Windows.Input.ICommand.CanExecute(object parameter)
		{
			return this._canExecute == null || this._canExecute(parameter);
		}

		// Token: 0x1400006D RID: 109
		// (add) Token: 0x06001FBC RID: 8124 RVA: 0x00089E54 File Offset: 0x00088054
		// (remove) Token: 0x06001FBD RID: 8125 RVA: 0x00089E5C File Offset: 0x0008805C
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

		// Token: 0x06001FBE RID: 8126 RVA: 0x00089E64 File Offset: 0x00088064
		void global::System.Windows.Input.ICommand.Execute(object parameter)
		{
			this._execute(parameter);
		}

		// Token: 0x04000D59 RID: 3417
		private global::System.Predicate<object> _canExecute;

		// Token: 0x04000D5A RID: 3418
		private global::System.Action<object> _execute;
	}
}
