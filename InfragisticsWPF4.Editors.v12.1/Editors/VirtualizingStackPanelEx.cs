using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Infragistics.Windows.Editors
{
	// Token: 0x0200001D RID: 29
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class VirtualizingStackPanelEx : global::System.Windows.Controls.VirtualizingStackPanel
	{
		// Token: 0x060000F6 RID: 246 RVA: 0x00004F6C File Offset: 0x0000316C
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			double value = (base.ScrollOwner == null) ? 0.0 : ((base.Orientation == global::System.Windows.Controls.Orientation.Vertical) ? base.ViewportHeight : base.ViewportWidth);
			global::System.Windows.Size result = base.MeasureOverride(availableSize);
			double value2 = (base.ScrollOwner == null) ? 0.0 : ((base.Orientation == global::System.Windows.Controls.Orientation.Vertical) ? base.ViewportHeight : base.ViewportWidth);
			if (!global::Infragistics.CoreUtilities.AreClose(value, value2))
			{
				global::System.Windows.UIElement uielement = global::System.Windows.Media.VisualTreeHelper.GetParent(this) as global::System.Windows.UIElement;
				if (uielement != null && uielement.IsMeasureValid)
				{
					uielement.InvalidateMeasure();
				}
			}
			return result;
		}
	}
}
