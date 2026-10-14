using System;
using Infragistics.Controls.Layouts.Primitives;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000168 RID: 360
	internal interface IWrapperLayoutItem
	{
		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06001509 RID: 5385
		global::Infragistics.Controls.Layouts.Primitives.ILayoutItem InnerLayoutItem { get; }

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x0600150A RID: 5386
		// (set) Token: 0x0600150B RID: 5387
		double? ExplicitWidth { get; set; }

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x0600150C RID: 5388
		// (set) Token: 0x0600150D RID: 5389
		double? ExplicitHeight { get; set; }
	}
}
