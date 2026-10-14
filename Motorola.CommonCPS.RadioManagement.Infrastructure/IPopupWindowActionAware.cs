using System;
using System.Windows;
using Microsoft.Practices.Prism.Interactivity.InteractionRequest;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x02000027 RID: 39
	public interface IPopupWindowActionAware
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600007D RID: 125
		// (set) Token: 0x0600007E RID: 126
		global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.Notification Notification { get; set; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600007F RID: 127
		// (set) Token: 0x06000080 RID: 128
		global::System.Windows.Window Window { get; set; }
	}
}
