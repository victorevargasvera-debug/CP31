using System;
using System.Reflection;
using System.Windows.Input;

namespace System.Windows.Interactivity
{
	// Token: 0x02000013 RID: 19
	public sealed class InvokeCommandAction : global::System.Windows.Interactivity.TriggerAction<global::System.Windows.DependencyObject>
	{
		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00003860 File Offset: 0x00001A60
		// (set) Token: 0x06000088 RID: 136 RVA: 0x0000386E File Offset: 0x00001A6E
		public string CommandName
		{
			get
			{
				base.ReadPreamble();
				return this.commandName;
			}
			set
			{
				if (this.CommandName != value)
				{
					base.WritePreamble();
					this.commandName = value;
					base.WritePostscript();
				}
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00003891 File Offset: 0x00001A91
		// (set) Token: 0x0600008A RID: 138 RVA: 0x000038A3 File Offset: 0x00001AA3
		public global::System.Windows.Input.ICommand Command
		{
			get
			{
				return (global::System.Windows.Input.ICommand)base.GetValue(global::System.Windows.Interactivity.InvokeCommandAction.CommandProperty);
			}
			set
			{
				base.SetValue(global::System.Windows.Interactivity.InvokeCommandAction.CommandProperty, value);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600008B RID: 139 RVA: 0x000038B1 File Offset: 0x00001AB1
		// (set) Token: 0x0600008C RID: 140 RVA: 0x000038BE File Offset: 0x00001ABE
		public object CommandParameter
		{
			get
			{
				return base.GetValue(global::System.Windows.Interactivity.InvokeCommandAction.CommandParameterProperty);
			}
			set
			{
				base.SetValue(global::System.Windows.Interactivity.InvokeCommandAction.CommandParameterProperty, value);
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x000038CC File Offset: 0x00001ACC
		protected override void Invoke(object parameter)
		{
			if (base.AssociatedObject != null)
			{
				global::System.Windows.Input.ICommand command = this.ResolveCommand();
				if (command != null && command.CanExecute(this.CommandParameter))
				{
					command.Execute(this.CommandParameter);
				}
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00003908 File Offset: 0x00001B08
		private global::System.Windows.Input.ICommand ResolveCommand()
		{
			global::System.Windows.Input.ICommand result = null;
			if (this.Command != null)
			{
				result = this.Command;
			}
			else if (base.AssociatedObject != null)
			{
				global::System.Type type = base.AssociatedObject.GetType();
				global::System.Reflection.PropertyInfo[] properties = type.GetProperties(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public);
				foreach (global::System.Reflection.PropertyInfo propertyInfo in properties)
				{
					if (typeof(global::System.Windows.Input.ICommand).IsAssignableFrom(propertyInfo.PropertyType) && string.Equals(propertyInfo.Name, this.CommandName, global::System.StringComparison.Ordinal))
					{
						result = (global::System.Windows.Input.ICommand)propertyInfo.GetValue(base.AssociatedObject, null);
					}
				}
			}
			return result;
		}

		// Token: 0x04000027 RID: 39
		private string commandName;

		// Token: 0x04000028 RID: 40
		public static readonly global::System.Windows.DependencyProperty CommandProperty = global::System.Windows.DependencyProperty.Register("Command", typeof(global::System.Windows.Input.ICommand), typeof(global::System.Windows.Interactivity.InvokeCommandAction), null);

		// Token: 0x04000029 RID: 41
		public static readonly global::System.Windows.DependencyProperty CommandParameterProperty = global::System.Windows.DependencyProperty.Register("CommandParameter", typeof(object), typeof(global::System.Windows.Interactivity.InvokeCommandAction), null);
	}
}
