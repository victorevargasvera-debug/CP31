using System;
using System.Collections.Generic;

namespace Infragistics
{
	// Token: 0x0200007B RID: 123
	public abstract class PropertyChangeNotifierExtended : global::Infragistics.PropertyChangeNotifier, global::Infragistics.ISupportPropertyChangeNotifications, global::Infragistics.ITypedSupportPropertyChangeNotifications<object, string>, global::Infragistics.IPropertyChangeListener, global::Infragistics.ITypedPropertyChangeListener<object, string>
	{
		// Token: 0x060004C0 RID: 1216 RVA: 0x00013AF2 File Offset: 0x00011CF2
		protected override void OnPropertyChanged(string propertyName)
		{
			base.OnPropertyChanged(propertyName);
			this.NotifyListeners(this, propertyName, null);
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00013B04 File Offset: 0x00011D04
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

		// Token: 0x060004C2 RID: 1218 RVA: 0x00013B2A File Offset: 0x00011D2A
		internal void AddListener(global::Infragistics.ITypedPropertyChangeListener<object, string> listener, bool useWeakReference)
		{
			this._listeners = global::Infragistics.ListenerList.Add(this._listeners, listener, useWeakReference);
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00013B3F File Offset: 0x00011D3F
		internal void NotifyListeners(object sender, string property, object extraInfo)
		{
			this.OnSubObjectPropertyChanged(sender, property, extraInfo);
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00013B4A File Offset: 0x00011D4A
		internal virtual void OnSubObjectPropertyChanged(object sender, string property, object extraInfo)
		{
			if (this._listeners != null)
			{
				global::Infragistics.ListenerList.RaisePropertyChanged<object, string>(this._listeners, sender, property, extraInfo);
			}
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00013B62 File Offset: 0x00011D62
		internal void RemoveListener(global::Infragistics.ITypedPropertyChangeListener<object, string> listener)
		{
			this._listeners = global::Infragistics.ListenerList.Remove(this._listeners, listener);
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00013B76 File Offset: 0x00011D76
		void global::Infragistics.ITypedSupportPropertyChangeNotifications<object, string>.AddListener(global::Infragistics.ITypedPropertyChangeListener<object, string> listener, bool useWeakReference)
		{
			this.AddListener(listener, useWeakReference);
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00013B80 File Offset: 0x00011D80
		void global::Infragistics.ITypedSupportPropertyChangeNotifications<object, string>.RemoveListener(global::Infragistics.ITypedPropertyChangeListener<object, string> listener)
		{
			this.RemoveListener(listener);
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00013B89 File Offset: 0x00011D89
		void global::Infragistics.ITypedPropertyChangeListener<object, string>.OnPropertyValueChanged(object sender, string property, object extraInfo)
		{
			this.NotifyListeners(sender, property, extraInfo);
		}

		// Token: 0x040001C5 RID: 453
		private object _listeners;
	}
}
