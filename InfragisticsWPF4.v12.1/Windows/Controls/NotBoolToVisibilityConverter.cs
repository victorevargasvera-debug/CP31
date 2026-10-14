using System;

namespace Infragistics.Windows.Controls
{
	// Token: 0x020000EF RID: 239
	public class NotBoolToVisibilityConverter : global::Infragistics.Windows.Controls.BoolConverter
	{
		// Token: 0x06000869 RID: 2153 RVA: 0x0001C79C File Offset: 0x0001A99C
		public NotBoolToVisibilityConverter()
		{
			this.trueValue = global::Infragistics.KnownBoxes.VisibilityCollapsedBox;
			this.falseValue = global::Infragistics.KnownBoxes.VisibilityVisibleBox;
		}
	}
}
