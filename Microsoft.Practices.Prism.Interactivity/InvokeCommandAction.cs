using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interactivity;
using Microsoft.Practices.Prism.Commands;

namespace Microsoft.Practices.Prism.Interactivity
{
	// Token: 0x02000008 RID: 8
	public class InvokeCommandAction : global::System.Windows.Interactivity.TriggerAction<global::System.Windows.UIElement>
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00002268 File Offset: 0x00000468
		// (set) Token: 0x06000019 RID: 25 RVA: 0x0000227A File Offset: 0x0000047A
		public global::System.Windows.Input.ICommand Command
		{
			get
			{
				return base.GetValue(global::Microsoft.Practices.Prism.Interactivity.InvokeCommandAction.CommandProperty) as global::System.Windows.Input.ICommand;
			}
			set
			{
				base.SetValue(global::Microsoft.Practices.Prism.Interactivity.InvokeCommandAction.CommandProperty, value);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00002288 File Offset: 0x00000488
		// (set) Token: 0x0600001B RID: 27 RVA: 0x00002295 File Offset: 0x00000495
		public object CommandParameter
		{
			get
			{
				return base.GetValue(global::Microsoft.Practices.Prism.Interactivity.InvokeCommandAction.CommandParameterProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Practices.Prism.Interactivity.InvokeCommandAction.CommandParameterProperty, value);
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000022A3 File Offset: 0x000004A3
		public void Invoke()
		{
			this.Invoke(null);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000022AC File Offset: 0x000004AC
		protected override void Invoke(object unusedParameter)
		{
			global::Microsoft.Practices.Prism.Interactivity.InvokeCommandAction.ExecutableCommandBehavior orCreateBehavior = this.GetOrCreateBehavior();
			if (orCreateBehavior != null)
			{
				orCreateBehavior.ExecuteCommand();
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000022C9 File Offset: 0x000004C9
		protected override void OnDetaching()
		{
			base.OnDetaching();
			this.Command = null;
			this.CommandParameter = null;
			this.commandBehavior = null;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000022E8 File Offset: 0x000004E8
		protected override void OnAttached()
		{
			base.OnAttached();
			global::Microsoft.Practices.Prism.Interactivity.InvokeCommandAction.ExecutableCommandBehavior orCreateBehavior = this.GetOrCreateBehavior();
			if (orCreateBehavior.Command != this.Command)
			{
				orCreateBehavior.Command = this.Command;
			}
			if (orCreateBehavior.CommandParameter != this.CommandParameter)
			{
				orCreateBehavior.CommandParameter = this.CommandParameter;
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002338 File Offset: 0x00000538
		private void OnCommandChanged(global::System.Windows.Input.ICommand newValue)
		{
			global::Microsoft.Practices.Prism.Interactivity.InvokeCommandAction.ExecutableCommandBehavior orCreateBehavior = this.GetOrCreateBehavior();
			if (orCreateBehavior != null)
			{
				orCreateBehavior.Command = newValue;
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002358 File Offset: 0x00000558
		private void OnCommandParameterChanged(object newValue)
		{
			global::Microsoft.Practices.Prism.Interactivity.InvokeCommandAction.ExecutableCommandBehavior orCreateBehavior = this.GetOrCreateBehavior();
			if (orCreateBehavior != null)
			{
				orCreateBehavior.CommandParameter = newValue;
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002376 File Offset: 0x00000576
		private global::Microsoft.Practices.Prism.Interactivity.InvokeCommandAction.ExecutableCommandBehavior GetOrCreateBehavior()
		{
			if (this.commandBehavior == null && base.AssociatedObject != null)
			{
				this.commandBehavior = new global::Microsoft.Practices.Prism.Interactivity.InvokeCommandAction.ExecutableCommandBehavior(base.AssociatedObject);
			}
			return this.commandBehavior;
		}

		// Token: 0x04000008 RID: 8
		public static readonly global::System.Windows.DependencyProperty CommandProperty = global::System.Windows.DependencyProperty.Register("Command", typeof(global::System.Windows.Input.ICommand), typeof(global::Microsoft.Practices.Prism.Interactivity.InvokeCommandAction), new global::System.Windows.PropertyMetadata(null, delegate(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Microsoft.Practices.Prism.Interactivity.InvokeCommandAction)d).OnCommandChanged((global::System.Windows.Input.ICommand)e.NewValue);
		}));

		// Token: 0x04000009 RID: 9
		public static readonly global::System.Windows.DependencyProperty CommandParameterProperty = global::System.Windows.DependencyProperty.Register("CommandParameter", typeof(object), typeof(global::Microsoft.Practices.Prism.Interactivity.InvokeCommandAction), new global::System.Windows.PropertyMetadata(null, delegate(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Microsoft.Practices.Prism.Interactivity.InvokeCommandAction)d).OnCommandParameterChanged(e.NewValue);
		}));

		// Token: 0x0400000A RID: 10
		private global::Microsoft.Practices.Prism.Interactivity.InvokeCommandAction.ExecutableCommandBehavior commandBehavior;

		// Token: 0x02000009 RID: 9
		private class ExecutableCommandBehavior : global::Microsoft.Practices.Prism.Commands.CommandBehaviorBase<global::System.Windows.UIElement>
		{
			// Token: 0x06000027 RID: 39 RVA: 0x0000246D File Offset: 0x0000066D
			public ExecutableCommandBehavior(global::System.Windows.UIElement target) : base(target)
			{
			}

			// Token: 0x06000028 RID: 40 RVA: 0x00002476 File Offset: 0x00000676
			public new void ExecuteCommand()
			{
				base.ExecuteCommand();
			}
		}
	}
}
