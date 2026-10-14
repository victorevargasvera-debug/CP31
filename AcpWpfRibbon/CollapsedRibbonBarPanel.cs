using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace DevComponents.WpfRibbon
{
	// Token: 0x02000021 RID: 33
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class CollapsedRibbonBarPanel : global::System.Windows.Controls.Panel
	{
		// Token: 0x0600029D RID: 669 RVA: 0x0003CA2C File Offset: 0x0003AC2C
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			switch (0)
			{
			case 0:
				goto IL_6C;
			}
			short num;
			int num3;
			global::DevComponents.WpfRibbon.CollapsedRibbonBarButton collapsedRibbonBarButton;
			for (;;)
			{
				IL_0A:
				num = (short)993316957;
				short num2 = num;
				num = (short)267178077;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)118751232;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						if (collapsedRibbonBarButton.AttachedRibbonBar != null)
						{
							num = (short)468451328;
							short num4 = num;
							num = (short)1506344963;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_184;
					case 1:
						goto IL_9A;
					case 2:
						num = (short)330301440;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_17F;
					}
					goto IL_6C;
				}
				IL_9A:
				if (collapsedRibbonBarButton == null)
				{
					goto IL_184;
				}
				num = (short)662568962;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_17F:
			num = (short)1434058753;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.RibbonBar attachedRibbonBar = collapsedRibbonBarButton.AttachedRibbonBar;
			base.Children.Add(attachedRibbonBar);
			attachedRibbonBar.Measure(new global::System.Windows.Size(double.PositiveInfinity, attachedRibbonBar.DesiredSize.Height));
			return attachedRibbonBar.DesiredSize;
			IL_184:
			return base.MeasureOverride(availableSize);
			IL_6C:
			base.Children.Clear();
			collapsedRibbonBarButton = (base.TemplatedParent as global::DevComponents.WpfRibbon.CollapsedRibbonBarButton);
			num = (short)276692993;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0003CBC4 File Offset: 0x0003ADC4
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			short num;
			for (;;)
			{
				num = (short)22937600;
				short num2 = num;
				if (base.Children.Count == 1)
				{
					goto IL_AE;
				}
				num = (short)1175167859;
				short num3 = num;
				num = (short)1622057843;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_6E;
				}
			}
			IL_6E:
			num = (short)1568342017;
			if (num != 0)
			{
			}
			num = (short)1393426432;
			if (num != 0)
			{
			}
			return finalSize;
			IL_AE:
			(base.Children[0] as global::DevComponents.WpfRibbon.RibbonBar).Arrange(new global::System.Windows.Rect(finalSize));
			return finalSize;
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0003CC9C File Offset: 0x0003AE9C
		protected override global::System.Windows.Controls.UIElementCollection CreateUIElementCollection(global::System.Windows.FrameworkElement logicalParent)
		{
			short num = (short)1921646593;
			if (num != 0)
			{
			}
			num = (short)306511872;
			short num2 = num;
			num = (short)1859991413;
			short num3 = num;
			num = (short)1328887669;
			switch (num3 == num)
			{
			}
			num = (short)1531183104;
			if (num != 0)
			{
			}
			return new global::System.Windows.Controls.UIElementCollection(this, (base.TemplatedParent == null) ? logicalParent : null);
		}
	}
}
