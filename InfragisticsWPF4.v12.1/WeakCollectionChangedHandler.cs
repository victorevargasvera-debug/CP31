using System;
using System.Collections.Specialized;

namespace Infragistics
{
	// Token: 0x02000095 RID: 149
	internal class WeakCollectionChangedHandler<TInstance> : global::Infragistics.WeakEventHandler<TInstance, global::System.Collections.Specialized.INotifyCollectionChanged, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs> where TInstance : class
	{
		// Token: 0x060005BE RID: 1470 RVA: 0x000158B7 File Offset: 0x00013AB7
		public WeakCollectionChangedHandler(TInstance instance, global::System.Collections.Specialized.INotifyCollectionChanged eventSource, global::System.Action<TInstance, object, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs> onEventAction) : base(instance, eventSource, onEventAction, delegate(global::Infragistics.WeakEventHandler<TInstance, global::System.Collections.Specialized.INotifyCollectionChanged, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs> weakHandler, global::System.Collections.Specialized.INotifyCollectionChanged evSource)
		{
			evSource.CollectionChanged -= weakHandler.OnEvent;
		})
		{
		}
	}
}
