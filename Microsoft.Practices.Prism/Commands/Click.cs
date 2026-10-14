using System;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace Microsoft.Practices.Prism.Commands
{
	// Token: 0x02000005 RID: 5
	[global::System.Obsolete("The Click static class is obsolete.  Silverlight supports the Command property for buttons.")]
	public static class Click
	{
		// Token: 0x0600001F RID: 31 RVA: 0x000023DA File Offset: 0x000005DA
		public static void SetCommand(global::System.Windows.Controls.Primitives.ButtonBase buttonBase, global::System.Windows.Input.ICommand command)
		{
			if (buttonBase == null)
			{
				throw new global::System.ArgumentNullException("buttonBase");
			}
			buttonBase.SetValue(global::Microsoft.Practices.Prism.Commands.Click.CommandProperty, command);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000023F6 File Offset: 0x000005F6
		public static global::System.Windows.Input.ICommand GetCommand(global::System.Windows.Controls.Primitives.ButtonBase buttonBase)
		{
			if (buttonBase == null)
			{
				throw new global::System.ArgumentNullException("buttonBase");
			}
			return buttonBase.GetValue(global::Microsoft.Practices.Prism.Commands.Click.CommandProperty) as global::System.Windows.Input.ICommand;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002416 File Offset: 0x00000616
		public static void SetCommandParameter(global::System.Windows.Controls.Primitives.ButtonBase buttonBase, object parameter)
		{
			if (buttonBase == null)
			{
				throw new global::System.ArgumentNullException("buttonBase");
			}
			buttonBase.SetValue(global::Microsoft.Practices.Prism.Commands.Click.CommandParameterProperty, parameter);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002432 File Offset: 0x00000632
		public static object GetCommandParameter(global::System.Windows.Controls.Primitives.ButtonBase buttonBase)
		{
			if (buttonBase == null)
			{
				throw new global::System.ArgumentNullException("buttonBase");
			}
			return buttonBase.GetValue(global::Microsoft.Practices.Prism.Commands.Click.CommandParameterProperty);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002450 File Offset: 0x00000650
		private static void OnSetCommandCallback(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Controls.Primitives.ButtonBase buttonBase = dependencyObject as global::System.Windows.Controls.Primitives.ButtonBase;
			if (buttonBase != null)
			{
				global::Microsoft.Practices.Prism.Commands.ButtonBaseClickCommandBehavior orCreateBehavior = global::Microsoft.Practices.Prism.Commands.Click.GetOrCreateBehavior(buttonBase);
				orCreateBehavior.Command = (e.NewValue as global::System.Windows.Input.ICommand);
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002480 File Offset: 0x00000680
		private static void OnSetCommandParameterCallback(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Controls.Primitives.ButtonBase buttonBase = dependencyObject as global::System.Windows.Controls.Primitives.ButtonBase;
			if (buttonBase != null)
			{
				global::Microsoft.Practices.Prism.Commands.ButtonBaseClickCommandBehavior orCreateBehavior = global::Microsoft.Practices.Prism.Commands.Click.GetOrCreateBehavior(buttonBase);
				orCreateBehavior.CommandParameter = e.NewValue;
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000024AC File Offset: 0x000006AC
		private static global::Microsoft.Practices.Prism.Commands.ButtonBaseClickCommandBehavior GetOrCreateBehavior(global::System.Windows.Controls.Primitives.ButtonBase buttonBase)
		{
			global::Microsoft.Practices.Prism.Commands.ButtonBaseClickCommandBehavior buttonBaseClickCommandBehavior = buttonBase.GetValue(global::Microsoft.Practices.Prism.Commands.Click.ClickCommandBehaviorProperty) as global::Microsoft.Practices.Prism.Commands.ButtonBaseClickCommandBehavior;
			if (buttonBaseClickCommandBehavior == null)
			{
				buttonBaseClickCommandBehavior = new global::Microsoft.Practices.Prism.Commands.ButtonBaseClickCommandBehavior(buttonBase);
				buttonBase.SetValue(global::Microsoft.Practices.Prism.Commands.Click.ClickCommandBehaviorProperty, buttonBaseClickCommandBehavior);
			}
			return buttonBaseClickCommandBehavior;
		}

		// Token: 0x04000008 RID: 8
		private static readonly global::System.Windows.DependencyProperty ClickCommandBehaviorProperty = global::System.Windows.DependencyProperty.RegisterAttached("ClickCommandBehavior", typeof(global::Microsoft.Practices.Prism.Commands.ButtonBaseClickCommandBehavior), typeof(global::Microsoft.Practices.Prism.Commands.Click), null);

		// Token: 0x04000009 RID: 9
		public static readonly global::System.Windows.DependencyProperty CommandProperty = global::System.Windows.DependencyProperty.RegisterAttached("Command", typeof(global::System.Windows.Input.ICommand), typeof(global::Microsoft.Practices.Prism.Commands.Click), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Microsoft.Practices.Prism.Commands.Click.OnSetCommandCallback)));

		// Token: 0x0400000A RID: 10
		public static readonly global::System.Windows.DependencyProperty CommandParameterProperty = global::System.Windows.DependencyProperty.RegisterAttached("CommandParameter", typeof(object), typeof(global::Microsoft.Practices.Prism.Commands.Click), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Microsoft.Practices.Prism.Commands.Click.OnSetCommandParameterCallback)));
	}
}
