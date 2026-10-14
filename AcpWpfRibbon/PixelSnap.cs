using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace DevComponents.WpfRibbon
{
	// Token: 0x0200006B RID: 107
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class PixelSnap : global::System.Windows.Controls.Decorator
	{
		// Token: 0x0600051E RID: 1310 RVA: 0x00070268 File Offset: 0x0006E468
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size constraint)
		{
			int num;
			global::System.Windows.UIElement child;
			global::System.Windows.Size result;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						constraint.Width = global::System.Math.Floor(constraint.Width);
						constraint.Height = global::System.Math.Floor(constraint.Height);
						child.Measure(constraint);
						result = new global::System.Windows.Size(global::System.Math.Round(child.DesiredSize.Width), global::System.Math.Round(child.DesiredSize.Height));
						num2 = (short)1941241856;
						short num3 = num2;
						num2 = (short)1058430621;
						short num4 = num2;
						num2 = (short)188505757;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3C;
						default:
							num2 = (short)974585857;
							if (num2 != 0)
							{
							}
							num2 = (short)61276160;
							if (num2 != 0)
							{
							}
							num2 = (short)1385299970;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 1:
						if (child != null)
						{
							num2 = (short)1877540864;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 2:
						return result;
					}
					goto IL_1C;
				}
				return result;
			}
			IL_1C:
			child = this.Child;
			result = new global::System.Windows.Size(0.0, 0.0);
			IL_3C:
			num2 = (short)105578497;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x000703F0 File Offset: 0x0006E5F0
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			short num = (short)1421017089;
			if (num != 0)
			{
			}
			num = (short)1709965312;
			short num2 = num;
			global::System.Windows.UIElement child = this.Child;
			if (child != null)
			{
				for (;;)
				{
					num = (short)846061407;
					short num3 = num;
					num = (short)1670176607;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_96;
					}
				}
				IL_96:
				num = (short)2077753344;
				if (num != 0)
				{
				}
				global::System.Windows.Rect finalRect = new global::System.Windows.Rect(0.0, 0.0, global::System.Math.Floor(finalSize.Width), global::System.Math.Floor(finalSize.Height));
				child.Arrange(finalRect);
				return finalRect.Size;
			}
			return finalSize;
		}
	}
}
