using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace DevComponents.WpfRibbon
{
	// Token: 0x02000053 RID: 83
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class GalleryWrapPanel : global::System.Windows.Controls.WrapPanel
	{
		// Token: 0x060003E1 RID: 993 RVA: 0x0005402C File Offset: 0x0005222C
		protected override global::System.Windows.Controls.UIElementCollection CreateUIElementCollection(global::System.Windows.FrameworkElement logicalParent)
		{
			short num = (short)1657513836;
			short num2 = num;
			num = (short)1707255660;
			switch (num2 == num)
			{
			}
			num = (short)1705639936;
			short num3 = num;
			num = (short)532086785;
			if (num != 0)
			{
			}
			num = (short)589692928;
			if (num != 0)
			{
			}
			return new global::System.Windows.Controls.UIElementCollection(this, null);
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x000540E0 File Offset: 0x000522E0
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size constraint)
		{
			short num = (short)826146817;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)969367604;
				short num3 = num;
				num = (short)1398038580;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_405;
				default:
				{
					num = (short)1685061632;
					if (num != 0)
					{
					}
					global::System.Windows.Controls.ItemsPresenter itemsPresenter;
					switch (num2)
					{
					case 0:
						goto IL_22A;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_C5;
						}
						continue;
					case 2:
						goto IL_2B6;
					case 3:
						num = (short)408551442;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (base.TemplatedParent is global::DevComponents.WpfRibbon.Gallery)
						{
							num = (short)4653063;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)355008525;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (itemsPresenter != null)
						{
							num = (short)470417411;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F4;
					case 6:
						goto IL_F4;
					case 7:
					{
						global::DevComponents.WpfRibbon.Gallery gallery = base.TemplatedParent as global::DevComponents.WpfRibbon.Gallery;
						num = (short)1751580680;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_F4;
					case 9:
						goto IL_F4;
					case 10:
						num = (short)617152513;
						if (num != 0)
						{
						}
						num = (short)844169232;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						num = (short)870711315;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
					{
						global::DevComponents.WpfRibbon.Gallery gallery = itemsPresenter.TemplatedParent as global::DevComponents.WpfRibbon.Gallery;
						num = (short)1707474950;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
					{
						num = (short)1278541824;
						short num4 = num;
						if (base.Parent is global::System.Windows.Controls.Panel)
						{
							num = (short)1460600842;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_373;
					}
					case 14:
					{
						global::DevComponents.WpfRibbon.Gallery gallery = null;
						num = (short)251527172;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
					{
						global::DevComponents.WpfRibbon.Gallery gallery;
						if (gallery != null)
						{
							num = (short)1882652683;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_405;
					}
					case 16:
						if (((global::System.Windows.Controls.Panel)base.Parent).TemplatedParent is global::DevComponents.WpfRibbon.Gallery)
						{
							num = (short)857407505;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_373;
					case 17:
					{
						global::DevComponents.WpfRibbon.Gallery gallery = ((global::System.Windows.Controls.Panel)base.Parent).TemplatedParent as global::DevComponents.WpfRibbon.Gallery;
						num = (short)1245904905;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						if (itemsPresenter.TemplatedParent is global::DevComponents.WpfRibbon.Gallery)
						{
							num = (short)840302604;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F4;
					case 19:
					{
						global::DevComponents.WpfRibbon.Gallery gallery;
						if (gallery.IsCollapsed)
						{
							num = (short)1526923284;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						constraint.Width = gallery.InternalItemsPanel.ActualWidth + 20.0;
						num = (short)1280835586;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						constraint.Width = 200.0;
						num = (short)1400373248;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_C5:
					if (double.IsPositiveInfinity(constraint.Width))
					{
						num = (short)1650851854;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					goto IL_405;
					IL_F4:
					num = (short)58195983;
					num2 = (int)((global::System.IntPtr)num);
					break;
					IL_373:
					itemsPresenter = (base.TemplatedParent as global::System.Windows.Controls.ItemsPresenter);
					num = (short)619511813;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
			IL_22A:
			IL_2B6:
			IL_405:
			return base.MeasureOverride(constraint);
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x000544FC File Offset: 0x000526FC
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			short num = (short)1210363110;
			short num2 = num;
			num = (short)1614720230;
			switch (num2 == num)
			{
			}
			num = (short)1765605376;
			short num3 = num;
			num = (short)1228668929;
			if (num != 0)
			{
			}
			num = (short)1937178624;
			if (num != 0)
			{
			}
			global::System.Windows.Size result = base.ArrangeOverride(finalSize);
			if (double.IsNaN(base.Width) && (!(base.Parent is global::System.Windows.Controls.Panel) || double.IsNaN(((global::System.Windows.Controls.Panel)base.Parent).Width)))
			{
				base.Width = finalSize.Width + 2.0;
			}
			return result;
		}
	}
}
