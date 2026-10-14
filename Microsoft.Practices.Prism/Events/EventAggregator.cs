using System;
using System.Collections.Generic;

namespace Microsoft.Practices.Prism.Events
{
	// Token: 0x02000019 RID: 25
	public class EventAggregator : global::Microsoft.Practices.Prism.Events.IEventAggregator
	{
		// Token: 0x06000083 RID: 131 RVA: 0x0000356C File Offset: 0x0000176C
		public TEventType GetEvent<TEventType>() where TEventType : global::Microsoft.Practices.Prism.Events.EventBase, new()
		{
			global::Microsoft.Practices.Prism.Events.EventBase eventBase = null;
			if (!this.events.TryGetValue(typeof(TEventType), out eventBase))
			{
				TEventType teventType = global::System.Activator.CreateInstance<TEventType>();
				this.events[typeof(TEventType)] = teventType;
				return teventType;
			}
			return (TEventType)((object)eventBase);
		}

		// Token: 0x04000023 RID: 35
		private readonly global::System.Collections.Generic.Dictionary<global::System.Type, global::Microsoft.Practices.Prism.Events.EventBase> events = new global::System.Collections.Generic.Dictionary<global::System.Type, global::Microsoft.Practices.Prism.Events.EventBase>();
	}
}
