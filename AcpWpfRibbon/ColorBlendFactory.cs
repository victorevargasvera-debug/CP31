using System;
using System.Windows.Media;

namespace DevComponents.WpfRibbon
{
	// Token: 0x02000023 RID: 35
	internal class ColorBlendFactory : global::DevComponents.WpfRibbon.ColorFactory
	{
		// Token: 0x060002A4 RID: 676 RVA: 0x0003CD84 File Offset: 0x0003AF84
		public ColorBlendFactory(global::System.Windows.Media.Color blendColor)
		{
			this.m_BlendColor = blendColor;
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0003CDA0 File Offset: 0x0003AFA0
		public override global::System.Windows.Media.Color GetColor(int rgb)
		{
			short num;
			for (;;)
			{
				num = (short)216530944;
				short num2 = num;
				if (rgb != -1)
				{
					goto IL_A9;
				}
				num = (short)1386776510;
				short num3 = num;
				num = (short)1531348926;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_64;
				}
			}
			IL_64:
			num = (short)1308884992;
			if (num != 0)
			{
			}
			num = (short)1135476737;
			if (num != 0)
			{
			}
			return default(global::System.Windows.Media.Color);
			IL_A9:
			return global::System.Windows.Media.Color.FromArgb(byte.MaxValue, global::DevComponents.WpfRibbon.ColorBlendFactory.SoftLight((rgb & 16711680) >> 16, (int)this.m_BlendColor.R), global::DevComponents.WpfRibbon.ColorBlendFactory.SoftLight((rgb & 65280) >> 8, (int)this.m_BlendColor.G), global::DevComponents.WpfRibbon.ColorBlendFactory.SoftLight(rgb & 255, (int)this.m_BlendColor.B));
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0003CEAC File Offset: 0x0003B0AC
		public override global::System.Windows.Media.Color GetColor(global::System.Windows.Media.Color c)
		{
			short num;
			for (;;)
			{
				num = (short)4325376;
				short num2 = num;
				if (c.A != 0)
				{
					goto IL_82;
				}
				num = (short)1849579651;
				short num3 = num;
				num = (short)1079990403;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_6B;
				}
			}
			IL_6B:
			num = (short)1214644224;
			if (num != 0)
			{
			}
			return c;
			IL_82:
			num = (short)1915944961;
			if (num != 0)
			{
			}
			return global::System.Windows.Media.Color.FromArgb(c.A, global::DevComponents.WpfRibbon.ColorBlendFactory.SoftLight((int)c.R, (int)this.m_BlendColor.R), global::DevComponents.WpfRibbon.ColorBlendFactory.SoftLight((int)c.G, (int)this.m_BlendColor.G), global::DevComponents.WpfRibbon.ColorBlendFactory.SoftLight((int)c.B, (int)this.m_BlendColor.B));
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0003CFB4 File Offset: 0x0003B1B4
		internal static byte SoftLight(int a, int b)
		{
			short num = (short)2131521842;
			short num2 = num;
			num = (short)575697202;
			switch (num2 == num)
			{
			default:
			{
				num = (short)327548928;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)708444161;
			if (num != 0)
			{
			}
			num = (short)740294656;
			if (num != 0)
			{
			}
			int num4 = a * b / 255;
			return (byte)(num4 + a * (255 - (255 - a) * (255 - b) / 255 - num4) / 255);
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x0003D090 File Offset: 0x0003B290
		internal static global::System.Windows.Media.Color SoftLight(global::System.Windows.Media.Color c, global::System.Windows.Media.Color light)
		{
			short num = (short)1342387798;
			short num2 = num;
			num = (short)1808610902;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1090322432;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1853358081;
			if (num != 0)
			{
			}
			num = (short)1021968384;
			if (num != 0)
			{
			}
			return global::System.Windows.Media.Color.FromArgb(c.A, global::DevComponents.WpfRibbon.ColorBlendFactory.SoftLight((int)c.R, (int)light.R), global::DevComponents.WpfRibbon.ColorBlendFactory.SoftLight((int)c.G, (int)light.G), global::DevComponents.WpfRibbon.ColorBlendFactory.SoftLight((int)c.B, (int)light.B));
		}

		// Token: 0x040000E3 RID: 227
		private global::System.Windows.Media.Color m_BlendColor;
	}
}
