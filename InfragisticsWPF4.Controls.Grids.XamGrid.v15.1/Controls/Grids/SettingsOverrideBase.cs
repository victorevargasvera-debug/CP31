using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200000D RID: 13
	public abstract class SettingsOverrideBase : global::Infragistics.DependencyObjectNotifier
	{
		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x000078FC File Offset: 0x00005AFC
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x00007904 File Offset: 0x00005B04
		protected internal global::Infragistics.Controls.Grids.ColumnLayout ColumnLayout { get; set; }

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000C7 RID: 199
		protected abstract global::Infragistics.Controls.Grids.SettingsBase SettingsObject { get; }
	}
}
