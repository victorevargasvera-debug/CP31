using System;
using System.Windows;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200020B RID: 523
	public class FixedBorderFooterCellControl : global::Infragistics.Controls.Grids.Primitives.FooterCellControl
	{
		// Token: 0x06000EE9 RID: 3817 RVA: 0x000389FC File Offset: 0x00036BFC
		static FixedBorderFooterCellControl()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.FixedBorderFooterCellControl), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.FixedBorderFooterCellControl)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.FixedBorderFooterCellControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
		}

		// Token: 0x06000EEA RID: 3818 RVA: 0x00038A4A File Offset: 0x00036C4A
		public FixedBorderFooterCellControl()
		{
			base.DefaultStyleKey = typeof(global::Infragistics.Controls.Grids.Primitives.FixedBorderFooterCellControl);
			base.IsTabStop = false;
		}
	}
}
