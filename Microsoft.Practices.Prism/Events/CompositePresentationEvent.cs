using System;
using System.Linq;

namespace Microsoft.Practices.Prism.Events
{
	// Token: 0x02000011 RID: 17
	public class CompositePresentationEvent<TPayload> : global::Microsoft.Practices.Prism.Events.EventBase
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00003213 File Offset: 0x00001413
		private global::Microsoft.Practices.Prism.Events.IDispatcherFacade UIDispatcher
		{
			get
			{
				if (this.uiDispatcher == null)
				{
					this.uiDispatcher = new global::Microsoft.Practices.Prism.Events.DefaultDispatcher();
				}
				return this.uiDispatcher;
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000322E File Offset: 0x0000142E
		public global::Microsoft.Practices.Prism.Events.SubscriptionToken Subscribe(global::System.Action<TPayload> action)
		{
			return this.Subscribe(action, global::Microsoft.Practices.Prism.Events.ThreadOption.PublisherThread);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00003238 File Offset: 0x00001438
		public global::Microsoft.Practices.Prism.Events.SubscriptionToken Subscribe(global::System.Action<TPayload> action, global::Microsoft.Practices.Prism.Events.ThreadOption threadOption)
		{
			return this.Subscribe(action, threadOption, false);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00003243 File Offset: 0x00001443
		public global::Microsoft.Practices.Prism.Events.SubscriptionToken Subscribe(global::System.Action<TPayload> action, bool keepSubscriberReferenceAlive)
		{
			return this.Subscribe(action, global::Microsoft.Practices.Prism.Events.ThreadOption.PublisherThread, keepSubscriberReferenceAlive);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000324E File Offset: 0x0000144E
		public global::Microsoft.Practices.Prism.Events.SubscriptionToken Subscribe(global::System.Action<TPayload> action, global::Microsoft.Practices.Prism.Events.ThreadOption threadOption, bool keepSubscriberReferenceAlive)
		{
			return this.Subscribe(action, threadOption, keepSubscriberReferenceAlive, null);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00003260 File Offset: 0x00001460
		public virtual global::Microsoft.Practices.Prism.Events.SubscriptionToken Subscribe(global::System.Action<TPayload> action, global::Microsoft.Practices.Prism.Events.ThreadOption threadOption, bool keepSubscriberReferenceAlive, global::System.Predicate<TPayload> filter)
		{
			global::Microsoft.Practices.Prism.Events.IDelegateReference actionReference = new global::Microsoft.Practices.Prism.Events.DelegateReference(action, keepSubscriberReferenceAlive);
			global::Microsoft.Practices.Prism.Events.IDelegateReference filterReference;
			if (filter != null)
			{
				filterReference = new global::Microsoft.Practices.Prism.Events.DelegateReference(filter, keepSubscriberReferenceAlive);
			}
			else
			{
				filterReference = new global::Microsoft.Practices.Prism.Events.DelegateReference(new global::System.Predicate<TPayload>((TPayload A_0) => true), true);
			}
			global::Microsoft.Practices.Prism.Events.EventSubscription<TPayload> eventSubscription;
			switch (threadOption)
			{
			case global::Microsoft.Practices.Prism.Events.ThreadOption.PublisherThread:
				eventSubscription = new global::Microsoft.Practices.Prism.Events.EventSubscription<TPayload>(actionReference, filterReference);
				break;
			case global::Microsoft.Practices.Prism.Events.ThreadOption.UIThread:
				eventSubscription = new global::Microsoft.Practices.Prism.Events.DispatcherEventSubscription<TPayload>(actionReference, filterReference, this.UIDispatcher);
				break;
			case global::Microsoft.Practices.Prism.Events.ThreadOption.BackgroundThread:
				eventSubscription = new global::Microsoft.Practices.Prism.Events.BackgroundEventSubscription<TPayload>(actionReference, filterReference);
				break;
			default:
				eventSubscription = new global::Microsoft.Practices.Prism.Events.EventSubscription<TPayload>(actionReference, filterReference);
				break;
			}
			return base.InternalSubscribe(eventSubscription);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000032F4 File Offset: 0x000014F4
		public virtual void Publish(TPayload payload)
		{
			base.InternalPublish(new object[]
			{
				payload
			});
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00003334 File Offset: 0x00001534
		public virtual void Unsubscribe(global::System.Action<TPayload> subscriber)
		{
			lock (base.Subscriptions)
			{
				global::Microsoft.Practices.Prism.Events.IEventSubscription eventSubscription = base.Subscriptions.Cast<global::Microsoft.Practices.Prism.Events.EventSubscription<TPayload>>().FirstOrDefault((global::Microsoft.Practices.Prism.Events.EventSubscription<TPayload> evt) => evt.Action == subscriber);
				if (eventSubscription != null)
				{
					base.Subscriptions.Remove(eventSubscription);
				}
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000033D0 File Offset: 0x000015D0
		public virtual bool Contains(global::System.Action<TPayload> subscriber)
		{
			global::Microsoft.Practices.Prism.Events.IEventSubscription eventSubscription;
			lock (base.Subscriptions)
			{
				eventSubscription = base.Subscriptions.Cast<global::Microsoft.Practices.Prism.Events.EventSubscription<TPayload>>().FirstOrDefault((global::Microsoft.Practices.Prism.Events.EventSubscription<TPayload> evt) => evt.Action == subscriber);
			}
			return eventSubscription != null;
		}

		// Token: 0x0400001B RID: 27
		private global::Microsoft.Practices.Prism.Events.IDispatcherFacade uiDispatcher;
	}
}
