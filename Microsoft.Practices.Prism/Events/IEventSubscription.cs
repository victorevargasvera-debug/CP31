using System;

namespace Microsoft.Practices.Prism.Events
{
	// Token: 0x0200000D RID: 13
	public interface IEventSubscription
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000059 RID: 89
		// (set) Token: 0x0600005A RID: 90
		global::Microsoft.Practices.Prism.Events.SubscriptionToken SubscriptionToken { get; set; }

		// Token: 0x0600005B RID: 91
		global::System.Action<object[]> GetExecutionStrategy();
	}
}
