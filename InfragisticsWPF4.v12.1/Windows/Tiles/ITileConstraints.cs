using System;
using System.Windows;

namespace Infragistics.Windows.Tiles
{
	// Token: 0x020001AA RID: 426
	public interface ITileConstraints
	{
		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000E7A RID: 3706
		global::System.Windows.HorizontalAlignment? HorizontalAlignment { get; }

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000E7B RID: 3707
		global::System.Windows.Thickness? Margin { get; }

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000E7C RID: 3708
		double MaxHeight { get; }

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000E7D RID: 3709
		double MaxWidth { get; }

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000E7E RID: 3710
		double MinHeight { get; }

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000E7F RID: 3711
		double MinWidth { get; }

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000E80 RID: 3712
		double PreferredHeight { get; }

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000E81 RID: 3713
		double PreferredWidth { get; }

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000E82 RID: 3714
		global::System.Windows.VerticalAlignment? VerticalAlignment { get; }
	}
}
