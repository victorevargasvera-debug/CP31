using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Infragistics
{
	// Token: 0x02000038 RID: 56
	public abstract class DependencyObjectNotifier : global::System.Windows.DependencyObject, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x06000272 RID: 626 RVA: 0x0000AA2C File Offset: 0x00008C2C
		protected virtual void OnPropertyChanged(string propertyName)
		{
			global::System.ComponentModel.PropertyChangedEventHandler propertyChangedHandler = this._propertyChangedHandler;
			if (propertyChangedHandler != null)
			{
				propertyChangedHandler(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0000AA50 File Offset: 0x00008C50
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		protected void RaisePropertyChangedEvent(string propertyName)
		{
			this.OnPropertyChanged(propertyName);
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0000AA59 File Offset: 0x00008C59
		[global::System.Obsolete("Notifications for nested property has been deprecated. To raise a property change notification for a non-nested property, use the OnPropertyChanged method.", true)]
		protected void RaisePropertyChangedEvent(string propertyName, object nestedSender, global::System.ComponentModel.PropertyChangedEventArgs nestedArgs)
		{
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000275 RID: 629 RVA: 0x0000AA5B File Offset: 0x00008C5B
		// (remove) Token: 0x06000276 RID: 630 RVA: 0x0000AA74 File Offset: 0x00008C74
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

		// Token: 0x040000BE RID: 190
		private global::System.ComponentModel.PropertyChangedEventHandler _propertyChangedHandler;
	}
}
