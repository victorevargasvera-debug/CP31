using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Infragistics
{
	// Token: 0x0200003A RID: 58
	public abstract class PropertyChangeNotifier : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000256 RID: 598 RVA: 0x0000A836 File Offset: 0x00008A36
		protected bool HasListeners
		{
			get
			{
				return this._propertyChangedHandler != null;
			}
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0000A844 File Offset: 0x00008A44
		protected virtual void OnFirstListenerAdding()
		{
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0000A846 File Offset: 0x00008A46
		protected virtual void OnHasListenersChanged()
		{
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0000A848 File Offset: 0x00008A48
		protected virtual void OnPropertyChanged(string propertyName)
		{
			global::System.ComponentModel.PropertyChangedEventHandler propertyChangedHandler = this._propertyChangedHandler;
			if (propertyChangedHandler != null)
			{
				propertyChangedHandler(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0000A86C File Offset: 0x00008A6C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		protected void RaisePropertyChangedEvent(string propertyName)
		{
			this.OnPropertyChanged(propertyName);
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0000A875 File Offset: 0x00008A75
		[global::System.Obsolete("Notifications for nested property has been deprecated. To raise a property change notification for a non-nested property, use the OnPropertyChanged method.", true)]
		protected void RaisePropertyChangedEvent(string propertyName, object nestedSender, global::System.ComponentModel.PropertyChangedEventArgs nestedArgs)
		{
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x0600025C RID: 604 RVA: 0x0000A878 File Offset: 0x00008A78
		// (remove) Token: 0x0600025D RID: 605 RVA: 0x0000A8BC File Offset: 0x00008ABC
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

		// Token: 0x04000094 RID: 148
		private global::System.ComponentModel.PropertyChangedEventHandler _propertyChangedHandler;
	}
}
