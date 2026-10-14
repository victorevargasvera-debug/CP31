using System;
using System.Collections.Generic;
using System.Linq;

namespace Microsoft.Practices.Prism.Events
{
	// Token: 0x02000010 RID: 16
	public abstract class EventBase
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00002F87 File Offset: 0x00001187
		protected global::System.Collections.Generic.ICollection<global::Microsoft.Practices.Prism.Events.IEventSubscription> Subscriptions
		{
			get
			{
				return this._subscriptions;
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002F90 File Offset: 0x00001190
		protected virtual global::Microsoft.Practices.Prism.Events.SubscriptionToken InternalSubscribe(global::Microsoft.Practices.Prism.Events.IEventSubscription eventSubscription)
		{
			if (eventSubscription == null)
			{
				throw new global::System.ArgumentNullException("eventSubscription");
			}
			eventSubscription.SubscriptionToken = new global::Microsoft.Practices.Prism.Events.SubscriptionToken(new global::System.Action<global::Microsoft.Practices.Prism.Events.SubscriptionToken>(this.Unsubscribe));
			lock (this.Subscriptions)
			{
				this.Subscriptions.Add(eventSubscription);
			}
			return eventSubscription.SubscriptionToken;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00003004 File Offset: 0x00001204
		protected virtual void InternalPublish(params object[] arguments)
		{
			global::System.Collections.Generic.List<global::System.Action<object[]>> list = this.PruneAndReturnStrategies();
			foreach (global::System.Action<object[]> action in list)
			{
				action(arguments);
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00003074 File Offset: 0x00001274
		public virtual void Unsubscribe(global::Microsoft.Practices.Prism.Events.SubscriptionToken token)
		{
			lock (this.Subscriptions)
			{
				global::Microsoft.Practices.Prism.Events.IEventSubscription eventSubscription = this.Subscriptions.FirstOrDefault((global::Microsoft.Practices.Prism.Events.IEventSubscription evt) => evt.SubscriptionToken == token);
				if (eventSubscription != null)
				{
					this.Subscriptions.Remove(eventSubscription);
				}
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00003104 File Offset: 0x00001304
		public virtual bool Contains(global::Microsoft.Practices.Prism.Events.SubscriptionToken token)
		{
			bool result;
			lock (this.Subscriptions)
			{
				global::Microsoft.Practices.Prism.Events.IEventSubscription eventSubscription = this.Subscriptions.FirstOrDefault((global::Microsoft.Practices.Prism.Events.IEventSubscription evt) => evt.SubscriptionToken == token);
				result = (eventSubscription != null);
			}
			return result;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00003178 File Offset: 0x00001378
		private global::System.Collections.Generic.List<global::System.Action<object[]>> PruneAndReturnStrategies()
		{
			global::System.Collections.Generic.List<global::System.Action<object[]>> list = new global::System.Collections.Generic.List<global::System.Action<object[]>>();
			lock (this.Subscriptions)
			{
				for (int i = this.Subscriptions.Count - 1; i >= 0; i--)
				{
					global::System.Action<object[]> executionStrategy = this._subscriptions[i].GetExecutionStrategy();
					if (executionStrategy == null)
					{
						this._subscriptions.RemoveAt(i);
					}
					else
					{
						list.Add(executionStrategy);
					}
				}
			}
			return list;
		}

		// Token: 0x0400001A RID: 26
		private readonly global::System.Collections.Generic.List<global::Microsoft.Practices.Prism.Events.IEventSubscription> _subscriptions = new global::System.Collections.Generic.List<global::Microsoft.Practices.Prism.Events.IEventSubscription>();
	}
}
