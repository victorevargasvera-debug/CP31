using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using Infragistics.Windows.Automation.Peers.DataPresenter;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000167 RID: 359
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class FixedFieldButton : global::System.Windows.Controls.Control, global::System.Windows.IWeakEventListener
	{
		// Token: 0x06001656 RID: 5718 RVA: 0x00063234 File Offset: 0x00061434
		static FixedFieldButton()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.FixedFieldButton), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.FixedFieldButton)));
		}

		// Token: 0x06001657 RID: 5719 RVA: 0x000633F4 File Offset: 0x000615F4
		public FixedFieldButton()
		{
			base.SetValue(global::Infragistics.Windows.DataPresenter.FixedFieldButton.FixToNearEdgeCommandPropertyKey, new global::Infragistics.Windows.DataPresenter.FixedFieldButton.FixCommand(this, global::Infragistics.Windows.DataPresenter.DataPresenterCommands.FixFieldNear));
			base.SetValue(global::Infragistics.Windows.DataPresenter.FixedFieldButton.FixToFarEdgeCommandPropertyKey, new global::Infragistics.Windows.DataPresenter.FixedFieldButton.FixCommand(this, global::Infragistics.Windows.DataPresenter.DataPresenterCommands.FixFieldFar));
			base.SetValue(global::Infragistics.Windows.DataPresenter.FixedFieldButton.UnfixCommandPropertyKey, new global::Infragistics.Windows.DataPresenter.FixedFieldButton.FixCommand(this, global::Infragistics.Windows.DataPresenter.DataPresenterCommands.UnfixField));
		}

		// Token: 0x06001658 RID: 5720 RVA: 0x00063449 File Offset: 0x00061649
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.DataPresenter.FixedFieldButtonAutomationPeer(this);
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06001659 RID: 5721 RVA: 0x00063451 File Offset: 0x00061651
		public global::System.Windows.Input.ICommand CurrentCommand
		{
			get
			{
				return (global::System.Windows.Input.ICommand)base.GetValue(global::Infragistics.Windows.DataPresenter.FixedFieldButton.CurrentCommandProperty);
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x0600165A RID: 5722 RVA: 0x00063463 File Offset: 0x00061663
		public global::System.Windows.Input.ICommand FixToNearEdgeCommand
		{
			get
			{
				return (global::System.Windows.Input.ICommand)base.GetValue(global::Infragistics.Windows.DataPresenter.FixedFieldButton.FixToNearEdgeCommandProperty);
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x0600165B RID: 5723 RVA: 0x00063475 File Offset: 0x00061675
		public global::System.Windows.Input.ICommand FixToFarEdgeCommand
		{
			get
			{
				return (global::System.Windows.Input.ICommand)base.GetValue(global::Infragistics.Windows.DataPresenter.FixedFieldButton.FixToFarEdgeCommandProperty);
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x0600165C RID: 5724 RVA: 0x00063487 File Offset: 0x00061687
		public global::System.Windows.Input.ICommand UnfixCommand
		{
			get
			{
				return (global::System.Windows.Input.ICommand)base.GetValue(global::Infragistics.Windows.DataPresenter.FixedFieldButton.UnfixCommandProperty);
			}
		}

		// Token: 0x0600165D RID: 5725 RVA: 0x0006349C File Offset: 0x0006169C
		private static void OnFieldChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FixedFieldButton fixedFieldButton = target as global::Infragistics.Windows.DataPresenter.FixedFieldButton;
			fixedFieldButton.VerifyCommandState();
			global::Infragistics.Windows.DataPresenter.Field field = e.OldValue as global::Infragistics.Windows.DataPresenter.Field;
			if (field != null)
			{
				global::System.ComponentModel.PropertyChangedEventManager.RemoveListener(field, fixedFieldButton, string.Empty);
			}
			global::Infragistics.Windows.DataPresenter.Field field2 = e.NewValue as global::Infragistics.Windows.DataPresenter.Field;
			if (field2 != null)
			{
				global::System.ComponentModel.PropertyChangedEventManager.AddListener(field2, fixedFieldButton, string.Empty);
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x0600165E RID: 5726 RVA: 0x000634EE File Offset: 0x000616EE
		// (set) Token: 0x0600165F RID: 5727 RVA: 0x00063500 File Offset: 0x00061700
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.Field)base.GetValue(global::Infragistics.Windows.DataPresenter.FixedFieldButton.FieldProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FixedFieldButton.FieldProperty, value);
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06001660 RID: 5728 RVA: 0x0006350E File Offset: 0x0006170E
		// (set) Token: 0x06001661 RID: 5729 RVA: 0x00063520 File Offset: 0x00061720
		[global::System.ComponentModel.Bindable(true)]
		public string FixToFarEdgePrompt
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.FixedFieldButton.FixToFarEdgePromptProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FixedFieldButton.FixToFarEdgePromptProperty, value);
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06001662 RID: 5730 RVA: 0x0006352E File Offset: 0x0006172E
		// (set) Token: 0x06001663 RID: 5731 RVA: 0x00063540 File Offset: 0x00061740
		[global::System.ComponentModel.Bindable(true)]
		public string FixToNearEdgePrompt
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.FixedFieldButton.FixToNearEdgePromptProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FixedFieldButton.FixToNearEdgePromptProperty, value);
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06001664 RID: 5732 RVA: 0x0006354E File Offset: 0x0006174E
		// (set) Token: 0x06001665 RID: 5733 RVA: 0x00063560 File Offset: 0x00061760
		[global::System.ComponentModel.Bindable(true)]
		public string UnfixPrompt
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.FixedFieldButton.UnfixPromptProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FixedFieldButton.UnfixPromptProperty, value);
			}
		}

		// Token: 0x06001666 RID: 5734 RVA: 0x00063570 File Offset: 0x00061770
		private void OnFieldPropertyChanged(global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			string propertyName;
			if ((propertyName = e.PropertyName) != null)
			{
				if (!(propertyName == "FixedLocation") && !(propertyName == "AllowFixingResolved"))
				{
					return;
				}
				this.VerifyCommandState();
			}
		}

		// Token: 0x06001667 RID: 5735 RVA: 0x000635A8 File Offset: 0x000617A8
		private void VerifyCommandState()
		{
			global::Infragistics.Windows.DataPresenter.FixedFieldButton.FixCommand fixCommand = this.FixToFarEdgeCommand as global::Infragistics.Windows.DataPresenter.FixedFieldButton.FixCommand;
			fixCommand.VerifyCanEecute();
			fixCommand = (this.FixToNearEdgeCommand as global::Infragistics.Windows.DataPresenter.FixedFieldButton.FixCommand);
			fixCommand.VerifyCanEecute();
			fixCommand = (this.UnfixCommand as global::Infragistics.Windows.DataPresenter.FixedFieldButton.FixCommand);
			fixCommand.VerifyCanEecute();
			global::System.Windows.Input.ICommand command = null;
			global::Infragistics.Windows.DataPresenter.Field field = this.Field;
			if (field != null)
			{
				if (field.FixedLocation == global::Infragistics.Windows.DataPresenter.FixedFieldLocation.Scrollable)
				{
					switch (field.AllowFixingResolved)
					{
					case global::Infragistics.Windows.DataPresenter.AllowFieldFixing.Near:
						command = this.FixToNearEdgeCommand;
						break;
					case global::Infragistics.Windows.DataPresenter.AllowFieldFixing.Far:
						command = this.FixToFarEdgeCommand;
						break;
					}
				}
				else
				{
					command = this.UnfixCommand;
				}
			}
			if (command != null)
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FixedFieldButton.CurrentCommandPropertyKey, command);
				return;
			}
			base.ClearValue(global::Infragistics.Windows.DataPresenter.FixedFieldButton.CurrentCommandPropertyKey);
		}

		// Token: 0x06001668 RID: 5736 RVA: 0x00063650 File Offset: 0x00061850
		bool global::System.Windows.IWeakEventListener.ReceiveWeakEvent(global::System.Type managerType, object sender, global::System.EventArgs e)
		{
			if (managerType == typeof(global::System.ComponentModel.PropertyChangedEventManager))
			{
				global::System.ComponentModel.PropertyChangedEventArgs propertyChangedEventArgs = e as global::System.ComponentModel.PropertyChangedEventArgs;
				if (propertyChangedEventArgs != null)
				{
					if (sender is global::Infragistics.Windows.DataPresenter.Field)
					{
						this.OnFieldPropertyChanged(propertyChangedEventArgs);
						return true;
					}
					return false;
				}
			}
			return false;
		}

		// Token: 0x040008CD RID: 2253
		private static readonly global::System.Windows.DependencyPropertyKey CurrentCommandPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("CurrentCommand", typeof(global::System.Windows.Input.ICommand), typeof(global::Infragistics.Windows.DataPresenter.FixedFieldButton), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040008CE RID: 2254
		public static readonly global::System.Windows.DependencyProperty CurrentCommandProperty = global::Infragistics.Windows.DataPresenter.FixedFieldButton.CurrentCommandPropertyKey.DependencyProperty;

		// Token: 0x040008CF RID: 2255
		private static readonly global::System.Windows.DependencyPropertyKey FixToNearEdgeCommandPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("FixToNearEdgeCommand", typeof(global::System.Windows.Input.ICommand), typeof(global::Infragistics.Windows.DataPresenter.FixedFieldButton), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040008D0 RID: 2256
		public static readonly global::System.Windows.DependencyProperty FixToNearEdgeCommandProperty = global::Infragistics.Windows.DataPresenter.FixedFieldButton.FixToNearEdgeCommandPropertyKey.DependencyProperty;

		// Token: 0x040008D1 RID: 2257
		private static readonly global::System.Windows.DependencyPropertyKey FixToFarEdgeCommandPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("FixToFarEdgeCommand", typeof(global::System.Windows.Input.ICommand), typeof(global::Infragistics.Windows.DataPresenter.FixedFieldButton), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040008D2 RID: 2258
		public static readonly global::System.Windows.DependencyProperty FixToFarEdgeCommandProperty = global::Infragistics.Windows.DataPresenter.FixedFieldButton.FixToFarEdgeCommandPropertyKey.DependencyProperty;

		// Token: 0x040008D3 RID: 2259
		private static readonly global::System.Windows.DependencyPropertyKey UnfixCommandPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("UnfixCommand", typeof(global::System.Windows.Input.ICommand), typeof(global::Infragistics.Windows.DataPresenter.FixedFieldButton), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040008D4 RID: 2260
		public static readonly global::System.Windows.DependencyProperty UnfixCommandProperty = global::Infragistics.Windows.DataPresenter.FixedFieldButton.UnfixCommandPropertyKey.DependencyProperty;

		// Token: 0x040008D5 RID: 2261
		public static readonly global::System.Windows.DependencyProperty FieldProperty = global::System.Windows.DependencyProperty.Register("Field", typeof(global::Infragistics.Windows.DataPresenter.Field), typeof(global::Infragistics.Windows.DataPresenter.FixedFieldButton), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FixedFieldButton.OnFieldChanged)));

		// Token: 0x040008D6 RID: 2262
		public static readonly global::System.Windows.DependencyProperty FixToFarEdgePromptProperty = global::System.Windows.DependencyProperty.Register("FixToFarEdgePrompt", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.FixedFieldButton), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x040008D7 RID: 2263
		public static readonly global::System.Windows.DependencyProperty FixToNearEdgePromptProperty = global::System.Windows.DependencyProperty.Register("FixToNearEdgePrompt", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.FixedFieldButton), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x040008D8 RID: 2264
		public static readonly global::System.Windows.DependencyProperty UnfixPromptProperty = global::System.Windows.DependencyProperty.Register("UnfixPrompt", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.FixedFieldButton), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x02000168 RID: 360
		private class FixCommand : global::System.Windows.Input.ICommand
		{
			// Token: 0x06001669 RID: 5737 RVA: 0x0006368F File Offset: 0x0006188F
			internal FixCommand(global::Infragistics.Windows.DataPresenter.FixedFieldButton owner, global::System.Windows.Input.RoutedCommand command)
			{
				this._owner = owner;
				this._command = command;
			}

			// Token: 0x14000060 RID: 96
			// (add) Token: 0x0600166A RID: 5738 RVA: 0x000636A8 File Offset: 0x000618A8
			// (remove) Token: 0x0600166B RID: 5739 RVA: 0x000636E0 File Offset: 0x000618E0
			public event global::System.EventHandler CanExecuteChanged;

			// Token: 0x0600166C RID: 5740 RVA: 0x00063715 File Offset: 0x00061915
			public bool CanExecute(object parameter)
			{
				return this.CanExecuteHelper();
			}

			// Token: 0x0600166D RID: 5741 RVA: 0x0006371D File Offset: 0x0006191D
			public void Execute(object parameter)
			{
				if (this._command.CanExecute(parameter, this._owner))
				{
					this._command.Execute(parameter, this._owner);
				}
			}

			// Token: 0x0600166E RID: 5742 RVA: 0x00063745 File Offset: 0x00061945
			public void VerifyCanEecute()
			{
				if (this._lastCanExecute != null)
				{
					this.CanExecuteHelper();
				}
			}

			// Token: 0x0600166F RID: 5743 RVA: 0x0006375C File Offset: 0x0006195C
			private bool CanExecuteHelper()
			{
				bool flag = false;
				global::Infragistics.Windows.DataPresenter.Field field = this._owner.Field;
				if (field != null)
				{
					if (this._command == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.UnfixField)
					{
						flag = (field.FixedLocation != global::Infragistics.Windows.DataPresenter.FixedFieldLocation.Scrollable);
					}
					else
					{
						global::Infragistics.Windows.DataPresenter.AllowFieldFixing allowFixingResolved = field.AllowFixingResolved;
						if (this._command == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.FixFieldFar)
						{
							flag = (allowFixingResolved == global::Infragistics.Windows.DataPresenter.AllowFieldFixing.Far || allowFixingResolved == global::Infragistics.Windows.DataPresenter.AllowFieldFixing.NearOrFar);
						}
						else if (this._command == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.FixFieldNear)
						{
							flag = (allowFixingResolved == global::Infragistics.Windows.DataPresenter.AllowFieldFixing.Near || allowFixingResolved == global::Infragistics.Windows.DataPresenter.AllowFieldFixing.NearOrFar);
						}
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

			// Token: 0x040008D9 RID: 2265
			private global::Infragistics.Windows.DataPresenter.FixedFieldButton _owner;

			// Token: 0x040008DA RID: 2266
			private global::System.Windows.Input.RoutedCommand _command;

			// Token: 0x040008DB RID: 2267
			private bool? _lastCanExecute;
		}
	}
}
