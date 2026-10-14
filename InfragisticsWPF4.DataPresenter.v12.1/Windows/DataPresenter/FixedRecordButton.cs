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
	// Token: 0x02000153 RID: 339
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class FixedRecordButton : global::System.Windows.Controls.Control
	{
		// Token: 0x06001328 RID: 4904 RVA: 0x00052FA8 File Offset: 0x000511A8
		static FixedRecordButton()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.FixedRecordButton), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.FixedRecordButton)));
			global::System.Windows.FrameworkElement.DataContextProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.FixedRecordButton), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FixedRecordButton.OnDataContextChanged)));
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x000531C8 File Offset: 0x000513C8
		public FixedRecordButton()
		{
			base.SetValue(global::Infragistics.Windows.DataPresenter.FixedRecordButton.FixToTopCommandPropertyKey, new global::Infragistics.Windows.DataPresenter.FixedRecordButton.FixCommand(this, global::Infragistics.Windows.DataPresenter.DataPresenterCommands.FixRecordTop));
			base.SetValue(global::Infragistics.Windows.DataPresenter.FixedRecordButton.FixToBottomCommandPropertyKey, new global::Infragistics.Windows.DataPresenter.FixedRecordButton.FixCommand(this, global::Infragistics.Windows.DataPresenter.DataPresenterCommands.FixRecordBottom));
			base.SetValue(global::Infragistics.Windows.DataPresenter.FixedRecordButton.UnfixCommandPropertyKey, new global::Infragistics.Windows.DataPresenter.FixedRecordButton.FixCommand(this, global::Infragistics.Windows.DataPresenter.DataPresenterCommands.UnfixRecord));
		}

		// Token: 0x0600132A RID: 4906 RVA: 0x0005321D File Offset: 0x0005141D
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.DataPresenter.FixedRecordButtonAutomationPeer(this);
		}

		// Token: 0x0600132B RID: 4907 RVA: 0x00053228 File Offset: 0x00051428
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

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x0600132C RID: 4908 RVA: 0x00053272 File Offset: 0x00051472
		[global::System.ComponentModel.Description("Returns the command to unfix the record to make it scrollable (read-only)")]
		[global::System.ComponentModel.Category("Behavior")]
		public global::System.Windows.Input.ICommand CurrentCommand
		{
			get
			{
				return (global::System.Windows.Input.ICommand)base.GetValue(global::Infragistics.Windows.DataPresenter.FixedRecordButton.CurrentCommandProperty);
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x0600132D RID: 4909 RVA: 0x00053284 File Offset: 0x00051484
		[global::System.ComponentModel.Description("Returns the command to fix the record to the top (read-only)")]
		[global::System.ComponentModel.Category("Behavior")]
		public global::System.Windows.Input.ICommand FixToTopCommand
		{
			get
			{
				return (global::System.Windows.Input.ICommand)base.GetValue(global::Infragistics.Windows.DataPresenter.FixedRecordButton.FixToTopCommandProperty);
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x0600132E RID: 4910 RVA: 0x00053296 File Offset: 0x00051496
		[global::System.ComponentModel.Category("Behavior")]
		[global::System.ComponentModel.Description("Returns the command to fix the record to the bottom (read-only)")]
		public global::System.Windows.Input.ICommand FixToBottomCommand
		{
			get
			{
				return (global::System.Windows.Input.ICommand)base.GetValue(global::Infragistics.Windows.DataPresenter.FixedRecordButton.FixToBottomCommandProperty);
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x0600132F RID: 4911 RVA: 0x000532A8 File Offset: 0x000514A8
		[global::System.ComponentModel.Category("Behavior")]
		[global::System.ComponentModel.Description("Returns the command to unfix the record to make it scrollable (read-only)")]
		public global::System.Windows.Input.ICommand UnfixCommand
		{
			get
			{
				return (global::System.Windows.Input.ICommand)base.GetValue(global::Infragistics.Windows.DataPresenter.FixedRecordButton.UnfixCommandProperty);
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06001330 RID: 4912 RVA: 0x000532BA File Offset: 0x000514BA
		// (set) Token: 0x06001331 RID: 4913 RVA: 0x000532CC File Offset: 0x000514CC
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

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06001332 RID: 4914 RVA: 0x000532DA File Offset: 0x000514DA
		// (set) Token: 0x06001333 RID: 4915 RVA: 0x000532EC File Offset: 0x000514EC
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

		// Token: 0x06001334 RID: 4916 RVA: 0x000532FC File Offset: 0x000514FC
		private static void OnIsFixedAllowedChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FixedRecordButton fixedRecordButton = target as global::Infragistics.Windows.DataPresenter.FixedRecordButton;
			fixedRecordButton.VerifyCommandState();
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06001335 RID: 4917 RVA: 0x00053316 File Offset: 0x00051516
		// (set) Token: 0x06001336 RID: 4918 RVA: 0x00053328 File Offset: 0x00051528
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

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06001337 RID: 4919 RVA: 0x0005333B File Offset: 0x0005153B
		// (set) Token: 0x06001338 RID: 4920 RVA: 0x0005334D File Offset: 0x0005154D
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

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06001339 RID: 4921 RVA: 0x00053360 File Offset: 0x00051560
		// (set) Token: 0x0600133A RID: 4922 RVA: 0x00053372 File Offset: 0x00051572
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

		// Token: 0x0600133B RID: 4923 RVA: 0x00053380 File Offset: 0x00051580
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

		// Token: 0x0600133C RID: 4924 RVA: 0x000533D0 File Offset: 0x000515D0
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

		// Token: 0x0400074E RID: 1870
		private global::Infragistics.Windows.Internal.PropertyValueTracker _tracker;

		// Token: 0x0400074F RID: 1871
		private static readonly global::System.Windows.DependencyPropertyKey CurrentCommandPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("CurrentCommand", typeof(global::System.Windows.Input.ICommand), typeof(global::Infragistics.Windows.DataPresenter.FixedRecordButton), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000750 RID: 1872
		public static readonly global::System.Windows.DependencyProperty CurrentCommandProperty = global::Infragistics.Windows.DataPresenter.FixedRecordButton.CurrentCommandPropertyKey.DependencyProperty;

		// Token: 0x04000751 RID: 1873
		private static readonly global::System.Windows.DependencyPropertyKey FixToTopCommandPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("FixToTopCommand", typeof(global::System.Windows.Input.ICommand), typeof(global::Infragistics.Windows.DataPresenter.FixedRecordButton), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000752 RID: 1874
		public static readonly global::System.Windows.DependencyProperty FixToTopCommandProperty = global::Infragistics.Windows.DataPresenter.FixedRecordButton.FixToTopCommandPropertyKey.DependencyProperty;

		// Token: 0x04000753 RID: 1875
		private static readonly global::System.Windows.DependencyPropertyKey FixToBottomCommandPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("FixToBottomCommand", typeof(global::System.Windows.Input.ICommand), typeof(global::Infragistics.Windows.DataPresenter.FixedRecordButton), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000754 RID: 1876
		public static readonly global::System.Windows.DependencyProperty FixToBottomCommandProperty = global::Infragistics.Windows.DataPresenter.FixedRecordButton.FixToBottomCommandPropertyKey.DependencyProperty;

		// Token: 0x04000755 RID: 1877
		private static readonly global::System.Windows.DependencyPropertyKey UnfixCommandPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("UnfixCommand", typeof(global::System.Windows.Input.ICommand), typeof(global::Infragistics.Windows.DataPresenter.FixedRecordButton), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000756 RID: 1878
		public static readonly global::System.Windows.DependencyProperty UnfixCommandProperty = global::Infragistics.Windows.DataPresenter.FixedRecordButton.UnfixCommandPropertyKey.DependencyProperty;

		// Token: 0x04000757 RID: 1879
		public static readonly global::System.Windows.DependencyProperty FixToBottomPromptProperty = global::System.Windows.DependencyProperty.Register("FixToBottomPrompt", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.FixedRecordButton), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000758 RID: 1880
		public static readonly global::System.Windows.DependencyProperty FixToTopPromptProperty = global::System.Windows.DependencyProperty.Register("FixToTopPrompt", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.FixedRecordButton), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000759 RID: 1881
		public static readonly global::System.Windows.DependencyProperty IsFixedOnBottomAllowedProperty = global::System.Windows.DependencyProperty.Register("IsFixedOnBottomAllowed", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.FixedRecordButton), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FixedRecordButton.OnIsFixedAllowedChanged)));

		// Token: 0x0400075A RID: 1882
		public static readonly global::System.Windows.DependencyProperty IsFixedOnTopAllowedProperty = global::System.Windows.DependencyProperty.Register("IsFixedOnTopAllowed", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.FixedRecordButton), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FixedRecordButton.OnIsFixedAllowedChanged)));

		// Token: 0x0400075B RID: 1883
		public static readonly global::System.Windows.DependencyProperty UnfixPromptProperty = global::System.Windows.DependencyProperty.Register("UnfixPrompt", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.FixedRecordButton), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x02000154 RID: 340
		private class FixCommand : global::System.Windows.Input.ICommand
		{
			// Token: 0x0600133D RID: 4925 RVA: 0x0005347C File Offset: 0x0005167C
			internal FixCommand(global::Infragistics.Windows.DataPresenter.FixedRecordButton owner, global::System.Windows.Input.RoutedCommand command)
			{
				this._owner = owner;
				this._command = command;
			}

			// Token: 0x14000060 RID: 96
			// (add) Token: 0x0600133E RID: 4926 RVA: 0x00053494 File Offset: 0x00051694
			// (remove) Token: 0x0600133F RID: 4927 RVA: 0x000534CC File Offset: 0x000516CC
			public event global::System.EventHandler CanExecuteChanged;

			// Token: 0x06001340 RID: 4928 RVA: 0x00053501 File Offset: 0x00051701
			public bool CanExecute(object parameter)
			{
				return this.CanExecuteHelper();
			}

			// Token: 0x06001341 RID: 4929 RVA: 0x00053509 File Offset: 0x00051709
			public void Execute(object parameter)
			{
				if (this._command.CanExecute(parameter, this._owner))
				{
					this._command.Execute(parameter, this._owner);
				}
			}

			// Token: 0x06001342 RID: 4930 RVA: 0x00053531 File Offset: 0x00051731
			public void VerifyCanEecute()
			{
				if (this._lastCanExecute != null)
				{
					this.CanExecuteHelper();
				}
			}

			// Token: 0x06001343 RID: 4931 RVA: 0x00053548 File Offset: 0x00051748
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

			// Token: 0x0400075C RID: 1884
			private global::Infragistics.Windows.DataPresenter.FixedRecordButton _owner;

			// Token: 0x0400075D RID: 1885
			private global::System.Windows.Input.RoutedCommand _command;

			// Token: 0x0400075E RID: 1886
			private bool? _lastCanExecute;
		}
	}
}
