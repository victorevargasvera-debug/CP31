using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Windows.Controls
{
	// Token: 0x020000F7 RID: 247
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class CardPanel : global::System.Windows.Controls.Panel
	{
		// Token: 0x0600088A RID: 2186 RVA: 0x0001CAA4 File Offset: 0x0001ACA4
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			double num = 0.0;
			double num2 = 0.0;
			global::System.Windows.Controls.UIElementCollection children = base.Children;
			int i = 0;
			int count = children.Count;
			while (i < count)
			{
				global::System.Windows.UIElement uielement = children[i];
				uielement.Measure(availableSize);
				global::System.Windows.Size desiredSize = uielement.DesiredSize;
				if (desiredSize.Width > num)
				{
					num = desiredSize.Width;
				}
				if (desiredSize.Height > num2)
				{
					num2 = desiredSize.Height;
				}
				i++;
			}
			return new global::System.Windows.Size(num, num2);
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x0001CB28 File Offset: 0x0001AD28
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			global::System.Windows.Controls.UIElementCollection children = base.Children;
			global::System.Windows.Rect finalRect = new global::System.Windows.Rect(finalSize);
			int i = 0;
			int count = children.Count;
			while (i < count)
			{
				children[i].Arrange(finalRect);
				i++;
			}
			return finalSize;
		}
	}
}
