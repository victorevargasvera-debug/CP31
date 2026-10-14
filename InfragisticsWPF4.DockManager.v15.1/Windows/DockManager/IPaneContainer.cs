using System;
using System.Collections;

namespace Infragistics.Windows.DockManager
{
	// Token: 0x02000030 RID: 48
	internal interface IPaneContainer
	{
		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600028A RID: 650
		global::System.Collections.IList Panes { get; }

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600028B RID: 651
		bool CanBeRemoved { get; }

		// Token: 0x0600028C RID: 652
		bool RemovePane(object pane);
	}
}
