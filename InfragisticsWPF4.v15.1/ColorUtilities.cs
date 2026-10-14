using System;
using System.Windows.Media;

namespace Infragistics
{
	// Token: 0x0200001F RID: 31
	internal static class ColorUtilities
	{
		// Token: 0x0600014B RID: 331 RVA: 0x00006E78 File Offset: 0x00005078
		static ColorUtilities()
		{
			int length = global::System.Enum.GetValues(typeof(global::Infragistics.ColorBlendMode)).Length;
			global::System.Func<global::System.Windows.Media.Color, global::System.Windows.Media.Color, global::System.Windows.Media.Color>[] array = new global::System.Func<global::System.Windows.Media.Color, global::System.Windows.Media.Color, global::System.Windows.Media.Color>[length];
			array[0] = ((global::System.Windows.Media.Color cB, global::System.Windows.Media.Color cS) => global::Infragistics.ColorUtilities.BlendChannels(cB, cS, new global::System.Func<float, float, float>(global::Infragistics.ColorUtilities.ChannelBlend.Normal)));
			array[1] = ((global::System.Windows.Media.Color cB, global::System.Windows.Media.Color cS) => global::Infragistics.ColorUtilities.BlendChannels(cB, cS, new global::System.Func<float, float, float>(global::Infragistics.ColorUtilities.ChannelBlend.Multiply)));
			array[2] = ((global::System.Windows.Media.Color cB, global::System.Windows.Media.Color cS) => global::Infragistics.ColorUtilities.BlendChannels(cB, cS, new global::System.Func<float, float, float>(global::Infragistics.ColorUtilities.ChannelBlend.Screen)));
			array[3] = ((global::System.Windows.Media.Color cB, global::System.Windows.Media.Color cS) => global::Infragistics.ColorUtilities.BlendChannels(cB, cS, new global::System.Func<float, float, float>(global::Infragistics.ColorUtilities.ChannelBlend.Overlay)));
			array[4] = ((global::System.Windows.Media.Color cB, global::System.Windows.Media.Color cS) => global::Infragistics.ColorUtilities.BlendChannels(cB, cS, new global::System.Func<float, float, float>(global::Infragistics.ColorUtilities.ChannelBlend.Darken)));
			array[5] = ((global::System.Windows.Media.Color cB, global::System.Windows.Media.Color cS) => global::Infragistics.ColorUtilities.BlendChannels(cB, cS, new global::System.Func<float, float, float>(global::Infragistics.ColorUtilities.ChannelBlend.Lighten)));
			array[6] = ((global::System.Windows.Media.Color cB, global::System.Windows.Media.Color cS) => global::Infragistics.ColorUtilities.BlendChannels(cB, cS, new global::System.Func<float, float, float>(global::Infragistics.ColorUtilities.ChannelBlend.ColorDodge)));
			array[7] = ((global::System.Windows.Media.Color cB, global::System.Windows.Media.Color cS) => global::Infragistics.ColorUtilities.BlendChannels(cB, cS, new global::System.Func<float, float, float>(global::Infragistics.ColorUtilities.ChannelBlend.ColorBurn)));
			array[8] = ((global::System.Windows.Media.Color cB, global::System.Windows.Media.Color cS) => global::Infragistics.ColorUtilities.BlendChannels(cB, cS, new global::System.Func<float, float, float>(global::Infragistics.ColorUtilities.ChannelBlend.HardLight)));
			array[9] = ((global::System.Windows.Media.Color cB, global::System.Windows.Media.Color cS) => global::Infragistics.ColorUtilities.BlendChannels(cB, cS, new global::System.Func<float, float, float>(global::Infragistics.ColorUtilities.ChannelBlend.SoftLight)));
			array[10] = ((global::System.Windows.Media.Color cB, global::System.Windows.Media.Color cS) => global::Infragistics.ColorUtilities.BlendChannels(cB, cS, new global::System.Func<float, float, float>(global::Infragistics.ColorUtilities.ChannelBlend.Difference)));
			array[11] = ((global::System.Windows.Media.Color cB, global::System.Windows.Media.Color cS) => global::Infragistics.ColorUtilities.BlendChannels(cB, cS, new global::System.Func<float, float, float>(global::Infragistics.ColorUtilities.ChannelBlend.Exclusion)));
			array[12] = ((global::System.Windows.Media.Color cB, global::System.Windows.Media.Color cS) => global::Infragistics.ColorUtilities.BlendChannels(cB, cS, new global::System.Func<float, float, float>(global::Infragistics.ColorUtilities.ChannelBlend.LinearBurn)));
			array[13] = ((global::System.Windows.Media.Color cB, global::System.Windows.Media.Color cS) => global::Infragistics.ColorUtilities.BlendChannels(cB, cS, new global::System.Func<float, float, float>(global::Infragistics.ColorUtilities.ChannelBlend.LinearDodge)));
			array[14] = ((global::System.Windows.Media.Color cB, global::System.Windows.Media.Color cS) => global::Infragistics.ColorUtilities.BlendChannels(cB, cS, new global::System.Func<float, float, float>(global::Infragistics.ColorUtilities.ChannelBlend.Subtract)));
			array[15] = ((global::System.Windows.Media.Color cB, global::System.Windows.Media.Color cS) => global::Infragistics.ColorUtilities.BlendChannels(cB, cS, new global::System.Func<float, float, float>(global::Infragistics.ColorUtilities.ChannelBlend.Divide)));
			array[16] = ((global::System.Windows.Media.Color cB, global::System.Windows.Media.Color cS) => global::Infragistics.ColorUtilities.BlendChannels(cB, cS, new global::System.Func<float, float, float>(global::Infragistics.ColorUtilities.ChannelBlend.PinLight)));
			array[17] = ((global::System.Windows.Media.Color cB, global::System.Windows.Media.Color cS) => global::Infragistics.ColorUtilities.BlendChannels(cB, cS, new global::System.Func<float, float, float>(global::Infragistics.ColorUtilities.ChannelBlend.LinearLight)));
			array[18] = ((global::System.Windows.Media.Color cB, global::System.Windows.Media.Color cS) => global::Infragistics.ColorUtilities.BlendChannels(cB, cS, new global::System.Func<float, float, float>(global::Infragistics.ColorUtilities.ChannelBlend.VividLight)));
			array[19] = ((global::System.Windows.Media.Color cB, global::System.Windows.Media.Color cS) => global::Infragistics.ColorUtilities.BlendChannels(cB, cS, new global::System.Func<float, float, float>(global::Infragistics.ColorUtilities.ChannelBlend.HardMix)));
			foreach (object obj in global::System.Enum.GetValues(typeof(global::Infragistics.ColorBlendMode)))
			{
				global::Infragistics.ColorBlendMode colorBlendMode = (global::Infragistics.ColorBlendMode)obj;
				if (array[(int)colorBlendMode] == null)
				{
					array[(int)colorBlendMode] = delegate(global::System.Windows.Media.Color b, global::System.Windows.Media.Color s)
					{
						throw new global::System.NotImplementedException();
					};
				}
			}
			global::Infragistics.ColorUtilities._blendFunctions = array;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x000071A8 File Offset: 0x000053A8
		private static global::System.Windows.Media.Color BlendChannels(global::System.Windows.Media.Color backdrop, global::System.Windows.Media.Color source, global::System.Func<float, float, float> blendFunc)
		{
			if (backdrop.A == 255 && source.A == 255)
			{
				return global::Infragistics.ColorUtilities.BlendChannelsOpaque(backdrop, source, blendFunc);
			}
			return global::Infragistics.ColorUtilities.BlendChannelsAlpha(backdrop, source, blendFunc);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x000071D8 File Offset: 0x000053D8
		private static global::System.Windows.Media.Color BlendChannelsOpaque(global::System.Windows.Media.Color backdrop, global::System.Windows.Media.Color source, global::System.Func<float, float, float> blendFunc)
		{
			float value = blendFunc(global::Infragistics.ColorUtilities.RgbByteToFloat(backdrop.R), global::Infragistics.ColorUtilities.RgbByteToFloat(source.R));
			float value2 = blendFunc(global::Infragistics.ColorUtilities.RgbByteToFloat(backdrop.G), global::Infragistics.ColorUtilities.RgbByteToFloat(source.G));
			float value3 = blendFunc(global::Infragistics.ColorUtilities.RgbByteToFloat(backdrop.B), global::Infragistics.ColorUtilities.RgbByteToFloat(source.B));
			return global::System.Windows.Media.Color.FromArgb(byte.MaxValue, global::Infragistics.ColorUtilities.RgbFloatToByte(value), global::Infragistics.ColorUtilities.RgbFloatToByte(value2), global::Infragistics.ColorUtilities.RgbFloatToByte(value3));
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00007260 File Offset: 0x00005460
		private static global::System.Windows.Media.Color BlendChannelsAlpha(global::System.Windows.Media.Color backdrop, global::System.Windows.Media.Color source, global::System.Func<float, float, float> blendFunc)
		{
			float num = global::Infragistics.ColorUtilities.RgbByteToFloat(backdrop.A);
			float num2 = global::Infragistics.ColorUtilities.RgbByteToFloat(source.A);
			float num3 = num + num2 - num * num2;
			float value = global::Infragistics.ColorUtilities.BlendChannelWithAlpha(global::Infragistics.ColorUtilities.RgbByteToFloat(backdrop.R), global::Infragistics.ColorUtilities.RgbByteToFloat(source.R), num, num2, num3, blendFunc);
			float value2 = global::Infragistics.ColorUtilities.BlendChannelWithAlpha(global::Infragistics.ColorUtilities.RgbByteToFloat(backdrop.G), global::Infragistics.ColorUtilities.RgbByteToFloat(source.G), num, num2, num3, blendFunc);
			float value3 = global::Infragistics.ColorUtilities.BlendChannelWithAlpha(global::Infragistics.ColorUtilities.RgbByteToFloat(backdrop.B), global::Infragistics.ColorUtilities.RgbByteToFloat(source.B), num, num2, num3, blendFunc);
			return global::System.Windows.Media.Color.FromArgb(global::Infragistics.ColorUtilities.RgbFloatToByte(num3), global::Infragistics.ColorUtilities.RgbFloatToByte(value), global::Infragistics.ColorUtilities.RgbFloatToByte(value2), global::Infragistics.ColorUtilities.RgbFloatToByte(value3));
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00007316 File Offset: 0x00005516
		private static float BlendChannelWithAlpha(float cB, float cS, float aB, float aS, float aR, global::System.Func<float, float, float> blendFunc)
		{
			return (1f - aS / aR) * cB + aS / aR * ((1f - aB) * cS + aB * blendFunc(cB, cS));
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00007340 File Offset: 0x00005540
		private static double CalculateSRgbBrightness(global::System.Windows.Media.Color color)
		{
			return global::System.Math.Pow((double)color.R / 255.0, 2.2) * 0.2126 + global::System.Math.Pow((double)color.G / 255.0, 2.2) * 0.7152 + global::System.Math.Pow((double)color.B / 255.0, 2.2) * 0.0722;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x000073CF File Offset: 0x000055CF
		private static void Clamp(ref float value, float min, float max)
		{
			if (value < min)
			{
				value = min;
				return;
			}
			if (value > max)
			{
				value = max;
			}
		}

		// Token: 0x06000152 RID: 338 RVA: 0x000073E2 File Offset: 0x000055E2
		private static float Max(float f1, float f2, float f3)
		{
			return global::System.Math.Max(global::System.Math.Max(f1, f2), f3);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x000073F1 File Offset: 0x000055F1
		private static float Min(float f1, float f2, float f3)
		{
			return global::System.Math.Min(global::System.Math.Min(f1, f2), f3);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00007400 File Offset: 0x00005600
		private static byte RgbFloatToByte(float value)
		{
			value = (float)global::System.Math.Round((double)(value * 255f), 0, global::System.MidpointRounding.AwayFromZero);
			if (value < 0f)
			{
				return 0;
			}
			if (value > 255f)
			{
				return byte.MaxValue;
			}
			return (byte)value;
		}

		// Token: 0x06000155 RID: 341 RVA: 0x0000742E File Offset: 0x0000562E
		private static float RgbByteToFloat(byte rgbChannel)
		{
			return (float)rgbChannel / 255f;
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00007438 File Offset: 0x00005638
		internal static global::System.Windows.Media.Color CalculateForeground(global::System.Windows.Media.Color background, params global::System.Windows.Media.Color[] foregroundColors)
		{
			double num = global::Infragistics.ColorUtilities.CalculateSRgbBrightness(background);
			double num2 = -1.0;
			global::System.Windows.Media.Color result = global::System.Windows.Media.Colors.Transparent;
			foreach (global::System.Windows.Media.Color color in foregroundColors)
			{
				double num3 = global::Infragistics.ColorUtilities.CalculateSRgbBrightness(color);
				double num4 = (num3 > num) ? ((num3 + 0.05) / (num + 0.05)) : ((num + 0.05) / (num3 + 0.05));
				if (num4 > num2)
				{
					num2 = num4;
					result = color;
				}
			}
			return result;
		}

		// Token: 0x06000157 RID: 343 RVA: 0x000074D0 File Offset: 0x000056D0
		internal static global::System.Windows.Media.Color CalculateForeground(global::System.Windows.Media.Color background)
		{
			double num = global::Infragistics.ColorUtilities.CalculateSRgbBrightness(background);
			double num2 = 1.05 / (num + 0.05);
			double num3 = (num + 0.05) / 0.05;
			if (num3 <= num2)
			{
				return global::System.Windows.Media.Colors.White;
			}
			return global::System.Windows.Media.Colors.Black;
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00007520 File Offset: 0x00005720
		internal static global::System.Windows.Media.Color? ColorFromObject(object value)
		{
			if (value is global::System.Windows.Media.Color)
			{
				return new global::System.Windows.Media.Color?((global::System.Windows.Media.Color)value);
			}
			if (value is string)
			{
				try
				{
					return new global::System.Windows.Media.Color?((global::System.Windows.Media.Color)global::System.Windows.Media.ColorConverter.ConvertFromString((string)value));
				}
				catch (global::System.FormatException)
				{
				}
			}
			if (value is global::System.Windows.Media.SolidColorBrush)
			{
				return new global::System.Windows.Media.Color?(((global::System.Windows.Media.SolidColorBrush)value).Color);
			}
			return null;
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00007598 File Offset: 0x00005798
		public static global::System.Windows.Media.Color Blend(global::System.Windows.Media.Color backdrop, global::System.Windows.Media.Color source, global::Infragistics.ColorBlendMode blendMode)
		{
			return global::Infragistics.ColorUtilities._blendFunctions[(int)blendMode](backdrop, source);
		}

		// Token: 0x04000080 RID: 128
		private static readonly global::System.Func<global::System.Windows.Media.Color, global::System.Windows.Media.Color, global::System.Windows.Media.Color>[] _blendFunctions;

		// Token: 0x02000020 RID: 32
		internal static class ChannelBlend
		{
			// Token: 0x0600016F RID: 367 RVA: 0x000075A8 File Offset: 0x000057A8
			internal static float ColorBurn(float b, float s)
			{
				if (s <= 0f)
				{
					return 0f;
				}
				return 1f - global::System.Math.Min((1f - b) / s, 1f);
			}

			// Token: 0x06000170 RID: 368 RVA: 0x000075D1 File Offset: 0x000057D1
			internal static float ColorDodge(float b, float s)
			{
				if (s >= 1f)
				{
					return 1f;
				}
				return global::System.Math.Min(b / (1f - s), 1f);
			}

			// Token: 0x06000171 RID: 369 RVA: 0x000075F4 File Offset: 0x000057F4
			internal static float Darken(float b, float s)
			{
				return global::System.Math.Min(b, s);
			}

			// Token: 0x06000172 RID: 370 RVA: 0x000075FD File Offset: 0x000057FD
			internal static float Difference(float b, float s)
			{
				return global::System.Math.Abs(b - s);
			}

			// Token: 0x06000173 RID: 371 RVA: 0x00007607 File Offset: 0x00005807
			internal static float Divide(float b, float s)
			{
				return b / s;
			}

			// Token: 0x06000174 RID: 372 RVA: 0x0000760C File Offset: 0x0000580C
			internal static float Exclusion(float b, float s)
			{
				return b + s - 2f * b * s;
			}

			// Token: 0x06000175 RID: 373 RVA: 0x0000761B File Offset: 0x0000581B
			internal static float HardLight(float b, float s)
			{
				if (s > 0.5f)
				{
					return global::Infragistics.ColorUtilities.ChannelBlend.Screen(b, 2f * s - 1f);
				}
				return global::Infragistics.ColorUtilities.ChannelBlend.Multiply(b, 2f * s);
			}

			// Token: 0x06000176 RID: 374 RVA: 0x00007646 File Offset: 0x00005846
			internal static float HardMix(float b, float s)
			{
				if (global::Infragistics.ColorUtilities.ChannelBlend.VividLight(b, s) >= 0.5f)
				{
					return 1f;
				}
				return 0f;
			}

			// Token: 0x06000177 RID: 375 RVA: 0x00007661 File Offset: 0x00005861
			internal static float Lighten(float b, float s)
			{
				return global::System.Math.Max(b, s);
			}

			// Token: 0x06000178 RID: 376 RVA: 0x0000766A File Offset: 0x0000586A
			internal static float LinearBurn(float b, float s)
			{
				return b + s - 1f;
			}

			// Token: 0x06000179 RID: 377 RVA: 0x00007675 File Offset: 0x00005875
			internal static float LinearDodge(float b, float s)
			{
				return b + s;
			}

			// Token: 0x0600017A RID: 378 RVA: 0x0000767A File Offset: 0x0000587A
			internal static float LinearLight(float b, float s)
			{
				if (s > 0.5f)
				{
					return global::Infragistics.ColorUtilities.ChannelBlend.LinearDodge(b, 2f * (s - 0.5f));
				}
				return global::Infragistics.ColorUtilities.ChannelBlend.LinearBurn(b, 2f * s);
			}

			// Token: 0x0600017B RID: 379 RVA: 0x000076A5 File Offset: 0x000058A5
			internal static float Multiply(float b, float s)
			{
				return b * s;
			}

			// Token: 0x0600017C RID: 380 RVA: 0x000076AA File Offset: 0x000058AA
			internal static float Normal(float b, float s)
			{
				return s;
			}

			// Token: 0x0600017D RID: 381 RVA: 0x000076AD File Offset: 0x000058AD
			internal static float Overlay(float b, float s)
			{
				return global::Infragistics.ColorUtilities.ChannelBlend.HardLight(s, b);
			}

			// Token: 0x0600017E RID: 382 RVA: 0x000076B6 File Offset: 0x000058B6
			internal static float PinLight(float b, float s)
			{
				if (s > 0.5f)
				{
					return global::Infragistics.ColorUtilities.ChannelBlend.Lighten(b, 2f * (s - 0.5f));
				}
				return global::Infragistics.ColorUtilities.ChannelBlend.Darken(b, 2f * s);
			}

			// Token: 0x0600017F RID: 383 RVA: 0x000076E1 File Offset: 0x000058E1
			internal static float Screen(float b, float s)
			{
				return b + s - b * s;
			}

			// Token: 0x06000180 RID: 384 RVA: 0x000076EA File Offset: 0x000058EA
			internal static float SoftLight(float b, float s)
			{
				if (s > 0.5f)
				{
					return b + (2f * s - 1f) * (global::Infragistics.ColorUtilities.ChannelBlend.SoftLightD(b) - b);
				}
				return b - (1f - 2f * s) * b * (1f - b);
			}

			// Token: 0x06000181 RID: 385 RVA: 0x00007726 File Offset: 0x00005926
			internal static float Subtract(float b, float s)
			{
				return b - s;
			}

			// Token: 0x06000182 RID: 386 RVA: 0x0000772B File Offset: 0x0000592B
			internal static float VividLight(float b, float s)
			{
				if (s > 0.5f)
				{
					return global::Infragistics.ColorUtilities.ChannelBlend.ColorDodge(b, 2f * (s - 0.5f));
				}
				return global::Infragistics.ColorUtilities.ChannelBlend.ColorBurn(b, 2f * s);
			}

			// Token: 0x06000183 RID: 387 RVA: 0x00007756 File Offset: 0x00005956
			private static float SoftLightD(float x)
			{
				if (x > 0.25f)
				{
					return (float)global::System.Math.Sqrt((double)x);
				}
				return ((16f * x - 12f) * x + 4f) * x;
			}
		}
	}
}
