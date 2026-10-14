using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Microsoft.Practices.Prism.Properties;

namespace Microsoft.Practices.Prism.Commands
{
	// Token: 0x02000006 RID: 6
	public class CompositeCommand : global::System.Windows.Input.ICommand
	{
		// Token: 0x06000027 RID: 39 RVA: 0x0000257D File Offset: 0x0000077D
		public CompositeCommand()
		{
			this.onRegisteredCommandCanExecuteChangedHandler = new global::System.EventHandler(this.OnRegisteredCommandCanExecuteChanged);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000025A2 File Offset: 0x000007A2
		public CompositeCommand(bool monitorCommandActivity) : this()
		{
			this.monitorCommandActivity = monitorCommandActivity;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000025B4 File Offset: 0x000007B4
		public virtual void RegisterCommand(global::System.Windows.Input.ICommand command)
		{
			if (command == null)
			{
				throw new global::System.ArgumentNullException("command");
			}
			if (command == this)
			{
				throw new global::System.ArgumentException(global::Microsoft.Practices.Prism.Properties.Resources.CannotRegisterCompositeCommandInItself);
			}
			lock (this.registeredCommands)
			{
				if (this.registeredCommands.Contains(command))
				{
					throw new global::System.InvalidOperationException(global::Microsoft.Practices.Prism.Properties.Resources.CannotRegisterSameCommandTwice);
				}
				this.registeredCommands.Add(command);
			}
			command.CanExecuteChanged += this.onRegisteredCommandCanExecuteChangedHandler;
			this.OnCanExecuteChanged();
			if (this.monitorCommandActivity)
			{
				global::Microsoft.Practices.Prism.IActiveAware activeAware = command as global::Microsoft.Practices.Prism.IActiveAware;
				if (activeAware != null)
				{
					activeAware.IsActiveChanged += this.Command_IsActiveChanged;
				}
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002668 File Offset: 0x00000868
		public virtual void UnregisterCommand(global::System.Windows.Input.ICommand command)
		{
			if (command == null)
			{
				throw new global::System.ArgumentNullException("command");
			}
			bool flag2;
			lock (this.registeredCommands)
			{
				flag2 = this.registeredCommands.Remove(command);
			}
			if (flag2)
			{
				command.CanExecuteChanged -= this.onRegisteredCommandCanExecuteChangedHandler;
				this.OnCanExecuteChanged();
				if (this.monitorCommandActivity)
				{
					global::Microsoft.Practices.Prism.IActiveAware activeAware = command as global::Microsoft.Practices.Prism.IActiveAware;
					if (activeAware != null)
					{
						activeAware.IsActiveChanged -= this.Command_IsActiveChanged;
					}
				}
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000026F8 File Offset: 0x000008F8
		private void OnRegisteredCommandCanExecuteChanged(object sender, global::System.EventArgs e)
		{
			this.OnCanExecuteChanged();
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002700 File Offset: 0x00000900
		public virtual bool CanExecute(object parameter)
		{
			bool result = false;
			global::System.Windows.Input.ICommand[] array;
			lock (this.registeredCommands)
			{
				array = this.registeredCommands.ToArray();
			}
			foreach (global::System.Windows.Input.ICommand command in array)
			{
				if (this.ShouldExecute(command))
				{
					if (!command.CanExecute(parameter))
					{
						return false;
					}
					result = true;
				}
			}
			return result;
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600002D RID: 45 RVA: 0x00002784 File Offset: 0x00000984
		// (remove) Token: 0x0600002E RID: 46 RVA: 0x00002793 File Offset: 0x00000993
		public event global::System.EventHandler CanExecuteChanged
		{
			add
			{
				global::Microsoft.Practices.Prism.Commands.WeakEventHandlerManager.AddWeakReferenceHandler(ref this._canExecuteChangedHandlers, value, 2);
			}
			remove
			{
				global::Microsoft.Practices.Prism.Commands.WeakEventHandlerManager.RemoveWeakReferenceHandler(this._canExecuteChangedHandlers, value);
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000027A4 File Offset: 0x000009A4
		public virtual void Execute(object parameter)
		{
			global::System.Collections.Generic.Queue<global::System.Windows.Input.ICommand> queue;
			lock (this.registeredCommands)
			{
				queue = new global::System.Collections.Generic.Queue<global::System.Windows.Input.ICommand>(this.registeredCommands.Where(new global::System.Func<global::System.Windows.Input.ICommand, bool>(this.ShouldExecute)).ToList<global::System.Windows.Input.ICommand>());
				goto IL_4E;
			}
			IL_40:
			global::System.Windows.Input.ICommand command = queue.Dequeue();
			command.Execute(parameter);
			IL_4E:
			if (queue.Count <= 0)
			{
				return;
			}
			goto IL_40;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002818 File Offset: 0x00000A18
		protected virtual bool ShouldExecute(global::System.Windows.Input.ICommand command)
		{
			global::Microsoft.Practices.Prism.IActiveAware activeAware = command as global::Microsoft.Practices.Prism.IActiveAware;
			return !this.monitorCommandActivity || activeAware == null || activeAware.IsActive;
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00002840 File Offset: 0x00000A40
		public global::System.Collections.Generic.IList<global::System.Windows.Input.ICommand> RegisteredCommands
		{
			get
			{
				global::System.Collections.Generic.IList<global::System.Windows.Input.ICommand> result;
				lock (this.registeredCommands)
				{
					result = this.registeredCommands.ToList<global::System.Windows.Input.ICommand>();
				}
				return result;
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002888 File Offset: 0x00000A88
		protected virtual void OnCanExecuteChanged()
		{
			global::Microsoft.Practices.Prism.Commands.WeakEventHandlerManager.CallWeakReferenceHandlers(this, this._canExecuteChangedHandlers);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002896 File Offset: 0x00000A96
		private void Command_IsActiveChanged(object sender, global::System.EventArgs e)
		{
			this.OnCanExecuteChanged();
		}

		// Token: 0x0400000B RID: 11
		private readonly global::System.Collections.Generic.List<global::System.Windows.Input.ICommand> registeredCommands = new global::System.Collections.Generic.List<global::System.Windows.Input.ICommand>();

		// Token: 0x0400000C RID: 12
		private readonly bool monitorCommandActivity;

		// Token: 0x0400000D RID: 13
		private readonly global::System.EventHandler onRegisteredCommandCanExecuteChangedHandler;

		// Token: 0x0400000E RID: 14
		private global::System.Collections.Generic.List<global::System.WeakReference> _canExecuteChangedHandlers;
	}
}
