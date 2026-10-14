using System;
using System.Windows;

namespace Infragistics.Controls.Layouts.Primitives
{
	// Token: 0x0200004B RID: 75
	public interface ILayoutItem
	{
		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600034C RID: 844
		global::System.Windows.Visibility Visibility { get; }

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600034D RID: 845
		global::System.Windows.Size MaximumSize { get; }

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600034E RID: 846
		global::System.Windows.Size MinimumSize { get; }

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600034F RID: 847
		global::System.Windows.Size PreferredSize { get; }
	}
}
