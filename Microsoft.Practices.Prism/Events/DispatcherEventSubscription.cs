using System;

namespace Microsoft.Practices.Prism.Events
{
	// Token: 0x02000017 RID: 23
	public class DispatcherEventSubscription<TPayload> : global::Microsoft.Practices.Prism.Events.EventSubscription<TPayload>
	{
		// Token: 0x06000080 RID: 128 RVA: 0x00003544 File Offset: 0x00001744
		public DispatcherEventSubscription(global::Microsoft.Practices.Prism.Events.IDelegateReference actionReference, global::Microsoft.Practices.Prism.Events.IDelegateReference filterReference, global::Microsoft.Practices.Prism.Events.IDispatcherFacade dispatcher) : base(actionReference, filterReference)
		{
			this.dispatcher = dispatcher;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00003555 File Offset: 0x00001755
		public override void InvokeAction(global::System.Action<TPayload> action, TPayload argument)
		{
			this.dispatcher.BeginInvoke(action, argument);
		}

		// Token: 0x04000022 RID: 34
		private readonly global::Microsoft.Practices.Prism.Events.IDispatcherFacade dispatcher;
	}
}
