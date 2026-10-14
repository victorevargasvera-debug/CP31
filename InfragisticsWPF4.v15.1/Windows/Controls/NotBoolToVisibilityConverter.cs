using System;

namespace Infragistics.Windows.Controls
{
	// Token: 0x0200010D RID: 269
	public class NotBoolToVisibilityConverter : global::Infragistics.Windows.Controls.BoolConverter
	{
		// Token: 0x06000968 RID: 2408 RVA: 0x00020364 File Offset: 0x0001E564
		public NotBoolToVisibilityConverter()
		{
			this.trueValue = global::Infragistics.KnownBoxes.VisibilityCollapsedBox;
			this.falseValue = global::Infragistics.KnownBoxes.VisibilityVisibleBox;
		}
	}
}
