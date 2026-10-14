using System;
using System.Windows.Media;

namespace Infragistics
{
	// Token: 0x02000074 RID: 116
	public static class ColorUtil
	{
		// Token: 0x0600063B RID: 1595 RVA: 0x0001B465 File Offset: 0x00019665
		public static global::System.Windows.Media.Color RandomColor(byte alpha)
		{
			return global::System.Windows.Media.Color.FromArgb(alpha, (byte)global::Infragistics.ColorUtil.R.Next(0, 255), (byte)global::Infragistics.ColorUtil.R.Next(0, 255), (byte)global::Infragistics.ColorUtil.R.Next(0, 255));
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x0001B4A0 File Offset: 0x000196A0
		public static global::System.Windows.Media.Color RandomHue(global::System.Windows.Media.Color color)
		{
			double[] ahsv = color.GetAHSV();
			return global::Infragistics.ColorUtil.FromAHSV(ahsv[0], (double)global::Infragistics.ColorUtil.R.Next(0, 359), ahsv[2], ahsv[3]);
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x0001B4D4 File Offset: 0x000196D4
		public static global::System.Windows.Media.Color GetInterpolation(this global::System.Windows.Media.Color minimum, double interpolation_, global::System.Windows.Media.Color maximum_, global::Infragistics.InterpolationMode interpolationMode)
		{
			switch (interpolationMode)
			{
			case global::Infragistics.InterpolationMode.RGB:
				return global::System.Windows.Media.Color.FromArgb((byte)((double)minimum.A + interpolation_ * (double)(maximum_.A - minimum.A)), (byte)((double)minimum.R + interpolation_ * (double)(maximum_.R - minimum.R)), (byte)((double)minimum.G + interpolation_ * (double)(maximum_.G - minimum.G)), (byte)((double)minimum.B + interpolation_ * (double)(maximum_.B - minimum.B)));
			case global::Infragistics.InterpolationMode.HSV:
			{
				double[] ahsv = minimum.GetAHSV();
				double[] ahsv2 = maximum_.GetAHSV();
				double num = (ahsv[1] >= 0.0) ? ahsv[1] : ahsv2[1];
				double num2 = (ahsv2[1] >= 0.0) ? ahsv2[1] : ahsv[1];
				if (num >= 0.0 && num2 >= 0.0 && global::System.Math.Abs(num2 - num) > 180.0)
				{
					if (num2 > num)
					{
						num += 360.0;
					}
					else
					{
						num2 += 360.0;
					}
				}
				interpolation_ = global::System.Math.Max(0.0, global::System.Math.Min(1.0, interpolation_));
				return global::Infragistics.ColorUtil.FromAHSV(ahsv[0] + interpolation_ * (ahsv2[0] - ahsv[0]), num + interpolation_ * (num2 - num), ahsv[2] + interpolation_ * (ahsv2[2] - ahsv[2]), ahsv[3] + interpolation_ * (ahsv2[3] - ahsv[3]));
			}
			default:
				return minimum;
			}
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x0001B648 File Offset: 0x00019848
		public static global::System.Windows.Media.Color GetAHSVInterpolation(double[] minimum, double interpolation, double[] maximum)
		{
			double num = (minimum[1] >= 0.0) ? minimum[1] : maximum[1];
			double num2 = (maximum[1] >= 0.0) ? maximum[1] : minimum[1];
			if (num >= 0.0 && num2 >= 0.0 && global::System.Math.Abs(num2 - num) > 180.0)
			{
				if (num2 > num)
				{
					num += 360.0;
				}
				else
				{
					num2 += 360.0;
				}
			}
			interpolation = global::System.Math.Max(0.0, global::System.Math.Min(1.0, interpolation));
			return global::Infragistics.ColorUtil.FromAHSV(minimum[0] + interpolation * (maximum[0] - minimum[0]), num + interpolation * (num2 - num), minimum[2] + interpolation * (maximum[2] - minimum[2]), minimum[3] + interpolation * (maximum[3] - minimum[3]));
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x0001B720 File Offset: 0x00019920
		public static global::System.Windows.Media.Color GetLightened(this global::System.Windows.Media.Color color, double interpolation)
		{
			double[] ahsl = color.GetAHSL();
			if (interpolation < 0.0)
			{
				return global::Infragistics.ColorUtil.FromAHSL(ahsl[0], ahsl[1], ahsl[2], ahsl[3] * (1.0 - global::Infragistics.MathUtil.Clamp(-interpolation, 0.0, 1.0)));
			}
			return global::Infragistics.ColorUtil.FromAHSL(ahsl[0], ahsl[1], ahsl[2], ahsl[3] + global::Infragistics.MathUtil.Clamp(interpolation, 0.0, 1.0) * (1.0 - ahsl[3]));
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x0001B7B0 File Offset: 0x000199B0
		public static double[] GetAHSL(this global::System.Windows.Media.Color color)
		{
			double[] array = new double[4];
			double num = (double)color.R / 255.0;
			double num2 = (double)color.G / 255.0;
			double num3 = (double)color.B / 255.0;
			double num4 = global::System.Math.Min(global::System.Math.Min(num, num2), num3);
			double num5 = global::System.Math.Max(global::System.Math.Max(num, num2), num3);
			double num6 = num5 - num4;
			array[0] = (double)color.A / 255.0;
			array[3] = (num5 + num4) / 2.0;
			if (num6 == 0.0)
			{
				array[1] = -1.0;
				array[2] = 0.0;
			}
			else
			{
				array[1] = global::Infragistics.ColorUtil.H(num5, num6, num, num2, num3);
				array[2] = ((array[3] < 0.5) ? (num6 / (num5 + num4)) : (num6 / (2.0 - num5 - num4)));
			}
			return array;
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x0001B8B0 File Offset: 0x00019AB0
		public static double[] GetAHSV(this global::System.Windows.Media.Color color)
		{
			double num = (double)color.A / 255.0;
			double num2 = (double)color.R / 255.0;
			double num3 = (double)color.G / 255.0;
			double num4 = (double)color.B / 255.0;
			double num5 = global::System.Math.Min(num2, global::System.Math.Min(num3, num4));
			double num6 = global::System.Math.Max(num2, global::System.Math.Max(num3, num4));
			double num7 = num6 - num5;
			double[] array = new double[]
			{
				num,
				0.0,
				0.0,
				num6
			};
			if (num7 == 0.0)
			{
				array[1] = -1.0;
				array[2] = 0.0;
			}
			else
			{
				array[1] = global::Infragistics.ColorUtil.H(num6, num7, num2, num3, num4);
				array[2] = num7 / num6;
			}
			return array;
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x0001B988 File Offset: 0x00019B88
		public static global::System.Windows.Media.Color FromAHSL(double alpha, double hue, double saturation, double lightness)
		{
			double num;
			double num2;
			double num3;
			if (saturation == 0.0)
			{
				num = lightness;
				num2 = lightness;
				num3 = lightness;
			}
			else
			{
				double num4 = (lightness < 0.5) ? (lightness * (1.0 + saturation)) : (lightness + saturation - lightness * saturation);
				double p = 2.0 * lightness - num4;
				double num5 = hue / 360.0;
				num = global::Infragistics.ColorUtil.C(p, num4, num5 + 0.3333333333333333);
				num2 = global::Infragistics.ColorUtil.C(p, num4, num5);
				num3 = global::Infragistics.ColorUtil.C(p, num4, num5 - 0.3333333333333333);
			}
			return global::System.Windows.Media.Color.FromArgb((byte)(alpha * 255.0), (byte)(num * 255.0), (byte)(num2 * 255.0), (byte)(num3 * 255.0));
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x0001BA54 File Offset: 0x00019C54
		public static global::System.Windows.Media.Color FromAHSV(double alpha, double hue, double saturation, double value)
		{
			while (hue >= 360.0)
			{
				hue -= 360.0;
			}
			double num;
			double num2;
			double num3;
			if (saturation == 0.0)
			{
				num = value;
				num2 = value;
				num3 = value;
			}
			else
			{
				hue /= 60.0;
				double num4 = global::System.Math.Floor(hue);
				double num5 = hue - num4;
				double num6 = value * (1.0 - saturation);
				double num7 = value * (1.0 - saturation * num5);
				double num8 = value * (1.0 - saturation * (1.0 - num5));
				switch ((int)num4)
				{
				case 0:
					num = value;
					num2 = num8;
					num3 = num6;
					break;
				case 1:
					num = num7;
					num2 = value;
					num3 = num6;
					break;
				case 2:
					num = num6;
					num2 = value;
					num3 = num8;
					break;
				case 3:
					num = num6;
					num2 = num7;
					num3 = value;
					break;
				case 4:
					num = num8;
					num2 = num6;
					num3 = value;
					break;
				default:
					num = value;
					num2 = num6;
					num3 = num7;
					break;
				}
			}
			return global::System.Windows.Media.Color.FromArgb((byte)(alpha * 255.0), (byte)(num * 255.0), (byte)(num2 * 255.0), (byte)(num3 * 255.0));
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x0001BB7C File Offset: 0x00019D7C
		private static double H(double max, double delta, double r, double g, double b)
		{
			double num = (r == max) ? ((g - b) / delta) : ((g == max) ? (2.0 + (b - r) / delta) : (4.0 + (r - g) / delta));
			num *= 60.0;
			if (num < 0.0)
			{
				num += 360.0;
			}
			return num;
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x0001BBE0 File Offset: 0x00019DE0
		private static double C(double p, double q, double t)
		{
			t = ((t < 0.0) ? (t + 1.0) : ((t > 1.0) ? (t - 1.0) : t));
			if (t < 0.16666666666666666)
			{
				return p + (q - p) * 6.0 * t;
			}
			if (t < 0.5)
			{
				return q;
			}
			if (t < 0.6666666666666666)
			{
				return p + (q - p) * 6.0 * (0.6666666666666666 - t);
			}
			return p;
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000646 RID: 1606 RVA: 0x0001BC78 File Offset: 0x00019E78
		private static global::System.Windows.Media.Color[] RandomColors
		{
			get
			{
				if (global::Infragistics.ColorUtil._RandomColors == null)
				{
					global::Infragistics.ColorUtil._RandomColors = new global::System.Windows.Media.Color[100];
					global::Infragistics.ColorUtil._RandomColors[0] = global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 70, 130, 180);
					global::Infragistics.ColorUtil._RandomColors[1] = global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 65, 105, 225);
					global::Infragistics.ColorUtil._RandomColors[2] = global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 100, 149, 237);
					global::Infragistics.ColorUtil._RandomColors[3] = global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 176, 196, 222);
					global::Infragistics.ColorUtil._RandomColors[4] = global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 123, 104, 238);
					global::Infragistics.ColorUtil._RandomColors[5] = global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 106, 90, 205);
					global::Infragistics.ColorUtil._RandomColors[6] = global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 72, 61, 139);
					global::Infragistics.ColorUtil._RandomColors[7] = global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 25, 25, 112);
					for (int i = 8; i < 100; i++)
					{
						global::Infragistics.ColorUtil._RandomColors[i] = global::System.Windows.Media.Color.FromArgb(byte.MaxValue, (byte)global::Infragistics.ColorUtil.R.Next(255), (byte)global::Infragistics.ColorUtil.R.Next(255), (byte)global::Infragistics.ColorUtil.R.Next(255));
					}
				}
				return global::Infragistics.ColorUtil._RandomColors;
			}
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x0001BE18 File Offset: 0x0001A018
		public static global::System.Windows.Media.Color GetRandomColor(int index)
		{
			index %= 100;
			return global::Infragistics.ColorUtil.RandomColors[index];
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x0001BE30 File Offset: 0x0001A030
		public static int ColorToInt(global::System.Windows.Media.Color color)
		{
			double num = (double)color.A / 255.0;
			int num2 = (int)((double)color.R * num);
			int num3 = (int)((double)color.G * num);
			int num4 = (int)((double)color.B * num);
			return (int)color.A << 24 | num2 << 16 | num3 << 8 | num4;
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x0001BE8C File Offset: 0x0001A08C
		public static global::System.Windows.Media.Color GetColor(global::System.Windows.Media.Brush brush)
		{
			if (brush is global::System.Windows.Media.SolidColorBrush)
			{
				return ((global::System.Windows.Media.SolidColorBrush)brush).Color;
			}
			if (brush is global::System.Windows.Media.GradientBrush)
			{
				global::System.Windows.Media.GradientBrush gradientBrush = brush as global::System.Windows.Media.GradientBrush;
				if (gradientBrush.GradientStops != null && gradientBrush.GradientStops.Count > 0)
				{
					return gradientBrush.GradientStops[0].Color;
				}
			}
			return global::System.Windows.Media.Colors.Transparent;
		}

		// Token: 0x04000279 RID: 633
		private static global::System.Random R = new global::System.Random();

		// Token: 0x0400027A RID: 634
		private static global::System.Windows.Media.Color[] _RandomColors;
	}
}
