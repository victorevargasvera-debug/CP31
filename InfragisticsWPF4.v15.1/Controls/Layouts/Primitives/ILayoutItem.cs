using System;
using System.Windows;

namespace Infragistics.Controls.Layouts.Primitives
{
	// Token: 0x0200005F RID: 95
	public interface ILayoutItem
	{
		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060003E0 RID: 992
		global::System.Windows.Visibility Visibility { get; }

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060003E1 RID: 993
		global::System.Windows.Size MaximumSize { get; }

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060003E2 RID: 994
		global::System.Windows.Size MinimumSize { get; }

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060003E3 RID: 995
		global::System.Windows.Size PreferredSize { get; }
	}
}
