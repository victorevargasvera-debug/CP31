using System;

namespace Infragistics.Windows.Controls
{
	// Token: 0x020000EE RID: 238
	public class BoolToHiddenConverter : global::Infragistics.Windows.Controls.BoolConverter
	{
		// Token: 0x06000868 RID: 2152 RVA: 0x0001C77E File Offset: 0x0001A97E
		public BoolToHiddenConverter()
		{
			this.trueValue = global::Infragistics.KnownBoxes.VisibilityVisibleBox;
			this.falseValue = global::Infragistics.KnownBoxes.VisibilityHiddenBox;
		}
	}
}
