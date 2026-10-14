using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using Infragistics.Windows.Automation.Peers.DataPresenter;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200016F RID: 367
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class FixedRecordButton : global::System.Windows.Controls.Control
	{
		// Token: 0x060016A0 RID: 5792 RVA: 0x00064D30 File Offset: 0x00062F30
		static FixedRecordButton()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.FixedRecordButton), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.FixedRecordButton)));
			global::System.Windows.FrameworkElement.DataContextProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.FixedRecordButton), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FixedRecordButton.OnDataContextChanged)));
		}

		// Token: 0x060016A1 RID: 5793 RVA: 0x00064F50 File Offset: 0x00063150
		public FixedRecordButton()
		{
			base.SetValue(global::Infragistics.Windows.DataPresenter.FixedRecordButton.FixToTopCommandPropertyKey, new global::Infragistics.Windows.DataPresenter.FixedRecordButton.FixCommand(this, global::Infragistics.Windows.DataPresenter.DataPresenterCommands.FixRecordTop));
			base.SetValue(global::Infragistics.Windows.DataPresenter.FixedRecordButton.FixToBottomCommandPropertyKey, new global::Infragistics.Windows.DataPresenter.FixedRecordButton.FixCommand(this, global::Infragistics.Windows.DataPresenter.DataPresenterCommands.FixRecordBottom));
			base.SetValue(global::Infragistics.Windows.DataPresenter.FixedRecordButton.UnfixCommandPropertyKey, new global::Infragistics.Windows.DataPresenter.FixedRecordButton.FixCommand(this, global::Infragistics.Windows.DataPresenter.DataPresenterCommands.UnfixRecord));
		}

		// Token: 0x060016A2 RID: 5794 RVA: 0x00064FA5 File Offset: 0x000631A5
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.DataPresenter.FixedRecordButtonAutomationPeer(this);
		}

		// Token: 0x060016A3 RID: 5795 RVA: 0x00064FB0 File Offset: 0x000631B0
		protected override void OnPreviewMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (this.IsFixedOnBottomAllowed && this.IsFixedOnTopAllowed)
			{
				global::Infragistics.Windows.DataPresenter.Record record = base.DataContext as global::Infragistics.Windows.DataPresenter.Record;
				if (record != null && !record.IsActive && record.IsActivatable)
				{
					record.IsActive = true;
				}
			}
			base.OnPreviewMouseLeftButtonDown(e);
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x060016A4 RID: 5796 RVA: 0x00064FFA File Offset: 0x000631FA
		[global::System.ComponentModel.Category("Behavior")]
		[global::System.ComponentModel.Description("Returns the command to unfix the record to make it scrollable (read-only)")]
		public global::System.Windows.Input.ICommand CurrentCommand
		{
			get
			{
				return (global::System.Windows.Input.ICommand)base.GetValue(global::Infragistics.Windows.DataPresenter.FixedRecordButton.CurrentCommandProperty);
			}
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x060016A5 RID: 5797 RVA: 0x0006500C File Offset: 0x0006320C
		[global::System.ComponentModel.Description("Returns the command to fix the record to the top (read-only)")]
		[global::System.ComponentModel.Category("Behavior")]
		public global::System.Windows.Input.ICommand FixToTopCommand
		{
			get
			{
				return (global::System.Windows.Input.ICommand)base.GetValue(global::Infragistics.Windows.DataPresenter.FixedRecordButton.FixToTopCommandProperty);
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x060016A6 RID: 5798 RVA: 0x0006501E File Offset: 0x0006321E
		[global::System.ComponentModel.Category("Behavior")]
		[global::System.ComponentModel.Description("Returns the command to fix the record to the bottom (read-only)")]
		public global::System.Windows.Input.ICommand FixToBottomCommand
		{
			get
			{
				return (global::System.Windows.Input.ICommand)base.GetValue(global::Infragistics.Windows.DataPresenter.FixedRecordButton.FixToBottomCommandProperty);
			}
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x060016A7 RID: 5799 RVA: 0x00065030 File Offset: 0x00063230
		[global::System.ComponentModel.Category("Behavior")]
		[global::System.ComponentModel.Description("Returns the command to unfix the record to make it scrollable (read-only)")]
		public global::System.Windows.Input.ICommand UnfixCommand
		{
			get
			{
				return (global::System.Windows.Input.ICommand)base.GetValue(global::Infragistics.Windows.DataPresenter.FixedRecordButton.UnfixCommandProperty);
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x060016A8 RID: 5800 RVA: 0x00065042 File Offset: 0x00063242
		// (set) Token: 0x060016A9 RID: 5801 RVA: 0x00065054 File Offset: 0x00063254
		[global::System.ComponentModel.Bindable(true)]
		public string FixToBottomPrompt
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.FixedRecordButton.FixToBottomPromptProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FixedRecordButton.FixToBottomPromptProperty, value);
			}
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x060016AA RID: 5802 RVA: 0x00065062 File Offset: 0x00063262
		// (set) Token: 0x060016AB RID: 5803 RVA: 0x00065074 File Offset: 0x00063274
		[global::System.ComponentModel.Bindable(true)]
		public string FixToTopPrompt
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.FixedRecordButton.FixToTopPromptProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FixedRecordButton.FixToTopPromptProperty, value);
			}
		}

		// Token: 0x060016AC RID: 5804 RVA: 0x00065084 File Offset: 0x00063284
		private static void OnIsFixedAllowedChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FixedRecordButton fixedRecordButton = target as global::Infragistics.Windows.DataPresenter.FixedRecordButton;
			fixedRecordButton.VerifyCommandState();
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x060016AD RID: 5805 RVA: 0x0006509E File Offset: 0x0006329E
		// (set) Token: 0x060016AE RID: 5806 RVA: 0x000650B0 File Offset: 0x000632B0
		public bool IsFixedOnBottomAllowed
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.FixedRecordButton.IsFixedOnBottomAllowedProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FixedRecordButton.IsFixedOnBottomAllowedProperty, value);
			}
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x060016AF RID: 5807 RVA: 0x000650C3 File Offset: 0x000632C3
		// (set) Token: 0x060016B0 RID: 5808 RVA: 0x000650D5 File Offset: 0x000632D5
		public bool IsFixedOnTopAllowed
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.FixedRecordButton.IsFixedOnTopAllowedProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FixedRecordButton.IsFixedOnTopAllowedProperty, value);
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x060016B1 RID: 5809 RVA: 0x000650E8 File Offset: 0x000632E8
		// (set) Token: 0x060016B2 RID: 5810 RVA: 0x000650FA File Offset: 0x000632FA
		[global::System.ComponentModel.Bindable(true)]
		public string UnfixPrompt
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.FixedRecordButton.UnfixPromptProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FixedRecordButton.UnfixPromptProperty, value);
			}
		}

		// Token: 0x060016B3 RID: 5811 RVA: 0x00065108 File Offset: 0x00063308
		private static void OnDataContextChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FixedRecordButton fixedRecordButton = target as global::Infragistics.Windows.DataPresenter.FixedRecordButton;
			fixedRecordButton.VerifyCommandState();
			global::Infragistics.Windows.DataPresenter.Record record = e.NewValue as global::Infragistics.Windows.DataPresenter.Record;
			if (record != null)
			{
				fixedRecordButton._tracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(record, "FixedLocation", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(fixedRecordButton.VerifyCommandState));
				return;
			}
			fixedRecordButton._tracker = null;
		}

		// Token: 0x060016B4 RID: 5812 RVA: 0x00065158 File Offset: 0x00063358
		private void VerifyCommandState()
		{
			global::Infragistics.Windows.DataPresenter.FixedRecordButton.FixCommand fixCommand = this.FixToBottomCommand as global::Infragistics.Windows.DataPresenter.FixedRecordButton.FixCommand;
			fixCommand.VerifyCanEecute();
			fixCommand = (this.FixToTopCommand as global::Infragistics.Windows.DataPresenter.FixedRecordButton.FixCommand);
			fixCommand.VerifyCanEecute();
			fixCommand = (this.UnfixCommand as global::Infragistics.Windows.DataPresenter.FixedRecordButton.FixCommand);
			fixCommand.VerifyCanEecute();
			global::System.Windows.Input.ICommand command = null;
			global::Infragistics.Windows.DataPresenter.Record record = base.DataContext as global::Infragistics.Windows.DataPresenter.Record;
			if (record != null)
			{
				if (record.FixedLocation == global::Infragistics.Windows.DataPresenter.FixedRecordLocation.Scrollable)
				{
					bool isFixedOnTopAllowed = this.IsFixedOnTopAllowed;
					bool isFixedOnBottomAllowed = this.IsFixedOnBottomAllowed;
					if (isFixedOnBottomAllowed != isFixedOnTopAllowed)
					{
						if (isFixedOnTopAllowed)
						{
							command = this.FixToTopCommand;
						}
						else
						{
							command = this.FixToBottomCommand;
						}
					}
				}
				else
				{
					command = this.UnfixCommand;
				}
			}
			if (command != null)
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FixedRecordButton.CurrentCommandPropertyKey, command);
				return;
			}
			base.ClearValue(global::Infragistics.Windows.DataPresenter.FixedRecordButton.CurrentCommandPropertyKey);
		}

		// Token: 0x04000900 RID: 2304
		private global::Infragistics.Windows.Internal.PropertyValueTracker _tracker;

		// Token: 0x04000901 RID: 2305
		private static readonly global::System.Windows.DependencyPropertyKey CurrentCommandPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("CurrentCommand", typeof(global::System.Windows.Input.ICommand), typeof(global::Infragistics.Windows.DataPresenter.FixedRecordButton), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000902 RID: 2306
		public static readonly global::System.Windows.DependencyProperty CurrentCommandProperty = global::Infragistics.Windows.DataPresenter.FixedRecordButton.CurrentCommandPropertyKey.DependencyProperty;

		// Token: 0x04000903 RID: 2307
		private static readonly global::System.Windows.DependencyPropertyKey FixToTopCommandPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("FixToTopCommand", typeof(global::System.Windows.Input.ICommand), typeof(global::Infragistics.Windows.DataPresenter.FixedRecordButton), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000904 RID: 2308
		public static readonly global::System.Windows.DependencyProperty FixToTopCommandProperty = global::Infragistics.Windows.DataPresenter.FixedRecordButton.FixToTopCommandPropertyKey.DependencyProperty;

		// Token: 0x04000905 RID: 2309
		private static readonly global::System.Windows.DependencyPropertyKey FixToBottomCommandPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("FixToBottomCommand", typeof(global::System.Windows.Input.ICommand), typeof(global::Infragistics.Windows.DataPresenter.FixedRecordButton), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000906 RID: 2310
		public static readonly global::System.Windows.DependencyProperty FixToBottomCommandProperty = global::Infragistics.Windows.DataPresenter.FixedRecordButton.FixToBottomCommandPropertyKey.DependencyProperty;

		// Token: 0x04000907 RID: 2311
		private static readonly global::System.Windows.DependencyPropertyKey UnfixCommandPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("UnfixCommand", typeof(global::System.Windows.Input.ICommand), typeof(global::Infragistics.Windows.DataPresenter.FixedRecordButton), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000908 RID: 2312
		public static readonly global::System.Windows.DependencyProperty UnfixCommandProperty = global::Infragistics.Windows.DataPresenter.FixedRecordButton.UnfixCommandPropertyKey.DependencyProperty;

		// Token: 0x04000909 RID: 2313
		public static readonly global::System.Windows.DependencyProperty FixToBottomPromptProperty = global::System.Windows.DependencyProperty.Register("FixToBottomPrompt", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.FixedRecordButton), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x0400090A RID: 2314
		public static readonly global::System.Windows.DependencyProperty FixToTopPromptProperty = global::System.Windows.DependencyProperty.Register("FixToTopPrompt", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.FixedRecordButton), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x0400090B RID: 2315
		public static readonly global::System.Windows.DependencyProperty IsFixedOnBottomAllowedProperty = global::System.Windows.DependencyProperty.Register("IsFixedOnBottomAllowed", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.FixedRecordButton), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FixedRecordButton.OnIsFixedAllowedChanged)));

		// Token: 0x0400090C RID: 2316
		public static readonly global::System.Windows.DependencyProperty IsFixedOnTopAllowedProperty = global::System.Windows.DependencyProperty.Register("IsFixedOnTopAllowed", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.FixedRecordButton), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FixedRecordButton.OnIsFixedAllowedChanged)));

		// Token: 0x0400090D RID: 2317
		public static readonly global::System.Windows.DependencyProperty UnfixPromptProperty = global::System.Windows.DependencyProperty.Register("UnfixPrompt", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.FixedRecordButton), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x02000170 RID: 368
		private class FixCommand : global::System.Windows.Input.ICommand
		{
			// Token: 0x060016B5 RID: 5813 RVA: 0x00065204 File Offset: 0x00063404
			internal FixCommand(global::Infragistics.Windows.DataPresenter.FixedRecordButton owner, global::System.Windows.Input.RoutedCommand command)
			{
				this._owner = owner;
				this._command = command;
			}

			// Token: 0x14000061 RID: 97
			// (add) Token: 0x060016B6 RID: 5814 RVA: 0x0006521C File Offset: 0x0006341C
			// (remove) Token: 0x060016B7 RID: 5815 RVA: 0x00065254 File Offset: 0x00063454
			public event global::System.EventHandler CanExecuteChanged;

			// Token: 0x060016B8 RID: 5816 RVA: 0x00065289 File Offset: 0x00063489
			public bool CanExecute(object parameter)
			{
				return this.CanExecuteHelper();
			}

			// Token: 0x060016B9 RID: 5817 RVA: 0x00065291 File Offset: 0x00063491
			public void Execute(object parameter)
			{
				if (this._command.CanExecute(parameter, this._owner))
				{
					this._command.Execute(parameter, this._owner);
				}
			}

			// Token: 0x060016BA RID: 5818 RVA: 0x000652B9 File Offset: 0x000634B9
			public void VerifyCanEecute()
			{
				if (this._lastCanExecute != null)
				{
					this.CanExecuteHelper();
				}
			}

			// Token: 0x060016BB RID: 5819 RVA: 0x000652D0 File Offset: 0x000634D0
			private bool CanExecuteHelper()
			{
				bool flag = false;
				global::Infragistics.Windows.DataPresenter.Record record = this._owner.DataContext as global::Infragistics.Windows.DataPresenter.Record;
				if (record != null)
				{
					if (this._command == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.FixRecordTop)
					{
						flag = this._owner.IsFixedOnTopAllowed;
					}
					else if (this._command == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.FixRecordBottom)
					{
						flag = this._owner.IsFixedOnBottomAllowed;
					}
					else
					{
						flag = (record.FixedLocation != global::Infragistics.Windows.DataPresenter.FixedRecordLocation.Scrollable);
					}
				}
				if (this._lastCanExecute == null)
				{
					this._lastCanExecute = new bool?(flag);
				}
				else if (this._lastCanExecute.Value != flag)
				{
					this._lastCanExecute = new bool?(flag);
					if (this.CanExecuteChanged != null)
					{
						this.CanExecuteChanged(this, global::System.EventArgs.Empty);
					}
				}
				return flag;
			}

			// Token: 0x0400090E RID: 2318
			private global::Infragistics.Windows.DataPresenter.FixedRecordButton _owner;

			// Token: 0x0400090F RID: 2319
			private global::System.Windows.Input.RoutedCommand _command;

			// Token: 0x04000910 RID: 2320
			private bool? _lastCanExecute;
		}
	}
}
