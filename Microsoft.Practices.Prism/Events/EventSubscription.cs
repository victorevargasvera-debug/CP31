using System;
using System.Globalization;
using Microsoft.Practices.Prism.Properties;

namespace Microsoft.Practices.Prism.Events
{
	// Token: 0x0200000E RID: 14
	public class EventSubscription<TPayload> : global::Microsoft.Practices.Prism.Events.IEventSubscription
	{
		// Token: 0x0600005C RID: 92 RVA: 0x00002D78 File Offset: 0x00000F78
		public EventSubscription(global::Microsoft.Practices.Prism.Events.IDelegateReference actionReference, global::Microsoft.Practices.Prism.Events.IDelegateReference filterReference)
		{
			if (actionReference == null)
			{
				throw new global::System.ArgumentNullException("actionReference");
			}
			if (!(actionReference.Target is global::System.Action<TPayload>))
			{
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Microsoft.Practices.Prism.Properties.Resources.InvalidDelegateRerefenceTypeException, new object[]
				{
					typeof(global::System.Action<TPayload>).FullName
				}), "actionReference");
			}
			if (filterReference == null)
			{
				throw new global::System.ArgumentNullException("filterReference");
			}
			if (!(filterReference.Target is global::System.Predicate<TPayload>))
			{
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Microsoft.Practices.Prism.Properties.Resources.InvalidDelegateRerefenceTypeException, new object[]
				{
					typeof(global::System.Predicate<TPayload>).FullName
				}), "filterReference");
			}
			this._actionReference = actionReference;
			this._filterReference = filterReference;
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00002E37 File Offset: 0x00001037
		public global::System.Action<TPayload> Action
		{
			get
			{
				return (global::System.Action<TPayload>)this._actionReference.Target;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00002E49 File Offset: 0x00001049
		public global::System.Predicate<TPayload> Filter
		{
			get
			{
				return (global::System.Predicate<TPayload>)this._filterReference.Target;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00002E5B File Offset: 0x0000105B
		// (set) Token: 0x06000060 RID: 96 RVA: 0x00002E63 File Offset: 0x00001063
		public global::Microsoft.Practices.Prism.Events.SubscriptionToken SubscriptionToken { get; set; }

		// Token: 0x06000061 RID: 97 RVA: 0x00002EC0 File Offset: 0x000010C0
		public virtual global::System.Action<object[]> GetExecutionStrategy()
		{
			global::System.Action<TPayload> action = this.Action;
			global::System.Predicate<TPayload> filter = this.Filter;
			if (action != null && filter != null)
			{
				return delegate(object[] arguments)
				{
					TPayload tpayload = default(TPayload);
					if (arguments != null && arguments.Length > 0 && arguments[0] != null)
					{
						tpayload = (TPayload)((object)arguments[0]);
					}
					if (filter(tpayload))
					{
						this.InvokeAction(action, tpayload);
					}
				};
			}
			return null;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002F17 File Offset: 0x00001117
		public virtual void InvokeAction(global::System.Action<TPayload> action, TPayload argument)
		{
			if (action == null)
			{
				throw new global::System.ArgumentNullException("action");
			}
			action(argument);
		}

		// Token: 0x04000017 RID: 23
		private readonly global::Microsoft.Practices.Prism.Events.IDelegateReference _actionReference;

		// Token: 0x04000018 RID: 24
		private readonly global::Microsoft.Practices.Prism.Events.IDelegateReference _filterReference;
	}
}
