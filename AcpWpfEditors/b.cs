using System;
using System.Windows.Media;

namespace DevComponents.WpfEditors
{
	// Token: 0x0200000B RID: 11
	internal class b : global::DevComponents.WpfEditors.a
	{
		// Token: 0x06000053 RID: 83 RVA: 0x00008F2C File Offset: 0x0000712C
		public b(global::System.Windows.Media.Color A_0)
		{
			this.a = A_0;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00008F48 File Offset: 0x00007148
		public override global::System.Windows.Media.Color c(int A_0)
		{
			while (A_0 != -1)
			{
				short num = (short)555723101;
				short num2 = num;
				num = (short)343386461;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					break;
				default:
				{
					num = (short)910622720;
					short num3 = num;
					break;
				}
				}
				num = (short)1496449024;
				if (num != 0)
				{
				}
				num = (short)1010630657;
				if (num != 0)
				{
				}
				return global::System.Windows.Media.Color.FromArgb(byte.MaxValue, global::DevComponents.WpfEditors.b.a((A_0 & 16711680) >> 16, (int)this.a.R), global::DevComponents.WpfEditors.b.a((A_0 & 65280) >> 8, (int)this.a.G), global::DevComponents.WpfEditors.b.a(A_0 & 255, (int)this.a.B));
			}
			return default(global::System.Windows.Media.Color);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00009058 File Offset: 0x00007258
		public override global::System.Windows.Media.Color d(global::System.Windows.Media.Color A_0)
		{
			while (A_0.A != 0)
			{
				short num = (short)831352018;
				short num2 = num;
				num = (short)1486056658;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					break;
				default:
				{
					num = (short)35389440;
					short num3 = num;
					break;
				}
				}
				num = (short)897449985;
				if (num != 0)
				{
				}
				num = (short)337313792;
				if (num != 0)
				{
				}
				return global::System.Windows.Media.Color.FromArgb(A_0.A, global::DevComponents.WpfEditors.b.a((int)A_0.R, (int)this.a.R), global::DevComponents.WpfEditors.b.a((int)A_0.G, (int)this.a.G), global::DevComponents.WpfEditors.b.a((int)A_0.B, (int)this.a.B));
			}
			return A_0;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00009160 File Offset: 0x00007360
		internal static byte a(int A_0, int A_1)
		{
			short num = (short)689559967;
			short num2 = num;
			num = (short)459659679;
			switch (num2 == num)
			{
			}
			num = (short)1007943680;
			short num3 = num;
			num = (short)1774649345;
			if (num != 0)
			{
			}
			num = (short)1967194112;
			if (num != 0)
			{
			}
			int num4 = A_0 * A_1 / 255;
			return (byte)(num4 + A_0 * (255 - (255 - A_0) * (255 - A_1) / 255 - num4) / 255);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000923C File Offset: 0x0000743C
		internal static global::System.Windows.Media.Color a(global::System.Windows.Media.Color A_0, global::System.Windows.Media.Color A_1)
		{
			short num = (short)1015349249;
			if (num != 0)
			{
			}
			num = (short)319809474;
			short num2 = num;
			num = (short)88401858;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1335951360;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)550371328;
			if (num != 0)
			{
			}
			return global::System.Windows.Media.Color.FromArgb(A_0.A, global::DevComponents.WpfEditors.b.a((int)A_0.R, (int)A_1.R), global::DevComponents.WpfEditors.b.a((int)A_0.G, (int)A_1.G), global::DevComponents.WpfEditors.b.a((int)A_0.B, (int)A_1.B));
		}

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Media.Color a;
	}
}
