using System;
using System.Collections.Specialized;

namespace Infragistics
{
	// Token: 0x02000057 RID: 87
	internal class PropertyChangeListenerList : global::Infragistics.TypedPropertyChangeListenerList<object, string>, global::Infragistics.IPropertyChangeListener, global::Infragistics.ITypedPropertyChangeListener<object, string>
	{
		// Token: 0x06000372 RID: 882 RVA: 0x0000F865 File Offset: 0x0000DA65
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

		// Token: 0x06000373 RID: 883 RVA: 0x0000F8A4 File Offset: 0x0000DAA4
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

		// Token: 0x06000374 RID: 884 RVA: 0x0000F8EA File Offset: 0x0000DAEA
		internal void OnCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this.OnPropertyValueChanged(sender, e.Action.ToString(), e);
		}
	}
}
