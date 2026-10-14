using System;
using System.Collections.Generic;

namespace Infragistics
{
	// Token: 0x02000064 RID: 100
	public abstract class PropertyChangeNotifierExtended : global::Infragistics.PropertyChangeNotifier, global::Infragistics.ISupportPropertyChangeNotifications, global::Infragistics.ITypedSupportPropertyChangeNotifications<object, string>, global::Infragistics.IPropertyChangeListener, global::Infragistics.ITypedPropertyChangeListener<object, string>
	{
		// Token: 0x060003FF RID: 1023 RVA: 0x00011343 File Offset: 0x0000F543
		protected override void OnPropertyChanged(string propertyName)
		{
			base.OnPropertyChanged(propertyName);
			this.NotifyListeners(this, propertyName, null);
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00011355 File Offset: 0x0000F555
		protected virtual bool SetField<T>(ref T member, T newValue, string propertyName)
		{
			if (global::System.Collections.Generic.EqualityComparer<T>.Default.Equals(member, newValue))
			{
				return false;
			}
			member = newValue;
			this.OnPropertyChanged(propertyName);
			return true;
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x0001137B File Offset: 0x0000F57B
		internal void AddListener(global::Infragistics.ITypedPropertyChangeListener<object, string> listener, bool useWeakReference)
		{
			this._listeners = global::Infragistics.ListenerList.Add(this._listeners, listener, useWeakReference);
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00011390 File Offset: 0x0000F590
		internal void NotifyListeners(object sender, string property, object extraInfo)
		{
			this.OnSubObjectPropertyChanged(sender, property, extraInfo);
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x0001139B File Offset: 0x0000F59B
		internal virtual void OnSubObjectPropertyChanged(object sender, string property, object extraInfo)
		{
			if (this._listeners != null)
			{
				global::Infragistics.ListenerList.RaisePropertyChanged<object, string>(this._listeners, sender, property, extraInfo);
			}
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x000113B3 File Offset: 0x0000F5B3
		internal void RemoveListener(global::Infragistics.ITypedPropertyChangeListener<object, string> listener)
		{
			this._listeners = global::Infragistics.ListenerList.Remove(this._listeners, listener);
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x000113C7 File Offset: 0x0000F5C7
		void global::Infragistics.ITypedSupportPropertyChangeNotifications<object, string>.AddListener(global::Infragistics.ITypedPropertyChangeListener<object, string> listener, bool useWeakReference)
		{
			this.AddListener(listener, useWeakReference);
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x000113D1 File Offset: 0x0000F5D1
		void global::Infragistics.ITypedSupportPropertyChangeNotifications<object, string>.RemoveListener(global::Infragistics.ITypedPropertyChangeListener<object, string> listener)
		{
			this.RemoveListener(listener);
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x000113DA File Offset: 0x0000F5DA
		void global::Infragistics.ITypedPropertyChangeListener<object, string>.OnPropertyValueChanged(object sender, string property, object extraInfo)
		{
			this.NotifyListeners(sender, property, extraInfo);
		}

		// Token: 0x04000156 RID: 342
		private object _listeners;
	}
}
