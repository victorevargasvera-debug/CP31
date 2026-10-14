using System;

namespace Infragistics
{
	// Token: 0x0200006A RID: 106
	internal class TypedPropertyChangeListenerList<TItem, TProperty> : global::Infragistics.ITypedPropertyChangeListener<TItem, TProperty>
	{
		// Token: 0x06000401 RID: 1025 RVA: 0x00011470 File Offset: 0x0000F670
		internal TypedPropertyChangeListenerList()
		{
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00011478 File Offset: 0x0000F678
		internal void Add(global::Infragistics.ITypedPropertyChangeListener<TItem, TProperty> listener, bool useWeakReference)
		{
			this._listeners = global::Infragistics.ListenerList.Add(this._listeners, listener, useWeakReference);
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x0001148D File Offset: 0x0000F68D
		internal void Remove(global::Infragistics.ITypedPropertyChangeListener<TItem, TProperty> listener)
		{
			this._listeners = global::Infragistics.ListenerList.Remove(this._listeners, listener);
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x000114A1 File Offset: 0x0000F6A1
		public virtual void OnPropertyValueChanged(TItem sender, TProperty property, object extraInfo)
		{
			if (this._listeners != null)
			{
				global::Infragistics.ListenerList.RaisePropertyChanged<TItem, TProperty>(this._listeners, sender, property, extraInfo);
			}
		}

		// Token: 0x04000179 RID: 377
		private object _listeners;
	}
}
