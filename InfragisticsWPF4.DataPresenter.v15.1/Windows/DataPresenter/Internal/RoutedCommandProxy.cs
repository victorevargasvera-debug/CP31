using System;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace Infragistics.Windows.DataPresenter.Internal
{
	// Token: 0x02000356 RID: 854
	internal class RoutedCommandProxy : global::System.Windows.Input.ICommand
	{
		// Token: 0x06002980 RID: 10624 RVA: 0x000B69AB File Offset: 0x000B4BAB
		private RoutedCommandProxy(global::System.Windows.Controls.Primitives.ButtonBase button, global::System.Windows.Input.RoutedCommand command)
		{
			this._button = button;
			this._command = command;
		}

		// Token: 0x06002981 RID: 10625 RVA: 0x000B69C4 File Offset: 0x000B4BC4
		internal static void WireProxy(global::System.Windows.Controls.Primitives.ButtonBase button)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(button);
			global::System.Windows.Input.RoutedCommand routedCommand = button.Command as global::System.Windows.Input.RoutedCommand;
			if (routedCommand != null)
			{
				button.Command = new global::Infragistics.Windows.DataPresenter.Internal.RoutedCommandProxy(button, routedCommand);
			}
		}

		// Token: 0x06002982 RID: 10626 RVA: 0x000B69F3 File Offset: 0x000B4BF3
		bool global::System.Windows.Input.ICommand.CanExecute(object parameter)
		{
			return true;
		}

		// Token: 0x1400007B RID: 123
		// (add) Token: 0x06002983 RID: 10627 RVA: 0x000B69F6 File Offset: 0x000B4BF6
		// (remove) Token: 0x06002984 RID: 10628 RVA: 0x000B69F8 File Offset: 0x000B4BF8
		event global::System.EventHandler global::System.Windows.Input.ICommand.CanExecuteChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x06002985 RID: 10629 RVA: 0x000B69FC File Offset: 0x000B4BFC
		void global::System.Windows.Input.ICommand.Execute(object parameter)
		{
			if (this._button.Command == this)
			{
				global::System.Windows.IInputElement inputElement = this._button.CommandTarget;
				if (inputElement == null)
				{
					inputElement = this._button;
				}
				if (this._command.CanExecute(parameter, inputElement))
				{
					this._command.Execute(parameter, inputElement);
				}
			}
		}

		// Token: 0x04001400 RID: 5120
		private global::System.Windows.Controls.Primitives.ButtonBase _button;

		// Token: 0x04001401 RID: 5121
		private global::System.Windows.Input.RoutedCommand _command;
	}
}
