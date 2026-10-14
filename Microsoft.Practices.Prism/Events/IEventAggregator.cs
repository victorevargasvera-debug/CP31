using System;

namespace Microsoft.Practices.Prism.Events
{
	// Token: 0x02000018 RID: 24
	public interface IEventAggregator
	{
		// Token: 0x06000082 RID: 130
		TEventType GetEvent<TEventType>() where TEventType : global::Microsoft.Practices.Prism.Events.EventBase, new();
	}
}
