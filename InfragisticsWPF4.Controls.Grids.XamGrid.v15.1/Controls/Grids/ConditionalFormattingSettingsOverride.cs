using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000029 RID: 41
	public class ConditionalFormattingSettingsOverride : global::Infragistics.Controls.Grids.SettingsOverrideBase
	{
		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x0000AB24 File Offset: 0x00008D24
		protected override global::Infragistics.Controls.Grids.SettingsBase SettingsObject
		{
			get
			{
				global::Infragistics.Controls.Grids.SettingsBase result = null;
				if (base.ColumnLayout != null && base.ColumnLayout.Grid != null)
				{
					result = base.ColumnLayout.Grid.FilteringSettings;
				}
				return result;
			}
		}
	}
}
