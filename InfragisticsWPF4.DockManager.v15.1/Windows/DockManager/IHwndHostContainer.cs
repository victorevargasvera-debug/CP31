using System;
using System.Collections.Generic;
using System.Windows.Interop;

namespace Infragistics.Windows.DockManager
{
	// Token: 0x02000074 RID: 116
	internal interface IHwndHostContainer
	{
		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060003FD RID: 1021
		bool HasHwndHost { get; }

		// Token: 0x060003FE RID: 1022
		global::System.Collections.Generic.IEnumerable<global::System.Windows.Interop.HwndHost> GetHosts();
	}
}
