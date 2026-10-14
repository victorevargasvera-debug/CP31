using System;
using System.Windows.Media;

namespace DevComponents.WpfDock
{
	// Token: 0x02000005 RID: 5
	internal class b : global::DevComponents.WpfDock.a
	{
		// Token: 0x0600000D RID: 13 RVA: 0x000025C8 File Offset: 0x000007C8
		public b(global::System.Windows.Media.Color A_0)
		{
			this.a = A_0;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000025E4 File Offset: 0x000007E4
		public override global::System.Windows.Media.Color a(int A_0)
		{
			short num;
			while (A_0 == -1)
			{
				num = (short)1920216903;
				short num2 = num;
				num = (short)133443399;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)703922177;
					if (num != 0)
					{
					}
					num = (short)1607860224;
					if (num != 0)
					{
					}
					return default(global::System.Windows.Media.Color);
				}
			}
			num = (short)570621952;
			short num3 = num;
			return global::System.Windows.Media.Color.FromArgb(byte.MaxValue, global::DevComponents.WpfDock.b.a((A_0 & 16711680) >> 16, (int)this.a.R), global::DevComponents.WpfDock.b.a((A_0 & 65280) >> 8, (int)this.a.G), global::DevComponents.WpfDock.b.a(A_0 & 255, (int)this.a.B));
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000026F4 File Offset: 0x000008F4
		public override global::System.Windows.Media.Color b(global::System.Windows.Media.Color A_0)
		{
			short num = (short)1262944256;
			short num2 = num;
			if (A_0.A == 0)
			{
				num = (short)79074093;
				short num3 = num;
				num = (short)1076859693;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)2076770304;
					if (num != 0)
					{
					}
					num = (short)218300417;
					if (num != 0)
					{
					}
					return A_0;
				}
			}
			return global::System.Windows.Media.Color.FromArgb(A_0.A, global::DevComponents.WpfDock.b.a((int)A_0.R, (int)this.a.R), global::DevComponents.WpfDock.b.a((int)A_0.G, (int)this.a.G), global::DevComponents.WpfDock.b.a((int)A_0.B, (int)this.a.B));
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000027FC File Offset: 0x000009FC
		internal static byte a(int A_0, int A_1)
		{
			short num = (short)1615659009;
			if (num != 0)
			{
			}
			num = (short)1034859680;
			short num2 = num;
			num = (short)661370016;
			switch (num2 == num)
			{
			}
			num = (short)1837826048;
			short num3 = num;
			num = (short)1031471104;
			if (num != 0)
			{
			}
			int num4 = A_0 * A_1 / 255;
			return (byte)(num4 + A_0 * (255 - (255 - A_0) * (255 - A_1) / 255 - num4) / 255);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000028D8 File Offset: 0x00000AD8
		internal static global::System.Windows.Media.Color a(global::System.Windows.Media.Color A_0, global::System.Windows.Media.Color A_1)
		{
			short num = (short)1415697607;
			short num2 = num;
			num = (short)78238919;
			switch (num2 == num)
			{
			}
			num = (short)1750073344;
			if (num != 0)
			{
			}
			num = (short)332857344;
			short num3 = num;
			num = (short)292749313;
			if (num != 0)
			{
			}
			return global::System.Windows.Media.Color.FromArgb(A_0.A, global::DevComponents.WpfDock.b.a((int)A_0.R, (int)A_1.R), global::DevComponents.WpfDock.b.a((int)A_0.G, (int)A_1.G), global::DevComponents.WpfDock.b.a((int)A_0.B, (int)A_1.B));
		}

		// Token: 0x04000006 RID: 6
		private new global::System.Windows.Media.Color a;
	}
}
