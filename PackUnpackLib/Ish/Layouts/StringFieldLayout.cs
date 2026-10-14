using System;
using Motorola.Acp.PackUnpack.Ish.Collections;

namespace Motorola.Acp.PackUnpack.Ish.Layouts
{
	// Token: 0x0200006B RID: 107
	public class StringFieldLayout : global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout
	{
		// Token: 0x0600034E RID: 846 RVA: 0x000442C0 File Offset: 0x000424C0
		public StringFieldLayout(string name, global::Motorola.Acp.PackUnpack.Ish.Layouts.StringEncoding encoding, int offset, global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldJustification justification, int stringLength) : this(name, encoding, offset, justification, stringLength, '\0')
		{
		}

		// Token: 0x0600034F RID: 847 RVA: 0x000442DC File Offset: 0x000424DC
		public StringFieldLayout(string name, global::Motorola.Acp.PackUnpack.Ish.Layouts.StringEncoding encoding, int offset, global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldJustification justification, int stringLength, char terminator)
		{
			int a_ = 14;
			base..ctor(name, global::System.TypeCode.String, offset, justification);
			if (stringLength <= 0)
			{
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("횤펦\udba8슪쎬좮ﶰ횲\udbb4킶춸펺", a_));
			}
			switch (encoding)
			{
			case global::Motorola.Acp.PackUnpack.Ish.Layouts.StringEncoding.Unicode:
				this.b = stringLength * 2;
				break;
			case global::Motorola.Acp.PackUnpack.Ish.Layouts.StringEncoding.Ascii:
				this.b = stringLength;
				break;
			case global::Motorola.Acp.PackUnpack.Ish.Layouts.StringEncoding.Bcd:
			case global::Motorola.Acp.PackUnpack.Ish.Layouts.StringEncoding.Bch:
				this.b = (int)global::System.Math.Ceiling((double)(stringLength / 2));
				break;
			default:
				throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("삤즦쪨쒪즬욮\udfb0풲", a_));
			}
			this.a(justification, encoding);
			if (justification == global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldJustification.Left)
			{
				this.a(encoding, terminator);
			}
			this.a = encoding;
			this.c = stringLength;
			this.d = terminator;
		}

		// Token: 0x06000350 RID: 848 RVA: 0x000443A4 File Offset: 0x000425A4
		private void a(global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldJustification A_0, global::Motorola.Acp.PackUnpack.Ish.Layouts.StringEncoding A_1)
		{
			int a_ = 11;
			short num = (short)564708888;
			short num2 = num;
			num = (short)1651426840;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_FE:
				num = (short)238419968;
				short num3 = num;
				if (A_0 == global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldJustification.Left)
				{
					return;
				}
				num = (short)795410435;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			default:
				num = (short)703397888;
				if (num != 0)
				{
				}
				num = (short)1980432386;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num4)
				{
				case 0:
					goto IL_FE;
				case 1:
					if (A_1 == global::Motorola.Acp.PackUnpack.Ish.Layouts.StringEncoding.Unicode)
					{
						num = (short)1188364292;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_8F;
					}
					continue;
				case 3:
					goto IL_143;
				case 4:
					goto IL_C0;
				case 5:
					num = (short)1560805377;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_8F:
				if (A_1 != global::Motorola.Acp.PackUnpack.Ish.Layouts.StringEncoding.Ascii)
				{
					num = (short)627834885;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_C0:
				num = (short)1364525057;
				if (num != 0)
				{
				}
				num = (short)1015218176;
				num4 = (int)((global::System.IntPtr)num);
			}
			IL_143:
			throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("좡톣향\udca7쎩쪫잭펯펱삳\udfb5ힷ풹", a_));
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00044534 File Offset: 0x00042734
		private void a(global::Motorola.Acp.PackUnpack.Ish.Layouts.StringEncoding A_0, char A_1)
		{
			int a_ = 10;
			short num = (short)183959554;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)214695957;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)1428684805;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_87;
					}
					continue;
				case 3:
					goto IL_1CC;
				case 4:
					if (A_0 == global::Motorola.Acp.PackUnpack.Ish.Layouts.StringEncoding.Bcd)
					{
						num = (short)1654325248;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)712179725;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (A_1.CompareTo('0') < 0)
					{
						num = (short)1495859212;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1710030854;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (A_1.CompareTo('9') > 0)
					{
						num = (short)776994835;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 7:
					goto IL_207;
				case 8:
					if (A_1.CompareTo('F') > 0)
					{
						num = (short)665780234;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 9:
					if (A_1.CompareTo('\0') != 0)
					{
						num = (short)611057671;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 10:
					goto IL_1C7;
				case 11:
					if (A_1.CompareTo('9') > 0)
					{
						num = (short)1490026516;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 12:
					goto IL_126;
				case 13:
					if (A_0 == global::Motorola.Acp.PackUnpack.Ish.Layouts.StringEncoding.Bch)
					{
						num = (short)1448738817;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_249;
				case 14:
					num = (short)988348427;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
				{
					num = (short)2097765419;
					short num3 = num;
					num = (short)682974251;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_249;
					default:
						num = (short)1310851072;
						if (num != 0)
						{
						}
						num = (short)1619918856;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 16:
					if (A_0 == global::Motorola.Acp.PackUnpack.Ish.Layouts.StringEncoding.Unicode)
					{
						num = (short)1436811267;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2025652228;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					num = (short)791150608;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					num = (short)1468399617;
					if (num != 0)
					{
					}
					if (A_1.CompareTo('A') >= 0)
					{
						num = (short)1790771215;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2A9;
				case 19:
					num = (short)1872035858;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					goto IL_3DB;
				case 21:
					if (A_1.CompareTo('0') >= 0)
					{
						num = (short)2046165006;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_25D;
				}
				IL_87:
				if (A_0 != global::Motorola.Acp.PackUnpack.Ish.Layouts.StringEncoding.Ascii)
				{
					num = (short)2119172113;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_1CC:
				num = (short)1668349961;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_126:
			throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("햠욢힤쪦삨얪첬\udbae\udeb0솲", a_));
			IL_1C7:
			goto IL_2A9;
			IL_207:
			num = (short)1346830336;
			short num4 = num;
			throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("햠욢힤쪦삨얪첬\udbae\udeb0솲", a_));
			IL_249:
			throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쒠춢욤좦춨슪쎬좮", a_));
			IL_25D:
			throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("햠욢힤쪦삨얪첬\udbae\udeb0솲", a_));
			IL_2A9:
			throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("햠욢힤쪦삨얪첬\udbae\udeb0솲", a_));
			IL_3DB:
			goto IL_25D;
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000352 RID: 850 RVA: 0x0004495C File Offset: 0x00042B5C
		public override int Size
		{
			get
			{
				short num = (short)1823735809;
				if (num != 0)
				{
				}
				num = (short)1981549413;
				short num2 = num;
				num = (short)597756773;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1880489984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)50659328;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000353 RID: 851 RVA: 0x00044A0C File Offset: 0x00042C0C
		public global::Motorola.Acp.PackUnpack.Ish.Layouts.StringEncoding Encoding
		{
			get
			{
				short num = (short)1179790033;
				short num2 = num;
				num = (short)1515858641;
				switch (num2 == num)
				{
				}
				num = (short)1934163968;
				short num3 = num;
				num = (short)726204417;
				if (num != 0)
				{
				}
				num = (short)1890123776;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000354 RID: 852 RVA: 0x00044ABC File Offset: 0x00042CBC
		public char Terminator
		{
			get
			{
				short num = (short)1952411947;
				short num2 = num;
				num = (short)1156673835;
				switch (num2 == num)
				{
				}
				num = (short)659423232;
				short num3 = num;
				num = (short)992215041;
				if (num != 0)
				{
				}
				num = (short)122093568;
				if (num != 0)
				{
				}
				return this.d;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000355 RID: 853 RVA: 0x00044B6C File Offset: 0x00042D6C
		internal int StringLength
		{
			get
			{
				short num = (short)83418762;
				short num2 = num;
				num = (short)2105400970;
				switch (num2 == num)
				{
				}
				num = (short)1285357568;
				short num3 = num;
				num = (short)1860567041;
				if (num != 0)
				{
				}
				num = (short)1502937088;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x0400014A RID: 330
		private global::Motorola.Acp.PackUnpack.Ish.Layouts.StringEncoding a;

		// Token: 0x0400014B RID: 331
		private int b;

		// Token: 0x0400014C RID: 332
		private int c;

		// Token: 0x0400014D RID: 333
		private char d;
	}
}
