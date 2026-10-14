using System;
using System.Windows;

namespace Infragistics
{
	// Token: 0x020000B6 RID: 182
	public interface ISmartPlaceable
	{
		// Token: 0x060007DE RID: 2014
		global::Infragistics.SmartPosition[] GetSmartPositions();

		// Token: 0x060007DF RID: 2015
		global::System.Windows.Rect GetSmartBounds(global::Infragistics.SmartPosition position);

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060007E0 RID: 2016
		// (set) Token: 0x060007E1 RID: 2017
		global::Infragistics.SmartPosition SmartPosition { get; set; }

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060007E2 RID: 2018
		// (set) Token: 0x060007E3 RID: 2019
		double Opacity { get; set; }
	}
}
