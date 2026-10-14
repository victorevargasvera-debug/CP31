using System;
using System.Windows;

namespace Infragistics.Windows.Tiles
{
	// Token: 0x020001D7 RID: 471
	public interface ITileConstraints
	{
		// Token: 0x17000343 RID: 835
		// (get) Token: 0x0600103A RID: 4154
		global::System.Windows.HorizontalAlignment? HorizontalAlignment { get; }

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x0600103B RID: 4155
		global::System.Windows.Thickness? Margin { get; }

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x0600103C RID: 4156
		double MaxHeight { get; }

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x0600103D RID: 4157
		double MaxWidth { get; }

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x0600103E RID: 4158
		double MinHeight { get; }

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x0600103F RID: 4159
		double MinWidth { get; }

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06001040 RID: 4160
		double PreferredHeight { get; }

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06001041 RID: 4161
		double PreferredWidth { get; }

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06001042 RID: 4162
		global::System.Windows.VerticalAlignment? VerticalAlignment { get; }
	}
}
