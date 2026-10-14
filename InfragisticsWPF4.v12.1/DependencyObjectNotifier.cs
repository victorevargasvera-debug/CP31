using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Infragistics
{
	// Token: 0x0200002A RID: 42
	public abstract class DependencyObjectNotifier : global::System.Windows.DependencyObject, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x060001FD RID: 509 RVA: 0x000095C8 File Offset: 0x000077C8
		protected virtual void OnPropertyChanged(string propertyName)
		{
			global::System.ComponentModel.PropertyChangedEventHandler propertyChangedHandler = this._propertyChangedHandler;
			if (propertyChangedHandler != null)
			{
				propertyChangedHandler(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x060001FE RID: 510 RVA: 0x000095EC File Offset: 0x000077EC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		protected void RaisePropertyChangedEvent(string propertyName)
		{
			this.OnPropertyChanged(propertyName);
		}

		// Token: 0x060001FF RID: 511 RVA: 0x000095F5 File Offset: 0x000077F5
		[global::System.Obsolete("Notifications for nested property has been deprecated. To raise a property change notification for a non-nested property, use the OnPropertyChanged method.", true)]
		protected void RaisePropertyChangedEvent(string propertyName, object nestedSender, global::System.ComponentModel.PropertyChangedEventArgs nestedArgs)
		{
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000200 RID: 512 RVA: 0x000095F7 File Offset: 0x000077F7
		// (remove) Token: 0x06000201 RID: 513 RVA: 0x00009610 File Offset: 0x00007810
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged
		{
			[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
			add
			{
				this._propertyChangedHandler = (global::System.Delegate.Combine(this._propertyChangedHandler, value) as global::System.ComponentModel.PropertyChangedEventHandler);
			}
			[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
			remove
			{
				this._propertyChangedHandler = (global::System.Delegate.Remove(this._propertyChangedHandler, value) as global::System.ComponentModel.PropertyChangedEventHandler);
			}
		}

		// Token: 0x04000074 RID: 116
		private global::System.ComponentModel.PropertyChangedEventHandler _propertyChangedHandler;
	}
}
