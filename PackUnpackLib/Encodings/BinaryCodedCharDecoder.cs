using System;
using System.Text;
using Motorola.Acp.PackUnpack.Ish.Collections;
using Motorola.Acp.PackUnpack.Ish.Layouts;

namespace Motorola.Acp.PackUnpack.Encodings
{
	// Token: 0x02000008 RID: 8
	public class BinaryCodedCharDecoder : global::System.Text.Decoder
	{
		// Token: 0x0600000B RID: 11 RVA: 0x00002594 File Offset: 0x00000794
		internal BinaryCodedCharDecoder(bool A_0)
		{
			this.b = A_0;
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000025B0 File Offset: 0x000007B0
		// (set) Token: 0x0600000D RID: 13 RVA: 0x0000265C File Offset: 0x0000085C
		internal global::Motorola.Acp.PackUnpack.Ish.Layouts.Nibble StartNibble
		{
			get
			{
				short num = (short)1715629406;
				short num2 = num;
				num = (short)760376670;
				switch (num2 == num)
				{
				}
				num = (short)448987137;
				if (num != 0)
				{
				}
				num = (short)1434058752;
				short num3 = num;
				num = (short)449249280;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1785537599;
				short num2 = num;
				num = (short)150479935;
				switch (num2 == num)
				{
				}
				num = (short)185532417;
				if (num != 0)
				{
				}
				num = (short)49217536;
				short num3 = num;
				num = (short)1076494336;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600000E RID: 14 RVA: 0x0000270C File Offset: 0x0000090C
		internal bool BchDecode
		{
			get
			{
				short num = (short)2082301208;
				short num2 = num;
				num = (short)1095197976;
				switch (num2 == num)
				{
				}
				num = (short)782958592;
				if (num != 0)
				{
				}
				num = (short)871890944;
				short num3 = num;
				num = (short)259260417;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000027B8 File Offset: 0x000009B8
		public override int GetCharCount(byte[] bytes, int index, int count)
		{
			int a_ = 2;
			short num = (short)844955648;
			switch (num)
			{
			default:
			{
				num = (short)559153161;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					int num3;
					int num4;
					int num5;
					switch (num2)
					{
					case 0:
						goto IL_AC;
					case 1:
						goto IL_3AA;
					case 2:
						goto IL_25D;
					case 3:
					{
						byte b = this.a(bytes[num3], global::Motorola.Acp.PackUnpack.Ish.Layouts.Nibble.Lower);
						num = (short)1293221895;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_32E;
					case 5:
						num = (short)1209532429;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						if (num4 > num5)
						{
							num = (short)860422159;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte b = this.a(bytes[num4], global::Motorola.Acp.PackUnpack.Ish.Layouts.Nibble.Upper);
						this.a(b);
						int num6;
						num6++;
						b = this.a(bytes[num4], global::Motorola.Acp.PackUnpack.Ish.Layouts.Nibble.Lower);
						this.a(b);
						num6++;
						num4++;
						num = (short)1360723978;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						byte b;
						if (b > 9)
						{
							num = (short)1016856580;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num6;
						num6++;
						num3++;
						num = (short)2074738700;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						num = (short)251461632;
						short num7 = num;
						if (count > bytes.Length - index)
						{
							num = (short)1961951233;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num6 = 0;
						num3 = index;
						num = (short)1379991568;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						switch (0)
						{
						case 0:
							goto IL_91;
						}
						continue;
					case 10:
						goto IL_25D;
					case 11:
						if (index >= 0)
						{
							num = (short)691929093;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2AE;
					case 12:
						goto IL_2C2;
					case 13:
					{
						if (index <= bytes.Length - 1)
						{
							num = (short)2883592;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)665901335;
						short num8 = num;
						num = (short)1540872471;
						switch ((num8 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_21D;
						default:
							num = (short)1408892928;
							if (num != 0)
							{
							}
							num = (short)207880206;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 14:
						goto IL_1C9;
					case 15:
					{
						int num6;
						return num6;
					}
					case 16:
						num = (short)1230176257;
						if (num != 0)
						{
						}
						if (this.a == global::Motorola.Acp.PackUnpack.Ish.Layouts.Nibble.Lower)
						{
							num = (short)1311899651;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2C2;
					}
					IL_91:
					if (bytes == null)
					{
						num = (short)1242365952;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_21D:
					num = (short)23003147;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_25D:
					num = (short)622788614;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2C2:
					num5 = index + count - 1;
					num4 = num3;
					num = (short)1918894082;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_AC:
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﮘ爵튠", a_));
				IL_1C9:
				IL_2AE:
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("列爵\ud9a0", a_));
				IL_32E:
				throw new global::System.Text.EncoderFallbackException();
				IL_3AA:
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("滛햠", a_));
			}
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002B78 File Offset: 0x00000D78
		public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
		{
			int a_ = 14;
			short num = (short)940376064;
			switch (num)
			{
			default:
			{
				num = (short)262151;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					int num4;
					switch (num2)
					{
					case 0:
						if (charIndex >= 0)
						{
							num = (short)1511784453;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3AC;
					case 1:
						goto IL_1D3;
					case 2:
						if (this.a == global::Motorola.Acp.PackUnpack.Ish.Layouts.Nibble.Lower)
						{
							num = (short)1384054798;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D3;
					case 3:
						goto IL_13D;
					case 4:
						goto IL_3F9;
					case 5:
						num = (short)1698299922;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						int num3;
						if (num3 > num4)
						{
							num = (short)2080899089;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte a_2 = this.a(bytes[num3], global::Motorola.Acp.PackUnpack.Ish.Layouts.Nibble.Upper);
						int num5;
						chars[num5] = this.b(a_2);
						int num6;
						num6++;
						num5++;
						a_2 = this.a(bytes[num3], global::Motorola.Acp.PackUnpack.Ish.Layouts.Nibble.Lower);
						chars[num5] = this.b(a_2);
						num6++;
						num5++;
						num3++;
						num = (short)1653211145;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						switch (0)
						{
						case 0:
							goto IL_9A;
						}
						continue;
					case 8:
						num = (short)435355663;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_2C0;
					case 10:
						if (chars == null)
						{
							num = (short)604372996;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1138491392;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_B5;
					case 12:
						goto IL_2C0;
					case 13:
						goto IL_210;
					case 14:
					{
						num = (short)170618966;
						short num7 = num;
						num = (short)2145022038;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_210;
						default:
						{
							num = (short)1771044864;
							if (num != 0)
							{
							}
							int num3;
							byte a_2 = this.a(bytes[num3], global::Motorola.Acp.PackUnpack.Ish.Layouts.Nibble.Lower);
							int num5;
							chars[num5] = this.b(a_2);
							int num6;
							num6++;
							num5++;
							num3++;
							num = (short)1029636097;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 15:
						if (byteIndex > bytes.Length - 1)
						{
							num = (short)1426259968;
							short num8 = num;
							num = (short)374865936;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)937426954;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						goto IL_1A7;
					case 17:
					{
						int num6;
						return num6;
					}
					case 18:
					{
						if (charIndex > chars.Length - 1)
						{
							num = (short)1889009667;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num6 = 0;
						int num3 = byteIndex;
						int num5 = charIndex;
						num = (short)1063583746;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_9A:
					if (bytes == null)
					{
						num = (short)937295883;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1027407885;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1D3:
					num4 = byteIndex + byteCount - 1;
					num = (short)549060620;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_210:
					if (byteIndex >= 0)
					{
						num = (short)793051144;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_339;
					IL_2C0:
					num = (short)1214709766;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_B5:
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("욤쾦좨\ud9aa\udeac", a_));
				IL_13D:
				goto IL_3AC;
				IL_1A7:
				num = (short)299565057;
				if (num != 0)
				{
				}
				IL_339:
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("욤쾦좨\ud9aa솮햰횲춴", a_));
				IL_3AC:
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("욤쾦좨\ud9aa솮햰횲춴", a_));
				IL_3F9:
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("욤쾦좨\ud9aa\udeac", a_));
			}
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002FAC File Offset: 0x000011AC
		private char b(byte A_0)
		{
			int a_ = 13;
			short num = (short)1909160296;
			short num2 = num;
			num = (short)302283112;
			switch (num2 == num)
			{
			}
			num = (short)198246401;
			if (num != 0)
			{
			}
			num = (short)996737024;
			short num3 = num;
			num = (short)44761088;
			if (num != 0)
			{
			}
			this.a(A_0);
			return global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("钣鞥骧馩颫鮭蚯薱貳辵醴ﾻ諾薿蓁", a_)[(int)A_0];
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00003078 File Offset: 0x00001278
		private byte a(byte A_0, global::Motorola.Acp.PackUnpack.Ish.Layouts.Nibble A_1)
		{
			short num = (short)475070464;
			short num2 = num;
			num = (short)951619156;
			short num3 = num;
			num = (short)2052886100;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1180631040;
				if (num != 0)
				{
				}
				if (A_1 == global::Motorola.Acp.PackUnpack.Ish.Layouts.Nibble.Upper)
				{
					return (byte)(A_0 >> 4 & 15);
				}
				break;
			}
			num = (short)2069102593;
			if (num != 0)
			{
			}
			return A_0 & 15;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00003138 File Offset: 0x00001338
		private void a(byte A_0)
		{
			short num = (short)1032650753;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)2063728643;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 2:
					goto IL_16D;
				case 3:
					num = (short)1786052609;
					if (num != 0)
					{
					}
					if (A_0 > 15)
					{
						num = (short)260177922;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
				{
					if (A_0 <= 9)
					{
						return;
					}
					num = (short)759670646;
					short num3 = num;
					num = (short)236234614;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)1926234112;
						if (num != 0)
						{
						}
						num = (short)1465384965;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
					goto IL_10A;
				}
				IL_3C:
				if (this.b)
				{
					num = (short)311558144;
					short num4 = num;
					num = (short)1949302784;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)356974596;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_10A:
			throw new global::System.Text.EncoderFallbackException();
			IL_16D:
			throw new global::System.Text.EncoderFallbackException();
		}

		// Token: 0x04000008 RID: 8
		private global::Motorola.Acp.PackUnpack.Ish.Layouts.Nibble a;

		// Token: 0x04000009 RID: 9
		private bool b;
	}
}
