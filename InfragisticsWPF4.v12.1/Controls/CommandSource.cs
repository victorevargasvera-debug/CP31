using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;

namespace Infragistics.Controls
{
	// Token: 0x020000B0 RID: 176
	public abstract class CommandSource : global::Infragistics.DependencyObjectNotifier
	{
		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060006AA RID: 1706 RVA: 0x000180D2 File Offset: 0x000162D2
		// (set) Token: 0x060006AB RID: 1707 RVA: 0x000180DA File Offset: 0x000162DA
		public string EventName { get; set; }

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060006AC RID: 1708 RVA: 0x000180E3 File Offset: 0x000162E3
		// (set) Token: 0x060006AD RID: 1709 RVA: 0x000180EB File Offset: 0x000162EB
		public global::System.Windows.FrameworkElement SourceElement
		{
			get
			{
				return this._se;
			}
			protected internal set
			{
				if (this._se != value)
				{
					this._se = value;
					this.OnPropertyChanged("SourceElement");
				}
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060006AE RID: 1710 RVA: 0x00018108 File Offset: 0x00016308
		// (set) Token: 0x060006AF RID: 1711 RVA: 0x00018110 File Offset: 0x00016310
		public object Target { get; set; }

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060006B0 RID: 1712 RVA: 0x00018119 File Offset: 0x00016319
		// (set) Token: 0x060006B1 RID: 1713 RVA: 0x00018121 File Offset: 0x00016321
		public string TargetName { get; set; }

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060006B2 RID: 1714 RVA: 0x0001812A File Offset: 0x0001632A
		// (set) Token: 0x060006B3 RID: 1715 RVA: 0x00018137 File Offset: 0x00016337
		public object Parameter
		{
			get
			{
				return base.GetValue(global::Infragistics.Controls.CommandSource.ParameterProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.CommandSource.ParameterProperty, value);
			}
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x00018148 File Offset: 0x00016348
		private static void ParameterChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.CommandSource commandSource = (global::Infragistics.Controls.CommandSource)obj;
			commandSource.OnPropertyChanged("Parameter");
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060006B5 RID: 1717 RVA: 0x00018167 File Offset: 0x00016367
		// (set) Token: 0x060006B6 RID: 1718 RVA: 0x0001816F File Offset: 0x0001636F
		public global::System.Windows.Data.Binding ParameterBinding { get; set; }

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060006B7 RID: 1719 RVA: 0x00018178 File Offset: 0x00016378
		public object ParameterResolved
		{
			get
			{
				if (this.ParameterBinding == null)
				{
					return this.Parameter;
				}
				global::Infragistics.Controls.CommandSource.CommandSourceBindingContext commandSourceBindingContext = new global::Infragistics.Controls.CommandSource.CommandSourceBindingContext();
				if (this.SourceElement.DataContext != null)
				{
					global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding("DataContext");
					binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
					binding.Source = this.SourceElement;
					commandSourceBindingContext.SetBinding(global::System.Windows.FrameworkElement.DataContextProperty, binding);
				}
				else
				{
					commandSourceBindingContext.DataContext = this.SourceElement;
				}
				commandSourceBindingContext.SetBinding(global::Infragistics.Controls.CommandSource.CommandSourceBindingContext.ValueProperty, this.ParameterBinding);
				return commandSourceBindingContext.Value;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060006B8 RID: 1720 RVA: 0x000181F8 File Offset: 0x000163F8
		public global::System.Windows.Input.ICommand Command
		{
			get
			{
				return this.ResolveCommand();
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060006B9 RID: 1721 RVA: 0x00018200 File Offset: 0x00016400
		// (set) Token: 0x060006BA RID: 1722 RVA: 0x00018208 File Offset: 0x00016408
		public bool Handled { get; set; }

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060006BB RID: 1723 RVA: 0x00018211 File Offset: 0x00016411
		// (set) Token: 0x060006BC RID: 1724 RVA: 0x00018219 File Offset: 0x00016419
		public bool AllowEventHandling
		{
			get
			{
				return this._allowEventHandling;
			}
			set
			{
				this._allowEventHandling = value;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060006BD RID: 1725 RVA: 0x00018222 File Offset: 0x00016422
		// (set) Token: 0x060006BE RID: 1726 RVA: 0x0001822A File Offset: 0x0001642A
		protected internal global::System.Delegate EventHandler { get; set; }

		// Token: 0x060006BF RID: 1727
		protected abstract global::System.Windows.Input.ICommand ResolveCommand();

		// Token: 0x060006C0 RID: 1728 RVA: 0x00018234 File Offset: 0x00016434
		protected object ResolveParameter(global::Infragistics.ICommandTarget target)
		{
			object obj = this.ParameterResolved;
			if (obj == null && target != null)
			{
				obj = target.GetParameter(this);
			}
			return obj;
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x00018258 File Offset: 0x00016458
		protected void Execute(global::Infragistics.ICommandTarget target, bool canExecute)
		{
			global::System.Windows.Input.ICommand command = this.Command;
			global::Infragistics.CommandBase commandBase = command as global::Infragistics.CommandBase;
			if (commandBase != null)
			{
				commandBase.CommandSource = this;
			}
			object parameter = this.ResolveParameter(target);
			if (canExecute)
			{
				if (command.CanExecute(parameter))
				{
					command.Execute(parameter);
					return;
				}
			}
			else
			{
				global::System.Windows.Controls.Control control = this.SourceElement as global::System.Windows.Controls.Control;
				if (control != null)
				{
					control.IsEnabled = command.CanExecute(parameter);
				}
			}
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x000182B8 File Offset: 0x000164B8
		protected internal void InvokeCommand(bool execute)
		{
			global::System.Windows.FrameworkElement sourceElement = this.SourceElement;
			global::System.Windows.Input.ICommand command = this.Command;
			global::Infragistics.CommandBase commandBase = command as global::Infragistics.CommandBase;
			if (commandBase != null)
			{
				commandBase.CommandSource = this;
			}
			if (this.Target == null)
			{
				bool flag = string.IsNullOrEmpty(this.TargetName);
				if (flag && this.LookForCommandTarget(sourceElement, execute, command))
				{
					return;
				}
				global::System.Collections.ObjectModel.Collection<global::Infragistics.ICommandTarget> targets = global::Infragistics.CommandSourceManager.GetTargets(command);
				using (global::System.Collections.Generic.IEnumerator<global::Infragistics.ICommandTarget> enumerator = targets.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						global::Infragistics.ICommandTarget commandTarget = enumerator.Current;
						global::System.Windows.FrameworkElement frameworkElement = commandTarget as global::System.Windows.FrameworkElement;
						if (flag || (frameworkElement != null && frameworkElement.Name == this.TargetName))
						{
							this.Execute(commandTarget, execute);
						}
					}
					return;
				}
			}
			this.Execute(this.Target as global::Infragistics.ICommandTarget, execute);
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060006C3 RID: 1731 RVA: 0x0001838C File Offset: 0x0001658C
		// (set) Token: 0x060006C4 RID: 1732 RVA: 0x00018394 File Offset: 0x00016594
		public global::System.EventArgs OriginEventArgs { get; protected set; }

		// Token: 0x060006C5 RID: 1733 RVA: 0x000183A0 File Offset: 0x000165A0
		private bool LookForCommandTarget(global::System.Windows.FrameworkElement parent, bool execute, global::System.Windows.Input.ICommand command)
		{
			global::System.Windows.Controls.ItemsControl itemsControl = null;
			while (parent != null)
			{
				global::Infragistics.ICommandTarget commandTarget = global::Infragistics.Controls.Commanding.GetCommandTarget(parent) as global::Infragistics.ICommandTarget;
				if (commandTarget != null && commandTarget.SupportsCommand(command))
				{
					this.Execute(commandTarget, execute);
					return true;
				}
				global::System.Windows.Controls.ItemsControl itemsControl2 = parent as global::System.Windows.Controls.ItemsControl;
				if (itemsControl2 != null)
				{
					itemsControl = itemsControl2;
				}
				commandTarget = (parent as global::Infragistics.ICommandTarget);
				if (commandTarget != null && commandTarget.SupportsCommand(command))
				{
					this.Execute(commandTarget, execute);
					return true;
				}
				global::System.Windows.FrameworkElement frameworkElement = parent;
				parent = (global::System.Windows.Media.VisualTreeHelper.GetParent(parent) as global::System.Windows.FrameworkElement);
				if (parent == null && frameworkElement != null)
				{
					parent = (frameworkElement.Parent as global::System.Windows.FrameworkElement);
				}
			}
			return itemsControl != null && this.LookForCommandTarget(itemsControl.Parent as global::System.Windows.FrameworkElement, execute, command);
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x0001843C File Offset: 0x0001663C
		internal void EventFired(object sender, global::System.EventArgs e)
		{
			global::System.Windows.Input.MouseButtonEventArgs mouseButtonEventArgs = e as global::System.Windows.Input.MouseButtonEventArgs;
			if (mouseButtonEventArgs != null && mouseButtonEventArgs.Handled)
			{
				return;
			}
			global::System.Windows.Input.KeyEventArgs keyEventArgs = e as global::System.Windows.Input.KeyEventArgs;
			if (keyEventArgs != null && keyEventArgs.Handled)
			{
				return;
			}
			this.OriginEventArgs = e;
			this.InvokeCommand(true);
			if (this.Handled && this.AllowEventHandling)
			{
				if (mouseButtonEventArgs != null)
				{
					mouseButtonEventArgs.Handled = true;
				}
				if (keyEventArgs != null)
				{
					keyEventArgs.Handled = true;
				}
				this.Handled = false;
			}
			this.OriginEventArgs = null;
		}

		// Token: 0x04000315 RID: 789
		private bool _allowEventHandling = true;

		// Token: 0x04000316 RID: 790
		private global::System.Windows.FrameworkElement _se;

		// Token: 0x04000317 RID: 791
		public static readonly global::System.Windows.DependencyProperty ParameterProperty = global::System.Windows.DependencyProperty.Register("Parameter", typeof(object), typeof(global::Infragistics.Controls.CommandSource), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.CommandSource.ParameterChanged)));

		// Token: 0x020000B1 RID: 177
		private class CommandSourceBindingContext : global::System.Windows.FrameworkElement
		{
			// Token: 0x17000121 RID: 289
			// (get) Token: 0x060006C9 RID: 1737 RVA: 0x000184F4 File Offset: 0x000166F4
			// (set) Token: 0x060006CA RID: 1738 RVA: 0x00018501 File Offset: 0x00016701
			public object Value
			{
				get
				{
					return base.GetValue(global::Infragistics.Controls.CommandSource.CommandSourceBindingContext.ValueProperty);
				}
				set
				{
					base.SetValue(global::Infragistics.Controls.CommandSource.CommandSourceBindingContext.ValueProperty, value);
				}
			}

			// Token: 0x060006CB RID: 1739 RVA: 0x0001850F File Offset: 0x0001670F
			private static void ValueChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
			{
			}

			// Token: 0x0400031F RID: 799
			public static readonly global::System.Windows.DependencyProperty ValueProperty = global::System.Windows.DependencyProperty.Register("Value", typeof(object), typeof(global::Infragistics.Controls.CommandSource.CommandSourceBindingContext), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.CommandSource.CommandSourceBindingContext.ValueChanged)));
		}
	}
}
