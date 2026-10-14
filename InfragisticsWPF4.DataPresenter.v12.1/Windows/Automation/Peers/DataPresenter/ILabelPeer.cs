using System;
using Infragistics.Windows.DataPresenter;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x02000020 RID: 32
	internal interface ILabelPeer
	{
		// Token: 0x060000E2 RID: 226
		bool IsEnabled();

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000E3 RID: 227
		global::Infragistics.Windows.DataPresenter.Field Field { get; }

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000E4 RID: 228
		global::Infragistics.Windows.DataPresenter.LabelPresenter Label { get; }
	}
}
