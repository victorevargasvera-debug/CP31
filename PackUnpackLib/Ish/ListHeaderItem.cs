using System;
using System.IO;
using Motorola.Acp.PackUnpack.Ish.Collections;
using Motorola.Acp.PackUnpack.Ish.Layouts;

namespace Motorola.Acp.PackUnpack.Ish
{
	// Token: 0x02000024 RID: 36
	public class ListHeaderItem : global::Motorola.Acp.PackUnpack.Ish.IshItem, global::Motorola.Acp.PackUnpack.Ish.IListNode
	{
		// Token: 0x0600014D RID: 333 RVA: 0x00020D44 File Offset: 0x0001EF44
		internal ListHeaderItem(global::Motorola.Acp.PackUnpack.Ish.ListHeaderType A_0, int A_1, int A_2, int A_3, int A_4, int A_5, global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream A_6, int A_7, global::Motorola.Acp.PackUnpack.Ish.IshItemName A_8, global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout A_9) : this(A_0, A_1, A_2, A_3, A_4, null, A_5, A_6, A_7, A_8, A_9)
		{
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00020D6C File Offset: 0x0001EF6C
		internal ListHeaderItem(global::Motorola.Acp.PackUnpack.Ish.ListHeaderType A_0, int A_1, int A_2, int A_3, int A_4, global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream A_5, int A_6, global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream A_7, int A_8, global::Motorola.Acp.PackUnpack.Ish.IshItemName A_9, global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout A_10)
		{
			int a_ = 5;
			base..ctor(A_0, A_1, A_10);
			if (A_2 <= 0)
			{
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("펟횡장\ud8a7쮩쾫잭쒯쮱", a_));
			}
			if (A_3 < 0)
			{
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﮝ솟욡솣풥쮩\udcab쾭펯\udbb1삳쾵", a_));
			}
			if (A_4 < 0)
			{
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("펟횡좣쎥\udca7춫\udead톯톱\uddb3습솷", a_));
			}
			if (A_8 <= 0)
			{
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("펟횡좥\udca7\ud8a9햫ﶭ\ud9af좱톳", a_));
			}
			if (A_6 < 0)
			{
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﮝ솟욡솣풥얩\ud9ab삭쒯", a_));
			}
			if (A_6 > 0)
			{
				if (A_7 == null)
				{
					throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("펟횡좥\udca7\ud8a9얫쮭쎯삳쒵\uddb7\udbb9톻", a_));
				}
				if ((long)(A_6 * A_8) != A_7.Length)
				{
					throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﮝ솟욡솣풥얩\ud9ab삭쒯", a_));
				}
				int num;
				global::System.Math.DivRem((int)A_7.Length, A_8, out num);
				if (num != 0)
				{
					throw new global::System.IO.InvalidDataException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﮝ솟욡솣풥얩\ud9ab삭쒯", a_));
				}
				this.g = new global::Motorola.Acp.PackUnpack.Ish.DataArea(A_7);
			}
			else
			{
				if (A_7 != null)
				{
					throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("펟횡좥\udca7\ud8a9얫쮭쎯삳쒵\uddb7\udbb9톻", a_));
				}
				this.g = null;
			}
			if (A_5 != null)
			{
				this.e = new global::Motorola.Acp.PackUnpack.Ish.DataArea(A_5);
			}
			else
			{
				this.e = null;
			}
			this.a = A_2;
			this.b = A_3;
			this.c = A_4;
			this.f = A_6;
			this.d = A_8;
			this.h = A_9;
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600014F RID: 335 RVA: 0x00020F30 File Offset: 0x0001F130
		internal new global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout Layout
		{
			get
			{
				short num = (short)2136735744;
				short num2 = num;
				num = (short)2144135027;
				short num3 = num;
				num = (short)2108483443;
				switch (num3 == num)
				{
				}
				num = (short)233701377;
				if (num != 0)
				{
				}
				num = (short)1415249920;
				if (num != 0)
				{
				}
				return base.Layout as global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000150 RID: 336 RVA: 0x00020FE4 File Offset: 0x0001F1E4
		internal new global::Motorola.Acp.PackUnpack.Ish.ListHeaderType Type
		{
			get
			{
				short num = (short)1744175104;
				short num2 = num;
				num = (short)695085935;
				short num3 = num;
				num = (short)85470063;
				switch (num3 == num)
				{
				}
				num = (short)1754267649;
				if (num != 0)
				{
				}
				num = (short)1454112768;
				if (num != 0)
				{
				}
				return base.Type as global::Motorola.Acp.PackUnpack.Ish.ListHeaderType;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000151 RID: 337 RVA: 0x00021098 File Offset: 0x0001F298
		internal int ListCapacity
		{
			get
			{
				short num = (short)596770816;
				short num2 = num;
				num = (short)573707589;
				short num3 = num;
				num = (short)1527518533;
				switch (num3 == num)
				{
				}
				num = (short)131137537;
				if (num != 0)
				{
				}
				num = (short)77070336;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000152 RID: 338 RVA: 0x00021148 File Offset: 0x0001F348
		internal int ListletCapacity
		{
			get
			{
				short num = (short)344719360;
				short num2 = num;
				num = (short)1132696915;
				short num3 = num;
				num = (short)330077523;
				switch (num3 == num)
				{
				}
				num = (short)480182272;
				if (num != 0)
				{
				}
				num = (short)1307508737;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000153 RID: 339 RVA: 0x000211F8 File Offset: 0x0001F3F8
		internal int HeaderCapacity
		{
			get
			{
				short num = (short)98500608;
				short num2 = num;
				num = (short)335893369;
				short num3 = num;
				num = (short)1070486393;
				switch (num3 == num)
				{
				}
				num = (short)1226899456;
				if (num != 0)
				{
				}
				num = (short)2050293761;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000154 RID: 340 RVA: 0x000212A8 File Offset: 0x0001F4A8
		public int Count
		{
			get
			{
				short num = (short)389480448;
				short num2 = num;
				num = (short)907949557;
				short num3 = num;
				num = (short)1141847541;
				switch (num3 == num)
				{
				}
				num = (short)397213697;
				if (num != 0)
				{
				}
				num = (short)1896349696;
				if (num != 0)
				{
				}
				return this.f;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000155 RID: 341 RVA: 0x00021358 File Offset: 0x0001F558
		internal int HeaderDataAreaSize
		{
			get
			{
				short num = (short)1179844608;
				short num2 = num;
				num = (short)1597437019;
				short num3 = num;
				num = (short)1165554779;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1521025024;
					if (num != 0)
					{
					}
					num = (short)616431617;
					if (num != 0)
					{
					}
					if (this.e == null)
					{
						return 0;
					}
					break;
				}
				return (int)this.e.PackedData.Length;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000156 RID: 342 RVA: 0x00021420 File Offset: 0x0001F620
		internal int ListEntrySize
		{
			get
			{
				short num = (short)474939392;
				short num2 = num;
				num = (short)139758396;
				short num3 = num;
				num = (short)1922272060;
				switch (num3 == num)
				{
				}
				num = (short)878837761;
				if (num != 0)
				{
				}
				num = (short)1328939008;
				if (num != 0)
				{
				}
				return this.d;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000157 RID: 343 RVA: 0x000214D0 File Offset: 0x0001F6D0
		internal global::Motorola.Acp.PackUnpack.Ish.DataArea HeaderDataArea
		{
			get
			{
				short num = (short)1837432832;
				short num2 = num;
				num = (short)900574061;
				short num3 = num;
				num = (short)668183405;
				switch (num3 == num)
				{
				}
				num = (short)1681653761;
				if (num != 0)
				{
				}
				num = (short)532152320;
				if (num != 0)
				{
				}
				return this.e;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000158 RID: 344 RVA: 0x00021580 File Offset: 0x0001F780
		internal global::Motorola.Acp.PackUnpack.Ish.DataArea HeaderListEntries
		{
			get
			{
				short num = (short)1348861952;
				short num2 = num;
				num = (short)363986945;
				if (num != 0)
				{
				}
				num = (short)841744380;
				short num3 = num;
				num = (short)1968570364;
				switch (num3 == num)
				{
				}
				num = (short)2076639232;
				if (num != 0)
				{
				}
				return this.g;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000159 RID: 345 RVA: 0x00021630 File Offset: 0x0001F830
		// (set) Token: 0x0600015A RID: 346 RVA: 0x000216E0 File Offset: 0x0001F8E0
		public global::Motorola.Acp.PackUnpack.Ish.IshItemName Next
		{
			get
			{
				short num = (short)812711936;
				short num2 = num;
				num = (short)1933428627;
				short num3 = num;
				num = (short)1705691027;
				switch (num3 == num)
				{
				}
				num = (short)1415249921;
				if (num != 0)
				{
				}
				num = (short)411107328;
				if (num != 0)
				{
				}
				return this.h;
			}
			set
			{
				short num = (short)1196163072;
				short num2 = num;
				num = (short)1770848351;
				short num3 = num;
				num = (short)957153375;
				switch (num3 == num)
				{
				}
				num = (short)61931521;
				if (num != 0)
				{
				}
				num = (short)1850998784;
				if (num != 0)
				{
				}
				this.h = value;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600015B RID: 347 RVA: 0x00021794 File Offset: 0x0001F994
		public override int Length
		{
			get
			{
				switch (0)
				{
				case 0:
					goto IL_28;
				}
				int num;
				long num2;
				short num3;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						num2 += this.e.PackedData.Length;
						num3 = (short)474611714;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 1:
						if (this.e != null)
						{
							num3 = (short)367329280;
							short num4 = num3;
							num3 = (short)1511915520;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_ED;
					case 2:
						goto IL_ED;
					case 3:
						num3 = (short)1962868737;
						if (num3 != 0)
						{
						}
						num2 += this.g.PackedData.Length;
						num3 = (short)94175236;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 4:
						goto IL_E8;
					case 5:
						if (this.g != null)
						{
							num3 = (short)1949892611;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_1A2;
					}
					goto IL_28;
					IL_ED:
					num3 = (short)1408664019;
					short num5 = num3;
					num3 = (short)912490963;
					switch ((num5 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num3 = (short)709558272;
						if (num3 != 0)
						{
						}
						num3 = (short)856686597;
						num = (int)((global::System.IntPtr)num3);
						break;
					}
				}
				IL_E8:
				IL_1A2:
				return (int)num2;
				IL_28:
				num2 = 18L;
				num3 = (short)902496257;
				num = (int)((global::System.IntPtr)num3);
				goto IL_0A;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600015C RID: 348 RVA: 0x00021948 File Offset: 0x0001FB48
		public global::Motorola.Acp.PackUnpack.Ish.DataArea Entries
		{
			get
			{
				short num = (short)1645477888;
				short num2 = num;
				num = (short)1282845452;
				short num3 = num;
				num = (short)171485964;
				switch (num3 == num)
				{
				}
				num = (short)1212612609;
				if (num != 0)
				{
				}
				num = (short)627572736;
				if (num != 0)
				{
				}
				return this.HeaderListEntries;
			}
		}

		// Token: 0x04000068 RID: 104
		private int a;

		// Token: 0x04000069 RID: 105
		private int b;

		// Token: 0x0400006A RID: 106
		private int c;

		// Token: 0x0400006B RID: 107
		private int d;

		// Token: 0x0400006C RID: 108
		private global::Motorola.Acp.PackUnpack.Ish.DataArea e;

		// Token: 0x0400006D RID: 109
		private int f;

		// Token: 0x0400006E RID: 110
		private global::Motorola.Acp.PackUnpack.Ish.DataArea g;

		// Token: 0x0400006F RID: 111
		private global::Motorola.Acp.PackUnpack.Ish.IshItemName h;

		// Token: 0x04000070 RID: 112
		private const int i = 18;
	}
}
