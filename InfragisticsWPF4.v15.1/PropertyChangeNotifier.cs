using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Infragistics
{
	// Token: 0x0200004E RID: 78
	public abstract class PropertyChangeNotifier : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x0000C2C0 File Offset: 0x0000A4C0
		protected bool HasListeners
		{
			get
			{
				return this._propertyChangedHandler != null;
			}
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x0000C2CE File Offset: 0x0000A4CE
		protected virtual void OnFirstListenerAdding()
		{
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x0000C2D0 File Offset: 0x0000A4D0
		protected virtual void OnHasListenersChanged()
		{
		}

		// Token: 0x060002EA RID: 746 RVA: 0x0000C2D4 File Offset: 0x0000A4D4
		protected virtual void OnPropertyChanged(string propertyName)
		{
			global::System.ComponentModel.PropertyChangedEventHandler propertyChangedHandler = this._propertyChangedHandler;
			if (propertyChangedHandler != null)
			{
				propertyChangedHandler(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x060002EB RID: 747 RVA: 0x0000C2F8 File Offset: 0x0000A4F8
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		protected void RaisePropertyChangedEvent(string propertyName)
		{
			this.OnPropertyChanged(propertyName);
		}

		// Token: 0x060002EC RID: 748 RVA: 0x0000C301 File Offset: 0x0000A501
		[global::System.Obsolete("Notifications for nested property has been deprecated. To raise a property change notification for a non-nested property, use the OnPropertyChanged method.", true)]
		protected void RaisePropertyChangedEvent(string propertyName, object nestedSender, global::System.ComponentModel.PropertyChangedEventArgs nestedArgs)
		{
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x060002ED RID: 749 RVA: 0x0000C304 File Offset: 0x0000A504
		// (remove) Token: 0x060002EE RID: 750 RVA: 0x0000C348 File Offset: 0x0000A548
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged
		{
			[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
			add
			{
				bool hasListeners = this.HasListeners;
				if (!hasListeners)
				{
					this.OnFirstListenerAdding();
				}
				this._propertyChangedHandler = (global::System.Delegate.Combine(this._propertyChangedHandler, value) as global::System.ComponentModel.PropertyChangedEventHandler);
				if (this.HasListeners != hasListeners)
				{
					this.OnHasListenersChanged();
				}
			}
			[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
			remove
			{
				bool hasListeners = this.HasListeners;
				this._propertyChangedHandler = (global::System.Delegate.Remove(this._propertyChangedHandler, value) as global::System.ComponentModel.PropertyChangedEventHandler);
				if (this.HasListeners != hasListeners)
				{
					this.OnHasListenersChanged();
				}
			}
		}

		// Token: 0x040000EF RID: 239
		private global::System.ComponentModel.PropertyChangedEventHandler _propertyChangedHandler;
	}
}
