using System;

namespace Infragistics
{
	// Token: 0x020000A2 RID: 162
	public static class MathUtil
	{
		// Token: 0x06000725 RID: 1829 RVA: 0x00021794 File Offset: 0x0001F994
		public static double Asinh(double angle)
		{
			return global::System.Math.Log(angle + global::System.Math.Sqrt(angle * angle + 1.0));
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x000217AF File Offset: 0x0001F9AF
		public static double Hypot(double x, double y)
		{
			return global::System.Math.Sqrt(x * x + y * y);
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x000217BD File Offset: 0x0001F9BD
		public static double Sqr(double x)
		{
			return x * x;
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x00021838 File Offset: 0x0001FA38
		public static double GammaLn(double x)
		{
			if (x <= 0.0)
			{
				return double.NaN;
			}
			double[] array = new double[]
			{
				57.15623566586292,
				-59.59796035547549,
				14.136097974741746,
				-0.4919138160976202,
				3.399464998481189E-05,
				4.652362892704858E-05,
				-9.837447530487956E-05,
				0.0001580887032249125,
				-0.00021026444172410488,
				0.00021743961811521265,
				-0.0001643181065367639,
				8.441822398385275E-05,
				-2.6190838401581408E-05,
				3.6899182659531625E-06
			};
			double num = x;
			double num2 = (x + 0.5) * global::System.Math.Log(x + 5.2421875) - (x + 5.2421875);
			double num3 = 0.9999999999999971;
			for (int i = 0; i < 14; i++)
			{
				num3 += array[i] / (num += 1.0);
			}
			return num2 + global::System.Math.Log(2.5066282746310007 * num3 / x);
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x000218DD File Offset: 0x0001FADD
		public static double Clamp(double value, double minimum, double maximum)
		{
			return global::System.Math.Min(maximum, global::System.Math.Max(minimum, value));
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x000218EC File Offset: 0x0001FAEC
		public static double Radians(double degrees)
		{
			return 3.141592653589793 * degrees / 180.0;
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x00021903 File Offset: 0x0001FB03
		public static double Degrees(double radians)
		{
			return 180.0 * radians / 3.141592653589793;
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x0002191C File Offset: 0x0001FB1C
		public static double Noise(double x, double y, double z)
		{
			int num = (int)global::System.Math.Floor(x) & 255;
			int num2 = (int)global::System.Math.Floor(y) & 255;
			int num3 = (int)global::System.Math.Floor(z) & 255;
			x -= global::System.Math.Floor(x);
			y -= global::System.Math.Floor(y);
			z -= global::System.Math.Floor(z);
			double t = global::Infragistics.MathUtil.fade(x);
			double t2 = global::Infragistics.MathUtil.fade(y);
			double t3 = global::Infragistics.MathUtil.fade(z);
			int num4 = global::Infragistics.MathUtil.basis[num] + num2;
			int num5 = global::Infragistics.MathUtil.basis[num4] + num3;
			int num6 = global::Infragistics.MathUtil.basis[num4 + 1] + num3;
			int num7 = global::Infragistics.MathUtil.basis[num + 1] + num2;
			int num8 = global::Infragistics.MathUtil.basis[num7] + num3;
			int num9 = global::Infragistics.MathUtil.basis[num7 + 1] + num3;
			return global::Infragistics.MathUtil.lerp(t3, global::Infragistics.MathUtil.lerp(t2, global::Infragistics.MathUtil.lerp(t, global::Infragistics.MathUtil.grad(global::Infragistics.MathUtil.basis[num5], x, y, z), global::Infragistics.MathUtil.grad(global::Infragistics.MathUtil.basis[num8], x - 1.0, y, z)), global::Infragistics.MathUtil.lerp(t, global::Infragistics.MathUtil.grad(global::Infragistics.MathUtil.basis[num6], x, y - 1.0, z), global::Infragistics.MathUtil.grad(global::Infragistics.MathUtil.basis[num9], x - 1.0, y - 1.0, z))), global::Infragistics.MathUtil.lerp(t2, global::Infragistics.MathUtil.lerp(t, global::Infragistics.MathUtil.grad(global::Infragistics.MathUtil.basis[num5 + 1], x, y, z - 1.0), global::Infragistics.MathUtil.grad(global::Infragistics.MathUtil.basis[num8 + 1], x - 1.0, y, z - 1.0)), global::Infragistics.MathUtil.lerp(t, global::Infragistics.MathUtil.grad(global::Infragistics.MathUtil.basis[num6 + 1], x, y - 1.0, z - 1.0), global::Infragistics.MathUtil.grad(global::Infragistics.MathUtil.basis[num9 + 1], x - 1.0, y - 1.0, z - 1.0))));
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x00021B01 File Offset: 0x0001FD01
		private static double fade(double t)
		{
			return t * t * t * (t * (t * 6.0 - 15.0) + 10.0);
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x00021B2A File Offset: 0x0001FD2A
		private static double lerp(double t, double a, double b)
		{
			return a + t * (b - a);
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x00021B34 File Offset: 0x0001FD34
		private static double grad(int hash, double x, double y, double z)
		{
			int num = hash & 15;
			double num2 = (num < 8) ? x : y;
			double num3 = (num < 4) ? y : ((num == 12 || num == 14) ? x : z);
			return (((num & 1) == 0) ? num2 : (-num2)) + (((num & 2) == 0) ? num3 : (-num3));
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x00021B7C File Offset: 0x0001FD7C
		public static double NiceFloor(double value)
		{
			if (value == 0.0)
			{
				return 0.0;
			}
			if (value < 0.0)
			{
				return -global::Infragistics.MathUtil.NiceCeiling(-value);
			}
			int n = (int)global::System.Math.Floor(global::System.Math.Log10(value));
			double num = value / global::Infragistics.MathUtil.expt(10.0, n);
			double num2 = (num < 2.0) ? 1.0 : ((num < 5.0) ? 2.0 : ((num < 10.0) ? 5.0 : 10.0));
			return num2 * global::Infragistics.MathUtil.expt(10.0, n);
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x00021C34 File Offset: 0x0001FE34
		public static double NiceRound(double value)
		{
			if (value == 0.0)
			{
				return 0.0;
			}
			if (value < 0.0)
			{
				return -global::Infragistics.MathUtil.NiceRound(-value);
			}
			int n = (int)global::System.Math.Floor(global::System.Math.Log10(value));
			double num = value / global::Infragistics.MathUtil.expt(10.0, n);
			double num2 = (num < 1.0) ? 1.0 : ((num < 3.0) ? 2.0 : ((num < 7.0) ? 5.0 : 10.0));
			return num2 * global::Infragistics.MathUtil.expt(10.0, n);
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x00021CEC File Offset: 0x0001FEEC
		public static double NiceCeiling(double value)
		{
			if (value == 0.0)
			{
				return 0.0;
			}
			if (value < 0.0)
			{
				return -global::Infragistics.MathUtil.NiceFloor(-value);
			}
			int n = (int)global::System.Math.Floor(global::System.Math.Log10(value));
			double num = value / global::Infragistics.MathUtil.expt(10.0, n);
			double num2 = (num <= 1.0) ? 1.0 : ((num <= 2.0) ? 2.0 : ((num <= 5.0) ? 5.0 : 10.0));
			return num2 * global::Infragistics.MathUtil.expt(10.0, n);
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x00021DA4 File Offset: 0x0001FFA4
		private static double expt(double a, int n)
		{
			double num = 1.0;
			while (n > 0)
			{
				num *= a;
				n--;
			}
			while (n < 0)
			{
				num /= a;
				n++;
			}
			return num;
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x00021DDA File Offset: 0x0001FFDA
		public static double Min3(double v1, double v2, double v3)
		{
			return global::System.Math.Min(v1, global::System.Math.Min(v2, v3));
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x00021DE9 File Offset: 0x0001FFE9
		public static double Max3(double v1, double v2, double v3)
		{
			return global::System.Math.Max(v1, global::System.Math.Max(v2, v3));
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x00021DF8 File Offset: 0x0001FFF8
		public static double Min(params double[] a)
		{
			double num = a[0];
			for (int i = 1; i < a.Length; i++)
			{
				num = global::System.Math.Min(num, a[i]);
			}
			return num;
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x00021E24 File Offset: 0x00020024
		public static double Max(params double[] a)
		{
			double num = a[0];
			for (int i = 1; i < a.Length; i++)
			{
				num = global::System.Math.Max(num, a[i]);
			}
			return num;
		}

		// Token: 0x040002B8 RID: 696
		public const double DegreeAsRadian = 0.017453292519943295;

		// Token: 0x040002B9 RID: 697
		public static readonly double PHI = (1.0 + global::System.Math.Sqrt(5.0)) / 2.0;

		// Token: 0x040002BA RID: 698
		public static readonly double SQRT2 = global::System.Math.Sqrt(2.0);

		// Token: 0x040002BB RID: 699
		private static int[] basis = new int[]
		{
			151,
			160,
			137,
			91,
			90,
			15,
			131,
			13,
			201,
			95,
			96,
			53,
			194,
			233,
			7,
			225,
			140,
			36,
			103,
			30,
			69,
			142,
			8,
			99,
			37,
			240,
			21,
			10,
			23,
			190,
			6,
			148,
			247,
			120,
			234,
			75,
			0,
			26,
			197,
			62,
			94,
			252,
			219,
			203,
			117,
			35,
			11,
			32,
			57,
			177,
			33,
			88,
			237,
			149,
			56,
			87,
			174,
			20,
			125,
			136,
			171,
			168,
			68,
			175,
			74,
			165,
			71,
			134,
			139,
			48,
			27,
			166,
			77,
			146,
			158,
			231,
			83,
			111,
			229,
			122,
			60,
			211,
			133,
			230,
			220,
			105,
			92,
			41,
			55,
			46,
			245,
			40,
			244,
			102,
			143,
			54,
			65,
			25,
			63,
			161,
			1,
			216,
			80,
			73,
			209,
			76,
			132,
			187,
			208,
			89,
			18,
			169,
			200,
			196,
			135,
			130,
			116,
			188,
			159,
			86,
			164,
			100,
			109,
			198,
			173,
			186,
			3,
			64,
			52,
			217,
			226,
			250,
			124,
			123,
			5,
			202,
			38,
			147,
			118,
			126,
			255,
			82,
			85,
			212,
			207,
			206,
			59,
			227,
			47,
			16,
			58,
			17,
			182,
			189,
			28,
			42,
			223,
			183,
			170,
			213,
			119,
			248,
			152,
			2,
			44,
			154,
			163,
			70,
			221,
			153,
			101,
			155,
			167,
			43,
			172,
			9,
			129,
			22,
			39,
			253,
			19,
			98,
			108,
			110,
			79,
			113,
			224,
			232,
			178,
			185,
			112,
			104,
			218,
			246,
			97,
			228,
			251,
			34,
			242,
			193,
			238,
			210,
			144,
			12,
			191,
			179,
			162,
			241,
			81,
			51,
			145,
			235,
			249,
			14,
			239,
			107,
			49,
			192,
			214,
			31,
			181,
			199,
			106,
			157,
			184,
			84,
			204,
			176,
			115,
			121,
			50,
			45,
			127,
			4,
			150,
			254,
			138,
			236,
			205,
			93,
			222,
			114,
			67,
			29,
			24,
			72,
			243,
			141,
			128,
			195,
			78,
			66,
			215,
			61,
			156,
			180,
			151,
			160,
			137,
			91,
			90,
			15,
			131,
			13,
			201,
			95,
			96,
			53,
			194,
			233,
			7,
			225,
			140,
			36,
			103,
			30,
			69,
			142,
			8,
			99,
			37,
			240,
			21,
			10,
			23,
			190,
			6,
			148,
			247,
			120,
			234,
			75,
			0,
			26,
			197,
			62,
			94,
			252,
			219,
			203,
			117,
			35,
			11,
			32,
			57,
			177,
			33,
			88,
			237,
			149,
			56,
			87,
			174,
			20,
			125,
			136,
			171,
			168,
			68,
			175,
			74,
			165,
			71,
			134,
			139,
			48,
			27,
			166,
			77,
			146,
			158,
			231,
			83,
			111,
			229,
			122,
			60,
			211,
			133,
			230,
			220,
			105,
			92,
			41,
			55,
			46,
			245,
			40,
			244,
			102,
			143,
			54,
			65,
			25,
			63,
			161,
			1,
			216,
			80,
			73,
			209,
			76,
			132,
			187,
			208,
			89,
			18,
			169,
			200,
			196,
			135,
			130,
			116,
			188,
			159,
			86,
			164,
			100,
			109,
			198,
			173,
			186,
			3,
			64,
			52,
			217,
			226,
			250,
			124,
			123,
			5,
			202,
			38,
			147,
			118,
			126,
			255,
			82,
			85,
			212,
			207,
			206,
			59,
			227,
			47,
			16,
			58,
			17,
			182,
			189,
			28,
			42,
			223,
			183,
			170,
			213,
			119,
			248,
			152,
			2,
			44,
			154,
			163,
			70,
			221,
			153,
			101,
			155,
			167,
			43,
			172,
			9,
			129,
			22,
			39,
			253,
			19,
			98,
			108,
			110,
			79,
			113,
			224,
			232,
			178,
			185,
			112,
			104,
			218,
			246,
			97,
			228,
			251,
			34,
			242,
			193,
			238,
			210,
			144,
			12,
			191,
			179,
			162,
			241,
			81,
			51,
			145,
			235,
			249,
			14,
			239,
			107,
			49,
			192,
			214,
			31,
			181,
			199,
			106,
			157,
			184,
			84,
			204,
			176,
			115,
			121,
			50,
			45,
			127,
			4,
			150,
			254,
			138,
			236,
			205,
			93,
			222,
			114,
			67,
			29,
			24,
			72,
			243,
			141,
			128,
			195,
			78,
			66,
			215,
			61,
			156,
			180
		};
	}
}
