using System;
using System.Windows.Interactivity;

namespace Microsoft.Practices.Prism.Interactivity.InteractionRequest
{
	// Token: 0x02000007 RID: 7
	public class InteractionRequestTrigger : global::System.Windows.Interactivity.EventTrigger
	{
		// Token: 0x06000016 RID: 22 RVA: 0x00002259 File Offset: 0x00000459
		protected override string GetEventName()
		{
			return "Raised";
		}
	}
}
