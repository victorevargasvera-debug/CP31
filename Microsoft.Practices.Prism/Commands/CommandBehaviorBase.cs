using System;
using System.Windows;
using System.Windows.Input;

namespace Microsoft.Practices.Prism.Commands
{
	// Token: 0x02000003 RID: 3
	public class CommandBehaviorBase<T> where T : global::System.Windows.UIElement
	{
		// Token: 0x06000014 RID: 20 RVA: 0x00002278 File Offset: 0x00000478
		public CommandBehaviorBase(T targetObject)
		{
			this.targetObject = new global::System.WeakReference(targetObject);
			this.commandCanExecuteChangedHandler = new global::System.EventHandler(this.CommandCanExecuteChanged);
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000015 RID: 21 RVA: 0x000022A3 File Offset: 0x000004A3
		// (set) Token: 0x06000016 RID: 22 RVA: 0x000022AC File Offset: 0x000004AC
		public global::System.Windows.Input.ICommand Command
		{
			get
			{
				return this.command;
			}
			set
			{
				if (this.command != null)
				{
					this.command.CanExecuteChanged -= this.commandCanExecuteChangedHandler;
				}
				this.command = value;
				if (this.command != null)
				{
					this.command.CanExecuteChanged += this.commandCanExecuteChangedHandler;
					this.UpdateEnabledState();
				}
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000017 RID: 23 RVA: 0x000022F8 File Offset: 0x000004F8
		// (set) Token: 0x06000018 RID: 24 RVA: 0x00002300 File Offset: 0x00000500
		public object CommandParameter
		{
			get
			{
				return this.commandParameter;
			}
			set
			{
				if (this.commandParameter != value)
				{
					this.commandParameter = value;
					this.UpdateEnabledState();
				}
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00002318 File Offset: 0x00000518
		protected T TargetObject
		{
			get
			{
				return this.targetObject.Target as T;
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002330 File Offset: 0x00000530
		protected virtual void UpdateEnabledState()
		{
			if (this.TargetObject == null)
			{
				this.Command = null;
				this.CommandParameter = null;
				return;
			}
			if (this.Command != null)
			{
				T t = this.TargetObject;
				t.IsEnabled = this.Command.CanExecute(this.CommandParameter);
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002386 File Offset: 0x00000586
		private void CommandCanExecuteChanged(object sender, global::System.EventArgs e)
		{
			this.UpdateEnabledState();
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000238E File Offset: 0x0000058E
		protected virtual void ExecuteCommand()
		{
			if (this.Command != null)
			{
				this.Command.Execute(this.CommandParameter);
			}
		}

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Input.ICommand command;

		// Token: 0x04000005 RID: 5
		private object commandParameter;

		// Token: 0x04000006 RID: 6
		private readonly global::System.WeakReference targetObject;

		// Token: 0x04000007 RID: 7
		private readonly global::System.EventHandler commandCanExecuteChangedHandler;
	}
}
