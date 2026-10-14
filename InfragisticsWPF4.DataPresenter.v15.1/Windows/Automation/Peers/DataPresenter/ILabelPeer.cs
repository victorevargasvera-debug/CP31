using System;
using Infragistics.Windows.DataPresenter;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x02000020 RID: 32
	internal interface ILabelPeer
	{
		// Token: 0x060000ED RID: 237
		bool IsEnabled();

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000EE RID: 238
		global::Infragistics.Windows.DataPresenter.Field Field { get; }

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000EF RID: 239
		global::Infragistics.Windows.DataPresenter.LabelPresenter Label { get; }
	}
}
