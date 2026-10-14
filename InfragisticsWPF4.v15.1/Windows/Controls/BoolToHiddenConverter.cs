using System;

namespace Infragistics.Windows.Controls
{
	// Token: 0x0200010C RID: 268
	public class BoolToHiddenConverter : global::Infragistics.Windows.Controls.BoolConverter
	{
		// Token: 0x06000967 RID: 2407 RVA: 0x00020346 File Offset: 0x0001E546
		public BoolToHiddenConverter()
		{
			this.trueValue = global::Infragistics.KnownBoxes.VisibilityVisibleBox;
			this.falseValue = global::Infragistics.KnownBoxes.VisibilityHiddenBox;
		}
	}
}
