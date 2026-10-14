using System;
using System.Threading;

namespace Microsoft.Practices.Prism.Events
{
	// Token: 0x0200000F RID: 15
	public class BackgroundEventSubscription<TPayload> : global::Microsoft.Practices.Prism.Events.EventSubscription<TPayload>
	{
		// Token: 0x06000063 RID: 99 RVA: 0x00002F2E File Offset: 0x0000112E
		public BackgroundEventSubscription(global::Microsoft.Practices.Prism.Events.IDelegateReference actionReference, global::Microsoft.Practices.Prism.Events.IDelegateReference filterReference) : base(actionReference, filterReference)
		{
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002F54 File Offset: 0x00001154
		public override void InvokeAction(global::System.Action<TPayload> action, TPayload argument)
		{
			global::System.Threading.ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				action(argument);
			});
		}
	}
}
