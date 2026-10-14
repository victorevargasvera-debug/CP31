using System;

namespace Microsoft.Practices.Prism.Interactivity.InteractionRequest
{
	// Token: 0x02000004 RID: 4
	public interface IInteractionRequest
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000009 RID: 9
		// (remove) Token: 0x0600000A RID: 10
		event global::System.EventHandler<global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequestedEventArgs> Raised;
	}
}
