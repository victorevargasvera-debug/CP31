using System;
using System.ComponentModel;
using System.Windows;

namespace DevComponents.WpfRibbon
{
	// Token: 0x0200001F RID: 31
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class CollapsedRibbonBarControl : global::DevComponents.WpfRibbon.HeaderedPopupControl
	{
		// Token: 0x0600028F RID: 655 RVA: 0x0003BFA0 File Offset: 0x0003A1A0
		static CollapsedRibbonBarControl()
		{
			short num = (short)482804267;
			short num2 = num;
			num = (short)351207979;
			switch (num2 == num)
			{
			default:
			{
				num = (short)828506112;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1624571905;
			if (num != 0)
			{
			}
			num = (short)770506752;
			if (num != 0)
			{
			}
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfRibbon.CollapsedRibbonBarControl), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfRibbon.CollapsedRibbonBarControl)));
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0003C06C File Offset: 0x0003A26C
		internal global::DevComponents.WpfRibbon.CollapsedRibbonBarButton CreateButton()
		{
			short num = (short)56019583;
			short num2 = num;
			num = (short)1200999039;
			switch (num2 == num)
			{
			default:
			{
				num = (short)170000384;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)484114433;
			if (num != 0)
			{
			}
			num = (short)971440128;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.CollapsedRibbonBarButton collapsedRibbonBarButton = new global::DevComponents.WpfRibbon.CollapsedRibbonBarButton();
			collapsedRibbonBarButton.Role = global::DevComponents.WpfRibbon.eButtonRole.DropDown;
			base.Header = collapsedRibbonBarButton;
			return collapsedRibbonBarButton;
		}
	}
}
