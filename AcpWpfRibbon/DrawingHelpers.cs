using System;
using System.Windows;
using System.Windows.Media;

namespace DevComponents.WpfRibbon
{
	// Token: 0x02000033 RID: 51
	internal class DrawingHelpers
	{
		// Token: 0x06000383 RID: 899 RVA: 0x0004D0BC File Offset: 0x0004B2BC
		public static void DrawBorder(global::System.Windows.Media.DrawingContext dc, global::System.Windows.Thickness borderThickness, global::System.Windows.Media.Brush borderBrush, global::System.Windows.Rect borderBounds)
		{
			short num = (short)458752000;
			switch (num)
			{
			default:
			{
				num = (short)1431896081;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (global::DevComponents.WpfRibbon.LayoutHelpers.IsUniform(borderThickness))
						{
							num = (short)970653705;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						borderBounds.Y = 0.5;
						borderBounds.Height -= 1.0;
						borderBounds.X += 0.5;
						borderBounds.Width -= 1.0;
						num = (short)1932263434;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						global::System.Windows.Media.Pen pen = new global::System.Windows.Media.Pen(borderBrush, borderThickness.Left);
						dc.DrawLine(pen, borderBounds.TopLeft, borderBounds.BottomLeft);
						num = (short)902823943;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						num = (short)467992580;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						return;
					case 4:
						if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsEmpty(borderThickness))
						{
							num = (short)740360207;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 5:
						goto IL_184;
					case 6:
						if (borderThickness.Bottom > 0.0)
						{
							num = (short)782172173;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 7:
						num = (short)1238630401;
						if (num != 0)
						{
						}
						goto IL_AE;
					case 8:
						if (borderThickness.Left > 0.0)
						{
							num = (short)184483841;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AE;
					case 9:
						goto IL_17F;
					case 10:
						if (borderThickness.Top > 0.0)
						{
							num = (short)1606418444;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F8;
					case 11:
						if (borderThickness.Right > 0.0)
						{
							num = (short)1619197966;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_184;
					case 12:
					{
						num = (short)484704262;
						short num3 = num;
						num = (short)893583366;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
						{
							num = (short)1883570176;
							if (num != 0)
							{
							}
							global::System.Windows.Media.Pen pen2 = new global::System.Windows.Media.Pen(borderBrush, borderThickness.Top);
							dc.DrawLine(pen2, borderBounds.TopLeft, borderBounds.TopRight);
							num = (short)2120155136;
							short num4 = num;
							num = (short)841416720;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 13:
					{
						global::System.Windows.Media.Pen pen3 = new global::System.Windows.Media.Pen(borderBrush, borderThickness.Bottom);
						dc.DrawLine(pen3, borderBounds.BottomLeft, borderBounds.BottomRight);
						num = (short)1564606467;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
					{
						global::System.Windows.Media.Pen pen4 = new global::System.Windows.Media.Pen(borderBrush, borderThickness.Right);
						dc.DrawLine(pen4, borderBounds.TopRight, borderBounds.BottomRight);
						num = (short)194183173;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						num = (short)349962240;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						goto IL_F8;
					case 17:
						switch (0)
						{
						case 0:
							goto IL_8C;
						}
						continue;
					}
					IL_8C:
					if (borderBrush != null)
					{
						num = (short)16515074;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_AE:
					num = (short)515637259;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F8:
					num = (short)1920139272;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_184:
					num = (short)240320518;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_17F:
				global::System.Windows.Media.Pen pen5 = new global::System.Windows.Media.Pen(borderBrush, borderThickness.Left);
				dc.DrawRectangle(null, pen5, borderBounds);
				return;
			}
			}
		}
	}
}
