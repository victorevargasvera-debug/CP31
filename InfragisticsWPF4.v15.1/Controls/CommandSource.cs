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
	// Token: 0x020000CA RID: 202
	public abstract class CommandSource : global::Infragistics.DependencyObjectNotifier
	{
		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000790 RID: 1936 RVA: 0x0001B790 File Offset: 0x00019990
		// (set) Token: 0x06000791 RID: 1937 RVA: 0x0001B798 File Offset: 0x00019998
		public string EventName { get; set; }

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000792 RID: 1938 RVA: 0x0001B7A1 File Offset: 0x000199A1
		// (set) Token: 0x06000793 RID: 1939 RVA: 0x0001B7A9 File Offset: 0x000199A9
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

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000794 RID: 1940 RVA: 0x0001B7C6 File Offset: 0x000199C6
		// (set) Token: 0x06000795 RID: 1941 RVA: 0x0001B7E1 File Offset: 0x000199E1
		internal global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> SourceElements
		{
			get
			{
				if (this._seList == null)
				{
					this._seList = new global::System.Collections.Generic.List<global::System.Windows.FrameworkElement>();
				}
				return this._seList;
			}
			set
			{
				if (this._seList != value)
				{
					this._seList = value;
					this.OnPropertyChanged("SourceElements");
				}
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000796 RID: 1942 RVA: 0x0001B7FE File Offset: 0x000199FE
		// (set) Token: 0x06000797 RID: 1943 RVA: 0x0001B806 File Offset: 0x00019A06
		public object Target { get; set; }

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000798 RID: 1944 RVA: 0x0001B80F File Offset: 0x00019A0F
		// (set) Token: 0x06000799 RID: 1945 RVA: 0x0001B817 File Offset: 0x00019A17
		public string TargetName { get; set; }

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x0600079A RID: 1946 RVA: 0x0001B820 File Offset: 0x00019A20
		// (set) Token: 0x0600079B RID: 1947 RVA: 0x0001B82D File Offset: 0x00019A2D
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

		// Token: 0x0600079C RID: 1948 RVA: 0x0001B83C File Offset: 0x00019A3C
		private static void ParameterChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.CommandSource commandSource = (global::Infragistics.Controls.CommandSource)obj;
			commandSource.OnPropertyChanged("Parameter");
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600079D RID: 1949 RVA: 0x0001B85B File Offset: 0x00019A5B
		// (set) Token: 0x0600079E RID: 1950 RVA: 0x0001B863 File Offset: 0x00019A63
		public global::System.Windows.Data.Binding ParameterBinding { get; set; }

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600079F RID: 1951 RVA: 0x0001B86C File Offset: 0x00019A6C
		// (set) Token: 0x060007A0 RID: 1952 RVA: 0x0001B874 File Offset: 0x00019A74
		public global::Infragistics.Controls.ParameterBindingDataContext ParameterBindingDataContext { get; set; }

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060007A1 RID: 1953 RVA: 0x0001B880 File Offset: 0x00019A80
		public object ParameterResolved
		{
			get
			{
				if (this.ParameterBinding == null)
				{
					return this.Parameter;
				}
				global::Infragistics.Controls.CommandSource.CommandSourceBindingContext commandSourceBindingContext = new global::Infragistics.Controls.CommandSource.CommandSourceBindingContext();
				if (this.ParameterBindingDataContext == global::Infragistics.Controls.ParameterBindingDataContext.SourceElementDataContext && this.SourceElement.DataContext != null)
				{
					global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding();
					binding.Path = new global::System.Windows.PropertyPath("DataContext", new object[0]);
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

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060007A2 RID: 1954 RVA: 0x0001B919 File Offset: 0x00019B19
		public global::System.Windows.Input.ICommand Command
		{
			get
			{
				return this.ResolveCommand();
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060007A3 RID: 1955 RVA: 0x0001B921 File Offset: 0x00019B21
		// (set) Token: 0x060007A4 RID: 1956 RVA: 0x0001B929 File Offset: 0x00019B29
		public bool Handled { get; set; }

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060007A5 RID: 1957 RVA: 0x0001B932 File Offset: 0x00019B32
		// (set) Token: 0x060007A6 RID: 1958 RVA: 0x0001B93A File Offset: 0x00019B3A
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

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060007A7 RID: 1959 RVA: 0x0001B943 File Offset: 0x00019B43
		// (set) Token: 0x060007A8 RID: 1960 RVA: 0x0001B94B File Offset: 0x00019B4B
		protected internal global::System.Delegate EventHandler { get; set; }

		// Token: 0x060007A9 RID: 1961
		protected abstract global::System.Windows.Input.ICommand ResolveCommand();

		// Token: 0x060007AA RID: 1962 RVA: 0x0001B954 File Offset: 0x00019B54
		protected object ResolveParameter(global::Infragistics.ICommandTarget target)
		{
			object obj = this.ParameterResolved;
			if (obj == null && target != null)
			{
				obj = target.GetParameter(this);
			}
			return obj;
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x0001B978 File Offset: 0x00019B78
		protected void Execute(global::Infragistics.ICommandTarget target, bool canExecute)
		{
			global::System.Windows.Input.ICommand command = this.Command;
			global::Infragistics.ICommandTarget currentTarget = null;
			global::Infragistics.CommandBase commandBase = command as global::Infragistics.CommandBase;
			if (commandBase != null)
			{
				commandBase.CommandSource = this;
				currentTarget = commandBase.CurrentTarget;
				commandBase.CurrentTarget = target;
			}
			try
			{
				object parameter = this.ResolveParameter(target);
				if (canExecute)
				{
					if (command.CanExecute(parameter))
					{
						command.Execute(parameter);
					}
				}
				else
				{
					foreach (global::System.Windows.FrameworkElement frameworkElement in this.SourceElements)
					{
						global::System.Windows.Controls.Control control = frameworkElement as global::System.Windows.Controls.Control;
						if (control != null)
						{
							control.IsEnabled = command.CanExecute(parameter);
						}
					}
				}
			}
			finally
			{
				if (commandBase != null)
				{
					commandBase.CurrentTarget = currentTarget;
				}
			}
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x0001BA40 File Offset: 0x00019C40
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

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060007AD RID: 1965 RVA: 0x0001BB14 File Offset: 0x00019D14
		// (set) Token: 0x060007AE RID: 1966 RVA: 0x0001BB1C File Offset: 0x00019D1C
		public global::System.EventArgs OriginEventArgs { get; protected set; }

		// Token: 0x060007AF RID: 1967 RVA: 0x0001BB28 File Offset: 0x00019D28
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
					if (parent == null && frameworkElement is global::Infragistics.IProvideParent)
					{
						parent = (((global::Infragistics.IProvideParent)frameworkElement).Parent as global::System.Windows.FrameworkElement);
					}
				}
			}
			return itemsControl != null && this.LookForCommandTarget(itemsControl.Parent as global::System.Windows.FrameworkElement, execute, command);
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x0001BBE4 File Offset: 0x00019DE4
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

		// Token: 0x040003B9 RID: 953
		private bool _allowEventHandling = true;

		// Token: 0x040003BA RID: 954
		private global::System.Windows.FrameworkElement _se;

		// Token: 0x040003BB RID: 955
		private global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> _seList;

		// Token: 0x040003BC RID: 956
		public static readonly global::System.Windows.DependencyProperty ParameterProperty = global::System.Windows.DependencyProperty.Register("Parameter", typeof(object), typeof(global::Infragistics.Controls.CommandSource), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.CommandSource.ParameterChanged)));

		// Token: 0x020000CB RID: 203
		private class CommandSourceBindingContext : global::System.Windows.FrameworkElement
		{
			// Token: 0x17000138 RID: 312
			// (get) Token: 0x060007B3 RID: 1971 RVA: 0x0001BC9C File Offset: 0x00019E9C
			// (set) Token: 0x060007B4 RID: 1972 RVA: 0x0001BCA9 File Offset: 0x00019EA9
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

			// Token: 0x060007B5 RID: 1973 RVA: 0x0001BCB7 File Offset: 0x00019EB7
			private static void ValueChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
			{
			}

			// Token: 0x040003C5 RID: 965
			public static readonly global::System.Windows.DependencyProperty ValueProperty = global::System.Windows.DependencyProperty.Register("Value", typeof(object), typeof(global::Infragistics.Controls.CommandSource.CommandSourceBindingContext), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.CommandSource.CommandSourceBindingContext.ValueChanged)));
		}
	}
}
