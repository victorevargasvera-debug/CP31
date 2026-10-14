using System;
using System.Collections.Specialized;

namespace Infragistics
{
	// Token: 0x020000AE RID: 174
	internal class WeakCollectionChangedHandler<TInstance> : global::Infragistics.WeakEventHandler<TInstance, global::System.Collections.Specialized.INotifyCollectionChanged, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs> where TInstance : class
	{
		// Token: 0x0600069D RID: 1693 RVA: 0x00018F5B File Offset: 0x0001715B
		public WeakCollectionChangedHandler(TInstance instance, global::System.Collections.Specialized.INotifyCollectionChanged eventSource, global::System.Action<TInstance, object, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs> onEventAction) : base(instance, eventSource, onEventAction, delegate(global::Infragistics.WeakEventHandler<TInstance, global::System.Collections.Specialized.INotifyCollectionChanged, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs> weakHandler, global::System.Collections.Specialized.INotifyCollectionChanged evSource)
		{
			evSource.CollectionChanged -= weakHandler.OnEvent;
		})
		{
		}
	}
}
