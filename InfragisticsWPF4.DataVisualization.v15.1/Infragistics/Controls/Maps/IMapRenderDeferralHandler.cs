using System;
using System.ComponentModel;
using System.Windows;

namespace Infragistics.Controls.Maps
{
	// Token: 0x020000EC RID: 236
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	public interface IMapRenderDeferralHandler
	{
		// Token: 0x060009C8 RID: 2504
		void Register(global::System.Windows.DependencyObject source, global::System.Action<bool> refresh);

		// Token: 0x060009C9 RID: 2505
		void UnRegister(global::System.Windows.DependencyObject source);

		// Token: 0x060009CA RID: 2506
		void DeferredRefresh();
	}
}
