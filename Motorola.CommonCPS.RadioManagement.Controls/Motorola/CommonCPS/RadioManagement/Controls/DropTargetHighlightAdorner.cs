using System;
using System.Windows;
using System.Windows.Media;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x0200004E RID: 78
	public class DropTargetHighlightAdorner : global::Motorola.CommonCPS.RadioManagement.Controls.DropTargetAdorner
	{
		// Token: 0x0600012D RID: 301 RVA: 0x000124E4 File Offset: 0x000106E4
		public DropTargetHighlightAdorner(global::System.Windows.UIElement adornedElement) : base(adornedElement)
		{
		}

		// Token: 0x0600012E RID: 302 RVA: 0x000124F8 File Offset: 0x000106F8
		protected override void OnRender(global::System.Windows.Media.DrawingContext drawingContext)
		{
			short num = (short)934084608;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_57;
				}
				global::System.Windows.UIElement targetItem;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
					{
						global::System.Windows.Rect descendantBounds = global::System.Windows.Media.VisualTreeHelper.GetDescendantBounds(targetItem);
						global::System.Windows.Point location = targetItem.TranslatePoint(default(global::System.Windows.Point), base.AdornedElement);
						global::System.Windows.Rect rect = new global::System.Windows.Rect(location, targetItem.RenderSize);
						descendantBounds.Union(rect);
						global::System.Windows.Rect contentBounds = global::System.Windows.Media.VisualTreeHelper.GetContentBounds(base.AdornedElement);
						descendantBounds.Intersect(contentBounds);
						double x = location.X + 1.0;
						double y = location.Y + 1.0;
						double width = descendantBounds.Width - location.X - 2.0;
						double actualHeight = ((global::System.Windows.FrameworkElement)targetItem).ActualHeight;
						global::System.Windows.Rect empty = new global::System.Windows.Rect(x, y, width, actualHeight);
						num = (short)281149442;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_99;
					case 2:
						goto IL_1FE;
					case 3:
						if (global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(targetItem) > 0)
						{
							num = (short)88735744;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1FE;
					case 4:
					{
						num = (short)43757257;
						short num3 = num;
						num = (short)1263906505;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
						{
							num = (short)803012608;
							if (num != 0)
							{
							}
							global::System.Windows.Rect empty = new global::System.Windows.Rect(targetItem.TranslatePoint(default(global::System.Windows.Point), base.AdornedElement), global::System.Windows.Media.VisualTreeHelper.GetDescendantBounds(targetItem).Size);
							num = (short)114294785;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 5:
					{
						num = (short)1056112640;
						short num4 = num;
						global::System.Windows.Rect empty = global::System.Windows.Rect.Empty;
						num = (short)1255800835;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						return;
					case 7:
						if (targetItem != null)
						{
							num = (short)634519557;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 8:
					{
						global::System.Windows.Rect empty;
						drawingContext.DrawRoundedRectangle(null, new global::System.Windows.Media.Pen(base.DropInfo.IsDataAccepted ? global::System.Windows.Media.Brushes.Green : global::System.Windows.Media.Brushes.LightGray, 2.0), empty, 2.0, 2.0);
						num = (short)459079686;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
					{
						global::System.Windows.Rect empty;
						if (empty.IsEmpty)
						{
							num = (short)1150746628;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_99;
					}
					}
					goto IL_57;
					IL_99:
					num = (short)486670344;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1FE:
					num = (short)740491265;
					if (num != 0)
					{
					}
					num = (short)733478921;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_57:
				targetItem = base.DropInfo.TargetItem;
				num = (short)990445575;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}
	}
}
