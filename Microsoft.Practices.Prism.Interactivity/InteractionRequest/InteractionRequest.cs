using System;

namespace Microsoft.Practices.Prism.Interactivity.InteractionRequest
{
	// Token: 0x02000005 RID: 5
	public class InteractionRequest<T> : global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.IInteractionRequest where T : global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.Notification
	{
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600000B RID: 11 RVA: 0x00002114 File Offset: 0x00000314
		// (remove) Token: 0x0600000C RID: 12 RVA: 0x0000214C File Offset: 0x0000034C
		public event global::System.EventHandler<global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequestedEventArgs> Raised;

		// Token: 0x0600000D RID: 13 RVA: 0x00002183 File Offset: 0x00000383
		public void Raise(T context)
		{
			this.Raise(context, delegate(T c)
			{
			});
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000021C4 File Offset: 0x000003C4
		public void Raise(T context, global::System.Action<T> callback)
		{
			global::System.EventHandler<global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequestedEventArgs> raised = this.Raised;
			if (raised != null)
			{
				raised(this, new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequestedEventArgs(context, delegate()
				{
					callback(context);
				}));
			}
		}
	}
}
