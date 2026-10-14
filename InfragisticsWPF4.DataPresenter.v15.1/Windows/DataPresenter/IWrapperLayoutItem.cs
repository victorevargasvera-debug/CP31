using System;
using Infragistics.Controls.Layouts.Primitives;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000184 RID: 388
	internal interface IWrapperLayoutItem
	{
		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06001881 RID: 6273
		global::Infragistics.Controls.Layouts.Primitives.ILayoutItem InnerLayoutItem { get; }

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06001882 RID: 6274
		// (set) Token: 0x06001883 RID: 6275
		double? ExplicitWidth { get; set; }

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06001884 RID: 6276
		// (set) Token: 0x06001885 RID: 6277
		double? ExplicitHeight { get; set; }
	}
}
