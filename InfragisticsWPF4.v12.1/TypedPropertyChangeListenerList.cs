using System;

namespace Infragistics
{
	// Token: 0x02000056 RID: 86
	internal class TypedPropertyChangeListenerList<TItem, TProperty> : global::Infragistics.ITypedPropertyChangeListener<TItem, TProperty>
	{
		// Token: 0x0600036D RID: 877 RVA: 0x0000F814 File Offset: 0x0000DA14
		internal TypedPropertyChangeListenerList()
		{
		}

		// Token: 0x0600036E RID: 878 RVA: 0x0000F81C File Offset: 0x0000DA1C
		internal void Add(global::Infragistics.ITypedPropertyChangeListener<TItem, TProperty> listener, bool useWeakReference)
		{
			this._listeners = global::Infragistics.ListenerList.Add(this._listeners, listener, useWeakReference);
		}

		// Token: 0x0600036F RID: 879 RVA: 0x0000F831 File Offset: 0x0000DA31
		internal void Remove(global::Infragistics.ITypedPropertyChangeListener<TItem, TProperty> listener)
		{
			this._listeners = global::Infragistics.ListenerList.Remove(this._listeners, listener);
		}

		// Token: 0x06000370 RID: 880 RVA: 0x0000F845 File Offset: 0x0000DA45
		public virtual void OnPropertyValueChanged(TItem sender, TProperty property, object extraInfo)
		{
			if (this._listeners != null)
			{
				global::Infragistics.ListenerList.RaisePropertyChanged<TItem, TProperty>(this._listeners, sender, property, extraInfo);
			}
		}

		// Token: 0x0400011E RID: 286
		private object _listeners;
	}
}
