using System;
using System.Collections.Generic;
using System.Windows.Input;
using Microsoft.Practices.Prism.Properties;

namespace Microsoft.Practices.Prism.Commands
{
	// Token: 0x02000008 RID: 8
	public abstract class DelegateCommandBase : global::System.Windows.Input.ICommand, global::Microsoft.Practices.Prism.IActiveAware
	{
		// Token: 0x06000038 RID: 56 RVA: 0x0000289E File Offset: 0x00000A9E
		protected DelegateCommandBase(global::System.Action<object> executeMethod, global::System.Func<object, bool> canExecuteMethod)
		{
			if (executeMethod == null || canExecuteMethod == null)
			{
				throw new global::System.ArgumentNullException("executeMethod", global::Microsoft.Practices.Prism.Properties.Resources.DelegateCommandDelegatesCannotBeNull);
			}
			this.executeMethod = executeMethod;
			this.canExecuteMethod = canExecuteMethod;
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000039 RID: 57 RVA: 0x000028CA File Offset: 0x00000ACA
		// (set) Token: 0x0600003A RID: 58 RVA: 0x000028D2 File Offset: 0x00000AD2
		public bool IsActive
		{
			get
			{
				return this._isActive;
			}
			set
			{
				if (this._isActive != value)
				{
					this._isActive = value;
					this.OnIsActiveChanged();
				}
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000028EA File Offset: 0x00000AEA
		protected virtual void OnCanExecuteChanged()
		{
			global::Microsoft.Practices.Prism.Commands.WeakEventHandlerManager.CallWeakReferenceHandlers(this, this._canExecuteChangedHandlers);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000028F8 File Offset: 0x00000AF8
		public void RaiseCanExecuteChanged()
		{
			this.OnCanExecuteChanged();
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600003D RID: 61 RVA: 0x00002900 File Offset: 0x00000B00
		// (remove) Token: 0x0600003E RID: 62 RVA: 0x00002938 File Offset: 0x00000B38
		public virtual event global::System.EventHandler IsActiveChanged;

		// Token: 0x0600003F RID: 63 RVA: 0x00002970 File Offset: 0x00000B70
		protected virtual void OnIsActiveChanged()
		{
			global::System.EventHandler isActiveChanged = this.IsActiveChanged;
			if (isActiveChanged != null)
			{
				isActiveChanged(this, global::System.EventArgs.Empty);
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002993 File Offset: 0x00000B93
		void global::System.Windows.Input.ICommand.Execute(object parameter)
		{
			this.Execute(parameter);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0000299C File Offset: 0x00000B9C
		bool global::System.Windows.Input.ICommand.CanExecute(object parameter)
		{
			return this.CanExecute(parameter);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000029A5 File Offset: 0x00000BA5
		protected void Execute(object parameter)
		{
			this.executeMethod(parameter);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000029B3 File Offset: 0x00000BB3
		protected bool CanExecute(object parameter)
		{
			return this.canExecuteMethod == null || this.canExecuteMethod(parameter);
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000044 RID: 68 RVA: 0x000029CB File Offset: 0x00000BCB
		// (remove) Token: 0x06000045 RID: 69 RVA: 0x000029DA File Offset: 0x00000BDA
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

		// Token: 0x0400000F RID: 15
		private readonly global::System.Action<object> executeMethod;

		// Token: 0x04000010 RID: 16
		private readonly global::System.Func<object, bool> canExecuteMethod;

		// Token: 0x04000011 RID: 17
		private bool _isActive;

		// Token: 0x04000012 RID: 18
		private global::System.Collections.Generic.List<global::System.WeakReference> _canExecuteChangedHandlers;
	}
}
