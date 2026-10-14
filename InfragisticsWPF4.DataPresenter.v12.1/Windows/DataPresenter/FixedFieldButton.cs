using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using Infragistics.Windows.Automation.Peers.DataPresenter;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200014B RID: 331
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class FixedFieldButton : global::System.Windows.Controls.Control, global::System.Windows.IWeakEventListener
	{
		// Token: 0x060012DE RID: 4830 RVA: 0x000514AC File Offset: 0x0004F6AC
		static FixedFieldButton()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.FixedFieldButton), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.FixedFieldButton)));
		}

		// Token: 0x060012DF RID: 4831 RVA: 0x0005166C File Offset: 0x0004F86C
		public FixedFieldButton()
		{
			base.SetValue(global::Infragistics.Windows.DataPresenter.FixedFieldButton.FixToNearEdgeCommandPropertyKey, new global::Infragistics.Windows.DataPresenter.FixedFieldButton.FixCommand(this, global::Infragistics.Windows.DataPresenter.DataPresenterCommands.FixFieldNear));
			base.SetValue(global::Infragistics.Windows.DataPresenter.FixedFieldButton.FixToFarEdgeCommandPropertyKey, new global::Infragistics.Windows.DataPresenter.FixedFieldButton.FixCommand(this, global::Infragistics.Windows.DataPresenter.DataPresenterCommands.FixFieldFar));
			base.SetValue(global::Infragistics.Windows.DataPresenter.FixedFieldButton.UnfixCommandPropertyKey, new global::Infragistics.Windows.DataPresenter.FixedFieldButton.FixCommand(this, global::Infragistics.Windows.DataPresenter.DataPresenterCommands.UnfixField));
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x000516C1 File Offset: 0x0004F8C1
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.DataPresenter.FixedFieldButtonAutomationPeer(this);
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x060012E1 RID: 4833 RVA: 0x000516C9 File Offset: 0x0004F8C9
		public global::System.Windows.Input.ICommand CurrentCommand
		{
			get
			{
				return (global::System.Windows.Input.ICommand)base.GetValue(global::Infragistics.Windows.DataPresenter.FixedFieldButton.CurrentCommandProperty);
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x060012E2 RID: 4834 RVA: 0x000516DB File Offset: 0x0004F8DB
		public global::System.Windows.Input.ICommand FixToNearEdgeCommand
		{
			get
			{
				return (global::System.Windows.Input.ICommand)base.GetValue(global::Infragistics.Windows.DataPresenter.FixedFieldButton.FixToNearEdgeCommandProperty);
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x060012E3 RID: 4835 RVA: 0x000516ED File Offset: 0x0004F8ED
		public global::System.Windows.Input.ICommand FixToFarEdgeCommand
		{
			get
			{
				return (global::System.Windows.Input.ICommand)base.GetValue(global::Infragistics.Windows.DataPresenter.FixedFieldButton.FixToFarEdgeCommandProperty);
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x060012E4 RID: 4836 RVA: 0x000516FF File Offset: 0x0004F8FF
		public global::System.Windows.Input.ICommand UnfixCommand
		{
			get
			{
				return (global::System.Windows.Input.ICommand)base.GetValue(global::Infragistics.Windows.DataPresenter.FixedFieldButton.UnfixCommandProperty);
			}
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x00051714 File Offset: 0x0004F914
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

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x060012E6 RID: 4838 RVA: 0x00051766 File Offset: 0x0004F966
		// (set) Token: 0x060012E7 RID: 4839 RVA: 0x00051778 File Offset: 0x0004F978
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

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x060012E8 RID: 4840 RVA: 0x00051786 File Offset: 0x0004F986
		// (set) Token: 0x060012E9 RID: 4841 RVA: 0x00051798 File Offset: 0x0004F998
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

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x060012EA RID: 4842 RVA: 0x000517A6 File Offset: 0x0004F9A6
		// (set) Token: 0x060012EB RID: 4843 RVA: 0x000517B8 File Offset: 0x0004F9B8
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

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x060012EC RID: 4844 RVA: 0x000517C6 File Offset: 0x0004F9C6
		// (set) Token: 0x060012ED RID: 4845 RVA: 0x000517D8 File Offset: 0x0004F9D8
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

		// Token: 0x060012EE RID: 4846 RVA: 0x000517E8 File Offset: 0x0004F9E8
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

		// Token: 0x060012EF RID: 4847 RVA: 0x00051820 File Offset: 0x0004FA20
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

		// Token: 0x060012F0 RID: 4848 RVA: 0x000518C8 File Offset: 0x0004FAC8
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

		// Token: 0x0400071B RID: 1819
		private static readonly global::System.Windows.DependencyPropertyKey CurrentCommandPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("CurrentCommand", typeof(global::System.Windows.Input.ICommand), typeof(global::Infragistics.Windows.DataPresenter.FixedFieldButton), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x0400071C RID: 1820
		public static readonly global::System.Windows.DependencyProperty CurrentCommandProperty = global::Infragistics.Windows.DataPresenter.FixedFieldButton.CurrentCommandPropertyKey.DependencyProperty;

		// Token: 0x0400071D RID: 1821
		private static readonly global::System.Windows.DependencyPropertyKey FixToNearEdgeCommandPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("FixToNearEdgeCommand", typeof(global::System.Windows.Input.ICommand), typeof(global::Infragistics.Windows.DataPresenter.FixedFieldButton), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x0400071E RID: 1822
		public static readonly global::System.Windows.DependencyProperty FixToNearEdgeCommandProperty = global::Infragistics.Windows.DataPresenter.FixedFieldButton.FixToNearEdgeCommandPropertyKey.DependencyProperty;

		// Token: 0x0400071F RID: 1823
		private static readonly global::System.Windows.DependencyPropertyKey FixToFarEdgeCommandPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("FixToFarEdgeCommand", typeof(global::System.Windows.Input.ICommand), typeof(global::Infragistics.Windows.DataPresenter.FixedFieldButton), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000720 RID: 1824
		public static readonly global::System.Windows.DependencyProperty FixToFarEdgeCommandProperty = global::Infragistics.Windows.DataPresenter.FixedFieldButton.FixToFarEdgeCommandPropertyKey.DependencyProperty;

		// Token: 0x04000721 RID: 1825
		private static readonly global::System.Windows.DependencyPropertyKey UnfixCommandPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("UnfixCommand", typeof(global::System.Windows.Input.ICommand), typeof(global::Infragistics.Windows.DataPresenter.FixedFieldButton), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000722 RID: 1826
		public static readonly global::System.Windows.DependencyProperty UnfixCommandProperty = global::Infragistics.Windows.DataPresenter.FixedFieldButton.UnfixCommandPropertyKey.DependencyProperty;

		// Token: 0x04000723 RID: 1827
		public static readonly global::System.Windows.DependencyProperty FieldProperty = global::System.Windows.DependencyProperty.Register("Field", typeof(global::Infragistics.Windows.DataPresenter.Field), typeof(global::Infragistics.Windows.DataPresenter.FixedFieldButton), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FixedFieldButton.OnFieldChanged)));

		// Token: 0x04000724 RID: 1828
		public static readonly global::System.Windows.DependencyProperty FixToFarEdgePromptProperty = global::System.Windows.DependencyProperty.Register("FixToFarEdgePrompt", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.FixedFieldButton), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000725 RID: 1829
		public static readonly global::System.Windows.DependencyProperty FixToNearEdgePromptProperty = global::System.Windows.DependencyProperty.Register("FixToNearEdgePrompt", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.FixedFieldButton), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000726 RID: 1830
		public static readonly global::System.Windows.DependencyProperty UnfixPromptProperty = global::System.Windows.DependencyProperty.Register("UnfixPrompt", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.FixedFieldButton), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x0200014C RID: 332
		private class FixCommand : global::System.Windows.Input.ICommand
		{
			// Token: 0x060012F1 RID: 4849 RVA: 0x00051907 File Offset: 0x0004FB07
			internal FixCommand(global::Infragistics.Windows.DataPresenter.FixedFieldButton owner, global::System.Windows.Input.RoutedCommand command)
			{
				this._owner = owner;
				this._command = command;
			}

			// Token: 0x1400005F RID: 95
			// (add) Token: 0x060012F2 RID: 4850 RVA: 0x00051920 File Offset: 0x0004FB20
			// (remove) Token: 0x060012F3 RID: 4851 RVA: 0x00051958 File Offset: 0x0004FB58
			public event global::System.EventHandler CanExecuteChanged;

			// Token: 0x060012F4 RID: 4852 RVA: 0x0005198D File Offset: 0x0004FB8D
			public bool CanExecute(object parameter)
			{
				return this.CanExecuteHelper();
			}

			// Token: 0x060012F5 RID: 4853 RVA: 0x00051995 File Offset: 0x0004FB95
			public void Execute(object parameter)
			{
				if (this._command.CanExecute(parameter, this._owner))
				{
					this._command.Execute(parameter, this._owner);
				}
			}

			// Token: 0x060012F6 RID: 4854 RVA: 0x000519BD File Offset: 0x0004FBBD
			public void VerifyCanEecute()
			{
				if (this._lastCanExecute != null)
				{
					this.CanExecuteHelper();
				}
			}

			// Token: 0x060012F7 RID: 4855 RVA: 0x000519D4 File Offset: 0x0004FBD4
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

			// Token: 0x04000727 RID: 1831
			private global::Infragistics.Windows.DataPresenter.FixedFieldButton _owner;

			// Token: 0x04000728 RID: 1832
			private global::System.Windows.Input.RoutedCommand _command;

			// Token: 0x04000729 RID: 1833
			private bool? _lastCanExecute;
		}
	}
}
