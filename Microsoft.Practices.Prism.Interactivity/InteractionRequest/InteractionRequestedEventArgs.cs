using System;

namespace Microsoft.Practices.Prism.Interactivity.InteractionRequest
{
	// Token: 0x02000006 RID: 6
	public class InteractionRequestedEventArgs : global::System.EventArgs
	{
		// Token: 0x06000011 RID: 17 RVA: 0x00002221 File Offset: 0x00000421
		public InteractionRequestedEventArgs(global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.Notification context, global::System.Action callback)
		{
			this.Context = context;
			this.Callback = callback;
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00002237 File Offset: 0x00000437
		// (set) Token: 0x06000013 RID: 19 RVA: 0x0000223F File Offset: 0x0000043F
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.Notification Context { get; private set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002248 File Offset: 0x00000448
		// (set) Token: 0x06000015 RID: 21 RVA: 0x00002250 File Offset: 0x00000450
		public global::System.Action Callback { get; private set; }
	}
}
