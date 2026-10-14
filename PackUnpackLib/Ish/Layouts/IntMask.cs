using System;
using Motorola.Acp.PackUnpack.Ish.Collections;

namespace Motorola.Acp.PackUnpack.Ish.Layouts
{
	// Token: 0x02000063 RID: 99
	public class IntMask : global::Motorola.Acp.PackUnpack.Ish.Layouts.INumericMask<int>
	{
		// Token: 0x0600033A RID: 826 RVA: 0x0004364C File Offset: 0x0004184C
		public IntMask(int bitOffset, int bitSize)
		{
			int a_ = 3;
			this.e = 31;
			this.f = 32;
			base..ctor();
			if (bitOffset >= 0)
			{
				if (bitOffset <= this.MaxBitOffset)
				{
					if (bitSize > 0)
					{
						if (bitSize <= this.MaxBitSize)
						{
							if (bitOffset - bitSize + 1 < 0)
							{
								throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쮡\udea3쎥", a_));
							}
							this.a = this.a(bitOffset, bitSize, out this.d);
							this.b = bitOffset;
							this.c = bitSize;
							return;
						}
					}
					throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쮡\udea3쎥", a_));
				}
			}
			throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쒡슣향춧\udea9", a_));
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00043704 File Offset: 0x00041904
		private int a(int A_0, int A_1, out int A_2)
		{
			short num = (short)194494859;
			short num2 = num;
			num = (short)1655751051;
			switch (num2 == num)
			{
			}
			num = (short)522715136;
			if (num != 0)
			{
			}
			num = (short)1187119105;
			if (num != 0)
			{
			}
			num = (short)1824522240;
			short num3 = num;
			A_2 = A_0 - A_1 + 1;
			return (1 << A_1) - 1 << A_2;
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x0600033C RID: 828 RVA: 0x000437C4 File Offset: 0x000419C4
		public int BitOffset
		{
			get
			{
				short num = (short)233817718;
				short num2 = num;
				num = (short)642238070;
				switch (num2 == num)
				{
				}
				num = (short)617938945;
				if (num != 0)
				{
				}
				num = (short)1700986880;
				if (num != 0)
				{
				}
				num = (short)522452992;
				short num3 = num;
				return this.b;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600033D RID: 829 RVA: 0x00043874 File Offset: 0x00041A74
		public int BitSize
		{
			get
			{
				short num = (short)885329746;
				short num2 = num;
				num = (short)1116737362;
				switch (num2 == num)
				{
				}
				num = (short)2022768641;
				if (num != 0)
				{
				}
				num = (short)366739456;
				if (num != 0)
				{
				}
				num = (short)217120768;
				short num3 = num;
				return this.c;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600033E RID: 830 RVA: 0x00043928 File Offset: 0x00041B28
		public int MaxBitOffset
		{
			get
			{
				short num = (short)158529388;
				short num2 = num;
				num = (short)1820391276;
				switch (num2 == num)
				{
				}
				num = (short)272171008;
				if (num != 0)
				{
				}
				num = (short)1948909569;
				if (num != 0)
				{
				}
				num = (short)1208090624;
				short num3 = num;
				return this.e;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600033F RID: 831 RVA: 0x000439D8 File Offset: 0x00041BD8
		public int MaxBitSize
		{
			get
			{
				short num = (short)286584532;
				short num2 = num;
				num = (short)628158164;
				switch (num2 == num)
				{
				}
				num = (short)101711872;
				if (num != 0)
				{
				}
				num = (short)150798337;
				if (num != 0)
				{
				}
				num = (short)1488388096;
				short num3 = num;
				return this.f;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000340 RID: 832 RVA: 0x00043A88 File Offset: 0x00041C88
		public int Shift
		{
			get
			{
				short num = (short)1332215809;
				if (num != 0)
				{
				}
				num = (short)786937619;
				short num2 = num;
				num = (short)218150675;
				switch (num2 == num)
				{
				}
				num = (short)786497536;
				if (num != 0)
				{
				}
				num = (short)2116943872;
				short num3 = num;
				return this.d;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000341 RID: 833 RVA: 0x00043B34 File Offset: 0x00041D34
		public int Mask
		{
			get
			{
				short num = (short)1558076191;
				short num2 = num;
				num = (short)1885231903;
				switch (num2 == num)
				{
				}
				num = (short)258080768;
				if (num != 0)
				{
				}
				num = (short)1733820417;
				if (num != 0)
				{
				}
				num = (short)1952645120;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00043BE4 File Offset: 0x00041DE4
		public int Apply(int value, global::Motorola.Acp.PackUnpack.Ish.Layouts.MaskApplication application)
		{
			short num = (short)2006843392;
			short num2 = num;
			if (application == global::Motorola.Acp.PackUnpack.Ish.Layouts.MaskApplication.Unpack)
			{
				num = (short)877527041;
				if (num != 0)
				{
				}
				num = (short)1179385466;
				short num3 = num;
				num = (short)1143996026;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)2063663104;
					if (num != 0)
					{
					}
					return (int)((uint)(value & this.a) >> this.d);
				}
			}
			return value << this.d & this.a;
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00043CBC File Offset: 0x00041EBC
		public uint Apply(uint value, global::Motorola.Acp.PackUnpack.Ish.Layouts.MaskApplication application)
		{
			short num = (short)541589504;
			short num2 = num;
			if (application == global::Motorola.Acp.PackUnpack.Ish.Layouts.MaskApplication.Unpack)
			{
				num = (short)2041839617;
				if (num != 0)
				{
				}
				num = (short)1841366646;
				short num3 = num;
				num = (short)1389037174;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)485294080;
					if (num != 0)
					{
					}
					return (uint)((ulong)value & (ulong)((long)this.a)) >> this.d;
				}
			}
			return (uint)((ulong)((ulong)value << this.d) & (ulong)((long)this.a));
		}

		// Token: 0x04000132 RID: 306
		private int a;

		// Token: 0x04000133 RID: 307
		private int b;

		// Token: 0x04000134 RID: 308
		private int c;

		// Token: 0x04000135 RID: 309
		private int d;

		// Token: 0x04000136 RID: 310
		private int e;

		// Token: 0x04000137 RID: 311
		private int f;
	}
}
