using System;

namespace Infragistics
{
	// Token: 0x02000005 RID: 5
	internal interface ITypedSupportPropertyChangeNotifications<TItem, TProperty>
	{
		// Token: 0x06000017 RID: 23
		void AddListener(global::Infragistics.ITypedPropertyChangeListener<TItem, TProperty> listener, bool useWeakReference);

		// Token: 0x06000018 RID: 24
		void RemoveListener(global::Infragistics.ITypedPropertyChangeListener<TItem, TProperty> listener);
	}
}
