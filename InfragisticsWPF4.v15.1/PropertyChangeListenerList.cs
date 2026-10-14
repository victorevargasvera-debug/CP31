using System;
using System.Collections.Specialized;

namespace Infragistics
{
	// Token: 0x0200006B RID: 107
	internal class PropertyChangeListenerList : global::Infragistics.TypedPropertyChangeListenerList<object, string>, global::Infragistics.IPropertyChangeListener, global::Infragistics.ITypedPropertyChangeListener<object, string>
	{
		// Token: 0x06000406 RID: 1030 RVA: 0x000114C1 File Offset: 0x0000F6C1
		internal static void ManageListenerHelper<T>(ref T val, T newVal, global::Infragistics.IPropertyChangeListener listener, bool useWeakReference) where T : global::Infragistics.ISupportPropertyChangeNotifications
		{
			if (val != null)
			{
				val.RemoveListener(listener);
			}
			val = newVal;
			if (val != null)
			{
				val.AddListener(listener, useWeakReference);
			}
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00011500 File Offset: 0x0000F700
		internal static void ManageListenerHelperObj<T>(ref T val, T newVal, global::Infragistics.IPropertyChangeListener listener, bool useWeakReference)
		{
			global::Infragistics.ISupportPropertyChangeNotifications supportPropertyChangeNotifications = val as global::Infragistics.ISupportPropertyChangeNotifications;
			if (supportPropertyChangeNotifications != null)
			{
				supportPropertyChangeNotifications.RemoveListener(listener);
			}
			val = newVal;
			supportPropertyChangeNotifications = (newVal as global::Infragistics.ISupportPropertyChangeNotifications);
			if (supportPropertyChangeNotifications != null)
			{
				supportPropertyChangeNotifications.AddListener(listener, useWeakReference);
			}
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00011546 File Offset: 0x0000F746
		internal void OnCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this.OnPropertyValueChanged(sender, e.Action.ToString(), e);
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00011560 File Offset: 0x0000F760
		internal static void RaisePropertyChanged(object listeners, object sender, string property, object extraInfo)
		{
			global::Infragistics.ListenerList.RaisePropertyChanged<object, string>(listeners, sender, property, extraInfo);
		}
	}
}
