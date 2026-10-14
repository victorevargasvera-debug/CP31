using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

namespace DevComponents.WpfRibbon
{
	// Token: 0x02000056 RID: 86
	internal class KeyTipRenderInfo
	{
		// Token: 0x040001DD RID: 477
		public global::DevComponents.WpfRibbon.KeyTipColors EnabledColors;

		// Token: 0x040001DE RID: 478
		public global::DevComponents.WpfRibbon.KeyTipColors DisabledColors;

		// Token: 0x040001DF RID: 479
		public global::System.Windows.Media.Typeface Typeface;

		// Token: 0x040001E0 RID: 480
		public double FontSize;

		// Token: 0x040001E1 RID: 481
		public string KeyTipsStack = "";

		// Token: 0x040001E2 RID: 482
		public global::DevComponents.WpfRibbon.KeyTipsAdorner Adorner;

		// Token: 0x040001E3 RID: 483
		public bool UseSpecKeyTipPositioning;

		// Token: 0x040001E4 RID: 484
		public global::System.Collections.Generic.List<global::System.Windows.UIElement> ActiveKeyTipsElements;

		// Token: 0x040001E5 RID: 485
		public bool RibbonMenuMode;
	}
}
