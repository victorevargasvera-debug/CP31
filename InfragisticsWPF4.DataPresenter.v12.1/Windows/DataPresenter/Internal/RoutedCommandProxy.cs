using System;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace Infragistics.Windows.DataPresenter.Internal
{
	// Token: 0x02000315 RID: 789
	internal class RoutedCommandProxy : global::System.Windows.Input.ICommand
	{
		// Token: 0x060025CD RID: 9677 RVA: 0x000A285B File Offset: 0x000A0A5B
		private RoutedCommandProxy(global::System.Windows.Controls.Primitives.ButtonBase button, global::System.Windows.Input.RoutedCommand command)
		{
			this._button = button;
			this._command = command;
		}

		// Token: 0x060025CE RID: 9678 RVA: 0x000A2874 File Offset: 0x000A0A74
		internal static void WireProxy(global::System.Windows.Controls.Primitives.ButtonBase button)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(button);
			global::System.Windows.Input.RoutedCommand routedCommand = button.Command as global::System.Windows.Input.RoutedCommand;
			if (routedCommand != null)
			{
				button.Command = new global::Infragistics.Windows.DataPresenter.Internal.RoutedCommandProxy(button, routedCommand);
			}
		}

		// Token: 0x060025CF RID: 9679 RVA: 0x000A28A3 File Offset: 0x000A0AA3
		bool global::System.Windows.Input.ICommand.CanExecute(object parameter)
		{
			return true;
		}

		// Token: 0x1400007A RID: 122
		// (add) Token: 0x060025D0 RID: 9680 RVA: 0x000A28A6 File Offset: 0x000A0AA6
		// (remove) Token: 0x060025D1 RID: 9681 RVA: 0x000A28A8 File Offset: 0x000A0AA8
		event global::System.EventHandler global::System.Windows.Input.ICommand.CanExecuteChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x060025D2 RID: 9682 RVA: 0x000A28AC File Offset: 0x000A0AAC
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

		// Token: 0x040011E0 RID: 4576
		private global::System.Windows.Controls.Primitives.ButtonBase _button;

		// Token: 0x040011E1 RID: 4577
		private global::System.Windows.Input.RoutedCommand _command;
	}
}
