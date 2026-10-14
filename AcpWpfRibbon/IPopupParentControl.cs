using System;
using System.Windows;

namespace DevComponents.WpfRibbon
{
	// Token: 0x0200000E RID: 14
	internal interface IPopupParentControl
	{
		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060001C0 RID: 448
		// (set) Token: 0x060001C1 RID: 449
		bool IsPopupMode { get; set; }

		// Token: 0x060001C2 RID: 450
		bool QueryMouseCapturePopupClose(global::System.Windows.DependencyObject sourceObject);
	}
}
